"""Render a layout figure (PNG) from a VB.NET Windows Forms designer file.

The figure is a documentation drawing built from the coordinates, sizes,
colors and texts that are declared inside Form*.Designer.vb, so it always
matches the design that is really saved in the project.
"""
import os
import re
from PIL import Image, ImageDraw, ImageFont

SCALE = 2
FONT_REG = "/usr/share/fonts/truetype/dejavu/DejaVuSans.ttf"
FONT_BOLD = "/usr/share/fonts/truetype/dejavu/DejaVuSans-Bold.ttf"
FONT_MONO = "/usr/share/fonts/truetype/dejavu/DejaVuSansMono.ttf"

NAMED_COLORS = {
    "White": (255, 255, 255), "Black": (0, 0, 0), "Red": (255, 0, 0),
    "Green": (0, 128, 0), "Blue": (0, 0, 255), "Gray": (128, 128, 128),
    "LightGray": (211, 211, 211), "Control": (240, 240, 240),
    "Transparent": None,
}

CTRL_TYPES = [
    "Panel", "Label", "Button", "TextBox", "MenuStrip", "SplitContainer", "ListBox",
    "ListView", "TreeView", "PictureBox", "RadioButton", "CheckBox", "GroupBox",
    "DataGridView", "DateTimePicker",
    "ComboBox", "NumericUpDown", "ToolStrip", "StatusStrip", "TabControl", "TabPage",
    "DataGridView", "LinkLabel", "TrackBar", "Timer", "ColumnHeader",
    "ToolStripButton", "ToolStripDropDownButton", "ToolStripMenuItem", "ToolStripSeparator",
    "ToolStripLabel", "ToolStripComboBox", "ToolStripTextBox", "CheckBox",
]


def _color(text):
    if text is None:
        return None
    m = re.match(r"System\.Drawing\.Color\.FromArgb\((\d+),\s*(\d+),\s*(\d+)\)", text)
    if m:
        return (int(m.group(1)), int(m.group(2)), int(m.group(3)))
    m = re.match(r"System\.Drawing\.Color\.(\w+)$", text)
    if m:
        return NAMED_COLORS.get(m.group(1))
    return None


class Control:
    def __init__(self, name, kind):
        self.image = None
        self.name = name
        self.kind = kind
        self.loc = (0, 0)
        self.size = (0, 0)
        self.text = ""
        self.back = None
        self.fore = None
        self.font_size = 8.25
        self.bold = False
        self.mono = False
        self.dock = None
        self.visible = True
        self.border = None
        self.align = None
        self.multiline = False
        self.children = []          # direct children added with Controls.Add
        self.panel1 = []            # SplitContainer panel 1
        self.panel2 = []
        self.distance = 0
        self.splitter_width = 6
        self.orientation = "Vertical"
        self.columns = []
        self.items_added = False
        self.selected_index = 0
        self.checked = False        # sample output state of a radio button / check box
        self.rows = []              # sample output rows for ListView / ListBox
        self.nodes = []             # sample output nodes for TreeView
        self.header = []            # sample output column headers


NEWLINE_MARK = "\x00"


def normalize(src):
    """Join VB string continuations so multi line captions can be read."""
    src = re.sub(r'"\s*&\s*_\s*\n\s*"', '', src)
    src = re.sub(r'"\s*&\s*_\s*\n\s*',
                 '" & ', src)
    src = src.replace("Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)",
                      NEWLINE_MARK)
    src = src.replace("vbCrLf", NEWLINE_MARK)
    return src


def literal_value(rhs):
    pieces = rhs.split(NEWLINE_MARK)
    out = []
    for piece in pieces:
        # a VB string literal: "" inside the quotes is one escaped quote character
        quoted = [q.replace('""', '"') for q in re.findall(r'"((?:[^"]|"")*)"', piece)]
        if quoted:
            out.append("".join(quoted))
        elif out:
            out.append("")
    return "\n".join(out).strip()


