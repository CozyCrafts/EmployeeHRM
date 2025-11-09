<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance_Tracker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance_Tracker))
        adminheader_pnl = New Panel()
        btnSignOut = New FontAwesome.Sharp.IconButton()
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
        gbAttendanceList = New GroupBox()
        txtSearchAttendance = New TextBox()
        PictureBox1 = New PictureBox()
        dgvAttendanceList = New DataGridView()
        gbAttendanceDetails = New GroupBox()
        gbDailyTimeRecord = New GroupBox()
        dtpCheckOutPM = New DateTimePicker()
        dtpCheckInPM = New DateTimePicker()
        dtpCheckOutAM = New DateTimePicker()
        dtpCheckInAM = New DateTimePicker()
        dtpDateAttendance = New DateTimePicker()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label14 = New Label()
        txtJobTitle = New TextBox()
        btnEditAttendance = New FontAwesome.Sharp.IconButton()
        Label9 = New Label()
        btnCancelAttendance = New FontAwesome.Sharp.IconButton()
        txtAttendanceID = New TextBox()
        Label6 = New Label()
        btnSaveAttendance = New FontAwesome.Sharp.IconButton()
        txtAbscences = New TextBox()
        Label15 = New Label()
        txtDaysAttended = New TextBox()
        Label13 = New Label()
        txtExtendedHours = New TextBox()
        Label12 = New Label()
        txtEmployeeName = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        cbAttendanceStatus = New ComboBox()
        txtTotalHours = New TextBox()
        txtDepartmentID = New TextBox()
        txtEmployeeID = New TextBox()
        Label21 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        adminheader_pnl.SuspendLayout()
        Panel1.SuspendLayout()
        gbAttendanceList.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAttendanceList, ComponentModel.ISupportInitialize).BeginInit()
        gbAttendanceDetails.SuspendLayout()
        gbDailyTimeRecord.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(btnSignOut)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 4
        ' 
        ' btnSignOut
        ' 
        btnSignOut.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnSignOut.IconColor = Color.Black
        btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSignOut.IconSize = 38
        btnSignOut.ImageAlign = ContentAlignment.MiddleLeft
        btnSignOut.Location = New Point(1265, 46)
        btnSignOut.Name = "btnSignOut"
        btnSignOut.Size = New Size(142, 54)
        btnSignOut.TabIndex = 40
        btnSignOut.Text = "Sign Out"
        btnSignOut.TextAlign = ContentAlignment.MiddleRight
        btnSignOut.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(72, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(326, 34)
        Label2.TabIndex = 0
        Label2.Text = "Attendance Tracker"
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
        ' gbAttendanceList
        ' 
        gbAttendanceList.Controls.Add(txtSearchAttendance)
        gbAttendanceList.Controls.Add(PictureBox1)
        gbAttendanceList.Controls.Add(dgvAttendanceList)
        gbAttendanceList.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbAttendanceList.Location = New Point(410, 545)
        gbAttendanceList.Margin = New Padding(4, 3, 4, 3)
        gbAttendanceList.Name = "gbAttendanceList"
        gbAttendanceList.Padding = New Padding(4, 3, 4, 3)
        gbAttendanceList.Size = New Size(1335, 573)
        gbAttendanceList.TabIndex = 68
        gbAttendanceList.TabStop = False
        gbAttendanceList.Text = "Attendance List"
        ' 
        ' txtSearchAttendance
        ' 
        txtSearchAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchAttendance.Location = New Point(81, 54)
        txtSearchAttendance.Margin = New Padding(4, 3, 4, 3)
        txtSearchAttendance.Name = "txtSearchAttendance"
        txtSearchAttendance.Size = New Size(256, 32)
        txtSearchAttendance.TabIndex = 90
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(15, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 104
        PictureBox1.TabStop = False
        ' 
        ' dgvAttendanceList
        ' 
        dgvAttendanceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendanceList.Location = New Point(26, 92)
        dgvAttendanceList.Margin = New Padding(4, 3, 4, 3)
        dgvAttendanceList.Name = "dgvAttendanceList"
        dgvAttendanceList.RowHeadersWidth = 51
        dgvAttendanceList.Size = New Size(1288, 454)
        dgvAttendanceList.TabIndex = 0
        ' 
        ' gbAttendanceDetails
        ' 
        gbAttendanceDetails.Controls.Add(gbDailyTimeRecord)
        gbAttendanceDetails.Controls.Add(txtJobTitle)
        gbAttendanceDetails.Controls.Add(btnEditAttendance)
        gbAttendanceDetails.Controls.Add(Label9)
        gbAttendanceDetails.Controls.Add(btnCancelAttendance)
        gbAttendanceDetails.Controls.Add(txtAttendanceID)
        gbAttendanceDetails.Controls.Add(Label6)
        gbAttendanceDetails.Controls.Add(btnSaveAttendance)
        gbAttendanceDetails.Controls.Add(txtAbscences)
        gbAttendanceDetails.Controls.Add(Label15)
        gbAttendanceDetails.Controls.Add(txtDaysAttended)
        gbAttendanceDetails.Controls.Add(Label13)
        gbAttendanceDetails.Controls.Add(txtExtendedHours)
        gbAttendanceDetails.Controls.Add(Label12)
        gbAttendanceDetails.Controls.Add(txtEmployeeName)
        gbAttendanceDetails.Controls.Add(Label11)
        gbAttendanceDetails.Controls.Add(Label10)
        gbAttendanceDetails.Controls.Add(cbAttendanceStatus)
        gbAttendanceDetails.Controls.Add(txtTotalHours)
        gbAttendanceDetails.Controls.Add(txtDepartmentID)
        gbAttendanceDetails.Controls.Add(txtEmployeeID)
        gbAttendanceDetails.Controls.Add(Label21)
        gbAttendanceDetails.Controls.Add(Label1)
        gbAttendanceDetails.Controls.Add(Label5)
        gbAttendanceDetails.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbAttendanceDetails.Location = New Point(410, 154)
        gbAttendanceDetails.Margin = New Padding(4, 3, 4, 3)
        gbAttendanceDetails.Name = "gbAttendanceDetails"
        gbAttendanceDetails.Padding = New Padding(4, 3, 4, 3)
        gbAttendanceDetails.Size = New Size(1335, 385)
        gbAttendanceDetails.TabIndex = 83
        gbAttendanceDetails.TabStop = False
        gbAttendanceDetails.Text = "Details"
        ' 
        ' gbDailyTimeRecord
        ' 
        gbDailyTimeRecord.Controls.Add(dtpCheckOutPM)
        gbDailyTimeRecord.Controls.Add(dtpCheckInPM)
        gbDailyTimeRecord.Controls.Add(dtpCheckOutAM)
        gbDailyTimeRecord.Controls.Add(dtpCheckInAM)
        gbDailyTimeRecord.Controls.Add(dtpDateAttendance)
        gbDailyTimeRecord.Controls.Add(Label19)
        gbDailyTimeRecord.Controls.Add(Label18)
        gbDailyTimeRecord.Controls.Add(Label17)
        gbDailyTimeRecord.Controls.Add(Label16)
        gbDailyTimeRecord.Controls.Add(Label14)
        gbDailyTimeRecord.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDailyTimeRecord.Location = New Point(915, 40)
        gbDailyTimeRecord.Margin = New Padding(4, 3, 4, 3)
        gbDailyTimeRecord.Name = "gbDailyTimeRecord"
        gbDailyTimeRecord.Padding = New Padding(4, 3, 4, 3)
        gbDailyTimeRecord.Size = New Size(399, 322)
        gbDailyTimeRecord.TabIndex = 120
        gbDailyTimeRecord.TabStop = False
        gbDailyTimeRecord.Text = "Daily Time Record"
        ' 
        ' dtpCheckOutPM
        ' 
        dtpCheckOutPM.CustomFormat = "hh:mm tt"
        dtpCheckOutPM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckOutPM.Format = DateTimePickerFormat.Custom
        dtpCheckOutPM.Location = New Point(212, 260)
        dtpCheckOutPM.Name = "dtpCheckOutPM"
        dtpCheckOutPM.Size = New Size(157, 32)
        dtpCheckOutPM.TabIndex = 126
        ' 
        ' dtpCheckInPM
        ' 
        dtpCheckInPM.CustomFormat = "hh:mm tt"
        dtpCheckInPM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckInPM.Format = DateTimePickerFormat.Custom
        dtpCheckInPM.Location = New Point(212, 210)
        dtpCheckInPM.Name = "dtpCheckInPM"
        dtpCheckInPM.Size = New Size(157, 32)
        dtpCheckInPM.TabIndex = 125
        ' 
        ' dtpCheckOutAM
        ' 
        dtpCheckOutAM.CustomFormat = "hh:mm tt"
        dtpCheckOutAM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckOutAM.Format = DateTimePickerFormat.Custom
        dtpCheckOutAM.Location = New Point(212, 160)
        dtpCheckOutAM.Name = "dtpCheckOutAM"
        dtpCheckOutAM.Size = New Size(157, 32)
        dtpCheckOutAM.TabIndex = 124
        ' 
        ' dtpCheckInAM
        ' 
        dtpCheckInAM.CustomFormat = "hh:mm tt"
        dtpCheckInAM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCheckInAM.Format = DateTimePickerFormat.Custom
        dtpCheckInAM.Location = New Point(212, 110)
        dtpCheckInAM.Name = "dtpCheckInAM"
        dtpCheckInAM.Size = New Size(157, 32)
        dtpCheckInAM.TabIndex = 123
        ' 
        ' dtpDateAttendance
        ' 
        dtpDateAttendance.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        dtpDateAttendance.Location = New Point(42, 69)
        dtpDateAttendance.Name = "dtpDateAttendance"
        dtpDateAttendance.Size = New Size(327, 30)
        dtpDateAttendance.TabIndex = 122
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 13F)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(48, 265)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(157, 25)
        Label19.TabIndex = 121
        Label19.Text = "Time Out PM:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 13F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(44, 167)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(161, 25)
        Label18.TabIndex = 120
        Label18.Text = "Time Out AM:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 13F)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(69, 217)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(136, 25)
        Label17.TabIndex = 119
        Label17.Text = "Time In PM:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 13F)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(65, 117)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(140, 25)
        Label16.TabIndex = 118
        Label16.Text = "Time In AM:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 13F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(42, 41)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(71, 25)
        Label14.TabIndex = 117
        Label14.Text = "Date:"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Location = New Point(231, 179)
        txtJobTitle.Margin = New Padding(4, 3, 4, 3)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(256, 36)
        txtJobTitle.TabIndex = 106
        ' 
        ' btnEditAttendance
        ' 
        btnEditAttendance.BackColor = SystemColors.InactiveCaption
        btnEditAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnEditAttendance.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditAttendance.IconColor = Color.Black
        btnEditAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditAttendance.IconSize = 35
        btnEditAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnEditAttendance.Location = New Point(363, 299)
        btnEditAttendance.Name = "btnEditAttendance"
        btnEditAttendance.Size = New Size(341, 67)
        btnEditAttendance.TabIndex = 122
        btnEditAttendance.Text = "Edit Attendance"
        btnEditAttendance.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(116, 192)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 25)
        Label9.TabIndex = 105
        Label9.Text = "Job Title:"
        ' 
        ' btnCancelAttendance
        ' 
        btnCancelAttendance.BackColor = SystemColors.InactiveCaption
        btnCancelAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancelAttendance.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelAttendance.IconColor = Color.Black
        btnCancelAttendance.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnCancelAttendance.IconSize = 35
        btnCancelAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelAttendance.Location = New Point(533, 299)
        btnCancelAttendance.Name = "btnCancelAttendance"
        btnCancelAttendance.Size = New Size(171, 68)
        btnCancelAttendance.TabIndex = 124
        btnCancelAttendance.Text = "Cancel"
        btnCancelAttendance.TextAlign = ContentAlignment.MiddleRight
        btnCancelAttendance.UseVisualStyleBackColor = False
        ' 
        ' txtAttendanceID
        ' 
        txtAttendanceID.Location = New Point(706, 56)
        txtAttendanceID.Margin = New Padding(4, 3, 4, 3)
        txtAttendanceID.Name = "txtAttendanceID"
        txtAttendanceID.Size = New Size(201, 36)
        txtAttendanceID.TabIndex = 80
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(521, 66)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 25)
        Label6.TabIndex = 79
        Label6.Text = "Attendance ID:"
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
        btnSaveAttendance.Location = New Point(363, 300)
        btnSaveAttendance.Name = "btnSaveAttendance"
        btnSaveAttendance.Size = New Size(173, 67)
        btnSaveAttendance.TabIndex = 125
        btnSaveAttendance.Text = "Save "
        btnSaveAttendance.TextAlign = ContentAlignment.MiddleRight
        btnSaveAttendance.UseVisualStyleBackColor = False
        ' 
        ' txtAbscences
        ' 
        txtAbscences.Location = New Point(706, 181)
        txtAbscences.Margin = New Padding(4, 3, 4, 3)
        txtAbscences.Name = "txtAbscences"
        txtAbscences.Size = New Size(201, 36)
        txtAbscences.TabIndex = 95
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 13F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(561, 192)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(137, 25)
        Label15.TabIndex = 94
        Label15.Text = "Abscences:"
        ' 
        ' txtDaysAttended
        ' 
        txtDaysAttended.Location = New Point(706, 223)
        txtDaysAttended.Margin = New Padding(4, 3, 4, 3)
        txtDaysAttended.Name = "txtDaysAttended"
        txtDaysAttended.Size = New Size(201, 36)
        txtDaysAttended.TabIndex = 91
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 13F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(517, 234)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(181, 25)
        Label13.TabIndex = 90
        Label13.Text = "Days Attended:"
        ' 
        ' txtExtendedHours
        ' 
        txtExtendedHours.Location = New Point(706, 139)
        txtExtendedHours.Margin = New Padding(4, 3, 4, 3)
        txtExtendedHours.Name = "txtExtendedHours"
        txtExtendedHours.Size = New Size(201, 36)
        txtExtendedHours.TabIndex = 89
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13F)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(514, 150)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(184, 25)
        Label12.TabIndex = 88
        Label12.Text = "Extended Hours:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(231, 95)
        txtEmployeeName.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(256, 36)
        txtEmployeeName.TabIndex = 86
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(15, 104)
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
        Label10.Location = New Point(141, 231)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 25)
        Label10.TabIndex = 85
        Label10.Text = "Status:"
        ' 
        ' cbAttendanceStatus
        ' 
        cbAttendanceStatus.FormattingEnabled = True
        cbAttendanceStatus.Location = New Point(231, 221)
        cbAttendanceStatus.Name = "cbAttendanceStatus"
        cbAttendanceStatus.Size = New Size(256, 35)
        cbAttendanceStatus.TabIndex = 84
        ' 
        ' txtTotalHours
        ' 
        txtTotalHours.Location = New Point(706, 98)
        txtTotalHours.Margin = New Padding(4, 3, 4, 3)
        txtTotalHours.Name = "txtTotalHours"
        txtTotalHours.Size = New Size(201, 36)
        txtTotalHours.TabIndex = 82
        ' 
        ' txtDepartmentID
        ' 
        txtDepartmentID.Location = New Point(231, 137)
        txtDepartmentID.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentID.Name = "txtDepartmentID"
        txtDepartmentID.Size = New Size(256, 36)
        txtDepartmentID.TabIndex = 72
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(231, 53)
        txtEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(256, 36)
        txtEmployeeID.TabIndex = 23
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(62, 62)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(161, 27)
        Label21.TabIndex = 70
        Label21.Text = "Employee ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(45, 150)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 25)
        Label1.TabIndex = 71
        Label1.Text = "Department ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(568, 109)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 25)
        Label5.TabIndex = 74
        Label5.Text = "Total Hours:"
        ' 
        ' Attendance_Tracker
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 1033)
        ControlBox = False
        Controls.Add(gbAttendanceDetails)
        Controls.Add(gbAttendanceList)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Attendance_Tracker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance_Tracker"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        gbAttendanceList.ResumeLayout(False)
        gbAttendanceList.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAttendanceList, ComponentModel.ISupportInitialize).EndInit()
        gbAttendanceDetails.ResumeLayout(False)
        gbAttendanceDetails.PerformLayout()
        gbDailyTimeRecord.ResumeLayout(False)
        gbDailyTimeRecord.PerformLayout()
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
    Friend WithEvents gbAttendanceList As GroupBox
    Friend WithEvents txtSearchAttendance As TextBox
    Friend WithEvents dgvAttendanceList As DataGridView
    Friend WithEvents gbAttendanceDetails As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbAttendanceStatus As ComboBox
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalHours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAbscences As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDaysAttended As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtExtendedHours As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gbDailyTimeRecord As GroupBox
    Friend WithEvents dtpCheckOutPM As DateTimePicker
    Friend WithEvents dtpCheckInPM As DateTimePicker
    Friend WithEvents dtpCheckOutAM As DateTimePicker
    Friend WithEvents dtpCheckInAM As DateTimePicker
    Friend WithEvents dtpDateAttendance As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEditAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
