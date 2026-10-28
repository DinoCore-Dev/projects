# -*- coding: utf-8 -*-
from rd_base import *
from designer_edit import _enum
from rd_gen import gen, C, P, S, Q

NOB = "System.Windows.Forms.BorderStyle.None"

def mix(a, b, k):  # k of a
    return tuple(int(round(a[i] * k + b[i] * (1 - k))) for i in range(3))

def light(c):
    return mix((255, 255, 255), c, 0.35)

def btn(d, name, kind, size=None, fnt=None):
    """kind: p solid mint | m mint neon | a amber neon | v violet neon | n neutral neon | x danger neon"""
    cols = {"m": MINT, "a": AMBER, "v": (167, 139, 250), "n": (148, 163, 184), "x": (248, 113, 113)}
    if kind == "p":
        d.flat(name, MINT, INK, MINT_L, 1)
    else:
        c = cols[kind]
        d.flat(name, mix(c, PAGE, 0.13), light(c) if kind != "n" else TEXT2, c if kind != "n" else (88, 98, 116), 1)
    if fnt:
        d.set(name, "Font", fnt)

def buttons(d, spec):
    for k, v in spec.items():
        btn(d, k, v)

def lab(d, name, x, y, w, h, size=None, bold=None, color=None, align=None, text=None):
    d.place(name, x, y, w, h)
    d.autosize(name, False)
    if size is not None:
        d.font(name, FAM, size, bool(bold))
    if color is not None:
        d.fore(name, color)
    if align:
        d.align(name, align)
    if text is not None:
        d.text(name, text)

def inputs_dark(d):
    for n, k in d.kinds().items():
        if k in ("TextBox", "ListBox", "ListView", "TreeView", "NumericUpDown", "ComboBox", "DateTimePicker"):
            d.back(n, INPUT); d.fore(n, TEXT)
        if k == "DataGridView":
            d.set(n, "BackgroundColor", rgb(INPUT))

def formprops(d, w, h, back=PAGE):
    f = d.form_name()
    d.set(f, "ClientSize", "New System.Drawing.Size(%d, %d)" % (w, h))
    d.set(f, "BackColor", rgb(back))
    return f

# =========================================================================================
def act4():
    d = Designer(find("Activity4_20260703/Activity4_20260703/Form1.Designer.vb"))
    formprops(d, 900, 520)
    # sidebar (Left dock) with title, subtitle, author and the two utility buttons
    d.back("pnlBanner", CHROME); d.dock("pnlBanner", "Left", 250, 520)
    d.panel("pnlRuleA", "pnlBanner", 24, 28, 44, 4, MINT)
    lab(d, "lblTitle", 24, 44, 204, 70, 21, True, TEXT)
    lab(d, "lblSubtitle", 24, 122, 204, 84, 9, False, MINT_L)
    lab(d, "lblAuthorName", 24, 392, 204, 24, 12, True, TEXT, "TopLeft")
    lab(d, "lblAuthorCourse", 24, 418, 204, 40, 9, False, MUTED, "TopLeft")
    d.set("lblAuthorName", "Anchor", "CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)")
    d.set("lblAuthorCourse", "Anchor", "CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)")
    for n, x in (("btnClear", 24), ("btnExit", 128)):
        d.reparent(n, "pnlBanner"); d.place(n, x, 318, 98, 36)
    # inputs: three fields in one row (caption above the box)
    d.place("pnlInput", 274, 24, 602, 130)
    lab(d, "lblInputTitle", 18, 12, 300, 18, 9, True, MUTED)
    for i, (cap, txt) in enumerate((("lblFirst", "txtN1"), ("lblSecond", "txtN2"), ("lblThird", "txtN3"))):
        x = 18 + i * 188
        lab(d, cap, x, 40, 170, 20, 10, False, TEXT2)
        d.place(txt, x, 62, 170, 28); d.font(txt, FAM, 12)
    lab(d, "lblInputNote", 18, 100, 560, 18, 8.25, False, MUTED)
    # results: five tiles in one row
    d.place("pnlOutput", 274, 170, 602, 168)
    lab(d, "lblOutputTitle", 18, 12, 300, 18, 9, True, MUTED)
    for i, (key, cap) in enumerate((("Sum", "Sum"), ("Diff", "Difference"), ("Prod", "Product"), ("Quot", "Quotient"), ("Ave", "Average"))):
        x = 18 + i * 114
        tile = "pnlTile" + key
        d.panel(tile, "pnlOutput", x, 42, 106, 108, MINT_D if key == "Ave" else ALT)
        d.reparent("lbl%sCaption" % key, tile); d.reparent("lbl%sValue" % key, tile)
        lab(d, "lbl%sCaption" % key, 10, 10, 86, 18, 9, True, MINT_L if key == "Ave" else MUTED)
        lab(d, "lbl%sValue" % key, 4, 40, 98, 52, 13, True, TEXT, "MiddleCenter")
        d.back("lbl%sValue" % key, MINT_D if key == "Ave" else ALT)
        d.set("lbl%sValue" % key, "BorderStyle", NOB)
    # operation buttons in one row
    d.place("pnlActions", 274, 354, 602, 66); d.back("pnlActions", PAGE); d.set("pnlActions", "BorderStyle", "System.Windows.Forms.BorderStyle.None")
    for i, n in enumerate(("btnSum", "btnDifference", "btnProduct", "btnQuotient", "btnAverage")):
        d.place(n, i * 122, 10, 114, 42)
    buttons(d, {"btnSum": "m", "btnDifference": "m", "btnProduct": "m", "btnQuotient": "m", "btnAverage": "p",
                "btnClear": "n", "btnExit": "x"})
    # footer (right of the sidebar)
    d.back("pnlFooter", CHROME); d.fore("lblStatus", MUTED); d.fore("lblFooterAuthor", MUTED)
    d.place("lblFooterAuthor", 380, 9, 250, 16)
    inputs_dark(d)
    d.save()


def fonts_in(d, names, size, bold=False):
    for n in names:
        d.font(n, FAM, size, bold)

