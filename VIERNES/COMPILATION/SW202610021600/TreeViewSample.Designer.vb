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
        Me.tree = New System.Windows.Forms.TreeView()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblPathCaption = New System.Windows.Forms.Label()
        Me.selectedPath = New System.Windows.Forms.TextBox()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.pnlRule_pnlSide = New System.Windows.Forms.Panel()
        Me.lblTitle_pnlSide = New System.Windows.Forms.Label()
        Me.lblSub_pnlSide = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pnlInfo.SuspendLayout()
        Me.pnlSide.SuspendLayout()
        Me.pnlRule_pnlSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'tree
        '
        Me.tree.Location = New System.Drawing.Point(220, 72)
        Me.tree.Size = New System.Drawing.Size(660, 488)
        Me.tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tree.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.tree.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.tree.Name = "tree"
        Me.tree.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.tree.TabIndex = 0
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.lblPathCaption)
        Me.pnlInfo.Controls.Add(Me.selectedPath)
        Me.pnlInfo.Location = New System.Drawing.Point(220, 0)
        Me.pnlInfo.Size = New System.Drawing.Size(660, 72)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.TabIndex = 1
        '
        'lblPathCaption
        '
        Me.lblPathCaption.Location = New System.Drawing.Point(20, 12)
        Me.lblPathCaption.Size = New System.Drawing.Size(300, 18)
        Me.lblPathCaption.Text = "SELECTED PATH"
        Me.lblPathCaption.AutoSize = False
        Me.lblPathCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPathCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblPathCaption.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblPathCaption.Name = "lblPathCaption"
        Me.lblPathCaption.TabIndex = 2
        '
        'selectedPath
        '
        Me.selectedPath.Location = New System.Drawing.Point(20, 36)
        Me.selectedPath.Size = New System.Drawing.Size(620, 23)
        Me.selectedPath.ReadOnly = True
        Me.selectedPath.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.selectedPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selectedPath.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.selectedPath.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.selectedPath.Name = "selectedPath"
        Me.selectedPath.TabIndex = 3
        '
        'pnlSide
        '
        Me.pnlSide.Controls.Add(Me.pnlRule_pnlSide)
        Me.pnlSide.Controls.Add(Me.lblTitle_pnlSide)
        Me.pnlSide.Controls.Add(Me.lblSub_pnlSide)
        Me.pnlSide.Controls.Add(Me.btnRefresh)
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Size = New System.Drawing.Size(220, 560)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.TabIndex = 4
        '
        'pnlRule_pnlSide
        '
        Me.pnlRule_pnlSide.Location = New System.Drawing.Point(20, 26)
        Me.pnlRule_pnlSide.Size = New System.Drawing.Size(40, 4)
        Me.pnlRule_pnlSide.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.pnlRule_pnlSide.Name = "pnlRule_pnlSide"
        Me.pnlRule_pnlSide.TabIndex = 5
        '
        'lblTitle_pnlSide
        '
        Me.lblTitle_pnlSide.Location = New System.Drawing.Point(20, 40)
        Me.lblTitle_pnlSide.Size = New System.Drawing.Size(180, 60)
        Me.lblTitle_pnlSide.Text = "TreeView File Explorer"
        Me.lblTitle_pnlSide.AutoSize = False
        Me.lblTitle_pnlSide.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle_pnlSide.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblTitle_pnlSide.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTitle_pnlSide.Name = "lblTitle_pnlSide"
        Me.lblTitle_pnlSide.TabIndex = 6
        '
        'lblSub_pnlSide
        '
        Me.lblSub_pnlSide.Location = New System.Drawing.Point(20, 108)
        Me.lblSub_pnlSide.Size = New System.Drawing.Size(176, 80)
        Me.lblSub_pnlSide.Text = "Expand a drive or a folder, then select a node to see its full path."
        Me.lblSub_pnlSide.AutoSize = False
        Me.lblSub_pnlSide.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblSub_pnlSide.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblSub_pnlSide.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSub_pnlSide.Name = "lblSub_pnlSide"
        Me.lblSub_pnlSide.TabIndex = 7
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(20, 196)
        Me.btnRefresh.Size = New System.Drawing.Size(180, 42)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 8
        '
        'TreeViewSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.tree)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlSide)
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.Name = "TreeViewSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 7 - TreeView File Explorer"
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlSide.ResumeLayout(False)
        Me.pnlRule_pnlSide.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tree As System.Windows.Forms.TreeView
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblPathCaption As System.Windows.Forms.Label
    Friend WithEvents selectedPath As System.Windows.Forms.TextBox
    Friend WithEvents pnlSide As System.Windows.Forms.Panel
    Friend WithEvents pnlRule_pnlSide As System.Windows.Forms.Panel
    Friend WithEvents lblTitle_pnlSide As System.Windows.Forms.Label
    Friend WithEvents lblSub_pnlSide As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
