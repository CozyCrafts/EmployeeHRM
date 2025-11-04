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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leave_Management))
        Panel1 = New Panel()
        lblAmenities = New Label()
        lblTrainings = New Label()
        lblLeaveApproval = New Label()
        lblEmployeeTrainings = New Label()
        lblPayrollSummary = New Label()
        lblDepartment = New Label()
        lblAttendanceTracker = New Label()
        lblTeamOverview = New Label()
        Label28 = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        lblSalary = New Label()
        Label49 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        lblDashboard = New Label()
        Label51 = New Label()
        adminheader_pnl = New Panel()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        gbLeaveHistory = New GroupBox()
        btnRefreshLeave = New Button()
        txtSearchLeave = New TextBox()
        btnSearchLeave = New Button()
        dgvLeaveHistory = New DataGridView()
        gbLeaveDetails = New GroupBox()
        gbLeaveDuration = New GroupBox()
        Label13 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label14 = New Label()
        DateTimePicker1 = New DateTimePicker()
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
        btnApplyforLeave = New Button()
        btnSubmitLeave = New Button()
        btnResetLeave = New Button()
        btnDeleteLeaveRequest = New Button()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        gbLeaveHistory.SuspendLayout()
        CType(dgvLeaveHistory, ComponentModel.ISupportInitialize).BeginInit()
        gbLeaveDetails.SuspendLayout()
        gbLeaveDuration.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(lblAmenities)
        Panel1.Controls.Add(lblTrainings)
        Panel1.Controls.Add(lblLeaveApproval)
        Panel1.Controls.Add(lblEmployeeTrainings)
        Panel1.Controls.Add(lblPayrollSummary)
        Panel1.Controls.Add(lblDepartment)
        Panel1.Controls.Add(lblAttendanceTracker)
        Panel1.Controls.Add(lblTeamOverview)
        Panel1.Controls.Add(Label28)
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
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.White
        Label28.Location = New Point(30, 500)
        Label28.Name = "Label28"
        Label28.Size = New Size(135, 22)
        Label28.TabIndex = 103
        Label28.Text = "MANAGEMENT"
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
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 3
        ' 
        ' pcbTerminate
        ' 
        pcbTerminate.Image = CType(resources.GetObject("pcbTerminate.Image"), Image)
        pcbTerminate.Location = New Point(1352, 45)
        pcbTerminate.Name = "pcbTerminate"
        pcbTerminate.Size = New Size(55, 54)
        pcbTerminate.SizeMode = PictureBoxSizeMode.StretchImage
        pcbTerminate.TabIndex = 1
        pcbTerminate.TabStop = False
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
        gbLeaveHistory.Controls.Add(btnRefreshLeave)
        gbLeaveHistory.Controls.Add(txtSearchLeave)
        gbLeaveHistory.Controls.Add(btnSearchLeave)
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
        ' btnRefreshLeave
        ' 
        btnRefreshLeave.BackColor = SystemColors.InactiveCaption
        btnRefreshLeave.BackgroundImageLayout = ImageLayout.None
        btnRefreshLeave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnRefreshLeave.ForeColor = Color.Black
        btnRefreshLeave.Location = New Point(1187, 40)
        btnRefreshLeave.Name = "btnRefreshLeave"
        btnRefreshLeave.Size = New Size(167, 46)
        btnRefreshLeave.TabIndex = 94
        btnRefreshLeave.Text = "Refresh Data"
        btnRefreshLeave.UseVisualStyleBackColor = False
        ' 
        ' txtSearchLeave
        ' 
        txtSearchLeave.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchLeave.Location = New Point(202, 61)
        txtSearchLeave.Margin = New Padding(4, 3, 4, 3)
        txtSearchLeave.Name = "txtSearchLeave"
        txtSearchLeave.Size = New Size(256, 32)
        txtSearchLeave.TabIndex = 93
        ' 
        ' btnSearchLeave
        ' 
        btnSearchLeave.BackColor = SystemColors.InactiveCaption
        btnSearchLeave.BackgroundImageLayout = ImageLayout.None
        btnSearchLeave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSearchLeave.ForeColor = Color.Black
        btnSearchLeave.Location = New Point(28, 53)
        btnSearchLeave.Name = "btnSearchLeave"
        btnSearchLeave.Size = New Size(167, 46)
        btnSearchLeave.TabIndex = 92
        btnSearchLeave.Text = "Search"
        btnSearchLeave.UseVisualStyleBackColor = False
        ' 
        ' dgvLeaveHistory
        ' 
        dgvLeaveHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLeaveHistory.Location = New Point(28, 105)
        dgvLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        dgvLeaveHistory.Name = "dgvLeaveHistory"
        dgvLeaveHistory.RowHeadersWidth = 51
        dgvLeaveHistory.Size = New Size(1326, 320)
        dgvLeaveHistory.TabIndex = 0
        ' 
        ' gbLeaveDetails
        ' 
        gbLeaveDetails.Controls.Add(btnDeleteLeaveRequest)
        gbLeaveDetails.Controls.Add(btnApplyforLeave)
        gbLeaveDetails.Controls.Add(btnSubmitLeave)
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
        gbLeaveDetails.Controls.Add(btnResetLeave)
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
        ' gbLeaveDuration
        ' 
        gbLeaveDuration.Controls.Add(Label13)
        gbLeaveDuration.Controls.Add(DateTimePicker2)
        gbLeaveDuration.Controls.Add(Label14)
        gbLeaveDuration.Controls.Add(DateTimePicker1)
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
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        DateTimePicker2.Location = New Point(176, 108)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(364, 32)
        DateTimePicker2.TabIndex = 98
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
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(176, 57)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(364, 32)
        DateTimePicker1.TabIndex = 97
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
        ' btnApplyforLeave
        ' 
        btnApplyforLeave.BackColor = SystemColors.InactiveCaption
        btnApplyforLeave.BackgroundImageLayout = ImageLayout.None
        btnApplyforLeave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnApplyforLeave.ForeColor = Color.Black
        btnApplyforLeave.Location = New Point(869, 223)
        btnApplyforLeave.Name = "btnApplyforLeave"
        btnApplyforLeave.Size = New Size(342, 46)
        btnApplyforLeave.TabIndex = 100
        btnApplyforLeave.Text = "Apply for Leave"
        btnApplyforLeave.UseVisualStyleBackColor = False
        ' 
        ' btnSubmitLeave
        ' 
        btnSubmitLeave.BackColor = SystemColors.InactiveCaption
        btnSubmitLeave.BackgroundImageLayout = ImageLayout.None
        btnSubmitLeave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSubmitLeave.ForeColor = Color.Black
        btnSubmitLeave.Location = New Point(871, 223)
        btnSubmitLeave.Name = "btnSubmitLeave"
        btnSubmitLeave.Size = New Size(167, 46)
        btnSubmitLeave.TabIndex = 101
        btnSubmitLeave.Text = "Submit"
        btnSubmitLeave.UseVisualStyleBackColor = False
        ' 
        ' btnResetLeave
        ' 
        btnResetLeave.BackColor = SystemColors.InactiveCaption
        btnResetLeave.BackgroundImageLayout = ImageLayout.None
        btnResetLeave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnResetLeave.ForeColor = Color.Black
        btnResetLeave.Location = New Point(1044, 223)
        btnResetLeave.Name = "btnResetLeave"
        btnResetLeave.Size = New Size(167, 46)
        btnResetLeave.TabIndex = 102
        btnResetLeave.Text = "Reset"
        btnResetLeave.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteLeaveRequest
        ' 
        btnDeleteLeaveRequest.BackColor = SystemColors.InactiveCaption
        btnDeleteLeaveRequest.BackgroundImageLayout = ImageLayout.None
        btnDeleteLeaveRequest.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnDeleteLeaveRequest.ForeColor = Color.Black
        btnDeleteLeaveRequest.Location = New Point(869, 275)
        btnDeleteLeaveRequest.Name = "btnDeleteLeaveRequest"
        btnDeleteLeaveRequest.Size = New Size(342, 46)
        btnDeleteLeaveRequest.TabIndex = 103
        btnDeleteLeaveRequest.Text = "Delete Request"
        btnDeleteLeaveRequest.UseVisualStyleBackColor = False
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        gbLeaveHistory.ResumeLayout(False)
        gbLeaveHistory.PerformLayout()
        CType(dgvLeaveHistory, ComponentModel.ISupportInitialize).EndInit()
        gbLeaveDetails.ResumeLayout(False)
        gbLeaveDetails.PerformLayout()
        gbLeaveDuration.ResumeLayout(False)
        gbLeaveDuration.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents gbLeaveHistory As GroupBox
    Friend WithEvents btnRefreshLeave As Button
    Friend WithEvents txtSearchLeave As TextBox
    Friend WithEvents btnSearchLeave As Button
    Friend WithEvents dgvLeaveHistory As DataGridView
    Friend WithEvents gbLeaveDetails As GroupBox
    Friend WithEvents gbLeaveDuration As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
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
    Friend WithEvents btnApplyforLeave As Button
    Friend WithEvents btnResetLeave As Button
    Friend WithEvents btnSubmitLeave As Button
    Friend WithEvents btnDeleteLeaveRequest As Button
End Class
