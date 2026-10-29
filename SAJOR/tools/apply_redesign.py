# -*- coding: utf-8 -*-
"""SAJOR (code 13) is a full redesign (theme "Indigo Studio") instead of only a layout/style code.

Run ONCE on a clean clone of another identity, in this order:

    python3 tools/style_variants.py 13   # Franklin Gothic Medium + ink buttons for the whole base
    python3 tools/apply_redesign.py      # new composition of every form 4-13 (overrides what it touches)
    python3 tools/style_variants.py --fit-only
    python3 tools/build_documents.py     # figures + DOCX/PDF
    python3 tools/build_package.py       # student zip

Files:  rd_base.py (palette), rd_forms.py (one function per activity), rd_gen.py (designers rebuilt from
scratch: Act 9 and Act 11), designer_edit.py (text patching engine for *.Designer.vb files).
Control names / types are never changed, so the code-behind keeps working.
"""
import os, sys
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
MARK = os.path.join(HERE, "redesign_code.txt")
if os.path.exists(MARK):
    sys.exit("redesign already applied (" + MARK + ")")
import rd_base, rd_forms
for fn in rd_forms.ALL:
    fn()
# own sample values of the console activity 1 (the sample data of Sajor differs from the other identities)
_p = os.path.join(os.path.dirname(HERE), "COMPILATION", "Act1_Activity202606241600", "Activity202606241600", "Module1.vb")
_t = open(_p, "rb").read().decode("utf-8")
for _a, _b in (('Dim character As Char = "A"c', 'Dim character As Char = "R"c'),
               ("Dim number1 As Integer = 12", "Dim number1 As Integer = 27"),
               ("Dim number2 As Double = 12.12", "Dim number2 As Double = 3.14")):
    assert _a in _t
    _t = _t.replace(_a, _b)
open(_p, "wb").write(_t.encode("utf-8"))
open(MARK, "w").write("redesign 13 (Indigo Studio: light lavender, ink buttons, Franklin Gothic Medium)\n")
print("redesign applied: acts", ", ".join(f.__name__[3:] for f in rd_forms.ALL))
