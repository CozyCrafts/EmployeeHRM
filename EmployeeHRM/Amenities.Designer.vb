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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        btnSignOut = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        gbAmenitiesList = New GroupBox()
        txtSearchAmenities = New TextBox()
        PictureBox1 = New PictureBox()
        dgvAmenities = New DataGridView()
        gbDetailsAmenities = New GroupBox()
        btnEditAmenity = New FontAwesome.Sharp.IconButton()
        btnDeleteAmenity = New FontAwesome.Sharp.IconButton()
        btnAddAmenity = New FontAwesome.Sharp.IconButton()
        Label10 = New Label()
        cbConditionAmenities = New ComboBox()
        txtLocationAmenities = New TextBox()
        txtNameAmenities = New TextBox()
        Label9 = New Label()
        txtDepartmentID = New TextBox()
        txtAmenitiesID = New TextBox()
        txtEmployeeID = New TextBox()
        Label6 = New Label()
        Label21 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        btnSaveAmenity = New FontAwesome.Sharp.IconButton()
        btnCancelAmenity = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        gbAmenitiesList.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAmenities, ComponentModel.ISupportInitialize).BeginInit()
        gbDetailsAmenities.SuspendLayout()
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
        adminheader_pnl.Controls.Add(btnSignOut)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 3
        ' 
        ' btnSignOut
        ' 
        btnSignOut.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnSignOut.IconColor = Color.Black
        btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSignOut.IconSize = 38
        btnSignOut.ImageAlign = ContentAlignment.MiddleLeft
        btnSignOut.Location = New Point(1252, 46)
        btnSignOut.Name = "btnSignOut"
        btnSignOut.Size = New Size(142, 54)
        btnSignOut.TabIndex = 38
        btnSignOut.Text = "Sign Out"
        btnSignOut.TextAlign = ContentAlignment.MiddleRight
        btnSignOut.UseVisualStyleBackColor = True
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
        ' gbAmenitiesList
        ' 
        gbAmenitiesList.Controls.Add(txtSearchAmenities)
        gbAmenitiesList.Controls.Add(PictureBox1)
        gbAmenitiesList.Controls.Add(dgvAmenities)
        gbAmenitiesList.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbAmenitiesList.Location = New Point(374, 424)
        gbAmenitiesList.Margin = New Padding(4, 3, 4, 3)
        gbAmenitiesList.Name = "gbAmenitiesList"
        gbAmenitiesList.Padding = New Padding(4, 3, 4, 3)
        gbAmenitiesList.Size = New Size(1358, 660)
        gbAmenitiesList.TabIndex = 67
        gbAmenitiesList.TabStop = False
        gbAmenitiesList.Text = "Amenities List"
        ' 
        ' txtSearchAmenities
        ' 
        txtSearchAmenities.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchAmenities.Location = New Point(85, 57)
        txtSearchAmenities.Margin = New Padding(4, 3, 4, 3)
        txtSearchAmenities.Name = "txtSearchAmenities"
        txtSearchAmenities.Size = New Size(256, 32)
        txtSearchAmenities.TabIndex = 90
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(18, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 103
        PictureBox1.TabStop = False
        ' 
        ' dgvAmenities
        ' 
        dgvAmenities.AllowUserToResizeColumns = False
        dgvAmenities.AllowUserToResizeRows = False
        dgvAmenities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAmenities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvAmenities.DefaultCellStyle = DataGridViewCellStyle1
        dgvAmenities.Location = New Point(34, 110)
        dgvAmenities.Margin = New Padding(4, 3, 4, 3)
        dgvAmenities.Name = "dgvAmenities"
        dgvAmenities.RowHeadersWidth = 51
        dgvAmenities.Size = New Size(1298, 525)
        dgvAmenities.TabIndex = 0
        ' 
        ' gbDetailsAmenities
        ' 
        gbDetailsAmenities.Controls.Add(btnEditAmenity)
        gbDetailsAmenities.Controls.Add(btnDeleteAmenity)
        gbDetailsAmenities.Controls.Add(btnAddAmenity)
        gbDetailsAmenities.Controls.Add(Label10)
        gbDetailsAmenities.Controls.Add(cbConditionAmenities)
        gbDetailsAmenities.Controls.Add(txtLocationAmenities)
        gbDetailsAmenities.Controls.Add(txtNameAmenities)
        gbDetailsAmenities.Controls.Add(Label9)
        gbDetailsAmenities.Controls.Add(txtDepartmentID)
        gbDetailsAmenities.Controls.Add(txtAmenitiesID)
        gbDetailsAmenities.Controls.Add(txtEmployeeID)
        gbDetailsAmenities.Controls.Add(Label6)
        gbDetailsAmenities.Controls.Add(Label21)
        gbDetailsAmenities.Controls.Add(Label1)
        gbDetailsAmenities.Controls.Add(Label5)
        gbDetailsAmenities.Controls.Add(btnSaveAmenity)
        gbDetailsAmenities.Controls.Add(btnCancelAmenity)
        gbDetailsAmenities.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDetailsAmenities.Location = New Point(374, 114)
        gbDetailsAmenities.Margin = New Padding(4, 3, 4, 3)
        gbDetailsAmenities.Name = "gbDetailsAmenities"
        gbDetailsAmenities.Padding = New Padding(4, 3, 4, 3)
        gbDetailsAmenities.Size = New Size(1358, 297)
        gbDetailsAmenities.TabIndex = 82
        gbDetailsAmenities.TabStop = False
        gbDetailsAmenities.Text = "Details"
        ' 
        ' btnEditAmenity
        ' 
        btnEditAmenity.BackColor = SystemColors.InactiveCaption
        btnEditAmenity.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnEditAmenity.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditAmenity.IconColor = Color.Black
        btnEditAmenity.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditAmenity.IconSize = 40
        btnEditAmenity.ImageAlign = ContentAlignment.MiddleLeft
        btnEditAmenity.Location = New Point(1024, 118)
        btnEditAmenity.Name = "btnEditAmenity"
        btnEditAmenity.Size = New Size(250, 57)
        btnEditAmenity.TabIndex = 91
        btnEditAmenity.Text = "Edit Amenity"
        btnEditAmenity.TextAlign = ContentAlignment.MiddleRight
        btnEditAmenity.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAmenity
        ' 
        btnDeleteAmenity.BackColor = SystemColors.InactiveCaption
        btnDeleteAmenity.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnDeleteAmenity.IconChar = FontAwesome.Sharp.IconChar.Trash
        btnDeleteAmenity.IconColor = Color.Black
        btnDeleteAmenity.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDeleteAmenity.IconSize = 35
        btnDeleteAmenity.ImageAlign = ContentAlignment.MiddleLeft
        btnDeleteAmenity.Location = New Point(1024, 191)
        btnDeleteAmenity.Name = "btnDeleteAmenity"
        btnDeleteAmenity.Size = New Size(250, 57)
        btnDeleteAmenity.TabIndex = 106
        btnDeleteAmenity.Text = "Delete Amenity"
        btnDeleteAmenity.TextAlign = ContentAlignment.MiddleRight
        btnDeleteAmenity.UseVisualStyleBackColor = False
        ' 
        ' btnAddAmenity
        ' 
        btnAddAmenity.BackColor = SystemColors.InactiveCaption
        btnAddAmenity.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnAddAmenity.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        btnAddAmenity.IconColor = Color.Black
        btnAddAmenity.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddAmenity.IconSize = 35
        btnAddAmenity.ImageAlign = ContentAlignment.MiddleLeft
        btnAddAmenity.Location = New Point(1024, 54)
        btnAddAmenity.Name = "btnAddAmenity"
        btnAddAmenity.Size = New Size(250, 58)
        btnAddAmenity.TabIndex = 88
        btnAddAmenity.Text = "Add Amenity"
        btnAddAmenity.TextAlign = ContentAlignment.MiddleRight
        btnAddAmenity.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(577, 115)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(121, 25)
        Label10.TabIndex = 85
        Label10.Text = "Condition:"
        ' 
        ' cbConditionAmenities
        ' 
        cbConditionAmenities.FormattingEnabled = True
        cbConditionAmenities.Location = New Point(705, 105)
        cbConditionAmenities.Name = "cbConditionAmenities"
        cbConditionAmenities.Size = New Size(256, 35)
        cbConditionAmenities.TabIndex = 84
        ' 
        ' txtLocationAmenities
        ' 
        txtLocationAmenities.Location = New Point(205, 212)
        txtLocationAmenities.Margin = New Padding(4, 3, 4, 3)
        txtLocationAmenities.Name = "txtLocationAmenities"
        txtLocationAmenities.Size = New Size(757, 36)
        txtLocationAmenities.TabIndex = 83
        ' 
        ' txtNameAmenities
        ' 
        txtNameAmenities.Location = New Point(205, 157)
        txtNameAmenities.Margin = New Padding(4, 3, 4, 3)
        txtNameAmenities.Name = "txtNameAmenities"
        txtNameAmenities.Size = New Size(757, 36)
        txtNameAmenities.TabIndex = 82
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(87, 221)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 25)
        Label9.TabIndex = 81
        Label9.Text = "Location:"
        ' 
        ' txtDepartmentID
        ' 
        txtDepartmentID.Location = New Point(706, 54)
        txtDepartmentID.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentID.Name = "txtDepartmentID"
        txtDepartmentID.Size = New Size(256, 36)
        txtDepartmentID.TabIndex = 72
        ' 
        ' txtAmenitiesID
        ' 
        txtAmenitiesID.Location = New Point(205, 104)
        txtAmenitiesID.Margin = New Padding(4, 3, 4, 3)
        txtAmenitiesID.Name = "txtAmenitiesID"
        txtAmenitiesID.Size = New Size(256, 36)
        txtAmenitiesID.TabIndex = 80
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(205, 54)
        txtEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(256, 36)
        txtEmployeeID.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(46, 115)
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
        Label21.Location = New Point(36, 63)
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
        Label1.Location = New Point(520, 58)
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
        Label5.Location = New Point(112, 168)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 74
        Label5.Text = "Name:"
        ' 
        ' btnSaveAmenity
        ' 
        btnSaveAmenity.BackColor = SystemColors.InactiveCaption
        btnSaveAmenity.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        btnSaveAmenity.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveAmenity.IconColor = Color.Black
        btnSaveAmenity.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveAmenity.IconSize = 35
        btnSaveAmenity.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveAmenity.Location = New Point(1024, 87)
        btnSaveAmenity.Name = "btnSaveAmenity"
        btnSaveAmenity.Size = New Size(250, 57)
        btnSaveAmenity.TabIndex = 104
        btnSaveAmenity.Text = "Save"
        btnSaveAmenity.TextAlign = ContentAlignment.MiddleRight
        btnSaveAmenity.UseVisualStyleBackColor = False
        ' 
        ' btnCancelAmenity
        ' 
        btnCancelAmenity.BackColor = SystemColors.InactiveCaption
        btnCancelAmenity.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        btnCancelAmenity.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelAmenity.IconColor = Color.Black
        btnCancelAmenity.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelAmenity.IconSize = 35
        btnCancelAmenity.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelAmenity.Location = New Point(1024, 150)
        btnCancelAmenity.Name = "btnCancelAmenity"
        btnCancelAmenity.Size = New Size(250, 57)
        btnCancelAmenity.TabIndex = 105
        btnCancelAmenity.Text = "Cancel"
        btnCancelAmenity.TextAlign = ContentAlignment.MiddleRight
        btnCancelAmenity.UseVisualStyleBackColor = False
        ' 
        ' Amenities
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(gbDetailsAmenities)
        Controls.Add(gbAmenitiesList)
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
        gbAmenitiesList.ResumeLayout(False)
        gbAmenitiesList.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAmenities, ComponentModel.ISupportInitialize).EndInit()
        gbDetailsAmenities.ResumeLayout(False)
        gbDetailsAmenities.PerformLayout()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents gbAmenitiesList As GroupBox
    Friend WithEvents dgvAmenities As DataGridView
    Friend WithEvents gbDetailsAmenities As GroupBox
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtAmenitiesID As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLocationAmenities As TextBox
    Friend WithEvents txtNameAmenities As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbConditionAmenities As ComboBox
    Friend WithEvents txtSearchAmenities As TextBox

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddAmenity As FontAwesome.Sharp.IconButton

    Friend WithEvents btnEditAmenity As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelAmenity As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveAmenity As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteAmenity As FontAwesome.Sharp.IconButton
End Class
