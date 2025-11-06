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
        btnEditProfile = New Button()
        btnSaveProfile = New Button()
        btnCancelProfile = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBox5 = New TextBox()
        Label25 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        txtDepartment = New TextBox()
        Label48 = New Label()
        Label1 = New Label()
        txtContractType = New TextBox()
        txtDateHired = New TextBox()
        txtEmployeeStatus = New TextBox()
        txtJobTitle = New TextBox()
        Label12 = New Label()
        Label15 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        GroupBox5 = New GroupBox()
        btnEditEmergencyContact = New Button()
        btnCancelEmergencyContact = New Button()
        TextBox6 = New TextBox()
        Label11 = New Label()
        TextBox3 = New TextBox()
        Label54 = New Label()
        Label24 = New Label()
        txtC1Phone = New TextBox()
        Label6 = New Label()
        txtC1Relationship = New TextBox()
        Label5 = New Label()
        txtC1Name = New TextBox()
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
        TextBox2 = New TextBox()
        Label10 = New Label()
        txtPass = New TextBox()
        txtUname = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label52 = New Label()
        TextBox1 = New TextBox()
        cmbCivilStatus = New ComboBox()
        dtpBirthdate = New DateTimePicker()
        cmbSex = New ComboBox()
        txtLname = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtMname = New TextBox()
        Label13 = New Label()
        txtage = New TextBox()
        Label14 = New Label()
        Label17 = New Label()
        lblage = New Label()
        txtFname = New TextBox()
        lblfname = New Label()
        Label18 = New Label()
        TextBox7 = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label19 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        dgvPersonalInfo = New DataGridView()
        btnSaveEmergencyContact = New Button()
        GroupBox1 = New GroupBox()
        btnChangeUsername = New Button()
        btnChangePassword = New Button()
        btnCancelPassword = New Button()
        btnCancelUsername = New Button()
        btnSavePassword = New Button()
        btnSaveUsername = New Button()
        cmbUser = New ComboBox()
        dgvOtherInfo = New DataGridView()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvPersonalInfo, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvOtherInfo, ComponentModel.ISupportInitialize).BeginInit()
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
        ' btnEditProfile
        ' 
        btnEditProfile.BackColor = SystemColors.InactiveCaption
        btnEditProfile.BackgroundImageLayout = ImageLayout.None
        btnEditProfile.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditProfile.ForeColor = Color.Black
        btnEditProfile.Location = New Point(497, 367)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(355, 47)
        btnEditProfile.TabIndex = 80
        btnEditProfile.Text = "Edit Profile"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' btnSaveProfile
        ' 
        btnSaveProfile.BackColor = SystemColors.InactiveCaption
        btnSaveProfile.BackgroundImageLayout = ImageLayout.None
        btnSaveProfile.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveProfile.ForeColor = Color.Black
        btnSaveProfile.Location = New Point(167, 264)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(140, 39)
        btnSaveProfile.TabIndex = 78
        btnSaveProfile.Text = "Save"
        btnSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' btnCancelProfile
        ' 
        btnCancelProfile.BackColor = SystemColors.InactiveCaption
        btnCancelProfile.BackgroundImageLayout = ImageLayout.None
        btnCancelProfile.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelProfile.ForeColor = Color.Black
        btnCancelProfile.Location = New Point(672, 367)
        btnCancelProfile.Name = "btnCancelProfile"
        btnCancelProfile.Size = New Size(180, 47)
        btnCancelProfile.TabIndex = 79
        btnCancelProfile.Text = "Cancel"
        btnCancelProfile.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "mm/dd/yyyy"
        DateTimePicker1.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(207, 213)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(258, 26)
        DateTimePicker1.TabIndex = 49
        DateTimePicker1.Value = New Date(2025, 9, 13, 1, 11, 7, 0)
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(209, 64)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(256, 30)
        TextBox5.TabIndex = 20
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(130, 109)
        Label25.Name = "Label25"
        Label25.Size = New Size(71, 21)
        Label25.TabIndex = 19
        Label25.Text = "Job ID:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(209, 100)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(256, 30)
        TextBox4.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(55, 37)
        Label9.Name = "Label9"
        Label9.Size = New Size(146, 21)
        Label9.TabIndex = 17
        Label9.Text = "Department ID:"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDepartment.Location = New Point(209, 28)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(256, 30)
        txtDepartment.TabIndex = 16
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label48.Location = New Point(78, 73)
        Label48.Name = "Label48"
        Label48.Size = New Size(123, 21)
        Label48.TabIndex = 15
        Label48.Text = "Department:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 21)
        Label1.TabIndex = 15
        Label1.Text = "Years of Service:"
        ' 
        ' txtContractType
        ' 
        txtContractType.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContractType.Location = New Point(207, 245)
        txtContractType.Name = "txtContractType"
        txtContractType.Size = New Size(258, 30)
        txtContractType.TabIndex = 14
        ' 
        ' txtDateHired
        ' 
        txtDateHired.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDateHired.Location = New Point(207, 281)
        txtDateHired.Name = "txtDateHired"
        txtDateHired.Size = New Size(258, 30)
        txtDateHired.TabIndex = 13
        ' 
        ' txtEmployeeStatus
        ' 
        txtEmployeeStatus.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeStatus.Location = New Point(207, 172)
        txtEmployeeStatus.Name = "txtEmployeeStatus"
        txtEmployeeStatus.Size = New Size(258, 30)
        txtEmployeeStatus.TabIndex = 12
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJobTitle.Location = New Point(209, 136)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(256, 30)
        txtJobTitle.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(57, 254)
        Label12.Name = "Label12"
        Label12.Size = New Size(144, 21)
        Label12.TabIndex = 4
        Label12.Text = "Contract Type:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(16, 181)
        Label15.Name = "Label15"
        Label15.Size = New Size(185, 21)
        Label15.TabIndex = 3
        Label15.Text = "Employment Status:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(93, 218)
        Label20.Name = "Label20"
        Label20.Size = New Size(108, 21)
        Label20.TabIndex = 1
        Label20.Text = "Date Hired:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(115, 145)
        Label21.Name = "Label21"
        Label21.Size = New Size(86, 21)
        Label21.TabIndex = 0
        Label21.Text = "Job Title:"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(btnEditEmergencyContact)
        GroupBox5.Controls.Add(btnCancelEmergencyContact)
        GroupBox5.Controls.Add(TextBox6)
        GroupBox5.Controls.Add(btnSaveProfile)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(TextBox3)
        GroupBox5.Controls.Add(Label54)
        GroupBox5.Controls.Add(Label24)
        GroupBox5.Controls.Add(txtC1Phone)
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(txtC1Relationship)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(txtC1Name)
        GroupBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(1269, 546)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(460, 333)
        GroupBox5.TabIndex = 64
        GroupBox5.TabStop = False
        GroupBox5.Text = "Emergency Contact"
        ' 
        ' btnEditEmergencyContact
        ' 
        btnEditEmergencyContact.BackColor = SystemColors.InactiveCaption
        btnEditEmergencyContact.BackgroundImageLayout = ImageLayout.None
        btnEditEmergencyContact.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditEmergencyContact.ForeColor = Color.Black
        btnEditEmergencyContact.Location = New Point(165, 261)
        btnEditEmergencyContact.Name = "btnEditEmergencyContact"
        btnEditEmergencyContact.Size = New Size(275, 45)
        btnEditEmergencyContact.TabIndex = 81
        btnEditEmergencyContact.Text = "Edit Emergency Contact"
        btnEditEmergencyContact.UseVisualStyleBackColor = False
        ' 
        ' btnCancelEmergencyContact
        ' 
        btnCancelEmergencyContact.BackColor = SystemColors.InactiveCaption
        btnCancelEmergencyContact.BackgroundImageLayout = ImageLayout.None
        btnCancelEmergencyContact.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelEmergencyContact.ForeColor = Color.Black
        btnCancelEmergencyContact.Location = New Point(300, 264)
        btnCancelEmergencyContact.Name = "btnCancelEmergencyContact"
        btnCancelEmergencyContact.Size = New Size(140, 39)
        btnCancelEmergencyContact.TabIndex = 85
        btnCancelEmergencyContact.Text = "Cancel"
        btnCancelEmergencyContact.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(167, 195)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(273, 57)
        TextBox6.TabIndex = 77
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(47, 60)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 21)
        Label11.TabIndex = 75
        Label11.Text = "Contact ID:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(167, 51)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(273, 30)
        TextBox3.TabIndex = 76
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(76, 198)
        Label54.Name = "Label54"
        Label54.Size = New Size(85, 21)
        Label54.TabIndex = 74
        Label54.Text = "Address:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(92, 96)
        Label24.Name = "Label24"
        Label24.Size = New Size(69, 21)
        Label24.TabIndex = 68
        Label24.Text = "Name:"
        ' 
        ' txtC1Phone
        ' 
        txtC1Phone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Phone.Location = New Point(167, 159)
        txtC1Phone.Name = "txtC1Phone"
        txtC1Phone.Size = New Size(273, 30)
        txtC1Phone.TabIndex = 73
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(42, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 21)
        Label6.TabIndex = 69
        Label6.Text = "Relationship:"
        ' 
        ' txtC1Relationship
        ' 
        txtC1Relationship.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Relationship.Location = New Point(167, 123)
        txtC1Relationship.Name = "txtC1Relationship"
        txtC1Relationship.Size = New Size(273, 30)
        txtC1Relationship.TabIndex = 72
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 21)
        Label5.TabIndex = 70
        Label5.Text = "Phone Number:"
        ' 
        ' txtC1Name
        ' 
        txtC1Name.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtC1Name.Location = New Point(167, 87)
        txtC1Name.Name = "txtC1Name"
        txtC1Name.Size = New Size(273, 30)
        txtC1Name.TabIndex = 71
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
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        TextBox2.Location = New Point(115, 51)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(255, 30)
        TextBox2.TabIndex = 48
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(36, 60)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 21)
        Label10.TabIndex = 47
        Label10.Text = "User ID:"
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtPass.Location = New Point(115, 123)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(255, 30)
        txtPass.TabIndex = 45
        ' 
        ' txtUname
        ' 
        txtUname.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtUname.Location = New Point(115, 159)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(255, 30)
        txtUname.TabIndex = 44
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(16, 163)
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
        Label8.Location = New Point(11, 127)
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
        Label52.Location = New Point(16, 96)
        Label52.Name = "Label52"
        Label52.Size = New Size(94, 21)
        Label52.TabIndex = 30
        Label52.Text = "User Type:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        TextBox1.Location = New Point(154, 221)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(259, 30)
        TextBox1.TabIndex = 51
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        cmbCivilStatus.Location = New Point(572, 329)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(259, 30)
        cmbCivilStatus.TabIndex = 49
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Bold)
        dtpBirthdate.CustomFormat = "mm/dd/yyyy"
        dtpBirthdate.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        dtpBirthdate.Location = New Point(572, 225)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(259, 26)
        dtpBirthdate.TabIndex = 48
        dtpBirthdate.Value = New Date(2025, 9, 13, 1, 11, 7, 0)
        ' 
        ' cmbSex
        ' 
        cmbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSex.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        cmbSex.FormattingEnabled = True
        cmbSex.Items.AddRange(New Object() {"Female", "Male"})
        cmbSex.Location = New Point(572, 293)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(259, 30)
        cmbSex.TabIndex = 47
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtLname.Location = New Point(154, 329)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(259, 30)
        txtLname.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.8F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(40, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 21)
        Label3.TabIndex = 40
        Label3.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10.8F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(15, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 21)
        Label4.TabIndex = 38
        Label4.Text = "Middle Name:"
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtMname.Location = New Point(154, 293)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(259, 30)
        txtMname.TabIndex = 37
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 10.8F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(458, 336)
        Label13.Name = "Label13"
        Label13.Size = New Size(108, 21)
        Label13.TabIndex = 34
        Label13.Text = "Civil Status:"
        ' 
        ' txtage
        ' 
        txtage.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtage.Location = New Point(572, 257)
        txtage.Name = "txtage"
        txtage.Size = New Size(259, 30)
        txtage.TabIndex = 32
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 10.8F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(521, 302)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 21)
        Label14.TabIndex = 30
        Label14.Text = "Sex:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 10.8F)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(466, 230)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 21)
        Label17.TabIndex = 27
        Label17.Text = "Birth Date:"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Century Gothic", 10.8F)
        lblage.ForeColor = Color.Black
        lblage.Location = New Point(512, 266)
        lblage.Name = "lblage"
        lblage.Size = New Size(54, 21)
        lblage.TabIndex = 29
        lblage.Text = "Age:"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        txtFname.Location = New Point(154, 257)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(259, 30)
        txtFname.TabIndex = 24
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Font = New Font("Century Gothic", 10.8F)
        lblfname.ForeColor = Color.Black
        lblfname.Location = New Point(43, 266)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(105, 21)
        lblfname.TabIndex = 14
        lblfname.Text = "First Name:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 10.8F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(21, 230)
        Label18.Name = "Label18"
        Label18.Size = New Size(127, 21)
        Label18.TabIndex = 13
        Label18.Text = "Employee ID:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(1020, 293)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(310, 66)
        TextBox7.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(1019, 257)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(310, 30)
        txtEmail.TabIndex = 13
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(1020, 221)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(308, 30)
        txtPhone.TabIndex = 12
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(928, 296)
        Label19.Name = "Label19"
        Label19.Size = New Size(85, 21)
        Label19.TabIndex = 4
        Label19.Text = "Address:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(867, 230)
        Label22.Name = "Label22"
        Label22.Size = New Size(147, 21)
        Label22.TabIndex = 3
        Label22.Text = "Phone Number:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(878, 266)
        Label23.Name = "Label23"
        Label23.Size = New Size(135, 21)
        Label23.TabIndex = 1
        Label23.Text = "Email Address:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(TextBox5)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(txtDepartment)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Label48)
        GroupBox3.Controls.Add(txtJobTitle)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(txtEmployeeStatus)
        GroupBox3.Controls.Add(txtContractType)
        GroupBox3.Controls.Add(txtDateHired)
        GroupBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox3.Location = New Point(375, 546)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(491, 333)
        GroupBox3.TabIndex = 81
        GroupBox3.TabStop = False
        GroupBox3.Text = "Job Details"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvPersonalInfo)
        GroupBox4.Controls.Add(TextBox7)
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Controls.Add(btnEditProfile)
        GroupBox4.Controls.Add(Label19)
        GroupBox4.Controls.Add(btnCancelProfile)
        GroupBox4.Controls.Add(txtEmail)
        GroupBox4.Controls.Add(Label23)
        GroupBox4.Controls.Add(txtPhone)
        GroupBox4.Controls.Add(Label22)
        GroupBox4.Controls.Add(cmbCivilStatus)
        GroupBox4.Controls.Add(txtage)
        GroupBox4.Controls.Add(btnSaveEmergencyContact)
        GroupBox4.Controls.Add(dtpBirthdate)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Controls.Add(cmbSex)
        GroupBox4.Controls.Add(lblfname)
        GroupBox4.Controls.Add(txtLname)
        GroupBox4.Controls.Add(txtFname)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(lblage)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(txtMname)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox4.Location = New Point(375, 114)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1354, 426)
        GroupBox4.TabIndex = 82
        GroupBox4.TabStop = False
        GroupBox4.Text = "Personal Information"
        ' 
        ' dgvPersonalInfo
        ' 
        dgvPersonalInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPersonalInfo.Location = New Point(21, 47)
        dgvPersonalInfo.Name = "dgvPersonalInfo"
        dgvPersonalInfo.RowHeadersWidth = 51
        dgvPersonalInfo.Size = New Size(1310, 151)
        dgvPersonalInfo.TabIndex = 85
        ' 
        ' btnSaveEmergencyContact
        ' 
        btnSaveEmergencyContact.BackColor = SystemColors.InactiveCaption
        btnSaveEmergencyContact.BackgroundImageLayout = ImageLayout.None
        btnSaveEmergencyContact.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveEmergencyContact.ForeColor = Color.Black
        btnSaveEmergencyContact.Location = New Point(497, 367)
        btnSaveEmergencyContact.Name = "btnSaveEmergencyContact"
        btnSaveEmergencyContact.Size = New Size(180, 45)
        btnSaveEmergencyContact.TabIndex = 84
        btnSaveEmergencyContact.Text = "Save"
        btnSaveEmergencyContact.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnChangeUsername)
        GroupBox1.Controls.Add(btnChangePassword)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(txtUname)
        GroupBox1.Controls.Add(btnCancelPassword)
        GroupBox1.Controls.Add(btnCancelUsername)
        GroupBox1.Controls.Add(btnSavePassword)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(btnSaveUsername)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cmbUser)
        GroupBox1.Controls.Add(Label52)
        GroupBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox1.Location = New Point(872, 546)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(391, 333)
        GroupBox1.TabIndex = 83
        GroupBox1.TabStop = False
        GroupBox1.Text = "Account Details"
        ' 
        ' btnChangeUsername
        ' 
        btnChangeUsername.BackColor = SystemColors.InactiveCaption
        btnChangeUsername.BackgroundImageLayout = ImageLayout.None
        btnChangeUsername.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnChangeUsername.ForeColor = Color.Black
        btnChangeUsername.Location = New Point(102, 206)
        btnChangeUsername.Name = "btnChangeUsername"
        btnChangeUsername.Size = New Size(186, 45)
        btnChangeUsername.TabIndex = 82
        btnChangeUsername.Text = "Change Username"
        btnChangeUsername.UseVisualStyleBackColor = False
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = SystemColors.InactiveCaption
        btnChangePassword.BackgroundImageLayout = ImageLayout.None
        btnChangePassword.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnChangePassword.ForeColor = Color.Black
        btnChangePassword.Location = New Point(103, 257)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(186, 47)
        btnChangePassword.TabIndex = 81
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' btnCancelPassword
        ' 
        btnCancelPassword.BackColor = SystemColors.InactiveCaption
        btnCancelPassword.BackgroundImageLayout = ImageLayout.None
        btnCancelPassword.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelPassword.ForeColor = Color.Black
        btnCancelPassword.Location = New Point(209, 257)
        btnCancelPassword.Name = "btnCancelPassword"
        btnCancelPassword.Size = New Size(80, 33)
        btnCancelPassword.TabIndex = 87
        btnCancelPassword.Text = "Cancel"
        btnCancelPassword.UseVisualStyleBackColor = False
        ' 
        ' btnCancelUsername
        ' 
        btnCancelUsername.BackColor = SystemColors.InactiveCaption
        btnCancelUsername.BackgroundImageLayout = ImageLayout.None
        btnCancelUsername.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelUsername.ForeColor = Color.Black
        btnCancelUsername.Location = New Point(197, 206)
        btnCancelUsername.Name = "btnCancelUsername"
        btnCancelUsername.Size = New Size(92, 45)
        btnCancelUsername.TabIndex = 85
        btnCancelUsername.Text = "Cancel"
        btnCancelUsername.UseVisualStyleBackColor = False
        ' 
        ' btnSavePassword
        ' 
        btnSavePassword.BackColor = SystemColors.InactiveCaption
        btnSavePassword.BackgroundImageLayout = ImageLayout.None
        btnSavePassword.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSavePassword.ForeColor = Color.Black
        btnSavePassword.Location = New Point(103, 257)
        btnSavePassword.Name = "btnSavePassword"
        btnSavePassword.Size = New Size(92, 47)
        btnSavePassword.TabIndex = 86
        btnSavePassword.Text = "Save"
        btnSavePassword.UseVisualStyleBackColor = False
        ' 
        ' btnSaveUsername
        ' 
        btnSaveUsername.BackColor = SystemColors.InactiveCaption
        btnSaveUsername.BackgroundImageLayout = ImageLayout.None
        btnSaveUsername.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveUsername.ForeColor = Color.Black
        btnSaveUsername.Location = New Point(102, 206)
        btnSaveUsername.Name = "btnSaveUsername"
        btnSaveUsername.Size = New Size(92, 45)
        btnSaveUsername.TabIndex = 84
        btnSaveUsername.Text = "Save"
        btnSaveUsername.UseVisualStyleBackColor = False
        ' 
        ' cmbUser
        ' 
        cmbUser.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUser.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        cmbUser.FormattingEnabled = True
        cmbUser.Items.AddRange(New Object() {"Manager", "Staff"})
        cmbUser.Location = New Point(115, 87)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(255, 30)
        cmbUser.TabIndex = 46
        ' 
        ' dgvOtherInfo
        ' 
        dgvOtherInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOtherInfo.Location = New Point(375, 885)
        dgvOtherInfo.Name = "dgvOtherInfo"
        dgvOtherInfo.RowHeadersWidth = 51
        dgvOtherInfo.Size = New Size(1354, 235)
        dgvOtherInfo.TabIndex = 86
        ' 
        ' MyProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(dgvOtherInfo)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(Panel2)
        Controls.Add(GroupBox5)
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
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(dgvPersonalInfo, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvOtherInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContractType As TextBox
    Friend WithEvents txtEmployeeStatus As TextBox
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents lblfname As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtDateHired As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnCancelProfile As Button
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtC1Phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtC1Relationship As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtC1Name As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents btnCancelEmergencyContact As Button
    Friend WithEvents btnEditEmergencyContact As Button
    Friend WithEvents btnSaveEmergencyContact As Button
    Friend WithEvents btnChangeUsername As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnSaveUsername As Button
    Friend WithEvents btnCancelUsername As Button
    Friend WithEvents btnCancelPassword As Button
    Friend WithEvents btnSavePassword As Button
    Friend WithEvents dgvPersonalInfo As DataGridView
    Friend WithEvents dgvOtherInfo As DataGridView
End Class
