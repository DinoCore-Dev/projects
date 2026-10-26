# MASTER PROMPT — Activity Compilation (reusable, ilagay lang ang bagong pangalan)

**Paano gamitin:** kopyahin ang LAHAT ng nasa loob ng code block sa ibaba, palitan lang ang
6 na linya sa `1) IDENTITY` (pangalan, course, subject, instructor, SY, date), tapos i-send.
Automatic nang susundan ng agent ang natitirang rules — walang ibang i-edit.

Kung ang repo na ito ang gagamitin, puwede ring sabihin lang:
*"Gamitin ang Master Prompt sa docs/Master_Prompt.md. Bagong pangalan: <Pangalan>, <Course>. I-update at i-rebuild lahat tapos bigay ang zip."*

---

```text
Ikaw ay aking coding agent. I-update mo ang buong activity compilation ko at ang compilation
document (DOCX + PDF), tapos bigyan mo ako ng isang zip na pang-download.

===========================================================
1) IDENTITY  (ITO LANG ANG BABAGUHIN KO SA BAWAT BAGONG PASA)
===========================================================
- Pangalan (author)            : [Sonajo, Christian Paolo]
- Course, Year and Section     : [BSIT 3B]
- Subject                      : [Integrative Programming]
- Instructor (Submitted to)    : [BLANK / pangalan ng instructor]
- School Year                  : [School Year 2026 - 2027]
- Date Submitted               : [October 26, 2026]

===========================================================
2) SOURCE NG CODE
===========================================================
- Kunin ang lahat ng activities mula sa repo ko (folder COMPILATION/ o ang zip na upload ko).
- Huwag galawin ang original upload; gumawa ng malinis na kopya.
- Alisin ang `bin/`, `obj/`, `*.suo`, `*.user`.
- Panatilihin ang orihinal na pangalan ng projects at folders
  (hal. Activity4_20260703, Act5/Ternary2, SW20261002/PanelSplitPanelDemo,
  FileExplorerClone/PanelSplitDemo, IntegProgProject2026).
- Huwag mag-alis ng activity: Act 1 hanggang sa huling activity, kumpleto.

===========================================================
3) PALITAN ANG IDENTITY SA LAHAT (WALANG IIWAN)
===========================================================
Palitan ang dating pangalan / course sa lahat ng lugar na ito:
a) Console programs (Activity 1, 2, 3 at iba pang console):
   - header sa umpisa: activity name, `Author: <Pangalan>`, `Course Year Section: <Course>`
   - closing line sa dulo na may pangalan (hal. `Prepared by: <Pangalan>  |  <Course>`)
b) Windows Forms:
   - form title (`Me.Text`) ng bawat form, kasama ang pangalan
   - banner / rail / header labels na may author at course
   - footer o status line kung meron
   - kung wala pang author label ang form, DAGDAGAN sa DESIGN mismo
     (hindi lang sa code) para makita sa screenshot at sa Form Design figure
c) Iba pang lugar: About form (pangalan + course), `frmMain` toolstrip user info,
   `app.config` (UserInfo), MDI main form title, answers/notes tab.
d) Compilation document: cover page, header, footer, Appendix B at LAHAT ng Sample Output.
e) Final check: `grep -ri "<dating pangalan>"` — walang dapat mahanap sa buong repo.

===========================================================
4) BAGONG DESIGN + BAGONG CODE (HUWAG KOPYAHIN ANG SAMPLE)
===========================================================
Baguhin ang form design AT ang code (bago ang layout at structure, pareho pa rin ang lesson
at feature set) para sa mga activity na ito:
- Activity 4  (arithmetic)   : 2-panel card layout + dark banner, isang `ReadInputs()`
                               validation function, `ShowResult()` formatting, division-by-zero guard.
- Activity 5  (ternary)      : side rail + 3 result cards, Enter key = evaluate, card color feedback.
- Activity 6  (Select Case)  : input card + malaking average badge + 3 remark rows, isang
                               `ReadGrades()` validation, 0–100 range check.
- Activity 8  (MessageBox)   : compose card + 3 option cards (hindi magkapatong na GroupBox),
                               helper functions para sa icon / buttons / default button / result.
- Activity 10 (Panel/Split)  : dalawang form — "Panel Playground" (nav rail, workspace,
                               API inspector, event log na may counter) at "Split Container Lab"
                               (categories, records, details, reset layout, ratio-based
                               `SetRatioDistance`).
- Activity 12 (File Explorer): bagong app name (hal. `<Apelyido> Explorer`) na may Back/Forward
                               history stack, address bar + Go, live filter, numeric column
                               sorting, safe image preview (i-dispose ang lumang bitmap),
                               text preview limit, at layout buttons para sa nested splitters.
- Sa lahat ng binagong form: malinaw na control names, validation, status message, at author label.

===========================================================
5) COMPATIBILITY (KRITIKAL) — Visual Studio 2010
===========================================================
- Solution file: `Format Version 11.00` at `# Visual Studio 2010`
- Project file : `ToolsVersion="4.0"`, `<TargetFrameworkVersion>v4.0</TargetFrameworkVersion>`
                 (Client Profile ok), walang NuGet o third-party DLL
