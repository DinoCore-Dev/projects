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
    Friend WithEvents pnlRuleA As System.Windows.Forms.Panel

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
        Me.pnlRuleA = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlAveBadge.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlRuleA.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlHeader.Controls.Add(Me.lblCourse)
        Me.pnlHeader.Controls.Add(Me.lblAuthor)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.pnlRuleA)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(240, 600)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = False
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Corbel", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblHeaderTitle.Location = New System.Drawing.Point(24, 46)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(196, 96)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Select Case Grade Evaluation"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = False
        Me.lblHeaderSub.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblHeaderSub.Location = New System.Drawing.Point(24, 150)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(196, 80)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Activity 6 - Act6_IntegProg1_20260715  |  three grades evaluated with Select Case"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblAuthor.Location = New System.Drawing.Point(24, 486)
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(196, 24)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Viernes, Mark Syrel"
        Me.lblAuthor.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        '
        'lblCourse
        '
        Me.lblCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCourse.Location = New System.Drawing.Point(24, 512)
        Me.lblCourse.AutoSize = False
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(196, 40)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "BSIT 3B  |  Integrative Programming"
        Me.lblCourse.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
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
        Me.pnlLeft.Location = New System.Drawing.Point(264, 24)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(672, 140)
        Me.pnlLeft.TabIndex = 1
        '
        'lblLeftTitle
        '
        Me.lblLeftTitle.AutoSize = False
        Me.lblLeftTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLeftTitle.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblLeftTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblLeftTitle.Name = "lblLeftTitle"
        Me.lblLeftTitle.Size = New System.Drawing.Size(300, 18)
        Me.lblLeftTitle.TabIndex = 0
        Me.lblLeftTitle.Text = "GRADE INPUTS"
        '
        'lblG1Caption
        '
        Me.lblG1Caption.AutoSize = False
        Me.lblG1Caption.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblG1Caption.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblG1Caption.Location = New System.Drawing.Point(18, 38)
        Me.lblG1Caption.Name = "lblG1Caption"
        Me.lblG1Caption.Size = New System.Drawing.Size(196, 20)
        Me.lblG1Caption.TabIndex = 1
        Me.lblG1Caption.Text = "Grade 1"
        '
        'txtG1
        '
        Me.txtG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG1.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.txtG1.Location = New System.Drawing.Point(18, 60)
        Me.txtG1.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtG1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtG1.Name = "txtG1"
        Me.txtG1.Size = New System.Drawing.Size(198, 32)
        Me.txtG1.TabIndex = 2
        Me.txtG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblG2Caption
        '
        Me.lblG2Caption.AutoSize = False
        Me.lblG2Caption.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblG2Caption.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblG2Caption.Location = New System.Drawing.Point(236, 38)
        Me.lblG2Caption.Name = "lblG2Caption"
        Me.lblG2Caption.Size = New System.Drawing.Size(196, 20)
        Me.lblG2Caption.TabIndex = 3
        Me.lblG2Caption.Text = "Grade 2"
        '
        'txtG2
        '
        Me.txtG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG2.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.txtG2.Location = New System.Drawing.Point(236, 60)
        Me.txtG2.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtG2.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtG2.Name = "txtG2"
        Me.txtG2.Size = New System.Drawing.Size(198, 32)
        Me.txtG2.TabIndex = 4
        Me.txtG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblG3Caption
        '
        Me.lblG3Caption.AutoSize = False
        Me.lblG3Caption.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblG3Caption.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblG3Caption.Location = New System.Drawing.Point(454, 38)
        Me.lblG3Caption.Name = "lblG3Caption"
        Me.lblG3Caption.Size = New System.Drawing.Size(196, 20)
        Me.lblG3Caption.TabIndex = 5
        Me.lblG3Caption.Text = "Grade 3"
        '
        'txtG3
        '
        Me.txtG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG3.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.txtG3.Location = New System.Drawing.Point(454, 60)
        Me.txtG3.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtG3.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtG3.Name = "txtG3"
        Me.txtG3.Size = New System.Drawing.Size(198, 32)
        Me.txtG3.TabIndex = 6
        Me.txtG3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLeftNote
        '
        Me.lblLeftNote.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblLeftNote.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblLeftNote.Location = New System.Drawing.Point(18, 110)
        Me.lblLeftNote.AutoSize = False
        Me.lblLeftNote.Name = "lblLeftNote"
        Me.lblLeftNote.Size = New System.Drawing.Size(636, 22)
        Me.lblLeftNote.TabIndex = 7
        Me.lblLeftNote.Text = "Enter three grades from 0 to 100. The average is computed first, then three" & _
            " different Select Case blocks convert it into remarks."
        '
        'lblLeftRule
        '
        Me.lblLeftRule.BackColor = System.Drawing.Color.FromArgb(58, 65, 80)
        Me.lblLeftRule.Location = New System.Drawing.Point(18, 104)
        Me.lblLeftRule.Name = "lblLeftRule"
        Me.lblLeftRule.Size = New System.Drawing.Size(636, 1)
        Me.lblLeftRule.TabIndex = 8
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
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
        Me.pnlRight.Location = New System.Drawing.Point(264, 184)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(672, 330)
        Me.pnlRight.TabIndex = 2
        '
        'lblAveCaption
        '
        Me.lblAveCaption.AutoSize = False
        Me.lblAveCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblAveCaption.Location = New System.Drawing.Point(18, 14)
        Me.lblAveCaption.Name = "lblAveCaption"
        Me.lblAveCaption.Size = New System.Drawing.Size(200, 18)
        Me.lblAveCaption.TabIndex = 0
        Me.lblAveCaption.Text = "AVERAGE"
        '
        'pnlAveBadge
        '
        Me.pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(49, 38, 92)
        Me.pnlAveBadge.Controls.Add(Me.lblAverage)
        Me.pnlAveBadge.Location = New System.Drawing.Point(18, 40)
        Me.pnlAveBadge.Name = "pnlAveBadge"
        Me.pnlAveBadge.Size = New System.Drawing.Size(234, 190)
        Me.pnlAveBadge.TabIndex = 1
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAverage.Font = New System.Drawing.Font("Corbel", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblAverage.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.lblAverage.Location = New System.Drawing.Point(0, 0)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(414, 108)
        Me.lblAverage.TabIndex = 0
        Me.lblAverage.Text = "0.00"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAveNote
        '
        Me.lblAveNote.Font = New System.Drawing.Font("Corbel", 8.5!)
        Me.lblAveNote.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblAveNote.Location = New System.Drawing.Point(18, 240)
        Me.lblAveNote.AutoSize = False
        Me.lblAveNote.Name = "lblAveNote"
        Me.lblAveNote.Size = New System.Drawing.Size(234, 60)
        Me.lblAveNote.TabIndex = 2
        Me.lblAveNote.Text = "Average of the three grades, rounded to two decimal places."
        '
        'lblR1Caption
        '
        Me.lblR1Caption.AutoSize = False
        Me.lblR1Caption.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblR1Caption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblR1Caption.Location = New System.Drawing.Point(276, 14)
        Me.lblR1Caption.Name = "lblR1Caption"
        Me.lblR1Caption.Size = New System.Drawing.Size(380, 18)
        Me.lblR1Caption.TabIndex = 3
        Me.lblR1Caption.Text = "Remarks 1 - Passed / Conditional / Failed"
        '
        'lblRemarks1
        '
        Me.lblRemarks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks1.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblRemarks1.Location = New System.Drawing.Point(276, 38)
        Me.lblRemarks1.AutoSize = False
        Me.lblRemarks1.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblRemarks1.Name = "lblRemarks1"
        Me.lblRemarks1.Size = New System.Drawing.Size(380, 56)
        Me.lblRemarks1.TabIndex = 4
        Me.lblRemarks1.Text = "-"
        Me.lblRemarks1.TextAlign = System.Windows.Forms.ContentAlignment.MiddleCenter
        '
        'lblR2Caption
        '
        Me.lblR2Caption.AutoSize = False
        Me.lblR2Caption.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblR2Caption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblR2Caption.Location = New System.Drawing.Point(276, 118)
        Me.lblR2Caption.Name = "lblR2Caption"
        Me.lblR2Caption.Size = New System.Drawing.Size(380, 18)
        Me.lblR2Caption.TabIndex = 5
        Me.lblR2Caption.Text = "Remarks 2 - Letter grade (A-F)"
        '
        'lblRemarks2
        '
        Me.lblRemarks2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks2.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks2.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblRemarks2.Location = New System.Drawing.Point(276, 142)
        Me.lblRemarks2.AutoSize = False
        Me.lblRemarks2.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblRemarks2.Name = "lblRemarks2"
        Me.lblRemarks2.Size = New System.Drawing.Size(380, 56)
        Me.lblRemarks2.TabIndex = 6
        Me.lblRemarks2.Text = "-"
        Me.lblRemarks2.TextAlign = System.Windows.Forms.ContentAlignment.MiddleCenter
        '
        'lblR3Caption
        '
        Me.lblR3Caption.AutoSize = False
        Me.lblR3Caption.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblR3Caption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblR3Caption.Location = New System.Drawing.Point(276, 222)
        Me.lblR3Caption.Name = "lblR3Caption"
        Me.lblR3Caption.Size = New System.Drawing.Size(380, 18)
        Me.lblR3Caption.TabIndex = 7
        Me.lblR3Caption.Text = "Remarks 3 - Numeric rating"
        '
        'lblRemarks3
        '
        Me.lblRemarks3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks3.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks3.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblRemarks3.Location = New System.Drawing.Point(276, 246)
        Me.lblRemarks3.AutoSize = False
        Me.lblRemarks3.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblRemarks3.Name = "lblRemarks3"
        Me.lblRemarks3.Size = New System.Drawing.Size(380, 56)
        Me.lblRemarks3.TabIndex = 8
        Me.lblRemarks3.Text = "-"
        Me.lblRemarks3.TextAlign = System.Windows.Forms.ContentAlignment.MiddleCenter
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.lblStatus)
        Me.pnlActions.Controls.Add(Me.btnExit)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnEvaluate)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(0, 518)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(720, 64)
        Me.pnlActions.TabIndex = 3
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnEvaluate.FlatAppearance.BorderSize = 1
        Me.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluate.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.btnEvaluate.Location = New System.Drawing.Point(548, 12)
        Me.btnEvaluate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(156, 40)
        Me.btnEvaluate.TabIndex = 0
        Me.btnEvaluate.Text = "Evaluate Grades"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnClear.FlatAppearance.BorderSize = 1
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnClear.Location = New System.Drawing.Point(340, 12)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 40)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(47, 31, 36)
        Me.btnExit.FlatAppearance.BorderSize = 1
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(250, 163, 163)
        Me.btnExit.Location = New System.Drawing.Point(444, 12)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(248, 113, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblStatus.Location = New System.Drawing.Point(20, 22)
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(310, 20)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Ready. Enter the three grades."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRuleA
        '
        Me.pnlRuleA.Location = New System.Drawing.Point(24, 30)
        Me.pnlRuleA.Size = New System.Drawing.Size(44, 4)
        Me.pnlRuleA.Name = "pnlRuleA"
        Me.pnlRuleA.TabIndex = 0
        Me.pnlRuleA.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.ClientSize = New System.Drawing.Size(960, 600)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 6 - Select Case Grade Evaluation  |  Viernes, Mark Syrel"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlAveBadge.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.pnlRuleA.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
