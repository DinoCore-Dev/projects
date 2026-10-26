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
 Friend WithEvents lblAuthor As Label
 Friend WithEvents menuStrip1 As MenuStrip
 Friend WithEvents menuForms As ToolStripMenuItem
 Friend WithEvents menuList As ToolStripMenuItem
 Friend WithEvents menuTree As ToolStripMenuItem
 Friend WithEvents menuOpen As ToolStripMenuItem
 Friend WithEvents menuCombined As ToolStripMenuItem
 Friend WithEvents menuExit As ToolStripMenuItem
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.txtPath=New TextBox() : Me.browse=New Button() : Me.btnRefresh=New Button() : Me.details=New Button() : Me.list=New Button() : Me.lv=New ListView() : Me.lbl=New Label() : Me.lblAuthor=New Label()
  Me.menuStrip1=New MenuStrip() : Me.menuForms=New ToolStripMenuItem() : Me.menuList=New ToolStripMenuItem() : Me.menuTree=New ToolStripMenuItem() : Me.menuOpen=New ToolStripMenuItem() : Me.menuCombined=New ToolStripMenuItem() : Me.menuExit=New ToolStripMenuItem()
  Me.SuspendLayout()
  Me.menuForms.Text="Forms"
  Me.menuList.Text="ListView File Explorer"
  Me.menuTree.Text="TreeView File Explorer"
  Me.menuOpen.Text="OpenFileDialog File Explorer"
  Me.menuCombined.Text="Combined File Explorer"
  Me.menuExit.Text="Exit"
  Me.menuForms.DropDownItems.AddRange(New ToolStripItem() {Me.menuList,Me.menuTree,Me.menuOpen,Me.menuCombined,Me.menuExit})
  Me.menuStrip1.Items.Add(Me.menuForms)
  Me.menuStrip1.Dock=DockStyle.Top
  Me.txtPath.SetBounds(10,38,560,25) : Me.browse.SetBounds(580,36,85,28) : Me.browse.Text="Browse..." : Me.btnRefresh.SetBounds(675,36,75,28) : Me.btnRefresh.Text="Refresh" : Me.details.SetBounds(760,36,70,28) : Me.details.Text="Details" : Me.list.SetBounds(840,36,55,28) : Me.list.Text="List" : Me.lv.SetBounds(10,108,885,460) : Me.lv.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.lv.View=View.Details : Me.lv.FullRowSelect=True : Me.lv.GridLines=True : Me.lv.Columns.Add("Name",300) : Me.lv.Columns.Add("Type",150) : Me.lv.Columns.Add("Modified/Size",200) : Me.lbl.SetBounds(10,73,640,25) : Me.lblAuthor.SetBounds(660,73,230,25) : Me.lblAuthor.TextAlign=ContentAlignment.MiddleRight : Me.lblAuthor.ForeColor=System.Drawing.Color.FromArgb(100,116,139) : Me.lblAuthor.Text="Author: Lucena, Lyka Joy  |  BSIT 3B" : Me.Controls.AddRange(New Control() {Me.txtPath,Me.browse,Me.btnRefresh,Me.details,Me.list,Me.lv,Me.lbl,Me.lblAuthor,Me.menuStrip1})
  Me.ClientSize = New System.Drawing.Size(900, 572)
  Me.Text = "Activity 9 - ListView File Explorer  |  Lucena, Lyka Joy"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.ResumeLayout(False)
 End Sub
End Class
