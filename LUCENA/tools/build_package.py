"""Build the single submission zip.

The zip has everything at the top level, so the person who opens it sees
the PDF, the DOCX, the master prompt and one folder per activity - nothing
else and no second zip.

Layout inside the zip
---------------------
    START_HERE.txt
    Lucena_LykaJoy_Activity_Compilation.pdf
    Lucena_LykaJoy_Activity_Compilation.docx
    Master_Prompt.md
    Form_Designs/                     (one PNG per form design)
    01_Act1_Console_Basics/           (full Visual Studio 2010 solution)
    ...
    13_Act13_Integrative_Project_MDI/

Usage
-----
    python3 tools/build_package.py
"""

import os
import shutil
import tempfile
import zipfile

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
COMPILATION = os.path.join(ROOT, "COMPILATION")
DOCS = os.path.join(ROOT, "docs")
REPO = os.path.dirname(ROOT)
OUT_ZIP = os.path.join(REPO, "Lucena_LykaJoy_Compilation.zip")

PDF = "Lucena_LykaJoy_Activity_Compilation.pdf"
DOCX = "Lucena_LykaJoy_Activity_Compilation.docx"

# (name inside the zip, folder inside COMPILATION)
FOLDERS = [
    ("01_Act1_Console_Basics", "Act1_Activity202606241600"),
    ("02_Act2_Celsius_Fahrenheit", "Act2 Celcius-Fahrenheit Converter"),
    ("03_Act3_Sum_Retry_Console", "Activity3_20260629"),
    ("04_Act4_Arithmetic_Machine", "Activity4_20260703"),
    ("05_Act5_Ternary_Remarks", "Act5"),
    ("06_Act6_Select_Case_Grade", "Act6_IntegProg1_20260715"),
    ("07_Act7_Integrative_Program1", "Act7_IntegProg1_SW20260720"),
    ("08_Act8_The_Message", "Act8_SW20260805"),
    ("09_Act9_ListView_File_Explorer", "SW202609301600"),
    ("10_Act10_Panel_and_SplitContainer", "SW20261002"),
    ("11_Act11_Controls_Collection", "SW202610021600"),
    ("12_Act12_File_Explorer_Clone", "FileExplorerClone"),
    ("13_Act13_Integrative_Project_MDI", "IntegProgProject2026"),
]

SKIP_DIRS = {"bin", "obj", ".vs"}
SKIP_EXT = {".suo", ".user", ".cache", ".ds_store"}

START_HERE = """====================================================================
 ACTIVITY COMPILATION - INTEGRATIVE PROGRAMMING
====================================================================
 Author          : Lucena, Lyka Joy
 Course/Year/Sec : BSIT 3B
 Subject         : Integrative Programming
 IDE             : Visual Studio 2010 (.NET Framework 4.0)
 Document        : {pages} pages (PDF at the top of this folder)
====================================================================

WHAT IS INSIDE THIS ZIP
----------------------
  Lucena_LykaJoy_Activity_Compilation.pdf   <- ito ang ipasa ({pages} pages)
  Lucena_LykaJoy_Activity_Compilation.docx  <- kung kailangan i-edit
  Master_Prompt.md                           <- template kung magbabago ng pangalan
  Form_Designs\\                              <- {figures} PNG na drawing at sample output
  01_ ... 13_ ...                            <- isang folder bawat activity

Each activity folder already contains the full Visual Studio 2010
solution (source code + form designer). Walang bin, obj o .suo,
kaya bubuksan lang at F5.

LIST OF ACTIVITIES (folder -> solution file to open)
----------------------------------------------------
 01_Act1_Console_Basics              -> Activity202606241600.sln
    Act 1  Console Basics and Data Types

 02_Act2_Celsius_Fahrenheit          -> Act2.sln
    Act 2  Name Input and Celsius - Fahrenheit Converter

 03_Act3_Sum_Retry_Console           -> Activity3_20260629.sln
    Act 3  Sum, Difference, Product, Quotient and Average (Console with Retry)

 04_Act4_Arithmetic_Machine          -> Activity4_20260703.sln
    Act 4  Arithmetic Machine (Windows Form)

 05_Act5_Ternary_Remarks             -> Ternary2.sln
    Act 5  Ternary Remarks (If Operator)

 06_Act6_Select_Case_Grade           -> IntegrativeProg1_20260715.sln
    Act 6  Select Case Grade Evaluation

 07_Act7_Integrative_Program1        -> IntegProg1_SW20260720.sln
    Act 7  Integrative Program 1 - Interest, Square and Class Average

 08_Act8_The_Message                 -> TheMessage.sln
    Act 8  The Message (MessageBox Options)

 09_Act9_ListView_File_Explorer      -> SW202609301600.sln
    Act 9  ListView File Explorer

 10_Act10_Panel_and_SplitContainer   -> PanelSplitPanelDemo.sln
    Act 10 Panel and SplitContainer Laboratory

 11_Act11_Controls_Collection        -> SW202610021600.sln
    Act 11 Windows Forms Controls (Menu, TreeView, OpenFileDialog and Combined Explorer)

 12_Act12_File_Explorer_Clone        -> PanelSplitDemo.sln
    Act 12 File Explorer Clone

 13_Act13_Integrative_Project_MDI    -> IntegProgProject2026.sln
    Act 13 Integrative Project - School Records with MDI Forms

HOW TO RUN
----------
 1. I-extract muna ang buong zip (right click -> Extract All).
    Huwag mag-run ng .sln mula sa loob ng zip.
 2. Buksan ang folder ng activity, i-double click ang .sln file.
 3. Sa Visual Studio 2010: Build -> Build Solution, tapos F5.
 4. Kung lumabas ang "convert" wizard, ibig sabihin hindi VS2010
    ang gumamit - i-cancel at VS2010 ang gamitin.

WHERE THE NAME APPEARS
----------------------
 Pangalan ng author at BSIT 3B ay nasa lahat ng activity:
 console header at closing line (Act 1-3), form title, banner,
 author label sa designer, About form, MDI status bar, at sa
 Sample Output ng dokumento (bawat activity may Sample Output).

NOTE
----
 Ang lahat ng form ay bagong design. Ang Act 10 (Panel at
 SplitContainer) at Act 12 (File Explorer Clone) ay may bagong
 layout at bagong code kumpara sa orihinal na sample.
"""


