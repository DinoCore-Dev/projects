<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenFileDialogSample
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
        Me.selected = New System.Windows.Forms.ListBox()
        Me.pnlRail = New System.Windows.Forms.Panel()
        Me.lblRailTitle = New System.Windows.Forms.Label()
        Me.one = New System.Windows.Forms.Button()
        Me.many = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.lblRailNote = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlTopRule = New System.Windows.Forms.Panel()
        Me.lblTitle_pnlTop = New System.Windows.Forms.Label()
        Me.lblSub_pnlTop = New System.Windows.Forms.Label()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.pnlRail.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlTopRule.SuspendLayout()
        Me.SuspendLayout()
        '
        'selected
        '
        Me.selected.Location = New System.Drawing.Point(0, 70)
        Me.selected.Size = New System.Drawing.Size(560, 450)
        Me.selected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.selected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.selected.ItemHeight = 19
        Me.selected.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.selected.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.selected.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.selected.Name = "selected"
        Me.selected.TabIndex = 0
        '
        'pnlRail
        '
        Me.pnlRail.Controls.Add(Me.lblRailTitle)
        Me.pnlRail.Controls.Add(Me.one)
        Me.pnlRail.Controls.Add(Me.many)
        Me.pnlRail.Controls.Add(Me.clear)
        Me.pnlRail.Controls.Add(Me.lblRailNote)
        Me.pnlRail.Location = New System.Drawing.Point(580, 70)
        Me.pnlRail.Size = New System.Drawing.Size(220, 450)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.TabIndex = 1
        '
        'lblRailTitle
        '
        Me.lblRailTitle.Location = New System.Drawing.Point(20, 22)
        Me.lblRailTitle.Size = New System.Drawing.Size(180, 18)
        Me.lblRailTitle.Text = "CHOOSE"
        Me.lblRailTitle.AutoSize = False
        Me.lblRailTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblRailTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailTitle.Name = "lblRailTitle"
        Me.lblRailTitle.TabIndex = 2
        '
        'one
        '
        Me.one.Location = New System.Drawing.Point(20, 52)
        Me.one.Size = New System.Drawing.Size(180, 44)
        Me.one.Text = "Open one..."
        Me.one.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.one.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.one.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.one.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.one.FlatAppearance.BorderSize = 1
        Me.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.one.UseVisualStyleBackColor = False
        Me.one.Name = "one"
        Me.one.TabIndex = 3
        '
        'many
        '
        Me.many.Location = New System.Drawing.Point(20, 106)
        Me.many.Size = New System.Drawing.Size(180, 44)
        Me.many.Text = "Open multiple..."
        Me.many.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.many.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.many.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.many.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.many.FlatAppearance.BorderSize = 1
        Me.many.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.many.UseVisualStyleBackColor = False
        Me.many.Name = "many"
        Me.many.TabIndex = 4
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(20, 160)
        Me.clear.Size = New System.Drawing.Size(180, 44)
        Me.clear.Text = "Clear"
        Me.clear.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.clear.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.clear.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.clear.FlatAppearance.BorderSize = 1
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.UseVisualStyleBackColor = False
        Me.clear.Name = "clear"
        Me.clear.TabIndex = 5
        '
        'lblRailNote
        '
        Me.lblRailNote.Location = New System.Drawing.Point(20, 226)
        Me.lblRailNote.Size = New System.Drawing.Size(182, 90)
        Me.lblRailNote.Text = "Pick one file or many files. Your selection is listed on the left."
        Me.lblRailNote.AutoSize = False
        Me.lblRailNote.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblRailNote.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblRailNote.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailNote.Name = "lblRailNote"
        Me.lblRailNote.TabIndex = 6
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlTopRule)
        Me.pnlTop.Controls.Add(Me.lblTitle_pnlTop)
        Me.pnlTop.Controls.Add(Me.lblSub_pnlTop)
        Me.pnlTop.Controls.Add(Me.lblHead)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Size = New System.Drawing.Size(800, 70)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.TabIndex = 7
        '
        'pnlTopRule
        '
        Me.pnlTopRule.Location = New System.Drawing.Point(0, 66)
        Me.pnlTopRule.Size = New System.Drawing.Size(800, 4)
        Me.pnlTopRule.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlTopRule.Name = "pnlTopRule"
        Me.pnlTopRule.TabIndex = 8
        '
        'lblTitle_pnlTop
        '
        Me.lblTitle_pnlTop.Location = New System.Drawing.Point(20, 10)
        Me.lblTitle_pnlTop.Size = New System.Drawing.Size(520, 30)
        Me.lblTitle_pnlTop.Text = "OpenFileDialog"
        Me.lblTitle_pnlTop.AutoSize = False
        Me.lblTitle_pnlTop.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle_pnlTop.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblTitle_pnlTop.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTitle_pnlTop.Name = "lblTitle_pnlTop"
        Me.lblTitle_pnlTop.TabIndex = 9
        '
        'lblSub_pnlTop
        '
        Me.lblSub_pnlTop.Location = New System.Drawing.Point(22, 42)
        Me.lblSub_pnlTop.Size = New System.Drawing.Size(520, 18)
        Me.lblSub_pnlTop.Text = "Selected files are listed below."
        Me.lblSub_pnlTop.AutoSize = False
        Me.lblSub_pnlTop.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblSub_pnlTop.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblSub_pnlTop.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSub_pnlTop.Name = "lblSub_pnlTop"
        Me.lblSub_pnlTop.TabIndex = 10
        '
        'lblHead
        '
        Me.lblHead.Location = New System.Drawing.Point(600, 24)
        Me.lblHead.Size = New System.Drawing.Size(180, 22)
        Me.lblHead.Text = "SELECTED FILES"
        Me.lblHead.AutoSize = False
        Me.lblHead.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.TabIndex = 11
        '
        'OpenFileDialogSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.pnlRail)
        Me.Controls.Add(Me.pnlTop)
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "OpenFileDialogSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 8 - OpenFileDialog"
        Me.pnlRail.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTopRule.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selected As System.Windows.Forms.ListBox
    Friend WithEvents pnlRail As System.Windows.Forms.Panel
    Friend WithEvents lblRailTitle As System.Windows.Forms.Label
    Friend WithEvents one As System.Windows.Forms.Button
    Friend WithEvents many As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents lblRailNote As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlTopRule As System.Windows.Forms.Panel
    Friend WithEvents lblTitle_pnlTop As System.Windows.Forms.Label
    Friend WithEvents lblSub_pnlTop As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
End Class
