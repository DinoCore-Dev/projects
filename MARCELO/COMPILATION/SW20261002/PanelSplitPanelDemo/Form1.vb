' ============================================================
' Activity 10 - SW20261002  (Panel Demo)
' Demonstrates the most common members of the Panel control :
' Visible, BackColor, BorderStyle, BringToFront, SendToBack,
' Contains, Focus, Refresh, Invalidate and Dispose.
' Author : Marcelo, John Carlo   |   BSIT 3B
' ============================================================
Option Strict On
Option Explicit On

Public Class Form1

    Private actionCounter As Integer = 0
    Private colorIndex As Integer = 0
    Private borderIndex As Integer = 0

    Private ReadOnly palette As Color() = { _
        Color.FromArgb(254, 243, 199), _
        Color.FromArgb(239, 254, 219), _
        Color.FromArgb(220, 252, 231)}

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        WriteLog("Form1 loaded - Panel Playground is ready.")
        WriteLog("pnlWorkspace contains " & pnlWorkspace.Controls.Count.ToString() & " child control(s).")
        pnlNested.TabStop = True
        lblStatus.Text = "Panel demo is ready."
    End Sub

    ' ---------------------------------------------------------
    ' helper routines
    ' ---------------------------------------------------------
    Private Sub WriteLog(ByVal message As String)
        actionCounter += 1
        lstLog.Items.Insert(0, actionCounter.ToString("00") & "  " & message)
        lblStatus.Text = message
        lblCounter.Text = actionCounter.ToString() & " action(s) performed"
    End Sub

    Private Sub OpenSplitLab()
        Dim lab As New Form2()
        lab.Owner = Me
        AddHandler lab.FormClosed, AddressOf SplitLabClosed
        lab.Show()
        Me.Hide()
    End Sub

    Private Sub SplitLabClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If Not Me.IsDisposed Then
            Me.Show()
            WriteLog("Split Panel Lab was closed, Panel Playground is shown again.")
        End If
    End Sub

    ' ---------------------------------------------------------
    ' navigation
    ' ---------------------------------------------------------
    Private Sub btnNavSplit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavSplit.Click
        OpenSplitLab()
    End Sub

    Private Sub mnuSplitLab_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuSplitLab.Click
        OpenSplitLab()
    End Sub

    Private Sub btnNavPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavPanel.Click
        WriteLog("You are already on the Panel demo.")
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    ' ---------------------------------------------------------
    ' grouped controls demo
    ' ---------------------------------------------------------
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim fullName As String = txtName.Text.Trim()
        Dim course As String = txtCourse.Text.Trim()

        If fullName = "" Then
            WriteLog("Nothing saved - the full name box is empty.")
            txtName.Focus()
            Return
        End If

        If course = "" Then
            course = "no course given"
        End If

        WriteLog("Saved from pnlGroup : " & fullName & " - " & course)
    End Sub

    ' ---------------------------------------------------------
    ' Panel API demo buttons
    ' ---------------------------------------------------------
    Private Sub btnToggleGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnToggleGroup.Click
        pnlGroup.Visible = Not pnlGroup.Visible
        btnToggleGroup.Text = If(pnlGroup.Visible, "Show / hide pnlGroup", "pnlGroup is hidden - click to show")
        WriteLog("pnlGroup.Visible = " & pnlGroup.Visible.ToString())
    End Sub

    Private Sub btnSwapColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSwapColor.Click
        colorIndex += 1
        If colorIndex > palette.Length - 1 Then colorIndex = 0

        pnlNested.BackColor = palette(colorIndex)
        lblNestedBadge.BackColor = ControlPaint.Light(palette(colorIndex))
        WriteLog("pnlNested.BackColor changed to " & ColorName(palette(colorIndex)) & ".")
    End Sub

    Private Function ColorName(ByVal value As Color) As String
        If value = palette(0) Then Return "amber"
        If value = palette(1) Then Return "blue"
        Return "green"
    End Function

    Private Sub btnCycleBorder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCycleBorder.Click
        borderIndex += 1
        Select Case borderIndex Mod 3
            Case 0
                pnlWorkspace.BorderStyle = BorderStyle.Fixed3D
            Case 1
                pnlWorkspace.BorderStyle = BorderStyle.FixedSingle
            Case 2
                pnlWorkspace.BorderStyle = BorderStyle.None
        End Select
        WriteLog("pnlWorkspace.BorderStyle = " & pnlWorkspace.BorderStyle.ToString())
    End Sub

    Private Sub btnBringFront_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBringFront.Click
        pnlNested.BringToFront()
        WriteLog("pnlNested.BringToFront() - the child panel is now in front of pnlGroup.")
    End Sub

    Private Sub btnSendBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSendBack.Click
        pnlNested.SendToBack()
        WriteLog("pnlNested.SendToBack() - the child panel moved behind pnlGroup.")
    End Sub

    Private Sub btnContains_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContains.Click
        Dim hasGroup As Boolean = pnlWorkspace.Contains(pnlGroup)
        Dim hasNested As Boolean = pnlWorkspace.Contains(pnlNested)
        Dim hasOutsider As Boolean = pnlMain.Contains(pnlGroup)
        WriteLog("Contains -> pnlGroup : " & hasGroup.ToString() & _
                 ", pnlNested : " & hasNested.ToString() & _
                 ", from pnlMain : " & hasOutsider.ToString())
    End Sub

    Private Sub btnDisposeDemo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisposeDemo.Click
        Dim temporary As New Panel()
        temporary.Controls.Add(New Label())
        temporary.Controls.Add(New TextBox())
        Dim childCount As Integer = temporary.Controls.Count
        temporary.Dispose()
        WriteLog("A temporary panel with " & childCount.ToString() & " child control(s) was disposed safely.")
    End Sub

    Private Sub btnFocusPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFocusPanel.Click
        Dim gotFocus As Boolean = pnlNested.Focus()
        WriteLog("pnlNested.Focus() returned " & gotFocus.ToString() & ".")
    End Sub

    Private Sub btnRedraw_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRedraw.Click
        pnlNested.Refresh()
        pnlWorkspace.Invalidate(True)
        WriteLog("Refresh() and Invalidate(True) requested a redraw of the child panels.")
    End Sub
End Class
