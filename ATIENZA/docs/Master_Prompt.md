# MASTER PROMPT — Activity Compilation (reusable, ilagay lang ang bagong pangalan)

**Paano gamitin:** kopyahin ang LAHAT ng nasa loob ng code block sa ibaba, palitan lang ang
9 na linya sa `1) IDENTITY` (pangalan, course, subject, instructor, SY, date, paboritong quote, address, litrato), tapos i-send.
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
- Pangalan (author)            : [Atienza, Argielyn]
- Course, Year and Section     : [BSIT 3B]
- Subject                      : [Integrative Programming]
- Instructor (Submitted to)    : [Drymlad Rebaja]
- School Year                  : [School Year 2026 - 2027]
- Date Submitted               : [October 26, 2026]
- Paboritong quote (About)     : ["Alone we can do so little; together we can do so much." - Helen Keller]
                                 (kung blangko: hanapin online ayon sa 3 c2)
- Address (About)              : [Marcos, Roxas, Isabela]
                                 (palitan ang `lblAddress` ng `frmAbout`; kapag wala pa, iwan ang placeholder)
- Litrato (About)              : [photo/ATIENZA, ARGIELYN.jpg]
                                 (JPG ng estudyante; ilagay sa folder na `photo/` ng identity)

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
c2) Paboritong quote sa About form (`lblQuote` ng `frmAbout`, Act 13): MAGKAIBA sa bawat
   identity. Kung walang ibinigay na quote sa seksyon 1, MAG-SEARCH ONLINE ng totoong quote
   (INSPIRATIONAL: tiyaga, pangarap, pag-aaral, tapang), at gumamit ng quote na may malinaw na
   pinagmulan (i-verify sa web search; iwasan ang mga kilalang maling-attribute na quote)
   - Format: `"quote" - Awtor`, isang linya lang ang teksto (kasya sa 300 x 80 na label,
     humigit-kumulang 100 character)
   - Sa VB designer, ang panipi ay `""` (`Me.lblQuote.Text = """quote"" - Awtor"`); iwasan
     ang `&` sa teksto (nawawala ito dahil mnemonic ng Label)
   - Huwag gamitin ang quote ng ibang identity na nasa repo (ihambing sa lahat ng
     `frmAbout.Designer.vb`), at huwag iwan ang quote ng dating author
   - Dapat lumabas din ito sa Sample Output picture ng `frmAbout`
c3) Litrato sa About form (`PictureBox1` ng `frmAbout`, Act 13): ang JPG ng estudyante.
   - Kopyahin ang orihinal sa `photo/<APELYIDO, PANGALAN>.jpg` ng identity folder
   - Gumawa ng maliit na bersyon (hanggang 640 px ang pinakamahabang gilid, JPEG quality ~88)
     at ilagay sa `COMPILATION/IntegProgProject2026/IntegProgProject2026/Images/photo.jpg`;
     nasa `.vbproj` ito bilang `<Content ... CopyToOutputDirectory=PreserveNewest>`
   - Sa `frmAbout.vb`, binabasa ang `Application.StartupPath\\Images\\photo.jpg` at inilalagay sa
     `PictureBox1` (`SizeMode = Zoom`). BAWAL ang mahabang Base64 string sa code at hindi dapat
     mag-crash kapag nawawala ang file
   - Dapat lumabas ang totoong litrato sa Sample Output picture ng `frmAbout`
     (`{PHOTO}` token sa `tools/samples.py`)
   - Huwag gamitin ang litrato ng ibang identity
d) Compilation document: cover page, header, footer, Appendix B at LAHAT ng Sample Output.
e) Final check: `grep -ri "<dating pangalan>"` — walang dapat mahanap sa buong repo.

c4) LAYOUT NG MGA FORM (Act 4 - 13): MAGKAIBA ang layout ng bawat identity sa lahat ng iba
   pang identity sa repo - hindi sapat ang kulay lang.
   - Gamitin ang `tools/layout_variants.py <LAYOUT CODE 0-15>` (isang beses lang bawat identity;
     may marker na `tools/layout_code.txt`). Bawat form ay may 4 operations (op0, op1, op2, op3):
     palitan ng puwesto ang kaliwa/kanang bloke, ilipat ang action bar sa itaas/ibaba, baligtarin
     ang hanay ng buttons, rail sa kanan, header na baliktad, at ang pagkakasunod ng menu items.
     Bit 0/1/2/3 ng code = op0/op1/op2/op3 (ang op3 ay unang inaapply). Walang pareho ang mga code, kaya magkakaiba ang layout ng lahat.
   - Walang laman ng repo ang pwedeng may parehong code. Mga code ngayon: ATIENZA 0, SONAJO 1,
     LUCENA 2, DEGUZMAN 3, PASTOR 4, MARCOS 5, MARCELO 6, ANICIETE 7, ATIENZA 8, ALAP 9. Ang bagong
     identity ay gumagamit ng susunod na hindi pa nagagamit (10 hanggang 15 ay may op3 na; lampas 15:
     dagdagan ang op ng bawat form).
   - Pangalan ng controls ang ginagamit ng code, kaya Location / Size / Dock lang ang nagbabago;
     huwag baguhin ang logic. I-rebuild ang `docs/figures` pagkatapos para tumugma ang Form Design
     at Sample Output pictures sa bagong layout.
