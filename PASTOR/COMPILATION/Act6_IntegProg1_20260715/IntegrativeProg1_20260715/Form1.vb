' ============================================================
' Activity 6 - Act6_IntegProg1_20260715
' Reads three grades, computes the average and displays three
' different remarks using Select Case.
' Author : Pastor, James Lorenz   |   BSIT 3B
' ============================================================
Public Class Form1

    Private grade1 As Double
    Private grade2 As Double
    Private grade3 As Double
    Private averageGrade As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetScreen()
    End Sub

    Private Sub ResetScreen()
        txtG1.Clear()
        txtG2.Clear()
        txtG3.Clear()
        lblAverage.Text = "0.00"
        lblRemarks1.Text = "-"
        lblRemarks2.Text = "-"
        lblRemarks3.Text = "-"
        lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74)
        pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(75, 47, 27)
        lblStatus.Text = "Ready. Enter the three grades."
        txtG1.Focus()
    End Sub

    Private Function ReadGrades() As Boolean
        Try
            grade1 = Convert.ToDouble(txtG1.Text.Trim())
            grade2 = Convert.ToDouble(txtG2.Text.Trim())
            grade3 = Convert.ToDouble(txtG3.Text.Trim())
        Catch ex As Exception
            lblAverage.Text = "0.00"
            lblRemarks1.Text = "Invalid entry"
            lblRemarks2.Text = "Numbers only"
            lblRemarks3.Text = "Numbers only"
            lblStatus.Text = "Only numeric grades are accepted. Example : 88 or 91.5"
            Return False
        End Try

        If grade1 < 0 OrElse grade2 < 0 OrElse grade3 < 0 OrElse _
           grade1 > 100 OrElse grade2 > 100 OrElse grade3 > 100 Then
            lblStatus.Text = "Each grade must be from 0 to 100 only."
            lblRemarks1.Text = "Out of range"
            lblRemarks2.Text = "Out of range"
            lblRemarks3.Text = "Out of range"
            lblAverage.Text = "0.00"
            Return False
        End If

        Return True
    End Function

    Private Sub btnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluate.Click
        If Not ReadGrades() Then Return

        ' Average of the three grades (Double so decimals are kept)
        averageGrade = (grade1 + grade2 + grade3) / 3
        lblAverage.Text = averageGrade.ToString("0.00")

        ' Remarks 1 : passed / conditional / failed
        Select Case averageGrade
            Case Is >= 75
                lblRemarks1.Text = "Passed!"
            Case Is >= 70
                lblRemarks1.Text = "Conditional!"
            Case Else
                lblRemarks1.Text = "Failed!"
        End Select

        ' Remarks 2 : letter grade
        Select Case averageGrade
            Case Is >= 95
                lblRemarks2.Text = "A"
            Case Is >= 89
                lblRemarks2.Text = "B"
            Case Is >= 80
                lblRemarks2.Text = "C"
            Case Is >= 75
                lblRemarks2.Text = "D"
            Case Is >= 70
                lblRemarks2.Text = "E"
            Case Else
                lblRemarks2.Text = "F"
        End Select

        ' Remarks 3 : numeric rating
        Select Case averageGrade
            Case Is >= 98
                lblRemarks3.Text = "1.00"
            Case Is >= 95
                lblRemarks3.Text = "1.25"
            Case Is >= 92
                lblRemarks3.Text = "1.50"
            Case Is >= 89
                lblRemarks3.Text = "1.75"
            Case Is >= 86
                lblRemarks3.Text = "2.00"
            Case Is >= 83
                lblRemarks3.Text = "2.25"
            Case Is >= 80
                lblRemarks3.Text = "2.50"
            Case Is >= 77
                lblRemarks3.Text = "2.75"
            Case Is >= 75
                lblRemarks3.Text = "3.00"
            Case Is >= 70
                lblRemarks3.Text = "4.00"
            Case Else
                lblRemarks3.Text = "5.00"
        End Select

        ShowBadgeColor()
        lblStatus.Text = "Average " & averageGrade.ToString("0.00") & " evaluated with three Select Case blocks."
    End Sub

    Private Sub ShowBadgeColor()
        If averageGrade >= 75 Then
            pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(6, 78, 59)
            lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74)
        ElseIf averageGrade >= 70 Then
            pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(120, 53, 15)
            lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6)
        Else
            pnlAveBadge.BackColor = System.Drawing.Color.FromArgb(127, 29, 29)
            lblRemarks1.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ResetScreen()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
