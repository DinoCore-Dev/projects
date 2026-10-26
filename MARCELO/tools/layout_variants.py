# -*- coding: utf-8 -*-
"""Layout variants for the form activities (Acts 4-13).

Every identity gets its own LAYOUT CODE (0..7).  Each form has three independent layout
operations (op0, op1, op2); bit n of the code switches operation n on.  Because the eight
codes are all different, the eight identities end up with eight different layouts on every
form that has three effective operations (and every identity differs from the others on
the form activities as a whole).

The operations only rewrite Location / Size / Dock lines (and the order of menu / status
items) inside the *.Designer.vb files.  Controls keep their names, so the code-behind of
each activity is untouched.  Run once per identity folder:

    python3 tools/layout_variants.py <LAYOUT_CODE 0-7>

A marker file (tools/layout_code.txt) stops the operations from being applied twice.
"""
import os
import re
import sys

HERE = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.dirname(HERE)
COMP = os.path.join(ROOT, "COMPILATION")
MARKER = os.path.join(HERE, "layout_code.txt")


class Designer(object):
    def __init__(self, path):
        self.path = path
        self.text = open(path, "rb").read().decode("utf-8")

    def save(self):
        open(self.path, "wb").write(self.text.encode("utf-8"))

    # ---- geometry -------------------------------------------------------------------
    def _bounds(self, name):
        rx = re.compile(r"(Me\.%s\.SetBounds\()\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)(\s*\))"
                        % re.escape(name))
        return rx, rx.search(self.text)

    def _find(self, name, prop, kind):
        rx = re.compile(r"(Me\.%s\.%s\s*=\s*New System\.Drawing\.%s\()(-?\d+),\s*(-?\d+)(\))"
                        % (re.escape(name), prop, kind))
        m = rx.search(self.text)
        if not m:
            raise KeyError("%s.%s not found in %s" % (name, prop, self.path))
        return rx, m

    def loc(self, name):
        _, b = self._bounds(name)
        if b:
            return int(b.group(2)), int(b.group(3))
        _, m = self._find(name, "Location", "Point")
        return int(m.group(2)), int(m.group(3))

    def size(self, name):
        _, b = self._bounds(name)
        if b:
            return int(b.group(4)), int(b.group(5))
        _, m = self._find(name, "Size", "Size")
        return int(m.group(2)), int(m.group(3))

    def set_loc(self, name, x, y):
        _, b = self._bounds(name)
        if b:
            self.text = (self.text[:b.start()] + "%s%d,%d,%s,%s%s" % (b.group(1), x, y, b.group(4), b.group(5), b.group(6))
                         + self.text[b.end():])
            return
        rx, m = self._find(name, "Location", "Point")
        self.text = self.text[:m.start()] + "%s%d, %d%s" % (m.group(1), x, y, m.group(4)) + self.text[m.end():]

    def rect(self, name):
        x, y = self.loc(name)
        w, h = self.size(name)
        return x, y, w, h

    def span(self, names):
        rs = [self.rect(n) for n in names]
        return (min(r[0] for r in rs), min(r[1] for r in rs),
                max(r[0] + r[2] for r in rs), max(r[1] + r[3] for r in rs))

    def shift(self, names, dx=0, dy=0):
        for n in names:
            x, y = self.loc(n)
            self.set_loc(n, x + dx, y + dy)

    def set_dock(self, name, old, new):
        a = "Me.%s.Dock = System.Windows.Forms.DockStyle.%s" % (name, old)
        b = "Me.%s.Dock = System.Windows.Forms.DockStyle.%s" % (name, new)
        if a not in self.text:
            raise KeyError(a)
        self.text = self.text.replace(a, b)

    # ---- operations -----------------------------------------------------------------
    def flip_align(self, names):
        """Mirror a label's text alignment (Left <-> Right) after it changed side."""
        for n in names:
            rx = re.compile(r"(Me\.%s\.TextAlign\s*=\s*(?:System\.Drawing\.)?ContentAlignment\.)(\w+)" % re.escape(n))
            m = rx.search(self.text)
            if not m:
                continue
            v = m.group(2)
            if v.endswith("Right"):
                v = v[:-5] + "Left"
            elif v.endswith("Left"):
                v = v[:-4] + "Right"
            else:
                continue
            self.text = self.text[:m.start()] + m.group(1) + v + self.text[m.end():]

    def swap_x(self, A, B, flip=True, rpad=0):
        """Exchange the horizontal positions of two groups that sit side by side."""
        if flip:
            self.flip_align(A + B)
        a, b = self.span(A), self.span(B)
        left, right = (A, B) if a[0] <= b[0] else (B, A)
        sl, sr = self.span(left), self.span(right)
        gap = sr[0] - sl[2]
        self.shift(right, dx=sl[0] - sr[0])
        self.shift(left, dx=(sl[0] + (sr[2] - sr[0]) + gap) - sl[0])
        if rpad:   # keep a little room at the right edge for the group that moved there
            self.shift(left, dx=-rpad)

    def swap_y(self, A, B):
        """Exchange the vertical positions of two stacked groups."""
        a, b = self.span(A), self.span(B)
        top, bottom = (A, B) if a[1] <= b[1] else (B, A)
        st, sb = self.span(top), self.span(bottom)
        gap = sb[1] - st[3]
        self.shift(bottom, dy=st[1] - sb[1])
        self.shift(top, dy=(st[1] + (sb[3] - sb[1]) + gap) - st[1])

    def reverse_row(self, names):
        rs = sorted(names, key=lambda n: self.loc(n)[0])
        rects = [self.rect(n) for n in rs]
        gaps = [rects[i + 1][0] - (rects[i][0] + rects[i][2]) for i in range(len(rs) - 1)]
        x = rects[0][0]
        for i, n in enumerate(reversed(rs)):
            _, y = self.loc(n)
            self.set_loc(n, x, y)
            w = self.size(n)[0]
            x += w + (list(reversed(gaps))[i] if i < len(gaps) else 0)

    def reverse_col(self, names):
        rs = sorted(names, key=lambda n: self.loc(n)[1])
        rects = [self.rect(n) for n in rs]
        gaps = [rects[i + 1][1] - (rects[i][1] + rects[i][3]) for i in range(len(rs) - 1)]
        y = rects[0][1]
        for i, n in enumerate(reversed(rs)):
            x, _ = self.loc(n)
            self.set_loc(n, x, y)
            h = self.size(n)[1]
            y += h + (list(reversed(gaps))[i] if i < len(gaps) else 0)

    def right_align(self, names, width, margin):
        s = self.span(names)
        self.shift(names, dx=(width - margin) - s[2])

    def permute_items(self, owner, func):
        rx = re.compile(r"(Me\.%s\.Items\.AddRange\(New System\.Windows\.Forms\.ToolStripItem\(\) \{)([^}]*)(\}\))"
                        % re.escape(owner))
        m = rx.search(self.text)
        if not m:
            raise KeyError(owner)
        items = [i.strip() for i in m.group(2).split(",")]
        items = func(items)
        self.text = self.text[:m.start()] + m.group(1) + ", ".join(items) + m.group(3) + self.text[m.end():]

    def permute_controls(self, owner, func):
        """Re-order the consecutive 'Me.<owner>.Controls.Add(Me.x)' lines (tab order)."""
        rx = re.compile(r"((?:[ \t]*Me\.%s\.Controls\.Add\(Me\.\w+\)\r?\n)+)" % re.escape(owner))
        m = rx.search(self.text)
        if not m:
            raise KeyError(owner)
        lines = m.group(1).splitlines(True)
        lines = func(lines)
        self.text = self.text[:m.start()] + "".join(lines) + self.text[m.end():]


