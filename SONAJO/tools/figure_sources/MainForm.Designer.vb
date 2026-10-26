' Picture source only: MainForm of Activity 11 builds its controls in code,
' so this layout mirrors that code for the Form Design / Sample Output pictures.
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.explorerTab = New System.Windows.Forms.TabPage()
        Me.listTab = New System.Windows.Forms.TabPage()
        Me.treeTab = New System.Windows.Forms.TabPage()
        Me.answersTab = New System.Windows.Forms.TabPage()
        Me.answers = New System.Windows.Forms.TextBox()
        Me.statusBar = New System.Windows.Forms.Label()
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.explorerTab)
        Me.tabs.Controls.Add(Me.listTab)
        Me.tabs.Controls.Add(Me.treeTab)
        Me.tabs.Controls.Add(Me.answersTab)
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(1000, 596)
        '
        'explorerTab
        '
        Me.explorerTab.Location = New System.Drawing.Point(4, 22)
        Me.explorerTab.Name = "explorerTab"
        Me.explorerTab.Size = New System.Drawing.Size(992, 570)
        Me.explorerTab.Text = "File explorer + dialogs"
        '
        'listTab
        '
        Me.listTab.Location = New System.Drawing.Point(4, 22)
        Me.listTab.Name = "listTab"
        Me.listTab.Size = New System.Drawing.Size(992, 570)
        Me.listTab.Text = "ListView examples"
        '
        'treeTab
        '
        Me.treeTab.Location = New System.Drawing.Point(4, 22)
        Me.treeTab.Name = "treeTab"
        Me.treeTab.Size = New System.Drawing.Size(992, 570)
        Me.treeTab.Text = "TreeView examples"
        '
        'answersTab
        '
        Me.answersTab.Controls.Add(Me.answers)
        Me.answersTab.Location = New System.Drawing.Point(4, 22)
        Me.answersTab.Name = "answersTab"
        Me.answersTab.Size = New System.Drawing.Size(992, 570)
        Me.answersTab.Text = "Assignment answers"
        '
        'answers
        '
        Me.answers.Location = New System.Drawing.Point(0, 0)
        Me.answers.Multiline = True
        Me.answers.Name = "answers"
        Me.answers.Size = New System.Drawing.Size(992, 570)
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(0, 598)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(1000, 24)
        Me.statusBar.Text = "Author"
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(1000, 622)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.statusBar)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
    End Sub
    Friend WithEvents tabs As System.Windows.Forms.TabControl
    Friend WithEvents explorerTab As System.Windows.Forms.TabPage
    Friend WithEvents listTab As System.Windows.Forms.TabPage
    Friend WithEvents treeTab As System.Windows.Forms.TabPage
    Friend WithEvents answersTab As System.Windows.Forms.TabPage
    Friend WithEvents answers As System.Windows.Forms.TextBox
    Friend WithEvents statusBar As System.Windows.Forms.Label
End Class
