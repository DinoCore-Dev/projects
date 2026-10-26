# Activity Compilation - eight students, eight separate packages

Repository for the **Integrative Programming** activity compilation (13 activities each),
built for **Visual Studio 2010 / .NET Framework 4.0**.

The repository holds **eight separate, complete compilations** - one folder and one zip each:

| Student | Folder (source) | Download zip |
|---------|-----------------|--------------|
| **Sonajo, Christian Paolo** - BSIT 3B | `SONAJO/` | `Sonajo_ChristianPaolo_Compilation.zip` |
| **Mangalili, Fhetz Jherald** - BSIT 3B | `MANGALILI/` | `Mangalili_FhetzJherald_Compilation.zip` |
| **Lucena, Lyka Joy** - BSIT 3B | `LUCENA/` | `Lucena_LykaJoy_Compilation.zip` |
| **Deguzman, Liza Gaile** - BSIT 3B | `DEGUZMAN/` | `Deguzman_LizaGaile_Compilation.zip` |
| **Pastor, Lorenz James** - BSIT 3B | `PASTOR/` | `Pastor_LorenzJames_Compilation.zip` |
| **Marcos, Angela** - BSIT 3B | `MARCOS/` | `Marcos_Angela_Compilation.zip` |
| **Aniciete, Shane Antoinette** - BSIT 3B | `ANICIETE/` | `Aniciete_ShaneAntoinette_Compilation.zip` |
| **Marcelo, John Carlo** - BSIT 3B | `MARCELO/` | `Marcelo_JohnCarlo_Compilation.zip` |

All eight zips have the same clean layout: the DOCX, the form design figures and one numbered
folder per activity (`01_ ... 13_ ...`). There is no PDF, no `START_HERE.txt` and no `.md` file in
the zip, and no nested second zip. (The PDF and `Master_Prompt.md` stay in each identity's `docs/`
folder in the repo.)

```
<Name>_Compilation.zip
├── <Name>_Activity_Compilation.docx
├── Form_Designs/                          (22 PNG: 11 form designs + 11 sample outputs)
└── 01_Act1_Console_Basics/ ... 13_Act13_Integrative_Project_MDI/
```

Each activity folder is a full Visual Studio 2010 solution (`.sln` + project + designer +
source), without `bin`, `obj` or `.suo`.

### What the document contains

Only four things per activity - nothing else:

1. **Title** - just `Activity N` (no activity name), then one small line with the project, author and course
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

**Document format (DOCX and PDF):** everything is in **Courier New** (the PDF uses the standard
Courier, which has the same metrics). No text colour is set: the DOCX uses *automatic* colour and
the PDF is black. The cover page is, centred: `INTEGRATIVE PROGRAMMING` / `ACTIVITY COMPILATION` /
blank lines / author / `BSIT 3B` / `Subject  :  Integrative Programming` /
`School Year  :  School Year 2026 - 2027` / `Date Submitted  :  October 26, 2026` /
`Submitted to  : Drymlad Rebaja` (`INSTRUCTOR_LINE` in `tools/activities.py`).

> **Note on branches:** this Arena session is bound to one branch
> (`arena/bf05a101-projects`) and cannot create or push a second branch, so the
> compilations are separated **inside this branch** by folder (`SONAJO/`, `MANGALILI/`, `LUCENA/`, `DEGUZMAN/`, `PASTOR/`, `MARCOS/`, `ANICIETE/`, `MARCELO/`)
> and by zip name. Every file of each student lives only in their own folder - nothing is
> shared or overwritten.

---

## The versions are different (colour, layout, quote, photo)

