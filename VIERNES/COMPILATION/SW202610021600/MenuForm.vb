Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MenuForm
    Inherits Form

    Private menuStrip1 As MenuStrip
    Private listMenu As ToolStripMenuItem
    Private treeMenu As ToolStripMenuItem
    Private openMenu As ToolStripMenuItem
    Private combinedMenu As ToolStripMenuItem
    Private exitMenu As ToolStripMenuItem
    Private lblHeading As Label
    Private lblSubheading As Label

    Public Sub New()
        Me.Text = "Activity 11 - SW202610021600  |  Viernes, Mark Syrel"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(720, 400)
        menuStrip1 = New MenuStrip()
        treeMenu = New ToolStripMenuItem("TreeView File Explorer")
        openMenu = New ToolStripMenuItem("OpenFileDialog File Explorer")
        combinedMenu = New ToolStripMenuItem("Combined File Explorer")
        exitMenu = New ToolStripMenuItem("Exit")
        menuStrip1.Items.AddRange(New ToolStripItem() {openMenu, combinedMenu, treeMenu, exitMenu})
        menuStrip1.Dock = DockStyle.Top
        menuStrip1.BackColor = Color.FromArgb(10, 12, 16)
        menuStrip1.ForeColor = Color.FromArgb(236, 239, 244)
        Me.BackColor = Color.FromArgb(17, 19, 25)
        lblHeading = New Label()
        lblHeading.AutoSize = False
        lblHeading.SetBounds(40, 72, 640, 44)
        lblHeading.Font = New Font("Corbel", 22.0F, FontStyle.Bold)
        lblHeading.ForeColor = Color.FromArgb(236, 239, 244)
        lblHeading.Text = "Windows Forms Controls"
        lblSubheading = New Label()
        lblSubheading.AutoSize = False
        lblSubheading.SetBounds(40, 120, 640, 44)
        lblSubheading.Font = New Font("Corbel", 10.0F)
        lblSubheading.ForeColor = Color.FromArgb(52, 211, 153)
        lblSubheading.Text = "File explorer demos: OpenFileDialog, the combined explorer and the TreeView."
        Me.Controls.Add(lblHeading)
        Me.Controls.Add(lblSubheading)
        Me.Controls.Add(menuStrip1)
        Me.MainMenuStrip = menuStrip1

        AddHandler treeMenu.Click, AddressOf OpenTree
        AddHandler openMenu.Click, AddressOf OpenDialog
        AddHandler combinedMenu.Click, AddressOf OpenCombined
        AddHandler exitMenu.Click, AddressOf ExitProgram
    End Sub


    Private Sub OpenTree(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New TreeViewSample()
            form.ShowDialog()
        End Using
    End Sub

    Private Sub OpenDialog(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New OpenFileDialogSample()
            form.ShowDialog()
        End Using
    End Sub

    Private Sub OpenCombined(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New CombinedSample()
            form.ShowDialog()
        End Using
    End Sub

    Private Sub ExitProgram(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'MenuForm
        '
        Me.ClientSize = New System.Drawing.Size(729, 387)
        Me.Name = "MenuForm"
        Me.ResumeLayout(False)

    End Sub

    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
