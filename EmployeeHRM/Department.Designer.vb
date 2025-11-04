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
        gbDepartmentRecords = New GroupBox()
        dgvDepartmentRecords = New DataGridView()
        gbDepartmentDetails = New GroupBox()
        txtDepartmentDescription = New TextBox()
        btnRefreshDepartment = New Button()
        btnDeleteDepartment = New Button()
        btnClearDepartment = New Button()
        btnEditDepartment = New Button()
        btnAddDepartment = New Button()
        txtDepartmentName = New TextBox()
        Label9 = New Label()
        txtEmployeeName = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        txtDepartmentID = New TextBox()
        txtEmployeeID = New TextBox()
        Label21 = New Label()
        Label1 = New Label()
        btnSaveDepartment = New Button()
        txtSearchDepartment = New TextBox()
        btnSearchDepartment = New Button()
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        gbDepartmentRecords.SuspendLayout()
        CType(dgvDepartmentRecords, ComponentModel.ISupportInitialize).BeginInit()
        gbDepartmentDetails.SuspendLayout()
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
        Label2.Size = New Size(205, 34)
        Label2.TabIndex = 0
        Label2.Text = "Department"
        ' 
        ' gbDepartmentRecords
        ' 
        gbDepartmentRecords.Controls.Add(txtSearchDepartment)
        gbDepartmentRecords.Controls.Add(btnSearchDepartment)
        gbDepartmentRecords.Controls.Add(dgvDepartmentRecords)
        gbDepartmentRecords.Font = New Font("Century Gothic", 14.0F, FontStyle.Bold)
        gbDepartmentRecords.Location = New Point(391, 494)
        gbDepartmentRecords.Margin = New Padding(4, 3, 4, 3)
        gbDepartmentRecords.Name = "gbDepartmentRecords"
        gbDepartmentRecords.Padding = New Padding(4, 3, 4, 3)
        gbDepartmentRecords.Size = New Size(1338, 500)
        gbDepartmentRecords.TabIndex = 87
        gbDepartmentRecords.TabStop = False
        gbDepartmentRecords.Text = "Department Records"
        ' 
        ' dgvDepartmentRecords
        ' 
        dgvDepartmentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDepartmentRecords.Location = New Point(28, 105)
        dgvDepartmentRecords.Margin = New Padding(4, 3, 4, 3)
        dgvDepartmentRecords.Name = "dgvDepartmentRecords"
        dgvDepartmentRecords.RowHeadersWidth = 51
        dgvDepartmentRecords.Size = New Size(1290, 363)
        dgvDepartmentRecords.TabIndex = 0
        ' 
        ' gbDepartmentDetails
        ' 
        gbDepartmentDetails.Controls.Add(txtDepartmentDescription)
        gbDepartmentDetails.Controls.Add(btnRefreshDepartment)
        gbDepartmentDetails.Controls.Add(btnDeleteDepartment)
        gbDepartmentDetails.Controls.Add(btnClearDepartment)
        gbDepartmentDetails.Controls.Add(btnEditDepartment)
        gbDepartmentDetails.Controls.Add(btnAddDepartment)
        gbDepartmentDetails.Controls.Add(txtDepartmentName)
        gbDepartmentDetails.Controls.Add(Label9)
        gbDepartmentDetails.Controls.Add(txtEmployeeName)
        gbDepartmentDetails.Controls.Add(Label11)
        gbDepartmentDetails.Controls.Add(Label10)
        gbDepartmentDetails.Controls.Add(txtDepartmentID)
        gbDepartmentDetails.Controls.Add(txtEmployeeID)
        gbDepartmentDetails.Controls.Add(Label21)
        gbDepartmentDetails.Controls.Add(Label1)
        gbDepartmentDetails.Controls.Add(btnSaveDepartment)
        gbDepartmentDetails.Cursor = Cursors.PanNE
        gbDepartmentDetails.Font = New Font("Century Gothic", 14.0F, FontStyle.Bold)
        gbDepartmentDetails.Location = New Point(391, 125)
        gbDepartmentDetails.Margin = New Padding(4, 3, 4, 3)
        gbDepartmentDetails.Name = "gbDepartmentDetails"
        gbDepartmentDetails.Padding = New Padding(4, 3, 4, 3)
        gbDepartmentDetails.Size = New Size(1338, 338)
        gbDepartmentDetails.TabIndex = 86
        gbDepartmentDetails.TabStop = False
        gbDepartmentDetails.Text = "Details"
        ' 
        ' txtDepartmentDescription
        ' 
        txtDepartmentDescription.Location = New Point(211, 167)
        txtDepartmentDescription.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentDescription.Multiline = True
        txtDepartmentDescription.Name = "txtDepartmentDescription"
        txtDepartmentDescription.Size = New Size(780, 83)
        txtDepartmentDescription.TabIndex = 118
        ' 
        ' btnRefreshDepartment
        ' 
        btnRefreshDepartment.BackColor = SystemColors.InactiveCaption
        btnRefreshDepartment.BackgroundImageLayout = ImageLayout.None
        btnRefreshDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnRefreshDepartment.ForeColor = Color.Black
        btnRefreshDepartment.Location = New Point(1016, 187)
        btnRefreshDepartment.Name = "btnRefreshDepartment"
        btnRefreshDepartment.Size = New Size(281, 46)
        btnRefreshDepartment.TabIndex = 117
        btnRefreshDepartment.Text = "Refresh"
        btnRefreshDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteDepartment
        ' 
        btnDeleteDepartment.BackColor = SystemColors.InactiveCaption
        btnDeleteDepartment.BackgroundImageLayout = ImageLayout.None
        btnDeleteDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnDeleteDepartment.ForeColor = Color.Black
        btnDeleteDepartment.Location = New Point(602, 269)
        btnDeleteDepartment.Name = "btnDeleteDepartment"
        btnDeleteDepartment.Size = New Size(281, 46)
        btnDeleteDepartment.TabIndex = 116
        btnDeleteDepartment.Text = "Delete"
        btnDeleteDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnClearDepartment
        ' 
        btnClearDepartment.BackColor = SystemColors.InactiveCaption
        btnClearDepartment.BackgroundImageLayout = ImageLayout.None
        btnClearDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnClearDepartment.ForeColor = Color.Black
        btnClearDepartment.Location = New Point(1016, 131)
        btnClearDepartment.Name = "btnClearDepartment"
        btnClearDepartment.Size = New Size(281, 46)
        btnClearDepartment.TabIndex = 115
        btnClearDepartment.Text = "Clear"
        btnClearDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnEditDepartment
        ' 
        btnEditDepartment.BackColor = SystemColors.InactiveCaption
        btnEditDepartment.BackgroundImageLayout = ImageLayout.None
        btnEditDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditDepartment.ForeColor = Color.Black
        btnEditDepartment.Location = New Point(298, 269)
        btnEditDepartment.Name = "btnEditDepartment"
        btnEditDepartment.Size = New Size(281, 46)
        btnEditDepartment.TabIndex = 113
        btnEditDepartment.Text = "Edit Department"
        btnEditDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnAddDepartment
        ' 
        btnAddDepartment.BackColor = SystemColors.InactiveCaption
        btnAddDepartment.BackgroundImageLayout = ImageLayout.None
        btnAddDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnAddDepartment.ForeColor = Color.Black
        btnAddDepartment.Location = New Point(1016, 79)
        btnAddDepartment.Name = "btnAddDepartment"
        btnAddDepartment.Size = New Size(281, 46)
        btnAddDepartment.TabIndex = 107
        btnAddDepartment.Text = "Add Department"
        btnAddDepartment.UseVisualStyleBackColor = False
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.Location = New Point(709, 109)
        txtDepartmentName.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.Size = New Size(282, 36)
        txtDepartmentName.TabIndex = 106
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.0F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(478, 120)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(223, 25)
        Label9.TabIndex = 105
        Label9.Text = "Department Name:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(707, 58)
        txtEmployeeName.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(282, 36)
        txtEmployeeName.TabIndex = 86
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(491, 67)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(208, 27)
        Label11.TabIndex = 87
        Label11.Text = "Employee Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13.0F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(70, 171)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(136, 25)
        Label10.TabIndex = 85
        Label10.Text = "Description:"
        ' 
        ' txtDepartmentID
        ' 
        txtDepartmentID.Location = New Point(214, 109)
        txtDepartmentID.Margin = New Padding(4, 3, 4, 3)
        txtDepartmentID.Name = "txtDepartmentID"
        txtDepartmentID.Size = New Size(256, 36)
        txtDepartmentID.TabIndex = 72
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(214, 58)
        txtEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(256, 36)
        txtEmployeeID.TabIndex = 23
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(45, 67)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(161, 27)
        Label21.TabIndex = 70
        Label21.Text = "Employee ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.0F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(28, 120)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 25)
        Label1.TabIndex = 71
        Label1.Text = "Department ID:"
        ' 
        ' btnSaveDepartment
        ' 
        btnSaveDepartment.BackColor = SystemColors.InactiveCaption
        btnSaveDepartment.BackgroundImageLayout = ImageLayout.None
        btnSaveDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveDepartment.ForeColor = Color.Black
        btnSaveDepartment.Location = New Point(1016, 79)
        btnSaveDepartment.Name = "btnSaveDepartment"
        btnSaveDepartment.Size = New Size(281, 46)
        btnSaveDepartment.TabIndex = 114
        btnSaveDepartment.Text = "Save"
        btnSaveDepartment.UseVisualStyleBackColor = False
        ' 
        ' txtSearchDepartment
        ' 
        txtSearchDepartment.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchDepartment.Location = New Point(202, 61)
        txtSearchDepartment.Margin = New Padding(4, 3, 4, 3)
        txtSearchDepartment.Name = "txtSearchDepartment"
        txtSearchDepartment.Size = New Size(256, 32)
        txtSearchDepartment.TabIndex = 93
        ' 
        ' btnSearchDepartment
        ' 
        btnSearchDepartment.BackColor = SystemColors.InactiveCaption
        btnSearchDepartment.BackgroundImageLayout = ImageLayout.None
        btnSearchDepartment.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSearchDepartment.ForeColor = Color.Black
        btnSearchDepartment.Location = New Point(28, 53)
        btnSearchDepartment.Name = "btnSearchDepartment"
        btnSearchDepartment.Size = New Size(167, 46)
        btnSearchDepartment.TabIndex = 92
        btnSearchDepartment.Text = "Search"
        btnSearchDepartment.UseVisualStyleBackColor = False
        ' 
        ' Department
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
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
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        gbDepartmentRecords.ResumeLayout(False)
        gbDepartmentRecords.PerformLayout()
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
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbDepartmentRecords As GroupBox
    Friend WithEvents dgvDepartmentRecords As DataGridView
    Friend WithEvents gbDepartmentDetails As GroupBox
    Friend WithEvents btnRefreshDepartment As Button
    Friend WithEvents btnDeleteDepartment As Button
    Friend WithEvents btnClearDepartment As Button
    Friend WithEvents btnSaveDepartment As Button
    Friend WithEvents btnEditDepartment As Button
    Friend WithEvents btnAddDepartment As Button
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartmentDescription As TextBox
    Friend WithEvents txtSearchDepartment As TextBox
    Friend WithEvents btnSearchDepartment As Button
End Class
