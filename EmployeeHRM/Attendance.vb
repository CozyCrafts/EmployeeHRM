Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Attendance
    Private dbtable As DataTable
    Private dbadapter As MySqlDataAdapter
    Private originalValues As New Dictionary(Of String, Object)

    ' Load form
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LockFields()
        DisableAllTimeButtons()
        PopulateAttendanceStatusCombo()
        dtpDateAttendance.Value = DateTime.Today
        dtpDateAttendance.Enabled = False
        btnRecordAttendance.Enabled = True
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False

        If LoggedInUserType = "Staff" Then
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
            Using con As MySqlConnection = HRMModule.GetConnection()
                con.Open()
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
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                    dbadapter = New MySqlDataAdapter(cmd)
                    dbtable = New DataTable()
                    dbadapter.Fill(dbtable)
                End Using
            End Using

            dgvAttendanceHistory.DataSource = dbtable
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
            Using con As MySqlConnection = HRMModule.GetConnection()
                con.Open()

                Dim insertQuery As String = "
                    INSERT INTO tblattendance(EmployeeID, Date)
                    SELECT @empID, @attDate
                    WHERE NOT EXISTS (
                        SELECT 1 FROM tblattendance WHERE EmployeeID=@empID AND Date=@attDate
                    );"
                Using cmdInsert As New MySqlCommand(insertQuery, con)
                    cmdInsert.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                    cmdInsert.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                    cmdInsert.ExecuteNonQuery()
                End Using

                Dim updateQuery As String = $"UPDATE tblattendance SET {columnName}=@time WHERE EmployeeID=@empID AND Date=@attDate"
                Using cmdUpdate As New MySqlCommand(updateQuery, con)
                    cmdUpdate.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"))
                    cmdUpdate.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                    cmdUpdate.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using

            LoadAttendanceData()
        Catch ex As Exception
            MessageBox.Show("Error updating attendance time: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRecordAttendance_Click(sender As Object, e As EventArgs) Handles btnRecordAttendance.Click
        Try
            Using con As MySqlConnection = HRMModule.GetConnection()
                con.Open()

                Dim cmdCheck As New MySqlCommand("SELECT AttendanceID FROM tblattendance WHERE EmployeeID=@empID AND Date=@attDate", con)
                cmdCheck.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                cmdCheck.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                Dim attendanceID = cmdCheck.ExecuteScalar()

                If attendanceID Is Nothing Then
                    Dim insertQuery As String = "INSERT INTO tblattendance(EmployeeID, Date) VALUES(@empID, @attDate)"
                    Using cmdInsert As New MySqlCommand(insertQuery, con)
                        cmdInsert.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                        cmdInsert.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                End If

                Dim clearTimesQuery As String = "
                UPDATE tblattendance
                SET TimeIn_AM=NULL, TimeOut_AM=NULL, TimeIn_PM=NULL, TimeOut_PM=NULL
                WHERE EmployeeID=@empID AND Date=@attDate"
                Using cmdClear As New MySqlCommand(clearTimesQuery, con)
                    cmdClear.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                    cmdClear.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                    cmdClear.ExecuteNonQuery()
                End Using
            End Using

            btnRecordAttendance.Visible = False
            btnEditAttendance.Visible = True
            btnSaveAttendance.Visible = False
            btnCancelAttendance.Visible = False

            DisableAllTimeButtons()
            LoadAttendanceData()
            MessageBox.Show("Attendance ready to record times.")
        Catch ex As Exception
            MessageBox.Show("Error recording attendance: " & ex.Message)
        End Try
    End Sub


    Private Sub btnEditAttendance_Click(sender As Object, e As EventArgs) Handles btnEditAttendance.Click
        Try
            OpenCon()
            btnEditAttendance.Visible = False
            btnSaveAttendance.Visible = True
            btnCancelAttendance.Visible = True
            originalValues.Clear()

            Dim query As String = "SELECT TimeIn_AM, TimeOut_AM, TimeIn_PM, TimeOut_PM, AttendanceStatus FROM tblattendance WHERE EmployeeID=@empID AND Date=@attDate"
            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        originalValues("TimeIn_AM") = If(IsDBNull(reader("TimeIn_AM")), Nothing, reader("TimeIn_AM"))
                        originalValues("TimeOut_AM") = If(IsDBNull(reader("TimeOut_AM")), Nothing, reader("TimeOut_AM"))
                        originalValues("TimeIn_PM") = If(IsDBNull(reader("TimeIn_PM")), Nothing, reader("TimeIn_PM"))
                        originalValues("TimeOut_PM") = If(IsDBNull(reader("TimeOut_PM")), Nothing, reader("TimeOut_PM"))
                        originalValues("AttendanceStatus") = If(IsDBNull(reader("AttendanceStatus")), Nothing, reader("AttendanceStatus"))

                        btnCheckInAM.Enabled = IsNothing(originalValues("TimeIn_AM"))
                        btnCheckOutAM.Enabled = Not IsNothing(originalValues("TimeIn_AM")) AndAlso IsNothing(originalValues("TimeOut_AM"))
                        btnCheckInPM.Enabled = IsNothing(originalValues("TimeIn_PM"))
                        btnCheckOutPM.Enabled = Not IsNothing(originalValues("TimeIn_PM")) AndAlso IsNothing(originalValues("TimeOut_PM"))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error editing attendance: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub

    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Try
            OpenCon()

            LoadAttendanceData()
            MessageBox.Show("Attendance saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message)
        Finally
            btnSaveAttendance.Visible = False
            btnCancelAttendance.Visible = False
            btnEditAttendance.Visible = True
            DisableAllTimeButtons()
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
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
        btnCheckOutPM.Enabled = False
        cbAttendanceStatus.SelectedItem = "Left"
        MessageBox.Show("PM Check-out recorded.")
    End Sub

    ' Grid selection
    Private Sub dgvAttendanceHistory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAttendanceHistory.SelectionChanged
        If dgvAttendanceHistory.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvAttendanceHistory.SelectedRows(0)
            txtAttendanceID.Text = row.Cells("AttendanceID").Value.ToString()
            txtEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
            txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
            txtJobTitle.Text = row.Cells("JobTitle").Value.ToString()
        End If
    End Sub


    ' Navigation labels
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

    ' Sign out
    Private Sub btnSignOut_Click_1(sender As Object, e As EventArgs) Handles btnSignOut.Click
        If MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Login_frm.ClearLoginFields()
            LoggedInEmployeeID = ""
            LoggedInUsername = ""
            LoggedInUserType = ""
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub
End Class
