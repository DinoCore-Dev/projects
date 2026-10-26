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

    Friend WithEvents pnlRail As System.Windows.Forms.Panel
    Friend WithEvents lblRailBadge As System.Windows.Forms.Label
    Friend WithEvents lblRailTitle As System.Windows.Forms.Label
    Friend WithEvents pnlRailRule As System.Windows.Forms.Panel
    Friend WithEvents lblRailText As System.Windows.Forms.Label
    Friend WithEvents lblRailAuthor As System.Windows.Forms.Label
    Friend WithEvents lblRailCourse As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents pnlEntry As System.Windows.Forms.Panel
    Friend WithEvents lblAverageCaption As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
    Friend WithEvents lblCardsHeading As System.Windows.Forms.Label
    Friend WithEvents pnlCard1 As System.Windows.Forms.Panel
    Friend WithEvents lblCard1Title As System.Windows.Forms.Label
    Friend WithEvents lblCard1Value As System.Windows.Forms.Label
    Friend WithEvents lblCard1Note As System.Windows.Forms.Label
    Friend WithEvents pnlCard2 As System.Windows.Forms.Panel
    Friend WithEvents lblCard2Title As System.Windows.Forms.Label
    Friend WithEvents lblCard2Value As System.Windows.Forms.Label
    Friend WithEvents lblCard2Note As System.Windows.Forms.Label
    Friend WithEvents pnlCard3 As System.Windows.Forms.Panel
    Friend WithEvents lblCard3Title As System.Windows.Forms.Label
    Friend WithEvents lblCard3Value As System.Windows.Forms.Label
    Friend WithEvents lblCard3Note As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblInfoText As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlRail = New System.Windows.Forms.Panel()
        Me.lblRailCourse = New System.Windows.Forms.Label()
        Me.lblRailAuthor = New System.Windows.Forms.Label()
        Me.lblRailText = New System.Windows.Forms.Label()
        Me.pnlRailRule = New System.Windows.Forms.Panel()
        Me.lblRailTitle = New System.Windows.Forms.Label()
        Me.lblRailBadge = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblInfoText = New System.Windows.Forms.Label()
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.lblCard3Note = New System.Windows.Forms.Label()
        Me.lblCard3Value = New System.Windows.Forms.Label()
        Me.lblCard3Title = New System.Windows.Forms.Label()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblCard2Note = New System.Windows.Forms.Label()
        Me.lblCard2Value = New System.Windows.Forms.Label()
        Me.lblCard2Title = New System.Windows.Forms.Label()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblCard1Note = New System.Windows.Forms.Label()
        Me.lblCard1Value = New System.Windows.Forms.Label()
        Me.lblCard1Title = New System.Windows.Forms.Label()
        Me.lblCardsHeading = New System.Windows.Forms.Label()
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lblAverageCaption = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.pnlRail.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRail
        '
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(16, 26, 14)
        Me.pnlRail.Controls.Add(Me.lblRailCourse)
        Me.pnlRail.Controls.Add(Me.lblRailAuthor)
        Me.pnlRail.Controls.Add(Me.lblRailText)
        Me.pnlRail.Controls.Add(Me.pnlRailRule)
        Me.pnlRail.Controls.Add(Me.lblRailTitle)
        Me.pnlRail.Controls.Add(Me.lblRailBadge)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRail.Location = New System.Drawing.Point(0, 0)
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.Size = New System.Drawing.Size(260, 560)
        Me.pnlRail.TabIndex = 0
        '
        'lblRailBadge
        '
        Me.lblRailBadge.AutoSize = True
        Me.lblRailBadge.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailBadge.ForeColor = System.Drawing.Color.FromArgb(79, 202, 55)
        Me.lblRailBadge.Location = New System.Drawing.Point(24, 198)
        Me.lblRailBadge.Name = "lblRailBadge"
        Me.lblRailBadge.Size = New System.Drawing.Size(118, 13)
        Me.lblRailBadge.TabIndex = 0
        Me.lblRailBadge.Text = "ACTIVITY 5  •  TERNARY"
        '
        'lblRailTitle
        '
        Me.lblRailTitle.Font = New System.Drawing.Font("Trebuchet MS", 19.5!, System.Drawing.FontStyle.Bold)
        Me.lblRailTitle.ForeColor = System.Drawing.Color.White
        Me.lblRailTitle.Location = New System.Drawing.Point(20, 220)
        Me.lblRailTitle.Name = "lblRailTitle"
        Me.lblRailTitle.Size = New System.Drawing.Size(216, 78)
        Me.lblRailTitle.TabIndex = 1
        Me.lblRailTitle.Text = "Grade Remark Evaluator"
        '
        'pnlRailRule
        '
        Me.pnlRailRule.BackColor = System.Drawing.Color.FromArgb(79, 202, 55)
        Me.pnlRailRule.Location = New System.Drawing.Point(24, 310)
        Me.pnlRailRule.Name = "pnlRailRule"
        Me.pnlRailRule.Size = New System.Drawing.Size(90, 3)
        Me.pnlRailRule.TabIndex = 2
        '
        'lblRailText
        '
        Me.lblRailText.Font = New System.Drawing.Font("Trebuchet MS", 8.75!)
        Me.lblRailText.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblRailText.Location = New System.Drawing.Point(24, 330)
        Me.lblRailText.Name = "lblRailText"
        Me.lblRailText.Size = New System.Drawing.Size(206, 190)
        Me.lblRailText.TabIndex = 3
        Me.lblRailText.Text = "This form uses the ternary If operator to decide the remarks, the letter grade and" & _
            " the numeric rating of one average grade." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
            "Every result is produced by a single nested If expression."
        '
        'lblRailAuthor
        '
        Me.lblRailAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRailAuthor.Font = New System.Drawing.Font("Trebuchet MS", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblRailAuthor.ForeColor = System.Drawing.Color.White
        Me.lblRailAuthor.Location = New System.Drawing.Point(24, 30)
        Me.lblRailAuthor.Name = "lblRailAuthor"
        Me.lblRailAuthor.Size = New System.Drawing.Size(212, 22)
        Me.lblRailAuthor.TabIndex = 4
        Me.lblRailAuthor.Text = "Gaudan, Darwin"
        '
        'lblRailCourse
        '
        Me.lblRailCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRailCourse.Font = New System.Drawing.Font("Trebuchet MS", 8.75!)
        Me.lblRailCourse.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblRailCourse.Location = New System.Drawing.Point(24, 54)
        Me.lblRailCourse.Name = "lblRailCourse"
        Me.lblRailCourse.Size = New System.Drawing.Size(212, 20)
        Me.lblRailCourse.TabIndex = 5
        Me.lblRailCourse.Text = "BSIT 3B  |  Integrative Programming"
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 250, 248)
        Me.pnlBody.Controls.Add(Me.lblStatus)
        Me.pnlBody.Controls.Add(Me.btnExit)
        Me.pnlBody.Controls.Add(Me.btnClear)
        Me.pnlBody.Controls.Add(Me.pnlInfo)
        Me.pnlBody.Controls.Add(Me.pnlCard3)
        Me.pnlBody.Controls.Add(Me.pnlCard2)
        Me.pnlBody.Controls.Add(Me.pnlCard1)
        Me.pnlBody.Controls.Add(Me.lblCardsHeading)
        Me.pnlBody.Controls.Add(Me.pnlEntry)
        Me.pnlBody.Controls.Add(Me.lblHint)
        Me.pnlBody.Controls.Add(Me.lblHeading)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(260, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(560, 560)
        Me.pnlBody.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(16, 26, 14)
        Me.lblHeading.Location = New System.Drawing.Point(24, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(196, 30)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Enter the average"
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Trebuchet MS", 8.75!)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(101, 120, 98)
        Me.lblHint.Location = New System.Drawing.Point(27, 56)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(270, 15)
        Me.lblHint.TabIndex = 1
        Me.lblHint.Text = "Type a grade from 0 to 100, then click Evaluate."
        '
        'pnlEntry
        '
        Me.pnlEntry.BackColor = System.Drawing.Color.White
        Me.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEntry.Controls.Add(Me.btnEvaluate)
        Me.pnlEntry.Controls.Add(Me.txtAverage)
        Me.pnlEntry.Controls.Add(Me.lblAverageCaption)
        Me.pnlEntry.Location = New System.Drawing.Point(24, 84)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(512, 96)
        Me.pnlEntry.TabIndex = 2
        '
        'lblAverageCaption
        '
        Me.lblAverageCaption.AutoSize = True
        Me.lblAverageCaption.Font = New System.Drawing.Font("Trebuchet MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblAverageCaption.ForeColor = System.Drawing.Color.FromArgb(101, 120, 98)
        Me.lblAverageCaption.Location = New System.Drawing.Point(18, 16)
        Me.lblAverageCaption.Name = "lblAverageCaption"
        Me.lblAverageCaption.Size = New System.Drawing.Size(112, 15)
        Me.lblAverageCaption.TabIndex = 0
        Me.lblAverageCaption.Text = "AVERAGE GRADE"
        '
        'txtAverage
        '
        Me.txtAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAverage.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Bold)
        Me.txtAverage.ForeColor = System.Drawing.Color.FromArgb(16, 26, 14)
        Me.txtAverage.Location = New System.Drawing.Point(18, 42)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(230, 32)
        Me.txtAverage.TabIndex = 1
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(8, 14, 7)
        Me.btnEvaluate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(111, 117, 110)
        Me.btnEvaluate.FlatAppearance.BorderSize = 2
        Me.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluate.Font = New System.Drawing.Font("Trebuchet MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.btnEvaluate.Location = New System.Drawing.Point(266, 40)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(226, 36)
        Me.btnEvaluate.TabIndex = 2
        Me.btnEvaluate.Text = "Evaluate Remarks"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'lblCardsHeading
        '
        Me.lblCardsHeading.AutoSize = True
        Me.lblCardsHeading.Font = New System.Drawing.Font("Trebuchet MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblCardsHeading.ForeColor = System.Drawing.Color.FromArgb(101, 120, 98)
        Me.lblCardsHeading.Location = New System.Drawing.Point(24, 294)
        Me.lblCardsHeading.Name = "lblCardsHeading"
        Me.lblCardsHeading.Size = New System.Drawing.Size(88, 15)
        Me.lblCardsHeading.TabIndex = 3
        Me.lblCardsHeading.Text = "TERM RESULTS"
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.White
        Me.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard1.Controls.Add(Me.lblCard1Note)
        Me.pnlCard1.Controls.Add(Me.lblCard1Value)
        Me.pnlCard1.Controls.Add(Me.lblCard1Title)
        Me.pnlCard1.Location = New System.Drawing.Point(24, 316)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(160, 122)
        Me.pnlCard1.TabIndex = 4
        '
        'lblCard1Title
        '
        Me.lblCard1Title.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblCard1Title.Location = New System.Drawing.Point(12, 10)
        Me.lblCard1Title.Name = "lblCard1Title"
        Me.lblCard1Title.Size = New System.Drawing.Size(136, 16)
        Me.lblCard1Title.TabIndex = 0
        Me.lblCard1Title.Text = "REMARKS 1"
        '
        'lblCard1Value
        '
        Me.lblCard1Value.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74)
        Me.lblCard1Value.Location = New System.Drawing.Point(10, 34)
        Me.lblCard1Value.Name = "lblCard1Value"
        Me.lblCard1Value.Size = New System.Drawing.Size(140, 54)
        Me.lblCard1Value.TabIndex = 1
        Me.lblCard1Value.Text = "--"
        Me.lblCard1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard1Note
        '
        Me.lblCard1Note.Font = New System.Drawing.Font("Trebuchet MS", 7.25!)
        Me.lblCard1Note.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblCard1Note.Location = New System.Drawing.Point(12, 94)
        Me.lblCard1Note.Name = "lblCard1Note"
        Me.lblCard1Note.Size = New System.Drawing.Size(136, 16)
        Me.lblCard1Note.TabIndex = 2
        Me.lblCard1Note.Text = "passed / failed"
        Me.lblCard1Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.White
        Me.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard2.Controls.Add(Me.lblCard2Note)
        Me.pnlCard2.Controls.Add(Me.lblCard2Value)
        Me.pnlCard2.Controls.Add(Me.lblCard2Title)
        Me.pnlCard2.Location = New System.Drawing.Point(194, 316)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(160, 122)
        Me.pnlCard2.TabIndex = 5
        '
        'lblCard2Title
        '
        Me.lblCard2Title.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblCard2Title.Location = New System.Drawing.Point(12, 10)
        Me.lblCard2Title.Name = "lblCard2Title"
        Me.lblCard2Title.Size = New System.Drawing.Size(136, 16)
        Me.lblCard2Title.TabIndex = 0
        Me.lblCard2Title.Text = "REMARKS 2"
        '
        'lblCard2Value
        '
        Me.lblCard2Value.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(53, 123, 39)
        Me.lblCard2Value.Location = New System.Drawing.Point(10, 34)
        Me.lblCard2Value.Name = "lblCard2Value"
        Me.lblCard2Value.Size = New System.Drawing.Size(140, 54)
        Me.lblCard2Value.TabIndex = 1
        Me.lblCard2Value.Text = "--"
        Me.lblCard2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard2Note
        '
        Me.lblCard2Note.Font = New System.Drawing.Font("Trebuchet MS", 7.25!)
        Me.lblCard2Note.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblCard2Note.Location = New System.Drawing.Point(12, 94)
        Me.lblCard2Note.Name = "lblCard2Note"
        Me.lblCard2Note.Size = New System.Drawing.Size(136, 16)
        Me.lblCard2Note.TabIndex = 2
        Me.lblCard2Note.Text = "letter grade"
        Me.lblCard2Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.White
        Me.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard3.Controls.Add(Me.lblCard3Note)
        Me.pnlCard3.Controls.Add(Me.lblCard3Value)
        Me.pnlCard3.Controls.Add(Me.lblCard3Title)
        Me.pnlCard3.Location = New System.Drawing.Point(364, 316)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(172, 122)
        Me.pnlCard3.TabIndex = 6
        '
        'lblCard3Title
        '
        Me.lblCard3Title.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblCard3Title.Location = New System.Drawing.Point(12, 10)
        Me.lblCard3Title.Name = "lblCard3Title"
        Me.lblCard3Title.Size = New System.Drawing.Size(148, 16)
        Me.lblCard3Title.TabIndex = 0
        Me.lblCard3Title.Text = "REMARKS 3"
        '
        'lblCard3Value
        '
        Me.lblCard3Value.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblCard3Value.ForeColor = System.Drawing.Color.FromArgb(147, 51, 234)
        Me.lblCard3Value.Location = New System.Drawing.Point(10, 34)
        Me.lblCard3Value.Name = "lblCard3Value"
        Me.lblCard3Value.Size = New System.Drawing.Size(152, 54)
        Me.lblCard3Value.TabIndex = 1
        Me.lblCard3Value.Text = "--"
        Me.lblCard3Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard3Note
        '
        Me.lblCard3Note.Font = New System.Drawing.Font("Trebuchet MS", 7.25!)
        Me.lblCard3Note.ForeColor = System.Drawing.Color.FromArgb(147, 167, 142)
        Me.lblCard3Note.Location = New System.Drawing.Point(12, 94)
        Me.lblCard3Note.Name = "lblCard3Note"
        Me.lblCard3Note.Size = New System.Drawing.Size(148, 16)
        Me.lblCard3Note.TabIndex = 2
        Me.lblCard3Note.Text = "numeric rating"
        Me.lblCard3Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(205, 242, 197)
        Me.pnlInfo.Controls.Add(Me.lblInfoText)
        Me.pnlInfo.Controls.Add(Me.lblInfoTitle)
        Me.pnlInfo.Location = New System.Drawing.Point(24, 198)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(512, 82)
        Me.pnlInfo.TabIndex = 7
        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.AutoSize = True
        Me.lblInfoTitle.Font = New System.Drawing.Font("Trebuchet MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(39, 64, 35)
        Me.lblInfoTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.Size = New System.Drawing.Size(95, 15)
        Me.lblInfoTitle.TabIndex = 0
        Me.lblInfoTitle.Text = "Ternary reminder"
        '
        'lblInfoText
        '
        Me.lblInfoText.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(39, 64, 35)
        Me.lblInfoText.Location = New System.Drawing.Point(16, 32)
        Me.lblInfoText.Name = "lblInfoText"
        Me.lblInfoText.Size = New System.Drawing.Size(478, 40)
        Me.lblInfoText.TabIndex = 1
        Me.lblInfoText.Text = "If(condition, valueWhenTrue, valueWhenFalse).  A nested ternary If checks the next" & _
            " range whenever the first condition is False, which replaces a long block of If-Else statements."
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(225, 234, 223)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(168, 175, 167)
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 43, 29)
        Me.btnClear.Location = New System.Drawing.Point(160, 456)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 38)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(121, 20, 20)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(234, 124, 124)
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.btnExit.Location = New System.Drawing.Point(24, 456)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 38)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Trebuchet MS", 8.75!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(73, 88, 70)
        Me.lblStatus.Location = New System.Drawing.Point(24, 508)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(512, 34)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Waiting for an average grade."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(248, 250, 248)
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlRail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 5 - Ternary Remarks  |  Gaudan, Darwin"
        Me.pnlRail.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlEntry.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
