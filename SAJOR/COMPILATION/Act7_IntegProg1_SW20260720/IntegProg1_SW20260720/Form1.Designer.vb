<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInterest = New System.Windows.Forms.TabPage()
        Me.principalLabel = New System.Windows.Forms.Label()
        Me.principalTextBox = New System.Windows.Forms.TextBox()
        Me.interestRateLabel = New System.Windows.Forms.Label()
        Me.interestRateTextBox = New System.Windows.Forms.TextBox()
        Me.yearsLabel = New System.Windows.Forms.Label()
        Me.yearsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.balancesLabel = New System.Windows.Forms.Label()
        Me.resultsListBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.tabSquare = New System.Windows.Forms.TabPage()
        Me.fillCharacterLabel = New System.Windows.Forms.Label()
        Me.fillCharacterTextBox = New System.Windows.Forms.TextBox()
        Me.sideLengthLabel = New System.Windows.Forms.Label()
        Me.sideLengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.displaySquareButton = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.tabClassAverage = New System.Windows.Forms.TabPage()
        Me.gradeLabel = New System.Windows.Forms.Label()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.submitGradeButton = New System.Windows.Forms.Button()
        Me.gradesLabel = New System.Windows.Forms.Label()
        Me.gradesListBox = New System.Windows.Forms.ListBox()
        Me.calculateAverageButton = New System.Windows.Forms.Button()
        Me.clearGradesButton = New System.Windows.Forms.Button()
        Me.classAverageLabel = New System.Windows.Forms.Label()
        Me.tabDecimalEquivalent = New System.Windows.Forms.TabPage()
        Me.decimalOutputTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlRuleA = New System.Windows.Forms.Panel()
        Me.lblTopTitle = New System.Windows.Forms.Label()
        Me.lblTopSub = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabInterest.SuspendLayout()
        CType(Me.yearsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSquare.SuspendLayout()
        CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClassAverage.SuspendLayout()
        Me.tabDecimalEquivalent.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlRuleA.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInterest)
        Me.TabControl1.Controls.Add(Me.tabSquare)
        Me.TabControl1.Controls.Add(Me.tabClassAverage)
        Me.TabControl1.Controls.Add(Me.tabDecimalEquivalent)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(14, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 424)
        Me.TabControl1.TabIndex = 0
        '
        'tabInterest
        '
        Me.tabInterest.Controls.Add(Me.principalLabel)
        Me.tabInterest.Controls.Add(Me.principalTextBox)
        Me.tabInterest.Controls.Add(Me.interestRateLabel)
        Me.tabInterest.Controls.Add(Me.interestRateTextBox)
        Me.tabInterest.Controls.Add(Me.yearsLabel)
        Me.tabInterest.Controls.Add(Me.yearsNumericUpDown)
        Me.tabInterest.Controls.Add(Me.balancesLabel)
        Me.tabInterest.Controls.Add(Me.resultsListBox)
        Me.tabInterest.Controls.Add(Me.calculateButton)
        Me.tabInterest.Location = New System.Drawing.Point(4, 22)
        Me.tabInterest.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.tabInterest.Name = "tabInterest"
        Me.tabInterest.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.tabInterest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInterest.Size = New System.Drawing.Size(744, 396)
        Me.tabInterest.TabIndex = 0
        Me.tabInterest.Text = "App: Interest Calculator"
        Me.tabInterest.UseVisualStyleBackColor = False
        '
        'principalLabel
        '
        Me.principalLabel.AutoSize = False
        Me.principalLabel.Location = New System.Drawing.Point(20, 18)
        Me.principalLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.principalLabel.Size = New System.Drawing.Size(210, 18)
        Me.principalLabel.TabIndex = 0
        Me.principalLabel.Text = "Principal:"
        '
        'principalTextBox
        '
        Me.principalTextBox.Location = New System.Drawing.Point(20, 40)
        Me.principalTextBox.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.principalTextBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.principalTextBox.Size = New System.Drawing.Size(210, 30)
        Me.principalTextBox.TabIndex = 1
        Me.principalTextBox.Text = "1000"
        '
        'interestRateLabel
        '
        Me.interestRateLabel.AutoSize = False
        Me.interestRateLabel.Location = New System.Drawing.Point(20, 90)
        Me.interestRateLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.interestRateLabel.Name = "interestRateLabel"
        Me.interestRateLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.interestRateLabel.Size = New System.Drawing.Size(210, 18)
        Me.interestRateLabel.TabIndex = 2
        Me.interestRateLabel.Text = "Interest rate:"
        '
        'interestRateTextBox
        '
        Me.interestRateTextBox.Location = New System.Drawing.Point(20, 112)
        Me.interestRateTextBox.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.interestRateTextBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.interestRateTextBox.Name = "interestRateTextBox"
        Me.interestRateTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.interestRateTextBox.Size = New System.Drawing.Size(210, 30)
        Me.interestRateTextBox.TabIndex = 3
        Me.interestRateTextBox.Text = "5"
        '
        'yearsLabel
        '
        Me.yearsLabel.AutoSize = False
        Me.yearsLabel.Location = New System.Drawing.Point(20, 162)
        Me.yearsLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.yearsLabel.Name = "yearsLabel"
        Me.yearsLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.yearsLabel.Size = New System.Drawing.Size(210, 18)
        Me.yearsLabel.TabIndex = 4
        Me.yearsLabel.Text = "Years:"
        '
        'yearsNumericUpDown
        '
        Me.yearsNumericUpDown.Location = New System.Drawing.Point(20, 184)
        Me.yearsNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.yearsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.yearsNumericUpDown.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.yearsNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.yearsNumericUpDown.Name = "yearsNumericUpDown"
        Me.yearsNumericUpDown.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.yearsNumericUpDown.Size = New System.Drawing.Size(120, 30)
        Me.yearsNumericUpDown.TabIndex = 5
        Me.yearsNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'balancesLabel
        '
        Me.balancesLabel.AutoSize = False
        Me.balancesLabel.Location = New System.Drawing.Point(256, 18)
        Me.balancesLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.balancesLabel.Name = "balancesLabel"
        Me.balancesLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.balancesLabel.Size = New System.Drawing.Size(300, 18)
        Me.balancesLabel.TabIndex = 6
        Me.balancesLabel.Text = "Balances:"
        '
        'resultsListBox
        '
        Me.resultsListBox.FormattingEnabled = True
        Me.resultsListBox.Location = New System.Drawing.Point(256, 40)
        Me.resultsListBox.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.resultsListBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.resultsListBox.Name = "resultsListBox"
        Me.resultsListBox.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.resultsListBox.Size = New System.Drawing.Size(472, 330)
        Me.resultsListBox.TabIndex = 7
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(20, 240)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.calculateButton.FlatAppearance.BorderSize = 1
        Me.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculateButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.calculateButton.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.calculateButton.Size = New System.Drawing.Size(210, 42)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = False
        '
        'tabSquare
        '
        Me.tabSquare.Controls.Add(Me.fillCharacterLabel)
        Me.tabSquare.Controls.Add(Me.fillCharacterTextBox)
        Me.tabSquare.Controls.Add(Me.sideLengthLabel)
        Me.tabSquare.Controls.Add(Me.sideLengthNumericUpDown)
        Me.tabSquare.Controls.Add(Me.displaySquareButton)
        Me.tabSquare.Controls.Add(Me.outputTextBox)
        Me.tabSquare.Location = New System.Drawing.Point(4, 22)
        Me.tabSquare.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.tabSquare.Name = "tabSquare"
        Me.tabSquare.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.tabSquare.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSquare.Size = New System.Drawing.Size(744, 396)
        Me.tabSquare.TabIndex = 1
        Me.tabSquare.Text = "Square of Character"
        Me.tabSquare.UseVisualStyleBackColor = False
        '
        'fillCharacterLabel
        '
        Me.fillCharacterLabel.AutoSize = False
        Me.fillCharacterLabel.Location = New System.Drawing.Point(20, 18)
        Me.fillCharacterLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.fillCharacterLabel.Name = "fillCharacterLabel"
        Me.fillCharacterLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.fillCharacterLabel.Size = New System.Drawing.Size(210, 18)
        Me.fillCharacterLabel.TabIndex = 0
        Me.fillCharacterLabel.Text = "Enter fill character:"
        '
        'fillCharacterTextBox
        '
        Me.fillCharacterTextBox.Location = New System.Drawing.Point(20, 40)
        Me.fillCharacterTextBox.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.fillCharacterTextBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.fillCharacterTextBox.Name = "fillCharacterTextBox"
        Me.fillCharacterTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.fillCharacterTextBox.Size = New System.Drawing.Size(110, 30)
        Me.fillCharacterTextBox.TabIndex = 1
        Me.fillCharacterTextBox.Text = "#"
        '
        'sideLengthLabel
        '
        Me.sideLengthLabel.AutoSize = False
        Me.sideLengthLabel.Location = New System.Drawing.Point(20, 90)
        Me.sideLengthLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.sideLengthLabel.Name = "sideLengthLabel"
        Me.sideLengthLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.sideLengthLabel.Size = New System.Drawing.Size(210, 18)
        Me.sideLengthLabel.TabIndex = 2
        Me.sideLengthLabel.Text = "Enter side length:"
        '
        'sideLengthNumericUpDown
        '
        Me.sideLengthNumericUpDown.Location = New System.Drawing.Point(20, 112)
        Me.sideLengthNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.sideLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sideLengthNumericUpDown.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.sideLengthNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.sideLengthNumericUpDown.Name = "sideLengthNumericUpDown"
        Me.sideLengthNumericUpDown.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.sideLengthNumericUpDown.Size = New System.Drawing.Size(110, 30)
        Me.sideLengthNumericUpDown.TabIndex = 3
        Me.sideLengthNumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'displaySquareButton
        '
        Me.displaySquareButton.Location = New System.Drawing.Point(20, 164)
        Me.displaySquareButton.Name = "displaySquareButton"
        Me.displaySquareButton.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.displaySquareButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.displaySquareButton.FlatAppearance.BorderSize = 1
        Me.displaySquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.displaySquareButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.displaySquareButton.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.displaySquareButton.Size = New System.Drawing.Size(210, 42)
        Me.displaySquareButton.TabIndex = 4
        Me.displaySquareButton.Text = "Display Square"
        Me.displaySquareButton.UseVisualStyleBackColor = False
        '
        'outputTextBox
        '
        Me.outputTextBox.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.outputTextBox.Location = New System.Drawing.Point(256, 18)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.outputTextBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(472, 352)
        Me.outputTextBox.TabIndex = 5
        '
        'tabClassAverage
        '
        Me.tabClassAverage.Controls.Add(Me.gradeLabel)
        Me.tabClassAverage.Controls.Add(Me.gradeTextBox)
        Me.tabClassAverage.Controls.Add(Me.submitGradeButton)
        Me.tabClassAverage.Controls.Add(Me.gradesLabel)
        Me.tabClassAverage.Controls.Add(Me.gradesListBox)
        Me.tabClassAverage.Controls.Add(Me.calculateAverageButton)
        Me.tabClassAverage.Controls.Add(Me.clearGradesButton)
        Me.tabClassAverage.Controls.Add(Me.classAverageLabel)
        Me.tabClassAverage.Location = New System.Drawing.Point(4, 22)
        Me.tabClassAverage.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.tabClassAverage.Name = "tabClassAverage"
        Me.tabClassAverage.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.tabClassAverage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClassAverage.Size = New System.Drawing.Size(744, 396)
        Me.tabClassAverage.TabIndex = 2
        Me.tabClassAverage.Text = "Class Average"
        Me.tabClassAverage.UseVisualStyleBackColor = False
        '
        'gradeLabel
        '
        Me.gradeLabel.AutoSize = False
        Me.gradeLabel.Location = New System.Drawing.Point(20, 18)
        Me.gradeLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.gradeLabel.Name = "gradeLabel"
        Me.gradeLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gradeLabel.Size = New System.Drawing.Size(190, 18)
        Me.gradeLabel.TabIndex = 0
        Me.gradeLabel.Text = "Enter grade:"
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(20, 40)
        Me.gradeTextBox.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.gradeTextBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.gradeTextBox.Size = New System.Drawing.Size(190, 30)
        Me.gradeTextBox.TabIndex = 1
        '
        'submitGradeButton
        '
        Me.submitGradeButton.Location = New System.Drawing.Point(20, 82)
        Me.submitGradeButton.Name = "submitGradeButton"
        Me.submitGradeButton.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.submitGradeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.submitGradeButton.FlatAppearance.BorderSize = 1
        Me.submitGradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitGradeButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.submitGradeButton.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.submitGradeButton.Size = New System.Drawing.Size(190, 36)
        Me.submitGradeButton.TabIndex = 2
        Me.submitGradeButton.Text = "Submit Grade"
        Me.submitGradeButton.UseVisualStyleBackColor = False
        '
        'gradesLabel
        '
        Me.gradesLabel.AutoSize = False
        Me.gradesLabel.Location = New System.Drawing.Point(20, 134)
        Me.gradesLabel.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.gradesLabel.Name = "gradesLabel"
        Me.gradesLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gradesLabel.Size = New System.Drawing.Size(190, 18)
        Me.gradesLabel.TabIndex = 3
        Me.gradesLabel.Text = "Grades:"
        '
        'gradesListBox
        '
        Me.gradesListBox.FormattingEnabled = True
        Me.gradesListBox.Location = New System.Drawing.Point(20, 156)
        Me.gradesListBox.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.gradesListBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.gradesListBox.Name = "gradesListBox"
        Me.gradesListBox.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.0!)
        Me.gradesListBox.Size = New System.Drawing.Size(190, 150)
        Me.gradesListBox.TabIndex = 4
        '
        'calculateAverageButton
        '
        Me.calculateAverageButton.Location = New System.Drawing.Point(20, 322)
        Me.calculateAverageButton.Name = "calculateAverageButton"
        Me.calculateAverageButton.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.calculateAverageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.calculateAverageButton.FlatAppearance.BorderSize = 1
        Me.calculateAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculateAverageButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 7.25!, System.Drawing.FontStyle.Bold)
        Me.calculateAverageButton.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.calculateAverageButton.Size = New System.Drawing.Size(93, 40)
        Me.calculateAverageButton.TabIndex = 5
        Me.calculateAverageButton.Text = "Calculate Average"
        Me.calculateAverageButton.UseVisualStyleBackColor = False
        '
        'clearGradesButton
        '
        Me.clearGradesButton.Location = New System.Drawing.Point(118, 322)
        Me.clearGradesButton.Name = "clearGradesButton"
        Me.clearGradesButton.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.clearGradesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.clearGradesButton.FlatAppearance.BorderSize = 1
        Me.clearGradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearGradesButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clearGradesButton.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.clearGradesButton.Size = New System.Drawing.Size(92, 40)
        Me.clearGradesButton.TabIndex = 6
        Me.clearGradesButton.Text = "Clear Grades"
        Me.clearGradesButton.UseVisualStyleBackColor = False
        '
        'classAverageLabel
        '
        Me.classAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.classAverageLabel.Location = New System.Drawing.Point(232, 18)
        Me.classAverageLabel.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        Me.classAverageLabel.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.classAverageLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.classAverageLabel.Name = "classAverageLabel"
        Me.classAverageLabel.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.classAverageLabel.Size = New System.Drawing.Size(496, 344)
        Me.classAverageLabel.TabIndex = 7
        '
        'tabDecimalEquivalent
        '
        Me.tabDecimalEquivalent.Controls.Add(Me.decimalOutputTextBox)
        Me.tabDecimalEquivalent.Location = New System.Drawing.Point(4, 22)
        Me.tabDecimalEquivalent.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.tabDecimalEquivalent.Name = "tabDecimalEquivalent"
        Me.tabDecimalEquivalent.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.tabDecimalEquivalent.Size = New System.Drawing.Size(744, 396)
        Me.tabDecimalEquivalent.TabIndex = 3
        Me.tabDecimalEquivalent.Text = "Decimal Equivalent"
        Me.tabDecimalEquivalent.UseVisualStyleBackColor = False
        '
        'decimalOutputTextBox
        '
        Me.decimalOutputTextBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.decimalOutputTextBox.Location = New System.Drawing.Point(16, 16)
        Me.decimalOutputTextBox.Multiline = True
        Me.decimalOutputTextBox.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.decimalOutputTextBox.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.decimalOutputTextBox.Name = "decimalOutputTextBox"
        Me.decimalOutputTextBox.ReadOnly = True
        Me.decimalOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.decimalOutputTextBox.Size = New System.Drawing.Size(712, 364)
        Me.decimalOutputTextBox.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(744, 396)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Area Calculator"
        Me.TabPage1.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(8, 8)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(728, 380)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(720, 354)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(720, 354)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.0!)
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(720, 354)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = False
        '
        'lblAuthor
        '
        Me.lblAuthor.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblAuthor.Location = New System.Drawing.Point(16, 7)
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(280, 18)
        Me.lblAuthor.TabIndex = 1
        Me.lblAuthor.Text = "Author: Sajor, Renz   |   BSIT 3B   |   Activity 7"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlRuleA)
        Me.pnlTop.Controls.Add(Me.lblTopTitle)
        Me.pnlTop.Controls.Add(Me.lblTopSub)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Size = New System.Drawing.Size(780, 60)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.TabIndex = 0
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lblAuthor)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 508)
        Me.pnlBottom.Size = New System.Drawing.Size(780, 32)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.TabIndex = 0
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(232, 234, 250)
        '
        'pnlRuleA
        '
        Me.pnlRuleA.Location = New System.Drawing.Point(0, 56)
        Me.pnlRuleA.Size = New System.Drawing.Size(780, 4)
        Me.pnlRuleA.Name = "pnlRuleA"
        Me.pnlRuleA.TabIndex = 0
        Me.pnlRuleA.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        '
        'lblTopTitle
        '
        Me.lblTopTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblTopTitle.Size = New System.Drawing.Size(420, 32)
        Me.lblTopTitle.Name = "lblTopTitle"
        Me.lblTopTitle.TabIndex = 0
        Me.lblTopTitle.AutoSize = False
        Me.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.lblTopTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTopTitle.Text = "Integrative Program 1"
        Me.lblTopTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblTopSub
        '
        Me.lblTopSub.Location = New System.Drawing.Point(440, 20)
        Me.lblTopSub.Size = New System.Drawing.Size(320, 22)
        Me.lblTopSub.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTopSub.Name = "lblTopSub"
        Me.lblTopSub.TabIndex = 0
        Me.lblTopSub.AutoSize = False
        Me.lblTopSub.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblTopSub.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblTopSub.Text = "Activity 7  |  IntegProg1_SW20260720"
        Me.lblTopSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 540)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 7 - IntegProg1_SW20260720  |  Sajor, Renz"
        Me.TabControl1.ResumeLayout(False)
        Me.tabInterest.ResumeLayout(False)
        Me.tabInterest.PerformLayout()
        CType(Me.yearsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSquare.ResumeLayout(False)
        Me.tabSquare.PerformLayout()
        CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClassAverage.ResumeLayout(False)
        Me.tabClassAverage.PerformLayout()
        Me.tabDecimalEquivalent.ResumeLayout(False)
        Me.tabDecimalEquivalent.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlRuleA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabInterest As System.Windows.Forms.TabPage
    Friend WithEvents tabSquare As System.Windows.Forms.TabPage
    Friend WithEvents tabClassAverage As System.Windows.Forms.TabPage
    Friend WithEvents tabDecimalEquivalent As System.Windows.Forms.TabPage
    Friend WithEvents principalLabel As System.Windows.Forms.Label
    Friend WithEvents principalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents interestRateLabel As System.Windows.Forms.Label
    Friend WithEvents interestRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents yearsLabel As System.Windows.Forms.Label
    Friend WithEvents yearsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents balancesLabel As System.Windows.Forms.Label
    Friend WithEvents resultsListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents fillCharacterLabel As System.Windows.Forms.Label
    Friend WithEvents fillCharacterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sideLengthLabel As System.Windows.Forms.Label
    Friend WithEvents sideLengthNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents displaySquareButton As System.Windows.Forms.Button
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gradeLabel As System.Windows.Forms.Label
    Friend WithEvents gradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents submitGradeButton As System.Windows.Forms.Button
    Friend WithEvents gradesLabel As System.Windows.Forms.Label
    Friend WithEvents gradesListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateAverageButton As System.Windows.Forms.Button
    Friend WithEvents clearGradesButton As System.Windows.Forms.Button
    Friend WithEvents classAverageLabel As System.Windows.Forms.Label
    Friend WithEvents decimalOutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlRuleA As System.Windows.Forms.Panel
    Friend WithEvents lblTopTitle As System.Windows.Forms.Label
    Friend WithEvents lblTopSub As System.Windows.Forms.Label
End Class
