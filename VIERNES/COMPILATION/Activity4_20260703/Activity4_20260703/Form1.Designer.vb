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

    Friend WithEvents pnlBanner As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblAuthorName As System.Windows.Forms.Label
    Friend WithEvents lblAuthorCourse As System.Windows.Forms.Label
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents lblInputTitle As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents txtN3 As System.Windows.Forms.TextBox
    Friend WithEvents lblInputNote As System.Windows.Forms.Label
    Friend WithEvents pnlOutput As System.Windows.Forms.Panel
    Friend WithEvents lblOutputTitle As System.Windows.Forms.Label
    Friend WithEvents lblSumCaption As System.Windows.Forms.Label
    Friend WithEvents lblDiffCaption As System.Windows.Forms.Label
    Friend WithEvents lblProdCaption As System.Windows.Forms.Label
    Friend WithEvents lblQuotCaption As System.Windows.Forms.Label
    Friend WithEvents lblAveCaption As System.Windows.Forms.Label
    Friend WithEvents lblSumValue As System.Windows.Forms.Label
    Friend WithEvents lblDiffValue As System.Windows.Forms.Label
    Friend WithEvents lblProdValue As System.Windows.Forms.Label
    Friend WithEvents lblQuotValue As System.Windows.Forms.Label
    Friend WithEvents lblAveValue As System.Windows.Forms.Label
    Friend WithEvents pnlActions As System.Windows.Forms.Panel
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents btnDifference As System.Windows.Forms.Button
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnQuotient As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblFooterAuthor As System.Windows.Forms.Label
    Friend WithEvents pnlRuleA As System.Windows.Forms.Panel
    Friend WithEvents pnlTileSum As System.Windows.Forms.Panel
    Friend WithEvents pnlTileDiff As System.Windows.Forms.Panel
    Friend WithEvents pnlTileProd As System.Windows.Forms.Panel
    Friend WithEvents pnlTileQuot As System.Windows.Forms.Panel
    Friend WithEvents pnlTileAve As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlBanner = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.lblAuthorCourse = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblInputTitle = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.txtN3 = New System.Windows.Forms.TextBox()
        Me.lblInputNote = New System.Windows.Forms.Label()
        Me.pnlOutput = New System.Windows.Forms.Panel()
        Me.lblOutputTitle = New System.Windows.Forms.Label()
        Me.lblSumCaption = New System.Windows.Forms.Label()
        Me.lblDiffCaption = New System.Windows.Forms.Label()
        Me.lblProdCaption = New System.Windows.Forms.Label()
        Me.lblQuotCaption = New System.Windows.Forms.Label()
        Me.lblAveCaption = New System.Windows.Forms.Label()
        Me.lblSumValue = New System.Windows.Forms.Label()
        Me.lblDiffValue = New System.Windows.Forms.Label()
        Me.lblProdValue = New System.Windows.Forms.Label()
        Me.lblQuotValue = New System.Windows.Forms.Label()
        Me.lblAveValue = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnDifference = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnQuotient = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFooterAuthor = New System.Windows.Forms.Label()
        Me.pnlRuleA = New System.Windows.Forms.Panel()
        Me.pnlTileSum = New System.Windows.Forms.Panel()
        Me.pnlTileDiff = New System.Windows.Forms.Panel()
        Me.pnlTileProd = New System.Windows.Forms.Panel()
        Me.pnlTileQuot = New System.Windows.Forms.Panel()
        Me.pnlTileAve = New System.Windows.Forms.Panel()
        Me.pnlBanner.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlOutput.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlRuleA.SuspendLayout()
        Me.pnlTileSum.SuspendLayout()
        Me.pnlTileDiff.SuspendLayout()
        Me.pnlTileProd.SuspendLayout()
        Me.pnlTileQuot.SuspendLayout()
        Me.pnlTileAve.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBanner
        '
        Me.pnlBanner.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlBanner.Controls.Add(Me.lblAuthorCourse)
        Me.pnlBanner.Controls.Add(Me.lblAuthorName)
        Me.pnlBanner.Controls.Add(Me.lblSubtitle)
        Me.pnlBanner.Controls.Add(Me.lblTitle)
        Me.pnlBanner.Controls.Add(Me.pnlRuleA)
        Me.pnlBanner.Controls.Add(Me.btnClear)
        Me.pnlBanner.Controls.Add(Me.btnExit)
        Me.pnlBanner.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBanner.Location = New System.Drawing.Point(0, 0)
        Me.pnlBanner.Name = "pnlBanner"
        Me.pnlBanner.Size = New System.Drawing.Size(250, 520)
        Me.pnlBanner.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblTitle.Location = New System.Drawing.Point(24, 44)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(204, 70)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Arithmetic Machine"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = False
        Me.lblSubtitle.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 122)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(204, 84)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Activity 4 - Act4_20260703  |  Sum, difference, product, quotient and average of three numbers"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAuthorName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthorName.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblAuthorName.Location = New System.Drawing.Point(24, 392)
        Me.lblAuthorName.AutoSize = False
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(204, 24)
        Me.lblAuthorName.TabIndex = 2
        Me.lblAuthorName.Text = "Viernes, Mark Syrel"
        Me.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblAuthorCourse
        '
        Me.lblAuthorCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAuthorCourse.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblAuthorCourse.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblAuthorCourse.Location = New System.Drawing.Point(24, 418)
        Me.lblAuthorCourse.AutoSize = False
        Me.lblAuthorCourse.Name = "lblAuthorCourse"
        Me.lblAuthorCourse.Size = New System.Drawing.Size(204, 40)
        Me.lblAuthorCourse.TabIndex = 3
        Me.lblAuthorCourse.Text = "BSIT 3B  |  Integrative Programming"
        Me.lblAuthorCourse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.lblInputNote)
        Me.pnlInput.Controls.Add(Me.txtN3)
        Me.pnlInput.Controls.Add(Me.txtN2)
        Me.pnlInput.Controls.Add(Me.txtN1)
        Me.pnlInput.Controls.Add(Me.lblThird)
        Me.pnlInput.Controls.Add(Me.lblSecond)
        Me.pnlInput.Controls.Add(Me.lblFirst)
        Me.pnlInput.Controls.Add(Me.lblInputTitle)
        Me.pnlInput.Location = New System.Drawing.Point(274, 24)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(602, 130)
        Me.pnlInput.TabIndex = 1
        '
        'lblInputTitle
        '
        Me.lblInputTitle.AutoSize = False
        Me.lblInputTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblInputTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblInputTitle.Name = "lblInputTitle"
        Me.lblInputTitle.Size = New System.Drawing.Size(300, 18)
        Me.lblInputTitle.TabIndex = 0
        Me.lblInputTitle.Text = "INPUT NUMBERS"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = False
        Me.lblFirst.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblFirst.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblFirst.Location = New System.Drawing.Point(18, 40)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(170, 20)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First number"
        '
        'txtN1
        '
        Me.txtN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN1.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.txtN1.Location = New System.Drawing.Point(18, 62)
        Me.txtN1.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtN1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(170, 28)
        Me.txtN1.TabIndex = 2
        Me.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = False
        Me.lblSecond.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblSecond.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblSecond.Location = New System.Drawing.Point(206, 40)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(170, 20)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Second number"
        '
        'txtN2
        '
        Me.txtN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.txtN2.Location = New System.Drawing.Point(206, 62)
        Me.txtN2.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtN2.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(170, 28)
        Me.txtN2.TabIndex = 4
        Me.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThird
        '
        Me.lblThird.AutoSize = False
        Me.lblThird.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblThird.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblThird.Location = New System.Drawing.Point(394, 40)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(170, 20)
        Me.lblThird.TabIndex = 5
        Me.lblThird.Text = "Third number"
        '
        'txtN3
        '
        Me.txtN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.txtN3.Location = New System.Drawing.Point(394, 62)
        Me.txtN3.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtN3.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(170, 28)
        Me.txtN3.TabIndex = 6
        Me.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInputNote
        '
        Me.lblInputNote.AutoSize = False
        Me.lblInputNote.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblInputNote.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblInputNote.Location = New System.Drawing.Point(18, 100)
        Me.lblInputNote.Name = "lblInputNote"
        Me.lblInputNote.Size = New System.Drawing.Size(560, 18)
        Me.lblInputNote.TabIndex = 7
        Me.lblInputNote.Text = "Whole numbers and decimal numbers are accepted."
        '
        'pnlOutput
        '
        Me.pnlOutput.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOutput.Controls.Add(Me.lblOutputTitle)
        Me.pnlOutput.Controls.Add(Me.pnlTileSum)
        Me.pnlOutput.Controls.Add(Me.pnlTileDiff)
        Me.pnlOutput.Controls.Add(Me.pnlTileProd)
        Me.pnlOutput.Controls.Add(Me.pnlTileQuot)
        Me.pnlOutput.Controls.Add(Me.pnlTileAve)
        Me.pnlOutput.Location = New System.Drawing.Point(274, 170)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(602, 168)
        Me.pnlOutput.TabIndex = 2
        '
        'lblOutputTitle
        '
        Me.lblOutputTitle.AutoSize = False
        Me.lblOutputTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutputTitle.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblOutputTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblOutputTitle.Name = "lblOutputTitle"
        Me.lblOutputTitle.Size = New System.Drawing.Size(300, 18)
        Me.lblOutputTitle.TabIndex = 0
        Me.lblOutputTitle.Text = "RESULTS"
        '
        'lblSumCaption
        '
        Me.lblSumCaption.AutoSize = False
        Me.lblSumCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblSumCaption.Location = New System.Drawing.Point(10, 10)
        Me.lblSumCaption.Name = "lblSumCaption"
        Me.lblSumCaption.Size = New System.Drawing.Size(86, 18)
        Me.lblSumCaption.TabIndex = 1
        Me.lblSumCaption.Text = "Sum"
        '
        'lblSumValue
        '
        Me.lblSumValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblSumValue.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumValue.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblSumValue.Location = New System.Drawing.Point(4, 40)
        Me.lblSumValue.AutoSize = False
        Me.lblSumValue.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblSumValue.Name = "lblSumValue"
        Me.lblSumValue.Size = New System.Drawing.Size(98, 52)
        Me.lblSumValue.TabIndex = 2
        Me.lblSumValue.Text = "-"
        Me.lblSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiffCaption
        '
        Me.lblDiffCaption.AutoSize = False
        Me.lblDiffCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiffCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblDiffCaption.Location = New System.Drawing.Point(10, 10)
        Me.lblDiffCaption.Name = "lblDiffCaption"
        Me.lblDiffCaption.Size = New System.Drawing.Size(86, 18)
        Me.lblDiffCaption.TabIndex = 3
        Me.lblDiffCaption.Text = "Difference"
        '
        'lblDiffValue
        '
        Me.lblDiffValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDiffValue.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiffValue.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblDiffValue.Location = New System.Drawing.Point(4, 40)
        Me.lblDiffValue.AutoSize = False
        Me.lblDiffValue.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblDiffValue.Name = "lblDiffValue"
        Me.lblDiffValue.Size = New System.Drawing.Size(98, 52)
        Me.lblDiffValue.TabIndex = 4
        Me.lblDiffValue.Text = "-"
        Me.lblDiffValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProdCaption
        '
        Me.lblProdCaption.AutoSize = False
        Me.lblProdCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProdCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblProdCaption.Location = New System.Drawing.Point(10, 10)
        Me.lblProdCaption.Name = "lblProdCaption"
        Me.lblProdCaption.Size = New System.Drawing.Size(86, 18)
        Me.lblProdCaption.TabIndex = 5
        Me.lblProdCaption.Text = "Product"
        '
        'lblProdValue
        '
        Me.lblProdValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblProdValue.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblProdValue.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblProdValue.Location = New System.Drawing.Point(4, 40)
        Me.lblProdValue.AutoSize = False
        Me.lblProdValue.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblProdValue.Name = "lblProdValue"
        Me.lblProdValue.Size = New System.Drawing.Size(98, 52)
        Me.lblProdValue.TabIndex = 6
        Me.lblProdValue.Text = "-"
        Me.lblProdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuotCaption
        '
        Me.lblQuotCaption.AutoSize = False
        Me.lblQuotCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotCaption.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblQuotCaption.Location = New System.Drawing.Point(10, 10)
        Me.lblQuotCaption.Name = "lblQuotCaption"
        Me.lblQuotCaption.Size = New System.Drawing.Size(86, 18)
        Me.lblQuotCaption.TabIndex = 7
        Me.lblQuotCaption.Text = "Quotient"
        '
        'lblQuotValue
        '
        Me.lblQuotValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblQuotValue.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotValue.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblQuotValue.Location = New System.Drawing.Point(4, 40)
        Me.lblQuotValue.AutoSize = False
        Me.lblQuotValue.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.lblQuotValue.Name = "lblQuotValue"
        Me.lblQuotValue.Size = New System.Drawing.Size(98, 52)
        Me.lblQuotValue.TabIndex = 8
        Me.lblQuotValue.Text = "-"
        Me.lblQuotValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAveCaption
        '
        Me.lblAveCaption.AutoSize = False
        Me.lblAveCaption.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveCaption.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblAveCaption.Location = New System.Drawing.Point(10, 10)
        Me.lblAveCaption.Name = "lblAveCaption"
        Me.lblAveCaption.Size = New System.Drawing.Size(86, 18)
        Me.lblAveCaption.TabIndex = 9
        Me.lblAveCaption.Text = "Average"
        '
        'lblAveValue
        '
        Me.lblAveValue.BackColor = System.Drawing.Color.FromArgb(16, 78, 60)
        Me.lblAveValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblAveValue.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveValue.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblAveValue.Location = New System.Drawing.Point(4, 40)
        Me.lblAveValue.AutoSize = False
        Me.lblAveValue.Name = "lblAveValue"
        Me.lblAveValue.Size = New System.Drawing.Size(98, 52)
        Me.lblAveValue.TabIndex = 10
        Me.lblAveValue.Text = "-"
        Me.lblAveValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlActions.Controls.Add(Me.btnAverage)
        Me.pnlActions.Controls.Add(Me.btnQuotient)
        Me.pnlActions.Controls.Add(Me.btnProduct)
        Me.pnlActions.Controls.Add(Me.btnDifference)
        Me.pnlActions.Controls.Add(Me.btnSum)
        Me.pnlActions.Location = New System.Drawing.Point(274, 354)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(602, 66)
        Me.pnlActions.TabIndex = 3
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnSum.FlatAppearance.BorderSize = 1
        Me.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSum.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSum.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnSum.Location = New System.Drawing.Point(0, 10)
        Me.btnSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(114, 42)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'btnDifference
        '
        Me.btnDifference.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnDifference.FlatAppearance.BorderSize = 1
        Me.btnDifference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDifference.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDifference.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnDifference.Location = New System.Drawing.Point(122, 10)
        Me.btnDifference.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnDifference.Name = "btnDifference"
        Me.btnDifference.Size = New System.Drawing.Size(114, 42)
        Me.btnDifference.TabIndex = 1
        Me.btnDifference.Text = "Difference"
        Me.btnDifference.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnProduct.FlatAppearance.BorderSize = 1
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnProduct.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnProduct.Location = New System.Drawing.Point(244, 10)
        Me.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(114, 42)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnQuotient
        '
        Me.btnQuotient.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.btnQuotient.FlatAppearance.BorderSize = 1
        Me.btnQuotient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotient.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuotient.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.btnQuotient.Location = New System.Drawing.Point(366, 10)
        Me.btnQuotient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnQuotient.Name = "btnQuotient"
        Me.btnQuotient.Size = New System.Drawing.Size(114, 42)
        Me.btnQuotient.TabIndex = 3
        Me.btnQuotient.Text = "Quotient"
        Me.btnQuotient.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnAverage.FlatAppearance.BorderSize = 1
        Me.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAverage.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAverage.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.btnAverage.Location = New System.Drawing.Point(488, 10)
        Me.btnAverage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(114, 42)
        Me.btnAverage.TabIndex = 4
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnClear.FlatAppearance.BorderSize = 1
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnClear.Location = New System.Drawing.Point(24, 318)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 36)
        Me.btnClear.TabIndex = 5
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
        Me.btnExit.Location = New System.Drawing.Point(128, 318)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(248, 113, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlFooter.Controls.Add(Me.lblFooterAuthor)
        Me.pnlFooter.Controls.Add(Me.lblStatus)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 486)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(900, 34)
        Me.pnlFooter.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblStatus.Location = New System.Drawing.Point(16, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(228, 15)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Ready. Enter three numbers to begin."
        '
        'lblFooterAuthor
        '
        Me.lblFooterAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooterAuthor.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.lblFooterAuthor.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblFooterAuthor.Location = New System.Drawing.Point(380, 9)
        Me.lblFooterAuthor.Name = "lblFooterAuthor"
        Me.lblFooterAuthor.Size = New System.Drawing.Size(250, 16)
        Me.lblFooterAuthor.TabIndex = 1
        Me.lblFooterAuthor.Text = "Viernes, Mark Syrel  |  BSIT 3B"
        Me.lblFooterAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlRuleA
        '
        Me.pnlRuleA.Location = New System.Drawing.Point(24, 28)
        Me.pnlRuleA.Size = New System.Drawing.Size(44, 4)
        Me.pnlRuleA.Name = "pnlRuleA"
        Me.pnlRuleA.TabIndex = 0
        Me.pnlRuleA.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        '
        'pnlTileSum
        '
        Me.pnlTileSum.Controls.Add(Me.lblSumCaption)
        Me.pnlTileSum.Controls.Add(Me.lblSumValue)
        Me.pnlTileSum.Location = New System.Drawing.Point(18, 42)
        Me.pnlTileSum.Size = New System.Drawing.Size(106, 108)
        Me.pnlTileSum.Name = "pnlTileSum"
        Me.pnlTileSum.TabIndex = 0
        Me.pnlTileSum.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        '
        'pnlTileDiff
        '
        Me.pnlTileDiff.Controls.Add(Me.lblDiffCaption)
        Me.pnlTileDiff.Controls.Add(Me.lblDiffValue)
        Me.pnlTileDiff.Location = New System.Drawing.Point(132, 42)
        Me.pnlTileDiff.Size = New System.Drawing.Size(106, 108)
        Me.pnlTileDiff.Name = "pnlTileDiff"
        Me.pnlTileDiff.TabIndex = 0
        Me.pnlTileDiff.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        '
        'pnlTileProd
        '
        Me.pnlTileProd.Controls.Add(Me.lblProdCaption)
        Me.pnlTileProd.Controls.Add(Me.lblProdValue)
        Me.pnlTileProd.Location = New System.Drawing.Point(246, 42)
        Me.pnlTileProd.Size = New System.Drawing.Size(106, 108)
        Me.pnlTileProd.Name = "pnlTileProd"
        Me.pnlTileProd.TabIndex = 0
        Me.pnlTileProd.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        '
        'pnlTileQuot
        '
        Me.pnlTileQuot.Controls.Add(Me.lblQuotCaption)
        Me.pnlTileQuot.Controls.Add(Me.lblQuotValue)
        Me.pnlTileQuot.Location = New System.Drawing.Point(360, 42)
        Me.pnlTileQuot.Size = New System.Drawing.Size(106, 108)
        Me.pnlTileQuot.Name = "pnlTileQuot"
        Me.pnlTileQuot.TabIndex = 0
        Me.pnlTileQuot.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        '
        'pnlTileAve
        '
        Me.pnlTileAve.Controls.Add(Me.lblAveCaption)
        Me.pnlTileAve.Controls.Add(Me.lblAveValue)
        Me.pnlTileAve.Location = New System.Drawing.Point(474, 42)
        Me.pnlTileAve.Size = New System.Drawing.Size(106, 108)
        Me.pnlTileAve.Name = "pnlTileAve"
        Me.pnlTileAve.TabIndex = 0
        Me.pnlTileAve.BackColor = System.Drawing.Color.FromArgb(16, 78, 60)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.ClientSize = New System.Drawing.Size(900, 520)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlOutput)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlBanner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 4 - Arithmetic Machine  |  Viernes, Mark Syrel"
        Me.pnlBanner.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.pnlOutput.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlRuleA.ResumeLayout(False)
        Me.pnlTileSum.ResumeLayout(False)
        Me.pnlTileDiff.ResumeLayout(False)
        Me.pnlTileProd.ResumeLayout(False)
        Me.pnlTileQuot.ResumeLayout(False)
        Me.pnlTileAve.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
