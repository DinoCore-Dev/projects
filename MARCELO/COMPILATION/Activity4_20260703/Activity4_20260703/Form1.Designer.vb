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
        Me.pnlBanner.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlOutput.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBanner
        '
        Me.pnlBanner.BackColor = System.Drawing.Color.FromArgb(47, 59, 30)
        Me.pnlBanner.Controls.Add(Me.lblAuthorCourse)
        Me.pnlBanner.Controls.Add(Me.lblAuthorName)
        Me.pnlBanner.Controls.Add(Me.lblSubtitle)
        Me.pnlBanner.Controls.Add(Me.lblTitle)
        Me.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBanner.Location = New System.Drawing.Point(0, 0)
        Me.pnlBanner.Name = "pnlBanner"
        Me.pnlBanner.Size = New System.Drawing.Size(900, 92)
        Me.pnlBanner.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 18.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(26, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Arithmetic Machine"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Times New Roman", 9.25!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(209, 253, 147)
        Me.lblSubtitle.Location = New System.Drawing.Point(29, 54)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(489, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Activity 4 - Act4_20260703  |  Sum, difference, product, quotient and average of three numbers"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthorName.Font = New System.Drawing.Font("Times New Roman", 11.5!, System.Drawing.FontStyle.Bold)
        Me.lblAuthorName.ForeColor = System.Drawing.Color.White
        Me.lblAuthorName.Location = New System.Drawing.Point(650, 22)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(226, 22)
        Me.lblAuthorName.TabIndex = 2
        Me.lblAuthorName.Text = "Marcelo, John Carlo"
        Me.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAuthorCourse
        '
        Me.lblAuthorCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthorCourse.Font = New System.Drawing.Font("Times New Roman", 9.25!)
        Me.lblAuthorCourse.ForeColor = System.Drawing.Color.FromArgb(169, 184, 148)
        Me.lblAuthorCourse.Location = New System.Drawing.Point(650, 46)
        Me.lblAuthorCourse.Name = "lblAuthorCourse"
        Me.lblAuthorCourse.Size = New System.Drawing.Size(226, 20)
        Me.lblAuthorCourse.TabIndex = 3
        Me.lblAuthorCourse.Text = "BSIT 3B  |  Integrative Programming"
        Me.lblAuthorCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.White
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.lblInputNote)
        Me.pnlInput.Controls.Add(Me.txtN3)
        Me.pnlInput.Controls.Add(Me.txtN2)
        Me.pnlInput.Controls.Add(Me.txtN1)
        Me.pnlInput.Controls.Add(Me.lblThird)
        Me.pnlInput.Controls.Add(Me.lblSecond)
        Me.pnlInput.Controls.Add(Me.lblFirst)
        Me.pnlInput.Controls.Add(Me.lblInputTitle)
        Me.pnlInput.Location = New System.Drawing.Point(28, 220)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(400, 224)
        Me.pnlInput.TabIndex = 1
        '
        'lblInputTitle
        '
        Me.lblInputTitle.AutoSize = True
        Me.lblInputTitle.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(123, 139, 100)
        Me.lblInputTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblInputTitle.Name = "lblInputTitle"
        Me.lblInputTitle.Size = New System.Drawing.Size(101, 15)
        Me.lblInputTitle.TabIndex = 0
        Me.lblInputTitle.Text = "INPUT NUMBERS"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblFirst.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblFirst.Location = New System.Drawing.Point(18, 52)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(92, 19)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First number"
        '
        'txtN1
        '
        Me.txtN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN1.Font = New System.Drawing.Font("Times New Roman", 11.5!)
        Me.txtN1.Location = New System.Drawing.Point(152, 48)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(222, 27)
        Me.txtN1.TabIndex = 2
        Me.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblSecond.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblSecond.Location = New System.Drawing.Point(18, 98)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(110, 19)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Second number"
        '
        'txtN2
        '
        Me.txtN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN2.Font = New System.Drawing.Font("Times New Roman", 11.5!)
        Me.txtN2.Location = New System.Drawing.Point(152, 94)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(222, 27)
        Me.txtN2.TabIndex = 4
        Me.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThird
        '
        Me.lblThird.AutoSize = True
        Me.lblThird.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblThird.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblThird.Location = New System.Drawing.Point(18, 144)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(96, 19)
        Me.lblThird.TabIndex = 5
        Me.lblThird.Text = "Third number"
        '
        'txtN3
        '
        Me.txtN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN3.Font = New System.Drawing.Font("Times New Roman", 11.5!)
        Me.txtN3.Location = New System.Drawing.Point(152, 140)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(222, 27)
        Me.txtN3.TabIndex = 6
        Me.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInputNote
        '
        Me.lblInputNote.AutoSize = True
        Me.lblInputNote.Font = New System.Drawing.Font("Times New Roman", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblInputNote.ForeColor = System.Drawing.Color.FromArgb(169, 184, 148)
        Me.lblInputNote.Location = New System.Drawing.Point(18, 184)
        Me.lblInputNote.Name = "lblInputNote"
        Me.lblInputNote.Size = New System.Drawing.Size(247, 13)
        Me.lblInputNote.TabIndex = 7
        Me.lblInputNote.Text = "Whole numbers and decimal numbers are accepted."
        '
        'pnlOutput
        '
        Me.pnlOutput.BackColor = System.Drawing.Color.White
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOutput.Controls.Add(Me.lblAveValue)
        Me.pnlOutput.Controls.Add(Me.lblAveCaption)
        Me.pnlOutput.Controls.Add(Me.lblQuotValue)
        Me.pnlOutput.Controls.Add(Me.lblQuotCaption)
        Me.pnlOutput.Controls.Add(Me.lblProdValue)
        Me.pnlOutput.Controls.Add(Me.lblProdCaption)
        Me.pnlOutput.Controls.Add(Me.lblDiffValue)
        Me.pnlOutput.Controls.Add(Me.lblDiffCaption)
        Me.pnlOutput.Controls.Add(Me.lblSumValue)
        Me.pnlOutput.Controls.Add(Me.lblSumCaption)
        Me.pnlOutput.Controls.Add(Me.lblOutputTitle)
        Me.pnlOutput.Location = New System.Drawing.Point(452, 220)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(420, 224)
        Me.pnlOutput.TabIndex = 2
        '
        'lblOutputTitle
        '
        Me.lblOutputTitle.AutoSize = True
        Me.lblOutputTitle.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblOutputTitle.ForeColor = System.Drawing.Color.FromArgb(123, 139, 100)
        Me.lblOutputTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblOutputTitle.Name = "lblOutputTitle"
        Me.lblOutputTitle.Size = New System.Drawing.Size(56, 15)
        Me.lblOutputTitle.TabIndex = 0
        Me.lblOutputTitle.Text = "RESULTS"
        '
        'lblSumCaption
        '
        Me.lblSumCaption.AutoSize = True
        Me.lblSumCaption.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblSumCaption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblSumCaption.Location = New System.Drawing.Point(18, 48)
        Me.lblSumCaption.Name = "lblSumCaption"
        Me.lblSumCaption.Size = New System.Drawing.Size(34, 19)
        Me.lblSumCaption.TabIndex = 1
        Me.lblSumCaption.Text = "Sum"
        '
        'lblSumValue
        '
        Me.lblSumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumValue.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumValue.ForeColor = System.Drawing.Color.FromArgb(153, 235, 37)
        Me.lblSumValue.Location = New System.Drawing.Point(140, 42)
        Me.lblSumValue.Name = "lblSumValue"
        Me.lblSumValue.Size = New System.Drawing.Size(256, 30)
        Me.lblSumValue.TabIndex = 2
        Me.lblSumValue.Text = "-"
        Me.lblSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiffCaption
        '
        Me.lblDiffCaption.AutoSize = True
        Me.lblDiffCaption.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblDiffCaption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblDiffCaption.Location = New System.Drawing.Point(18, 84)
        Me.lblDiffCaption.Name = "lblDiffCaption"
        Me.lblDiffCaption.Size = New System.Drawing.Size(69, 19)
        Me.lblDiffCaption.TabIndex = 3
        Me.lblDiffCaption.Text = "Difference"
        '
        'lblDiffValue
        '
        Me.lblDiffValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiffValue.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiffValue.ForeColor = System.Drawing.Color.FromArgb(153, 235, 37)
        Me.lblDiffValue.Location = New System.Drawing.Point(140, 78)
        Me.lblDiffValue.Name = "lblDiffValue"
        Me.lblDiffValue.Size = New System.Drawing.Size(256, 30)
        Me.lblDiffValue.TabIndex = 4
        Me.lblDiffValue.Text = "-"
        Me.lblDiffValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProdCaption
        '
        Me.lblProdCaption.AutoSize = True
        Me.lblProdCaption.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblProdCaption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblProdCaption.Location = New System.Drawing.Point(18, 120)
        Me.lblProdCaption.Name = "lblProdCaption"
        Me.lblProdCaption.Size = New System.Drawing.Size(54, 19)
        Me.lblProdCaption.TabIndex = 5
        Me.lblProdCaption.Text = "Product"
        '
        'lblProdValue
        '
        Me.lblProdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProdValue.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblProdValue.ForeColor = System.Drawing.Color.FromArgb(153, 235, 37)
        Me.lblProdValue.Location = New System.Drawing.Point(140, 114)
        Me.lblProdValue.Name = "lblProdValue"
        Me.lblProdValue.Size = New System.Drawing.Size(256, 30)
        Me.lblProdValue.TabIndex = 6
        Me.lblProdValue.Text = "-"
        Me.lblProdValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuotCaption
        '
        Me.lblQuotCaption.AutoSize = True
        Me.lblQuotCaption.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.lblQuotCaption.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblQuotCaption.Location = New System.Drawing.Point(18, 156)
        Me.lblQuotCaption.Name = "lblQuotCaption"
        Me.lblQuotCaption.Size = New System.Drawing.Size(55, 19)
        Me.lblQuotCaption.TabIndex = 7
        Me.lblQuotCaption.Text = "Quotient"
        '
        'lblQuotValue
        '
        Me.lblQuotValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotValue.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuotValue.ForeColor = System.Drawing.Color.FromArgb(153, 235, 37)
        Me.lblQuotValue.Location = New System.Drawing.Point(140, 150)
        Me.lblQuotValue.Name = "lblQuotValue"
        Me.lblQuotValue.Size = New System.Drawing.Size(256, 30)
        Me.lblQuotValue.TabIndex = 8
        Me.lblQuotValue.Text = "-"
        Me.lblQuotValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAveCaption
        '
        Me.lblAveCaption.AutoSize = True
        Me.lblAveCaption.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblAveCaption.ForeColor = System.Drawing.Color.FromArgb(31, 42, 15)
        Me.lblAveCaption.Location = New System.Drawing.Point(18, 192)
        Me.lblAveCaption.Name = "lblAveCaption"
        Me.lblAveCaption.Size = New System.Drawing.Size(64, 19)
        Me.lblAveCaption.TabIndex = 9
        Me.lblAveCaption.Text = "Average"
        '
        'lblAveValue
        '
        Me.lblAveValue.BackColor = System.Drawing.Color.FromArgb(239, 254, 219)
        Me.lblAveValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAveValue.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAveValue.ForeColor = System.Drawing.Color.FromArgb(115, 175, 30)
        Me.lblAveValue.Location = New System.Drawing.Point(140, 186)
        Me.lblAveValue.Name = "lblAveValue"
        Me.lblAveValue.Size = New System.Drawing.Size(256, 30)
        Me.lblAveValue.TabIndex = 10
        Me.lblAveValue.Text = "-"
        Me.lblAveValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.White
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.btnExit)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnAverage)
        Me.pnlActions.Controls.Add(Me.btnQuotient)
        Me.pnlActions.Controls.Add(Me.btnProduct)
        Me.pnlActions.Controls.Add(Me.btnDifference)
        Me.pnlActions.Controls.Add(Me.btnSum)
        Me.pnlActions.Location = New System.Drawing.Point(28, 116)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(844, 88)
        Me.pnlActions.TabIndex = 3
        '
        'btnSum
        '
        Me.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSum.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnSum.Location = New System.Drawing.Point(720, 24)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(108, 38)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnDifference
        '
        Me.btnDifference.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDifference.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnDifference.Location = New System.Drawing.Point(604, 24)
        Me.btnDifference.Name = "btnDifference"
        Me.btnDifference.Size = New System.Drawing.Size(108, 38)
        Me.btnDifference.TabIndex = 1
        Me.btnDifference.Text = "Difference"
        Me.btnDifference.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnProduct.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnProduct.Location = New System.Drawing.Point(488, 24)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(108, 38)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnQuotient
        '
        Me.btnQuotient.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnQuotient.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnQuotient.Location = New System.Drawing.Point(372, 24)
        Me.btnQuotient.Name = "btnQuotient"
        Me.btnQuotient.Size = New System.Drawing.Size(108, 38)
        Me.btnQuotient.TabIndex = 3
        Me.btnQuotient.Text = "Quotient"
        Me.btnQuotient.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAverage.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnAverage.Location = New System.Drawing.Point(256, 24)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(108, 38)
        Me.btnAverage.TabIndex = 4
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(132, 24)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 38)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(16, 24)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
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
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 9.25!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 51)
        Me.lblStatus.Location = New System.Drawing.Point(16, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(228, 15)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Ready. Enter three numbers to begin."
        '
        'lblFooterAuthor
        '
        Me.lblFooterAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooterAuthor.Font = New System.Drawing.Font("Times New Roman", 8.5!)
        Me.lblFooterAuthor.ForeColor = System.Drawing.Color.FromArgb(123, 139, 100)
        Me.lblFooterAuthor.Location = New System.Drawing.Point(620, 9)
        Me.lblFooterAuthor.Name = "lblFooterAuthor"
        Me.lblFooterAuthor.Size = New System.Drawing.Size(264, 15)
        Me.lblFooterAuthor.TabIndex = 1
        Me.lblFooterAuthor.Text = "Marcelo, John Carlo  |  BSIT 3B"
        Me.lblFooterAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
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
        Me.Text = "Activity 4 - Arithmetic Machine  |  Marcelo, John Carlo"
        Me.pnlBanner.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.pnlOutput.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
