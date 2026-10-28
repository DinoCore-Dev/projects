' Picture source only: MenuForm of Activity 11 builds its MenuStrip in code.
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.treeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.openMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.combinedMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubheading = New System.Windows.Forms.Label()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openMenu, Me.combinedMenu, Me.treeMenu, Me.exitMenu})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuStrip1.Font = New System.Drawing.Font("Corbel", 8.25!)
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
        'lblHeading
        '
        Me.lblHeading.AutoSize = False
        Me.lblHeading.Font = New System.Drawing.Font("Corbel", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblHeading.Location = New System.Drawing.Point(40, 72)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(640, 44)
        Me.lblHeading.Text = "Windows Forms Controls"
        '
        'lblSubheading
        '
        Me.lblSubheading.AutoSize = False
        Me.lblSubheading.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblSubheading.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.lblSubheading.Location = New System.Drawing.Point(40, 120)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(640, 44)
        Me.lblSubheading.Text = "File explorer demos: OpenFileDialog, the combined explorer and the TreeView."
        '
        'MenuForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.ClientSize = New System.Drawing.Size(720, 376)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblSubheading)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
    End Sub
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents treeMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents combinedMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblSubheading As System.Windows.Forms.Label
End Class
