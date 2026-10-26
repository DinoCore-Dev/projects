' ============================================================
' Activity 4 - Act4_20260703
' Arithmetic Machine : sum, difference, product, quotient and
' average of three numbers entered by the user.
' Author : Lucena, Lyka Joy   |   BSIT 3B
' ============================================================
Public Class Form1

    Private number1 As Double
    Private number2 As Double
    Private number3 As Double
    Private inputsAreValid As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetForm()
        txtN1.Focus()
    End Sub

    ' Reads the three text boxes and stores the values in the
    ' module level variables. Returns False when an entry is not a number.
    Private Function ReadInputs() As Boolean
        Try
            number1 = Convert.ToDouble(txtN1.Text.Trim())
            number2 = Convert.ToDouble(txtN2.Text.Trim())
            number3 = Convert.ToDouble(txtN3.Text.Trim())
            inputsAreValid = True
        Catch ex As Exception
            inputsAreValid = False
            ClearResults()
            lblStatus.Text = "Invalid entry. Please type numbers only (for example 12 or 12.5)."
        End Try
        Return inputsAreValid
    End Function

    Private Sub ShowResult(ByVal target As Label, ByVal value As Double, ByVal operation As String)
        target.Text = value.ToString("N4")
        lblStatus.Text = operation & " = " & value.ToString("N4")
    End Sub

    Private Sub ClearResults()
        lblSumValue.Text = "-"
        lblDiffValue.Text = "-"
        lblProdValue.Text = "-"
        lblQuotValue.Text = "-"
        lblAveValue.Text = "-"
    End Sub

    Private Sub ResetForm()
        txtN1.Clear()
        txtN2.Clear()
        txtN3.Clear()
        ClearResults()
        lblStatus.Text = "Ready. Enter three numbers to begin."
        txtN1.Focus()
    End Sub

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        If Not ReadInputs() Then Return
        ShowResult(lblSumValue, number1 + number2 + number3, "Sum")
    End Sub

    Private Sub btnDifference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDifference.Click
        If Not ReadInputs() Then Return
        ShowResult(lblDiffValue, number1 - number2 - number3, "Difference")
    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        If Not ReadInputs() Then Return
        ShowResult(lblProdValue, number1 * number2 * number3, "Product")
    End Sub

    Private Sub btnQuotient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuotient.Click
        If Not ReadInputs() Then Return
        If number2 = 0 OrElse number3 = 0 Then
            lblQuotValue.Text = "undefined"
            lblStatus.Text = "Quotient is undefined because the second or third number is zero."
            Return
        End If
        ShowResult(lblQuotValue, number1 / number2 / number3, "Quotient")
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        If Not ReadInputs() Then Return
        ShowResult(lblAveValue, (number1 + number2 + number3) / 3, "Average")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Close the Arithmetic Machine?", "Exit", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
