# Activity Compilation - Mangalili, Fhetz (BSIT 3B)

Visual Basic .NET activity compilation of **Mangalili, Fhetz - BSIT 3B**
for the subject **Integrative Programming**, built for **Visual Studio 2010**
(.NET Framework 4.0).

---

## DOWNLOAD

Isang zip lang ang kailangan. Nasa root ito ng repository:

```
Mangalili_Fhetz_Compilation.zip          <- ito ang i-download at i-extract
```

Sa GitHub: i-click ang file na `Mangalili_Fhetz_Compilation.zip`, tapos
**Download raw file** (o `Code` -> `Download ZIP` para sa buong repo).

Naka-private ang repository na ito, kaya kailangang naka-sign in sa GitHub
ang magda-download. Kapag hindi naka-sign in, `404 Not Found` ang sagot
ng GitHub sa private na repository.

### Ano ang laman ng zip

Lahat ay nasa pinaka-ibabaw ng zip, walang naka-nested na folder at walang
pangalawang zip:

| Laman | Detalye |
|-------|---------|
| `Mangalili_Fhetz_Activity_Compilation.pdf` | Ang compilation document, **69 pages**, ito ang ipapasa |
| `Mangalili_Fhetz_Activity_Compilation.docx` | Parehong document, editable |
| `Master_Prompt.md` | Reusable prompt para kung magbabago ang pangalan |
| `Form_Designs/` | 9 PNG na drawing ng mga form |
| `01_ ... 13_ ...` | Isang folder bawat activity, buong Visual Studio 2010 solution |
| `START_HERE.txt` | Maikling gabay: alin ang bubukasing `.sln` sa bawat activity |

Walang `bin`, `obj` at `.suo` sa loob, kaya malinis at maliit lang.

---

## Activities

| # | Folder sa zip | Solution file | Title |
|---|---------------|---------------|-------|
| 1 | `01_Act1_Console_Basics` | `Activity202606241600.sln` | Console basics and data types |
| 2 | `02_Act2_Celsius_Fahrenheit` | `Act2.sln` | Name input and Celsius - Fahrenheit converter |
| 3 | `03_Act3_Sum_Retry_Console` | `Activity3_20260629.sln` | Sum, difference, product, quotient, average (console with retry) |
| 4 | `04_Act4_Arithmetic_Machine` | `Activity4_20260703.sln` | Arithmetic Machine (**new form design and code**) |
| 5 | `05_Act5_Ternary_Remarks` | `Ternary2.sln` | Ternary remarks (**new form design and code**) |
| 6 | `06_Act6_Select_Case_Grade` | `IntegrativeProg1_20260715.sln` | Select Case grade evaluation (**new form design and code**) |
| 7 | `07_Act7_Integrative_Program1` | `IntegProg1_SW20260720.sln` | Integrative program 1 (interest, square, class average) |
| 8 | `08_Act8_The_Message` | `TheMessage.sln` | The Message, MessageBox options (**new form design and code**) |
| 9 | `09_Act9_ListView_File_Explorer` | `SW202609301600.sln` | ListView file explorer |
| 10 | `10_Act10_Panel_and_SplitContainer` | `PanelSplitPanelDemo.sln` | Panel Playground and Split Container Lab (**both forms and code rewritten**) |
| 11 | `11_Act11_Controls_Collection` | `SW202610021600.sln` | TabControl collection of ListView, TreeView and file dialogs |
| 12 | `12_Act12_File_Explorer_Clone` | `PanelSplitDemo.sln` | Mangalili Explorer (**design and code rewritten**) |
| 13 | `13_Act13_Integrative_Project_MDI` | `IntegProgProject2026.sln` | MDI integrative project (Schedules, Quotes, Bible Verses, About) |

## Names and details used

* Author: **Mangalili, Fhetz**
* Course, year and section: **BSIT 3B**
* Subject: **Integrative Programming**
* Submitted to: blank line in the document, ready to be filled in
* School year: **2026 - 2027**

Every form title, banner, About form and console header carries the new name and course,
and so does the printed **Sample Output** of every activity inside the document.

The name also appears in the activities that had no author label before:

* Activities 1 and 2 - printed at the start of the console output and again on the last line.
* Activity 3 - printed in the header of the console program together with BSIT 3B.
* Activity 7 - new `lblAuthor` label at the bottom right of the form.
* Activity 9 - new `lblAuthor` label beside the item count in the status line.
* Activity 11 - author in the status line of the main form and in the answers tab.
* Activity 13 - author in the main form title, the About form and the MDI status strip.

## Opening the projects

Every project is a classic Visual Basic .NET project (`ToolsVersion 4.0`, .NET Framework 4.0
Client Profile, solution format 11.00 / `# Visual Studio 2010`). Extract the zip first, open
the `.sln` file of an activity in **Visual Studio 2010** (or a newer Visual Studio that still
supports .NET Framework 4.0) and press F5.

The code stays inside the Visual Basic 2010 language level: no string interpolation, no
`Async` / `Await`, no iterator method and no multiline lambda, therefore every project
builds in Visual Studio 2010 without any change. No NuGet package is needed.

Activities 1, 2 and 3 are console applications; the rest are Windows Forms applications.

---

## Files of this repository

| Path | Content |
|------|---------|
| `Mangalili_Fhetz_Compilation.zip` | **The single submission zip** (docs + PDF + all activities) |
| `COMPILATION/` | Working copy of the 13 activity projects, source of the zip |
| `docs/` | The DOCX, the PDF, the figures and `Master_Prompt.md` |
| `tools/` | The Python scripts that build the figures, the documents and the zip |
| `README.md` | This file |

## Rebuilding everything

```bash
python3 tools/build_documents.py     # figures + DOCX + PDF  (needs python-docx, reportlab, pillow)
python3 tools/build_package.py       # rebuilds Mangalili_Fhetz_Compilation.zip
```

## Changing the name

All identity values live in **one place**: `tools/activities.py`
(`AUTHOR`, `COURSE`, `SUBJECT`, `INSTRUCTOR_LINE`, `SCHOOL_YEAR`, `DATE_LINE`), plus the
form titles and author labels inside the `*.Designer.vb` files and the console headers in
`Module1.vb`. After changing them, run the two commands above.

The full reusable prompt that reproduces this whole task is in `docs/Master_Prompt.md`.
