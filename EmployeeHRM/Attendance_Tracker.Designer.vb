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
        gbAttendanceList = New GroupBox()
        txtSearchAttendance = New TextBox()
        PictureBox1 = New PictureBox()
        dgvAttendanceList = New DataGridView()
        gbAttendanceDetails = New GroupBox()
        cbEmployeeID = New ComboBox()
        gbDailyTimeRecord = New GroupBox()
        dtpTimeOutPM = New DateTimePicker()
        dtpTimeInPM = New DateTimePicker()
        dtpTimeOutAM = New DateTimePicker()
        dtpTimeInAM = New DateTimePicker()
        dtpDate = New DateTimePicker()
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
        txtAbsences = New TextBox()
        Label15 = New Label()
        txtDaysAttended = New TextBox()
        Label13 = New Label()
        txtExceededHours = New TextBox()
        Label12 = New Label()
        txtEmployeeName = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        cbAttendanceStatus = New ComboBox()
        txtTotalHours = New TextBox()
        txtDepartmentName = New TextBox()
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
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(326, 34)
        Label2.TabIndex = 0
        Label2.Text = "Attendance Tracker"
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
        ' gbAttendanceList
        ' 
        gbAttendanceList.Controls.Add(txtSearchAttendance)
        gbAttendanceList.Controls.Add(PictureBox1)
        gbAttendanceList.Controls.Add(dgvAttendanceList)
        gbAttendanceList.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbAttendanceList.Location = New Point(391, 519)
        gbAttendanceList.Margin = New Padding(4, 3, 4, 3)
        gbAttendanceList.Name = "gbAttendanceList"
        gbAttendanceList.Padding = New Padding(4, 3, 4, 3)
        gbAttendanceList.Size = New Size(1320, 600)
        gbAttendanceList.TabIndex = 68
        gbAttendanceList.TabStop = False
        gbAttendanceList.Text = "Attendance List"
        ' 
        ' txtSearchAttendance
        ' 
        txtSearchAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchAttendance.Location = New Point(84, 54)
        txtSearchAttendance.Margin = New Padding(4, 3, 4, 3)
        txtSearchAttendance.Name = "txtSearchAttendance"
        txtSearchAttendance.Size = New Size(256, 32)
        txtSearchAttendance.TabIndex = 90
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(19, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 104
        PictureBox1.TabStop = False
        ' 
        ' dgvAttendanceList
        ' 
        dgvAttendanceList.AllowUserToOrderColumns = True
        dgvAttendanceList.AllowUserToResizeColumns = False
        dgvAttendanceList.AllowUserToResizeRows = False
        dgvAttendanceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAttendanceList.ColumnHeadersHeight = 29
        dgvAttendanceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAttendanceList.Location = New Point(33, 101)
        dgvAttendanceList.Margin = New Padding(4, 3, 4, 3)
        dgvAttendanceList.Name = "dgvAttendanceList"
        dgvAttendanceList.RowHeadersWidth = 51
        dgvAttendanceList.Size = New Size(1259, 451)
        dgvAttendanceList.TabIndex = 0
        ' 
        ' gbAttendanceDetails
        ' 
        gbAttendanceDetails.Controls.Add(cbEmployeeID)
        gbAttendanceDetails.Controls.Add(gbDailyTimeRecord)
        gbAttendanceDetails.Controls.Add(txtJobTitle)
        gbAttendanceDetails.Controls.Add(btnEditAttendance)
        gbAttendanceDetails.Controls.Add(Label9)
        gbAttendanceDetails.Controls.Add(btnCancelAttendance)
        gbAttendanceDetails.Controls.Add(txtAttendanceID)
        gbAttendanceDetails.Controls.Add(Label6)
        gbAttendanceDetails.Controls.Add(btnSaveAttendance)
        gbAttendanceDetails.Controls.Add(txtAbsences)
        gbAttendanceDetails.Controls.Add(Label15)
        gbAttendanceDetails.Controls.Add(txtDaysAttended)
        gbAttendanceDetails.Controls.Add(Label13)
        gbAttendanceDetails.Controls.Add(txtExceededHours)
        gbAttendanceDetails.Controls.Add(Label12)
        gbAttendanceDetails.Controls.Add(txtEmployeeName)
        gbAttendanceDetails.Controls.Add(Label11)
        gbAttendanceDetails.Controls.Add(Label10)
        gbAttendanceDetails.Controls.Add(cbAttendanceStatus)
        gbAttendanceDetails.Controls.Add(txtTotalHours)
        gbAttendanceDetails.Controls.Add(txtDepartmentName)
        gbAttendanceDetails.Controls.Add(Label21)
        gbAttendanceDetails.Controls.Add(Label1)
        gbAttendanceDetails.Controls.Add(Label5)
        gbAttendanceDetails.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbAttendanceDetails.Location = New Point(391, 114)
        gbAttendanceDetails.Margin = New Padding(4, 3, 4, 3)
        gbAttendanceDetails.Name = "gbAttendanceDetails"
        gbAttendanceDetails.Padding = New Padding(4, 3, 4, 3)
        gbAttendanceDetails.Size = New Size(1320, 384)
        gbAttendanceDetails.TabIndex = 83
        gbAttendanceDetails.TabStop = False
        gbAttendanceDetails.Text = "Details"
        ' 
        ' cbEmployeeID
        ' 
        cbEmployeeID.FormattingEnabled = True
        cbEmployeeID.Location = New Point(249, 54)
        cbEmployeeID.Name = "cbEmployeeID"
        cbEmployeeID.Size = New Size(256, 35)
        cbEmployeeID.TabIndex = 126
        ' 
        ' gbDailyTimeRecord
        ' 
        gbDailyTimeRecord.Controls.Add(dtpTimeOutPM)
        gbDailyTimeRecord.Controls.Add(dtpTimeInPM)
        gbDailyTimeRecord.Controls.Add(dtpTimeOutAM)
        gbDailyTimeRecord.Controls.Add(dtpTimeInAM)
        gbDailyTimeRecord.Controls.Add(dtpDate)
        gbDailyTimeRecord.Controls.Add(Label19)
        gbDailyTimeRecord.Controls.Add(Label18)
        gbDailyTimeRecord.Controls.Add(Label17)
        gbDailyTimeRecord.Controls.Add(Label16)
        gbDailyTimeRecord.Controls.Add(Label14)
        gbDailyTimeRecord.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDailyTimeRecord.Location = New Point(928, 40)
        gbDailyTimeRecord.Margin = New Padding(4, 3, 4, 3)
        gbDailyTimeRecord.Name = "gbDailyTimeRecord"
        gbDailyTimeRecord.Padding = New Padding(4, 3, 4, 3)
        gbDailyTimeRecord.Size = New Size(367, 322)
        gbDailyTimeRecord.TabIndex = 120
        gbDailyTimeRecord.TabStop = False
        gbDailyTimeRecord.Text = "Daily Time Record"
        ' 
        ' dtpTimeOutPM
        ' 
        dtpTimeOutPM.CustomFormat = "hh:mm tt"
        dtpTimeOutPM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTimeOutPM.Format = DateTimePickerFormat.Custom
        dtpTimeOutPM.Location = New Point(188, 265)
        dtpTimeOutPM.Name = "dtpTimeOutPM"
        dtpTimeOutPM.Size = New Size(157, 32)
        dtpTimeOutPM.TabIndex = 126
        ' 
        ' dtpTimeInPM
        ' 
        dtpTimeInPM.CustomFormat = "hh:mm tt"
        dtpTimeInPM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTimeInPM.Format = DateTimePickerFormat.Custom
        dtpTimeInPM.Location = New Point(188, 215)
        dtpTimeInPM.Name = "dtpTimeInPM"
        dtpTimeInPM.Size = New Size(157, 32)
        dtpTimeInPM.TabIndex = 125
        ' 
        ' dtpTimeOutAM
        ' 
        dtpTimeOutAM.CustomFormat = "hh:mm tt"
        dtpTimeOutAM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTimeOutAM.Format = DateTimePickerFormat.Custom
        dtpTimeOutAM.Location = New Point(188, 165)
        dtpTimeOutAM.Name = "dtpTimeOutAM"
        dtpTimeOutAM.Size = New Size(157, 32)
        dtpTimeOutAM.TabIndex = 124
        ' 
        ' dtpTimeInAM
        ' 
        dtpTimeInAM.CustomFormat = "hh:mm tt"
        dtpTimeInAM.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTimeInAM.Format = DateTimePickerFormat.Custom
        dtpTimeInAM.Location = New Point(188, 115)
        dtpTimeInAM.Name = "dtpTimeInAM"
        dtpTimeInAM.Size = New Size(157, 32)
        dtpTimeInAM.TabIndex = 123
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        dtpDate.Location = New Point(18, 74)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(327, 30)
        dtpDate.TabIndex = 122
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 13F)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(24, 270)
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
        Label18.Location = New Point(20, 172)
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
        Label17.Location = New Point(45, 222)
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
        Label16.Location = New Point(41, 122)
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
        Label14.Location = New Point(18, 46)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(71, 25)
        Label14.TabIndex = 117
        Label14.Text = "Date:"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Location = New Point(249, 179)
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
        btnEditAttendance.Location = New Point(366, 290)
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
        Label9.Location = New Point(134, 192)
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
        btnCancelAttendance.Location = New Point(536, 290)
        btnCancelAttendance.Name = "btnCancelAttendance"
        btnCancelAttendance.Size = New Size(171, 68)
        btnCancelAttendance.TabIndex = 124
        btnCancelAttendance.Text = "Cancel"
        btnCancelAttendance.TextAlign = ContentAlignment.MiddleRight
        btnCancelAttendance.UseVisualStyleBackColor = False
        ' 
        ' txtAttendanceID
        ' 
        txtAttendanceID.Location = New Point(709, 56)
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
        Label6.Location = New Point(524, 66)
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
        btnSaveAttendance.Location = New Point(366, 291)
        btnSaveAttendance.Name = "btnSaveAttendance"
        btnSaveAttendance.Size = New Size(173, 67)
        btnSaveAttendance.TabIndex = 125
        btnSaveAttendance.Text = "Save "
        btnSaveAttendance.TextAlign = ContentAlignment.MiddleRight
        btnSaveAttendance.UseVisualStyleBackColor = False
        ' 
        ' txtAbsences
        ' 
        txtAbsences.Location = New Point(709, 181)
        txtAbsences.Margin = New Padding(4, 3, 4, 3)
        txtAbsences.Name = "txtAbsences"
        txtAbsences.Size = New Size(201, 36)
        txtAbsences.TabIndex = 95
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 13F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(564, 192)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(123, 25)
        Label15.TabIndex = 94
        Label15.Text = "Absences:"
        ' 
        ' txtDaysAttended
        ' 
        txtDaysAttended.Location = New Point(709, 223)
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
        Label13.Location = New Point(520, 234)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(181, 25)
        Label13.TabIndex = 90
        Label13.Text = "Days Attended:"
        ' 
        ' txtExceededHours
        ' 
        txtExceededHours.Location = New Point(709, 139)
        txtExceededHours.Margin = New Padding(4, 3, 4, 3)
        txtExceededHours.Name = "txtExceededHours"
        txtExceededHours.Size = New Size(201, 36)
        txtExceededHours.TabIndex = 89
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13F)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(517, 150)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(184, 25)
        Label12.TabIndex = 88
        Label12.Text = "Extended Hours:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(249, 95)
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
        Label11.Location = New Point(33, 104)
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
        Label10.Location = New Point(159, 231)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 25)
        Label10.TabIndex = 85
        Label10.Text = "Status:"
        ' 
        ' cbAttendanceStatus
        ' 
        cbAttendanceStatus.FormattingEnabled = True
        cbAttendanceStatus.Location = New Point(249, 221)
        cbAttendanceStatus.Name = "cbAttendanceStatus"
        cbAttendanceStatus.Size = New Size(256, 35)
        cbAttendanceStatus.TabIndex = 84
        ' 
        ' txtTotalHours
        ' 
        txtTotalHours.Location = New Point(709, 98)
        txtTotalHours.Margin = New Padding(4, 3, 4, 3)
        txtTotalHours.Name = "txtTotalHours"
        txtTotalHours.Size = New Size(201, 36)
        txtTotalHours.TabIndex = 82
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.Location = New Point(249, 137)
        txtDepartmentName.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.Size = New Size(256, 36)
        txtDepartmentName.TabIndex = 72
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(80, 62)
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
        Label1.Location = New Point(18, 148)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 25)
        Label1.TabIndex = 71
        Label1.Text = "Department Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(571, 109)
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
        ClientSize = New Size(1761, 1033)
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
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTotalHours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAbsences As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDaysAttended As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtExceededHours As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gbDailyTimeRecord As GroupBox
    Friend WithEvents dtpTimeOutPM As DateTimePicker
    Friend WithEvents dtpTimeInPM As DateTimePicker
    Friend WithEvents dtpTimeOutAM As DateTimePicker
    Friend WithEvents dtpTimeInAM As DateTimePicker
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEditAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveAttendance As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbEmployeeID As ComboBox
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
