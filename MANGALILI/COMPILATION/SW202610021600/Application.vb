Imports System
Imports System.Windows.Forms
Module Application
 <STAThread()> Public Sub Main()
  System.Windows.Forms.Application.EnableVisualStyles()
  System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)
  System.Windows.Forms.Application.Run(New MainForm())
 End Sub
End Module
