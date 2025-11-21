<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Label6 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        lblDashboard = New Label()
        Label51 = New Label()
        gbDetailsAttendance = New GroupBox()
        btnRecordAttendance = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        txtAttendanceID = New TextBox()
        btnEditAttendance = New FontAwesome.Sharp.IconButton()
        btnCancelAttendance = New FontAwesome.Sharp.IconButton()
        btnSaveAttendance = New FontAwesome.Sharp.IconButton()
        gbDailyTimeRecord = New GroupBox()
        GroupBox2 = New GroupBox()
        btnCheckOutPM = New FontAwesome.Sharp.IconButton()
        btnCheckInPM = New FontAwesome.Sharp.IconButton()
        Label19 = New Label()
        dtpCheckOutPM = New DateTimePicker()
        dtpCheckInPM = New DateTimePicker()
        Label17 = New Label()
        GroupBox1 = New GroupBox()
        btnCheckOutAM = New FontAwesome.Sharp.IconButton()
        dtpCheckInAM = New DateTimePicker()
        Label18 = New Label()
        dtpCheckOutAM = New DateTimePicker()
        btnCheckInAM = New FontAwesome.Sharp.IconButton()
        Label16 = New Label()
        Label14 = New Label()
        dtpDateAttendance = New DateTimePicker()
        txtJobTitle = New TextBox()
        Label9 = New Label()
        txtEmployeeName = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        cbAttendanceStatus = New ComboBox()
        txtEmployeeID = New TextBox()
        Label21 = New Label()
        gbAttendanceHistory = New GroupBox()
        dgvAttendanceHistory = New DataGridView()
        adminheader_pnl.SuspendLayout()
        Panel2.SuspendLayout()
        gbDetailsAttendance.SuspendLayout()
        gbDailyTimeRecord.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        gbAttendanceHistory.SuspendLayout()
        CType(dgvAttendanceHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(206, 34)
        Label2.TabIndex = 0
        Label2.Text = " Attendance"
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
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(Label51)
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
        btnSignOut.TabIndex = 112
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(30, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 22)
        Label6.TabIndex = 98
        Label6.Text = "OVERVIEW"
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
        ' gbDetailsAttendance
        ' 
        gbDetailsAttendance.Controls.Add(btnRecordAttendance)
        gbDetailsAttendance.Controls.Add(Label1)
        gbDetailsAttendance.Controls.Add(txtAttendanceID)
        gbDetailsAttendance.Controls.Add(btnEditAttendance)
        gbDetailsAttendance.Controls.Add(btnCancelAttendance)
        gbDetailsAttendance.Controls.Add(btnSaveAttendance)
        gbDetailsAttendance.Controls.Add(gbDailyTimeRecord)
        gbDetailsAttendance.Controls.Add(txtJobTitle)
        gbDetailsAttendance.Controls.Add(Label9)
        gbDetailsAttendance.Controls.Add(txtEmployeeName)
        gbDetailsAttendance.Controls.Add(Label11)
        gbDetailsAttendance.Controls.Add(Label10)
        gbDetailsAttendance.Controls.Add(cbAttendanceStatus)
        gbDetailsAttendance.Controls.Add(txtEmployeeID)
        gbDetailsAttendance.Controls.Add(Label21)
        gbDetailsAttendance.Cursor = Cursors.PanNE
        gbDetailsAttendance.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDetailsAttendance.Location = New Point(386, 135)
        gbDetailsAttendance.Margin = New Padding(4, 3, 4, 3)
        gbDetailsAttendance.Name = "gbDetailsAttendance"
        gbDetailsAttendance.Padding = New Padding(4, 3, 4, 3)
        gbDetailsAttendance.Size = New Size(1354, 533)
        gbDetailsAttendance.TabIndex = 84
        gbDetailsAttendance.TabStop = False
        gbDetailsAttendance.Text = "Details"
        ' 
        ' btnRecordAttendance
        ' 
        btnRecordAttendance.BackColor = SystemColors.InactiveCaption
        btnRecordAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRecordAttendance.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck
        btnRecordAttendance.IconColor = Color.Black
        btnRecordAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRecordAttendance.IconSize = 40
        btnRecordAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnRecordAttendance.Location = New Point(237, 440)
        btnRecordAttendance.Name = "btnRecordAttendance"
        btnRecordAttendance.Size = New Size(347, 55)
        btnRecordAttendance.TabIndex = 120
        btnRecordAttendance.Text = "Record Attendance"
        btnRecordAttendance.TextAlign = ContentAlignment.MiddleRight
        btnRecordAttendance.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(44, 121)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 27)
        Label1.TabIndex = 119
        Label1.Text = "Attendance ID:"
        ' 
        ' txtAttendanceID
        ' 
        txtAttendanceID.Location = New Point(237, 112)
        txtAttendanceID.Margin = New Padding(4, 3, 4, 3)
        txtAttendanceID.Name = "txtAttendanceID"
        txtAttendanceID.Size = New Size(347, 36)
        txtAttendanceID.TabIndex = 118
        ' 
        ' btnEditAttendance
        ' 
        btnEditAttendance.BackColor = SystemColors.InactiveCaption
        btnEditAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditAttendance.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditAttendance.IconColor = Color.Black
        btnEditAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditAttendance.IconSize = 40
        btnEditAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnEditAttendance.Location = New Point(236, 371)
        btnEditAttendance.Name = "btnEditAttendance"
        btnEditAttendance.Size = New Size(347, 55)
        btnEditAttendance.TabIndex = 115
        btnEditAttendance.Text = "Edit Attendance"
        btnEditAttendance.TextAlign = ContentAlignment.MiddleRight
        btnEditAttendance.UseVisualStyleBackColor = False
        ' 
        ' btnCancelAttendance
        ' 
        btnCancelAttendance.BackColor = SystemColors.InactiveCaption
        btnCancelAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancelAttendance.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelAttendance.IconColor = Color.Black
        btnCancelAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelAttendance.IconSize = 35
        btnCancelAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelAttendance.Location = New Point(409, 372)
        btnCancelAttendance.Name = "btnCancelAttendance"
        btnCancelAttendance.Size = New Size(174, 52)
        btnCancelAttendance.TabIndex = 117
        btnCancelAttendance.Text = "Cancel"
        btnCancelAttendance.TextAlign = ContentAlignment.MiddleRight
        btnCancelAttendance.UseVisualStyleBackColor = False
        ' 
        ' btnSaveAttendance
        ' 
        btnSaveAttendance.BackColor = SystemColors.InactiveCaption
        btnSaveAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSaveAttendance.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveAttendance.IconColor = Color.Black
        btnSaveAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveAttendance.IconSize = 35
        btnSaveAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveAttendance.Location = New Point(237, 372)
        btnSaveAttendance.Name = "btnSaveAttendance"
        btnSaveAttendance.Size = New Size(174, 52)
        btnSaveAttendance.TabIndex = 116
        btnSaveAttendance.Text = "Save"
        btnSaveAttendance.TextAlign = ContentAlignment.MiddleRight
        btnSaveAttendance.UseVisualStyleBackColor = False
        ' 
        ' gbDailyTimeRecord
        ' 
        gbDailyTimeRecord.Controls.Add(GroupBox2)
        gbDailyTimeRecord.Controls.Add(GroupBox1)
        gbDailyTimeRecord.Controls.Add(Label14)
        gbDailyTimeRecord.Controls.Add(dtpDateAttendance)
        gbDailyTimeRecord.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDailyTimeRecord.Location = New Point(622, 35)
        gbDailyTimeRecord.Margin = New Padding(4, 3, 4, 3)
        gbDailyTimeRecord.Name = "gbDailyTimeRecord"
        gbDailyTimeRecord.Padding = New Padding(4, 3, 4, 3)
        gbDailyTimeRecord.Size = New Size(701, 471)
        gbDailyTimeRecord.TabIndex = 114
        gbDailyTimeRecord.TabStop = False
        gbDailyTimeRecord.Text = "Daily Time Record"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnCheckOutPM)
        GroupBox2.Controls.Add(btnCheckInPM)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(dtpCheckOutPM)
        GroupBox2.Controls.Add(dtpCheckInPM)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Location = New Point(19, 287)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(666, 168)
        GroupBox2.TabIndex = 119
        GroupBox2.TabStop = False
        GroupBox2.Text = "PM"
        ' 
        ' btnCheckOutPM
        ' 
        btnCheckOutPM.BackColor = SystemColors.InactiveCaption
        btnCheckOutPM.BackgroundImageLayout = ImageLayout.None
        btnCheckOutPM.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        btnCheckOutPM.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft
        btnCheckOutPM.IconColor = Color.Black
        btnCheckOutPM.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCheckOutPM.IconSize = 30
        btnCheckOutPM.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckOutPM.Location = New Point(496, 88)
        btnCheckOutPM.Name = "btnCheckOutPM"
        btnCheckOutPM.Size = New Size(154, 56)
        btnCheckOutPM.TabIndex = 118
        btnCheckOutPM.Text = "Check Out"
        btnCheckOutPM.TextAlign = ContentAlignment.MiddleRight
        btnCheckOutPM.UseVisualStyleBackColor = False
        ' 
        ' btnCheckInPM
        ' 
        btnCheckInPM.BackColor = SystemColors.InactiveCaption
        btnCheckInPM.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckInPM.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        btnCheckInPM.IconColor = Color.Black
        btnCheckInPM.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCheckInPM.IconSize = 30
        btnCheckInPM.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckInPM.Location = New Point(168, 90)
        btnCheckInPM.Name = "btnCheckInPM"
        btnCheckInPM.Size = New Size(139, 56)
        btnCheckInPM.TabIndex = 117
        btnCheckInPM.Text = "Check In"
        btnCheckInPM.TextAlign = ContentAlignment.MiddleRight
        btnCheckInPM.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 13F)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(332, 59)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(157, 25)
        Label19.TabIndex = 102
        Label19.Text = "Time Out PM:"
        ' 
        ' dtpCheckOutPM
        ' 
        dtpCheckOutPM.CustomFormat = "hh:mm tt"
        dtpCheckOutPM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckOutPM.Format = DateTimePickerFormat.Custom
        dtpCheckOutPM.Location = New Point(496, 50)
        dtpCheckOutPM.Name = "dtpCheckOutPM"
        dtpCheckOutPM.Size = New Size(154, 32)
        dtpCheckOutPM.TabIndex = 110
        ' 
        ' dtpCheckInPM
        ' 
        dtpCheckInPM.CustomFormat = "hh:mm tt"
        dtpCheckInPM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckInPM.Format = DateTimePickerFormat.Custom
        dtpCheckInPM.Location = New Point(168, 52)
        dtpCheckInPM.Name = "dtpCheckInPM"
        dtpCheckInPM.Size = New Size(140, 32)
        dtpCheckInPM.TabIndex = 112
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 13F)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(25, 57)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(136, 25)
        Label17.TabIndex = 98
        Label17.Text = "Time In PM:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnCheckOutAM)
        GroupBox1.Controls.Add(dtpCheckInAM)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(dtpCheckOutAM)
        GroupBox1.Controls.Add(btnCheckInAM)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Location = New Point(19, 120)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(666, 161)
        GroupBox1.TabIndex = 118
        GroupBox1.TabStop = False
        GroupBox1.Text = "AM"
        ' 
        ' btnCheckOutAM
        ' 
        btnCheckOutAM.BackColor = SystemColors.InactiveCaption
        btnCheckOutAM.BackgroundImageLayout = ImageLayout.None
        btnCheckOutAM.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        btnCheckOutAM.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft
        btnCheckOutAM.IconColor = Color.Black
        btnCheckOutAM.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCheckOutAM.IconSize = 30
        btnCheckOutAM.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckOutAM.Location = New Point(496, 87)
        btnCheckOutAM.Name = "btnCheckOutAM"
        btnCheckOutAM.Size = New Size(154, 56)
        btnCheckOutAM.TabIndex = 116
        btnCheckOutAM.Text = "Check Out"
        btnCheckOutAM.TextAlign = ContentAlignment.MiddleRight
        btnCheckOutAM.UseVisualStyleBackColor = False
        ' 
        ' dtpCheckInAM
        ' 
        dtpCheckInAM.CustomFormat = "hh:mm tt"
        dtpCheckInAM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckInAM.Format = DateTimePickerFormat.Custom
        dtpCheckInAM.Location = New Point(168, 49)
        dtpCheckInAM.Name = "dtpCheckInAM"
        dtpCheckInAM.Size = New Size(139, 32)
        dtpCheckInAM.TabIndex = 109
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 13F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(328, 56)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(161, 25)
        Label18.TabIndex = 100
        Label18.Text = "Time Out AM:"
        ' 
        ' dtpCheckOutAM
        ' 
        dtpCheckOutAM.CustomFormat = "hh:mm tt"
        dtpCheckOutAM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckOutAM.Format = DateTimePickerFormat.Custom
        dtpCheckOutAM.Location = New Point(496, 49)
        dtpCheckOutAM.Name = "dtpCheckOutAM"
        dtpCheckOutAM.Size = New Size(154, 32)
        dtpCheckOutAM.TabIndex = 111
        ' 
        ' btnCheckInAM
        ' 
        btnCheckInAM.BackColor = SystemColors.InactiveCaption
        btnCheckInAM.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckInAM.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        btnCheckInAM.IconColor = Color.Black
        btnCheckInAM.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCheckInAM.IconSize = 30
        btnCheckInAM.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckInAM.Location = New Point(168, 87)
        btnCheckInAM.Name = "btnCheckInAM"
        btnCheckInAM.Size = New Size(139, 56)
        btnCheckInAM.TabIndex = 115
        btnCheckInAM.Text = "Check In"
        btnCheckInAM.TextAlign = ContentAlignment.MiddleRight
        btnCheckInAM.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 13F)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(21, 56)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(140, 25)
        Label16.TabIndex = 96
        Label16.Text = "Time In AM:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 13F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(183, 81)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(71, 25)
        Label14.TabIndex = 92
        Label14.Text = "Date:"
        ' 
        ' dtpDateAttendance
        ' 
        dtpDateAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpDateAttendance.Location = New Point(261, 74)
        dtpDateAttendance.Name = "dtpDateAttendance"
        dtpDateAttendance.Size = New Size(357, 32)
        dtpDateAttendance.TabIndex = 104
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Location = New Point(237, 268)
        txtJobTitle.Margin = New Padding(4, 3, 4, 3)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(347, 36)
        txtJobTitle.TabIndex = 106
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(122, 279)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 25)
        Label9.TabIndex = 105
        Label9.Text = "Job Title:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(237, 216)
        txtEmployeeName.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(347, 36)
        txtEmployeeName.TabIndex = 86
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(21, 225)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(208, 27)
        Label11.TabIndex = 87
        Label11.Text = "Employee Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(147, 330)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 25)
        Label10.TabIndex = 85
        Label10.Text = "Status:"
        ' 
        ' cbAttendanceStatus
        ' 
        cbAttendanceStatus.FormattingEnabled = True
        cbAttendanceStatus.Location = New Point(236, 320)
        cbAttendanceStatus.Name = "cbAttendanceStatus"
        cbAttendanceStatus.Size = New Size(347, 35)
        cbAttendanceStatus.TabIndex = 84
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(237, 164)
        txtEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(347, 36)
        txtEmployeeID.TabIndex = 23
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(68, 173)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(161, 27)
        Label21.TabIndex = 70
        Label21.Text = "Employee ID:"
        ' 
        ' gbAttendanceHistory
        ' 
        gbAttendanceHistory.Controls.Add(dgvAttendanceHistory)
        gbAttendanceHistory.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbAttendanceHistory.Location = New Point(386, 677)
        gbAttendanceHistory.Margin = New Padding(4, 3, 4, 3)
        gbAttendanceHistory.Name = "gbAttendanceHistory"
        gbAttendanceHistory.Padding = New Padding(4, 3, 4, 3)
        gbAttendanceHistory.Size = New Size(1338, 380)
        gbAttendanceHistory.TabIndex = 85
        gbAttendanceHistory.TabStop = False
        gbAttendanceHistory.Text = "Attendance History"
        ' 
        ' dgvAttendanceHistory
        ' 
        dgvAttendanceHistory.AllowUserToAddRows = False
        dgvAttendanceHistory.AllowUserToDeleteRows = False
        dgvAttendanceHistory.AllowUserToResizeColumns = False
        dgvAttendanceHistory.AllowUserToResizeRows = False
        dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAttendanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendanceHistory.Location = New Point(44, 57)
        dgvAttendanceHistory.Margin = New Padding(4, 3, 4, 3)
        dgvAttendanceHistory.Name = "dgvAttendanceHistory"
        dgvAttendanceHistory.ReadOnly = True
        dgvAttendanceHistory.RowHeadersWidth = 51
        dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendanceHistory.Size = New Size(1255, 282)
        dgvAttendanceHistory.TabIndex = 0
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(gbAttendanceHistory)
        Controls.Add(gbDetailsAttendance)
        Controls.Add(Panel2)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Time_and_Attendancevb"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        gbDetailsAttendance.ResumeLayout(False)
        gbDetailsAttendance.PerformLayout()
        gbDailyTimeRecord.ResumeLayout(False)
        gbDailyTimeRecord.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbAttendanceHistory.ResumeLayout(False)
        CType(dgvAttendanceHistory, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents gbDetailsAttendance As GroupBox
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDateAttendance As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbAttendanceStatus As ComboBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents gbAttendanceHistory As GroupBox
    Friend WithEvents dgvAttendanceHistory As DataGridView
    Friend WithEvents dtpCheckInPM As DateTimePicker
    Friend WithEvents dtpCheckOutAM As DateTimePicker
    Friend WithEvents dtpCheckOutPM As DateTimePicker
    Friend WithEvents dtpCheckInAM As DateTimePicker
    Friend WithEvents gbDailyTimeRecord As GroupBox
    Friend WithEvents btnCheckInAM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCheckOutAM As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCheckOutPM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCheckInPM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRecordAttendance As FontAwesome.Sharp.IconButton
End Class
