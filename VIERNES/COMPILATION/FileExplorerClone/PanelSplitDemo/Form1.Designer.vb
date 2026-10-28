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

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblApp As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents btnTreeToggle As System.Windows.Forms.Button
    Friend WithEvents btnPreviewToggle As System.Windows.Forms.Button
    Friend WithEvents btnSwapLayout As System.Windows.Forms.Button
    Friend WithEvents btnLockSplitters As System.Windows.Forms.Button
    Friend WithEvents lblSplitInfo As System.Windows.Forms.Label
    Friend WithEvents splRoot As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlTreeHost As System.Windows.Forms.Panel
    Friend WithEvents lblTreeTitle As System.Windows.Forms.Label
    Friend WithEvents tvFolders As System.Windows.Forms.TreeView
    Friend WithEvents splWorkspace As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlListHost As System.Windows.Forms.Panel
    Friend WithEvents lblListTitle As System.Windows.Forms.Label
    Friend WithEvents pnlFilterBar As System.Windows.Forms.Panel
    Friend WithEvents lblFilterCaption As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents lvFiles As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents colModified As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlPreviewHost As System.Windows.Forms.Panel
    Friend WithEvents lblPreviewTitle As System.Windows.Forms.Label
    Friend WithEvents txtPreview As System.Windows.Forms.TextBox
    Friend WithEvents pbPreview As System.Windows.Forms.PictureBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.pnlTools = New System.Windows.Forms.Panel()
        Me.lblSplitInfo = New System.Windows.Forms.Label()
        Me.btnLockSplitters = New System.Windows.Forms.Button()
        Me.btnSwapLayout = New System.Windows.Forms.Button()
        Me.btnPreviewToggle = New System.Windows.Forms.Button()
        Me.btnTreeToggle = New System.Windows.Forms.Button()
        Me.splRoot = New System.Windows.Forms.SplitContainer()
        Me.pnlTreeHost = New System.Windows.Forms.Panel()
        Me.tvFolders = New System.Windows.Forms.TreeView()
        Me.lblTreeTitle = New System.Windows.Forms.Label()
        Me.splWorkspace = New System.Windows.Forms.SplitContainer()
        Me.pnlListHost = New System.Windows.Forms.Panel()
        Me.lvFiles = New System.Windows.Forms.ListView()
        Me.colName = New System.Windows.Forms.ColumnHeader()
        Me.colType = New System.Windows.Forms.ColumnHeader()
        Me.colSize = New System.Windows.Forms.ColumnHeader()
        Me.colModified = New System.Windows.Forms.ColumnHeader()
        Me.pnlFilterBar = New System.Windows.Forms.Panel()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilterCaption = New System.Windows.Forms.Label()
        Me.lblListTitle = New System.Windows.Forms.Label()
        Me.pnlPreviewHost = New System.Windows.Forms.Panel()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.txtPreview = New System.Windows.Forms.TextBox()
        Me.lblPreviewTitle = New System.Windows.Forms.Label()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        CType(Me.splRoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splRoot.Panel1.SuspendLayout()
        Me.splRoot.Panel2.SuspendLayout()
        Me.splRoot.SuspendLayout()
        Me.pnlTreeHost.SuspendLayout()
        CType(Me.splWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splWorkspace.Panel1.SuspendLayout()
        Me.splWorkspace.Panel2.SuspendLayout()
        Me.splWorkspace.SuspendLayout()
        Me.pnlListHost.SuspendLayout()
        Me.pnlFilterBar.SuspendLayout()
        Me.pnlPreviewHost.SuspendLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlHeader.Controls.Add(Me.btnGo)
        Me.pnlHeader.Controls.Add(Me.txtPath)
        Me.pnlHeader.Controls.Add(Me.btnRefresh)
        Me.pnlHeader.Controls.Add(Me.btnHome)
        Me.pnlHeader.Controls.Add(Me.btnUp)
        Me.pnlHeader.Controls.Add(Me.btnForward)
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.lblApp)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 58)
        Me.pnlHeader.TabIndex = 0
        '
        'lblApp
        '
        Me.lblApp.AutoSize = False
        Me.lblApp.Font = New System.Drawing.Font("Corbel", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblApp.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblApp.Location = New System.Drawing.Point(20, 8)
        Me.lblApp.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(270, 28)
        Me.lblApp.TabIndex = 0
        Me.lblApp.Text = "VIERNES EXPLORER"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = False
        Me.lblHeaderSub.Font = New System.Drawing.Font("Corbel", 6.5!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblHeaderSub.Location = New System.Drawing.Point(22, 36)
        Me.lblHeaderSub.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(270, 16)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Activity 12 - PanelSplitDemo  |  TreeView + ListView + live preview inside SplitContainers"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Corbel", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblAuthor.Location = New System.Drawing.Point(800, 6)
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(380, 18)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Viernes, Mark Syrel  |  BSIT 3B"
        Me.lblAuthor.TextAlign = System.Windows.Forms.ContentAlignment.MiddleRight
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnBack.Location = New System.Drawing.Point(300, 13)
        Me.btnBack.FlatAppearance.BorderSize = 1
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(62, 32)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForward.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnForward.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnForward.Location = New System.Drawing.Point(368, 13)
        Me.btnForward.FlatAppearance.BorderSize = 1
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(76, 32)
        Me.btnForward.TabIndex = 4
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnUp.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnUp.Location = New System.Drawing.Point(450, 13)
        Me.btnUp.FlatAppearance.BorderSize = 1
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(52, 32)
        Me.btnUp.TabIndex = 5
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnHome.Location = New System.Drawing.Point(508, 13)
        Me.btnHome.FlatAppearance.BorderSize = 1
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(62, 32)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnRefresh.Location = New System.Drawing.Point(576, 13)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.txtPath.Location = New System.Drawing.Point(672, 17)
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtPath.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(426, 24)
        Me.txtPath.TabIndex = 8
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnGo.FlatAppearance.BorderSize = 1
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnGo.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.btnGo.Location = New System.Drawing.Point(1108, 13)
        Me.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(74, 32)
        Me.btnGo.TabIndex = 9
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pnlTools.Controls.Add(Me.lblSplitInfo)
        Me.pnlTools.Controls.Add(Me.btnLockSplitters)
        Me.pnlTools.Controls.Add(Me.btnSwapLayout)
        Me.pnlTools.Controls.Add(Me.btnPreviewToggle)
        Me.pnlTools.Controls.Add(Me.btnTreeToggle)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTools.Location = New System.Drawing.Point(0, 96)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(160, 632)
        Me.pnlTools.TabIndex = 1
        '
        'btnTreeToggle
        '
        Me.btnTreeToggle.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnTreeToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnTreeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreeToggle.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnTreeToggle.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnTreeToggle.Location = New System.Drawing.Point(12, 24)
        Me.btnTreeToggle.FlatAppearance.BorderSize = 1
        Me.btnTreeToggle.Name = "btnTreeToggle"
        Me.btnTreeToggle.Size = New System.Drawing.Size(136, 38)
        Me.btnTreeToggle.TabIndex = 0
        Me.btnTreeToggle.Text = "Hide folder tree"
        Me.btnTreeToggle.UseVisualStyleBackColor = False
        '
        'btnPreviewToggle
        '
        Me.btnPreviewToggle.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnPreviewToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnPreviewToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviewToggle.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnPreviewToggle.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnPreviewToggle.Location = New System.Drawing.Point(12, 74)
        Me.btnPreviewToggle.FlatAppearance.BorderSize = 1
        Me.btnPreviewToggle.Name = "btnPreviewToggle"
        Me.btnPreviewToggle.Size = New System.Drawing.Size(136, 38)
        Me.btnPreviewToggle.TabIndex = 1
        Me.btnPreviewToggle.Text = "Hide preview pane"
        Me.btnPreviewToggle.UseVisualStyleBackColor = False
        '
        'btnSwapLayout
        '
        Me.btnSwapLayout.BackColor = System.Drawing.Color.FromArgb(36, 35, 54)
        Me.btnSwapLayout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(167, 139, 250)
        Me.btnSwapLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwapLayout.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnSwapLayout.ForeColor = System.Drawing.Color.FromArgb(198, 180, 252)
        Me.btnSwapLayout.Location = New System.Drawing.Point(12, 124)
        Me.btnSwapLayout.FlatAppearance.BorderSize = 1
        Me.btnSwapLayout.Name = "btnSwapLayout"
        Me.btnSwapLayout.Size = New System.Drawing.Size(136, 38)
        Me.btnSwapLayout.TabIndex = 2
        Me.btnSwapLayout.Text = "Preview beside list"
        Me.btnSwapLayout.UseVisualStyleBackColor = False
        '
        'btnLockSplitters
        '
        Me.btnLockSplitters.BackColor = System.Drawing.Color.FromArgb(47, 41, 26)
        Me.btnLockSplitters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(251, 191, 36)
        Me.btnLockSplitters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLockSplitters.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.btnLockSplitters.ForeColor = System.Drawing.Color.FromArgb(252, 213, 113)
        Me.btnLockSplitters.Location = New System.Drawing.Point(12, 174)
        Me.btnLockSplitters.FlatAppearance.BorderSize = 1
        Me.btnLockSplitters.Name = "btnLockSplitters"
        Me.btnLockSplitters.Size = New System.Drawing.Size(136, 38)
        Me.btnLockSplitters.TabIndex = 3
        Me.btnLockSplitters.Text = "Lock splitters"
        Me.btnLockSplitters.UseVisualStyleBackColor = False
        '
        'lblSplitInfo
        '
        Me.lblSplitInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSplitInfo.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.lblSplitInfo.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblSplitInfo.Location = New System.Drawing.Point(12, 240)
        Me.lblSplitInfo.AutoSize = False
        Me.lblSplitInfo.Name = "lblSplitInfo"
        Me.lblSplitInfo.Size = New System.Drawing.Size(136, 120)
        Me.lblSplitInfo.TabIndex = 4
        Me.lblSplitInfo.Text = "splitRoot : 240 px   |   splitWorkspace : 340 px"
        Me.lblSplitInfo.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        '
        'splRoot
        '
        Me.splRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splRoot.Location = New System.Drawing.Point(0, 140)
        Me.splRoot.BackColor = System.Drawing.Color.FromArgb(58, 65, 80)
        Me.splRoot.Name = "splRoot"
        Me.splRoot.Orientation = System.Windows.Forms.Orientation.Vertical
        '
        'splRoot.Panel1
        '
        Me.splRoot.Panel1.Controls.Add(Me.pnlTreeHost)
        Me.splRoot.Panel1MinSize = 190
        '
        'splRoot.Panel2
        '
        Me.splRoot.Panel2.Controls.Add(Me.splWorkspace)
        Me.splRoot.Panel2MinSize = 480
        Me.splRoot.Size = New System.Drawing.Size(1200, 552)
        Me.splRoot.SplitterDistance = 240
        Me.splRoot.SplitterWidth = 6
        Me.splRoot.TabIndex = 2
        '
        'pnlTreeHost
        '
        Me.pnlTreeHost.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlTreeHost.Controls.Add(Me.tvFolders)
        Me.pnlTreeHost.Controls.Add(Me.lblTreeTitle)
        Me.pnlTreeHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTreeHost.Location = New System.Drawing.Point(0, 0)
        Me.pnlTreeHost.Name = "pnlTreeHost"
        Me.pnlTreeHost.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlTreeHost.Size = New System.Drawing.Size(240, 552)
        Me.pnlTreeHost.TabIndex = 0
        '
        'lblTreeTitle
        '
        Me.lblTreeTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTreeTitle.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTreeTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblTreeTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTreeTitle.BackColor = System.Drawing.Color.FromArgb(38, 43, 55)
        Me.lblTreeTitle.Name = "lblTreeTitle"
        Me.lblTreeTitle.Size = New System.Drawing.Size(220, 26)
        Me.lblTreeTitle.TabIndex = 0
        Me.lblTreeTitle.Text = "FOLDERS"
        '
        'tvFolders
        '
        Me.tvFolders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvFolders.Font = New System.Drawing.Font("Corbel", 9.5!)
        Me.tvFolders.FullRowSelect = True
        Me.tvFolders.HideSelection = False
        Me.tvFolders.ItemHeight = 22
        Me.tvFolders.Location = New System.Drawing.Point(10, 36)
        Me.tvFolders.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.tvFolders.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.tvFolders.Name = "tvFolders"
        Me.tvFolders.ShowLines = False
        Me.tvFolders.Size = New System.Drawing.Size(220, 506)
        Me.tvFolders.TabIndex = 1
        '
        'splWorkspace
        '
        Me.splWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splWorkspace.Location = New System.Drawing.Point(0, 0)
        Me.splWorkspace.BackColor = System.Drawing.Color.FromArgb(58, 65, 80)
        Me.splWorkspace.Name = "splWorkspace"
        Me.splWorkspace.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splWorkspace.Panel1
        '
        Me.splWorkspace.Panel1.Controls.Add(Me.pnlListHost)
        Me.splWorkspace.Panel1MinSize = 180
        '
        'splWorkspace.Panel2
        '
        Me.splWorkspace.Panel2.Controls.Add(Me.pnlPreviewHost)
        Me.splWorkspace.Panel2MinSize = 130
        Me.splWorkspace.Size = New System.Drawing.Size(954, 552)
        Me.splWorkspace.SplitterDistance = 340
        Me.splWorkspace.SplitterWidth = 6
        Me.splWorkspace.TabIndex = 0
        '
        'pnlListHost
        '
        Me.pnlListHost.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlListHost.Controls.Add(Me.lvFiles)
        Me.pnlListHost.Controls.Add(Me.pnlFilterBar)
        Me.pnlListHost.Controls.Add(Me.lblListTitle)
        Me.pnlListHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListHost.Location = New System.Drawing.Point(0, 0)
        Me.pnlListHost.Name = "pnlListHost"
        Me.pnlListHost.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlListHost.Size = New System.Drawing.Size(954, 340)
        Me.pnlListHost.TabIndex = 0
        '
        'lblListTitle
        '
        Me.lblListTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblListTitle.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblListTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblListTitle.BackColor = System.Drawing.Color.FromArgb(38, 43, 55)
        Me.lblListTitle.Name = "lblListTitle"
        Me.lblListTitle.Size = New System.Drawing.Size(934, 24)
        Me.lblListTitle.TabIndex = 0
        Me.lblListTitle.Text = "CONTENTS"
        '
        'pnlFilterBar
        '
        Me.pnlFilterBar.Controls.Add(Me.txtFilter)
        Me.pnlFilterBar.Controls.Add(Me.lblFilterCaption)
        Me.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBar.Location = New System.Drawing.Point(10, 34)
        Me.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlFilterBar.Name = "pnlFilterBar"
        Me.pnlFilterBar.Size = New System.Drawing.Size(934, 30)
        Me.pnlFilterBar.TabIndex = 1
        '
        'lblFilterCaption
        '
        Me.lblFilterCaption.AutoSize = True
        Me.lblFilterCaption.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.lblFilterCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblFilterCaption.Location = New System.Drawing.Point(0, 7)
        Me.lblFilterCaption.Name = "lblFilterCaption"
        Me.lblFilterCaption.Size = New System.Drawing.Size(160, 13)
        Me.lblFilterCaption.TabIndex = 0
        Me.lblFilterCaption.Text = "Filter the items in this folder :"
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Font = New System.Drawing.Font("Corbel", 9.5!)
        Me.txtFilter.Location = New System.Drawing.Point(520, 3)
        Me.txtFilter.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtFilter.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(250, 23)
        Me.txtFilter.TabIndex = 1
        '
        'lvFiles
        '
        Me.lvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colType, Me.colSize, Me.colModified})
        Me.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFiles.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lvFiles.FullRowSelect = True
        Me.lvFiles.GridLines = False
        Me.lvFiles.HideSelection = False
        Me.lvFiles.Location = New System.Drawing.Point(10, 64)
        Me.lvFiles.MultiSelect = False
        Me.lvFiles.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.lvFiles.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lvFiles.Name = "lvFiles"
        Me.lvFiles.Size = New System.Drawing.Size(934, 266)
        Me.lvFiles.TabIndex = 2
        Me.lvFiles.UseCompatibleStateImageBehavior = False
        Me.lvFiles.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 360
        '
        'colType
        '
        Me.colType.Text = "Type"
        Me.colType.Width = 150
        '
        'colSize
        '
        Me.colSize.Text = "Size"
        Me.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colSize.Width = 120
        '
        'colModified
        '
        Me.colModified.Text = "Date modified"
        Me.colModified.Width = 190
        '
        'pnlPreviewHost
        '
        Me.pnlPreviewHost.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlPreviewHost.Controls.Add(Me.pbPreview)
        Me.pnlPreviewHost.Controls.Add(Me.txtPreview)
        Me.pnlPreviewHost.Controls.Add(Me.lblPreviewTitle)
        Me.pnlPreviewHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPreviewHost.Location = New System.Drawing.Point(0, 0)
        Me.pnlPreviewHost.Name = "pnlPreviewHost"
        Me.pnlPreviewHost.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlPreviewHost.Size = New System.Drawing.Size(954, 206)
        Me.pnlPreviewHost.TabIndex = 0
        '
        'lblPreviewTitle
        '
        Me.lblPreviewTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPreviewTitle.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblPreviewTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblPreviewTitle.BackColor = System.Drawing.Color.FromArgb(38, 43, 55)
        Me.lblPreviewTitle.Name = "lblPreviewTitle"
        Me.lblPreviewTitle.Size = New System.Drawing.Size(934, 24)
        Me.lblPreviewTitle.TabIndex = 0
        Me.lblPreviewTitle.Text = "PREVIEW"
        '
        'txtPreview
        '
        Me.txtPreview.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPreview.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtPreview.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtPreview.Location = New System.Drawing.Point(10, 34)
        Me.txtPreview.Multiline = True
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.ReadOnly = True
        Me.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPreview.Size = New System.Drawing.Size(934, 162)
        Me.txtPreview.TabIndex = 1
        Me.txtPreview.WordWrap = False
        '
        'pbPreview
        '
        Me.pbPreview.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pbPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPreview.Location = New System.Drawing.Point(10, 34)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(934, 162)
        Me.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPreview.TabIndex = 2
        Me.pbPreview.TabStop = False
        Me.pbPreview.Visible = False
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlStatus.Controls.Add(Me.lblCount)
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Controls.Add(Me.lblAuthor)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 692)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1200, 30)
        Me.pnlStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblStatus.Location = New System.Drawing.Point(14, 6)
        Me.lblStatus.TextAlign = System.Windows.Forms.ContentAlignment.MiddleLeft
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(480, 18)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Choose a folder from the tree to start."
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblCount.Location = New System.Drawing.Point(500, 6)
        Me.lblCount.AutoSize = False
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(280, 18)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0 item(s)"
        Me.lblCount.TextAlign = System.Windows.Forms.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.splRoot)
        Me.Controls.Add(Me.pnlTools)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlHeader)
        Me.MinimumSize = New System.Drawing.Size(980, 620)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 12 - Viernes Explorer  |  Viernes, Mark Syrel"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.splRoot.Panel1.ResumeLayout(False)
        Me.splRoot.Panel2.ResumeLayout(False)
        CType(Me.splRoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splRoot.ResumeLayout(False)
        Me.pnlTreeHost.ResumeLayout(False)
        Me.splWorkspace.Panel1.ResumeLayout(False)
        Me.splWorkspace.Panel2.ResumeLayout(False)
        CType(Me.splWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splWorkspace.ResumeLayout(False)
        Me.pnlListHost.ResumeLayout(False)
        Me.pnlFilterBar.ResumeLayout(False)
        Me.pnlPreviewHost.ResumeLayout(False)
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
