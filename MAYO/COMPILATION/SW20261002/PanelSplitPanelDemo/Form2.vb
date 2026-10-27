' ============================================================
' Activity 10 - SW20261002  (SplitContainer Demo)
' Nested SplitContainer practice : two panels in the outer
' splitter, two panels in the inner splitter.
' Author : Mayo, Mhike Charles   |   BSIT 3B
' ============================================================
Option Strict On
Option Explicit On

Public Class Form2

    ' one line of sample data
    Private Class RecordItem
        Public Name As String
        Public Category As String
        Public Status As String
        Public Detail As String

        Public Sub New(ByVal recordName As String, ByVal recordCategory As String, _
                       ByVal recordStatus As String, ByVal recordDetail As String)
            Name = recordName
            Category = recordCategory
            Status = recordStatus
            Detail = recordDetail
        End Sub
    End Class

    Private records As New List(Of RecordItem)()
    Private splittersLocked As Boolean = False

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BuildSampleData()
        FillCategories()
        ApplyDefaultLayout()

        If lstCategories.Items.Count > 0 Then lstCategories.SelectedIndex = 0

        lblStatus.Text = "Drag any splitter to resize the panels."
        lblCount.Text = records.Count.ToString() & " sample record(s) loaded"
    End Sub

    ' ---------------------------------------------------------
    ' sample data
    ' ---------------------------------------------------------
    Private Sub BuildSampleData()
        records.Add(New RecordItem("Student Masterlist", "Students", "Active", _
            "The student masterlist holds the complete list of enrolled students of BSIT 3B." & vbCrLf & _
            "Fields : student number, full name, year level, section and status."))
        records.Add(New RecordItem("Grade Sheet", "Students", "Active", _
            "The grade sheet stores the midterm and final grades of every student." & vbCrLf & _
            "Average and remarks are computed automatically."))
        records.Add(New RecordItem("Course Catalog", "Courses", "Active", _
            "The course catalog lists every subject with its code, title and unit count."))
        records.Add(New RecordItem("Class Schedule", "Courses", "Draft", _
            "The class schedule combines a course, a teacher, a day, a time and a room."))
        records.Add(New RecordItem("Enrollment Slip", "Enrollments", "Active", _
            "The enrollment slip is printed for each student after the subjects are confirmed."))
        records.Add(New RecordItem("Subject Load", "Enrollments", "Pending", _
            "The subject load shows the subjects and schedules of one student for the term."))
        records.Add(New RecordItem("Enrollment Report", "Reports", "Active", _
            "A summary of the number of enrolled students per course and per year level."))
        records.Add(New RecordItem("Grade Summary", "Reports", "Draft", _
            "A report that groups the class by remarks : passed, conditional and failed."))
        records.Add(New RecordItem("User Accounts", "Settings", "Active", _
            "User accounts control who can add, edit or delete the records of the system."))
        records.Add(New RecordItem("Backup Preferences", "Settings", "Pending", _
            "Backup preferences decide how often the database file is copied to a safe folder."))
    End Sub

    Private Sub FillCategories()
        lstCategories.Items.Clear()
        lstCategories.Items.Add("All records")
        lstCategories.Items.Add("Students")
        lstCategories.Items.Add("Courses")
        lstCategories.Items.Add("Enrollments")
        lstCategories.Items.Add("Reports")
        lstCategories.Items.Add("Settings")
    End Sub

    Private Sub lstCategories_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstCategories.SelectedIndexChanged
        ShowRecords(CStr(lstCategories.SelectedItem))
    End Sub

    Private Sub ShowRecords(ByVal category As String)
        lvRecords.BeginUpdate()
        lvRecords.Items.Clear()

        For Each record As RecordItem In records
            If category = "All records" OrElse record.Category = category Then
                Dim row As New ListViewItem(record.Name)
                row.SubItems.Add(record.Category)
                row.SubItems.Add(record.Status)
                row.Tag = record
                lvRecords.Items.Add(row)
            End If
        Next

        lvRecords.EndUpdate()
        txtDetails.Text = "Select a record in the list above to display its details here."
        lblStatus.Text = If(category = "All records", "Showing every record", "Showing the " & category & " records") & _
                         " - " & lvRecords.Items.Count.ToString() & " item(s)."
        lblCount.Text = "outer splitter : " & splOuter.SplitterDistance.ToString() & " px"
    End Sub

    Private Sub lvRecords_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvRecords.SelectedIndexChanged
        If lvRecords.SelectedItems.Count = 0 Then Return

        Dim chosen As RecordItem = CType(lvRecords.SelectedItems(0).Tag, RecordItem)
        txtDetails.Text = chosen.Name & vbCrLf & _
                          "Category : " & chosen.Category & vbCrLf & _
                          "Status : " & chosen.Status & vbCrLf & vbCrLf & _
                          chosen.Detail & vbCrLf & vbCrLf & _
                          "This text is shown inside Panel2 of the inner SplitContainer."
        lblStatus.Text = "Selected : " & chosen.Name
    End Sub

    ' ---------------------------------------------------------
    ' split container layout helpers
    ' ---------------------------------------------------------
    Private Sub ApplyDefaultLayout()
        splOuter.Panel1Collapsed = False
        splOuter.Panel2Collapsed = False
        splInner.Panel1Collapsed = False
        splInner.Panel2Collapsed = False
        splInner.Orientation = Orientation.Horizontal

        SetRatioDistance(splOuter, 0.24)
        SetRatioDistance(splInner, 0.62)
        ShowSplitInfo()
    End Sub

    ' The distance is given as a ratio of the available space so the
    ' splitter never goes beyond its minimum sizes.
    Private Sub SetRatioDistance(ByVal splitter As SplitContainer, ByVal ratio As Double)
        Dim available As Integer
        If splitter.Orientation = Orientation.Vertical Then
            available = splitter.ClientSize.Width
        Else
            available = splitter.ClientSize.Height
        End If

        Dim lowest As Integer = splitter.Panel1MinSize
        Dim highest As Integer = available - splitter.Panel2MinSize - splitter.SplitterWidth
        If highest <= lowest Then Return

        Dim requested As Integer = CInt(available * ratio)
        If requested < lowest Then requested = lowest
        If requested > highest Then requested = highest
        splitter.SplitterDistance = requested
    End Sub

    Private Sub ShowSplitInfo()
        lblSplitInfo.Text = "outer : " & splOuter.SplitterDistance.ToString() & " px" & vbCrLf & _
                            "inner : " & splInner.SplitterDistance.ToString() & " px"
    End Sub

    Private Sub btnCollapseLeft_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollapseLeft.Click
        splOuter.Panel1Collapsed = Not splOuter.Panel1Collapsed
        lblStatus.Text = "splOuter.Panel1Collapsed = " & splOuter.Panel1Collapsed.ToString()
        ShowSplitInfo()
    End Sub

    Private Sub btnCollapseTop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollapseTop.Click
        splInner.Panel1Collapsed = Not splInner.Panel1Collapsed
        lblStatus.Text = "splInner.Panel1Collapsed = " & splInner.Panel1Collapsed.ToString()
        ShowSplitInfo()
    End Sub

    Private Sub btnSwapOrientation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSwapOrientation.Click
        Try
            If splInner.Orientation = Orientation.Horizontal Then
                splInner.Orientation = Orientation.Vertical
                lblStatus.Text = "Orientation = Vertical, the inner panels are now left and right."
            Else
                splInner.Orientation = Orientation.Horizontal
                lblStatus.Text = "Orientation = Horizontal, the inner panels are now top and bottom."
            End If
            SetRatioDistance(splInner, 0.62)
            ShowSplitInfo()
        Catch ex As Exception
            lblStatus.Text = "The orientation could not be changed : " & ex.Message
        End Try
    End Sub

    Private Sub btnLock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLock.Click
        splittersLocked = Not splittersLocked
        splOuter.IsSplitterFixed = splittersLocked
        splInner.IsSplitterFixed = splittersLocked
        btnLock.Text = If(splittersLocked, "Unlock splitters", "Lock splitters")
        lblStatus.Text = "IsSplitterFixed = " & splittersLocked.ToString()
    End Sub

    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        splittersLocked = False
        splOuter.IsSplitterFixed = False
        splInner.IsSplitterFixed = False
        btnLock.Text = "Lock splitters"
        ApplyDefaultLayout()
        lblStatus.Text = "The default layout and splitter distances were restored."
    End Sub

    Private Sub splOuter_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splOuter.SplitterMoved
        ShowSplitInfo()
        lblStatus.Text = "Outer splitter moved to " & splOuter.SplitterDistance.ToString() & " pixels."
    End Sub

    Private Sub splInner_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splInner.SplitterMoved
        ShowSplitInfo()
        lblStatus.Text = "Inner splitter moved to " & splInner.SplitterDistance.ToString() & " pixels."
    End Sub

    ' ---------------------------------------------------------
    ' navigation
    ' ---------------------------------------------------------
    Private Sub mnuPanelDemo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuPanelDemo.Click
        Me.Close()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
