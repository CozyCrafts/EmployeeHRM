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
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
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
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
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
        btnDeleteTraining = New Button()
        gbEmployeeLeaveHistory = New GroupBox()
        btnRefreshLeave = New Button()
        txtSearchLeave = New TextBox()
        btnSearchLeave = New Button()
        dgvEmployeeLeaveHistory = New DataGridView()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgvEmployeeTrainingHistory, ComponentModel.ISupportInitialize).BeginInit()
        gbLeaveDetails.SuspendLayout()
        gbLeaveDuration.SuspendLayout()
        gbEmployeeLeaveHistory.SuspendLayout()
        CType(dgvEmployeeLeaveHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 4
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
        Label2.Size = New Size(260, 34)
        Label2.TabIndex = 0
        Label2.Text = "Leave Approval"
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
        gbLeaveDetails.Controls.Add(Button1)
        gbLeaveDetails.Controls.Add(Button3)
        gbLeaveDetails.Controls.Add(Button2)
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
        gbLeaveDetails.Location = New Point(386, 154)
        gbLeaveDetails.Margin = New Padding(4, 3, 4, 3)
        gbLeaveDetails.Name = "gbLeaveDetails"
        gbLeaveDetails.Padding = New Padding(4, 3, 4, 3)
        gbLeaveDetails.Size = New Size(1365, 362)
        gbLeaveDetails.TabIndex = 85
        gbLeaveDetails.TabStop = False
        gbLeaveDetails.Text = "Details"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.InactiveCaption
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(729, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 66)
        Button1.TabIndex = 100
        Button1.Text = "Approve"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.InactiveCaption
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(949, 245)
        Button3.Name = "Button3"
        Button3.Size = New Size(183, 66)
        Button3.TabIndex = 102
        Button3.Text = "Reject"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveCaption
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(1160, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(183, 66)
        Button2.TabIndex = 103
        Button2.Text = "Set to Review"
        Button2.UseVisualStyleBackColor = False
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
        Label13.Location = New Point(51, 66)
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
        Label14.Location = New Point(78, 117)
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
        Label10.Location = New Point(618, 261)
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
        Label9.Location = New Point(155, 254)
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
        Label12.Location = New Point(30, 86)
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
        Label11.Location = New Point(76, 44)
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
        Label6.Location = New Point(141, 214)
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
        Label21.Location = New Point(119, 128)
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
        Label1.Location = New Point(94, 172)
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
        Label5.Location = New Point(79, 298)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 25)
        Label5.TabIndex = 74
        Label5.Text = "Approved By:"
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
        gbEmployeeLeaveHistory.Controls.Add(btnRefreshLeave)
        gbEmployeeLeaveHistory.Controls.Add(txtSearchLeave)
        gbEmployeeLeaveHistory.Controls.Add(btnSearchLeave)
        gbEmployeeLeaveHistory.Controls.Add(dgvEmployeeLeaveHistory)
        gbEmployeeLeaveHistory.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbEmployeeLeaveHistory.Location = New Point(375, 574)
        gbEmployeeLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        gbEmployeeLeaveHistory.Name = "gbEmployeeLeaveHistory"
        gbEmployeeLeaveHistory.Padding = New Padding(4, 3, 4, 3)
        gbEmployeeLeaveHistory.Size = New Size(1370, 443)
        gbEmployeeLeaveHistory.TabIndex = 88
        gbEmployeeLeaveHistory.TabStop = False
        gbEmployeeLeaveHistory.Text = "Employee Leave History"
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
        ' dgvEmployeeLeaveHistory
        ' 
        dgvEmployeeLeaveHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeLeaveHistory.Location = New Point(28, 105)
        dgvEmployeeLeaveHistory.Margin = New Padding(4, 3, 4, 3)
        dgvEmployeeLeaveHistory.Name = "dgvEmployeeLeaveHistory"
        dgvEmployeeLeaveHistory.RowHeadersWidth = 51
        dgvEmployeeLeaveHistory.Size = New Size(1326, 320)
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
        Text = "Leave_Approval"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvEmployeeTrainingHistory, ComponentModel.ISupportInitialize).EndInit()
        gbLeaveDetails.ResumeLayout(False)
        gbLeaveDetails.PerformLayout()
        gbLeaveDuration.ResumeLayout(False)
        gbLeaveDuration.PerformLayout()
        gbEmployeeLeaveHistory.ResumeLayout(False)
        gbEmployeeLeaveHistory.PerformLayout()
        CType(dgvEmployeeLeaveHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents pcbTerminate As PictureBox
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
    Friend WithEvents txtLeaveType As TextBox
    Friend WithEvents txtLeaveReason As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApprovedBy As TextBox
    Friend WithEvents gbLeaveDuration As GroupBox
    Friend WithEvents gbEmployeeLeaveHistory As GroupBox
    Friend WithEvents txtSearchLeave As TextBox
    Friend WithEvents btnSearchLeave As Button
    Friend WithEvents dgvEmployeeLeaveHistory As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtStatusLeave As TextBox
    Friend WithEvents btnRefreshLeave As Button
End Class
