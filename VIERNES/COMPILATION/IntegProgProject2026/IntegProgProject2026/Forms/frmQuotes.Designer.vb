<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotes
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
        Me.lblQuoteID = New System.Windows.Forms.Label()
        Me.txtQuoteID = New System.Windows.Forms.TextBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblQuoteDate = New System.Windows.Forms.Label()
        Me.dtpQuoteDate = New System.Windows.Forms.DateTimePicker()
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
        Me.grpDetails.Controls.Add(Me.lblQuoteID)
        Me.grpDetails.Controls.Add(Me.txtQuoteID)
        Me.grpDetails.Controls.Add(Me.lblContent)
        Me.grpDetails.Controls.Add(Me.txtContent)
        Me.grpDetails.Controls.Add(Me.lblAuthor)
        Me.grpDetails.Controls.Add(Me.txtAuthor)
        Me.grpDetails.Controls.Add(Me.lblSource)
        Me.grpDetails.Controls.Add(Me.txtSource)
        Me.grpDetails.Controls.Add(Me.lblQuoteDate)
        Me.grpDetails.Controls.Add(Me.dtpQuoteDate)
        Me.grpDetails.Location = New System.Drawing.Point(12, 258)
        Me.grpDetails.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Font = New System.Drawing.Font("Corbel", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpDetails.Size = New System.Drawing.Size(982, 144)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        '
        'lblQuoteID
        '
        Me.lblQuoteID.AutoSize = False
        Me.lblQuoteID.Location = New System.Drawing.Point(14, 26)
        Me.lblQuoteID.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblQuoteID.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblQuoteID.Name = "lblQuoteID"
        Me.lblQuoteID.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblQuoteID.Size = New System.Drawing.Size(295, 16)
        Me.lblQuoteID.TabIndex = 0
        Me.lblQuoteID.Text = "Quote ID:"
        '
        'txtQuoteID
        '
        Me.txtQuoteID.Location = New System.Drawing.Point(14, 44)
        Me.txtQuoteID.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtQuoteID.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtQuoteID.Name = "txtQuoteID"
        Me.txtQuoteID.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.txtQuoteID.ReadOnly = True
        Me.txtQuoteID.Size = New System.Drawing.Size(295, 24)
        Me.txtQuoteID.TabIndex = 1
        Me.txtQuoteID.TabStop = False
        '
        'lblContent
        '
        Me.lblContent.AutoSize = False
        Me.lblContent.Location = New System.Drawing.Point(333, 26)
        Me.lblContent.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblContent.Size = New System.Drawing.Size(295, 16)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "Content:"
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(333, 44)
        Me.txtContent.MaxLength = 500
        Me.txtContent.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtContent.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.txtContent.Size = New System.Drawing.Size(295, 24)
        Me.txtContent.TabIndex = 3
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Location = New System.Drawing.Point(652, 26)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblAuthor.Size = New System.Drawing.Size(295, 16)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "Author:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(652, 44)
        Me.txtAuthor.MaxLength = 100
        Me.txtAuthor.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.txtAuthor.Size = New System.Drawing.Size(295, 24)
        Me.txtAuthor.TabIndex = 5
        '
        'lblSource
        '
        Me.lblSource.AutoSize = False
        Me.lblSource.Location = New System.Drawing.Point(14, 80)
        Me.lblSource.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblSource.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblSource.Size = New System.Drawing.Size(295, 16)
        Me.lblSource.TabIndex = 6
        Me.lblSource.Text = "Source:"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(14, 98)
        Me.txtSource.MaxLength = 150
        Me.txtSource.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtSource.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.txtSource.Size = New System.Drawing.Size(295, 24)
        Me.txtSource.TabIndex = 7
        '
        'lblQuoteDate
        '
        Me.lblQuoteDate.AutoSize = False
        Me.lblQuoteDate.Location = New System.Drawing.Point(333, 80)
        Me.lblQuoteDate.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblQuoteDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblQuoteDate.Name = "lblQuoteDate"
        Me.lblQuoteDate.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblQuoteDate.Size = New System.Drawing.Size(295, 16)
        Me.lblQuoteDate.TabIndex = 8
        Me.lblQuoteDate.Text = "Quote Date:"
        '
        'dtpQuoteDate
        '
        Me.dtpQuoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpQuoteDate.Location = New System.Drawing.Point(333, 98)
        Me.dtpQuoteDate.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.dtpQuoteDate.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.dtpQuoteDate.Name = "dtpQuoteDate"
        Me.dtpQuoteDate.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.dtpQuoteDate.Size = New System.Drawing.Size(295, 24)
        Me.dtpQuoteDate.TabIndex = 9
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(12, 412)
        Me.addButton.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.addButton.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.addButton.FlatAppearance.BorderSize = 1
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Name = "addButton"
        Me.addButton.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.addButton.Size = New System.Drawing.Size(120, 36)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(142, 412)
        Me.updateButton.BackColor = System.Drawing.Color.FromArgb(22, 44, 42)
        Me.updateButton.ForeColor = System.Drawing.Color.FromArgb(123, 226, 189)
        Me.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.updateButton.FlatAppearance.BorderSize = 1
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.updateButton.Size = New System.Drawing.Size(120, 36)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(272, 412)
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(47, 31, 36)
        Me.deleteButton.ForeColor = System.Drawing.Color.FromArgb(250, 163, 163)
        Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(248, 113, 113)
        Me.deleteButton.FlatAppearance.BorderSize = 1
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.deleteButton.Size = New System.Drawing.Size(120, 36)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(402, 412)
        Me.clearButton.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.clearButton.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.clearButton.FlatAppearance.BorderSize = 1
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.clearButton.Size = New System.Drawing.Size(120, 36)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(532, 412)
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.exitButton.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.exitButton.FlatAppearance.BorderSize = 1
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.exitButton.Size = New System.Drawing.Size(120, 36)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'grpRecords
        '
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(12, 10)
        Me.grpRecords.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.grpRecords.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Font = New System.Drawing.Font("Corbel", 9.5!, System.Drawing.FontStyle.Bold)
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
        Me.dataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.dataGridView1.EnableHeadersVisualStyles = False
        Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView1.GridColor = System.Drawing.Color.FromArgb(58, 65, 80)
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 36, 48)
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(16, 78, 60)
        Me.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 27, 35)
        Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Font = New System.Drawing.Font("Corbel", 9.5!)
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(958, 200)
        Me.dataGridView1.TabIndex = 0
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = False
        Me.lblDatabase.Location = New System.Drawing.Point(12, 458)
        Me.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblDatabase.Size = New System.Drawing.Size(982, 18)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        '
        'frmQuotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 492)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.lblDatabase)
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.Name = "frmQuotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotes - Viernes, Mark Syrel  |  BSIT 3B"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuoteID As System.Windows.Forms.Label
    Friend WithEvents txtQuoteID As System.Windows.Forms.TextBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblQuoteDate As System.Windows.Forms.Label
    Friend WithEvents dtpQuoteDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDatabase As System.Windows.Forms.Label

End Class
