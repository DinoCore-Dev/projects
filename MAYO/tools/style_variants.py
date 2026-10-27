# -*- coding: utf-8 -*-
"""Font and button-style variants for the form activities (Acts 4-13).

Every identity gets its own STYLE CODE (0..11).  A style is

    * one font family that Visual Studio 2010 offers on any Windows PC
      (Segoe UI, Courier New, Georgia, Verdana, Calibri, Cambria, Arial,
       Times New Roman, Consolas, Tahoma, Trebuchet MS, Candara), and
    * one button look: borderless, 2px border, outline, 3D, popup, thin, native,
      3px outline, tonal, heavy border, inverse (dark fill, light border) or halo (thick pale frame).

What the script rewrites inside the *.Designer.vb files (and the two forms built in code):

    * `Font("Segoe UI" | "Microsoft Sans Serif", size, ...)` -> the identity's family; the size is
      scaled so that the text keeps about the same width as the original (Courier New is wide,
      Calibri is narrow);
    * every control that had no Font line gets one (so a plain form also shows the family);
    * `FlatStyle`, `FlatAppearance.BorderSize / BorderColor`, `BackColor`, `ForeColor` of buttons.

Control names, positions and event handlers stay the same, so the code-behind is untouched.
Run once per identity folder (a marker file tools/style_code.txt stops a second run):

    python3 tools/style_variants.py <STYLE_CODE 0-11>
"""
import colorsys
import glob
import os
import re
import sys

HERE = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.dirname(HERE)
COMP = os.path.join(ROOT, "COMPILATION")
MARKER = os.path.join(HERE, "style_code.txt")

# code: (font family, size scale, button style)
STYLES = {
    0: ("Segoe UI", 1.00, "solid"),
    1: ("Courier New", 0.88, "border2"),
    2: ("Georgia", 0.97, "ghost2"),
    3: ("Verdana", 0.92, "bevel"),
    4: ("Calibri", 1.04, "popup"),
    5: ("Cambria", 1.04, "thin"),
    6: ("Times New Roman", 1.04, "native"),
    7: ("Arial", 0.96, "ghost3"),
    8: ("Consolas", 0.92, "tonal"),
    9: ("Tahoma", 0.95, "heavy"),
    10: ("Trebuchet MS", 0.98, "inverse"),
    11: ("Candara", 1.05, "halo"),
}
MIN_SIZE = 7.0
FONT_KINDS = ("Label", "Button", "TextBox", "ComboBox", "DateTimePicker", "DataGridView", "GroupBox",
              "TabControl", "TabPage", "ListBox", "ListView", "TreeView", "NumericUpDown", "RadioButton",
              "CheckBox", "MenuStrip", "StatusStrip", "ToolStrip")
FORM_BASE_SIZE = 8.25
COLOR = r"System\.Drawing\.Color\.(?:FromArgb\((\d+), (\d+), (\d+)\)|(\w+))"
NAMED = {"White": (255, 255, 255), "Black": (0, 0, 0), "Control": (240, 240, 240)}


def scaled(size, scale):
    return max(MIN_SIZE, round(size * scale * 4) / 4.0)


def fmt(rgb):
    return "System.Drawing.Color.FromArgb(%d, %d, %d)" % tuple(int(v) for v in rgb)


def darker(rgb, k):
    return tuple(int(v * k) for v in rgb)


def mix_white(rgb, k):
    return tuple(int(v + (255 - v) * k) for v in rgb)


def luminance(rgb):
    r, g, b = [v / 255.0 for v in rgb]
    return 0.2126 * r + 0.7152 * g + 0.0722 * b


def parse_color(text):
    if text is None:
        return None
    m = re.match(COLOR + r"$", text.strip())
    if not m:
        return None
    if m.group(1) is not None:
        return (int(m.group(1)), int(m.group(2)), int(m.group(3)))
    return NAMED.get(m.group(4))


def read(path):
    raw = open(path, "rb").read()
    text = raw.decode("utf-8-sig")
    crlf = "\r\n" in text
    return text.replace("\r\n", "\n"), crlf, raw.startswith(b"\xef\xbb\xbf")


