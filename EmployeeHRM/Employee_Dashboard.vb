Public Class Employee_Dashboard
    Private Sub EmpDashbtn_Click(sender As Object, e As EventArgs) Handles EmpDashbtn.Click
        EmpDashbtn.Enabled = False

    End Sub

    Private Sub MyProfbtn_Click(sender As Object, e As EventArgs) Handles MyProfbtn.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub EmpTAbtn_Click(sender As Object, e As EventArgs) Handles EmpTAbtn.Click
        Employee_Time_and_Attendance.Show()
        Me.Hide()
    End Sub

    Private Sub EmpPaybtn_Click(sender As Object, e As EventArgs) Handles EmpPaybtn.Click
        EmpPaybtn.Enabled = False

    End Sub

    Private Sub EmpPDbtn_Click(sender As Object, e As EventArgs) Handles EmpPDbtn.Click
        Employee_Performance_and_Development.Show()
        Me.Hide()
    End Sub
    Private Sub LogOutbtn_Click(sender As Object, e As EventArgs) Handles LogOutbtn.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout")

        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
