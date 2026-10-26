Public Class frmAbout

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmAbout] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogStep("Load start")
        Try
            Dim photoPath As String = IO.Path.Combine(Application.StartupPath, "Images\photo.jpg")
            If IO.File.Exists(photoPath) Then
                Dim bytes As Byte() = IO.File.ReadAllBytes(photoPath)
                Using stream As New IO.MemoryStream(bytes)
                    Using photo As Image = Image.FromStream(stream)
                        PictureBox1.Image = New Bitmap(photo)
                    End Using
                End Using
            Else
                LogStep("photo not found: " & photoPath)
            End If
        Catch ex As Exception
            LogStep("photo not loaded: " & ex.Message)
        End Try
        LogStep("Load end")
    End Sub

End Class