def write(path, text, crlf, bom):
    if crlf:
        text = text.replace("\n", "\r\n")
    data = text.encode("utf-8")
    if bom:
        data = b"\xef\xbb\xbf" + data
    open(path, "wb").write(data)


def accent_of_identity():
    """The main colour of the identity = BackColor of the first button of Activity 4."""
    path = os.path.join(COMP, "Activity4_20260703", "Activity4_20260703", "Form1.Designer.vb")
    text, _, _ = read(path)
    m = re.search(r"Me\.btnSum\.BackColor = " + COLOR, text)
    return (int(m.group(1)), int(m.group(2)), int(m.group(3)))


# ------------------------------------------------------------------------------------------
def retype_fonts(text, family, scale):
    """Replace Segoe UI / Microsoft Sans Serif fonts by the identity's family."""
    rx = re.compile(r'(New (?:System\.Drawing\.)?Font\()"(?:Segoe UI|Microsoft Sans Serif)", ([\d.]+)(!|F)')

    def repl(m):
        size = scaled(float(m.group(2)), scale) if scale != 1.0 else float(m.group(2))
        return '%s"%s", %s%s' % (m.group(1), family, ("%g" % size) if size != int(size) else "%d.0" % int(size),
                                 m.group(3))
    return rx.sub(repl, text)


def add_missing_fonts(text, family, scale):
    """Give every control that has no Font line one (Segoe-sized 8.25 pt)."""
    kinds = {}
    for m in re.finditer(r"^\s*Me\.(\w+) = New System\.Windows\.Forms\.(\w+)\(\)\s*$", text, re.M):
        kinds[m.group(1)] = m.group(2)
    size = scaled(FORM_BASE_SIZE, scale)
    size_text = ("%g" % size) if size != int(size) else "%d.0" % int(size)
    out = []
    lines = text.split("\n")
    for line in lines:
        out.append(line)
        m = re.match(r'^(\s*)Me\.(\w+)\.Name = "(\w+)"\s*$', line)
        if not m:
            continue
        name = m.group(2)
        if kinds.get(name) in FONT_KINDS and not re.search(r"^\s*Me\.%s\.Font = " % re.escape(name), text, re.M):
            out.append('%sMe.%s.Font = New System.Drawing.Font("%s", %s!)' % (m.group(1), name, family, size_text))
    return "\n".join(out)


def button_names(text):
    return [m.group(1) for m in re.finditer(r"^\s*Me\.(\w+) = New System\.Windows\.Forms\.Button\(\)\s*$", text, re.M)]


def restyle_buttons(text, style, accent):
    for name in button_names(text):
        text = restyle_one(text, name, style, accent)
    return text


def prop(text, name, prop_name):
    m = re.search(r"^[ \t]*Me\.%s\.%s = (.*)$" % (re.escape(name), re.escape(prop_name)), text, re.M)
    return m.group(1).strip() if m else None


def drop(text, name, prop_name):
    return re.sub(r"^[ \t]*Me\.%s\.%s = .*\n" % (re.escape(name), re.escape(prop_name)), "", text, flags=re.M)


