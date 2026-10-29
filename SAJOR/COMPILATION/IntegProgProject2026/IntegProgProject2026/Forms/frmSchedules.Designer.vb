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
        '
        'grpDetails
        '
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
        'lblScheduleID
        '
        Me.lblScheduleID.AutoSize = False
        Me.lblScheduleID.Location = New System.Drawing.Point(14, 30)
        Me.lblScheduleID.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblScheduleID.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblScheduleID.Name = "lblScheduleID"
        Me.lblScheduleID.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblScheduleID.Size = New System.Drawing.Size(360, 16)
        Me.lblScheduleID.TabIndex = 0
        Me.lblScheduleID.Text = "Schedule ID:"
        '
        'txtScheduleID
        '
        Me.txtScheduleID.Location = New System.Drawing.Point(14, 48)
        Me.txtScheduleID.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtScheduleID.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtScheduleID.Name = "txtScheduleID"
        Me.txtScheduleID.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtScheduleID.ReadOnly = True
        Me.txtScheduleID.Size = New System.Drawing.Size(360, 24)
        Me.txtScheduleID.TabIndex = 1
        Me.txtScheduleID.TabStop = False
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = False
        Me.lblCourseID.Location = New System.Drawing.Point(398, 30)
        Me.lblCourseID.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblCourseID.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblCourseID.Size = New System.Drawing.Size(360, 16)
        Me.lblCourseID.TabIndex = 2
        Me.lblCourseID.Text = "Course ID:"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(398, 48)
        Me.txtCourseID.MaxLength = 50
        Me.txtCourseID.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtCourseID.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtCourseID.Size = New System.Drawing.Size(360, 24)
        Me.txtCourseID.TabIndex = 3
        '
        'lblTeacherID
        '
        Me.lblTeacherID.AutoSize = False
        Me.lblTeacherID.Location = New System.Drawing.Point(14, 90)
        Me.lblTeacherID.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblTeacherID.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblTeacherID.Size = New System.Drawing.Size(360, 16)
        Me.lblTeacherID.TabIndex = 4
        Me.lblTeacherID.Text = "Teacher ID:"
        '
        'txtTeacherID
        '
        Me.txtTeacherID.Location = New System.Drawing.Point(14, 108)
        Me.txtTeacherID.MaxLength = 50
        Me.txtTeacherID.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtTeacherID.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtTeacherID.Size = New System.Drawing.Size(360, 24)
        Me.txtTeacherID.TabIndex = 5
        '
        'lblDay
        '
        Me.lblDay.AutoSize = False
        Me.lblDay.Location = New System.Drawing.Point(398, 90)
        Me.lblDay.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblDay.Size = New System.Drawing.Size(360, 16)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day:"
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cboDay.Location = New System.Drawing.Point(398, 108)
        Me.cboDay.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.cboDay.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.cboDay.Size = New System.Drawing.Size(360, 24)
        Me.cboDay.TabIndex = 7
        '
        'lblTime
        '
        Me.lblTime.AutoSize = False
        Me.lblTime.Location = New System.Drawing.Point(14, 150)
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblTime.Size = New System.Drawing.Size(360, 16)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time:"
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "HH:mm"
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Location = New System.Drawing.Point(14, 168)
        Me.dtpTime.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.dtpTime.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.dtpTime.Size = New System.Drawing.Size(360, 24)
        Me.dtpTime.TabIndex = 9
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = False
        Me.lblRoom.Location = New System.Drawing.Point(398, 150)
        Me.lblRoom.ForeColor = System.Drawing.Color.FromArgb(72, 70, 122)
        Me.lblRoom.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.5!)
        Me.lblRoom.Size = New System.Drawing.Size(360, 16)
        Me.lblRoom.TabIndex = 10
        Me.lblRoom.Text = "Room:"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(398, 168)
        Me.txtRoom.MaxLength = 50
        Me.txtRoom.BackColor = System.Drawing.Color.FromArgb(247, 248, 255)
        Me.txtRoom.ForeColor = System.Drawing.Color.FromArgb(38, 36, 92)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.5!)
        Me.txtRoom.Size = New System.Drawing.Size(360, 24)
        Me.txtRoom.TabIndex = 11
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
        'frmSchedules
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
        Me.Name = "frmSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedules - Sajor, Renz  |  BSIT 3B"
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