# =========================================================================================
def act5():
    d = Designer(find("Act5/Ternary2/Form1.Designer.vb"))
    formprops(d, 820, 560)
    # the rail becomes a slim bar at the bottom, the hero text moves into the body
    d.back("pnlRail", CHROME); d.dock("pnlRail", "Bottom", 820, 64)
    lab(d, "lblRailAuthor", 24, 11, 360, 24, 12, True, TEXT, "TopLeft")
    lab(d, "lblRailCourse", 24, 36, 360, 20, 9, False, MUTED, "TopLeft")
    lab(d, "lblRailBadge", 480, 24, 316, 18, 9, True, MINT, "MiddleRight")
    d.set("lblRailBadge", "Anchor", "CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)")
    for n in ("pnlRailRule", "lblRailTitle", "lblRailText"):
        d.reparent(n, "pnlBody")
    d.back("pnlBody", PAGE)
    d.back("pnlRailRule", MINT); d.place("pnlRailRule", 40, 28, 44, 4)
    lab(d, "lblRailTitle", 40, 40, 740, 44, 26, True, TEXT)
    lab(d, "lblRailText", 40, 88, 720, 40, 10, False, MUTED)
    lab(d, "lblHeading", 40, 150, 300, 28, 15, True, TEXT)
    lab(d, "lblHint", 40, 182, 300, 36, 9, False, MUTED)
    d.place("pnlEntry", 360, 138, 420, 86)
    lab(d, "lblAverageCaption", 16, 10, 200, 18, 9, True, MUTED)
    d.place("txtAverage", 16, 36, 170, 36); d.font("txtAverage", FAM, 15, True)
    d.place("btnEvaluate", 198, 36, 206, 36)
    lab(d, "lblCardsHeading", 40, 238, 300, 18, 9, True, MUTED)
    for i, k in enumerate((1, 2, 3)):
        x = 40 + i * 244
        d.place("pnlCard%d" % k, x, 260, 232, 124)
        lab(d, "lblCard%dTitle" % k, 16, 12, 200, 18, 9, True, MUTED)
        lab(d, "lblCard%dValue" % k, 8, 36, 216, 56, 24, True, TEXT, "MiddleCenter")
        lab(d, "lblCard%dNote" % k, 16, 98, 200, 18, 8.25, False, MUTED, "MiddleCenter")
        d.back("pnlCard%d" % k, CARD)
    d.back("pnlInfo", CARD2); d.place("pnlInfo", 40, 398, 480, 60)
    lab(d, "lblInfoTitle", 14, 8, 440, 18, 9, True, MINT_L)
    lab(d, "lblInfoText", 14, 28, 456, 28, 8.25, False, TEXT2)
    d.place("btnClear", 540, 404, 110, 46); d.place("btnExit", 660, 404, 120, 46)
    lab(d, "lblStatus", 40, 466, 740, 20, 9, False, MUTED)
    buttons(d, {"btnEvaluate": "p", "btnClear": "n", "btnExit": "x"})
    inputs_dark(d)
    d.save()

# =========================================================================================
def act6():
    d = Designer(find("Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.Designer.vb"))
    formprops(d, 960, 600)
    d.back("pnlHeader", CHROME); d.dock("pnlHeader", "Left", 240, 600)
    d.panel("pnlRuleA", "pnlHeader", 24, 30, 44, 4, MINT)
    lab(d, "lblHeaderTitle", 24, 46, 196, 96, 21, True, TEXT)
    lab(d, "lblHeaderSub", 24, 150, 196, 80, 9, False, MINT_L)
    lab(d, "lblAuthor", 24, 486, 196, 24, 12, True, TEXT, "TopLeft")
    lab(d, "lblCourse", 24, 512, 196, 40, 9, False, MUTED, "TopLeft")
    d.back("pnlActions", CHROME); d.dock("pnlActions", "Bottom", 720, 64)
    lab(d, "lblStatus", 20, 22, 310, 20, 9, False, MUTED)
    d.place("btnClear", 340, 12, 96, 40); d.place("btnExit", 444, 12, 96, 40); d.place("btnEvaluate", 548, 12, 156, 40)
    # inputs in one row
    d.place("pnlLeft", 264, 24, 672, 140)
    lab(d, "lblLeftTitle", 18, 12, 300, 18, 9, True, MUTED)
    for i, k in enumerate((1, 2, 3)):
        x = 18 + i * 218
        lab(d, "lblG%dCaption" % k, x, 38, 196, 20, 10, False, TEXT2)
        d.place("txtG%d" % k, x, 60, 198, 32); d.font("txtG%d" % k, FAM, 14)
    d.place("lblLeftRule", 18, 104, 636, 1); d.back("lblLeftRule", LINE)
    lab(d, "lblLeftNote", 18, 110, 636, 22, 8.25, False, MUTED)
    # average badge on the left, remarks on the right
    d.place("pnlRight", 264, 184, 672, 330)
    lab(d, "lblAveCaption", 18, 14, 200, 18, 9, True, MUTED)
    d.place("pnlAveBadge", 18, 40, 234, 190)
    d.font("lblAverage", FAM, 40, True)
    lab(d, "lblAveNote", 18, 240, 234, 60, 8.5, False, MUTED)
    for i, k in enumerate((1, 2, 3)):
        y = 14 + i * 104
        lab(d, "lblR%dCaption" % k, 276, y, 380, 18, 9, False, MUTED)
        lab(d, "lblRemarks%d" % k, 276, y + 24, 380, 56, 16, True, TEXT, "MiddleCenter")
        d.back("lblRemarks%d" % k, ALT)
    buttons(d, {"btnEvaluate": "p", "btnClear": "n", "btnExit": "x"})
    inputs_dark(d)
    d.save()

# =========================================================================================
def act7():
    d = Designer(find("Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb"))
    f = formprops(d, 760, 520)
    d.panel("pnlTop", "FORM", 0, 0, 760, 64, CHROME)
    d.panel("pnlBottom", "FORM", 0, 484, 760, 36, CHROME)
    d.panel("pnlRuleA", "pnlTop", 24, 14, 44, 4, MINT)
    d.label("lblTopTitle", "pnlTop", 24, 22, 460, 32, "Integrative Program 1", TEXT, F(18, True))
    d.label("lblTopSub", "pnlTop", 480, 26, 256, 22, "Activity 7  |  IntegProg1_SW20260720", MINT_L, F(9), "MiddleRight")
    d.dock("pnlTop", "Top", 760, 64); d.dock("pnlBottom", "Bottom", 760, 36)
    d.reparent("lblAuthor", "pnlBottom")
    lab(d, "lblAuthor", 24, 8, 712, 20, 9, False, MUTED, "MiddleRight")
    d.order("FORM", ["TabControl1", "pnlBottom", "pnlTop"])
    d.place("TabControl1", 16, 76, 728, 396)
    tw, th = 720, 370
    for p in ("tabInterest", "tabSquare", "tabClassAverage", "tabDecimalEquivalent", "TabPage1"):
        d.set(p, "Size", "New System.Drawing.Size(%d, %d)" % (tw, th))
        d.back(p, CARD); d.set(p, "UseVisualStyleBackColor", "False")
    d.place("TabControl2", 8, 8, 704, 354)
    for p in ("TabPage2", "TabPage3", "TabPage4"):
        d.set(p, "Size", "New System.Drawing.Size(696, 328)"); d.back(p, CARD); d.set(p, "UseVisualStyleBackColor", "False")
    def cap(n, x, y, w=200):
        lab(d, n, x, y, w, 20, 10, False, MUTED)
    def box(n, x, y, w, h=28):
        d.place(n, x, y, w, h); d.font(n, FAM, 11)
    cap("principalLabel", 20, 16); box("principalTextBox", 20, 40, 200)
    cap("interestRateLabel", 240, 16); box("interestRateTextBox", 240, 40, 200)
    cap("yearsLabel", 460, 16, 120); box("yearsNumericUpDown", 460, 40, 120)
    d.place("calculateButton", 600, 38, 100, 32)
    cap("balancesLabel", 20, 90); d.place("resultsListBox", 20, 112, 680, 236); d.font("resultsListBox", FAM, 11)
    cap("fillCharacterLabel", 20, 16, 220); box("fillCharacterTextBox", 20, 40, 100)
    cap("sideLengthLabel", 160, 16, 220); box("sideLengthNumericUpDown", 160, 40, 100)
    d.place("displaySquareButton", 290, 38, 150, 32)
    d.place("outputTextBox", 20, 90, 680, 258)
    cap("gradeLabel", 20, 16); box("gradeTextBox", 20, 40, 170)
    d.place("submitGradeButton", 204, 38, 120, 32)
    cap("gradesLabel", 20, 90); d.place("gradesListBox", 20, 112, 304, 150); d.font("gradesListBox", FAM, 11)
    d.place("calculateAverageButton", 20, 276, 148, 34); d.place("clearGradesButton", 176, 276, 148, 34)
    d.place("classAverageLabel", 348, 112, 352, 198); d.back("classAverageLabel", ALT)
    d.font("classAverageLabel", FAM, 14, True); d.fore("classAverageLabel", MINT_L); d.align("classAverageLabel", "MiddleCenter")
    d.place("decimalOutputTextBox", 16, 16, 688, 338)
    buttons(d, {"calculateButton": "p", "displaySquareButton": "p", "submitGradeButton": "p",
                "calculateAverageButton": "m", "clearGradesButton": "n"})
    inputs_dark(d)
    d.save()

