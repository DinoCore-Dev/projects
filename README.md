# Activity Compilation - Mangalili, Fhetz (BSIT 3B)

This repository holds the Visual Basic .NET activity compilation of
**Mangalili, Fhetz - BSIT 3B** for the subject **Integrative Programming**.

## What is inside

| Path | Content |
|------|---------|
| `COMPILATION/` | The 13 activity projects (VB.NET Console and Windows Forms). `bin`, `obj` and `.suo` files were removed. |
| `docs/Mangalili_Fhetz_Activity_Compilation.docx` | The updated compilation document (editable). |
| `docs/Mangalili_Fhetz_Activity_Compilation.pdf` | The same document as PDF, ready for submission. |
| `docs/figures/` | The form design figures used inside the document. |
| `COMPILATION_Mangalili_Fhetz.zip` | A clean zip of `COMPILATION/` for uploading or submitting. |
| `tools/` | The Python scripts that generated the figures and the documents. |
| `COMPILATION.zip` | The original archive that was uploaded (left untouched for reference). |

## Activities

1. `Act1_Activity202606241600` - console basics and data types
2. `Act2 Celcius-Fahrenheit Converter` - name input and temperature converter
3. `Activity3_20260629` - sum, difference, product, quotient and average (console with retry)
4. `Activity4_20260703` - Arithmetic Machine (**new form design and code**)
5. `Act5 / Ternary2` - ternary remarks (**new form design and code**)
6. `Act6_IntegProg1_20260715` - Select Case grade evaluation (**new form design and code**)
7. `Act7_IntegProg1_SW20260720` - integrative program 1 (interest, square, class average)
8. `Act8_SW20260805` - The Message, MessageBox options (**new form design and code**)
9. `SW202609301600` - ListView file explorer
10. `SW20261002` - Panel Playground and Split Container Lab (**both forms and code rewritten**)
11. `SW202610021600` - TabControl collection of ListView, TreeView and file dialogs
12. `FileExplorerClone / PanelSplitDemo` - Mangalili Explorer (**design and code rewritten**)
13. `IntegProgProject2026` - MDI integrative project (Schedules, Quotes, Bible Verses, About)

## Names and details used

* Author: **Mangalili, Fhetz**
* Course, year and section: **BSIT 3B**
* Subject: **Integrative Programming**
* Submitted to: blank line in the document, ready to be filled in
* School year: **2026 - 2027**

Every form title, banner, About form and console header now carries the new name and course.
The old `Alvarez, Rex` entries were replaced everywhere (console programs, form banners, the
About form, `frmMain` user info and `app.config`).

## Rebuilding the documents

```bash
python3 tools/build_documents.py
```

The script reads the source files from `COMPILATION/`, draws one layout figure per form
design straight from the coordinates inside `Form1.Designer.vb`, and rewrites both the DOCX
and the PDF inside `docs/`. Requirements: `python-docx`, `reportlab` and `pillow`.

## Opening the projects

Every project is a classic Visual Basic .NET Windows Forms project (`ToolsVersion 4.0`,
.NET Framework 4.0 Client Profile). Open the `.sln` file of an activity in Visual Studio
(2010 or newer, with the .NET Framework 4.0 developer pack installed) and press F5.
