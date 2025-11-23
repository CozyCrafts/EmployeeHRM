<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trainings
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
        Label49 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        lblDashboard = New Label()
        Label51 = New Label()
        adminheader_pnl = New Panel()
        Label2 = New Label()
        GroupBox4 = New GroupBox()
        txtTrainingTitle = New TextBox()
        txtTrainingType = New TextBox()
        txtTrainingID = New TextBox()
        Label6 = New Label()
        Label21 = New Label()
        Label3 = New Label()
        txtTrainingDescription = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        dgvTrainingHistory = New DataGridView()
        GroupBox3 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        btnUpdateTraining = New FontAwesome.Sharp.IconButton()
        btnCancelTraining = New FontAwesome.Sharp.IconButton()
        btnSaveTraining = New FontAwesome.Sharp.IconButton()
        rbPostponed = New RadioButton()
        rbCompleted = New RadioButton()
        rbPlanned = New RadioButton()
        rbInProgress = New RadioButton()
        dtpStarted = New DateTimePicker()
        dtpCompleted = New DateTimePicker()
        Panel2.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvTrainingHistory, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
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
        Panel2.Controls.Add(Label49)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(Label51)
        Panel2.Location = New Point(-6, -6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 29
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
        btnSignOut.TabIndex = 92
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
        lblAmenities.TabIndex = 91
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
        lblTrainings.TabIndex = 90
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
        lblLeaveApproval.TabIndex = 89
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
        lblEmployeeTrainings.TabIndex = 88
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
        lblPayrollSummary.TabIndex = 87
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
        lblDepartment.TabIndex = 86
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
        lblAttendanceTracker.TabIndex = 85
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
        lblTeamOverview.TabIndex = 84
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
        lblManagement.TabIndex = 83
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
        lblMyProfile.TabIndex = 82
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
        lblAttendance.TabIndex = 81
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
        lblLeaveManagement.TabIndex = 80
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
        lblSalary.TabIndex = 79
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
        Label49.TabIndex = 78
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
        Label26.TabIndex = 77
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
        Label27.TabIndex = 76
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
        lblDashboard.TabIndex = 71
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
        Label51.TabIndex = 70
        Label51.Text = "MAIN"
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 30
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 34)
        Label2.TabIndex = 0
        Label2.Text = "Trainings"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txtTrainingTitle)
        GroupBox4.Controls.Add(txtTrainingType)
        GroupBox4.Controls.Add(txtTrainingID)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label21)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(txtTrainingDescription)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(391, 114)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(660, 487)
        GroupBox4.TabIndex = 82
        GroupBox4.TabStop = False
        GroupBox4.Text = "Details"
        ' 
        ' txtTrainingTitle
        ' 
        txtTrainingTitle.Location = New Point(196, 157)
        txtTrainingTitle.Margin = New Padding(4, 3, 4, 3)
        txtTrainingTitle.Name = "txtTrainingTitle"
        txtTrainingTitle.Size = New Size(438, 36)
        txtTrainingTitle.TabIndex = 72
        ' 
        ' txtTrainingType
        ' 
        txtTrainingType.Location = New Point(196, 214)
        txtTrainingType.Margin = New Padding(4, 3, 4, 3)
        txtTrainingType.Name = "txtTrainingType"
        txtTrainingType.Size = New Size(438, 36)
        txtTrainingType.TabIndex = 80
        ' 
        ' txtTrainingID
        ' 
        txtTrainingID.Location = New Point(196, 96)
        txtTrainingID.Margin = New Padding(4, 3, 4, 3)
        txtTrainingID.Name = "txtTrainingID"
        txtTrainingID.Size = New Size(438, 36)
        txtTrainingID.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(29, 225)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 25)
        Label6.TabIndex = 79
        Label6.Text = "Training Type:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(52, 105)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(136, 27)
        Label21.TabIndex = 70
        Label21.Text = "Training ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(39, 168)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 71
        Label3.Text = "Training Title:"
        ' 
        ' txtTrainingDescription
        ' 
        txtTrainingDescription.Location = New Point(196, 275)
        txtTrainingDescription.Margin = New Padding(4, 3, 4, 3)
        txtTrainingDescription.Multiline = True
        txtTrainingDescription.Name = "txtTrainingDescription"
        txtTrainingDescription.Size = New Size(438, 72)
        txtTrainingDescription.TabIndex = 73
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(52, 275)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 74
        Label1.Text = "Description:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvTrainingHistory)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(391, 612)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(1322, 468)
        GroupBox1.TabIndex = 83
        GroupBox1.TabStop = False
        GroupBox1.Text = "Training History"
        ' 
        ' dgvTrainingHistory
        ' 
        dgvTrainingHistory.AllowUserToResizeColumns = False
        dgvTrainingHistory.AllowUserToResizeRows = False
        dgvTrainingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTrainingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrainingHistory.Location = New Point(31, 53)
        dgvTrainingHistory.Margin = New Padding(4, 3, 4, 3)
        dgvTrainingHistory.Name = "dgvTrainingHistory"
        dgvTrainingHistory.RowHeadersWidth = 51
        dgvTrainingHistory.Size = New Size(1259, 377)
        dgvTrainingHistory.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(dtpStarted)
        GroupBox3.Controls.Add(dtpCompleted)
        GroupBox3.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox3.Location = New Point(1059, 114)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(654, 487)
        GroupBox3.TabIndex = 84
        GroupBox3.TabStop = False
        GroupBox3.Text = " Duration"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(48, 139)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 23)
        Label5.TabIndex = 79
        Label5.Text = "Date Completed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(91, 82)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 23)
        Label4.TabIndex = 78
        Label4.Text = "Date Started:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnUpdateTraining)
        GroupBox2.Controls.Add(btnCancelTraining)
        GroupBox2.Controls.Add(btnSaveTraining)
        GroupBox2.Controls.Add(rbPostponed)
        GroupBox2.Controls.Add(rbCompleted)
        GroupBox2.Controls.Add(rbPlanned)
        GroupBox2.Controls.Add(rbInProgress)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(25, 214)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(597, 233)
        GroupBox2.TabIndex = 75
        GroupBox2.TabStop = False
        GroupBox2.Text = "Status"
        ' 
        ' btnUpdateTraining
        ' 
        btnUpdateTraining.BackColor = SystemColors.InactiveCaption
        btnUpdateTraining.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnUpdateTraining.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnUpdateTraining.IconColor = Color.Black
        btnUpdateTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUpdateTraining.IconSize = 30
        btnUpdateTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdateTraining.Location = New Point(138, 139)
        btnUpdateTraining.Name = "btnUpdateTraining"
        btnUpdateTraining.Size = New Size(340, 49)
        btnUpdateTraining.TabIndex = 91
        btnUpdateTraining.Text = "Update Status"
        btnUpdateTraining.TextAlign = ContentAlignment.MiddleRight
        btnUpdateTraining.UseVisualStyleBackColor = False
        ' 
        ' btnCancelTraining
        ' 
        btnCancelTraining.BackColor = SystemColors.InactiveCaption
        btnCancelTraining.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancelTraining.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelTraining.IconColor = Color.Black
        btnCancelTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelTraining.IconSize = 30
        btnCancelTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelTraining.Location = New Point(311, 139)
        btnCancelTraining.Name = "btnCancelTraining"
        btnCancelTraining.Size = New Size(167, 49)
        btnCancelTraining.TabIndex = 93
        btnCancelTraining.Text = "Cancel"
        btnCancelTraining.TextAlign = ContentAlignment.MiddleRight
        btnCancelTraining.UseVisualStyleBackColor = False
        ' 
        ' btnSaveTraining
        ' 
        btnSaveTraining.BackColor = SystemColors.InactiveCaption
        btnSaveTraining.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSaveTraining.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveTraining.IconColor = Color.Black
        btnSaveTraining.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveTraining.IconSize = 30
        btnSaveTraining.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveTraining.Location = New Point(138, 139)
        btnSaveTraining.Name = "btnSaveTraining"
        btnSaveTraining.Size = New Size(167, 49)
        btnSaveTraining.TabIndex = 92
        btnSaveTraining.Text = "Save"
        btnSaveTraining.TextAlign = ContentAlignment.MiddleRight
        btnSaveTraining.UseVisualStyleBackColor = False
        ' 
        ' rbPostponed
        ' 
        rbPostponed.AutoSize = True
        rbPostponed.Font = New Font("Century Gothic", 12F)
        rbPostponed.Location = New Point(453, 65)
        rbPostponed.Margin = New Padding(4, 3, 4, 3)
        rbPostponed.Name = "rbPostponed"
        rbPostponed.Size = New Size(137, 27)
        rbPostponed.TabIndex = 3
        rbPostponed.TabStop = True
        rbPostponed.Text = "Postponed"
        rbPostponed.UseVisualStyleBackColor = True
        ' 
        ' rbCompleted
        ' 
        rbCompleted.AutoSize = True
        rbCompleted.Font = New Font("Century Gothic", 12F)
        rbCompleted.Location = New Point(297, 65)
        rbCompleted.Margin = New Padding(4, 3, 4, 3)
        rbCompleted.Name = "rbCompleted"
        rbCompleted.Size = New Size(145, 27)
        rbCompleted.TabIndex = 2
        rbCompleted.TabStop = True
        rbCompleted.Text = "Completed"
        rbCompleted.UseVisualStyleBackColor = True
        ' 
        ' rbPlanned
        ' 
        rbPlanned.AutoSize = True
        rbPlanned.Font = New Font("Century Gothic", 12F)
        rbPlanned.Location = New Point(29, 65)
        rbPlanned.Margin = New Padding(4, 3, 4, 3)
        rbPlanned.Name = "rbPlanned"
        rbPlanned.Size = New Size(113, 27)
        rbPlanned.TabIndex = 1
        rbPlanned.TabStop = True
        rbPlanned.Text = "Planned"
        rbPlanned.UseVisualStyleBackColor = True
        ' 
        ' rbInProgress
        ' 
        rbInProgress.AutoSize = True
        rbInProgress.Font = New Font("Century Gothic", 12F)
        rbInProgress.Location = New Point(153, 65)
        rbInProgress.Margin = New Padding(4, 3, 4, 3)
        rbInProgress.Name = "rbInProgress"
        rbInProgress.Size = New Size(133, 27)
        rbInProgress.TabIndex = 0
        rbInProgress.TabStop = True
        rbInProgress.Text = "In Progress"
        rbInProgress.UseVisualStyleBackColor = True
        ' 
        ' dtpStarted
        ' 
        dtpStarted.CalendarFont = New Font("Century Gothic", 10.2F)
        dtpStarted.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpStarted.Location = New Point(249, 73)
        dtpStarted.Margin = New Padding(4, 3, 4, 3)
        dtpStarted.Name = "dtpStarted"
        dtpStarted.Size = New Size(373, 32)
        dtpStarted.TabIndex = 76
        ' 
        ' dtpCompleted
        ' 
        dtpCompleted.CalendarFont = New Font("Century Gothic", 10.2F)
        dtpCompleted.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCompleted.Location = New Point(249, 130)
        dtpCompleted.Margin = New Padding(4, 3, 4, 3)
        dtpCompleted.Name = "dtpCompleted"
        dtpCompleted.Size = New Size(373, 32)
        dtpCompleted.TabIndex = 77
        ' 
        ' Trainings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Controls.Add(Panel2)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Trainings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Trainings"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgvTrainingHistory, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Label49 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTrainingTitle As TextBox
    Friend WithEvents txtTrainingType As TextBox
    Friend WithEvents txtTrainingID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTrainingDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvTrainingHistory As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUpdateTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveTraining As FontAwesome.Sharp.IconButton
    Friend WithEvents rbPostponed As RadioButton
    Friend WithEvents rbCompleted As RadioButton
    Friend WithEvents rbPlanned As RadioButton
    Friend WithEvents rbInProgress As RadioButton
    Friend WithEvents dtpStarted As DateTimePicker
    Friend WithEvents dtpCompleted As DateTimePicker
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