# =========================================================================================
def act8():
    d = Designer(find("Act8_SW20260805/TheMessage/Form1.Designer.vb"))
    formprops(d, 1080, 600)
    d.back("pnlHeader", CHROME); d.dock("pnlHeader", "Left", 250, 600)
    d.panel("pnlRuleA", "pnlHeader", 24, 30, 44, 4, MINT)
    lab(d, "lblHeaderTitle", 24, 46, 206, 40, 23, True, TEXT)
    lab(d, "lblHeaderSub", 24, 98, 206, 80, 9, False, MINT_L)
    lab(d, "lblAuthor", 24, 504, 206, 44, 10.5, True, TEXT, "TopLeft")
    d.back("pnlActions", CHROME); d.dock("pnlActions", "Right", 180, 600)
    d.place("btnDisplay", 20, 40, 140, 48); d.place("btnClear", 20, 100, 140, 40); d.place("btnExit", 20, 152, 140, 40)
    lab(d, "lblStatus", 16, 330, 150, 150, 9, False, MUTED)
    # compose card
    d.place("pnlCompose", 274, 24, 618, 232)
    lab(d, "lblComposeTitle", 18, 12, 300, 18, 9, True, MUTED)
    lab(d, "lblTitleCaption", 18, 40, 200, 20, 10, False, TEXT2)
    d.place("txtTitle", 18, 62, 580, 30); d.font("txtTitle", FAM, 12)
    lab(d, "lblMessageCaption", 18, 100, 200, 20, 10, False, TEXT2)
    d.place("txtMessage", 18, 122, 580, 70); d.font("txtMessage", FAM, 11)
    lab(d, "lblComposeNote", 18, 196, 580, 30, 8, False, MUTED)
    cards = (("pnlIcons", "lblIconsTitle", ("rbInfo", "rbWarning", "rbQuestion", "rbCritical")),
             ("pnlButtons", "lblButtonsTitle", ("rbOk", "rbOkCancel", "rbYesNo", "rbYesNoCancel", "rbRetryCancel", "rbAbortRetryIgnore")),
             ("pnlDefault", "lblDefaultTitle", ("rbDefault1", "rbDefault2", "rbDefault3")))
    for i, (pn, tt, rbs) in enumerate(cards):
        d.place(pn, 274 + i * 210, 276, 198, 292)
        lab(d, tt, 16, 12, 170, 18, 9, True, MINT_L)
        for j, rb in enumerate(rbs):
            d.place(rb, 16, 46 + j * 38, 168, 26); d.font(rb, FAM, 10.5)
    buttons(d, {"btnDisplay": "p", "btnClear": "n", "btnExit": "x"})
    inputs_dark(d)
    d.save()

ALL = [act4, act5, act6, act7, act8]

# =========================================================================================
def old_texts(path):
    t = open(path, "rb").read().decode("utf-8-sig")
    title = re.search(r'Me\.Text\s*=\s*"([^"]*)"', t)
    auth = re.search(r'Me\.lblAuthor\.Text\s*=\s*"([^"]*)"', t)
    return (title.group(1) if title else ""), (auth.group(1) if auth else "")

def act9():
    path = find("SW202609301600/ListViewSample.Designer.vb")
    title, auth = old_texts(path)
    cs = [
        C("pnlPath", "Panel", None, 194, 40, 730, 66, BackColor=rgb(ALT), BorderStyle=_enum("BorderStyle", "FixedSingle")),
        C("lblPathCaption", "Label", "pnlPath", 16, 8, 300, 18, text="CURRENT FOLDER", AutoSize="False"),
        C("txtPath", "TextBox", "pnlPath", 16, 30, 698, 23),
        C("lv", "ListView", None, 194, 120, 730, 424, View=_enum("View", "Details"), FullRowSelect="True", GridLines="False",
          HideSelection="False", BorderStyle=_enum("BorderStyle", "FixedSingle"),
          Columns__Add='("Name", 300)'),
        C("lbl", "Label", None, 194, 556, 560, 22, AutoSize="False", text="0 item(s)"),
        C("pnlRail", "Panel", None, 0, 24, 170, 576, BackColor=rgb(CHROME), Dock=_enum("DockStyle", "Left")),
        C("pnlRuleR", "Panel", "pnlRail", 18, 26, 40, 4, BackColor=rgb(MINT)),
        C("lblRailTitle", "Label", "pnlRail", 18, 40, 140, 56, text="ListView File Explorer", AutoSize="False"),
        C("lblRailSub", "Label", "pnlRail", 18, 100, 138, 48, text="Browse a folder in Details or List view.", AutoSize="False"),
        C("browse", "Button", "pnlRail", 16, 170, 138, 40, text="Browse..."),
        C("btnRefresh", "Button", "pnlRail", 16, 218, 138, 40, text="Refresh"),
        C("details", "Button", "pnlRail", 16, 266, 138, 40, text="Details"),
        C("list", "Button", "pnlRail", 16, 314, 138, 40, text="List"),
        C("lblAuthor", "Label", "pnlRail", 18, 480, 138, 70, text=auth, AutoSize="False"),
        C("menuStrip1", "MenuStrip", None, 0, 0, 940, 24),
        C("menuForms", "ToolStripMenuItem", "menuStrip1", text="Forms"),
        C("menuList", "ToolStripMenuItem", "menuForms", text="ListView File Explorer"),
        C("menuTree", "ToolStripMenuItem", "menuForms", text="TreeView File Explorer"),
        C("menuOpen", "ToolStripMenuItem", "menuForms", text="OpenFileDialog File Explorer"),
        C("menuCombined", "ToolStripMenuItem", "menuForms", text="Combined File Explorer"),
        C("menuExit", "ToolStripMenuItem", "menuForms", text="Exit"),
    ]
    # columns: the extra two are written as separate statements after the first one
    for c in cs:
        if c.name == "lv":
            c.props = [(k, v) for k, v in c.props if k != "Columns.Add"]
            c.props += [("Columns.Add", '("Name", 300)')]
    gen(path, "ListViewSample", cs, [("MainMenuStrip", "Me.menuStrip1"), ("BackColor", rgb(PAGE))], (940, 600), title)
    # Columns.Add is a call, so patch the three calls in as statements
    t = open(path, "rb").read().decode("utf-8-sig")
    t = t.replace('        Me.lv.Columns.Add = ("Name", 300)\r\n',
                  '        Me.lv.Columns.Add("Name", 300)\r\n        Me.lv.Columns.Add("Type", 150)\r\n        Me.lv.Columns.Add("Modified/Size", 200)\r\n')
    open(path, "wb").write(b"\xef\xbb\xbf" + t.encode("utf-8"))
    d = Designer(path)
    d.anchor("lv", "TBLR")
    lab(d, "lblRailTitle", 18, 40, 140, 56, 15, True, TEXT, "TopLeft")
    lab(d, "lblRailSub", 18, 100, 138, 48, 9, False, MUTED, "TopLeft")
    lab(d, "lblPathCaption", 16, 8, 300, 18, 9, True, MUTED, "TopLeft")
    lab(d, "lblAuthor", 18, 478, 138, 70, 9, False, MUTED, "TopLeft")
    lab(d, "lbl", 194, 556, 560, 22, 9, False, MUTED, "MiddleLeft")
    d.font("txtPath", FAM, 11); d.font("lv", FAM, 10)
    for n in ("browse", "btnRefresh", "details", "list"):
        d.font(n, FAM, 10, True)
    buttons(d, {"browse": "p", "btnRefresh": "m", "details": "n", "list": "n"})
    for n in ("menuStrip1",):
        d.back(n, CHROME); d.fore(n, TEXT)
    for n in ("menuForms", "menuList", "menuTree", "menuOpen", "menuCombined", "menuExit"):
        d.fore(n, TEXT); d.back(n, CHROME)
    inputs_dark(d)
    d.save()

