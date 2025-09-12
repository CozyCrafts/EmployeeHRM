Public Class Login_frm
    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If cmbRole.Text = "Manager" Then
            Admin_frm.Show()
            Me.Hide()
        ElseIf cmbRole.Text = "Staff" Then
            Employee_Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Select a valid role", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class