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
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.browse = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.details = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlTopRule = New System.Windows.Forms.Panel()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.pnlSide.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlTopRule.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(170, 56)
        Me.lv.Size = New System.Drawing.Size(730, 504)
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.View = System.Windows.Forms.View.Details
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.HideSelection = False
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv.Columns.Add("Name", 300)
        Me.lv.Columns.Add("Type", 150)
        Me.lv.Columns.Add("Modified/Size", 200)
        Me.lv.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!)
        Me.lv.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.lv.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.lv.Name = "lv"
        Me.lv.TabIndex = 0
        '
        'pnlSide
        '
        Me.pnlSide.Controls.Add(Me.browse)
        Me.pnlSide.Controls.Add(Me.btnRefresh)
        Me.pnlSide.Controls.Add(Me.details)
        Me.pnlSide.Controls.Add(Me.list)
        Me.pnlSide.Controls.Add(Me.lbl)
        Me.pnlSide.Location = New System.Drawing.Point(0, 56)
        Me.pnlSide.Size = New System.Drawing.Size(170, 504)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.TabIndex = 1
        '
        'browse
        '
        Me.browse.Location = New System.Drawing.Point(14, 20)
        Me.browse.Size = New System.Drawing.Size(142, 40)
        Me.browse.Text = "Browse..."
        Me.browse.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.browse.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.browse.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.browse.FlatAppearance.BorderSize = 1
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse.UseVisualStyleBackColor = False
        Me.browse.Name = "browse"
        Me.browse.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(14, 68)
        Me.btnRefresh.Size = New System.Drawing.Size(142, 40)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnRefresh.FlatAppearance.BorderSize = 1
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 3
        '
        'details
        '
        Me.details.Location = New System.Drawing.Point(14, 116)
        Me.details.Size = New System.Drawing.Size(142, 40)
        Me.details.Text = "Details"
        Me.details.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.details.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.details.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.details.FlatAppearance.BorderSize = 1
        Me.details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.details.UseVisualStyleBackColor = False
        Me.details.Name = "details"
        Me.details.TabIndex = 4
        '
        'list
        '
        Me.list.Location = New System.Drawing.Point(14, 164)
        Me.list.Size = New System.Drawing.Size(142, 40)
        Me.list.Text = "List"
        Me.list.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.list.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.list.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.list.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.list.FlatAppearance.BorderSize = 1
        Me.list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.list.UseVisualStyleBackColor = False
        Me.list.Name = "list"
        Me.list.TabIndex = 5
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(14, 440)
        Me.lbl.Size = New System.Drawing.Size(142, 40)
        Me.lbl.Text = "0 item(s)"
        Me.lbl.AutoSize = False
        Me.lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl.Name = "lbl"
        Me.lbl.TabIndex = 6
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlTopRule)
        Me.pnlTop.Controls.Add(Me.txtPath)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Size = New System.Drawing.Size(900, 56)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.TabIndex = 7
        '
        'pnlTopRule
        '
        Me.pnlTopRule.Location = New System.Drawing.Point(0, 52)
        Me.pnlTopRule.Size = New System.Drawing.Size(900, 4)
        Me.pnlTopRule.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlTopRule.Name = "pnlTopRule"
        Me.pnlTopRule.TabIndex = 8
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(16, 14)
        Me.txtPath.Size = New System.Drawing.Size(868, 23)
        Me.txtPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtPath.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.TabIndex = 9
        '
        'ListViewSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 560)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlTop)
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "ListViewSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 6 - ListView File Explorer"
        Me.pnlSide.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTopRule.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents pnlSide As System.Windows.Forms.Panel
    Friend WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents details As System.Windows.Forms.Button
    Friend WithEvents list As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlTopRule As System.Windows.Forms.Panel
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
End Class
