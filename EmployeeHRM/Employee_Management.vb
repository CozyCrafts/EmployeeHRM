Imports MySql.Data.MySqlClient
Public Class Employee_Management
    Private Sub Employee_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None

        Try
            dbcon = New MySqlConnection("server=localhost;username=root;password=admin;database=db_hrm;")
            Call OpenCon()
            dbcmd.Connection = dbcon
            dbadapter = New MySqlDataAdapter("SELECT * FROM tbltesting", dbcon)
            dbtable = New DataTable
            dbadapter.Fill(dbtable)

            DataGridView1.DataSource = dbtable

            dbcon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click

    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmployees_Click(sender As Object, e As EventArgs) Handles lblEmployees.Click
        Employee_Time_and_Attendancevb.Show()
        Me.Hide()
    End Sub

    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        LeaveManagement_frm.Show()
        Me.Hide()
    End Sub

    Private Sub SalaryProcessinglbl_Click(sender As Object, e As EventArgs) Handles SalaryProcessinglbl.Click
        SalaryProcessing_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Payslipslbl_Click(sender As Object, e As EventArgs) Handles Payslipslbl.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub lblManageEmployees_Click(sender As Object, e As EventArgs) Handles lblManageEmployees.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

End Class