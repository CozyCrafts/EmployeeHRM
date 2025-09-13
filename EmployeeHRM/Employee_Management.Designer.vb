<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Management))
        Panel1 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Payslipslbl = New Label()
        SalaryProcessinglbl = New Label()
        Label4 = New Label()
        lblProfile = New Label()
        lblEmployees = New Label()
        lblLeaveManagement = New Label()
        lblManageEmployees = New Label()
        Label3 = New Label()
        lblDashboard = New Label()
        lblMain = New Label()
        adminheader_pnl = New Panel()
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
        GroupBox7 = New GroupBox()
        Label49 = New Label()
        Label48 = New Label()
        Label47 = New Label()
        Label46 = New Label()
        Label44 = New Label()
        Label42 = New Label()
        TextBox43 = New TextBox()
        TextBox44 = New TextBox()
        TextBox45 = New TextBox()
        TextBox46 = New TextBox()
        TextBox35 = New TextBox()
        TextBox38 = New TextBox()
        TextBox39 = New TextBox()
        TextBox40 = New TextBox()
        Label41 = New Label()
        Label40 = New Label()
        TextBox36 = New TextBox()
        TextBox37 = New TextBox()
        TextBox41 = New TextBox()
        TextBox42 = New TextBox()
        Label36 = New Label()
        Label37 = New Label()
        Label43 = New Label()
        Label45 = New Label()
        GroupBox5 = New GroupBox()
        TextBox20 = New TextBox()
        TextBox23 = New TextBox()
        TextBox27 = New TextBox()
        Label27 = New Label()
        Label28 = New Label()
        Label31 = New Label()
        btnAddEmployee = New FontAwesome.Sharp.IconButton()
        btnEditEmployee = New FontAwesome.Sharp.IconButton()
        btnUpdate = New Button()
        pcbTerminate = New PictureBox()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        CType(dgvAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox5.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Payslipslbl)
        Panel1.Controls.Add(SalaryProcessinglbl)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblProfile)
        Panel1.Controls.Add(lblEmployees)
        Panel1.Controls.Add(lblLeaveManagement)
        Panel1.Controls.Add(lblManageEmployees)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblDashboard)
        Panel1.Controls.Add(lblMain)
        Panel1.Location = New Point(-5, -15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 1357)
        Panel1.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(38, 37)
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
        Label7.Location = New Point(33, 58)
        Label7.Name = "Label7"
        Label7.Size = New Size(312, 27)
        Label7.TabIndex = 11
        Label7.Text = "                                                  "
        ' 
        ' Payslipslbl
        ' 
        Payslipslbl.AutoSize = True
        Payslipslbl.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Payslipslbl.ForeColor = Color.White
        Payslipslbl.Location = New Point(61, 555)
        Payslipslbl.Name = "Payslipslbl"
        Payslipslbl.Size = New Size(101, 27)
        Payslipslbl.TabIndex = 10
        Payslipslbl.Text = "Payslips"
        ' 
        ' SalaryProcessinglbl
        ' 
        SalaryProcessinglbl.AutoSize = True
        SalaryProcessinglbl.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SalaryProcessinglbl.ForeColor = Color.White
        SalaryProcessinglbl.Location = New Point(61, 513)
        SalaryProcessinglbl.Name = "SalaryProcessinglbl"
        SalaryProcessinglbl.Size = New Size(206, 27)
        SalaryProcessinglbl.TabIndex = 9
        SalaryProcessinglbl.Text = "Salary Processing"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(38, 474)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 22)
        Label4.TabIndex = 8
        Label4.Text = " PAYROLL"
        ' 
        ' lblProfile
        ' 
        lblProfile.AutoSize = True
        lblProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProfile.ForeColor = Color.White
        lblProfile.Location = New Point(56, 277)
        lblProfile.Name = "lblProfile"
        lblProfile.Size = New Size(211, 27)
        lblProfile.TabIndex = 7
        lblProfile.Text = "Employees Profile"
        ' 
        ' lblEmployees
        ' 
        lblEmployees.AutoSize = True
        lblEmployees.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployees.ForeColor = Color.White
        lblEmployees.Location = New Point(56, 322)
        lblEmployees.Name = "lblEmployees"
        lblEmployees.Size = New Size(279, 27)
        lblEmployees.TabIndex = 6
        lblEmployees.Text = "Employees Attendance"
        ' 
        ' lblLeaveManagement
        ' 
        lblLeaveManagement.AutoSize = True
        lblLeaveManagement.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLeaveManagement.ForeColor = Color.White
        lblLeaveManagement.Location = New Point(56, 365)
        lblLeaveManagement.Name = "lblLeaveManagement"
        lblLeaveManagement.Size = New Size(248, 27)
        lblLeaveManagement.TabIndex = 5
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' lblManageEmployees
        ' 
        lblManageEmployees.AutoSize = True
        lblManageEmployees.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblManageEmployees.ForeColor = Color.White
        lblManageEmployees.Location = New Point(56, 402)
        lblManageEmployees.Name = "lblManageEmployees"
        lblManageEmployees.Size = New Size(240, 27)
        lblManageEmployees.TabIndex = 4
        lblManageEmployees.Text = "Manage Employees"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(38, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 22)
        Label3.TabIndex = 3
        Label3.Text = "EMPLOYEES"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(61, 162)
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
        lblMain.Location = New Point(38, 118)
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
        adminheader_pnl.Location = New Point(343, -36)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(385, 34)
        Label2.TabIndex = 0
        Label2.Text = "Employee Management"
        ' 
        ' dgvAccount
        ' 
        dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvAccount.ColumnHeadersHeight = 29
        dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAccount.Location = New Point(398, 735)
        dgvAccount.Name = "dgvAccount"
        dgvAccount.RowHeadersWidth = 51
        dgvAccount.Size = New Size(1349, 250)
        dgvAccount.TabIndex = 39
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(360, 88)
        Label14.Name = "Label14"
        Label14.Size = New Size(216, 27)
        Label14.TabIndex = 37
        Label14.Text = "Search Employee:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(593, 90)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(249, 27)
        TextBox7.TabIndex = 36
        ' 
        ' pbEmployee
        ' 
        pbEmployee.BorderStyle = BorderStyle.FixedSingle
        pbEmployee.Location = New Point(360, 155)
        pbEmployee.Name = "pbEmployee"
        pbEmployee.Size = New Size(205, 192)
        pbEmployee.TabIndex = 43
        pbEmployee.TabStop = False
        ' 
        ' btnUpdatePic
        ' 
        btnUpdatePic.Location = New Point(445, 351)
        btnUpdatePic.Name = "btnUpdatePic"
        btnUpdatePic.Size = New Size(79, 31)
        btnUpdatePic.TabIndex = 44
        btnUpdatePic.Text = "Update"
        btnUpdatePic.UseVisualStyleBackColor = True
        ' 
        ' btnAddPic
        ' 
        btnAddPic.Location = New Point(360, 351)
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
        GroupBox1.Location = New Point(583, 155)
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
        GroupBox4.Location = New Point(1385, 155)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(374, 221)
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
        cmbUser.Size = New Size(323, 26)
        cmbUser.TabIndex = 46
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(27, 182)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(326, 26)
        txtPass.TabIndex = 45
        ' 
        ' txtUname
        ' 
        txtUname.Location = New Point(27, 122)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(326, 26)
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
        btnCancel.Location = New Point(1644, 88)
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
        btnDelete.Location = New Point(1523, 90)
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
        btnSave.Location = New Point(1534, 89)
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
        GroupBox3.Location = New Point(366, 395)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1381, 86)
        GroupBox3.TabIndex = 76
        GroupBox3.TabStop = False
        GroupBox3.Text = "Added Information"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(831, 40)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(532, 30)
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
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(Label49)
        GroupBox7.Controls.Add(Label48)
        GroupBox7.Controls.Add(Label47)
        GroupBox7.Controls.Add(Label46)
        GroupBox7.Controls.Add(Label44)
        GroupBox7.Controls.Add(Label42)
        GroupBox7.Controls.Add(TextBox43)
        GroupBox7.Controls.Add(TextBox44)
        GroupBox7.Controls.Add(TextBox45)
        GroupBox7.Controls.Add(TextBox46)
        GroupBox7.Controls.Add(TextBox35)
        GroupBox7.Controls.Add(TextBox38)
        GroupBox7.Controls.Add(TextBox39)
        GroupBox7.Controls.Add(TextBox40)
        GroupBox7.Controls.Add(Label41)
        GroupBox7.Controls.Add(Label40)
        GroupBox7.Controls.Add(TextBox36)
        GroupBox7.Controls.Add(TextBox37)
        GroupBox7.Controls.Add(TextBox41)
        GroupBox7.Controls.Add(TextBox42)
        GroupBox7.Controls.Add(Label36)
        GroupBox7.Controls.Add(Label37)
        GroupBox7.Controls.Add(Label43)
        GroupBox7.Controls.Add(Label45)
        GroupBox7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.Location = New Point(366, 487)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(962, 205)
        GroupBox7.TabIndex = 77
        GroupBox7.TabStop = False
        GroupBox7.Text = "Government-Mandated Benefits"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label49.Location = New Point(699, 148)
        Label49.Name = "Label49"
        Label49.Size = New Size(65, 21)
        Label49.TabIndex = 32
        Label49.Text = "Expiry:"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label48.Location = New Point(699, 112)
        Label48.Name = "Label48"
        Label48.Size = New Size(65, 21)
        Label48.TabIndex = 31
        Label48.Text = "Expiry:"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label47.Location = New Point(699, 76)
        Label47.Name = "Label47"
        Label47.Size = New Size(65, 21)
        Label47.TabIndex = 30
        Label47.Text = "Expiry:"
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label46.Location = New Point(405, 151)
        Label46.Name = "Label46"
        Label46.Size = New Size(72, 21)
        Label46.TabIndex = 29
        Label46.Text = "Details:"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label44.Location = New Point(405, 115)
        Label44.Name = "Label44"
        Label44.Size = New Size(72, 21)
        Label44.TabIndex = 28
        Label44.Text = "Details:"
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label42.Location = New Point(405, 79)
        Label42.Name = "Label42"
        Label42.Size = New Size(72, 21)
        Label42.TabIndex = 27
        Label42.Text = "Details:"
        ' 
        ' TextBox43
        ' 
        TextBox43.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox43.Location = New Point(483, 142)
        TextBox43.Name = "TextBox43"
        TextBox43.Size = New Size(201, 30)
        TextBox43.TabIndex = 26
        ' 
        ' TextBox44
        ' 
        TextBox44.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox44.Location = New Point(483, 106)
        TextBox44.Name = "TextBox44"
        TextBox44.Size = New Size(201, 30)
        TextBox44.TabIndex = 25
        ' 
        ' TextBox45
        ' 
        TextBox45.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox45.Location = New Point(483, 70)
        TextBox45.Name = "TextBox45"
        TextBox45.Size = New Size(201, 30)
        TextBox45.TabIndex = 24
        ' 
        ' TextBox46
        ' 
        TextBox46.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox46.Location = New Point(483, 31)
        TextBox46.Name = "TextBox46"
        TextBox46.Size = New Size(201, 30)
        TextBox46.TabIndex = 23
        ' 
        ' TextBox35
        ' 
        TextBox35.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox35.Location = New Point(770, 139)
        TextBox35.Name = "TextBox35"
        TextBox35.Size = New Size(181, 30)
        TextBox35.TabIndex = 22
        ' 
        ' TextBox38
        ' 
        TextBox38.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox38.Location = New Point(770, 103)
        TextBox38.Name = "TextBox38"
        TextBox38.Size = New Size(181, 30)
        TextBox38.TabIndex = 21
        ' 
        ' TextBox39
        ' 
        TextBox39.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox39.Location = New Point(770, 67)
        TextBox39.Name = "TextBox39"
        TextBox39.Size = New Size(181, 30)
        TextBox39.TabIndex = 20
        ' 
        ' TextBox40
        ' 
        TextBox40.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox40.Location = New Point(770, 31)
        TextBox40.Name = "TextBox40"
        TextBox40.Size = New Size(181, 30)
        TextBox40.TabIndex = 19
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label41.Location = New Point(699, 37)
        Label41.Name = "Label41"
        Label41.Size = New Size(65, 21)
        Label41.TabIndex = 18
        Label41.Text = "Expiry:"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label40.Location = New Point(405, 40)
        Label40.Name = "Label40"
        Label40.Size = New Size(72, 21)
        Label40.TabIndex = 17
        Label40.Text = "Details:"
        ' 
        ' TextBox36
        ' 
        TextBox36.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox36.Location = New Point(175, 142)
        TextBox36.Name = "TextBox36"
        TextBox36.Size = New Size(213, 30)
        TextBox36.TabIndex = 16
        ' 
        ' TextBox37
        ' 
        TextBox37.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox37.Location = New Point(175, 106)
        TextBox37.Name = "TextBox37"
        TextBox37.Size = New Size(213, 30)
        TextBox37.TabIndex = 15
        ' 
        ' TextBox41
        ' 
        TextBox41.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox41.Location = New Point(175, 70)
        TextBox41.Name = "TextBox41"
        TextBox41.Size = New Size(213, 30)
        TextBox41.TabIndex = 11
        ' 
        ' TextBox42
        ' 
        TextBox42.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox42.Location = New Point(175, 34)
        TextBox42.Name = "TextBox42"
        TextBox42.Size = New Size(213, 30)
        TextBox42.TabIndex = 10
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label36.Location = New Point(84, 150)
        Label36.Name = "Label36"
        Label36.Size = New Size(85, 21)
        Label36.TabIndex = 9
        Label36.Text = "Bonuses:"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label37.Location = New Point(53, 114)
        Label37.Name = "Label37"
        Label37.Size = New Size(116, 21)
        Label37.TabIndex = 8
        Label37.Text = "Allowances:"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label43.Location = New Point(34, 79)
        Label43.Name = "Label43"
        Label43.Size = New Size(135, 21)
        Label43.TabIndex = 2
        Label43.Text = "Life Insurance:"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label45.Location = New Point(6, 43)
        Label45.Name = "Label45"
        Label45.Size = New Size(163, 21)
        Label45.TabIndex = 0
        Label45.Text = "Health Insurance:"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(TextBox20)
        GroupBox5.Controls.Add(TextBox23)
        GroupBox5.Controls.Add(TextBox27)
        GroupBox5.Controls.Add(Label27)
        GroupBox5.Controls.Add(Label28)
        GroupBox5.Controls.Add(Label31)
        GroupBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(1334, 487)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(409, 203)
        GroupBox5.TabIndex = 69
        GroupBox5.TabStop = False
        GroupBox5.Text = "Emergency Contact"
        ' 
        ' TextBox20
        ' 
        TextBox20.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox20.Location = New Point(186, 122)
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(189, 30)
        TextBox20.TabIndex = 18
        ' 
        ' TextBox23
        ' 
        TextBox23.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox23.Location = New Point(186, 86)
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New Size(189, 30)
        TextBox23.TabIndex = 17
        ' 
        ' TextBox27
        ' 
        TextBox27.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox27.Location = New Point(186, 50)
        TextBox27.Name = "TextBox27"
        TextBox27.Size = New Size(189, 30)
        TextBox27.TabIndex = 16
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(33, 131)
        Label27.Name = "Label27"
        Label27.Size = New Size(147, 21)
        Label27.TabIndex = 15
        Label27.Text = "Phone Number:"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(61, 95)
        Label28.Name = "Label28"
        Label28.Size = New Size(119, 21)
        Label28.TabIndex = 14
        Label28.Text = "Relationship:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(111, 59)
        Label31.Name = "Label31"
        Label31.Size = New Size(69, 21)
        Label31.TabIndex = 13
        Label31.Text = "Name:"
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
        btnAddEmployee.Location = New Point(1407, 76)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(170, 70)
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
        btnEditEmployee.Location = New Point(1583, 76)
        btnEditEmployee.Name = "btnEditEmployee"
        btnEditEmployee.Size = New Size(176, 70)
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
        btnUpdate.Location = New Point(1413, 91)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 46)
        btnUpdate.TabIndex = 80
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
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
        ' Employee_Management
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 1033)
        Controls.Add(btnUpdate)
        Controls.Add(btnEditEmployee)
        Controls.Add(btnAddEmployee)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox7)
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
        Controls.Add(adminheader_pnl)
        Controls.Add(Panel1)
        Name = "Employee_Management"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Management"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(dgvAccount, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEmployee, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Payslipslbl As Label
    Friend WithEvents SalaryProcessinglbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents lblEmployees As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblManageEmployees As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label
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
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents TextBox46 As TextBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents btnAddEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditEmployee As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As Button
    Friend WithEvents pcbTerminate As PictureBox
End Class
