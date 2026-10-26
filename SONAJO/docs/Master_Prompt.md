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
  3. Source Code  - ang PLAIN `.vb` files lang, may label bawat file. Bawal isama ang
     `*.Designer.vb` (design code), ang `My Project/` files, ang `.vbproj`, ang `.sln` at
     ang `app.config` - dahil picture na ang design at sample output, dagdag na haba lang
     ang mga iyon.
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
6B) PICTURE QUALITY (KRITIKAL — ito ang madalas mali)
===========================================================
Dalawang picture kada form activity, at IBA ang hitsura nila:

A) Form Design  = hitsura ng DESIGNER sa Visual Studio 2010
   - dotted alignment grid sa buong client area (8 px ang pagitan)
   - asul na selection border sa gilid ng form at 8 maliliit na puting
     selection handle (4 sulok + 4 gitna ng gilid)
   - WALANG menu strip / status strip na tumatakbo, walang data sa loob ng
     textbox - blangko lahat dahil design pa lang
   - title bar lang ang may teksto, at doon nakalagay ang pangalan

B) Sample Output = hitsura ng TUMATAKBONG app
   - buong window frame: title bar, MenuStrip/ToolStrip/StatusStrip na may
     totoong label (hal. Forms | TreeView File Explorer | ... | Exit)
   - totoong nilalaman: naka-type na halaga sa textbox, resulta sa label,
     totoong rows sa ListView / TreeView / DataGridView (pangalan, type,
     size, petsa), may napindot na radio button, may sample na preview text
   - BAWAL ang grey placeholder bar / pekeng guhit na linya sa loob ng
     ListView, TreeView, ComboBox, o multiline TextBox. Kung wala kang
     sample na data, iwanan itong PUTI at blangko - huwag mag-imbento ng
     guhit.
   - BAWAL ang doble: bawat menu item at status item isang beses lang
     iginuguhit, at walang `&` mnemonic (dapat `Forms`, hindi `&Forms`)
   - Panatilihin ang totoong proporsyon at posisyon mula sa `*.Designer.vb`

Pareho sa dalawang picture:
   - Makikita ang pangalan ng author (title bar, banner, author label, o
     status strip) at ang course
   - Tugma ang sample na data sa code: ang format ng resulta (hal. N4, 0.00),
     ang range (grade 0-100), at ang bilang ng item ("5 item(s)" kung 5 rows)
   - Ang sample values ay nasa `tools/samples.py`, hindi hard coded sa
     renderer, at may `{USER}` / `{AUTHOR}` / `{COURSE}` token
   - Console activities (Act 1-3): text lang, walang picture

Pagkatapos mag-render, buksan ang PNG at tingnan: walang grey bar, walang
putol na teksto, walang kulang na menu, at tama ang pangalan.


===========================================================
6C) ACTIVITY NA MARAMING FORMS (kritikal)
===========================================================
Kapag ang activity ay may higit sa isang form (hal. Panel + SplitContainer,
Controls Collection, MDI project na may frmMain / frmSchedules / frmQuotes /
frmBibleVerses / frmAbout), HINDI sapat ang isang picture lang. Para sa BAWAT form:
   1. pangalan ng form (maliit na linya lang)
   2. Form Design  - picture ng form na iyon
   3. Source Code  - ang `.vb` ng form na iyon
   4. Sample Output - picture ng form na iyon na tumatakbo
Ayos: form 1 buong set, tapos form 2 buong set, at iba pa, ayon sa pagkakasunod ng
orihinal na proyekto. Ang file na walang form (hal. `Application.vb` / Module) ay
Source Code lang, walang picture.
- Isama LAHAT ng forms - kahit ang MDI parent (frmMain, grey na workspace + menu +
  status strip) at ang About form. Huwag piliin ang isa lang bilang kinatawan.
- Ang About form: ilagay ang picture box na may neutral na portrait; ang estudyante
  na ang magpapalit ng litrato sa dokumento (docs/figures/output_actNN_K.png).
- Kapag ang form ay buong gawa sa code (walang Designer.vb), gumawa ng picture-only
  layout sa `tools/figure_sources/<Form>.Designer.vb` na kopya ng code - HINDI ito
  isinasama sa COMPILATION at hindi ipinapakita sa Source Code.
- Ilagay ang pangalan ng author sa title bar ng BAWAT form (hal.
  `Schedules - <Pangalan>  |  <Course>`), hindi lang sa main form.
- Tugma ang sample data sa code: ang seed rows na nasa `SeedSampleData`, ang header
  text ng grid, ang `lbl.Text` ng code (hal. `5 item(s)`, `Storage: ... N record(s)`),
  ang ListView na `Folder` / `.ext` / `N bytes`. Huwag mag-imbento ng ibang format.
- Sa `tools/activities.py`, nakalista ito sa `GROUPS = {numero: [(pangalan,
  [(path, label)], designer o None), ...]}`; sa `tools/samples.py`, may sample ang bawat
  designer path. Idagdag lang doon kapag may bagong form.

===========================================================
7) TOOLS SA REPO (gamitin, huwag magsimula sa zero kung meron na)
===========================================================
- `tools/design_figure.py`     : gumagawa ng Form Design figure mula sa totoong coordinates
                                 ng `*.Designer.vb`. May dalawang mode: `mode="design"`
                                 (dotted grid + asul na selection handles, hitsura ng VS2010
                                 designer) at `mode="running"` (tumatakbong window: title bar,
                                 MenuStrip, StatusStrip, totoong ListView/TreeView/DataGridView
                                 rows). Suportado: Panel, Label, Button, TextBox, ListBox,
                                 ListView, TreeView, DataGridView, ComboBox, DateTimePicker,
                                 RadioButton, CheckBox, GroupBox, SplitContainer, TabControl,
                                 MenuStrip, ToolStrip, StatusStrip
- `tools/activities.py`        : metadata per activity (title, project, files, figures,
                                 output) + AUTHOR / COURSE / SUBJECT / INSTRUCTOR_LINE /
                                 SCHOOL_YEAR / DATE_LINE
- `tools/figure_sources/`      : picture-only layout ng mga form na gawa sa code
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

===========================================================
9) FINAL CHECK (patakbuhin bago mag-report)
===========================================================
1. Walang lumang pangalan:  grep -ri "<dating pangalan>" .   -> walang output
2. Document:
   - bawat form ng multi-form activity ay may sarili nitong Form Design + Source Code + Sample Output
   - pages, at bilang ng pictures (dapat 2 pictures kada form activity)
   - walang "Designer.vb" / "Friend WithEvents" sa teksto ng PDF
   - walang header/footer/page number, walang Table of Contents
   - lahat ng Sample Output ng form activity ay PICTURE, hindi text
3. Pictures: buksan ang `docs/figures/` at tingnan ang 3 random na PNG
   (isang design, isang running, isang may ListView) - walang grey bar
4. Zip: flat ang loob (START_HERE.txt, PDF, DOCX, Master_Prompt.md,
   Form_Designs/, 01_ ... 13_), walang bin/obj/suo, isang zip lang
5. I-report: ano ang binago, saan ang files, download link, at ano ang
   HINDI na-verify (hal. actual build sa Visual Studio)
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
