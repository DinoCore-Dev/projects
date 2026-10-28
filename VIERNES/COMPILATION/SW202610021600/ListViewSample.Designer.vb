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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.browse = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.details = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(0, 56)
        Me.lv.Size = New System.Drawing.Size(900, 444)
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.View = System.Windows.Forms.View.Details
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = False
        Me.lv.HideSelection = False
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv.Columns.Add("Name", 300)
        Me.lv.Columns.Add("Type", 150)
        Me.lv.Columns.Add("Modified/Size", 200)
        Me.lv.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lv.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.lv.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lv.Name = "lv"
        Me.lv.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.txtPath)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Size = New System.Drawing.Size(900, 56)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.TabIndex = 1
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(20, 17)
        Me.txtPath.Size = New System.Drawing.Size(860, 23)
        Me.txtPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtPath.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.TabIndex = 2
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.browse)
        Me.pnlBottom.Controls.Add(Me.btnRefresh)
        Me.pnlBottom.Controls.Add(Me.details)
        Me.pnlBottom.Controls.Add(Me.list)
        Me.pnlBottom.Controls.Add(Me.lbl)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 500)
        Me.pnlBottom.Size = New System.Drawing.Size(900, 60)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.TabIndex = 3
        '
        'browse
        '
        Me.browse.Location = New System.Drawing.Point(16, 10)
        Me.browse.Size = New System.Drawing.Size(112, 40)
        Me.browse.Text = "Browse..."
        Me.browse.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.browse.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.browse.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.browse.FlatAppearance.BorderSize = 1
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse.UseVisualStyleBackColor = False
        Me.browse.Name = "browse"
        Me.browse.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(136, 10)
        Me.btnRefresh.Size = New System.Drawing.Size(112, 40)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 5
        '
        'details
        '
        Me.details.Location = New System.Drawing.Point(256, 10)
        Me.details.Size = New System.Drawing.Size(100, 40)
        Me.details.Text = "Details"
        Me.details.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.details.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.details.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.details.FlatAppearance.BorderSize = 1
        Me.details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.details.UseVisualStyleBackColor = False
        Me.details.Name = "details"
        Me.details.TabIndex = 6
        '
        'list
        '
        Me.list.Location = New System.Drawing.Point(364, 10)
        Me.list.Size = New System.Drawing.Size(100, 40)
        Me.list.Text = "List"
        Me.list.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.list.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.list.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.list.FlatAppearance.BorderSize = 1
        Me.list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.list.UseVisualStyleBackColor = False
        Me.list.Name = "list"
        Me.list.TabIndex = 7
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(500, 19)
        Me.lbl.Size = New System.Drawing.Size(380, 22)
        Me.lbl.Text = "0 item(s)"
        Me.lbl.AutoSize = False
        Me.lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lbl.TextAlign = System.Windows.Forms.ContentAlignment.MiddleRight
        Me.lbl.Name = "lbl"
        Me.lbl.TabIndex = 8
        '
        'ListViewSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 560)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.Name = "ListViewSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 6 - ListView File Explorer"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents details As System.Windows.Forms.Button
    Friend WithEvents list As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
End Class
