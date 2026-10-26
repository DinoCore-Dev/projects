# Activity Compilation - two students, two separate packages

Repository for the **Integrative Programming** activity compilation (13 activities each),
built for **Visual Studio 2010 / .NET Framework 4.0**.

The repository holds **two separate, complete compilations** - one folder and one zip each:

| Student | Folder (source) | Download zip |
|---------|-----------------|--------------|
| **Sonajo, Christian Paolo** - BSIT 3B | `SONAJO/` | `Sonajo_ChristianPaolo_Compilation.zip` |
| **Mangalili, Fhetz** - BSIT 3B | `MANGALILI/` | `Mangalili_Fhetz_Compilation.zip` |

Both zips have the same clean layout: the PDF, the DOCX, the master prompt, the form
design figures and one numbered folder per activity (`01_ ... 13_ ...`), with a
`START_HERE.txt` guide at the top. Nothing else, and no nested second zip.

```
<Name>_Compilation.zip
├── START_HERE.txt
├── <Name>_Activity_Compilation.pdf        (67 pages, ito ang ipapasa)
├── <Name>_Activity_Compilation.docx
├── Master_Prompt.md
├── Form_Designs/                          (22 PNG: 11 form designs + 11 sample outputs)
└── 01_Act1_Console_Basics/ ... 13_Act13_Integrative_Project_MDI/
```

Each activity folder is a full Visual Studio 2010 solution (`.sln` + project + designer +
source), without `bin`, `obj` or `.suo`.

### What the document contains

Only four things per activity - nothing else:

1. **Title** - activity number, title, and one small line with the project, author and course
2. **Form Design** - picture of the **Visual Studio 2010 designer**: dotted alignment grid,
   blue selection border and eight resize handles (form activities only)
3. **Source Code** - only the plain `.vb` files, one labelled block each. The designer code
   (`*.Designer.vb`), `My Project/`, `.vbproj` and `.sln` are never printed - the design is
   already a picture and the code list would only add pages
4. **Sample Output** - picture of the **running program** for form activities: title bar,
   menu strip and status strip, typed values in the textboxes, results on the labels, real
   rows in the ListView / TreeView / DataGridView, a selected radio button - and the console
   text for Activities 1, 2 and 3

Activities with several forms (10, 11 and 13) repeat the same three parts **once per form**:
Form Design picture, the form's own `.vb`, and its Sample Output picture - for example Activity 13 has
`frmMain`, `frmSchedules`, `frmQuotes`, `frmBibleVerses` and `frmAbout`, each with its own set.

No grey placeholder bars are ever drawn: an empty list stays white instead of showing fake
rows, so the picture always looks like the real program.

There is **no** table of contents, no description, no objectives, no notes, no appendices,
and no page header or footer. Only a plain cover page at the front.

> **Note on branches:** this Arena session is bound to one branch
> (`arena/bf05a101-projects`) and cannot create or push a second branch, so the two
> compilations are separated **inside this branch** by folder (`SONAJO/`, `MANGALILI/`)
> and by zip name. Every file of each student lives only in their own folder - nothing is
> shared or overwritten.

---

## The two versions are visually different

| | Sonajo, Christian Paolo | Mangalili, Fhetz |
|---|---|---|
| Colour theme | dark teal / emerald (`#0C4A45`, `#059669`, `#CCFBF1`) | navy / blue (`#1E293B`, `#2563EB`, `#E2E8F0`) |
| Document accent | teal headings and rules | navy headings and rules |
| File explorer app name | **Sonajo Explorer** | **Mangalili Explorer** |
| Console headers, banners, author labels, About form, MDI status strip | Sonajo, Christian Paolo / BSIT 3B | Mangalili, Fhetz / BSIT 3B |

Same lesson content and same feature set, different presentation and different colour
identity, so the two submissions do not look like copies of each other.

## Activities (same 13 for both students)

