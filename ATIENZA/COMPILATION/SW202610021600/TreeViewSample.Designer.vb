Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents tree As TreeView
 Friend WithEvents selectedPath As TextBox
 Friend WithEvents btnRefresh As Button
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.tree=New TreeView() : Me.selectedPath=New TextBox() : Me.btnRefresh=New Button()
  Me.SuspendLayout()
  Me.tree.SetBounds(10,10,330,520) : Me.tree.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left : Me.selectedPath.SetBounds(360,45,510,25) : Me.selectedPath.ReadOnly=True : Me.btnRefresh.SetBounds(360,10,100,28) : Me.btnRefresh.Text="Refresh" : Me.Controls.AddRange(New Control() {Me.tree,Me.selectedPath,Me.btnRefresh})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 7 - TreeView File Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.ResumeLayout(False)
 End Sub
End Class