def parse_designer(path):
    src = normalize(open(path, encoding="utf-8-sig", errors="ignore").read())
    form = Control("Form", "Form")

    # a dictionary of every control object
    controls = {}
    for m in re.finditer(r"^\s*Me\.(\w+) = New System\.Windows\.Forms\.(\w+)\(\)\s*$", src, re.M):
        name, kind = m.group(1), m.group(2)
        if name in ("components",):
            continue
        controls[name] = Control(name, kind)
    form = Control("Form", "Form")
    controls["Form"] = form

    def each(pattern, handler, flags=re.M):
        for mm in re.finditer(pattern, src, flags):
            handler(mm)

    def loc(m):
        c = controls.get(m.group(1))
        if c:
            c.loc = (int(m.group(2)), int(m.group(3)))

    def size(m):
        c = controls.get(m.group(1))
        if c:
            c.size = (int(m.group(2)), int(m.group(3)))

    def text(m):
        c = controls.get(m.group(1))
        if c:
            value = literal_value(m.group(2))
            if value:
                c.text = value

    def back(m):
        c = controls.get(m.group(1))
        if c:
            c.back = _color(m.group(2))

    def fore(m):
        c = controls.get(m.group(1))
        if c:
            c.fore = _color(m.group(2))

    def font(m):
        c = controls.get(m.group(1))
        if c:
            c.font_size = float(m.group(3))
            if "Mono" in m.group(2):
                c.mono = True
            style = m.group(4) if m.lastindex and m.lastindex >= 4 else ""
            c.bold = bool(style and "Bold" in style)

    def dock(m):
        c = controls.get(m.group(1))
        if c:
            c.dock = m.group(2)

    def visible(m):
        c = controls.get(m.group(1))
        if c:
            c.visible = m.group(2) != "False"

    def border(m):
        c = controls.get(m.group(1))
        if c:
            c.border = m.group(2)

    def align(m):
        c = controls.get(m.group(1))
        if c:
            c.align = m.group(2)

    def multiline(m):
        c = controls.get(m.group(1))
        if c:
            c.multiline = m.group(2) == "True"

    def splitter_distance(m):
        c = controls.get(m.group(1))
        if c:
            c.distance = int(m.group(2))

    def splitter_width(m):
        c = controls.get(m.group(1))
        if c:
            c.splitter_width = int(m.group(2))

    def orientation(m):
        c = controls.get(m.group(1))
        if c:
            c.orientation = m.group(2)

    def selected_index(m):
        c = controls.get(m.group(1))
        if c:
            c.selected_index = int(m.group(2))

    def client_size(m):
        form.size = (int(m.group(1)), int(m.group(2)))

    def column(m):
        pass

    each(r"^\s*Me\.(\w+)\.Location = New System\.Drawing\.Point\((-?\d+), (-?\d+)\)", loc)
    each(r"^\s*Me\.(\w+)\.Size = New System\.Drawing\.Size\((\d+), (\d+)\)", size)
    each(r'^\s*Me\.(\w+)\.Text = (".*?)\s*$', text)
    each(r"^\s*Me\.(\w+)\.BackColor = (System\.Drawing\.Color\.(?:FromArgb\(\d+, \d+, \d+\)|\w+))\s*$", back)
    each(r"^\s*Me\.(\w+)\.ForeColor = (System\.Drawing\.Color\.(?:FromArgb\(\d+, \d+, \d+\)|\w+))\s*$", fore)
    each(r'^\s*Me\.(\w+)\.Font = New System\.Drawing\.Font\("([^"]+)", ([\d.]+)!(?:, System\.Drawing\.FontStyle\.(\w+))?\)', font)
    each(r"^\s*Me\.(\w+)\.Dock = System\.Windows\.Forms\.DockStyle\.(\w+)\s*$", dock)
    each(r"^\s*Me\.(\w+)\.Visible = (True|False)\s*$", visible)
    each(r"^\s*Me\.(\w+)\.BorderStyle = System\.Windows\.Forms\.BorderStyle\.(\w+)\s*$", border)
    each(r"^\s*Me\.(\w+)\.TextAlign = System\.Drawing\.ContentAlignment\.(\w+)\s*$", align)
    each(r"^\s*Me\.(\w+)\.Multiline = (True|False)\s*$", multiline)
    each(r"^\s*Me\.(\w+)\.SplitterDistance = (\d+)\s*$", splitter_distance)
    each(r"^\s*Me\.(\w+)\.SplitterWidth = (\d+)\s*$", splitter_width)
    each(r"^\s*Me\.(\w+)\.Orientation = System\.Windows\.Forms\.Orientation\.(\w+)\s*$", orientation)
    each(r"^\s*Me\.ClientSize = New System\.Drawing\.Size\((\d+), (\d+)\)", client_size)
    each(r"^\s*Me\.(\w+)\.SelectedIndex = (\d+)\s*$", selected_index)
    each(r'^\s*Me\.Text = "([^"]*)"\s*$', lambda m: setattr(form, "text", m.group(1)) if False else None)

    m = re.search(r'^\s*Me\.Text = (".*?)\s*$', src, re.M)
    if m:
        form.text = literal_value(m.group(1))
    if form.size == (0, 0):
        form.size = (900, 600)

    # parents
    for m in re.finditer(r"^\s*Me\.(\w+)\.Panel([12])\.Controls\.Add\(Me\.(\w+)\)\s*$", src, re.M):
        parent, panel, child = m.group(1), m.group(2), m.group(3)
        if parent in controls and child in controls:
            (controls[parent].panel1 if panel == "1" else controls[parent].panel2).append(child)

    for m in re.finditer(r"^\s*Me\.Controls\.Add\(Me\.(\w+)\)\s*$", src, re.M):
        child = m.group(1)
        if child in controls:
            form.children.append(child)

    for m in re.finditer(r"^\s*Me\.(\w+)\.Controls\.Add\(Me\.(\w+)\)\s*$", src, re.M):
        parent, child = m.group(1), m.group(2)
        if parent == "Form":
            form.children.append(child)
        elif parent in controls and child in controls:
            controls[parent].children.append(child)

    # ---- compact style (the original sample packs statements on one line) ----
    def compact_instantiate(m):
        name, kind = m.group(1), m.group(2)
        short = kind.split(".")[-1]
        if name != "components" and short in CTRL_TYPES and name not in controls:
            controls[name] = Control(name, short)

    each(r"Me\.(\w+)\s*=\s*New\s+(?:System\.Windows\.Forms\.)?(\w+)\(\)", compact_instantiate)

    def compact_bounds(m):
        name = m.group(1)
        if name in controls:
            controls[name].loc = (int(m.group(2)), int(m.group(3)))
            controls[name].size = (int(m.group(4)), int(m.group(5)))

    each(r"Me\.(\w+)\.SetBounds\((\d+),\s*(\d+),\s*(\d+),\s*(\d+)\)", compact_bounds)

    def compact_text(m):
        name = m.group(1)
        if name in controls and not controls[name].text:
            controls[name].text = m.group(2)

    each(r'Me\.(\w+)\.Text\s*=\s*"([^"]*)"', compact_text)

    def compact_color(m):
        name, which, value = m.group(1), m.group(2), m.group(3)
        if name in controls:
            colour = _color(value.replace(", ", ", ").replace(",", ", "))
            if which == "BackColor":
                controls[name].back = colour
            else:
                controls[name].fore = colour

    each(r"Me\.(\w+)\.(BackColor|ForeColor)\s*=\s*(System\.Drawing\.Color\.(?:FromArgb\(\d+,\s*\d+,\s*\d+\)|\w+))",
         compact_color)

    def compact_columns(m):
        name = m.group(1)
        if name in controls and m.group(2) not in controls[name].header:
            controls[name].header.append(m.group(2))

    each(r'Me\.(\w+)\.Columns\.Add\("([^"]*)"', compact_columns)

    def compact_font(m):
        name = m.group(1)
        if name in controls:
            try:
                controls[name].font_size = float(m.group(2))
            except ValueError:
                pass

    each(r'Me\.(\w+)\.Font\s*=\s*New System\.Drawing\.Font\("([^"]+)",\s*([\d.]+)!', compact_font)

    def compact_dock(m):
        name = m.group(1)
        if name in controls:
            controls[name].dock = m.group(2)

    each(r"Me\.(\w+)\.Dock\s*=\s*(?:System\.Windows\.Forms\.)?DockStyle\.(\w+)", compact_dock)

    def compact_add(m):
        parent, children = m.group(1), m.group(2)
        for child in re.findall(r"Me\.(\w+)", children):
            if child not in controls:
                continue
            if parent is None:
                if child not in form.children:
                    form.children.append(child)
            elif parent == "Form":
                if child not in form.children:
                    form.children.append(child)
            elif parent in controls and child not in controls[parent].children:
                controls[parent].children.append(child)

    each(r"Me\.(?:(\w+)\.)?Controls\.AddRange\(New (?:System\.Windows\.Forms\.)?Control\(\)\s*\{([^}]*)\}", compact_add)

    # ---- items of a ToolStrip / MenuStrip / StatusStrip ----
    for m in re.finditer(r"Me\.(\w+)\.Items\.AddRange\(New (?:System\.Windows\.Forms\.)?ToolStripItem\(\)\s*\{([^}]*)\}\)", src):
        strip = controls.get(m.group(1))
        if strip is not None:
            for item in re.findall(r"Me\.(\w+)", m.group(2)):
                if item in controls and item not in strip.children:
                    strip.children.append(item)

    for m in re.finditer(r"Me\.(\w+)\.Items\.Add\(Me\.(\w+)\)", src):
        strip = controls.get(m.group(1))
        if strip is not None and m.group(2) in controls:
            if m.group(2) not in strip.children:
                strip.children.append(m.group(2))

    return form, controls


