# -*- coding: utf-8 -*-
"""VIERNES (code 12) is a full redesign instead of a layout/style code.

Run ONCE on a clean clone of another identity (the design of every form 4-13 is rebuilt):

    python3 tools/apply_redesign.py      # dark graphite + mint theme, Corbel, new composition per form
    python3 tools/style_variants.py 12   # Corbel + neon buttons for everything that is still untouched
    python3 tools/build_documents.py     # figures + DOCX/PDF
    python3 tools/build_package.py       # student zip

Files:  rd_base.py  (palette, colour remap of the *.vb files)
        rd_forms.py (one function per activity: act4 ... act13)
        rd_gen.py   (writes the designers that are rebuilt from scratch: Act 9 and Act 11)
        designer_edit.py (text patching engine for *.Designer.vb files)
Control names / types are never changed, so the code-behind keeps working.
"""
import os, sys, glob
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
MARK = os.path.join(HERE, "redesign_code.txt")
if os.path.exists(MARK):
    sys.exit("redesign already applied (" + MARK + ")")
import rd_base, rd_forms
ROOT = os.path.dirname(HERE)
for p in glob.glob(ROOT + "/COMPILATION/**/*.vb", recursive=True) + glob.glob(HERE + "/figure_sources/*.vb"):
    if "My Project" in p:
        continue
    t, bom = rd_base.rd(p)
    t2 = rd_base.remap_text(t)
    if t2 != t:
        rd_base.wr(p, t2, bom)
for fn in rd_forms.ALL:
    fn()
open(MARK, "w").write("redesign 12 (dark graphite + mint)\n")
print("redesign applied: acts", ", ".join(f.__name__[3:] for f in rd_forms.ALL))
