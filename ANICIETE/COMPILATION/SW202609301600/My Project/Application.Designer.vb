Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Public Sub New()
            MyBase.New(AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.SW202609301600.ListViewSample
        End Sub
    End Class
End Namespace