def layout(form, controls, padding_top=0):
    rects = {}

    def walk(owner_key, rect):
        owner = controls[owner_key]
        kids = owner.children
        x, y, w, h = rect
        cursor = {"top": y, "bottom": y + h, "left": x, "right": x + w}
        for key in reversed(kids):
            c = controls.get(key)
            if c is None or not c.visible:
                continue
            dock = c.dock
            if dock == "Top":
                child = (cursor["left"], cursor["top"], cursor["right"] - cursor["left"], c.size[1] or 24)
                cursor["top"] += child[3]
            elif dock == "Bottom":
                child = (cursor["left"], cursor["bottom"] - (c.size[1] or 24), cursor["right"] - cursor["left"], c.size[1] or 24)
                cursor["bottom"] -= child[3]
            elif dock == "Left":
                child = (cursor["left"], cursor["top"], c.size[0] or 100, cursor["bottom"] - cursor["top"])
                cursor["left"] += child[2]
            elif dock == "Right":
                child = (cursor["right"] - (c.size[0] or 100), cursor["top"], c.size[0] or 100, cursor["bottom"] - cursor["top"])
                cursor["right"] -= child[2]
            elif dock == "Fill":
                child = (cursor["left"], cursor["top"], cursor["right"] - cursor["left"], cursor["bottom"] - cursor["top"])
            else:
                child = (cursor["left"] - x + x + c.loc[0] - (cursor["left"] - x), cursor["top"] - y + c.loc[1] + y - (cursor["top"] - y), c.size[0], c.size[1])
                child = (x + c.loc[0], y + c.loc[1], c.size[0], c.size[1])
            rects[key] = child
            if c.kind == "TabControl":
                page_rect = (child[0] + 2, child[1] + 22, child[2] - 4, child[3] - 24)
                for page_key in c.children:
                    rects[page_key] = page_rect
                    walk(page_key, page_rect)
            elif c.kind == "SplitContainer":
                sx, sy, sw, sh = child
                dist = c.distance
                swidth = c.splitter_width or 6
                if c.orientation == "Vertical":
                    p1 = (sx, sy, dist, sh)
                    p2 = (sx + dist + swidth, sy, sw - dist - swidth, sh)
                else:
                    p1 = (sx, sy, sw, dist)
                    p2 = (sx, sy + dist + swidth, sw, sh - dist - swidth)
                for panel_key, panel_rect in (("Panel1", p1), ("Panel2", p2)):
                    fake = Control(owner_key + "." + panel_key, "Panel")
                    fake.children = c.panel1 if panel_key == "Panel1" else c.panel2
                    controls[fake.name] = fake
                    rects[fake.name] = panel_rect
                    walk(fake.name, panel_rect)
            else:
                walk(key, child)

    rects["Form"] = (0, 0, form.size[0], form.size[1])
    walk("Form", rects["Form"])
    return rects


