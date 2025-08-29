<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Payroll
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
        LogOutbtn = New Button()
        EmpPDbtn = New Button()
        EmpPaybtn = New Button()
        EmpTAbtn = New Button()
        MyProfbtn = New Button()
        EmpDashbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogOutbtn
        ' 
        LogOutbtn.BackColor = Color.DarkCyan
        LogOutbtn.FlatStyle = FlatStyle.Flat
        LogOutbtn.Font = New Font("Bugaki", 10.2F)
        LogOutbtn.ForeColor = Color.White
        LogOutbtn.Location = New Point(12, 648)
        LogOutbtn.Name = "LogOutbtn"
        LogOutbtn.Size = New Size(323, 37)
        LogOutbtn.TabIndex = 11
        LogOutbtn.Text = "Log Out"
        LogOutbtn.UseVisualStyleBackColor = False
        ' 
        ' EmpPDbtn
        ' 
        EmpPDbtn.BackColor = Color.DarkCyan
        EmpPDbtn.FlatStyle = FlatStyle.Flat
        EmpPDbtn.Font = New Font("Bugaki", 10F)
        EmpPDbtn.ForeColor = Color.White
        EmpPDbtn.ImageAlign = ContentAlignment.MiddleLeft
        EmpPDbtn.Location = New Point(12, 472)
        EmpPDbtn.Name = "EmpPDbtn"
        EmpPDbtn.Size = New Size(323, 39)
        EmpPDbtn.TabIndex = 10
        EmpPDbtn.Text = "Performance and Development"
        EmpPDbtn.UseVisualStyleBackColor = False
        ' 
        ' EmpPaybtn
        ' 
        EmpPaybtn.BackColor = Color.DarkCyan
        EmpPaybtn.FlatStyle = FlatStyle.Flat
        EmpPaybtn.Font = New Font("Bugaki", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmpPaybtn.ForeColor = Color.White
        EmpPaybtn.Location = New Point(12, 407)
        EmpPaybtn.Name = "EmpPaybtn"
        EmpPaybtn.Size = New Size(323, 39)
        EmpPaybtn.TabIndex = 9
        EmpPaybtn.Text = "Payroll"
        EmpPaybtn.UseVisualStyleBackColor = False
        ' 
        ' EmpTAbtn
        ' 
        EmpTAbtn.BackColor = Color.DarkCyan
        EmpTAbtn.FlatStyle = FlatStyle.Flat
        EmpTAbtn.Font = New Font("Bugaki", 10F)
        EmpTAbtn.ForeColor = Color.White
        EmpTAbtn.Location = New Point(12, 345)
        EmpTAbtn.Name = "EmpTAbtn"
        EmpTAbtn.Size = New Size(323, 39)
        EmpTAbtn.TabIndex = 8
        EmpTAbtn.Text = "Time and Attendance"
        EmpTAbtn.UseVisualStyleBackColor = False
        ' 
        ' MyProfbtn
        ' 
        MyProfbtn.BackColor = Color.DarkCyan
        MyProfbtn.FlatStyle = FlatStyle.Flat
        MyProfbtn.Font = New Font("Bugaki", 10F)
        MyProfbtn.ForeColor = Color.White
        MyProfbtn.Location = New Point(12, 281)
        MyProfbtn.Name = "MyProfbtn"
        MyProfbtn.Size = New Size(323, 39)
        MyProfbtn.TabIndex = 7
        MyProfbtn.Text = "My Profile"
        MyProfbtn.UseVisualStyleBackColor = False
        ' 
        ' EmpDashbtn
        ' 
        EmpDashbtn.BackColor = Color.DarkCyan
        EmpDashbtn.FlatStyle = FlatStyle.Flat
        EmpDashbtn.Font = New Font("Bugaki", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmpDashbtn.ForeColor = Color.White
        EmpDashbtn.Location = New Point(12, 211)
        EmpDashbtn.Name = "EmpDashbtn"
        EmpDashbtn.Size = New Size(323, 39)
        EmpDashbtn.TabIndex = 6
        EmpDashbtn.Text = "Dashboard"
        EmpDashbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkCyan
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(346, 703)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Employee_Payroll
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1082, 703)
        Controls.Add(LogOutbtn)
        Controls.Add(EmpPDbtn)
        Controls.Add(EmpPaybtn)
        Controls.Add(EmpTAbtn)
        Controls.Add(MyProfbtn)
        Controls.Add(EmpDashbtn)
        Controls.Add(PictureBox1)
        Name = "Employee_Payroll"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Payroll"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogOutbtn As Button
    Friend WithEvents EmpPDbtn As Button
    Friend WithEvents EmpPaybtn As Button
    Friend WithEvents EmpTAbtn As Button
    Friend WithEvents MyProfbtn As Button
    Friend WithEvents EmpDashbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
