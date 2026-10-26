Public Class Form1

    Private Sub calculateButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles calculateButton.Click

        Dim principal As Decimal = Val(principalTextBox.Text)
        Dim rate As Decimal = Val(interestRateTextBox.Text)
        Dim amount As Decimal

        resultsListBox.Items.Add(
            "Year" & vbTab & "Amount on Deposit")

        For yearCounter As Integer = 1 To yearsNumericUpDown.Value
            amount = principal * ((1 + rate / 100) ^ yearCounter)
            resultsListBox.Items.Add(yearCounter & vbTab &
                String.Format("{0:C}", amount))
        Next
    End Sub

    Private Sub principalTextBox_TextChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles principalTextBox.TextChanged
        resultsListBox.Items.Clear()
    End Sub

    Private Sub interestRateTextBox_TextChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles interestRateTextBox.TextChanged
        resultsListBox.Items.Clear()
    End Sub

    Private Sub yearsNumericUpDown_ValueChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles yearsNumericUpDown.ValueChanged
        resultsListBox.Items.Clear()
    End Sub

    Private Sub displaySquareButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles displaySquareButton.Click

        outputTextBox.Clear()

        Dim fillCharacter As String = fillCharacterTextBox.Text
        Dim sideLength As Integer = sideLengthNumericUpDown.Value

        For row As Integer = 1 To sideLength
            For column As Integer = 1 To sideLength
                outputTextBox.AppendText(fillCharacter & " ")
            Next column

            outputTextBox.AppendText(vbCrLf)
        Next row
    End Sub

    Private Sub fillCharacterTextBox_TextChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles fillCharacterTextBox.TextChanged
        outputTextBox.Clear()
    End Sub

    Private Sub sideLengthNumericUpDown_ValueChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles sideLengthNumericUpDown.ValueChanged
        outputTextBox.Clear()
    End Sub

    Dim aCount As Integer
    Dim bCount As Integer
    Dim cCount As Integer
    Dim dCount As Integer
    Dim fCount As Integer
    Dim perfectScoreCount As Integer

    Private Sub submitGradeButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles submitGradeButton.Click

        Dim grade As Integer = Val(gradeTextBox.Text)

        gradesListBox.Items.Add(grade)
        gradeTextBox.Clear()

        Select Case grade
            Case 100
                perfectScoreCount += 1
                aCount += 1
            Case 90 To 99
                aCount += 1
            Case 80 To 89
                bCount += 1
            Case 70 To 79
                cCount += 1
            Case 60 To 69
                dCount += 1
            Case Else
                fCount += 1
        End Select

        gradeTextBox.Focus()
    End Sub

    Private Sub calculateAverageButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles calculateAverageButton.Click

        Dim total As Integer
        Dim gradeCounter As Integer
        Dim grade As Integer
        Dim average As Double

        total = 0
        gradeCounter = 0

        Do While gradeCounter < gradesListBox.Items.Count
            grade = gradesListBox.Items(gradeCounter)
            total += grade
            gradeCounter += 1
        Loop

        If gradeCounter <> 0 Then
            average = total / gradeCounter

            classAverageLabel.Text = "Total of the " & gradeCounter &
                " grade(s) is " & total & vbCrLf & "Class average is " &
                String.Format("{0:F}", average) & vbCrLf & vbCrLf

            classAverageLabel.Text &=
                "Letter grade summary:" & vbCrLf & "A: " & aCount &
                vbCrLf & "B: " & bCount & vbCrLf & "C: " & cCount &
                vbCrLf & "D: " & dCount & vbCrLf & "F: " & fCount &
                vbCrLf & "Perfect scores: " & perfectScoreCount
        Else
            classAverageLabel.Text = "No grades were entered"
        End If
    End Sub

    Private Sub clearGradesButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles clearGradesButton.Click

        gradesListBox.Items.Clear()
        classAverageLabel.Text = String.Empty
    End Sub

    Private Sub Form1_Load(ByVal sender As Object,
            ByVal e As EventArgs) Handles MyBase.Load

        decimalOutputTextBox.AppendText("Decimal" & vbTab & "Octal" &
            vbTab & "Hexadecimal" & vbTab & "Binary" & vbCrLf)

        For number As Integer = 1 To 255
            decimalOutputTextBox.AppendText(number & vbTab &
                Convert.ToString(number, 8) & vbTab &
                Convert.ToString(number, 16).ToUpper() & vbTab & vbTab &
                Convert.ToString(number, 2) & vbCrLf)
        Next number
    End Sub

    Private Sub decimalOutputTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decimalOutputTextBox.TextChanged

    End Sub

    Private Sub tabClassAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabClassAverage.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        'square, rectangle, trapesoid, triangle, circle
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub
End Class
