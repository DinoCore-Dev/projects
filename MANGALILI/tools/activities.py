"""Activity metadata for the compilation documents of Mangalili, Fhetz."""

AUTHOR = "Mangalili, Fhetz"
COURSE = "BSIT 3B"
SUBJECT = "Integrative Programming"
INSTRUCTOR_LINE = "________________________"
SCHOOL_YEAR = "School Year 2026 - 2027"
DATE_LINE = "October 26, 2026"

# ---------------------------------------------------------------------------
# every entry:
#   number, title, project, folder, description (list of paragraphs),
#   objectives (list), files (list of (path relative to COMPILATION, label)),
#   figures (list of (designer path relative to COMPILATION, caption)),
#   notes (list of paragraphs, optional)
# ---------------------------------------------------------------------------
ACTIVITIES = [
    {
        "number": 1,
        "title": "Console Basics and Data Types",
        "project": "Act1_Activity202606241600",
        "folder": "Act1_Activity202606241600",
        "description": [
            "The first activity is a console application that prints a short greeting and "
            "declares one variable of every basic data type (String, Integer, Double, "
            "Boolean and Char). The program ends with Console.ReadKey() so the console "
            "window stays open until a key is pressed.",
            "The output starts with the activity name, the author (Mangalili, Fhetz) and the "
            "course and section (BSIT 3B), and it ends with a closing line that repeats the "
            "name of the author, so the printed screen already carries the complete identity "
            "of the student.",
        ],
        "objectives": [
            "Create a Visual Basic .NET console application and identify the Module and Sub Main entry point.",
            "Declare variables with the correct data type and assign initial values.",
            "Print output with Console.WriteLine and pause the console with Console.ReadKey.",
        ],
        "files": [("Act1_Activity202606241600/Activity202606241600/Module1.vb", "Module1.vb")],
        "output": [
            "Activity202606241600",
            "Author: Mangalili, Fhetz",
            "Course Year Section: BSIT 3B",
            "",
            "Hello Mangalili, Fhetz",
            "n1        = 0",
            "n2        = 0",
            "isValid   = True",
            "character = A",
            "number1   = 12",
            "number2   = 12.12",
            "",
            "Prepared by: Mangalili, Fhetz  |  BSIT 3B",
        ],
        "notes": [],
    },
    {
        "number": 2,
        "title": "Name Input and Celsius - Fahrenheit Converter",
        "project": "Act2 Celcius-Fahrenheit Converter",
        "folder": "Act2 Celcius-Fahrenheit Converter",
        "description": [
            "This console program asks for the last name and the first name of the user, "
            "prints them back, and then performs two temperature conversions. The first "
            "conversion changes Celsius into Fahrenheit using the formula (C x 1.8) + 32, "
            "and the second conversion changes Fahrenheit into Celsius using "
            "(F - 32) / 1.8.",
        ],
        "objectives": [
            "Read input from the user with Console.ReadLine.",
            "Convert text input into numbers with Convert.ToDecimal.",
            "Apply arithmetic formulas and display the computed results.",
        ],
        "files": [("Act2 Celcius-Fahrenheit Converter/Act2/Module1.vb", "Module1.vb")],
        "output": [
            "Act2 Celcius-Fahrenheit Converter",
            "Author: Mangalili, Fhetz",
            "Course Year Section: BSIT 3B",
            "",
            "Hello world",
            "Enter Lastname: Mangalili",
            "Enter Firstname: Fhetz",
            "Your Lastname is Mangalili",
            "Your Firstname is Fhetz",
            "--- Celsius to Fahrenheit Converter ---",
            "Enter Celsius: 37",
            "Result in Fahrenheit: 98.6",
            "--- Fahrenheit to Celsius Converter ---",
            "Enter Fahrenheit: 98.6",
            "Result in Celsius: 37.0",
            "",
            "Activity 2 completed by: Mangalili, Fhetz  |  BSIT 3B",
        ],
        "notes": [],
    },
    {
        "number": 3,
        "title": "Sum, Difference, Product, Quotient and Average (Console with Retry)",
        "project": "Activity3_20260629",
        "folder": "Activity3_20260629",
        "description": [
            "The program accepts three whole numbers and displays their sum, difference, "
            "product, quotient and average. A Try - Catch block with the label ulit "
            "traps a FormatException, so when the user types a letter instead of a number "
            "the program prints the error message and asks for the three numbers again "
            "instead of closing.",
        ],
        "objectives": [
            "Use Convert.ToInt16 to read three numbers.",
            "Compute the five required results and display them with labels.",
            "Handle invalid input with Try - Catch and a GoTo label so the program repeats.",
        ],
        "files": [("Activity3_20260629/Activity3_20260629/Module1.vb", "Module1.vb")],
        "output": [
            "Activity3_20260629",
            "Author: Mangalili, Fhetz",
            "Course Year Section: BSIT 3B",
            "Enter number 1: 10",
            "Enter number 2: 5",
            "Enter number 3: 2",
            "The sum is: 17",
            "The difference is: 3",
            "The product is: 100",
            "The quotient is: 1",
            "The average is: 5.666666666666667",
        ],
        "notes": [],
    },
    {
        "number": 4,
        "title": "Arithmetic Machine (Windows Form)",
        "project": "Activity4_20260703",
        "folder": "Activity4_20260703",
        "description": [
            "Activity 4 converts the console computation of Activity 3 into a Windows "
            "Form application. The form is divided into an input card, a result card and a "
            "row of action buttons. The three numbers are read once by a shared function, "
            "and every operation button writes its answer in its own result box.",
            "The interface of this activity was redesigned for this compilation: the old "
            "free-floating labels and text boxes were replaced by two bordered panels, a "
            "dark banner that carries the activity number and the author, and colour coded "
            "buttons. The program logic was rewritten as well: a single ReadInputs() "
            "function validates the entries, a ShowResult() routine formats every answer to "
            "four decimal places, and the quotient button checks for division by zero "
            "before it computes.",
        ],
        "objectives": [
            "Design a Windows Form with Panel containers, Labels, TextBoxes and Buttons.",
            "Declare module level variables and use a Function that returns Boolean for validation.",
            "Trap conversion errors with Try - Catch and guard the quotient against division by zero.",
        ],
        "files": [("Activity4_20260703/Activity4_20260703/Form1.vb", "Form1.vb")],
        "figures": [("Activity4_20260703/Activity4_20260703/Form1.Designer.vb",
                     "Form design of Activity 4 - Arithmetic Machine")],
        "output": [
            "Banner      : Arithmetic Machine",
            "Author      : Mangalili, Fhetz   |   BSIT 3B   |   Integrative Programming",
            "",
            "First number  : 10",
            "Second number : 5",
            "Third number  : 2",
            "",
            "Sum        = 17.0000",
            "Difference = 3.0000",
            "Product    = 100.0000",
            "Quotient   = 1.0000",
            "Average    = 5.6667",
            "",
            "Status bar : Average = 5.6667",
            "Footer     : Mangalili, Fhetz  |  BSIT 3B",
        ],
        "notes": [
            "Average is highlighted in blue because it is the summary value of the three "
            "operations above it. Clear returns the form to its start-up state, and Exit "
            "asks for confirmation before the application closes.",
        ],
    },
    {
        "number": 5,
        "title": "Ternary Remarks (If Operator)",
        "project": "Act5 - Ternary2",
        "folder": "Act5",
        "description": [
            "The user types one average grade and the program displays three different "
            "remarks: the pass or fail remark, the letter grade and the numeric rating. "
            "Every result is produced by one nested ternary If expression instead of a long "
            "If - ElseIf block.",
            "For this compilation the form was rebuilt as a two-column layout. The dark side "
            "rail holds the title and the name of the author, while the right side contains "
            "the entry box and three result cards. The code was reorganised into small "
            "procedures (ClearOutputs, ApplyCardColor), the Enter key inside the text box "
            "runs the evaluation, and the first card changes colour depending on the result.",
        ],
        "objectives": [
            "Use the ternary If(condition, truePart, falsePart) operator.",
            "Nest several If operators to build a grading scale.",
            "Validate numeric input with Try - Catch and guide the user with status messages.",
        ],
        "files": [("Act5/Ternary2/Form1.vb", "Form1.vb")],
        "figures": [("Act5/Ternary2/Form1.Designer.vb",
                     "Form design of Activity 5 - Ternary Remarks")],
        "output": [
            "Activity 5  -  Ternary",
            "Author : Mangalili, Fhetz   |   BSIT 3B   |   Integrative Programming",
            "",
            "Average grade : 88",
            "Remarks 1     : Passed        (shown in green)",
            "Remarks 2     : C",
            "Remarks 3     : 2.00",
            "Status        : Average 88 evaluated using nested ternary If operators.",
            "",
            "Other tests",
            "Average grade : 74   ->  Conditional  |  F  |  5.00   (amber)",
            "Average grade : 60   ->  Failed       |  F  |  5.00   (red)",
        ],
        "notes": [
            "Test values that show the boundaries: 75 (Passed / E / 3.00), 74 (Conditional / "
            "F / 5.00) and 98 (Passed / A / 1.00).",
        ],
    },
    {
        "number": 6,
        "title": "Select Case Grade Evaluation",
        "project": "Act6_IntegProg1_20260715",
        "folder": "Act6_IntegProg1_20260715",
        "description": [
            "Three grades are entered and the program computes their average. Three separate "
            "Select Case blocks then convert the average into the pass or fail remark, the "
            "letter grade and the numeric rating.",
            "The form was redesigned for this compilation. The three grade boxes are grouped "
            "in one card on the left, the average is shown in a large dark badge on the right "
            "with three remark rows below it, and the badge changes colour (green, amber or "
            "red) depending on the result. The code was cleaned up so that the old duplicated "
            "button handlers are gone, validation is done by one ReadGrades() function, and "
            "grades outside the 0 to 100 range are rejected.",
        ],
        "objectives": [
            "Compute the average of three grades.",
            "Use Select Case with relational cases (Case Is >=) and ranges (Case 70 To 74).",
            "Present the result with colour coded feedback.",
        ],
        "files": [("Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.vb", "Form1.vb")],
        "figures": [("Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.Designer.vb",
                     "Form design of Activity 6 - Select Case Grade Evaluation")],
        "output": [
            "Banner   : Select Case Grade Evaluation",
            "Author   : Mangalili, Fhetz   |   BSIT 3B",
            "",
            "Grade 1 : 88",
            "Grade 2 : 92",
            "Grade 3 : 85",
            "",
            "Average  : 88.33          (dark badge)",
            "Remarks 1 : Passed!",
            "Remarks 2 : B",
            "Remarks 3 : 2.00",
            "Status    : Average 88.33 evaluated with three Select Case blocks.",
        ],
        "notes": [],
    },
    {
        "number": 7,
        "title": "Integrative Program 1 - Interest, Square and Class Average",
        "project": "Act7_IntegProg1_SW20260720",
        "folder": "Act7_IntegProg1_SW20260720",
        "description": [
            "Activity 7 is a multi-tab integrative exercise. One tab computes compound "
            "interest with a For loop and a NumericUpDown for the number of years, one tab "
            "draws a square out of a fill character using nested For loops, one tab collects "
            "grades in a ListBox and counts the letter grade distribution with Select Case, "
            "and one tab converts the numbers 1 to 255 into octal, hexadecimal and binary.",
        ],
        "objectives": [
            "Use For loops, Do While loops and NumericUpDown values.",
            "Apply Select Case for tallying grades.",
            "Use Convert.ToString(number, base) for number system conversion.",
        ],
        "files": [("Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.vb", "Form1.vb")],
        "figures": [("Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
                     "Form design of Activity 7 - the author label is at the bottom right")],
        "output": [
            "Title  : Activity 7 - IntegProg1_SW20260720  |  Mangalili, Fhetz",
            "Label  : Author: Mangalili, Fhetz   |   BSIT 3B   |   Activity 7",
            "",
            "Tab App: Interest Calculator",
            "  Principal : 1000     Interest rate : 5     Years : 3",
            "  Year   Amount on Deposit",
            "  1      P1,050.00",
            "  2      P1,102.50",
            "  3      P1,157.63",
            "",
            "Tab Decimal Equivalent : 1 1 1 1  ... up to 255",
        ],
        "notes": [],
    },
    {
        "number": 8,
        "title": "The Message (MessageBox Options)",
        "project": "Act8_SW20260805",
        "folder": "Act8_SW20260805",
        "description": [
            "The Message activity collects everything that a MessageBox needs: a title, a "
            "message body, one icon, one button set and one default button. When Display is "
            "clicked the program validates the five groups and then shows the message box "
            "with the selected options. The answer of the user is reported back in another "
            "message box.",
            "The form was redesigned for this compilation from four overlapping GroupBoxes "
            "into a two-column dashboard: a compose card on the left and three option cards "
            "on the right. The code was rewritten with small helper functions - ValidateEntry, "
            "ChosenIcon, ChosenButtons, ChosenDefaultButton and DescribeResult - so that the "
            "long chain of If statements in the original version is no longer needed.",
        ],
        "objectives": [
            "Use MessageBox.Show with a title, message, buttons, icon and default button.",
            "Read DialogResult values and describe the answer of the user.",
            "Validate user entries before showing a dialog.",
        ],
        "files": [("Act8_SW20260805/TheMessage/Form1.vb", "Form1.vb")],
        "figures": [("Act8_SW20260805/TheMessage/Form1.Designer.vb",
                     "Form design of Activity 8 - The Message")],
        "output": [
            "Header : The Message",
            "Author : Mangalili, Fhetz   |   BSIT 3B",
            "",
            "Title   : Saving the record",
            "Message : Do you want to save this record?",
            "Icon    : Question",
            "Buttons : Yes / No / Cancel",
            "Default : Button 1",
            "",
            "Message box  : [Question]  Do you want to save this record?   (Yes) (No) (Cancel)",
            "After click  : [Information]  Yes was clicked.",
            "Status bar   : Yes was clicked.",
        ],
        "notes": [],
    },
    {
        "number": 9,
        "title": "ListView File Explorer",
        "project": "SW202609301600",
        "folder": "SW202609301600",
        "description": [
            "This activity introduces the ListView control. The form lists the folders and "
            "files of the Documents folder with their type and size, and the user can browse "
            "another folder through a FolderBrowserDialog. The Details and List buttons switch "
            "the view, and the menu opens the same form again.",
        ],
        "objectives": [
            "Fill a ListView with folders and files using Directory.GetDirectories and Directory.GetFiles.",
            "Add columns to a ListView and switch between the Details and List views.",
            "Use FolderBrowserDialog to choose a folder.",
        ],
        "files": [
            ("SW202609301600/ListViewSample.vb", "ListViewSample.vb"),
        ],
        "figures": [("SW202609301600/ListViewSample.Designer.vb",
                     "Form design of Activity 9 - the author label shares the status line")],
        "output": [
            "Title      : Activity 9 - ListView File Explorer  |  Mangalili, Fhetz",
            "Path       : C:\\Users\\Mangalili\\Documents",
            "Name                    Type            Modified/Size",
            "Documents               Folder          ...",
            "notes.txt               .txt            1.2 KB",
            "Activity1.docx          .docx           24.6 KB",
            "Status     : 3 item(s)          Author: Mangalili, Fhetz  |  BSIT 3B",
        ],
        "notes": [
            "The form title now reads Activity 9 - ListView File Explorer | Mangalili, Fhetz and "
            "the author label at the bottom right of the form shows Mangalili, Fhetz | BSIT 3B.",
        ],
    },
    {
        "number": 10,
        "title": "Panel and SplitContainer Laboratory",
        "project": "SW20261002 - PanelSplitPanelDemo",
        "folder": "SW20261002",
        "description": [
            "Activity 10 is a laboratory for two container controls. Form1 shows the members of "
            "the Panel control - Visible, BackColor, BorderStyle, BringToFront, SendToBack, "
            "Contains, Focus, Refresh, Invalidate and Dispose - while Form2 shows two nested "
            "SplitContainer controls with collapsing, orientation switching and splitter locking.",
            "Both forms and both code files were completely rebuilt for this compilation. "
            "Instead of the old plain buttons that only changed a status label, Form1 now has a "
            "navigation rail, a workspace with a parent panel and two child panels, an API "
            "inspector and an event log that records every action with a counter. Form2 was "
            "replaced by a Split Container Lab with a category list, a record list, a details "
            "pane, a reset layout button and a ratio based SetRatioDistance helper that keeps "
            "the splitter inside the allowed minimum sizes.",
        ],
        "objectives": [
            "Demonstrate the properties and methods of the Panel control.",
            "Use a vertical and a horizontal SplitContainer, including nested panels.",
            "Collapse, expand, re-orient and lock splitters at run time.",
        ],
        "files": [
            ("SW20261002/PanelSplitPanelDemo/Form1.vb", "Form1.vb  (Panel Playground)"),
            ("SW20261002/PanelSplitPanelDemo/Form2.vb", "Form2.vb  (Split Container Lab)"),
        ],
        "figures": [
            ("SW20261002/PanelSplitPanelDemo/Form1.Designer.vb",
             "Form design of Activity 10 - Panel Playground"),
            ("SW20261002/PanelSplitPanelDemo/Form2.Designer.vb",
             "Form design of Activity 10 - Split Container Lab"),
        ],
        "output": [
            "Panel Playground      -  Author : Mangalili, Fhetz   |   BSIT 3B",
            "01  pnlGroup.Visible = False",
            "02  pnlNested.BackColor changed to blue.",
            "03  Contains -> pnlGroup : True, pnlNested : True, from pnlMain : False",
            "04  pnlNested.Focus() returned True.",
            "    Status bar : 4 action(s) performed",
            "",
            "Split Container Lab   -  Author : Mangalili, Fhetz   |   BSIT 3B",
            "outer : 220 px      inner : 260 px",
            "splOuter.Panel1Collapsed = True",
            "Orientation = Vertical, the inner panels are now left and right.",
        ],
        "notes": [],
    },
    {
        "number": 11,
        "title": "Windows Forms Controls Collection (TabControl, TreeView, ListView, Dialogs)",
        "project": "SW202610021600",
        "folder": "SW202610021600",
        "figures": [("SW202610021600/CombinedSample.Designer.vb",
                     "Combined explorer - TreeView and ListView in one form")],
        "description": [
            "The eleventh activity collects the answers to questions 6 to 9 in one TabControl "
            "based program: a ListView file explorer, a TreeView file explorer, an "
            "OpenFileDialog and SaveFileDialog demonstration, and a combined explorer that "
            "uses the TreeView, the ListView and both dialogs together. One tab lists the "
            "written answers of the assignment.",
        ],
        "objectives": [
            "Build forms completely in code without the designer.",
            "Embed one form inside a TabPage of another form.",
            "Combine TreeView, ListView, OpenFileDialog and SaveFileDialog in one application.",
        ],
        "files": [
            ("SW202610021600/Application.vb", "Application.vb"),
            ("SW202610021600/MainForm.vb", "MainForm.vb"),
            ("SW202610021600/MenuForm.vb", "MenuForm.vb"),
            ("SW202610021600/ListViewSample.vb", "ListViewSample.vb"),
            ("SW202610021600/TreeViewSample.vb", "TreeViewSample.vb"),
            ("SW202610021600/OpenFileDialogSample.vb", "OpenFileDialogSample.vb"),
            ("SW202610021600/CombinedSample.vb", "CombinedSample.vb"),
        ],
        "output": [
            "Title      : Activity 11 - SW202610021600 - Windows Forms Controls  |  Mangalili, Fhetz",
            "Status bar : Author: Mangalili, Fhetz   |   BSIT 3B   |   Activity 11 - SW202610021600",
            "",
            "Tab 1  File explorer + dialogs   -> OpenFileDialog / SaveFileDialog demo",
            "Tab 2  ListView examples         -> folder browsing with Details / List view",
            "Tab 3  TreeView examples         -> drives and directories, loaded on expand",
            "Tab 4  Assignment answers        -> Activity 11 - SW202610021600",
            "                                    Author : Mangalili, Fhetz | BSIT 3B",
        ],
        "notes": [
            "The main form has a status line at the bottom that prints Author: Mangalili, Fhetz | "
            "BSIT 3B, and the same identity is printed at the top of the Assignment answers tab.",
        ],
    },
    {
        "number": 12,
        "title": "File Explorer Clone (PanelSplitDemo)",
        "project": "FileExplorerClone - PanelSplitDemo",
        "folder": "FileExplorerClone",
        "description": [
            "The last activity of the container chapter is a working file explorer. The folder "
            "tree is loaded on demand, the file list shows the name, type, size and date "
            "modified of every item, and the preview pane shows the text of a file, the "
            "picture of an image or the summary of a folder. The layout is built from two "
            "SplitContainer controls: one between the tree and the workspace, and one between "
            "the file list and the preview.",
            "The whole activity was rewritten for this compilation so that the design and the "
            "code are different from the sample. The new name of the program is Mangalili "
            "Explorer. The additions are: a Back and Forward history stack, a Home button, an "
            "editable address bar with a Go button, a live filter box, column sorting that "
            "compares sizes as numbers, hidden files excluded from the list, an image preview "
            "that disposes the previous bitmap before showing a new one, a text preview limited "
            "to 6000 characters, and buttons that hide the tree or the preview and swap the "
            "orientation of the inner splitter.",
        ],
        "objectives": [
            "Combine TreeView, ListView, PictureBox and TextBox inside nested SplitContainers.",
            "Navigate the file system with Directory, File, FileInfo and DirectoryInfo.",
            "Preview text, images and folders safely with error handling.",
        ],
        "files": [("FileExplorerClone/PanelSplitDemo/Form1.vb", "Form1.vb")],
        "figures": [("FileExplorerClone/PanelSplitDemo/Form1.Designer.vb",
                     "Form design of Activity 12 - Mangalili Explorer")],
        "output": [
            "MANGALILI EXPLORER        Author : Mangalili, Fhetz   |   BSIT 3B",
            "",
            "Address bar : C:\\Users\\Mangalili\\Documents",
            "Contents    : 5 item(s)   |   C:\\Users\\Mangalili\\Documents",
            "Preview     : Name : notes.txt    Size : 1.2 KB",
            "              Modified : Oct 26, 2026  9:24 AM",
            "Status bar  : Now browsing : C:\\Users\\Mangalili\\Documents",
        ],
        "notes": [
            "The preview pane keeps the memory safe: every new picture disposes the previous "
            "bitmap, and only the first 6000 characters of a text file are read.",
        ],
    },
    {
        "number": 13,
        "title": "Integrative Project - School Records with MDI Forms",
        "project": "IntegProgProject2026",
        "folder": "IntegProgProject2026",
        "figures": [("IntegProgProject2026/IntegProgProject2026/Forms/frmSchedules.Designer.vb",
                     "Schedule form of the MDI project")],
        "description": [
            "The final activity is the integrative project. A main MDI form holds a menu, a "
            "tool strip that shows the name of the user and a live date and time, and a status "
            "bar. Four child forms are opened inside the main form: Schedules, Quotes, Bible "
            "Verses and About. The record forms read and write their data through a DataTable "
            "that is saved to an XML file, and the About form shows the picture of the "
            "programmer.",
        ],
        "objectives": [
            "Build an MDI parent form with child forms.",
            "Store and load records with DataTable, ReadXml and WriteXml.",
            "Use a MenuStrip, a ToolStrip with a Timer and a StatusStrip.",
        ],
        "files": [
            ("IntegProgProject2026/IntegProgProject2026/Forms/frmMain.vb", "frmMain.vb"),
            ("IntegProgProject2026/IntegProgProject2026/Forms/frmSchedules.vb", "frmSchedules.vb"),
            ("IntegProgProject2026/IntegProgProject2026/Forms/frmQuotes.vb", "frmQuotes.vb"),
            ("IntegProgProject2026/IntegProgProject2026/Forms/frmBibleVerses.vb", "frmBibleVerses.vb"),
            ("IntegProgProject2026/IntegProgProject2026/Forms/frmAbout.vb", "frmAbout.vb"),
        ],
        "output": [
            "Main form  : Integrative Project 2026 - Mangalili, Fhetz  |  BSIT 3B",
            "Status strip: UserInfo: Mangalili, Fhetz  |  BSIT 3B",
            "              CurrentDate: Monday, 26 October 2026",
            "              Current Time: 9:24:41 AM",
            "",
            "Menu -> Schedules     : opened inside the main form",
            "Menu -> Quotes        : opened inside the main form",
            "Menu -> Bible Verse   : opened inside the main form",
            "Menu -> About         : About - Mangalili, Fhetz",
        ],
        "notes": [
            "The title of the main form now reads Integrative Project 2026 - Mangalili, Fhetz | "
            "BSIT 3B and the About form is titled About - Mangalili, Fhetz.",
            "The long Base64 picture data inside frmAbout.vb is left out of this document so "
            "that the source listing stays readable. The complete file is inside the "
            "IntegProgProject2026 folder of the compilation.",
        ],
    },
]
