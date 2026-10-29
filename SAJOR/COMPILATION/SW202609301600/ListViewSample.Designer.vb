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
        Me.lv = New System.Windows.Forms.ListView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.pnlPath = New System.Windows.Forms.Panel()
        Me.lblPathCaption = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.pnlRail = New System.Windows.Forms.Panel()
        Me.pnlRuleR = New System.Windows.Forms.Panel()
        Me.lblRailTitle = New System.Windows.Forms.Label()
        Me.lblRailSub = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.browse = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.details = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.Button()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCombined = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTree = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuList = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBottom.SuspendLayout()
        Me.pnlPath.SuspendLayout()
        Me.pnlRail.SuspendLayout()
        Me.pnlRuleR.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(0, 170)
        Me.lv.Size = New System.Drawing.Size(940, 366)
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.View = System.Windows.Forms.View.Details
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.HideSelection = False
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv.Columns.Add("Name", 300)
        Me.lv.Columns.Add("Type", 150)
        Me.lv.Columns.Add("Modified/Size", 200)
        Me.lv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!)
        Me.lv.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.lv.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.lv.Name = "lv"
        Me.lv.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lbl)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 536)
        Me.pnlBottom.Size = New System.Drawing.Size(940, 32)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(16, 7)
        Me.lbl.Size = New System.Drawing.Size(480, 18)
        Me.lbl.Text = "0 item(s)"
        Me.lbl.AutoSize = False
        Me.lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl.Name = "lbl"
        Me.lbl.TabIndex = 2
        '
        'pnlPath
        '
        Me.pnlPath.Controls.Add(Me.lblPathCaption)
        Me.pnlPath.Controls.Add(Me.txtPath)
        Me.pnlPath.Location = New System.Drawing.Point(0, 108)
        Me.pnlPath.Size = New System.Drawing.Size(940, 62)
        Me.pnlPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPath.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.pnlPath.Name = "pnlPath"
        Me.pnlPath.TabIndex = 3
        '
        'lblPathCaption
        '
        Me.lblPathCaption.Location = New System.Drawing.Point(16, 7)
        Me.lblPathCaption.Size = New System.Drawing.Size(300, 16)
        Me.lblPathCaption.Text = "CURRENT FOLDER"
        Me.lblPathCaption.AutoSize = False
        Me.lblPathCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPathCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblPathCaption.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblPathCaption.Name = "lblPathCaption"
        Me.lblPathCaption.TabIndex = 4
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(16, 28)
        Me.txtPath.Size = New System.Drawing.Size(908, 23)
        Me.txtPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtPath.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.TabIndex = 5
        '
        'pnlRail
        '
        Me.pnlRail.Controls.Add(Me.pnlRuleR)
        Me.pnlRail.Controls.Add(Me.lblRailTitle)
        Me.pnlRail.Controls.Add(Me.lblRailSub)
        Me.pnlRail.Controls.Add(Me.lblAuthor)
        Me.pnlRail.Controls.Add(Me.browse)
        Me.pnlRail.Controls.Add(Me.btnRefresh)
        Me.pnlRail.Controls.Add(Me.details)
        Me.pnlRail.Controls.Add(Me.list)
        Me.pnlRail.Location = New System.Drawing.Point(0, 24)
        Me.pnlRail.Size = New System.Drawing.Size(940, 108)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.TabIndex = 6
        '
        'pnlRuleR
        '
        Me.pnlRuleR.Location = New System.Drawing.Point(0, 104)
        Me.pnlRuleR.Size = New System.Drawing.Size(940, 4)
        Me.pnlRuleR.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlRuleR.Name = "pnlRuleR"
        Me.pnlRuleR.TabIndex = 7
        '
        'lblRailTitle
        '
        Me.lblRailTitle.Location = New System.Drawing.Point(16, 10)
        Me.lblRailTitle.Size = New System.Drawing.Size(560, 30)
        Me.lblRailTitle.Text = "ListView File Explorer"
        Me.lblRailTitle.AutoSize = False
        Me.lblRailTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailTitle.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblRailTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailTitle.Name = "lblRailTitle"
        Me.lblRailTitle.TabIndex = 8
        '
        'lblRailSub
        '
        Me.lblRailSub.Location = New System.Drawing.Point(18, 44)
        Me.lblRailSub.Size = New System.Drawing.Size(560, 18)
        Me.lblRailSub.Text = "Browse a folder in Details or List view."
        Me.lblRailSub.AutoSize = False
        Me.lblRailSub.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblRailSub.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblRailSub.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailSub.Name = "lblRailSub"
        Me.lblRailSub.TabIndex = 9
        '
        'lblAuthor
        '
        Me.lblAuthor.Location = New System.Drawing.Point(600, 16)
        Me.lblAuthor.Size = New System.Drawing.Size(324, 22)
        Me.lblAuthor.Text = "Author: Sajor, Renz  |  BSIT 3B"
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.TabIndex = 10
        '
        'browse
        '
        Me.browse.Location = New System.Drawing.Point(16, 64)
        Me.browse.Size = New System.Drawing.Size(120, 34)
        Me.browse.Text = "Browse..."
        Me.browse.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.browse.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.browse.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.browse.FlatAppearance.BorderSize = 1
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse.UseVisualStyleBackColor = False
        Me.browse.Name = "browse"
        Me.browse.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(144, 64)
        Me.btnRefresh.Size = New System.Drawing.Size(110, 34)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 12
        '
        'details
        '
        Me.details.Location = New System.Drawing.Point(262, 64)
        Me.details.Size = New System.Drawing.Size(100, 34)
        Me.details.Text = "Details"
        Me.details.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.details.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.details.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.details.FlatAppearance.BorderSize = 1
        Me.details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.details.UseVisualStyleBackColor = False
        Me.details.Name = "details"
        Me.details.TabIndex = 13
        '
        'list
        '
        Me.list.Location = New System.Drawing.Point(370, 64)
        Me.list.Size = New System.Drawing.Size(100, 34)
        Me.list.Text = "List"
        Me.list.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.list.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.list.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.list.FlatAppearance.BorderSize = 1
        Me.list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.list.UseVisualStyleBackColor = False
        Me.list.Name = "list"
        Me.list.TabIndex = 14
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuForms})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Size = New System.Drawing.Size(940, 24)
        Me.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.TabIndex = 15
        '
        'menuForms
        '
        Me.menuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCombined, Me.menuOpen, Me.menuTree, Me.menuList, Me.menuExit})
        Me.menuForms.Text = "Forms"
        Me.menuForms.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuForms.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuForms.Name = "menuForms"
        '
        'menuCombined
        '
        Me.menuCombined.Text = "Combined File Explorer"
        Me.menuCombined.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuCombined.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuCombined.Name = "menuCombined"
        '
        'menuOpen
        '
        Me.menuOpen.Text = "OpenFileDialog File Explorer"
        Me.menuOpen.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuOpen.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuOpen.Name = "menuOpen"
        '
        'menuTree
        '
        Me.menuTree.Text = "TreeView File Explorer"
        Me.menuTree.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuTree.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuTree.Name = "menuTree"
        '
        'menuList
        '
        Me.menuList.Text = "ListView File Explorer"
        Me.menuList.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuList.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuList.Name = "menuList"
        '
        'menuExit
        '
        Me.menuExit.Text = "Exit"
        Me.menuExit.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuExit.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuExit.Name = "menuExit"
        '
        'ListViewSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 568)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlPath)
        Me.Controls.Add(Me.pnlRail)
        Me.Controls.Add(Me.menuStrip1)
        Me.MainMenuStrip = Me.menuStrip1
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "ListViewSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 9 - ListView File Explorer  |  Sajor, Renz"
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlPath.ResumeLayout(False)
        Me.pnlRail.ResumeLayout(False)
        Me.pnlRuleR.ResumeLayout(False)
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents pnlPath As System.Windows.Forms.Panel
    Friend WithEvents lblPathCaption As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents pnlRail As System.Windows.Forms.Panel
    Friend WithEvents pnlRuleR As System.Windows.Forms.Panel
    Friend WithEvents lblRailTitle As System.Windows.Forms.Label
    Friend WithEvents lblRailSub As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents details As System.Windows.Forms.Button
    Friend WithEvents list As System.Windows.Forms.Button
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCombined As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
End Class
