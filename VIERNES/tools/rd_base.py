# -*- coding: utf-8 -*-
"""Full redesign for the VIERNES identity (style code 12): graphite dark theme, mint / violet / amber accents,
Corbel font, outline-neon buttons, and a NEW composition for every form (not a re-ordering of the base)."""
import os, re, glob, sys
HERE = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.dirname(HERE)
COMP = os.path.join(ROOT, "COMPILATION")
sys.path.insert(0, HERE)
from designer_edit import Designer, rgb, font, _enum

FAM = "Corbel"
def F(size, bold=False): return font(FAM, size, bold)

# ---- palette ---------------------------------------------------------------------------------
PAGE   = (17, 19, 25)
ALT    = (24, 27, 35)
CARD   = (31, 35, 44)
CARD2  = (38, 43, 55)
CHROME = (10, 12, 16)
INPUT  = (12, 14, 19)
LINE   = (58, 65, 80)
TEXT   = (236, 239, 244)
TEXT2  = (190, 198, 211)
MUTED  = (141, 152, 170)
MINT   = (52, 211, 153)
MINT_L = (110, 231, 183)
MINT_D = (16, 78, 60)
VIOLET = (139, 92, 246)
VIOLET_D = (49, 38, 92)
AMBER  = (251, 191, 36)
RED    = (220, 38, 38)
INK    = (8, 20, 16)

BACK_MAP = {
    "White": CARD, (241, 245, 249): PAGE, (248, 250, 252): ALT, (226, 232, 240): CARD2,
    (37, 99, 235): MINT, (15, 23, 42): CHROME, (30, 41, 59): CHROME, (220, 38, 38): RED,
    (56, 189, 248): AMBER, (79, 70, 229): VIOLET, (13, 148, 136): VIOLET, (224, 231, 255): CARD2,
    (49, 46, 129): VIOLET_D, (30, 27, 75): VIOLET_D,
}
FORE_MAP = {
    (30, 41, 59): TEXT, (51, 65, 85): TEXT2, (71, 85, 105): (176, 186, 200), (100, 116, 139): MUTED,
    (148, 163, 184): (148, 163, 184), (15, 23, 42): INK, (37, 99, 235): MINT_L, (56, 189, 248): AMBER,
    (22, 163, 74): (74, 222, 128), (217, 119, 6): AMBER, (220, 38, 38): (248, 113, 113),
    (147, 51, 234): (196, 148, 252), (49, 46, 129): (196, 181, 253), (120, 53, 15): (253, 224, 71),
    (226, 232, 240): (226, 232, 240),
}
BORDER_MAP = {(203, 213, 225): LINE, (148, 163, 184): (88, 98, 116), (51, 65, 85): (100, 112, 132)}
UNMAPPED = set()

def _hls_dark(c, light):
    import colorsys
    h, l, s = colorsys.rgb_to_hls(c[0] / 255, c[1] / 255, c[2] / 255)
    r, g, b = colorsys.hls_to_rgb(h, 0.22 if not light else 0.86, min(0.6, s * 0.7))
    return (round(r * 255), round(g * 255), round(b * 255))

def _lum(c):
    return (0.2126 * c[0] + 0.7152 * c[1] + 0.0722 * c[2]) / 255

def remap(prop, col):
    if prop in ("BackColor", "BackgroundColor", "GridColor"):
        m = BACK_MAP
    elif prop == "BorderColor":
        m = BORDER_MAP
    else:
        m = FORE_MAP
    if col in m:
        return m[col]
    if col == "White":
        return CARD if prop.endswith("BackColor") or prop == "BackgroundColor" else (255, 255, 255)
    if isinstance(col, tuple):
        if prop in ("BackColor", "BackgroundColor") and _lum(col) > 0.6:
            UNMAPPED.add((prop, col)); return _hls_dark(col, False)
        if prop == "ForeColor" and _lum(col) < 0.4 and col not in FORE_MAP:
            UNMAPPED.add((prop, col)); return _hls_dark(col, True)
    return col

NAMED = {"White": (255, 255, 255), "Black": (0, 0, 0)}
CRX = re.compile(r"(\w+)( = (?:System\.Drawing\.)?)Color\.(?:FromArgb\((\d+), ?(\d+), ?(\d+)\)|(\w+))")

def remap_text(t):
    def sub(m):
        prop, mid = m.group(1), m.group(2)
        col = (int(m.group(3)), int(m.group(4)), int(m.group(5))) if m.group(3) else m.group(6)
        if col in ("Control", "Transparent", "Black", "Window") or (isinstance(col, str) and col not in ("White",)):
            return m.group(0)
        new = remap(prop, col)
        if new == col:
            return m.group(0)
        if isinstance(new, str):
            return "%s%sColor.%s" % (prop, mid, new)
        return "%s%sColor.FromArgb(%d, %d, %d)" % (prop, mid, new[0], new[1], new[2])
    return CRX.sub(sub, t)

def rd(path):
    raw = open(path, "rb").read()
    return raw.decode("utf-8-sig"), raw.startswith(b"\xef\xbb\xbf")

def wr(path, text, bom):
    data = text.encode("utf-8")
    open(path, "wb").write((b"\xef\xbb\xbf" if bom else b"") + data)

def find(rel):
    return os.path.join(COMP, rel)
