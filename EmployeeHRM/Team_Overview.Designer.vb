<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team_Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Team_Overview))
        Panel1 = New Panel()
        lblAmenities = New Label()
        lblTrainings = New Label()
        lblLeaveApproval = New Label()
        lblEmployeeTrainings = New Label()
        lblPayrollSummary = New Label()
        lblDepartment = New Label()
        Label8 = New Label()
        Label7 = New Label()
        lblAttandanceTracker = New Label()
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
        dgvAccount = New DataGridView()
        Label14 = New Label()
        TextBox7 = New TextBox()
        pbEmployee = New PictureBox()
        btnUpdatePic = New Button()
        btnAddPic = New Button()
        GroupBox1 = New GroupBox()
        cmbCivilStatus = New ComboBox()
        dtpBirthdate = New DateTimePicker()
        cmbSex = New ComboBox()
        txtSuffix = New TextBox()
        txtLname = New TextBox()
        Label6 = New Label()
        Label21 = New Label()
        txtMname = New TextBox()
        Label20 = New Label()
        Label16 = New Label()
        txtage = New TextBox()
        Label15 = New Label()
        lblage = New Label()
        Label10 = New Label()
        txtFname = New TextBox()
        lblID = New Label()
        lblfname = New Label()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        cmbUser = New ComboBox()
        txtPass = New TextBox()
        txtUname = New TextBox()
        Label24 = New Label()
        Label13 = New Label()
        Label5 = New Label()
        btnCancel = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        GroupBox3 = New GroupBox()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label29 = New Label()
        Label30 = New Label()
        Label32 = New Label()
        btnAddEmployee = New FontAwesome.Sharp.IconButton()
        btnEditEmployee = New FontAwesome.Sharp.IconButton()
        btnUpdate = New Button()
        GroupBox6 = New GroupBox()
        TextBox26 = New TextBox()
        TextBox27 = New TextBox()
        TextBox28 = New TextBox()
        TextBox23 = New TextBox()
        TextBox24 = New TextBox()
        TextBox25 = New TextBox()
        Label34 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label31 = New Label()
        TextBox30 = New TextBox()
        TextBox31 = New TextBox()
        TextBox32 = New TextBox()
        Label12 = New Label()
        Label33 = New Label()
        Label35 = New Label()
        GroupBox2 = New GroupBox()
        TextBox1 = New TextBox()
        Label17 = New Label()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        TextBox20 = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label25 = New Label()
        GroupBox5 = New GroupBox()
        TextBox2 = New TextBox()
        Label54 = New Label()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox16 = New TextBox()
        Label48 = New Label()
        Label49 = New Label()
        Label50 = New Label()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox5.SuspendLayout()
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
        Panel1.Controls.Add(lblAttandanceTracker)
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
        Panel1.TabIndex = 3
        ' 
        ' lblAmenities
        ' 
        lblAmenities.AutoSize = True
        lblAmenities.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmenities.ForeColor = Color.White
        lblAmenities.Location = New Point(53, 780)
        lblAmenities.Name = "lblAmenities"
        lblAmenities.Size = New Size(118, 27)
        lblAmenities.TabIndex = 36
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
        lblTrainings.TabIndex = 35
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
        lblLeaveApproval.TabIndex = 34
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
        lblEmployeeTrainings.TabIndex = 33
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
        lblPayrollSummary.TabIndex = 32
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
        lblDepartment.TabIndex = 31
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
        Label8.TabIndex = 30
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
        Label7.TabIndex = 29
        Label7.Text = "                                                  "
        ' 
        ' lblAttandanceTracker
        ' 
        lblAttandanceTracker.AutoSize = True
        lblAttandanceTracker.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAttandanceTracker.ForeColor = Color.White
        lblAttandanceTracker.Location = New Point(53, 580)
        lblAttandanceTracker.Name = "lblAttandanceTracker"
        lblAttandanceTracker.Size = New Size(239, 27)
        lblAttandanceTracker.TabIndex = 28
        lblAttandanceTracker.Text = "Attendance Tracker"
        ' 
        ' lblTeamOverview
        ' 
        lblTeamOverview.AutoSize = True
        lblTeamOverview.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTeamOverview.ForeColor = Color.White
        lblTeamOverview.Location = New Point(53, 540)
        lblTeamOverview.Name = "lblTeamOverview"
        lblTeamOverview.Size = New Size(195, 27)
        lblTeamOverview.TabIndex = 27
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
        Label4.TabIndex = 26
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
        lblMyProfile.TabIndex = 25
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
        lblAttendance.TabIndex = 24
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
        lblLeaveManagement.TabIndex = 23
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
        lblSalary.TabIndex = 22
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
        Label3.TabIndex = 21
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
        lblDashboard.TabIndex = 20
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
        lblMain.TabIndex = 19
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
        adminheader_pnl.TabIndex = 4
        ' 
        ' pcbTerminate
        ' 
        pcbTerminate.Image = CType(resources.GetObject("pcbTerminate.Image"), Image)
        pcbTerminate.Location = New Point(1352, 45)
        pcbTerminate.Name = "pcbTerminate"
        pcbTerminate.Size = New Size(55, 54)
        pcbTerminate.SizeMode = PictureBoxSizeMode.StretchImage
        pcbTerminate.TabIndex = 81
        pcbTerminate.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(261, 34)
        Label2.TabIndex = 0
        Label2.Text = "Team Overview"
        ' 
        ' dgvAccount
        ' 
        dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvAccount.ColumnHeadersHeight = 29
        dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAccount.Location = New Point(358, 733)
        dgvAccount.Name = "dgvAccount"
        dgvAccount.RowHeadersWidth = 51
        dgvAccount.Size = New Size(951, 288)
        dgvAccount.TabIndex = 39
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(360, 99)
        Label14.Name = "Label14"
        Label14.Size = New Size(216, 27)
        Label14.TabIndex = 37
        Label14.Text = "Search Employee:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(593, 101)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(249, 27)
        TextBox7.TabIndex = 36
        ' 
        ' pbEmployee
        ' 
        pbEmployee.BorderStyle = BorderStyle.FixedSingle
        pbEmployee.Location = New Point(360, 139)
        pbEmployee.Name = "pbEmployee"
        pbEmployee.Size = New Size(205, 192)
        pbEmployee.TabIndex = 43
        pbEmployee.TabStop = False
        ' 
        ' btnUpdatePic
        ' 
        btnUpdatePic.Location = New Point(490, 333)
        btnUpdatePic.Name = "btnUpdatePic"
        btnUpdatePic.Size = New Size(79, 31)
        btnUpdatePic.TabIndex = 44
        btnUpdatePic.Text = "Update"
        btnUpdatePic.UseVisualStyleBackColor = True
        ' 
        ' btnAddPic
        ' 
        btnAddPic.Location = New Point(405, 333)
        btnAddPic.Name = "btnAddPic"
        btnAddPic.Size = New Size(79, 31)
        btnAddPic.TabIndex = 45
        btnAddPic.Text = "Save"
        btnAddPic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbCivilStatus)
        GroupBox1.Controls.Add(dtpBirthdate)
        GroupBox1.Controls.Add(cmbSex)
        GroupBox1.Controls.Add(txtSuffix)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Controls.Add(txtMname)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(txtage)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(lblage)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Controls.Add(lblID)
        GroupBox1.Controls.Add(lblfname)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(573, 139)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(796, 221)
        GroupBox1.TabIndex = 46
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        cmbCivilStatus.Location = New Point(583, 178)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(207, 26)
        cmbCivilStatus.TabIndex = 49
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.CustomFormat = "mm/dd/yyyy"
        dtpBirthdate.Location = New Point(583, 109)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(207, 26)
        dtpBirthdate.TabIndex = 48
        dtpBirthdate.Value = New Date(2025, 9, 13, 1, 11, 7, 0)
        ' 
        ' cmbSex
        ' 
        cmbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSex.FormattingEnabled = True
        cmbSex.Items.AddRange(New Object() {"Female", "Male"})
        cmbSex.Location = New Point(583, 143)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(207, 26)
        cmbSex.TabIndex = 47
        ' 
        ' txtSuffix
        ' 
        txtSuffix.Location = New Point(177, 177)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(269, 26)
        txtSuffix.TabIndex = 42
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(177, 145)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(269, 26)
        txtLname.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(38, 145)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 23)
        Label6.TabIndex = 40
        Label6.Text = "Last Name:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(11, 112)
        Label21.Name = "Label21"
        Label21.Size = New Size(148, 23)
        Label21.TabIndex = 38
        Label21.Text = "Middle Name:"
        ' 
        ' txtMname
        ' 
        txtMname.Location = New Point(177, 112)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(269, 26)
        txtMname.TabIndex = 37
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(96, 177)
        Label20.Name = "Label20"
        Label20.Size = New Size(62, 23)
        Label20.TabIndex = 36
        Label20.Text = "Suffix:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(458, 178)
        Label16.Name = "Label16"
        Label16.Size = New Size(119, 23)
        Label16.TabIndex = 34
        Label16.Text = "Civil Status:"
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(585, 72)
        txtage.Name = "txtage"
        txtage.Size = New Size(205, 26)
        txtage.TabIndex = 32
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(529, 145)
        Label15.Name = "Label15"
        Label15.Size = New Size(48, 23)
        Label15.TabIndex = 30
        Label15.Text = "Sex:"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblage.ForeColor = Color.Black
        lblage.Location = New Point(521, 75)
        lblage.Name = "lblage"
        lblage.Size = New Size(56, 23)
        lblage.TabIndex = 29
        lblage.Text = "Age:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(469, 112)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 23)
        Label10.TabIndex = 27
        Label10.Text = "Birth Date:"
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(177, 76)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(269, 26)
        txtFname.TabIndex = 24
        ' 
        ' lblID
        ' 
        lblID.BackColor = SystemColors.ButtonHighlight
        lblID.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(177, 34)
        lblID.Name = "lblID"
        lblID.Size = New Size(269, 32)
        lblID.TabIndex = 23
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblfname.ForeColor = Color.Black
        lblfname.Location = New Point(42, 79)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(116, 23)
        lblfname.TabIndex = 14
        lblfname.Text = "First Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 23)
        Label1.TabIndex = 13
        Label1.Text = "Employee ID:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(cmbUser)
        GroupBox4.Controls.Add(txtPass)
        GroupBox4.Controls.Add(txtUname)
        GroupBox4.Controls.Add(Label24)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(1378, 143)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(361, 221)
        GroupBox4.TabIndex = 47
        GroupBox4.TabStop = False
        GroupBox4.Text = "User Information"
        ' 
        ' cmbUser
        ' 
        cmbUser.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUser.FormattingEnabled = True
        cmbUser.Items.AddRange(New Object() {"Manager", "Staff"})
        cmbUser.Location = New Point(27, 57)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(311, 26)
        cmbUser.TabIndex = 46
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(27, 182)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(314, 26)
        txtPass.TabIndex = 45
        ' 
        ' txtUname
        ' 
        txtUname.Location = New Point(27, 122)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(314, 26)
        txtUname.TabIndex = 44
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.Black
        Label24.Location = New Point(27, 160)
        Label24.Name = "Label24"
        Label24.Size = New Size(93, 21)
        Label24.TabIndex = 32
        Label24.Text = "Password:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(27, 95)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 21)
        Label13.TabIndex = 31
        Label13.Text = "Username:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(27, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 21)
        Label5.TabIndex = 30
        Label5.Text = "User Type:"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.InactiveCaption
        btnCancel.BackgroundImageLayout = ImageLayout.None
        btnCancel.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancel.ForeColor = Color.Black
        btnCancel.Location = New Point(1623, 94)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 45)
        btnCancel.TabIndex = 75
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.InactiveCaption
        btnDelete.BackgroundImageLayout = ImageLayout.None
        btnDelete.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnDelete.ForeColor = Color.Black
        btnDelete.Location = New Point(1502, 98)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(115, 45)
        btnDelete.TabIndex = 74
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.InactiveCaption
        btnSave.BackgroundImageLayout = ImageLayout.None
        btnSave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(1513, 97)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 46)
        btnSave.TabIndex = 73
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtAddress)
        GroupBox3.Controls.Add(txtEmail)
        GroupBox3.Controls.Add(txtPhone)
        GroupBox3.Controls.Add(Label29)
        GroupBox3.Controls.Add(Label30)
        GroupBox3.Controls.Add(Label32)
        GroupBox3.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(358, 369)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1374, 86)
        GroupBox3.TabIndex = 76
        GroupBox3.TabStop = False
        GroupBox3.Text = "Added Information"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(831, 40)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(499, 30)
        txtAddress.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(519, 40)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(218, 30)
        txtEmail.TabIndex = 13
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(160, 37)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(218, 30)
        txtPhone.TabIndex = 12
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(740, 46)
        Label29.Name = "Label29"
        Label29.Size = New Size(85, 21)
        Label29.TabIndex = 4
        Label29.Text = "Address:"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(14, 43)
        Label30.Name = "Label30"
        Label30.Size = New Size(147, 21)
        Label30.TabIndex = 3
        Label30.Text = "Phone Number:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(384, 43)
        Label32.Name = "Label32"
        Label32.Size = New Size(135, 21)
        Label32.TabIndex = 1
        Label32.Text = "Email Address:"
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.BackColor = SystemColors.InactiveCaption
        btnAddEmployee.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.ForeColor = SystemColors.ControlText
        btnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        btnAddEmployee.IconColor = Color.Black
        btnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddEmployee.IconSize = 38
        btnAddEmployee.Location = New Point(1384, 96)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(170, 49)
        btnAddEmployee.TabIndex = 78
        btnAddEmployee.Text = "Add Employee"
        btnAddEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnAddEmployee.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnEditEmployee
        ' 
        btnEditEmployee.BackColor = SystemColors.InactiveCaption
        btnEditEmployee.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditEmployee.IconChar = FontAwesome.Sharp.IconChar.UserPen
        btnEditEmployee.IconColor = Color.Black
        btnEditEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditEmployee.Location = New Point(1560, 94)
        btnEditEmployee.Name = "btnEditEmployee"
        btnEditEmployee.Size = New Size(176, 49)
        btnEditEmployee.TabIndex = 79
        btnEditEmployee.Text = "Edit Employee"
        btnEditEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnEditEmployee.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEditEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.InactiveCaption
        btnUpdate.BackgroundImageLayout = ImageLayout.None
        btnUpdate.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(1392, 96)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 46)
        btnUpdate.TabIndex = 80
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(TextBox26)
        GroupBox6.Controls.Add(TextBox27)
        GroupBox6.Controls.Add(TextBox28)
        GroupBox6.Controls.Add(TextBox23)
        GroupBox6.Controls.Add(TextBox24)
        GroupBox6.Controls.Add(TextBox25)
        GroupBox6.Controls.Add(Label34)
        GroupBox6.Controls.Add(Label38)
        GroupBox6.Controls.Add(Label39)
        GroupBox6.Controls.Add(Label9)
        GroupBox6.Controls.Add(Label11)
        GroupBox6.Controls.Add(Label31)
        GroupBox6.Controls.Add(TextBox30)
        GroupBox6.Controls.Add(TextBox31)
        GroupBox6.Controls.Add(TextBox32)
        GroupBox6.Controls.Add(Label12)
        GroupBox6.Controls.Add(Label33)
        GroupBox6.Controls.Add(Label35)
        GroupBox6.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        GroupBox6.Location = New Point(357, 568)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(952, 151)
        GroupBox6.TabIndex = 81
        GroupBox6.TabStop = False
        GroupBox6.Text = "Company-Provided Benefits"
        ' 
        ' TextBox26
        ' 
        TextBox26.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox26.Location = New Point(467, 106)
        TextBox26.Name = "TextBox26"
        TextBox26.Size = New Size(160, 30)
        TextBox26.TabIndex = 33
        ' 
        ' TextBox27
        ' 
        TextBox27.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox27.Location = New Point(467, 70)
        TextBox27.Name = "TextBox27"
        TextBox27.Size = New Size(160, 30)
        TextBox27.TabIndex = 32
        ' 
        ' TextBox28
        ' 
        TextBox28.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox28.Location = New Point(467, 34)
        TextBox28.Name = "TextBox28"
        TextBox28.Size = New Size(160, 30)
        TextBox28.TabIndex = 31
        ' 
        ' TextBox23
        ' 
        TextBox23.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox23.Location = New Point(776, 100)
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New Size(160, 30)
        TextBox23.TabIndex = 30
        ' 
        ' TextBox24
        ' 
        TextBox24.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox24.Location = New Point(776, 64)
        TextBox24.Name = "TextBox24"
        TextBox24.Size = New Size(160, 30)
        TextBox24.TabIndex = 29
        ' 
        ' TextBox25
        ' 
        TextBox25.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox25.Location = New Point(776, 28)
        TextBox25.Name = "TextBox25"
        TextBox25.Size = New Size(160, 30)
        TextBox25.TabIndex = 28
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Century Gothic", 9F)
        Label34.Location = New Point(645, 110)
        Label34.Name = "Label34"
        Label34.Size = New Size(125, 20)
        Label34.TabIndex = 27
        Label34.Text = "Employer Share:"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Century Gothic", 9F)
        Label38.Location = New Point(640, 74)
        Label38.Name = "Label38"
        Label38.Size = New Size(130, 20)
        Label38.TabIndex = 26
        Label38.Text = "Employee Share:"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(655, 37)
        Label39.Name = "Label39"
        Label39.Size = New Size(115, 21)
        Label39.TabIndex = 25
        Label39.Text = "Pag-IBIG ID:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9F)
        Label9.Location = New Point(336, 110)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 20)
        Label9.TabIndex = 21
        Label9.Text = "Employer Share:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9F)
        Label11.Location = New Point(331, 74)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 20)
        Label11.TabIndex = 20
        Label11.Text = "Employee Share:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(338, 37)
        Label31.Name = "Label31"
        Label31.Size = New Size(123, 21)
        Label31.TabIndex = 19
        Label31.Text = "PhilHealth ID:"
        ' 
        ' TextBox30
        ' 
        TextBox30.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox30.Location = New Point(146, 106)
        TextBox30.Name = "TextBox30"
        TextBox30.Size = New Size(160, 30)
        TextBox30.TabIndex = 12
        ' 
        ' TextBox31
        ' 
        TextBox31.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox31.Location = New Point(146, 70)
        TextBox31.Name = "TextBox31"
        TextBox31.Size = New Size(160, 30)
        TextBox31.TabIndex = 11
        ' 
        ' TextBox32
        ' 
        TextBox32.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox32.Location = New Point(146, 34)
        TextBox32.Name = "TextBox32"
        TextBox32.Size = New Size(160, 30)
        TextBox32.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 9F)
        Label12.Location = New Point(15, 110)
        Label12.Name = "Label12"
        Label12.Size = New Size(125, 20)
        Label12.TabIndex = 3
        Label12.Text = "Employer Share:"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Century Gothic", 9F)
        Label33.Location = New Point(10, 74)
        Label33.Name = "Label33"
        Label33.Size = New Size(130, 20)
        Label33.TabIndex = 2
        Label33.Text = "Employee Share:"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(75, 37)
        Label35.Name = "Label35"
        Label35.Size = New Size(65, 21)
        Label35.TabIndex = 0
        Label35.Text = "SSS ID:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(TextBox13)
        GroupBox2.Controls.Add(TextBox14)
        GroupBox2.Controls.Add(TextBox20)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(Label23)
        GroupBox2.Controls.Add(Label25)
        GroupBox2.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        GroupBox2.Location = New Point(358, 461)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1374, 106)
        GroupBox2.TabIndex = 85
        GroupBox2.TabStop = False
        GroupBox2.Text = "Work Information"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(1012, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 30)
        TextBox1.TabIndex = 16
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(853, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(154, 21)
        Label17.TabIndex = 15
        Label17.Text = "Years of Service:"
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(1012, 23)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(206, 30)
        TextBox11.TabIndex = 14
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12.Location = New Point(570, 59)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(255, 30)
        TextBox12.TabIndex = 13
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox13.Location = New Point(570, 23)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(255, 30)
        TextBox13.TabIndex = 12
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14.Location = New Point(157, 65)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(220, 30)
        TextBox14.TabIndex = 11
        ' 
        ' TextBox20
        ' 
        TextBox20.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox20.Location = New Point(157, 29)
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(220, 30)
        TextBox20.TabIndex = 10
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(862, 32)
        Label18.Name = "Label18"
        Label18.Size = New Size(144, 21)
        Label18.TabIndex = 4
        Label18.Text = "Contract Type:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(384, 32)
        Label19.Name = "Label19"
        Label19.Size = New Size(185, 21)
        Label19.TabIndex = 3
        Label19.Text = "Employment Status:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(70, 74)
        Label22.Name = "Label22"
        Label22.Size = New Size(81, 21)
        Label22.TabIndex = 2
        Label22.Text = "Position:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(460, 68)
        Label23.Name = "Label23"
        Label23.Size = New Size(108, 21)
        Label23.TabIndex = 1
        Label23.Text = "Date Hired:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(65, 38)
        Label25.Name = "Label25"
        Label25.Size = New Size(86, 21)
        Label25.TabIndex = 0
        Label25.Text = "Job Title:"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label54)
        GroupBox5.Controls.Add(TextBox2)
        GroupBox5.Controls.Add(TextBox5)
        GroupBox5.Controls.Add(TextBox3)
        GroupBox5.Controls.Add(Label50)
        GroupBox5.Controls.Add(Label49)
        GroupBox5.Controls.Add(TextBox16)
        GroupBox5.Controls.Add(Label48)
        GroupBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(1323, 570)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(409, 209)
        GroupBox5.TabIndex = 86
        GroupBox5.TabStop = False
        GroupBox5.Text = "Emergency Contact"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(190, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(189, 30)
        TextBox2.TabIndex = 14
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(99, 157)
        Label54.Name = "Label54"
        Label54.Size = New Size(85, 21)
        Label54.TabIndex = 13
        Label54.Text = "Address:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(190, 113)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(189, 30)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(190, 77)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(189, 30)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox16
        ' 
        TextBox16.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox16.Location = New Point(190, 41)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(189, 30)
        TextBox16.TabIndex = 10
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label48.Location = New Point(37, 122)
        Label48.Name = "Label48"
        Label48.Size = New Size(147, 21)
        Label48.TabIndex = 3
        Label48.Text = "Phone Number:"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label49.Location = New Point(65, 86)
        Label49.Name = "Label49"
        Label49.Size = New Size(119, 21)
        Label49.TabIndex = 2
        Label49.Text = "Relationship:"
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label50.Location = New Point(115, 50)
        Label50.Name = "Label50"
        Label50.Size = New Size(69, 21)
        Label50.TabIndex = 0
        Label50.Text = "Name:"
        ' 
        ' Team_Overview
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox6)
        Controls.Add(btnUpdate)
        Controls.Add(btnEditEmployee)
        Controls.Add(btnAddEmployee)
        Controls.Add(GroupBox3)
        Controls.Add(btnDelete)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Controls.Add(pbEmployee)
        Controls.Add(btnUpdatePic)
        Controls.Add(btnAddPic)
        Controls.Add(dgvAccount)
        Controls.Add(Label14)
        Controls.Add(TextBox7)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Team_Overview"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Team Overview"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAccount, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAccount As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents pbEmployee As PictureBox
    Friend WithEvents btnUpdatePic As Button
    Friend WithEvents btnAddPic As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnAddEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As Button
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lblAmenities As Label
    Friend WithEvents lblTrainings As Label
    Friend WithEvents lblLeaveApproval As Label
    Friend WithEvents lblEmployeeTrainings As Label
    Friend WithEvents lblPayrollSummary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAttandanceTracker As Label
    Friend WithEvents lblTeamOverview As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMyProfile As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label
End Class
