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
            "caption": "Arithmetic Machine after clicking Average (45, 5 and 3)",
            "values": {
                "txtN1": "45", "txtN2": "5", "txtN3": "3",
                "lblSumValue": "53.0000", "lblDiffValue": "37.0000",
                "lblProdValue": "675.0000", "lblQuotValue": "3.0000",
                "lblAveValue": "17.6667",
                "lblStatus": "Average = 17.6667",
            },
        },
    ],
    5: [
        {
            "designer": "Act5/Ternary2/Form1.Designer.vb",
            "caption": "Ternary remarks for an average grade of 84",
            "values": {
                "txtAverage": "84",
                "lblCard1Value": "Passed",
                "lblCard2Value": "C",
                "lblCard3Value": "2.25",
                "lblStatus": "Average 84 evaluated using nested ternary If operators.",
            },
        },
    ],
    6: [
        {
            "designer": "Act6_IntegProg1_20260715/IntegrativeProg1_20260715/Form1.Designer.vb",
            "caption": "Select Case evaluation of the grades 82, 86 and 88",
            "values": {
                "txtG1": "82", "txtG2": "86", "txtG3": "88",
                "lblAverage": "85.33",
                "lblRemarks1": "Passed!",
                "lblRemarks2": "C",
                "lblRemarks3": "2.25",
                "lblStatus": "Average 85.33 evaluated with three Select Case blocks.",
            },
        },
    ],
    7: [
        {
            "designer": "Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
            "caption": "Interest Calculator - P2,500 at 4% for 5 years",
            "values": {
                "TabControl1": 0,
                "principalTextBox": "2500",
                "interestRateTextBox": "4",
                "yearsNumericUpDown": "5",
                "resultsListBox": ["Year    Amount on Deposit", "1          $2,600.00", "2          $2,704.00",
                                   "3          $2,812.16", "4          $2,924.65", "5          $3,041.63"],
            },
        },
        {
            "designer": "Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
            "caption": "Class Average - four grades submitted and averaged",
            "values": {
                "TabControl1": 2,
                "gradesListBox": ["78", "85", "91", "100"],
                "classAverageLabel": "Total of the 4 grade(s) is 354\nClass average is 88.50\n\nLetter grade summary:\nA: 2\nB: 1\nC: 1\nD: 0\nF: 0\nPerfect scores: 1",
            },
        },
        {
            "designer": "Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
            "caption": "Square of Character - fill character * with side length 5",
            "values": {
                "TabControl1": 1,
                "fillCharacterTextBox": "*",
                "sideLengthNumericUpDown": "5",
                "outputTextBox": "\n".join(["* * * * * "] * 5),
            },
        },
        {
            "designer": "Act7_IntegProg1_SW20260720/IntegProg1_SW20260720/Form1.Designer.vb",
            "caption": "Decimal Equivalent - the table filled when the form loads",
            "values": {
                "TabControl1": 3,
                "decimalOutputTextBox": "Decimal    Octal    Hexadecimal    Binary\n" + "\n".join(
                    "%-11d%-9s%-15s%s" % (n, format(n, "o"), format(n, "X"), format(n, "b")) for n in range(1, 21)),
            },
        },
    ],
    8: [
        {
            "designer": "Act8_SW20260805/TheMessage/Form1.Designer.vb",
            "caption": "Message composed with the Question icon and the Yes / No buttons",
            "values": {
                "txtTitle": "Submission",
                "txtMessage": "Did you send your compilation to the instructor?\nThe deadline is on Friday.",
                "rbQuestion": {"checked": True},
                "rbYesNo": {"checked": True},
                "rbDefault2": {"checked": True},
                "lblStatus": "Yes was clicked.",
            },
        },
    ],
    9: [
        {
            "designer": "SW202609301600/ListViewSample.Designer.vb",
            "caption": "Files of a folder listed in the ListView",
            "values": {
                "Form": "Activity 9 - ListView File Explorer  |  {AUTHOR}",
                "txtPath": "C:\\Users\\{USER}\\Desktop\\School Files",
                "lv": {
                    "header": ["Name", "Type", "Modified/Size"],
                    "rows": [
                        ["Integrative Programming", "Folder", "10/20/2026 2:14:33 PM"],
                        ["Reports", "Folder", "10/22/2026 9:41:05 AM"],
                        ["Activity4.docx", ".docx", "31744 bytes"],
                        ["Activity7.vb", ".vb", "6144 bytes"],
                        ["Grades.xlsx", ".xlsx", "18432 bytes"],
                        ["Readme.txt", ".txt", "512 bytes"],
                        ["Schedule.pdf", ".pdf", "262144 bytes"],
                        ["Sunset.jpg", ".jpg", "987136 bytes"],
                        ["Backup.zip", ".zip", "2560000 bytes"],
                    ],
                },
                "lbl": "9 item(s)",
            },
        },
    ],
    10: [
        {
            "designer": "SW20261002/PanelSplitPanelDemo/Form1.Designer.vb",
            "caption": "Panel Playground after saving the grouped details",
            "values": {
                "txtName": "{AUTHOR}",
                "txtCourse": "BSIT 3B",
                "lstLog": ["02  Saved from pnlGroup : {AUTHOR} - BSIT 3B", "01  You are already on the Panel demo."],
                "lblCounter": "2 action(s) performed",
                "lblStatus": "Saved from pnlGroup : {AUTHOR} - BSIT 3B",
            },
        },
        {
            "designer": "SW20261002/PanelSplitPanelDemo/Form2.Designer.vb",
            "caption": "Split Container Lab with a record selected",
            "values": {
                "lstCategories": ["All records", "Students", "Courses", "Enrollments", "Reports", "Settings"],
                "lvRecords": {
                    "header": ["Record", "Category", "Status"],
                    "rows": [
                        ["Student Masterlist", "Students", "Active"],
                        ["Grade Sheet", "Students", "Active"],
                        ["Course Catalog", "Courses", "Active"],
                        ["Class Schedule", "Courses", "Draft"],
                        ["Enrollment Slip", "Enrollments", "Active"],
                        ["Subject Load", "Enrollments", "Pending"],
                        ["Enrollment Report", "Reports", "Active"],
                        ["Grade Summary", "Reports", "Draft"],
                        ["User Accounts", "Settings", "Active"],
                        ["Backup Preferences", "Settings", "Pending"],
                    ],
                },
                "txtDetails": "Class Schedule\nCategory : Courses\nStatus : Draft\n\nThe class schedule combines a course, a teacher, a day, a time and a room.\n\nThis text is shown inside Panel2 of the inner SplitContainer.",
                "lblStatus": "Selected : Class Schedule",
                "lblCount": "outer splitter : 220 px",
                "lblSplitInfo": "outer : 220 px\ninner : 260 px",
            },
        },
    ],
    11: [
        {
            "designer": "tools:figure_sources/MenuForm.Designer.vb",
            "caption": "MenuForm - the menu that opens each explorer",
            "values": {
                "Form": "Activity 11 - SW202610021600  |  {AUTHOR}",
            },
        },
        {
            "designer": "SW202610021600/TreeViewSample.Designer.vb",
            "caption": "TreeViewSample - a node selected, its path shown",
            "values": {
                "Form": "Question 7 - TreeView File Explorer  |  {AUTHOR}",
                "tree": ["C:\\", "  Users", "    {USER}", "      Desktop", "      Documents", "        School Files",
                         "      Music", "  Program Files", "D:\\"],
                "selectedPath": "C:\\Users\\{USER}\\Documents\\School Files",
            },
        },
        {
            "designer": "SW202610021600/OpenFileDialogSample.Designer.vb",
            "caption": "OpenFileDialogSample - files chosen with Open multiple...",
            "values": {
                "Form": "Question 8 - OpenFileDialog  |  {AUTHOR}",
                "selected": ["C:\\Users\\{USER}\\Documents\\Activity4.docx",
                             "C:\\Users\\{USER}\\Documents\\Activity7.docx",
                             "C:\\Users\\{USER}\\Documents\\Grades.xlsx"],
            },
        },
        {
            "designer": "SW202610021600/CombinedSample.Designer.vb",
            "caption": "CombinedSample - TreeView on the left, ListView on the right",
            "values": {
                "Form": "Question 9 - Combined Explorer  |  {AUTHOR}",
                "tree": ["C:\\", "  Users", "    {USER}", "      Desktop", "      Documents", "        School Files",
                         "      Music", "D:\\"],
                "lv": {
                    "header": ["Name", "Type"],
                    "rows": [
                        ["School Files", "Folder"],
                        ["Activity4.docx", "File"],
                        ["Activity7.docx", "File"],
                        ["Grades.xlsx", "File"],
                        ["Readme.txt", "File"],
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
                "txtPath": "C:\\Users\\{USER}\\Documents\\School Files",
                "tvFolders": ["Desktop", "Documents", "  School Files", "    Integrative", "    Reports",
                              "    Backup", "  Downloads", "Pictures"],
                "lvFiles": {
                    "header": ["Name", "Type", "Size", "Modified"],
                    "rows": [
                        ["Integrative", "File folder", "", "10/20/2026  14:14"],
                        ["Reports", "File folder", "", "10/22/2026  09:41"],
                        ["Backup", "File folder", "", "10/23/2026  18:05"],
                        ["Grades.xlsx", "Microsoft Excel", "18 KB", "10/24/2026  16:20"],
                        ["Schedule.pdf", "PDF document", "256 KB", "10/25/2026  08:15"],
                        ["Readme.txt", "Text document", "1 KB", "10/25/2026  20:47"],
                    ],
                },
                "txtPreview": "Name        : Readme.txt\nType        : Text document\nSize        : 1 KB\nModified    : 10/25/2026 20:47\n\nAct 12 - File Explorer Clone\nAuthor : {AUTHOR}\nCourse : BSIT 3B",
                "lblCount": "6 item(s)",
                "lblStatus": "C:\\Users\\{USER}\\Documents\\School Files opened.",
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
                "lblDatabase": "Storage: ...\\bin\\Debug\\projectDB.sdf   |   7 record(s)",
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
                "lblDatabase": "Storage: ...\\bin\\Debug\\projectDB.sdf   |   6 record(s)",
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
                "lblDatabase": "Storage: ...\\bin\\Debug\\projectDB.sdf   |   6 record(s)",
            },
        },
        {
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmAbout.Designer.vb",
            "caption": "frmAbout - the About form with the programmer's photo",
            "values": {"PictureBox1": {"image": "{PHOTO}"}},
        },
    ],
}
