<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Dashboard))
        GroupBox2 = New GroupBox()
        btnSeeTrainings = New FontAwesome.Sharp.IconButton()
        btnViewSalary = New FontAwesome.Sharp.IconButton()
        btnApplyforLeave = New FontAwesome.Sharp.IconButton()
        btnCheckInOut = New FontAwesome.Sharp.IconButton()
        GroupBox1 = New GroupBox()
        btnSafetyInfo = New FontAwesome.Sharp.IconButton()
        btnHolidayCalendar = New FontAwesome.Sharp.IconButton()
        btnPolicies = New FontAwesome.Sharp.IconButton()
        btnEmployeeHandbook = New FontAwesome.Sharp.IconButton()
        adminheader_pnl = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        lblAmenities = New Label()
        lblLeaveApproval = New Label()
        lblEmployeeTrainings = New Label()
        lblPayrollSummary = New Label()
        lblDepartment = New Label()
        lblAttendanceTracker = New Label()
        lblTeamOverview = New Label()
        lblManagement = New Label()
        lblTrainings = New Label()
        lblSalary = New Label()
        Label26 = New Label()
        Label27 = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        Label50 = New Label()
        lblEmpDashboard = New Label()
        Label51 = New Label()
        gbInfo = New GroupBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        btnProfile = New FontAwesome.Sharp.IconButton()
        Label9 = New Label()
        lblWelcome = New Label()
        Label5 = New Label()
        Label3 = New Label()
        txtDepartment = New TextBox()
        txtJobTitle = New TextBox()
        txtName = New TextBox()
        txtEmployeeID = New TextBox()
        Label4 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        btnSignOut = New FontAwesome.Sharp.IconButton()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        Panel2.SuspendLayout()
        gbInfo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnSeeTrainings)
        GroupBox2.Controls.Add(btnViewSalary)
        GroupBox2.Controls.Add(btnApplyforLeave)
        GroupBox2.Controls.Add(btnCheckInOut)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(947, 276)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(771, 272)
        GroupBox2.TabIndex = 78
        GroupBox2.TabStop = False
        GroupBox2.Text = "Shortcuts"
        ' 
        ' btnSeeTrainings
        ' 
        btnSeeTrainings.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnSeeTrainings.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher
        btnSeeTrainings.IconColor = Color.Black
        btnSeeTrainings.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSeeTrainings.IconSize = 35
        btnSeeTrainings.ImageAlign = ContentAlignment.MiddleLeft
        btnSeeTrainings.Location = New Point(408, 135)
        btnSeeTrainings.Name = "btnSeeTrainings"
        btnSeeTrainings.Size = New Size(320, 69)
        btnSeeTrainings.TabIndex = 48
        btnSeeTrainings.Text = "See Trainings"
        btnSeeTrainings.TextAlign = ContentAlignment.MiddleRight
        btnSeeTrainings.UseVisualStyleBackColor = True
        ' 
        ' btnViewSalary
        ' 
        btnViewSalary.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnViewSalary.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        btnViewSalary.IconColor = Color.Black
        btnViewSalary.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnViewSalary.IconSize = 35
        btnViewSalary.ImageAlign = ContentAlignment.MiddleLeft
        btnViewSalary.Location = New Point(408, 45)
        btnViewSalary.Name = "btnViewSalary"
        btnViewSalary.Size = New Size(320, 69)
        btnViewSalary.TabIndex = 47
        btnViewSalary.Text = "View Salary"
        btnViewSalary.TextAlign = ContentAlignment.MiddleRight
        btnViewSalary.UseVisualStyleBackColor = True
        ' 
        ' btnApplyforLeave
        ' 
        btnApplyforLeave.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnApplyforLeave.IconChar = FontAwesome.Sharp.IconChar.FileContract
        btnApplyforLeave.IconColor = Color.Black
        btnApplyforLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnApplyforLeave.IconSize = 35
        btnApplyforLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnApplyforLeave.Location = New Point(62, 134)
        btnApplyforLeave.Name = "btnApplyforLeave"
        btnApplyforLeave.Size = New Size(320, 69)
        btnApplyforLeave.TabIndex = 46
        btnApplyforLeave.Text = "Apply for Leave"
        btnApplyforLeave.TextAlign = ContentAlignment.MiddleRight
        btnApplyforLeave.UseVisualStyleBackColor = True
        ' 
        ' btnCheckInOut
        ' 
        btnCheckInOut.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnCheckInOut.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        btnCheckInOut.IconColor = Color.Black
        btnCheckInOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCheckInOut.IconSize = 35
        btnCheckInOut.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckInOut.Location = New Point(62, 45)
        btnCheckInOut.Name = "btnCheckInOut"
        btnCheckInOut.Size = New Size(320, 69)
        btnCheckInOut.TabIndex = 45
        btnCheckInOut.Text = "Check In/Out"
        btnCheckInOut.TextAlign = ContentAlignment.MiddleRight
        btnCheckInOut.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSafetyInfo)
        GroupBox1.Controls.Add(btnHolidayCalendar)
        GroupBox1.Controls.Add(btnPolicies)
        GroupBox1.Controls.Add(btnEmployeeHandbook)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(947, 559)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(771, 272)
        GroupBox1.TabIndex = 73
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee Resources"
        ' 
        ' btnSafetyInfo
        ' 
        btnSafetyInfo.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSafetyInfo.IconChar = FontAwesome.Sharp.IconChar.ShieldBlank
        btnSafetyInfo.IconColor = Color.Black
        btnSafetyInfo.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSafetyInfo.IconSize = 35
        btnSafetyInfo.ImageAlign = ContentAlignment.MiddleLeft
        btnSafetyInfo.Location = New Point(408, 149)
        btnSafetyInfo.Name = "btnSafetyInfo"
        btnSafetyInfo.Size = New Size(320, 69)
        btnSafetyInfo.TabIndex = 82
        btnSafetyInfo.Text = "Safety Info"
        btnSafetyInfo.TextAlign = ContentAlignment.MiddleRight
        btnSafetyInfo.UseVisualStyleBackColor = True
        ' 
        ' btnHolidayCalendar
        ' 
        btnHolidayCalendar.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnHolidayCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarDays
        btnHolidayCalendar.IconColor = Color.Black
        btnHolidayCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnHolidayCalendar.IconSize = 35
        btnHolidayCalendar.ImageAlign = ContentAlignment.MiddleLeft
        btnHolidayCalendar.Location = New Point(408, 69)
        btnHolidayCalendar.Name = "btnHolidayCalendar"
        btnHolidayCalendar.Size = New Size(320, 69)
        btnHolidayCalendar.TabIndex = 44
        btnHolidayCalendar.Text = "Holiday Calendar"
        btnHolidayCalendar.TextAlign = ContentAlignment.MiddleRight
        btnHolidayCalendar.UseVisualStyleBackColor = True
        ' 
        ' btnPolicies
        ' 
        btnPolicies.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnPolicies.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced
        btnPolicies.IconColor = Color.Black
        btnPolicies.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPolicies.IconSize = 35
        btnPolicies.ImageAlign = ContentAlignment.MiddleLeft
        btnPolicies.Location = New Point(62, 154)
        btnPolicies.Name = "btnPolicies"
        btnPolicies.Size = New Size(320, 69)
        btnPolicies.TabIndex = 43
        btnPolicies.Text = "Policies"
        btnPolicies.TextAlign = ContentAlignment.MiddleRight
        btnPolicies.UseVisualStyleBackColor = True
        ' 
        ' btnEmployeeHandbook
        ' 
        btnEmployeeHandbook.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnEmployeeHandbook.IconChar = FontAwesome.Sharp.IconChar.Book
        btnEmployeeHandbook.IconColor = Color.Black
        btnEmployeeHandbook.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEmployeeHandbook.IconSize = 35
        btnEmployeeHandbook.ImageAlign = ContentAlignment.MiddleLeft
        btnEmployeeHandbook.Location = New Point(62, 69)
        btnEmployeeHandbook.Name = "btnEmployeeHandbook"
        btnEmployeeHandbook.Size = New Size(320, 69)
        btnEmployeeHandbook.TabIndex = 41
        btnEmployeeHandbook.Text = "Employee Handbook"
        btnEmployeeHandbook.TextAlign = ContentAlignment.MiddleRight
        btnEmployeeHandbook.UseVisualStyleBackColor = True
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 79
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(72, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 34)
        Label2.TabIndex = 0
        Label2.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(lblAmenities)
        Panel2.Controls.Add(lblLeaveApproval)
        Panel2.Controls.Add(lblEmployeeTrainings)
        Panel2.Controls.Add(lblPayrollSummary)
        Panel2.Controls.Add(lblDepartment)
        Panel2.Controls.Add(lblAttendanceTracker)
        Panel2.Controls.Add(lblTeamOverview)
        Panel2.Controls.Add(lblManagement)
        Panel2.Controls.Add(lblTrainings)
        Panel2.Controls.Add(lblSalary)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(lblMyProfile)
        Panel2.Controls.Add(lblAttendance)
        Panel2.Controls.Add(lblLeaveManagement)
        Panel2.Controls.Add(Label50)
        Panel2.Controls.Add(lblEmpDashboard)
        Panel2.Controls.Add(Label51)
        Panel2.Location = New Point(-6, -6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 80
        ' 
        ' lblAmenities
        ' 
        lblAmenities.AutoSize = True
        lblAmenities.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmenities.ForeColor = Color.White
        lblAmenities.Location = New Point(53, 780)
        lblAmenities.Name = "lblAmenities"
        lblAmenities.Size = New Size(118, 27)
        lblAmenities.TabIndex = 77
        lblAmenities.Text = "Amenties"
        ' 
        ' lblLeaveApproval
        ' 
        lblLeaveApproval.AutoSize = True
        lblLeaveApproval.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveApproval.ForeColor = Color.White
        lblLeaveApproval.Location = New Point(53, 620)
        lblLeaveApproval.Name = "lblLeaveApproval"
        lblLeaveApproval.Size = New Size(198, 27)
        lblLeaveApproval.TabIndex = 76
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
        lblEmployeeTrainings.TabIndex = 75
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
        lblPayrollSummary.TabIndex = 74
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
        lblDepartment.TabIndex = 73
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
        lblAttendanceTracker.TabIndex = 72
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
        lblTeamOverview.TabIndex = 71
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
        lblManagement.TabIndex = 70
        lblManagement.Text = "MANAGEMENT"
        ' 
        ' lblTrainings
        ' 
        lblTrainings.AutoSize = True
        lblTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrainings.ForeColor = Color.White
        lblTrainings.Location = New Point(53, 430)
        lblTrainings.Name = "lblTrainings"
        lblTrainings.Size = New Size(110, 27)
        lblTrainings.TabIndex = 69
        lblTrainings.Text = "Trainings"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(53, 390)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(81, 27)
        lblSalary.TabIndex = 68
        lblSalary.Text = "Salary"
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
        ' lblMyProfile
        ' 
        lblMyProfile.AutoSize = True
        lblMyProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMyProfile.ForeColor = Color.White
        lblMyProfile.Location = New Point(53, 270)
        lblMyProfile.Name = "lblMyProfile"
        lblMyProfile.Size = New Size(124, 27)
        lblMyProfile.TabIndex = 7
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
        lblAttendance.TabIndex = 6
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
        lblLeaveManagement.TabIndex = 5
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label50.ForeColor = Color.White
        Label50.Location = New Point(30, 230)
        Label50.Name = "Label50"
        Label50.Size = New Size(98, 22)
        Label50.TabIndex = 3
        Label50.Text = "OVERVIEW"
        ' 
        ' lblEmpDashboard
        ' 
        lblEmpDashboard.AutoSize = True
        lblEmpDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpDashboard.ForeColor = Color.White
        lblEmpDashboard.Location = New Point(53, 160)
        lblEmpDashboard.Name = "lblEmpDashboard"
        lblEmpDashboard.Size = New Size(138, 27)
        lblEmpDashboard.TabIndex = 2
        lblEmpDashboard.Text = "Dashboard"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label51.ForeColor = Color.White
        Label51.Location = New Point(30, 120)
        Label51.Name = "Label51"
        Label51.Size = New Size(57, 22)
        Label51.TabIndex = 1
        Label51.Text = "MAIN"
        ' 
        ' gbInfo
        ' 
        gbInfo.Controls.Add(PictureBox1)
        gbInfo.Controls.Add(Label6)
        gbInfo.Controls.Add(btnProfile)
        gbInfo.Controls.Add(Label9)
        gbInfo.Controls.Add(lblWelcome)
        gbInfo.Controls.Add(Label5)
        gbInfo.Controls.Add(Label3)
        gbInfo.Controls.Add(txtDepartment)
        gbInfo.Controls.Add(txtJobTitle)
        gbInfo.Controls.Add(txtName)
        gbInfo.Controls.Add(txtEmployeeID)
        gbInfo.Controls.Add(Label4)
        gbInfo.Controls.Add(Label7)
        gbInfo.Controls.Add(Label10)
        gbInfo.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbInfo.Location = New Point(400, 257)
        gbInfo.Name = "gbInfo"
        gbInfo.Size = New Size(513, 574)
        gbInfo.TabIndex = 81
        gbInfo.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(71, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(366, 204)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 47
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(28, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 37)
        Label6.TabIndex = 46
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = SystemColors.Control
        btnProfile.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnProfile.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnProfile.IconColor = Color.Black
        btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProfile.IconSize = 30
        btnProfile.ImageAlign = ContentAlignment.MiddleLeft
        btnProfile.Location = New Point(184, 507)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(296, 48)
        btnProfile.TabIndex = 45
        btnProfile.Text = "Edit Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleRight
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(37, 346)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 40)
        Label9.TabIndex = 44
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 20F, FontStyle.Bold)
        lblWelcome.Location = New Point(28, 270)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 40)
        lblWelcome.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(29, 338)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 37)
        Label5.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13F)
        Label3.Location = New Point(28, 470)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 25)
        Label3.TabIndex = 41
        Label3.Text = "Department:"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        txtDepartment.Location = New Point(184, 461)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(296, 34)
        txtDepartment.TabIndex = 40
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        txtJobTitle.Location = New Point(184, 415)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(296, 34)
        txtJobTitle.TabIndex = 12
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        txtName.Location = New Point(184, 369)
        txtName.Name = "txtName"
        txtName.Size = New Size(296, 34)
        txtName.TabIndex = 11
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        txtEmployeeID.Location = New Point(184, 325)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(296, 34)
        txtEmployeeID.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13F)
        Label4.Location = New Point(71, 424)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 25)
        Label4.TabIndex = 3
        Label4.Text = "Job Title:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13F)
        Label7.Location = New Point(93, 378)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 25)
        Label7.TabIndex = 2
        Label7.Text = "Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13F)
        Label10.Location = New Point(22, 333)
        Label10.Name = "Label10"
        Label10.Size = New Size(156, 25)
        Label10.TabIndex = 0
        Label10.Text = "Employee ID:"
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
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(btnSignOut)
        Controls.Add(gbInfo)
        Controls.Add(Panel2)
        Controls.Add(adminheader_pnl)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        gbInfo.ResumeLayout(False)
        gbInfo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lblEmpDashboard As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btmEmployeeHandbook As Button
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents lblManagement As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmployeeHandbook As FontAwesome.Sharp.IconButton
    Friend WithEvents btnApplyforLeave As FontAwesome.Sharp.IconButton

    Friend WithEvents btnProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHolidayCalendar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPolicies As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSafetyInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSeeTrainings As FontAwesome.Sharp.IconButton
    Friend WithEvents btnViewSalary As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCheckInOut As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox

End Class
