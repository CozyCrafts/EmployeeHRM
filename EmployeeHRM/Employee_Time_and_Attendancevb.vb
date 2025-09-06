Public Class Employee_Time_and_Attendancevb
    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
        Emp_Dashboard.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub lblMyProf_Click(sender As Object, e As EventArgs) Handles lblMyProf.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpTA_Click(sender As Object, e As EventArgs) Handles lblEmpTA.Click
        lblEmpTA.Enabled = False
    End Sub

    Private Sub lblEmpPayroll_Click(sender As Object, e As EventArgs) Handles lblEmpPayroll.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpGG_Click(sender As Object, e As EventArgs) Handles lblEmpGG.Click
        Employee_Goals_and_Growth.Show()
        Me.Hide()
    End Sub
End Class