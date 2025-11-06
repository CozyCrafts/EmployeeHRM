
Public Class Login_frm
    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Employee_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnManager_Click(sender As Object, e As EventArgs) Handles btnManager.Click
        Manager_Dashboard.Show()
        Me.Hide()
    End Sub
End Class