c5) FONT AT BUTTON STYLE (Act 4 - 13): MAGKAIBA rin ang font family at itsura ng buttons ng bawat
   identity. Fonts na available lang sa MS Visual Studio 2010 / Windows ang gamit (walang kailangang i-install).
   - Gamitin ang `tools/style_variants.py <STYLE CODE>` (isang beses lang bawat identity; marker na
     `tools/style_code.txt`; pareho ng numero ng LAYOUT CODE). Pinapalitan nito ang font family ng lahat
     ng `*.Designer.vb` at ng `New Font(...)` sa code, nilalagyan ng font ang mga controls na wala pa,
     at inaayos ang itsura ng Button (FlatStyle, border, kulay mula sa accent ng identity).
   - Pagkatapos, automatic na `fit_fonts`: kapag mas malapad ang bagong font sa label / button / tab,
     liliit ang font (hanggang 6.5 pt) o lilipat pakaliwa ang label para walang sumobra o magpatong.
     Kung may kailangan lang ulitin: `python3 tools/style_variants.py --fit-only`.
   - Talahanayan (code - family - button style): 0 Segoe UI solid; 1 Courier New border2; 2 Georgia ghost2;
     3 Verdana bevel; 4 Calibri popup; 5 Cambria thin; 6 Times New Roman native; 7 Arial ghost3;
     8 Consolas tonal; 9 Tahoma heavy. Bagong identity: kunin ang susunod na code at idagdag ang
     family sa `STYLES` at `FONT_TABLE` (kasama ang TTF na pamalit sa `tools/fonts/` para sa figure).
   - Ang figure ay gumagamit ng metric-compatible na pamalit (Cousine, Gelasio, Carlito, Caladea, Arimo, Tinos,
     Inconsolata, Open Sans); ang Windows na ang gagamit ng totoong font sa VS2010. Bago mag-rebuild ng docs,
     tapusin muna ang layout_variants at style_variants.


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
  1. Title  (`Activity N` lang - WALANG pamagat ng activity - + isang maliit na linya: project name | author | course)
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
Windows Forms Controls, MDI project na may frmMain / frmSchedules / frmQuotes /
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
- Ang About form: nasa picture box ang totoong litrato ng estudyante (tingnan ang c3).
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
6D) DATABASE NG ACT 13 (kritikal) - projectDB.sdf
===========================================================
May basic CRUD ang Act 13 (`frmSchedules`, `frmQuotes`, `frmBibleVerses`), kaya DAPAT may
totoong database, parehong gaya ng original, at PAREHO sa lahat ng identity:
- Ang database ay SQL Server Compact 3.5 at ang file ay `projectDB.sdf` sa `bin\Debug`
  (`Application.StartupPath`). ISANG file, tatlong table: `Schedules`, `Quotes`, `BibleVerses`.
- Awtomatiko ito: pagbukas ng form, kung walang `projectDB.sdf` ay ginagawa ito ng program
  (`SqlCeEngine.CreateDatabase`), ginagawa ang table (`CREATE TABLE ... IDENTITY(1,1)`) at nilalagyan
  ng sample records kung walang laman. Walang `.sdf` sa zip dahil hindi ito mabubuo nang
  walang SQL CE - ginagawa ito sa unang takbo.
- Totoong SQL ang CRUD: `INSERT` (+ `SELECT @@IDENTITY` para sa bagong ID), `UPDATE ... WHERE`,
  `DELETE ... WHERE`, `SELECT ... ORDER BY`. Gumamit ng parameters (`@p1`, `@id`), hindi
  string concatenation.
- Walang compile-time reference sa `System.Data.SqlServerCe`. Gamitin ang
  `DbProviderFactories.GetFactory("System.Data.SqlServerCe.3.5")` at reflection para sa
  `SqlCeEngine`, para mag-compile pa rin sa VS2010 kahit walang SQL CE. Nasa `app.config` ang
  `<system.data><DbProviderFactories>` entry at
  `<startup useLegacyV2RuntimeActivationPolicy="true">`.