| Student | Folder | Colour theme | Layout code | About quote (verified) |
|---|---|---|---|---|
| Mangalili, Fhetz Jherald | `MANGALILI/` | navy / blue | 0 (original arrangement) | "The only way to do great work is to love what you do." - Steve Jobs (Stanford commencement, 2005) |
| Sonajo, Christian Paolo | `SONAJO/` | dark teal / emerald | 1 | "The best way to predict the future is to invent it." - Alan Kay (1971) |
| Lucena, Lyka Joy | `LUCENA/` | deep violet | 2 | "A ship in harbor is safe, but that is not what ships are built for." - John A. Shedd (*Salt from My Attic*, 1928) |
| Deguzman, Liza Gaile | `DEGUZMAN/` | wine / rose | 3 | "Imagination is more important than knowledge." - Albert Einstein (Saturday Evening Post, 1929) |
| Pastor, Lorenz James | `PASTOR/` | orange / brown | 4 | "Genius is one percent inspiration, ninety-nine percent perspiration." - Thomas Edison |
| Marcos, Angela | `MARCOS/` | green | 5 | "You must do the thing you think you cannot do." - Eleanor Roosevelt (*You Learn by Living*, 1960) |
| Marcelo, John Carlo | `MARCELO/` | olive / lime | 6 | "The only limit to our realization of tomorrow will be our doubts of today." - Franklin D. Roosevelt (1945) |
| Aniciete, Shane Antoinette | `ANICIETE/` | magenta / plum | 7 | "I can accept failure, everyone fails at something. But I can't accept not trying." - Michael Jordan (1994) |

Each identity also has its own app name (**<Surname> Explorer**), its own name / BSIT 3B on every
console header, banner, author label, About form and MDI status strip, and its own photo.

### Layout codes

Every form activity (Acts 4 - 13, all Act 13 forms included) is arranged differently in each
identity. `tools/layout_variants.py <code 0-7>` gives every form three independent layout
operations (bit 0, 1, 2 of the code): left and right blocks swapped, the action bar moved to the
other side of the form, button rows reversed, the rail moved to the right, header title and
author swapped, grid and details swapped on the CRUD forms, photo and text swapped on the About
form, menu items re-ordered, and so on. Only `Location`, `Size`, `Dock`, `TextAlign` and the
order of menu items change; the control names, and therefore the code-behind, stay the same.
Because the eight codes are all different, no two identities share a layout, and the Form
Design and Sample Output pictures in each document show that identity's own arrangement.
The script runs once per folder (marker `tools/layout_code.txt`).

## Activities (same 13 for every student)

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

The other seven identities (Mangalili, Lucena, Deguzman, Pastor, Marcos, Aniciete, Marcelo) carry
the same details with their own author / course identity. Addresses on the About form:

| Student | Address |
|---|---|
| Mangalili, Fhetz Jherald | Olango, Mallig, Isabela |
| Sonajo, Christian Paolo | San Pedro, Mallig, Isabela |
| Marcos, Angela | Olango, Mallig, Isabela |
| Aniciete, Shane Antoinette | Centro 1, Mallig, Isabela |
| Pastor, Lorenz James | Centro 2, Mallig, Isabela |
| Marcelo, John Carlo | Villanueva, San Manuel, Isabela |
| Lucena, Lyka Joy | Villa Concepcion, Roxas, Isabela |
| Deguzman, Liza Gaile | Purok Pag-asa, San Pedro, Mallig, Isabela |

Each identity has its own colour theme, layout code and favourite quote (see the table above) and
its own photo: the original JPG is in `<FOLDER>/photo/`, a resized copy is
`Images/photo.jpg` in the Act 13 project (copied to `bin\\Debug`, shown in `frmAbout`, and drawn
in the Sample Output picture of the About form).

In every version the name appears in the console header and closing line (Act 1-3), the
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

The same two commands work inside the `tools/` folder of every identity.
Requirements: `python-docx`, `reportlab`, `pillow`.

The sample values printed inside the Sample Output pictures live in
`tools/samples.py` (textbox text, label results, ListView rows, TreeView nodes, checked
radio buttons). It uses `{USER}` / `{AUTHOR}` / `{COURSE}` tokens, so the same file works for
every student and the name inside the picture always matches the owner of the folder.

## Changing the name

Per student, the identity lives in `tools/activities.py` (`AUTHOR`, `COURSE`, `SUBJECT`,
`INSTRUCTOR_LINE`, `SCHOOL_YEAR`, `DATE_LINE`), plus the form titles and author labels in
`*.Designer.vb` and the console headers in `Module1.vb`. Then rebuild with the two commands
above. The reusable fill-in prompt is in each student's `docs/Master_Prompt.md`.
