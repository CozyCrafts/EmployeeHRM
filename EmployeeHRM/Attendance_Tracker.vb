Imports MySql.Data.MySqlClient

Public Class Attendance_Tracker

    ' 🔹 Use the same database connection format as Payroll_Summary
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"

    Private Sub Attendance_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendanceList()
    End Sub

    ' =========================================
    ' ========== LOAD ATTENDANCE DATA ==========
    ' =========================================
    Private Sub LoadAttendanceList()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                    SELECT 
                        e.EmployeeID,
                        CONCAT_WS(' ', e.`First Name`, e.MiddleName, e.LastName) AS EmployeeName,
                        a.AttendanceStatus,
                        a.TotalHours,
                        a.ExceededHours,
                        a.Absences,
                        a.DaysAttended,
                        a.Date,
                        a.TimeIn_AM,
                        a.TimeOut_AM,
                        a.TimeIn_PM,
                        a.TimeOut_PM
                    FROM tblemployee e
                    LEFT JOIN tblattendance a ON e.EmployeeID = a.EmployeeID
                    ORDER BY a.Date DESC;
                "

                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim attendanceTable As New DataTable()
                        adapter.Fill(attendanceTable)
                        dgvAttendanceList.DataSource = attendanceTable
                    End Using
                End Using
            End Using

            ' Optional: make the grid look cleaner
            dgvAttendanceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAttendanceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAttendanceList.ReadOnly = True
            dgvAttendanceList.AllowUserToAddRows = False
            dgvAttendanceList.AllowUserToDeleteRows = False

        Catch ex As Exception
            MessageBox.Show("Error loading attendance list: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Manager_Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        MyProfile.Show()
        Me.Hide()
    End Sub
    Private Sub lblAttendance_Click(sender As Object, e As EventArgs) Handles lblAttendance.Click
        Attendance.Show()
        Hide()
    End Sub
    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        Leave_Management.Show()
        Hide()
    End Sub
    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        Salary.Show()
        Hide()
    End Sub
    Private Sub lblTrainings_Click(sender As Object, e As EventArgs) Handles lblTrainings.Click
        Trainings.Show()
        Hide()
    End Sub
    Private Sub lblTeamOverview_Click(sender As Object, e As EventArgs) Handles lblTeamOverview.Click
        Team_Overview.Show()
        Me.Hide()

    End Sub
    Private Sub lblAttendanceTracker_Click(sender As Object, e As EventArgs) Handles lblAttendanceTracker.Click
        lblAttendanceTracker.Enabled = False

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
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to sign out?",
            "Confirm Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If result = DialogResult.Yes Then
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub

End Class