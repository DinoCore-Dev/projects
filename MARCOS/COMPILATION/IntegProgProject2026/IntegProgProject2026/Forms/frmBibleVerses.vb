Public Class frmBibleVerses

    Private selectedId As Integer = 0
    Private isLoading As Boolean = False
    Private store As DataTable
    Private nextId As Integer = 1

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmBibleVerses] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private useSdf As Boolean = False

    Private Const SqlCeProvider As String = "System.Data.SqlServerCe.3.5"
    Private Const SqlCeEngineType As String = "System.Data.SqlServerCe.SqlCeEngine, System.Data.SqlServerCe, Version=3.5.1.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91"

    Private Function XmlPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB_BibleVerses.xml")
    End Function

    Private Function SdfPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.sdf")
    End Function

    Private Function StoragePath() As String
        If useSdf Then Return SdfPath()
        Return XmlPath()
    End Function

    Private Function NewConnection() As System.Data.Common.DbConnection
        Dim factory As System.Data.Common.DbProviderFactory = System.Data.Common.DbProviderFactories.GetFactory(SqlCeProvider)
        Dim conn As System.Data.Common.DbConnection = factory.CreateConnection()
        conn.ConnectionString = "Data Source=" & SdfPath() & ";Persist Security Info=False;"
        Return conn
    End Function

    Private Sub AddParam(ByVal cmd As System.Data.Common.DbCommand, ByVal name As String, ByVal value As Object)
        Dim p As System.Data.Common.DbParameter = cmd.CreateParameter()
        p.ParameterName = name
        p.Value = value
        cmd.Parameters.Add(p)
    End Sub

    Private Sub frmBibleVerses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        store = New DataTable("BibleVerses")
        store.Columns.Add("VerseID", GetType(Integer))
        store.Columns.Add("Book", GetType(String))
        store.Columns.Add("Chapter", GetType(Integer))
        store.Columns.Add("Verse", GetType(Integer))
        store.Columns.Add("Content", GetType(String))
        store.Columns.Add("Translation", GetType(String))
        store.Columns.Add("Remarks", GetType(String))
        store.Columns.Add("Category", GetType(String))
        useSdf = False
        Try
            OpenSdf()
            useSdf = True
        Catch ex As Exception
            LogStep("projectDB.sdf is not available (" & ex.Message & "), using the XML file instead")
        End Try
        If useSdf Then
            LoadFromSdf()
        Else
            LoadFromXml()
        End If
        lblDatabase.Text = "Storage: " & StoragePath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
    End Sub

    ' ---------- SQL Server Compact database (bin\Debug\projectDB.sdf) ----------

    Private Sub OpenSdf()
        If Not IO.File.Exists(SdfPath()) Then
            Dim engineType As Type = Type.GetType(SqlCeEngineType)
            If engineType Is Nothing Then Throw New InvalidOperationException("SQL Server Compact 3.5 is not installed.")
            Dim engine As Object = Activator.CreateInstance(engineType, New Object() {"Data Source=" & SdfPath() & ";"})
            engine.CreateDatabase()
            engine.Dispose()
            LogStep("created " & SdfPath())
        End If
        Using conn As System.Data.Common.DbConnection = NewConnection()
            conn.Open()
            Dim hasTable As Boolean = False
            Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                cmd.CommandText = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'BibleVerses'"
                hasTable = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            End Using
            If Not hasTable Then
                Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                    cmd.CommandText = "CREATE TABLE [BibleVerses] ([VerseID] INT IDENTITY(1,1) PRIMARY KEY, [Book] NVARCHAR(255), [Chapter] INT, [Verse] INT, [Content] NVARCHAR(4000), [Translation] NVARCHAR(255), [Remarks] NVARCHAR(4000), [Category] NVARCHAR(255))"
                    cmd.ExecuteNonQuery()
                End Using
                LogStep("created table BibleVerses")
            End If
            Dim total As Integer = 0
            Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                cmd.CommandText = "SELECT COUNT(*) FROM [BibleVerses]"
                total = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            If total = 0 Then
                SeedSampleData()
                For Each row As DataRow In store.Rows
                    InsertRow(conn, row)
                Next
                store.Clear()
                nextId = 1
                LogStep("seeded sample data into projectDB.sdf")
            End If
        End Using
    End Sub

    Private Sub LoadFromSdf()
        store.Clear()
        Using conn As System.Data.Common.DbConnection = NewConnection()
            conn.Open()
            Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                cmd.CommandText = "SELECT [VerseID], [Book], [Chapter], [Verse], [Content], [Translation], [Remarks], [Category] FROM [BibleVerses] ORDER BY [VerseID]"
                Using reader As System.Data.Common.DbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim row As DataRow = store.NewRow()
                        For i As Integer = 0 To store.Columns.Count - 1
                            row.Item(i) = reader.GetValue(i)
                        Next
                        store.Rows.Add(row)
                    End While
                End Using
            End Using
        End Using
        store.AcceptChanges()
        LogStep("loaded rows from projectDB.sdf: " & store.Rows.Count.ToString())
    End Sub

    Private Function InsertRow(ByVal conn As System.Data.Common.DbConnection, ByVal row As DataRow) As Integer
        Dim newId As Integer = 0
        Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
            cmd.CommandText = "INSERT INTO [BibleVerses] ([Book], [Chapter], [Verse], [Content], [Translation], [Remarks], [Category]) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)"
            AddParam(cmd, "@p1", Convert.ToString(row.Item("Book")))
            AddParam(cmd, "@p2", IntValue(Convert.ToString(row.Item("Chapter"))))
            AddParam(cmd, "@p3", IntValue(Convert.ToString(row.Item("Verse"))))
            AddParam(cmd, "@p4", Convert.ToString(row.Item("Content")))
            AddParam(cmd, "@p5", Convert.ToString(row.Item("Translation")))
            AddParam(cmd, "@p6", Convert.ToString(row.Item("Remarks")))
            AddParam(cmd, "@p7", Convert.ToString(row.Item("Category")))
            cmd.ExecuteNonQuery()
        End Using
        Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
            cmd.CommandText = "SELECT @@IDENTITY"
            newId = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return newId
    End Function

    Private Sub UpdateRow(ByVal conn As System.Data.Common.DbConnection, ByVal row As DataRow)
        Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
            cmd.CommandText = "UPDATE [BibleVerses] SET [Book] = @p1, [Chapter] = @p2, [Verse] = @p3, [Content] = @p4, [Translation] = @p5, [Remarks] = @p6, [Category] = @p7 WHERE [VerseID] = @id"
            AddParam(cmd, "@p1", Convert.ToString(row.Item("Book")))
            AddParam(cmd, "@p2", IntValue(Convert.ToString(row.Item("Chapter"))))
            AddParam(cmd, "@p3", IntValue(Convert.ToString(row.Item("Verse"))))
            AddParam(cmd, "@p4", Convert.ToString(row.Item("Content")))
            AddParam(cmd, "@p5", Convert.ToString(row.Item("Translation")))
            AddParam(cmd, "@p6", Convert.ToString(row.Item("Remarks")))
            AddParam(cmd, "@p7", Convert.ToString(row.Item("Category")))
            AddParam(cmd, "@id", Convert.ToInt32(row.Item("VerseID")))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' ---------- XML file (only used when SQL Server Compact is not installed) ----------

    Private Sub LoadFromXml()
        store.Clear()
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
            SaveXml()
            LogStep("seeded sample data")
        End If
        nextId = 1
        For Each row As DataRow In store.Rows
            Dim id As Integer = Convert.ToInt32(row.Item("VerseID"))
            If id >= nextId Then nextId = id + 1
        Next
    End Sub

    Private Sub SaveXml()
        Try
            store.AcceptChanges()
            store.WriteXml(XmlPath())
        Catch ex As Exception
            LogStep("WriteXml failed: " & ex.Message)
        End Try
    End Sub

    ' ---------- Create / Update / Delete ----------

    Private Function SaveNewRecord(ByVal row As DataRow) As Integer
        Dim newId As Integer = 0
        If useSdf Then
            Using conn As System.Data.Common.DbConnection = NewConnection()
                conn.Open()
                newId = InsertRow(conn, row)
            End Using
        Else
            newId = nextId
            nextId += 1
        End If
        row.Item("VerseID") = newId
        store.Rows.Add(row)
        store.AcceptChanges()
        If Not useSdf Then SaveXml()
        Return newId
    End Function

    Private Sub SaveChangedRecord(ByVal row As DataRow)
        If useSdf Then
            Using conn As System.Data.Common.DbConnection = NewConnection()
                conn.Open()
                UpdateRow(conn, row)
            End Using
        End If
        store.AcceptChanges()
        If Not useSdf Then SaveXml()
    End Sub

    Private Sub DeleteRecord(ByVal id As Integer)
        If useSdf Then
            Using conn As System.Data.Common.DbConnection = NewConnection()
                conn.Open()
                Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                    cmd.CommandText = "DELETE FROM [BibleVerses] WHERE [VerseID] = @id"
                    AddParam(cmd, "@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
        For i As Integer = store.Rows.Count - 1 To 0 Step -1
            If Convert.ToInt32(store.Rows(i).Item("VerseID")) = id Then
                store.Rows.RemoveAt(i)
            End If
        Next
        store.AcceptChanges()
        If Not useSdf Then SaveXml()
    End Sub

    Private Sub SeedSampleData()
        Dim rows As String() = New String() { _
            "Genesis|1|1|In the beginning God created the heavens and the earth.|NIV|Creation|Old Testament", _
            "Exodus|20|3|You shall have no other gods before me.|NIV|Commandments|Old Testament", _
            "Joshua|1|9|Be strong and courageous. Do not be afraid.|NIV|Courage|History", _
            "Isaiah|41|10|So do not fear, for I am with you.|NIV|Comfort|Prophecy", _
            "Matthew|5|9|Blessed are the peacemakers.|NIV|Peace|Gospel", _
            "James|1|22|Do not merely listen to the word, and so deceive yourselves. Do what it says.|NIV|Action|Epistle"
            }
        For Each line As String In rows
            Dim parts As String() = line.Split("|"c)
            If parts.Length = 7 Then
                Dim row As DataRow = store.NewRow()
                row.Item("VerseID") = nextId
                row.Item("Book") = parts(0)
                row.Item("Chapter") = IntValue(parts(1))
                row.Item("Verse") = IntValue(parts(2))
                row.Item("Content") = parts(3)
                row.Item("Translation") = parts(4)
                row.Item("Remarks") = parts(5)
                row.Item("Category") = parts(6)
                store.Rows.Add(row)
                nextId += 1
            End If
        Next
    End Sub

    Private Sub RefreshGrid()
        Try
            If store Is Nothing Then Return
            Dim view As New DataTable("BibleVerses")
            view = store.Copy()
            dataGridView1.DataSource = view
            FormatGrid()
            lblDatabase.Text = "Storage: " & StoragePath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
        Catch ex As Exception
            LogStep("RefreshGrid failed: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dataGridView1.Columns.Count = 0 Then Return
        With dataGridView1
            .Columns("VerseID").HeaderText = "ID"
            .Columns("Book").HeaderText = "Book"
            .Columns("Chapter").HeaderText = "Chapter"
            .Columns("Verse").HeaderText = "Verse"
            .Columns("Content").HeaderText = "Content"
            .Columns("Translation").HeaderText = "Translation"
            .Columns("Remarks").HeaderText = "Remarks"
            .Columns("Category").HeaderText = "Category"
        End With
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try
            If Not IsValidInput() Then Return
            Dim row As DataRow = store.NewRow()
            row.Item("VerseID") = nextId
            row.Item("Book") = txtBook.Text.Trim()
            row.Item("Chapter") = IntValue(txtChapter.Text)
            row.Item("Verse") = IntValue(txtVerse.Text)
            row.Item("Content") = txtContent.Text.Trim()
            row.Item("Translation") = txtTranslation.Text.Trim()
            row.Item("Remarks") = txtRemarks.Text.Trim()
            row.Item("Category") = txtCategory.Text.Trim()
            Dim newId As Integer = SaveNewRecord(row)
            MessageBox.Show("The record was saved." & vbCrLf & vbCrLf & "New ID: " & newId.ToString(), _
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
                If Convert.ToInt32(row.Item("VerseID")) = selectedId Then
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
            found.Item("Book") = txtBook.Text.Trim()
            found.Item("Chapter") = IntValue(txtChapter.Text)
            found.Item("Verse") = IntValue(txtVerse.Text)
            found.Item("Content") = txtContent.Text.Trim()
            found.Item("Translation") = txtTranslation.Text.Trim()
            found.Item("Remarks") = txtRemarks.Text.Trim()
            found.Item("Category") = txtCategory.Text.Trim()
            SaveChangedRecord(found)
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
            DeleteRecord(selectedId)
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
        If row.Cells("VerseID").Value Is Nothing Then Return
        If row.Cells("VerseID").Value Is DBNull.Value Then Return
        isLoading = True
        Try
            selectedId = Convert.ToInt32(row.Cells("VerseID").Value)
            txtVerseID.Text = selectedId.ToString()
            txtBook.Text = Convert.ToString(row.Cells("Book").Value)
            txtChapter.Text = Convert.ToString(row.Cells("Chapter").Value)
            txtVerse.Text = Convert.ToString(row.Cells("Verse").Value)
            txtContent.Text = Convert.ToString(row.Cells("Content").Value)
            txtTranslation.Text = Convert.ToString(row.Cells("Translation").Value)
            txtRemarks.Text = Convert.ToString(row.Cells("Remarks").Value)
            txtCategory.Text = Convert.ToString(row.Cells("Category").Value)
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
        txtVerseID.Clear()
        txtBook.Clear()
        txtChapter.Clear()
        txtVerse.Clear()
        txtContent.Clear()
        txtTranslation.Clear()
        txtRemarks.Clear()
        txtCategory.Clear()
        txtBook.Focus()
        isLoading = False
    End Sub

    Private Function IsValidInput() As Boolean
        If txtBook.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Book.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBook.Focus()
            Return False
        End If
        If txtChapter.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Chapter.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChapter.Focus()
            Return False
        End If
        Dim ChapterNum As Integer = 0
        If txtChapter.Text.Trim() <> "" AndAlso Not Integer.TryParse(txtChapter.Text.Trim(), ChapterNum) Then
            MessageBox.Show("The Chapter must be a whole number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChapter.Focus()
            Return False
        End If
        If txtVerse.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Verse.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerse.Focus()
            Return False
        End If
        Dim VerseNum As Integer = 0
        If txtVerse.Text.Trim() <> "" AndAlso Not Integer.TryParse(txtVerse.Text.Trim(), VerseNum) Then
            MessageBox.Show("The Verse must be a whole number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerse.Focus()
            Return False
        End If
        If txtContent.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Content.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Return False
        End If
        If txtTranslation.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Translation.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTranslation.Focus()
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
