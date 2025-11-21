<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave_Management
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
        gbLeaveHistory = New GroupBox()
        dgvLeaveHistory = New DataGridView()
        btnApplyforLeave = New FontAwesome.Sharp.IconButton()
        gbLeaveDetails = New GroupBox()
        btnSaveLeave = New FontAwesome.Sharp.IconButton()
        btnCancelLeave = New FontAwesome.Sharp.IconButton()
        gbLeaveDuration = New GroupBox()
        Label13 = New Label()
        dtpDurationDateTo = New DateTimePicker()
        Label14 = New Label()
        dtpDurationDateFrom = New DateTimePicker()
        Label10 = New Label()
        txtStatusLeave = New TextBox()
        Label9 = New Label()
        txtApprovedBy = New TextBox()
        Label12 = New Label()
        txtEmployeeName = New TextBox()
        Label11 = New Label()
        txtLeaveID = New TextBox()
        txtLeaveType = New TextBox()
        txtLeaveReason = New TextBox()
        txtEmployeeID = New TextBox()
        Label6 = New Label()
        Label21 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label51 = New Label()
        lblDashboard = New Label()
        Label27 = New Label()
        Label26 = New Label()
        Label49 = New Label()
        lblSalary = New Label()
        lblLeaveManagement = New Label()
        lblAttendance = New Label()
        lblMyProfile = New Label()
        lblManagement = New Label()
        lblTeamOverview = New Label()
        lblAttendanceTracker = New Label()
        lblDepartment = New Label()
        lblPayrollSummary = New Label()
        lblEmployeeTrainings = New Label()
        lblLeaveApproval = New Label()
        lblTrainings = New Label()
        lblAmenities = New Label()
        Panel1 = New Panel()
        btnSignOut = New FontAwesome.Sharp.IconButton()
        adminheader_pnl.SuspendLayout()
        gbLeaveHistory.SuspendLayout()
        CType(dgvLeaveHistory, ComponentModel.ISupportInitialize).BeginInit()
        gbLeaveDetails.SuspendLayout()
        gbLeaveDuration.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(72, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(324, 34)
        Label2.TabIndex = 0
        Label2.Text = "Leave Management"
        ' 
        ' gbLeaveHistory
        ' 
        gbLeaveHistory.Controls.Add(dgvLeaveHistory)
        gbLeaveHistory.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbLeaveHistory.Location = New Point(372, 549)
        gbLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        gbLeaveHistory.Name = "gbLeaveHistory"
        gbLeaveHistory.Padding = New Padding(4, 3, 4, 3)
        gbLeaveHistory.Size = New Size(1373, 443)
        gbLeaveHistory.TabIndex = 90
        gbLeaveHistory.TabStop = False
        gbLeaveHistory.Text = " Leave History"
        ' 
        ' dgvLeaveHistory
        ' 
        dgvLeaveHistory.AllowUserToResizeColumns = False
        dgvLeaveHistory.AllowUserToResizeRows = False
        dgvLeaveHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLeaveHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLeaveHistory.Location = New Point(28, 59)
        dgvLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        dgvLeaveHistory.Name = "dgvLeaveHistory"
        dgvLeaveHistory.RowHeadersWidth = 51
        dgvLeaveHistory.Size = New Size(1326, 366)
        dgvLeaveHistory.TabIndex = 0
        ' 
        ' btnApplyforLeave
        ' 
        btnApplyforLeave.BackColor = SystemColors.InactiveCaption
        btnApplyforLeave.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnApplyforLeave.IconChar = FontAwesome.Sharp.IconChar.CalendarDays
        btnApplyforLeave.IconColor = Color.Black
        btnApplyforLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnApplyforLeave.IconSize = 30
        btnApplyforLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnApplyforLeave.Location = New Point(926, 233)
        btnApplyforLeave.Name = "btnApplyforLeave"
        btnApplyforLeave.Size = New Size(323, 77)
        btnApplyforLeave.TabIndex = 94
        btnApplyforLeave.Text = "Apply for Leave"
        btnApplyforLeave.TextAlign = ContentAlignment.MiddleRight
        btnApplyforLeave.UseVisualStyleBackColor = False
        ' 
        ' gbLeaveDetails
        ' 
        gbLeaveDetails.Controls.Add(btnApplyforLeave)
        gbLeaveDetails.Controls.Add(btnSaveLeave)
        gbLeaveDetails.Controls.Add(btnCancelLeave)
        gbLeaveDetails.Controls.Add(gbLeaveDuration)
        gbLeaveDetails.Controls.Add(Label10)
        gbLeaveDetails.Controls.Add(txtStatusLeave)
        gbLeaveDetails.Controls.Add(Label9)
        gbLeaveDetails.Controls.Add(txtApprovedBy)
        gbLeaveDetails.Controls.Add(Label12)
        gbLeaveDetails.Controls.Add(txtEmployeeName)
        gbLeaveDetails.Controls.Add(Label11)
        gbLeaveDetails.Controls.Add(txtLeaveID)
        gbLeaveDetails.Controls.Add(txtLeaveType)
        gbLeaveDetails.Controls.Add(txtLeaveReason)
        gbLeaveDetails.Controls.Add(txtEmployeeID)
        gbLeaveDetails.Controls.Add(Label6)
        gbLeaveDetails.Controls.Add(Label21)
        gbLeaveDetails.Controls.Add(Label1)
        gbLeaveDetails.Controls.Add(Label5)
        gbLeaveDetails.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbLeaveDetails.Location = New Point(375, 156)
        gbLeaveDetails.Margin = New Padding(4, 3, 4, 3)
        gbLeaveDetails.Name = "gbLeaveDetails"
        gbLeaveDetails.Padding = New Padding(4, 3, 4, 3)
        gbLeaveDetails.Size = New Size(1370, 362)
        gbLeaveDetails.TabIndex = 89
        gbLeaveDetails.TabStop = False
        gbLeaveDetails.Text = "Details"
        ' 
        ' btnSaveLeave
        ' 
        btnSaveLeave.BackColor = SystemColors.InactiveCaption
        btnSaveLeave.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveLeave.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveLeave.IconColor = Color.Black
        btnSaveLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveLeave.IconSize = 35
        btnSaveLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveLeave.Location = New Point(937, 237)
        btnSaveLeave.Name = "btnSaveLeave"
        btnSaveLeave.Size = New Size(153, 74)
        btnSaveLeave.TabIndex = 112
        btnSaveLeave.Text = "Save"
        btnSaveLeave.TextAlign = ContentAlignment.MiddleRight
        btnSaveLeave.UseVisualStyleBackColor = False
        ' 
        ' btnCancelLeave
        ' 
        btnCancelLeave.BackColor = SystemColors.InactiveCaption
        btnCancelLeave.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelLeave.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelLeave.IconColor = Color.Black
        btnCancelLeave.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelLeave.IconSize = 35
        btnCancelLeave.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelLeave.Location = New Point(1096, 238)
        btnCancelLeave.Name = "btnCancelLeave"
        btnCancelLeave.Size = New Size(153, 72)
        btnCancelLeave.TabIndex = 113
        btnCancelLeave.Text = "Cancel"
        btnCancelLeave.TextAlign = ContentAlignment.MiddleRight
        btnCancelLeave.UseVisualStyleBackColor = False
        ' 
        ' gbLeaveDuration
        ' 
        gbLeaveDuration.Controls.Add(Label13)
        gbLeaveDuration.Controls.Add(dtpDurationDateTo)
        gbLeaveDuration.Controls.Add(Label14)
        gbLeaveDuration.Controls.Add(dtpDurationDateFrom)
        gbLeaveDuration.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbLeaveDuration.Location = New Point(729, 35)
        gbLeaveDuration.Margin = New Padding(4, 3, 4, 3)
        gbLeaveDuration.Name = "gbLeaveDuration"
        gbLeaveDuration.Padding = New Padding(4, 3, 4, 3)
        gbLeaveDuration.Size = New Size(614, 173)
        gbLeaveDuration.TabIndex = 99
        gbLeaveDuration.TabStop = False
        gbLeaveDuration.Text = "Leave Duration"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(52, 66)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 23)
        Label13.TabIndex = 95
        Label13.Text = "Date From:"
        ' 
        ' dtpDurationDateTo
        ' 
        dtpDurationDateTo.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpDurationDateTo.Location = New Point(176, 108)
        dtpDurationDateTo.Name = "dtpDurationDateTo"
        dtpDurationDateTo.Size = New Size(364, 32)
        dtpDurationDateTo.TabIndex = 98
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(79, 117)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 23)
        Label14.TabIndex = 96
        Label14.Text = "Date To:"
        ' 
        ' dtpDurationDateFrom
        ' 
        dtpDurationDateFrom.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpDurationDateFrom.Location = New Point(176, 57)
        dtpDurationDateFrom.Name = "dtpDurationDateFrom"
        dtpDurationDateFrom.Size = New Size(364, 32)
        dtpDurationDateFrom.TabIndex = 97
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(619, 261)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 27)
        Label10.TabIndex = 94
        ' 
        ' txtStatusLeave
        ' 
        txtStatusLeave.Location = New Point(247, 245)
        txtStatusLeave.Margin = New Padding(4, 3, 4, 3)
        txtStatusLeave.Name = "txtStatusLeave"
        txtStatusLeave.Size = New Size(461, 36)
        txtStatusLeave.TabIndex = 93
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(156, 254)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 27)
        Label9.TabIndex = 92
        Label9.Text = "Status:"
        ' 
        ' txtApprovedBy
        ' 
        txtApprovedBy.Location = New Point(247, 291)
        txtApprovedBy.Margin = New Padding(4, 3, 4, 3)
        txtApprovedBy.Name = "txtApprovedBy"
        txtApprovedBy.Size = New Size(460, 36)
        txtApprovedBy.TabIndex = 91
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(31, 86)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(208, 27)
        Label12.TabIndex = 90
        Label12.Text = "Employee Name:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(246, 77)
        txtEmployeeName.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(462, 36)
        txtEmployeeName.TabIndex = 89
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(77, 44)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 27)
        Label11.TabIndex = 86
        Label11.Text = "Employee ID:"
        ' 
        ' txtLeaveID
        ' 
        txtLeaveID.Location = New Point(246, 119)
        txtLeaveID.Margin = New Padding(4, 3, 4, 3)
        txtLeaveID.Name = "txtLeaveID"
        txtLeaveID.Size = New Size(462, 36)
        txtLeaveID.TabIndex = 85
        ' 
        ' txtLeaveType
        ' 
        txtLeaveType.Location = New Point(245, 161)
        txtLeaveType.Margin = New Padding(4, 3, 4, 3)
        txtLeaveType.Name = "txtLeaveType"
        txtLeaveType.Size = New Size(462, 36)
        txtLeaveType.TabIndex = 72
        ' 
        ' txtLeaveReason
        ' 
        txtLeaveReason.Location = New Point(245, 203)
        txtLeaveReason.Margin = New Padding(4, 3, 4, 3)
        txtLeaveReason.Name = "txtLeaveReason"
        txtLeaveReason.Size = New Size(462, 36)
        txtLeaveReason.TabIndex = 80
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(245, 35)
        txtEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(462, 36)
        txtEmployeeID.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(142, 214)
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
        Label21.Location = New Point(120, 128)
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
        Label1.Location = New Point(95, 172)
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
        Label5.Location = New Point(80, 298)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 25)
        Label5.TabIndex = 74
        Label5.Text = "Approved By:"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label51.ForeColor = Color.White
        Label51.Location = New Point(30, 120)
        Label51.Name = "Label51"
        Label51.Size = New Size(57, 22)
        Label51.TabIndex = 90
        Label51.Text = "MAIN"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(53, 160)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(138, 27)
        lblDashboard.TabIndex = 91
        lblDashboard.Text = "Dashboard"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.White
        Label27.Location = New Point(30, 65)
        Label27.Name = "Label27"
        Label27.Size = New Size(312, 27)
        Label27.TabIndex = 96
        Label27.Text = "                                                  "
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(85, 35)
        Label26.Name = "Label26"
        Label26.Size = New Size(197, 34)
        Label26.TabIndex = 97
        Label26.Text = " HR System"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label49.ForeColor = Color.White
        Label49.Location = New Point(30, 230)
        Label49.Name = "Label49"
        Label49.Size = New Size(98, 22)
        Label49.TabIndex = 98
        Label49.Text = "OVERVIEW"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(53, 390)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(81, 27)
        lblSalary.TabIndex = 99
        lblSalary.Text = "Salary"
        ' 
        ' lblLeaveManagement
        ' 
        lblLeaveManagement.AutoSize = True
        lblLeaveManagement.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveManagement.ForeColor = Color.White
        lblLeaveManagement.Location = New Point(53, 350)
        lblLeaveManagement.Name = "lblLeaveManagement"
        lblLeaveManagement.Size = New Size(248, 27)
        lblLeaveManagement.TabIndex = 100
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.AutoSize = True
        lblAttendance.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendance.ForeColor = Color.White
        lblAttendance.Location = New Point(53, 310)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(150, 27)
        lblAttendance.TabIndex = 101
        lblAttendance.Text = "Attendance"
        ' 
        ' lblMyProfile
        ' 
        lblMyProfile.AutoSize = True
        lblMyProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMyProfile.ForeColor = Color.White
        lblMyProfile.Location = New Point(53, 270)
        lblMyProfile.Name = "lblMyProfile"
        lblMyProfile.Size = New Size(124, 27)
        lblMyProfile.TabIndex = 102
        lblMyProfile.Text = "My Profile"
        ' 
        ' lblManagement
        ' 
        lblManagement.AutoSize = True
        lblManagement.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblManagement.ForeColor = Color.White
        lblManagement.Location = New Point(30, 500)
        lblManagement.Name = "lblManagement"
        lblManagement.Size = New Size(135, 22)
        lblManagement.TabIndex = 103
        lblManagement.Text = "MANAGEMENT"
        ' 
        ' lblTeamOverview
        ' 
        lblTeamOverview.AutoSize = True
        lblTeamOverview.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTeamOverview.ForeColor = Color.White
        lblTeamOverview.Location = New Point(53, 540)
        lblTeamOverview.Name = "lblTeamOverview"
        lblTeamOverview.Size = New Size(195, 27)
        lblTeamOverview.TabIndex = 104
        lblTeamOverview.Text = "Team Overview"
        ' 
        ' lblAttendanceTracker
        ' 
        lblAttendanceTracker.AutoSize = True
        lblAttendanceTracker.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendanceTracker.ForeColor = Color.White
        lblAttendanceTracker.Location = New Point(53, 580)
        lblAttendanceTracker.Name = "lblAttendanceTracker"
        lblAttendanceTracker.Size = New Size(239, 27)
        lblAttendanceTracker.TabIndex = 105
        lblAttendanceTracker.Text = "Attendance Tracker"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDepartment.ForeColor = Color.White
        lblDepartment.Location = New Point(53, 740)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(150, 27)
        lblDepartment.TabIndex = 106
        lblDepartment.Text = "Department"
        ' 
        ' lblPayrollSummary
        ' 
        lblPayrollSummary.AutoSize = True
        lblPayrollSummary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPayrollSummary.ForeColor = Color.White
        lblPayrollSummary.Location = New Point(53, 660)
        lblPayrollSummary.Name = "lblPayrollSummary"
        lblPayrollSummary.Size = New Size(200, 27)
        lblPayrollSummary.TabIndex = 107
        lblPayrollSummary.Text = "Payroll Summary"
        ' 
        ' lblEmployeeTrainings
        ' 
        lblEmployeeTrainings.AutoSize = True
        lblEmployeeTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployeeTrainings.ForeColor = Color.White
        lblEmployeeTrainings.Location = New Point(53, 700)
        lblEmployeeTrainings.Name = "lblEmployeeTrainings"
        lblEmployeeTrainings.Size = New Size(230, 27)
        lblEmployeeTrainings.TabIndex = 108
        lblEmployeeTrainings.Text = "Employee Trainings"
        ' 
        ' lblLeaveApproval
        ' 
        lblLeaveApproval.AutoSize = True
        lblLeaveApproval.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveApproval.ForeColor = Color.White
        lblLeaveApproval.Location = New Point(53, 620)
        lblLeaveApproval.Name = "lblLeaveApproval"
        lblLeaveApproval.Size = New Size(198, 27)
        lblLeaveApproval.TabIndex = 109
        lblLeaveApproval.Text = "Leave Approval"
        ' 
        ' lblTrainings
        ' 
        lblTrainings.AutoSize = True
        lblTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrainings.ForeColor = Color.White
        lblTrainings.Location = New Point(53, 430)
        lblTrainings.Name = "lblTrainings"
        lblTrainings.Size = New Size(110, 27)
        lblTrainings.TabIndex = 110
        lblTrainings.Text = "Trainings"
        ' 
        ' lblAmenities
        ' 
        lblAmenities.AutoSize = True
        lblAmenities.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmenities.ForeColor = Color.White
        lblAmenities.Location = New Point(53, 780)
        lblAmenities.Name = "lblAmenities"
        lblAmenities.Size = New Size(118, 27)
        lblAmenities.TabIndex = 111
        lblAmenities.Text = "Amenties"
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
        Panel1.Controls.Add(lblAttendanceTracker)
        Panel1.Controls.Add(lblTeamOverview)
        Panel1.Controls.Add(lblManagement)
        Panel1.Controls.Add(lblMyProfile)
        Panel1.Controls.Add(lblAttendance)
        Panel1.Controls.Add(lblLeaveManagement)
        Panel1.Controls.Add(lblSalary)
        Panel1.Controls.Add(Label49)
        Panel1.Controls.Add(Label26)
        Panel1.Controls.Add(Label27)
        Panel1.Controls.Add(lblDashboard)
        Panel1.Controls.Add(Label51)
        Panel1.Location = New Point(-5, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 1357)
        Panel1.TabIndex = 2
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
        btnSignOut.TabIndex = 112
        btnSignOut.Text = "Sign Out"
        btnSignOut.TextAlign = ContentAlignment.MiddleRight
        btnSignOut.UseVisualStyleBackColor = False
        ' 
        ' Leave_Management
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(gbLeaveHistory)
        Controls.Add(gbLeaveDetails)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Leave_Management"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LeaveManagement_frm"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        gbLeaveHistory.ResumeLayout(False)
        CType(dgvLeaveHistory, ComponentModel.ISupportInitialize).EndInit()
        gbLeaveDetails.ResumeLayout(False)
        gbLeaveDetails.PerformLayout()
        gbLeaveDuration.ResumeLayout(False)
        gbLeaveDuration.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents gbLeaveHistory As GroupBox
    Friend WithEvents dgvLeaveHistory As DataGridView
    Friend WithEvents gbLeaveDetails As GroupBox
    Friend WithEvents gbLeaveDuration As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpDurationDateTo As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpDurationDateFrom As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStatusLeave As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApprovedBy As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLeaveID As TextBox
    Friend WithEvents txtLeaveType As TextBox
    Friend WithEvents txtLeaveReason As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnApplyforLeave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelLeave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveLeave As FontAwesome.Sharp.IconButton
    Friend WithEvents Label51 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblManagement As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblAmenities As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
