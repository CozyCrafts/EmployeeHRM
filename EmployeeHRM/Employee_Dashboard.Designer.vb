<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Dashboard))
        adminheader_pnl = New Panel()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        btnHoliday = New Button()
        btnForms = New Button()
        btnPolicies = New Button()
        btnHandbook = New Button()
        GroupBox2 = New GroupBox()
        btnPerfRev = New Button()
        btnCIO = New Button()
        btnViewPayslips = New Button()
        GroupBox3 = New GroupBox()
        btnEditProf = New Button()
        txtProfPic = New PictureBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox4 = New TextBox()
        Label13 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox4 = New GroupBox()
        dgAnnounce = New DataGridView()
        GroupBox5 = New GroupBox()
        dgUpEvents = New DataGridView()
        GroupBox6 = New GroupBox()
        DateTimePicker3 = New DateTimePicker()
        lblCurrentStatus = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Label5 = New Label()
        Payslipslbl = New Label()
        SalaryProcessinglbl = New Label()
        Label6 = New Label()
        lblProfile = New Label()
        lblEmployees = New Label()
        lblLeaveManagement = New Label()
        Label10 = New Label()
        lblDashboard = New Label()
        Label11 = New Label()
        pcbTerminate = New PictureBox()
        adminheader_pnl.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(txtProfPic, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(dgAnnounce, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        CType(dgUpEvents, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(pcbTerminate)
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(343, -27)
        adminheader_pnl.Name = "adminheader_pnl"
        adminheader_pnl.Size = New Size(1608, 107)
        adminheader_pnl.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 34)
        Label2.TabIndex = 0
        Label2.Text = "Dashboard"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnHoliday)
        GroupBox1.Controls.Add(btnForms)
        GroupBox1.Controls.Add(btnPolicies)
        GroupBox1.Controls.Add(btnHandbook)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(1025, 399)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(744, 144)
        GroupBox1.TabIndex = 61
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quick Access"
        ' 
        ' btnHoliday
        ' 
        btnHoliday.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnHoliday.Location = New Point(548, 52)
        btnHoliday.Name = "btnHoliday"
        btnHoliday.Size = New Size(168, 60)
        btnHoliday.TabIndex = 3
        btnHoliday.Text = "Holiday Calendar"
        btnHoliday.UseVisualStyleBackColor = True
        ' 
        ' btnForms
        ' 
        btnForms.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnForms.Location = New Point(196, 52)
        btnForms.Name = "btnForms"
        btnForms.Size = New Size(168, 60)
        btnForms.TabIndex = 2
        btnForms.Text = "Forms"
        btnForms.UseVisualStyleBackColor = True
        ' 
        ' btnPolicies
        ' 
        btnPolicies.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnPolicies.Location = New Point(374, 52)
        btnPolicies.Name = "btnPolicies"
        btnPolicies.Size = New Size(168, 60)
        btnPolicies.TabIndex = 1
        btnPolicies.Text = "Policies"
        btnPolicies.UseVisualStyleBackColor = True
        ' 
        ' btnHandbook
        ' 
        btnHandbook.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnHandbook.Location = New Point(22, 52)
        btnHandbook.Name = "btnHandbook"
        btnHandbook.Size = New Size(168, 60)
        btnHandbook.TabIndex = 0
        btnHandbook.Text = "Employee Handook"
        btnHandbook.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnPerfRev)
        GroupBox2.Controls.Add(btnCIO)
        GroupBox2.Controls.Add(btnViewPayslips)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(1379, 127)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(390, 240)
        GroupBox2.TabIndex = 62
        GroupBox2.TabStop = False
        GroupBox2.Text = "Shortcuts"
        ' 
        ' btnPerfRev
        ' 
        btnPerfRev.BackColor = SystemColors.InactiveCaption
        btnPerfRev.BackgroundImageLayout = ImageLayout.None
        btnPerfRev.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnPerfRev.ForeColor = Color.Black
        btnPerfRev.Location = New Point(35, 164)
        btnPerfRev.Name = "btnPerfRev"
        btnPerfRev.Size = New Size(320, 46)
        btnPerfRev.TabIndex = 37
        btnPerfRev.Text = "Performance Review"
        btnPerfRev.UseVisualStyleBackColor = False
        ' 
        ' btnCIO
        ' 
        btnCIO.BackColor = SystemColors.InactiveCaption
        btnCIO.BackgroundImageLayout = ImageLayout.None
        btnCIO.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnCIO.ForeColor = Color.Black
        btnCIO.Location = New Point(35, 44)
        btnCIO.Name = "btnCIO"
        btnCIO.Size = New Size(320, 46)
        btnCIO.TabIndex = 36
        btnCIO.Text = "Check In / Out"
        btnCIO.UseVisualStyleBackColor = False
        ' 
        ' btnViewPayslips
        ' 
        btnViewPayslips.BackColor = SystemColors.InactiveCaption
        btnViewPayslips.BackgroundImageLayout = ImageLayout.None
        btnViewPayslips.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnViewPayslips.ForeColor = Color.Black
        btnViewPayslips.Location = New Point(35, 102)
        btnViewPayslips.Name = "btnViewPayslips"
        btnViewPayslips.Size = New Size(320, 46)
        btnViewPayslips.TabIndex = 35
        btnViewPayslips.Text = "View Payslips"
        btnViewPayslips.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnEditProf)
        GroupBox3.Controls.Add(txtProfPic)
        GroupBox3.Controls.Add(TextBox9)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Controls.Add(TextBox7)
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox3.Location = New Point(381, 108)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(626, 259)
        GroupBox3.TabIndex = 63
        GroupBox3.TabStop = False
        GroupBox3.Text = "Profile"
        ' 
        ' btnEditProf
        ' 
        btnEditProf.BackColor = SystemColors.InactiveCaption
        btnEditProf.BackgroundImageLayout = ImageLayout.None
        btnEditProf.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        btnEditProf.ForeColor = Color.Black
        btnEditProf.Location = New Point(475, 198)
        btnEditProf.Name = "btnEditProf"
        btnEditProf.Size = New Size(126, 44)
        btnEditProf.TabIndex = 39
        btnEditProf.Text = "Edit Profile"
        btnEditProf.UseVisualStyleBackColor = False
        ' 
        ' txtProfPic
        ' 
        txtProfPic.BorderStyle = BorderStyle.Fixed3D
        txtProfPic.Location = New Point(29, 46)
        txtProfPic.Name = "txtProfPic"
        txtProfPic.Size = New Size(215, 196)
        txtProfPic.TabIndex = 38
        txtProfPic.TabStop = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(383, 148)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(218, 30)
        TextBox9.TabIndex = 13
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(383, 112)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(218, 30)
        TextBox8.TabIndex = 12
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(383, 76)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(218, 30)
        TextBox7.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(383, 40)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(218, 30)
        TextBox4.TabIndex = 10
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(291, 121)
        Label13.Name = "Label13"
        Label13.Size = New Size(86, 21)
        Label13.TabIndex = 3
        Label13.Text = "Job Title:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(308, 85)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 21)
        Label9.TabIndex = 2
        Label9.Text = "Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(296, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 21)
        Label4.TabIndex = 1
        Label4.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(250, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 0
        Label3.Text = "Employee ID:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgAnnounce)
        GroupBox4.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox4.Location = New Point(381, 399)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(626, 605)
        GroupBox4.TabIndex = 64
        GroupBox4.TabStop = False
        GroupBox4.Text = "Announcements"
        ' 
        ' dgAnnounce
        ' 
        dgAnnounce.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgAnnounce.Location = New Point(29, 48)
        dgAnnounce.Name = "dgAnnounce"
        dgAnnounce.RowHeadersWidth = 51
        dgAnnounce.Size = New Size(572, 535)
        dgAnnounce.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(dgUpEvents)
        GroupBox5.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox5.Location = New Point(1025, 567)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(744, 437)
        GroupBox5.TabIndex = 65
        GroupBox5.TabStop = False
        GroupBox5.Text = "Upcoming Events"
        ' 
        ' dgUpEvents
        ' 
        dgUpEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgUpEvents.Location = New Point(22, 46)
        dgUpEvents.Name = "dgUpEvents"
        dgUpEvents.RowHeadersWidth = 51
        dgUpEvents.Size = New Size(694, 369)
        dgUpEvents.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(DateTimePicker3)
        GroupBox6.Controls.Add(lblCurrentStatus)
        GroupBox6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        GroupBox6.Location = New Point(1031, 127)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(332, 240)
        GroupBox6.TabIndex = 66
        GroupBox6.TabStop = False
        GroupBox6.Text = "Current Status"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        DateTimePicker3.Location = New Point(26, 38)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(288, 26)
        DateTimePicker3.TabIndex = 38
        ' 
        ' lblCurrentStatus
        ' 
        lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle
        lblCurrentStatus.Location = New Point(26, 74)
        lblCurrentStatus.Name = "lblCurrentStatus"
        lblCurrentStatus.Size = New Size(288, 144)
        lblCurrentStatus.TabIndex = 37
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Payslipslbl)
        Panel2.Controls.Add(SalaryProcessinglbl)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(lblProfile)
        Panel2.Controls.Add(lblEmployees)
        Panel2.Controls.Add(lblLeaveManagement)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(-8, -5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(38, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 34)
        Label1.TabIndex = 12
        Label1.Text = " HR System"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(33, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(312, 27)
        Label5.TabIndex = 11
        Label5.Text = "                                                  "
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(38, 474)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 22)
        Label6.TabIndex = 8
        Label6.Text = " PAYROLL"
        ' 
        ' lblProfile
        ' 
        lblProfile.AutoSize = True
        lblProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProfile.ForeColor = Color.White
        lblProfile.Location = New Point(56, 278)
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
        lblEmployees.Location = New Point(56, 323)
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
        lblLeaveManagement.Location = New Point(56, 366)
        lblLeaveManagement.Name = "lblLeaveManagement"
        lblLeaveManagement.Size = New Size(248, 27)
        lblLeaveManagement.TabIndex = 5
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(38, 235)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 22)
        Label10.TabIndex = 3
        Label10.Text = "EMPLOYEES"
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(38, 118)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 22)
        Label11.TabIndex = 1
        Label11.Text = "MAIN"
        ' 
        ' pcbTerminate
        ' 
        pcbTerminate.Image = CType(resources.GetObject("pcbTerminate.Image"), Image)
        pcbTerminate.Location = New Point(1354, 39)
        pcbTerminate.Name = "pcbTerminate"
        pcbTerminate.Size = New Size(55, 54)
        pcbTerminate.SizeMode = PictureBoxSizeMode.StretchImage
        pcbTerminate.TabIndex = 2
        pcbTerminate.TabStop = False
        ' 
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 1033)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Emp_Dashboard"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(txtProfPic, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(dgAnnounce, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        CType(dgUpEvents, ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pcbTerminate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHandbook As Button
    Friend WithEvents btnHoliday As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCIO As Button
    Friend WithEvents btnViewPayslips As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEditProf As Button
    Friend WithEvents txtProfPic As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnPerfRev As Button
    Friend WithEvents btnForms As Button
    Friend WithEvents btnPolicies As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents lblCurrentStatus As Label
    Friend WithEvents dgAnnounce As DataGridView
    Friend WithEvents dgUpEvents As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Payslipslbl As Label
    Friend WithEvents SalaryProcessinglbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents lblEmployees As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pcbTerminate As PictureBox
End Class
