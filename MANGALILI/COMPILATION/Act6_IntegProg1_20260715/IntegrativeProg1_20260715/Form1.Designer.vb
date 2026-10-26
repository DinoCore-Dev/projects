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
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblLeftTitle As System.Windows.Forms.Label
    Friend WithEvents lblG1Caption As System.Windows.Forms.Label
    Friend WithEvents lblG2Caption As System.Windows.Forms.Label
    Friend WithEvents lblG3Caption As System.Windows.Forms.Label
    Friend WithEvents txtG1 As System.Windows.Forms.TextBox
    Friend WithEvents txtG2 As System.Windows.Forms.TextBox
    Friend WithEvents txtG3 As System.Windows.Forms.TextBox
    Friend WithEvents lblLeftNote As System.Windows.Forms.Label
    Friend WithEvents lblLeftRule As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblAveCaption As System.Windows.Forms.Label
    Friend WithEvents pnlAveBadge As System.Windows.Forms.Panel
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblAveNote As System.Windows.Forms.Label
    Friend WithEvents lblR1Caption As System.Windows.Forms.Label
    Friend WithEvents lblR2Caption As System.Windows.Forms.Label
    Friend WithEvents lblR3Caption As System.Windows.Forms.Label
    Friend WithEvents lblRemarks1 As System.Windows.Forms.Label
    Friend WithEvents lblRemarks2 As System.Windows.Forms.Label
    Friend WithEvents lblRemarks3 As System.Windows.Forms.Label
    Friend WithEvents pnlActions As System.Windows.Forms.Panel
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblLeftRule = New System.Windows.Forms.Panel()
        Me.lblLeftNote = New System.Windows.Forms.Label()
        Me.txtG3 = New System.Windows.Forms.TextBox()
        Me.txtG2 = New System.Windows.Forms.TextBox()
        Me.txtG1 = New System.Windows.Forms.TextBox()
        Me.lblG3Caption = New System.Windows.Forms.Label()
        Me.lblG2Caption = New System.Windows.Forms.Label()
        Me.lblG1Caption = New System.Windows.Forms.Label()
        Me.lblLeftTitle = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblRemarks3 = New System.Windows.Forms.Label()
        Me.lblRemarks2 = New System.Windows.Forms.Label()
        Me.lblRemarks1 = New System.Windows.Forms.Label()
        Me.lblR3Caption = New System.Windows.Forms.Label()
        Me.lblR2Caption = New System.Windows.Forms.Label()
        Me.lblR1Caption = New System.Windows.Forms.Label()
        Me.lblAveNote = New System.Windows.Forms.Label()
        Me.pnlAveBadge = New System.Windows.Forms.Panel()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAveCaption = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlAveBadge.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(49, 46, 129)
        Me.pnlHeader.Controls.Add(Me.lblCourse)
        Me.pnlHeader.Controls.Add(Me.lblAuthor)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(920, 88)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(24, 14)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(287, 30)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Select Case Grade Evaluation"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.lblHeaderSub.Location = New System.Drawing.Point(26, 50)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(420, 15)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Activity 6 - Act6_IntegProg1_20260715  |  three grades evaluated with Select Case"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.White
        Me.lblAuthor.Location = New System.Drawing.Point(660, 20)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(236, 22)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Mangalili, Fhetz Jherald"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse
        '
        Me.lblCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(165, 180, 252)
        Me.lblCourse.Location = New System.Drawing.Point(660, 44)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(236, 20)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "BSIT 3B  |  Integrative Programming"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblLeftRule)
        Me.pnlLeft.Controls.Add(Me.lblLeftNote)
        Me.pnlLeft.Controls.Add(Me.txtG3)
        Me.pnlLeft.Controls.Add(Me.txtG2)
        Me.pnlLeft.Controls.Add(Me.txtG1)
        Me.pnlLeft.Controls.Add(Me.lblG3Caption)
        Me.pnlLeft.Controls.Add(Me.lblG2Caption)
        Me.pnlLeft.Controls.Add(Me.lblG1Caption)
        Me.pnlLeft.Controls.Add(Me.lblLeftTitle)
        Me.pnlLeft.Location = New System.Drawing.Point(24, 112)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(400, 384)
        Me.pnlLeft.TabIndex = 1
        '
        'lblLeftTitle
        '
        Me.lblLeftTitle.AutoSize = True
        Me.lblLeftTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLeftTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblLeftTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblLeftTitle.Name = "lblLeftTitle"
        Me.lblLeftTitle.Size = New System.Drawing.Size(90, 15)
        Me.lblLeftTitle.TabIndex = 0
        Me.lblLeftTitle.Text = "GRADE INPUTS"
        '
        'lblG1Caption
        '
        Me.lblG1Caption.AutoSize = True
        Me.lblG1Caption.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblG1Caption.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblG1Caption.Location = New System.Drawing.Point(18, 56)
        Me.lblG1Caption.Name = "lblG1Caption"
        Me.lblG1Caption.Size = New System.Drawing.Size(55, 19)
        Me.lblG1Caption.TabIndex = 1
        Me.lblG1Caption.Text = "Grade 1"
        '
        'txtG1
        '
        Me.txtG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtG1.Location = New System.Drawing.Point(120, 50)
        Me.txtG1.Name = "txtG1"
        Me.txtG1.Size = New System.Drawing.Size(252, 29)
        Me.txtG1.TabIndex = 2
        Me.txtG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblG2Caption
        '
        Me.lblG2Caption.AutoSize = True
        Me.lblG2Caption.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblG2Caption.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblG2Caption.Location = New System.Drawing.Point(18, 104)
        Me.lblG2Caption.Name = "lblG2Caption"
        Me.lblG2Caption.Size = New System.Drawing.Size(55, 19)
        Me.lblG2Caption.TabIndex = 3
        Me.lblG2Caption.Text = "Grade 2"
        '
        'txtG2
        '
        Me.txtG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtG2.Location = New System.Drawing.Point(120, 98)
        Me.txtG2.Name = "txtG2"
        Me.txtG2.Size = New System.Drawing.Size(252, 29)
        Me.txtG2.TabIndex = 4
        Me.txtG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblG3Caption
        '
        Me.lblG3Caption.AutoSize = True
        Me.lblG3Caption.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblG3Caption.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblG3Caption.Location = New System.Drawing.Point(18, 152)
        Me.lblG3Caption.Name = "lblG3Caption"
        Me.lblG3Caption.Size = New System.Drawing.Size(55, 19)
        Me.lblG3Caption.TabIndex = 5
        Me.lblG3Caption.Text = "Grade 3"
        '
        'txtG3
        '
        Me.txtG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtG3.Location = New System.Drawing.Point(120, 146)
        Me.txtG3.Name = "txtG3"
        Me.txtG3.Size = New System.Drawing.Size(252, 29)
        Me.txtG3.TabIndex = 6
        Me.txtG3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLeftNote
        '
        Me.lblLeftNote.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblLeftNote.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.lblLeftNote.Location = New System.Drawing.Point(18, 190)
        Me.lblLeftNote.Name = "lblLeftNote"
        Me.lblLeftNote.Size = New System.Drawing.Size(354, 40)
        Me.lblLeftNote.TabIndex = 7
        Me.lblLeftNote.Text = "Enter three grades from 0 to 100. The average is computed first, then three" & _
            " different Select Case blocks convert it into remarks."
        '
        'lblLeftRule
        '
        Me.lblLeftRule.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.lblLeftRule.Location = New System.Drawing.Point(18, 244)
        Me.lblLeftRule.Name = "lblLeftRule"
        Me.lblLeftRule.Size = New System.Drawing.Size(354, 1)
        Me.lblLeftRule.TabIndex = 8
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRight.Controls.Add(Me.lblRemarks3)
        Me.pnlRight.Controls.Add(Me.lblRemarks2)
        Me.pnlRight.Controls.Add(Me.lblRemarks1)
        Me.pnlRight.Controls.Add(Me.lblR3Caption)
        Me.pnlRight.Controls.Add(Me.lblR2Caption)
        Me.pnlRight.Controls.Add(Me.lblR1Caption)
        Me.pnlRight.Controls.Add(Me.lblAveNote)
        Me.pnlRight.Controls.Add(Me.pnlAveBadge)
        Me.pnlRight.Controls.Add(Me.lblAveCaption)
        Me.pnlRight.Location = New System.Drawing.Point(444, 112)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(452, 384)
        Me.pnlRight.TabIndex = 2
        '
        'lblAveCaption
        '
        Me.lblAveCaption.AutoSize = True
        Me.lblAveCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblAveCaption.Location = New System.Drawing.Point(18, 16)
        Me.lblAveCaption.Name = "lblAveCaption"
        Me.lblAveCaption.Size = New System.Drawing.Size(62, 15)
        Me.lblAveCaption.TabIndex = 0
        Me.lblAveCaption.Text = "AVERAGE"
        '
        'pnlAveBadge
        '
        Me.pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.pnlAveBadge.Controls.Add(Me.lblAverage)
        Me.pnlAveBadge.Location = New System.Drawing.Point(18, 36)
        Me.pnlAveBadge.Name = "pnlAveBadge"
        Me.pnlAveBadge.Size = New System.Drawing.Size(414, 108)
        Me.pnlAveBadge.TabIndex = 1
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAverage.Font = New System.Drawing.Font("Consolas", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblAverage.ForeColor = System.Drawing.Color.White
        Me.lblAverage.Location = New System.Drawing.Point(0, 0)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(414, 108)
        Me.lblAverage.TabIndex = 0
        Me.lblAverage.Text = "0.00"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAveNote
        '
        Me.lblAveNote.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblAveNote.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.lblAveNote.Location = New System.Drawing.Point(18, 150)
        Me.lblAveNote.Name = "lblAveNote"
        Me.lblAveNote.Size = New System.Drawing.Size(414, 20)
        Me.lblAveNote.TabIndex = 2
        Me.lblAveNote.Text = "Average of the three grades, rounded to two decimal places."
        '
        'lblR1Caption
        '
        Me.lblR1Caption.AutoSize = True
        Me.lblR1Caption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblR1Caption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105)
        Me.lblR1Caption.Location = New System.Drawing.Point(18, 186)
        Me.lblR1Caption.Name = "lblR1Caption"
        Me.lblR1Caption.Size = New System.Drawing.Size(220, 15)
        Me.lblR1Caption.TabIndex = 3
        Me.lblR1Caption.Text = "Remarks 1 - Passed / Conditional / Failed"
        '
        'lblRemarks1
        '
        Me.lblRemarks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74)
        Me.lblRemarks1.Location = New System.Drawing.Point(18, 204)
        Me.lblRemarks1.Name = "lblRemarks1"
        Me.lblRemarks1.Size = New System.Drawing.Size(414, 30)
        Me.lblRemarks1.TabIndex = 4
        Me.lblRemarks1.Text = "-"
        Me.lblRemarks1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblR2Caption
        '
        Me.lblR2Caption.AutoSize = True
        Me.lblR2Caption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblR2Caption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105)
        Me.lblR2Caption.Location = New System.Drawing.Point(18, 248)
        Me.lblR2Caption.Name = "lblR2Caption"
        Me.lblR2Caption.Size = New System.Drawing.Size(160, 15)
        Me.lblR2Caption.TabIndex = 5
        Me.lblR2Caption.Text = "Remarks 2 - Letter grade (A-F)"
        '
        'lblRemarks2
        '
        Me.lblRemarks2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks2.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.lblRemarks2.Location = New System.Drawing.Point(18, 266)
        Me.lblRemarks2.Name = "lblRemarks2"
        Me.lblRemarks2.Size = New System.Drawing.Size(414, 30)
        Me.lblRemarks2.TabIndex = 6
        Me.lblRemarks2.Text = "-"
        Me.lblRemarks2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblR3Caption
        '
        Me.lblR3Caption.AutoSize = True
        Me.lblR3Caption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblR3Caption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105)
        Me.lblR3Caption.Location = New System.Drawing.Point(18, 310)
        Me.lblR3Caption.Name = "lblR3Caption"
        Me.lblR3Caption.Size = New System.Drawing.Size(176, 15)
        Me.lblR3Caption.TabIndex = 7
        Me.lblR3Caption.Text = "Remarks 3 - Numeric rating"
        '
        'lblRemarks3
        '
        Me.lblRemarks3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks3.ForeColor = System.Drawing.Color.FromArgb(147, 51, 234)
        Me.lblRemarks3.Location = New System.Drawing.Point(18, 328)
        Me.lblRemarks3.Name = "lblRemarks3"
        Me.lblRemarks3.Size = New System.Drawing.Size(414, 30)
        Me.lblRemarks3.TabIndex = 8
        Me.lblRemarks3.Text = "-"
        Me.lblRemarks3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.White
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.lblStatus)
        Me.pnlActions.Controls.Add(Me.btnExit)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnEvaluate)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(0, 518)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(920, 62)
        Me.pnlActions.TabIndex = 3
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(79, 70, 229)
        Me.btnEvaluate.FlatAppearance.BorderSize = 0
        Me.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.White
        Me.btnEvaluate.Location = New System.Drawing.Point(24, 12)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(170, 38)
        Me.btnEvaluate.TabIndex = 0
        Me.btnEvaluate.Text = "Evaluate Grades"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.btnClear.Location = New System.Drawing.Point(204, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 38)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(324, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105)
        Me.lblStatus.Location = New System.Drawing.Point(456, 20)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(440, 22)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Ready. Enter the three grades."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.ClientSize = New System.Drawing.Size(920, 580)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 6 - Select Case Grade Evaluation  |  Mangalili, Fhetz Jherald"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlAveBadge.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
