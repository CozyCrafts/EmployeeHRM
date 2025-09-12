Public Class LeaveManagement_frm
    Private Sub LeaveManagement_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub lblManageEmployees_Click(sender As Object, e As EventArgs) Handles lblManageEmployees.Click
        Employee_Management.Show()
        Me.Hide()
    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmployees_Click(sender As Object, e As EventArgs) Handles lblEmployees.Click
        Employee_Time_and_Attendancevb.Show()
        Me.Hide()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        SalaryProcessing_frm.Show()
        Me.Hide()
    End Sub

    Private Sub lblPayslips_Click(sender As Object, e As EventArgs) Handles lblPayslips.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub
End Class