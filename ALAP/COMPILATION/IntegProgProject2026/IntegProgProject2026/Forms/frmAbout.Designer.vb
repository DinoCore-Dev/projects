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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(338, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(150, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Alap, Adrian"
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(20, 56)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.lblCourse.Size = New System.Drawing.Size(120, 13)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course/Year/Section: BSIT 3B"
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(20, 104)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.lblAddress.Size = New System.Drawing.Size(160, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address: Casili, Mallig, Isabela"
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Location = New System.Drawing.Point(20, 80)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.lblSkills.Size = New System.Drawing.Size(140, 13)
        Me.lblSkills.TabIndex = 4
        Me.lblSkills.Text = "Skills: Programmer"
        Me.lblQuote.Location = New System.Drawing.Point(20, 132)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(300, 80)
        Me.lblQuote.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.TabIndex = 5
        Me.lblQuote.Text = """A journey of a thousand miles begins with a single step."" - Lao Tzu"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 248)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.lblQuote)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About - Alap, Adrian"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSkills As System.Windows.Forms.Label
    Friend WithEvents lblQuote As System.Windows.Forms.Label

End Class
