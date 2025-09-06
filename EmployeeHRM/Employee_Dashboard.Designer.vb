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
        Panel1 = New Panel()
        lblEmpGG = New Label()
        lblEmpPayroll = New Label()
        lblEmpTA = New Label()
        lblMyProf = New Label()
        lblEmpDashboard = New Label()
        Label8 = New Label()
        Label7 = New Label()
        lblMain = New Label()
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
        Panel1.SuspendLayout()
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
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(lblEmpGG)
        Panel1.Controls.Add(lblEmpPayroll)
        Panel1.Controls.Add(lblEmpTA)
        Panel1.Controls.Add(lblMyProf)
        Panel1.Controls.Add(lblEmpDashboard)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblMain)
        Panel1.Location = New Point(-7, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 1357)
        Panel1.TabIndex = 22
        ' 
        ' lblEmpGG
        ' 
        lblEmpGG.AutoSize = True
        lblEmpGG.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpGG.ForeColor = Color.White
        lblEmpGG.Location = New Point(64, 390)
        lblEmpGG.Name = "lblEmpGG"
        lblEmpGG.Size = New Size(220, 27)
        lblEmpGG.TabIndex = 25
        lblEmpGG.Text = "Goals and Growth"
        ' 
        ' lblEmpPayroll
        ' 
        lblEmpPayroll.AutoSize = True
        lblEmpPayroll.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpPayroll.ForeColor = Color.White
        lblEmpPayroll.Location = New Point(64, 327)
        lblEmpPayroll.Name = "lblEmpPayroll"
        lblEmpPayroll.Size = New Size(89, 27)
        lblEmpPayroll.TabIndex = 24
        lblEmpPayroll.Text = "Payroll"
        ' 
        ' lblEmpTA
        ' 
        lblEmpTA.AutoSize = True
        lblEmpTA.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpTA.ForeColor = Color.White
        lblEmpTA.Location = New Point(64, 266)
        lblEmpTA.Name = "lblEmpTA"
        lblEmpTA.Size = New Size(262, 27)
        lblEmpTA.TabIndex = 23
        lblEmpTA.Text = "Time and Attendance"
        ' 
        ' lblMyProf
        ' 
        lblMyProf.AutoSize = True
        lblMyProf.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMyProf.ForeColor = Color.White
        lblMyProf.Location = New Point(64, 205)
        lblMyProf.Name = "lblMyProf"
        lblMyProf.Size = New Size(124, 27)
        lblMyProf.TabIndex = 22
        lblMyProf.Text = "My Profile"
        ' 
        ' lblEmpDashboard
        ' 
        lblEmpDashboard.AutoSize = True
        lblEmpDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpDashboard.ForeColor = Color.White
        lblEmpDashboard.Location = New Point(64, 145)
        lblEmpDashboard.Name = "lblEmpDashboard"
        lblEmpDashboard.Size = New Size(138, 27)
        lblEmpDashboard.TabIndex = 21
        lblEmpDashboard.Text = "Dashboard"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(41, 20)
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
        Label7.Location = New Point(36, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(312, 27)
        Label7.TabIndex = 11
        Label7.Text = "                                                  "
        ' 
        ' lblMain
        ' 
        lblMain.AutoSize = True
        lblMain.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMain.ForeColor = Color.White
        lblMain.Location = New Point(41, 101)
        lblMain.Name = "lblMain"
        lblMain.Size = New Size(57, 22)
        lblMain.TabIndex = 1
        lblMain.Text = "MAIN"
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
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
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 1033)
        ControlBox = False
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Emp_Dashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEmpGG As Label
    Friend WithEvents lblEmpPayroll As Label
    Friend WithEvents lblEmpTA As Label
    Friend WithEvents lblMyProf As Label
    Friend WithEvents lblEmpDashboard As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMain As Label
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
End Class
