<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_frm))
        PictureBox1 = New PictureBox()
        lbllogin = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtUname = New TextBox()
        txtPass = New TextBox()
        cmbRole = New ComboBox()
        btnlogin = New Button()
        btnEmployee = New Button()
        btnManager = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(330, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lbllogin
        ' 
        lbllogin.AutoSize = True
        lbllogin.Font = New Font("Perpetua Titling MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbllogin.ForeColor = SystemColors.MenuHighlight
        lbllogin.Location = New Point(159, 223)
        lbllogin.Name = "lbllogin"
        lbllogin.Size = New Size(73, 22)
        lbllogin.TabIndex = 1
        lbllogin.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.Location = New Point(73, 344)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 23)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(76, 410)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 23)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(76, 280)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 23)
        Label1.TabIndex = 4
        Label1.Text = "Role:"
        ' 
        ' txtUname
        ' 
        txtUname.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUname.Location = New Point(76, 367)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(244, 34)
        txtUname.TabIndex = 5
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPass.Location = New Point(76, 433)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(244, 34)
        txtPass.TabIndex = 6
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Manager", "Staff"})
        cmbRole.Location = New Point(76, 303)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(245, 32)
        cmbRole.TabIndex = 7
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.White
        btnlogin.Font = New Font("Perpetua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = SystemColors.MenuHighlight
        btnlogin.Location = New Point(145, 489)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(101, 47)
        btnlogin.TabIndex = 8
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' btnEmployee
        ' 
        btnEmployee.BackColor = Color.White
        btnEmployee.Font = New Font("Perpetua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEmployee.ForeColor = SystemColors.MenuHighlight
        btnEmployee.Location = New Point(73, 542)
        btnEmployee.Name = "btnEmployee"
        btnEmployee.Size = New Size(121, 47)
        btnEmployee.TabIndex = 10
        btnEmployee.Text = "Employee"
        btnEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnManager
        ' 
        btnManager.BackColor = Color.White
        btnManager.Font = New Font("Perpetua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManager.ForeColor = SystemColors.MenuHighlight
        btnManager.Location = New Point(200, 542)
        btnManager.Name = "btnManager"
        btnManager.Size = New Size(121, 47)
        btnManager.TabIndex = 11
        btnManager.Text = "Manager"
        btnManager.UseVisualStyleBackColor = False
        ' 
        ' Login_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(394, 612)
        Controls.Add(btnManager)
        Controls.Add(btnEmployee)
        Controls.Add(btnlogin)
        Controls.Add(cmbRole)
        Controls.Add(txtPass)
        Controls.Add(txtUname)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lbllogin)
        Controls.Add(PictureBox1)
        Name = "Login_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login_frm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbllogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnManager As Button
End Class
