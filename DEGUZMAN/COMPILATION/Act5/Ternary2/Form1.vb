' ============================================================
' Activity 5 - Ternary2
' Displays the remarks, the letter grade and the numeric rating
' of an average grade using nested ternary (If) operators.
' Author : Deguzman, Liza Gaile   |   BSIT 3B
' ============================================================
Public Class Form1

    Private averageGrade As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearOutputs()
        lblStatus.Text = "Waiting for an average grade."
        txtAverage.Focus()
    End Sub

    Private Sub ClearOutputs()
        lblCard1Value.Text = "--"
        lblCard2Value.Text = "--"
        lblCard3Value.Text = "--"
    End Sub

    Private Sub txtAverage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAverage.KeyPress
        ' Enter key inside the textbox works like clicking the Evaluate button
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnEvaluate.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub btnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluate.Click
        Try
            averageGrade = Convert.ToDouble(txtAverage.Text.Trim())

            ' Remarks 1 : passed / conditional / failed
            lblCard1Value.Text = If(averageGrade >= 75, "Passed",
                                 If(averageGrade >= 70, "Conditional", "Failed"))

            ' Remarks 2 : letter grade
            lblCard2Value.Text = If(averageGrade >= 94, "A",
                                 If(averageGrade >= 89, "B",
                                 If(averageGrade >= 84, "C",
                                 If(averageGrade >= 80, "D",
                                 If(averageGrade >= 75, "E", "F")))))

            ' Remarks 3 : numeric rating
            lblCard3Value.Text = If(averageGrade >= 98, "1.00",
                                 If(averageGrade >= 95, "1.25",
                                 If(averageGrade >= 92, "1.50",
                                 If(averageGrade >= 89, "1.75",
                                 If(averageGrade >= 86, "2.00",
                                 If(averageGrade >= 83, "2.25",
                                 If(averageGrade >= 80, "2.50",
                                 If(averageGrade >= 77, "2.75",
                                 If(averageGrade >= 75, "3.00",
                                 If(averageGrade >= 70, "5.00", "Invalid Grade..."))))))))))

            If averageGrade > 100 OrElse averageGrade < 0 Then
                lblStatus.Text = "The grade " & averageGrade.ToString("0.##") & " is outside the 0 to 100 range."
            Else
                lblStatus.Text = "Average " & averageGrade.ToString("0.##") & " evaluated using nested ternary If operators."
            End If

            ApplyCardColor(averageGrade)
        Catch ex As Exception
            ClearOutputs()
            lblCard1Value.Text = "Invalid"
            lblCard2Value.Text = "Invalid"
            lblCard3Value.Text = "Invalid"
            lblStatus.Text = "Please type a valid number, for example 88.5"
            txtAverage.SelectAll()
            txtAverage.Focus()
        End Try
    End Sub

    ' Small extra touch : the first card changes color with the result
    Private Sub ApplyCardColor(ByVal grade As Double)
        If grade >= 75 Then
            lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74)
        ElseIf grade >= 70 Then
            lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6)
        Else
            lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAverage.Clear()
        ClearOutputs()
        lblStatus.Text = "Cleared. Type another average grade."
        txtAverage.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
