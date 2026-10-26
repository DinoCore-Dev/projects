Public Class frmQuotes

    Private selectedId As Integer = 0
    Private isLoading As Boolean = False
    Private store As DataTable
    Private nextId As Integer = 1

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmQuotes] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private useSdf As Boolean = False

    Private Const SqlCeProvider As String = "System.Data.SqlServerCe.3.5"
    Private Const SqlCeEngineType As String = "System.Data.SqlServerCe.SqlCeEngine, System.Data.SqlServerCe, Version=3.5.1.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91"

    Private Function XmlPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB_Quotes.xml")
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

    Private Sub frmQuotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        store = New DataTable("Quotes")
        store.Columns.Add("QuoteID", GetType(Integer))
        store.Columns.Add("Content", GetType(String))
        store.Columns.Add("Author", GetType(String))
        store.Columns.Add("Source", GetType(String))
        store.Columns.Add("QuoteDate", GetType(Date))
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
                cmd.CommandText = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Quotes'"
                hasTable = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            End Using
            If Not hasTable Then
                Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                    cmd.CommandText = "CREATE TABLE [Quotes] ([QuoteID] INT IDENTITY(1,1) PRIMARY KEY, [Content] NVARCHAR(4000), [Author] NVARCHAR(255), [Source] NVARCHAR(255), [QuoteDate] DATETIME)"
                    cmd.ExecuteNonQuery()
                End Using
                LogStep("created table Quotes")
            End If
            Dim total As Integer = 0
            Using cmd As System.Data.Common.DbCommand = conn.CreateCommand()
                cmd.CommandText = "SELECT COUNT(*) FROM [Quotes]"
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
                cmd.CommandText = "SELECT [QuoteID], [Content], [Author], [Source], [QuoteDate] FROM [Quotes] ORDER BY [QuoteID]"
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
            cmd.CommandText = "INSERT INTO [Quotes] ([Content], [Author], [Source], [QuoteDate]) VALUES (@p1, @p2, @p3, @p4)"
            AddParam(cmd, "@p1", Convert.ToString(row.Item("Content")))
            AddParam(cmd, "@p2", Convert.ToString(row.Item("Author")))
            AddParam(cmd, "@p3", Convert.ToString(row.Item("Source")))
            AddParam(cmd, "@p4", Convert.ToDateTime(row.Item("QuoteDate")))
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
            cmd.CommandText = "UPDATE [Quotes] SET [Content] = @p1, [Author] = @p2, [Source] = @p3, [QuoteDate] = @p4 WHERE [QuoteID] = @id"
            AddParam(cmd, "@p1", Convert.ToString(row.Item("Content")))
            AddParam(cmd, "@p2", Convert.ToString(row.Item("Author")))
            AddParam(cmd, "@p3", Convert.ToString(row.Item("Source")))
            AddParam(cmd, "@p4", Convert.ToDateTime(row.Item("QuoteDate")))
            AddParam(cmd, "@id", Convert.ToInt32(row.Item("QuoteID")))
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
            Dim id As Integer = Convert.ToInt32(row.Item("QuoteID"))
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
        row.Item("QuoteID") = newId
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
                    cmd.CommandText = "DELETE FROM [Quotes] WHERE [QuoteID] = @id"
                    AddParam(cmd, "@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
        For i As Integer = store.Rows.Count - 1 To 0 Step -1
            If Convert.ToInt32(store.Rows(i).Item("QuoteID")) = id Then
                store.Rows.RemoveAt(i)
            End If
        Next
        store.AcceptChanges()
        If Not useSdf Then SaveXml()
    End Sub

    Private Sub SeedSampleData()
        Dim rows As String() = New String() { _
            "Simplicity is the soul of efficiency.|Austin Freeman|The Social Welfare of the Blind|1912-01-01", _
            "First, solve the problem. Then, write the code.|John Johnson|Tech talk|1980-05-20", _
            "Experience is the name everyone gives to their mistakes.|Oscar Wilde|Lady Windermere Fan|1892-02-20", _
            "Code is like humor. When you have to explain it, it is bad.|Cory House|Blog post|2015-03-11", _
            "Make it work, make it right, make it fast.|Kent Beck|Extreme Programming|1999-10-05", _
            "The best error message is the one that never shows up.|Thomas Fuchs|Conference talk|2011-07-19"
            }
        For Each line As String In rows
            Dim parts As String() = line.Split("|"c)
            If parts.Length = 4 Then
                Dim row As DataRow = store.NewRow()
                row.Item("QuoteID") = nextId
                row.Item("Content") = parts(0)
                row.Item("Author") = parts(1)
                row.Item("Source") = parts(2)
                row.Item("QuoteDate") = DateValue(parts(3))
                store.Rows.Add(row)
                nextId += 1
            End If
        Next
    End Sub

    Private Sub RefreshGrid()
        Try
            If store Is Nothing Then Return
            Dim view As New DataTable("Quotes")
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
            .Columns("QuoteID").HeaderText = "ID"
            .Columns("Content").HeaderText = "Content"
            .Columns("Author").HeaderText = "Author"
            .Columns("Source").HeaderText = "Source"
            .Columns("QuoteDate").HeaderText = "Quote Date"
        End With
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try
            If Not IsValidInput() Then Return
            Dim row As DataRow = store.NewRow()
            row.Item("QuoteID") = nextId
            row.Item("Content") = txtContent.Text.Trim()
            row.Item("Author") = txtAuthor.Text.Trim()
            row.Item("Source") = txtSource.Text.Trim()
            row.Item("QuoteDate") = dtpQuoteDate.Value.Date
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
                If Convert.ToInt32(row.Item("QuoteID")) = selectedId Then
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
            found.Item("Content") = txtContent.Text.Trim()
            found.Item("Author") = txtAuthor.Text.Trim()
            found.Item("Source") = txtSource.Text.Trim()
            found.Item("QuoteDate") = dtpQuoteDate.Value.Date
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
        If row.Cells("QuoteID").Value Is Nothing Then Return
        If row.Cells("QuoteID").Value Is DBNull.Value Then Return
        isLoading = True
        Try
            selectedId = Convert.ToInt32(row.Cells("QuoteID").Value)
            txtQuoteID.Text = selectedId.ToString()
            txtContent.Text = Convert.ToString(row.Cells("Content").Value)
            txtAuthor.Text = Convert.ToString(row.Cells("Author").Value)
            txtSource.Text = Convert.ToString(row.Cells("Source").Value)
            Dim QuoteDateDate As Date
            If Date.TryParse(Convert.ToString(row.Cells("QuoteDate").Value), QuoteDateDate) Then
                dtpQuoteDate.Value = QuoteDateDate
            End If
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
        txtQuoteID.Clear()
        txtContent.Clear()
        txtAuthor.Clear()
        txtSource.Clear()
        dtpQuoteDate.Value = Date.Today
        txtContent.Focus()
        isLoading = False
    End Sub

    Private Function IsValidInput() As Boolean
        If txtContent.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Content.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Return False
        End If
        If txtAuthor.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Author.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAuthor.Focus()
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