# ---- small permutations -----------------------------------------------------------------
def rev(items):
    return list(reversed(items))


def last_first(items):
    return [items[-1]] + items[:-1]


def swap_ends(items):
    items = list(items)
    items[0], items[-1] = items[-1], items[0]
    return items


# ---- per-form operation tables ------------------------------------------------------------
CRUD_BUTTONS = ["addButton", "updateButton", "deleteButton", "clearButton", "exitButton"]


def crud(ed):
    # op0 grid <-> details, op1 reverse the button row, op2 buttons above the details box
    def op0():
        ed.swap_x(["grpDetails"] + CRUD_BUTTONS, ["grpRecords"])

    def op1():
        ed.reverse_row(CRUD_BUTTONS)

    def op2():
        ed.swap_y(CRUD_BUTTONS, ["grpDetails"])
    return [op0, op1, op2]


def form_ops(rel, ed):
    if rel.startswith("Activity4_"):
        acts = ["btnSum", "btnDifference", "btnProduct", "btnQuotient", "btnAverage", "btnClear", "btnExit"]
        return [lambda: ed.swap_x(["pnlInput"], ["pnlOutput"]),
                lambda: ed.reverse_row(acts),
                lambda: ed.swap_y(["pnlActions"], ["pnlInput", "pnlOutput"])]
    if rel.startswith("Act5/"):
        return [lambda: ed.set_dock("pnlRail", "Left", "Right"),
                lambda: ed.swap_y(["pnlInfo"], ["lblCardsHeading", "pnlCard1", "pnlCard2", "pnlCard3"]),
                lambda: ed.right_align(["btnClear", "btnExit"], 560, 24)]
    if rel.startswith("Act6_"):
        return [lambda: ed.swap_x(["pnlLeft"], ["pnlRight"]),
                lambda: ed.swap_x(["btnEvaluate", "btnClear", "btnExit"], ["lblStatus"]),
                lambda: ed.swap_x(["lblHeaderTitle", "lblHeaderSub"], ["lblAuthor", "lblCourse"], rpad=24)]
    if rel.startswith("Act7_"):
        return [lambda: ed.swap_y(["TabControl1"], ["lblAuthor"]),
                lambda: ed.swap_y(["principalLabel", "principalTextBox"], ["yearsLabel", "yearsNumericUpDown"]),
                lambda: ed.swap_y(["principalLabel", "principalTextBox", "interestRateLabel",
                                   "interestRateTextBox", "yearsLabel", "yearsNumericUpDown", "calculateButton"],
                                  ["balancesLabel", "resultsListBox"])]
    if rel.startswith("Act8_"):
        return [lambda: ed.swap_x(["pnlCompose"], ["pnlIcons", "pnlButtons", "pnlDefault"]),
                lambda: ed.swap_x(["btnDisplay", "btnClear", "btnExit"], ["lblStatus"]),
                lambda: ed.swap_x(["lblHeaderTitle", "lblHeaderSub"], ["lblAuthor"], rpad=24)]
    if rel.startswith("SW202609301600/"):      # Act 9 ListViewSample
        return [lambda: ed.swap_x(["txtPath"], ["browse", "btnRefresh", "details", "list"]),
                lambda: ed.swap_y(["lv"], ["lbl", "lblAuthor"]),
                lambda: ed.swap_x(["lbl"], ["lblAuthor"])]
    if rel.startswith("SW20261002/PanelSplitPanelDemo/Form1"):
        return [lambda: ed.set_dock("pnlRail", "Left", "Right"),
                lambda: ed.swap_y(["pnlInspector"], ["pnlLog"]),
                lambda: ed.swap_y(["pnlWorkspace"], ["pnlInspector", "pnlLog"])]
    if rel.startswith("SW20261002/PanelSplitPanelDemo/Form2"):
        return [lambda: ed.swap_x(["btnCollapseLeft", "btnCollapseTop", "btnSwapOrientation", "btnLock",
                                   "btnReset", "btnExit"], ["lblSplitInfo"]),
                lambda: ed.reverse_row(["btnCollapseLeft", "btnCollapseTop", "btnSwapOrientation", "btnLock",
                                        "btnReset", "btnExit"]),
                lambda: ed.swap_y(["lblTitle"], ["lblSub"])]
    if rel.startswith("SW202610021600/TreeViewSample"):
        return [lambda: ed.swap_x(["tree"], ["selectedPath", "btnRefresh"]),
                lambda: ed.swap_y(["btnRefresh"], ["selectedPath"]),
                lambda: ed.right_align(["btnRefresh"], 900, 30)]
    if rel.startswith("SW202610021600/OpenFileDialogSample"):
        return [lambda: ed.reverse_row(["one", "many", "clear"]),
                lambda: ed.swap_y(["one", "many", "clear"], ["selected"]),
                lambda: ed.right_align(["one", "many", "clear"], 900, 20)]
    if rel.startswith("SW202610021600/CombinedSample"):
        return [lambda: ed.swap_x(["tree"], ["lv"]),
                lambda: ed.reverse_row(["open", "save", "btnRefresh"]),
                lambda: ed.swap_y(["open", "save", "btnRefresh"], ["tree", "lv"])]
    if rel.startswith("FileExplorerClone/"):
        return [lambda: ed.swap_x(["lblApp", "lblHeaderSub"], ["lblAuthor"]),
                lambda: ed.swap_x(["btnTreeToggle", "btnPreviewToggle", "btnSwapLayout", "btnLockSplitters"],
                                  ["lblSplitInfo"]),
                lambda: ed.swap_x(["btnGo"], ["txtPath"])]
    if rel.endswith("frmSchedules.Designer.vb") or rel.endswith("frmQuotes.Designer.vb") \
            or rel.endswith("frmBibleVerses.Designer.vb"):
        return crud(ed)
    if rel.endswith("frmAbout.Designer.vb"):
        texts = ["lblName", "lblCourse", "lblAddress", "lblSkills"]
        return [lambda: ed.swap_x(["PictureBox1"], texts + ["lblQuote"], flip=False),
                lambda: ed.reverse_col(texts),
                lambda: ed.swap_y(texts, ["lblQuote"])]
    if rel.endswith("frmMain.Designer.vb"):
        return [lambda: ed.permute_items("MenuStrip1", rev),
                lambda: ed.permute_items("StatusStrip1", rev),
                lambda: ed.permute_items("MenuStrip1", swap_ends)]
    return []