- Fallback: kung walang SQL CE ang computer, XML file kada form (`projectDB_Schedules.xml`,
  `projectDB_Quotes.xml`, `projectDB_BibleVerses.xml`) ang gagamitin para hindi mag-crash.
- Ipinapakita ng `lblDatabase` ang totoong path (`Storage: ...\bin\Debug\projectDB.sdf | N record(s)`) -
  ganito rin ang nasa Sample Output sa `tools/samples.py`.
- Huwag ibalik ang OleDb / ADOX at huwag gawing mirror lang ang `.sdf`.
- Kapag nagpalit ng identity, huwag galawin ang database code. Pangalan lang ang pinapalitan.

===========================================================
6E) FORMAT NG DOCS (DOCX at PDF)
===========================================================
- Heading ng bawat activity: `Activity N` lang (walang pamagat).
- Font: Courier New sa buong DOCX at PDF. Awtomatikong kulay ng text (walang explicit na kulay
  sa DOCX; itim sa PDF).
- Page 1 (naka-center): INTEGRATIVE PROGRAMMING / ACTIVITY COMPILATION / apat na blankong linya /
  <Author> / BSIT 3B / `Subject  :  Integrative Programming` /
  `School Year  :  School Year 2026 - 2027` / `Date Submitted  :  October 26, 2026` /
  `Submitted to  : Drymlad Rebaja`. Ang instructor ay nasa `INSTRUCTOR_LINE` ng `tools/activities.py`.

===========================================================
7) TOOLS SA REPO (gamitin, huwag magsimula sa zero kung meron na)
===========================================================
- `tools/style_variants.py`    : font family + button style + fit (c5)
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
- `tools/build_documents.py`   : binubuo ang `docs/figures/*.png`, ang DOCX at ang PDF (Courier New,
                                 auto na kulay, cover ayon sa 6E)
- `tools/build_package.py`     : binubuo ang zip (DOCX + activity folders lang)
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
  ang DOCX at `01_ ... 13_ ...` (isang folder kada activity, buong VS2010
  solution). BAWAL sa loob ng zip: ang `Form_Designs/` folder, ang PDF, `START_HERE.txt` at kahit anong `.md` (kasama ang
  `Master_Prompt.md`). Nasa `docs/` lang ng repo ang PDF at ang master prompt.
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
2b. Act 13: `grep -rn "OleDb\|ADOX" COMPILATION/IntegProgProject2026` -> walang output; nasa
   `Forms/frm*.vb` ang `projectDB.sdf` + `INSERT/UPDATE/DELETE`; may `<system.data>` sa `app.config`;
   `lblDatabase` sa Sample Output ay `projectDB.sdf`
2e. Style: `python3 tools/style_variants.py` ay nagamit na (may `tools/style_code.txt`); iba ang font family at
   button style ng identity sa lahat ng iba, at walang label / button na lumalampas sa laki.
2d. Layout: `python3 tools/layout_variants.py` ay nagamit na (may `tools/layout_code.txt`) at
   magkaiba ang code at ang Location/Size/Dock ng mga form sa bawat identity folder; ang quote
   ay inspirational at hindi pareho sa iba.
2c. About: may `Images/photo.jpg` sa Act 13 project, may `photo/<pangalan>.jpg` sa identity folder, at litrato
   ng estudyante (hindi ng iba) ang nasa `output_act13_5.png`
3. Pictures: buksan ang `docs/figures/` at tingnan ang 3 random na PNG
   (isang design, isang running, isang may ListView) - walang grey bar
4. Zip: flat ang loob (DOCX, 01_ ... 13_), WALANG Form_Designs/, PDF / START_HERE.txt / .md,
   walang bin/obj/suo, isang zip lang (`unzip -l <zip> | grep -iE "\.(pdf|md|txt)$"` -> walang output)
4b. Docs: heading ay `Activity N` lang, Courier New, walang explicit na kulay, at ang page 1 ay
   ayon sa seksyon 6E (kasama ang `Submitted to  : Drymlad Rebaja`)
5. I-report: ano ang binago, saan ang files, download link, at ano ang
   HINDI na-verify (hal. actual build sa Visual Studio)
```

---

## Notes para sa akin (hindi bahagi ng prompt)

* Naka-set na sa repo na ito ang lahat: `COMPILATION/`, `docs/`, `tools/`, at ang
  `Atienza_Argielyn_Compilation.zip`.
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
