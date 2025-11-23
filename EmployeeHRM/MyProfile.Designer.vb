<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        adminheader_pnl = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        btnSignOut = New FontAwesome.Sharp.IconButton()
        lblAmenities = New Label()
        lblTrainings = New Label()
        lblLeaveApproval = New Label()
        lblEmployeeTrainings = New Label()
        lblPayrollSummary = New Label()
        lblDepartment = New Label()
        lblAttendanceTracker = New Label()
        lblTeamOverview = New Label()
        lblManagement = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        lblSalary = New Label()
        Label49 = New Label()
        lblDashboard = New Label()
        lblMain = New Label()
        Label26 = New Label()
        Label27 = New Label()
        btnEditInformation = New GroupBox()
        btnEditInfo = New FontAwesome.Sharp.IconButton()
        btnCancelInfo = New FontAwesome.Sharp.IconButton()
        btnSaveInfo = New FontAwesome.Sharp.IconButton()
        GroupBox1 = New GroupBox()
        btnEditAccount = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        cbUserType = New ComboBox()
        txtUsername = New TextBox()
        Label29 = New Label()
        txtPassword = New TextBox()
        txtUserID = New TextBox()
        Label52 = New Label()
        Label10 = New Label()
        btnCancelAccount = New FontAwesome.Sharp.IconButton()
        btnSaveAccount = New FontAwesome.Sharp.IconButton()
        cbCivilStatus = New ComboBox()
        cbSex = New ComboBox()
        GroupBox3 = New GroupBox()
        cbContractType = New ComboBox()
        cbEmployeeStatus = New ComboBox()
        dtpDateHired = New DateTimePicker()
        txtDepartment = New TextBox()
        Label11 = New Label()
        Label25 = New Label()
        Label21 = New Label()
        txtJobID = New TextBox()
        Label20 = New Label()
        Label15 = New Label()
        txtDepartmentID = New TextBox()
        Label12 = New Label()
        Label48 = New Label()
        txtJobTitle = New TextBox()
        Label16 = New Label()
        txtYearsOfSevice = New TextBox()
        GroupBox5 = New GroupBox()
        btnEditContact = New FontAwesome.Sharp.IconButton()
        btnCancelContact = New FontAwesome.Sharp.IconButton()
        btnSaveContact = New FontAwesome.Sharp.IconButton()
        txtECAddress = New TextBox()
        Label24 = New Label()
        txtECContactID = New TextBox()
        Label54 = New Label()
        Label3 = New Label()
        txtECPhone = New TextBox()
        Label4 = New Label()
        txtECRelationship = New TextBox()
        Label5 = New Label()
        txtECName = New TextBox()
        txtAddress = New TextBox()
        txtEmployeeID = New TextBox()
        Label19 = New Label()
        txtEmail = New TextBox()
        Label23 = New Label()
        txtPhone = New TextBox()
        Label22 = New Label()
        txtAge = New TextBox()
        dtpBirthDate = New DateTimePicker()
        Label18 = New Label()
        lblfname = New Label()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        Label6 = New Label()
        lblage = New Label()
        Label9 = New Label()
        Label17 = New Label()
        txtMiddleName = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        adminheader_pnl.SuspendLayout()
        Panel2.SuspendLayout()
        btnEditInformation.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(322, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 34)
        Label2.TabIndex = 0
        Label2.Text = "My Profile"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(btnSignOut)
        Panel2.Controls.Add(lblAmenities)
        Panel2.Controls.Add(lblTrainings)
        Panel2.Controls.Add(lblLeaveApproval)
        Panel2.Controls.Add(lblEmployeeTrainings)
        Panel2.Controls.Add(lblPayrollSummary)
        Panel2.Controls.Add(lblDepartment)
        Panel2.Controls.Add(lblAttendanceTracker)
        Panel2.Controls.Add(lblTeamOverview)
        Panel2.Controls.Add(lblManagement)
        Panel2.Controls.Add(lblMyProfile)
        Panel2.Controls.Add(lblAttendance)
        Panel2.Controls.Add(lblLeaveManagement)
        Panel2.Controls.Add(lblSalary)
        Panel2.Controls.Add(Label49)
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(lblMain)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Location = New Point(-6, -6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 28
        ' 
        ' btnSignOut
        ' 
        btnSignOut.BackColor = Color.SteelBlue
        btnSignOut.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignOut.ForeColor = Color.White
        btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnSignOut.IconColor = Color.White
        btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSignOut.IconSize = 38
        btnSignOut.ImageAlign = ContentAlignment.MiddleLeft
        btnSignOut.Location = New Point(30, 1080)
        btnSignOut.Name = "btnSignOut"
        btnSignOut.Size = New Size(308, 54)
        btnSignOut.TabIndex = 80
        btnSignOut.Text = "Sign Out"
        btnSignOut.TextAlign = ContentAlignment.MiddleRight
        btnSignOut.UseVisualStyleBackColor = False
        ' 
        ' lblAmenities
        ' 
        lblAmenities.AutoSize = True
        lblAmenities.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmenities.ForeColor = Color.White
        lblAmenities.Location = New Point(53, 780)
        lblAmenities.Name = "lblAmenities"
        lblAmenities.Size = New Size(118, 27)
        lblAmenities.TabIndex = 34
        lblAmenities.Text = "Amenties"
        ' 
        ' lblTrainings
        ' 
        lblTrainings.AutoSize = True
        lblTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrainings.ForeColor = Color.White
        lblTrainings.Location = New Point(53, 430)
        lblTrainings.Name = "lblTrainings"
        lblTrainings.Size = New Size(110, 27)
        lblTrainings.TabIndex = 33
        lblTrainings.Text = "Trainings"
        ' 
        ' lblLeaveApproval
        ' 
        lblLeaveApproval.AutoSize = True
        lblLeaveApproval.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveApproval.ForeColor = Color.White
        lblLeaveApproval.Location = New Point(53, 620)
        lblLeaveApproval.Name = "lblLeaveApproval"
        lblLeaveApproval.Size = New Size(198, 27)
        lblLeaveApproval.TabIndex = 32
        lblLeaveApproval.Text = "Leave Approval"
        ' 
        ' lblEmployeeTrainings
        ' 
        lblEmployeeTrainings.AutoSize = True
        lblEmployeeTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployeeTrainings.ForeColor = Color.White
        lblEmployeeTrainings.Location = New Point(53, 700)
        lblEmployeeTrainings.Name = "lblEmployeeTrainings"
        lblEmployeeTrainings.Size = New Size(230, 27)
        lblEmployeeTrainings.TabIndex = 31
        lblEmployeeTrainings.Text = "Employee Trainings"
        ' 
        ' lblPayrollSummary
        ' 
        lblPayrollSummary.AutoSize = True
        lblPayrollSummary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPayrollSummary.ForeColor = Color.White
        lblPayrollSummary.Location = New Point(53, 660)
        lblPayrollSummary.Name = "lblPayrollSummary"
        lblPayrollSummary.Size = New Size(200, 27)
        lblPayrollSummary.TabIndex = 30
        lblPayrollSummary.Text = "Payroll Summary"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDepartment.ForeColor = Color.White
        lblDepartment.Location = New Point(53, 740)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(150, 27)
        lblDepartment.TabIndex = 29
        lblDepartment.Text = "Department"
        ' 
        ' lblAttendanceTracker
        ' 
        lblAttendanceTracker.AutoSize = True
        lblAttendanceTracker.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendanceTracker.ForeColor = Color.White
        lblAttendanceTracker.Location = New Point(53, 580)
        lblAttendanceTracker.Name = "lblAttendanceTracker"
        lblAttendanceTracker.Size = New Size(239, 27)
        lblAttendanceTracker.TabIndex = 28
        lblAttendanceTracker.Text = "Attendance Tracker"
        ' 
        ' lblTeamOverview
        ' 
        lblTeamOverview.AutoSize = True
        lblTeamOverview.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTeamOverview.ForeColor = Color.White
        lblTeamOverview.Location = New Point(53, 540)
        lblTeamOverview.Name = "lblTeamOverview"
        lblTeamOverview.Size = New Size(195, 27)
        lblTeamOverview.TabIndex = 27
        lblTeamOverview.Text = "Team Overview"
        ' 
        ' lblManagement
        ' 
        lblManagement.AutoSize = True
        lblManagement.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblManagement.ForeColor = Color.White
        lblManagement.Location = New Point(30, 500)
        lblManagement.Name = "lblManagement"
        lblManagement.Size = New Size(135, 22)
        lblManagement.TabIndex = 26
        lblManagement.Text = "MANAGEMENT"
        ' 
        ' lblMyProfile
        ' 
        lblMyProfile.AutoSize = True
        lblMyProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMyProfile.ForeColor = Color.White
        lblMyProfile.Location = New Point(53, 270)
        lblMyProfile.Name = "lblMyProfile"
        lblMyProfile.Size = New Size(124, 27)
        lblMyProfile.TabIndex = 25
        lblMyProfile.Text = "My Profile"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.AutoSize = True
        lblAttendance.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendance.ForeColor = Color.White
        lblAttendance.Location = New Point(53, 310)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(150, 27)
        lblAttendance.TabIndex = 24
        lblAttendance.Text = "Attendance"
        ' 
        ' lblLeaveManagement
        ' 
        lblLeaveManagement.AutoSize = True
        lblLeaveManagement.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveManagement.ForeColor = Color.White
        lblLeaveManagement.Location = New Point(53, 350)
        lblLeaveManagement.Name = "lblLeaveManagement"
        lblLeaveManagement.Size = New Size(248, 27)
        lblLeaveManagement.TabIndex = 23
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(53, 390)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(81, 27)
        lblSalary.TabIndex = 22
        lblSalary.Text = "Salary"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label49.ForeColor = Color.White
        Label49.Location = New Point(30, 230)
        Label49.Name = "Label49"
        Label49.Size = New Size(98, 22)
        Label49.TabIndex = 21
        Label49.Text = "OVERVIEW"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(53, 160)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(138, 27)
        lblDashboard.TabIndex = 20
        lblDashboard.Text = "Dashboard"
        ' 
        ' lblMain
        ' 
        lblMain.AutoSize = True
        lblMain.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMain.ForeColor = Color.White
        lblMain.Location = New Point(30, 120)
        lblMain.Name = "lblMain"
        lblMain.Size = New Size(57, 22)
        lblMain.TabIndex = 19
        lblMain.Text = "MAIN"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(85, 35)
        Label26.Name = "Label26"
        Label26.Size = New Size(197, 34)
        Label26.TabIndex = 12
        Label26.Text = " HR System"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.White
        Label27.Location = New Point(30, 65)
        Label27.Name = "Label27"
        Label27.Size = New Size(312, 27)
        Label27.TabIndex = 11
        Label27.Text = "                                                  "
        ' 
        ' btnEditInformation
        ' 
        btnEditInformation.BackgroundImageLayout = ImageLayout.Zoom
        btnEditInformation.Controls.Add(btnEditInfo)
        btnEditInformation.Controls.Add(btnCancelInfo)
        btnEditInformation.Controls.Add(btnSaveInfo)
        btnEditInformation.Controls.Add(GroupBox1)
        btnEditInformation.Controls.Add(cbCivilStatus)
        btnEditInformation.Controls.Add(cbSex)
        btnEditInformation.Controls.Add(GroupBox3)
        btnEditInformation.Controls.Add(GroupBox5)
        btnEditInformation.Controls.Add(txtAddress)
        btnEditInformation.Controls.Add(txtEmployeeID)
        btnEditInformation.Controls.Add(Label19)
        btnEditInformation.Controls.Add(txtEmail)
        btnEditInformation.Controls.Add(Label23)
        btnEditInformation.Controls.Add(txtPhone)
        btnEditInformation.Controls.Add(Label22)
        btnEditInformation.Controls.Add(txtAge)
        btnEditInformation.Controls.Add(dtpBirthDate)
        btnEditInformation.Controls.Add(Label18)
        btnEditInformation.Controls.Add(lblfname)
        btnEditInformation.Controls.Add(txtLastName)
        btnEditInformation.Controls.Add(txtFirstName)
        btnEditInformation.Controls.Add(Label6)
        btnEditInformation.Controls.Add(lblage)
        btnEditInformation.Controls.Add(Label9)
        btnEditInformation.Controls.Add(Label17)
        btnEditInformation.Controls.Add(txtMiddleName)
        btnEditInformation.Controls.Add(Label14)
        btnEditInformation.Controls.Add(Label13)
        btnEditInformation.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditInformation.Location = New Point(375, 114)
        btnEditInformation.Name = "btnEditInformation"
        btnEditInformation.Size = New Size(1355, 1009)
        btnEditInformation.TabIndex = 90
        btnEditInformation.TabStop = False
        btnEditInformation.Text = "Employee Information"
        ' 
        ' btnEditInfo
        ' 
        btnEditInfo.BackColor = SystemColors.InactiveCaption
        btnEditInfo.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditInfo.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditInfo.IconColor = Color.Black
        btnEditInfo.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditInfo.IconSize = 40
        btnEditInfo.ImageAlign = ContentAlignment.MiddleLeft
        btnEditInfo.Location = New Point(870, 228)
        btnEditInfo.Name = "btnEditInfo"
        btnEditInfo.Size = New Size(406, 69)
        btnEditInfo.TabIndex = 111
        btnEditInfo.Text = "Edit Information" & vbCrLf
        btnEditInfo.TextAlign = ContentAlignment.MiddleRight
        btnEditInfo.UseVisualStyleBackColor = False
        ' 
        ' btnCancelInfo
        ' 
        btnCancelInfo.BackColor = SystemColors.InactiveCaption
        btnCancelInfo.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelInfo.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelInfo.IconColor = Color.Black
        btnCancelInfo.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelInfo.IconSize = 35
        btnCancelInfo.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelInfo.Location = New Point(1066, 229)
        btnCancelInfo.Name = "btnCancelInfo"
        btnCancelInfo.Size = New Size(211, 68)
        btnCancelInfo.TabIndex = 113
        btnCancelInfo.Text = "Cancel"
        btnCancelInfo.TextAlign = ContentAlignment.MiddleRight
        btnCancelInfo.UseVisualStyleBackColor = False
        ' 
        ' btnSaveInfo
        ' 
        btnSaveInfo.BackColor = SystemColors.InactiveCaption
        btnSaveInfo.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveInfo.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveInfo.IconColor = Color.Black
        btnSaveInfo.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveInfo.IconSize = 35
        btnSaveInfo.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveInfo.Location = New Point(870, 229)
        btnSaveInfo.Name = "btnSaveInfo"
        btnSaveInfo.Size = New Size(198, 69)
        btnSaveInfo.TabIndex = 112
        btnSaveInfo.Text = "Save"
        btnSaveInfo.TextAlign = ContentAlignment.MiddleRight
        btnSaveInfo.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnEditAccount)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cbUserType)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label29)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUserID)
        GroupBox1.Controls.Add(Label52)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(btnCancelAccount)
        GroupBox1.Controls.Add(btnSaveAccount)
        GroupBox1.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(63, 399)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1230, 155)
        GroupBox1.TabIndex = 108
        GroupBox1.TabStop = False
        GroupBox1.Text = "Account "
        ' 
        ' btnEditAccount
        ' 
        btnEditAccount.BackColor = SystemColors.InactiveCaption
        btnEditAccount.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditAccount.IconColor = Color.Black
        btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditAccount.IconSize = 35
        btnEditAccount.ImageAlign = ContentAlignment.MiddleLeft
        btnEditAccount.Location = New Point(929, 49)
        btnEditAccount.Name = "btnEditAccount"
        btnEditAccount.Size = New Size(271, 69)
        btnEditAccount.TabIndex = 108
        btnEditAccount.Text = "Edit Account"
        btnEditAccount.TextAlign = ContentAlignment.MiddleRight
        btnEditAccount.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F)
        Label1.Location = New Point(466, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 23)
        Label1.TabIndex = 75
        Label1.Text = "Username:"
        ' 
        ' cbUserType
        ' 
        cbUserType.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cbUserType.FormattingEnabled = True
        cbUserType.Location = New Point(168, 92)
        cbUserType.Name = "cbUserType"
        cbUserType.Size = New Size(271, 31)
        cbUserType.TabIndex = 107
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtUsername.Location = New Point(585, 49)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(271, 32)
        txtUsername.TabIndex = 76
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century Gothic", 12F)
        Label29.Location = New Point(471, 101)
        Label29.Name = "Label29"
        Label29.Size = New Size(108, 23)
        Label29.TabIndex = 68
        Label29.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtPassword.Location = New Point(585, 92)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(271, 32)
        txtPassword.TabIndex = 71
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtUserID.Location = New Point(168, 49)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(271, 32)
        txtUserID.TabIndex = 48
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Font = New Font("Century Gothic", 12F)
        Label52.ForeColor = Color.Black
        Label52.Location = New Point(55, 100)
        Label52.Name = "Label52"
        Label52.Size = New Size(107, 23)
        Label52.TabIndex = 30
        Label52.Text = "User Type:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(81, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 23)
        Label10.TabIndex = 47
        Label10.Text = "User ID:"
        ' 
        ' btnCancelAccount
        ' 
        btnCancelAccount.BackColor = SystemColors.InactiveCaption
        btnCancelAccount.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelAccount.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelAccount.IconColor = Color.Black
        btnCancelAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelAccount.IconSize = 35
        btnCancelAccount.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelAccount.Location = New Point(1065, 48)
        btnCancelAccount.Name = "btnCancelAccount"
        btnCancelAccount.Size = New Size(135, 68)
        btnCancelAccount.TabIndex = 110
        btnCancelAccount.Text = "Cancel"
        btnCancelAccount.TextAlign = ContentAlignment.MiddleRight
        btnCancelAccount.UseVisualStyleBackColor = False
        ' 
        ' btnSaveAccount
        ' 
        btnSaveAccount.BackColor = SystemColors.InactiveCaption
        btnSaveAccount.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveAccount.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveAccount.IconColor = Color.Black
        btnSaveAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveAccount.IconSize = 35
        btnSaveAccount.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveAccount.Location = New Point(929, 49)
        btnSaveAccount.Name = "btnSaveAccount"
        btnSaveAccount.Size = New Size(137, 69)
        btnSaveAccount.TabIndex = 109
        btnSaveAccount.Text = "Save"
        btnSaveAccount.TextAlign = ContentAlignment.MiddleRight
        btnSaveAccount.UseVisualStyleBackColor = False
        ' 
        ' cbCivilStatus
        ' 
        cbCivilStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cbCivilStatus.FormattingEnabled = True
        cbCivilStatus.Location = New Point(247, 355)
        cbCivilStatus.Name = "cbCivilStatus"
        cbCivilStatus.Size = New Size(407, 31)
        cbCivilStatus.TabIndex = 106
        ' 
        ' cbSex
        ' 
        cbSex.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cbSex.FormattingEnabled = True
        cbSex.Location = New Point(247, 313)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(407, 31)
        cbSex.TabIndex = 105
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(cbContractType)
        GroupBox3.Controls.Add(cbEmployeeStatus)
        GroupBox3.Controls.Add(dtpDateHired)
        GroupBox3.Controls.Add(txtDepartment)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(txtJobID)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(txtDepartmentID)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Label48)
        GroupBox3.Controls.Add(txtJobTitle)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(txtYearsOfSevice)
        GroupBox3.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(63, 555)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(650, 406)
        GroupBox3.TabIndex = 88
        GroupBox3.TabStop = False
        GroupBox3.Text = "Job Details"
        ' 
        ' cbContractType
        ' 
        cbContractType.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cbContractType.FormattingEnabled = True
        cbContractType.Location = New Point(246, 264)
        cbContractType.Name = "cbContractType"
        cbContractType.Size = New Size(357, 31)
        cbContractType.TabIndex = 107
        ' 
        ' cbEmployeeStatus
        ' 
        cbEmployeeStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cbEmployeeStatus.FormattingEnabled = True
        cbEmployeeStatus.Location = New Point(246, 222)
        cbEmployeeStatus.Name = "cbEmployeeStatus"
        cbEmployeeStatus.Size = New Size(357, 31)
        cbEmployeeStatus.TabIndex = 106
        ' 
        ' dtpDateHired
        ' 
        dtpDateHired.CustomFormat = "mm/dd/yyyy"
        dtpDateHired.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpDateHired.Location = New Point(246, 306)
        dtpDateHired.Name = "dtpDateHired"
        dtpDateHired.Size = New Size(357, 32)
        dtpDateHired.TabIndex = 49
        dtpDateHired.Value = New Date(2025, 9, 13, 1, 11, 7, 0)
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtDepartment.Location = New Point(246, 179)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(355, 32)
        txtDepartment.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12F)
        Label11.Location = New Point(79, 145)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 23)
        Label11.TabIndex = 17
        Label11.Text = "Department ID:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 12F)
        Label25.Location = New Point(162, 59)
        Label25.Name = "Label25"
        Label25.Size = New Size(78, 23)
        Label25.TabIndex = 19
        Label25.Text = "Job ID:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 12F)
        Label21.Location = New Point(146, 102)
        Label21.Name = "Label21"
        Label21.Size = New Size(94, 23)
        Label21.TabIndex = 0
        Label21.Text = "Job Title:"
        ' 
        ' txtJobID
        ' 
        txtJobID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtJobID.Location = New Point(246, 50)
        txtJobID.Name = "txtJobID"
        txtJobID.Size = New Size(355, 32)
        txtJobID.TabIndex = 18
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 12F)
        Label20.Location = New Point(120, 313)
        Label20.Name = "Label20"
        Label20.Size = New Size(120, 23)
        Label20.TabIndex = 1
        Label20.Text = "Date Hired:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 12F)
        Label15.Location = New Point(37, 230)
        Label15.Name = "Label15"
        Label15.Size = New Size(203, 23)
        Label15.TabIndex = 3
        Label15.Text = "Employment Status:"
        ' 
        ' txtDepartmentID
        ' 
        txtDepartmentID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtDepartmentID.Location = New Point(246, 136)
        txtDepartmentID.Name = "txtDepartmentID"
        txtDepartmentID.Size = New Size(355, 32)
        txtDepartmentID.TabIndex = 16
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F)
        Label12.Location = New Point(85, 272)
        Label12.Name = "Label12"
        Label12.Size = New Size(155, 23)
        Label12.TabIndex = 4
        Label12.Text = "Contract Type:"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Century Gothic", 12F)
        Label48.Location = New Point(105, 188)
        Label48.Name = "Label48"
        Label48.Size = New Size(135, 23)
        Label48.TabIndex = 15
        Label48.Text = "Department:"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtJobTitle.Location = New Point(246, 93)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(355, 32)
        txtJobTitle.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 12F)
        Label16.Location = New Point(67, 358)
        Label16.Name = "Label16"
        Label16.Size = New Size(171, 23)
        Label16.TabIndex = 15
        Label16.Text = "Years of Service:"
        ' 
        ' txtYearsOfSevice
        ' 
        txtYearsOfSevice.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtYearsOfSevice.Location = New Point(244, 349)
        txtYearsOfSevice.Name = "txtYearsOfSevice"
        txtYearsOfSevice.Size = New Size(357, 32)
        txtYearsOfSevice.TabIndex = 13
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(btnEditContact)
        GroupBox5.Controls.Add(btnCancelContact)
        GroupBox5.Controls.Add(btnSaveContact)
        GroupBox5.Controls.Add(txtECAddress)
        GroupBox5.Controls.Add(Label24)
        GroupBox5.Controls.Add(txtECContactID)
        GroupBox5.Controls.Add(Label54)
        GroupBox5.Controls.Add(Label3)
        GroupBox5.Controls.Add(txtECPhone)
        GroupBox5.Controls.Add(Label4)
        GroupBox5.Controls.Add(txtECRelationship)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(txtECName)
        GroupBox5.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(731, 557)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(562, 404)
        GroupBox5.TabIndex = 87
        GroupBox5.TabStop = False
        GroupBox5.Text = "Emergency Contact"
        ' 
        ' btnEditContact
        ' 
        btnEditContact.BackColor = SystemColors.InactiveCaption
        btnEditContact.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditContact.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditContact.IconColor = Color.Black
        btnEditContact.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditContact.IconSize = 35
        btnEditContact.ImageAlign = ContentAlignment.MiddleLeft
        btnEditContact.Location = New Point(193, 328)
        btnEditContact.Name = "btnEditContact"
        btnEditContact.Size = New Size(325, 62)
        btnEditContact.TabIndex = 111
        btnEditContact.Text = "Edit Emergency Contact"
        btnEditContact.TextAlign = ContentAlignment.MiddleRight
        btnEditContact.UseVisualStyleBackColor = False
        ' 
        ' btnCancelContact
        ' 
        btnCancelContact.BackColor = SystemColors.InactiveCaption
        btnCancelContact.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelContact.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelContact.IconColor = Color.Black
        btnCancelContact.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelContact.IconSize = 35
        btnCancelContact.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelContact.Location = New Point(357, 329)
        btnCancelContact.Name = "btnCancelContact"
        btnCancelContact.Size = New Size(161, 61)
        btnCancelContact.TabIndex = 113
        btnCancelContact.Text = "Cancel"
        btnCancelContact.TextAlign = ContentAlignment.MiddleRight
        btnCancelContact.UseVisualStyleBackColor = False
        ' 
        ' btnSaveContact
        ' 
        btnSaveContact.BackColor = SystemColors.InactiveCaption
        btnSaveContact.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveContact.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveContact.IconColor = Color.Black
        btnSaveContact.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveContact.IconSize = 35
        btnSaveContact.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveContact.Location = New Point(196, 329)
        btnSaveContact.Name = "btnSaveContact"
        btnSaveContact.Size = New Size(161, 62)
        btnSaveContact.TabIndex = 112
        btnSaveContact.Text = "Save"
        btnSaveContact.TextAlign = ContentAlignment.MiddleRight
        btnSaveContact.UseVisualStyleBackColor = False
        ' 
        ' txtECAddress
        ' 
        txtECAddress.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtECAddress.Location = New Point(193, 225)
        txtECAddress.Multiline = True
        txtECAddress.Name = "txtECAddress"
        txtECAddress.Size = New Size(325, 82)
        txtECAddress.TabIndex = 77
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 12F)
        Label24.Location = New Point(64, 54)
        Label24.Name = "Label24"
        Label24.Size = New Size(123, 23)
        Label24.TabIndex = 75
        Label24.Text = "Contact ID:"
        ' 
        ' txtECContactID
        ' 
        txtECContactID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtECContactID.Location = New Point(193, 45)
        txtECContactID.Name = "txtECContactID"
        txtECContactID.Size = New Size(325, 32)
        txtECContactID.TabIndex = 76
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Century Gothic", 12F)
        Label54.Location = New Point(94, 228)
        Label54.Name = "Label54"
        Label54.Size = New Size(93, 23)
        Label54.TabIndex = 74
        Label54.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F)
        Label3.Location = New Point(111, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 23)
        Label3.TabIndex = 68
        Label3.Text = "Name:"
        ' 
        ' txtECPhone
        ' 
        txtECPhone.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtECPhone.Location = New Point(193, 180)
        txtECPhone.Name = "txtECPhone"
        txtECPhone.Size = New Size(325, 32)
        txtECPhone.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F)
        Label4.Location = New Point(56, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 23)
        Label4.TabIndex = 69
        Label4.Text = "Relationship:"
        ' 
        ' txtECRelationship
        ' 
        txtECRelationship.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtECRelationship.Location = New Point(193, 135)
        txtECRelationship.Name = "txtECRelationship"
        txtECRelationship.Size = New Size(325, 32)
        txtECRelationship.TabIndex = 72
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F)
        Label5.Location = New Point(25, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 23)
        Label5.TabIndex = 70
        Label5.Text = "Phone Number:"
        ' 
        ' txtECName
        ' 
        txtECName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtECName.Location = New Point(193, 90)
        txtECName.Name = "txtECName"
        txtECName.Size = New Size(325, 32)
        txtECName.TabIndex = 71
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Century Gothic", 12F)
        txtAddress.Location = New Point(870, 141)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(406, 67)
        txtAddress.TabIndex = 14
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtEmployeeID.Location = New Point(247, 55)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(407, 32)
        txtEmployeeID.TabIndex = 51
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 12F)
        Label19.Location = New Point(772, 144)
        Label19.Name = "Label19"
        Label19.Size = New Size(93, 23)
        Label19.TabIndex = 4
        Label19.Text = "Address:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Century Gothic", 12F)
        txtEmail.Location = New Point(871, 98)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(407, 32)
        txtEmail.TabIndex = 13
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 12F)
        Label23.Location = New Point(714, 107)
        Label23.Name = "Label23"
        Label23.Size = New Size(151, 23)
        Label23.TabIndex = 1
        Label23.Text = "Email Address:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Century Gothic", 12F)
        txtPhone.Location = New Point(869, 55)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(407, 32)
        txtPhone.TabIndex = 12
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 12F)
        Label22.Location = New Point(701, 64)
        Label22.Name = "Label22"
        Label22.Size = New Size(162, 23)
        Label22.TabIndex = 3
        Label22.Text = "Phone Number:"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtAge.Location = New Point(247, 270)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(407, 32)
        txtAge.TabIndex = 32
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Bold)
        dtpBirthDate.CustomFormat = "mm/dd/yyyy"
        dtpBirthDate.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpBirthDate.Location = New Point(247, 227)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(407, 32)
        dtpBirthDate.TabIndex = 48
        dtpBirthDate.Value = New Date(2025, 11, 7, 0, 0, 0, 0)
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 12F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(101, 64)
        Label18.Name = "Label18"
        Label18.Size = New Size(140, 23)
        Label18.TabIndex = 13
        Label18.Text = "Employee ID:"
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Font = New Font("Century Gothic", 12F)
        lblfname.ForeColor = Color.Black
        lblfname.Location = New Point(125, 109)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(116, 23)
        lblfname.TabIndex = 14
        lblfname.Text = "First Name:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtLastName.Location = New Point(247, 184)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(407, 32)
        txtLastName.TabIndex = 41
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtFirstName.Location = New Point(247, 98)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(407, 32)
        txtFirstName.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(121, 193)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 23)
        Label6.TabIndex = 40
        Label6.Text = "Last Name:"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Century Gothic", 12F)
        lblage.ForeColor = Color.Black
        lblage.Location = New Point(185, 279)
        lblage.Name = "lblage"
        lblage.Size = New Size(56, 23)
        lblage.TabIndex = 29
        lblage.Text = "Age:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(93, 150)
        Label9.Name = "Label9"
        Label9.Size = New Size(148, 23)
        Label9.TabIndex = 38
        Label9.Text = "Middle Name:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 12F)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(132, 236)
        Label17.Name = "Label17"
        Label17.Size = New Size(109, 23)
        Label17.TabIndex = 27
        Label17.Text = "Birth Date:"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtMiddleName.Location = New Point(247, 141)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(407, 32)
        txtMiddleName.TabIndex = 37
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(193, 321)
        Label14.Name = "Label14"
        Label14.Size = New Size(48, 23)
        Label14.TabIndex = 30
        Label14.Text = "Sex:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(122, 363)
        Label13.Name = "Label13"
        Label13.Size = New Size(119, 23)
        Label13.TabIndex = 34
        Label13.Text = "Civil Status:"
        ' 
        ' MyProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(btnEditInformation)
        Controls.Add(Panel2)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "MyProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Profile"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        btnEditInformation.ResumeLayout(False)
        btnEditInformation.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents lblManagement As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnEditInformation As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbUserType As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbContractType As ComboBox
    Friend WithEvents cbEmployeeStatus As ComboBox
    Friend WithEvents dtpDateHired As DateTimePicker
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtJobID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtYearsOfSevice As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtECAddress As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtECContactID As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtECPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtECRelationship As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtECName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCancelAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditContact As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelContact As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveContact As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
