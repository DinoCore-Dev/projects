<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewSample
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlPath = New System.Windows.Forms.Panel()
        Me.lblPathCaption = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.lbl = New System.Windows.Forms.Label()
        Me.pnlRail = New System.Windows.Forms.Panel()
        Me.pnlRuleR = New System.Windows.Forms.Panel()
        Me.lblRailTitle = New System.Windows.Forms.Label()
        Me.lblRailSub = New System.Windows.Forms.Label()
        Me.browse = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.details = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.Button()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuList = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTree = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCombined = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPath.SuspendLayout()
        Me.pnlRail.SuspendLayout()
        Me.pnlRuleR.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPath
        '
        Me.pnlPath.Controls.Add(Me.lblPathCaption)
        Me.pnlPath.Controls.Add(Me.txtPath)
        Me.pnlPath.Location = New System.Drawing.Point(194, 40)
        Me.pnlPath.Size = New System.Drawing.Size(730, 66)
        Me.pnlPath.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pnlPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPath.Name = "pnlPath"
        Me.pnlPath.TabIndex = 0
        '
        'lblPathCaption
        '
        Me.lblPathCaption.Location = New System.Drawing.Point(16, 8)
        Me.lblPathCaption.Size = New System.Drawing.Size(300, 18)
        Me.lblPathCaption.Text = "CURRENT FOLDER"
        Me.lblPathCaption.AutoSize = False
        Me.lblPathCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPathCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblPathCaption.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblPathCaption.Name = "lblPathCaption"
        Me.lblPathCaption.TabIndex = 1
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(16, 30)
        Me.txtPath.Size = New System.Drawing.Size(698, 23)
        Me.txtPath.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtPath.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.TabIndex = 2
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(194, 120)
        Me.lv.Size = New System.Drawing.Size(730, 424)
        Me.lv.View = System.Windows.Forms.View.Details
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = False
        Me.lv.HideSelection = False
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv.Columns.Add("Name", 300)
        Me.lv.Columns.Add("Type", 150)
        Me.lv.Columns.Add("Modified/Size", 200)
        Me.lv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lv.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.lv.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lv.Name = "lv"
        Me.lv.TabIndex = 3
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(194, 556)
        Me.lbl.Size = New System.Drawing.Size(560, 22)
        Me.lbl.Text = "0 item(s)"
        Me.lbl.AutoSize = False
        Me.lbl.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lbl.TextAlign = System.Windows.Forms.ContentAlignment.MiddleLeft
        Me.lbl.Name = "lbl"
        Me.lbl.TabIndex = 4
        '
        'pnlRail
        '
        Me.pnlRail.Controls.Add(Me.pnlRuleR)
        Me.pnlRail.Controls.Add(Me.lblRailTitle)
        Me.pnlRail.Controls.Add(Me.lblRailSub)
        Me.pnlRail.Controls.Add(Me.browse)
        Me.pnlRail.Controls.Add(Me.btnRefresh)
        Me.pnlRail.Controls.Add(Me.details)
        Me.pnlRail.Controls.Add(Me.list)
        Me.pnlRail.Controls.Add(Me.lblAuthor)
        Me.pnlRail.Location = New System.Drawing.Point(0, 24)
        Me.pnlRail.Size = New System.Drawing.Size(170, 576)
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.TabIndex = 5
        '
        'pnlRuleR
        '
        Me.pnlRuleR.Location = New System.Drawing.Point(18, 26)
        Me.pnlRuleR.Size = New System.Drawing.Size(40, 4)
        Me.pnlRuleR.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.pnlRuleR.Name = "pnlRuleR"
        Me.pnlRuleR.TabIndex = 6
        '
        'lblRailTitle
        '
        Me.lblRailTitle.Location = New System.Drawing.Point(18, 40)
        Me.lblRailTitle.Size = New System.Drawing.Size(140, 56)
        Me.lblRailTitle.Text = "ListView File Explorer"
        Me.lblRailTitle.AutoSize = False
        Me.lblRailTitle.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailTitle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblRailTitle.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblRailTitle.Name = "lblRailTitle"
        Me.lblRailTitle.TabIndex = 7
        '
        'lblRailSub
        '
        Me.lblRailSub.Location = New System.Drawing.Point(18, 100)
        Me.lblRailSub.Size = New System.Drawing.Size(138, 48)
        Me.lblRailSub.Text = "Browse a folder in Details or List view."
        Me.lblRailSub.AutoSize = False
        Me.lblRailSub.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblRailSub.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblRailSub.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblRailSub.Name = "lblRailSub"
        Me.lblRailSub.TabIndex = 8
        '
        'browse
        '
        Me.browse.Location = New System.Drawing.Point(16, 170)
        Me.browse.Size = New System.Drawing.Size(138, 40)
        Me.browse.Text = "Browse..."
        Me.browse.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.browse.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.browse.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.browse.FlatAppearance.BorderSize = 1
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse.UseVisualStyleBackColor = False
        Me.browse.Name = "browse"
        Me.browse.TabIndex = 9
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(16, 218)
        Me.btnRefresh.Size = New System.Drawing.Size(138, 40)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 10
        '
        'details
        '
        Me.details.Location = New System.Drawing.Point(16, 266)
        Me.details.Size = New System.Drawing.Size(138, 40)
        Me.details.Text = "Details"
        Me.details.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.details.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.details.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.details.FlatAppearance.BorderSize = 1
        Me.details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.details.UseVisualStyleBackColor = False
        Me.details.Name = "details"
        Me.details.TabIndex = 11
        '
        'list
        '
        Me.list.Location = New System.Drawing.Point(16, 314)
        Me.list.Size = New System.Drawing.Size(138, 40)
        Me.list.Text = "List"
        Me.list.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.list.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.list.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.list.FlatAppearance.BorderSize = 1
        Me.list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.list.UseVisualStyleBackColor = False
        Me.list.Name = "list"
        Me.list.TabIndex = 12
        '
        'lblAuthor
        '
        Me.lblAuthor.Location = New System.Drawing.Point(18, 478)
        Me.lblAuthor.Size = New System.Drawing.Size(138, 70)
        Me.lblAuthor.Text = "Author: Viernes, Mark Syrel  |  BSIT 3B"
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblAuthor.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.TabIndex = 13
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuForms})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Size = New System.Drawing.Size(940, 24)
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.menuStrip1.TabIndex = 14
        '
        'menuForms
        '
        Me.menuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuList, Me.menuTree, Me.menuOpen, Me.menuCombined, Me.menuExit})
        Me.menuForms.Text = "Forms"
        Me.menuForms.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuForms.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuForms.Name = "menuForms"
        '
        'menuList
        '
        Me.menuList.Text = "ListView File Explorer"
        Me.menuList.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuList.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuList.Name = "menuList"
        '
        'menuTree
        '
        Me.menuTree.Text = "TreeView File Explorer"
        Me.menuTree.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuTree.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuTree.Name = "menuTree"
        '
        'menuOpen
        '
        Me.menuOpen.Text = "OpenFileDialog File Explorer"
        Me.menuOpen.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuOpen.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuOpen.Name = "menuOpen"
        '
        'menuCombined
        '
        Me.menuCombined.Text = "Combined File Explorer"
        Me.menuCombined.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuCombined.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuCombined.Name = "menuCombined"
        '
        'menuExit
        '
        Me.menuExit.Text = "Exit"
        Me.menuExit.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.menuExit.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.menuExit.Name = "menuExit"
        '
        'ListViewSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 600)
        Me.Controls.Add(Me.pnlPath)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.pnlRail)
        Me.Controls.Add(Me.menuStrip1)
        Me.MainMenuStrip = Me.menuStrip1
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.Name = "ListViewSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 9 - ListView File Explorer  |  Viernes, Mark Syrel"
        Me.pnlPath.ResumeLayout(False)
        Me.pnlRail.ResumeLayout(False)
        Me.pnlRuleR.ResumeLayout(False)
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlPath As System.Windows.Forms.Panel
    Friend WithEvents lblPathCaption As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents pnlRail As System.Windows.Forms.Panel
    Friend WithEvents pnlRuleR As System.Windows.Forms.Panel
    Friend WithEvents lblRailTitle As System.Windows.Forms.Label
    Friend WithEvents lblRailSub As System.Windows.Forms.Label
    Friend WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents details As System.Windows.Forms.Button
    Friend WithEvents list As System.Windows.Forms.Button
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCombined As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
End Class
