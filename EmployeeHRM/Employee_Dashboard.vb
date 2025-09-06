Public Class Employee_Dashboard
    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
        lblEmpDashboard.Enabled = False
    End Sub

    Private Sub lblMyProf_Click(sender As Object, e As EventArgs) Handles lblMyProf.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpTA_Click(sender As Object, e As EventArgs) Handles lblEmpTA.Click
        Employee_Time_and_Attendancevb.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpPayroll_Click(sender As Object, e As EventArgs) Handles lblEmpPayroll.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpGG_Click(sender As Object, e As EventArgs) Handles lblEmpGG.Click
        Employee_Goals_and_Growth.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditProf_Click(sender As Object, e As EventArgs) Handles btnEditProf.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

End Class