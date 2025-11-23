Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Attendance
    Private originalValues As New Dictionary(Of String, Object)

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LockFields()
        DisableAllTimeButtons()
        PopulateAttendanceStatusCombo()
        dtpDateAttendance.Value = DateTime.Today
        dtpDateAttendance.Enabled = False
        btnRecordAttendance.Enabled = True
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False

        If CurrentUser.UserType = "Staff" Then
            lblManagement.Visible = False
            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If

        LoadAttendanceData()
    End Sub

    Private Sub LoadAttendanceData()
        Try
            Dim query As String = "
                SELECT 
                    a.AttendanceID,
                    e.EmployeeID,
                    CONCAT(e.`First Name`, ' ', e.MiddleName, ' ', e.LastName) AS EmployeeName,
                    j.JobTitle,
                    a.AttendanceStatus,
                    IFNULL(a.TotalHours, 0) AS TotalHours,
                    IFNULL(a.ExceededHours, 0) AS ExceededHours,
                    IFNULL(a.Absences, 0) AS Absences,
                    IFNULL(a.DaysAttended, 0) AS DaysAttended,
                    DATE(a.Date) AS Date,
                    a.TimeIn_AM,
                    a.TimeOut_AM,
                    a.TimeIn_PM,
                    a.TimeOut_PM
                FROM tblattendance a
                INNER JOIN tblemployee e ON a.EmployeeID = e.EmployeeID
                INNER JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                WHERE a.EmployeeID=@empID
                ORDER BY a.Date DESC;
            "
            Dim dt As DataTable = HRMModule.ExecuteQuery(query, New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", CurrentUser.EmployeeID)
            })
            dgvAttendanceHistory.DataSource = dt
            ConfigureGrid()
        Catch ex As Exception
            MessageBox.Show("Error loading attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigureGrid()
        dgvAttendanceHistory.Columns("AttendanceID").HeaderText = "Attendance ID"
        dgvAttendanceHistory.Columns("EmployeeID").HeaderText = "Employee ID"
        dgvAttendanceHistory.Columns("EmployeeName").HeaderText = "Employee Name"
        dgvAttendanceHistory.Columns("JobTitle").HeaderText = "Job Title"
        dgvAttendanceHistory.Columns("AttendanceStatus").HeaderText = "Status"
        dgvAttendanceHistory.Columns("TotalHours").HeaderText = "Total Hours"
        dgvAttendanceHistory.Columns("ExceededHours").HeaderText = "Exceeded Hours"
        dgvAttendanceHistory.Columns("Absences").HeaderText = "Absences"
        dgvAttendanceHistory.Columns("DaysAttended").HeaderText = "Days Attended"
        dgvAttendanceHistory.Columns("Date").HeaderText = "Date"

        dgvAttendanceHistory.Columns("Date").DefaultCellStyle.Format = "yyyy-MM-dd"
        dgvAttendanceHistory.Columns("TotalHours").DefaultCellStyle.Format = "F2"
        dgvAttendanceHistory.Columns("ExceededHours").DefaultCellStyle.Format = "F2"

        dgvAttendanceHistory.Columns("EmployeeName").Visible = False
        dgvAttendanceHistory.Columns("JobTitle").Visible = False
        dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LockFields()
        txtAttendanceID.ReadOnly = True
        txtEmployeeID.ReadOnly = True
        txtEmployeeName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        dtpCheckInAM.Enabled = False
        dtpCheckOutAM.Enabled = False
        dtpCheckInPM.Enabled = False
        dtpCheckOutPM.Enabled = False
        dtpDateAttendance.Enabled = False
        cbAttendanceStatus.Enabled = False
    End Sub

    Private Sub PopulateAttendanceStatusCombo()
        cbAttendanceStatus.Items.Clear()
        cbAttendanceStatus.Items.AddRange(New String() {"Present", "Late", "Absent", "On Leave", "Break", "Lunch Break", "Left"})
        cbAttendanceStatus.SelectedIndex = -1
    End Sub

    Private Sub DisableAllTimeButtons()
        btnCheckInAM.Enabled = False
        btnCheckOutAM.Enabled = False
        btnCheckInPM.Enabled = False
        btnCheckOutPM.Enabled = False
    End Sub

    Private Sub UpdateAttendanceTime(columnName As String)
        Try
            Dim query As String = $"UPDATE tblattendance SET {columnName}=@time WHERE EmployeeID=@empID AND Date=@attDate"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@time", DateTime.Now.ToString("HH:mm:ss")),
                New MySqlParameter("@empID", CurrentUser.EmployeeID),
                New MySqlParameter("@attDate", dtpDateAttendance.Value.ToString("yyyy-MM-dd"))
            }
            HRMModule.ExecuteNonQuery(query, parameters)
            LoadAttendanceData()
            EnableAttendanceButtons()
        Catch ex As Exception
            MessageBox.Show("Error updating attendance time: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRecordAttendance_Click(sender As Object, e As EventArgs) Handles btnRecordAttendance.Click
        RecordOrUpdateAttendance()
        EnableAttendanceButtons()
        MessageBox.Show("Attendance ready to record times.")
        btnRecordAttendance.Visible = False
        btnEditAttendance.Visible = True
    End Sub

    Private Sub RecordOrUpdateAttendance()
        Try
            Dim query As String = "
                INSERT INTO tblattendance(AttendanceID, EmployeeID, Date) 
                VALUES(@attID, @empID, @attDate)
                ON DUPLICATE KEY UPDATE Date=@attDate;
            "
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@attID", CurrentUser.EmployeeID),
                New MySqlParameter("@empID", CurrentUser.EmployeeID),
                New MySqlParameter("@attDate", dtpDateAttendance.Value.ToString("yyyy-MM-dd"))
            }
            HRMModule.ExecuteNonQuery(query, parameters)
            LoadAttendanceData()
        Catch ex As Exception
            MessageBox.Show("Error recording attendance: " & ex.Message)
        End Try
    End Sub

    Private Function IsTodaySelected() As Boolean
        Return dtpDateAttendance.Value.Date = DateTime.Today
    End Function

    Private Sub EnableAttendanceButtons()
        If Not IsTodaySelected() Then
            DisableAllTimeButtons()
            Return
        End If

        Dim TimeInAM = originalValues.GetValueOrDefault("TimeIn_AM")
        Dim TimeOutAM = originalValues.GetValueOrDefault("TimeOut_AM")
        Dim TimeInPM = originalValues.GetValueOrDefault("TimeIn_PM")
        Dim TimeOutPM = originalValues.GetValueOrDefault("TimeOut_PM")

        btnCheckInAM.Enabled = (TimeInAM Is Nothing)
        btnCheckOutAM.Enabled = (TimeInAM IsNot Nothing AndAlso TimeOutAM Is Nothing)
        btnCheckInPM.Enabled = (TimeInPM Is Nothing)
        btnCheckOutPM.Enabled = (TimeInPM IsNot Nothing AndAlso TimeOutPM Is Nothing)
    End Sub

    Private Function GetAttendanceValue(columnName As String) As Object
        Try
            Dim query As String = $"SELECT {columnName} FROM tblattendance WHERE EmployeeID=@empID AND Date=@attDate"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", CurrentUser.EmployeeID),
                New MySqlParameter("@attDate", dtpDateAttendance.Value.ToString("yyyy-MM-dd"))
            }
            Dim dt As DataTable = HRMModule.ExecuteQuery(query, parameters)
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                Return dt.Rows(0)(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading attendance: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub btnEditAttendance_Click(sender As Object, e As EventArgs) Handles btnEditAttendance.Click
        Try
            btnEditAttendance.Visible = False
            btnSaveAttendance.Visible = True
            btnCancelAttendance.Visible = True

            originalValues.Clear()

            Dim query As String = "
                SELECT TimeIn_AM, TimeOut_AM, TimeIn_PM, TimeOut_PM, AttendanceStatus
                FROM tblattendance
                WHERE EmployeeID=@empID AND Date=@attDate
            "
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", CurrentUser.EmployeeID),
                New MySqlParameter("@attDate", dtpDateAttendance.Value.ToString("yyyy-MM-dd"))
            }
            Dim dt As DataTable = HRMModule.ExecuteQuery(query, parameters)

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                originalValues("TimeIn_AM") = If(row("TimeIn_AM") Is DBNull.Value OrElse row("TimeIn_AM").ToString() = "00:00:00", Nothing, row("TimeIn_AM"))
                originalValues("TimeOut_AM") = If(row("TimeOut_AM") Is DBNull.Value OrElse row("TimeOut_AM").ToString() = "00:00:00", Nothing, row("TimeOut_AM"))
                originalValues("TimeIn_PM") = If(row("TimeIn_PM") Is DBNull.Value OrElse row("TimeIn_PM").ToString() = "00:00:00", Nothing, row("TimeIn_PM"))
                originalValues("TimeOut_PM") = If(row("TimeOut_PM") Is DBNull.Value OrElse row("TimeOut_PM").ToString() = "00:00:00", Nothing, row("TimeOut_PM"))
                originalValues("AttendanceStatus") = If(row("AttendanceStatus") Is DBNull.Value, Nothing, row("AttendanceStatus"))
            End If

            EnableAttendanceButtons()
        Catch ex As Exception
            MessageBox.Show("Error editing attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Try
            LoadAttendanceData()
            MessageBox.Show("Attendance saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message)
        Finally
            btnSaveAttendance.Visible = False
            btnCancelAttendance.Visible = False
            btnEditAttendance.Visible = True
            DisableAllTimeButtons()
        End Try
    End Sub

    Private Sub btnCancelAttendance_Click(sender As Object, e As EventArgs) Handles btnCancelAttendance.Click
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
        btnEditAttendance.Visible = True
        DisableAllTimeButtons()
        LoadAttendanceData()
        MessageBox.Show("Attendance editing cancelled.")
    End Sub

    Private Sub UpdateTotalHours()
        Try
            Dim query As String = "
                UPDATE tblattendance
                SET TotalHours = 
                    (IFNULL(TIMESTAMPDIFF(SECOND, TimeIn_AM, TimeOut_AM),0) +
                     IFNULL(TIMESTAMPDIFF(SECOND, TimeIn_PM, TimeOut_PM),0)) / 3600
                WHERE EmployeeID=@empID AND Date=@attDate
            "
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", CurrentUser.EmployeeID),
                New MySqlParameter("@attDate", dtpDateAttendance.Value.Date)
            }
            HRMModule.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            MessageBox.Show("Error updating total hours: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCheckInAM_Click(sender As Object, e As EventArgs) Handles btnCheckInAM.Click
        UpdateAttendanceTime("TimeIn_AM")
        btnCheckInAM.Enabled = False
        cbAttendanceStatus.SelectedItem = "Present"
        MessageBox.Show("AM Check-in recorded.")
    End Sub

    Private Sub btnCheckOutAM_Click(sender As Object, e As EventArgs) Handles btnCheckOutAM.Click
        UpdateAttendanceTime("TimeOut_AM")
        btnCheckOutAM.Enabled = False
        cbAttendanceStatus.SelectedItem = "Left"
        MessageBox.Show("AM Check-out recorded.")
    End Sub

    Private Sub btnCheckInPM_Click(sender As Object, e As EventArgs) Handles btnCheckInPM.Click
        UpdateAttendanceTime("TimeIn_PM")
        btnCheckInPM.Enabled = False
        cbAttendanceStatus.SelectedItem = "Present"
        MessageBox.Show("PM Check-in recorded.")
    End Sub

    Private Sub btnCheckOutPM_Click(sender As Object, e As EventArgs) Handles btnCheckOutPM.Click
        UpdateAttendanceTime("TimeOut_PM")
        UpdateTotalHours()
        btnCheckOutPM.Enabled = False
        cbAttendanceStatus.SelectedItem = "Left"
        MessageBox.Show("PM Check-out recorded and total hours updated.")
    End Sub

    Private Sub dgvAttendanceHistory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAttendanceHistory.SelectionChanged
        If dgvAttendanceHistory.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvAttendanceHistory.SelectedRows(0)
            txtAttendanceID.Text = row.Cells("AttendanceID").Value.ToString()
            txtEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
            txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
            txtJobTitle.Text = row.Cells("JobTitle").Value.ToString()
        End If
    End Sub

    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
        Employee_Trainings.Show()
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

    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            HRMModule.SignOut(Me)
            MessageBox.Show("You have been signed out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class
