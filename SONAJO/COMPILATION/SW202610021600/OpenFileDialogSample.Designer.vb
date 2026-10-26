Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenFileDialogSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents one As Button
 Friend WithEvents many As Button
 Friend WithEvents clear As Button
 Friend WithEvents selected As ListBox
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.one=New Button() : Me.many=New Button() : Me.clear=New Button() : Me.selected=New ListBox()
  Me.SuspendLayout()
  Me.one.SetBounds(10,10,130,30) : Me.one.Text="Open one..." : Me.many.SetBounds(150,10,160,30) : Me.many.Text="Open multiple..." : Me.clear.SetBounds(320,10,80,30) : Me.clear.Text="Clear" : Me.selected.SetBounds(10,55,860,470) : Me.selected.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.Controls.AddRange(New Control() {Me.one,Me.many,Me.clear,Me.selected})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 8 - OpenFileDialog"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.ResumeLayout(False)
 End Sub
End Class
