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
        '
        'grpDetails
        '
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
        Me.grpDetails.Location = New System.Drawing.Point(12, 10)
        Me.grpDetails.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpDetails.Size = New System.Drawing.Size(792, 230)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        '
        'lblVerseID
        '
        Me.lblVerseID.AutoSize = False
        Me.lblVerseID.Location = New System.Drawing.Point(14, 30)
        Me.lblVerseID.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblVerseID.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblVerseID.Name = "lblVerseID"
        Me.lblVerseID.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblVerseID.Size = New System.Drawing.Size(232, 16)
        Me.lblVerseID.TabIndex = 0
        Me.lblVerseID.Text = "Verse ID:"
        '
        'txtVerseID
        '
        Me.txtVerseID.Location = New System.Drawing.Point(14, 48)
        Me.txtVerseID.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtVerseID.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtVerseID.Name = "txtVerseID"
        Me.txtVerseID.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtVerseID.ReadOnly = True
        Me.txtVerseID.Size = New System.Drawing.Size(232, 24)
        Me.txtVerseID.TabIndex = 1
        Me.txtVerseID.TabStop = False
        '
        'lblBook
        '
        Me.lblBook.AutoSize = False
        Me.lblBook.Location = New System.Drawing.Point(270, 30)
        Me.lblBook.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblBook.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblBook.Size = New System.Drawing.Size(232, 16)
        Me.lblBook.TabIndex = 2
        Me.lblBook.Text = "Book:"
        '
        'txtBook
        '
        Me.txtBook.Location = New System.Drawing.Point(270, 48)
        Me.txtBook.MaxLength = 50
        Me.txtBook.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtBook.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtBook.Size = New System.Drawing.Size(232, 24)
        Me.txtBook.TabIndex = 3
        '
        'lblChapter
        '
        Me.lblChapter.AutoSize = False
        Me.lblChapter.Location = New System.Drawing.Point(526, 30)
        Me.lblChapter.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblChapter.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblChapter.Name = "lblChapter"
        Me.lblChapter.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblChapter.Size = New System.Drawing.Size(232, 16)
        Me.lblChapter.TabIndex = 4
        Me.lblChapter.Text = "Chapter:"
        '
        'txtChapter
        '
        Me.txtChapter.Location = New System.Drawing.Point(526, 48)
        Me.txtChapter.MaxLength = 4
        Me.txtChapter.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtChapter.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtChapter.Size = New System.Drawing.Size(232, 24)
        Me.txtChapter.TabIndex = 5
        '
        'lblVerse
        '
        Me.lblVerse.AutoSize = False
        Me.lblVerse.Location = New System.Drawing.Point(14, 90)
        Me.lblVerse.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblVerse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblVerse.Name = "lblVerse"
        Me.lblVerse.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblVerse.Size = New System.Drawing.Size(232, 16)
        Me.lblVerse.TabIndex = 6
        Me.lblVerse.Text = "Verse:"
        '
        'txtVerse
        '
        Me.txtVerse.Location = New System.Drawing.Point(14, 108)
        Me.txtVerse.MaxLength = 4
        Me.txtVerse.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtVerse.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtVerse.Name = "txtVerse"
        Me.txtVerse.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtVerse.Size = New System.Drawing.Size(232, 24)
        Me.txtVerse.TabIndex = 7
        '
        'lblContent
        '
        Me.lblContent.AutoSize = False
        Me.lblContent.Location = New System.Drawing.Point(270, 90)
        Me.lblContent.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblContent.Size = New System.Drawing.Size(232, 16)
        Me.lblContent.TabIndex = 8
        Me.lblContent.Text = "Content:"
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(270, 108)
        Me.txtContent.MaxLength = 500
        Me.txtContent.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtContent.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtContent.Size = New System.Drawing.Size(232, 24)
        Me.txtContent.TabIndex = 9
        '
        'lblTranslation
        '
        Me.lblTranslation.AutoSize = False
        Me.lblTranslation.Location = New System.Drawing.Point(526, 90)
        Me.lblTranslation.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblTranslation.Size = New System.Drawing.Size(232, 16)
        Me.lblTranslation.TabIndex = 10
        Me.lblTranslation.Text = "Translation:"
        '
        'txtTranslation
        '
        Me.txtTranslation.Location = New System.Drawing.Point(526, 108)
        Me.txtTranslation.MaxLength = 50
        Me.txtTranslation.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtTranslation.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtTranslation.Size = New System.Drawing.Size(232, 24)
        Me.txtTranslation.TabIndex = 11
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = False
        Me.lblRemarks.Location = New System.Drawing.Point(14, 150)
        Me.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblRemarks.Size = New System.Drawing.Size(232, 16)
        Me.lblRemarks.TabIndex = 12
        Me.lblRemarks.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(14, 168)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtRemarks.Size = New System.Drawing.Size(232, 24)
        Me.txtRemarks.TabIndex = 13
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = False
        Me.lblCategory.Location = New System.Drawing.Point(270, 150)
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblCategory.Size = New System.Drawing.Size(232, 16)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Category:"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(270, 168)
        Me.txtCategory.MaxLength = 50
        Me.txtCategory.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtCategory.Size = New System.Drawing.Size(232, 24)
        Me.txtCategory.TabIndex = 15
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(818, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99, 102, 241)
        Me.addButton.FlatAppearance.BorderSize = 1
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.addButton.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.addButton.Size = New System.Drawing.Size(176, 38)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(818, 60)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.BackColor = System.Drawing.Color.FromArgb(12, 52, 66)
        Me.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 170, 200)
        Me.updateButton.FlatAppearance.BorderSize = 1
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.updateButton.ForeColor = System.Drawing.Color.FromArgb(186, 236, 248)
        Me.updateButton.Size = New System.Drawing.Size(176, 38)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(818, 108)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(88, 20, 34)
        Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 60, 90)
        Me.deleteButton.FlatAppearance.BorderSize = 1
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.deleteButton.ForeColor = System.Drawing.Color.FromArgb(255, 214, 220)
        Me.deleteButton.Size = New System.Drawing.Size(176, 38)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(818, 156)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.clearButton.FlatAppearance.BorderSize = 1
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.clearButton.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.clearButton.Size = New System.Drawing.Size(176, 38)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(818, 204)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(48, 48, 66)
        Me.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 152, 182)
        Me.exitButton.FlatAppearance.BorderSize = 1
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!, System.Drawing.FontStyle.Bold)
        Me.exitButton.ForeColor = System.Drawing.Color.FromArgb(224, 226, 240)
        Me.exitButton.Size = New System.Drawing.Size(176, 38)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'grpRecords
        '
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(12, 254)
        Me.grpRecords.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.grpRecords.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpRecords.Size = New System.Drawing.Size(982, 238)
        Me.grpRecords.TabIndex = 2
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Records"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(12, 24)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.dataGridView1.EnableHeadersVisualStyles = False
        Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView1.GridColor = System.Drawing.Color.FromArgb(200, 204, 232)
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(199, 210, 254)
        Me.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(214, 218, 246)
        Me.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 27, 75)
        Me.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(958, 202)
        Me.dataGridView1.TabIndex = 0
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = False
        Me.lblDatabase.Location = New System.Drawing.Point(12, 500)
        Me.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(105, 103, 150)
        Me.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        Me.lblDatabase.Size = New System.Drawing.Size(982, 18)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        '
        'frmBibleVerses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 532)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.lblDatabase)
        Me.BackColor = System.Drawing.Color.FromArgb(244, 245, 252)
        Me.Name = "frmBibleVerses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bible Verses - Sajor, Renz  |  BSIT 3B"
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
