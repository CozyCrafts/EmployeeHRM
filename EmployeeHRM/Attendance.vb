Imports MySql.Data.MySqlClient

Public Class Attendance
    Public Property UserRole As String

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoggedInUserType = "Staff" Then

            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If
        Try
            OpenCon() ' Ensure database connection is open

            Dim query As String = "SELECT date, time_in, time_out, status FROM tblattendance WHERE employee_id = @empID ORDER BY date DESC"
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)

            dbadapter = New MySqlDataAdapter(dbcmd)
            dbtable = New DataTable()
            dbadapter.Fill(dbtable)

            ' Bind the data to DataGridView
            dgvAttendanceHistory.DataSource = dbtable

        Catch ex As Exception
            MessageBox.Show("Error loading attendance: " & ex.Message)
        End Try
    End Sub

    ' --- Navigation buttons ---
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Employee_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        MyProfile.Show()
        Me.Hide()
    End Sub

    Private Sub lblAttendance_Click(sender As Object, e As EventArgs) Handles lblAttendance.Click
        lblAttendance.Enabled = False
    End Sub

    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        Leave_Management.Show()
        Me.Hide()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        Salary.Show()
        Me.Hide()
    End Sub

    Private Sub lblTrainings_Click(sender As Object, e As EventArgs) Handles lblTrainings.Click
        Trainings.Show()
        Me.Hide()
    End Sub

    Private Sub lblTeamOverview_Click(sender As Object, e As EventArgs) Handles lblTeamOverview.Click
        Team_Overview.Show()
        Me.Hide()
    End Sub

    Private Sub lblAttendanceTracker_Click(sender As Object, e As EventArgs) Handles lblAttendanceTracker.Click
        Attendance_Tracker.Show()
        Me.Hide()
    End Sub

    Private Sub lblLeaveApproval_Click(sender As Object, e As EventArgs) Handles lblLeaveApproval.Click
        Leave_Approval.Show()
        Me.Hide()
    End Sub

    Private Sub lblPayrollSummary_Click(sender As Object, e As EventArgs) Handles lblPayrollSummary.Click
        Payroll_Summary.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmployeeTrainings_Click(sender As Object, e As EventArgs) Handles lblEmployeeTrainings.Click
        Employee_Trainings.Show()
        Me.Hide()
    End Sub

    Private Sub lblDepartment_Click(sender As Object, e As EventArgs) Handles lblDepartment.Click
        Department.Show()
        Me.Hide()
    End Sub

    Private Sub lblAmenities_Click(sender As Object, e As EventArgs) Handles lblAmenities.Click
        Amenities.Show()
        Me.Hide()
    End Sub


    Private Sub btnSignOut_Click_1(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result = MessageBox.Show(
         "Are you sure you want to sign out?",
         "Confirm Sign Out",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
     )
        If result = DialogResult.Yes Then
            Login_frm.ClearLoginFields()
            LoggedInEmployeeID = ""
            LoggedInUsername = ""
            LoggedInUserType = ""
            Login_frm.Show()
            Hide()
        End If
    End Sub
End Class
