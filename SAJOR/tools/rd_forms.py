# -*- coding: utf-8 -*-
from rd_base import *
from designer_edit import _enum
from rd_gen import gen, C, P, S, Q

NOB = "System.Windows.Forms.BorderStyle.None"
FIXED = "System.Windows.Forms.BorderStyle.FixedSingle"

INK = {   # kind: (fill, text, border)  - the "ink" button style of code 13
    "p": ((30, 27, 75), (199, 210, 254), (99, 102, 241)),
    "c": ((74, 28, 36), (254, 205, 198), (240, 110, 95)),
    "t": ((12, 52, 66), (186, 236, 248), (34, 170, 200)),
    "n": ((48, 48, 66), (224, 226, 240), (150, 152, 182)),
    "x": ((88, 20, 34), (255, 214, 220), (225, 60, 90)),
}


def btn(d, name, kind):
    b, f, bd = INK[kind]
    d.flat(name, b, f, bd, 1)


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


def inputs_light(d):
    for n, k in d.kinds().items():
        if k in ("TextBox", "NumericUpDown", "ComboBox", "DateTimePicker"):
            d.back(n, INPUT); d.fore(n, TEXT)
        if k in ("ListBox", "ListView", "TreeView"):
            d.back(n, WHITE); d.fore(n, TEXT)
        if k == "DataGridView":
            d.set(n, "BackgroundColor", rgb(WHITE))


def formprops(d, w, h, back=PAGE):
    f = d.form_name()
    d.set(f, "ClientSize", "New System.Drawing.Size(%d, %d)" % (w, h))
    d.set(f, "BackColor", rgb(back))
    return f


def card(d, name, x, y, w, h, accent=INDIGO, strip=True, back=WHITE):
    d.place(name, x, y, w, h)
    d.back(name, back)
    d.set(name, "BorderStyle", NOB)
    if strip:
        d.panel("pnlStrip_" + name, name, 0, 0, w, 3, accent)


def anchor(d, names, letters):
    for n in names:
        d.anchor(n, letters)


def headbar(d, name, h, w, back=WHITE, rule=INDIGO):
    """white top bar with a 4 px indigo underline"""
    d.back(name, back)
    d.dock(name, "Top", w, h)
    d.panel("pnlRule_" + name, name, 0, h - 4, w, 4, rule)
    d.anchor("pnlRule_" + name, "BLR")


