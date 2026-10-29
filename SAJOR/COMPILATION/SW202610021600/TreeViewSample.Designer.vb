<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewSample
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
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblPathCaption = New System.Windows.Forms.Label()
        Me.selectedPath = New System.Windows.Forms.TextBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.tree = New System.Windows.Forms.TreeView()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.pnlHeadRule = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblTitle_pnlHead = New System.Windows.Forms.Label()
        Me.lblSub_pnlHead = New System.Windows.Forms.Label()
        Me.pnlInfo.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.pnlHeadRule.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.lblPathCaption)
        Me.pnlInfo.Controls.Add(Me.selectedPath)
        Me.pnlInfo.Controls.Add(Me.lblHelp)
        Me.pnlInfo.Location = New System.Drawing.Point(320, 78)
        Me.pnlInfo.Size = New System.Drawing.Size(560, 482)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.TabIndex = 0
        '
        'lblPathCaption
        '
        Me.lblPathCaption.Location = New System.Drawing.Point(24, 26)
        Me.lblPathCaption.Size = New System.Drawing.Size(300, 18)
        Me.lblPathCaption.Text = "SELECTED PATH"
        Me.lblPathCaption.AutoSize = False
        Me.lblPathCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPathCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblPathCaption.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblPathCaption.Name = "lblPathCaption"
        Me.lblPathCaption.TabIndex = 1
        '
        'selectedPath
        '
        Me.selectedPath.Location = New System.Drawing.Point(24, 50)
        Me.selectedPath.Size = New System.Drawing.Size(512, 23)
        Me.selectedPath.ReadOnly = True
        Me.selectedPath.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.selectedPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selectedPath.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.selectedPath.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.selectedPath.Name = "selectedPath"
        Me.selectedPath.TabIndex = 2
        '
        'lblHelp
        '
        Me.lblHelp.Location = New System.Drawing.Point(24, 100)
        Me.lblHelp.Size = New System.Drawing.Size(512, 60)
        Me.lblHelp.Text = "Expand a drive or a folder, then select a node to see its full path."
        Me.lblHelp.AutoSize = False
        Me.lblHelp.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.lblHelp.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblHelp.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.TabIndex = 3
        '
        'tree
        '
        Me.tree.Location = New System.Drawing.Point(0, 78)
        Me.tree.Size = New System.Drawing.Size(320, 482)
        Me.tree.Dock = System.Windows.Forms.DockStyle.Left
        Me.tree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tree.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.tree.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.tree.Name = "tree"
        Me.tree.TabIndex = 4
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.pnlHeadRule)
        Me.pnlHead.Controls.Add(Me.btnRefresh)
        Me.pnlHead.Controls.Add(Me.lblTitle_pnlHead)
        Me.pnlHead.Controls.Add(Me.lblSub_pnlHead)
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Size = New System.Drawing.Size(880, 78)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.TabIndex = 5
        '
        'pnlHeadRule
        '
        Me.pnlHeadRule.Location = New System.Drawing.Point(0, 74)
        Me.pnlHeadRule.Size = New System.Drawing.Size(880, 4)
        Me.pnlHeadRule.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlHeadRule.Name = "pnlHeadRule"
        Me.pnlHeadRule.TabIndex = 6
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(732, 18)
        Me.btnRefresh.Size = New System.Drawing.Size(128, 38)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 7
        '
        'lblTitle_pnlHead
        '
        Me.lblTitle_pnlHead.Location = New System.Drawing.Point(20, 12)
        Me.lblTitle_pnlHead.Size = New System.Drawing.Size(520, 30)
        Me.lblTitle_pnlHead.Text = "TreeView File Explorer"
        Me.lblTitle_pnlHead.AutoSize = False
        Me.lblTitle_pnlHead.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle_pnlHead.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblTitle_pnlHead.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTitle_pnlHead.Name = "lblTitle_pnlHead"
        Me.lblTitle_pnlHead.TabIndex = 8
        '
        'lblSub_pnlHead
        '
        Me.lblSub_pnlHead.Location = New System.Drawing.Point(22, 46)
        Me.lblSub_pnlHead.Size = New System.Drawing.Size(600, 18)
        Me.lblSub_pnlHead.Text = "Drives and folders load when a node is expanded."
        Me.lblSub_pnlHead.AutoSize = False
        Me.lblSub_pnlHead.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblSub_pnlHead.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblSub_pnlHead.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSub_pnlHead.Name = "lblSub_pnlHead"
        Me.lblSub_pnlHead.TabIndex = 9
        '
        'TreeViewSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.tree)
        Me.Controls.Add(Me.pnlHead)
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "TreeViewSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 7 - TreeView File Explorer"
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlHead.ResumeLayout(False)
        Me.pnlHeadRule.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblPathCaption As System.Windows.Forms.Label
    Friend WithEvents selectedPath As System.Windows.Forms.TextBox
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents tree As System.Windows.Forms.TreeView
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents pnlHeadRule As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblTitle_pnlHead As System.Windows.Forms.Label
    Friend WithEvents lblSub_pnlHead As System.Windows.Forms.Label
End Class
