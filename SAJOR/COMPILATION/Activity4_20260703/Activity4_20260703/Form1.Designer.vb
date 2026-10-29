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
    Friend WithEvents pnlRule_pnlBanner As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlInput As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlOutput As System.Windows.Forms.Panel
    Friend WithEvents pnlTileSum As System.Windows.Forms.Panel
    Friend WithEvents pnlTileDiff As System.Windows.Forms.Panel
    Friend WithEvents pnlTileProd As System.Windows.Forms.Panel
    Friend WithEvents pnlTileQuot As System.Windows.Forms.Panel
    Friend WithEvents pnlTileAve As System.Windows.Forms.Panel
    Friend WithEvents pnlStrip_pnlActions As System.Windows.Forms.Panel
    Friend WithEvents lblActionsTitle As System.Windows.Forms.Label

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
        Me.pnlRule_pnlBanner = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlInput = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlOutput = New System.Windows.Forms.Panel()
        Me.pnlTileSum = New System.Windows.Forms.Panel()
        Me.pnlTileDiff = New System.Windows.Forms.Panel()
        Me.pnlTileProd = New System.Windows.Forms.Panel()
        Me.pnlTileQuot = New System.Windows.Forms.Panel()
        Me.pnlTileAve = New System.Windows.Forms.Panel()
        Me.pnlStrip_pnlActions = New System.Windows.Forms.Panel()
        Me.lblActionsTitle = New System.Windows.Forms.Label()
        Me.pnlBanner.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlOutput.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlRule_pnlBanner.SuspendLayout()
        Me.pnlStrip_pnlInput.SuspendLayout()
        Me.pnlStrip_pnlOutput.SuspendLayout()
        Me.pnlTileSum.SuspendLayout()
        Me.pnlTileDiff.SuspendLayout()
        Me.pnlTileProd.SuspendLayout()
        Me.pnlTileQuot.SuspendLayout()
        Me.pnlTileAve.SuspendLayout()
        Me.pnlStrip_pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBanner
        '
        Me.pnlBanner.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlBanner.Controls.Add(Me.lblAuthorCourse)
        Me.pnlBanner.Controls.Add(Me.lblAuthorName)
        Me.pnlBanner.Controls.Add(Me.lblSubtitle)
        Me.pnlBanner.Controls.Add(Me.lblTitle)
        Me.pnlBanner.Controls.Add(Me.pnlRule_pnlBanner)
        Me.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBanner.Location = New System.Drawing.Point(0, 0)
        Me.pnlBanner.Name = "pnlBanner"
        Me.pnlBanner.Size = New System.Drawing.Size(900, 72)
        Me.pnlBanner.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblTitle.Location = New System.Drawing.Point(24, 10)
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(440, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Arithmetic Machine"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = False
        Me.lblSubtitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 44)
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(640, 18)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Activity 4 - Act4_20260703  |  Sum, difference, product, quotient and average of three numbers"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthorName.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAuthorName.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblAuthorName.Location = New System.Drawing.Point(580, 12)
        Me.lblAuthorName.AutoSize = False
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(296, 24)
        Me.lblAuthorName.TabIndex = 2
        Me.lblAuthorName.Text = "Sajor, Renz"
        Me.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAuthorCourse
        '
        Me.lblAuthorCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthorCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblAuthorCourse.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblAuthorCourse.Location = New System.Drawing.Point(580, 40)
        Me.lblAuthorCourse.AutoSize = False
        Me.lblAuthorCourse.Name = "lblAuthorCourse"
        Me.lblAuthorCourse.Size = New System.Drawing.Size(296, 18)
        Me.lblAuthorCourse.TabIndex = 3
        Me.lblAuthorCourse.Text = "BSIT 3B  |  Integrative Programming"
        Me.lblAuthorCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlInput.Controls.Add(Me.lblInputNote)
        Me.pnlInput.Controls.Add(Me.txtN3)
        Me.pnlInput.Controls.Add(Me.txtN2)
        Me.pnlInput.Controls.Add(Me.txtN1)
        Me.pnlInput.Controls.Add(Me.lblThird)
        Me.pnlInput.Controls.Add(Me.lblSecond)
        Me.pnlInput.Controls.Add(Me.lblFirst)
        Me.pnlInput.Controls.Add(Me.lblInputTitle)
        Me.pnlInput.Controls.Add(Me.pnlStrip_pnlInput)
        Me.pnlInput.Location = New System.Drawing.Point(20, 88)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(250, 380)
        Me.pnlInput.TabIndex = 1
        '
        'lblInputTitle
        '
        Me.lblInputTitle.AutoSize = False
        Me.lblInputTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblInputTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblInputTitle.Name = "lblInputTitle"
        Me.lblInputTitle.Size = New System.Drawing.Size(218, 18)
        Me.lblInputTitle.TabIndex = 0
        Me.lblInputTitle.Text = "INPUT NUMBERS"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = False
        Me.lblFirst.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!)
        Me.lblFirst.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblFirst.Location = New System.Drawing.Point(16, 46)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(218, 18)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First number"
        '
        'txtN1
        '
        Me.txtN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN1.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.txtN1.Location = New System.Drawing.Point(16, 68)
        Me.txtN1.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtN1.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(218, 32)
        Me.txtN1.TabIndex = 2
        Me.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = False
        Me.lblSecond.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!)
        Me.lblSecond.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblSecond.Location = New System.Drawing.Point(16, 134)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(218, 18)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Second number"
        '
        'txtN2
        '
        Me.txtN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN2.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.txtN2.Location = New System.Drawing.Point(16, 156)
        Me.txtN2.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtN2.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(218, 32)
        Me.txtN2.TabIndex = 4
        Me.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThird
        '
        Me.lblThird.AutoSize = False
        Me.lblThird.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!)
        Me.lblThird.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblThird.Location = New System.Drawing.Point(16, 222)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(218, 18)
        Me.lblThird.TabIndex = 5
        Me.lblThird.Text = "Third number"
        '
        'txtN3
        '
        Me.txtN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN3.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.txtN3.Location = New System.Drawing.Point(16, 244)
        Me.txtN3.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtN3.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(218, 32)
        Me.txtN3.TabIndex = 6
        Me.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInputNote
        '
        Me.lblInputNote.AutoSize = False
        Me.lblInputNote.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.5!)
        Me.lblInputNote.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblInputNote.Location = New System.Drawing.Point(16, 316)
        Me.lblInputNote.Name = "lblInputNote"
        Me.lblInputNote.Size = New System.Drawing.Size(218, 48)
        Me.lblInputNote.TabIndex = 7
        Me.lblInputNote.Text = "Whole numbers and decimal numbers are accepted."
        '
        'pnlOutput
        '
        Me.pnlOutput.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlOutput.Controls.Add(Me.lblOutputTitle)
        Me.pnlOutput.Controls.Add(Me.pnlStrip_pnlOutput)
        Me.pnlOutput.Controls.Add(Me.pnlTileSum)
        Me.pnlOutput.Controls.Add(Me.pnlTileDiff)
        Me.pnlOutput.Controls.Add(Me.pnlTileProd)
        Me.pnlOutput.Controls.Add(Me.pnlTileQuot)
        Me.pnlOutput.Controls.Add(Me.pnlTileAve)
        Me.pnlOutput.Location = New System.Drawing.Point(286, 88)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(328, 380)
        Me.pnlOutput.TabIndex = 2
        '
        'lblOutputTitle
        '
        Me.lblOutputTitle.AutoSize = False
        Me.lblOutputTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutputTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblOutputTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblOutputTitle.Name = "lblOutputTitle"
        Me.lblOutputTitle.Size = New System.Drawing.Size(296, 18)
        Me.lblOutputTitle.TabIndex = 0
        Me.lblOutputTitle.Text = "RESULTS"
        '
        'lblSumCaption
        '
        Me.lblSumCaption.AutoSize = False
        Me.lblSumCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSumCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblSumCaption.Location = New System.Drawing.Point(12, 12)
        Me.lblSumCaption.Name = "lblSumCaption"
        Me.lblSumCaption.Size = New System.Drawing.Size(124, 18)
        Me.lblSumCaption.TabIndex = 1
        Me.lblSumCaption.Text = "Sum"
        '
        'lblSumValue
        '
        Me.lblSumValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblSumValue.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumValue.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblSumValue.Location = New System.Drawing.Point(4, 48)
        Me.lblSumValue.AutoSize = False
        Me.lblSumValue.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblSumValue.Name = "lblSumValue"
        Me.lblSumValue.Size = New System.Drawing.Size(140, 60)
        Me.lblSumValue.TabIndex = 2
        Me.lblSumValue.Text = "-"
        Me.lblSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiffCaption
        '
        Me.lblDiffCaption.AutoSize = False
        Me.lblDiffCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblDiffCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblDiffCaption.Location = New System.Drawing.Point(12, 12)
        Me.lblDiffCaption.Name = "lblDiffCaption"
        Me.lblDiffCaption.Size = New System.Drawing.Size(124, 18)
        Me.lblDiffCaption.TabIndex = 3
        Me.lblDiffCaption.Text = "Difference"
        '
        'lblDiffValue
        '
        Me.lblDiffValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDiffValue.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiffValue.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblDiffValue.Location = New System.Drawing.Point(4, 48)
        Me.lblDiffValue.AutoSize = False
        Me.lblDiffValue.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblDiffValue.Name = "lblDiffValue"
        Me.lblDiffValue.Size = New System.Drawing.Size(140, 60)
        Me.lblDiffValue.TabIndex = 4
        Me.lblDiffValue.Text = "-"
        Me.lblDiffValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProdCaption
        '
        Me.lblProdCaption.AutoSize = False
        Me.lblProdCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblProdCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblProdCaption.Location = New System.Drawing.Point(12, 12)
        Me.lblProdCaption.Name = "lblProdCaption"
        Me.lblProdCaption.Size = New System.Drawing.Size(124, 18)
        Me.lblProdCaption.TabIndex = 5
        Me.lblProdCaption.Text = "Product"
        '
        'lblProdValue
        '
        Me.lblProdValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblProdValue.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblProdValue.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblProdValue.Location = New System.Drawing.Point(4, 48)
        Me.lblProdValue.AutoSize = False
        Me.lblProdValue.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblProdValue.Name = "lblProdValue"
        Me.lblProdValue.Size = New System.Drawing.Size(140, 60)
        Me.lblProdValue.TabIndex = 6
        Me.lblProdValue.Text = "-"
        Me.lblProdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuotCaption
        '
        Me.lblQuotCaption.AutoSize = False
        Me.lblQuotCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblQuotCaption.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblQuotCaption.Location = New System.Drawing.Point(12, 12)
        Me.lblQuotCaption.Name = "lblQuotCaption"
        Me.lblQuotCaption.Size = New System.Drawing.Size(124, 18)
        Me.lblQuotCaption.TabIndex = 7
        Me.lblQuotCaption.Text = "Quotient"
        '
        'lblQuotValue
        '
        Me.lblQuotValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblQuotValue.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotValue.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblQuotValue.Location = New System.Drawing.Point(4, 48)
        Me.lblQuotValue.AutoSize = False
        Me.lblQuotValue.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.lblQuotValue.Name = "lblQuotValue"
        Me.lblQuotValue.Size = New System.Drawing.Size(140, 60)
        Me.lblQuotValue.TabIndex = 8
        Me.lblQuotValue.Text = "-"
        Me.lblQuotValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAveCaption
        '
        Me.lblAveCaption.AutoSize = False
        Me.lblAveCaption.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblAveCaption.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.lblAveCaption.Location = New System.Drawing.Point(14, 16)
        Me.lblAveCaption.Name = "lblAveCaption"
        Me.lblAveCaption.Size = New System.Drawing.Size(110, 20)
        Me.lblAveCaption.TabIndex = 9
        Me.lblAveCaption.Text = "Average"
        '
        'lblAveValue
        '
        Me.lblAveValue.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblAveValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblAveValue.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveValue.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.lblAveValue.Location = New System.Drawing.Point(120, 6)
        Me.lblAveValue.AutoSize = False
        Me.lblAveValue.Name = "lblAveValue"
        Me.lblAveValue.Size = New System.Drawing.Size(176, 40)
        Me.lblAveValue.TabIndex = 10
        Me.lblAveValue.Text = "-"
        Me.lblAveValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlActions.Controls.Add(Me.btnExit)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnAverage)
        Me.pnlActions.Controls.Add(Me.btnQuotient)
        Me.pnlActions.Controls.Add(Me.btnProduct)
        Me.pnlActions.Controls.Add(Me.btnDifference)
        Me.pnlActions.Controls.Add(Me.btnSum)
        Me.pnlActions.Controls.Add(Me.pnlStrip_pnlActions)
        Me.pnlActions.Controls.Add(Me.lblActionsTitle)
        Me.pnlActions.Location = New System.Drawing.Point(630, 88)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(250, 380)
        Me.pnlActions.TabIndex = 3
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnSum.FlatAppearance.BorderSize = 1
        Me.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSum.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSum.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnSum.Location = New System.Drawing.Point(16, 42)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(218, 40)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'btnDifference
        '
        Me.btnDifference.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnDifference.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnDifference.FlatAppearance.BorderSize = 1
        Me.btnDifference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDifference.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDifference.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnDifference.Location = New System.Drawing.Point(16, 92)
        Me.btnDifference.Name = "btnDifference"
        Me.btnDifference.Size = New System.Drawing.Size(218, 40)
        Me.btnDifference.TabIndex = 1
        Me.btnDifference.Text = "Difference"
        Me.btnDifference.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnProduct.FlatAppearance.BorderSize = 1
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnProduct.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnProduct.Location = New System.Drawing.Point(16, 142)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(218, 40)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnQuotient
        '
        Me.btnQuotient.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.btnQuotient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.btnQuotient.FlatAppearance.BorderSize = 1
        Me.btnQuotient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotient.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuotient.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.btnQuotient.Location = New System.Drawing.Point(16, 192)
        Me.btnQuotient.Name = "btnQuotient"
        Me.btnQuotient.Size = New System.Drawing.Size(218, 40)
        Me.btnQuotient.TabIndex = 3
        Me.btnQuotient.Text = "Quotient"
        Me.btnQuotient.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.btnAverage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.btnAverage.FlatAppearance.BorderSize = 1
        Me.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAverage.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAverage.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.btnAverage.Location = New System.Drawing.Point(16, 242)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(218, 40)
        Me.btnAverage.TabIndex = 4
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.btnClear.FlatAppearance.BorderSize = 1
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.btnClear.Location = New System.Drawing.Point(16, 306)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 44)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(88, 20, 34)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 60, 90)
        Me.btnExit.FlatAppearance.BorderSize = 1
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(255, 214, 220)
        Me.btnExit.Location = New System.Drawing.Point(130, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.pnlFooter.Controls.Add(Me.lblFooterAuthor)
        Me.pnlFooter.Controls.Add(Me.lblStatus)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 486)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(900, 36)
        Me.pnlFooter.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblStatus.Location = New System.Drawing.Point(16, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(520, 18)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Ready. Enter three numbers to begin."
        '
        'lblFooterAuthor
        '
        Me.lblFooterAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooterAuthor.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblFooterAuthor.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblFooterAuthor.Location = New System.Drawing.Point(580, 9)
        Me.lblFooterAuthor.AutoSize = False
        Me.lblFooterAuthor.Name = "lblFooterAuthor"
        Me.lblFooterAuthor.Size = New System.Drawing.Size(304, 18)
        Me.lblFooterAuthor.TabIndex = 1
        Me.lblFooterAuthor.Text = "Sajor, Renz  |  BSIT 3B"
        Me.lblFooterAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlRule_pnlBanner
        '
        Me.pnlRule_pnlBanner.Location = New System.Drawing.Point(0, 68)
        Me.pnlRule_pnlBanner.Size = New System.Drawing.Size(900, 4)
        Me.pnlRule_pnlBanner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRule_pnlBanner.Name = "pnlRule_pnlBanner"
        Me.pnlRule_pnlBanner.TabIndex = 0
        Me.pnlRule_pnlBanner.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'pnlStrip_pnlInput
        '
        Me.pnlStrip_pnlInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlInput.Size = New System.Drawing.Size(250, 3)
        Me.pnlStrip_pnlInput.Name = "pnlStrip_pnlInput"
        Me.pnlStrip_pnlInput.TabIndex = 0
        Me.pnlStrip_pnlInput.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'pnlStrip_pnlOutput
        '
        Me.pnlStrip_pnlOutput.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlOutput.Size = New System.Drawing.Size(328, 3)
        Me.pnlStrip_pnlOutput.Name = "pnlStrip_pnlOutput"
        Me.pnlStrip_pnlOutput.TabIndex = 0
        Me.pnlStrip_pnlOutput.BackColor = System.Drawing.Color.FromArgb(14, 116, 144)
        '
        'pnlTileSum
        '
        Me.pnlTileSum.Controls.Add(Me.lblSumCaption)
        Me.pnlTileSum.Controls.Add(Me.lblSumValue)
        Me.pnlTileSum.Location = New System.Drawing.Point(12, 40)
        Me.pnlTileSum.Size = New System.Drawing.Size(148, 128)
        Me.pnlTileSum.Name = "pnlTileSum"
        Me.pnlTileSum.TabIndex = 0
        Me.pnlTileSum.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlTileDiff
        '
        Me.pnlTileDiff.Controls.Add(Me.lblDiffCaption)
        Me.pnlTileDiff.Controls.Add(Me.lblDiffValue)
        Me.pnlTileDiff.Location = New System.Drawing.Point(168, 40)
        Me.pnlTileDiff.Size = New System.Drawing.Size(148, 128)
        Me.pnlTileDiff.Name = "pnlTileDiff"
        Me.pnlTileDiff.TabIndex = 0
        Me.pnlTileDiff.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlTileProd
        '
        Me.pnlTileProd.Controls.Add(Me.lblProdCaption)
        Me.pnlTileProd.Controls.Add(Me.lblProdValue)
        Me.pnlTileProd.Location = New System.Drawing.Point(12, 176)
        Me.pnlTileProd.Size = New System.Drawing.Size(148, 128)
        Me.pnlTileProd.Name = "pnlTileProd"
        Me.pnlTileProd.TabIndex = 0
        Me.pnlTileProd.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlTileQuot
        '
        Me.pnlTileQuot.Controls.Add(Me.lblQuotCaption)
        Me.pnlTileQuot.Controls.Add(Me.lblQuotValue)
        Me.pnlTileQuot.Location = New System.Drawing.Point(168, 176)
        Me.pnlTileQuot.Size = New System.Drawing.Size(148, 128)
        Me.pnlTileQuot.Name = "pnlTileQuot"
        Me.pnlTileQuot.TabIndex = 0
        Me.pnlTileQuot.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlTileAve
        '
        Me.pnlTileAve.Controls.Add(Me.lblAveCaption)
        Me.pnlTileAve.Controls.Add(Me.lblAveValue)
        Me.pnlTileAve.Location = New System.Drawing.Point(12, 316)
        Me.pnlTileAve.Size = New System.Drawing.Size(304, 52)
        Me.pnlTileAve.Name = "pnlTileAve"
        Me.pnlTileAve.TabIndex = 0
        Me.pnlTileAve.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        '
        'pnlStrip_pnlActions
        '
        Me.pnlStrip_pnlActions.Location = New System.Drawing.Point(0, 0)
        Me.pnlStrip_pnlActions.Size = New System.Drawing.Size(250, 3)
        Me.pnlStrip_pnlActions.Name = "pnlStrip_pnlActions"
        Me.pnlStrip_pnlActions.TabIndex = 0
        Me.pnlStrip_pnlActions.BackColor = System.Drawing.Color.FromArgb(224, 82, 67)
        '
        'lblActionsTitle
        '
        Me.lblActionsTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblActionsTitle.Size = New System.Drawing.Size(218, 18)
        Me.lblActionsTitle.Name = "lblActionsTitle"
        Me.lblActionsTitle.TabIndex = 0
        Me.lblActionsTitle.AutoSize = False
        Me.lblActionsTitle.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblActionsTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblActionsTitle.Text = "OPERATIONS"
        Me.lblActionsTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.ClientSize = New System.Drawing.Size(900, 520)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlOutput)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlBanner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 4 - Arithmetic Machine  |  Sajor, Renz"
        Me.pnlBanner.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.pnlOutput.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlRule_pnlBanner.ResumeLayout(False)
        Me.pnlStrip_pnlInput.ResumeLayout(False)
        Me.pnlStrip_pnlOutput.ResumeLayout(False)
        Me.pnlTileSum.ResumeLayout(False)
        Me.pnlTileDiff.ResumeLayout(False)
        Me.pnlTileProd.ResumeLayout(False)
        Me.pnlTileQuot.ResumeLayout(False)
        Me.pnlTileAve.ResumeLayout(False)
        Me.pnlStrip_pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
