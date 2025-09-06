<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_Dashboard
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
        Panel1.SuspendLayout()
        adminheader_pnl.SuspendLayout()
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
        Panel1.Size = New Size(371, 1045)
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
        adminheader_pnl.Location = New Point(346, -27)
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
        ' Emp_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 1033)
        Controls.Add(Panel1)
        Controls.Add(adminheader_pnl)
        Name = "Emp_Dashboard"
        Text = "Emp_Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        adminheader_pnl.ResumeLayout(False)
        adminheader_pnl.PerformLayout()
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
End Class
