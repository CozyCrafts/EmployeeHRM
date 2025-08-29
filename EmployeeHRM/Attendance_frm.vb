Public Class Employee_Time_and_Attendance
    Private Sub EmpDashbtn_Click(sender As Object, e As EventArgs) Handles EmpDashbtn.Click
        Employee_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub MyProfbtn_Click(sender As Object, e As EventArgs) Handles MyProfbtn.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub EmpTAbtn_Click(sender As Object, e As EventArgs) Handles EmpTAbtn.Click
        EmpTAbtn.Enabled = False
    End Sub

    Private Sub EmpPaybtn_Click(sender As Object, e As EventArgs) Handles EmpPaybtn.Click
        Employee_Payroll.Show()
        Me.Hide()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class