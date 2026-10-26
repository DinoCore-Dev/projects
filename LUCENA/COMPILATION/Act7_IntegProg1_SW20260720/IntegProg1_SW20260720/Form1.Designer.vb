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
        Me.TabControl1.SuspendLayout()
        Me.tabInterest.SuspendLayout()
        CType(Me.yearsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSquare.SuspendLayout()
        CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClassAverage.SuspendLayout()
        Me.tabDecimalEquivalent.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInterest)
        Me.TabControl1.Controls.Add(Me.tabSquare)
        Me.TabControl1.Controls.Add(Me.tabClassAverage)
        Me.TabControl1.Controls.Add(Me.tabDecimalEquivalent)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 384)
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
        Me.tabInterest.Name = "tabInterest"
        Me.tabInterest.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.tabInterest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInterest.Size = New System.Drawing.Size(564, 386)
        Me.tabInterest.TabIndex = 0
        Me.tabInterest.Text = "App: Interest Calculator"
        Me.tabInterest.UseVisualStyleBackColor = True
        '
        'principalLabel
        '
        Me.principalLabel.AutoSize = True
        Me.principalLabel.Location = New System.Drawing.Point(12, 69)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.principalLabel.Size = New System.Drawing.Size(50, 13)
        Me.principalLabel.TabIndex = 0
        Me.principalLabel.Text = "Principal:"
        '
        'principalTextBox
        '
        Me.principalTextBox.Location = New System.Drawing.Point(90, 67)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.principalTextBox.Size = New System.Drawing.Size(150, 20)
        Me.principalTextBox.TabIndex = 1
        Me.principalTextBox.Text = "1000"
        '
        'interestRateLabel
        '
        Me.interestRateLabel.AutoSize = True
        Me.interestRateLabel.Location = New System.Drawing.Point(12, 43)
        Me.interestRateLabel.Name = "interestRateLabel"
        Me.interestRateLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.interestRateLabel.Size = New System.Drawing.Size(66, 13)
        Me.interestRateLabel.TabIndex = 2
        Me.interestRateLabel.Text = "Interest rate:"
        '
        'interestRateTextBox
        '
        Me.interestRateTextBox.Location = New System.Drawing.Point(90, 41)
        Me.interestRateTextBox.Name = "interestRateTextBox"
        Me.interestRateTextBox.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.interestRateTextBox.Size = New System.Drawing.Size(150, 20)
        Me.interestRateTextBox.TabIndex = 3
        Me.interestRateTextBox.Text = "5"
        '
        'yearsLabel
        '
        Me.yearsLabel.AutoSize = True
        Me.yearsLabel.Location = New System.Drawing.Point(12, 17)
        Me.yearsLabel.Name = "yearsLabel"
        Me.yearsLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.yearsLabel.Size = New System.Drawing.Size(37, 13)
        Me.yearsLabel.TabIndex = 4
        Me.yearsLabel.Text = "Years:"
        '
        'yearsNumericUpDown
        '
        Me.yearsNumericUpDown.Location = New System.Drawing.Point(90, 15)
        Me.yearsNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.yearsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.yearsNumericUpDown.Name = "yearsNumericUpDown"
        Me.yearsNumericUpDown.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.yearsNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.yearsNumericUpDown.TabIndex = 5
        Me.yearsNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'balancesLabel
        '
        Me.balancesLabel.AutoSize = True
        Me.balancesLabel.Location = New System.Drawing.Point(12, 106)
        Me.balancesLabel.Name = "balancesLabel"
        Me.balancesLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.balancesLabel.Size = New System.Drawing.Size(54, 13)
        Me.balancesLabel.TabIndex = 6
        Me.balancesLabel.Text = "Balances:"
        '
        'resultsListBox
        '
        Me.resultsListBox.FormattingEnabled = True
        Me.resultsListBox.Location = New System.Drawing.Point(90, 103)
        Me.resultsListBox.Name = "resultsListBox"
        Me.resultsListBox.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.resultsListBox.Size = New System.Drawing.Size(440, 212)
        Me.resultsListBox.TabIndex = 7
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(255, 13)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(129, 37, 235)
        Me.calculateButton.FlatAppearance.BorderSize = 2
        Me.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculateButton.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.calculateButton.Size = New System.Drawing.Size(90, 23)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
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
        Me.tabSquare.Name = "tabSquare"
        Me.tabSquare.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.tabSquare.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSquare.Size = New System.Drawing.Size(564, 386)
        Me.tabSquare.TabIndex = 1
        Me.tabSquare.Text = "Square of Character"
        Me.tabSquare.UseVisualStyleBackColor = True
        '
        'fillCharacterLabel
        '
        Me.fillCharacterLabel.AutoSize = True
        Me.fillCharacterLabel.Location = New System.Drawing.Point(14, 20)
        Me.fillCharacterLabel.Name = "fillCharacterLabel"
        Me.fillCharacterLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.fillCharacterLabel.Size = New System.Drawing.Size(95, 13)
        Me.fillCharacterLabel.TabIndex = 0
        Me.fillCharacterLabel.Text = "Enter fill character:"
        '
        'fillCharacterTextBox
        '
        Me.fillCharacterTextBox.Location = New System.Drawing.Point(119, 17)
        Me.fillCharacterTextBox.Name = "fillCharacterTextBox"
        Me.fillCharacterTextBox.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.fillCharacterTextBox.Size = New System.Drawing.Size(50, 20)
        Me.fillCharacterTextBox.TabIndex = 1
        Me.fillCharacterTextBox.Text = "#"
        '
        'sideLengthLabel
        '
        Me.sideLengthLabel.AutoSize = True
        Me.sideLengthLabel.Location = New System.Drawing.Point(14, 46)
        Me.sideLengthLabel.Name = "sideLengthLabel"
        Me.sideLengthLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.sideLengthLabel.Size = New System.Drawing.Size(89, 13)
        Me.sideLengthLabel.TabIndex = 2
        Me.sideLengthLabel.Text = "Enter side length:"
        '
        'sideLengthNumericUpDown
        '
        Me.sideLengthNumericUpDown.Location = New System.Drawing.Point(119, 43)
        Me.sideLengthNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.sideLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sideLengthNumericUpDown.Name = "sideLengthNumericUpDown"
        Me.sideLengthNumericUpDown.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.sideLengthNumericUpDown.Size = New System.Drawing.Size(50, 20)
        Me.sideLengthNumericUpDown.TabIndex = 3
        Me.sideLengthNumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'displaySquareButton
        '
        Me.displaySquareButton.Location = New System.Drawing.Point(230, 15)
        Me.displaySquareButton.Name = "displaySquareButton"
        Me.displaySquareButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(129, 37, 235)
        Me.displaySquareButton.FlatAppearance.BorderSize = 2
        Me.displaySquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.displaySquareButton.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.displaySquareButton.Size = New System.Drawing.Size(100, 23)
        Me.displaySquareButton.TabIndex = 4
        Me.displaySquareButton.Text = "Display Square"
        Me.displaySquareButton.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTextBox.Location = New System.Drawing.Point(14, 78)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(535, 290)
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
        Me.tabClassAverage.Name = "tabClassAverage"
        Me.tabClassAverage.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.tabClassAverage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClassAverage.Size = New System.Drawing.Size(564, 386)
        Me.tabClassAverage.TabIndex = 2
        Me.tabClassAverage.Text = "Class Average"
        Me.tabClassAverage.UseVisualStyleBackColor = True
        '
        'gradeLabel
        '
        Me.gradeLabel.AutoSize = True
        Me.gradeLabel.Location = New System.Drawing.Point(18, 20)
        Me.gradeLabel.Name = "gradeLabel"
        Me.gradeLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.gradeLabel.Size = New System.Drawing.Size(65, 13)
        Me.gradeLabel.TabIndex = 0
        Me.gradeLabel.Text = "Enter grade:"
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(87, 17)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.gradeTextBox.Size = New System.Drawing.Size(70, 20)
        Me.gradeTextBox.TabIndex = 1
        '
        'submitGradeButton
        '
        Me.submitGradeButton.Location = New System.Drawing.Point(172, 15)
        Me.submitGradeButton.Name = "submitGradeButton"
        Me.submitGradeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(129, 37, 235)
        Me.submitGradeButton.FlatAppearance.BorderSize = 2
        Me.submitGradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitGradeButton.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.submitGradeButton.Size = New System.Drawing.Size(95, 23)
        Me.submitGradeButton.TabIndex = 2
        Me.submitGradeButton.Text = "Submit Grade"
        Me.submitGradeButton.UseVisualStyleBackColor = True
        '
        'gradesLabel
        '
        Me.gradesLabel.AutoSize = True
        Me.gradesLabel.Location = New System.Drawing.Point(18, 50)
        Me.gradesLabel.Name = "gradesLabel"
        Me.gradesLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.gradesLabel.Size = New System.Drawing.Size(44, 13)
        Me.gradesLabel.TabIndex = 3
        Me.gradesLabel.Text = "Grades:"
        '
        'gradesListBox
        '
        Me.gradesListBox.FormattingEnabled = True
        Me.gradesListBox.Location = New System.Drawing.Point(18, 70)
        Me.gradesListBox.Name = "gradesListBox"
        Me.gradesListBox.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.gradesListBox.Size = New System.Drawing.Size(150, 186)
        Me.gradesListBox.TabIndex = 4
        '
        'calculateAverageButton
        '
        Me.calculateAverageButton.Location = New System.Drawing.Point(18, 263)
        Me.calculateAverageButton.Name = "calculateAverageButton"
        Me.calculateAverageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(129, 37, 235)
        Me.calculateAverageButton.FlatAppearance.BorderSize = 2
        Me.calculateAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculateAverageButton.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.calculateAverageButton.Size = New System.Drawing.Size(150, 24)
        Me.calculateAverageButton.TabIndex = 5
        Me.calculateAverageButton.Text = "Calculate Average"
        Me.calculateAverageButton.UseVisualStyleBackColor = True
        '
        'clearGradesButton
        '
        Me.clearGradesButton.Location = New System.Drawing.Point(18, 293)
        Me.clearGradesButton.Name = "clearGradesButton"
        Me.clearGradesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(129, 37, 235)
        Me.clearGradesButton.FlatAppearance.BorderSize = 2
        Me.clearGradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearGradesButton.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.clearGradesButton.Size = New System.Drawing.Size(150, 24)
        Me.clearGradesButton.TabIndex = 6
        Me.clearGradesButton.Text = "Clear Grades"
        Me.clearGradesButton.UseVisualStyleBackColor = True
        '
        'classAverageLabel
        '
        Me.classAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.classAverageLabel.Location = New System.Drawing.Point(184, 70)
        Me.classAverageLabel.Name = "classAverageLabel"
        Me.classAverageLabel.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.classAverageLabel.Size = New System.Drawing.Size(365, 247)
        Me.classAverageLabel.TabIndex = 7
        '
        'tabDecimalEquivalent
        '
        Me.tabDecimalEquivalent.Controls.Add(Me.decimalOutputTextBox)
        Me.tabDecimalEquivalent.Location = New System.Drawing.Point(4, 22)
        Me.tabDecimalEquivalent.Name = "tabDecimalEquivalent"
        Me.tabDecimalEquivalent.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.tabDecimalEquivalent.Size = New System.Drawing.Size(564, 386)
        Me.tabDecimalEquivalent.TabIndex = 3
        Me.tabDecimalEquivalent.Text = "Decimal Equivalent"
        Me.tabDecimalEquivalent.UseVisualStyleBackColor = True
        '
        'decimalOutputTextBox
        '
        Me.decimalOutputTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decimalOutputTextBox.Location = New System.Drawing.Point(14, 14)
        Me.decimalOutputTextBox.Multiline = True
        Me.decimalOutputTextBox.Name = "decimalOutputTextBox"
        Me.decimalOutputTextBox.ReadOnly = True
        Me.decimalOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.decimalOutputTextBox.Size = New System.Drawing.Size(536, 350)
        Me.decimalOutputTextBox.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 386)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Area Calculator"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(6, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(552, 377)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 351)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(544, 351)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(544, 351)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblAuthor
        '
        Me.lblAuthor.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(118, 100, 139)
        Me.lblAuthor.Location = New System.Drawing.Point(6, 394)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(572, 20)
        Me.lblAuthor.TabIndex = 1
        Me.lblAuthor.Text = "Author: Lucena, Lyka Joy   |   BSIT 3B   |   Activity 7"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 424)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 7 - IntegProg1_SW20260720  |  Lucena, Lyka Joy"
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
End Class
