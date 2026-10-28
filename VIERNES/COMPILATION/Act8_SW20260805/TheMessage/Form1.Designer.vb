<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents pnlCompose As System.Windows.Forms.Panel
    Friend WithEvents lblComposeTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitleCaption As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblMessageCaption As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblComposeNote As System.Windows.Forms.Label
    Friend WithEvents pnlIcons As System.Windows.Forms.Panel
    Friend WithEvents lblIconsTitle As System.Windows.Forms.Label
    Friend WithEvents rbInfo As System.Windows.Forms.RadioButton
    Friend WithEvents rbWarning As System.Windows.Forms.RadioButton
    Friend WithEvents rbQuestion As System.Windows.Forms.RadioButton
    Friend WithEvents rbCritical As System.Windows.Forms.RadioButton
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents lblButtonsTitle As System.Windows.Forms.Label
    Friend WithEvents rbOk As System.Windows.Forms.RadioButton
    Friend WithEvents rbOkCancel As System.Windows.Forms.RadioButton
    Friend WithEvents rbYesNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbYesNoCancel As System.Windows.Forms.RadioButton
    Friend WithEvents rbRetryCancel As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbortRetryIgnore As System.Windows.Forms.RadioButton
    Friend WithEvents pnlDefault As System.Windows.Forms.Panel
    Friend WithEvents lblDefaultTitle As System.Windows.Forms.Label
    Friend WithEvents rbDefault1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDefault2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDefault3 As System.Windows.Forms.RadioButton
    Friend WithEvents pnlActions As System.Windows.Forms.Panel
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pnlRuleA As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlCompose = New System.Windows.Forms.Panel()
        Me.lblComposeNote = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblMessageCaption = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitleCaption = New System.Windows.Forms.Label()
        Me.lblComposeTitle = New System.Windows.Forms.Label()
        Me.pnlIcons = New System.Windows.Forms.Panel()
        Me.rbCritical = New System.Windows.Forms.RadioButton()
        Me.rbQuestion = New System.Windows.Forms.RadioButton()
        Me.rbWarning = New System.Windows.Forms.RadioButton()
        Me.rbInfo = New System.Windows.Forms.RadioButton()
        Me.lblIconsTitle = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.rbAbortRetryIgnore = New System.Windows.Forms.RadioButton()
        Me.rbRetryCancel = New System.Windows.Forms.RadioButton()
        Me.rbYesNoCancel = New System.Windows.Forms.RadioButton()
        Me.rbYesNo = New System.Windows.Forms.RadioButton()
        Me.rbOkCancel = New System.Windows.Forms.RadioButton()
        Me.rbOk = New System.Windows.Forms.RadioButton()
        Me.lblButtonsTitle = New System.Windows.Forms.Label()
        Me.pnlDefault = New System.Windows.Forms.Panel()
        Me.rbDefault3 = New System.Windows.Forms.RadioButton()
        Me.rbDefault2 = New System.Windows.Forms.RadioButton()
        Me.rbDefault1 = New System.Windows.Forms.RadioButton()
        Me.lblDefaultTitle = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.pnlRuleA = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCompose.SuspendLayout()
        Me.pnlIcons.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlDefault.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlRuleA.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlHeader.Controls.Add(Me.lblAuthor)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.pnlRuleA)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(250, 600)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = False
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Corbel", 23.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblHeaderTitle.Location = New System.Drawing.Point(24, 46)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(206, 40)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "The Message"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = False
        Me.lblHeaderSub.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblHeaderSub.Location = New System.Drawing.Point(24, 98)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(206, 80)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Activity 8 - Act8_SW20260805  |  MessageBox icon, buttons and default button demo"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.Font = New System.Drawing.Font("Corbel", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.lblAuthor.Location = New System.Drawing.Point(24, 504)
        Me.lblAuthor.AutoSize = False
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(206, 44)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Author : Viernes, Mark Syrel  |  BSIT 3B"
        Me.lblAuthor.TextAlign = System.Windows.Forms.ContentAlignment.TopLeft
        '
        'pnlCompose
        '
        Me.pnlCompose.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlCompose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCompose.Controls.Add(Me.lblComposeNote)
        Me.pnlCompose.Controls.Add(Me.txtMessage)
        Me.pnlCompose.Controls.Add(Me.lblMessageCaption)
        Me.pnlCompose.Controls.Add(Me.txtTitle)
        Me.pnlCompose.Controls.Add(Me.lblTitleCaption)
        Me.pnlCompose.Controls.Add(Me.lblComposeTitle)
        Me.pnlCompose.Location = New System.Drawing.Point(274, 24)
        Me.pnlCompose.Name = "pnlCompose"
        Me.pnlCompose.Size = New System.Drawing.Size(618, 232)
        Me.pnlCompose.TabIndex = 1
        '
        'lblComposeTitle
        '
        Me.lblComposeTitle.AutoSize = False
        Me.lblComposeTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblComposeTitle.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblComposeTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblComposeTitle.Name = "lblComposeTitle"
        Me.lblComposeTitle.Size = New System.Drawing.Size(300, 18)
        Me.lblComposeTitle.TabIndex = 0
        Me.lblComposeTitle.Text = "MESSAGE TO DISPLAY"
        '
        'lblTitleCaption
        '
        Me.lblTitleCaption.AutoSize = False
        Me.lblTitleCaption.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblTitleCaption.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblTitleCaption.Location = New System.Drawing.Point(18, 40)
        Me.lblTitleCaption.Name = "lblTitleCaption"
        Me.lblTitleCaption.Size = New System.Drawing.Size(200, 20)
        Me.lblTitleCaption.TabIndex = 1
        Me.lblTitleCaption.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.txtTitle.Location = New System.Drawing.Point(18, 62)
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(580, 30)
        Me.txtTitle.TabIndex = 2
        '
        'lblMessageCaption
        '
        Me.lblMessageCaption.AutoSize = False
        Me.lblMessageCaption.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblMessageCaption.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.lblMessageCaption.Location = New System.Drawing.Point(18, 100)
        Me.lblMessageCaption.Name = "lblMessageCaption"
        Me.lblMessageCaption.Size = New System.Drawing.Size(200, 20)
        Me.lblMessageCaption.TabIndex = 3
        Me.lblMessageCaption.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.txtMessage.Location = New System.Drawing.Point(18, 122)
        Me.txtMessage.Multiline = True
        Me.txtMessage.BackColor = System.Drawing.Color.FromArgb(12, 14, 19)
        Me.txtMessage.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(580, 70)
        Me.txtMessage.TabIndex = 4
        '
        'lblComposeNote
        '
        Me.lblComposeNote.Font = New System.Drawing.Font("Corbel", 8.0!)
        Me.lblComposeNote.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblComposeNote.Location = New System.Drawing.Point(18, 196)
        Me.lblComposeNote.AutoSize = False
        Me.lblComposeNote.Name = "lblComposeNote"
        Me.lblComposeNote.Size = New System.Drawing.Size(580, 30)
        Me.lblComposeNote.TabIndex = 5
        Me.lblComposeNote.Text = "Fill in the title and the message, then choose one icon, one set of buttons and one" & _
            " default button before clicking Display. The program validates every group first so" & _
            " the message box is always complete."
        '
        'pnlIcons
        '
        Me.pnlIcons.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlIcons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIcons.Controls.Add(Me.rbCritical)
        Me.pnlIcons.Controls.Add(Me.rbQuestion)
        Me.pnlIcons.Controls.Add(Me.rbWarning)
        Me.pnlIcons.Controls.Add(Me.rbInfo)
        Me.pnlIcons.Controls.Add(Me.lblIconsTitle)
        Me.pnlIcons.Location = New System.Drawing.Point(274, 276)
        Me.pnlIcons.Name = "pnlIcons"
        Me.pnlIcons.Size = New System.Drawing.Size(198, 292)
        Me.pnlIcons.TabIndex = 2
        '
        'lblIconsTitle
        '
        Me.lblIconsTitle.AutoSize = False
        Me.lblIconsTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIconsTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblIconsTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblIconsTitle.Name = "lblIconsTitle"
        Me.lblIconsTitle.Size = New System.Drawing.Size(170, 18)
        Me.lblIconsTitle.TabIndex = 0
        Me.lblIconsTitle.Text = "ICON"
        '
        'rbInfo
        '
        Me.rbInfo.AutoSize = False
        Me.rbInfo.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbInfo.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbInfo.Location = New System.Drawing.Point(16, 46)
        Me.rbInfo.Name = "rbInfo"
        Me.rbInfo.Size = New System.Drawing.Size(168, 26)
        Me.rbInfo.TabIndex = 1
        Me.rbInfo.Text = "Information"
        Me.rbInfo.UseVisualStyleBackColor = True
        '
        'rbWarning
        '
        Me.rbWarning.AutoSize = False
        Me.rbWarning.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbWarning.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbWarning.Location = New System.Drawing.Point(16, 84)
        Me.rbWarning.Name = "rbWarning"
        Me.rbWarning.Size = New System.Drawing.Size(168, 26)
        Me.rbWarning.TabIndex = 2
        Me.rbWarning.Text = "Warning"
        Me.rbWarning.UseVisualStyleBackColor = True
        '
        'rbQuestion
        '
        Me.rbQuestion.AutoSize = False
        Me.rbQuestion.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbQuestion.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbQuestion.Location = New System.Drawing.Point(16, 122)
        Me.rbQuestion.Name = "rbQuestion"
        Me.rbQuestion.Size = New System.Drawing.Size(168, 26)
        Me.rbQuestion.TabIndex = 3
        Me.rbQuestion.Text = "Question"
        Me.rbQuestion.UseVisualStyleBackColor = True
        '
        'rbCritical
        '
        Me.rbCritical.AutoSize = False
        Me.rbCritical.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbCritical.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbCritical.Location = New System.Drawing.Point(16, 160)
        Me.rbCritical.Name = "rbCritical"
        Me.rbCritical.Size = New System.Drawing.Size(168, 26)
        Me.rbCritical.TabIndex = 4
        Me.rbCritical.Text = "Critical"
        Me.rbCritical.UseVisualStyleBackColor = True
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlButtons.Controls.Add(Me.rbAbortRetryIgnore)
        Me.pnlButtons.Controls.Add(Me.rbRetryCancel)
        Me.pnlButtons.Controls.Add(Me.rbYesNoCancel)
        Me.pnlButtons.Controls.Add(Me.rbYesNo)
        Me.pnlButtons.Controls.Add(Me.rbOkCancel)
        Me.pnlButtons.Controls.Add(Me.rbOk)
        Me.pnlButtons.Controls.Add(Me.lblButtonsTitle)
        Me.pnlButtons.Location = New System.Drawing.Point(484, 276)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(198, 292)
        Me.pnlButtons.TabIndex = 3
        '
        'lblButtonsTitle
        '
        Me.lblButtonsTitle.AutoSize = False
        Me.lblButtonsTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblButtonsTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblButtonsTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblButtonsTitle.Name = "lblButtonsTitle"
        Me.lblButtonsTitle.Size = New System.Drawing.Size(170, 18)
        Me.lblButtonsTitle.TabIndex = 0
        Me.lblButtonsTitle.Text = "BUTTONS TO DISPLAY"
        '
        'rbOk
        '
        Me.rbOk.AutoSize = False
        Me.rbOk.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbOk.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbOk.Location = New System.Drawing.Point(16, 46)
        Me.rbOk.Name = "rbOk"
        Me.rbOk.Size = New System.Drawing.Size(168, 26)
        Me.rbOk.TabIndex = 1
        Me.rbOk.Text = "OK"
        Me.rbOk.UseVisualStyleBackColor = True
        '
        'rbOkCancel
        '
        Me.rbOkCancel.AutoSize = False
        Me.rbOkCancel.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbOkCancel.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbOkCancel.Location = New System.Drawing.Point(16, 84)
        Me.rbOkCancel.Name = "rbOkCancel"
        Me.rbOkCancel.Size = New System.Drawing.Size(168, 26)
        Me.rbOkCancel.TabIndex = 2
        Me.rbOkCancel.Text = "OK / Cancel"
        Me.rbOkCancel.UseVisualStyleBackColor = True
        '
        'rbYesNo
        '
        Me.rbYesNo.AutoSize = False
        Me.rbYesNo.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbYesNo.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbYesNo.Location = New System.Drawing.Point(16, 122)
        Me.rbYesNo.Name = "rbYesNo"
        Me.rbYesNo.Size = New System.Drawing.Size(168, 26)
        Me.rbYesNo.TabIndex = 3
        Me.rbYesNo.Text = "Yes / No"
        Me.rbYesNo.UseVisualStyleBackColor = True
        '
        'rbYesNoCancel
        '
        Me.rbYesNoCancel.AutoSize = False
        Me.rbYesNoCancel.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbYesNoCancel.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbYesNoCancel.Location = New System.Drawing.Point(16, 160)
        Me.rbYesNoCancel.Name = "rbYesNoCancel"
        Me.rbYesNoCancel.Size = New System.Drawing.Size(168, 26)
        Me.rbYesNoCancel.TabIndex = 4
        Me.rbYesNoCancel.Text = "Yes / No / Cancel"
        Me.rbYesNoCancel.UseVisualStyleBackColor = True
        '
        'rbRetryCancel
        '
        Me.rbRetryCancel.AutoSize = False
        Me.rbRetryCancel.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbRetryCancel.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbRetryCancel.Location = New System.Drawing.Point(16, 198)
        Me.rbRetryCancel.Name = "rbRetryCancel"
        Me.rbRetryCancel.Size = New System.Drawing.Size(168, 26)
        Me.rbRetryCancel.TabIndex = 5
        Me.rbRetryCancel.Text = "Retry / Cancel"
        Me.rbRetryCancel.UseVisualStyleBackColor = True
        '
        'rbAbortRetryIgnore
        '
        Me.rbAbortRetryIgnore.AutoSize = False
        Me.rbAbortRetryIgnore.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbAbortRetryIgnore.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbAbortRetryIgnore.Location = New System.Drawing.Point(16, 236)
        Me.rbAbortRetryIgnore.Name = "rbAbortRetryIgnore"
        Me.rbAbortRetryIgnore.Size = New System.Drawing.Size(168, 26)
        Me.rbAbortRetryIgnore.TabIndex = 6
        Me.rbAbortRetryIgnore.Text = "Abort / Retry / Ignore"
        Me.rbAbortRetryIgnore.UseVisualStyleBackColor = True
        '
        'pnlDefault
        '
        Me.pnlDefault.BackColor = System.Drawing.Color.FromArgb(31, 35, 44)
        Me.pnlDefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDefault.Controls.Add(Me.rbDefault3)
        Me.pnlDefault.Controls.Add(Me.rbDefault2)
        Me.pnlDefault.Controls.Add(Me.rbDefault1)
        Me.pnlDefault.Controls.Add(Me.lblDefaultTitle)
        Me.pnlDefault.Location = New System.Drawing.Point(694, 276)
        Me.pnlDefault.Name = "pnlDefault"
        Me.pnlDefault.Size = New System.Drawing.Size(198, 292)
        Me.pnlDefault.TabIndex = 4
        '
        'lblDefaultTitle
        '
        Me.lblDefaultTitle.AutoSize = False
        Me.lblDefaultTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDefaultTitle.ForeColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.lblDefaultTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblDefaultTitle.Name = "lblDefaultTitle"
        Me.lblDefaultTitle.Size = New System.Drawing.Size(170, 18)
        Me.lblDefaultTitle.TabIndex = 0
        Me.lblDefaultTitle.Text = "DEFAULT BUTTON"
        '
        'rbDefault1
        '
        Me.rbDefault1.AutoSize = False
        Me.rbDefault1.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbDefault1.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbDefault1.Location = New System.Drawing.Point(16, 46)
        Me.rbDefault1.Name = "rbDefault1"
        Me.rbDefault1.Size = New System.Drawing.Size(168, 26)
        Me.rbDefault1.TabIndex = 1
        Me.rbDefault1.Text = "Button 1"
        Me.rbDefault1.UseVisualStyleBackColor = True
        '
        'rbDefault2
        '
        Me.rbDefault2.AutoSize = False
        Me.rbDefault2.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbDefault2.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbDefault2.Location = New System.Drawing.Point(16, 84)
        Me.rbDefault2.Name = "rbDefault2"
        Me.rbDefault2.Size = New System.Drawing.Size(168, 26)
        Me.rbDefault2.TabIndex = 2
        Me.rbDefault2.Text = "Button 2"
        Me.rbDefault2.UseVisualStyleBackColor = True
        '
        'rbDefault3
        '
        Me.rbDefault3.AutoSize = False
        Me.rbDefault3.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.rbDefault3.ForeColor = System.Drawing.Color.FromArgb(236, 239, 244)
        Me.rbDefault3.Location = New System.Drawing.Point(16, 122)
        Me.rbDefault3.Name = "rbDefault3"
        Me.rbDefault3.Size = New System.Drawing.Size(168, 26)
        Me.rbDefault3.TabIndex = 3
        Me.rbDefault3.Text = "Button 3"
        Me.rbDefault3.UseVisualStyleBackColor = True
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(10, 12, 16)
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.lblStatus)
        Me.pnlActions.Controls.Add(Me.btnExit)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnDisplay)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlActions.Location = New System.Drawing.Point(0, 536)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(180, 600)
        Me.pnlActions.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        Me.btnDisplay.FlatAppearance.BorderSize = 1
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDisplay.ForeColor = System.Drawing.Color.FromArgb(8, 20, 16)
        Me.btnDisplay.Location = New System.Drawing.Point(20, 40)
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(110, 231, 183)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(140, 48)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Message"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(34, 38, 46)
        Me.btnClear.FlatAppearance.BorderSize = 1
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(190, 198, 211)
        Me.btnClear.Location = New System.Drawing.Point(20, 100)
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(88, 98, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 40)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(47, 31, 36)
        Me.btnExit.FlatAppearance.BorderSize = 1
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(250, 163, 163)
        Me.btnExit.Location = New System.Drawing.Point(20, 152)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(248, 113, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(141, 152, 170)
        Me.lblStatus.Location = New System.Drawing.Point(16, 330)
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(150, 150)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Ready. Compose a message to begin."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRuleA
        '
        Me.pnlRuleA.Location = New System.Drawing.Point(24, 30)
        Me.pnlRuleA.Size = New System.Drawing.Size(44, 4)
        Me.pnlRuleA.Name = "pnlRuleA"
        Me.pnlRuleA.TabIndex = 0
        Me.pnlRuleA.BackColor = System.Drawing.Color.FromArgb(52, 211, 153)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(17, 19, 25)
        Me.ClientSize = New System.Drawing.Size(1080, 600)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlDefault)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlIcons)
        Me.Controls.Add(Me.pnlCompose)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity 8 - The Message  |  Viernes, Mark Syrel"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlCompose.ResumeLayout(False)
        Me.pnlIcons.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlDefault.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.pnlRuleA.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class
