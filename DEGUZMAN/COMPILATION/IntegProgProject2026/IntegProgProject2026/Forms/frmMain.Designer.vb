<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SchedulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibleVerseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolstripUserInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripCurrentDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripCurrentTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.BibleVerseToolStripMenuItem, Me.QuotesToolStripMenuItem, Me.AboutToolStripMenuItem, Me.SchedulesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.SchedulesToolStripMenuItem.Name = "SchedulesToolStripMenuItem"
        Me.SchedulesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SchedulesToolStripMenuItem.Text = "Schedules"
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.QuotesToolStripMenuItem.Name = "QuotesToolStripMenuItem"
        Me.QuotesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuotesToolStripMenuItem.Text = "Quotes"
        Me.BibleVerseToolStripMenuItem.Name = "BibleVerseToolStripMenuItem"
        Me.BibleVerseToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.BibleVerseToolStripMenuItem.Text = "BibleVerse"
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusBar, Me.toolstripCurrentTime, Me.toolstripCurrentDate, Me.toolstripUserInfo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 546)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.toolstripUserInfo.Name = "toolstripUserInfo"
        Me.toolstripUserInfo.Size = New System.Drawing.Size(60, 17)
        Me.toolstripUserInfo.Text = "UserInfo"
        Me.toolstripCurrentDate.Name = "toolstripCurrentDate"
        Me.toolstripCurrentDate.Size = New System.Drawing.Size(76, 17)
        Me.toolstripCurrentDate.Text = "CurrentDate"
        Me.toolstripCurrentTime.Name = "toolstripCurrentTime"
        Me.toolstripCurrentTime.Size = New System.Drawing.Size(80, 17)
        Me.toolstripCurrentTime.Text = "Current Time"
        Me.lblStatusBar.Name = "lblStatusBar"
        Me.lblStatusBar.Size = New System.Drawing.Size(40, 17)
        Me.lblStatusBar.Text = "Ready"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 568)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Integrative Project 2026 - Deguzman, Liza Gaile  |  BSIT 3B"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SchedulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BibleVerseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents toolstripUserInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripCurrentDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripCurrentTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
