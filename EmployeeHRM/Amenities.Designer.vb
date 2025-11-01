<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Amenities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Amenities))
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
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        TextBox3 = New TextBox()
        dgvTrainingHistory = New DataGridView()
        Button1 = New Button()
        GroupBox4 = New GroupBox()
        btnDeleteAmenity = New Button()
        btnAddAmenity = New Button()
        btnUpdateAmenity = New Button()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label9 = New Label()
        txtTrainingTitle = New TextBox()
        txtTrainingType = New TextBox()
        txtTrainingID = New TextBox()
        Label6 = New Label()
        Label21 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        btnCancelAmenity = New Button()
        btnSaveAmenity = New Button()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvTrainingHistory, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
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
        lblTrainings.TextAlign = ContentAlignment.TopCenter
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
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 3
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
        Label2.Size = New Size(175, 34)
        Label2.TabIndex = 0
        Label2.Text = "Amenities"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(dgvTrainingHistory)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(410, 534)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(1361, 434)
        GroupBox1.TabIndex = 67
        GroupBox1.TabStop = False
        GroupBox1.Text = "Amenities List"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(208, 59)
        TextBox3.Margin = New Padding(4, 3, 4, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(256, 32)
        TextBox3.TabIndex = 90
        ' 
        ' dgvTrainingHistory
        ' 
        dgvTrainingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrainingHistory.Location = New Point(34, 120)
        dgvTrainingHistory.Margin = New Padding(4, 3, 4, 3)
        dgvTrainingHistory.Name = "dgvTrainingHistory"
        dgvTrainingHistory.RowHeadersWidth = 51
        dgvTrainingHistory.Size = New Size(1308, 285)
        dgvTrainingHistory.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.InactiveCaption
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(34, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 46)
        Button1.TabIndex = 89
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnDeleteAmenity)
        GroupBox4.Controls.Add(btnAddAmenity)
        GroupBox4.Controls.Add(btnUpdateAmenity)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(ComboBox1)
        GroupBox4.Controls.Add(TextBox2)
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(txtTrainingTitle)
        GroupBox4.Controls.Add(txtTrainingType)
        GroupBox4.Controls.Add(txtTrainingID)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label21)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(btnCancelAmenity)
        GroupBox4.Controls.Add(btnSaveAmenity)
        GroupBox4.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox4.Location = New Point(407, 208)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(1361, 297)
        GroupBox4.TabIndex = 82
        GroupBox4.TabStop = False
        GroupBox4.Text = "Details"
        ' 
        ' btnDeleteAmenity
        ' 
        btnDeleteAmenity.BackColor = SystemColors.InactiveCaption
        btnDeleteAmenity.BackgroundImageLayout = ImageLayout.None
        btnDeleteAmenity.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnDeleteAmenity.ForeColor = Color.Black
        btnDeleteAmenity.Location = New Point(996, 200)
        btnDeleteAmenity.Name = "btnDeleteAmenity"
        btnDeleteAmenity.Size = New Size(340, 46)
        btnDeleteAmenity.TabIndex = 89
        btnDeleteAmenity.Text = "Delete"
        btnDeleteAmenity.UseVisualStyleBackColor = False
        ' 
        ' btnAddAmenity
        ' 
        btnAddAmenity.BackColor = SystemColors.InactiveCaption
        btnAddAmenity.BackgroundImageLayout = ImageLayout.None
        btnAddAmenity.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnAddAmenity.ForeColor = Color.Black
        btnAddAmenity.Location = New Point(996, 63)
        btnAddAmenity.Name = "btnAddAmenity"
        btnAddAmenity.Size = New Size(340, 46)
        btnAddAmenity.TabIndex = 87
        btnAddAmenity.Text = "Add Amenity "
        btnAddAmenity.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateAmenity
        ' 
        btnUpdateAmenity.BackColor = SystemColors.InactiveCaption
        btnUpdateAmenity.BackgroundImageLayout = ImageLayout.None
        btnUpdateAmenity.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnUpdateAmenity.ForeColor = Color.Black
        btnUpdateAmenity.Location = New Point(996, 129)
        btnUpdateAmenity.Name = "btnUpdateAmenity"
        btnUpdateAmenity.Size = New Size(340, 46)
        btnUpdateAmenity.TabIndex = 86
        btnUpdateAmenity.Text = "Update"
        btnUpdateAmenity.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(568, 115)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(121, 25)
        Label10.TabIndex = 85
        Label10.Text = "Condition:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(696, 105)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(256, 35)
        ComboBox1.TabIndex = 84
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(196, 212)
        TextBox2.Margin = New Padding(4, 3, 4, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(757, 36)
        TextBox2.TabIndex = 83
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(196, 157)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(757, 36)
        TextBox1.TabIndex = 82
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(78, 221)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 25)
        Label9.TabIndex = 81
        Label9.Text = "Location:"
        ' 
        ' txtTrainingTitle
        ' 
        txtTrainingTitle.Location = New Point(697, 54)
        txtTrainingTitle.Margin = New Padding(4, 3, 4, 3)
        txtTrainingTitle.Name = "txtTrainingTitle"
        txtTrainingTitle.Size = New Size(256, 36)
        txtTrainingTitle.TabIndex = 72
        ' 
        ' txtTrainingType
        ' 
        txtTrainingType.Location = New Point(196, 104)
        txtTrainingType.Margin = New Padding(4, 3, 4, 3)
        txtTrainingType.Name = "txtTrainingType"
        txtTrainingType.Size = New Size(256, 36)
        txtTrainingType.TabIndex = 80
        ' 
        ' txtTrainingID
        ' 
        txtTrainingID.Location = New Point(196, 54)
        txtTrainingID.Margin = New Padding(4, 3, 4, 3)
        txtTrainingID.Name = "txtTrainingID"
        txtTrainingID.Size = New Size(256, 36)
        txtTrainingID.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(37, 115)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 25)
        Label6.TabIndex = 79
        Label6.Text = "Amenities ID:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(27, 63)
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
        Label1.Location = New Point(511, 58)
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
        Label5.Location = New Point(103, 168)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 74
        Label5.Text = "Name:"
        ' 
        ' btnCancelAmenity
        ' 
        btnCancelAmenity.BackColor = SystemColors.InactiveCaption
        btnCancelAmenity.BackgroundImageLayout = ImageLayout.None
        btnCancelAmenity.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelAmenity.ForeColor = Color.Black
        btnCancelAmenity.Location = New Point(1169, 130)
        btnCancelAmenity.Name = "btnCancelAmenity"
        btnCancelAmenity.Size = New Size(167, 46)
        btnCancelAmenity.TabIndex = 88
        btnCancelAmenity.Text = "Cancel"
        btnCancelAmenity.UseVisualStyleBackColor = False
        ' 
        ' btnSaveAmenity
        ' 
        btnSaveAmenity.BackColor = SystemColors.InactiveCaption
        btnSaveAmenity.BackgroundImageLayout = ImageLayout.None
        btnSaveAmenity.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveAmenity.ForeColor = Color.Black
        btnSaveAmenity.Location = New Point(996, 131)
        btnSaveAmenity.Name = "btnSaveAmenity"
        btnSaveAmenity.Size = New Size(167, 46)
        btnSaveAmenity.TabIndex = 90
        btnSaveAmenity.Text = "Save"
        btnSaveAmenity.UseVisualStyleBackColor = False
        ' 
        ' Amenities
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Amenities"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Amenities"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvTrainingHistory, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
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
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvTrainingHistory As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTrainingTitle As TextBox
    Friend WithEvents txtTrainingType As TextBox
    Friend WithEvents txtTrainingID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnUpdateAmenity As Button
    Friend WithEvents btnAddAmenity As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnSaveAmenity As Button
    Friend WithEvents btnDeleteAmenity As Button
    Friend WithEvents btnCancelAmenity As Button
End Class
