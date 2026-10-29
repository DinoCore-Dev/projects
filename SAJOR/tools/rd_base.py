# -*- coding: utf-8 -*-
"""SAJOR (code 13) - full redesign "Indigo Studio": light lavender pages, white cards with a coloured
top strip, deep-indigo ink buttons, Franklin Gothic Medium, and a NEW composition for every form
(three-column keypad layouts, top toolbars, right-hand columns, bottom bars ...).
Control names / types are never changed, so the code-behind keeps working."""
import os, re, sys
HERE = os.path.dirname(os.path.abspath(__file__))
ROOT = os.path.dirname(HERE)
COMP = os.path.join(ROOT, "COMPILATION")
sys.path.insert(0, HERE)
from designer_edit import Designer, rgb, font, _enum

FAM = "Franklin Gothic Medium"


def F(size, bold=False):
    return font(FAM, size, bold)


# ---- palette ---------------------------------------------------------------------------------
PAGE = (244, 245, 252)
WHITE = (255, 255, 255)
INPUT = (247, 248, 255)
TINT = (232, 234, 250)
TINT2 = (214, 218, 246)
LINE = (200, 204, 232)
DEEP = (30, 27, 75)
TEXT = (38, 36, 92)
TEXT2 = (72, 70, 122)
MUTED = (105, 103, 150)
INDIGO = (67, 56, 202)
INDIGO_L = (99, 102, 241)
CORAL = (224, 82, 67)
TEAL = (14, 116, 144)
AMBER = (194, 120, 3)
RED = (190, 38, 60)
PALE = (199, 210, 254)


def rd(path):
    raw = open(path, "rb").read()
    return raw.decode("utf-8-sig"), raw.startswith(b"\xef\xbb\xbf")


def wr(path, text, bom):
    data = text.encode("utf-8")
    open(path, "wb").write((b"\xef\xbb\xbf" if bom else b"") + data)


def find(rel):
    return os.path.join(COMP, rel)
