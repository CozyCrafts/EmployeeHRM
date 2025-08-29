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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        cmbRole = New ComboBox()
        btnlogin = New Button()
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
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(76, 367)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(244, 34)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(76, 433)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(244, 34)
        TextBox2.TabIndex = 6
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "Employee"})
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
        ' Login_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(394, 612)
        Controls.Add(btnlogin)
        Controls.Add(cmbRole)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnlogin As Button
End Class