def restyle_one(text, name, style, accent):
    flat = prop(text, name, "FlatStyle")
    if flat is not None and "FlatStyle.Flat" not in flat:
        return text                      # already special: leave it
    back = parse_color(prop(text, name, "BackColor"))
    fore = parse_color(prop(text, name, "ForeColor"))
    styled = flat is not None            # the designed (coloured) buttons
    if style == "solid":
        return text
    indent = "        "
    m = re.search(r"^([ \t]*)Me\.%s\.(?:Font|Location|Name) = " % re.escape(name), text, re.M)
    if m:
        indent = m.group(1)

    lines = []          # new lines (before the Font line)
    new_back = new_fore = None
    use_vs = None
    flat_name = None
    border_size = None
    border_color = None
    base = back if back is not None else accent
    light = styled and back is not None and luminance(back) > 0.75   # e.g. the grey "Clear" button

    if style == "border2":
        flat_name, border_size = "Flat", 2
        border_color = darker(base, 0.60)
    elif style == "thin":
        flat_name, border_size = "Flat", 1
        border_color = darker(base, 0.65)
    elif style == "heavy":
        flat_name, border_size = "Flat", 3
        border_color = darker(base, 0.45)
    elif style in ("ghost2", "ghost3"):
        flat_name, border_size = "Flat", (2 if style == "ghost2" else 3)
        if styled and not light:
            new_back, new_fore, border_color = (255, 255, 255), base, base
        elif styled:
            border_color = darker(base, 0.75)
        else:
            border_color = accent
    elif style == "tonal":
        flat_name, border_size = "Flat", 1
        if styled and not light:
            new_back, new_fore, border_color = mix_white(base, 0.82), darker(base, 0.62), base
        elif styled:
            border_color = darker(base, 0.75)
        else:
            new_back, new_fore, border_color = mix_white(accent, 0.86), darker(accent, 0.62), accent
    elif style == "inverse":
        flat_name, border_size = "Flat", 2
        if styled and not light:
            new_back, new_fore, border_color = darker(base, 0.55), (255, 255, 255), mix_white(base, 0.40)
        elif styled:
            border_color = darker(base, 0.75)
        else:
            new_back, new_fore, border_color = darker(accent, 0.55), (255, 255, 255), mix_white(accent, 0.40)
    elif style == "halo":
        flat_name, border_size = "Flat", 4
        if styled and not light:
            border_color = mix_white(base, 0.60)
        elif styled:
            border_color = darker(base, 0.85)
        else:
            new_back, new_fore, border_color = darker(accent, 0.85), (255, 255, 255), mix_white(accent, 0.60)
    elif style == "popup":
        flat_name = "Popup"
    elif style == "bevel":
        flat_name = "Standard"
        if not styled:
            return text
    elif style == "native":
        flat_name = "System"
        use_vs = "True"
    else:
        return text

    # remove the old statements
    text = drop(text, name, "FlatAppearance.BorderSize")
    text = drop(text, name, "FlatAppearance.BorderColor")
    text = drop(text, name, "FlatStyle")
    if new_back is not None:
        text = drop(text, name, "BackColor")
    if new_fore is not None:
        text = drop(text, name, "ForeColor")
    if style == "native":
        text = drop(text, name, "BackColor")
        text = drop(text, name, "ForeColor")
    if style == "thin":
        text = re.sub(r"(Me\.%s\.Font = New System\.Drawing\.Font\([^\n]*?), System\.Drawing\.FontStyle\.Bold\)" % re.escape(name),
                      r"\1)", text)

    if new_back is not None:
        lines.append("%sMe.%s.BackColor = %s" % (indent, name, fmt(new_back)))
        use_vs = "False"
    if border_size is not None:
        lines.append("%sMe.%s.FlatAppearance.BorderColor = %s" % (indent, name, fmt(border_color)))
        lines.append("%sMe.%s.FlatAppearance.BorderSize = %d" % (indent, name, border_size))
    lines.append("%sMe.%s.FlatStyle = System.Windows.Forms.FlatStyle.%s" % (indent, name, flat_name))
    block = "\n".join(lines) + "\n"
    m = re.search(r"^[ \t]*Me\.%s\.Font = " % re.escape(name), text, re.M)
    if m is None:
        m = re.search(r"^[ \t]*Me\.%s\.Location = " % re.escape(name), text, re.M)
    text = text[:m.start()] + block + text[m.start():]
    if new_fore is not None:
        # ForeColor goes after the Font line
        m = re.search(r"^[ \t]*Me\.%s\.Font = [^\n]*\n" % re.escape(name), text, re.M)
        if m is None:
            m = re.search(r"^[ \t]*Me\.%s\.Location = [^\n]*\n" % re.escape(name), text, re.M)
            text = text[:m.start()] + "%sMe.%s.ForeColor = %s\n" % (indent, name, fmt(new_fore)) + text[m.start():]
        else:
            text = text[:m.end()] + "%sMe.%s.ForeColor = %s\n" % (indent, name, fmt(new_fore)) + text[m.end():]
    if use_vs is not None:
        if re.search(r"^[ \t]*Me\.%s\.UseVisualStyleBackColor = " % re.escape(name), text, re.M):
            text = re.sub(r"(^[ \t]*Me\.%s\.UseVisualStyleBackColor = )\w+" % re.escape(name), r"\g<1>" + use_vs,
                          text, flags=re.M)
        else:
            m = re.search(r"^[ \t]*Me\.%s\.Text = [^\n]*\n" % re.escape(name), text, re.M)
            if m:
                text = text[:m.end()] + "%sMe.%s.UseVisualStyleBackColor = %s\n" % (indent, name, use_vs) + text[m.end():]
    return text


