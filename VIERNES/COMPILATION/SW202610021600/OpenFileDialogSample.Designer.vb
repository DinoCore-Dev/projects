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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.pnlRail = New System.Windows.Forms.Panel()
        Me.pnlRule_pnlRail = New System.Windows.Forms.Panel()
        Me.lblTitle_pnlRail = New System.Windows.Forms.Label()
        Me.lblSub_pnlRail = New System.Windows.Forms.Label()
        Me.one = New System.Windows.Forms.Button()
        Me.many = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlRail.SuspendLayout()
        Me.pnlRule_pnlRail.SuspendLayout()
        Me.SuspendLayout()
        '
        'selected
        '
        Me.selected.Location = New System.Drawing.Point(200, 56)
        Me.selected.Size = New System.Drawing.Size(600, 464)
        Me.selected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.selected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.selected.ItemHeight = 19
        Me.selected.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.selected.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.selected.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.selected.Name = "selected"
        Me.selected.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblHead)
        Me.pnlTop.Location = New System.Drawing.Point(200, 0)
        Me.pnlTop.Size = New System.Drawing.Size(600, 56)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.TabIndex = 1
        '
        'lblHead
        '
        Me.lblHead.Location = New System.Drawing.Point(20, 18)
        Me.lblHead.Size = New System.Drawing.Size(400, 22)
        Me.lblHead.Text = "SELECTED FILES"
        Me.lblHead.AutoSize = False
        Me.lblHead.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblHead.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblHead.Name = "lblHead"
        Me.lblHead.TabIndex = 2
        '
        'pnlRail
        '
        Me.pnlRail.Controls.Add(Me.pnlRule_pnlRail)
        Me.pnlRail.Controls.Add(Me.lblTitle_pnlRail)
        Me.pnlRail.Controls.Add(Me.lblSub_pnlRail)
        Me.pnlRail.Controls.Add(Me.one)
        Me.pnlRail.Controls.Add(Me.many)
        Me.pnlRail.Controls.Add(Me.clear)
        Me.pnlRail.Location = New System.Drawing.Point(0, 0)
        Me.pnlRail.Size = New System.Drawing.Size(200, 520)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.TabIndex = 3
        '
        'pnlRule_pnlRail
        '
        Me.pnlRule_pnlRail.Location = New System.Drawing.Point(20, 26)
        Me.pnlRule_pnlRail.Size = New System.Drawing.Size(40, 4)
        Me.pnlRule_pnlRail.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.pnlRule_pnlRail.Name = "pnlRule_pnlRail"
        Me.pnlRule_pnlRail.TabIndex = 4
        '
        'lblTitle_pnlRail
        '
        Me.lblTitle_pnlRail.Location = New System.Drawing.Point(20, 40)
        Me.lblTitle_pnlRail.Size = New System.Drawing.Size(160, 60)
        Me.lblTitle_pnlRail.Text = "OpenFileDialog"
        Me.lblTitle_pnlRail.AutoSize = False
        Me.lblTitle_pnlRail.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle_pnlRail.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblTitle_pnlRail.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblTitle_pnlRail.Name = "lblTitle_pnlRail"
        Me.lblTitle_pnlRail.TabIndex = 5
        '
        'lblSub_pnlRail
        '
        Me.lblSub_pnlRail.Location = New System.Drawing.Point(20, 108)
        Me.lblSub_pnlRail.Size = New System.Drawing.Size(156, 70)
        Me.lblSub_pnlRail.Text = "Pick one file or many files. Your selection is listed on the right."
        Me.lblSub_pnlRail.AutoSize = False
        Me.lblSub_pnlRail.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblSub_pnlRail.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblSub_pnlRail.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        Me.lblSub_pnlRail.Name = "lblSub_pnlRail"
        Me.lblSub_pnlRail.TabIndex = 6
        '
        'one
        '
        Me.one.Location = New System.Drawing.Point(20, 190)
        Me.one.Size = New System.Drawing.Size(160, 44)
        Me.one.Text = "Open one..."
        Me.one.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.one.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.one.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.one.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.one.FlatAppearance.BorderSize = 1
        Me.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.one.UseVisualStyleBackColor = False
        Me.one.Name = "one"
        Me.one.TabIndex = 7
        '
        'many
        '
        Me.many.Location = New System.Drawing.Point(20, 242)
        Me.many.Size = New System.Drawing.Size(160, 44)
        Me.many.Text = "Open multiple..."
        Me.many.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.many.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.many.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.many.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.many.FlatAppearance.BorderSize = 1
        Me.many.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.many.UseVisualStyleBackColor = False
        Me.many.Name = "many"
        Me.many.TabIndex = 8
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(20, 294)
        Me.clear.Size = New System.Drawing.Size(160, 44)
        Me.clear.Text = "Clear"
        Me.clear.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.clear.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.clear.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.clear.FlatAppearance.BorderSize = 1
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.UseVisualStyleBackColor = False
        Me.clear.Name = "clear"
        Me.clear.TabIndex = 9
        '
        'OpenFileDialogSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlRail)
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.Name = "OpenFileDialogSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 8 - OpenFileDialog"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlRail.ResumeLayout(False)
        Me.pnlRule_pnlRail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selected As System.Windows.Forms.ListBox
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents pnlRail As System.Windows.Forms.Panel
    Friend WithEvents pnlRule_pnlRail As System.Windows.Forms.Panel
    Friend WithEvents lblTitle_pnlRail As System.Windows.Forms.Label
    Friend WithEvents lblSub_pnlRail As System.Windows.Forms.Label
    Friend WithEvents one As System.Windows.Forms.Button
    Friend WithEvents many As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
End Class
