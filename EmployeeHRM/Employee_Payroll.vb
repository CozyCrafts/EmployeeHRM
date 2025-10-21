Public Class Employee_Payroll
    Public Property UserRole As String
    Private Sub Employee_Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        If UserRole = "Staff" Then
            lblManageEmployees.Visible = False
        ElseIf UserRole = "Manager" Then
            lblManageEmployees.Visible = True
        End If
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        If UserRole = "Staff" Then
            Employee_Dashboard.Show()
        ElseIf UserRole = "Manager" Then
            Admin_frm.Show()
        End If
    End Sub

    Private Sub pcbTerminate_Click(sender As Object, e As EventArgs) Handles pcbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the system?",
                                                "Confirm Exit",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class