def copy_tree(src, dst):
    count = 0
    for root, dirs, files in os.walk(src):
        dirs[:] = [d for d in dirs if d.lower() not in SKIP_DIRS]
        rel = os.path.relpath(root, src)
        target = dst if rel == "." else os.path.join(dst, rel)
        os.makedirs(target, exist_ok=True)
        for name in files:
            if os.path.splitext(name)[1].lower() in SKIP_EXT:
                continue
            shutil.copy2(os.path.join(root, name), os.path.join(target, name))
            count += 1
    return count


def pdf_pages():
    """Page count of the compiled PDF, so START_HERE never shows a stale number."""
    for name in os.listdir(DOCS):
        if name.lower().endswith(".pdf"):
            try:
                import pymupdf
                return str(pymupdf.open(os.path.join(DOCS, name)).page_count)
            except Exception:
                return "?"
    return "?"


def figure_count():
    folder = os.path.join(DOCS, "figures")
    if not os.path.isdir(folder):
        return "0"
    return str(len([f for f in os.listdir(folder) if f.lower().endswith(".png")]))


def main():
    staging = tempfile.mkdtemp(prefix="package-")
    try:
        total = 0

        with open(os.path.join(staging, "START_HERE.txt"), "w",
                  encoding="utf-8", newline="\r\n") as handle:
            handle.write(START_HERE.format(pages=pdf_pages(), figures=figure_count()))

        for name in (PDF, DOCX, "Master_Prompt.md"):
            shutil.copy2(os.path.join(DOCS, name), os.path.join(staging, name))

        figures = os.path.join(staging, "Form_Designs")
        os.makedirs(figures)
        for name in sorted(os.listdir(os.path.join(DOCS, "figures"))):
            shutil.copy2(os.path.join(DOCS, "figures", name),
                         os.path.join(figures, name))

        for folder_name, source in FOLDERS:
            source_path = os.path.join(COMPILATION, source)
            if not os.path.isdir(source_path):
                raise SystemExit("missing activity folder: " + source)
            total += copy_tree(source_path, os.path.join(staging, folder_name))

        if os.path.exists(OUT_ZIP):
            os.remove(OUT_ZIP)

        with zipfile.ZipFile(OUT_ZIP, "w", zipfile.ZIP_DEFLATED) as archive:
            for root, dirs, files in os.walk(staging):
                dirs.sort()
                for name in sorted(files):
                    full = os.path.join(root, name)
                    arc = os.path.relpath(full, staging)
                    archive.write(full, arc)
    finally:
        shutil.rmtree(staging, ignore_errors=True)

    size = os.path.getsize(OUT_ZIP)
    print("wrote %s (%.2f MB, %d activity files)"
          % (OUT_ZIP, size / 1048576.0, total))


if __name__ == "__main__":
    main()
