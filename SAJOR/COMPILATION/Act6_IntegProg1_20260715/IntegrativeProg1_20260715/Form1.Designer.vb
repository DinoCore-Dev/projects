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
    Friend WithEvents pnlRule_pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pnlTileR1 As System.Windows.Forms.Panel
    Friend WithEvents pnlTileR2 As System.Windows.Forms.Panel
    Friend WithEvents pnlTileR3 As System.Windows.Forms.Panel

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
        Me.pnlRule_pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlRight = New System.Windows.Forms.Panel()
        Me.pnlTileR1 = New System.Windows.Forms.Panel()
        Me.pnlTileR2 = New System.Windows.Forms.Panel()
        Me.pnlTileR3 = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlAveBadge.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlRule_pnlHeader.SuspendLayout()
        Me.pnlStrip_pnlLeft.SuspendLayout()
        Me.pnlStrip_pnlRight.SuspendLayout()
        Me.pnlTileR1.SuspendLayout()
        Me.pnlTileR2.SuspendLayout()
        Me.pnlTileR3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlHeader.Controls.Add(Me.lblCourse)
        Me.pnlHeader.Controls.Add(Me.lblAuthor)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.pnlRule_pnlHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(940, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = False
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblHeaderTitle.Location = New System.Drawing.Point(24, 10)
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(480, 32)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Select Case Grade Evaluation"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = False
        Me.lblHeaderSub.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblHeaderSub.Location = New System.Drawing.Point(24, 44)
        Me.lblHeaderSub.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(560, 18)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Activity 6 - Act6_IntegProg1_20260715  |  three grades evaluated with Select Case"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblAuthor.Location = New System.Drawing.Point(640, 12)
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(276, 24)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Sajor, Renz"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse
        '
        Me.lblCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblCourse.Location = New System.Drawing.Point(640, 40)
        Me.lblCourse.AutoSize = False
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(276, 18)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "BSIT 3B  |  Integrative Programming"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlLeft.Controls.Add(Me.lblLeftRule)
        Me.pnlLeft.Controls.Add(Me.lblLeftNote)
        Me.pnlLeft.Controls.Add(Me.txtG3)
        Me.pnlLeft.Controls.Add(Me.txtG2)
        Me.pnlLeft.Controls.Add(Me.txtG1)
        Me.pnlLeft.Controls.Add(Me.lblG3Caption)
        Me.pnlLeft.Controls.Add(Me.lblG2Caption)
        Me.pnlLeft.Controls.Add(Me.lblG1Caption)
        Me.pnlLeft.Controls.Add(Me.lblLeftTitle)
        Me.pnlLeft.Controls.Add(Me.pnlStrip_pnlLeft)
        Me.pnlLeft.Location = New System.Drawing.Point(20, 144)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(270, 428)
        Me.pnlLeft.TabIndex = 1
        '
        'lblLeftTitle
        '
        Me.lblLeftTitle.AutoSize = False
        Me.lblLeftTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLeftTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblLeftTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblLeftTitle.Name = "lblLeftTitle"
        Me.lblLeftTitle.Size = New System.Drawing.Size(230, 18)
        Me.lblLeftTitle.TabIndex = 0
        Me.lblLeftTitle.Text = "GRADE INPUTS"
        '
        'lblG1Caption
        '
        Me.lblG1Caption.AutoSize = False
        Me.lblG1Caption.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.lblG1Caption.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblG1Caption.Location = New System.Drawing.Point(18, 44)
        Me.lblG1Caption.Name = "lblG1Caption"
        Me.lblG1Caption.Size = New System.Drawing.Size(232, 20)
        Me.lblG1Caption.TabIndex = 1
        Me.lblG1Caption.Text = "Grade 1"
        '
        'txtG1
        '
        Me.txtG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!)
        Me.txtG1.Location = New System.Drawing.Point(18, 68)
        Me.txtG1.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtG1.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtG1.Name = "txtG1"
        Me.txtG1.Size = New System.Drawing.Size(232, 36)
        Me.txtG1.TabIndex = 2
        Me.txtG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblG2Caption
        '
        Me.lblG2Caption.AutoSize = False
        Me.lblG2Caption.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.lblG2Caption.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblG2Caption.Location = New System.Drawing.Point(18, 136)
        Me.lblG2Caption.Name = "lblG2Caption"
        Me.lblG2Caption.Size = New System.Drawing.Size(232, 20)
        Me.lblG2Caption.TabIndex = 3
        Me.lblG2Caption.Text = "Grade 2"
        '
        'txtG2
        '
        Me.txtG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!)
        Me.txtG2.Location = New System.Drawing.Point(18, 160)
        Me.txtG2.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtG2.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtG2.Name = "txtG2"
        Me.txtG2.Size = New System.Drawing.Size(232, 36)
        Me.txtG2.TabIndex = 4
        Me.txtG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblG3Caption
        '
        Me.lblG3Caption.AutoSize = False
        Me.lblG3Caption.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.lblG3Caption.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblG3Caption.Location = New System.Drawing.Point(18, 228)
        Me.lblG3Caption.Name = "lblG3Caption"
        Me.lblG3Caption.Size = New System.Drawing.Size(232, 20)
        Me.lblG3Caption.TabIndex = 5
        Me.lblG3Caption.Text = "Grade 3"
        '
        'txtG3
        '
        Me.txtG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG3.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!)
        Me.txtG3.Location = New System.Drawing.Point(18, 252)
        Me.txtG3.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtG3.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtG3.Name = "txtG3"
        Me.txtG3.Size = New System.Drawing.Size(232, 36)
        Me.txtG3.TabIndex = 6
        Me.txtG3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLeftNote
        '
        Me.lblLeftNote.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.5!)
        Me.lblLeftNote.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblLeftNote.Location = New System.Drawing.Point(18, 340)
        Me.lblLeftNote.AutoSize = False
        Me.lblLeftNote.Name = "lblLeftNote"
        Me.lblLeftNote.Size = New System.Drawing.Size(232, 70)
        Me.lblLeftNote.TabIndex = 7
        Me.lblLeftNote.Text = "Enter three grades from 0 to 100. The average is computed first, then three" & _
            " different Select Case blocks convert it into remarks."
        '
        'lblLeftRule
        '
        Me.lblLeftRule.BackColor = System.Drawing.Color.FromArgb(200, 204, 232)
        Me.lblLeftRule.Location = New System.Drawing.Point(18, 330)
        Me.lblLeftRule.Name = "lblLeftRule"
        Me.lblLeftRule.Size = New System.Drawing.Size(232, 1)
        Me.lblLeftRule.TabIndex = 8
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlRight.Controls.Add(Me.lblAveNote)
        Me.pnlRight.Controls.Add(Me.pnlAveBadge)
        Me.pnlRight.Controls.Add(Me.lblAveCaption)
        Me.pnlRight.Controls.Add(Me.pnlStrip_pnlRight)
        Me.pnlRight.Controls.Add(Me.pnlTileR1)
        Me.pnlRight.Controls.Add(Me.pnlTileR2)
        Me.pnlRight.Controls.Add(Me.pnlTileR3)
        Me.pnlRight.Location = New System.Drawing.Point(310, 144)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(610, 428)
        Me.pnlRight.TabIndex = 2
        '
        'lblAveCaption
        '
        Me.lblAveCaption.AutoSize = False
        Me.lblAveCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblAveCaption.Location = New System.Drawing.Point(18, 14)
        Me.lblAveCaption.Name = "lblAveCaption"
        Me.lblAveCaption.Size = New System.Drawing.Size(300, 18)
        Me.lblAveCaption.TabIndex = 0
        Me.lblAveCaption.Text = "AVERAGE"
        '
        'pnlAveBadge
        '
        Me.pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(43, 27, 75)
        Me.pnlAveBadge.Controls.Add(Me.lblAverage)
        Me.pnlAveBadge.Location = New System.Drawing.Point(18, 180)
        Me.pnlAveBadge.Name = "pnlAveBadge"
        Me.pnlAveBadge.Size = New System.Drawing.Size(574, 150)
        Me.pnlAveBadge.TabIndex = 1
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Font = New System.Drawing.Font("Franklin Gothic Medium", 54.0!, System.Drawing.FontStyle.Bold)
        Me.lblAverage.ForeColor = System.Drawing.Color.White
        Me.lblAverage.Location = New System.Drawing.Point(12, 14)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(550, 122)
        Me.lblAverage.TabIndex = 0
        Me.lblAverage.Text = "0.00"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAveNote
        '
        Me.lblAveNote.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblAveNote.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblAveNote.Location = New System.Drawing.Point(18, 346)
        Me.lblAveNote.AutoSize = False
        Me.lblAveNote.Name = "lblAveNote"
        Me.lblAveNote.Size = New System.Drawing.Size(574, 60)
        Me.lblAveNote.TabIndex = 2
        Me.lblAveNote.Text = "Average of the three grades, rounded to two decimal places."
        '
        'lblR1Caption
        '
        Me.lblR1Caption.AutoSize = False
        Me.lblR1Caption.Font = New System.Drawing.Font("Franklin Gothic Medium", 6.5!, System.Drawing.FontStyle.Bold)
        Me.lblR1Caption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblR1Caption.Location = New System.Drawing.Point(12, 10)
        Me.lblR1Caption.Name = "lblR1Caption"
        Me.lblR1Caption.Size = New System.Drawing.Size(164, 18)
        Me.lblR1Caption.TabIndex = 3
        Me.lblR1Caption.Text = "Remarks 1 - Passed / Conditional / Failed"
        '
        'lblRemarks1
        '
        Me.lblRemarks1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblRemarks1.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblRemarks1.Location = New System.Drawing.Point(6, 40)
        Me.lblRemarks1.AutoSize = False
        Me.lblRemarks1.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblRemarks1.Name = "lblRemarks1"
        Me.lblRemarks1.Size = New System.Drawing.Size(170, 64)
        Me.lblRemarks1.TabIndex = 4
        Me.lblRemarks1.Text = "-"
        Me.lblRemarks1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblR2Caption
        '
        Me.lblR2Caption.AutoSize = False
        Me.lblR2Caption.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblR2Caption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblR2Caption.Location = New System.Drawing.Point(12, 10)
        Me.lblR2Caption.Name = "lblR2Caption"
        Me.lblR2Caption.Size = New System.Drawing.Size(158, 18)
        Me.lblR2Caption.TabIndex = 5
        Me.lblR2Caption.Text = "Remarks 2 - Letter grade (A-F)"
        '
        'lblRemarks2
        '
        Me.lblRemarks2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblRemarks2.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks2.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblRemarks2.Location = New System.Drawing.Point(6, 40)
        Me.lblRemarks2.AutoSize = False
        Me.lblRemarks2.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblRemarks2.Name = "lblRemarks2"
        Me.lblRemarks2.Size = New System.Drawing.Size(170, 64)
        Me.lblRemarks2.TabIndex = 6
        Me.lblRemarks2.Text = "-"
        Me.lblRemarks2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblR3Caption
        '
        Me.lblR3Caption.AutoSize = False
        Me.lblR3Caption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblR3Caption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblR3Caption.Location = New System.Drawing.Point(12, 10)
        Me.lblR3Caption.Name = "lblR3Caption"
        Me.lblR3Caption.Size = New System.Drawing.Size(158, 18)
        Me.lblR3Caption.TabIndex = 7
        Me.lblR3Caption.Text = "Remarks 3 - Numeric rating"
        '
        'lblRemarks3
        '
        Me.lblRemarks3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblRemarks3.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks3.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblRemarks3.Location = New System.Drawing.Point(6, 40)
        Me.lblRemarks3.AutoSize = False
        Me.lblRemarks3.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblRemarks3.Name = "lblRemarks3"
        Me.lblRemarks3.Size = New System.Drawing.Size(170, 64)
        Me.lblRemarks3.TabIndex = 8
        Me.lblRemarks3.Text = "-"
        Me.lblRemarks3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.lblStatus)
        Me.pnlActions.Controls.Add(Me.btnExit)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnEvaluate)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActions.Location = New System.Drawing.Point(0, 518)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(940, 58)
        Me.pnlActions.TabIndex = 3
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnEvaluate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnEvaluate.FlatAppearance.BorderSize = 1
        Me.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluate.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnEvaluate.Location = New System.Drawing.Point(20, 9)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(150, 40)
        Me.btnEvaluate.TabIndex = 0
        Me.btnEvaluate.Text = "Evaluate Grades"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.btnClear.FlatAppearance.BorderSize = 1
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.btnClear.Location = New System.Drawing.Point(180, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(88, 20, 34)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 60, 90)
        Me.btnExit.FlatAppearance.BorderSize = 1
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(255, 214, 220)
        Me.btnExit.Location = New System.Drawing.Point(290, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblStatus.Location = New System.Drawing.Point(410, 19)
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(512, 20)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Ready. Enter the three grades."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlRule_pnlHeader
        '
        Me.pnlRule_pnlHeader.Location = New System.Drawing.Point(0, 66)
        Me.pnlRule_pnlHeader.Size = New System.Drawing.Size(940, 4)
        Me.pnlRule_pnlHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRule_pnlHeader.Name = "pnlRule_pnlHeader"
        Me.pnlRule_pnlHeader.TabIndex = 0
        Me.pnlRule_pnlHeader.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'pnlStrip_pnlLeft
        '
        Me.pnlStrip_pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlLeft.Size = New System.Drawing.Size(270, 3)
        Me.pnlStrip_pnlLeft.Name = "pnlStrip_pnlLeft"
        Me.pnlStrip_pnlLeft.TabIndex = 0
        Me.pnlStrip_pnlLeft.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'pnlStrip_pnlRight
        '
        Me.pnlStrip_pnlRight.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlRight.Size = New System.Drawing.Size(610, 3)
        Me.pnlStrip_pnlRight.Name = "pnlStrip_pnlRight"
        Me.pnlStrip_pnlRight.TabIndex = 0
        Me.pnlStrip_pnlRight.BackColor = System.Drawing.Color.FromArgb(14, 116, 144)
        '
        'pnlTileR1
        '
        Me.pnlTileR1.Controls.Add(Me.lblR1Caption)
        Me.pnlTileR1.Controls.Add(Me.lblRemarks1)
        Me.pnlTileR1.Location = New System.Drawing.Point(18, 42)
        Me.pnlTileR1.Size = New System.Drawing.Size(182, 118)
        Me.pnlTileR1.Name = "pnlTileR1"
        Me.pnlTileR1.TabIndex = 0
        Me.pnlTileR1.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlTileR2
        '
        Me.pnlTileR2.Controls.Add(Me.lblR2Caption)
        Me.pnlTileR2.Controls.Add(Me.lblRemarks2)
        Me.pnlTileR2.Location = New System.Drawing.Point(212, 42)
        Me.pnlTileR2.Size = New System.Drawing.Size(182, 118)
        Me.pnlTileR2.Name = "pnlTileR2"
        Me.pnlTileR2.TabIndex = 0
        Me.pnlTileR2.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlTileR3
        '
        Me.pnlTileR3.Controls.Add(Me.lblR3Caption)
        Me.pnlTileR3.Controls.Add(Me.lblRemarks3)
        Me.pnlTileR3.Location = New System.Drawing.Point(406, 42)
        Me.pnlTileR3.Size = New System.Drawing.Size(182, 118)
        Me.pnlTileR3.Name = "pnlTileR3"
        Me.pnlTileR3.TabIndex = 0
        Me.pnlTileR3.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.ClientSize = New System.Drawing.Size(940, 600)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 6 - Select Case Grade Evaluation  |  Sajor, Renz"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlAveBadge.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.pnlRule_pnlHeader.ResumeLayout(False)
        Me.pnlStrip_pnlLeft.ResumeLayout(False)
        Me.pnlStrip_pnlRight.ResumeLayout(False)
        Me.pnlTileR1.ResumeLayout(False)
        Me.pnlTileR2.ResumeLayout(False)
        Me.pnlTileR3.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