- Language level: VB 2010 lang. BAWAL ang string interpolation (`$"..."`), `Async`/`Await`,
  iterator method, multiline lambda, `NameOf`, C#-only syntax
- I-verify bago mag-report:
  * bawat control na ginagamit sa code ay may `Friend WithEvents` sa designer at naidagdag sa container
  * bawat `Handles` ay tumutukoy sa declared na control
  * balanced ang `Sub/End Sub`, `Function/End Function`, `Class/End Class`,
    `Try/End Try`, `Select/End Select`, `If/End If`, `For/Next`, `Using/End Using`,
    at parentheses / quotes sa lahat ng `.vb`

===========================================================
6) COMPILATION DOCUMENT (DOCX + PDF)
===========================================================
Gawa ng bagong document (huwag i-edit ang PDF ng iba). SIMPLE lang ito - apat na bagay
lang kada activity:
  1. Title  (Activity number + title + isang maliit na linya: project name | author | course)
  2. Form Design  - picture ng designer layout, para sa form activities lang
  3. Source Code  - ang totoong source files (may label bawat file)
  4. Sample Output - PICTURE ng tumatakbong form para sa form activities (may sample na
     nakasulat sa textbox, resulta sa label, listahan sa ListView/TreeView, naka-pindot
     na radio button), at TEXT na console output para sa console activities

Bawal sa document (sinadya itong tanggalin):
- Table of Contents / contents page
- Description, Objectives, Notes, "How to open and run the projects"
- Appendix A at Appendix B
- Header at footer, page number sa gilid, watermarks
Lamang ang cover page: subject, "ACTIVITY COMPILATION", pangalan, course, subject,
Submitted to (blank), School Year, Date Submitted.

Ang Sample Output picture ay gawa sa parehong `*.Designer.vb` coordinates, tapos
nilalagyan ng sample values (textbox text, label result, ListView rows, TreeView nodes,
checked radio button) - tingnan ang item 7.

I-verify: walang blankong page, walang putol na code block, walang lumang pangalan,
at LAHAT ng form activity ay may Sample Output picture.

===========================================================
7) TOOLS SA REPO (gamitin, huwag magsimula sa zero kung meron na)
===========================================================
- `tools/design_figure.py`     : gumagawa ng Form Design figure mula sa totoong coordinates
                                 ng `*.Designer.vb` (suportado: Panel, Label, Button, TextBox,
                                 ListView, TreeView, SplitContainer, TabControl, RadioButton)
- `tools/activities.py`        : metadata per activity (title, project, files, figures,
                                 output) + AUTHOR / COURSE / SUBJECT / INSTRUCTOR_LINE /
                                 SCHOOL_YEAR / DATE_LINE
- `tools/samples.py`           : sample values para sa Sample Output picture ng bawat form
                                 activity (textbox text, label results, ListView rows,
                                 TreeView nodes, checked radio button). May {USER} /
                                 {AUTHOR} / {COURSE} token para automatic na napapalitan.
- `tools/build_documents.py`   : binubuo ang `docs/figures/*.png`, ang DOCX at ang PDF
  Command: `python3 tools/build_documents.py`  (kailangan: python-docx, reportlab, pillow)

===========================================================
8) DELIVERABLES + DOWNLOAD + REPORT
===========================================================
- `COMPILATION/`            : malinis na activities (Act 1 hanggang huli)
- `docs/…docx` at `docs/…pdf` : bagong compilation document na may bagong pangalan
- `docs/figures/`           : Form Design at Sample Output pictures
- `tools/`                  : generator scripts
- Updated `README.md`
- ISANG zip na pang-download, flat ang loob (walang nakapaloob na pangalawang zip):
  `START_HERE.txt`, ang PDF, ang DOCX, `Master_Prompt.md`, `Form_Designs/`, at
  `01_ ... 13_ ...` (isang folder kada activity, buong VS2010 solution)
- I-commit at i-push sa branch ko, tapos i-report sa dulo:
  * ano ang binago per activity
  * saan hahanapin ang files
  * ang download link ng zip
  * ano ang HINDI na-verify (hal. actual build sa Visual Studio, kasi walang VS sa sandbox)
```

---

## Notes para sa akin (hindi bahagi ng prompt)

* Naka-set na sa repo na ito ang lahat: `COMPILATION/`, `docs/`, `tools/`, at ang
  `Sonajo_ChristianPaolo_Compilation.zip`.
* Kung bagong pangalan lang ang kailangan, ito ang 2 lugar na binabago ng agent:
  1. `tools/activities.py` → `AUTHOR`, `COURSE`, `SUBJECT`, `INSTRUCTOR_LINE`,
     `SCHOOL_YEAR`, `DATE_LINE`
  2. `Me.Text` / author labels sa `*.Designer.vb` at ang header ng `Module1.vb` (console)
  Tapos `python3 tools/build_documents.py` at `python3 tools/build_package.py`.
* Ang sample na nakikita sa Sample Output picture ay nasa `tools/samples.py`. Kung may
  nabago sa form (bagong textbox o label), dagdagan lang ng value doon.
* Kapag may bagong activity: magdagdag lang ng entry sa `ACTIVITIES` sa
  `tools/activities.py` (title, project, files, figures, output) — automatic nang kasama sa
  document. Kung form activity, dagdagan din ng entry sa `tools/samples.py`.
