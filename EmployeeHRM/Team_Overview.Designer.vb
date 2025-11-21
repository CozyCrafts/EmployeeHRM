<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team_Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Team_Overview))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnSignOut = New FontAwesome.Sharp.IconButton()
        lblAmenities = New Label()
        lblTrainings = New Label()
        lblLeaveApproval = New Label()
        lblEmployeeTrainings = New Label()
        lblPayrollSummary = New Label()
        lblDepartment = New Label()
        Label8 = New Label()
        Label7 = New Label()
        lblAttandanceTracker = New Label()
        lblTeamOverview = New Label()
        Label4 = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        lblSalary = New Label()
        Label3 = New Label()
        lblDashboard = New Label()
        lblMain = New Label()
        adminheader_pnl = New Panel()
        Label2 = New Label()
        btnCancelEmployee = New Button()
        btnSaveEmployee = New Button()
        btnAddEmployee = New FontAwesome.Sharp.IconButton()
        btnEditEmployee = New FontAwesome.Sharp.IconButton()
        GroupBox4 = New GroupBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        cbUserType = New ComboBox()
        txtUsername = New TextBox()
        Label29 = New Label()
        txtPassword = New TextBox()
        txtUserID = New TextBox()
        Label52 = New Label()
        Label10 = New Label()
        cbCivilStatus = New ComboBox()
        cbSex = New ComboBox()
        txtSearchEmployee = New TextBox()
        PictureBox1 = New PictureBox()
        dgvOtherInfo = New DataGridView()
        GroupBox3 = New GroupBox()
        cbDepartment = New ComboBox()
        cbContractType = New ComboBox()
        cbEmployeeStatus = New ComboBox()
        dtpDateHired = New DateTimePicker()
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
        txtECAddress = New TextBox()
        Label24 = New Label()
        txtECContactID = New TextBox()
        Label54 = New Label()
        Label26 = New Label()
        txtECPhone = New TextBox()
        Label27 = New Label()
        txtECRelationship = New TextBox()
        Label28 = New Label()
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
        btnDeleteEmployee = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOtherInfo, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(btnSignOut)
        Panel1.Controls.Add(lblAmenities)
        Panel1.Controls.Add(lblTrainings)
        Panel1.Controls.Add(lblLeaveApproval)
        Panel1.Controls.Add(lblEmployeeTrainings)
        Panel1.Controls.Add(lblPayrollSummary)
        Panel1.Controls.Add(lblDepartment)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblAttandanceTracker)
        Panel1.Controls.Add(lblTeamOverview)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblMyProfile)
        Panel1.Controls.Add(lblAttendance)
        Panel1.Controls.Add(lblLeaveManagement)
        Panel1.Controls.Add(lblSalary)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblDashboard)
        Panel1.Controls.Add(lblMain)
        Panel1.Location = New Point(-6, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 1357)
        Panel1.TabIndex = 3
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
        btnSignOut.TabIndex = 99
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
        lblAmenities.TabIndex = 36
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
        lblTrainings.TabIndex = 35
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
        lblLeaveApproval.TabIndex = 34
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
        lblEmployeeTrainings.TabIndex = 33
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
        lblPayrollSummary.TabIndex = 32
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
        lblDepartment.TabIndex = 31
        lblDepartment.Text = "Department"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(85, 35)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 34)
        Label8.TabIndex = 30
        Label8.Text = " HR System"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(30, 65)
        Label7.Name = "Label7"
        Label7.Size = New Size(312, 27)
        Label7.TabIndex = 29
        Label7.Text = "                                                  "
        ' 
        ' lblAttandanceTracker
        ' 
        lblAttandanceTracker.AutoSize = True
        lblAttandanceTracker.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttandanceTracker.ForeColor = Color.White
        lblAttandanceTracker.Location = New Point(53, 580)
        lblAttandanceTracker.Name = "lblAttandanceTracker"
        lblAttandanceTracker.Size = New Size(239, 27)
        lblAttandanceTracker.TabIndex = 28
        lblAttandanceTracker.Text = "Attendance Tracker"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(30, 500)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 22)
        Label4.TabIndex = 26
        Label4.Text = "MANAGEMENT"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 22)
        Label3.TabIndex = 21
        Label3.Text = "OVERVIEW"
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
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(261, 34)
        Label2.TabIndex = 0
        Label2.Text = "Team Overview"
        ' 
        ' btnCancelEmployee
        ' 
        btnCancelEmployee.BackColor = SystemColors.InactiveCaption
        btnCancelEmployee.BackgroundImageLayout = ImageLayout.None
        btnCancelEmployee.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelEmployee.ForeColor = Color.Black
        btnCancelEmployee.Location = New Point(1240, 35)
        btnCancelEmployee.Name = "btnCancelEmployee"
        btnCancelEmployee.Size = New Size(89, 45)
        btnCancelEmployee.TabIndex = 75
        btnCancelEmployee.Text = "Cancel"
        btnCancelEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnSaveEmployee
        ' 
        btnSaveEmployee.BackColor = SystemColors.InactiveCaption
        btnSaveEmployee.BackgroundImageLayout = ImageLayout.None
        btnSaveEmployee.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveEmployee.ForeColor = Color.Black
        btnSaveEmployee.Location = New Point(1151, 35)
        btnSaveEmployee.Name = "btnSaveEmployee"
        btnSaveEmployee.Size = New Size(90, 45)
        btnSaveEmployee.TabIndex = 73
        btnSaveEmployee.Text = "Save"
        btnSaveEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.BackColor = SystemColors.InactiveCaption
        btnAddEmployee.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.ForeColor = SystemColors.ControlText
        btnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        btnAddEmployee.IconColor = Color.Black
        btnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddEmployee.IconSize = 38
        btnAddEmployee.Location = New Point(1151, 36)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(178, 44)
        btnAddEmployee.TabIndex = 78
        btnAddEmployee.Text = "Add Employee"
        btnAddEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnAddEmployee.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnEditEmployee
        ' 
        btnEditEmployee.BackColor = SystemColors.InactiveCaption
        btnEditEmployee.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditEmployee.IconChar = FontAwesome.Sharp.IconChar.UserPen
        btnEditEmployee.IconColor = Color.Black
        btnEditEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditEmployee.IconSize = 38
        btnEditEmployee.Location = New Point(967, 34)
        btnEditEmployee.Name = "btnEditEmployee"
        btnEditEmployee.Size = New Size(178, 46)
        btnEditEmployee.TabIndex = 79
        btnEditEmployee.Text = "Edit Employee"
        btnEditEmployee.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEditEmployee.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackgroundImageLayout = ImageLayout.Zoom
        GroupBox4.Controls.Add(GroupBox1)
        GroupBox4.Controls.Add(cbCivilStatus)
        GroupBox4.Controls.Add(cbSex)
        GroupBox4.Controls.Add(txtSearchEmployee)
        GroupBox4.Controls.Add(PictureBox1)
        GroupBox4.Controls.Add(dgvOtherInfo)
        GroupBox4.Controls.Add(GroupBox3)
        GroupBox4.Controls.Add(btnAddEmployee)
        GroupBox4.Controls.Add(btnEditEmployee)
        GroupBox4.Controls.Add(GroupBox5)
        GroupBox4.Controls.Add(txtAddress)
        GroupBox4.Controls.Add(txtEmployeeID)
        GroupBox4.Controls.Add(Label19)
        GroupBox4.Controls.Add(txtEmail)
        GroupBox4.Controls.Add(Label23)
        GroupBox4.Controls.Add(txtPhone)
        GroupBox4.Controls.Add(Label22)
        GroupBox4.Controls.Add(txtAge)
        GroupBox4.Controls.Add(dtpBirthDate)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Controls.Add(lblfname)
        GroupBox4.Controls.Add(txtLastName)
        GroupBox4.Controls.Add(txtFirstName)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(lblage)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(txtMiddleName)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(btnCancelEmployee)
        GroupBox4.Controls.Add(btnSaveEmployee)
        GroupBox4.Controls.Add(btnDeleteEmployee)
        GroupBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox4.Location = New Point(391, 114)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1354, 1019)
        GroupBox4.TabIndex = 89
        GroupBox4.TabStop = False
        GroupBox4.Text = "Employee Information"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cbUserType)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label29)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUserID)
        GroupBox1.Controls.Add(Label52)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(910, 835)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(420, 161)
        GroupBox1.TabIndex = 108
        GroupBox1.TabStop = False
        GroupBox1.Text = "Account "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 21)
        Label1.TabIndex = 75
        Label1.Text = "Username:"
        ' 
        ' cbUserType
        ' 
        cbUserType.FormattingEnabled = True
        cbUserType.Location = New Point(281, 37)
        cbUserType.Name = "cbUserType"
        cbUserType.Size = New Size(123, 31)
        cbUserType.TabIndex = 107
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(133, 74)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(271, 30)
        txtUsername.TabIndex = 76
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(32, 119)
        Label29.Name = "Label29"
        Label29.Size = New Size(95, 21)
        Label29.TabIndex = 68
        Label29.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(133, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(271, 30)
        txtPassword.TabIndex = 71
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtUserID.Location = New Point(90, 38)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(85, 30)
        txtUserID.TabIndex = 48
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label52.ForeColor = Color.Black
        Label52.Location = New Point(181, 47)
        Label52.Name = "Label52"
        Label52.Size = New Size(94, 21)
        Label52.TabIndex = 30
        Label52.Text = "User Type:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(11, 47)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 21)
        Label10.TabIndex = 47
        Label10.Text = "User ID:"
        ' 
        ' cbCivilStatus
        ' 
        cbCivilStatus.FormattingEnabled = True
        cbCivilStatus.Location = New Point(155, 786)
        cbCivilStatus.Name = "cbCivilStatus"
        cbCivilStatus.Size = New Size(291, 31)
        cbCivilStatus.TabIndex = 106
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Location = New Point(155, 749)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(291, 31)
        cbSex.TabIndex = 105
        ' 
        ' txtSearchEmployee
        ' 
        txtSearchEmployee.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchEmployee.Location = New Point(65, 47)
        txtSearchEmployee.Margin = New Padding(4, 3, 4, 3)
        txtSearchEmployee.Name = "txtSearchEmployee"
        txtSearchEmployee.Size = New Size(256, 32)
        txtSearchEmployee.TabIndex = 98
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(0, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 102
        PictureBox1.TabStop = False
        ' 
        ' dgvOtherInfo
        ' 
        dgvOtherInfo.AllowUserToResizeColumns = False
        dgvOtherInfo.AllowUserToResizeRows = False
        dgvOtherInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOtherInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvOtherInfo.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dgvOtherInfo.ColumnHeadersHeight = 29
        dgvOtherInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvOtherInfo.DefaultCellStyle = DataGridViewCellStyle1
        dgvOtherInfo.Location = New Point(15, 86)
        dgvOtherInfo.Name = "dgvOtherInfo"
        dgvOtherInfo.RowHeadersWidth = 51
        dgvOtherInfo.Size = New Size(1314, 441)
        dgvOtherInfo.TabIndex = 90
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(cbDepartment)
        GroupBox3.Controls.Add(cbContractType)
        GroupBox3.Controls.Add(cbEmployeeStatus)
        GroupBox3.Controls.Add(dtpDateHired)
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
        GroupBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox3.Location = New Point(21, 836)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(883, 184)
        GroupBox3.TabIndex = 88
        GroupBox3.TabStop = False
        GroupBox3.Text = "Job Details"
        ' 
        ' cbDepartment
        ' 
        cbDepartment.FormattingEnabled = True
        cbDepartment.Location = New Point(170, 139)
        cbDepartment.Name = "cbDepartment"
        cbDepartment.Size = New Size(235, 31)
        cbDepartment.TabIndex = 108
        ' 
        ' cbContractType
        ' 
        cbContractType.FormattingEnabled = True
        cbContractType.Location = New Point(602, 67)
        cbContractType.Name = "cbContractType"
        cbContractType.Size = New Size(264, 31)
        cbContractType.TabIndex = 107
        ' 
        ' cbEmployeeStatus
        ' 
        cbEmployeeStatus.FormattingEnabled = True
        cbEmployeeStatus.Location = New Point(602, 30)
        cbEmployeeStatus.Name = "cbEmployeeStatus"
        cbEmployeeStatus.Size = New Size(264, 31)
        cbEmployeeStatus.TabIndex = 106
        ' 
        ' dtpDateHired
        ' 
        dtpDateHired.CustomFormat = "mm/dd/yyyy"
        dtpDateHired.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        dtpDateHired.Location = New Point(602, 104)
        dtpDateHired.Name = "dtpDateHired"
        dtpDateHired.Size = New Size(264, 26)
        dtpDateHired.TabIndex = 49
        dtpDateHired.Value = New Date(2025, 9, 13, 1, 11, 7, 0)
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(18, 112)
        Label11.Name = "Label11"
        Label11.Size = New Size(146, 21)
        Label11.TabIndex = 17
        Label11.Text = "Department ID:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(93, 40)
        Label25.Name = "Label25"
        Label25.Size = New Size(71, 21)
        Label25.TabIndex = 19
        Label25.Text = "Job ID:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(78, 76)
        Label21.Name = "Label21"
        Label21.Size = New Size(86, 21)
        Label21.TabIndex = 0
        Label21.Text = "Job Title:"
        ' 
        ' txtJobID
        ' 
        txtJobID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJobID.Location = New Point(170, 31)
        txtJobID.Name = "txtJobID"
        txtJobID.Size = New Size(235, 30)
        txtJobID.TabIndex = 18
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(488, 109)
        Label20.Name = "Label20"
        Label20.Size = New Size(108, 21)
        Label20.TabIndex = 1
        Label20.Text = "Date Hired:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(411, 40)
        Label15.Name = "Label15"
        Label15.Size = New Size(185, 21)
        Label15.TabIndex = 3
        Label15.Text = "Employment Status:"
        ' 
        ' txtDepartmentID
        ' 
        txtDepartmentID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDepartmentID.Location = New Point(170, 103)
        txtDepartmentID.Name = "txtDepartmentID"
        txtDepartmentID.Size = New Size(235, 30)
        txtDepartmentID.TabIndex = 16
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(452, 77)
        Label12.Name = "Label12"
        Label12.Size = New Size(144, 21)
        Label12.TabIndex = 4
        Label12.Text = "Contract Type:"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label48.Location = New Point(41, 148)
        Label48.Name = "Label48"
        Label48.Size = New Size(123, 21)
        Label48.TabIndex = 15
        Label48.Text = "Department:"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJobTitle.Location = New Point(170, 67)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(235, 30)
        txtJobTitle.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(442, 144)
        Label16.Name = "Label16"
        Label16.Size = New Size(154, 21)
        Label16.TabIndex = 15
        Label16.Text = "Years of Service:"
        ' 
        ' txtYearsOfSevice
        ' 
        txtYearsOfSevice.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYearsOfSevice.Location = New Point(602, 135)
        txtYearsOfSevice.Name = "txtYearsOfSevice"
        txtYearsOfSevice.Size = New Size(264, 30)
        txtYearsOfSevice.TabIndex = 13
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(txtECAddress)
        GroupBox5.Controls.Add(Label24)
        GroupBox5.Controls.Add(txtECContactID)
        GroupBox5.Controls.Add(Label54)
        GroupBox5.Controls.Add(Label26)
        GroupBox5.Controls.Add(txtECPhone)
        GroupBox5.Controls.Add(Label27)
        GroupBox5.Controls.Add(txtECRelationship)
        GroupBox5.Controls.Add(Label28)
        GroupBox5.Controls.Add(txtECName)
        GroupBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(818, 547)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(511, 282)
        GroupBox5.TabIndex = 87
        GroupBox5.TabStop = False
        GroupBox5.Text = "Emergency Contact"
        ' 
        ' txtECAddress
        ' 
        txtECAddress.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtECAddress.Location = New Point(160, 180)
        txtECAddress.Multiline = True
        txtECAddress.Name = "txtECAddress"
        txtECAddress.Size = New Size(325, 82)
        txtECAddress.TabIndex = 77
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(40, 45)
        Label24.Name = "Label24"
        Label24.Size = New Size(114, 21)
        Label24.TabIndex = 75
        Label24.Text = "Contact ID:"
        ' 
        ' txtECContactID
        ' 
        txtECContactID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtECContactID.Location = New Point(160, 36)
        txtECContactID.Name = "txtECContactID"
        txtECContactID.Size = New Size(325, 30)
        txtECContactID.TabIndex = 76
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(69, 183)
        Label54.Name = "Label54"
        Label54.Size = New Size(85, 21)
        Label54.TabIndex = 74
        Label54.Text = "Address:"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(85, 81)
        Label26.Name = "Label26"
        Label26.Size = New Size(69, 21)
        Label26.TabIndex = 68
        Label26.Text = "Name:"
        ' 
        ' txtECPhone
        ' 
        txtECPhone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtECPhone.Location = New Point(160, 144)
        txtECPhone.Name = "txtECPhone"
        txtECPhone.Size = New Size(325, 30)
        txtECPhone.TabIndex = 73
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(35, 117)
        Label27.Name = "Label27"
        Label27.Size = New Size(119, 21)
        Label27.TabIndex = 69
        Label27.Text = "Relationship:"
        ' 
        ' txtECRelationship
        ' 
        txtECRelationship.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtECRelationship.Location = New Point(160, 108)
        txtECRelationship.Name = "txtECRelationship"
        txtECRelationship.Size = New Size(325, 30)
        txtECRelationship.TabIndex = 72
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(7, 153)
        Label28.Name = "Label28"
        Label28.Size = New Size(147, 21)
        Label28.TabIndex = 70
        Label28.Text = "Phone Number:"
        ' 
        ' txtECName
        ' 
        txtECName.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtECName.Location = New Point(160, 72)
        txtECName.Name = "txtECName"
        txtECName.Size = New Size(325, 30)
        txtECName.TabIndex = 71
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(484, 698)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(310, 67)
        txtAddress.TabIndex = 14
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtEmployeeID.Location = New Point(154, 537)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(291, 30)
        txtEmployeeID.TabIndex = 51
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(484, 674)
        Label19.Name = "Label19"
        Label19.Size = New Size(85, 21)
        Label19.TabIndex = 4
        Label19.Text = "Address:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(484, 641)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(310, 30)
        txtEmail.TabIndex = 13
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(484, 617)
        Label23.Name = "Label23"
        Label23.Size = New Size(135, 21)
        Label23.TabIndex = 1
        Label23.Text = "Email Address:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(484, 584)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(310, 30)
        txtPhone.TabIndex = 12
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(482, 560)
        Label22.Name = "Label22"
        Label22.Size = New Size(147, 21)
        Label22.TabIndex = 3
        Label22.Text = "Phone Number:"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtAge.Location = New Point(154, 713)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(291, 30)
        txtAge.TabIndex = 32
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Bold)
        dtpBirthDate.CustomFormat = "mm/dd/yyyy"
        dtpBirthDate.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        dtpBirthDate.Location = New Point(154, 681)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(291, 26)
        dtpBirthDate.TabIndex = 48
        dtpBirthDate.Value = New Date(2025, 11, 7, 0, 0, 0, 0)
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 10.8F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(21, 546)
        Label18.Name = "Label18"
        Label18.Size = New Size(127, 21)
        Label18.TabIndex = 13
        Label18.Text = "Employee ID:"
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Font = New Font("Century Gothic", 10.8F)
        lblfname.ForeColor = Color.Black
        lblfname.Location = New Point(43, 582)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(105, 21)
        lblfname.TabIndex = 14
        lblfname.Text = "First Name:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtLastName.Location = New Point(154, 645)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(291, 30)
        txtLastName.TabIndex = 41
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtFirstName.Location = New Point(154, 573)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(291, 30)
        txtFirstName.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(40, 654)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 21)
        Label6.TabIndex = 40
        Label6.Text = "Last Name:"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Century Gothic", 10.8F)
        lblage.ForeColor = Color.Black
        lblage.Location = New Point(94, 722)
        lblage.Name = "lblage"
        lblage.Size = New Size(54, 21)
        lblage.TabIndex = 29
        lblage.Text = "Age:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10.8F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(15, 618)
        Label9.Name = "Label9"
        Label9.Size = New Size(133, 21)
        Label9.TabIndex = 38
        Label9.Text = "Middle Name:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 10.8F)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(48, 686)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 21)
        Label17.TabIndex = 27
        Label17.Text = "Birth Date:"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtMiddleName.Location = New Point(154, 609)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(291, 30)
        txtMiddleName.TabIndex = 37
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 10.8F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(103, 758)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 21)
        Label14.TabIndex = 30
        Label14.Text = "Sex:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 10.8F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(40, 794)
        Label13.Name = "Label13"
        Label13.Size = New Size(108, 21)
        Label13.TabIndex = 34
        Label13.Text = "Civil Status:"
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.BackColor = SystemColors.InactiveCaption
        btnDeleteEmployee.Font = New Font("Century Gothic", 8.2F, FontStyle.Bold)
        btnDeleteEmployee.ForeColor = SystemColors.ControlText
        btnDeleteEmployee.IconChar = FontAwesome.Sharp.IconChar.UserMinus
        btnDeleteEmployee.IconColor = Color.Black
        btnDeleteEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDeleteEmployee.IconSize = 38
        btnDeleteEmployee.ImageAlign = ContentAlignment.MiddleLeft
        btnDeleteEmployee.Location = New Point(783, 35)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(178, 44)
        btnDeleteEmployee.TabIndex = 104
        btnDeleteEmployee.Text = "Delete Employee"
        btnDeleteEmployee.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDeleteEmployee.UseVisualStyleBackColor = False
        ' 
        ' Team_Overview
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Team_Overview"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Team Overview"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOtherInfo, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelEmployee As Button
    Friend WithEvents btnSaveEmployee As Button
    Friend WithEvents btnAddEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAttandanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents GroupBox4 As GroupBox
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtECAddress As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtECContactID As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtECPhone As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtECRelationship As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtECName As TextBox
    Friend WithEvents txtSearchEmployee As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDeleteEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvOtherInfo As DataGridView
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbContractType As ComboBox
    Friend WithEvents cbEmployeeStatus As ComboBox
    Friend WithEvents dtpDateHired As DateTimePicker
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtJobID As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtYearsOfSevice As TextBox
    Friend WithEvents cbUserType As ComboBox
    Friend WithEvents cbEmploymentStatus As ComboBox
    Friend WithEvents cbJobID As ComboBox
    Friend WithEvents cbJobTitle As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
