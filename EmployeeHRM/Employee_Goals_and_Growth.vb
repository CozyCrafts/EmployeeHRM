Imports Google.Protobuf.WellKnownTypes

Public Class Employee_Goals_and_Growth
    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
        Employee_Dashboard.Show()
        Me.Hide()
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
        lblEmpGG.Enabled = False
    End Sub


End Class