ALL.append(act9)

# =========================================================================================
def _anchor(d, n, letters):
    d.anchor(n, letters)

def _side_title(cs, panel, title, sub, ty=40, sy=100):
    cs += [C("pnlRule_" + panel, "Panel", panel, 20, 26, 40, 4, BackColor=rgb(MINT)),
           C("lblTitle_" + panel, "Label", panel, 20, ty, 180, 56, AutoSize="False", text=title),
           C("lblSub_" + panel, "Label", panel, 20, sy, 176, 70, AutoSize="False", text=sub)]

def _style_side(d, panel, ty=40, sy=100, tw=180, th=56, sh=70):
    lab(d, "lblTitle_" + panel, 20, ty, tw, th, 15, True, TEXT, "TopLeft")
    lab(d, "lblSub_" + panel, 20, sy, tw - 4, sh, 9, False, MUTED, "TopLeft")

def act11():
    base = "SW202610021600/"
    D = rgb
    # ---------------------------------------------------------------- TreeViewSample (controls left, tree right)
    path = find(base + "TreeViewSample.Designer.vb")
    cs = [C("tree", "TreeView", None, 220, 72, 660, 488, Dock=_enum("DockStyle", "Fill"), BorderStyle=_enum("BorderStyle", "None")),
          C("pnlInfo", "Panel", None, 220, 0, 660, 72, Dock=_enum("DockStyle", "Top"), BackColor=D(ALT)),
          C("lblPathCaption", "Label", "pnlInfo", 20, 12, 300, 18, AutoSize="False", text="SELECTED PATH"),
          C("selectedPath", "TextBox", "pnlInfo", 20, 36, 620, 23, ReadOnly="True"),
          C("pnlSide", "Panel", None, 0, 0, 220, 560, Dock=_enum("DockStyle", "Left"), BackColor=D(CHROME))]
    _side_title(cs, "pnlSide", "TreeView File Explorer", "Expand a drive or a folder, then select a node to see its full path.")
    cs += [C("btnRefresh", "Button", "pnlSide", 20, 196, 180, 42, text="Refresh")]
    gen(path, "TreeViewSample", cs, [("BackColor", D(PAGE))], (880, 560), "Question 7 - TreeView File Explorer")
    d = Designer(path)
    _style_side(d, "pnlSide", 40, 108, 180, 60, 80)
    lab(d, "lblPathCaption", 20, 12, 300, 18, 9, True, MUTED, "TopLeft")
    d.font("selectedPath", FAM, 11); d.anchor("selectedPath", "TLR")
    d.font("btnRefresh", FAM, 10, True); buttons(d, {"btnRefresh": "p"}); inputs_dark(d); d.save()

    # ---------------------------------------------------------------- OpenFileDialogSample (vertical rail left)
    path = find(base + "OpenFileDialogSample.Designer.vb")
    cs = [C("selected", "ListBox", None, 200, 56, 600, 464, Dock=_enum("DockStyle", "Fill"), BorderStyle=_enum("BorderStyle", "None"),
            ItemHeight="19"),
          C("pnlTop", "Panel", None, 200, 0, 600, 56, Dock=_enum("DockStyle", "Top"), BackColor=D(ALT)),
          C("lblHead", "Label", "pnlTop", 20, 18, 400, 22, AutoSize="False", text="SELECTED FILES"),
          C("pnlRail", "Panel", None, 0, 0, 200, 520, Dock=_enum("DockStyle", "Left"), BackColor=D(CHROME))]
    _side_title(cs, "pnlRail", "OpenFileDialog", "Pick one file or many files. Your selection is listed on the right.")
    cs += [C("one", "Button", "pnlRail", 20, 190, 160, 44, text="Open one..."),
           C("many", "Button", "pnlRail", 20, 242, 160, 44, text="Open multiple..."),
           C("clear", "Button", "pnlRail", 20, 294, 160, 44, text="Clear")]
    gen(path, "OpenFileDialogSample", cs, [("BackColor", D(PAGE))], (800, 520), "Question 8 - OpenFileDialog")
    d = Designer(path)
    _style_side(d, "pnlRail", 40, 108, 160, 60, 70)
    lab(d, "lblHead", 20, 18, 400, 22, 10, True, MINT_L, "TopLeft")
    d.font("selected", FAM, 11)
    for n in ("one", "many", "clear"):
        d.font(n, FAM, 10, True)
    buttons(d, {"one": "p", "many": "m", "clear": "n"}); inputs_dark(d); d.save()

    # ---------------------------------------------------------------- CombinedSample (button bar at the bottom)
    path = find(base + "CombinedSample.Designer.vb")
    cs = [C("lv", "ListView", None, 280, 56, 680, 460, Dock=_enum("DockStyle", "Fill"), View=_enum("View", "Details"),
            FullRowSelect="True", HideSelection="False", BorderStyle=_enum("BorderStyle", "None")),
          C("tree", "TreeView", None, 0, 56, 280, 460, Dock=_enum("DockStyle", "Left"), BorderStyle=_enum("BorderStyle", "None")),
          C("pnlBar", "Panel", None, 0, 516, 960, 64, Dock=_enum("DockStyle", "Bottom"), BackColor=D(CHROME)),
          C("open", "Button", "pnlBar", 20, 12, 130, 40, text="Open file"),
          C("save", "Button", "pnlBar", 160, 12, 130, 40, text="Save As"),
          C("btnRefresh", "Button", "pnlBar", 300, 12, 120, 40, text="Refresh"),
          C("pnlHead", "Panel", None, 0, 0, 960, 56, Dock=_enum("DockStyle", "Top"), BackColor=D(ALT)),
          C("pnlHeadRule", "Panel", "pnlHead", 20, 14, 4, 28, BackColor=D(MINT)),
          C("lblHead", "Label", "pnlHead", 34, 14, 320, 28, AutoSize="False", text="Combined Explorer"),
          C("lblHeadHint", "Label", "pnlHead", 360, 18, 400, 20, AutoSize="False", text="Folders on the left, folder contents on the right.")]
    gen(path, "CombinedSample", cs, [("BackColor", D(PAGE))], (960, 580), "Question 9 - Combined Explorer")
    t = open(path, "rb").read().decode("utf-8-sig")
    t = t.replace('        Me.lv.Name = "lv"\r\n', '        Me.lv.Columns.Add("Name", 300)\r\n        Me.lv.Columns.Add("Type", 150)\r\n        Me.lv.Name = "lv"\r\n', 1)
    open(path, "wb").write(b"\xef\xbb\xbf" + t.encode("utf-8"))
    d = Designer(path)
    lab(d, "lblHead", 34, 12, 320, 32, 15, True, TEXT, "MiddleLeft")
    lab(d, "lblHeadHint", 360, 18, 400, 20, 9, False, MUTED, "MiddleLeft")
    d.font("lv", FAM, 10)
    for n in ("open", "save", "btnRefresh"):
        d.font(n, FAM, 10, True)
    buttons(d, {"open": "p", "save": "m", "btnRefresh": "n"}); inputs_dark(d); d.save()

    # ---------------------------------------------------------------- ListViewSample (toolbar at the bottom)
    path = find(base + "ListViewSample.Designer.vb")
    cs = [C("lv", "ListView", None, 0, 56, 900, 444, Dock=_enum("DockStyle", "Fill"), View=_enum("View", "Details"),
            FullRowSelect="True", GridLines="False", HideSelection="False", BorderStyle=_enum("BorderStyle", "None")),
          C("pnlTop", "Panel", None, 0, 0, 900, 56, Dock=_enum("DockStyle", "Top"), BackColor=D(ALT)),
          C("txtPath", "TextBox", "pnlTop", 20, 17, 860, 23),
          C("pnlBottom", "Panel", None, 0, 500, 900, 60, Dock=_enum("DockStyle", "Bottom"), BackColor=D(CHROME)),
          C("browse", "Button", "pnlBottom", 16, 10, 112, 40, text="Browse..."),
          C("btnRefresh", "Button", "pnlBottom", 136, 10, 112, 40, text="Refresh"),
          C("details", "Button", "pnlBottom", 256, 10, 100, 40, text="Details"),
          C("list", "Button", "pnlBottom", 364, 10, 100, 40, text="List"),
          C("lbl", "Label", "pnlBottom", 500, 20, 380, 22, AutoSize="False", text="0 item(s)")]
    gen(path, "ListViewSample", cs, [("BackColor", D(PAGE))], (900, 560), "Question 6 - ListView File Explorer")
    t = open(path, "rb").read().decode("utf-8-sig")
    t = t.replace('        Me.lv.Name = "lv"\r\n', '        Me.lv.Columns.Add("Name", 300)\r\n        Me.lv.Columns.Add("Type", 150)\r\n        Me.lv.Columns.Add("Modified/Size", 200)\r\n        Me.lv.Name = "lv"\r\n', 1)
    open(path, "wb").write(b"\xef\xbb\xbf" + t.encode("utf-8"))
    d = Designer(path)
    d.anchor("txtPath", "TLR"); d.anchor("lbl", "TR")
    lab(d, "lbl", 500, 19, 380, 22, 9, False, MUTED, "MiddleRight")
    d.font("txtPath", FAM, 11); d.font("lv", FAM, 10)
    for n in ("browse", "btnRefresh", "details", "list"):
        d.font(n, FAM, 10, True)
    buttons(d, {"browse": "p", "btnRefresh": "m", "details": "n", "list": "n"}); inputs_dark(d); d.save()

    # ---------------------------------------------------------------- MenuForm / MainForm (code-built)
    p = find(base + "MenuForm.vb")
    t, bom = rd(p)
    t = t.replace("{treeMenu, openMenu, combinedMenu, exitMenu})", "{openMenu, combinedMenu, treeMenu, exitMenu})")
    t = t.replace("        menuStrip1.Dock = DockStyle.Top\n",
        "        menuStrip1.Dock = DockStyle.Top\n"
        "        menuStrip1.BackColor = Color.FromArgb(10, 12, 16)\n"
        "        menuStrip1.ForeColor = Color.FromArgb(236, 239, 244)\n"
        "        Me.BackColor = Color.FromArgb(17, 19, 25)\n"
        "        lblHeading = New Label()\n"
        "        lblHeading.AutoSize = False\n"
        "        lblHeading.SetBounds(40, 72, 640, 44)\n"
        "        lblHeading.Font = New Font(\"Corbel\", 22.0F, FontStyle.Bold)\n"
        "        lblHeading.ForeColor = Color.FromArgb(236, 239, 244)\n"
        "        lblHeading.Text = \"Windows Forms Controls\"\n"
        "        lblSubheading = New Label()\n"
        "        lblSubheading.AutoSize = False\n"
        "        lblSubheading.SetBounds(40, 120, 640, 44)\n"
        "        lblSubheading.Font = New Font(\"Corbel\", 10.0F)\n"
        "        lblSubheading.ForeColor = Color.FromArgb(52, 211, 153)\n"
        "        lblSubheading.Text = \"File explorer demos: OpenFileDialog, the combined explorer and the TreeView.\"\n"
        "        Me.Controls.Add(lblHeading)\n"
        "        Me.Controls.Add(lblSubheading)\n", 1)
    t = t.replace("    Private exitMenu As ToolStripMenuItem\n", "    Private exitMenu As ToolStripMenuItem\n    Private lblHeading As Label\n    Private lblSubheading As Label\n", 1)
    wr(p, t, bom)
    p = find(base + "MainForm.vb")
    t, bom = rd(p)
    t = t.replace("        statusBar.ForeColor = Color.FromArgb(141, 152, 170)\n",
                  "        statusBar.ForeColor = Color.FromArgb(141, 152, 170)\n        statusBar.BackColor = Color.FromArgb(10, 12, 16)\n", 1)
    t = t.replace("        text.ReadOnly = True\n", "        text.ReadOnly = True\n        text.BackColor = Color.FromArgb(12, 14, 19)\n        text.ForeColor = Color.FromArgb(236, 239, 244)\n        text.BorderStyle = BorderStyle.None\n", 1)
    wr(p, t, bom)
    # picture source of MenuForm
    p = os.path.join(ROOT, "tools/figure_sources/MenuForm.Designer.vb")
    t, bom = rd(p)
    t = t.replace("{Me.treeMenu, Me.openMenu, Me.combinedMenu, Me.exitMenu})", "{Me.openMenu, Me.combinedMenu, Me.treeMenu, Me.exitMenu})")
    t = t.replace("        Me.menuStrip1.Name = \"menuStrip1\"\n",
        "        Me.menuStrip1.Name = \"menuStrip1\"\n        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)\n        Me.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)\n", 1)
    t = t.replace("        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()\n",
        "        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()\n        Me.lblHeading = New System.Windows.Forms.Label()\n        Me.lblSubheading = New System.Windows.Forms.Label()\n", 1)
    t = t.replace("        '\n        'MenuForm\n        '\n",
        "        '\n        'lblHeading\n        '\n        Me.lblHeading.AutoSize = False\n        Me.lblHeading.Font = New System.Drawing.Font(\"Corbel\", 22.0!, System.Drawing.FontStyle.Bold)\n"
        "        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)\n        Me.lblHeading.Location = New System.Drawing.Point(40, 72)\n        Me.lblHeading.Name = \"lblHeading\"\n"
        "        Me.lblHeading.Size = New System.Drawing.Size(640, 44)\n        Me.lblHeading.Text = \"Windows Forms Controls\"\n"
        "        '\n        'lblSubheading\n        '\n        Me.lblSubheading.AutoSize = False\n        Me.lblSubheading.Font = New System.Drawing.Font(\"Corbel\", 10.0!)\n"
        "        Me.lblSubheading.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153)\n        Me.lblSubheading.Location = New System.Drawing.Point(40, 120)\n        Me.lblSubheading.Name = \"lblSubheading\"\n"
        "        Me.lblSubheading.Size = New System.Drawing.Size(640, 44)\n        Me.lblSubheading.Text = \"File explorer demos: OpenFileDialog, the combined explorer and the TreeView.\"\n"
        "        '\n        'MenuForm\n        '\n        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)\n", 1)
    t = t.replace("        Me.Controls.Add(Me.menuStrip1)\n", "        Me.Controls.Add(Me.lblHeading)\n        Me.Controls.Add(Me.lblSubheading)\n        Me.Controls.Add(Me.menuStrip1)\n", 1)
    t = t.replace("    Friend WithEvents exitMenu As System.Windows.Forms.ToolStripMenuItem\n",
                  "    Friend WithEvents exitMenu As System.Windows.Forms.ToolStripMenuItem\n    Friend WithEvents lblHeading As System.Windows.Forms.Label\n    Friend WithEvents lblSubheading As System.Windows.Forms.Label\n", 1)
    wr(p, t, bom)