TITLE_BAR = 30


def apply_overrides(controls, overrides):
    """Fill controls with sample values so the picture looks like a real run.

    overrides = {
        "txtN1": "12",                       # text of a control
        "lblStatus": "Sum = 18.0000",
        "lvItems": {"header": ["Name", "Type"], "rows": [["a.txt", "Text"]]},
        "tvFolders": ["  Desktop", "  Documents"],
        "tabMain": 1,                        # selected tab index
    }
    """
    for name, value in (overrides or {}).items():
        control = controls.get(name)
        if control is None:
            continue
        if isinstance(value, str):
            control.text = value
        elif isinstance(value, int):
            control.selected_index = value
        elif isinstance(value, dict):
            if value.get("checked") is not None:
                control.checked = bool(value["checked"])
            control.header = value.get("header", control.header)
            control.rows = value.get("rows", control.rows)
            if value.get("text"):
                control.text = value["text"]
            if value.get("back"):
                control.back = tuple(value["back"])
            if value.get("image"):
                control.image = value["image"]
        elif isinstance(value, (list, tuple)):
            if value and isinstance(value[0], (list, tuple)):
                control.rows = value
            else:
                control.nodes = value


def item_name_is_button(item):
    return item.kind in ("ToolStripButton", "ToolStripDropDownButton", "ToolStripMenuItem")


