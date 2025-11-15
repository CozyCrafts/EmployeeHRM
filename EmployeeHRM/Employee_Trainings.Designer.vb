<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Trainings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Trainings))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        adminheader_pnl = New Panel()
        btnSignOut = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        gbEmployeeTrainingHistory = New GroupBox()
        txtSearchTrainings = New TextBox()
        PictureBox1 = New PictureBox()
        dgvEmployeeTrainingHistory = New DataGridView()
        gbSchedule = New GroupBox()
        Label9 = New Label()
        Label10 = New Label()
        dtpTrainingStarted = New DateTimePicker()
        dtpTrainingCompleted = New DateTimePicker()
        gbStatus = New GroupBox()
        rbPostponed = New RadioButton()
        rbCompleted = New RadioButton()
        rbPlanned = New RadioButton()
        rbInProgress = New RadioButton()
        Label5 = New Label()
        txtTrainingDescription = New TextBox()
        Label1 = New Label()
        Label21 = New Label()
        Label6 = New Label()
        txtTrainingID = New TextBox()
        txtTrainingType = New TextBox()
        txtTrainingTitle = New TextBox()
        Label11 = New Label()
        gbEmplyeeTrainingsDetails = New GroupBox()
        cbEmployeeID = New ComboBox()
        btnDeleteTraining = New FontAwesome.Sharp.IconButton()
        btnAddTraining = New FontAwesome.Sharp.IconButton()
        btnEditTraining = New FontAwesome.Sharp.IconButton()
        btnCancelTraining = New FontAwesome.Sharp.IconButton()
        btnSaveTraining = New FontAwesome.Sharp.IconButton()
        Label12 = New Label()
        txtEmployeeName = New TextBox()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        gbEmployeeTrainingHistory.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmployeeTrainingHistory, ComponentModel.ISupportInitialize).BeginInit()
        gbSchedule.SuspendLayout()
        gbStatus.SuspendLayout()
        gbEmplyeeTrainingsDetails.SuspendLayout()
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
        btnSignOut.TabIndex = 38
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
        Label2.Size = New Size(328, 34)
        Label2.TabIndex = 0
        Label2.Text = "Employee Trainings"
        ' 
        ' gbEmployeeTrainingHistory
        ' 
        gbEmployeeTrainingHistory.Controls.Add(txtSearchTrainings)
        gbEmployeeTrainingHistory.Controls.Add(PictureBox1)
        gbEmployeeTrainingHistory.Controls.Add(dgvEmployeeTrainingHistory)
        gbEmployeeTrainingHistory.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbEmployeeTrainingHistory.Location = New Point(386, 614)
        gbEmployeeTrainingHistory.Margin = New Padding(4, 3, 4, 3)
        gbEmployeeTrainingHistory.Name = "gbEmployeeTrainingHistory"
        gbEmployeeTrainingHistory.Padding = New Padding(4, 3, 4, 3)
        gbEmployeeTrainingHistory.Size = New Size(1362, 516)
        gbEmployeeTrainingHistory.TabIndex = 67
        gbEmployeeTrainingHistory.TabStop = False
        gbEmployeeTrainingHistory.Text = "Employee Training History"
        ' 
        ' txtSearchTrainings
        ' 
        txtSearchTrainings.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchTrainings.Location = New Point(75, 54)
        txtSearchTrainings.Margin = New Padding(4, 3, 4, 3)
        txtSearchTrainings.Name = "txtSearchTrainings"
        txtSearchTrainings.Size = New Size(256, 32)
        txtSearchTrainings.TabIndex = 93
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(10, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 103
        PictureBox1.TabStop = False
        ' 
        ' dgvEmployeeTrainingHistory
        ' 
        dgvEmployeeTrainingHistory.AllowUserToResizeColumns = False
        dgvEmployeeTrainingHistory.AllowUserToResizeRows = False
        dgvEmployeeTrainingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEmployeeTrainingHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEmployeeTrainingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeTrainingHistory.Location = New Point(27, 92)
        dgvEmployeeTrainingHistory.Margin = New Padding(4, 3, 4, 3)
        dgvEmployeeTrainingHistory.Name = "dgvEmployeeTrainingHistory"
        dgvEmployeeTrainingHistory.RowHeadersWidth = 51
        dgvEmployeeTrainingHistory.Size = New Size(1277, 392)
        dgvEmployeeTrainingHistory.TabIndex = 0
        ' 
        ' gbSchedule
        ' 
        gbSchedule.Controls.Add(Label9)
        gbSchedule.Controls.Add(Label10)
        gbSchedule.Controls.Add(dtpTrainingStarted)
        gbSchedule.Controls.Add(dtpTrainingCompleted)
        gbSchedule.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbSchedule.Location = New Point(383, 474)
        gbSchedule.Margin = New Padding(4, 3, 4, 3)
        gbSchedule.Name = "gbSchedule"
        gbSchedule.Padding = New Padding(4, 3, 4, 3)
        gbSchedule.Size = New Size(655, 127)
        gbSchedule.TabIndex = 83
        gbSchedule.TabStop = False
        gbSchedule.Text = "Schedule "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(34, 86)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(184, 23)
        Label9.TabIndex = 79
        Label9.Text = "Date Completed:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(77, 43)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(141, 23)
        Label10.TabIndex = 78
        Label10.Text = "Date Started:"
        ' 
        ' dtpTrainingStarted
        ' 
        dtpTrainingStarted.CalendarFont = New Font("Century Gothic", 10.2F)
        dtpTrainingStarted.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTrainingStarted.Location = New Point(235, 34)
        dtpTrainingStarted.Margin = New Padding(4, 3, 4, 3)
        dtpTrainingStarted.Name = "dtpTrainingStarted"
        dtpTrainingStarted.Size = New Size(396, 32)
        dtpTrainingStarted.TabIndex = 76
        ' 
        ' dtpTrainingCompleted
        ' 
        dtpTrainingCompleted.CalendarFont = New Font("Century Gothic", 10.2F)
        dtpTrainingCompleted.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTrainingCompleted.Location = New Point(235, 77)
        dtpTrainingCompleted.Margin = New Padding(4, 3, 4, 3)
        dtpTrainingCompleted.Name = "dtpTrainingCompleted"
        dtpTrainingCompleted.Size = New Size(396, 32)
        dtpTrainingCompleted.TabIndex = 77
        ' 
        ' gbStatus
        ' 
        gbStatus.Controls.Add(rbPostponed)
        gbStatus.Controls.Add(rbCompleted)
        gbStatus.Controls.Add(rbPlanned)
        gbStatus.Controls.Add(rbInProgress)
        gbStatus.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbStatus.Location = New Point(1058, 483)
        gbStatus.Margin = New Padding(4, 3, 4, 3)
        gbStatus.Name = "gbStatus"
        gbStatus.Padding = New Padding(4, 3, 4, 3)
        gbStatus.Size = New Size(687, 118)
        gbStatus.TabIndex = 82
        gbStatus.TabStop = False
        gbStatus.Text = "Status"
        ' 
        ' rbPostponed
        ' 
        rbPostponed.AutoSize = True
        rbPostponed.Font = New Font("Century Gothic", 13F)
        rbPostponed.Location = New Point(512, 55)
        rbPostponed.Margin = New Padding(4, 3, 4, 3)
        rbPostponed.Name = "rbPostponed"
        rbPostponed.Size = New Size(148, 29)
        rbPostponed.TabIndex = 3
        rbPostponed.TabStop = True
        rbPostponed.Text = "Postponed"
        rbPostponed.UseVisualStyleBackColor = True
        ' 
        ' rbCompleted
        ' 
        rbCompleted.AutoSize = True
        rbCompleted.Font = New Font("Century Gothic", 13F)
        rbCompleted.Location = New Point(329, 55)
        rbCompleted.Margin = New Padding(4, 3, 4, 3)
        rbCompleted.Name = "rbCompleted"
        rbCompleted.Size = New Size(159, 29)
        rbCompleted.TabIndex = 2
        rbCompleted.TabStop = True
        rbCompleted.Text = "Completed"
        rbCompleted.UseVisualStyleBackColor = True
        ' 
        ' rbPlanned
        ' 
        rbPlanned.AutoSize = True
        rbPlanned.Font = New Font("Century Gothic", 13F)
        rbPlanned.Location = New Point(34, 55)
        rbPlanned.Margin = New Padding(4, 3, 4, 3)
        rbPlanned.Name = "rbPlanned"
        rbPlanned.Size = New Size(122, 29)
        rbPlanned.TabIndex = 1
        rbPlanned.TabStop = True
        rbPlanned.Text = "Planned"
        rbPlanned.UseVisualStyleBackColor = True
        ' 
        ' rbInProgress
        ' 
        rbInProgress.AutoSize = True
        rbInProgress.Font = New Font("Century Gothic", 13F)
        rbInProgress.Location = New Point(164, 55)
        rbInProgress.Margin = New Padding(4, 3, 4, 3)
        rbInProgress.Name = "rbInProgress"
        rbInProgress.Size = New Size(146, 29)
        rbInProgress.TabIndex = 0
        rbInProgress.TabStop = True
        rbInProgress.Text = "In Progress"
        rbInProgress.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(120, 220)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 27)
        Label5.TabIndex = 74
        Label5.Text = "Description:"
        ' 
        ' txtTrainingDescription
        ' 
        txtTrainingDescription.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        txtTrainingDescription.Location = New Point(274, 218)
        txtTrainingDescription.Margin = New Padding(4, 3, 4, 3)
        txtTrainingDescription.Multiline = True
        txtTrainingDescription.Name = "txtTrainingDescription"
        txtTrainingDescription.Size = New Size(697, 58)
        txtTrainingDescription.TabIndex = 73
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(475, 132)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 27)
        Label1.TabIndex = 71
        Label1.Text = "Training Title:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.8F)
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(132, 132)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(136, 27)
        Label21.TabIndex = 70
        Label21.Text = "Training ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(100, 180)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(168, 27)
        Label6.TabIndex = 79
        Label6.Text = "Training Type:"
        ' 
        ' txtTrainingID
        ' 
        txtTrainingID.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        txtTrainingID.Location = New Point(276, 123)
        txtTrainingID.Margin = New Padding(4, 3, 4, 3)
        txtTrainingID.Name = "txtTrainingID"
        txtTrainingID.Size = New Size(144, 36)
        txtTrainingID.TabIndex = 23
        ' 
        ' txtTrainingType
        ' 
        txtTrainingType.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        txtTrainingType.Location = New Point(276, 171)
        txtTrainingType.Margin = New Padding(4, 3, 4, 3)
        txtTrainingType.Name = "txtTrainingType"
        txtTrainingType.Size = New Size(695, 36)
        txtTrainingType.TabIndex = 80
        ' 
        ' txtTrainingTitle
        ' 
        txtTrainingTitle.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        txtTrainingTitle.Location = New Point(642, 123)
        txtTrainingTitle.Margin = New Padding(4, 3, 4, 3)
        txtTrainingTitle.Name = "txtTrainingTitle"
        txtTrainingTitle.Size = New Size(329, 36)
        txtTrainingTitle.TabIndex = 72
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.8F)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(108, 84)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 27)
        Label11.TabIndex = 86
        Label11.Text = "Employee ID:"
        ' 
        ' gbEmplyeeTrainingsDetails
        ' 
        gbEmplyeeTrainingsDetails.Controls.Add(cbEmployeeID)
        gbEmplyeeTrainingsDetails.Controls.Add(btnDeleteTraining)
        gbEmplyeeTrainingsDetails.Controls.Add(btnAddTraining)
        gbEmplyeeTrainingsDetails.Controls.Add(btnEditTraining)
        gbEmplyeeTrainingsDetails.Controls.Add(btnCancelTraining)
        gbEmplyeeTrainingsDetails.Controls.Add(btnSaveTraining)
        gbEmplyeeTrainingsDetails.Controls.Add(Label12)
        gbEmplyeeTrainingsDetails.Controls.Add(txtEmployeeName)
        gbEmplyeeTrainingsDetails.Controls.Add(Label11)
        gbEmplyeeTrainingsDetails.Controls.Add(txtTrainingTitle)
        gbEmplyeeTrainingsDetails.Controls.Add(txtTrainingType)
        gbEmplyeeTrainingsDetails.Controls.Add(txtTrainingID)
        gbEmplyeeTrainingsDetails.Controls.Add(Label6)
        gbEmplyeeTrainingsDetails.Controls.Add(Label21)
        gbEmplyeeTrainingsDetails.Controls.Add(Label1)
        gbEmplyeeTrainingsDetails.Controls.Add(txtTrainingDescription)
        gbEmplyeeTrainingsDetails.Controls.Add(Label5)
        gbEmplyeeTrainingsDetails.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbEmplyeeTrainingsDetails.Location = New Point(380, 110)
        gbEmplyeeTrainingsDetails.Margin = New Padding(4, 3, 4, 3)
        gbEmplyeeTrainingsDetails.Name = "gbEmplyeeTrainingsDetails"
        gbEmplyeeTrainingsDetails.Padding = New Padding(4, 3, 4, 3)
        gbEmplyeeTrainingsDetails.Size = New Size(1365, 358)
        gbEmplyeeTrainingsDetails.TabIndex = 84
        gbEmplyeeTrainingsDetails.TabStop = False
        gbEmplyeeTrainingsDetails.Text = "Details"
        ' 
        ' cbEmployeeID
        ' 
        cbEmployeeID.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        cbEmployeeID.FormattingEnabled = True
        cbEmployeeID.Location = New Point(276, 76)
        cbEmployeeID.Name = "cbEmployeeID"
        cbEmployeeID.Size = New Size(144, 35)
        cbEmployeeID.TabIndex = 117
        ' 
        ' btnDeleteTraining
        ' 
        btnDeleteTraining.BackColor = SystemColors.InactiveCaption
        btnDeleteTraining.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnDeleteTraining.IconChar = FontAwesome.Sharp.IconChar.Trash
        btnDeleteTraining.IconColor = Color.Black
        btnDeleteTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDeleteTraining.IconSize = 35
        btnDeleteTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnDeleteTraining.Location = New Point(1021, 215)
        btnDeleteTraining.Name = "btnDeleteTraining"
        btnDeleteTraining.Size = New Size(250, 57)
        btnDeleteTraining.TabIndex = 116
        btnDeleteTraining.Text = "Delete Training"
        btnDeleteTraining.TextAlign = ContentAlignment.MiddleRight
        btnDeleteTraining.UseVisualStyleBackColor = False
        ' 
        ' btnAddTraining
        ' 
        btnAddTraining.BackColor = SystemColors.InactiveCaption
        btnAddTraining.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnAddTraining.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        btnAddTraining.IconColor = Color.Black
        btnAddTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddTraining.IconSize = 35
        btnAddTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnAddTraining.Location = New Point(1021, 63)
        btnAddTraining.Name = "btnAddTraining"
        btnAddTraining.Size = New Size(250, 58)
        btnAddTraining.TabIndex = 112
        btnAddTraining.Text = "Add Training"
        btnAddTraining.TextAlign = ContentAlignment.MiddleRight
        btnAddTraining.UseVisualStyleBackColor = False
        ' 
        ' btnEditTraining
        ' 
        btnEditTraining.BackColor = SystemColors.InactiveCaption
        btnEditTraining.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnEditTraining.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditTraining.IconColor = Color.Black
        btnEditTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditTraining.IconSize = 35
        btnEditTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnEditTraining.Location = New Point(1021, 138)
        btnEditTraining.Name = "btnEditTraining"
        btnEditTraining.Size = New Size(250, 57)
        btnEditTraining.TabIndex = 113
        btnEditTraining.Text = "Edit Training"
        btnEditTraining.TextAlign = ContentAlignment.MiddleRight
        btnEditTraining.UseVisualStyleBackColor = False
        ' 
        ' btnCancelTraining
        ' 
        btnCancelTraining.BackColor = SystemColors.InactiveCaption
        btnCancelTraining.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        btnCancelTraining.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelTraining.IconColor = Color.Black
        btnCancelTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelTraining.IconSize = 35
        btnCancelTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelTraining.Location = New Point(1021, 180)
        btnCancelTraining.Name = "btnCancelTraining"
        btnCancelTraining.Size = New Size(250, 57)
        btnCancelTraining.TabIndex = 115
        btnCancelTraining.Text = "Cancel"
        btnCancelTraining.TextAlign = ContentAlignment.MiddleRight
        btnCancelTraining.UseVisualStyleBackColor = False
        ' 
        ' btnSaveTraining
        ' 
        btnSaveTraining.BackColor = SystemColors.InactiveCaption
        btnSaveTraining.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        btnSaveTraining.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveTraining.IconColor = Color.Black
        btnSaveTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveTraining.IconSize = 35
        btnSaveTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveTraining.Location = New Point(1021, 100)
        btnSaveTraining.Name = "btnSaveTraining"
        btnSaveTraining.Size = New Size(250, 57)
        btnSaveTraining.TabIndex = 114
        btnSaveTraining.Text = "Save"
        btnSaveTraining.TextAlign = ContentAlignment.MiddleRight
        btnSaveTraining.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13.8F)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(426, 84)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(208, 27)
        Label12.TabIndex = 90
        Label12.Text = "Employee Name:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        txtEmployeeName.Location = New Point(642, 75)
        txtEmployeeName.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(329, 36)
        txtEmployeeName.TabIndex = 89
        ' 
        ' Employee_Trainings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(gbEmplyeeTrainingsDetails)
        Controls.Add(gbSchedule)
        Controls.Add(gbStatus)
        Controls.Add(gbEmployeeTrainingHistory)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee_Trainings"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        gbEmployeeTrainingHistory.ResumeLayout(False)
        gbEmployeeTrainingHistory.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmployeeTrainingHistory, ComponentModel.ISupportInitialize).EndInit()
        gbSchedule.ResumeLayout(False)
        gbSchedule.PerformLayout()
        gbStatus.ResumeLayout(False)
        gbStatus.PerformLayout()
        gbEmplyeeTrainingsDetails.ResumeLayout(False)
        gbEmplyeeTrainingsDetails.PerformLayout()
        ResumeLayout(False)
    End Sub

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
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents gbEmployeeTrainingHistory As GroupBox
    Friend WithEvents dgvEmployeeTrainingHistory As DataGridView
    Friend WithEvents gbSchedule As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpTrainingStarted As DateTimePicker
    Friend WithEvents dtpTrainingCompleted As DateTimePicker
    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents rbPostponed As RadioButton
    Friend WithEvents rbCompleted As RadioButton
    Friend WithEvents rbPlanned As RadioButton
    Friend WithEvents rbInProgress As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTrainingDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTrainingID As TextBox
    Friend WithEvents txtTrainingType As TextBox
    Friend WithEvents txtTrainingTitle As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents gbEmplyeeTrainingsDetails As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtSearchTrainings As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents cbEmployeeID As ComboBox
End Class
