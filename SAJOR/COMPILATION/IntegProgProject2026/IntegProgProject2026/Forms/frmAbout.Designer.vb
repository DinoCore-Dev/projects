<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.pnlSideAbout = New System.Windows.Forms.Panel()
        Me.pnlRuleAbout = New System.Windows.Forms.Panel()
        Me.pnlQuote = New System.Windows.Forms.Panel()
        Me.pnlQuoteBar = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSideAbout.SuspendLayout()
        Me.pnlRuleAbout.SuspendLayout()
        Me.pnlQuote.SuspendLayout()
        Me.pnlQuoteBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PictureBox1.Location = New System.Drawing.Point(24, 28)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 322)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = False
        Me.lblName.Font = New System.Drawing.Font("Franklin Gothic Medium", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(314, 50)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(360, 36)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Sajor, Renz"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = False
        Me.lblCourse.Location = New System.Drawing.Point(314, 98)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.5!)
        Me.lblCourse.Size = New System.Drawing.Size(360, 22)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course/Year/Section: BSIT 3B"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = False
        Me.lblAddress.Location = New System.Drawing.Point(314, 128)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.lblAddress.Size = New System.Drawing.Size(360, 22)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address: Minagbag, Quezon, Isabela"
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = False
        Me.lblSkills.Location = New System.Drawing.Point(314, 156)
        Me.lblSkills.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblSkills.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.lblSkills.Size = New System.Drawing.Size(360, 22)
        Me.lblSkills.TabIndex = 4
        Me.lblSkills.Text = "Skills: Programmer"
        '
        'lblQuote
        '
        Me.lblQuote.Location = New System.Drawing.Point(20, 10)
        Me.lblQuote.AutoSize = False
        Me.lblQuote.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(330, 108)
        Me.lblQuote.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.5!, System.Drawing.FontStyle.Bold)
        Me.lblQuote.TabIndex = 5
        Me.lblQuote.Text = """Knowing is not enough; we must apply. Willing is not enough; we must do."" - Johann Wolfgang von Goethe"
        '
        'pnlSideAbout
        '
        Me.pnlSideAbout.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideAbout.Size = New System.Drawing.Size(290, 376)
        Me.pnlSideAbout.Name = "pnlSideAbout"
        Me.pnlSideAbout.TabIndex = 0
        Me.pnlSideAbout.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        '
        'pnlRuleAbout
        '
        Me.pnlRuleAbout.Location = New System.Drawing.Point(314, 36)
        Me.pnlRuleAbout.Size = New System.Drawing.Size(44, 4)
        Me.pnlRuleAbout.Name = "pnlRuleAbout"
        Me.pnlRuleAbout.TabIndex = 0
        Me.pnlRuleAbout.BackColor = System.Drawing.Color.FromArgb(224, 82, 67)
        '
        'pnlQuote
        '
        Me.pnlQuote.Controls.Add(Me.pnlQuoteBar)
        Me.pnlQuote.Controls.Add(Me.lblQuote)
        Me.pnlQuote.Location = New System.Drawing.Point(314, 222)
        Me.pnlQuote.Size = New System.Drawing.Size(362, 128)
        Me.pnlQuote.Name = "pnlQuote"
        Me.pnlQuote.TabIndex = 0
        Me.pnlQuote.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        '
        'pnlQuoteBar
        '
        Me.pnlQuoteBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlQuoteBar.Size = New System.Drawing.Size(5, 128)
        Me.pnlQuoteBar.Name = "pnlQuoteBar"
        Me.pnlQuoteBar.TabIndex = 0
        Me.pnlQuoteBar.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 376)
        Me.Controls.Add(Me.pnlSideAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.pnlRuleAbout)
        Me.Controls.Add(Me.pnlQuote)
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About - Sajor, Renz"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSideAbout.ResumeLayout(False)
        Me.pnlRuleAbout.ResumeLayout(False)
        Me.pnlQuote.ResumeLayout(False)
        Me.pnlQuoteBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSkills As System.Windows.Forms.Label
    Friend WithEvents lblQuote As System.Windows.Forms.Label
    Friend WithEvents pnlSideAbout As System.Windows.Forms.Panel
    Friend WithEvents pnlRuleAbout As System.Windows.Forms.Panel
    Friend WithEvents pnlQuote As System.Windows.Forms.Panel
    Friend WithEvents pnlQuoteBar As System.Windows.Forms.Panel

End Class
