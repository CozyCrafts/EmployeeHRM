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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trainings))
        adminheader_pnl = New Panel()
        PictureBox1 = New PictureBox()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        dgvTrainingHistory = New DataGridView()
        Panel2 = New Panel()
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
        Label21 = New Label()
        txtTrainingID = New TextBox()
        Label1 = New Label()
        txtTrainingDescription = New TextBox()
        txtTrainingTitle = New TextBox()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        rbPostponed = New RadioButton()
        rbCompleted = New RadioButton()
        rbPlanned = New RadioButton()
        rbInProgress = New RadioButton()
        dtpStarted = New DateTimePicker()
        dtpCompleted = New DateTimePicker()
        GroupBox3 = New GroupBox()
        btnTrainingUpdate = New Button()
        btnTrainingSave = New Button()
        Label5 = New Label()
        Label4 = New Label()
        btnTrainingCancel = New Button()
        Label6 = New Label()
        txtTrainingType = New TextBox()
        GroupBox4 = New GroupBox()
        adminheader_pnl.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvTrainingHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(PictureBox1)
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Margin = New Padding(4, 3, 4, 3)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(2412, 123)
        adminheader_pnl.TabIndex = 23
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1352, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(55, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 81
        PictureBox1.TabStop = False
        ' 
        ' pcbTerminate
        ' 
        pcbTerminate.Image = CType(resources.GetObject("pcbTerminate.Image"), Image)
        pcbTerminate.Location = New Point(2028, 52)
        pcbTerminate.Margin = New Padding(4, 3, 4, 3)
        pcbTerminate.Name = "pcbTerminate"
        pcbTerminate.Size = New Size(82, 62)
        pcbTerminate.SizeMode = PictureBoxSizeMode.StretchImage
        pcbTerminate.TabIndex = 3
        pcbTerminate.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(80, 67)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 34)
        Label2.TabIndex = 0
        Label2.Text = "Trainings"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvTrainingHistory)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(418, 477)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(1330, 574)
        GroupBox1.TabIndex = 66
        GroupBox1.TabStop = False
        GroupBox1.Text = "Training History"
        ' 
        ' dgvTrainingHistory
        ' 
        dgvTrainingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrainingHistory.Location = New Point(25, 46)
        dgvTrainingHistory.Margin = New Padding(4, 3, 4, 3)
        dgvTrainingHistory.Name = "dgvTrainingHistory"
        dgvTrainingHistory.RowHeadersWidth = 51
        dgvTrainingHistory.Size = New Size(1291, 491)
        dgvTrainingHistory.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(lblAmenities)
        Panel2.Controls.Add(lblTrainings)
        Panel2.Controls.Add(lblLeaveApproval)
        Panel2.Controls.Add(lblEmployeeTrainings)
        Panel2.Controls.Add(lblPayrollSummary)
        Panel2.Controls.Add(lblDepartment)
        Panel2.Controls.Add(lblAttendanceTracker)
        Panel2.Controls.Add(lblTeamOverview)
        Panel2.Controls.Add(Label28)
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
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 26
        ' 
        ' lblAmenities
        ' 
        lblAmenities.AutoSize = True
        lblAmenities.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmenities.ForeColor = Color.White
        lblAmenities.Location = New Point(53, 780)
        lblAmenities.Margin = New Padding(4, 0, 4, 0)
        lblAmenities.Name = "lblAmenities"
        lblAmenities.Size = New Size(118, 27)
        lblAmenities.TabIndex = 101
        lblAmenities.Text = "Amenties"
        ' 
        ' lblTrainings
        ' 
        lblTrainings.AutoSize = True
        lblTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrainings.ForeColor = Color.White
        lblTrainings.Location = New Point(53, 430)
        lblTrainings.Margin = New Padding(4, 0, 4, 0)
        lblTrainings.Name = "lblTrainings"
        lblTrainings.Size = New Size(110, 27)
        lblTrainings.TabIndex = 100
        lblTrainings.Text = "Trainings"
        ' 
        ' lblLeaveApproval
        ' 
        lblLeaveApproval.AutoSize = True
        lblLeaveApproval.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveApproval.ForeColor = Color.White
        lblLeaveApproval.Location = New Point(53, 620)
        lblLeaveApproval.Margin = New Padding(4, 0, 4, 0)
        lblLeaveApproval.Name = "lblLeaveApproval"
        lblLeaveApproval.Size = New Size(198, 27)
        lblLeaveApproval.TabIndex = 99
        lblLeaveApproval.Text = "Leave Approval"
        ' 
        ' lblEmployeeTrainings
        ' 
        lblEmployeeTrainings.AutoSize = True
        lblEmployeeTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployeeTrainings.ForeColor = Color.White
        lblEmployeeTrainings.Location = New Point(53, 700)
        lblEmployeeTrainings.Margin = New Padding(4, 0, 4, 0)
        lblEmployeeTrainings.Name = "lblEmployeeTrainings"
        lblEmployeeTrainings.Size = New Size(230, 27)
        lblEmployeeTrainings.TabIndex = 98
        lblEmployeeTrainings.Text = "Employee Trainings"
        ' 
        ' lblPayrollSummary
        ' 
        lblPayrollSummary.AutoSize = True
        lblPayrollSummary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPayrollSummary.ForeColor = Color.White
        lblPayrollSummary.Location = New Point(53, 660)
        lblPayrollSummary.Margin = New Padding(4, 0, 4, 0)
        lblPayrollSummary.Name = "lblPayrollSummary"
        lblPayrollSummary.Size = New Size(200, 27)
        lblPayrollSummary.TabIndex = 97
        lblPayrollSummary.Text = "Payroll Summary"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDepartment.ForeColor = Color.White
        lblDepartment.Location = New Point(53, 740)
        lblDepartment.Margin = New Padding(4, 0, 4, 0)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(150, 27)
        lblDepartment.TabIndex = 96
        lblDepartment.Text = "Department"
        ' 
        ' lblAttendanceTracker
        ' 
        lblAttendanceTracker.AutoSize = True
        lblAttendanceTracker.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendanceTracker.ForeColor = Color.White
        lblAttendanceTracker.Location = New Point(53, 580)
        lblAttendanceTracker.Margin = New Padding(4, 0, 4, 0)
        lblAttendanceTracker.Name = "lblAttendanceTracker"
        lblAttendanceTracker.Size = New Size(239, 27)
        lblAttendanceTracker.TabIndex = 95
        lblAttendanceTracker.Text = "Attendance Tracker"
        ' 
        ' lblTeamOverview
        ' 
        lblTeamOverview.AutoSize = True
        lblTeamOverview.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTeamOverview.ForeColor = Color.White
        lblTeamOverview.Location = New Point(53, 540)
        lblTeamOverview.Margin = New Padding(4, 0, 4, 0)
        lblTeamOverview.Name = "lblTeamOverview"
        lblTeamOverview.Size = New Size(195, 27)
        lblTeamOverview.TabIndex = 94
        lblTeamOverview.Text = "Team Overview"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.White
        Label28.Location = New Point(30, 500)
        Label28.Margin = New Padding(4, 0, 4, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(135, 22)
        Label28.TabIndex = 93
        Label28.Text = "MANAGEMENT"
        ' 
        ' lblMyProfile
        ' 
        lblMyProfile.AutoSize = True
        lblMyProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMyProfile.ForeColor = Color.White
        lblMyProfile.Location = New Point(53, 270)
        lblMyProfile.Margin = New Padding(4, 0, 4, 0)
        lblMyProfile.Name = "lblMyProfile"
        lblMyProfile.Size = New Size(124, 27)
        lblMyProfile.TabIndex = 92
        lblMyProfile.Text = "My Profile"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.AutoSize = True
        lblAttendance.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttendance.ForeColor = Color.White
        lblAttendance.Location = New Point(53, 310)
        lblAttendance.Margin = New Padding(4, 0, 4, 0)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(150, 27)
        lblAttendance.TabIndex = 91
        lblAttendance.Text = "Attendance"
        ' 
        ' lblLeaveManagement
        ' 
        lblLeaveManagement.AutoSize = True
        lblLeaveManagement.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveManagement.ForeColor = Color.White
        lblLeaveManagement.Location = New Point(53, 350)
        lblLeaveManagement.Margin = New Padding(4, 0, 4, 0)
        lblLeaveManagement.Name = "lblLeaveManagement"
        lblLeaveManagement.Size = New Size(248, 27)
        lblLeaveManagement.TabIndex = 90
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(53, 390)
        lblSalary.Margin = New Padding(4, 0, 4, 0)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(81, 27)
        lblSalary.TabIndex = 89
        lblSalary.Text = "Salary"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label49.ForeColor = Color.White
        Label49.Location = New Point(30, 230)
        Label49.Margin = New Padding(4, 0, 4, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(98, 22)
        Label49.TabIndex = 88
        Label49.Text = "OVERVIEW"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(85, 35)
        Label26.Margin = New Padding(4, 0, 4, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(197, 34)
        Label26.TabIndex = 87
        Label26.Text = " HR System"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.White
        Label27.Location = New Point(30, 65)
        Label27.Margin = New Padding(4, 0, 4, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(312, 27)
        Label27.TabIndex = 86
        Label27.Text = "                                                  "
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(53, 160)
        lblDashboard.Margin = New Padding(4, 0, 4, 0)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(138, 27)
        lblDashboard.TabIndex = 81
        lblDashboard.Text = "Dashboard"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label51.ForeColor = Color.White
        Label51.Location = New Point(30, 120)
        Label51.Margin = New Padding(4, 0, 4, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(57, 22)
        Label51.TabIndex = 80
        Label51.Text = "MAIN"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(47, 57)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(136, 27)
        Label21.TabIndex = 70
        Label21.Text = "Training ID:"
        ' 
        ' txtTrainingID
        ' 
        txtTrainingID.Location = New Point(191, 48)
        txtTrainingID.Margin = New Padding(4, 3, 4, 3)
        txtTrainingID.Name = "txtTrainingID"
        txtTrainingID.Size = New Size(256, 36)
        txtTrainingID.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(47, 199)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 74
        Label1.Text = "Description:"
        ' 
        ' txtTrainingDescription
        ' 
        txtTrainingDescription.Location = New Point(191, 199)
        txtTrainingDescription.Margin = New Padding(4, 3, 4, 3)
        txtTrainingDescription.Multiline = True
        txtTrainingDescription.Name = "txtTrainingDescription"
        txtTrainingDescription.Size = New Size(475, 72)
        txtTrainingDescription.TabIndex = 73
        ' 
        ' txtTrainingTitle
        ' 
        txtTrainingTitle.Location = New Point(191, 100)
        txtTrainingTitle.Margin = New Padding(4, 3, 4, 3)
        txtTrainingTitle.Name = "txtTrainingTitle"
        txtTrainingTitle.Size = New Size(475, 36)
        txtTrainingTitle.TabIndex = 72
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(34, 107)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 71
        Label3.Text = "Training Title:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbPostponed)
        GroupBox2.Controls.Add(rbCompleted)
        GroupBox2.Controls.Add(rbPlanned)
        GroupBox2.Controls.Add(rbInProgress)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(24, 135)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(592, 95)
        GroupBox2.TabIndex = 75
        GroupBox2.TabStop = False
        GroupBox2.Text = "Status"
        ' 
        ' rbPostponed
        ' 
        rbPostponed.AutoSize = True
        rbPostponed.Font = New Font("Century Gothic", 12F)
        rbPostponed.Location = New Point(447, 45)
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
        rbCompleted.Location = New Point(294, 45)
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
        rbPlanned.Location = New Point(32, 45)
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
        rbInProgress.Location = New Point(153, 45)
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
        dtpStarted.Location = New Point(235, 35)
        dtpStarted.Margin = New Padding(4, 3, 4, 3)
        dtpStarted.Name = "dtpStarted"
        dtpStarted.Size = New Size(373, 32)
        dtpStarted.TabIndex = 76
        ' 
        ' dtpCompleted
        ' 
        dtpCompleted.CalendarFont = New Font("Century Gothic", 10.2F)
        dtpCompleted.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpCompleted.Location = New Point(235, 82)
        dtpCompleted.Margin = New Padding(4, 3, 4, 3)
        dtpCompleted.Name = "dtpCompleted"
        dtpCompleted.Size = New Size(373, 32)
        dtpCompleted.TabIndex = 77
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnTrainingUpdate)
        GroupBox3.Controls.Add(btnTrainingSave)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(dtpStarted)
        GroupBox3.Controls.Add(dtpCompleted)
        GroupBox3.Controls.Add(btnTrainingCancel)
        GroupBox3.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox3.Location = New Point(1118, 154)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(624, 317)
        GroupBox3.TabIndex = 78
        GroupBox3.TabStop = False
        GroupBox3.Text = " Duration"
        ' 
        ' btnTrainingUpdate
        ' 
        btnTrainingUpdate.BackColor = SystemColors.InactiveCaption
        btnTrainingUpdate.BackgroundImageLayout = ImageLayout.None
        btnTrainingUpdate.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnTrainingUpdate.ForeColor = Color.Black
        btnTrainingUpdate.Location = New Point(135, 245)
        btnTrainingUpdate.Name = "btnTrainingUpdate"
        btnTrainingUpdate.Size = New Size(353, 46)
        btnTrainingUpdate.TabIndex = 89
        btnTrainingUpdate.Text = "Update Status"
        btnTrainingUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnTrainingSave
        ' 
        btnTrainingSave.BackColor = SystemColors.InactiveCaption
        btnTrainingSave.BackgroundImageLayout = ImageLayout.None
        btnTrainingSave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnTrainingSave.ForeColor = Color.Black
        btnTrainingSave.Location = New Point(135, 245)
        btnTrainingSave.Name = "btnTrainingSave"
        btnTrainingSave.Size = New Size(175, 46)
        btnTrainingSave.TabIndex = 90
        btnTrainingSave.Text = "Save"
        btnTrainingSave.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(33, 91)
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
        Label4.Location = New Point(76, 44)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 23)
        Label4.TabIndex = 78
        Label4.Text = "Date Started:"
        ' 
        ' btnTrainingCancel
        ' 
        btnTrainingCancel.BackColor = SystemColors.InactiveCaption
        btnTrainingCancel.BackgroundImageLayout = ImageLayout.None
        btnTrainingCancel.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnTrainingCancel.ForeColor = Color.Black
        btnTrainingCancel.Location = New Point(316, 245)
        btnTrainingCancel.Name = "btnTrainingCancel"
        btnTrainingCancel.Size = New Size(172, 46)
        btnTrainingCancel.TabIndex = 90
        btnTrainingCancel.Text = "Cancel"
        btnTrainingCancel.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(24, 154)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 25)
        Label6.TabIndex = 79
        Label6.Text = "Training Type:"
        ' 
        ' txtTrainingType
        ' 
        txtTrainingType.Location = New Point(191, 147)
        txtTrainingType.Margin = New Padding(4, 3, 4, 3)
        txtTrainingType.Name = "txtTrainingType"
        txtTrainingType.Size = New Size(475, 36)
        txtTrainingType.TabIndex = 80
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
        GroupBox4.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox4.Location = New Point(418, 154)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(692, 317)
        GroupBox4.TabIndex = 81
        GroupBox4.TabStop = False
        GroupBox4.Text = "Details"
        ' 
        ' Trainings
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(Panel2)
        Controls.Add(GroupBox1)
        Controls.Add(adminheader_pnl)
        Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Trainings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Goals_and_Growth"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(dgvTrainingHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvTrainingHistory As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label51 As Label
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
    Friend WithEvents lblAmenities As Label
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTrainingID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrainingDescription As TextBox
    Friend WithEvents txtTrainingTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbCompleted As RadioButton
    Friend WithEvents rbPlanned As RadioButton
    Friend WithEvents rbInProgress As RadioButton
    Friend WithEvents dtpStarted As DateTimePicker
    Friend WithEvents dtpCompleted As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTrainingType As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rbPostponed As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnTrainingCancel As Button
    Friend WithEvents btnTrainingSave As Button
    Friend WithEvents btnTrainingUpdate As Button
End Class
