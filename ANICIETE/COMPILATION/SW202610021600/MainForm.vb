Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private statusBar As Label
    Private tabs As TabControl
    Private explorerTab As TabPage
    Private listTab As TabPage
    Private treeTab As TabPage
    Private answersTab As TabPage

    Public Sub New()
        Me.Text = "Activity 11 - SW202610021600 - Windows Forms Controls  |  Aniciete, Shane Antoinette"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 600)
        statusBar = New Label()
        statusBar.Dock = DockStyle.Bottom
        statusBar.Height = 24
        statusBar.TextAlign = ContentAlignment.MiddleRight
        statusBar.ForeColor = Color.FromArgb(139, 100, 132)
        statusBar.Text = "Author: Aniciete, Shane Antoinette   |   BSIT 3B   |   Activity 11 - SW202610021600"
        Me.Controls.Add(statusBar)

        tabs = New TabControl()
        tabs.Dock = DockStyle.Fill
        explorerTab = New TabPage("File explorer + dialogs")
        listTab = New TabPage("ListView examples")
        treeTab = New TabPage("TreeView examples")
        answersTab = New TabPage("Assignment answers")
        tabs.TabPages.Add(explorerTab)
        tabs.TabPages.Add(listTab)
        tabs.TabPages.Add(treeTab)
        tabs.TabPages.Add(answersTab)
        Me.Controls.Add(tabs)
        EmbedForm(New CombinedSample(), explorerTab)
        EmbedForm(New ListViewSample(), listTab)
        EmbedForm(New TreeViewSample(), treeTab)
        BuildAnswersTab()
    End Sub

    Private Sub EmbedForm(ByVal child As Form, ByVal page As TabPage)
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        page.Controls.Add(child)
        child.Show()
    End Sub

    Private Sub BuildAnswersTab()
        Dim text As New RichTextBox()
        text.Dock = DockStyle.Fill
        text.ReadOnly = True
        text.Font = New Font("Segoe UI", 11.0F)
        text.Text = "Activity 11 - SW202610021600" & Environment.NewLine & _
                    "Author : Aniciete, Shane Antoinette   |   Course, Year and Section : BSIT 3B" & _
                    Environment.NewLine & Environment.NewLine & _
                    "Question 6 - ListView" & Environment.NewLine & _
                    "The ListView examples tab imitates File Explorer with folder browsing, Details/List views, columns, sorting, double-click opening, and a status bar." & Environment.NewLine & Environment.NewLine & _
                    "Question 7 - TreeView" & Environment.NewLine & _
                    "The TreeView examples tab displays drives and directories. Nodes are loaded when expanded and the selected path is shown." & Environment.NewLine & Environment.NewLine & _
                    "Question 8 - OpenFileDialog" & Environment.NewLine & _
                    "The File explorer + dialogs tab demonstrates OpenFileDialog, file filters, multiple selection, CheckFileExists, and RestoreDirectory." & Environment.NewLine & Environment.NewLine & _
                    "Question 9 - Combined form" & Environment.NewLine & _
                    "The File explorer + dialogs tab combines OpenFileDialog, SaveFileDialog, TreeView, ListView, folder navigation, and saving a directory listing."
        answersTab.Controls.Add(text)
    End Sub
End Class
