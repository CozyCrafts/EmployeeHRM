Imports MySql.Data.MySqlClient
Public Class EmployeeManagement_frm
    Private Sub EmployeeManagement_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As MySqlConnection
        Dim command As New MySqlCommand
        Dim dbadapter As MySqlDataAdapter
        Dim table As DataTable

        Me.FormBorderStyle = FormBorderStyle.None

        Try
            connection = New MySqlConnection("server=localhost;username=root;password=admin;database=db_hrm;")
            OpenCon()
            command.Connection = connection
            dbadapter = New MySqlDataAdapter("SELECT * FROM tbltesting", connection)
            table = New DataTable
            dbadapter.Fill(table)

            DataGridView1.DataSource = table

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click

    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Profile_frm.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmployees_Click(sender As Object, e As EventArgs) Handles lblEmployees.Click
        EmployeeAttendance_frm.Show()
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
        Payroll_frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub


End Class