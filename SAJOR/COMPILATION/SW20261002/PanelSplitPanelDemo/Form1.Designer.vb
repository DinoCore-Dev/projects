<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSplitLab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlRail As System.Windows.Forms.Panel
    Friend WithEvents lblRailBadge As System.Windows.Forms.Label
    Friend WithEvents lblRailTitle As System.Windows.Forms.Label
    Friend WithEvents pnlRailRule As System.Windows.Forms.Panel
    Friend WithEvents btnNavPanel As System.Windows.Forms.Button
    Friend WithEvents btnNavSplit As System.Windows.Forms.Button
    Friend WithEvents lblRailHint As System.Windows.Forms.Label
    Friend WithEvents lblRailAuthor As System.Windows.Forms.Label
    Friend WithEvents lblRailCourse As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents pnlWorkspace As System.Windows.Forms.Panel
    Friend WithEvents lblWorkspaceTitle As System.Windows.Forms.Label
    Friend WithEvents pnlGroup As System.Windows.Forms.Panel
    Friend WithEvents lblGroupTitle As System.Windows.Forms.Label
    Friend WithEvents lblNameCaption As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblCourseCaption As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblGroupHint As System.Windows.Forms.Label
    Friend WithEvents pnlNested As System.Windows.Forms.Panel
    Friend WithEvents lblNestedTitle As System.Windows.Forms.Label
    Friend WithEvents lblNestedNote As System.Windows.Forms.Label
    Friend WithEvents lblNestedBadge As System.Windows.Forms.Label
    Friend WithEvents lblNestedHint As System.Windows.Forms.Label
    Friend WithEvents pnlInspector As System.Windows.Forms.Panel
    Friend WithEvents lblInspectorTitle As System.Windows.Forms.Label
    Friend WithEvents btnToggleGroup As System.Windows.Forms.Button
    Friend WithEvents btnSwapColor As System.Windows.Forms.Button
    Friend WithEvents btnCycleBorder As System.Windows.Forms.Button
    Friend WithEvents btnBringFront As System.Windows.Forms.Button
    Friend WithEvents btnSendBack As System.Windows.Forms.Button
    Friend WithEvents btnContains As System.Windows.Forms.Button
    Friend WithEvents btnDisposeDemo As System.Windows.Forms.Button
    Friend WithEvents btnFocusPanel As System.Windows.Forms.Button
    Friend WithEvents btnRedraw As System.Windows.Forms.Button
    Friend WithEvents pnlLog As System.Windows.Forms.Panel
    Friend WithEvents lblLogTitle As System.Windows.Forms.Label
    Friend WithEvents lstLog As System.Windows.Forms.ListBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents pnlStrip_pnlInspector As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlLog As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlWorkspace As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuDemo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSplitLab = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlRail = New System.Windows.Forms.Panel()
        Me.lblRailCourse = New System.Windows.Forms.Label()
        Me.lblRailAuthor = New System.Windows.Forms.Label()
        Me.lblRailHint = New System.Windows.Forms.Label()
        Me.btnNavSplit = New System.Windows.Forms.Button()
        Me.btnNavPanel = New System.Windows.Forms.Button()
        Me.pnlRailRule = New System.Windows.Forms.Panel()
        Me.lblRailTitle = New System.Windows.Forms.Label()
        Me.lblRailBadge = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlLog = New System.Windows.Forms.Panel()
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.lblLogTitle = New System.Windows.Forms.Label()
        Me.pnlInspector = New System.Windows.Forms.Panel()
        Me.btnRedraw = New System.Windows.Forms.Button()
        Me.btnFocusPanel = New System.Windows.Forms.Button()
        Me.btnDisposeDemo = New System.Windows.Forms.Button()
        Me.btnContains = New System.Windows.Forms.Button()
        Me.btnSendBack = New System.Windows.Forms.Button()
        Me.btnBringFront = New System.Windows.Forms.Button()
        Me.btnCycleBorder = New System.Windows.Forms.Button()
        Me.btnSwapColor = New System.Windows.Forms.Button()
        Me.btnToggleGroup = New System.Windows.Forms.Button()
        Me.lblInspectorTitle = New System.Windows.Forms.Label()
        Me.pnlWorkspace = New System.Windows.Forms.Panel()
        Me.pnlNested = New System.Windows.Forms.Panel()
        Me.lblNestedHint = New System.Windows.Forms.Label()
        Me.lblNestedBadge = New System.Windows.Forms.Label()
        Me.lblNestedNote = New System.Windows.Forms.Label()
        Me.lblNestedTitle = New System.Windows.Forms.Label()
        Me.pnlGroup = New System.Windows.Forms.Panel()
        Me.lblGroupHint = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblCourseCaption = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblNameCaption = New System.Windows.Forms.Label()
        Me.lblGroupTitle = New System.Windows.Forms.Label()
        Me.lblWorkspaceTitle = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlStrip_pnlInspector = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlLog = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlWorkspace = New System.Windows.Forms.Panel()
        Me.menuMain.SuspendLayout()
        Me.pnlRail.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        Me.pnlInspector.SuspendLayout()
        Me.pnlWorkspace.SuspendLayout()
        Me.pnlNested.SuspendLayout()
        Me.pnlGroup.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlStrip_pnlInspector.SuspendLayout()
        Me.pnlStrip_pnlLog.SuspendLayout()
        Me.pnlStrip_pnlWorkspace.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDemo})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.menuMain.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.menuMain.Size = New System.Drawing.Size(940, 24)
        Me.menuMain.TabIndex = 0
        '
        'mnuDemo
        '
        Me.mnuDemo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSplitLab, Me.mnuExit})
        Me.mnuDemo.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.mnuDemo.Name = "mnuDemo"
        Me.mnuDemo.Size = New System.Drawing.Size(57, 20)
        Me.mnuDemo.Text = "&Demos"
        '
        'mnuSplitLab
        '
        Me.mnuSplitLab.Name = "mnuSplitLab"
        Me.mnuSplitLab.Size = New System.Drawing.Size(170, 22)
        Me.mnuSplitLab.Text = "Split Panel Lab"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(170, 22)
        Me.mnuExit.Text = "Exit"
        '
        'pnlRail
        '
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlRail.Controls.Add(Me.lblRailCourse)
        Me.pnlRail.Controls.Add(Me.lblRailAuthor)
        Me.pnlRail.Controls.Add(Me.btnNavSplit)
        Me.pnlRail.Controls.Add(Me.btnNavPanel)
        Me.pnlRail.Controls.Add(Me.pnlRailRule)
        Me.pnlRail.Controls.Add(Me.lblRailTitle)
        Me.pnlRail.Controls.Add(Me.lblRailBadge)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRail.Location = New System.Drawing.Point(0, 24)
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.Size = New System.Drawing.Size(1000, 58)
        Me.pnlRail.TabIndex = 1
        '
        'lblRailBadge
        '
        Me.lblRailBadge.AutoSize = False
        Me.lblRailBadge.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRailBadge.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblRailBadge.Location = New System.Drawing.Point(24, 8)
        Me.lblRailBadge.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailBadge.Name = "lblRailBadge"
        Me.lblRailBadge.Size = New System.Drawing.Size(220, 14)
        Me.lblRailBadge.TabIndex = 0
        Me.lblRailBadge.Text = "ACTIVITY 10"
        '
        'lblRailTitle
        '
        Me.lblRailTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailTitle.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblRailTitle.Location = New System.Drawing.Point(24, 22)
        Me.lblRailTitle.AutoSize = False
        Me.lblRailTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailTitle.Name = "lblRailTitle"
        Me.lblRailTitle.Size = New System.Drawing.Size(360, 28)
        Me.lblRailTitle.TabIndex = 1
        Me.lblRailTitle.Text = "Panel Playground"
        '
        'pnlRailRule
        '
        Me.pnlRailRule.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlRailRule.Location = New System.Drawing.Point(0, 54)
        Me.pnlRailRule.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRailRule.Name = "pnlRailRule"
        Me.pnlRailRule.Size = New System.Drawing.Size(1000, 4)
        Me.pnlRailRule.TabIndex = 2
        '
        'btnNavPanel
        '
        Me.btnNavPanel.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnNavPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnNavPanel.FlatAppearance.BorderSize = 1
        Me.btnNavPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPanel.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnNavPanel.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnNavPanel.Location = New System.Drawing.Point(690, 10)
        Me.btnNavPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavPanel.Name = "btnNavPanel"
        Me.btnNavPanel.Size = New System.Drawing.Size(130, 34)
        Me.btnNavPanel.TabIndex = 3
        Me.btnNavPanel.Text = "Panel Demo"
        Me.btnNavPanel.UseVisualStyleBackColor = False
        '
        'btnNavSplit
        '
        Me.btnNavSplit.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.btnNavSplit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.btnNavSplit.FlatAppearance.BorderSize = 1
        Me.btnNavSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavSplit.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.75!)
        Me.btnNavSplit.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.btnNavSplit.Location = New System.Drawing.Point(830, 10)
        Me.btnNavSplit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavSplit.Name = "btnNavSplit"
        Me.btnNavSplit.Size = New System.Drawing.Size(146, 34)
        Me.btnNavSplit.TabIndex = 4
        Me.btnNavSplit.Text = "Split Panel Lab"
        Me.btnNavSplit.UseVisualStyleBackColor = False
        '
        'lblRailHint
        '
        Me.lblRailHint.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.5!)
        Me.lblRailHint.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblRailHint.Location = New System.Drawing.Point(14, 252)
        Me.lblRailHint.AutoSize = False
        Me.lblRailHint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailHint.Name = "lblRailHint"
        Me.lblRailHint.Size = New System.Drawing.Size(440, 32)
        Me.lblRailHint.TabIndex = 5
        Me.lblRailHint.Text = "Every click in the panel API list is written to the event log so the behaviour of" & _
            " each Panel member can be compared easily."
        '
        'lblRailAuthor
        '
        Me.lblRailAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRailAuthor.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.5!, System.Drawing.FontStyle.Bold)
        Me.lblRailAuthor.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblRailAuthor.Location = New System.Drawing.Point(410, 10)
        Me.lblRailAuthor.AutoSize = False
        Me.lblRailAuthor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailAuthor.Name = "lblRailAuthor"
        Me.lblRailAuthor.Size = New System.Drawing.Size(250, 22)
        Me.lblRailAuthor.TabIndex = 6
        Me.lblRailAuthor.Text = "Sajor, Renz"
        '
        'lblRailCourse
        '
        Me.lblRailCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRailCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblRailCourse.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblRailCourse.Location = New System.Drawing.Point(410, 32)
        Me.lblRailCourse.AutoSize = False
        Me.lblRailCourse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailCourse.Name = "lblRailCourse"
        Me.lblRailCourse.Size = New System.Drawing.Size(250, 16)
        Me.lblRailCourse.TabIndex = 7
        Me.lblRailCourse.Text = "BSIT 3B  |  SW20261002"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.pnlMain.Controls.Add(Me.pnlLog)
        Me.pnlMain.Controls.Add(Me.pnlInspector)
        Me.pnlMain.Controls.Add(Me.pnlWorkspace)
        Me.pnlMain.Controls.Add(Me.lblSub)
        Me.pnlMain.Controls.Add(Me.lblHeading)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(720, 624)
        Me.pnlMain.TabIndex = 2
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = False
        Me.lblHeading.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblHeading.Location = New System.Drawing.Point(24, 10)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(440, 30)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Panel properties in action"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = False
        Me.lblSub.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblSub.Location = New System.Drawing.Point(24, 40)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(440, 18)
        Me.lblSub.TabIndex = 1
        Me.lblSub.Text = "Activity 10 - SW20261002  |  Panel container, visibility and docking demo"
        '
        'pnlWorkspace
        '
        Me.pnlWorkspace.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlWorkspace.Controls.Add(Me.pnlNested)
        Me.pnlWorkspace.Controls.Add(Me.pnlGroup)
        Me.pnlWorkspace.Controls.Add(Me.lblWorkspaceTitle)
        Me.pnlWorkspace.Controls.Add(Me.pnlStrip_pnlWorkspace)
        Me.pnlWorkspace.Location = New System.Drawing.Point(514, 70)
        Me.pnlWorkspace.Name = "pnlWorkspace"
        Me.pnlWorkspace.Size = New System.Drawing.Size(462, 498)
        Me.pnlWorkspace.TabIndex = 2
        '
        'lblWorkspaceTitle
        '
        Me.lblWorkspaceTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblWorkspaceTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblWorkspaceTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblWorkspaceTitle.AutoSize = False
        Me.lblWorkspaceTitle.Name = "lblWorkspaceTitle"
        Me.lblWorkspaceTitle.Size = New System.Drawing.Size(420, 16)
        Me.lblWorkspaceTitle.TabIndex = 0
        Me.lblWorkspaceTitle.Text = "pnlWorkspace  (parent panel)"
        '
        'pnlGroup
        '
        Me.pnlGroup.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlGroup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlGroup.Controls.Add(Me.lblGroupHint)
        Me.pnlGroup.Controls.Add(Me.btnSave)
        Me.pnlGroup.Controls.Add(Me.txtCourse)
        Me.pnlGroup.Controls.Add(Me.lblCourseCaption)
        Me.pnlGroup.Controls.Add(Me.txtName)
        Me.pnlGroup.Controls.Add(Me.lblNameCaption)
        Me.pnlGroup.Controls.Add(Me.lblGroupTitle)
        Me.pnlGroup.Location = New System.Drawing.Point(14, 34)
        Me.pnlGroup.Name = "pnlGroup"
        Me.pnlGroup.Size = New System.Drawing.Size(434, 216)
        Me.pnlGroup.TabIndex = 1
        '
        'lblGroupTitle
        '
        Me.lblGroupTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblGroupTitle.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblGroupTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblGroupTitle.AutoSize = False
        Me.lblGroupTitle.Name = "lblGroupTitle"
        Me.lblGroupTitle.Size = New System.Drawing.Size(400, 16)
        Me.lblGroupTitle.TabIndex = 0
        Me.lblGroupTitle.Text = "pnlGroup  (controls are grouped)"
        '
        'lblNameCaption
        '
        Me.lblNameCaption.AutoSize = False
        Me.lblNameCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblNameCaption.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblNameCaption.Location = New System.Drawing.Point(12, 36)
        Me.lblNameCaption.Name = "lblNameCaption"
        Me.lblNameCaption.Size = New System.Drawing.Size(200, 16)
        Me.lblNameCaption.TabIndex = 1
        Me.lblNameCaption.Text = "Full name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtName.Location = New System.Drawing.Point(12, 54)
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(410, 26)
        Me.txtName.TabIndex = 2
        '
        'lblCourseCaption
        '
        Me.lblCourseCaption.AutoSize = False
        Me.lblCourseCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblCourseCaption.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblCourseCaption.Location = New System.Drawing.Point(12, 90)
        Me.lblCourseCaption.Name = "lblCourseCaption"
        Me.lblCourseCaption.Size = New System.Drawing.Size(200, 16)
        Me.lblCourseCaption.TabIndex = 3
        Me.lblCourseCaption.Text = "Course"
        '
        'txtCourse
        '
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtCourse.Location = New System.Drawing.Point(12, 108)
        Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(410, 26)
        Me.txtCourse.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnSave.FlatAppearance.BorderSize = 1
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnSave.Location = New System.Drawing.Point(12, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(410, 34)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save grouped details"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblGroupHint
        '
        Me.lblGroupHint.Font = New System.Drawing.Font("Franklin Gothic Medium", 6.75!)
        Me.lblGroupHint.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblGroupHint.Location = New System.Drawing.Point(12, 190)
        Me.lblGroupHint.AutoSize = False
        Me.lblGroupHint.Name = "lblGroupHint"
        Me.lblGroupHint.Size = New System.Drawing.Size(410, 18)
        Me.lblGroupHint.TabIndex = 6
        Me.lblGroupHint.Text = "Hiding this panel also hides every control inside it because they are children of" & _
            " the same container."
        '
        'pnlNested
        '
        Me.pnlNested.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlNested.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlNested.Controls.Add(Me.lblNestedHint)
        Me.pnlNested.Controls.Add(Me.lblNestedBadge)
        Me.pnlNested.Controls.Add(Me.lblNestedNote)
        Me.pnlNested.Controls.Add(Me.lblNestedTitle)
        Me.pnlNested.Location = New System.Drawing.Point(14, 262)
        Me.pnlNested.Name = "pnlNested"
        Me.pnlNested.Size = New System.Drawing.Size(434, 220)
        Me.pnlNested.TabIndex = 2
        '
        'lblNestedTitle
        '
        Me.lblNestedTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNestedTitle.ForeColor = System.Drawing.Color.FromArgb(14, 116, 144)
        Me.lblNestedTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblNestedTitle.AutoSize = False
        Me.lblNestedTitle.Name = "lblNestedTitle"
        Me.lblNestedTitle.Size = New System.Drawing.Size(400, 16)
        Me.lblNestedTitle.TabIndex = 0
        Me.lblNestedTitle.Text = "pnlNested  (second child panel)"
        '
        'lblNestedNote
        '
        Me.lblNestedNote.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblNestedNote.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblNestedNote.Location = New System.Drawing.Point(12, 32)
        Me.lblNestedNote.AutoSize = False
        Me.lblNestedNote.Name = "lblNestedNote"
        Me.lblNestedNote.Size = New System.Drawing.Size(410, 66)
        Me.lblNestedNote.TabIndex = 1
        Me.lblNestedNote.Text = "The buttons on the right change this panel only : its back color, its border" & _
            " style, its z-order and its focus. The parent panel is not affected."
        '
        'lblNestedBadge
        '
        Me.lblNestedBadge.BackColor = System.Drawing.Color.FromArgb(253, 230, 138)
        Me.lblNestedBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNestedBadge.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNestedBadge.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblNestedBadge.Location = New System.Drawing.Point(12, 106)
        Me.lblNestedBadge.AutoSize = False
        Me.lblNestedBadge.Name = "lblNestedBadge"
        Me.lblNestedBadge.Size = New System.Drawing.Size(410, 34)
        Me.lblNestedBadge.TabIndex = 2
        Me.lblNestedBadge.Text = "Color swatch of pnlNested"
        Me.lblNestedBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNestedHint
        '
        Me.lblNestedHint.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.5!)
        Me.lblNestedHint.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblNestedHint.Location = New System.Drawing.Point(12, 150)
        Me.lblNestedHint.AutoSize = False
        Me.lblNestedHint.Name = "lblNestedHint"
        Me.lblNestedHint.Size = New System.Drawing.Size(410, 44)
        Me.lblNestedHint.TabIndex = 3
        Me.lblNestedHint.Text = "TabStop is enabled so Focus() and Contains() can be tested."
        '
        'pnlInspector
        '
        Me.pnlInspector.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlInspector.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlInspector.Controls.Add(Me.btnRedraw)
        Me.pnlInspector.Controls.Add(Me.btnFocusPanel)
        Me.pnlInspector.Controls.Add(Me.btnDisposeDemo)
        Me.pnlInspector.Controls.Add(Me.btnContains)
        Me.pnlInspector.Controls.Add(Me.btnSendBack)
        Me.pnlInspector.Controls.Add(Me.btnBringFront)
        Me.pnlInspector.Controls.Add(Me.btnCycleBorder)
        Me.pnlInspector.Controls.Add(Me.btnSwapColor)
        Me.pnlInspector.Controls.Add(Me.btnToggleGroup)
        Me.pnlInspector.Controls.Add(Me.lblInspectorTitle)
        Me.pnlInspector.Controls.Add(Me.lblRailHint)
        Me.pnlInspector.Controls.Add(Me.pnlStrip_pnlInspector)
        Me.pnlInspector.Location = New System.Drawing.Point(24, 70)
        Me.pnlInspector.Name = "pnlInspector"
        Me.pnlInspector.Size = New System.Drawing.Size(470, 292)
        Me.pnlInspector.TabIndex = 3
        '
        'lblInspectorTitle
        '
        Me.lblInspectorTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInspectorTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblInspectorTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblInspectorTitle.AutoSize = False
        Me.lblInspectorTitle.Name = "lblInspectorTitle"
        Me.lblInspectorTitle.Size = New System.Drawing.Size(440, 16)
        Me.lblInspectorTitle.TabIndex = 0
        Me.lblInspectorTitle.Text = "PANEL API  -  click a method to test it"
        '
        'btnToggleGroup
        '
        Me.btnToggleGroup.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnToggleGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnToggleGroup.FlatAppearance.BorderSize = 1
        Me.btnToggleGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleGroup.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToggleGroup.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnToggleGroup.Location = New System.Drawing.Point(14, 36)
        Me.btnToggleGroup.Name = "btnToggleGroup"
        Me.btnToggleGroup.Size = New System.Drawing.Size(220, 34)
        Me.btnToggleGroup.TabIndex = 1
        Me.btnToggleGroup.Text = "Show / hide pnlGroup"
        Me.btnToggleGroup.UseVisualStyleBackColor = False
        '
        'btnSwapColor
        '
        Me.btnSwapColor.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnSwapColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnSwapColor.FlatAppearance.BorderSize = 1
        Me.btnSwapColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwapColor.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSwapColor.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnSwapColor.Location = New System.Drawing.Point(242, 36)
        Me.btnSwapColor.Name = "btnSwapColor"
        Me.btnSwapColor.Size = New System.Drawing.Size(220, 34)
        Me.btnSwapColor.TabIndex = 2
        Me.btnSwapColor.Text = "Change pnlNested back color"
        Me.btnSwapColor.UseVisualStyleBackColor = False
        '
        'btnCycleBorder
        '
        Me.btnCycleBorder.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnCycleBorder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnCycleBorder.FlatAppearance.BorderSize = 1
        Me.btnCycleBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCycleBorder.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCycleBorder.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnCycleBorder.Location = New System.Drawing.Point(14, 78)
        Me.btnCycleBorder.Name = "btnCycleBorder"
        Me.btnCycleBorder.Size = New System.Drawing.Size(220, 34)
        Me.btnCycleBorder.TabIndex = 3
        Me.btnCycleBorder.Text = "Cycle pnlWorkspace border"
        Me.btnCycleBorder.UseVisualStyleBackColor = False
        '
        'btnBringFront
        '
        Me.btnBringFront.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnBringFront.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnBringFront.FlatAppearance.BorderSize = 1
        Me.btnBringFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBringFront.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBringFront.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnBringFront.Location = New System.Drawing.Point(242, 78)
        Me.btnBringFront.Name = "btnBringFront"
        Me.btnBringFront.Size = New System.Drawing.Size(220, 34)
        Me.btnBringFront.TabIndex = 4
        Me.btnBringFront.Text = "BringToFront pnlNested"
        Me.btnBringFront.UseVisualStyleBackColor = False
        '
        'btnSendBack
        '
        Me.btnSendBack.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnSendBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnSendBack.FlatAppearance.BorderSize = 1
        Me.btnSendBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendBack.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSendBack.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnSendBack.Location = New System.Drawing.Point(14, 120)
        Me.btnSendBack.Name = "btnSendBack"
        Me.btnSendBack.Size = New System.Drawing.Size(220, 34)
        Me.btnSendBack.TabIndex = 5
        Me.btnSendBack.Text = "SendToBack pnlNested"
        Me.btnSendBack.UseVisualStyleBackColor = False
        '
        'btnContains
        '
        Me.btnContains.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnContains.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnContains.FlatAppearance.BorderSize = 1
        Me.btnContains.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContains.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnContains.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnContains.Location = New System.Drawing.Point(242, 120)
        Me.btnContains.Name = "btnContains"
        Me.btnContains.Size = New System.Drawing.Size(220, 34)
        Me.btnContains.TabIndex = 6
        Me.btnContains.Text = "Contains(pnlGroup) ?"
        Me.btnContains.UseVisualStyleBackColor = False
        '
        'btnDisposeDemo
        '
        Me.btnDisposeDemo.BackColor = System.Drawing.Color.FromArgb(88, 20, 34)
        Me.btnDisposeDemo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 60, 90)
        Me.btnDisposeDemo.FlatAppearance.BorderSize = 1
        Me.btnDisposeDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisposeDemo.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDisposeDemo.ForeColor = System.Drawing.Color.FromArgb(255, 214, 220)
        Me.btnDisposeDemo.Location = New System.Drawing.Point(14, 204)
        Me.btnDisposeDemo.Name = "btnDisposeDemo"
        Me.btnDisposeDemo.Size = New System.Drawing.Size(220, 34)
        Me.btnDisposeDemo.TabIndex = 7
        Me.btnDisposeDemo.Text = "Dispose a temporary panel"
        Me.btnDisposeDemo.UseVisualStyleBackColor = False
        '
        'btnFocusPanel
        '
        Me.btnFocusPanel.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnFocusPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnFocusPanel.FlatAppearance.BorderSize = 1
        Me.btnFocusPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFocusPanel.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFocusPanel.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnFocusPanel.Location = New System.Drawing.Point(14, 162)
        Me.btnFocusPanel.Name = "btnFocusPanel"
        Me.btnFocusPanel.Size = New System.Drawing.Size(220, 34)
        Me.btnFocusPanel.TabIndex = 8
        Me.btnFocusPanel.Text = "Focus pnlNested"
        Me.btnFocusPanel.UseVisualStyleBackColor = False
        '
        'btnRedraw
        '
        Me.btnRedraw.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnRedraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnRedraw.FlatAppearance.BorderSize = 1
        Me.btnRedraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRedraw.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRedraw.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnRedraw.Location = New System.Drawing.Point(242, 162)
        Me.btnRedraw.Name = "btnRedraw"
        Me.btnRedraw.Size = New System.Drawing.Size(220, 34)
        Me.btnRedraw.TabIndex = 9
        Me.btnRedraw.Text = "Refresh + Invalidate"
        Me.btnRedraw.UseVisualStyleBackColor = False
        '
        'pnlLog
        '
        Me.pnlLog.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlLog.Controls.Add(Me.lstLog)
        Me.pnlLog.Controls.Add(Me.lblLogTitle)
        Me.pnlLog.Controls.Add(Me.pnlStrip_pnlLog)
        Me.pnlLog.Location = New System.Drawing.Point(24, 378)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Size = New System.Drawing.Size(470, 190)
        Me.pnlLog.TabIndex = 4
        '
        'lblLogTitle
        '
        Me.lblLogTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblLogTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblLogTitle.AutoSize = False
        Me.lblLogTitle.Name = "lblLogTitle"
        Me.lblLogTitle.Size = New System.Drawing.Size(300, 16)
        Me.lblLogTitle.TabIndex = 0
        Me.lblLogTitle.Text = "EVENT LOG"
        '
        'lstLog
        '
        Me.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstLog.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lstLog.FormattingEnabled = True
        Me.lstLog.HorizontalScrollbar = True
        Me.lstLog.IntegralHeight = False
        Me.lstLog.ItemHeight = 13
        Me.lstLog.Location = New System.Drawing.Point(14, 34)
        Me.lstLog.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.lstLog.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(442, 144)
        Me.lstLog.TabIndex = 1
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlStatus.Controls.Add(Me.lblCounter)
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 648)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1000, 30)
        Me.pnlStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblStatus.Location = New System.Drawing.Point(16, 7)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(560, 16)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Panel demo is ready."
        '
        'lblCounter
        '
        Me.lblCounter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCounter.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCounter.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblCounter.Location = New System.Drawing.Point(676, 7)
        Me.lblCounter.AutoSize = False
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(300, 16)
        Me.lblCounter.TabIndex = 1
        Me.lblCounter.Text = "0 action(s) performed"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlStrip_pnlInspector
        '
        Me.pnlStrip_pnlInspector.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlInspector.Size = New System.Drawing.Size(470, 3)
        Me.pnlStrip_pnlInspector.Name = "pnlStrip_pnlInspector"
        Me.pnlStrip_pnlInspector.TabIndex = 0
        Me.pnlStrip_pnlInspector.BackColor = System.Drawing.Color.FromArgb(14, 116, 144)
        '
        'pnlStrip_pnlLog
        '
        Me.pnlStrip_pnlLog.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlLog.Size = New System.Drawing.Size(470, 3)
        Me.pnlStrip_pnlLog.Name = "pnlStrip_pnlLog"
        Me.pnlStrip_pnlLog.TabIndex = 0
        Me.pnlStrip_pnlLog.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'pnlStrip_pnlWorkspace
        '
        Me.pnlStrip_pnlWorkspace.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlWorkspace.Size = New System.Drawing.Size(462, 3)
        Me.pnlStrip_pnlWorkspace.Name = "pnlStrip_pnlWorkspace"
        Me.pnlStrip_pnlWorkspace.TabIndex = 0
        Me.pnlStrip_pnlWorkspace.BackColor = System.Drawing.Color.FromArgb(99, 102, 241)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.ClientSize = New System.Drawing.Size(1000, 680)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlRail)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.MinimumSize = New System.Drawing.Size(900, 640)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 10 - Panel Playground  |  Sajor, Renz"
        Me.menuMain.ResumeLayout(False)
        Me.pnlRail.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlLog.ResumeLayout(False)
        Me.pnlInspector.ResumeLayout(False)
        Me.pnlWorkspace.ResumeLayout(False)
        Me.pnlNested.ResumeLayout(False)
        Me.pnlGroup.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStrip_pnlInspector.ResumeLayout(False)
        Me.pnlStrip_pnlLog.ResumeLayout(False)
        Me.pnlStrip_pnlWorkspace.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
