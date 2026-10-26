<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBibleVerses
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
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblVerseID = New System.Windows.Forms.Label()
        Me.txtVerseID = New System.Windows.Forms.TextBox()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.lblChapter = New System.Windows.Forms.Label()
        Me.txtChapter = New System.Windows.Forms.TextBox()
        Me.lblVerse = New System.Windows.Forms.Label()
        Me.txtVerse = New System.Windows.Forms.TextBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.grpDetails.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.grpDetails.Controls.Add(Me.lblVerseID)
        Me.grpDetails.Controls.Add(Me.txtVerseID)
        Me.grpDetails.Controls.Add(Me.lblBook)
        Me.grpDetails.Controls.Add(Me.txtBook)
        Me.grpDetails.Controls.Add(Me.lblChapter)
        Me.grpDetails.Controls.Add(Me.txtChapter)
        Me.grpDetails.Controls.Add(Me.lblVerse)
        Me.grpDetails.Controls.Add(Me.txtVerse)
        Me.grpDetails.Controls.Add(Me.lblContent)
        Me.grpDetails.Controls.Add(Me.txtContent)
        Me.grpDetails.Controls.Add(Me.lblTranslation)
        Me.grpDetails.Controls.Add(Me.txtTranslation)
        Me.grpDetails.Controls.Add(Me.lblRemarks)
        Me.grpDetails.Controls.Add(Me.txtRemarks)
        Me.grpDetails.Controls.Add(Me.lblCategory)
        Me.grpDetails.Controls.Add(Me.txtCategory)
        Me.grpDetails.Location = New System.Drawing.Point(12, 47)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.grpDetails.Size = New System.Drawing.Size(370, 248)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        Me.lblVerseID.AutoSize = True
        Me.lblVerseID.Location = New System.Drawing.Point(12, 25)
        Me.lblVerseID.Name = "lblVerseID"
        Me.lblVerseID.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblVerseID.Size = New System.Drawing.Size(56, 13)
        Me.lblVerseID.TabIndex = 0
        Me.lblVerseID.Text = "Verse ID:"
        Me.txtVerseID.Location = New System.Drawing.Point(120, 22)
        Me.txtVerseID.Name = "txtVerseID"
        Me.txtVerseID.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtVerseID.ReadOnly = True
        Me.txtVerseID.Size = New System.Drawing.Size(230, 20)
        Me.txtVerseID.TabIndex = 1
        Me.txtVerseID.TabStop = False
        Me.lblBook.AutoSize = True
        Me.lblBook.Location = New System.Drawing.Point(12, 53)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblBook.Size = New System.Drawing.Size(28, 13)
        Me.lblBook.TabIndex = 2
        Me.lblBook.Text = "Book:"
        Me.txtBook.Location = New System.Drawing.Point(120, 50)
        Me.txtBook.MaxLength = 50
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtBook.Size = New System.Drawing.Size(230, 20)
        Me.txtBook.TabIndex = 3
        Me.lblChapter.AutoSize = True
        Me.lblChapter.Location = New System.Drawing.Point(12, 81)
        Me.lblChapter.Name = "lblChapter"
        Me.lblChapter.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblChapter.Size = New System.Drawing.Size(49, 13)
        Me.lblChapter.TabIndex = 4
        Me.lblChapter.Text = "Chapter:"
        Me.txtChapter.Location = New System.Drawing.Point(120, 78)
        Me.txtChapter.MaxLength = 4
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtChapter.Size = New System.Drawing.Size(230, 20)
        Me.txtChapter.TabIndex = 5
        Me.lblVerse.AutoSize = True
        Me.lblVerse.Location = New System.Drawing.Point(12, 109)
        Me.lblVerse.Name = "lblVerse"
        Me.lblVerse.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblVerse.Size = New System.Drawing.Size(35, 13)
        Me.lblVerse.TabIndex = 6
        Me.lblVerse.Text = "Verse:"
        Me.txtVerse.Location = New System.Drawing.Point(120, 106)
        Me.txtVerse.MaxLength = 4
        Me.txtVerse.Name = "txtVerse"
        Me.txtVerse.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtVerse.Size = New System.Drawing.Size(230, 20)
        Me.txtVerse.TabIndex = 7
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(12, 137)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblContent.Size = New System.Drawing.Size(49, 13)
        Me.lblContent.TabIndex = 8
        Me.lblContent.Text = "Content:"
        Me.txtContent.Location = New System.Drawing.Point(120, 134)
        Me.txtContent.MaxLength = 500
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtContent.Size = New System.Drawing.Size(230, 20)
        Me.txtContent.TabIndex = 9
        Me.lblTranslation.AutoSize = True
        Me.lblTranslation.Location = New System.Drawing.Point(12, 165)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblTranslation.Size = New System.Drawing.Size(77, 13)
        Me.lblTranslation.TabIndex = 10
        Me.lblTranslation.Text = "Translation:"
        Me.txtTranslation.Location = New System.Drawing.Point(120, 162)
        Me.txtTranslation.MaxLength = 50
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtTranslation.Size = New System.Drawing.Size(230, 20)
        Me.txtTranslation.TabIndex = 11
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(12, 193)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 12
        Me.lblRemarks.Text = "Remarks:"
        Me.txtRemarks.Location = New System.Drawing.Point(120, 190)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtRemarks.Size = New System.Drawing.Size(230, 20)
        Me.txtRemarks.TabIndex = 13
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(12, 221)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblCategory.Size = New System.Drawing.Size(56, 13)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Category:"
        Me.txtCategory.Location = New System.Drawing.Point(120, 218)
        Me.txtCategory.MaxLength = 50
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.txtCategory.Size = New System.Drawing.Size(230, 20)
        Me.txtCategory.TabIndex = 15
        Me.addButton.Location = New System.Drawing.Point(12, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addButton.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.addButton.Size = New System.Drawing.Size(66, 25)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        Me.updateButton.Location = New System.Drawing.Point(84, 12)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateButton.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.updateButton.Size = New System.Drawing.Size(66, 25)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        Me.deleteButton.Location = New System.Drawing.Point(156, 12)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteButton.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.deleteButton.Size = New System.Drawing.Size(66, 25)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        Me.clearButton.Location = New System.Drawing.Point(228, 12)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearButton.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.clearButton.Size = New System.Drawing.Size(66, 25)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        Me.exitButton.Location = New System.Drawing.Point(300, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitButton.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.exitButton.Size = New System.Drawing.Size(66, 25)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(394, 12)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.grpRecords.Size = New System.Drawing.Size(600, 326)
        Me.grpRecords.TabIndex = 2
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Records"
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(10, 20)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(580, 300)
        Me.dataGridView1.TabIndex = 0
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(12, 348)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Font = New System.Drawing.Font("Calibri", 8.5!)
        Me.lblDatabase.Size = New System.Drawing.Size(56, 13)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 374)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.lblDatabase)
        Me.Name = "frmBibleVerses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bible Verses - Pastor, Lorenz James  |  BSIT 3B"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblVerseID As System.Windows.Forms.Label
    Friend WithEvents txtVerseID As System.Windows.Forms.TextBox
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter As System.Windows.Forms.Label
    Friend WithEvents txtChapter As System.Windows.Forms.TextBox
    Friend WithEvents lblVerse As System.Windows.Forms.Label
    Friend WithEvents txtVerse As System.Windows.Forms.TextBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lblTranslation As System.Windows.Forms.Label
    Friend WithEvents txtTranslation As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDatabase As System.Windows.Forms.Label

End Class