# ------------------------------------------------------------------------------------------
def fit_fonts(path, family):
    """Make the new family fit: fixed-size single-line labels / buttons shrink their font (down to
    6.5 pt) and, if that is still not enough, grow to the width they need when nothing is in the
    way; tab headers shrink until all tabs fit into the TabControl."""
    sys.path.insert(0, HERE)
    import design_figure as df
    from PIL import ImageFont
    text, crlf, bom = read(path)
    form, controls = df.parse_designer(path)
    rects = df.layout(form, controls)
    entry = df.FONT_TABLE.get(family)
    if entry is None:
        return 0
    containers = ("Panel", "GroupBox", "TabControl", "TabPage", "SplitContainer", "Form", "MenuStrip",
                  "StatusStrip", "ToolStrip", "DataGridView", "ListView", "TreeView", "ListBox", "TextBox",
                  "PictureBox")
    changed = 0
    parent_of = {}
    for pn, pc in controls.items():
        for ch in list(pc.children) + list(pc.panel1) + list(pc.panel2):
            parent_of[ch] = pn

    def text_width(label, size, bold):
        path_ttf = os.path.join(df.FONT_DIR, entry[1] if bold else entry[0])
        f = ImageFont.truetype(path_ttf, max(7, int(round(size * 1.3333 * entry[2] * 4))))
        return f.getlength(label) / 4.0

    def set_font(name, size):
        nonlocal text, changed
        rx = re.compile(r'(^[ \t]*Me\.%s\.Font = New System\.Drawing\.Font\("%s", )([\d.]+)(!)' % (re.escape(name), re.escape(family)), re.M)
        text, n = rx.subn(lambda m: ("%s%g%s" % (m.group(1), size, m.group(3))) if size != int(size) else ("%s%d.0%s" % (m.group(1), int(size), m.group(3))), text)
        changed += n

    for name, c in controls.items():
        if c.family != family:
            continue
        if c.kind == "TabControl":
            labels = [controls[k].text or controls[k].name for k in c.children if k in controls]
            size = c.font_size
            avail = c.size[0] - 12
            new = size
            while new > 6.5 and sum(text_width(l, new, False) + 16 for l in labels) > avail:
                new -= 0.25
            if new < size:
                set_font(name, new)
            continue
        if c.kind not in ("Label", "Button", "RadioButton", "CheckBox") or not c.text or "\n" in c.text:
            continue
        if c.size[0] <= 0:
            continue
        if c.kind == "Label" and re.search(r"^\s*Me\.%s\.AutoSize = True" % re.escape(name), text, re.M):
            # an AutoSize label grows to its text at run time: shrink it while it would touch a neighbour
            if name in rects:
                x, y, w, h = rects[name]
                size = c.font_size
                while size > 6.5:
                    grown = (x, y + 2, text_width(c.text, size, c.bold) + 2, max(4, h - 5))
                    hit = grown[0] + grown[2] > form.size[0] - 12
                    for other, orc in rects.items():
                        oc = controls.get(other)
                        if other == name or oc is None or oc.kind in containers[:7] or oc.kind == "Form" or parent_of.get(other) != parent_of.get(name):
                            continue
                        if (grown[0] < orc[0] + orc[2] and orc[0] < grown[0] + grown[2] and
                                grown[1] < orc[1] + orc[3] and orc[1] < grown[1] + grown[3]):
                            hit = True
                            break
                    if not hit:
                        break
                    size -= 0.25
                if size < c.font_size:
                    set_font(name, size)
                wneed = int(text_width(c.text, size, c.bold) + 2)
                if x + wneed > form.size[0] - 12 and c.kind == "Label":
                    nx = max(4, form.size[0] - 16 - wneed)       # still too wide: slide it left
                    m = re.search(r"^([ \t]*Me\.%s\.Location = New System\.Drawing\.Point\()\d+(, \d+\))" % re.escape(name), text, re.M)
                    if m:
                        text = text[:m.start()] + "%s%d%s" % (m.group(1), nx, m.group(2)) + text[m.end():]
                        changed += 1
            continue
        if c.kind == "Label" and c.size[1] > c.font_size * 1.3333 * 2.3:
            continue                 # tall label: the text wraps
        extra = 8 if c.kind == "Button" else (22 if c.kind in ("RadioButton", "CheckBox") else 2)
        avail = c.size[0] - extra
        size = c.font_size
        new = size
        while new > 6.5 and text_width(c.text, new, c.bold) > avail:
            new -= 0.25
        if new < size:
            set_font(name, new)
        need = int(text_width(c.text, new, c.bold) + extra + 2)
        if need > c.size[0] and name in rects and c.kind in ("Label", "Button"):
            x, y, w, h = rects[name]
            grown = (x, y, need, h)
            blocked = grown[0] + grown[2] > form.size[0] - 4
            for other, orc in rects.items():
                oc = controls.get(other)
                if other == name or oc is None or oc.kind in containers[:7] or oc.kind == "Form" or parent_of.get(other) != parent_of.get(name):
                    continue
                if not (grown[0] < orc[0] + orc[2] and orc[0] < grown[0] + grown[2] and
                        grown[1] < orc[1] + orc[3] and orc[1] < grown[1] + grown[3]):
                    continue
                blocked = True
                break
            if not blocked:
                m = re.search(r"^([ \t]*Me\.%s\.Size = New System\.Drawing\.Size\()\d+(, \d+\))" % re.escape(name), text, re.M)
                if m:
                    text = text[:m.start()] + "%s%d%s" % (m.group(1), need, m.group(2)) + text[m.end():]
                    changed += 1
    if changed:
        write(path, text, crlf, bom)
    return changed


