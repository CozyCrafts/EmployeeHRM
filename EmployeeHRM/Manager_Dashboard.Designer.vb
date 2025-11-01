<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager_Dashboard))
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
        lblManagerDashboard = New Label()
        lblMain = New Label()
        GroupBox6 = New GroupBox()
        DateTimePicker3 = New DateTimePicker()
        lblCurrentStatus = New Label()
        GroupBox5 = New GroupBox()
        dgUpEvents = New DataGridView()
        GroupBox4 = New GroupBox()
        dgAnnounce = New DataGridView()
        GroupBox3 = New GroupBox()
        Label1 = New Label()
        txtDepartment = New TextBox()
        btnEditProf = New Button()
        txtProfPic = New PictureBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox4 = New TextBox()
        Label13 = New Label()
        Label9 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        btnHoliday = New Button()
        btnForms = New Button()
        btnPolicies = New Button()
        btnHandbook = New Button()
        GroupBox2 = New GroupBox()
        btnPerfRev = New Button()
        btnCIO = New Button()
        btnViewPayslips = New Button()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        CType(dgUpEvents, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(dgAnnounce, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(txtProfPic, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
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
        adminheader_pnl.TabIndex = 0
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
        Label2.Size = New Size(186, 34)
        Label2.TabIndex = 0
        Label2.Text = "Dashboard"
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
        Panel1.Controls.Add(lblManagerDashboard)
        Panel1.Controls.Add(lblMain)
        Panel1.Location = New Point(-6, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 1357)
        Panel1.TabIndex = 1
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
        ' lblManagerDashboard
        ' 
        lblManagerDashboard.AutoSize = True
        lblManagerDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblManagerDashboard.ForeColor = Color.White
        lblManagerDashboard.Location = New Point(53, 160)
        lblManagerDashboard.Name = "lblManagerDashboard"
        lblManagerDashboard.Size = New Size(138, 27)
        lblManagerDashboard.TabIndex = 2
        lblManagerDashboard.Text = "Dashboard"
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
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(DateTimePicker3)
        GroupBox6.Controls.Add(lblCurrentStatus)
        GroupBox6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox6.Location = New Point(1031, 108)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(332, 285)
        GroupBox6.TabIndex = 71
        GroupBox6.TabStop = False
        GroupBox6.Text = "Current Status"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        DateTimePicker3.Location = New Point(26, 38)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(288, 26)
        DateTimePicker3.TabIndex = 38
        ' 
        ' lblCurrentStatus
        ' 
        lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle
        lblCurrentStatus.Location = New Point(26, 74)
        lblCurrentStatus.Name = "lblCurrentStatus"
        lblCurrentStatus.Size = New Size(288, 171)
        lblCurrentStatus.TabIndex = 37
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(dgUpEvents)
        GroupBox5.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox5.Location = New Point(1025, 567)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(744, 437)
        GroupBox5.TabIndex = 70
        GroupBox5.TabStop = False
        GroupBox5.Text = "Upcoming Events"
        ' 
        ' dgUpEvents
        ' 
        dgUpEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgUpEvents.Location = New Point(22, 46)
        dgUpEvents.Name = "dgUpEvents"
        dgUpEvents.RowHeadersWidth = 51
        dgUpEvents.Size = New Size(694, 369)
        dgUpEvents.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgAnnounce)
        GroupBox4.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox4.Location = New Point(381, 399)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(626, 605)
        GroupBox4.TabIndex = 69
        GroupBox4.TabStop = False
        GroupBox4.Text = "Announcements"
        ' 
        ' dgAnnounce
        ' 
        dgAnnounce.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgAnnounce.Location = New Point(29, 48)
        dgAnnounce.Name = "dgAnnounce"
        dgAnnounce.RowHeadersWidth = 51
        dgAnnounce.Size = New Size(572, 535)
        dgAnnounce.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(txtDepartment)
        GroupBox3.Controls.Add(btnEditProf)
        GroupBox3.Controls.Add(txtProfPic)
        GroupBox3.Controls.Add(TextBox9)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Controls.Add(TextBox7)
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox3.Location = New Point(381, 108)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(626, 285)
        GroupBox3.TabIndex = 68
        GroupBox3.TabStop = False
        GroupBox3.Text = "Profile"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(254, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 21)
        Label1.TabIndex = 41
        Label1.Text = "Department:"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDepartment.Location = New Point(383, 184)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(218, 30)
        txtDepartment.TabIndex = 40
        ' 
        ' btnEditProf
        ' 
        btnEditProf.BackColor = SystemColors.InactiveCaption
        btnEditProf.BackgroundImageLayout = ImageLayout.None
        btnEditProf.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditProf.ForeColor = Color.Black
        btnEditProf.Location = New Point(475, 231)
        btnEditProf.Name = "btnEditProf"
        btnEditProf.Size = New Size(126, 44)
        btnEditProf.TabIndex = 39
        btnEditProf.Text = "Edit Profile"
        btnEditProf.UseVisualStyleBackColor = False
        ' 
        ' txtProfPic
        ' 
        txtProfPic.BorderStyle = BorderStyle.Fixed3D
        txtProfPic.Location = New Point(29, 47)
        txtProfPic.Name = "txtProfPic"
        txtProfPic.Size = New Size(215, 190)
        txtProfPic.TabIndex = 38
        txtProfPic.TabStop = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(383, 148)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(218, 30)
        TextBox9.TabIndex = 13
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(383, 112)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(218, 30)
        TextBox8.TabIndex = 12
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(383, 76)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(218, 30)
        TextBox7.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(383, 40)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(218, 30)
        TextBox4.TabIndex = 10
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(291, 121)
        Label13.Name = "Label13"
        Label13.Size = New Size(86, 21)
        Label13.TabIndex = 3
        Label13.Text = "Job Title:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(308, 85)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 21)
        Label9.TabIndex = 2
        Label9.Text = "Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(296, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 21)
        Label5.TabIndex = 1
        Label5.Text = "Position:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(250, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 21)
        Label6.TabIndex = 0
        Label6.Text = "Employee ID:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnHoliday)
        GroupBox1.Controls.Add(btnForms)
        GroupBox1.Controls.Add(btnPolicies)
        GroupBox1.Controls.Add(btnHandbook)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(1025, 399)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(744, 144)
        GroupBox1.TabIndex = 67
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quick Access"
        ' 
        ' btnHoliday
        ' 
        btnHoliday.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnHoliday.Location = New Point(548, 52)
        btnHoliday.Name = "btnHoliday"
        btnHoliday.Size = New Size(168, 60)
        btnHoliday.TabIndex = 3
        btnHoliday.Text = "Holiday Calendar"
        btnHoliday.UseVisualStyleBackColor = True
        ' 
        ' btnForms
        ' 
        btnForms.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnForms.Location = New Point(196, 52)
        btnForms.Name = "btnForms"
        btnForms.Size = New Size(168, 60)
        btnForms.TabIndex = 2
        btnForms.Text = "Forms"
        btnForms.UseVisualStyleBackColor = True
        ' 
        ' btnPolicies
        ' 
        btnPolicies.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnPolicies.Location = New Point(374, 52)
        btnPolicies.Name = "btnPolicies"
        btnPolicies.Size = New Size(168, 60)
        btnPolicies.TabIndex = 1
        btnPolicies.Text = "Policies"
        btnPolicies.UseVisualStyleBackColor = True
        ' 
        ' btnHandbook
        ' 
        btnHandbook.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnHandbook.Location = New Point(22, 52)
        btnHandbook.Name = "btnHandbook"
        btnHandbook.Size = New Size(168, 60)
        btnHandbook.TabIndex = 0
        btnHandbook.Text = "Employee Handook"
        btnHandbook.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnPerfRev)
        GroupBox2.Controls.Add(btnCIO)
        GroupBox2.Controls.Add(btnViewPayslips)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(1379, 108)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(390, 285)
        GroupBox2.TabIndex = 72
        GroupBox2.TabStop = False
        GroupBox2.Text = "Shortcuts"
        ' 
        ' btnPerfRev
        ' 
        btnPerfRev.BackColor = SystemColors.InactiveCaption
        btnPerfRev.BackgroundImageLayout = ImageLayout.None
        btnPerfRev.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnPerfRev.ForeColor = Color.Black
        btnPerfRev.Location = New Point(35, 199)
        btnPerfRev.Name = "btnPerfRev"
        btnPerfRev.Size = New Size(320, 46)
        btnPerfRev.TabIndex = 37
        btnPerfRev.Text = "Performance Review"
        btnPerfRev.UseVisualStyleBackColor = False
        ' 
        ' btnCIO
        ' 
        btnCIO.BackColor = SystemColors.InactiveCaption
        btnCIO.BackgroundImageLayout = ImageLayout.None
        btnCIO.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCIO.ForeColor = Color.Black
        btnCIO.Location = New Point(35, 44)
        btnCIO.Name = "btnCIO"
        btnCIO.Size = New Size(320, 46)
        btnCIO.TabIndex = 36
        btnCIO.Text = "Check In / Out"
        btnCIO.UseVisualStyleBackColor = False
        ' 
        ' btnViewPayslips
        ' 
        btnViewPayslips.BackColor = SystemColors.InactiveCaption
        btnViewPayslips.BackgroundImageLayout = ImageLayout.None
        btnViewPayslips.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnViewPayslips.ForeColor = Color.Black
        btnViewPayslips.Location = New Point(35, 119)
        btnViewPayslips.Name = "btnViewPayslips"
        btnViewPayslips.Size = New Size(320, 46)
        btnViewPayslips.TabIndex = 35
        btnViewPayslips.Text = "View Payslips"
        btnViewPayslips.UseVisualStyleBackColor = False
        ' 
        ' Manager_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Manager_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        CType(dgUpEvents, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(dgAnnounce, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(txtProfPic, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblManagerDashboard As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblAmenities As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents lblCurrentStatus As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgUpEvents As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgAnnounce As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnEditProf As Button
    Friend WithEvents txtProfPic As PictureBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHoliday As Button
    Friend WithEvents btnForms As Button
    Friend WithEvents btnPolicies As Button
    Friend WithEvents btnHandbook As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPerfRev As Button
    Friend WithEvents btnCIO As Button
    Friend WithEvents btnViewPayslips As Button
End Class
