Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombinedSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents tree As TreeView
 Friend WithEvents lv As ListView
 Friend WithEvents open As Button
 Friend WithEvents save As Button
 Friend WithEvents btnRefresh As Button
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.tree=New TreeView() : Me.lv=New ListView() : Me.open=New Button() : Me.save=New Button() : Me.btnRefresh=New Button()
  Me.SuspendLayout()
  Me.open.SetBounds(10,10,100,28) : Me.open.Text="Open file" : Me.save.SetBounds(120,10,100,28) : Me.save.Text="Save As" : Me.btnRefresh.SetBounds(230,10,90,28) : Me.btnRefresh.Text="Refresh" : Me.tree.SetBounds(500,50,380,480) : Me.tree.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left : Me.lv.SetBounds(10,50,480,480) : Me.lv.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.lv.View=View.Details : Me.lv.Columns.Add("Name",300) : Me.lv.Columns.Add("Type",150) : Me.Controls.AddRange(New Control() {Me.tree,Me.lv,Me.open,Me.save,Me.btnRefresh})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 9 - Combined Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.ResumeLayout(False)
 End Sub
End Class
