Imports System.Data.OleDb

Public Class frmSchedules

    Private selectedId As Integer = 0
    Private isLoading As Boolean = False
    Private store As DataTable
    Private nextId As Integer = 1

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmSchedules] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Function XmlPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.xml")
    End Function

    Private Function SdfPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.sdf")
    End Function

    Private Function HasSqlCe() As Boolean
        Try
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
        Catch
        End Try
        Return False
    End Function

    Private Sub frmSchedules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogStep("Load")
        Try
            SetupStore()
        Catch ex As Exception
            LogStep("SetupStore failed: " & ex.Message)
        End Try
        Try
            ClearFields()
        Catch
        End Try
        RefreshGrid()
    End Sub

    Private Sub SetupStore()
        store = New DataTable("Schedules")
        store.Columns.Add("ScheduleID", GetType(Integer))
        store.Columns.Add("CourseID", GetType(String))
        store.Columns.Add("TeacherID", GetType(String))
        store.Columns.Add("Day", GetType(String))
        store.Columns.Add("Time", GetType(String))
        store.Columns.Add("Room", GetType(String))
        If IO.File.Exists(XmlPath()) Then
            Try
                store.ReadXml(XmlPath())
                LogStep("loaded rows from xml: " & store.Rows.Count.ToString())
            Catch ex As Exception
                LogStep("xml unreadable, reseeding: " & ex.Message)
                store.Clear()
            End Try
        End If
        If store.Rows.Count = 0 Then
            SeedSampleData()
            SaveStore()
            LogStep("seeded sample data")
        End If
        nextId = 1
        For Each row As DataRow In store.Rows
            Dim id As Integer = Convert.ToInt32(row.Item("ScheduleID"))
            If id >= nextId Then nextId = id + 1
        Next
        lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
    End Sub

    Private Sub SaveStore()
        Try
            store.AcceptChanges()
            store.WriteXml(XmlPath())
        Catch ex As Exception
            LogStep("WriteXml failed: " & ex.Message)
        End Try
        SyncToSdf()
    End Sub

    Private Sub SyncToSdf()
        If Not HasSqlCe() Then Return
        Try
            If Not IO.File.Exists(SdfPath()) Then
                Dim catalog As Object = CreateObject("ADOX.Catalog")
                catalog.Create("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath())
                catalog = Nothing
            End If
            Using conn As New OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath() & ";Persist Security Info=False;")
                conn.Open()
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [Schedules]", conn)
                    cmd.ExecuteScalar()
                End Using
                Using cmd As New OleDbCommand("DELETE FROM [Schedules]", conn)
                    cmd.ExecuteNonQuery()
                End Using
                For Each row As DataRow In store.Rows
                    Using cmd As New OleDbCommand("INSERT INTO [Schedules] ([CourseID], [TeacherID], [Day], [Time], [Room]) VALUES (?, ?, ?, ?, ?)", conn)
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("CourseID")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("TeacherID")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Day")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Time")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Room")))
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            LogStep("sdf mirror skipped: " & ex.Message)
        End Try
    End Sub

    Private Sub SeedSampleData()
        Dim rows As String() = New String() { _
            "IT301|T-005|Monday|07:30|Room 205", _
            "IT302|T-006|Monday|11:00|Lab 3", _
            "CS201|T-007|Tuesday|09:30|Room 206", _
            "IT303|T-005|Wednesday|08:00|Lab 4", _
            "CS202|T-006|Thursday|13:30|Room 207", _
            "IT304|T-007|Friday|10:00|Room 208", _
            "CS203|T-005|Saturday|09:00|Lab 5"
            }
        For Each line As String In rows
            Dim parts As String() = line.Split("|"c)
            If parts.Length = 5 Then
                Dim row As DataRow = store.NewRow()
                row.Item("ScheduleID") = nextId
                row.Item("CourseID") = parts(0)
                row.Item("TeacherID") = parts(1)
                row.Item("Day") = parts(2)
                row.Item("Time") = parts(3)
                row.Item("Room") = parts(4)
                store.Rows.Add(row)
                nextId += 1
            End If
        Next
    End Sub

    Private Sub RefreshGrid()
        Try
            If store Is Nothing Then Return
            Dim view As New DataTable("Schedules")
            view = store.Copy()
            dataGridView1.DataSource = view
            FormatGrid()
            lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
        Catch ex As Exception
            LogStep("RefreshGrid failed: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dataGridView1.Columns.Count = 0 Then Return
        With dataGridView1
            .Columns("ScheduleID").HeaderText = "ID"
            .Columns("CourseID").HeaderText = "Course ID"
            .Columns("TeacherID").HeaderText = "Teacher ID"
            .Columns("Day").HeaderText = "Day"
            .Columns("Time").HeaderText = "Time"
            .Columns("Room").HeaderText = "Room"
        End With
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try
            If Not IsValidInput() Then Return
            Dim row As DataRow = store.NewRow()
            row.Item("ScheduleID") = nextId
            row.Item("CourseID") = txtCourseID.Text.Trim()
            row.Item("TeacherID") = txtTeacherID.Text.Trim()
            row.Item("Day") = cboDay.Text.Trim()
            row.Item("Time") = dtpTime.Value.ToString("HH:mm")
            row.Item("Room") = txtRoom.Text.Trim()
            store.Rows.Add(row)
            nextId += 1
            SaveStore()
            MessageBox.Show("The record was saved." & vbCrLf & vbCrLf & "New ID: " & (nextId - 1).ToString(), _
                "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Add failed: " & ex.Message)
            MessageBox.Show("The record could not be saved." & vbCrLf & vbCrLf & ex.Message, _
                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If Not IsValidInput() Then Return
            Dim found As DataRow = Nothing
            For Each row As DataRow In store.Rows
                If Convert.ToInt32(row.Item("ScheduleID")) = selectedId Then
                    found = row
                    Exit For
                End If
            Next
            If found Is Nothing Then
                MessageBox.Show("That record no longer exists.", "Record Not Found", _
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RefreshGrid()
                Return
            End If
            found.Item("CourseID") = txtCourseID.Text.Trim()
            found.Item("TeacherID") = txtTeacherID.Text.Trim()
            found.Item("Day") = cboDay.Text.Trim()
            found.Item("Time") = dtpTime.Value.ToString("HH:mm")
            found.Item("Room") = txtRoom.Text.Trim()
            SaveStore()
            MessageBox.Show("The record was updated.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Update failed: " & ex.Message)
            MessageBox.Show("The record could not be updated." & vbCrLf & vbCrLf & ex.Message, _
                "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If MessageBox.Show("Delete this record?" & vbCrLf & vbCrLf & "ID: " & selectedId.ToString(), _
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If
            For i As Integer = store.Rows.Count - 1 To 0 Step -1
                If Convert.ToInt32(store.Rows(i).Item("ScheduleID")) = selectedId Then
                    store.Rows.RemoveAt(i)
                End If
            Next
            SaveStore()
            MessageBox.Show("The record was deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Delete failed: " & ex.Message)
            MessageBox.Show("The record could not be deleted." & vbCrLf & vbCrLf & ex.Message, _
                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ClearFields()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGridView1.SelectionChanged
        If isLoading Then Return
        If dataGridView1.CurrentRow Is Nothing Then Return
        FillFromRow()
    End Sub

    Private Sub FillFromRow()
        Dim row As DataGridViewRow = dataGridView1.CurrentRow
        If row Is Nothing Then Return
        If row.Cells("ScheduleID").Value Is Nothing Then Return
        If row.Cells("ScheduleID").Value Is DBNull.Value Then Return
        isLoading = True
        Try
            selectedId = Convert.ToInt32(row.Cells("ScheduleID").Value)
            txtScheduleID.Text = selectedId.ToString()
            txtCourseID.Text = Convert.ToString(row.Cells("CourseID").Value)
            txtTeacherID.Text = Convert.ToString(row.Cells("TeacherID").Value)
            cboDay.Text = Convert.ToString(row.Cells("Day").Value)
            Dim TimeText As String = Convert.ToString(row.Cells("Time").Value)
            Dim TimeParsed As Date
            If Date.TryParse(DateTime.Today.ToShortDateString() & " " & TimeText, TimeParsed) Then
                dtpTime.Value = TimeParsed
            End If
            txtRoom.Text = Convert.ToString(row.Cells("Room").Value)
        Catch ex As Exception
            LogStep("FillFromRow failed: " & ex.Message)
        Finally
            isLoading = False
        End Try
    End Sub

    Private Sub ClearFields()
        isLoading = True
        Try
            dataGridView1.CurrentCell = Nothing
        Catch
        End Try
        selectedId = 0
        txtScheduleID.Clear()
        txtCourseID.Clear()
        txtTeacherID.Clear()
        cboDay.SelectedIndex = -1
        dtpTime.Value = DateTime.Today.AddHours(8)
        txtRoom.Clear()
        txtCourseID.Focus()
        isLoading = False
    End Sub

    Private Function IsValidInput() As Boolean
        If txtCourseID.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Course ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCourseID.Focus()
            Return False
        End If
        If txtTeacherID.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Teacher ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTeacherID.Focus()
            Return False
        End If
        If cboDay.SelectedIndex < 0 Then
            MessageBox.Show("Please choose the Day.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboDay.Focus()
            Return False
        End If
        If txtRoom.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Room.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoom.Focus()
            Return False
        End If
        Return True
    End Function


    Private Function IntValue(ByVal text As String) As Integer
        Dim value As Integer = 0
        If Integer.TryParse(text.Trim(), value) Then Return value
        Return 0
    End Function

    Private Function DateValue(ByVal text As String) As Date
        Dim parts As String() = text.Split("-"c)
        If parts.Length = 3 Then
            Dim y As Integer = 0
            Dim m As Integer = 0
            Dim d As Integer = 0
            If Integer.TryParse(parts(0), y) AndAlso Integer.TryParse(parts(1), m) AndAlso Integer.TryParse(parts(2), d) Then
                If y >= 1 AndAlso m >= 1 AndAlso m <= 12 AndAlso d >= 1 AndAlso d <= 31 Then
                    Return New Date(y, m, d)
                End If
            End If
        End If
        Return Date.Today
    End Function

End Class
