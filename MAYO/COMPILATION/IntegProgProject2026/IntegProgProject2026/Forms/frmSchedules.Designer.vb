<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedules
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
        Me.lblScheduleID = New System.Windows.Forms.Label()
        Me.txtScheduleID = New System.Windows.Forms.TextBox()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.lblTeacherID = New System.Windows.Forms.Label()
        Me.txtTeacherID = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
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
        Me.grpDetails.Controls.Add(Me.lblScheduleID)
        Me.grpDetails.Controls.Add(Me.txtScheduleID)
        Me.grpDetails.Controls.Add(Me.lblCourseID)
        Me.grpDetails.Controls.Add(Me.txtCourseID)
        Me.grpDetails.Controls.Add(Me.lblTeacherID)
        Me.grpDetails.Controls.Add(Me.txtTeacherID)
        Me.grpDetails.Controls.Add(Me.lblDay)
        Me.grpDetails.Controls.Add(Me.cboDay)
        Me.grpDetails.Controls.Add(Me.lblTime)
        Me.grpDetails.Controls.Add(Me.dtpTime)
        Me.grpDetails.Controls.Add(Me.lblRoom)
        Me.grpDetails.Controls.Add(Me.txtRoom)
        Me.grpDetails.Location = New System.Drawing.Point(624, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.grpDetails.Size = New System.Drawing.Size(370, 192)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        Me.lblScheduleID.AutoSize = True
        Me.lblScheduleID.Location = New System.Drawing.Point(273, 25)
        Me.lblScheduleID.Name = "lblScheduleID"
        Me.lblScheduleID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblScheduleID.Size = New System.Drawing.Size(77, 13)
        Me.lblScheduleID.TabIndex = 0
        Me.lblScheduleID.Text = "Schedule ID:"
        Me.txtScheduleID.Location = New System.Drawing.Point(12, 22)
        Me.txtScheduleID.Name = "txtScheduleID"
        Me.txtScheduleID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtScheduleID.ReadOnly = True
        Me.txtScheduleID.Size = New System.Drawing.Size(230, 20)
        Me.txtScheduleID.TabIndex = 1
        Me.txtScheduleID.TabStop = False
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Location = New System.Drawing.Point(273, 53)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblCourseID.Size = New System.Drawing.Size(63, 13)
        Me.lblCourseID.TabIndex = 2
        Me.lblCourseID.Text = "Course ID:"
        Me.txtCourseID.Location = New System.Drawing.Point(12, 50)
        Me.txtCourseID.MaxLength = 50
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtCourseID.Size = New System.Drawing.Size(230, 20)
        Me.txtCourseID.TabIndex = 3
        Me.lblTeacherID.AutoSize = True
        Me.lblTeacherID.Location = New System.Drawing.Point(273, 81)
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblTeacherID.Size = New System.Drawing.Size(70, 13)
        Me.lblTeacherID.TabIndex = 4
        Me.lblTeacherID.Text = "Teacher ID:"
        Me.txtTeacherID.Location = New System.Drawing.Point(12, 78)
        Me.txtTeacherID.MaxLength = 50
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtTeacherID.Size = New System.Drawing.Size(230, 20)
        Me.txtTeacherID.TabIndex = 5
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(273, 109)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblDay.Size = New System.Drawing.Size(21, 13)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day:"
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cboDay.Location = New System.Drawing.Point(12, 106)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.cboDay.Size = New System.Drawing.Size(230, 21)
        Me.cboDay.TabIndex = 7
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(273, 137)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblTime.Size = New System.Drawing.Size(28, 13)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time:"
        Me.dtpTime.CustomFormat = "HH:mm"
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Location = New System.Drawing.Point(12, 134)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.dtpTime.Size = New System.Drawing.Size(230, 20)
        Me.dtpTime.TabIndex = 9
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(273, 165)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.lblRoom.Size = New System.Drawing.Size(28, 13)
        Me.lblRoom.TabIndex = 10
        Me.lblRoom.Text = "Room:"
        Me.txtRoom.Location = New System.Drawing.Point(12, 162)
        Me.txtRoom.MaxLength = 50
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Font = New System.Drawing.Font("Candara", 8.75!)
        Me.txtRoom.Size = New System.Drawing.Size(230, 20)
        Me.txtRoom.TabIndex = 11
        Me.addButton.Location = New System.Drawing.Point(912, 214)
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
        Me.updateButton.Location = New System.Drawing.Point(840, 214)
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
        Me.deleteButton.Location = New System.Drawing.Point(768, 214)
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
        Me.clearButton.Location = New System.Drawing.Point(696, 214)
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
        Me.exitButton.Location = New System.Drawing.Point(624, 214)
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
        Me.Name = "frmSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedules - Mayo, Mhike Charles  |  BSIT 3B"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblScheduleID As System.Windows.Forms.Label
    Friend WithEvents txtScheduleID As System.Windows.Forms.TextBox
    Friend WithEvents lblCourseID As System.Windows.Forms.Label
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents lblTeacherID As System.Windows.Forms.Label
    Friend WithEvents txtTeacherID As System.Windows.Forms.TextBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDatabase As System.Windows.Forms.Label

End Class
