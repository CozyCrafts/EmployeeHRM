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
        GroupBox7 = New GroupBox()
        Label1 = New Label()
        txtDepartment = New TextBox()
        btnEditProfile = New Button()
        txtPosition = New TextBox()
        txtJobTitle = New TextBox()
        txtName = New TextBox()
        txtEmployeeID = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        GroupBox2 = New GroupBox()
        btnTrainings = New Button()
        btnApplyForLeave = New Button()
        btnAttendance = New Button()
        btnViewSalary = New Button()
        GroupBox1 = New GroupBox()
        btnHolidayCalendar = New Button()
        btnPolicies = New Button()
        btnForms = New Button()
        btmEmployeeHandbook = New Button()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(Label1)
        GroupBox7.Controls.Add(txtDepartment)
        GroupBox7.Controls.Add(btnEditProfile)
        GroupBox7.Controls.Add(txtPosition)
        GroupBox7.Controls.Add(txtJobTitle)
        GroupBox7.Controls.Add(txtName)
        GroupBox7.Controls.Add(txtEmployeeID)
        GroupBox7.Controls.Add(Label5)
        GroupBox7.Controls.Add(Label6)
        GroupBox7.Controls.Add(Label9)
        GroupBox7.Controls.Add(Label10)
        GroupBox7.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox7.Location = New Point(380, 110)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(869, 183)
        GroupBox7.TabIndex = 84
        GroupBox7.TabStop = False
        GroupBox7.Text = "Profile"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F)
        Label1.Location = New Point(461, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 23)
        Label1.TabIndex = 41
        Label1.Text = "Department:"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Century Gothic", 12F)
        txtDepartment.Location = New Point(602, 79)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(243, 32)
        txtDepartment.TabIndex = 40
        ' 
        ' btnEditProfile
        ' 
        btnEditProfile.BackColor = SystemColors.InactiveCaption
        btnEditProfile.BackgroundImageLayout = ImageLayout.None
        btnEditProfile.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditProfile.ForeColor = Color.Black
        btnEditProfile.Location = New Point(615, 116)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(218, 33)
        btnEditProfile.TabIndex = 39
        btnEditProfile.Text = "Edit Profile"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' txtPosition
        ' 
        txtPosition.Font = New Font("Century Gothic", 12F)
        txtPosition.Location = New Point(602, 41)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(243, 32)
        txtPosition.TabIndex = 13
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 12F)
        txtJobTitle.Location = New Point(194, 117)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(243, 32)
        txtJobTitle.TabIndex = 12
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Century Gothic", 12F)
        txtName.Location = New Point(194, 79)
        txtName.Name = "txtName"
        txtName.Size = New Size(243, 32)
        txtName.TabIndex = 11
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Font("Century Gothic", 12F)
        txtEmployeeID.Location = New Point(194, 41)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(243, 32)
        txtEmployeeID.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F)
        Label5.Location = New Point(94, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 23)
        Label5.TabIndex = 3
        Label5.Text = "Job Title:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F)
        Label6.Location = New Point(112, 90)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 23)
        Label6.TabIndex = 2
        Label6.Text = "Name:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F)
        Label9.Location = New Point(510, 50)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 23)
        Label9.TabIndex = 1
        Label9.Text = "Position:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F)
        Label10.Location = New Point(48, 50)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 23)
        Label10.TabIndex = 0
        Label10.Text = "Employee ID:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnTrainings)
        GroupBox2.Controls.Add(btnApplyForLeave)
        GroupBox2.Controls.Add(btnAttendance)
        GroupBox2.Controls.Add(btnViewSalary)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(1269, 110)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(476, 325)
        GroupBox2.TabIndex = 83
        GroupBox2.TabStop = False
        GroupBox2.Text = "Shortcuts"
        ' 
        ' btnTrainings
        ' 
        btnTrainings.BackColor = SystemColors.InactiveCaption
        btnTrainings.BackgroundImageLayout = ImageLayout.None
        btnTrainings.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnTrainings.ForeColor = Color.Black
        btnTrainings.Location = New Point(35, 243)
        btnTrainings.Name = "btnTrainings"
        btnTrainings.Size = New Size(420, 46)
        btnTrainings.TabIndex = 38
        btnTrainings.Text = "Trainings"
        btnTrainings.UseVisualStyleBackColor = False
        ' 
        ' btnApplyForLeave
        ' 
        btnApplyForLeave.BackColor = SystemColors.InactiveCaption
        btnApplyForLeave.BackgroundImageLayout = ImageLayout.None
        btnApplyForLeave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnApplyForLeave.ForeColor = Color.Black
        btnApplyForLeave.Location = New Point(35, 114)
        btnApplyForLeave.Name = "btnApplyForLeave"
        btnApplyForLeave.Size = New Size(420, 46)
        btnApplyForLeave.TabIndex = 37
        btnApplyForLeave.Text = "Apply for Leave"
        btnApplyForLeave.UseVisualStyleBackColor = False
        ' 
        ' btnAttendance
        ' 
        btnAttendance.BackColor = SystemColors.InactiveCaption
        btnAttendance.BackgroundImageLayout = ImageLayout.None
        btnAttendance.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnAttendance.ForeColor = Color.Black
        btnAttendance.Location = New Point(35, 44)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.Size = New Size(420, 46)
        btnAttendance.TabIndex = 36
        btnAttendance.Text = "Check In / Out"
        btnAttendance.UseVisualStyleBackColor = False
        ' 
        ' btnViewSalary
        ' 
        btnViewSalary.BackColor = SystemColors.InactiveCaption
        btnViewSalary.BackgroundImageLayout = ImageLayout.None
        btnViewSalary.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnViewSalary.ForeColor = Color.Black
        btnViewSalary.Location = New Point(35, 183)
        btnViewSalary.Name = "btnViewSalary"
        btnViewSalary.Size = New Size(420, 46)
        btnViewSalary.TabIndex = 35
        btnViewSalary.Text = "View Salary"
        btnViewSalary.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnHolidayCalendar)
        GroupBox1.Controls.Add(btnPolicies)
        GroupBox1.Controls.Add(btnForms)
        GroupBox1.Controls.Add(btmEmployeeHandbook)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(380, 313)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(869, 122)
        GroupBox1.TabIndex = 82
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quick Access"
        ' 
        ' btnHolidayCalendar
        ' 
        btnHolidayCalendar.BackColor = SystemColors.InactiveCaption
        btnHolidayCalendar.BackgroundImageLayout = ImageLayout.None
        btnHolidayCalendar.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnHolidayCalendar.ForeColor = Color.Black
        btnHolidayCalendar.Location = New Point(625, 53)
        btnHolidayCalendar.Name = "btnHolidayCalendar"
        btnHolidayCalendar.Size = New Size(196, 46)
        btnHolidayCalendar.TabIndex = 40
        btnHolidayCalendar.Text = "Holiday Calendar"
        btnHolidayCalendar.UseVisualStyleBackColor = False
        ' 
        ' btnPolicies
        ' 
        btnPolicies.BackColor = SystemColors.InactiveCaption
        btnPolicies.BackgroundImageLayout = ImageLayout.None
        btnPolicies.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnPolicies.ForeColor = Color.Black
        btnPolicies.Location = New Point(423, 53)
        btnPolicies.Name = "btnPolicies"
        btnPolicies.Size = New Size(196, 46)
        btnPolicies.TabIndex = 39
        btnPolicies.Text = "Policies"
        btnPolicies.UseVisualStyleBackColor = False
        ' 
        ' btnForms
        ' 
        btnForms.BackColor = SystemColors.InactiveCaption
        btnForms.BackgroundImageLayout = ImageLayout.None
        btnForms.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnForms.ForeColor = Color.Black
        btnForms.Location = New Point(221, 53)
        btnForms.Name = "btnForms"
        btnForms.Size = New Size(196, 46)
        btnForms.TabIndex = 38
        btnForms.Text = "Forms"
        btnForms.UseVisualStyleBackColor = False
        ' 
        ' btmEmployeeHandbook
        ' 
        btmEmployeeHandbook.BackColor = SystemColors.InactiveCaption
        btmEmployeeHandbook.BackgroundImageLayout = ImageLayout.None
        btmEmployeeHandbook.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btmEmployeeHandbook.ForeColor = Color.Black
        btmEmployeeHandbook.Location = New Point(19, 53)
        btmEmployeeHandbook.Name = "btmEmployeeHandbook"
        btmEmployeeHandbook.Size = New Size(196, 46)
        btmEmployeeHandbook.TabIndex = 37
        btmEmployeeHandbook.Text = "Employee Handbook"
        btmEmployeeHandbook.UseVisualStyleBackColor = False
        ' 
        ' Manager_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox7)
        Controls.Add(GroupBox2)
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
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
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
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTrainings As Button
    Friend WithEvents btnApplyForLeave As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnViewSalary As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHolidayCalendar As Button
    Friend WithEvents btnPolicies As Button
    Friend WithEvents btnForms As Button
    Friend WithEvents btmEmployeeHandbook As Button
End Class
