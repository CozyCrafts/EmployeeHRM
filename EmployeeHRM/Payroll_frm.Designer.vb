<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll_frm
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
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogOutbtn
        ' 
        LogOutbtn.BackColor = Color.DarkCyan
        LogOutbtn.FlatStyle = FlatStyle.Flat
        LogOutbtn.Font = New Font("Microsoft Sans Serif", 10.2F)
        LogOutbtn.ForeColor = Color.White
        LogOutbtn.Location = New Point(12, 648)
        LogOutbtn.Name = "LogOutbtn"
        LogOutbtn.Size = New Size(323, 37)
        LogOutbtn.TabIndex = 11
        LogOutbtn.Text = "Log Out"
        LogOutbtn.UseVisualStyleBackColor = False
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
        ' Payroll_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(LogOutbtn)
        Controls.Add(PictureBox1)
        Name = "Payroll_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee_Payroll"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogOutbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