ALL.append(act11)

# =========================================================================================
def act10():
    base = "SW20261002/PanelSplitPanelDemo/"
    # ------------------------------------------------------------------ Form1 : panel playground
    d = Designer(find(base + "Form1.Designer.vb"))
    f = formprops(d, 1000, 680)
    d.back("pnlRail", CHROME); d.dock("pnlRail", "Top", 1000, 76)
    d.back("pnlMain", PAGE); d.dock("pnlMain", "Fill")
    d.back("pnlStatus", CHROME)
    lab(d, "lblRailBadge", 24, 12, 120, 14, 8.25, True, MINT, "TopLeft")
    d.back("pnlRailRule", MINT); d.place("pnlRailRule", 24, 66, 60, 3)
    lab(d, "lblRailTitle", 24, 28, 320, 34, 17, True, TEXT, "TopLeft")
    lab(d, "lblRailAuthor", 380, 18, 280, 22, 11, True, TEXT, "TopLeft")
    lab(d, "lblRailCourse", 380, 42, 280, 18, 9, False, MUTED, "TopLeft")
    d.place("btnNavPanel", 690, 18, 130, 40); d.place("btnNavSplit", 830, 18, 140, 40)
    d.set("btnNavPanel", "Anchor", "CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)")
    d.set("btnNavSplit", "Anchor", "CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)")
    d.reparent("lblRailHint", "pnlInspector")
    lab(d, "lblRailHint", 16, 232, 456, 32, 8.25, False, MUTED, "TopLeft")
    # heading
    lab(d, "lblHeading", 24, 10, 440, 32, 17, True, TEXT)
    lab(d, "lblSub", 24, 44, 440, 18, 9, False, MINT_L)
    # left column
    d.place("pnlWorkspace", 24, 70, 440, 470); d.back("pnlWorkspace", CARD); d.set("pnlWorkspace", "BorderStyle", NOB)
    lab(d, "lblWorkspaceTitle", 14, 8, 400, 16, 8.5, True, MUTED)
    d.place("pnlGroup", 14, 30, 412, 206); d.back("pnlGroup", ALT)
    lab(d, "lblGroupTitle", 12, 8, 380, 16, 8.5, True, MINT_L)
    lab(d, "lblNameCaption", 12, 34, 200, 16, 9, False, TEXT2)
    d.place("txtName", 12, 52, 388, 26); d.font("txtName", FAM, 10.5)
    lab(d, "lblCourseCaption", 12, 86, 200, 16, 9, False, TEXT2)
    d.place("txtCourse", 12, 104, 388, 26); d.font("txtCourse", FAM, 10.5)
    d.place("btnSave", 12, 142, 388, 34)
    lab(d, "lblGroupHint", 12, 182, 388, 18, 8.25, False, MUTED)
    d.place("pnlNested", 14, 246, 412, 210); d.back("pnlNested", ALT)
    lab(d, "lblNestedTitle", 12, 8, 380, 16, 8.5, True, MINT_L)
    lab(d, "lblNestedNote", 12, 30, 388, 66, 9.5, False, TEXT2)
    lab(d, "lblNestedBadge", 12, 104, 388, 34, 10.5, True, TEXT)
    lab(d, "lblNestedHint", 12, 148, 388, 40, 8.25, False, MUTED)
    # right column
    d.place("pnlInspector", 488, 70, 488, 272); d.back("pnlInspector", CARD)
    lab(d, "lblInspectorTitle", 14, 8, 440, 16, 8.5, True, MUTED)
    names = ["btnToggleGroup", "btnSwapColor", "btnCycleBorder", "btnBringFront", "btnSendBack",
             "btnContains", "btnFocusPanel", "btnRedraw", "btnDisposeDemo"]
    for i, n in enumerate(names):
        col, row = i % 2, i // 2
        d.place(n, 16 + col * 236, 32 + row * 40, 224, 32)
    d.place("pnlLog", 488, 352, 488, 188); d.back("pnlLog", CARD)
    lab(d, "lblLogTitle", 14, 8, 300, 16, 8.5, True, MUTED)
    d.place("lstLog", 16, 28, 456, 150); d.font("lstLog", FAM, 9.5)
    lab(d, "lblStatus", 16, 8, 400, 16, 9, False, MUTED)
    lab(d, "lblCounter", 640, 8, 300, 16, 9, False, MINT_L, "MiddleRight")
    d.place("lblCounter", 676, 8, 300, 16)
    d.anchor("lblCounter", "TR")
    kinds = {n: "m" for n in names}
    kinds.update({"btnToggleGroup": "p", "btnDisposeDemo": "x", "btnSave": "p", "btnNavPanel": "p", "btnNavSplit": "n"})
    buttons(d, kinds)
    d.order("FORM", ["pnlMain", "pnlStatus", "pnlRail", "menuMain"])
    d.back("menuMain", CHROME); d.fore("menuMain", TEXT); d.fore("mnuDemo", TEXT)
    inputs_dark(d)
    d.save()

    # ------------------------------------------------------------------ Form2 : split container lab
    d = Designer(find(base + "Form2.Designer.vb"))
    f = formprops(d, 1000, 630)
    d.back("pnlTop", CHROME); d.dock("pnlTop", "Top", 1000, 66)
    lab(d, "lblTitle", 24, 8, 300, 32, 17, True, TEXT)
    lab(d, "lblSub", 26, 42, 620, 18, 9, False, MINT_L)
    lab(d, "lblAuthor", 700, 22, 276, 22, 11, True, TEXT, "MiddleRight")
    d.back("pnlTools", CHROME); d.dock("pnlTools", "Left", 176, 434)
    btns = ["btnCollapseLeft", "btnCollapseTop", "btnSwapOrientation", "btnLock", "btnReset", "btnExit"]
    for i, n in enumerate(btns):
        d.place(n, 16, 22 + i * 50, 144, 38)
    lab(d, "lblSplitInfo", 16, 336, 144, 70, 9, False, MINT_L, "TopLeft")
    buttons(d, {"btnCollapseLeft": "m", "btnCollapseTop": "m", "btnSwapOrientation": "v", "btnLock": "a", "btnReset": "n", "btnExit": "x"})
    d.back("pnlStatus", CHROME)
    lab(d, "lblStatus", 14, 7, 600, 16, 9, False, MUTED)
    lab(d, "lblCount", 700, 7, 284, 16, 9, False, MINT_L, "MiddleRight")
    d.anchor("lblCount", "TR")
    for sp in ("splOuter", "splInner"):
        d.back(sp, LINE)
    d.dock("splOuter", "Fill")
    for p in ("pnlLeft", "pnlTopPane", "pnlBottomPane"):
        d.back(p, CARD)
    for l in ("lblLeftTitle", "lblRecordsTitle", "lblDetailTitle"):
        d.fore(l, MINT_L); d.back(l, CARD2); d.font(l, FAM, 8.5, True)
    d.back("lstCategories", INPUT); d.back("lvRecords", INPUT); d.back("txtDetails", INPUT)
    d.font("lstCategories", FAM, 10.5); d.font("txtDetails", FAM, 10)
    d.order("FORM", ["splOuter", "pnlTools", "pnlStatus", "pnlTop", "menuMain"])
    d.back("menuMain", CHROME); d.fore("menuMain", TEXT); d.fore("mnuLab", TEXT)
    inputs_dark(d)
    d.save()

