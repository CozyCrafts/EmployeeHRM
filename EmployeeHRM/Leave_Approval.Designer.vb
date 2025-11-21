<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave_Approval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leave_Approval))
        adminheader_pnl = New Panel()
        Label2 = New Label()
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
        lblAttendanceTracker = New Label()
        lblTeamOverview = New Label()
        Label4 = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        lblSalary = New Label()
        Label3 = New Label()
        lblDashboard = New Label()
        lblMain = New Label()
        dgvEmployeeTrainingHistory = New DataGridView()
        gbLeaveDetails = New GroupBox()
        btnEditLeave = New FontAwesome.Sharp.IconButton()
        Label15 = New Label()
        cbStatus = New ComboBox()
        Label9 = New Label()
        txtJobTitle = New TextBox()
        cbLeaveType = New ComboBox()
        gbLeaveDuration = New GroupBox()
        Label13 = New Label()
        dtpLeaveDateTo = New DateTimePicker()
        Label14 = New Label()
        dtpLeaveDateFrom = New DateTimePicker()
        txtApprovedBy = New TextBox()
        Label12 = New Label()
        txtEmployeeName = New TextBox()
        Label11 = New Label()
        txtLeaveID = New TextBox()
        txtReason = New TextBox()
        txtEmployeeID = New TextBox()
        Label6 = New Label()
        Label21 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        btnCancelLeave = New FontAwesome.Sharp.IconButton()
        btnSaveLeave = New FontAwesome.Sharp.IconButton()
        btnDeleteTraining = New Button()
        gbEmployeeLeaveHistory = New GroupBox()
        txtSearchLeave = New TextBox()
        PictureBox1 = New PictureBox()
        dgvEmployeeLeaveHistory = New DataGridView()
        adminheader_pnl.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvEmployeeTrainingHistory, ComponentModel.ISupportInitialize).BeginInit()
        gbLeaveDetails.SuspendLayout()
        gbLeaveDuration.SuspendLayout()
        gbEmployeeLeaveHistory.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmployeeLeaveHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Label2.Location = New Point(72, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 34)
        Label2.TabIndex = 0
        Label2.Text = "Leave Approval"
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
        Panel1.Controls.Add(lblAttendanceTracker)
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
        Panel1.TabIndex = 5
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
        lblAmenities.TabIndex = 18
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
        lblTrainings.TabIndex = 17
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
        lblLeaveApproval.TabIndex = 16
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
        lblEmployeeTrainings.TabIndex = 15
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
        lblPayrollSummary.TabIndex = 14
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
        lblDepartment.TabIndex = 13
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
        Label8.TabIndex = 12
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
        Label7.TabIndex = 11
        Label7.Text = "                                                  "
        ' 
        ' lblAttendanceTracker
        ' 
        lblAttendanceTracker.AutoSize = True
        lblAttendanceTracker.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendanceTracker.ForeColor = Color.White
        lblAttendanceTracker.Location = New Point(53, 580)
        lblAttendanceTracker.Name = "lblAttendanceTracker"
        lblAttendanceTracker.Size = New Size(239, 27)
        lblAttendanceTracker.TabIndex = 10
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
        lblTeamOverview.TabIndex = 9
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
        Label4.TabIndex = 8
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
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(53, 390)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(81, 27)
        lblSalary.TabIndex = 4
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
        Label3.TabIndex = 3
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
        lblDashboard.TabIndex = 2
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
        lblMain.TabIndex = 1
        lblMain.Text = "MAIN"
        ' 
        ' dgvEmployeeTrainingHistory
        ' 
        dgvEmployeeTrainingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeTrainingHistory.Location = New Point(27, 92)
        dgvEmployeeTrainingHistory.Margin = New Padding(4, 3, 4, 3)
        dgvEmployeeTrainingHistory.Name = "dgvEmployeeTrainingHistory"
        dgvEmployeeTrainingHistory.RowHeadersWidth = 51
        dgvEmployeeTrainingHistory.Size = New Size(1277, 325)
        dgvEmployeeTrainingHistory.TabIndex = 0
        ' 
        ' gbLeaveDetails
        ' 
        gbLeaveDetails.Controls.Add(btnEditLeave)
        gbLeaveDetails.Controls.Add(Label15)
        gbLeaveDetails.Controls.Add(cbStatus)
        gbLeaveDetails.Controls.Add(Label9)
        gbLeaveDetails.Controls.Add(txtJobTitle)
        gbLeaveDetails.Controls.Add(cbLeaveType)
        gbLeaveDetails.Controls.Add(gbLeaveDuration)
        gbLeaveDetails.Controls.Add(txtApprovedBy)
        gbLeaveDetails.Controls.Add(Label12)
        gbLeaveDetails.Controls.Add(txtEmployeeName)
        gbLeaveDetails.Controls.Add(Label11)
        gbLeaveDetails.Controls.Add(txtLeaveID)
        gbLeaveDetails.Controls.Add(txtReason)
        gbLeaveDetails.Controls.Add(txtEmployeeID)
        gbLeaveDetails.Controls.Add(Label6)
        gbLeaveDetails.Controls.Add(Label21)
        gbLeaveDetails.Controls.Add(Label1)
        gbLeaveDetails.Controls.Add(Label5)
        gbLeaveDetails.Controls.Add(btnCancelLeave)
        gbLeaveDetails.Controls.Add(btnSaveLeave)
        gbLeaveDetails.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbLeaveDetails.Location = New Point(410, 114)
        gbLeaveDetails.Margin = New Padding(4, 3, 4, 3)
        gbLeaveDetails.Name = "gbLeaveDetails"
        gbLeaveDetails.Padding = New Padding(4, 3, 4, 3)
        gbLeaveDetails.Size = New Size(1335, 364)
        gbLeaveDetails.TabIndex = 85
        gbLeaveDetails.TabStop = False
        gbLeaveDetails.Text = "Details"
        ' 
        ' btnEditLeave
        ' 
        btnEditLeave.BackColor = SystemColors.InactiveCaption
        btnEditLeave.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnEditLeave.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditLeave.IconColor = Color.Black
        btnEditLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditLeave.IconSize = 30
        btnEditLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnEditLeave.Location = New Point(1048, 261)
        btnEditLeave.Name = "btnEditLeave"
        btnEditLeave.Size = New Size(270, 48)
        btnEditLeave.TabIndex = 116
        btnEditLeave.Text = "Edit Leave Approval"
        btnEditLeave.TextAlign = ContentAlignment.MiddleRight
        btnEditLeave.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 13F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(873, 178)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(82, 25)
        Label15.TabIndex = 115
        Label15.Text = "Status:"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Location = New Point(962, 168)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(356, 35)
        cbStatus.TabIndex = 114
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(109, 149)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 27)
        Label9.TabIndex = 113
        Label9.Text = "Job Title:"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Location = New Point(229, 140)
        txtJobTitle.Margin = New Padding(4, 3, 4, 3)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(525, 36)
        txtJobTitle.TabIndex = 112
        ' 
        ' cbLeaveType
        ' 
        cbLeaveType.FormattingEnabled = True
        cbLeaveType.Location = New Point(229, 224)
        cbLeaveType.Name = "cbLeaveType"
        cbLeaveType.Size = New Size(525, 35)
        cbLeaveType.TabIndex = 107
        ' 
        ' gbLeaveDuration
        ' 
        gbLeaveDuration.Controls.Add(Label13)
        gbLeaveDuration.Controls.Add(dtpLeaveDateTo)
        gbLeaveDuration.Controls.Add(Label14)
        gbLeaveDuration.Controls.Add(dtpLeaveDateFrom)
        gbLeaveDuration.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbLeaveDuration.Location = New Point(790, 35)
        gbLeaveDuration.Margin = New Padding(4, 3, 4, 3)
        gbLeaveDuration.Name = "gbLeaveDuration"
        gbLeaveDuration.Padding = New Padding(4, 3, 4, 3)
        gbLeaveDuration.Size = New Size(528, 126)
        gbLeaveDuration.TabIndex = 99
        gbLeaveDuration.TabStop = False
        gbLeaveDuration.Text = "Leave Duration"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(22, 44)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 23)
        Label13.TabIndex = 95
        Label13.Text = "Date From:"
        ' 
        ' dtpLeaveDateTo
        ' 
        dtpLeaveDateTo.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpLeaveDateTo.Location = New Point(147, 73)
        dtpLeaveDateTo.Name = "dtpLeaveDateTo"
        dtpLeaveDateTo.Size = New Size(364, 32)
        dtpLeaveDateTo.TabIndex = 98
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(49, 84)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 23)
        Label14.TabIndex = 96
        Label14.Text = "Date To:"
        ' 
        ' dtpLeaveDateFrom
        ' 
        dtpLeaveDateFrom.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpLeaveDateFrom.Location = New Point(147, 35)
        dtpLeaveDateFrom.Name = "dtpLeaveDateFrom"
        dtpLeaveDateFrom.Size = New Size(364, 32)
        dtpLeaveDateFrom.TabIndex = 97
        ' 
        ' txtApprovedBy
        ' 
        txtApprovedBy.Location = New Point(962, 209)
        txtApprovedBy.Margin = New Padding(4, 3, 4, 3)
        txtApprovedBy.Name = "txtApprovedBy"
        txtApprovedBy.Size = New Size(356, 36)
        txtApprovedBy.TabIndex = 91
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(15, 107)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(208, 27)
        Label12.TabIndex = 90
        Label12.Text = "Employee Name:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(229, 98)
        txtEmployeeName.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(525, 36)
        txtEmployeeName.TabIndex = 89
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(62, 65)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 27)
        Label11.TabIndex = 86
        Label11.Text = "Employee ID:"
        ' 
        ' txtLeaveID
        ' 
        txtLeaveID.Location = New Point(229, 182)
        txtLeaveID.Margin = New Padding(4, 3, 4, 3)
        txtLeaveID.Name = "txtLeaveID"
        txtLeaveID.Size = New Size(525, 36)
        txtLeaveID.TabIndex = 85
        ' 
        ' txtReason
        ' 
        txtReason.Location = New Point(229, 265)
        txtReason.Margin = New Padding(4, 3, 4, 3)
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(525, 36)
        txtReason.TabIndex = 80
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(229, 56)
        txtEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(525, 36)
        txtEmployeeID.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(127, 269)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 25)
        Label6.TabIndex = 79
        Label6.Text = "Reason:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(103, 191)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(119, 27)
        Label21.TabIndex = 70
        Label21.Text = "Leave ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(80, 234)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 25)
        Label1.TabIndex = 71
        Label1.Text = "Leave Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(790, 213)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 25)
        Label5.TabIndex = 74
        Label5.Text = "Authorized By:"
        ' 
        ' btnCancelLeave
        ' 
        btnCancelLeave.BackColor = SystemColors.InactiveCaption
        btnCancelLeave.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancelLeave.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelLeave.IconColor = Color.Black
        btnCancelLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelLeave.IconSize = 30
        btnCancelLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelLeave.Location = New Point(1186, 263)
        btnCancelLeave.Name = "btnCancelLeave"
        btnCancelLeave.Size = New Size(132, 44)
        btnCancelLeave.TabIndex = 118
        btnCancelLeave.Text = "Cancel"
        btnCancelLeave.TextAlign = ContentAlignment.MiddleRight
        btnCancelLeave.UseVisualStyleBackColor = False
        ' 
        ' btnSaveLeave
        ' 
        btnSaveLeave.BackColor = SystemColors.InactiveCaption
        btnSaveLeave.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSaveLeave.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveLeave.IconColor = Color.Black
        btnSaveLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveLeave.IconSize = 30
        btnSaveLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveLeave.Location = New Point(1049, 263)
        btnSaveLeave.Name = "btnSaveLeave"
        btnSaveLeave.Size = New Size(131, 44)
        btnSaveLeave.TabIndex = 117
        btnSaveLeave.Text = "Save"
        btnSaveLeave.TextAlign = ContentAlignment.MiddleRight
        btnSaveLeave.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteTraining
        ' 
        btnDeleteTraining.BackColor = SystemColors.InactiveCaption
        btnDeleteTraining.BackgroundImageLayout = ImageLayout.None
        btnDeleteTraining.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnDeleteTraining.ForeColor = Color.Black
        btnDeleteTraining.Location = New Point(577, 28)
        btnDeleteTraining.Name = "btnDeleteTraining"
        btnDeleteTraining.Size = New Size(340, 46)
        btnDeleteTraining.TabIndex = 88
        btnDeleteTraining.Text = "Delete"
        btnDeleteTraining.UseVisualStyleBackColor = False
        ' 
        ' gbEmployeeLeaveHistory
        ' 
        gbEmployeeLeaveHistory.Controls.Add(txtSearchLeave)
        gbEmployeeLeaveHistory.Controls.Add(PictureBox1)
        gbEmployeeLeaveHistory.Controls.Add(dgvEmployeeLeaveHistory)
        gbEmployeeLeaveHistory.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbEmployeeLeaveHistory.Location = New Point(410, 484)
        gbEmployeeLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        gbEmployeeLeaveHistory.Name = "gbEmployeeLeaveHistory"
        gbEmployeeLeaveHistory.Padding = New Padding(4, 3, 4, 3)
        gbEmployeeLeaveHistory.Size = New Size(1338, 627)
        gbEmployeeLeaveHistory.TabIndex = 88
        gbEmployeeLeaveHistory.TabStop = False
        gbEmployeeLeaveHistory.Text = "Employee Leave History"
        ' 
        ' txtSearchLeave
        ' 
        txtSearchLeave.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchLeave.Location = New Point(77, 67)
        txtSearchLeave.Margin = New Padding(4, 3, 4, 3)
        txtSearchLeave.Name = "txtSearchLeave"
        txtSearchLeave.Size = New Size(256, 32)
        txtSearchLeave.TabIndex = 93
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(11, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 103
        PictureBox1.TabStop = False
        ' 
        ' dgvEmployeeLeaveHistory
        ' 
        dgvEmployeeLeaveHistory.AllowUserToResizeColumns = False
        dgvEmployeeLeaveHistory.AllowUserToResizeRows = False
        dgvEmployeeLeaveHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployeeLeaveHistory.ColumnHeadersHeight = 29
        dgvEmployeeLeaveHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvEmployeeLeaveHistory.Location = New Point(28, 105)
        dgvEmployeeLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        dgvEmployeeLeaveHistory.Name = "dgvEmployeeLeaveHistory"
        dgvEmployeeLeaveHistory.RowHeadersWidth = 51
        dgvEmployeeLeaveHistory.Size = New Size(1315, 506)
        dgvEmployeeLeaveHistory.TabIndex = 0
        ' 
        ' Leave_Approval
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(gbEmployeeLeaveHistory)
        Controls.Add(gbLeaveDetails)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Leave_Approval"
        StartPosition = FormStartPosition.CenterScreen
        Text = "-"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvEmployeeTrainingHistory, ComponentModel.ISupportInitialize).EndInit()
        gbLeaveDetails.ResumeLayout(False)
        gbLeaveDetails.PerformLayout()
        gbLeaveDuration.ResumeLayout(False)
        gbLeaveDuration.PerformLayout()
        gbEmployeeLeaveHistory.ResumeLayout(False)
        gbEmployeeLeaveHistory.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmployeeLeaveHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents gbEmployeeTrainingHistory As GroupBox
    Friend WithEvents btnRefreshTrainings As Button
    Friend WithEvents txtSearchTrainings As TextBox
    Friend WithEvents btnSearchTrainings As Button
    Friend WithEvents dgvEmployeeTrainingHistory As DataGridView
    Friend WithEvents gbLeaveDetails As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnDeleteTraining As Button
    Friend WithEvents txtLeaveID As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpLeaveDateTo As DateTimePicker
    Friend WithEvents dtpLeaveDateFrom As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtApprovedBy As TextBox
    Friend WithEvents gbLeaveDuration As GroupBox
    Friend WithEvents gbEmployeeLeaveHistory As GroupBox
    Friend WithEvents txtSearchLeave As TextBox
    Friend WithEvents dgvEmployeeLeaveHistory As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbLeaveType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnCancelLeave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveLeave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditLeave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
