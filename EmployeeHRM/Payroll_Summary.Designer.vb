<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll_Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll_Summary))
        adminheader_pnl = New Panel()
        pcbTerminate = New PictureBox()
        Label2 = New Label()
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
        GroupBox6 = New GroupBox()
        txtPhilHealth = New TextBox()
        txtPagIBIG = New TextBox()
        Label39 = New Label()
        Label31 = New Label()
        txtSSS = New TextBox()
        Label35 = New Label()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtTotalDeduction = New TextBox()
        Button6 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label10 = New Label()
        txtAbscences = New TextBox()
        Label9 = New Label()
        txtDeductionID = New TextBox()
        dtpDateApplied = New DateTimePicker()
        Label14 = New Label()
        txtUnpaidLeave = New TextBox()
        Label17 = New Label()
        txtAttendanceID = New TextBox()
        Label20 = New Label()
        Button3 = New Button()
        Label23 = New Label()
        TextBox13 = New TextBox()
        Label22 = New Label()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        Label21 = New Label()
        Label19 = New Label()
        GroupBox3 = New GroupBox()
        btnEditPayroll = New Button()
        btnComputePayroll = New Button()
        btnAddPayroll = New Button()
        btnCancelPayroll = New Button()
        GroupBox2 = New GroupBox()
        btnEditSalary = New Button()
        btnCancelSalary = New Button()
        btnAddSalary = New Button()
        Label24 = New Label()
        TextBox14 = New TextBox()
        Label11 = New Label()
        TextBox3 = New TextBox()
        Label12 = New Label()
        TextBox4 = New TextBox()
        btnSaveSalary = New Button()
        btnSavePayroll = New Button()
        txtPayrollID = New TextBox()
        Label28 = New Label()
        txtBasicSalary = New TextBox()
        Label29 = New Label()
        txtEmployeeID = New TextBox()
        Label26 = New Label()
        txtEmployeeName = New TextBox()
        Label27 = New Label()
        txtOvertimePay = New TextBox()
        Label25 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        txtGrossSalary = New TextBox()
        dtpPaymentDate = New DateTimePicker()
        GroupBox4 = New GroupBox()
        btnRefreshPayroll = New Button()
        txtSearchPayroll = New TextBox()
        btnSearchPayroll = New Button()
        dgvPayrollSummary = New DataGridView()
        txtNetPay = New TextBox()
        adminheader_pnl.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvPayrollSummary, ComponentModel.ISupportInitialize).BeginInit()
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
        adminheader_pnl.TabIndex = 4
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
        Label2.Size = New Size(287, 34)
        Label2.TabIndex = 0
        Label2.Text = "Payroll Summary"
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
        Panel1.TabIndex = 5
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
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(txtPhilHealth)
        GroupBox6.Controls.Add(txtPagIBIG)
        GroupBox6.Controls.Add(Label39)
        GroupBox6.Controls.Add(Label31)
        GroupBox6.Controls.Add(txtSSS)
        GroupBox6.Controls.Add(Label35)
        GroupBox6.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.Location = New Point(372, 21)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(378, 132)
        GroupBox6.TabIndex = 91
        GroupBox6.TabStop = False
        GroupBox6.Text = "Benefits"
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhilHealth.Location = New Point(157, 58)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.Size = New Size(169, 30)
        txtPhilHealth.TabIndex = 31
        ' 
        ' txtPagIBIG
        ' 
        txtPagIBIG.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPagIBIG.Location = New Point(157, 94)
        txtPagIBIG.Name = "txtPagIBIG"
        txtPagIBIG.Size = New Size(169, 30)
        txtPagIBIG.TabIndex = 28
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Century Gothic", 11.0F)
        Label39.Location = New Point(55, 101)
        Label39.Name = "Label39"
        Label39.Size = New Size(96, 22)
        Label39.TabIndex = 25
        Label39.Text = "Pag-IBIG:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Century Gothic", 11.0F)
        Label31.Location = New Point(47, 66)
        Label31.Name = "Label31"
        Label31.Size = New Size(104, 22)
        Label31.TabIndex = 19
        Label31.Text = "PhilHealth:"
        ' 
        ' txtSSS
        ' 
        txtSSS.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSSS.Location = New Point(157, 22)
        txtSSS.Name = "txtSSS"
        txtSSS.Size = New Size(169, 30)
        txtSSS.TabIndex = 10
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Century Gothic", 11.0F)
        Label35.Location = New Point(109, 30)
        Label35.Name = "Label35"
        Label35.Size = New Size(42, 22)
        Label35.TabIndex = 0
        Label35.Text = "SSS:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtTotalDeduction)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button5)
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
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
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
        Label1.Font = New Font("Century Gothic", 11.0F)
        Label1.Location = New Point(13, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 22)
        Label1.TabIndex = 113
        Label1.Text = "Total Deduction:"
        ' 
        ' txtTotalDeduction
        ' 
        txtTotalDeduction.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalDeduction.Location = New Point(179, 200)
        txtTotalDeduction.Name = "txtTotalDeduction"
        txtTotalDeduction.Size = New Size(160, 30)
        txtTotalDeduction.TabIndex = 112
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.InactiveCaption
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button6.ForeColor = Color.Black
        Button6.Location = New Point(453, 169)
        Button6.Name = "Button6"
        Button6.Size = New Size(219, 41)
        Button6.TabIndex = 111
        Button6.Text = "Compute Deductions"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveCaption
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(574, 223)
        Button2.Name = "Button2"
        Button2.Size = New Size(176, 46)
        Button2.TabIndex = 107
        Button2.Text = "Edit Deduction"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.InactiveCaption
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(454, 169)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 42)
        Button4.TabIndex = 105
        Button4.Text = "Save"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.InactiveCaption
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(372, 224)
        Button5.Name = "Button5"
        Button5.Size = New Size(183, 46)
        Button5.TabIndex = 104
        Button5.Text = "Add Deduction"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 11.0F)
        Label10.Location = New Point(56, 128)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 22)
        Label10.TabIndex = 97
        Label10.Text = "Abscences:"
        ' 
        ' txtAbscences
        ' 
        txtAbscences.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAbscences.Location = New Point(179, 120)
        txtAbscences.Name = "txtAbscences"
        txtAbscences.Size = New Size(160, 30)
        txtAbscences.TabIndex = 96
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 11.0F)
        Label9.Location = New Point(37, 48)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 22)
        Label9.TabIndex = 95
        Label9.Text = "Deduction ID:"
        ' 
        ' txtDeductionID
        ' 
        txtDeductionID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeductionID.Location = New Point(179, 40)
        txtDeductionID.Name = "txtDeductionID"
        txtDeductionID.Size = New Size(160, 30)
        txtDeductionID.TabIndex = 94
        ' 
        ' dtpDateApplied
        ' 
        dtpDateApplied.CalendarFont = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDateApplied.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDateApplied.Format = DateTimePickerFormat.Short
        dtpDateApplied.Location = New Point(179, 240)
        dtpDateApplied.Name = "dtpDateApplied"
        dtpDateApplied.Size = New Size(160, 30)
        dtpDateApplied.TabIndex = 93
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 11.0F)
        Label14.Location = New Point(28, 168)
        Label14.Name = "Label14"
        Label14.Size = New Size(145, 22)
        Label14.TabIndex = 25
        Label14.Text = "Unpaid Leave:"
        ' 
        ' txtUnpaidLeave
        ' 
        txtUnpaidLeave.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUnpaidLeave.Location = New Point(179, 160)
        txtUnpaidLeave.Name = "txtUnpaidLeave"
        txtUnpaidLeave.Size = New Size(160, 30)
        txtUnpaidLeave.TabIndex = 11
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 11.0F)
        Label17.Location = New Point(19, 88)
        Label17.Name = "Label17"
        Label17.Size = New Size(154, 22)
        Label17.TabIndex = 19
        Label17.Text = "Attendance ID:"
        ' 
        ' txtAttendanceID
        ' 
        txtAttendanceID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAttendanceID.Location = New Point(179, 80)
        txtAttendanceID.Name = "txtAttendanceID"
        txtAttendanceID.Size = New Size(160, 30)
        txtAttendanceID.TabIndex = 10
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 11.0F)
        Label20.Location = New Point(35, 247)
        Label20.Name = "Label20"
        Label20.Size = New Size(138, 22)
        Label20.TabIndex = 0
        Label20.Text = "Date Applied:"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.InactiveCaption
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(566, 169)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 42)
        Button3.TabIndex = 106
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 11.0F)
        Label23.Location = New Point(35, 371)
        Label23.Name = "Label23"
        Label23.Size = New Size(149, 22)
        Label23.TabIndex = 0
        Label23.Text = "Payment Date:"
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox13.Location = New Point(179, 97)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(160, 30)
        TextBox13.TabIndex = 10
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 11.0F)
        Label22.Location = New Point(410, 33)
        Label22.Name = "Label22"
        Label22.Size = New Size(113, 22)
        Label22.TabIndex = 19
        Label22.Text = "Allowance:"
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12.Location = New Point(529, 63)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(160, 30)
        TextBox12.TabIndex = 11
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(529, 99)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(160, 30)
        TextBox11.TabIndex = 12
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 11.0F)
        Label21.Location = New Point(363, 105)
        Label21.Name = "Label21"
        Label21.Size = New Size(160, 22)
        Label21.TabIndex = 25
        Label21.Text = "Overtome Rate:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 11.0F)
        Label19.Location = New Point(55, 105)
        Label19.Name = "Label19"
        Label19.Size = New Size(118, 22)
        Label19.TabIndex = 26
        Label19.Text = "Base Salary:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtNetPay)
        GroupBox3.Controls.Add(btnEditPayroll)
        GroupBox3.Controls.Add(btnComputePayroll)
        GroupBox3.Controls.Add(btnAddPayroll)
        GroupBox3.Controls.Add(btnCancelPayroll)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(btnSavePayroll)
        GroupBox3.Controls.Add(txtPayrollID)
        GroupBox3.Controls.Add(GroupBox1)
        GroupBox3.Controls.Add(Label28)
        GroupBox3.Controls.Add(txtBasicSalary)
        GroupBox3.Controls.Add(Label29)
        GroupBox3.Controls.Add(txtEmployeeID)
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Controls.Add(txtEmployeeName)
        GroupBox3.Controls.Add(Label27)
        GroupBox3.Controls.Add(txtOvertimePay)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(txtGrossSalary)
        GroupBox3.Controls.Add(dtpPaymentDate)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Font = New Font("Century Gothic", 14.0F, FontStyle.Bold)
        GroupBox3.Location = New Point(410, 138)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1335, 543)
        GroupBox3.TabIndex = 91
        GroupBox3.TabStop = False
        GroupBox3.Text = "Payroll Computation"
        ' 
        ' btnEditPayroll
        ' 
        btnEditPayroll.BackColor = SystemColors.InactiveCaption
        btnEditPayroll.BackgroundImageLayout = ImageLayout.None
        btnEditPayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditPayroll.ForeColor = Color.Black
        btnEditPayroll.Location = New Point(293, 407)
        btnEditPayroll.Name = "btnEditPayroll"
        btnEditPayroll.Size = New Size(219, 48)
        btnEditPayroll.TabIndex = 111
        btnEditPayroll.Text = "Edit Payroll"
        btnEditPayroll.UseVisualStyleBackColor = False
        ' 
        ' btnComputePayroll
        ' 
        btnComputePayroll.BackColor = SystemColors.InactiveCaption
        btnComputePayroll.BackgroundImageLayout = ImageLayout.None
        btnComputePayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnComputePayroll.ForeColor = Color.Black
        btnComputePayroll.Location = New Point(177, 468)
        btnComputePayroll.Name = "btnComputePayroll"
        btnComputePayroll.Size = New Size(223, 48)
        btnComputePayroll.TabIndex = 104
        btnComputePayroll.Text = "Compute Payroll"
        btnComputePayroll.UseVisualStyleBackColor = False
        ' 
        ' btnAddPayroll
        ' 
        btnAddPayroll.BackColor = SystemColors.InactiveCaption
        btnAddPayroll.BackgroundImageLayout = ImageLayout.None
        btnAddPayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnAddPayroll.ForeColor = Color.Black
        btnAddPayroll.Location = New Point(67, 407)
        btnAddPayroll.Name = "btnAddPayroll"
        btnAddPayroll.Size = New Size(220, 49)
        btnAddPayroll.TabIndex = 109
        btnAddPayroll.Text = "Add Payroll"
        btnAddPayroll.UseVisualStyleBackColor = False
        ' 
        ' btnCancelPayroll
        ' 
        btnCancelPayroll.BackColor = SystemColors.InactiveCaption
        btnCancelPayroll.BackgroundImageLayout = ImageLayout.None
        btnCancelPayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelPayroll.ForeColor = Color.Black
        btnCancelPayroll.Location = New Point(293, 469)
        btnCancelPayroll.Name = "btnCancelPayroll"
        btnCancelPayroll.Size = New Size(107, 43)
        btnCancelPayroll.TabIndex = 110
        btnCancelPayroll.Text = "Cancel"
        btnCancelPayroll.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnEditSalary)
        GroupBox2.Controls.Add(btnCancelSalary)
        GroupBox2.Controls.Add(btnAddSalary)
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
        GroupBox2.Controls.Add(btnSaveSalary)
        GroupBox2.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        GroupBox2.Location = New Point(545, 27)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(760, 192)
        GroupBox2.TabIndex = 93
        GroupBox2.TabStop = False
        GroupBox2.Text = "Salary"
        ' 
        ' btnEditSalary
        ' 
        btnEditSalary.BackColor = SystemColors.InactiveCaption
        btnEditSalary.BackgroundImageLayout = ImageLayout.None
        btnEditSalary.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditSalary.ForeColor = Color.Black
        btnEditSalary.Location = New Point(356, 147)
        btnEditSalary.Name = "btnEditSalary"
        btnEditSalary.Size = New Size(204, 35)
        btnEditSalary.TabIndex = 103
        btnEditSalary.Text = "Edit Salary"
        btnEditSalary.UseVisualStyleBackColor = False
        ' 
        ' btnCancelSalary
        ' 
        btnCancelSalary.BackColor = SystemColors.InactiveCaption
        btnCancelSalary.BackgroundImageLayout = ImageLayout.None
        btnCancelSalary.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCancelSalary.ForeColor = Color.Black
        btnCancelSalary.Location = New Point(356, 148)
        btnCancelSalary.Name = "btnCancelSalary"
        btnCancelSalary.Size = New Size(107, 34)
        btnCancelSalary.TabIndex = 102
        btnCancelSalary.Text = "Cancel"
        btnCancelSalary.UseVisualStyleBackColor = False
        ' 
        ' btnAddSalary
        ' 
        btnAddSalary.BackColor = SystemColors.InactiveCaption
        btnAddSalary.BackgroundImageLayout = ImageLayout.None
        btnAddSalary.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnAddSalary.ForeColor = Color.Black
        btnAddSalary.Location = New Point(146, 145)
        btnAddSalary.Name = "btnAddSalary"
        btnAddSalary.Size = New Size(204, 37)
        btnAddSalary.TabIndex = 100
        btnAddSalary.Text = "Add Salary"
        btnAddSalary.UseVisualStyleBackColor = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 11.0F)
        Label24.Location = New Point(100, 33)
        Label24.Name = "Label24"
        Label24.Size = New Size(73, 22)
        Label24.TabIndex = 99
        Label24.Text = "Job ID:"
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14.Location = New Point(179, 25)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(160, 30)
        TextBox14.TabIndex = 98
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 11.0F)
        Label11.Location = New Point(415, 69)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 22)
        Label11.TabIndex = 97
        Label11.Text = "Daily Rate:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(529, 25)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(160, 30)
        TextBox3.TabIndex = 96
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 11.0F)
        Label12.Location = New Point(79, 69)
        Label12.Name = "Label12"
        Label12.Size = New Size(94, 22)
        Label12.TabIndex = 95
        Label12.Text = "Salary ID:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(179, 61)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(160, 30)
        TextBox4.TabIndex = 94
        ' 
        ' btnSaveSalary
        ' 
        btnSaveSalary.BackColor = SystemColors.InactiveCaption
        btnSaveSalary.BackgroundImageLayout = ImageLayout.None
        btnSaveSalary.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSaveSalary.ForeColor = Color.Black
        btnSaveSalary.Location = New Point(243, 146)
        btnSaveSalary.Name = "btnSaveSalary"
        btnSaveSalary.Size = New Size(107, 34)
        btnSaveSalary.TabIndex = 101
        btnSaveSalary.Text = "Save"
        btnSaveSalary.UseVisualStyleBackColor = False
        ' 
        ' btnSavePayroll
        ' 
        btnSavePayroll.BackColor = SystemColors.InactiveCaption
        btnSavePayroll.BackgroundImageLayout = ImageLayout.None
        btnSavePayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSavePayroll.ForeColor = Color.Black
        btnSavePayroll.Location = New Point(177, 469)
        btnSavePayroll.Name = "btnSavePayroll"
        btnSavePayroll.Size = New Size(109, 46)
        btnSavePayroll.TabIndex = 108
        btnSavePayroll.Text = "Save"
        btnSavePayroll.UseVisualStyleBackColor = False
        ' 
        ' txtPayrollID
        ' 
        txtPayrollID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPayrollID.Location = New Point(191, 138)
        txtPayrollID.Name = "txtPayrollID"
        txtPayrollID.Size = New Size(335, 30)
        txtPayrollID.TabIndex = 103
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 11.0F)
        Label28.Location = New Point(87, 144)
        Label28.Name = "Label28"
        Label28.Size = New Size(98, 22)
        Label28.TabIndex = 102
        Label28.Text = "Payroll ID:"
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBasicSalary.Location = New Point(191, 183)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.Size = New Size(335, 30)
        txtBasicSalary.TabIndex = 101
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Century Gothic", 11.0F)
        Label29.Location = New Point(43, 236)
        Label29.Name = "Label29"
        Label29.Size = New Size(142, 22)
        Label29.TabIndex = 100
        Label29.Text = "Overtime Pay:"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeID.Location = New Point(191, 48)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(335, 30)
        txtEmployeeID.TabIndex = 99
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Century Gothic", 11.0F)
        Label26.Location = New Point(56, 56)
        Label26.Name = "Label26"
        Label26.Size = New Size(129, 22)
        Label26.TabIndex = 98
        Label26.Text = "Employee ID:"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeName.Location = New Point(191, 93)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(335, 30)
        txtEmployeeName.TabIndex = 97
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 11.0F)
        Label27.Location = New Point(19, 96)
        Label27.Name = "Label27"
        Label27.Size = New Size(166, 22)
        Label27.TabIndex = 96
        Label27.Text = "Employee Name:"
        ' 
        ' txtOvertimePay
        ' 
        txtOvertimePay.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOvertimePay.Location = New Point(191, 228)
        txtOvertimePay.Name = "txtOvertimePay"
        txtOvertimePay.Size = New Size(335, 30)
        txtOvertimePay.TabIndex = 95
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 11.0F)
        Label25.Location = New Point(64, 191)
        Label25.Name = "Label25"
        Label25.Size = New Size(121, 22)
        Label25.TabIndex = 94
        Label25.Text = "Basic Salary:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 11.0F)
        Label15.Location = New Point(96, 325)
        Label15.Name = "Label15"
        Label15.Size = New Size(88, 22)
        Label15.TabIndex = 25
        Label15.Text = "Net Pay:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 11.0F)
        Label16.Location = New Point(61, 278)
        Label16.Name = "Label16"
        Label16.Size = New Size(124, 22)
        Label16.TabIndex = 19
        Label16.Text = "Gross Salary:"
        ' 
        ' txtGrossSalary
        ' 
        txtGrossSalary.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGrossSalary.Location = New Point(191, 273)
        txtGrossSalary.Name = "txtGrossSalary"
        txtGrossSalary.Size = New Size(335, 30)
        txtGrossSalary.TabIndex = 10
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.CalendarFont = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpPaymentDate.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpPaymentDate.Location = New Point(190, 363)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(335, 30)
        dtpPaymentDate.TabIndex = 93
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnRefreshPayroll)
        GroupBox4.Controls.Add(txtSearchPayroll)
        GroupBox4.Controls.Add(btnSearchPayroll)
        GroupBox4.Controls.Add(dgvPayrollSummary)
        GroupBox4.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        GroupBox4.Location = New Point(410, 683)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1335, 327)
        GroupBox4.TabIndex = 94
        GroupBox4.TabStop = False
        GroupBox4.Text = "Salary"
        ' 
        ' btnRefreshPayroll
        ' 
        btnRefreshPayroll.BackColor = SystemColors.InactiveCaption
        btnRefreshPayroll.BackgroundImageLayout = ImageLayout.None
        btnRefreshPayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnRefreshPayroll.ForeColor = Color.Black
        btnRefreshPayroll.Location = New Point(454, 35)
        btnRefreshPayroll.Name = "btnRefreshPayroll"
        btnRefreshPayroll.Size = New Size(167, 46)
        btnRefreshPayroll.TabIndex = 96
        btnRefreshPayroll.Text = "Refresh"
        btnRefreshPayroll.UseVisualStyleBackColor = False
        ' 
        ' txtSearchPayroll
        ' 
        txtSearchPayroll.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchPayroll.Location = New Point(191, 43)
        txtSearchPayroll.Margin = New Padding(4, 3, 4, 3)
        txtSearchPayroll.Name = "txtSearchPayroll"
        txtSearchPayroll.Size = New Size(256, 32)
        txtSearchPayroll.TabIndex = 95
        ' 
        ' btnSearchPayroll
        ' 
        btnSearchPayroll.BackColor = SystemColors.InactiveCaption
        btnSearchPayroll.BackgroundImageLayout = ImageLayout.None
        btnSearchPayroll.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnSearchPayroll.ForeColor = Color.Black
        btnSearchPayroll.Location = New Point(17, 35)
        btnSearchPayroll.Name = "btnSearchPayroll"
        btnSearchPayroll.Size = New Size(167, 46)
        btnSearchPayroll.TabIndex = 94
        btnSearchPayroll.Text = "Search"
        btnSearchPayroll.UseVisualStyleBackColor = False
        ' 
        ' dgvPayrollSummary
        ' 
        dgvPayrollSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayrollSummary.Location = New Point(17, 95)
        dgvPayrollSummary.Name = "dgvPayrollSummary"
        dgvPayrollSummary.RowHeadersWidth = 51
        dgvPayrollSummary.Size = New Size(1294, 209)
        dgvPayrollSummary.TabIndex = 0
        ' 
        ' txtNetPay
        ' 
        txtNetPay.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNetPay.Location = New Point(190, 318)
        txtNetPay.Name = "txtNetPay"
        txtNetPay.Size = New Size(335, 30)
        txtNetPay.TabIndex = 112
        ' 
        ' Payroll_Summary
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1761, 1033)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Payroll_Summary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll_Summary"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(dgvPayrollSummary, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents pcbTerminate As PictureBox
    Friend WithEvents Label2 As Label
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
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtPagIBIG As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtUnpaidLeave As TextBox
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpDateApplied As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAbscences As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDeductionID As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOvertimePay As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents txtPayrollID As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvPayrollSummary As DataGridView
    Friend WithEvents txtSearchPayroll As TextBox
    Friend WithEvents btnSearchPayroll As Button
    Friend WithEvents btnComputePayroll As Button
    Friend WithEvents btnAddSalary As Button
    Friend WithEvents btnSaveSalary As Button
    Friend WithEvents btnCancelSalary As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnAddPayroll As Button
    Friend WithEvents btnCancelPayroll As Button
    Friend WithEvents btnSavePayroll As Button
    Friend WithEvents btnEditSalary As Button
    Friend WithEvents btnEditPayroll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents btnRefreshPayroll As Button
    Friend WithEvents txtNetPay As TextBox
End Class
