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
        Me.pnlRail.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlRail.Controls.Add(Me.lblRailCourse)
        Me.pnlRail.Controls.Add(Me.lblRailAuthor)
        Me.pnlRail.Controls.Add(Me.lblRailBadge)
        Me.pnlRail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRail.Location = New System.Drawing.Point(0, 0)
        Me.pnlRail.Name = "pnlRail"
        Me.pnlRail.Size = New System.Drawing.Size(820, 64)
        Me.pnlRail.TabIndex = 0
        '
        'lblRailBadge
        '
        Me.lblRailBadge.AutoSize = False
        Me.lblRailBadge.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailBadge.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.lblRailBadge.Location = New System.Drawing.Point(480, 24)
        Me.lblRailBadge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRailBadge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRailBadge.Name = "lblRailBadge"
        Me.lblRailBadge.Size = New System.Drawing.Size(316, 18)
        Me.lblRailBadge.TabIndex = 0
        Me.lblRailBadge.Text = "ACTIVITY 5  •  TERNARY"
        '
        'lblRailTitle
        '
        Me.lblRailTitle.Font = New System.Drawing.Font("Corbel", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailTitle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblRailTitle.Location = New System.Drawing.Point(40, 40)
        Me.lblRailTitle.AutoSize = False
        Me.lblRailTitle.Name = "lblRailTitle"
        Me.lblRailTitle.Size = New System.Drawing.Size(740, 44)
        Me.lblRailTitle.TabIndex = 1
        Me.lblRailTitle.Text = "Grade Remark Evaluator"
        '
        'pnlRailRule
        '
        Me.pnlRailRule.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.pnlRailRule.Location = New System.Drawing.Point(40, 28)
        Me.pnlRailRule.Name = "pnlRailRule"
        Me.pnlRailRule.Size = New System.Drawing.Size(44, 4)
        Me.pnlRailRule.TabIndex = 2
        '
        'lblRailText
        '
        Me.lblRailText.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblRailText.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblRailText.Location = New System.Drawing.Point(40, 88)
        Me.lblRailText.AutoSize = False
        Me.lblRailText.Name = "lblRailText"
        Me.lblRailText.Size = New System.Drawing.Size(720, 40)
        Me.lblRailText.TabIndex = 3
        Me.lblRailText.Text = "This form uses the ternary If operator to decide the remarks, the letter grade and" & _
            " the numeric rating of one average grade." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
            "Every result is produced by a single nested If expression."
        '
        'lblRailAuthor
        '
        Me.lblRailAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRailAuthor.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRailAuthor.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblRailAuthor.Location = New System.Drawing.Point(24, 11)
        Me.lblRailAuthor.AutoSize = False
        Me.lblRailAuthor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailAuthor.Name = "lblRailAuthor"
        Me.lblRailAuthor.Size = New System.Drawing.Size(360, 24)
        Me.lblRailAuthor.TabIndex = 4
        Me.lblRailAuthor.Text = "Viernes, Mark Syrel"
        '
        'lblRailCourse
        '
        Me.lblRailCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRailCourse.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblRailCourse.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblRailCourse.Location = New System.Drawing.Point(24, 36)
        Me.lblRailCourse.AutoSize = False
        Me.lblRailCourse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRailCourse.Name = "lblRailCourse"
        Me.lblRailCourse.Size = New System.Drawing.Size(360, 20)
        Me.lblRailCourse.TabIndex = 5
        Me.lblRailCourse.Text = "BSIT 3B  |  Integrative Programming"
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
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
        Me.pnlBody.Controls.Add(Me.pnlRailRule)
        Me.pnlBody.Controls.Add(Me.lblRailTitle)
        Me.pnlBody.Controls.Add(Me.lblRailText)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(260, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(560, 560)
        Me.pnlBody.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = False
        Me.lblHeading.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblHeading.Location = New System.Drawing.Point(40, 150)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(300, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Enter the average"
        '
        'lblHint
        '
        Me.lblHint.AutoSize = False
        Me.lblHint.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblHint.Location = New System.Drawing.Point(40, 182)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(300, 36)
        Me.lblHint.TabIndex = 1
        Me.lblHint.Text = "Type a grade from 0 to 100, then click Evaluate."
        '
        'pnlEntry
        '
        Me.pnlEntry.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEntry.Controls.Add(Me.btnEvaluate)
        Me.pnlEntry.Controls.Add(Me.txtAverage)
        Me.pnlEntry.Controls.Add(Me.lblAverageCaption)
        Me.pnlEntry.Location = New System.Drawing.Point(360, 138)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(420, 86)
        Me.pnlEntry.TabIndex = 2
        '
        'lblAverageCaption
        '
        Me.lblAverageCaption.AutoSize = False
        Me.lblAverageCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAverageCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblAverageCaption.Location = New System.Drawing.Point(16, 10)
        Me.lblAverageCaption.Name = "lblAverageCaption"
        Me.lblAverageCaption.Size = New System.Drawing.Size(200, 18)
        Me.lblAverageCaption.TabIndex = 0
        Me.lblAverageCaption.Text = "AVERAGE GRADE"
        '
        'txtAverage
        '
        Me.txtAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAverage.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtAverage.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtAverage.Location = New System.Drawing.Point(16, 36)
        Me.txtAverage.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(170, 36)
        Me.txtAverage.TabIndex = 1
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnEvaluate.FlatAppearance.BorderSize = 1
        Me.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluate.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.btnEvaluate.Location = New System.Drawing.Point(198, 36)
        Me.btnEvaluate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(206, 36)
        Me.btnEvaluate.TabIndex = 2
        Me.btnEvaluate.Text = "Evaluate Remarks"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'lblCardsHeading
        '
        Me.lblCardsHeading.AutoSize = False
        Me.lblCardsHeading.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardsHeading.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCardsHeading.Location = New System.Drawing.Point(40, 238)
        Me.lblCardsHeading.Name = "lblCardsHeading"
        Me.lblCardsHeading.Size = New System.Drawing.Size(300, 18)
        Me.lblCardsHeading.TabIndex = 3
        Me.lblCardsHeading.Text = "TERM RESULTS"
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard1.Controls.Add(Me.lblCard1Note)
        Me.pnlCard1.Controls.Add(Me.lblCard1Value)
        Me.pnlCard1.Controls.Add(Me.lblCard1Title)
        Me.pnlCard1.Location = New System.Drawing.Point(40, 260)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(232, 124)
        Me.pnlCard1.TabIndex = 4
        '
        'lblCard1Title
        '
        Me.lblCard1Title.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCard1Title.Location = New System.Drawing.Point(16, 12)
        Me.lblCard1Title.AutoSize = False
        Me.lblCard1Title.Name = "lblCard1Title"
        Me.lblCard1Title.Size = New System.Drawing.Size(200, 18)
        Me.lblCard1Title.TabIndex = 0
        Me.lblCard1Title.Text = "REMARKS 1"
        '
        'lblCard1Value
        '
        Me.lblCard1Value.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblCard1Value.Location = New System.Drawing.Point(8, 36)
        Me.lblCard1Value.AutoSize = False
        Me.lblCard1Value.Name = "lblCard1Value"
        Me.lblCard1Value.Size = New System.Drawing.Size(216, 56)
        Me.lblCard1Value.TabIndex = 1
        Me.lblCard1Value.Text = "--"
        Me.lblCard1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard1Note
        '
        Me.lblCard1Note.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblCard1Note.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCard1Note.Location = New System.Drawing.Point(16, 98)
        Me.lblCard1Note.AutoSize = False
        Me.lblCard1Note.Name = "lblCard1Note"
        Me.lblCard1Note.Size = New System.Drawing.Size(200, 18)
        Me.lblCard1Note.TabIndex = 2
        Me.lblCard1Note.Text = "passed / failed"
        Me.lblCard1Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard2.Controls.Add(Me.lblCard2Note)
        Me.pnlCard2.Controls.Add(Me.lblCard2Value)
        Me.pnlCard2.Controls.Add(Me.lblCard2Title)
        Me.pnlCard2.Location = New System.Drawing.Point(284, 260)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(232, 124)
        Me.pnlCard2.TabIndex = 5
        '
        'lblCard2Title
        '
        Me.lblCard2Title.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCard2Title.Location = New System.Drawing.Point(16, 12)
        Me.lblCard2Title.AutoSize = False
        Me.lblCard2Title.Name = "lblCard2Title"
        Me.lblCard2Title.Size = New System.Drawing.Size(200, 18)
        Me.lblCard2Title.TabIndex = 0
        Me.lblCard2Title.Text = "REMARKS 2"
        '
        'lblCard2Value
        '
        Me.lblCard2Value.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblCard2Value.Location = New System.Drawing.Point(8, 36)
        Me.lblCard2Value.AutoSize = False
        Me.lblCard2Value.Name = "lblCard2Value"
        Me.lblCard2Value.Size = New System.Drawing.Size(216, 56)
        Me.lblCard2Value.TabIndex = 1
        Me.lblCard2Value.Text = "--"
        Me.lblCard2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard2Note
        '
        Me.lblCard2Note.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblCard2Note.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCard2Note.Location = New System.Drawing.Point(16, 98)
        Me.lblCard2Note.AutoSize = False
        Me.lblCard2Note.Name = "lblCard2Note"
        Me.lblCard2Note.Size = New System.Drawing.Size(200, 18)
        Me.lblCard2Note.TabIndex = 2
        Me.lblCard2Note.Text = "letter grade"
        Me.lblCard2Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard3.Controls.Add(Me.lblCard3Note)
        Me.pnlCard3.Controls.Add(Me.lblCard3Value)
        Me.pnlCard3.Controls.Add(Me.lblCard3Title)
        Me.pnlCard3.Location = New System.Drawing.Point(528, 260)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(232, 124)
        Me.pnlCard3.TabIndex = 6
        '
        'lblCard3Title
        '
        Me.lblCard3Title.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCard3Title.Location = New System.Drawing.Point(16, 12)
        Me.lblCard3Title.AutoSize = False
        Me.lblCard3Title.Name = "lblCard3Title"
        Me.lblCard3Title.Size = New System.Drawing.Size(200, 18)
        Me.lblCard3Title.TabIndex = 0
        Me.lblCard3Title.Text = "REMARKS 3"
        '
        'lblCard3Value
        '
        Me.lblCard3Value.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard3Value.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblCard3Value.Location = New System.Drawing.Point(8, 36)
        Me.lblCard3Value.AutoSize = False
        Me.lblCard3Value.Name = "lblCard3Value"
        Me.lblCard3Value.Size = New System.Drawing.Size(216, 56)
        Me.lblCard3Value.TabIndex = 1
        Me.lblCard3Value.Text = "--"
        Me.lblCard3Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard3Note
        '
        Me.lblCard3Note.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblCard3Note.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblCard3Note.Location = New System.Drawing.Point(16, 98)
        Me.lblCard3Note.AutoSize = False
        Me.lblCard3Note.Name = "lblCard3Note"
        Me.lblCard3Note.Size = New System.Drawing.Size(200, 18)
        Me.lblCard3Note.TabIndex = 2
        Me.lblCard3Note.Text = "numeric rating"
        Me.lblCard3Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(38, 43, 55)
        Me.pnlInfo.Controls.Add(Me.lblInfoText)
        Me.pnlInfo.Controls.Add(Me.lblInfoTitle)
        Me.pnlInfo.Location = New System.Drawing.Point(40, 398)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(480, 60)
        Me.pnlInfo.TabIndex = 7
        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.AutoSize = False
        Me.lblInfoTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblInfoTitle.Location = New System.Drawing.Point(14, 8)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.Size = New System.Drawing.Size(440, 18)
        Me.lblInfoTitle.TabIndex = 0
        Me.lblInfoTitle.Text = "Ternary reminder"
        '
        'lblInfoText
        '
        Me.lblInfoText.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblInfoText.Location = New System.Drawing.Point(14, 28)
        Me.lblInfoText.AutoSize = False
        Me.lblInfoText.Name = "lblInfoText"
        Me.lblInfoText.Size = New System.Drawing.Size(456, 28)
        Me.lblInfoText.TabIndex = 1
        Me.lblInfoText.Text = "If(condition, valueWhenTrue, valueWhenFalse).  A nested ternary If checks the next" & _
            " range whenever the first condition is False, which replaces a long block of If-Else statements."
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnClear.FlatAppearance.BorderSize = 1
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnClear.Location = New System.Drawing.Point(540, 404)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 46)
        Me.btnClear.TabIndex = 8
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
        Me.btnExit.Location = New System.Drawing.Point(660, 404)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(248, 113, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 46)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblStatus.Location = New System.Drawing.Point(40, 466)
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(740, 20)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Waiting for an average grade."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlRail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 5 - Ternary Remarks  |  Viernes, Mark Syrel"
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
