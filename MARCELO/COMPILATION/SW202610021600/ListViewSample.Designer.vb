Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents txtPath As TextBox
 Friend WithEvents browse As Button
 Friend WithEvents btnRefresh As Button
 Friend WithEvents details As Button
 Friend WithEvents list As Button
 Friend WithEvents lv As ListView
 Friend WithEvents lbl As Label
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.txtPath=New TextBox() : Me.browse=New Button() : Me.btnRefresh=New Button() : Me.details=New Button() : Me.list=New Button() : Me.lv=New ListView() : Me.lbl=New Label()
  Me.SuspendLayout()
  Me.txtPath.SetBounds(10,10,560,25) : Me.browse.SetBounds(580,8,85,28) : Me.browse.Text="Browse..." : Me.btnRefresh.SetBounds(675,8,75,28) : Me.btnRefresh.Text="Refresh" : Me.details.SetBounds(760,8,70,28) : Me.details.Text="Details" : Me.list.SetBounds(840,8,55,28) : Me.list.Text="List" : Me.lv.SetBounds(10,45,885,460) : Me.lv.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.lv.View=View.Details : Me.lv.FullRowSelect=True : Me.lv.GridLines=True : Me.lv.Columns.Add("Name",300) : Me.lv.Columns.Add("Type",150) : Me.lv.Columns.Add("Modified/Size",200) : Me.lbl.SetBounds(10,515,800,25) : Me.Controls.AddRange(New Control() {Me.txtPath,Me.browse,Me.btnRefresh,Me.details,Me.list,Me.lv,Me.lbl})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 6 - ListView File Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.ResumeLayout(False)
 End Sub
End Class
