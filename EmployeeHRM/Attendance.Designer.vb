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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance))
        adminheader_pnl = New Panel()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        TextBox8 = New TextBox()
        Label13 = New Label()
        Label9 = New Label()
        Label3 = New Label()
        btnSave = New Button()
        GroupBox4 = New GroupBox()
        DateTimePicker3 = New DateTimePicker()
        Label4 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        DataGridView2 = New DataGridView()
        GroupBox1 = New GroupBox()
        Panel2 = New Panel()
        lblAmenities = New Label()
        lblGoalsAndGrowth = New Label()
        lblLeaveApproval = New Label()
        lblPerformanceReview = New Label()
        lblPayrollSummary = New Label()
        lblDepartment = New Label()
        lblAttendanceTracker = New Label()
        lblTeamOverview = New Label()
        Label5 = New Label()
        lblMyProfile = New Label()
        lblAttendance = New Label()
        lblLeaveManagement = New Label()
        lblSalary = New Label()
        Label6 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        lblDashboard = New Label()
        Label51 = New Label()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
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
        adminheader_pnl.TabIndex = 23
        ' 
        ' pcbTerminate
        ' 
        pcbTerminate.Image = CType(resources.GetObject("pcbTerminate.Image"), Image)
        pcbTerminate.Location = New Point(1352, 45)
        pcbTerminate.Name = "pcbTerminate"
        pcbTerminate.Size = New Size(55, 54)
        pcbTerminate.SizeMode = PictureBoxSizeMode.StretchImage
        pcbTerminate.TabIndex = 65
        pcbTerminate.TabStop = False
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
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(DateTimePicker2)
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(btnSave)
        GroupBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox3.Location = New Point(1218, 116)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(514, 350)
        GroupBox3.TabIndex = 63
        GroupBox3.TabStop = False
        GroupBox3.Text = "Application for Leave"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.InactiveCaption
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(170, 294)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 46)
        Button3.TabIndex = 46
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Century Gothic", 11.2F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Service Incentive Leave", "Maternity Leave", "Paternity Leave", "Parental Leave for Solo Parents", "Special Leave for Women", "Leave for Victims of Violence Against Women and their Children "})
        ComboBox1.Location = New Point(170, 45)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(338, 30)
        ComboBox1.TabIndex = 45
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Century Gothic", 11.2F)
        DateTimePicker2.Location = New Point(170, 146)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(338, 30)
        DateTimePicker2.TabIndex = 44
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Century Gothic", 11.2F)
        DateTimePicker1.Location = New Point(170, 98)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(338, 30)
        DateTimePicker1.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11.2F)
        Label1.Location = New Point(78, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 22)
        Label1.TabIndex = 42
        Label1.Text = "To Date:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Century Gothic", 11.2F)
        TextBox8.Location = New Point(170, 202)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(338, 86)
        TextBox8.TabIndex = 41
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 11.2F)
        Label13.Location = New Point(81, 205)
        Label13.Name = "Label13"
        Label13.Size = New Size(83, 22)
        Label13.TabIndex = 38
        Label13.Text = "Reason:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 11.2F)
        Label9.Location = New Point(54, 106)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 22)
        Label9.TabIndex = 37
        Label9.Text = "From Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.2F)
        Label3.Location = New Point(18, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 22)
        Label3.TabIndex = 36
        Label3.Text = "Type of Leave:"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.InactiveCaption
        btnSave.BackgroundImageLayout = ImageLayout.None
        btnSave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(316, 294)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(192, 46)
        btnSave.TabIndex = 35
        btnSave.Text = "Sumbit Application"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(DateTimePicker3)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Button1)
        GroupBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox4.Location = New Point(370, 107)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(299, 332)
        GroupBox4.TabIndex = 64
        GroupBox4.TabStop = False
        GroupBox4.Text = "Current Status"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Font = New Font("Century Gothic", 8F, FontStyle.Bold)
        DateTimePicker3.Location = New Point(26, 38)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(254, 24)
        DateTimePicker3.TabIndex = 38
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Location = New Point(26, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(254, 120)
        Label4.TabIndex = 37
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveCaption
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(37, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(224, 46)
        Button2.TabIndex = 36
        Button2.Text = "Check In"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.InactiveCaption
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(37, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 46)
        Button1.TabIndex = 35
        Button1.Text = "Check Out"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(29, 31)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1347, 214)
        DataGridView2.TabIndex = 34
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView2)
        GroupBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(370, 462)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1399, 262)
        GroupBox1.TabIndex = 61
        GroupBox1.TabStop = False
        GroupBox1.Text = "Attendance History"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(lblAmenities)
        Panel2.Controls.Add(lblGoalsAndGrowth)
        Panel2.Controls.Add(lblLeaveApproval)
        Panel2.Controls.Add(lblPerformanceReview)
        Panel2.Controls.Add(lblPayrollSummary)
        Panel2.Controls.Add(lblDepartment)
        Panel2.Controls.Add(lblAttendanceTracker)
        Panel2.Controls.Add(lblTeamOverview)
        Panel2.Controls.Add(Label5)
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
        ' lblGoalsAndGrowth
        ' 
        lblGoalsAndGrowth.AutoSize = True
        lblGoalsAndGrowth.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGoalsAndGrowth.ForeColor = Color.White
        lblGoalsAndGrowth.Location = New Point(53, 430)
        lblGoalsAndGrowth.Name = "lblGoalsAndGrowth"
        lblGoalsAndGrowth.Size = New Size(220, 27)
        lblGoalsAndGrowth.TabIndex = 110
        lblGoalsAndGrowth.Text = "Goals and Growth"
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
        ' lblPerformanceReview
        ' 
        lblPerformanceReview.AutoSize = True
        lblPerformanceReview.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPerformanceReview.ForeColor = Color.White
        lblPerformanceReview.Location = New Point(53, 700)
        lblPerformanceReview.Name = "lblPerformanceReview"
        lblPerformanceReview.Size = New Size(250, 27)
        lblPerformanceReview.TabIndex = 108
        lblPerformanceReview.Text = "Performance Review"
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(30, 500)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 22)
        Label5.TabIndex = 103
        Label5.Text = "MANAGEMENT"
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
        Label27.Location = New Point(15, 60)
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
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1779, 1080)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Time_and_Attendancevb"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblGoalsAndGrowth As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblPerformanceReview As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblAttendanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label51 As Label
End Class
