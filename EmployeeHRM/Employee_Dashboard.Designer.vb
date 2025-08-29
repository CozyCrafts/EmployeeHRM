<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LogOutbtn = New Button()
        Panel1 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        lblProfile = New Label()
        lblEmployees = New Label()
        lblLeaveManagement = New Label()
        lblManageEmployees = New Label()
        Label3 = New Label()
        lblDashboard = New Label()
        lblMain = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogOutbtn
        ' 
        LogOutbtn.BackColor = Color.DarkCyan
        LogOutbtn.FlatStyle = FlatStyle.Flat
        LogOutbtn.Font = New Font("Microsoft Sans Serif", 10.2F)
        LogOutbtn.ForeColor = Color.White
        LogOutbtn.Location = New Point(7, 653)
        LogOutbtn.Name = "LogOutbtn"
        LogOutbtn.Size = New Size(323, 37)
        LogOutbtn.TabIndex = 18
        LogOutbtn.Text = "Log Out"
        LogOutbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblProfile)
        Panel1.Controls.Add(lblEmployees)
        Panel1.Controls.Add(lblLeaveManagement)
        Panel1.Controls.Add(lblManageEmployees)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblDashboard)
        Panel1.Controls.Add(lblMain)
        Panel1.Location = New Point(-7, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(371, 1045)
        Panel1.TabIndex = 19
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
        ' lblProfile
        ' 
        lblProfile.AutoSize = True
        lblProfile.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProfile.ForeColor = Color.White
        lblProfile.Location = New Point(64, 302)
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
        lblEmployees.Location = New Point(64, 347)
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
        lblLeaveManagement.Location = New Point(64, 390)
        lblLeaveManagement.Name = "lblLeaveManagement"
        lblLeaveManagement.Size = New Size(248, 27)
        lblLeaveManagement.TabIndex = 5
        lblLeaveManagement.Text = "Leave Management"
        ' 
        ' lblManageEmployees
        ' 
        lblManageEmployees.AutoSize = True
        lblManageEmployees.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblManageEmployees.ForeColor = Color.White
        lblManageEmployees.Location = New Point(64, 255)
        lblManageEmployees.Name = "lblManageEmployees"
        lblManageEmployees.Size = New Size(240, 27)
        lblManageEmployees.TabIndex = 4
        lblManageEmployees.Text = "Manage Employees"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(41, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 22)
        Label3.TabIndex = 3
        Label3.Text = "EMPLOYEES"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(64, 145)
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
        lblMain.Location = New Point(41, 101)
        lblMain.Name = "lblMain"
        lblMain.Size = New Size(57, 22)
        lblMain.TabIndex = 1
        lblMain.Text = "MAIN"
        ' 
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(LogOutbtn)
        Name = "Employee_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogOutbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents lblEmployees As Label
    Friend WithEvents lblLeaveManagement As Label
    Friend WithEvents lblManageEmployees As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblMain As Label

End Class
