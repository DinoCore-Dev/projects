# MASTER PROMPT — Activity Compilation (reusable)

Copy everything inside the box below, replace the `[...]` placeholders, and paste it as one
message. It reproduces exactly the compilation that is already in this repository.

---

```text
Ikaw ay aking coding agent. Gawin mo ang activity compilation ko para sa subject namin,
kasama ang bagong compilation document (DOCX + PDF). Sundin ito nang eksakto:

## 1. Ako at ang subject
- Pangalan (author): [Mangalili, Fhetz]
- Course, Year and Section: [BSIT 3B]
- Subject: [Integrative Programming]
- Instructor (ilalagay sa "Submitted to"): [BLANK / pangalan ng instructor]
- School Year / Date Submitted: [School Year 2026 - 2027] / [October 26, 2026]

## 2. Kunin ang code
- Kunin/nakopya ang lahat ng activities sa repo ko (folder COMPILATION/ o ang zip na upload ko).
- Isama ang lahat ng projects, pero alisin ang `bin/`, `obj/`, `*.suo`, `*.user`.
- Panatilihin ang orihinal na pangalan ng projects at folders (hal. Activity4_20260703,
  Act5/Ternary2, SW20261002/PanelSplitPanelDemo, FileExplorerClone/PanelSplitDemo).
- Huwag baguhin ang original na upload/zip; gawa lang ng malinis na kopya at ng bagong zip
  na pangalan ay COMPILATION_<Apelyido>_<Pangalan>.zip (walang bin/obj/suo).

## 3. Palitan ang identity (LAHAT, walang iiwan)
Palitan ang dating author/course sa **lahat** ng lugar, hindi lang sa malalaking activity:
- console programs (Activity 1, 2, 3): header sa umpisa (activity name + `Author: ...` +
  `Course Year Section: ...`) at closing line sa dulo na may pangalan mo;
- form title (`Me.Text`), banner/rail labels, About form, `frmMain` toolstrip user info,
  `app.config` (UserInfo), at status line kung meron;
- mga form na walang author label (hal. Activity 7, 9, 11, 13): dagdagan ng author label sa
  design (hindi lang sa code) para makita sa screenshot — Activity 7 at 9 sa ibaba ng form,
  Activity 11 sa status line at sa answers tab, Activity 13 sa main form title at About form;
- sample output sa document ay dapat may pangalan mo na rin.
Walang dapat maiwang "Alvarez", "Rex", o lumang course sa buong repo.

## 4. Bagong design + bagong code (huwag kopyahin ang sample)
Para sa mga activity na ito, **baguhin ang form design at ang code** (bago ang layout, bago
ang structure ng code, pero pareho pa rin ang aral/lesson at parehong feature set):
- Activity 4 (arithmetic): 2-panel card layout na may dark banner, isang `ReadInputs()`
  validation function, `ShowResult()` formatting, division-by-zero guard.
- Activity 5 (ternary): side rail + 3 result cards, Enter key = evaluate, card color feedback.
- Activity 6 (Select Case): input card + malaking average badge + 3 remark rows, isang
  `ReadGrades()` validation, 0–100 range check.
- Activity 8 (MessageBox): compose card + 3 option cards (hindi magkapatong na GroupBox),
  helper functions para sa icon/buttons/default button/result.
- Activity 10 (Panel / SplitContainer): dalawang form — "Panel Playground" (nav rail,
  workspace, API inspector, event log na may counter) at "Split Container Lab" (categories,
  records, details, reset layout, ratio-based `SetRatioDistance`).
- Activity 12 (File Explorer clone): gawing bagong app (hal. "<Apelyido> Explorer") na may
  Back/Forward history stack, address bar + Go, live filter, numeric column sorting, safe
  image preview (i-dispose ang lumang bitmap), text preview limit, at layout buttons para sa
  nested splitters.
- Sa lahat ng binagong form: bagong pangalan ng controls kung kailangan, may validation,
  may status message, at may author label/title.

## 5. Compatibility (kritikal)
- Visual Studio **2010** dapat lahat: solution format 11.00 (`# Visual Studio 2010`),
  `ToolsVersion="4.0"`, `.NET Framework 4.0` (Client Profile), VB 2010 language level.
- Bawal: string interpolation (`$"..."`), `Await`/`Async`, iterator method, multiline lambda,
  NuGet/third-party DLL, C#-only syntax, `NameOf`.
- I-check: bawat control na ginagamit sa code ay may `Friend WithEvents` declaration sa
  designer at naidagdag sa container; balanced ang `Sub/End Sub`, `Try/End Try`,
  `Select/End Select`, `If/End If`, `Using/End Using`, at parentheses.

## 6. Compilation document (DOCX + PDF)
Gawa ng bagong document (huwag i-edit ang PDF ng iba) na may:
- cover page (subject, "ACTIVITY COMPILATION", pangalan + course, subject, submitted to,
  school year, date);
- Table of Contents na clickable/bookmarked;
- "How to open and run the projects" (VS2010 / .NET 4.0 notes);
- isang section kada activity: Description, Objectives, **Form Design figure**, Source Code,
  Sample Output, Notes;
- Appendix A: listahan ng files per project; Appendix B: ano ang binago sa compilation;
- header at footer na may pangalan mo at page number.
- Ang Form Design figures ay gawin mula sa totoong coordinates ng `*.Designer.vb`
  (script na `tools/design_figure.py` + `tools/build_documents.py`), tapos i-generate ulit
  ang DOCX at PDF (`python3 tools/build_documents.py`).
- I-verify: walang blankong page, walang putol na code block, walang lumang pangalan.

## 7. Deliverables at report
- `COMPILATION/` (malinis), `COMPILATION_<Apelyido>_<Pangalan>.zip`
- `docs/<Apelyido>_<Pangalan>_Activity_Compilation.docx` at `.pdf` + `docs/figures/`
- `tools/` (generator scripts)
- Updated `README.md`
- I-commit at i-push sa branch ko, tapos i-report: ano ang binago per activity, saan ko
  hahanapin ang files, at ano ang hindi na-verify (hal. actual build sa Visual Studio).
```

---

## Notes para sa akin (hindi bahagi ng prompt)

* Ang lahat ng nabanggit sa itaas ay nagawa na sa repository na ito: `COMPILATION/`,
  `docs/Mangalili_Fhetz_Activity_Compilation.docx`, `docs/...pdf`, `docs/figures/`,
  `COMPILATION_Mangalili_Fhetz.zip`, at `tools/`.
* Kapag may bagong activity na idadagdag, ilagay lang ang metadata sa `tools/activities.py`
  (description, objectives, files, figures, output) tapos patakbuhin ang
  `python3 tools/build_documents.py`.
* Kung may babaguhin sa identity (pangalan, course, instructor), dalawang lugar lang:
  `tools/activities.py` (para sa document) at ang mismong `Me.Text` / label texts sa
  `*.Designer.vb` at console `Module1.vb` (para sa programs).
