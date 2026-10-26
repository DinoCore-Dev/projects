' Picture source only: MenuForm of Activity 11 builds its MenuStrip in code.
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.treeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.openMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.combinedMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openMenu, Me.combinedMenu, Me.exitMenu, Me.treeMenu})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(720, 24)
        '
        'treeMenu
        '
        Me.treeMenu.Name = "treeMenu"
        Me.treeMenu.Size = New System.Drawing.Size(140, 20)
        Me.treeMenu.Text = "TreeView File Explorer"
        '
        'openMenu
        '
        Me.openMenu.Name = "openMenu"
        Me.openMenu.Size = New System.Drawing.Size(170, 20)
        Me.openMenu.Text = "OpenFileDialog File Explorer"
        '
        'combinedMenu
        '
        Me.combinedMenu.Name = "combinedMenu"
        Me.combinedMenu.Size = New System.Drawing.Size(140, 20)
        Me.combinedMenu.Text = "Combined File Explorer"
        '
        'exitMenu
        '
        Me.exitMenu.Name = "exitMenu"
        Me.exitMenu.Size = New System.Drawing.Size(40, 20)
        Me.exitMenu.Text = "Exit"
        '
        'MenuForm
        '
        Me.ClientSize = New System.Drawing.Size(720, 376)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
    End Sub
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents treeMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents combinedMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitMenu As System.Windows.Forms.ToolStripMenuItem
End Class