FORMS = [
    "Activity4_20260703/Activity4_20260703/Form1.Designer.vb",
    "Act5/Ternary2/Form1.Designer.vb",
    "Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.Designer.vb",
    "Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
    "Act8_SW20260805/TheMessage/Form1.Designer.vb",
    "SW202609301600/ListViewSample.Designer.vb",
    "SW20261002/PanelSplitPanelDemo/Form1.Designer.vb",
    "SW20261002/PanelSplitPanelDemo/Form2.Designer.vb",
    "SW202610021600/TreeViewSample.Designer.vb",
    "SW202610021600/OpenFileDialogSample.Designer.vb",
    "SW202610021600/CombinedSample.Designer.vb",
    "FileExplorerClone/PanelSplitDemo/Form1.Designer.vb",
    "IntegProgProject2026/IntegProgProject2026/Forms/frmMain.Designer.vb",
    "IntegProgProject2026/IntegProgProject2026/Forms/frmSchedules.Designer.vb",
    "IntegProgProject2026/IntegProgProject2026/Forms/frmQuotes.Designer.vb",
    "IntegProgProject2026/IntegProgProject2026/Forms/frmBibleVerses.Designer.vb",
    "IntegProgProject2026/IntegProgProject2026/Forms/frmAbout.Designer.vb",
]


