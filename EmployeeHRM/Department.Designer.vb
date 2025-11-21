<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Department))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnSignOut = New FontAwesome.Sharp.IconButton()
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
        Label2 = New Label()
        gbDepartmentRecords = New GroupBox()
        txtSearchDepartment = New TextBox()
        PictureBox1 = New PictureBox()
        dgvDepartmentRecords = New DataGridView()
        gbDepartmentDetails = New GroupBox()
        btnDeleteDepartment = New FontAwesome.Sharp.IconButton()
        btnAddDepartment = New FontAwesome.Sharp.IconButton()
        btnEditDepartment = New FontAwesome.Sharp.IconButton()
        btnCancelDepartment = New FontAwesome.Sharp.IconButton()
        txtDepartmentDescription = New TextBox()
        txtDepartmentName = New TextBox()
        btnSaveDepartment = New FontAwesome.Sharp.IconButton()
        Label9 = New Label()
        Label10 = New Label()
        txtDepartmentID = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        gbDepartmentRecords.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDepartmentRecords, ComponentModel.ISupportInitialize).BeginInit()
        gbDepartmentDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(btnSignOut)
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
        ' btnSignOut
        ' 
        btnSignOut.BackColor = Color.SteelBlue
        btnSignOut.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignOut.ForeColor = Color.White
        btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnSignOut.IconColor = Color.White
        btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSignOut.IconSize = 38
        btnSignOut.ImageAlign = ContentAlignment.MiddleLeft
        btnSignOut.Location = New Point(30, 1080)
        btnSignOut.Name = "btnSignOut"
        btnSignOut.Size = New Size(308, 54)
        btnSignOut.TabIndex = 80
        btnSignOut.Text = "Sign Out"
        btnSignOut.TextAlign = ContentAlignment.MiddleRight
        btnSignOut.UseVisualStyleBackColor = False
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
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(338, -17)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(72, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 34)
        Label2.TabIndex = 0
        Label2.Text = "Department"
        ' 
        ' gbDepartmentRecords
        ' 
        gbDepartmentRecords.Controls.Add(txtSearchDepartment)
        gbDepartmentRecords.Controls.Add(PictureBox1)
        gbDepartmentRecords.Controls.Add(dgvDepartmentRecords)
        gbDepartmentRecords.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDepartmentRecords.Location = New Point(410, 494)
        gbDepartmentRecords.Margin = New Padding(4, 3, 4, 3)
        gbDepartmentRecords.Name = "gbDepartmentRecords"
        gbDepartmentRecords.Padding = New Padding(4, 3, 4, 3)
        gbDepartmentRecords.Size = New Size(1319, 620)
        gbDepartmentRecords.TabIndex = 87
        gbDepartmentRecords.TabStop = False
        gbDepartmentRecords.Text = "Department Records"
        ' 
        ' txtSearchDepartment
        ' 
        txtSearchDepartment.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchDepartment.Location = New Point(94, 67)
        txtSearchDepartment.Margin = New Padding(4, 3, 4, 3)
        txtSearchDepartment.Name = "txtSearchDepartment"
        txtSearchDepartment.Size = New Size(256, 32)
        txtSearchDepartment.TabIndex = 93
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(28, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 48)
        PictureBox1.TabIndex = 103
        PictureBox1.TabStop = False
        ' 
        ' dgvDepartmentRecords
        ' 
        dgvDepartmentRecords.AllowUserToResizeColumns = False
        dgvDepartmentRecords.AllowUserToResizeRows = False
        dgvDepartmentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDepartmentRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDepartmentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvDepartmentRecords.DefaultCellStyle = DataGridViewCellStyle2
        dgvDepartmentRecords.Location = New Point(40, 105)
        dgvDepartmentRecords.Margin = New Padding(4, 3, 4, 3)
        dgvDepartmentRecords.Name = "dgvDepartmentRecords"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDepartmentRecords.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvDepartmentRecords.RowHeadersWidth = 51
        dgvDepartmentRecords.Size = New Size(1254, 486)
        dgvDepartmentRecords.TabIndex = 0
        ' 
        ' gbDepartmentDetails
        ' 
        gbDepartmentDetails.Controls.Add(btnDeleteDepartment)
        gbDepartmentDetails.Controls.Add(btnAddDepartment)
        gbDepartmentDetails.Controls.Add(btnEditDepartment)
        gbDepartmentDetails.Controls.Add(btnCancelDepartment)
        gbDepartmentDetails.Controls.Add(txtDepartmentDescription)
        gbDepartmentDetails.Controls.Add(txtDepartmentName)
        gbDepartmentDetails.Controls.Add(btnSaveDepartment)
        gbDepartmentDetails.Controls.Add(Label9)
        gbDepartmentDetails.Controls.Add(Label10)
        gbDepartmentDetails.Controls.Add(txtDepartmentID)
        gbDepartmentDetails.Controls.Add(Label1)
        gbDepartmentDetails.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        gbDepartmentDetails.Location = New Point(410, 146)
        gbDepartmentDetails.Margin = New Padding(4, 3, 4, 3)
        gbDepartmentDetails.Name = "gbDepartmentDetails"
        gbDepartmentDetails.Padding = New Padding(4, 3, 4, 3)
        gbDepartmentDetails.Size = New Size(1319, 317)
        gbDepartmentDetails.TabIndex = 86
        gbDepartmentDetails.TabStop = False
        gbDepartmentDetails.Text = "Details"
        ' 
        ' btnDeleteDepartment
        ' 
        btnDeleteDepartment.BackColor = SystemColors.InactiveCaption
        btnDeleteDepartment.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnDeleteDepartment.IconChar = FontAwesome.Sharp.IconChar.Trash
        btnDeleteDepartment.IconColor = Color.Black
        btnDeleteDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDeleteDepartment.IconSize = 35
        btnDeleteDepartment.ImageAlign = ContentAlignment.MiddleLeft
        btnDeleteDepartment.Location = New Point(1044, 211)
        btnDeleteDepartment.Name = "btnDeleteDepartment"
        btnDeleteDepartment.Size = New Size(250, 57)
        btnDeleteDepartment.TabIndex = 111
        btnDeleteDepartment.Text = "Delete Amenity"
        btnDeleteDepartment.TextAlign = ContentAlignment.MiddleRight
        btnDeleteDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnAddDepartment
        ' 
        btnAddDepartment.BackColor = SystemColors.InactiveCaption
        btnAddDepartment.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnAddDepartment.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        btnAddDepartment.IconColor = Color.Black
        btnAddDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddDepartment.IconSize = 35
        btnAddDepartment.ImageAlign = ContentAlignment.MiddleLeft
        btnAddDepartment.Location = New Point(1044, 78)
        btnAddDepartment.Name = "btnAddDepartment"
        btnAddDepartment.Size = New Size(250, 58)
        btnAddDepartment.TabIndex = 107
        btnAddDepartment.Text = "Add Amenity"
        btnAddDepartment.TextAlign = ContentAlignment.MiddleRight
        btnAddDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnEditDepartment
        ' 
        btnEditDepartment.BackColor = SystemColors.InactiveCaption
        btnEditDepartment.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnEditDepartment.IconChar = FontAwesome.Sharp.IconChar.Edit
        btnEditDepartment.IconColor = Color.Black
        btnEditDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEditDepartment.IconSize = 35
        btnEditDepartment.ImageAlign = ContentAlignment.MiddleLeft
        btnEditDepartment.Location = New Point(1044, 145)
        btnEditDepartment.Name = "btnEditDepartment"
        btnEditDepartment.Size = New Size(250, 57)
        btnEditDepartment.TabIndex = 108
        btnEditDepartment.Text = "Edit Amenity"
        btnEditDepartment.TextAlign = ContentAlignment.MiddleRight
        btnEditDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnCancelDepartment
        ' 
        btnCancelDepartment.BackColor = SystemColors.InactiveCaption
        btnCancelDepartment.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        btnCancelDepartment.IconChar = FontAwesome.Sharp.IconChar.Cancel
        btnCancelDepartment.IconColor = Color.Black
        btnCancelDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCancelDepartment.IconSize = 35
        btnCancelDepartment.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelDepartment.Location = New Point(1044, 173)
        btnCancelDepartment.Name = "btnCancelDepartment"
        btnCancelDepartment.Size = New Size(250, 57)
        btnCancelDepartment.TabIndex = 110
        btnCancelDepartment.Text = "Cancel"
        btnCancelDepartment.TextAlign = ContentAlignment.MiddleRight
        btnCancelDepartment.UseVisualStyleBackColor = False
        ' 
        ' txtDepartmentDescription
        ' 
        txtDepartmentDescription.Location = New Point(227, 158)
        txtDepartmentDescription.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentDescription.Multiline = True
        txtDepartmentDescription.Name = "txtDepartmentDescription"
        txtDepartmentDescription.Size = New Size(780, 83)
        txtDepartmentDescription.TabIndex = 118
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.Location = New Point(725, 100)
        txtDepartmentName.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.Size = New Size(282, 36)
        txtDepartmentName.TabIndex = 106
        ' 
        ' btnSaveDepartment
        ' 
        btnSaveDepartment.BackColor = SystemColors.InactiveCaption
        btnSaveDepartment.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        btnSaveDepartment.IconChar = FontAwesome.Sharp.IconChar.Save
        btnSaveDepartment.IconColor = Color.Black
        btnSaveDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSaveDepartment.IconSize = 35
        btnSaveDepartment.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveDepartment.Location = New Point(1044, 118)
        btnSaveDepartment.Name = "btnSaveDepartment"
        btnSaveDepartment.Size = New Size(250, 57)
        btnSaveDepartment.TabIndex = 109
        btnSaveDepartment.Text = "Save"
        btnSaveDepartment.TextAlign = ContentAlignment.MiddleRight
        btnSaveDepartment.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(494, 111)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(223, 25)
        Label9.TabIndex = 105
        Label9.Text = "Department Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(86, 162)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(136, 25)
        Label10.TabIndex = 85
        Label10.Text = "Description:"
        ' 
        ' txtDepartmentID
        ' 
        txtDepartmentID.Location = New Point(230, 100)
        txtDepartmentID.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentID.Name = "txtDepartmentID"
        txtDepartmentID.Size = New Size(256, 36)
        txtDepartmentID.TabIndex = 72
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(44, 111)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 25)
        Label1.TabIndex = 71
        Label1.Text = "Department ID:"
        ' 
        ' Department
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(gbDepartmentRecords)
        Controls.Add(gbDepartmentDetails)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Department"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Department"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        gbDepartmentRecords.ResumeLayout(False)
        gbDepartmentRecords.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDepartmentRecords, ComponentModel.ISupportInitialize).EndInit()
        gbDepartmentDetails.ResumeLayout(False)
        gbDepartmentDetails.PerformLayout()
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
    Friend WithEvents gbDepartmentRecords As GroupBox
    Friend WithEvents dgvDepartmentRecords As DataGridView
    Friend WithEvents gbDepartmentDetails As GroupBox
    Friend WithEvents btnRefreshDepartment As Button
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartmentDescription As TextBox
    Friend WithEvents txtSearchDepartment As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDeleteDepartment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddDepartment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditDepartment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancelDepartment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveDepartment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSignOut As FontAwesome.Sharp.IconButton
End Class
