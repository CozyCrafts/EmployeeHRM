<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Dashboard))
        GroupBox2 = New GroupBox()
        btnApplyForLeave = New Button()
        btnAttendance = New Button()
        btnViewSalary = New Button()
        GroupBox1 = New GroupBox()
        adminheader_pnl = New Panel()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        Panel2 = New Panel()
        lblTrainings = New Label()
        lblSalary = New Label()
        Label26 = New Label()
        Label27 = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        Label50 = New Label()
        lblEmpDashboard = New Label()
        Label51 = New Label()
        GroupBox7 = New GroupBox()
        Label3 = New Label()
        txtDepartment = New TextBox()
        btnEditProfile = New Button()
        txtPosition = New TextBox()
        txtJobTitle = New TextBox()
        txtName = New TextBox()
        txtEmployeeID = New TextBox()
        Label4 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        btmEmployeeHandbook = New Button()
        btnForms = New Button()
        btnPolicies = New Button()
        btnHolidayCalendar = New Button()
        btnTrainings = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox7.SuspendLayout()
        SuspendLayout()
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
        GroupBox2.Size = New Size(476, 316)
        GroupBox2.TabIndex = 78
        GroupBox2.TabStop = False
        GroupBox2.Text = "Shortcuts"
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
        GroupBox1.Location = New Point(380, 304)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(869, 122)
        GroupBox1.TabIndex = 73
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quick Access"
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 79
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(lblTrainings)
        Panel2.Controls.Add(lblSalary)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(lblMyProfile)
        Panel2.Controls.Add(lblAttendance)
        Panel2.Controls.Add(lblLeaveManagement)
        Panel2.Controls.Add(Label50)
        Panel2.Controls.Add(lblEmpDashboard)
        Panel2.Controls.Add(Label51)
        Panel2.Location = New Point(-6, -6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 80
        ' 
        ' lblTrainings
        ' 
        lblTrainings.AutoSize = True
        lblTrainings.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrainings.ForeColor = Color.White
        lblTrainings.Location = New Point(53, 430)
        lblTrainings.Name = "lblTrainings"
        lblTrainings.Size = New Size(110, 27)
        lblTrainings.TabIndex = 69
        lblTrainings.Text = "Trainings"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(53, 390)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(81, 27)
        lblSalary.TabIndex = 68
        lblSalary.Text = "Salary"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(85, 35)
        Label26.Name = "Label26"
        Label26.Size = New Size(197, 34)
        Label26.TabIndex = 12
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
        Label27.TabIndex = 11
        Label27.Text = "                                                  "
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
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label50.ForeColor = Color.White
        Label50.Location = New Point(30, 230)
        Label50.Name = "Label50"
        Label50.Size = New Size(98, 22)
        Label50.TabIndex = 3
        Label50.Text = "OVERVIEW"
        ' 
        ' lblEmpDashboard
        ' 
        lblEmpDashboard.AutoSize = True
        lblEmpDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpDashboard.ForeColor = Color.White
        lblEmpDashboard.Location = New Point(53, 160)
        lblEmpDashboard.Name = "lblEmpDashboard"
        lblEmpDashboard.Size = New Size(138, 27)
        lblEmpDashboard.TabIndex = 2
        lblEmpDashboard.Text = "Dashboard"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label51.ForeColor = Color.White
        Label51.Location = New Point(30, 120)
        Label51.Name = "Label51"
        Label51.Size = New Size(57, 22)
        Label51.TabIndex = 1
        Label51.Text = "MAIN"
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(Label3)
        GroupBox7.Controls.Add(txtDepartment)
        GroupBox7.Controls.Add(btnEditProfile)
        GroupBox7.Controls.Add(txtPosition)
        GroupBox7.Controls.Add(txtJobTitle)
        GroupBox7.Controls.Add(txtName)
        GroupBox7.Controls.Add(txtEmployeeID)
        GroupBox7.Controls.Add(Label4)
        GroupBox7.Controls.Add(Label7)
        GroupBox7.Controls.Add(Label8)
        GroupBox7.Controls.Add(Label10)
        GroupBox7.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox7.Location = New Point(380, 110)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(869, 183)
        GroupBox7.TabIndex = 81
        GroupBox7.TabStop = False
        GroupBox7.Text = "Profile"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F)
        Label3.Location = New Point(461, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 23)
        Label3.TabIndex = 41
        Label3.Text = "Department:"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F)
        Label4.Location = New Point(94, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 23)
        Label4.TabIndex = 3
        Label4.Text = "Job Title:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F)
        Label7.Location = New Point(112, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 23)
        Label7.TabIndex = 2
        Label7.Text = "Name:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F)
        Label8.Location = New Point(510, 50)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 23)
        Label8.TabIndex = 1
        Label8.Text = "Position:"
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
        ' btnHolidayCalendar
        ' 
        btnHolidayCalendar.BackColor = SystemColors.InactiveCaption
        btnHolidayCalendar.BackgroundImageLayout = ImageLayout.None
        btnHolidayCalendar.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnHolidayCalendar.ForeColor = Color.Black
        btnHolidayCalendar.Location = New Point(636, 53)
        btnHolidayCalendar.Name = "btnHolidayCalendar"
        btnHolidayCalendar.Size = New Size(196, 46)
        btnHolidayCalendar.TabIndex = 40
        btnHolidayCalendar.Text = "Holiday Calendar"
        btnHolidayCalendar.UseVisualStyleBackColor = False
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
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox7)
        Controls.Add(Panel2)
        Controls.Add(adminheader_pnl)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnApplyForLeave As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnViewSalary As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lblEmpDashboard As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnHolidayCalendar As Button
    Friend WithEvents btnPolicies As Button
    Friend WithEvents btnForms As Button
    Friend WithEvents btmEmployeeHandbook As Button
    Friend WithEvents btnTrainings As Button
End Class
