Public Class EmployeeAttendance_frm
    Private Sub EmployeeAttendance_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click

    End Sub

    Private Sub lblManageEmployees_Click(sender As Object, e As EventArgs) Handles lblManageEmployees.Click
        EmployeeManagement_frm.Show()
        Me.Hide()
    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Profile_frm.Show()
        Me.Hide()
    End Sub

    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        LeaveManagement_frm.Show()
        Me.Hide()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        SalaryProcessing_frm.Show()
        Me.Hide()
    End Sub

    Private Sub lblPayslips_Click(sender As Object, e As EventArgs) Handles lblPayslips.Click
        Payroll_frm.Show()
        Me.Hide()
    End Sub
End Class