def render(designer_path, out_path, caption=None, max_width=1500, overrides=None, mode="running"):
    """Draw a form.

    mode="running" -> the window as it looks when the program runs (title bar,
                      menu strip, status strip, real rows).
    mode="design"  -> the Visual Studio 2010 designer surface: dotted grid and
                      the eight selection handles around the form, no title bar.
    """
    form, controls = parse_designer(designer_path)
    apply_overrides(controls, overrides)
    rects = layout(form, controls)

    width, height = form.size
    design_mode = (mode == "design")
    margin = 0
    top = TITLE_BAR
    total_w = width
    total_h = height + top

    img = Image.new("RGB", (total_w * SCALE, (total_h + 34) * SCALE), (255, 255, 255))
    draw = ImageDraw.Draw(img)

    def font(size_pt, bold=False, mono=False):
        px = max(7, int(size_pt * 1.34 * SCALE * 0.90))
        path = FONT_MONO if mono else (FONT_BOLD if bold else FONT_REG)
        try:
            return ImageFont.truetype(path, px)
        except Exception:
            return ImageFont.load_default()

    # window frame and title bar (both modes - the title carries the author name)
    draw.rectangle([0, 0, (total_w - 1) * SCALE, (total_h + 33) * SCALE], fill=(255, 255, 255),
                   outline=(120, 128, 140), width=SCALE)
    draw.rectangle([0, 0, (total_w - 1) * SCALE, TITLE_BAR * SCALE], fill=(243, 243, 243))
    draw.line([0, TITLE_BAR * SCALE, (total_w - 1) * SCALE, TITLE_BAR * SCALE],
              fill=(200, 200, 200), width=SCALE)
    draw.text((10 * SCALE, 7 * SCALE), (form.text or "Form")[:90], font=font(8.5),
              fill=(40, 40, 40))
    draw.text(((total_w - 92) * SCALE, 6 * SCALE), "\u2014   \u25a1   \u2715",
              font=font(9), fill=(70, 70, 70))

    client_bg = form.back or (240, 240, 240)
    draw.rectangle([SCALE, (TITLE_BAR + 1) * SCALE, (total_w - 2) * SCALE,
                    (TITLE_BAR + height) * SCALE], fill=client_bg)

    if design_mode:
        # dotted alignment grid of the Visual Studio 2010 designer
        step = 8 * SCALE
        dot = (214, 219, 226)
        yy = (TITLE_BAR + 2) * SCALE
        while yy < (TITLE_BAR + height - 2) * SCALE:
            xx = 2 * SCALE
            while xx < (total_w - 2) * SCALE:
                draw.rectangle([xx, yy, xx + SCALE - 1, yy + SCALE - 1], fill=dot)
                xx += step
            yy += step

    def screen(rect):
        x, y, w, h = rect
        return [(x + (margin if design_mode else 0)) * SCALE, (y + top) * SCALE,
                (x + w - 1 + (margin if design_mode else 0)) * SCALE,
                (y + h - 1 + top) * SCALE]

    def draw_control(key):
        c = controls.get(key)
        if c is None or not c.visible:
            return
        rect = rects.get(key)
        if rect is None:
            return
        x, y, w, h = rect
        if w <= 0 or h <= 0:
            return
        box = screen(rect)
        kind = c.kind
        back = c.back
        line = (150, 160, 172)

        if kind == "TabControl":
            draw.rectangle(box, fill=(246, 247, 249), outline=(190, 197, 206), width=SCALE)
            tabs = [key for key in c.children if controls.get(key) is not None]
            strip_y = box[1] + 2 * SCALE
            cursor_x = box[0] + 4 * SCALE
            if tabs:
                tab_h = 20 * SCALE
                selected = min(max(c.selected_index, 0), len(tabs) - 1)
                for index, page_key in enumerate(tabs):
                    page = controls[page_key]
                    label = page.text or page.name
                    text_font = font(8.0)
                    text_w = draw.textlength(label, font=text_font) + 20 * SCALE
                    selected_now = (index == selected)
                    tab_box = [cursor_x, strip_y,
                               cursor_x + text_w, strip_y + tab_h]
                    draw.rectangle(tab_box,
                                   fill=(255, 255, 255) if selected_now else (234, 238, 244),
                                   outline=(190, 197, 206), width=SCALE)
                    draw.text((cursor_x + 10 * SCALE,
                               strip_y + (tab_h - 8 * 1.34 * SCALE) / 2),
                              label, font=text_font,
                              fill=(30, 41, 59) if selected_now else (90, 100, 112))
                    cursor_x += text_w + 2 * SCALE
                page = controls[tabs[selected]]
                page_rect = rects.get(page.name)
                if page_rect is None:
                    page_rect = (x + 2, y + 22, w - 4, h - 24)
                page_box = screen(page_rect)
                draw.rectangle(page_box, fill=(255, 255, 255))
                for child in page.children:
                    draw_control(child)
            return
        elif kind == "TabPage":
            return
        elif kind in ("MenuStrip", "ToolStrip", "StatusStrip"):
            bar = back or (240, 240, 240)
            draw.rectangle(box, fill=bar, outline=(214, 219, 225), width=SCALE)
            f = font(9)
            cursor = box[0] + 6 * SCALE
            items = [k for k in c.children if controls.get(k) is not None]
            for item_key in items:
                item = controls[item_key]
                label = (item.text or "").replace("&", "")
                if not label:
                    continue
                text_w = draw.textlength(label, font=f)
                if kind == "StatusStrip":
                    yy = box[1] + (h * SCALE - 11 * SCALE) / 2
                    if item_key == items[-1] and len(items) > 1:
                        draw.text((box[2] - text_w - 8 * SCALE, yy), label, font=f,
                                  fill=(60, 70, 80))
                    else:
                        draw.text((cursor, yy), label, font=f, fill=(60, 70, 80))
                        cursor += text_w + 18 * SCALE
                    continue
                pad = 10 * SCALE
                if kind == "ToolStrip" and item_name_is_button(item):
                    draw.rectangle([cursor, box[1] + 3 * SCALE, cursor + text_w + 2 * pad,
                                    box[3] - 3 * SCALE], outline=(200, 206, 213), width=SCALE)
                if kind == "MenuStrip" and item_key != items[0]:
                    pad = 10 * SCALE
                draw.text((cursor + pad, box[1] + (h * SCALE - 11 * SCALE) / 2), label,
                          font=f, fill=(45, 55, 65))
                cursor += text_w + 2 * pad + 6 * SCALE
            return  # the items are already drawn, skip the generic recursion
        elif kind in ("Panel", "GroupBox", "Form", "PictureBox", "SplitContainer"):
            fill = back if back else None
            if fill:
                draw.rectangle(box, fill=fill)
            if c.border in ("FixedSingle",) or kind in ("GroupBox",):
                draw.rectangle(box, outline=line, width=SCALE)
            elif c.border == "Fixed3D":
                draw.rectangle(box, outline=(190, 195, 202), width=SCALE)
                draw.rectangle([box[0] + SCALE, box[1] + SCALE, box[2] - SCALE, box[3] - SCALE],
                               outline=(245, 246, 248), width=SCALE)
            if kind in ("MenuStrip", "ToolStrip", "StatusStrip") and c.back:
                draw.rectangle(box, fill=c.back)
            if kind == "PictureBox":
                draw.rectangle(box, fill=back or (255, 255, 255), outline=(158, 168, 180),
                               width=SCALE)
                if not design_mode and c.image and os.path.exists(c.image):
                    # the real photo of the student, scaled like PictureBoxSizeMode.Zoom
                    bw, bh = int(box[2] - box[0]), int(box[3] - box[1])
                    photo = Image.open(c.image).convert("RGB")
                    ratio = min((bw - 2 * SCALE) / photo.width, (bh - 2 * SCALE) / photo.height)
                    pw, ph = max(1, int(photo.width * ratio)), max(1, int(photo.height * ratio))
                    photo = photo.resize((pw, ph), Image.LANCZOS)
                    img.paste(photo, (int(box[0]) + (bw - pw) // 2, int(box[1]) + (bh - ph) // 2))
                    draw.rectangle(box, outline=(158, 168, 180), width=SCALE)
                elif not design_mode:
                    # neutral portrait: the programmer's photo is put in by the student
                    bw, bh = int(box[2] - box[0]), int(box[3] - box[1])
                    tile = Image.new("RGB", (bw, bh), back or (255, 255, 255))
                    td = ImageDraw.Draw(tile)
                    tone = (190, 198, 208)
                    head_r = int(min(bw, bh) * 0.17)
                    hy = int(bh * 0.36)
                    td.ellipse([bw // 2 - head_r, hy - head_r, bw // 2 + head_r, hy + head_r],
                               fill=tone)
                    td.ellipse([int(bw * 0.17), int(bh * 0.60), int(bw * 0.83), int(bh * 1.25)],
                               fill=tone)
                    img.paste(tile, (int(box[0]), int(box[1])))
                    draw.rectangle(box, outline=(158, 168, 180), width=SCALE)
        elif kind == "Label":
            if back:
                draw.rectangle(box, fill=back)
            if c.border == "FixedSingle":
                draw.rectangle(box, outline=(200, 205, 212), width=SCALE)
            txt = c.text
            if txt:
                f = font(c.font_size, c.bold)
                wrapped = []
                for raw_line in txt.split("\n"):
                    if draw.textlength(raw_line, font=f) > (w - 4) * SCALE and h > c.font_size * 2.6:
                        words = raw_line.split(" ")
                        current = ""
                        for word in words:
                            trial = (current + " " + word).strip()
                            if draw.textlength(trial, font=f) > (w - 4) * SCALE and current:
                                wrapped.append(current)
                                current = word
                            else:
                                current = trial
                        wrapped.append(current)
                    else:
                        wrapped.append(raw_line)
                lines = wrapped
                line_h = c.font_size * 1.5 * SCALE
                total_lines = min(len(lines), max(1, int((h - 1) * SCALE // line_h)) or 1)
                used = total_lines * line_h
                start_y = box[1] + 2 * SCALE
                if total_lines == 1 and h >= c.font_size * 2.6 and c.align and "Middle" in c.align:
                    start_y = box[1] + max(0, (h * SCALE - used) / 2)
                for index in range(total_lines):
                    line_text = lines[index]
                    tw = draw.textlength(line_text, font=f)
                    tx = box[0] + 3 * SCALE
                    if c.align and "Right" in c.align:
                        tx = box[2] - tw - 3 * SCALE
                    elif c.align and "Center" in c.align:
                        tx = box[0] + (box[2] - box[0] - tw) / 2
                    draw.text((tx, start_y + index * line_h), line_text, font=f,
                              fill=c.fore or (30, 30, 30))
        elif kind == "Button":
            if back:
                fill = back
                draw.rectangle(box, fill=fill, outline=(190, 196, 204), width=SCALE)
            else:
                # classic WinForms button: soft gradient and a 1px border
                for row in range(int(box[3] - box[1])):
                    shade = 244 - int(row * 8 / max(1, (box[3] - box[1])))
                    draw.line([box[0], box[1] + row, box[2], box[1] + row],
                              fill=(shade, shade, shade + 1))
                draw.rectangle(box, outline=(173, 179, 188), width=SCALE)
            f = font(c.font_size, True)
            txt = c.text
            if txt:
                tw = draw.textlength(txt, font=f)
                if tw > (w - 8) * SCALE:
                    while txt and draw.textlength(txt + "\u2026", font=f) > (w - 8) * SCALE:
                        txt = txt[:-1]
                    txt += "\u2026"
                    tw = draw.textlength(txt, font=f)
                draw.text((box[0] + (w * SCALE - tw) / 2, box[1] + (h * SCALE - c.font_size * 1.6 * SCALE) / 2),
                          txt, font=f, fill=c.fore or (30, 30, 30))
        elif kind == "TextBox":
            draw.rectangle(box, fill=back or (255, 255, 255), outline=(158, 168, 180), width=SCALE)
            if c.text and not c.multiline:
                f = font(c.font_size)
                txt = c.text
                while txt and draw.textlength(txt, font=f) > (w - 12) * SCALE:
                    txt = txt[:-1]
                draw.text((box[0] + 6 * SCALE, box[1] + (h * SCALE - c.font_size * 1.5 * SCALE) / 2),
                          txt, font=f, fill=c.fore or (25, 35, 45))
            elif c.text and c.multiline:
                f = font(c.font_size)
                line_h = c.font_size * 1.55 * SCALE
                for index, raw in enumerate(c.text.split("\n")):
                    yy = box[1] + 5 * SCALE + index * line_h
                    if yy > box[3] - 4 * SCALE:
                        break
                    draw.text((box[0] + 6 * SCALE, yy), raw, font=f,
                              fill=c.fore or (25, 35, 45))

        elif kind in ("ListView", "TreeView", "ListBox", "DataGridView"):
            draw.rectangle(box, fill=back or (255, 255, 255), outline=(158, 168, 180), width=SCALE)
            f = font(8)
            row_h = 18 * SCALE
            rows = int((h - 4) // 18)
            header_labels = c.header or ["Name", "Type", "Size", "Modified"]
            start_row = 0
            if kind in ("ListView", "DataGridView"):
                header_h = 22 * SCALE
                draw.rectangle([box[0], box[1], box[2], box[1] + header_h], fill=(246, 247, 249),
                               outline=(220, 224, 230), width=SCALE)
                col_w = (w - 4) / max(len(header_labels), 1)
                for i, lab in enumerate(header_labels):
                    draw.text((box[0] + (i * col_w + 6) * SCALE, box[1] + 4 * SCALE), lab, font=f,
                              fill=(90, 100, 112))
                start_row = 1
            if c.rows:
                col_w = (w - 4) / max(len(header_labels), 1)
                for r, cells in enumerate(c.rows):
                    yy = box[1] + (22 + r * 18) * SCALE
                    if yy > box[3] - 6 * SCALE:
                        break
                    for i, cell in enumerate(list(cells)[:len(header_labels)]):
                        txt = str(cell)
                        while txt and draw.textlength(txt, font=f) > (col_w - 10) * SCALE:
                            txt = txt[:-1]
                        draw.text((box[0] + (i * col_w + 6) * SCALE, yy + 3 * SCALE), txt,
                                  font=f, fill=c.fore or (35, 45, 55))
            elif c.nodes:
                for r, node in enumerate(c.nodes):
                    yy = box[1] + (4 + r * 18) * SCALE
                    if yy > box[3] - 6 * SCALE:
                        break
                    depth = (len(node) - len(node.lstrip(" "))) // 2
                    indent = depth * 14
                    if kind == "ListBox":
                        draw.text((box[0] + 4 * SCALE, yy), node.strip(), font=f,
                                  fill=c.fore or (35, 45, 55))
                        continue
                    draw.text((box[0] + (6 + indent) * SCALE, yy), "\u25b8", font=f,
                              fill=(120, 130, 142))
                    draw.text((box[0] + (18 + indent) * SCALE, yy), node.strip(), font=f,
                              fill=c.fore or (35, 45, 55))
            else:
                # empty list: just the white surface, no fake bars
                pass
        elif kind in ("RadioButton", "CheckBox"):
            draw.rectangle(box, fill=back or None) if back else None
            f = font(c.font_size)
            r = 6 * SCALE
            cy = box[1] + (h * SCALE) / 2
            draw.ellipse([box[0] + 2 * SCALE, cy - r, box[0] + 2 * SCALE + 2 * r, cy + r],
                         outline=(120, 130, 142), width=SCALE, fill=(255, 255, 255))
            if c.checked:
                inner = r - 3 * SCALE
                draw.ellipse([box[0] + 2 * SCALE + (r - inner), cy - inner,
                              box[0] + 2 * SCALE + (r + inner), cy + inner],
                             fill=c.fore or (5, 150, 105))
            if c.text:
                draw.text((box[0] + (16) * SCALE, cy - c.font_size * 0.7 * SCALE), c.text, font=f,
                          fill=c.fore or (30, 30, 30))
        else:
            draw.rectangle(box, fill=back or (255, 255, 255), outline=(158, 168, 180), width=SCALE)
            if c.text:
                f = font(c.font_size if c.font_size > 7 else 8.25)
                draw.text((box[0] + 6 * SCALE, box[1] + (h * SCALE - c.font_size * 1.5 * SCALE) / 2),
                          c.text[:46], font=f, fill=c.fore or (25, 35, 45))
            elif kind == "ComboBox":
                draw.text((box[2] - 16 * SCALE, box[1] + 3 * SCALE), "\u25be", font=font(8),
                          fill=(90, 100, 112))

        for child in c.children:
            draw_control(child)
        if kind == "SplitContainer":
            for child in c.panel1 + c.panel2:
                draw_control(child)

    for key in form.children:
        draw_control(key)

    if design_mode:
        # selection border and the eight resize handles, drawn on top
        surface = [SCALE, (TITLE_BAR + 1) * SCALE, (total_w - 2) * SCALE,
                   (TITLE_BAR + height - 1) * SCALE]
        draw.rectangle(surface, outline=(0, 122, 204), width=SCALE)
        handle = 7 * SCALE
        mid_x = (surface[0] + surface[2]) // 2
        mid_y = (surface[1] + surface[3]) // 2
        for hx, hy in [(surface[0], surface[1]), (mid_x, surface[1]), (surface[2], surface[1]),
                       (surface[0], mid_y), (surface[2], mid_y),
                       (surface[0], surface[3]), (mid_x, surface[3]), (surface[2], surface[3])]:
            draw.rectangle([hx - handle // 2, hy - handle // 2, hx + handle // 2, hy + handle // 2],
                           fill=(255, 255, 255), outline=(0, 122, 204), width=SCALE)

    # trim the extra strip used while the caption was part of the image
    img = img.crop((0, 0, total_w * SCALE, total_h * SCALE + 2 * SCALE))

    if total_w > max_width:
        ratio = max_width / total_w
        img = img.resize((int(img.width * ratio), int(img.height * ratio)), Image.LANCZOS)
    img.save(out_path, "PNG")
    return out_path, form.text, form.size


if __name__ == "__main__":
    import sys
    print(render(sys.argv[1], sys.argv[2], sys.argv[3] if len(sys.argv) > 3 else ""))
