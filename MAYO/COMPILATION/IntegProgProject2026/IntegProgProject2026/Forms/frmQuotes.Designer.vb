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
        Me.grpDetails.Location = New System.Drawing.Point(624, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.grpDetails.Size = New System.Drawing.Size(370, 164)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        Me.lblQuoteID.AutoSize = True
        Me.lblQuoteID.Location = New System.Drawing.Point(280, 25)
        Me.lblQuoteID.Name = "lblQuoteID"
        Me.lblQuoteID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblQuoteID.Size = New System.Drawing.Size(56, 13)
        Me.lblQuoteID.TabIndex = 0
        Me.lblQuoteID.Text = "Quote ID:"
        Me.txtQuoteID.Location = New System.Drawing.Point(12, 22)
        Me.txtQuoteID.Name = "txtQuoteID"
        Me.txtQuoteID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtQuoteID.ReadOnly = True
        Me.txtQuoteID.Size = New System.Drawing.Size(230, 20)
        Me.txtQuoteID.TabIndex = 1
        Me.txtQuoteID.TabStop = False
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(280, 53)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblContent.Size = New System.Drawing.Size(49, 13)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "Content:"
        Me.txtContent.Location = New System.Drawing.Point(12, 50)
        Me.txtContent.MaxLength = 500
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtContent.Size = New System.Drawing.Size(230, 20)
        Me.txtContent.TabIndex = 3
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(280, 81)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblAuthor.Size = New System.Drawing.Size(42, 13)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "Author:"
        Me.txtAuthor.Location = New System.Drawing.Point(12, 78)
        Me.txtAuthor.MaxLength = 100
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtAuthor.Size = New System.Drawing.Size(230, 20)
        Me.txtAuthor.TabIndex = 5
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(280, 109)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblSource.Size = New System.Drawing.Size(42, 13)
        Me.lblSource.TabIndex = 6
        Me.lblSource.Text = "Source:"
        Me.txtSource.Location = New System.Drawing.Point(12, 106)
        Me.txtSource.MaxLength = 150
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtSource.Size = New System.Drawing.Size(230, 20)
        Me.txtSource.TabIndex = 7
        Me.lblQuoteDate.AutoSize = True
        Me.lblQuoteDate.Location = New System.Drawing.Point(280, 137)
        Me.lblQuoteDate.Name = "lblQuoteDate"
        Me.lblQuoteDate.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblQuoteDate.Size = New System.Drawing.Size(70, 13)
        Me.lblQuoteDate.TabIndex = 8
        Me.lblQuoteDate.Text = "Quote Date:"
        Me.dtpQuoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpQuoteDate.Location = New System.Drawing.Point(12, 134)
        Me.dtpQuoteDate.Name = "dtpQuoteDate"
        Me.dtpQuoteDate.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.dtpQuoteDate.Size = New System.Drawing.Size(230, 20)
        Me.dtpQuoteDate.TabIndex = 9
        Me.addButton.Location = New System.Drawing.Point(912, 186)
        Me.addButton.Name = "addButton"
        Me.addButton.BackColor = System.Drawing.Color.FromArgb(108, 90, 34)
        Me.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 195, 169)
        Me.addButton.FlatAppearance.BorderSize = 4
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.addButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.addButton.Size = New System.Drawing.Size(66, 25)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        Me.updateButton.Location = New System.Drawing.Point(840, 186)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.BackColor = System.Drawing.Color.FromArgb(108, 90, 34)
        Me.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 195, 169)
        Me.updateButton.FlatAppearance.BorderSize = 4
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.updateButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.updateButton.Size = New System.Drawing.Size(66, 25)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = False
        Me.deleteButton.Location = New System.Drawing.Point(768, 186)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(108, 90, 34)
        Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 195, 169)
        Me.deleteButton.FlatAppearance.BorderSize = 4
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.deleteButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.deleteButton.Size = New System.Drawing.Size(66, 25)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = False
        Me.clearButton.Location = New System.Drawing.Point(696, 186)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.BackColor = System.Drawing.Color.FromArgb(108, 90, 34)
        Me.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 195, 169)
        Me.clearButton.FlatAppearance.BorderSize = 4
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.clearButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.clearButton.Size = New System.Drawing.Size(66, 25)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        Me.exitButton.Location = New System.Drawing.Point(624, 186)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(108, 90, 34)
        Me.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 195, 169)
        Me.exitButton.FlatAppearance.BorderSize = 4
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.exitButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
        Me.exitButton.Size = New System.Drawing.Size(66, 25)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(12, 12)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Font = New System.Drawing.Font("Candara", 8.75!)
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
        Me.dataGridView1.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(580, 300)
        Me.dataGridView1.TabIndex = 0
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(12, 348)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Font = New System.Drawing.Font("Candara", 8.75!)
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
        Me.Name = "frmQuotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotes - Mayo, Mhike Charles  |  BSIT 3B"
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
