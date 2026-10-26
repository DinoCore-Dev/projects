"""Sample values used to draw the "Sample Output" picture of every form activity.

The pictures are rendered from the real `*.Designer.vb` coordinates, then the
controls are filled with the values below so the picture looks like the program
after the user typed the data and clicked the button.

Each activity maps to a list of pictures:

    number: [
        {
            "designer": "path/inside/COMPILATION/Form1.Designer.vb",
            "caption": "Arithmetic Machine after computing the average",
            "values": {"txtN1": "12", "lblSumValue": "18.0000", ...},
        },
    ]

Supported value forms
---------------------
    "control": "text"                       -> Text of that control
    "control": 1                            -> SelectedIndex of a TabControl
    "control": {"checked": True}            -> radio button / check box state
    "control": {"header": [...], "rows": [[...]]}  -> ListView content
    "control": ["node", "  child node"]     -> TreeView nodes ("  " = one level)
"""

SAMPLES = {
    4: [
        {
            "designer": "Activity4_20260703/Activity4_20260703/Form1.Designer.vb",
            "caption": "Arithmetic Machine after clicking Average",
            "values": {
                "txtN1": "12", "txtN2": "4", "txtN3": "2",
                "lblSumValue": "18.0000", "lblDiffValue": "6.0000",
                "lblProdValue": "96.0000", "lblQuotValue": "1.5000",
                "lblAveValue": "6.0000",
                "lblStatus": "Average = 6.0000",
            },
        },
    ],
    5: [
        {
            "designer": "Act5/Ternary2/Form1.Designer.vb",
            "caption": "Ternary remarks for an average grade of 91",
            "values": {
                "txtAverage": "91",
                "lblCard1Value": "Passed",
                "lblCard2Value": "A",
                "lblCard3Value": "1.50",
                "lblStatus": "Average 91 evaluated using nested ternary If operators.",
            },
        },
    ],
    6: [
        {
            "designer": "Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.Designer.vb",
            "caption": "Select Case evaluation of the three grades",
            "values": {
                "txtG1": "95", "txtG2": "96", "txtG3": "97",
                "lblAverage": "96.00",
                "lblRemarks1": "Passed!",
                "lblRemarks2": "A",
                "lblRemarks3": "1.25",
                "lblStatus": "Average 96.00 evaluated with three Select Case blocks.",
            },
        },
    ],
    7: [
        {
            "designer": "Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
            "caption": "Interest, square and class average after computing",
            "values": {
                "principalTextBox": "1000",
                "interestRateTextBox": "5",
                "outputTextBox": "Year 1    1050.00\nYear 2    1102.50\nYear 3    1157.63\nYear 4    1215.51\nYear 5    1276.28",
                "fillCharacterTextBox": "#",
                "sideLengthTextBox": "6",
                "decimalOutputTextBox": "######\n######\n######\n######\n######\n######",
                "classAverageLabel": "Grades      88   92   95\nClass average : 91.67\nHighest : 95   Lowest : 88",
            },
        },
    ],
    8: [
        {
            "designer": "Act8_SW20260805/TheMessage/Form1.Designer.vb",
            "caption": "Message composed with the Information icon and the OK button",
            "values": {
                "txtTitle": "Reminder",
                "txtMessage": "Please save your work before the period ends.\nThe compilation is due today.",
                "rbInfo": {"checked": True},
                "rbOk": {"checked": True},
                "rbDefault1": {"checked": True},
                "lblStatus": "Information message displayed. The user clicked OK.",
            },
        },
    ],
    9: [
        {
            "designer": "SW202609301600/ListViewSample.Designer.vb",
            "caption": "Files of a folder listed in the ListView",
            "values": {
                "Form": "Activity 9 - ListView File Explorer  |  {AUTHOR}",
                "txtPath": "C:\\Users\\{USER}\\Documents",
                "lv": {
                    "header": ["Name", "Type", "Modified/Size"],
                    "rows": [
                        ["Activities", "Folder", "10/18/2026 9:05:12 PM"],
                        ["Pictures", "Folder", "10/19/2026 8:32:40 AM"],
                        ["Activity1.docx", ".docx", "24576 bytes"],
                        ["Activity2.docx", ".docx", "25102 bytes"],
                        ["Compilation.pdf", ".pdf", "1048576 bytes"],
                        ["Module1.vb", ".vb", "2048 bytes"],
                        ["Notes.txt", ".txt", "1234 bytes"],
                        ["Screenshot.png", ".png", "1302528 bytes"],
                    ],
                },
                "lbl": "8 item(s)",
            },
        },
    ],
    10: [
        {
            "designer": "SW20261002/PanelSplitPanelDemo/Form1.Designer.vb",
            "caption": "Panel Playground after three panel API calls",
            "values": {
                "txtName": "{AUTHOR}",
                "txtCourse": "BSIT 3B",
                "lblCounter": "3 action(s) performed",
                "lblStatus": "pnlNested.BringToFront() executed. Parent is still pnlWorkspace.",
                "lblNestedBadge": "#CCFBF1",
            },
        },
        {
            "designer": "SW20261002/PanelSplitPanelDemo/Form2.Designer.vb",
            "caption": "Split Container Lab with a record selected",
            "values": {
                "lvRecords": {
                    "header": ["ID", "Student", "Course", "Grade"],
                    "rows": [
                        ["2026-001", "{AUTHOR}", "BSIT 3B", "96.00"],
                        ["2026-002", "Dela Cruz, Maria", "BSIT 3B", "91.50"],
                        ["2026-003", "Santos, Jomar", "BSIT 3B", "88.00"],
                        ["2026-004", "Reyes, Ana", "BSIT 3A", "93.25"],
                        ["2026-005", "Bautista, Neil", "BSIT 3A", "79.00"],
                    ],
                },
                "txtDetails": "ID            : 2026-001\nStudent       : {AUTHOR}\nCourse        : BSIT 3B\nGrade         : 96.00\nRemarks       : Passed - Outstanding",
                "lblStatus": "Record 2026-001 selected. Drag a splitter to resize the panels.",
                "lblCount": "5 record(s)",
            },
        },
    ],
    11: [
        {
            "designer": "tools:figure_sources/MainForm.Designer.vb",
            "caption": "MainForm - the Assignment answers tab",
            "values": {
                "Form": "Activity 11 - SW202610021600 - Windows Forms Controls  |  {AUTHOR}",
                "tabs": 3,
                "answers": "Activity 11 - SW202610021600\nAuthor : {AUTHOR}   |   Course, Year and Section : {COURSE}\n\nQuestion 6 - ListView\nThe ListView examples tab imitates File Explorer with folder browsing, Details/List views, columns, sorting, double-click opening, and a status bar.\n\nQuestion 7 - TreeView\nThe TreeView examples tab displays drives and directories. Nodes are loaded when expanded and the selected path is shown.\n\nQuestion 8 - OpenFileDialog\nThe File explorer + dialogs tab demonstrates OpenFileDialog, file filters, multiple selection, CheckFileExists, and RestoreDirectory.\n\nQuestion 9 - Combined form\nThe File explorer + dialogs tab combines OpenFileDialog, SaveFileDialog, TreeView, ListView, folder navigation, and saving a directory listing.",
                "statusBar": "Author: {AUTHOR}   |   {COURSE}   |   Activity 11 - SW202610021600",
            },
        },
        {
            "designer": "tools:figure_sources/MenuForm.Designer.vb",
            "caption": "MenuForm - the menu that opens each explorer",
            "values": {
                "Form": "Activity 11 - SW202610021600  |  {AUTHOR}",
            },
        },
        {
            "designer": "SW202610021600/ListViewSample.Designer.vb",
            "caption": "ListViewSample - folder shown in Details view",
            "values": {
                "Form": "Question 6 - ListView File Explorer  |  {AUTHOR}",
                "txtPath": "C:\\Users\\{USER}\\Documents",
                "lv": {
                    "header": ["Name", "Type", "Modified/Size"],
                    "rows": [
                        ["Activities", "Folder", "10/18/2026 9:05:12 PM"],
                        ["Pictures", "Folder", "10/19/2026 8:32:40 AM"],
                        ["Activity1.docx", ".docx", "24576 bytes"],
                        ["Notes.txt", ".txt", "1234 bytes"],
                        ["Screenshot.png", ".png", "1302528 bytes"],
                    ],
                },
                "lbl": "5 item(s)",
            },
        },
        {
            "designer": "SW202610021600/TreeViewSample.Designer.vb",
            "caption": "TreeViewSample - a node selected, its path shown",
            "values": {
                "Form": "Question 7 - TreeView File Explorer  |  {AUTHOR}",
                "tree": ["C:\\", "  Users", "    {USER}", "      Documents", "      Downloads",
                         "      Pictures", "  Windows", "D:\\"],
                "selectedPath": "C:\\Users\\{USER}\\Documents",
            },
        },
        {
            "designer": "SW202610021600/OpenFileDialogSample.Designer.vb",
            "caption": "OpenFileDialogSample - files chosen with Open multiple...",
            "values": {
                "Form": "Question 8 - OpenFileDialog  |  {AUTHOR}",
                "selected": ["C:\\Users\\{USER}\\Documents\\Activity1.docx",
                             "C:\\Users\\{USER}\\Documents\\Activity2.docx",
                             "C:\\Users\\{USER}\\Documents\\Notes.txt"],
            },
        },
        {
            "designer": "SW202610021600/CombinedSample.Designer.vb",
            "caption": "CombinedSample - TreeView on the left, ListView on the right",
            "values": {
                "Form": "Question 9 - Combined Explorer  |  {AUTHOR}",
                "tree": ["C:\\", "  Users", "    {USER}", "      Documents", "        Activities",
                         "      Pictures", "D:\\"],
                "lv": {
                    "header": ["Name", "Type"],
                    "rows": [
                        ["Activities", "Folder"],
                        ["Activity1.docx", "File"],
                        ["Activity2.docx", "File"],
                        ["Notes.txt", "File"],
                    ],
                },
            },
        },
    ],
    12: [
        {
            "designer": "FileExplorerClone/PanelSplitDemo/Form1.Designer.vb",
            "caption": "File explorer clone showing a folder, its files and the preview",
            "values": {
                "txtPath": "C:\\Users\\{USER}\\Documents\\Activities",
                "tvFolders": ["Desktop", "Documents", "  Activities", "    Act9", "    Act11",
                              "    Act12", "  Downloads", "Pictures"],
                "lvFiles": {
                    "header": ["Name", "Type", "Size", "Modified"],
                    "rows": [
                        ["Act9", "File folder", "", "10/18/2026  21:05"],
                        ["Act11", "File folder", "", "10/19/2026  08:32"],
                        ["Act12", "File folder", "", "10/21/2026  19:44"],
                        ["Notes.txt", "Text document", "3 KB", "10/21/2026  07:31"],
                        ["Output.png", "PNG image", "212 KB", "10/22/2026  10:02"],
                    ],
                },
                "txtPreview": "Name        : Notes.txt\nType        : Text document\nSize        : 3 KB\nModified    : 10/21/2026 07:31\n\nAct 12 - File Explorer Clone\nAuthor : {AUTHOR}\nCourse : BSIT 3B",
                "lblCount": "5 item(s)",
                "lblStatus": "C:\\Users\\{USER}\\Documents\\Activities opened.",
            },
        },
    ],
    13: [
        {
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmMain.Designer.vb",
            "caption": "frmMain - the MDI parent with its menu and status strip",
            "values": {
                "Form": {"back": (171, 171, 171)},
                "toolstripUserInfo": "UserInfo: {AUTHOR}  |  {COURSE}",
                "toolstripCurrentDate": "CurrentDate: Monday, 26 October 2026",
                "toolstripCurrentTime": "Current Time: 9:24:41 AM",
                "lblStatusBar": "Choose a form from the menu.",
            },
        },
        {
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmSchedules.Designer.vb",
            "caption": "frmSchedules - first record selected in the grid",
            "values": {
                "txtScheduleID": "1",
                "txtCourseID": "IT301",
                "txtTeacherID": "T-005",
                "txtRoom": "Room 205",
                "cboDay": "Monday",
                "dtpTime": "07:30 AM",
                "dataGridView1": {
                    "header": ["ID", "Course ID", "Teacher ID", "Day", "Time", "Room"],
                    "rows": [
                        ["1", "IT301", "T-005", "Monday", "07:30", "Room 205"],
                        ["2", "IT302", "T-006", "Monday", "11:00", "Lab 3"],
                        ["3", "CS201", "T-007", "Tuesday", "09:30", "Room 206"],
                        ["4", "IT303", "T-005", "Wednesday", "08:00", "Lab 4"],
                        ["5", "CS202", "T-006", "Thursday", "13:30", "Room 207"],
                        ["6", "IT304", "T-007", "Friday", "10:00", "Room 208"],
                        ["7", "CS203", "T-005", "Saturday", "09:00", "Lab 5"],
                    ],
                },
                "lblDatabase": "Storage: ...\\bin\\Debug\\projectDB.xml   |   7 record(s)",
            },
        },
        {
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmQuotes.Designer.vb",
            "caption": "frmQuotes - first record selected in the grid",
            "values": {
                "txtQuoteID": "1",
                "txtContent": "Simplicity is the soul of efficiency.",
                "txtAuthor": "Austin Freeman",
                "txtSource": "The Social Welfare of the Blind",
                "dtpQuoteDate": "Monday, January 01, 1912",
                "dataGridView1": {
                    "header": ["ID", "Content", "Author", "Source", "Quote Date"],
                    "rows": [
                        ["1", "Simplicity is the soul of efficiency.", "Austin Freeman", "The Social Welfare of the Blind", "1/1/1912"],
                        ["2", "First, solve the problem. Then, write the code.", "John Johnson", "Tech talk", "5/20/1980"],
                        ["3", "Experience is the name everyone gives to their mistakes.", "Oscar Wilde", "Lady Windermere Fan", "2/20/1892"],
                        ["4", "Code is like humor. When you have to explain it, it is bad.", "Cory House", "Blog post", "3/11/2015"],
                        ["5", "Make it work, make it right, make it fast.", "Kent Beck", "Extreme Programming", "10/5/1999"],
                        ["6", "The best error message is the one that never shows up.", "Thomas Fuchs", "Conference talk", "7/19/2011"],
                    ],
                },
                "lblDatabase": "Storage: ...\\bin\\Debug\\projectDB.xml   |   6 record(s)",
            },
        },
        {
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmBibleVerses.Designer.vb",
            "caption": "frmBibleVerses - first record selected in the grid",
            "values": {
                "txtVerseID": "1",
                "txtBook": "Genesis",
                "txtChapter": "1",
                "txtVerse": "1",
                "txtContent": "In the beginning God created the heavens and the earth.",
                "txtTranslation": "NIV",
                "txtRemarks": "Creation",
                "txtCategory": "Old Testament",
                "dataGridView1": {
                    "header": ["ID", "Book", "Chapter", "Verse", "Content", "Translation", "Remarks", "Category"],
                    "rows": [
                        ["1", "Genesis", "1", "1", "In the beginning God created the heavens and the earth.", "NIV", "Creation", "Old Testament"],
                        ["2", "Exodus", "20", "3", "You shall have no other gods before me.", "NIV", "Commandments", "Old Testament"],
                        ["3", "Joshua", "1", "9", "Be strong and courageous. Do not be afraid.", "NIV", "Courage", "History"],
                        ["4", "Isaiah", "41", "10", "So do not fear, for I am with you.", "NIV", "Comfort", "Prophecy"],
                        ["5", "Matthew", "5", "9", "Blessed are the peacemakers.", "NIV", "Peace", "Gospel"],
                        ["6", "James", "1", "22", "Do not merely listen to the word, and so deceive yourselves. Do what it says.", "NIV", "Action", "Epistle"],
                    ],
                },
                "lblDatabase": "Storage: ...\\bin\\Debug\\projectDB.xml   |   6 record(s)",
            },
        },
        {
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmAbout.Designer.vb",
            "caption": "frmAbout - the About form (the programmer's photo goes in the picture box)",
            "values": {},
        },
    ],
}