| # | Folder inside the zip | Solution file | Title |
|---|----------------------|---------------|-------|
| 1 | `01_Act1_Console_Basics` | `Activity202606241600.sln` | Console basics and data types |
| 2 | `02_Act2_Celsius_Fahrenheit` | `Act2.sln` | Name input and Celsius - Fahrenheit converter |
| 3 | `03_Act3_Sum_Retry_Console` | `Activity3_20260629.sln` | Sum, difference, product, quotient, average (console with retry) |
| 4 | `04_Act4_Arithmetic_Machine` | `Activity4_20260703.sln` | Arithmetic Machine |
| 5 | `05_Act5_Ternary_Remarks` | `Ternary2.sln` | Ternary remarks |
| 6 | `06_Act6_Select_Case_Grade` | `IntegrativeProg1_20260715.sln` | Select Case grade evaluation |
| 7 | `07_Act7_Integrative_Program1` | `IntegProg1_SW20260720.sln` | Integrative program 1 (interest, square, class average) |
| 8 | `08_Act8_The_Message` | `TheMessage.sln` | The Message, MessageBox options |
| 9 | `09_Act9_ListView_File_Explorer` | `SW202609301600.sln` | ListView file explorer |
| 10 | `10_Act10_Panel_and_SplitContainer` | `PanelSplitPanelDemo.sln` | Panel Playground and Split Container Lab |
| 11 | `11_Act11_Controls_Collection` | `SW202610021600.sln` | Menu form that opens the TreeView, OpenFileDialog and combined explorer forms |
| 12 | `12_Act12_File_Explorer_Clone` | `PanelSplitDemo.sln` | File explorer clone (Back/Forward history, filter, preview) |
| 13 | `13_Act13_Integrative_Project_MDI` | `IntegProgProject2026.sln` | MDI integrative project (Schedules, Quotes, Bible Verses, About) with a SQL Server Compact database (`bin\Debug\projectDB.sdf`) |

Activities 4, 5, 6, 8, 10 and 12 carry **new form designs and new code** (not the layout of
the original sample): card layouts, validation helpers, status lines, author labels, and in
Act 12 the Back/Forward history, live filter, column sorting and safe image preview.

### Act 13 database
The three CRUD forms store their data in `projectDB.sdf` (SQL Server Compact 3.5) inside `bin\Debug`,
as in the original project. The file is created automatically on the first run (database, tables
and sample records), so it is not inside the zip. Add, Update and Delete run real parameterised
`INSERT` / `UPDATE` / `DELETE` statements. If SQL Server Compact 3.5 is not installed, each form falls
back to its own XML file so the program still runs (`lblDatabase` shows which one is in use).

## Identity used

**Sonajo, Christian Paolo - BSIT 3B** (`SONAJO/`)
* Author: Sonajo, Christian Paolo
* Course, year and section: BSIT 3B
* Subject: Integrative Programming
* Submitted to: blank line, ready to be filled in
* School year: 2026 - 2027

**Mangalili, Fhetz - BSIT 3B** (`MANGALILI/`)
* Same details with the author / course identity of Mangalili, Fhetz.

In both versions the name appears in the console header and closing line (Act 1-3), the
form title, the banner or rail, an author label inside the designer, the About form, the MDI
status strip, and in the **Sample Output of every activity** in the document.

## Opening and running

Extract the zip first, then open the `.sln` of an activity in **Visual Studio 2010**
(or a newer Visual Studio that still targets .NET Framework 4.0) and press F5.

Solutions are `Format Version 11.00 / # Visual Studio 2010`, projects use
`ToolsVersion="4.0"` with `v4.0` target framework, and the code stays inside the VB 2010
language level (no string interpolation, no `Async`/`Await`, no iterators, no multiline
lambdas). No NuGet package or third party DLL is needed.

## Rebuilding

Each folder is self-contained (`COMPILATION/`, `docs/`, `tools/`):

```bash
# documents and figures of one student
python3 SONAJO/tools/build_documents.py

# the single download zip of one student (written to the repository root)
python3 SONAJO/tools/build_package.py
```

The same two commands work inside `MANGALILI/tools/` for the other compilation.
Requirements: `python-docx`, `reportlab`, `pillow`.

The sample values printed inside the Sample Output pictures live in
`tools/samples.py` (textbox text, label results, ListView rows, TreeView nodes, checked
radio buttons). It uses `{USER}` / `{AUTHOR}` / `{COURSE}` tokens, so the same file works for
both students and the name inside the picture always matches the owner of the folder.

## Changing the name

Per student, the identity lives in `tools/activities.py` (`AUTHOR`, `COURSE`, `SUBJECT`,
`INSTRUCTOR_LINE`, `SCHOOL_YEAR`, `DATE_LINE`), plus the form titles and author labels in
`*.Designer.vb` and the console headers in `Module1.vb`. Then rebuild with the two commands
above. The reusable fill-in prompt is in each student's `docs/Master_Prompt.md`.
