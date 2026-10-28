<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombinedSample
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
        Me.tree = New System.Windows.Forms.TreeView()
        Me.pnlBar = New System.Windows.Forms.Panel()
        Me.open = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.pnlHeadRule = New System.Windows.Forms.Panel()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblHeadHint = New System.Windows.Forms.Label()
        Me.pnlBar.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.pnlHeadRule.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(280, 56)
        Me.lv.Size = New System.Drawing.Size(680, 460)
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.View = System.Windows.Forms.View.Details
        Me.lv.FullRowSelect = True
        Me.lv.HideSelection = False
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv.Columns.Add("Name", 300)
        Me.lv.Columns.Add("Type", 150)
        Me.lv.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lv.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.lv.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lv.Name = "lv"
        Me.lv.TabIndex = 0
        '
        'tree
        '
        Me.tree.Location = New System.Drawing.Point(0, 56)
        Me.tree.Size = New System.Drawing.Size(280, 460)
        Me.tree.Dock = System.Windows.Forms.DockStyle.Left
        Me.tree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tree.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.tree.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.tree.Name = "tree"
        Me.tree.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.tree.TabIndex = 1
        '
        'pnlBar
        '
        Me.pnlBar.Controls.Add(Me.open)
        Me.pnlBar.Controls.Add(Me.save)
        Me.pnlBar.Controls.Add(Me.btnRefresh)
        Me.pnlBar.Location = New System.Drawing.Point(0, 516)
        Me.pnlBar.Size = New System.Drawing.Size(960, 64)
        Me.pnlBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBar.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.TabIndex = 2
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(20, 12)
        Me.open.Size = New System.Drawing.Size(130, 40)
        Me.open.Text = "Open file"
        Me.open.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.open.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.open.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.open.FlatAppearance.BorderSize = 1
        Me.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open.UseVisualStyleBackColor = False
        Me.open.Name = "open"
        Me.open.TabIndex = 3
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(160, 12)
        Me.save.Size = New System.Drawing.Size(130, 40)
        Me.save.Text = "Save As"
        Me.save.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.save.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.save.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.save.FlatAppearance.BorderSize = 1
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.UseVisualStyleBackColor = False
        Me.save.Name = "save"
        Me.save.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(300, 12)
        Me.btnRefresh.Size = New System.Drawing.Size(120, 40)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 5
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.pnlHeadRule)
        Me.pnlHead.Controls.Add(Me.lblHead)
        Me.pnlHead.Controls.Add(Me.lblHeadHint)
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Size = New System.Drawing.Size(960, 56)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.TabIndex = 6
        '
        'pnlHeadRule
        '
        Me.pnlHeadRule.Location = New System.Drawing.Point(20, 14)
        Me.pnlHeadRule.Size = New System.Drawing.Size(4, 28)
        Me.pnlHeadRule.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.pnlHeadRule.Name = "pnlHeadRule"
        Me.pnlHeadRule.TabIndex = 7
        '
        'lblHead
        '
        Me.lblHead.Location = New System.Drawing.Point(34, 12)
        Me.lblHead.Size = New System.Drawing.Size(320, 32)
        Me.lblHead.Text = "Combined Explorer"
        Me.lblHead.AutoSize = False
        Me.lblHead.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHead.Name = "lblHead"
        Me.lblHead.TabIndex = 8
        '
        'lblHeadHint
        '
        Me.lblHeadHint.Location = New System.Drawing.Point(360, 18)
        Me.lblHeadHint.Size = New System.Drawing.Size(400, 20)
        Me.lblHeadHint.Text = "Folders on the left, folder contents on the right."
        Me.lblHeadHint.AutoSize = False
        Me.lblHeadHint.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblHeadHint.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblHeadHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeadHint.Name = "lblHeadHint"
        Me.lblHeadHint.TabIndex = 9
        '
        'CombinedSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 580)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tree)
        Me.Controls.Add(Me.pnlBar)
        Me.Controls.Add(Me.pnlHead)
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.Name = "CombinedSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 9 - Combined Explorer"
        Me.pnlBar.ResumeLayout(False)
        Me.pnlHead.ResumeLayout(False)
        Me.pnlHeadRule.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents tree As System.Windows.Forms.TreeView
    Friend WithEvents pnlBar As System.Windows.Forms.Panel
    Friend WithEvents open As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents pnlHeadRule As System.Windows.Forms.Panel
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblHeadHint As System.Windows.Forms.Label
End Class