ALL.append(act10)

# =========================================================================================
def act12():
    d = Designer(find("FileExplorerClone/PanelSplitDemo/Form1.Designer.vb"))
    formprops(d, 1200, 720)
    # slim top bar: title left, navigation in the middle, address on the right
    d.back("pnlHeader", CHROME); d.dock("pnlHeader", "Top", 1200, 58)
    lab(d, "lblApp", 20, 8, 270, 28, 14, True, TEXT, "TopLeft")
    lab(d, "lblHeaderSub", 22, 36, 270, 16, 8.5, False, MINT_L, "TopLeft")
    xs = [("btnBack", 300, 62), ("btnForward", 368, 76), ("btnUp", 450, 52), ("btnHome", 508, 62), ("btnRefresh", 576, 80)]
    for n, x, w in xs:
        d.place(n, x, 13, w, 32)
    d.place("txtPath", 672, 17, 426, 24); d.font("txtPath", FAM, 10.5); d.anchor("txtPath", "TLR")
    d.place("btnGo", 1108, 13, 74, 32); d.anchor("btnGo", "TR")
    # the author moves to the status bar
    d.reparent("lblAuthor", "pnlStatus")
    d.back("pnlStatus", CHROME); d.dock("pnlStatus", "Bottom", 1200, 30)
    lab(d, "lblAuthor", 800, 6, 380, 18, 9.5, True, TEXT, "MiddleRight"); d.anchor("lblAuthor", "TR")
    lab(d, "lblStatus", 14, 6, 480, 18, 9, False, MUTED, "MiddleLeft")
    lab(d, "lblCount", 500, 6, 280, 18, 9, False, MINT_L, "MiddleRight")
    # vertical tool rail on the left
    d.back("pnlTools", ALT); d.dock("pnlTools", "Left", 160, 632)
    for i, n in enumerate(("btnTreeToggle", "btnPreviewToggle", "btnSwapLayout", "btnLockSplitters")):
        d.place(n, 12, 24 + i * 50, 136, 38)
    lab(d, "lblSplitInfo", 12, 240, 136, 120, 8.5, False, MINT_L, "TopLeft")
    buttons(d, {"btnBack": "n", "btnForward": "n", "btnUp": "n", "btnHome": "n", "btnRefresh": "m", "btnGo": "p",
                "btnTreeToggle": "m", "btnPreviewToggle": "m", "btnSwapLayout": "v", "btnLockSplitters": "a"})
    d.back("splRoot", LINE); d.back("splWorkspace", LINE)
    for p in ("pnlTreeHost", "pnlListHost", "pnlPreviewHost"):
        d.back(p, CARD)
    d.back("pnlFilterBar", CARD)
    for l in ("lblTreeTitle", "lblListTitle", "lblPreviewTitle"):
        d.fore(l, MINT_L); d.back(l, CARD2); d.font(l, FAM, 8.5, True)
    d.fore("lblFilterCaption", MUTED); d.place("txtFilter", 520, 3, 250, 23)
    d.font("lvFiles", FAM, 10); d.font("txtFilter", FAM, 9.5); d.font("txtPreview", "Consolas", 9.5)
    d.order("FORM", ["splRoot", "pnlTools", "pnlStatus", "pnlHeader"])
    inputs_dark(d)
    d.save()

