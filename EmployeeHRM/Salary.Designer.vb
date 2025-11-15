<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salary))
        adminheader_pnl = New Panel()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
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
        Label26 = New Label()
        Label27 = New Label()
        lblDashboard = New Label()
        Label51 = New Label()
        GroupBox4 = New GroupBox()
        dgvSalaryHistory = New DataGridView()
        GroupBox3 = New GroupBox()
        txtJobTitle = New TextBox()
        Label6 = New Label()
        txtNetPay = New TextBox()
        GroupBox2 = New GroupBox()
        Label24 = New Label()
        TextBox14 = New TextBox()
        Label11 = New Label()
        TextBox3 = New TextBox()
        Label12 = New Label()
        TextBox4 = New TextBox()
        Label19 = New Label()
        Label21 = New Label()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        Label22 = New Label()
        TextBox13 = New TextBox()
        txtPayrollID = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtTotalDeduction = New TextBox()
        Label10 = New Label()
        txtAbscences = New TextBox()
        Label9 = New Label()
        txtDeductionID = New TextBox()
        dtpDateApplied = New DateTimePicker()
        GroupBox6 = New GroupBox()
        txtPhilHealth = New TextBox()
        txtPagIBIG = New TextBox()
        Label39 = New Label()
        Label31 = New Label()
        txtSSS = New TextBox()
        Label35 = New Label()
        Label14 = New Label()
        txtUnpaidLeave = New TextBox()
        Label17 = New Label()
        txtAttendanceID = New TextBox()
        Label20 = New Label()
        Label3 = New Label()
        txtBasicSalary = New TextBox()
        Label29 = New Label()
        txtEmployeeID = New TextBox()
        Label4 = New Label()
        txtEmployeeName = New TextBox()
        Label5 = New Label()
        txtOvertimePay = New TextBox()
        Label25 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        txtGrossSalary = New TextBox()
        dtpPaymentDate = New DateTimePicker()
        Label23 = New Label()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvSalaryHistory, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox6.SuspendLayout()
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
        pcbTerminate.TabIndex = 2
        pcbTerminate.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 34)
        Label2.TabIndex = 0
        Label2.Text = "Salary"
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
        lblAmenities.TabIndex = 91
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
        lblTrainings.TabIndex = 90
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
        lblLeaveApproval.TabIndex = 89
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
        lblEmployeeTrainings.TabIndex = 88
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
        lblPayrollSummary.TabIndex = 87
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
        lblDepartment.TabIndex = 86
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
        lblAttendanceTracker.TabIndex = 85
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
        lblTeamOverview.TabIndex = 84
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
        Label28.TabIndex = 83
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
        lblMyProfile.TabIndex = 82
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
        lblAttendance.TabIndex = 81
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
        lblLeaveManagement.TabIndex = 80
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
        lblSalary.TabIndex = 79
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
        Label49.TabIndex = 78
        Label49.Text = "OVERVIEW"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(85, 35)
        Label26.Name = "Label26"
        Label26.Size = New Size(197, 34)
        Label26.TabIndex = 77
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
        Label27.TabIndex = 76
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
        lblDashboard.TabIndex = 71
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
        Label51.TabIndex = 70
        Label51.Text = "MAIN"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvSalaryHistory)
        GroupBox4.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox4.Location = New Point(391, 683)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1335, 327)
        GroupBox4.TabIndex = 96
        GroupBox4.TabStop = False
        GroupBox4.Text = "Salary History"
        ' 
        ' dgvSalaryHistory
        ' 
        dgvSalaryHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSalaryHistory.Location = New Point(17, 51)
        dgvSalaryHistory.Name = "dgvSalaryHistory"
        dgvSalaryHistory.RowHeadersWidth = 51
        dgvSalaryHistory.Size = New Size(1294, 253)
        dgvSalaryHistory.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtJobTitle)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(txtNetPay)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(txtPayrollID)
        GroupBox3.Controls.Add(GroupBox1)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtBasicSalary)
        GroupBox3.Controls.Add(Label29)
        GroupBox3.Controls.Add(txtEmployeeID)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(txtEmployeeName)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(txtOvertimePay)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(txtGrossSalary)
        GroupBox3.Controls.Add(dtpPaymentDate)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        GroupBox3.Location = New Point(391, 138)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1335, 543)
        GroupBox3.TabIndex = 95
        GroupBox3.TabStop = False
        GroupBox3.Text = "Payroll Computation"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJobTitle.Location = New Point(188, 145)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(335, 30)
        txtJobTitle.TabIndex = 114
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11F)
        Label6.Location = New Point(15, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 22)
        Label6.TabIndex = 113
        Label6.Text = "Job Title:"
        ' 
        ' txtNetPay
        ' 
        txtNetPay.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNetPay.Location = New Point(187, 368)
        txtNetPay.Name = "txtNetPay"
        txtNetPay.Size = New Size(335, 30)
        txtNetPay.TabIndex = 112
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label24)
        GroupBox2.Controls.Add(TextBox14)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label21)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(TextBox13)
        GroupBox2.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        GroupBox2.Location = New Point(545, 27)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(760, 192)
        GroupBox2.TabIndex = 93
        GroupBox2.TabStop = False
        GroupBox2.Text = "Salary"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 11F)
        Label24.Location = New Point(105, 59)
        Label24.Name = "Label24"
        Label24.Size = New Size(73, 22)
        Label24.TabIndex = 99
        Label24.Text = "Job ID:"
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14.Location = New Point(184, 51)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(160, 30)
        TextBox14.TabIndex = 98
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 11F)
        Label11.Location = New Point(420, 95)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 22)
        Label11.TabIndex = 97
        Label11.Text = "Daily Rate:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(534, 51)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(160, 30)
        TextBox3.TabIndex = 96
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 11F)
        Label12.Location = New Point(84, 95)
        Label12.Name = "Label12"
        Label12.Size = New Size(94, 22)
        Label12.TabIndex = 95
        Label12.Text = "Salary ID:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(184, 87)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(160, 30)
        TextBox4.TabIndex = 94
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 11F)
        Label19.Location = New Point(60, 131)
        Label19.Name = "Label19"
        Label19.Size = New Size(118, 22)
        Label19.TabIndex = 26
        Label19.Text = "Base Salary:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 11F)
        Label21.Location = New Point(368, 131)
        Label21.Name = "Label21"
        Label21.Size = New Size(160, 22)
        Label21.TabIndex = 25
        Label21.Text = "Overtome Rate:"
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(534, 125)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(160, 30)
        TextBox11.TabIndex = 12
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12.Location = New Point(534, 89)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(160, 30)
        TextBox12.TabIndex = 11
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 11F)
        Label22.Location = New Point(415, 59)
        Label22.Name = "Label22"
        Label22.Size = New Size(113, 22)
        Label22.TabIndex = 19
        Label22.Text = "Allowance:"
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox13.Location = New Point(184, 123)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(160, 30)
        TextBox13.TabIndex = 10
        ' 
        ' txtPayrollID
        ' 
        txtPayrollID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPayrollID.Location = New Point(188, 188)
        txtPayrollID.Name = "txtPayrollID"
        txtPayrollID.Size = New Size(335, 30)
        txtPayrollID.TabIndex = 103
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtTotalDeduction)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtAbscences)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtDeductionID)
        GroupBox1.Controls.Add(dtpDateApplied)
        GroupBox1.Controls.Add(GroupBox6)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(txtUnpaidLeave)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(txtAttendanceID)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        GroupBox1.Location = New Point(545, 225)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(766, 298)
        GroupBox1.TabIndex = 92
        GroupBox1.TabStop = False
        GroupBox1.Text = "Deduction"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11F)
        Label1.Location = New Point(31, 219)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 22)
        Label1.TabIndex = 113
        Label1.Text = "Total Deduction:"
        ' 
        ' txtTotalDeduction
        ' 
        txtTotalDeduction.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalDeduction.Location = New Point(197, 211)
        txtTotalDeduction.Name = "txtTotalDeduction"
        txtTotalDeduction.Size = New Size(160, 30)
        txtTotalDeduction.TabIndex = 112
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 11F)
        Label10.Location = New Point(74, 147)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 22)
        Label10.TabIndex = 97
        Label10.Text = "Abscences:"
        ' 
        ' txtAbscences
        ' 
        txtAbscences.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAbscences.Location = New Point(197, 139)
        txtAbscences.Name = "txtAbscences"
        txtAbscences.Size = New Size(160, 30)
        txtAbscences.TabIndex = 96
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 11F)
        Label9.Location = New Point(55, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 22)
        Label9.TabIndex = 95
        Label9.Text = "Deduction ID:"
        ' 
        ' txtDeductionID
        ' 
        txtDeductionID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeductionID.Location = New Point(197, 59)
        txtDeductionID.Name = "txtDeductionID"
        txtDeductionID.Size = New Size(160, 30)
        txtDeductionID.TabIndex = 94
        ' 
        ' dtpDateApplied
        ' 
        dtpDateApplied.CalendarFont = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDateApplied.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDateApplied.Format = DateTimePickerFormat.Short
        dtpDateApplied.Location = New Point(519, 67)
        dtpDateApplied.Name = "dtpDateApplied"
        dtpDateApplied.Size = New Size(218, 30)
        dtpDateApplied.TabIndex = 93
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(txtPhilHealth)
        GroupBox6.Controls.Add(txtPagIBIG)
        GroupBox6.Controls.Add(Label39)
        GroupBox6.Controls.Add(Label31)
        GroupBox6.Controls.Add(txtSSS)
        GroupBox6.Controls.Add(Label35)
        GroupBox6.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.Location = New Point(381, 99)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(356, 147)
        GroupBox6.TabIndex = 91
        GroupBox6.TabStop = False
        GroupBox6.Text = "Benefits"
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhilHealth.Location = New Point(157, 65)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.Size = New Size(169, 30)
        txtPhilHealth.TabIndex = 31
        ' 
        ' txtPagIBIG
        ' 
        txtPagIBIG.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPagIBIG.Location = New Point(157, 101)
        txtPagIBIG.Name = "txtPagIBIG"
        txtPagIBIG.Size = New Size(169, 30)
        txtPagIBIG.TabIndex = 28
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Century Gothic", 11F)
        Label39.Location = New Point(55, 108)
        Label39.Name = "Label39"
        Label39.Size = New Size(96, 22)
        Label39.TabIndex = 25
        Label39.Text = "Pag-IBIG:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Century Gothic", 11F)
        Label31.Location = New Point(47, 73)
        Label31.Name = "Label31"
        Label31.Size = New Size(104, 22)
        Label31.TabIndex = 19
        Label31.Text = "PhilHealth:"
        ' 
        ' txtSSS
        ' 
        txtSSS.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSSS.Location = New Point(157, 29)
        txtSSS.Name = "txtSSS"
        txtSSS.Size = New Size(169, 30)
        txtSSS.TabIndex = 10
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Century Gothic", 11F)
        Label35.Location = New Point(109, 37)
        Label35.Name = "Label35"
        Label35.Size = New Size(42, 22)
        Label35.TabIndex = 0
        Label35.Text = "SSS:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 11F)
        Label14.Location = New Point(46, 183)
        Label14.Name = "Label14"
        Label14.Size = New Size(145, 22)
        Label14.TabIndex = 25
        Label14.Text = "Unpaid Leave:"
        ' 
        ' txtUnpaidLeave
        ' 
        txtUnpaidLeave.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUnpaidLeave.Location = New Point(197, 175)
        txtUnpaidLeave.Name = "txtUnpaidLeave"
        txtUnpaidLeave.Size = New Size(160, 30)
        txtUnpaidLeave.TabIndex = 11
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 11F)
        Label17.Location = New Point(37, 107)
        Label17.Name = "Label17"
        Label17.Size = New Size(154, 22)
        Label17.TabIndex = 19
        Label17.Text = "Attendance ID:"
        ' 
        ' txtAttendanceID
        ' 
        txtAttendanceID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAttendanceID.Location = New Point(197, 99)
        txtAttendanceID.Name = "txtAttendanceID"
        txtAttendanceID.Size = New Size(160, 30)
        txtAttendanceID.TabIndex = 10
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 11F)
        Label20.Location = New Point(381, 70)
        Label20.Name = "Label20"
        Label20.Size = New Size(138, 22)
        Label20.TabIndex = 0
        Label20.Text = "Date Applied:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11F)
        Label3.Location = New Point(84, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 22)
        Label3.TabIndex = 102
        Label3.Text = "Payroll ID:"
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBasicSalary.Location = New Point(188, 233)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.Size = New Size(335, 30)
        txtBasicSalary.TabIndex = 101
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century Gothic", 11F)
        Label29.Location = New Point(40, 286)
        Label29.Name = "Label29"
        Label29.Size = New Size(142, 22)
        Label29.TabIndex = 100
        Label29.Text = "Overtime Pay:"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeID.Location = New Point(188, 49)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(335, 30)
        txtEmployeeID.TabIndex = 99
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11F)
        Label4.Location = New Point(53, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 22)
        Label4.TabIndex = 98
        Label4.Text = "Employee ID:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeName.Location = New Point(188, 101)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(335, 30)
        txtEmployeeName.TabIndex = 97
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11F)
        Label5.Location = New Point(16, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 22)
        Label5.TabIndex = 96
        Label5.Text = "Employee Name:"
        ' 
        ' txtOvertimePay
        ' 
        txtOvertimePay.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOvertimePay.Location = New Point(188, 278)
        txtOvertimePay.Name = "txtOvertimePay"
        txtOvertimePay.Size = New Size(335, 30)
        txtOvertimePay.TabIndex = 95
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 11F)
        Label25.Location = New Point(61, 241)
        Label25.Name = "Label25"
        Label25.Size = New Size(121, 22)
        Label25.TabIndex = 94
        Label25.Text = "Basic Salary:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 11F)
        Label15.Location = New Point(93, 375)
        Label15.Name = "Label15"
        Label15.Size = New Size(88, 22)
        Label15.TabIndex = 25
        Label15.Text = "Net Pay:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 11F)
        Label16.Location = New Point(58, 328)
        Label16.Name = "Label16"
        Label16.Size = New Size(124, 22)
        Label16.TabIndex = 19
        Label16.Text = "Gross Salary:"
        ' 
        ' txtGrossSalary
        ' 
        txtGrossSalary.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGrossSalary.Location = New Point(188, 323)
        txtGrossSalary.Name = "txtGrossSalary"
        txtGrossSalary.Size = New Size(335, 30)
        txtGrossSalary.TabIndex = 10
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.CalendarFont = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpPaymentDate.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpPaymentDate.Location = New Point(187, 413)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(335, 30)
        dtpPaymentDate.TabIndex = 93
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 11F)
        Label23.Location = New Point(32, 421)
        Label23.Name = "Label23"
        Label23.Size = New Size(149, 22)
        Label23.TabIndex = 0
        Label23.Text = "Payment Date:"
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(Panel2)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Payroll"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(dgvSalaryHistory, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label51 As Label
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
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvSalaryHistory As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents txtPayrollID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAbscences As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDeductionID As TextBox
    Friend WithEvents dtpDateApplied As DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtPagIBIG As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUnpaidLeave As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOvertimePay As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label6 As Label
End Class