def apply_code(code, comp=COMP):
    for rel in FORMS:
        ed = Designer(os.path.join(comp, rel))
        ops = form_ops(rel, ed)
        assert len(ops) == 3, rel
        # y-direction / dock operations first, then x-direction ones (they never overlap)
        for bit in (2, 1, 0):
            if code & (1 << bit):
                ops[bit]()
        ed.save()
    # Act 11 MenuForm: built in code + its picture source
    menu_ops = [rev, last_first, swap_ends]
    for p in (os.path.join(comp, "SW202610021600", "MenuForm.vb"),
              os.path.join(HERE, "figure_sources", "MenuForm.Designer.vb")):
        s = open(p, "rb").read().decode("utf-8")
        rx = re.compile(r"(Items\.AddRange\(New (?:System\.Windows\.Forms\.)?ToolStripItem\(\) \{)([^}]*)(\}\))")
        m = rx.search(s)
        items = [i.strip() for i in m.group(2).split(",")]
        for bit in (2, 1, 0):
            if code & (1 << bit):
                items = menu_ops[bit](items)
        s = s[:m.start()] + m.group(1) + ", ".join(items) + m.group(3) + s[m.end():]
        open(p, "wb").write(s.encode("utf-8"))


if __name__ == "__main__":
    code = int(sys.argv[1])
    assert 0 <= code <= 7
    if os.path.exists(MARKER):
        raise SystemExit("layout already applied: " + open(MARKER).read().strip())
    apply_code(code)
    open(MARKER, "w").write("layout code %d\n" % code)
    print("layout code", code, "applied")
