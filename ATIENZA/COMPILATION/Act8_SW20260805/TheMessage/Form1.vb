' ============================================================
' Activity 8 - Act8_SW20260805
' The Message : composes a MessageBox with a title, a message,
' an icon, a button set and a default button.
' Author : Atienza, Argielyn   |   BSIT 3B
' ============================================================
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrepareForm()
    End Sub

    Private Sub PrepareForm()
        txtTitle.Clear()
        txtMessage.Clear()
        ClearRadioButtons(pnlIcons)
        ClearRadioButtons(pnlButtons)
        ClearRadioButtons(pnlDefault)
        lblStatus.Text = "Ready. Compose a message to begin."
        txtTitle.Focus()
    End Sub

    Private Sub ClearRadioButtons(ByVal host As Control)
        For Each child As Control In host.Controls
            If TypeOf child Is RadioButton Then
                CType(child, RadioButton).Checked = False
            End If
        Next
    End Sub

    ' ------------------------- validation -------------------------
    Private Function ValidateEntry() As Boolean
        If txtTitle.Text.Trim() = "" Then
            MessageBox.Show("Please enter a title.", "Missing Title", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitle.Focus()
            Return False
        End If

        If txtMessage.Text.Trim() = "" Then
            MessageBox.Show("Please enter a message.", "Missing Message", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMessage.Focus()
            Return False
        End If

        If Not (rbInfo.Checked OrElse rbWarning.Checked OrElse rbQuestion.Checked OrElse rbCritical.Checked) Then
            MessageBox.Show("Please select one icon.", "Icon Required", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not (rbOk.Checked OrElse rbOkCancel.Checked OrElse rbYesNo.Checked OrElse _
                rbYesNoCancel.Checked OrElse rbRetryCancel.Checked OrElse rbAbortRetryIgnore.Checked) Then
            MessageBox.Show("Please select the buttons to display.", "Buttons Required", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not (rbDefault1.Checked OrElse rbDefault2.Checked OrElse rbDefault3.Checked) Then
            MessageBox.Show("Please select the default button.", "Default Button Required", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' --------------------- selected MessageBox parts ---------------------
    Private Function ChosenIcon() As MessageBoxIcon
        If rbInfo.Checked Then Return MessageBoxIcon.Information
        If rbWarning.Checked Then Return MessageBoxIcon.Warning
        If rbQuestion.Checked Then Return MessageBoxIcon.Question
        Return MessageBoxIcon.Error
    End Function

    Private Function ChosenButtons() As MessageBoxButtons
        If rbOk.Checked Then Return MessageBoxButtons.OK
        If rbOkCancel.Checked Then Return MessageBoxButtons.OKCancel
        If rbYesNo.Checked Then Return MessageBoxButtons.YesNo
        If rbYesNoCancel.Checked Then Return MessageBoxButtons.YesNoCancel
        If rbRetryCancel.Checked Then Return MessageBoxButtons.RetryCancel
        Return MessageBoxButtons.AbortRetryIgnore
    End Function

    Private Function ChosenDefaultButton() As MessageBoxDefaultButton
        If rbDefault2.Checked Then Return MessageBoxDefaultButton.Button2
        If rbDefault3.Checked Then Return MessageBoxDefaultButton.Button3
        Return MessageBoxDefaultButton.Button1
    End Function

    Private Function DescribeResult(ByVal answer As DialogResult) As String
        Select Case answer
            Case DialogResult.OK
                Return "OK was clicked."
            Case DialogResult.Cancel
                Return "Cancel was clicked."
            Case DialogResult.Yes
                Return "Yes was clicked."
            Case DialogResult.No
                Return "No was clicked."
            Case DialogResult.Retry
                Return "Retry was clicked."
            Case DialogResult.Abort
                Return "Abort was clicked."
            Case DialogResult.Ignore
                Return "Ignore was clicked."
            Case Else
                Return "The message box was closed without a button answer."
        End Select
    End Function

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        If Not ValidateEntry() Then Return

        Try
            Dim answer As DialogResult = MessageBox.Show(txtMessage.Text, txtTitle.Text, _
                                                         ChosenButtons(), ChosenIcon(), _
                                                         ChosenDefaultButton())

            lblStatus.Text = DescribeResult(answer)

            MessageBox.Show(DescribeResult(answer), "Result", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "There is an error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PrepareForm()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