ALL.append(act12)

# =========================================================================================
def blockify(path):
    """Give a flat InitializeComponent one comment header per control so Designer can edit it."""
    t, bom = rd(path)
    crlf = "\r\n" in t
    t = t.replace("\r\n", "\n")
    if re.search(r"^        '\n        '\w+\n        '\n", t, re.M):
        return
    cls = re.search(r"Partial Class (\w+)", t).group(1)
    out, started, cur, formhdr, tail = [], False, None, False, False
    for ln in t.split("\n"):
        if not started:
            out.append(ln)
            if ln.strip() == "Me.SuspendLayout()":
                started = True
            continue
        if tail:
            out.append(ln); continue
        if re.match(r"^        (Me\.\w+\.(Resume|Perform)Layout|Me\.(Resume|Perform)Layout|CType\(Me\.\w+, System\.ComponentModel\.ISupportInitialize\)\.EndInit)", ln):
            tail = True; out.append(ln); continue
        m = re.match(r"^        Me\.(\w+)\.", ln)
        if formhdr:
            name = cls
        elif ln.startswith("        Me.AutoScaleDimensions") or (m is None and ln.startswith("        Me.")) or (m and m.group(1) == "Controls"):
            name = cls; formhdr = True
        elif m is None:
            out.append(ln); continue
        else:
            name = m.group(1)
        if name != cur:
            out += ["        '", "        '%s" % name, "        '"]; cur = name
        out.append(ln)
    t = "\n".join(out)
    if crlf:
        t = t.replace("\n", "\r\n")
    wr(path, t, bom)

