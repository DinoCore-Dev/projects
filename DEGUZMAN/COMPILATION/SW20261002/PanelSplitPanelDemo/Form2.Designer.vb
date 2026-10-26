<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
    Friend WithEvents mnuLab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPanelDemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents btnCollapseLeft As System.Windows.Forms.Button
    Friend WithEvents btnCollapseTop As System.Windows.Forms.Button
    Friend WithEvents btnSwapOrientation As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSplitInfo As System.Windows.Forms.Label
    Friend WithEvents splOuter As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblLeftTitle As System.Windows.Forms.Label
    Friend WithEvents lstCategories As System.Windows.Forms.ListBox
    Friend WithEvents splInner As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlTopPane As System.Windows.Forms.Panel
    Friend WithEvents lblRecordsTitle As System.Windows.Forms.Label
    Friend WithEvents lvRecords As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCategory As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlBottomPane As System.Windows.Forms.Panel
    Friend WithEvents lblDetailTitle As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuLab = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPanelDemo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTools = New System.Windows.Forms.Panel()
        Me.lblSplitInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnSwapOrientation = New System.Windows.Forms.Button()
        Me.btnCollapseTop = New System.Windows.Forms.Button()
        Me.btnCollapseLeft = New System.Windows.Forms.Button()
        Me.splOuter = New System.Windows.Forms.SplitContainer()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lstCategories = New System.Windows.Forms.ListBox()
        Me.lblLeftTitle = New System.Windows.Forms.Label()
        Me.splInner = New System.Windows.Forms.SplitContainer()
        Me.pnlTopPane = New System.Windows.Forms.Panel()
        Me.lvRecords = New System.Windows.Forms.ListView()
        Me.colName = New System.Windows.Forms.ColumnHeader()
        Me.colCategory = New System.Windows.Forms.ColumnHeader()
        Me.colStatus = New System.Windows.Forms.ColumnHeader()
        Me.lblRecordsTitle = New System.Windows.Forms.Label()
        Me.pnlBottomPane = New System.Windows.Forms.Panel()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.lblDetailTitle = New System.Windows.Forms.Label()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.menuMain.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        CType(Me.splOuter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splOuter.Panel1.SuspendLayout()
        Me.splOuter.Panel2.SuspendLayout()
        Me.splOuter.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.splInner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splInner.Panel1.SuspendLayout()
        Me.splInner.Panel2.SuspendLayout()
        Me.splInner.SuspendLayout()
        Me.pnlTopPane.SuspendLayout()
        Me.pnlBottomPane.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLab})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(1000, 24)
        Me.menuMain.TabIndex = 0
        '
        'mnuLab
        '
        Me.mnuLab.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPanelDemo, Me.mnuExit})
        Me.mnuLab.Name = "mnuLab"
        Me.mnuLab.Size = New System.Drawing.Size(39, 20)
        Me.mnuLab.Text = "&Lab"
        '
        'mnuPanelDemo
        '
        Me.mnuPanelDemo.Name = "mnuPanelDemo"
        Me.mnuPanelDemo.Size = New System.Drawing.Size(170, 22)
        Me.mnuPanelDemo.Text = "Panel Playground"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(170, 22)
        Me.mnuExit.Text = "Exit"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(75, 27, 39)
        Me.pnlTop.Controls.Add(Me.lblAuthor)
        Me.pnlTop.Controls.Add(Me.lblSub)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 24)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1000, 84)
        Me.pnlTop.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(24, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(224, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Split Container Lab"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(254, 199, 213)
        Me.lblSub.Location = New System.Drawing.Point(27, 52)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(430, 15)
        Me.lblSub.TabIndex = 1
        Me.lblSub.Text = "Activity 10 - SW20261002  |  nested SplitContainer, orientation, collapsing and locking"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.White
        Me.lblAuthor.Location = New System.Drawing.Point(700, 30)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(276, 20)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Deguzman, Liza Gaile  |  BSIT 3B"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.pnlTools.Controls.Add(Me.lblSplitInfo)
        Me.pnlTools.Controls.Add(Me.btnExit)
        Me.pnlTools.Controls.Add(Me.btnReset)
        Me.pnlTools.Controls.Add(Me.btnLock)
        Me.pnlTools.Controls.Add(Me.btnSwapOrientation)
        Me.pnlTools.Controls.Add(Me.btnCollapseTop)
        Me.pnlTools.Controls.Add(Me.btnCollapseLeft)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 108)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(1000, 58)
        Me.pnlTools.TabIndex = 2
        '
        'btnCollapseLeft
        '
        Me.btnCollapseLeft.BackColor = System.Drawing.Color.White
        Me.btnCollapseLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(184, 148, 157)
        Me.btnCollapseLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollapseLeft.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCollapseLeft.ForeColor = System.Drawing.Color.FromArgb(59, 30, 37)
        Me.btnCollapseLeft.Location = New System.Drawing.Point(14, 12)
        Me.btnCollapseLeft.Name = "btnCollapseLeft"
        Me.btnCollapseLeft.Size = New System.Drawing.Size(132, 34)
        Me.btnCollapseLeft.TabIndex = 0
        Me.btnCollapseLeft.Text = "Hide / show list"
        Me.btnCollapseLeft.UseVisualStyleBackColor = False
        '
        'btnCollapseTop
        '
        Me.btnCollapseTop.BackColor = System.Drawing.Color.White
        Me.btnCollapseTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(184, 148, 157)
        Me.btnCollapseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollapseTop.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCollapseTop.ForeColor = System.Drawing.Color.FromArgb(59, 30, 37)
        Me.btnCollapseTop.Location = New System.Drawing.Point(154, 12)
        Me.btnCollapseTop.Name = "btnCollapseTop"
        Me.btnCollapseTop.Size = New System.Drawing.Size(132, 34)
        Me.btnCollapseTop.TabIndex = 1
        Me.btnCollapseTop.Text = "Hide / show records"
        Me.btnCollapseTop.UseVisualStyleBackColor = False
        '
        'btnSwapOrientation
        '
        Me.btnSwapOrientation.BackColor = System.Drawing.Color.White
        Me.btnSwapOrientation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(184, 148, 157)
        Me.btnSwapOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwapOrientation.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnSwapOrientation.ForeColor = System.Drawing.Color.FromArgb(59, 30, 37)
        Me.btnSwapOrientation.Location = New System.Drawing.Point(294, 12)
        Me.btnSwapOrientation.Name = "btnSwapOrientation"
        Me.btnSwapOrientation.Size = New System.Drawing.Size(132, 34)
        Me.btnSwapOrientation.TabIndex = 2
        Me.btnSwapOrientation.Text = "Swap orientation"
        Me.btnSwapOrientation.UseVisualStyleBackColor = False
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.White
        Me.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(184, 148, 157)
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLock.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnLock.ForeColor = System.Drawing.Color.FromArgb(59, 30, 37)
        Me.btnLock.Location = New System.Drawing.Point(434, 12)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(118, 34)
        Me.btnLock.TabIndex = 3
        Me.btnLock.Text = "Lock splitters"
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(229, 70, 110)
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(560, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 34)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset layout"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(686, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblSplitInfo
        '
        Me.lblSplitInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSplitInfo.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.lblSplitInfo.ForeColor = System.Drawing.Color.FromArgb(105, 71, 79)
        Me.lblSplitInfo.Location = New System.Drawing.Point(786, 12)
        Me.lblSplitInfo.Name = "lblSplitInfo"
        Me.lblSplitInfo.Size = New System.Drawing.Size(200, 34)
        Me.lblSplitInfo.TabIndex = 6
        Me.lblSplitInfo.Text = "outer : 220 px" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "inner : 260 px"
        '
        'splOuter
        '
        Me.splOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splOuter.Location = New System.Drawing.Point(0, 166)
        Me.splOuter.Name = "splOuter"
        Me.splOuter.Orientation = System.Windows.Forms.Orientation.Vertical
        '
        'splOuter.Panel1
        '
        Me.splOuter.Panel1.Controls.Add(Me.pnlLeft)
        Me.splOuter.Panel1MinSize = 160
        '
        'splOuter.Panel2
        '
        Me.splOuter.Panel2.Controls.Add(Me.splInner)
        Me.splOuter.Panel2MinSize = 420
        Me.splOuter.Size = New System.Drawing.Size(1000, 434)
        Me.splOuter.SplitterDistance = 220
        Me.splOuter.SplitterWidth = 8
        Me.splOuter.TabIndex = 3
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Controls.Add(Me.lstCategories)
        Me.pnlLeft.Controls.Add(Me.lblLeftTitle)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlLeft.Size = New System.Drawing.Size(220, 434)
        Me.pnlLeft.TabIndex = 0
        '
        'lblLeftTitle
        '
        Me.lblLeftTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLeftTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLeftTitle.ForeColor = System.Drawing.Color.FromArgb(139, 100, 110)
        Me.lblLeftTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblLeftTitle.Name = "lblLeftTitle"
        Me.lblLeftTitle.Size = New System.Drawing.Size(196, 26)
        Me.lblLeftTitle.TabIndex = 0
        Me.lblLeftTitle.Text = "CATEGORIES  (Panel1 of splOuter)"
        '
        'lstCategories
        '
        Me.lstCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCategories.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lstCategories.FormattingEnabled = True
        Me.lstCategories.IntegralHeight = False
        Me.lstCategories.ItemHeight = 17
        Me.lstCategories.Location = New System.Drawing.Point(12, 38)
        Me.lstCategories.Name = "lstCategories"
        Me.lstCategories.Size = New System.Drawing.Size(196, 384)
        Me.lstCategories.TabIndex = 1
        '
        'splInner
        '
        Me.splInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splInner.Location = New System.Drawing.Point(0, 0)
        Me.splInner.Name = "splInner"
        Me.splInner.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splInner.Panel1
        '
        Me.splInner.Panel1.Controls.Add(Me.pnlTopPane)
        Me.splInner.Panel1MinSize = 140
        '
        'splInner.Panel2
        '
        Me.splInner.Panel2.Controls.Add(Me.pnlBottomPane)
        Me.splInner.Panel2MinSize = 110
        Me.splInner.Size = New System.Drawing.Size(772, 434)
        Me.splInner.SplitterDistance = 260
        Me.splInner.SplitterWidth = 8
        Me.splInner.TabIndex = 0
        '
        'pnlTopPane
        '
        Me.pnlTopPane.BackColor = System.Drawing.Color.White
        Me.pnlTopPane.Controls.Add(Me.lvRecords)
        Me.pnlTopPane.Controls.Add(Me.lblRecordsTitle)
        Me.pnlTopPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTopPane.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopPane.Name = "pnlTopPane"
        Me.pnlTopPane.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlTopPane.Size = New System.Drawing.Size(772, 260)
        Me.pnlTopPane.TabIndex = 0
        '
        'lblRecordsTitle
        '
        Me.lblRecordsTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRecordsTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(139, 100, 110)
        Me.lblRecordsTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblRecordsTitle.Name = "lblRecordsTitle"
        Me.lblRecordsTitle.Size = New System.Drawing.Size(748, 26)
        Me.lblRecordsTitle.TabIndex = 0
        Me.lblRecordsTitle.Text = "RECORDS  (Panel1 of splInner)"
        '
        'lvRecords
        '
        Me.lvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colCategory, Me.colStatus})
        Me.lvRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRecords.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lvRecords.FullRowSelect = True
        Me.lvRecords.GridLines = False
        Me.lvRecords.HideSelection = False
        Me.lvRecords.Location = New System.Drawing.Point(12, 38)
        Me.lvRecords.MultiSelect = False
        Me.lvRecords.Name = "lvRecords"
        Me.lvRecords.Size = New System.Drawing.Size(748, 210)
        Me.lvRecords.TabIndex = 1
        Me.lvRecords.UseCompatibleStateImageBehavior = False
        Me.lvRecords.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Record"
        Me.colName.Width = 320
        '
        'colCategory
        '
        Me.colCategory.Text = "Category"
        Me.colCategory.Width = 180
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        Me.colStatus.Width = 160
        '
        'pnlBottomPane
        '
        Me.pnlBottomPane.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.pnlBottomPane.Controls.Add(Me.txtDetails)
        Me.pnlBottomPane.Controls.Add(Me.lblDetailTitle)
        Me.pnlBottomPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBottomPane.Location = New System.Drawing.Point(0, 0)
        Me.pnlBottomPane.Name = "pnlBottomPane"
        Me.pnlBottomPane.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlBottomPane.Size = New System.Drawing.Size(772, 166)
        Me.pnlBottomPane.TabIndex = 0
        '
        'lblDetailTitle
        '
        Me.lblDetailTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(139, 100, 110)
        Me.lblDetailTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblDetailTitle.Name = "lblDetailTitle"
        Me.lblDetailTitle.Size = New System.Drawing.Size(748, 26)
        Me.lblDetailTitle.TabIndex = 0
        Me.lblDetailTitle.Text = "DETAILS  (Panel2 of splInner)"
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDetails.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtDetails.ForeColor = System.Drawing.Color.FromArgb(59, 30, 37)
        Me.txtDetails.Location = New System.Drawing.Point(12, 38)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(748, 116)
        Me.txtDetails.TabIndex = 1
        Me.txtDetails.Text = "Select a record in the list above to display its details here."
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.pnlStatus.Controls.Add(Me.lblCount)
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 600)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1000, 30)
        Me.pnlStatus.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(85, 51, 60)
        Me.lblStatus.Location = New System.Drawing.Point(14, 7)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(222, 15)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Drag any splitter to resize the panels."
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(139, 100, 110)
        Me.lblCount.Location = New System.Drawing.Point(700, 7)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(284, 16)
        Me.lblCount.TabIndex = 1
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.ClientSize = New System.Drawing.Size(1000, 630)
        Me.Controls.Add(Me.splOuter)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlTools)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 10 - Split Container Lab  |  Deguzman, Liza Gaile"
        Me.menuMain.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.splOuter.Panel1.ResumeLayout(False)
        Me.splOuter.Panel2.ResumeLayout(False)
        CType(Me.splOuter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splOuter.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.splInner.Panel1.ResumeLayout(False)
        Me.splInner.Panel2.ResumeLayout(False)
        CType(Me.splInner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splInner.ResumeLayout(False)
        Me.pnlTopPane.ResumeLayout(False)
        Me.pnlBottomPane.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
