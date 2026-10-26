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
                "txtPath": "C:\\Users\\{USER}\\Documents",
                "lv": {
                    "header": ["Name", "Type", "Modified/Size"],
                    "rows": [
                        ["Activity1.docx", "Word document", "10/12/2026  08:15"],
                        ["Activity2.docx", "Word document", "10/12/2026  08:20"],
                        ["Activity3.docx", "Word document", "10/13/2026  09:02"],
                        ["Compilation.pdf", "PDF document", "10/20/2026  14:40"],
                        ["Form1.Designer.vb", "VB source", "10/18/2026  21:07"],
                        ["Module1.vb", "VB source", "10/18/2026  21:05"],
                        ["Notes.txt", "Text document", "10/21/2026  07:31"],
                        ["Screenshot.png", "PNG image", "1.24 MB"],
                    ],
                },
                "lbl": "8 item(s) - C:\\Users\\{USER}\\Documents",
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
            "designer": "SW202610021600/CombinedSample.Designer.vb",
            "caption": "TreeView on the left and ListView on the right",
            "values": {
                "tree": ["Documents", "  Activities", "    Act9.vb", "    Act11.vb", "  Pictures",
                         "  Downloads", "Desktop"],
                "lv": {
                    "header": ["Name", "Type"],
                    "rows": [
                        ["Act9.vb", "VB source"],
                        ["Act11.vb", "VB source"],
                        ["Activity_Compilation.pdf", "PDF document"],
                        ["Screenshot.png", "PNG image"],
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
            "designer": "IntegProgProject2026/IntegProgProject2026/Forms/frmSchedules.Designer.vb",
            "caption": "Schedule form of the MDI project with a saved record",
            "values": {
                "txtScheduleID": "SCH-2026-001",
                "txtCourseID": "BSIT-3B",
                "txtTeacherID": "T-014",
                "txtRoom": "Room 204",
                "cboDay": "Monday",
                "lblDatabase": "Database : schoolrecords.accdb  (connected)",
            },
        },
    ],
}