GRID_STYLE = [("EnableHeadersVisualStyles", "False"), ("BorderStyle", "System.Windows.Forms.BorderStyle.None"),
              ("GridColor", rgb(LINE)),
              ("ColumnHeadersDefaultCellStyle.BackColor", rgb((30, 36, 48))), ("ColumnHeadersDefaultCellStyle.ForeColor", rgb(MINT_L)),
              ("DefaultCellStyle.BackColor", rgb(INPUT)), ("DefaultCellStyle.ForeColor", rgb(TEXT)),
              ("DefaultCellStyle.SelectionBackColor", rgb(MINT_D)), ("DefaultCellStyle.SelectionForeColor", rgb((255, 255, 255))),
              ("AlternatingRowsDefaultCellStyle.BackColor", rgb(ALT))]

def crud(fname, cols):
    path = find("IntegProgProject2026/IntegProgProject2026/Forms/" + fname)
    blockify(path)
    d = Designer(path)
    W = 1006
    f = d.form_name()
    d.set(f, "BackColor", rgb(PAGE))
    # records grid on top, full width
    d.place("grpRecords", 12, 10, 982, 238); d.back("grpRecords", CARD); d.fore("grpRecords", MINT_L); d.font("grpRecords", FAM, 9.5, True)
    d.place("dataGridView1", 12, 26, 958, 200); d.anchor("dataGridView1", "TBLR"); d.back("dataGridView1", INPUT)
    d.font("dataGridView1", FAM, 9.5)
    for k, v in GRID_STYLE:
        d.set("dataGridView1", k, v)
    # details: label above input in a grid
    kids = d.children("grpDetails")
    pairs = [(kids[i], kids[i + 1]) for i in range(0, len(kids) - 1, 2)]
    rows = (len(pairs) + cols - 1) // cols
    gh = 30 + rows * 54 + 6
    d.place("grpDetails", 12, 258, 982, gh); d.back("grpDetails", CARD); d.fore("grpDetails", MINT_L); d.font("grpDetails", FAM, 9.5, True)
    cw = (982 - 24) // cols
    for i, (lb, ip) in enumerate(pairs):
        r, c = divmod(i, cols)
        x, y = 14 + c * cw, 26 + r * 54
        lab(d, lb, x, y, cw - 24, 16, 9, False, TEXT2, "TopLeft")
        d.place(ip, x, y + 18, cw - 24, 24); d.font(ip, FAM, 10.5)
    by = 258 + gh + 10
    for i, (n, k) in enumerate((("addButton", "p"), ("updateButton", "m"), ("deleteButton", "x"), ("clearButton", "n"), ("exitButton", "n"))):
        d.place(n, 12 + i * 130, by, 120, 36); d.font(n, FAM, 10, True)
        btn(d, n, k)
    lab(d, "lblDatabase", 12, by + 46, 982, 18, 9, False, MUTED, "MiddleLeft")
    d.anchor("lblDatabase", "BL")
    # z-order: grids first so tab order stays top-down
    d.set(f, "ClientSize", "New System.Drawing.Size(%d, %d)" % (W, by + 46 + 18 + 16))
    inputs_dark(d)
    d.save()

def act13():
    crud("frmSchedules.Designer.vb", 3)
    crud("frmQuotes.Designer.vb", 3)
    crud("frmBibleVerses.Designer.vb", 4)
    base = "IntegProgProject2026/IntegProgProject2026/Forms/"
    # ---------------------------------------------------------------- frmMain
    path = find(base + "frmMain.Designer.vb")
    blockify(path)
    d = Designer(path)
    d.set("frmMain", "BackColor", rgb(PAGE))
    s, e = d.span("MenuStrip1")
    seg = d.t[s:e]
    seg = re.sub(r"\{Me\.SchedulesToolStripMenuItem, Me\.AboutToolStripMenuItem, Me\.QuotesToolStripMenuItem, Me\.BibleVerseToolStripMenuItem, Me\.ExitToolStripMenuItem\}",
                 "{Me.AboutToolStripMenuItem, Me.BibleVerseToolStripMenuItem, Me.SchedulesToolStripMenuItem, Me.QuotesToolStripMenuItem, Me.ExitToolStripMenuItem}", seg)
    d.t = d.t[:s] + seg + d.t[e:]
    d.back("MenuStrip1", CHROME); d.fore("MenuStrip1", TEXT)
    d.back("StatusStrip1", CHROME); d.fore("StatusStrip1", TEXT2)
    d.font("MenuStrip1", FAM, 10)
    d.font("StatusStrip1", FAM, 9)
    d.save()
    # ---------------------------------------------------------------- frmAbout (new composition)
    path = find(base + "frmAbout.Designer.vb")
    blockify(path)
    d = Designer(path)
    d.set("frmAbout", "ClientSize", "New System.Drawing.Size(640, 336)")
    d.set("frmAbout", "BackColor", rgb(PAGE))
    d.panel("pnlRuleAbout", "FORM", 28, 30, 44, 4, MINT)
    d.place("PictureBox1", 412, 28, 200, 200); d.set("PictureBox1", "BorderStyle", NOB); d.back("PictureBox1", CARD)
    lab(d, "lblName", 28, 46, 370, 34, 20, True, TEXT, "TopLeft")
    lab(d, "lblCourse", 28, 92, 370, 20, 10.5, False, MINT_L, "TopLeft")
    lab(d, "lblAddress", 28, 120, 370, 20, 10.5, False, TEXT2, "TopLeft")
    lab(d, "lblSkills", 28, 148, 370, 20, 10.5, False, TEXT2, "TopLeft")
    d.panel("pnlQuote", "FORM", 28, 246, 584, 74, ALT)
    d.panel("pnlQuoteBar", "pnlQuote", 0, 0, 5, 74, MINT)
    d.reparent("lblQuote", "pnlQuote")
    lab(d, "lblQuote", 20, 8, 550, 58, 11, True, TEXT, "MiddleLeft")
    d.order("FORM", ["PictureBox1", "lblName", "lblCourse", "lblAddress", "lblSkills", "pnlRuleAbout", "pnlQuote"])
    d.save()

ALL.append(act13)
