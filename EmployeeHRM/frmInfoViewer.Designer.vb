<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoViewer
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
        rtbContent = New RichTextBox()
        SuspendLayout()
        ' 
        ' rtbContent
        ' 
        rtbContent.Dock = DockStyle.Fill
        rtbContent.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbContent.Location = New Point(0, 0)
        rtbContent.Name = "rtbContent"
        rtbContent.ReadOnly = True
        rtbContent.Size = New Size(800, 450)
        rtbContent.TabIndex = 0
        rtbContent.Text = ""
        ' 
        ' frmInfoViewer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(rtbContent)
        ForeColor = SystemColors.InactiveCaption
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmInfoViewer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmInfoViewer"
        ResumeLayout(False)
    End Sub

    Friend WithEvents rtbContent As RichTextBox
End Class
