# -*- coding: utf-8 -*-
"""Small text-patching engine for Visual Studio 2010 *.Designer.vb files.

It lets a redesign script move / resize / re-colour / re-parent controls and add new
decorative controls WITHOUT touching control names or types, so the code-behind of every
activity keeps working.  Everything is plain text edits on the designer file.
"""
import re


def rgb(r, g=None, b=None):
    if g is None:
        r, g, b = r
    return "System.Drawing.Color.FromArgb(%d, %d, %d)" % (r, g, b)


def font(family, size, bold=False):
    s = ("%s" % size)
    if "." not in s:
        s += ".0"
    return 'New System.Drawing.Font("%s", %s!%s)' % (
        family, s, ", System.Drawing.FontStyle.Bold" if bold else "")


def _enum(kind, value):
    # ContentAlignment lives in System.Drawing, everything else used here in System.Windows.Forms
    ns = "System.Drawing." if kind == "ContentAlignment" else "System.Windows.Forms."
    return "%s%s.%s" % (ns, kind, value)


ANCH = {"T": "Top", "B": "Bottom", "L": "Left", "R": "Right"}


class Designer(object):
    def __init__(self, path):
        self.path = path
        raw = open(path, "rb").read()
        self.bom = raw.startswith(b"\xef\xbb\xbf")
        txt = raw.decode("utf-8-sig")
        self.crlf = "\r\n" in txt
        self.t = txt.replace("\r\n", "\n")

    def save(self):
        t = self.t.replace("\n", "\r\n") if self.crlf else self.t
        data = t.encode("utf-8")
        if self.bom:
            data = b"\xef\xbb\xbf" + data
        open(self.path, "wb").write(data)

    # ------------------------------------------------------------------ structure
    HDR = re.compile(r"^        '\n        '([\w.]+)\n        '\n", re.M)

    def headers(self):
        return [(m.group(1), m.start(), m.end()) for m in self.HDR.finditer(self.t)]

    def form_name(self):
        if getattr(self, "_fn", None):
            return self._fn
        self._fn = self._form_name()
        return self._fn

    def _form_name(self):
        for name, s, e in self.headers():
            if "Me.ClientSize" in self.t[e:e + 4000].split("\n        '\n")[0] or \
               "Me.AutoScaleMode" in self.t[e:e + 600].split("\n        '\n")[0]:
                return name
        raise KeyError("form block")

    def span(self, name):
        hs = self.headers()
        for i, (n, s, e) in enumerate(hs):
            if n == name:
                end = None
                for n2, s2, e2 in hs[i + 1:]:
                    if not n2.startswith(name + "."):
                        end = s2
                        break
                if end is None:
                    m = re.search(r"^        Me\.\w+(?:\.\w+)*\.(?:Resume|Suspend)Layout|^        Me\.ResumeLayout|^        CType\(.*EndInit",
                                  self.t[e:], re.M)
                    end = e + (m.start() if m else len(self.t) - e)
                else:
                    # the form block is last: cut before the Resume/EndInit tail
                    if name == self.form_name():
                        m = re.search(r"^        (?:Me\.\w+(?:\.\w+)*\.ResumeLayout|Me\.ResumeLayout|CType\(.*EndInit)",
                                      self.t[e:], re.M)
                        end = e + m.start()
                return e, end
        raise KeyError(name)

    def has(self, name):
        return any(n == name for n, _, _ in self.headers())

    def kinds(self):
        return dict(re.findall(r"Friend WithEvents (\w+) As System\.Windows\.Forms\.(\w+)", self.t))

    # ------------------------------------------------------------------ properties
    def _pre(self, owner):
        """regex prefix of a property line: the form itself is plain `Me.`"""
        if owner == self.form_name():
            return r"Me\."
        return r"Me\.%s\." % re.escape(owner)

    def _line_rx(self, owner, prop):
        return re.compile(r"^[ \t]*%s%s = .*\n" % (self._pre(owner), re.escape(prop)), re.M)

    def get(self, name, prop):
        s, e = self.span(name)
        m = re.search(r"^[ \t]*%s%s = (.*)$" % (self._pre(name), re.escape(prop)), self.t[s:e], re.M)
        return m.group(1).strip() if m else None

    def set(self, name, prop, raw):
        s, e = self.span(name)
        seg = self.t[s:e]
        rx = self._line_rx(name, prop)
        line = "        Me.%s%s = %s\n" % ("" if name == self.form_name() else name + ".", prop, raw)
        if rx.search(seg):
            seg = rx.sub(lambda m: line, seg, count=1)
        else:
            # keep alphabetical-ish: insert before the Name line if there is one
            m = re.search(r"^[ \t]*%sName = " % self._pre(name), seg, re.M)
            seg = seg[:m.start()] + line + seg[m.start():] if m else seg + line
        self.t = self.t[:s] + seg + self.t[e:]

    def drop(self, name, prop):
        s, e = self.span(name)
        seg = self._line_rx(name, prop).sub("", self.t[s:e])
        self.t = self.t[:s] + seg + self.t[e:]

    def place(self, name, x, y, w=None, h=None):
        self.set(name, "Location", "New System.Drawing.Point(%d, %d)" % (x, y))
        if w is not None:
            self.set(name, "Size", "New System.Drawing.Size(%d, %d)" % (w, h))
        self.drop(name, "Dock")
        # AutoSize labels keep their own size
        if w is not None and self.get(name, "AutoSize") == "True":
            self.set(name, "AutoSize", "False")

    def dock(self, name, how, w=None, h=None):
        """how: Top | Bottom | Left | Right | Fill | None"""
        if how is None:
            self.drop(name, "Dock")
            return
        self.drop(name, "Anchor")
        self.set(name, "Dock", _enum("DockStyle", how))
        if w is not None:
            self.set(name, "Size", "New System.Drawing.Size(%d, %d)" % (w, h))
        if self.get(name, "AutoSize") == "True":
            self.set(name, "AutoSize", "False")

    def anchor(self, name, letters):
        parts = " Or ".join(_enum("AnchorStyles", ANCH[c]) for c in letters)
        self.set(name, "Anchor", "CType((%s), System.Windows.Forms.AnchorStyles)" % parts)

    def text(self, name, value):
        self.set(name, "Text", '"%s"' % value.replace('"', '""'))

    def back(self, name, color):
        self.set(name, "BackColor", rgb(color))

    def fore(self, name, color):
        self.set(name, "ForeColor", rgb(color))

    def font(self, name, family, size, bold=False):
        self.set(name, "Font", font(family, size, bold))

    def align(self, name, how):
        self.set(name, "TextAlign", _enum("ContentAlignment", how))

    def autosize(self, name, v):
        self.set(name, "AutoSize", "True" if v else "False")

    def visible(self, name, v):
        self.set(name, "Visible", "True" if v else "False")

    def flat(self, name, back, fore, border, size=1):
        self.set(name, "BackColor", rgb(back))
        self.set(name, "ForeColor", rgb(fore))
        self.set(name, "FlatAppearance.BorderColor", rgb(border))
        self.set(name, "FlatAppearance.BorderSize", str(size))
        self.set(name, "FlatStyle", _enum("FlatStyle", "Flat"))
        self.set(name, "UseVisualStyleBackColor", "False")

    # ------------------------------------------------------------------ hierarchy
    def _container(self, parent, sub):
        """text between `Me.` and `.Controls.Add`: '' for the form itself"""
        base = "" if parent == self.form_name() else parent
        if sub:
            return "%s.%s" % (base, sub) if base else sub
        return base

    def _cadd(self, owner):
        return (r"Me\.%s\." % re.escape(owner) if owner else r"Me\.") + r"Controls\.Add"

    def container_name(self, parent):
        return self.form_name() if parent in (None, "FORM") else parent

    def children(self, parent, sub=None):
        pn = self.container_name(parent)
        s, e = self.span(pn)
        owner = self._container(pn, sub)
        return re.findall(r"^[ \t]*%s\(Me\.(\w+)\)" % self._cadd(owner), self.t[s:e], re.M)

    def order(self, parent, names, sub=None):
        """Rewrite the Controls.Add lines of a container in the given order (first = back)."""
        pn = self.container_name(parent)
        s, e = self.span(pn)
        owner = self._container(pn, sub)
        seg = self.t[s:e]
        rx = re.compile(r"^[ \t]*%s\(Me\.\w+\)\n" % self._cadd(owner), re.M)
        ms = list(rx.finditer(seg))
        new = "".join("        Me.%sControls.Add(Me.%s)\n" % (owner + "." if owner else "", n) for n in names)
        if ms:
            first = ms[0].start()
            seg = rx.sub("", seg)
            seg = seg[:first] + new + seg[first:]
        else:
            # before the first property line of the block (after any comment header)
            seg = new + seg
        self.t = self.t[:s] + seg + self.t[e:]

    def reparent(self, child, parent, sub=None, keep_order=True):
        # remove from every container
        self.t = re.sub(r"^[ \t]*Me\.(?:[\w.]+\.)?Controls\.Add\(Me\.%s\)\n" % re.escape(child), "", self.t, flags=re.M)
        cur = self.children(parent, sub)
        self.order(parent, cur + [child], sub)

    def fill_first(self, parent, sub=None):
        """z-order helper: Fill docks must come first (lowest) in the collection."""
        names = self.children(parent, sub)
        fills = [n for n in names if self.get(n, "Dock") == _enum("DockStyle", "Fill")]
        self.order(parent, fills + [n for n in names if n not in fills], sub)

    # ------------------------------------------------------------------ new controls
    def new(self, kind, name, parent, x, y, w, h, sub=None, **props):
        assert not self.has(name), name
        # declaration
        decl = "    Friend WithEvents %s As System.Windows.Forms.%s\n" % (name, kind)
        ms = list(re.finditer(r"^    Friend WithEvents .*\n", self.t, re.M))
        p = ms[-1].end()
        self.t = self.t[:p] + decl + self.t[p:]
        # creation
        crs = list(re.finditer(r"^        Me\.\w+ = New System\.Windows\.Forms\.\w+\(\)\n", self.t, re.M))
        p = crs[-1].end()
        self.t = self.t[:p] + "        Me.%s = New System.Windows.Forms.%s()\n" % (name, kind) + self.t[p:]
        if kind in ("Panel", "GroupBox"):
            m = re.search(r"^        Me\.SuspendLayout\(\)\n", self.t, re.M)
            self.t = self.t[:m.start()] + "        Me.%s.SuspendLayout()\n" % name + self.t[m.start():]
            m = re.search(r"^        Me\.ResumeLayout\(False\)\n", self.t, re.M)
            self.t = self.t[:m.start()] + "        Me.%s.ResumeLayout(False)\n" % name + self.t[m.start():]
        # block (before the form block)
        fn = self.form_name()
        hs = {n: (s, e) for n, s, e in self.headers()}
        pos = hs[fn][0]
        lines = ["        '\n        '%s\n        '\n" % name]
        pr = {"Location": "New System.Drawing.Point(%d, %d)" % (x, y),
              "Size": "New System.Drawing.Size(%d, %d)" % (w, h),
              "Name": '"%s"' % name, "TabIndex": "0"}
        pr.update(props)
        for k, v in pr.items():
            lines.append("        Me.%s.%s = %s\n" % (name, k, v))
        self.t = self.t[:pos] + "".join(lines) + self.t[pos:]
        self.reparent(name, parent, sub)
        return name

    def panel(self, name, parent, x, y, w, h, back, sub=None, border=False, **props):
        pr = {"BackColor": rgb(back)}
        if border:
            pr["BorderStyle"] = _enum("BorderStyle", "FixedSingle")
        pr.update(props)
        return self.new("Panel", name, parent, x, y, w, h, sub=sub, **pr)

    def label(self, name, parent, x, y, w, h, text, color, fnt, align="TopLeft", sub=None, **props):
        pr = {"AutoSize": "False", "ForeColor": rgb(color), "Font": fnt,
              "Text": '"%s"' % text.replace('"', '""'),
              "TextAlign": _enum("ContentAlignment", align)}
        pr.update(props)
        return self.new("Label", name, parent, x, y, w, h, sub=sub, **pr)
