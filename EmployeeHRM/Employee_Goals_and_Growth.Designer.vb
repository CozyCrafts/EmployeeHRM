<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Goals_and_Growth
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
        adminheader_pnl = New Panel()
        Label2 = New Label()
        GroupBox4 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        DataGridView2 = New DataGridView()
        GroupBox2 = New GroupBox()
        DataGridView3 = New DataGridView()
        Panel2 = New Panel()
        lblManageEmployees = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Payslipslbl = New Label()
        SalaryProcessinglbl = New Label()
        Label4 = New Label()
        lblProfile = New Label()
        lblEmployees = New Label()
        lblLeaveManagement = New Label()
        Label5 = New Label()
        lblDashboard = New Label()
        Label6 = New Label()
        adminheader_pnl.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminheader_pnl
        ' 
        adminheader_pnl.BackColor = Color.White
        adminheader_pnl.Controls.Add(Label2)
        adminheader_pnl.Location = New Point(342, -27)
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
        Label2.Size = New Size(298, 34)
        Label2.TabIndex = 0
        Label2.Text = "Goals and Growth"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(DataGridView1)
        GroupBox4.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox4.Location = New Point(395, 97)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(662, 519)
        GroupBox4.TabIndex = 65
        GroupBox4.TabStop = False
        GroupBox4.Text = "Goals"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(26, 44)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(612, 450)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView2)
        GroupBox1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox1.Location = New Point(385, 634)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1367, 378)
        GroupBox1.TabIndex = 66
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appraisal History"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(20, 53)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1320, 301)
        DataGridView2.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView3)
        GroupBox2.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        GroupBox2.Location = New Point(1081, 109)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(671, 507)
        GroupBox2.TabIndex = 67
        GroupBox2.TabStop = False
        GroupBox2.Text = "Assigned Training"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(26, 35)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.Size = New Size(572, 447)
        DataGridView3.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(lblManageEmployees)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Payslipslbl)
        Panel2.Controls.Add(SalaryProcessinglbl)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(lblProfile)
        Panel2.Controls.Add(lblEmployees)
        Panel2.Controls.Add(lblLeaveManagement)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(lblDashboard)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(-5, -8)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 1357)
        Panel2.TabIndex = 26
        ' 
        ' lblManageEmployees
        ' 
        lblManageEmployees.AutoSize = True
        lblManageEmployees.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblManageEmployees.ForeColor = Color.White
        lblManageEmployees.Location = New Point(56, 410)
        lblManageEmployees.Name = "lblManageEmployees"
        lblManageEmployees.Size = New Size(240, 27)
        lblManageEmployees.TabIndex = 13
        lblManageEmployees.Text = "Manage Employees"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(33, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 27)
        Label3.TabIndex = 11
        Label3.Text = "                                                  "
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(38, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 22)
        Label5.TabIndex = 3
        Label5.Text = "EMPLOYEES"
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(38, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 22)
        Label6.TabIndex = 1
        Label6.Text = "MAIN"
        ' 
        ' Employee_Goals_and_Growth
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 1033)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Controls.Add(adminheader_pnl)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Employee_Goals_and_Growth"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Goals_and_Growth"
        WindowState = FormWindowState.Maximized
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents adminheader_pnl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Payslipslbl As Label
    Friend WithEvents SalaryProcessinglbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents lblEmployees As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblManageEmployees As Label
End Class
