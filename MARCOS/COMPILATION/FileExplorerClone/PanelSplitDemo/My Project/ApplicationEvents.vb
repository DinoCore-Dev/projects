Option Strict On
Option Explicit On

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            System.Windows.Forms.MessageBox.Show("The program encountered an unexpected error and will close safely." & vbCrLf & vbCrLf & e.Exception.Message, "Folder Explorer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            e.ExitApplication = True
        End Sub
    End Class
End Namespace
