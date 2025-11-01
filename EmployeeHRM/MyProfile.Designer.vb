<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyProfile))
        adminheader_pnl = New Panel()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
        pbProfilePicture = New PictureBox()
        btnEdit = New Button()
        btnSave = New Button()
        GroupBox2 = New GroupBox()
        txtYearsOfService = New TextBox()
        txtDepartment = New TextBox()
        Label48 = New Label()
        Label1 = New Label()
        txtContractType = New TextBox()
        txtDateHired = New TextBox()
        txtEmployeeStatus = New TextBox()
        txtPosition = New TextBox()
        txtJobTitle = New TextBox()
        Label12 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        GroupBox4 = New GroupBox()
        txtC1Address = New TextBox()
        Label54 = New Label()
        txtC1Phone = New TextBox()
        txtC1Relationship = New TextBox()
        txtC1Name = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label24 = New Label()
        GroupBox5 = New GroupBox()
        GroupBox3 = New GroupBox()
        txtC2Address = New TextBox()
        Label53 = New Label()
        txtC2Phone = New TextBox()
        txtRelationship = New TextBox()
        txtC2Name = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label25 = New Label()
        DataGridView1 = New DataGridView()
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
        lblDashboard = New Label()
        lblMain = New Label()
        Label26 = New Label()
        Label27 = New Label()
        GroupBox8 = New GroupBox()
        cmbUser = New ComboBox()
        txtPass = New TextBox()
        txtUname = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label52 = New Label()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label29 = New Label()
        cmbCivilStatus = New ComboBox()
        dtpBirthdate = New DateTimePicker()
        cmbSex = New ComboBox()
        txtSuffix = New TextBox()
        txtLname = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtMname = New TextBox()
        Label9 = New Label()
        Label13 = New Label()
        txtage = New TextBox()
        Label14 = New Label()
        lblage = New Label()
        Label17 = New Label()
        txtFname = New TextBox()
        lblfname = New Label()
        Label18 = New Label()
        GroupBox9 = New GroupBox()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label19 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox8.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox9.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(322, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 21
        ' 
        ' pcbTerminate
        ' 
        pcbTerminate.Image = CType(resources.GetObject("pcbTerminate.Image"), Image)
        pcbTerminate.Location = New Point(1352, 45)
        pcbTerminate.Name = "pcbTerminate"
        pcbTerminate.Size = New Size(55, 54)
        pcbTerminate.SizeMode = PictureBoxSizeMode.StretchImage
        pcbTerminate.TabIndex = 2
        pcbTerminate.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 34)
        Label2.TabIndex = 0
        Label2.Text = "My Profile"
        ' 
        ' pbProfilePicture
        ' 
        pbProfilePicture.BorderStyle = BorderStyle.Fixed3D
        pbProfilePicture.Location = New Point(329, 121)
        pbProfilePicture.Name = "pbProfilePicture"
        pbProfilePicture.Size = New Size(210, 179)
        pbProfilePicture.TabIndex = 22
        pbProfilePicture.TabStop = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.InactiveCaption
        btnEdit.BackgroundImageLayout = ImageLayout.None
        btnEdit.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEdit.ForeColor = Color.Black
        btnEdit.Location = New Point(398, 300)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(70, 29)
        btnEdit.TabIndex = 37
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.InactiveCaption
        btnSave.BackgroundImageLayout = ImageLayout.None
        btnSave.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(470, 300)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(69, 29)
        btnSave.TabIndex = 36
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtYearsOfService)
        GroupBox2.Controls.Add(txtDepartment)
        GroupBox2.Controls.Add(Label48)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtContractType)
        GroupBox2.Controls.Add(txtDateHired)
        GroupBox2.Controls.Add(txtEmployeeStatus)
        GroupBox2.Controls.Add(txtPosition)
        GroupBox2.Controls.Add(txtJobTitle)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(Label21)
        GroupBox2.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        GroupBox2.Location = New Point(348, 424)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1346, 106)
        GroupBox2.TabIndex = 61
        GroupBox2.TabStop = False
        GroupBox2.Text = "Work Information"
        ' 
        ' txtYearsOfService
        ' 
        txtYearsOfService.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYearsOfService.Location = New Point(1200, 54)
        txtYearsOfService.Name = "txtYearsOfService"
        txtYearsOfService.Size = New Size(94, 30)
        txtYearsOfService.TabIndex = 16
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDepartment.Location = New Point(518, 63)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(255, 30)
        txtDepartment.TabIndex = 16
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label48.Location = New Point(389, 72)
        Label48.Name = "Label48"
        Label48.Size = New Size(123, 21)
        Label48.TabIndex = 15
        Label48.Text = "Department:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1162, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 21)
        Label1.TabIndex = 15
        Label1.Text = "Years of Service:"
        ' 
        ' txtContractType
        ' 
        txtContractType.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContractType.Location = New Point(928, 27)
        txtContractType.Name = "txtContractType"
        txtContractType.Size = New Size(210, 30)
        txtContractType.TabIndex = 14
        ' 
        ' txtDateHired
        ' 
        txtDateHired.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDateHired.Location = New Point(928, 63)
        txtDateHired.Name = "txtDateHired"
        txtDateHired.Size = New Size(210, 30)
        txtDateHired.TabIndex = 13
        ' 
        ' txtEmployeeStatus
        ' 
        txtEmployeeStatus.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeStatus.Location = New Point(520, 27)
        txtEmployeeStatus.Name = "txtEmployeeStatus"
        txtEmployeeStatus.Size = New Size(255, 30)
        txtEmployeeStatus.TabIndex = 12
        ' 
        ' txtPosition
        ' 
        txtPosition.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPosition.Location = New Point(103, 63)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(220, 30)
        txtPosition.TabIndex = 11
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJobTitle.Location = New Point(103, 27)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(220, 30)
        txtJobTitle.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(782, 36)
        Label12.Name = "Label12"
        Label12.Size = New Size(144, 21)
        Label12.TabIndex = 4
        Label12.Text = "Contract Type:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(329, 36)
        Label15.Name = "Label15"
        Label15.Size = New Size(185, 21)
        Label15.TabIndex = 3
        Label15.Text = "Employment Status:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(16, 72)
        Label16.Name = "Label16"
        Label16.Size = New Size(81, 21)
        Label16.TabIndex = 2
        Label16.Text = "Position:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(818, 72)
        Label20.Name = "Label20"
        Label20.Size = New Size(108, 21)
        Label20.TabIndex = 1
        Label20.Text = "Date Hired:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(11, 36)
        Label21.Name = "Label21"
        Label21.Size = New Size(86, 21)
        Label21.TabIndex = 0
        Label21.Text = "Job Title:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txtC1Address)
        GroupBox4.Controls.Add(Label54)
        GroupBox4.Controls.Add(txtC1Phone)
        GroupBox4.Controls.Add(txtC1Relationship)
        GroupBox4.Controls.Add(txtC1Name)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label24)
        GroupBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(17, 33)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(370, 172)
        GroupBox4.TabIndex = 63
        GroupBox4.TabStop = False
        GroupBox4.Text = "Contact 1"
        ' 
        ' txtC1Address
        ' 
        txtC1Address.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Address.Location = New Point(159, 132)
        txtC1Address.Name = "txtC1Address"
        txtC1Address.Size = New Size(189, 30)
        txtC1Address.TabIndex = 14
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(68, 141)
        Label54.Name = "Label54"
        Label54.Size = New Size(85, 21)
        Label54.TabIndex = 13
        Label54.Text = "Address:"
        ' 
        ' txtC1Phone
        ' 
        txtC1Phone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Phone.Location = New Point(159, 97)
        txtC1Phone.Name = "txtC1Phone"
        txtC1Phone.Size = New Size(189, 30)
        txtC1Phone.TabIndex = 12
        ' 
        ' txtC1Relationship
        ' 
        txtC1Relationship.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Relationship.Location = New Point(159, 61)
        txtC1Relationship.Name = "txtC1Relationship"
        txtC1Relationship.Size = New Size(189, 30)
        txtC1Relationship.TabIndex = 11
        ' 
        ' txtC1Name
        ' 
        txtC1Name.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Name.Location = New Point(159, 25)
        txtC1Name.Name = "txtC1Name"
        txtC1Name.Size = New Size(189, 30)
        txtC1Name.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 21)
        Label5.TabIndex = 3
        Label5.Text = "Phone Number:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(34, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 21)
        Label6.TabIndex = 2
        Label6.Text = "Relationship:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(84, 34)
        Label24.Name = "Label24"
        Label24.Size = New Size(69, 21)
        Label24.TabIndex = 0
        Label24.Text = "Name:"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(GroupBox3)
        GroupBox5.Controls.Add(GroupBox4)
        GroupBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(1323, 559)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(409, 411)
        GroupBox5.TabIndex = 64
        GroupBox5.TabStop = False
        GroupBox5.Text = "Emergency Contact"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtC2Address)
        GroupBox3.Controls.Add(Label53)
        GroupBox3.Controls.Add(txtC2Phone)
        GroupBox3.Controls.Add(txtRelationship)
        GroupBox3.Controls.Add(txtC2Name)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(17, 215)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(370, 185)
        GroupBox3.TabIndex = 64
        GroupBox3.TabStop = False
        GroupBox3.Text = "Contact 2"
        ' 
        ' txtC2Address
        ' 
        txtC2Address.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC2Address.Location = New Point(159, 144)
        txtC2Address.Name = "txtC2Address"
        txtC2Address.Size = New Size(189, 30)
        txtC2Address.TabIndex = 14
        ' 
        ' Label53
        ' 
        Label53.AutoSize = True
        Label53.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label53.Location = New Point(68, 147)
        Label53.Name = "Label53"
        Label53.Size = New Size(85, 21)
        Label53.TabIndex = 13
        Label53.Text = "Address:"
        ' 
        ' txtC2Phone
        ' 
        txtC2Phone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC2Phone.Location = New Point(159, 104)
        txtC2Phone.Name = "txtC2Phone"
        txtC2Phone.Size = New Size(189, 30)
        txtC2Phone.TabIndex = 12
        ' 
        ' txtRelationship
        ' 
        txtRelationship.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRelationship.Location = New Point(159, 68)
        txtRelationship.Name = "txtRelationship"
        txtRelationship.Size = New Size(189, 30)
        txtRelationship.TabIndex = 11
        ' 
        ' txtC2Name
        ' 
        txtC2Name.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC2Name.Location = New Point(159, 32)
        txtC2Name.Name = "txtC2Name"
        txtC2Name.Size = New Size(189, 30)
        txtC2Name.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(6, 113)
        Label10.Name = "Label10"
        Label10.Size = New Size(147, 21)
        Label10.TabIndex = 3
        Label10.Text = "Phone Number:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(34, 77)
        Label11.Name = "Label11"
        Label11.Size = New Size(119, 21)
        Label11.TabIndex = 2
        Label11.Text = "Relationship:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(84, 41)
        Label25.Name = "Label25"
        Label25.Size = New Size(69, 21)
        Label25.TabIndex = 0
        Label25.Text = "Name:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(349, 559)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(954, 78)
        DataGridView1.TabIndex = 67
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
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(lblMain)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label27)
        Panel2.Location = New Point(-6, -6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 1357)
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
        lblAmenities.TabIndex = 34
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
        lblTrainings.TabIndex = 33
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
        lblLeaveApproval.TabIndex = 32
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
        lblEmployeeTrainings.TabIndex = 31
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
        lblPayrollSummary.TabIndex = 30
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
        lblDepartment.TabIndex = 29
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
        lblAttendanceTracker.TabIndex = 28
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
        lblTeamOverview.TabIndex = 27
        lblTeamOverview.Text = "Team Overview"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.White
        Label28.Location = New Point(30, 500)
        Label28.Name = "Label28"
        Label28.Size = New Size(135, 22)
        Label28.TabIndex = 26
        Label28.Text = "MANAGEMENT"
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
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label49.ForeColor = Color.White
        Label49.Location = New Point(30, 230)
        Label49.Name = "Label49"
        Label49.Size = New Size(98, 22)
        Label49.TabIndex = 21
        Label49.Text = "OVERVIEW"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(53, 167)
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
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(58, 35)
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
        Label27.Location = New Point(15, 60)
        Label27.Name = "Label27"
        Label27.Size = New Size(312, 27)
        Label27.TabIndex = 11
        Label27.Text = "                                                  "
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Controls.Add(cmbUser)
        GroupBox8.Controls.Add(txtPass)
        GroupBox8.Controls.Add(txtUname)
        GroupBox8.Controls.Add(Label7)
        GroupBox8.Controls.Add(Label8)
        GroupBox8.Controls.Add(Label52)
        GroupBox8.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox8.Location = New Point(1328, 109)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(374, 221)
        GroupBox8.TabIndex = 68
        GroupBox8.TabStop = False
        GroupBox8.Text = "User Information"
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(27, 160)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 21)
        Label7.TabIndex = 32
        Label7.Text = "Password:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(27, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 21)
        Label8.TabIndex = 31
        Label8.Text = "Username:"
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label52.ForeColor = Color.Black
        Label52.Location = New Point(27, 33)
        Label52.Name = "Label52"
        Label52.Size = New Size(94, 21)
        Label52.TabIndex = 30
        Label52.Text = "User Type:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label29)
        GroupBox1.Controls.Add(cmbCivilStatus)
        GroupBox1.Controls.Add(dtpBirthdate)
        GroupBox1.Controls.Add(cmbSex)
        GroupBox1.Controls.Add(txtSuffix)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtMname)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(txtage)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(lblage)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Controls.Add(lblfname)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(547, 112)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(779, 221)
        GroupBox1.TabIndex = 47
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(566, 40)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 26)
        TextBox2.TabIndex = 52
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(177, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(257, 26)
        TextBox1.TabIndex = 51
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = Color.Black
        Label29.Location = New Point(450, 44)
        Label29.Name = "Label29"
        Label29.Size = New Size(108, 23)
        Label29.TabIndex = 50
        Label29.Text = "Password:"
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        cmbCivilStatus.Location = New Point(564, 178)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(207, 26)
        cmbCivilStatus.TabIndex = 49
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.CustomFormat = "mm/dd/yyyy"
        dtpBirthdate.Location = New Point(564, 109)
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
        cmbSex.Location = New Point(564, 143)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(207, 26)
        cmbSex.TabIndex = 47
        ' 
        ' txtSuffix
        ' 
        txtSuffix.Location = New Point(177, 177)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(257, 26)
        txtSuffix.TabIndex = 42
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(177, 145)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(257, 26)
        txtLname.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(38, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 23)
        Label3.TabIndex = 40
        Label3.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(11, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 23)
        Label4.TabIndex = 38
        Label4.Text = "Middle Name:"
        ' 
        ' txtMname
        ' 
        txtMname.Location = New Point(177, 112)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(257, 26)
        txtMname.TabIndex = 37
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(96, 177)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 23)
        Label9.TabIndex = 36
        Label9.Text = "Suffix:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(439, 178)
        Label13.Name = "Label13"
        Label13.Size = New Size(119, 23)
        Label13.TabIndex = 34
        Label13.Text = "Civil Status:"
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(566, 72)
        txtage.Name = "txtage"
        txtage.Size = New Size(205, 26)
        txtage.TabIndex = 32
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(510, 145)
        Label14.Name = "Label14"
        Label14.Size = New Size(48, 23)
        Label14.TabIndex = 30
        Label14.Text = "Sex:"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblage.ForeColor = Color.Black
        lblage.Location = New Point(502, 75)
        lblage.Name = "lblage"
        lblage.Size = New Size(56, 23)
        lblage.TabIndex = 29
        lblage.Text = "Age:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(450, 112)
        Label17.Name = "Label17"
        Label17.Size = New Size(109, 23)
        Label17.TabIndex = 27
        Label17.Text = "Birth Date:"
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(177, 79)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(257, 26)
        txtFname.TabIndex = 24
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
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(19, 49)
        Label18.Name = "Label18"
        Label18.Size = New Size(140, 23)
        Label18.TabIndex = 13
        Label18.Text = "Employee ID:"
        ' 
        ' GroupBox9
        ' 
        GroupBox9.Controls.Add(txtAddress)
        GroupBox9.Controls.Add(txtEmail)
        GroupBox9.Controls.Add(txtPhone)
        GroupBox9.Controls.Add(Label19)
        GroupBox9.Controls.Add(Label22)
        GroupBox9.Controls.Add(Label23)
        GroupBox9.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox9.Location = New Point(349, 339)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(1352, 86)
        GroupBox9.TabIndex = 77
        GroupBox9.TabStop = False
        GroupBox9.Text = "Added Information"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(831, 40)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(508, 30)
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
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(740, 46)
        Label19.Name = "Label19"
        Label19.Size = New Size(85, 21)
        Label19.TabIndex = 4
        Label19.Text = "Address:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(14, 43)
        Label22.Name = "Label22"
        Label22.Size = New Size(147, 21)
        Label22.TabIndex = 3
        Label22.Text = "Phone Number:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(384, 43)
        Label23.Name = "Label23"
        Label23.Size = New Size(135, 21)
        Label23.TabIndex = 1
        Label23.Text = "Email Address:"
        ' 
        ' MyProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox9)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox8)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox2)
        Controls.Add(btnEdit)
        Controls.Add(btnSave)
        Controls.Add(pbProfilePicture)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "MyProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Profile"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        CType(pbProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox8.ResumeLayout(False)
        GroupBox8.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox9.ResumeLayout(False)
        GroupBox9.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pbProfilePicture As PictureBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtContractType As TextBox
    Friend WithEvents txtDateHired As TextBox
    Friend WithEvents txtEmployeeStatus As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtYearsOfService As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtC1Phone As TextBox
    Friend WithEvents txtC1Relationship As TextBox
    Friend WithEvents txtC1Name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtC2Phone As TextBox
    Friend WithEvents txtRelationship As TextBox
    Friend WithEvents txtC2Name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents lblfname As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtC2Address As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txtC1Address As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents lblAmenities As Label
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
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