# =========================================================================================
def act4():
    d = Designer(find("Activity4_20260703/Activity4_20260703/Form1.Designer.vb"))
    formprops(d, 900, 520)
    headbar(d, "pnlBanner", 72, 900)
    lab(d, "lblTitle", 24, 10, 440, 32, 19, True, DEEP, "TopLeft")
    lab(d, "lblSubtitle", 24, 44, 640, 18, 9, False, MUTED, "TopLeft")
    lab(d, "lblAuthorName", 580, 12, 296, 24, 12, True, DEEP, "MiddleRight")
    lab(d, "lblAuthorCourse", 580, 40, 296, 18, 9, False, MUTED, "MiddleRight")
    anchor(d, ("lblAuthorName", "lblAuthorCourse"), "TR")
    # column A : the three inputs stacked
    card(d, "pnlInput", 20, 88, 250, 380, INDIGO)
    lab(d, "lblInputTitle", 16, 14, 218, 18, 9, True, MUTED)
    for i, (cap, txt) in enumerate((("lblFirst", "txtN1"), ("lblSecond", "txtN2"), ("lblThird", "txtN3"))):
        y = 46 + i * 88
        lab(d, cap, 16, y, 218, 18, 10, False, TEXT2)
        d.place(txt, 16, y + 22, 218, 32); d.font(txt, FAM, 13)
    lab(d, "lblInputNote", 16, 316, 218, 48, 8.5, False, MUTED)
    # column B : 2 x 2 tiles + a wide average band
    card(d, "pnlOutput", 286, 88, 328, 380, TEAL)
    lab(d, "lblOutputTitle", 16, 14, 296, 18, 9, True, MUTED)
    for i, (key, cap) in enumerate((("Sum", "Sum"), ("Diff", "Difference"), ("Prod", "Product"), ("Quot", "Quotient"))):
        x, y = 12 + (i % 2) * 156, 40 + (i // 2) * 136
        tile = "pnlTile" + key
        d.panel(tile, "pnlOutput", x, y, 148, 128, TINT)
        d.reparent("lbl%sCaption" % key, tile); d.reparent("lbl%sValue" % key, tile)
        lab(d, "lbl%sCaption" % key, 12, 12, 124, 18, 9.5, True, MUTED)
        lab(d, "lbl%sValue" % key, 4, 48, 140, 60, 18, True, DEEP, "MiddleCenter")
        d.back("lbl%sValue" % key, TINT); d.set("lbl%sValue" % key, "BorderStyle", NOB)
    d.panel("pnlTileAve", "pnlOutput", 12, 316, 304, 52, DEEP)
    d.reparent("lblAveCaption", "pnlTileAve"); d.reparent("lblAveValue", "pnlTileAve")
    lab(d, "lblAveCaption", 14, 16, 110, 20, 10.5, True, PALE)
    lab(d, "lblAveValue", 120, 6, 176, 40, 20, True, WHITE, "MiddleRight")
    d.back("lblAveValue", DEEP); d.set("lblAveValue", "BorderStyle", NOB)
    # column C : the keypad
    card(d, "pnlActions", 630, 88, 250, 380, CORAL)
    d.label("lblActionsTitle", "pnlActions", 16, 14, 218, 18, "OPERATIONS", MUTED, F(9, True))
    for i, n in enumerate(("btnSum", "btnDifference", "btnProduct", "btnQuotient", "btnAverage")):
        d.place(n, 16, 42 + i * 50, 218, 40); d.font(n, FAM, 11, True)
    d.place("btnClear", 16, 306, 104, 44); d.place("btnExit", 130, 306, 104, 44)
    for n in ("btnClear", "btnExit"):
        d.font(n, FAM, 10.5, True)
    buttons(d, {"btnSum": "p", "btnDifference": "p", "btnProduct": "p", "btnQuotient": "p", "btnAverage": "t",
                "btnClear": "n", "btnExit": "x"})
    d.back("pnlFooter", TINT); d.dock("pnlFooter", "Bottom", 900, 36)
    lab(d, "lblStatus", 16, 9, 520, 18, 9.5, False, TEXT2)
    lab(d, "lblFooterAuthor", 580, 9, 304, 18, 9, False, MUTED, "MiddleRight")
    d.anchor("lblFooterAuthor", "TR")
    d.order("FORM", ["pnlInput", "pnlOutput", "pnlActions", "pnlFooter", "pnlBanner"])
    inputs_light(d)
    d.save()


# =========================================================================================
def act5():
    d = Designer(find("Act5/Ternary2/Form1.Designer.vb"))
    formprops(d, 820, 560)
    headbar(d, "pnlRail", 100, 820)
    d.dock("pnlBody", "Fill"); d.back("pnlBody", PAGE)
    d.order("FORM", ["pnlBody", "pnlRail"])
    d.drop("pnlRailRule", "Dock")
    d.place("pnlRailRule", 0, 96, 820, 4); d.back("pnlRailRule", INDIGO); d.anchor("pnlRailRule", "BLR")
    lab(d, "lblRailBadge", 24, 12, 200, 14, 8.5, True, INDIGO, "TopLeft")
    lab(d, "lblRailTitle", 24, 28, 470, 34, 20, True, DEEP, "TopLeft")
    lab(d, "lblRailText", 24, 64, 480, 28, 9.5, False, MUTED, "TopLeft")
    lab(d, "lblRailAuthor", 540, 28, 256, 24, 12, True, DEEP, "MiddleRight")
    lab(d, "lblRailCourse", 540, 56, 256, 18, 9, False, MUTED, "MiddleRight")
    anchor(d, ("lblRailAuthor", "lblRailCourse"), "TR")
    lab(d, "lblHeading", 24, 14, 300, 28, 15, True, DEEP)
    lab(d, "lblHint", 24, 44, 300, 40, 9, False, MUTED)
    card(d, "pnlEntry", 24, 94, 300, 120, INDIGO)
    lab(d, "lblAverageCaption", 16, 14, 260, 18, 9.5, True, MUTED)
    d.place("txtAverage", 16, 40, 124, 38); d.font("txtAverage", FAM, 16, True)
    d.place("btnEvaluate", 152, 40, 132, 38)
    lab(d, "lblCardsHeading", 344, 14, 400, 18, 9.5, True, MUTED)
    accents = (TEAL, AMBER, INDIGO_L)
    for i, k in enumerate((1, 2, 3)):
        card(d, "pnlCard%d" % k, 344, 40 + i * 108, 452, 98, accents[i])
        lab(d, "lblCard%dTitle" % k, 18, 16, 190, 18, 10, True, MUTED)
        lab(d, "lblCard%dNote" % k, 18, 44, 190, 40, 8.5, False, TEXT2, "TopLeft")
        lab(d, "lblCard%dValue" % k, 216, 14, 220, 76, 24, True, DEEP, "MiddleCenter")
        d.back("lblCard%dValue" % k, TINT); d.set("lblCard%dValue" % k, "BorderStyle", NOB)
    card(d, "pnlInfo", 24, 230, 300, 118, TINT2, strip=False, back=TINT)
    lab(d, "lblInfoTitle", 14, 10, 272, 18, 9.5, True, INDIGO)
    lab(d, "lblInfoText", 14, 32, 272, 78, 8.5, False, TEXT2)
    d.place("btnClear", 24, 366, 142, 46); d.place("btnExit", 182, 366, 142, 46)
    lab(d, "lblStatus", 24, 424, 772, 20, 9.5, False, TEXT2)
    buttons(d, {"btnEvaluate": "p", "btnClear": "n", "btnExit": "x"})
    inputs_light(d)
    d.save()


# =========================================================================================
def act6():
    d = Designer(find("Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.Designer.vb"))
    formprops(d, 940, 600)
    headbar(d, "pnlHeader", 70, 940)
    lab(d, "lblHeaderTitle", 24, 10, 480, 32, 19, True, DEEP, "TopLeft")
    lab(d, "lblHeaderSub", 24, 44, 560, 18, 9, False, MUTED, "TopLeft")
    lab(d, "lblAuthor", 640, 12, 276, 24, 12, True, DEEP, "MiddleRight")
    lab(d, "lblCourse", 640, 40, 276, 18, 9, False, MUTED, "MiddleRight")
    anchor(d, ("lblAuthor", "lblCourse"), "TR")
    # toolbar directly under the header : buttons left, status right
    d.back("pnlActions", TINT); d.dock("pnlActions", "Top", 940, 58)
    d.place("btnEvaluate", 20, 9, 150, 40); d.place("btnClear", 180, 9, 100, 40); d.place("btnExit", 290, 9, 100, 40)
    lab(d, "lblStatus", 410, 19, 512, 20, 9.5, False, TEXT2, "MiddleRight")
    d.anchor("lblStatus", "TR")
    d.order("FORM", ["pnlRight", "pnlLeft", "pnlActions", "pnlHeader"])
    # inputs stacked in a narrow column
    card(d, "pnlLeft", 20, 144, 270, 428, INDIGO)
    lab(d, "lblLeftTitle", 18, 14, 230, 18, 9, True, MUTED)
    for i, k in enumerate((1, 2, 3)):
        y = 44 + i * 92
        lab(d, "lblG%dCaption" % k, 18, y, 232, 20, 10.5, False, TEXT2)
        d.place("txtG%d" % k, 18, y + 24, 232, 36); d.font("txtG%d" % k, FAM, 15)
    d.place("lblLeftRule", 18, 330, 232, 1); d.back("lblLeftRule", LINE)
    lab(d, "lblLeftNote", 18, 340, 232, 70, 8.5, False, MUTED)
    # right : three remark tiles in a row, wide average band below
    card(d, "pnlRight", 310, 144, 610, 428, TEAL)
    lab(d, "lblAveCaption", 18, 14, 300, 18, 9, True, MUTED)
    for i, k in enumerate((1, 2, 3)):
        x = 18 + i * 194
        d.panel("pnlTileR%d" % k, "pnlRight", x, 42, 182, 118, TINT)
        d.reparent("lblR%dCaption" % k, "pnlTileR%d" % k); d.reparent("lblRemarks%d" % k, "pnlTileR%d" % k)
        lab(d, "lblR%dCaption" % k, 12, 10, 158, 18, 9.5, True, MUTED)
        lab(d, "lblRemarks%d" % k, 6, 40, 170, 64, 20, True, DEEP, "MiddleCenter")
        d.back("lblRemarks%d" % k, TINT); d.set("lblRemarks%d" % k, "BorderStyle", NOB)
    d.place("pnlAveBadge", 18, 180, 574, 150)
    d.place("lblAverage", 12, 14, 550, 122); d.font("lblAverage", FAM, 54, True); d.align("lblAverage", "MiddleCenter")
    lab(d, "lblAveNote", 18, 346, 574, 60, 9, False, MUTED)
    buttons(d, {"btnEvaluate": "p", "btnClear": "n", "btnExit": "x"})
    inputs_light(d)
    d.save()


# =========================================================================================
def act7():
    d = Designer(find("Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb"))
    f = formprops(d, 780, 540)
    d.panel("pnlTop", "FORM", 0, 0, 780, 60, WHITE)
    d.panel("pnlBottom", "FORM", 0, 508, 780, 32, TINT)
    d.panel("pnlRuleA", "pnlTop", 0, 56, 780, 4, INDIGO)
    d.label("lblTopTitle", "pnlTop", 20, 12, 420, 32, "Integrative Program 1", DEEP, F(18, True))
    d.label("lblTopSub", "pnlTop", 440, 20, 320, 22, "Activity 7  |  IntegProg1_SW20260720", MUTED, F(9), "MiddleRight")
    d.anchor("lblTopSub", "TR")
    d.dock("pnlTop", "Top", 780, 60); d.dock("pnlBottom", "Bottom", 780, 32)
    d.reparent("lblAuthor", "pnlBottom")
    lab(d, "lblAuthor", 16, 7, 280, 18, 9.5, True, TEXT2, "MiddleLeft")
    d.order("FORM", ["TabControl1", "pnlBottom", "pnlTop"])
    d.place("TabControl1", 14, 72, 752, 424)
    tw, th = 744, 396
    for p in ("tabInterest", "tabSquare", "tabClassAverage", "tabDecimalEquivalent", "TabPage1"):
        d.set(p, "Size", "New System.Drawing.Size(%d, %d)" % (tw, th))
        d.back(p, WHITE); d.set(p, "UseVisualStyleBackColor", "False")
    d.place("TabControl2", 8, 8, 728, 380)
    for p in ("TabPage2", "TabPage3", "TabPage4"):
        d.set(p, "Size", "New System.Drawing.Size(720, 354)"); d.back(p, WHITE); d.set(p, "UseVisualStyleBackColor", "False")

    def cap(n, x, y, w=210):
        lab(d, n, x, y, w, 18, 10, True, MUTED)

    def box(n, x, y, w, h=30):
        d.place(n, x, y, w, h); d.font(n, FAM, 12)
    # interest : inputs in a left column, balances on the right
    cap("principalLabel", 20, 18); box("principalTextBox", 20, 40, 210)
    cap("interestRateLabel", 20, 90); box("interestRateTextBox", 20, 112, 210)
    cap("yearsLabel", 20, 162); box("yearsNumericUpDown", 20, 184, 120)
    d.place("calculateButton", 20, 240, 210, 42)
    cap("balancesLabel", 256, 18, 300); d.place("resultsListBox", 256, 40, 472, 330); d.font("resultsListBox", FAM, 11)
    # square
    cap("fillCharacterLabel", 20, 18); box("fillCharacterTextBox", 20, 40, 110)
    cap("sideLengthLabel", 20, 90); box("sideLengthNumericUpDown", 20, 112, 110)
    d.place("displaySquareButton", 20, 164, 210, 42)
    d.place("outputTextBox", 256, 18, 472, 352); d.font("outputTextBox", "Consolas", 11)
    # class average : form on the left, grades in the middle, summary on the right
    cap("gradeLabel", 20, 18, 190); box("gradeTextBox", 20, 40, 190)
    d.place("submitGradeButton", 20, 82, 190, 36)
    cap("gradesLabel", 20, 134, 190); d.place("gradesListBox", 20, 156, 190, 150); d.font("gradesListBox", FAM, 11)
    d.place("calculateAverageButton", 20, 322, 92, 40); d.place("clearGradesButton", 118, 322, 92, 40)
    d.place("classAverageLabel", 232, 18, 496, 344); d.back("classAverageLabel", TINT)
    d.font("classAverageLabel", FAM, 12, True); d.fore("classAverageLabel", DEEP); d.align("classAverageLabel", "TopLeft")
    d.place("decimalOutputTextBox", 16, 16, 712, 364); d.font("decimalOutputTextBox", "Consolas", 10)
    buttons(d, {"calculateButton": "p", "displaySquareButton": "p", "submitGradeButton": "p",
                "calculateAverageButton": "t", "clearGradesButton": "n"})
    for n in ("calculateAverageButton", "clearGradesButton"):
        d.font(n, FAM, 9, True)
    inputs_light(d)
    d.save()


# =========================================================================================
def act8():
    d = Designer(find("Act8_SW20260805/TheMessage/Form1.Designer.vb"))
    formprops(d, 840, 560)
    headbar(d, "pnlHeader", 68, 840)
    lab(d, "lblHeaderTitle", 24, 10, 420, 32, 20, True, DEEP, "TopLeft")
    lab(d, "lblHeaderSub", 24, 44, 520, 18, 9, False, MUTED, "TopLeft")
    lab(d, "lblAuthor", 540, 24, 276, 24, 12, True, DEEP, "MiddleRight")
    d.anchor("lblAuthor", "TR")
    # bottom action bar : status on the left, buttons on the right
    d.back("pnlActions", WHITE); d.dock("pnlActions", "Bottom", 840, 64)
    d.panel("pnlRuleB", "pnlActions", 0, 0, 840, 3, LINE)
    lab(d, "lblStatus", 20, 22, 480, 20, 9.5, False, TEXT2)
    d.place("btnDisplay", 520, 12, 130, 42); d.place("btnClear", 660, 12, 80, 42); d.place("btnExit", 750, 12, 70, 42)
    for n in ("btnDisplay", "btnClear", "btnExit"):
        d.anchor(n, "TR")
    d.order("FORM", ["pnlCompose", "pnlButtons", "pnlIcons", "pnlDefault", "pnlActions", "pnlHeader"])
    card(d, "pnlCompose", 20, 84, 500, 246, INDIGO)
    lab(d, "lblComposeTitle", 16, 14, 300, 18, 9, True, MUTED)
    lab(d, "lblTitleCaption", 16, 40, 200, 18, 10, False, TEXT2)
    d.place("txtTitle", 16, 60, 466, 30); d.font("txtTitle", FAM, 12)
    lab(d, "lblMessageCaption", 16, 98, 200, 18, 10, False, TEXT2)
    d.place("txtMessage", 16, 118, 466, 60); d.font("txtMessage", FAM, 11)
    lab(d, "lblComposeNote", 16, 186, 466, 52, 8.5, False, MUTED)
    card(d, "pnlButtons", 20, 342, 500, 146, TEAL)
    lab(d, "lblButtonsTitle", 16, 14, 300, 18, 9.5, True, TEAL)
    for j, rb in enumerate(("rbOk", "rbOkCancel", "rbYesNo", "rbYesNoCancel", "rbRetryCancel", "rbAbortRetryIgnore")):
        d.place(rb, 16 + (j % 2) * 240, 42 + (j // 2) * 34, 226, 26); d.font(rb, FAM, 10.5)
    card(d, "pnlIcons", 540, 84, 280, 184, AMBER)
    lab(d, "lblIconsTitle", 16, 14, 240, 18, 9.5, True, AMBER)
    for j, rb in enumerate(("rbInfo", "rbWarning", "rbQuestion", "rbCritical")):
        d.place(rb, 16, 44 + j * 34, 246, 26); d.font(rb, FAM, 10.5)
    card(d, "pnlDefault", 540, 284, 280, 202, CORAL)
    lab(d, "lblDefaultTitle", 16, 14, 240, 18, 9.5, True, CORAL)
    for j, rb in enumerate(("rbDefault1", "rbDefault2", "rbDefault3")):
        d.place(rb, 16, 46 + j * 44, 246, 26); d.font(rb, FAM, 10.5)
    buttons(d, {"btnDisplay": "p", "btnClear": "n", "btnExit": "x"})
    inputs_light(d)
    d.save()


ALL = [act4, act5, act6, act7, act8]


# =========================================================================================
def old_texts(path):
    t = open(path, "rb").read().decode("utf-8-sig")
    title = re.search(r'Me\.Text\s*=\s*"([^"]*)"', t)
    auth = re.search(r'Me\.lblAuthor\.Text\s*=\s*"([^"]*)"', t)
    return (title.group(1) if title else ""), (auth.group(1) if auth else "")


def post_columns(path, cols, anchor_name="lv"):
    t = open(path, "rb").read().decode("utf-8-sig")
    block = "".join('        Me.%s.Columns.Add("%s", %d)\r\n' % (anchor_name, n, w) for n, w in cols)
    key = '        Me.%s.Name = "%s"\r\n' % (anchor_name, anchor_name)
    assert key in t
    t = t.replace(key, block + key, 1)
    open(path, "wb").write(b"\xef\xbb\xbf" + t.encode("utf-8"))


def act9():
    path = find("SW202609301600/ListViewSample.Designer.vb")
    title, auth = old_texts(path)
    D = rgb
    cs = [
        C("lv", "ListView", None, 0, 170, 940, 366, Dock=_enum("DockStyle", "Fill"), View=_enum("View", "Details"),
          FullRowSelect="True", GridLines="True", HideSelection="False", BorderStyle=_enum("BorderStyle", "None")),
        C("pnlBottom", "Panel", None, 0, 536, 940, 32, Dock=_enum("DockStyle", "Bottom"), BackColor=D(TINT)),
        C("lbl", "Label", "pnlBottom", 16, 7, 480, 18, AutoSize="False", text="0 item(s)"),
        C("pnlPath", "Panel", None, 0, 108, 940, 62, Dock=_enum("DockStyle", "Top"), BackColor=D(PAGE)),
        C("lblPathCaption", "Label", "pnlPath", 16, 7, 300, 16, text="CURRENT FOLDER", AutoSize="False"),
        C("txtPath", "TextBox", "pnlPath", 16, 28, 908, 23),
        C("pnlRail", "Panel", None, 0, 24, 940, 108, Dock=_enum("DockStyle", "Top"), BackColor=D(WHITE)),
        C("pnlRuleR", "Panel", "pnlRail", 0, 104, 940, 4, BackColor=D(INDIGO)),
        C("lblRailTitle", "Label", "pnlRail", 16, 10, 560, 30, text="ListView File Explorer", AutoSize="False"),
        C("lblRailSub", "Label", "pnlRail", 18, 42, 560, 18, text="Browse a folder in Details or List view.", AutoSize="False"),
        C("lblAuthor", "Label", "pnlRail", 600, 16, 324, 22, text=auth, AutoSize="False"),
        C("browse", "Button", "pnlRail", 16, 64, 120, 34, text="Browse..."),
        C("btnRefresh", "Button", "pnlRail", 144, 64, 110, 34, text="Refresh"),
        C("details", "Button", "pnlRail", 262, 64, 100, 34, text="Details"),
        C("list", "Button", "pnlRail", 370, 64, 100, 34, text="List"),
        C("menuStrip1", "MenuStrip", None, 0, 0, 940, 24),
        C("menuForms", "ToolStripMenuItem", "menuStrip1", text="Forms"),
        C("menuCombined", "ToolStripMenuItem", "menuForms", text="Combined File Explorer"),
        C("menuOpen", "ToolStripMenuItem", "menuForms", text="OpenFileDialog File Explorer"),
        C("menuTree", "ToolStripMenuItem", "menuForms", text="TreeView File Explorer"),
        C("menuList", "ToolStripMenuItem", "menuForms", text="ListView File Explorer"),
        C("menuExit", "ToolStripMenuItem", "menuForms", text="Exit"),
    ]
    gen(path, "ListViewSample", cs, [("MainMenuStrip", "Me.menuStrip1"), ("BackColor", rgb(PAGE))], (940, 568), title)
    post_columns(path, [("Name", 300), ("Type", 150), ("Modified/Size", 200)])
    d = Designer(path)
    d.anchor("lv", "TBLR"); d.anchor("txtPath", "TLR"); d.anchor("lblAuthor", "TR")
    lab(d, "lblRailTitle", 16, 10, 560, 30, 19, True, DEEP, "TopLeft")
    lab(d, "lblRailSub", 18, 44, 560, 18, 9, False, MUTED, "TopLeft")
    lab(d, "lblAuthor", 600, 16, 324, 22, 11, True, DEEP, "MiddleRight")
    lab(d, "lblPathCaption", 16, 7, 300, 16, 8.5, True, MUTED, "TopLeft")
    lab(d, "lbl", 16, 7, 480, 18, 9.5, False, TEXT2, "MiddleLeft")
    d.font("txtPath", FAM, 11); d.font("lv", FAM, 10)
    for n in ("browse", "btnRefresh", "details", "list"):
        d.font(n, FAM, 10, True)
    buttons(d, {"browse": "p", "btnRefresh": "t", "details": "n", "list": "n"})
    for n in ("menuStrip1", "menuForms", "menuList", "menuTree", "menuOpen", "menuCombined", "menuExit"):
        d.fore(n, DEEP); d.back(n, WHITE)
    inputs_light(d)
    d.save()


ALL.append(act9)


# =========================================================================================
def act10():
    base = "SW20261002/PanelSplitPanelDemo/"
    # ---------------------------------------------------------------- Form1 : panel playground
    d = Designer(find(base + "Form1.Designer.vb"))
    formprops(d, 1000, 680)
    d.back("pnlRail", WHITE); d.dock("pnlRail", "Top", 1000, 58)
    d.dock("pnlMain", "Fill"); d.back("pnlMain", PAGE)
    d.back("pnlStatus", TINT); d.dock("pnlStatus", "Bottom", 1000, 30)
    d.drop("pnlRailRule", "Dock")
    d.place("pnlRailRule", 0, 54, 1000, 4); d.back("pnlRailRule", INDIGO); d.anchor("pnlRailRule", "BLR")
    lab(d, "lblRailBadge", 24, 8, 220, 14, 8.5, True, INDIGO, "TopLeft")
    lab(d, "lblRailTitle", 24, 22, 360, 28, 16, True, DEEP, "TopLeft")
    lab(d, "lblRailAuthor", 410, 10, 250, 22, 11.5, True, DEEP, "TopLeft")
    lab(d, "lblRailCourse", 410, 32, 250, 16, 9, False, MUTED, "TopLeft")
    d.place("btnNavPanel", 690, 10, 130, 34); d.place("btnNavSplit", 830, 10, 146, 34)
    anchor(d, ("btnNavPanel", "btnNavSplit"), "TR")
    d.reparent("lblRailHint", "pnlInspector")
    d.order("FORM", ["pnlMain", "pnlStatus", "pnlRail", "menuMain"])
    lab(d, "lblHeading", 24, 10, 440, 30, 16, True, DEEP)
    lab(d, "lblSub", 24, 40, 440, 18, 9, False, MUTED)
    # left column : the inspector (buttons) and the log
    card(d, "pnlInspector", 24, 70, 470, 292, TEAL)
    lab(d, "lblInspectorTitle", 14, 12, 440, 16, 9, True, MUTED)
    names = ["btnToggleGroup", "btnSwapColor", "btnCycleBorder", "btnBringFront", "btnSendBack",
             "btnContains", "btnFocusPanel", "btnRedraw", "btnDisposeDemo"]
    for i, n in enumerate(names):
        d.place(n, 14 + (i % 2) * 228, 36 + (i // 2) * 42, 220, 34); d.font(n, FAM, 9, True)
    lab(d, "lblRailHint", 14, 252, 440, 32, 8.5, False, MUTED, "TopLeft")
    card(d, "pnlLog", 24, 378, 470, 190, INDIGO)
    lab(d, "lblLogTitle", 14, 12, 300, 16, 9, True, MUTED)
    d.place("lstLog", 14, 34, 442, 144); d.font("lstLog", FAM, 9.5)
    # right column : the workspace with the group and the nested panel
    card(d, "pnlWorkspace", 514, 70, 462, 498, INDIGO_L)
    lab(d, "lblWorkspaceTitle", 14, 12, 420, 16, 9, True, MUTED)
    d.place("pnlGroup", 14, 34, 434, 216); d.back("pnlGroup", TINT); d.set("pnlGroup", "BorderStyle", NOB)
    lab(d, "lblGroupTitle", 12, 10, 400, 16, 9, True, INDIGO)
    lab(d, "lblNameCaption", 12, 36, 200, 16, 9.5, False, TEXT2)
    d.place("txtName", 12, 54, 410, 26); d.font("txtName", FAM, 10.5)
    lab(d, "lblCourseCaption", 12, 90, 200, 16, 9.5, False, TEXT2)
    d.place("txtCourse", 12, 108, 410, 26); d.font("txtCourse", FAM, 10.5)
    d.place("btnSave", 12, 148, 410, 34)
    lab(d, "lblGroupHint", 12, 190, 410, 18, 8.5, False, MUTED)
    d.place("pnlNested", 14, 262, 434, 220); d.back("pnlNested", TINT); d.set("pnlNested", "BorderStyle", NOB)
    lab(d, "lblNestedTitle", 12, 10, 400, 16, 9, True, TEAL)
    lab(d, "lblNestedNote", 12, 32, 410, 66, 9.5, False, TEXT2)
    lab(d, "lblNestedBadge", 12, 106, 410, 34, 11, True, DEEP)
    lab(d, "lblNestedHint", 12, 150, 410, 44, 8.5, False, MUTED)
    lab(d, "lblStatus", 16, 7, 560, 16, 9.5, False, TEXT2)
    lab(d, "lblCounter", 676, 7, 300, 16, 9.5, True, INDIGO, "MiddleRight")
    d.anchor("lblCounter", "TR")
    kinds = {n: "t" for n in names}
    kinds.update({"btnToggleGroup": "p", "btnDisposeDemo": "x", "btnSave": "p", "btnNavPanel": "p", "btnNavSplit": "n"})
    buttons(d, kinds)
    d.back("menuMain", WHITE); d.fore("menuMain", DEEP); d.fore("mnuDemo", DEEP)
    inputs_light(d)
    d.save()

    # ---------------------------------------------------------------- Form2 : split container lab
    d = Designer(find(base + "Form2.Designer.vb"))
    formprops(d, 1000, 630)
    d.back("pnlTop", WHITE); d.dock("pnlTop", "Top", 1000, 62)
    d.panel("pnlRuleT", "pnlTop", 0, 58, 1000, 4, INDIGO)
    lab(d, "lblTitle", 24, 8, 380, 28, 17, True, DEEP)
    lab(d, "lblSub", 26, 38, 640, 18, 9, False, MUTED)
    lab(d, "lblAuthor", 700, 22, 276, 22, 11.5, True, DEEP, "MiddleRight")
    d.anchor("lblAuthor", "TR")
    d.back("pnlTools", WHITE); d.dock("pnlTools", "Bottom", 1000, 64)
    d.panel("pnlRuleB", "pnlTools", 0, 0, 1000, 3, LINE)
    xs = [("btnCollapseLeft", 16, 140), ("btnCollapseTop", 164, 156), ("btnSwapOrientation", 328, 140),
          ("btnLock", 476, 120), ("btnReset", 604, 110), ("btnExit", 722, 70)]
    for n, x, w in xs:
        d.place(n, x, 12, w, 40); d.font(n, FAM, 9.5, True)
    lab(d, "lblSplitInfo", 810, 12, 170, 40, 9, False, TEXT2, "MiddleRight")
    d.anchor("lblSplitInfo", "TR")
    buttons(d, {"btnCollapseLeft": "t", "btnCollapseTop": "t", "btnSwapOrientation": "p", "btnLock": "c",
                "btnReset": "n", "btnExit": "x"})
    d.back("pnlStatus", TINT); d.dock("pnlStatus", "Bottom", 1000, 28)
    lab(d, "lblStatus", 14, 5, 600, 18, 9.5, False, TEXT2)
    lab(d, "lblCount", 700, 5, 284, 18, 9.5, True, INDIGO, "MiddleRight")
    d.anchor("lblCount", "TR")
    for sp in ("splOuter", "splInner"):
        d.back(sp, LINE)
    d.dock("splOuter", "Fill")
    for p in ("pnlLeft", "pnlTopPane", "pnlBottomPane"):
        d.back(p, WHITE)
    for l in ("lblLeftTitle", "lblRecordsTitle", "lblDetailTitle"):
        d.fore(l, INDIGO); d.back(l, TINT); d.font(l, FAM, 8.5, True)
    d.back("lstCategories", WHITE); d.back("lvRecords", WHITE); d.back("txtDetails", INPUT)
    d.font("lstCategories", FAM, 10.5); d.font("txtDetails", FAM, 10)
    d.order("FORM", ["splOuter", "pnlTools", "pnlStatus", "pnlTop", "menuMain"])
    d.back("menuMain", WHITE); d.fore("menuMain", DEEP); d.fore("mnuLab", DEEP)
    inputs_light(d)
    d.save()


ALL.append(act10)


# =========================================================================================
def _head(cs, panel, title, sub, back=WHITE):
    cs += [C("lblTitle_" + panel, "Label", panel, 20, 12, 400, 30, AutoSize="False", text=title),
           C("lblSub_" + panel, "Label", panel, 22, 44, 500, 18, AutoSize="False", text=sub)]


def act11():
    base = "SW202610021600/"
    D = rgb
    # ---------------------------------------------------------------- TreeViewSample : tree left, info right
    path = find(base + "TreeViewSample.Designer.vb")
    cs = [C("pnlInfo", "Panel", None, 320, 78, 560, 482, Dock=_enum("DockStyle", "Fill"), BackColor=D(PAGE)),
          C("lblPathCaption", "Label", "pnlInfo", 24, 26, 300, 18, AutoSize="False", text="SELECTED PATH"),
          C("selectedPath", "TextBox", "pnlInfo", 24, 50, 512, 23, ReadOnly="True"),
          C("lblHelp", "Label", "pnlInfo", 24, 100, 512, 60, AutoSize="False",
            text="Expand a drive or a folder, then select a node to see its full path."),
          C("tree", "TreeView", None, 0, 78, 320, 482, Dock=_enum("DockStyle", "Left"), BorderStyle=_enum("BorderStyle", "None")),
          C("pnlHead", "Panel", None, 0, 0, 880, 78, Dock=_enum("DockStyle", "Top"), BackColor=D(WHITE)),
          C("pnlHeadRule", "Panel", "pnlHead", 0, 74, 880, 4, BackColor=D(INDIGO)),
          C("btnRefresh", "Button", "pnlHead", 732, 18, 128, 38, text="Refresh")]
    _head(cs, "pnlHead", "TreeView File Explorer", "Drives and folders load when a node is expanded.")
    gen(path, "TreeViewSample", cs, [("BackColor", D(PAGE))], (880, 560), "Question 7 - TreeView File Explorer")
    d = Designer(path)
    lab(d, "lblTitle_pnlHead", 20, 12, 520, 30, 19, True, DEEP, "TopLeft")
    lab(d, "lblSub_pnlHead", 22, 46, 600, 18, 9, False, MUTED, "TopLeft")
    lab(d, "lblPathCaption", 24, 26, 300, 18, 9, True, MUTED, "TopLeft")
    lab(d, "lblHelp", 24, 100, 512, 60, 12, False, TEXT2, "TopLeft")
    d.font("selectedPath", FAM, 11); d.anchor("selectedPath", "TLR"); d.anchor("btnRefresh", "TR")
    d.font("btnRefresh", FAM, 10.5, True); buttons(d, {"btnRefresh": "p"}); inputs_light(d); d.save()

    # ---------------------------------------------------------------- OpenFileDialogSample : rail on the right
    path = find(base + "OpenFileDialogSample.Designer.vb")
    cs = [C("selected", "ListBox", None, 0, 70, 560, 450, Dock=_enum("DockStyle", "Fill"), BorderStyle=_enum("BorderStyle", "None"),
            ItemHeight="19"),
          C("pnlRail", "Panel", None, 580, 70, 220, 450, Dock=_enum("DockStyle", "Right"), BackColor=D(TINT)),
          C("lblRailTitle", "Label", "pnlRail", 20, 22, 180, 18, AutoSize="False", text="CHOOSE"),
          C("one", "Button", "pnlRail", 20, 52, 180, 44, text="Open one..."),
          C("many", "Button", "pnlRail", 20, 106, 180, 44, text="Open multiple..."),
          C("clear", "Button", "pnlRail", 20, 160, 180, 44, text="Clear"),
          C("lblRailNote", "Label", "pnlRail", 20, 226, 182, 90, AutoSize="False",
            text="Pick one file or many files. Your selection is listed on the left."),
          C("pnlTop", "Panel", None, 0, 0, 800, 70, Dock=_enum("DockStyle", "Top"), BackColor=D(WHITE)),
          C("pnlTopRule", "Panel", "pnlTop", 0, 66, 800, 4, BackColor=D(INDIGO))]
    _head(cs, "pnlTop", "OpenFileDialog", "Selected files are listed below.")
    cs.append(C("lblHead", "Label", "pnlTop", 600, 24, 180, 22, AutoSize="False", text="SELECTED FILES"))
    gen(path, "OpenFileDialogSample", cs, [("BackColor", D(PAGE))], (800, 520), "Question 8 - OpenFileDialog")
    d = Designer(path)
    lab(d, "lblTitle_pnlTop", 20, 10, 520, 30, 19, True, DEEP, "TopLeft")
    lab(d, "lblSub_pnlTop", 22, 42, 520, 18, 9, False, MUTED, "TopLeft")
    lab(d, "lblHead", 600, 24, 180, 22, 9.5, True, INDIGO, "MiddleRight"); d.anchor("lblHead", "TR")
    lab(d, "lblRailTitle", 20, 22, 180, 18, 9, True, MUTED, "TopLeft")
    lab(d, "lblRailNote", 20, 226, 182, 90, 9.5, False, TEXT2, "TopLeft")
    d.font("selected", FAM, 11)
    for n in ("one", "many", "clear"):
        d.font(n, FAM, 10.5, True)
    buttons(d, {"one": "p", "many": "t", "clear": "n"}); inputs_light(d); d.save()

    # ---------------------------------------------------------------- CombinedSample : toolbar on top
    path = find(base + "CombinedSample.Designer.vb")
    cs = [C("lv", "ListView", None, 300, 120, 640, 460, Dock=_enum("DockStyle", "Fill"), View=_enum("View", "Details"),
            FullRowSelect="True", HideSelection="False", BorderStyle=_enum("BorderStyle", "None")),
          C("tree", "TreeView", None, 0, 120, 300, 460, Dock=_enum("DockStyle", "Left"), BorderStyle=_enum("BorderStyle", "None")),
          C("pnlBar", "Panel", None, 0, 60, 940, 60, Dock=_enum("DockStyle", "Top"), BackColor=D(TINT)),
          C("open", "Button", "pnlBar", 16, 10, 130, 40, text="Open file"),
          C("save", "Button", "pnlBar", 156, 10, 130, 40, text="Save As"),
          C("btnRefresh", "Button", "pnlBar", 296, 10, 120, 40, text="Refresh"),
          C("pnlHead", "Panel", None, 0, 0, 940, 60, Dock=_enum("DockStyle", "Top"), BackColor=D(WHITE)),
          C("pnlHeadRule", "Panel", "pnlHead", 0, 56, 940, 4, BackColor=D(INDIGO)),
          C("lblHead", "Label", "pnlHead", 20, 12, 380, 32, AutoSize="False", text="Combined Explorer"),
          C("lblHeadHint", "Label", "pnlHead", 480, 20, 440, 20, AutoSize="False", text="Folders on the left, folder contents on the right.")]
    gen(path, "CombinedSample", cs, [("BackColor", D(PAGE))], (940, 580), "Question 9 - Combined Explorer")
    post_columns(path, [("Name", 300), ("Type", 150)])
    d = Designer(path)
    lab(d, "lblHead", 20, 12, 420, 32, 19, True, DEEP, "MiddleLeft")
    lab(d, "lblHeadHint", 480, 20, 440, 20, 9, False, MUTED, "MiddleRight"); d.anchor("lblHeadHint", "TR")
    d.font("lv", FAM, 10)
    for n in ("open", "save", "btnRefresh"):
        d.font(n, FAM, 10, True)
    buttons(d, {"open": "p", "save": "t", "btnRefresh": "n"}); inputs_light(d); d.save()

    # ---------------------------------------------------------------- ListViewSample : narrow left rail
    path = find(base + "ListViewSample.Designer.vb")
    cs = [C("lv", "ListView", None, 170, 56, 730, 504, Dock=_enum("DockStyle", "Fill"), View=_enum("View", "Details"),
            FullRowSelect="True", GridLines="True", HideSelection="False", BorderStyle=_enum("BorderStyle", "None")),
          C("pnlSide", "Panel", None, 0, 56, 170, 504, Dock=_enum("DockStyle", "Left"), BackColor=D(TINT)),
          C("browse", "Button", "pnlSide", 14, 20, 142, 40, text="Browse..."),
          C("btnRefresh", "Button", "pnlSide", 14, 68, 142, 40, text="Refresh"),
          C("details", "Button", "pnlSide", 14, 116, 142, 40, text="Details"),
          C("list", "Button", "pnlSide", 14, 164, 142, 40, text="List"),
          C("lbl", "Label", "pnlSide", 14, 440, 142, 40, AutoSize="False", text="0 item(s)"),
          C("pnlTop", "Panel", None, 0, 0, 900, 56, Dock=_enum("DockStyle", "Top"), BackColor=D(WHITE)),
          C("pnlTopRule", "Panel", "pnlTop", 0, 52, 900, 4, BackColor=D(INDIGO)),
          C("txtPath", "TextBox", "pnlTop", 16, 14, 868, 23)]
    gen(path, "ListViewSample", cs, [("BackColor", D(PAGE))], (900, 560), "Question 6 - ListView File Explorer")
    post_columns(path, [("Name", 300), ("Type", 150), ("Modified/Size", 200)])
    d = Designer(path)
    d.anchor("txtPath", "TLR")
    lab(d, "lbl", 14, 440, 142, 40, 9.5, True, INDIGO, "MiddleLeft")
    d.font("txtPath", FAM, 11); d.font("lv", FAM, 10)
    for n in ("browse", "btnRefresh", "details", "list"):
        d.font(n, FAM, 10, True)
    buttons(d, {"browse": "p", "btnRefresh": "t", "details": "n", "list": "n"}); inputs_light(d); d.save()

    # ---------------------------------------------------------------- MenuForm / MainForm (code-built)
    p = find(base + "MenuForm.vb")
    t, bom = rd(p)
    t = t.replace("{treeMenu, openMenu, combinedMenu, exitMenu})", "{combinedMenu, treeMenu, openMenu, exitMenu})")
    t = t.replace("        menuStrip1.Dock = DockStyle.Top\n",
        "        menuStrip1.Dock = DockStyle.Top\n"
        "        menuStrip1.BackColor = Color.FromArgb(255, 255, 255)\n"
        "        menuStrip1.ForeColor = Color.FromArgb(30, 27, 75)\n"
        "        Me.BackColor = Color.FromArgb(244, 245, 252)\n"
        "        lblHeading = New Label()\n"
        "        lblHeading.AutoSize = False\n"
        "        lblHeading.SetBounds(48, 96, 620, 44)\n"
        "        lblHeading.Font = New Font(\"Franklin Gothic Medium\", 22.0F, FontStyle.Bold)\n"
        "        lblHeading.ForeColor = Color.FromArgb(30, 27, 75)\n"
        "        lblHeading.Text = \"Windows Forms Controls\"\n"
        "        lblSubheading = New Label()\n"
        "        lblSubheading.AutoSize = False\n"
        "        lblSubheading.SetBounds(48, 146, 620, 44)\n"
        "        lblSubheading.Font = New Font(\"Franklin Gothic Medium\", 10.0F)\n"
        "        lblSubheading.ForeColor = Color.FromArgb(67, 56, 202)\n"
        "        lblSubheading.Text = \"File explorer demos: the combined explorer, the TreeView and OpenFileDialog.\"\n"
        "        Me.Controls.Add(lblHeading)\n"
        "        Me.Controls.Add(lblSubheading)\n", 1)
    t = t.replace("    Private exitMenu As ToolStripMenuItem\n", "    Private exitMenu As ToolStripMenuItem\n    Private lblHeading As Label\n    Private lblSubheading As Label\n", 1)
    wr(p, t, bom)
    p = find(base + "MainForm.vb")
    t, bom = rd(p)
    t = t.replace("        statusBar.ForeColor = Color.FromArgb(102, 100, 139)\n",
                  "        statusBar.ForeColor = Color.FromArgb(72, 70, 122)\n        statusBar.BackColor = Color.FromArgb(232, 234, 250)\n", 1)
    t = t.replace("        text.ReadOnly = True\n", "        text.ReadOnly = True\n        text.BackColor = Color.FromArgb(255, 255, 255)\n        text.BorderStyle = BorderStyle.None\n", 1)
    wr(p, t, bom)
    # picture source of MenuForm
    p = os.path.join(ROOT, "tools/figure_sources/MenuForm.Designer.vb")
    t, bom = rd(p)
    t = t.replace("{Me.treeMenu, Me.openMenu, Me.combinedMenu, Me.exitMenu}", "{Me.combinedMenu, Me.treeMenu, Me.openMenu, Me.exitMenu}")
    t = t.replace("        Me.menuStrip1.Name = \"menuStrip1\"\n",
        "        Me.menuStrip1.Name = \"menuStrip1\"\n        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)\n        Me.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)\n", 1)
    t = t.replace("        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()\n",
        "        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()\n        Me.lblHeading = New System.Windows.Forms.Label()\n        Me.lblSubheading = New System.Windows.Forms.Label()\n", 1)
    t = t.replace("        '\n        'MenuForm\n        '\n",
        "        '\n        'lblHeading\n        '\n        Me.lblHeading.AutoSize = False\n        Me.lblHeading.Font = New System.Drawing.Font(\"Franklin Gothic Medium\", 22.0!, System.Drawing.FontStyle.Bold)\n"
        "        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)\n        Me.lblHeading.Location = New System.Drawing.Point(48, 96)\n        Me.lblHeading.Name = \"lblHeading\"\n"
        "        Me.lblHeading.Size = New System.Drawing.Size(620, 44)\n        Me.lblHeading.Text = \"Windows Forms Controls\"\n"
        "        '\n        'lblSubheading\n        '\n        Me.lblSubheading.AutoSize = False\n        Me.lblSubheading.Font = New System.Drawing.Font(\"Franklin Gothic Medium\", 10.0!)\n"
        "        Me.lblSubheading.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)\n        Me.lblSubheading.Location = New System.Drawing.Point(48, 146)\n        Me.lblSubheading.Name = \"lblSubheading\"\n"
        "        Me.lblSubheading.Size = New System.Drawing.Size(620, 44)\n        Me.lblSubheading.Text = \"File explorer demos: the combined explorer, the TreeView and OpenFileDialog.\"\n"
        "        '\n        'MenuForm\n        '\n        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)\n", 1)
    t = t.replace("        Me.Controls.Add(Me.menuStrip1)\n", "        Me.Controls.Add(Me.lblHeading)\n        Me.Controls.Add(Me.lblSubheading)\n        Me.Controls.Add(Me.menuStrip1)\n", 1)
    t = t.replace("    Friend WithEvents exitMenu As System.Windows.Forms.ToolStripMenuItem\n",
                  "    Friend WithEvents exitMenu As System.Windows.Forms.ToolStripMenuItem\n    Friend WithEvents lblHeading As System.Windows.Forms.Label\n    Friend WithEvents lblSubheading As System.Windows.Forms.Label\n", 1)
    wr(p, t, bom)


ALL.append(act11)


# =========================================================================================
def act12():
    d = Designer(find("FileExplorerClone/PanelSplitDemo/Form1.Designer.vb"))
    formprops(d, 1200, 720)
    # two-row header : title + author on the first row, navigation + address on the second
    d.back("pnlHeader", WHITE); d.dock("pnlHeader", "Top", 1200, 98)
    d.panel("pnlRuleH", "pnlHeader", 0, 94, 1200, 4, INDIGO); d.anchor("pnlRuleH", "BLR")
    lab(d, "lblApp", 20, 8, 300, 28, 15, True, DEEP, "TopLeft")
    lab(d, "lblHeaderSub", 326, 14, 520, 18, 9, False, MUTED, "MiddleLeft")
    lab(d, "lblAuthor", 880, 12, 300, 22, 11.5, True, DEEP, "MiddleRight"); d.anchor("lblAuthor", "TR")
    d.place("btnBack", 20, 48, 70, 36); d.place("btnForward", 96, 48, 86, 36); d.place("btnUp", 188, 48, 58, 36)
    d.place("btnHome", 252, 48, 70, 36); d.place("btnRefresh", 328, 48, 86, 36)
    d.place("txtPath", 430, 54, 664, 24); d.font("txtPath", FAM, 11); d.anchor("txtPath", "TLR")
    d.place("btnGo", 1104, 48, 76, 36); d.anchor("btnGo", "TR")
    # toggles in a bottom toolbar, the author stays in the header
    d.back("pnlTools", TINT); d.dock("pnlTools", "Bottom", 1200, 54)
    for i, (n, w) in enumerate((("btnTreeToggle", 160), ("btnPreviewToggle", 170), ("btnSwapLayout", 170), ("btnLockSplitters", 140))):
        x = 16 + sum(ww + 10 for ww in (160, 170, 170, 140)[:i])
        d.place(n, x, 9, w, 36)
    lab(d, "lblSplitInfo", 700, 9, 480, 36, 9, False, TEXT2, "MiddleRight"); d.anchor("lblSplitInfo", "TR")
    d.back("pnlStatus", WHITE); d.dock("pnlStatus", "Bottom", 1200, 28)
    lab(d, "lblStatus", 14, 5, 700, 18, 9.5, False, TEXT2, "MiddleLeft")
    lab(d, "lblCount", 900, 5, 280, 18, 9.5, True, INDIGO, "MiddleRight")
    buttons(d, {"btnBack": "n", "btnForward": "n", "btnUp": "n", "btnHome": "n", "btnRefresh": "t", "btnGo": "p",
                "btnTreeToggle": "t", "btnPreviewToggle": "t", "btnSwapLayout": "p", "btnLockSplitters": "c"})
    for n in ("btnBack", "btnForward", "btnUp", "btnHome", "btnRefresh", "btnGo", "btnTreeToggle", "btnPreviewToggle",
              "btnSwapLayout", "btnLockSplitters"):
        d.font(n, FAM, 9.5, True)
    d.back("splRoot", LINE); d.back("splWorkspace", LINE)
    for p in ("pnlTreeHost", "pnlListHost", "pnlPreviewHost"):
        d.back(p, WHITE)
    d.back("pnlFilterBar", WHITE)
    for l in ("lblTreeTitle", "lblListTitle", "lblPreviewTitle"):
        d.fore(l, INDIGO); d.back(l, TINT); d.font(l, FAM, 8.5, True)
    d.fore("lblFilterCaption", MUTED); d.place("txtFilter", 520, 3, 250, 23)
    d.font("lvFiles", FAM, 10); d.font("txtFilter", FAM, 9.5); d.font("txtPreview", "Consolas", 9.5)
    d.order("FORM", ["splRoot", "pnlTools", "pnlStatus", "pnlHeader"])
    inputs_light(d)
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


GRID_STYLE = [("EnableHeadersVisualStyles", "False"), ("BorderStyle", NOB),
              ("GridColor", rgb(LINE)),
              ("ColumnHeadersDefaultCellStyle.BackColor", rgb(DEEP)), ("ColumnHeadersDefaultCellStyle.ForeColor", rgb(PALE)),
              ("DefaultCellStyle.BackColor", rgb(WHITE)), ("DefaultCellStyle.ForeColor", rgb(TEXT)),
              ("DefaultCellStyle.SelectionBackColor", rgb(TINT2)), ("DefaultCellStyle.SelectionForeColor", rgb(DEEP)),
              ("AlternatingRowsDefaultCellStyle.BackColor", rgb(PAGE))]


def crud(fname, cols):
    path = find("IntegProgProject2026/IntegProgProject2026/Forms/" + fname)
    blockify(path)
    d = Designer(path)
    f = d.form_name()
    d.set(f, "BackColor", rgb(PAGE))
    kids = d.children("grpDetails")
    pairs = [(kids[i], kids[i + 1]) for i in range(0, len(kids) - 1, 2)]
    rows = (len(pairs) + cols - 1) // cols
    gh = max(30 + rows * 54 + 6, 230)
    # details form on top (left), the action buttons in a column on its right
    dw = 792
    d.place("grpDetails", 12, 10, dw, gh); d.back("grpDetails", WHITE); d.fore("grpDetails", INDIGO); d.font("grpDetails", FAM, 9.5, True)
    cw = (dw - 24) // cols
    for i, (lb, ip) in enumerate(pairs):
        r, c = divmod(i, cols)
        x = 14 + c * cw
        y = 26 + r * 54 if rows * 54 + 36 >= gh else 30 + r * ((gh - 50) // rows)
        lab(d, lb, x, y, cw - 24, 16, 9.5, False, TEXT2, "TopLeft")
        d.place(ip, x, y + 18, cw - 24, 24); d.font(ip, FAM, 10.5)
    names = ("addButton", "updateButton", "deleteButton", "clearButton", "exitButton")
    kinds = ("p", "t", "x", "n", "n")
    pitch = (gh - 38) // 4
    for i, n in enumerate(names):
        d.place(n, 818, 12 + i * pitch, 176, 38); d.font(n, FAM, 10.5, True)
        btn(d, n, kinds[i])
    gy = 10 + gh + 14
    d.place("grpRecords", 12, gy, 982, 238); d.back("grpRecords", WHITE); d.fore("grpRecords", INDIGO); d.font("grpRecords", FAM, 9.5, True)
    d.place("dataGridView1", 12, 24, 958, 202); d.anchor("dataGridView1", "TBLR"); d.back("dataGridView1", WHITE)
    d.font("dataGridView1", FAM, 9.5)
    for k, v in GRID_STYLE:
        d.set("dataGridView1", k, v)
    ly = gy + 238 + 8
    lab(d, "lblDatabase", 12, ly, 982, 18, 9, False, MUTED, "MiddleLeft")
    d.anchor("lblDatabase", "BL")
    d.set(f, "ClientSize", "New System.Drawing.Size(1006, %d)" % (ly + 18 + 14))
    inputs_light(d)
    d.save()


def act13():
    crud("frmSchedules.Designer.vb", 2)
    crud("frmQuotes.Designer.vb", 2)
    crud("frmBibleVerses.Designer.vb", 3)
    base = "IntegProgProject2026/IntegProgProject2026/Forms/"
    # ---------------------------------------------------------------- frmMain
    path = find(base + "frmMain.Designer.vb")
    blockify(path)
    d = Designer(path)
    d.set("frmMain", "BackColor", rgb(PAGE))
    s, e = d.span("MenuStrip1")
    seg = d.t[s:e]
    seg = re.sub(r"\{Me\.SchedulesToolStripMenuItem, Me\.AboutToolStripMenuItem, Me\.QuotesToolStripMenuItem, Me\.BibleVerseToolStripMenuItem, Me\.ExitToolStripMenuItem\}",
                 "{Me.QuotesToolStripMenuItem, Me.BibleVerseToolStripMenuItem, Me.SchedulesToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem}", seg)
    d.t = d.t[:s] + seg + d.t[e:]
    d.back("MenuStrip1", WHITE); d.fore("MenuStrip1", DEEP)
    d.back("StatusStrip1", TINT); d.fore("StatusStrip1", TEXT2)
    d.font("MenuStrip1", FAM, 10)
    d.font("StatusStrip1", FAM, 9)
    d.save()
    # ---------------------------------------------------------------- frmAbout : portrait on the left, quote band on the right
    path = find(base + "frmAbout.Designer.vb")
    blockify(path)
    d = Designer(path)
    d.set("frmAbout", "ClientSize", "New System.Drawing.Size(700, 376)")
    d.set("frmAbout", "BackColor", rgb(PAGE))
    d.panel("pnlSideAbout", "FORM", 0, 0, 290, 376, DEEP)
    d.panel("pnlRuleAbout", "FORM", 314, 36, 44, 4, CORAL)
    d.place("PictureBox1", 24, 28, 242, 322); d.set("PictureBox1", "BorderStyle", NOB); d.back("PictureBox1", DEEP)
    d.set("PictureBox1", "SizeMode", "System.Windows.Forms.PictureBoxSizeMode.Zoom")
    lab(d, "lblName", 314, 50, 360, 36, 22, True, DEEP, "TopLeft")
    lab(d, "lblCourse", 314, 98, 360, 22, 11.5, False, INDIGO, "TopLeft")
    lab(d, "lblAddress", 314, 128, 360, 22, 11, False, TEXT2, "TopLeft")
    lab(d, "lblSkills", 314, 156, 360, 22, 11, False, TEXT2, "TopLeft")
    d.panel("pnlQuote", "FORM", 314, 222, 362, 128, WHITE)
    d.panel("pnlQuoteBar", "pnlQuote", 0, 0, 5, 128, INDIGO)
    d.reparent("lblQuote", "pnlQuote")
    lab(d, "lblQuote", 20, 10, 330, 108, 11.5, True, DEEP, "MiddleLeft")
    d.order("FORM", ["pnlSideAbout", "PictureBox1", "lblName", "lblCourse", "lblAddress", "lblSkills", "pnlRuleAbout", "pnlQuote"])
    d.save()


ALL.append(act13)
