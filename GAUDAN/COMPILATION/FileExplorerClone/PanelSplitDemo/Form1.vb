' ============================================================
' Activity 12 - PanelSplitDemo  (Gaudan Explorer)
' A small file explorer built with TreeView + ListView + preview
' inside nested SplitContainer controls.
' Author : Gaudan, Darwin   |   BSIT 3B
' ============================================================
Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text

Public Class Form1

    Private currentFolder As String = ""
    Private ReadOnly backStack As New Stack(Of String)()
    Private ReadOnly forwardStack As New Stack(Of String)()
    Private syncingTree As Boolean = False
    Private splittersLocked As Boolean = False
    Private lastSortColumn As Integer = -1
    Private sortAscending As Boolean = True

    Private ReadOnly imageTypes As String() = _
        {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico", ".tif", ".tiff"}

    Private ReadOnly textTypes As String() = _
        {".txt", ".vb", ".cs", ".xml", ".config", ".csv", ".log", ".md", ".json", _
         ".ini", ".html", ".htm", ".css", ".js", ".sql", ".bat", ".sln", ".vbproj"}

    ' ---------------------------------------------------------
    ' start up
    ' ---------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            BuildFolderTree()
            ApplyDefaultLayout()
            NavigateTo(StartFolder(), False)
        Catch ex As Exception
            lblStatus.Text = "The explorer could not start : " & ex.Message
        End Try
    End Sub

    Private Function StartFolder() As String
        Dim documents As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If Directory.Exists(documents) Then Return documents

        Dim desktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        If Directory.Exists(desktopFolder) Then Return desktopFolder

        Return Environment.CurrentDirectory
    End Function

    ' ---------------------------------------------------------
    ' folder tree
    ' ---------------------------------------------------------
    Private Sub BuildFolderTree()
        tvFolders.BeginUpdate()
        tvFolders.Nodes.Clear()

        AddRootFolder("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        AddRootFolder("Documents", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        AddRootFolder("Pictures", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
        AddRootFolder("Downloads", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"))

        For Each drive As DriveInfo In DriveInfo.GetDrives()
            If drive.IsReady Then
                AddRootFolder(drive.Name, drive.RootDirectory.FullName)
            End If
        Next

        tvFolders.EndUpdate()
        lblStatus.Text = tvFolders.Nodes.Count.ToString() & " root folder(s) listed."
    End Sub

    Private Sub AddRootFolder(ByVal title As String, ByVal folderPath As String)
        If folderPath = "" OrElse Not Directory.Exists(folderPath) Then Return

        Dim node As New TreeNode(title)
        node.Tag = folderPath
        node.Nodes.Add(New TreeNode("loading"))
        tvFolders.Nodes.Add(node)
    End Sub

    Private Sub tvFolders_BeforeExpand(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles tvFolders.BeforeExpand
        If e.Node.Tag Is Nothing Then Return
        If e.Node.Nodes.Count <> 1 OrElse e.Node.Nodes(0).Text <> "loading" Then Return
        If e.Node.Nodes(0).Tag IsNot Nothing Then Return

        Dim parentPath As String = CStr(e.Node.Tag)
        e.Node.Nodes.Clear()

        Try
            For Each childPath As String In Directory.GetDirectories(parentPath)
                Dim child As New TreeNode(Path.GetFileName(childPath))
                If child.Text = "" Then child.Text = childPath
                child.Tag = childPath
                child.Nodes.Add(New TreeNode("loading"))
                e.Node.Nodes.Add(child)
            Next
        Catch ex As Exception
            lblStatus.Text = "Some folders cannot be listed : " & ex.Message
        End Try

        If e.Node.Nodes.Count = 0 Then e.Node.Nodes.Add(New TreeNode("empty"))
    End Sub

    Private Sub tvFolders_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tvFolders.AfterSelect
        If syncingTree Then Return
        If e.Node.Tag Is Nothing Then Return

        Dim folderPath As String = CStr(e.Node.Tag)
        If Directory.Exists(folderPath) Then
            NavigateTo(folderPath, True)
        End If
    End Sub

    ' ---------------------------------------------------------
    ' navigation
    ' ---------------------------------------------------------
    Private Sub NavigateTo(ByVal folderPath As String, ByVal remember As Boolean)
        If folderPath = "" OrElse Not Directory.Exists(folderPath) Then
            lblStatus.Text = "Folder not found : " & folderPath
            Return
        End If

        If remember AndAlso currentFolder <> "" AndAlso currentFolder <> folderPath Then
            backStack.Push(currentFolder)
            forwardStack.Clear()
        End If

        ShowFolder(folderPath)
    End Sub

    Private Sub ShowFolder(ByVal folderPath As String)
        currentFolder = folderPath
        txtPath.Text = folderPath
        RefreshFileList()
        SyncTreeSelection(folderPath)
        ShowPreview("")
        lblStatus.Text = "Now browsing : " & folderPath
    End Sub

    Private Sub SyncTreeSelection(ByVal folderPath As String)
        syncingTree = True
        Try
            Dim node As TreeNode = FindNode(tvFolders.Nodes, folderPath)
            If node IsNot Nothing Then
                tvFolders.SelectedNode = node
                node.EnsureVisible()
            End If
        Finally
            syncingTree = False
        End Try
    End Sub

    Private Function FindNode(ByVal siblings As TreeNodeCollection, ByVal folderPath As String) As TreeNode
        For Each node As TreeNode In siblings
            If node.Tag IsNot Nothing AndAlso _
               String.Equals(CStr(node.Tag), folderPath, StringComparison.OrdinalIgnoreCase) Then
                Return node
            End If

            If node.IsExpanded AndAlso node.Nodes.Count > 0 Then
                Dim found As TreeNode = FindNode(node.Nodes, folderPath)
                If found IsNot Nothing Then Return found
            End If
        Next
        Return Nothing
    End Function

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        If backStack.Count = 0 Then
            lblStatus.Text = "There is no previous folder in the history."
            Return
        End If

        forwardStack.Push(currentFolder)
        ShowFolder(backStack.Pop())
    End Sub

    Private Sub btnForward_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForward.Click
        If forwardStack.Count = 0 Then
            lblStatus.Text = "There is no next folder in the history."
            Return
        End If

        backStack.Push(currentFolder)
        ShowFolder(forwardStack.Pop())
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUp.Click
        If currentFolder = "" Then Return

        Dim parent As String = Path.GetDirectoryName(currentFolder)
        If parent Is Nothing OrElse parent = "" Then
            lblStatus.Text = "This is already the top of the drive."
            Return
        End If

        NavigateTo(parent, True)
    End Sub

    Private Sub btnHome_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHome.Click
        NavigateTo(StartFolder(), True)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        RefreshFileList()
        lblStatus.Text = "Folder refreshed."
    End Sub

    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGo.Click
        NavigateTo(txtPath.Text.Trim(), True)
    End Sub

    Private Sub txtPath_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPath.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            NavigateTo(txtPath.Text.Trim(), True)
        End If
    End Sub

    ' ---------------------------------------------------------
    ' file list
    ' ---------------------------------------------------------
    Private Sub RefreshFileList()
        lvFiles.BeginUpdate()
        lvFiles.Items.Clear()

        If currentFolder = "" OrElse Not Directory.Exists(currentFolder) Then
            lvFiles.EndUpdate()
            lblCount.Text = "0 item(s)"
            Return
        End If

        Dim keyword As String = txtFilter.Text.Trim()

        Try
            For Each folderPath As String In Directory.GetDirectories(currentFolder)
                Dim folderInfo As New DirectoryInfo(folderPath)
                If IsHidden(folderInfo) Then Continue For
                If Not Matches(keyword, folderInfo.Name) Then Continue For
                AddRow(folderInfo.Name, "File folder", "", folderInfo.LastWriteTime, folderInfo.FullName)
            Next

            For Each filePath As String In Directory.GetFiles(currentFolder)
                Dim fileInfo As New FileInfo(filePath)
                If IsHidden(fileInfo) Then Continue For
                If Not Matches(keyword, fileInfo.Name) Then Continue For
                AddRow(fileInfo.Name, TypeLabel(fileInfo), SizeLabel(fileInfo.Length), _
                       fileInfo.LastWriteTime, fileInfo.FullName)
            Next
        Catch ex As Exception
            lblStatus.Text = "This folder cannot be fully listed : " & ex.Message
        Finally
            lvFiles.EndUpdate()
        End Try

        If lastSortColumn >= 0 Then ApplySort(lastSortColumn, False)

        lblCount.Text = lvFiles.Items.Count.ToString() & " item(s)   |   " & currentFolder
    End Sub

    Private Sub AddRow(ByVal name As String, ByVal kind As String, ByVal size As String, _
                       ByVal modified As Date, ByVal fullPath As String)
        Dim row As New ListViewItem(name)
        row.SubItems.Add(kind)
        row.SubItems.Add(size)
        row.SubItems.Add(modified.ToString("MMM d, yyyy  h:mm tt"))
        row.Tag = fullPath
        lvFiles.Items.Add(row)
    End Sub

    Private Function IsHidden(ByVal info As FileSystemInfo) As Boolean
        Return (info.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden
    End Function

    Private Function Matches(ByVal keyword As String, ByVal itemName As String) As Boolean
        If keyword = "" Then Return True
        Return itemName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
    End Function

    Private Function TypeLabel(ByVal info As FileInfo) As String
        If info.Extension = "" Then Return "File"
        Return info.Extension.Substring(1).ToUpperInvariant() & " file"
    End Function

    Private Function SizeLabel(ByVal bytes As Long) As String
        If bytes >= 1073741824 Then Return (bytes / 1073741824.0).ToString("0.00") & " GB"
        If bytes >= 1048576 Then Return (bytes / 1048576.0).ToString("0.00") & " MB"
        If bytes >= 1024 Then Return (bytes / 1024.0).ToString("0.0") & " KB"
        Return bytes.ToString() & " B"
    End Function

    Private Sub txtFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtFilter.TextChanged
        If currentFolder = "" Then Return
        RefreshFileList()
    End Sub

    ' ---------------------------------------------------------
    ' sorting
    ' ---------------------------------------------------------
    Private Sub lvFiles_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles lvFiles.ColumnClick
        If lastSortColumn = e.Column Then
            sortAscending = Not sortAscending
        Else
            lastSortColumn = e.Column
            sortAscending = True
        End If

        ApplySort(e.Column, sortAscending)
        lblStatus.Text = "Sorted by column " & (e.Column + 1).ToString() & If(sortAscending, " (A to Z)", " (Z to A)")
    End Sub

    Private Sub ApplySort(ByVal column As Integer, ByVal ascending As Boolean)
        lvFiles.ListViewItemSorter = New ItemSorter(column, ascending)
        lvFiles.Sort()
    End Sub

    ' Compares two ListView rows; the size column is compared as a number.
    Friend Class ItemSorter
        Implements System.Collections.IComparer

        Private ReadOnly columnIndex As Integer
        Private ReadOnly ascendingOrder As Boolean

        Public Sub New(ByVal column As Integer, ByVal ascending As Boolean)
            columnIndex = column
            ascendingOrder = ascending
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim leftRow As ListViewItem = CType(x, ListViewItem)
            Dim rightRow As ListViewItem = CType(y, ListViewItem)

            Dim leftText As String = If(leftRow.SubItems.Count > columnIndex, leftRow.SubItems(columnIndex).Text, "")
            Dim rightText As String = If(rightRow.SubItems.Count > columnIndex, rightRow.SubItems(columnIndex).Text, "")

            Dim answer As Integer
            If columnIndex = 2 Then
                answer = BytesOf(leftText).CompareTo(BytesOf(rightText))
            Else
                answer = String.Compare(leftText, rightText, StringComparison.OrdinalIgnoreCase)
            End If

            If Not ascendingOrder Then answer = -answer
            Return answer
        End Function

        Private Function BytesOf(ByVal sizeText As String) As Double
            Dim numberPart As String = ""
            For Each character As Char In sizeText
                If Char.IsDigit(character) OrElse character = "."c Then
                    numberPart &= character
                Else
                    Exit For
                End If
            Next

            Dim value As Double = 0
            Double.TryParse(numberPart, value)

            If sizeText.Contains("GB") Then Return value * 1073741824
            If sizeText.Contains("MB") Then Return value * 1048576
            If sizeText.Contains("KB") Then Return value * 1024
            Return value
        End Function
    End Class

    ' ---------------------------------------------------------
    ' preview
    ' ---------------------------------------------------------
    Private Sub lvFiles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvFiles.SelectedIndexChanged
        If lvFiles.SelectedItems.Count = 0 Then
            ShowPreview("")
            Return
        End If

        ShowPreview(CStr(lvFiles.SelectedItems(0).Tag))
    End Sub

    Private Sub lvFiles_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvFiles.DoubleClick
        If lvFiles.SelectedItems.Count = 0 Then Return

        Dim chosenPath As String = CStr(lvFiles.SelectedItems(0).Tag)

        If Directory.Exists(chosenPath) Then
            NavigateTo(chosenPath, True)
            Return
        End If

        Try
            Process.Start(chosenPath)
        Catch ex As Exception
            lblStatus.Text = "This file cannot be opened : " & ex.Message
        End Try
    End Sub

    Private Sub ShowPreview(ByVal chosenPath As String)
        ReleasePicture()

        If chosenPath = "" Then
            lblPreviewTitle.Text = "PREVIEW"
            txtPreview.Visible = True
            txtPreview.Text = "Select a file or a folder to preview it here."
            Return
        End If

        Dim itemName As String = Path.GetFileName(chosenPath)
        If itemName = "" Then itemName = chosenPath
        lblPreviewTitle.Text = "PREVIEW  -  " & itemName

        If Directory.Exists(chosenPath) Then
            ShowFolderPreview(chosenPath)
            Return
        End If

        If Not File.Exists(chosenPath) Then
            txtPreview.Visible = True
            txtPreview.Text = "The selected item no longer exists."
            Return
        End If

        Dim info As New FileInfo(chosenPath)
        Dim extension As String = info.Extension.ToLowerInvariant()

        If IsOneOf(extension, imageTypes) Then
            If ShowImagePreview(chosenPath) Then Return
        End If

        txtPreview.Visible = True

        If IsOneOf(extension, textTypes) Then
            txtPreview.Text = ReadTextPreview(chosenPath, info)
        Else
            txtPreview.Text = "Name          : " & info.Name & vbCrLf & _
                              "Type          : " & TypeLabel(info) & vbCrLf & _
                              "Size          : " & SizeLabel(info.Length) & vbCrLf & _
                              "Created       : " & info.CreationTime.ToString("MMM d, yyyy  h:mm tt") & vbCrLf & _
                              "Last modified : " & info.LastWriteTime.ToString("MMM d, yyyy  h:mm tt") & vbCrLf & _
                              "Attributes    : " & info.Attributes.ToString() & vbCrLf & vbCrLf & _
                              "There is no built-in preview for this file type."
        End If
    End Sub

    Private Function IsOneOf(ByVal value As String, ByVal choices As String()) As Boolean
        For Each choice As String In choices
            If value = choice Then Return True
        Next
        Return False
    End Function

    Private Function ShowImagePreview(ByVal filePath As String) As Boolean
        Try
            Using stream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                Using source As Image = Image.FromStream(stream)
                    pbPreview.Image = New Bitmap(source)
                End Using
            End Using

            txtPreview.Visible = False
            pbPreview.Visible = True
            lblStatus.Text = "Image preview : " & Path.GetFileName(filePath)
            Return True
        Catch ex As Exception
            txtPreview.Visible = True
            pbPreview.Visible = False
            txtPreview.Text = "The image cannot be previewed." & vbCrLf & ex.Message
            Return True
        End Try
    End Function

    Private Sub ShowFolderPreview(ByVal folderPath As String)
        Dim summary As New StringBuilder()
        Dim folderCount As Integer = 0
        Dim fileCount As Integer = 0
        Dim totalSize As Long = 0

        Try
            For Each childFolder As String In Directory.GetDirectories(folderPath)
                folderCount += 1
            Next

            For Each childFile As String In Directory.GetFiles(folderPath)
                Dim childInfo As New FileInfo(childFile)
                fileCount += 1
                totalSize += childInfo.Length
            Next
        Catch ex As Exception
            summary.AppendLine("Some items cannot be counted : " & ex.Message)
        End Try

        Dim parentPath As String = Path.GetDirectoryName(folderPath)
        If parentPath Is Nothing Then parentPath = folderPath

        summary.AppendLine("Folder        : " & folderPath)
        summary.AppendLine("Parent        : " & parentPath)
        summary.AppendLine("Sub folders   : " & folderCount.ToString())
        summary.AppendLine("Files         : " & fileCount.ToString())
        summary.AppendLine("Total size    : " & SizeLabel(totalSize))
        summary.AppendLine()
        summary.AppendLine("CONTENTS (first 40 items)")
        summary.AppendLine("-------------------------------------------")

        Try
            Dim shown As Integer = 0
            For Each childFolder As String In Directory.GetDirectories(folderPath)
                summary.AppendLine("[folder]  " & Path.GetFileName(childFolder))
                shown += 1
                If shown >= 40 Then Exit For
            Next

            If shown < 40 Then
                For Each childFile As String In Directory.GetFiles(folderPath)
                    Dim childInfo As New FileInfo(childFile)
                    summary.AppendLine("          " & childInfo.Name & "   (" & SizeLabel(childInfo.Length) & ")")
                    shown += 1
                    If shown >= 40 Then Exit For
                Next
            End If
        Catch ex As Exception
            summary.AppendLine(ex.Message)
        End Try

        txtPreview.Visible = True
        txtPreview.Text = summary.ToString()
    End Sub

    Private Function ReadTextPreview(ByVal filePath As String, ByVal info As FileInfo) As String
        Const characterLimit As Integer = 6000

        Try
            Dim buffer(characterLimit) As Char
            Dim text As New StringBuilder()

            Using reader As New StreamReader(filePath, Encoding.Default, True)
                Dim readNow As Integer = reader.Read(buffer, 0, characterLimit)
                While readNow > 0
                    text.Append(New String(buffer, 0, readNow))
                    readNow = reader.Read(buffer, 0, characterLimit)
                End While
            End Using

            Dim header As String = "Name : " & info.Name & "    Size : " & SizeLabel(info.Length) & vbCrLf & _
                                   "Modified : " & info.LastWriteTime.ToString("MMM d, yyyy  h:mm tt") & vbCrLf & _
                                   "-------------------------------------------" & vbCrLf

            Dim body As String = text.ToString()
            If body.Length >= characterLimit Then
                body &= vbCrLf & vbCrLf & "...  only the first " & characterLimit.ToString() & " characters are shown."
            End If

            Return header & body
        Catch ex As Exception
            Return "The text of this file cannot be shown." & vbCrLf & ex.Message
        End Try
    End Function

    Private Sub ClearPreview(ByVal message As String)
        ReleasePicture()
        pbPreview.Visible = False
        txtPreview.Visible = True
        txtPreview.Text = message
    End Sub

    Private Sub ReleasePicture()
        If pbPreview.Image IsNot Nothing Then
            Dim oldPicture As Image = pbPreview.Image
            pbPreview.Image = Nothing
            oldPicture.Dispose()
        End If
        pbPreview.Visible = False
    End Sub

    ' ---------------------------------------------------------
    ' split container controls
    ' ---------------------------------------------------------
    Private Sub ApplyDefaultLayout()
        splRoot.Panel1Collapsed = False
        splRoot.Panel2Collapsed = False
        splWorkspace.Panel1Collapsed = False
        splWorkspace.Panel2Collapsed = False
        splWorkspace.Orientation = Orientation.Horizontal

        btnTreeToggle.Text = "Hide folder tree"
        btnPreviewToggle.Text = "Hide preview pane"
        btnSwapLayout.Text = "Preview beside list"

        SetRatioDistance(splRoot, 0.20)
        SetRatioDistance(splWorkspace, 0.62)
        ShowSplitInfo()
    End Sub

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
        lblSplitInfo.Text = "splitRoot : " & splRoot.SplitterDistance.ToString() & " px   |   " & _
                            "splitWorkspace : " & splWorkspace.SplitterDistance.ToString() & " px"
    End Sub

    Private Sub btnTreeToggle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTreeToggle.Click
        splRoot.Panel1Collapsed = Not splRoot.Panel1Collapsed
        btnTreeToggle.Text = If(splRoot.Panel1Collapsed, "Show folder tree", "Hide folder tree")
        lblStatus.Text = "splRoot.Panel1Collapsed = " & splRoot.Panel1Collapsed.ToString()
        ShowSplitInfo()
    End Sub

    Private Sub btnPreviewToggle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreviewToggle.Click
        splWorkspace.Panel2Collapsed = Not splWorkspace.Panel2Collapsed
        btnPreviewToggle.Text = If(splWorkspace.Panel2Collapsed, "Show preview pane", "Hide preview pane")
        lblStatus.Text = "splWorkspace.Panel2Collapsed = " & splWorkspace.Panel2Collapsed.ToString()
        ShowSplitInfo()
    End Sub

    Private Sub btnSwapLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSwapLayout.Click
        Try
            If splWorkspace.Orientation = Orientation.Horizontal Then
                splWorkspace.Orientation = Orientation.Vertical
                btnSwapLayout.Text = "Preview below list"
                lblStatus.Text = "The preview is now beside the file list."
            Else
                splWorkspace.Orientation = Orientation.Horizontal
                btnSwapLayout.Text = "Preview beside list"
                lblStatus.Text = "The preview is now below the file list."
            End If

            SetRatioDistance(splWorkspace, 0.62)
            ShowSplitInfo()
        Catch ex As Exception
            lblStatus.Text = "The layout cannot be changed : " & ex.Message
        End Try
    End Sub

    Private Sub btnLockSplitters_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLockSplitters.Click
        splittersLocked = Not splittersLocked
        splRoot.IsSplitterFixed = splittersLocked
        splWorkspace.IsSplitterFixed = splittersLocked
        btnLockSplitters.Text = If(splittersLocked, "Unlock splitters", "Lock splitters")
        lblStatus.Text = "IsSplitterFixed = " & splittersLocked.ToString()
    End Sub

    Private Sub splRoot_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splRoot.SplitterMoved
        ShowSplitInfo()
        lblStatus.Text = "Folder tree width set to " & splRoot.SplitterDistance.ToString() & " pixels."
    End Sub

    Private Sub splWorkspace_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splWorkspace.SplitterMoved
        ShowSplitInfo()
        lblStatus.Text = "Preview size set to " & splWorkspace.SplitterDistance.ToString() & " pixels."
    End Sub
End Class
