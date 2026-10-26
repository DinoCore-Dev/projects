Public Class frmMain

    Private Sub LogLine(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            toolstripUserInfo.Text = "UserInfo: Marcos, Angela  |  BSIT 3B"
            UpdateDateTime()
            Timer1.Interval = 1000
            Timer1.Start()
            lblStatusBar.Text = "Choose a form from the menu."
            LogLine("main form loaded")
        Catch ex As Exception
            LogLine("main load failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            UpdateDateTime()
        Catch
        End Try
    End Sub

    Private Sub UpdateDateTime()
        toolstripCurrentDate.Text = "CurrentDate: " & Date.Now.ToString("dddd, d MMMM yyyy")
        toolstripCurrentTime.Text = "Current Time: " & Date.Now.ToString("h:mm:ss tt")
    End Sub

    Private Sub SchedulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulesToolStripMenuItem.Click
        ShowChild(GetType(frmSchedules))
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ShowChild(GetType(frmAbout))
    End Sub

    Private Sub QuotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotesToolStripMenuItem.Click
        ShowChild(GetType(frmQuotes))
    End Sub

    Private Sub BibleVerseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BibleVerseToolStripMenuItem.Click
        ShowChild(GetType(frmBibleVerses))
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ShowChild(ByVal formType As Type)
        LogLine("opening " & formType.Name)
        Try
            For Each openForm As Form In Me.MdiChildren
                If openForm.GetType() Is formType Then
                    openForm.Activate()
                    lblStatusBar.Text = "Form: " & openForm.Text
                    LogLine(formType.Name & " already open - activated")
                    Return
                End If
            Next
            Dim child As Form = CType(Activator.CreateInstance(formType), Form)
            child.MdiParent = Me
            child.Show()
            child.WindowState = FormWindowState.Maximized
            lblStatusBar.Text = "Form: " & child.Text
            LogLine(formType.Name & " shown inside main form, Visible=" & child.Visible.ToString())
        Catch ex As Exception
            LogLine(formType.Name & " FAILED: " & ex.GetType().Name & " - " & ex.Message)
            Try
                MessageBox.Show("The form could not be opened." & vbCrLf & vbCrLf & _
                    "Form: " & formType.Name & vbCrLf & vbCrLf & _
                    "Details: " & ex.Message, "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch
            End Try
        End Try
    End Sub

End Class