def apply_code(code, comp=COMP):
    family, scale, style = STYLES[code]
    accent = accent_of_identity()
    files = glob.glob(os.path.join(comp, "**", "*.vb"), recursive=True)
    files += glob.glob(os.path.join(HERE, "figure_sources", "*.vb"))
    changed = 0
    for path in sorted(files):
        text, crlf, bom = read(path)
        original = text
        text = retype_fonts(text, family, scale)
        if path.endswith(".Designer.vb"):
            text = add_missing_fonts(text, family, scale)
            text = restyle_buttons(text, style, accent)
        if text != original:
            write(path, text, crlf, bom)
            changed += 1
        if path.endswith(".Designer.vb"):
            fit_fonts(path, family)
    return changed


if __name__ == "__main__":
    if sys.argv[1] == "--fit-only":
        code = int(open(MARKER).read().split()[2])
        for p in sorted(glob.glob(os.path.join(COMP, "**", "*.Designer.vb"), recursive=True)):
            fit_fonts(p, STYLES[code][0])
        raise SystemExit("fit pass done")
    code = int(sys.argv[1])
    assert code in STYLES
    if os.path.exists(MARKER):
        raise SystemExit("style already applied: " + open(MARKER).read().strip())
    n = apply_code(code)
    open(MARKER, "w").write("style code %d (%s, %s)\n" % (code, STYLES[code][0], STYLES[code][2]))
    print("style code", code, STYLES[code][0], STYLES[code][2], "- files changed:", n)
