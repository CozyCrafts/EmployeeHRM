Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Attendance
    Private originalValues As New Dictionary(Of String, Object)
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LockFields()
        DisableAllTimeButtons()
        LoadAttendanceData()
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
    End Sub
    Private Sub LoadAttendanceData()
        Try
            OpenCon()

            Dim query As String = "
            SELECT 
                a.AttendanceID,
                e.EmployeeID,
                CONCAT(e.`First Name`, ' ', e.MiddleName, ' ', e.LastName) AS EmployeeName,
                j.JobTitle,
                a.AttendanceStatus,
                a.TotalHours,
                a.ExceededHours,
                a.Absences,
                a.DaysAttended,
                DATE(a.Date) AS Date,
                a.TimeIn_AM,
                a.TimeOut_AM,
                a.TimeIn_PM,
                a.TimeOut_PM
            FROM tblattendance a
            INNER JOIN tblemployee e ON a.EmployeeID = e.EmployeeID
            INNER JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
            WHERE a.EmployeeID = @empID;
        "

            Dim cmd As New MySqlCommand(query, dbcon)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)

            dbadapter = New MySqlDataAdapter(cmd)
            dbtable = New DataTable()
            dbadapter.Fill(dbtable)

            For Each r As DataRow In dbtable.Rows
                If Not IsDBNull(r("Date")) Then
                    r("Date") = CDate(r("Date")).Date
                End If
            Next

            dgvAttendanceHistory.DataSource = dbtable

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
            dgvAttendanceHistory.Columns("EmployeeName").Visible = False
            dgvAttendanceHistory.Columns("JobTitle").Visible = False
            dgvAttendanceHistory.Columns("Date").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvAttendanceHistory.Columns("TotalHours").DefaultCellStyle.Format = "F2"
            dgvAttendanceHistory.Columns("ExceededHours").DefaultCellStyle.Format = "F2"

            Dim timeCols = New String() {"TimeIn_AM", "TimeOut_AM", "TimeIn_PM", "TimeOut_PM"}
            For Each tc In timeCols
                If dgvAttendanceHistory.Columns.Contains(tc) Then
                    dgvAttendanceHistory.Columns(tc).DefaultCellStyle.Format = "HH:mm:ss"
                End If
            Next

            dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception
            MessageBox.Show("LoadAttendanceData error: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
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
    Private Function GetTimeSpanRobust(raw As String) As TimeSpan
        If String.IsNullOrWhiteSpace(raw) Then Return TimeSpan.Zero

        Dim s = raw.Trim()
        Dim ts As TimeSpan
        If TimeSpan.TryParse(s, ts) Then
            Return ts
        End If
        Dim dt As DateTime
        If DateTime.TryParse(s, dt) Then
            Return dt.TimeOfDay
        End If
        Dim parts = s.Split(" "c)(0)
        If TimeSpan.TryParse(parts, ts) Then Return ts

        Dim m = System.Text.RegularExpressions.Regex.Match(s, "(\d{1,2})[:\s](\d{1,2})([:\s](\d{1,2}))?")
        If m.Success Then
            Dim hh = Integer.Parse(m.Groups(1).Value)
            Dim mm = Integer.Parse(m.Groups(2).Value)
            Dim ss = 0
            If m.Groups(4).Success Then Integer.TryParse(m.Groups(4).Value, ss)
            Return New TimeSpan(hh, mm, ss)
        End If

        Return TimeSpan.Zero
    End Function
    Private Sub UpdateAttendanceTime(columnName As String, dtp As DateTimePicker)
        Try
            OpenCon()

            Dim updateQuery As String = $"UPDATE tblattendance 
                                         SET {columnName}=@time, Date=@today
                                         WHERE EmployeeID=@empID"

            Using cmdUpdate As New MySqlCommand(updateQuery, dbcon)
                cmdUpdate.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"))
                cmdUpdate.Parameters.AddWithValue("@today", dtpDateAttendance.Value.Date)
                cmdUpdate.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                Dim affected = cmdUpdate.ExecuteNonQuery()
                If affected = 0 Then
                    MessageBox.Show("No attendance record exists for this employee. Please contact admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    RecalculateTotals()
                    RecalculateDaysAttended()
                    LoadAttendanceData()
                    Dim btn As Button = TryCast(dtp.Tag, Button)
                    If btn IsNot Nothing Then btn.Enabled = False
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating attendance: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Private Sub RecalculateTotals()
        Try
            OpenCon()
            Dim query As String = "SELECT TimeIn_AM, TimeOut_AM, TimeIn_PM, TimeOut_PM FROM tblattendance WHERE EmployeeID=@empID AND Date=@attDate"
            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim tInAM = GetTimeSpanFromDb(reader("TimeIn_AM"))
                        Dim tOutAM = GetTimeSpanFromDb(reader("TimeOut_AM"))
                        Dim tInPM = GetTimeSpanFromDb(reader("TimeIn_PM"))
                        Dim tOutPM = GetTimeSpanFromDb(reader("TimeOut_PM"))
                        reader.Close()

                        Dim totalHours As Double = 0
                        If tOutAM > tInAM Then totalHours += (tOutAM - tInAM).TotalHours
                        If tOutPM > tInPM Then totalHours += (tOutPM - tInPM).TotalHours

                        Dim standardHours As Double = 8
                        Dim exceededHours As Double = Math.Max(0, totalHours - standardHours)
                        Dim absence As Integer = If(totalHours < 4, 1, 0)

                        Dim updateQuery As String = "
                            UPDATE tblattendance
                            SET TotalHours=@total,
                                ExceededHours=@exceed,
                                Absences=@abs
                            WHERE EmployeeID=@empID AND Date=@attDate"
                        Using cmdUpdate As New MySqlCommand(updateQuery, dbcon)
                            cmdUpdate.Parameters.AddWithValue("@total", totalHours)
                            cmdUpdate.Parameters.AddWithValue("@exceed", exceededHours)
                            cmdUpdate.Parameters.AddWithValue("@abs", absence)
                            cmdUpdate.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                            cmdUpdate.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                            cmdUpdate.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error recalculating totals: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Private Function GetTimeSpanFromDb(obj As Object) As TimeSpan
        If IsDBNull(obj) OrElse String.IsNullOrEmpty(obj.ToString()) Then Return TimeSpan.Zero
        Dim ts As TimeSpan
        If TimeSpan.TryParse(obj.ToString(), ts) Then Return ts
        Return TimeSpan.Zero
    End Function
    Private Sub RecalculateDaysAttended()
        Try
            OpenCon()
            Dim query As String = "
                UPDATE tblattendance a
                JOIN (
                    SELECT EmployeeID, COUNT(*) AS DaysCount
                    FROM tblattendance
                    WHERE EmployeeID=@empID AND TotalHours > 0 AND MONTH(Date)=MONTH(@attDate) AND YEAR(Date)=YEAR(@attDate)
                    GROUP BY EmployeeID
                ) b ON a.EmployeeID=b.EmployeeID
                SET a.DaysAttended=b.DaysCount
                WHERE a.EmployeeID=@empID"
            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error recalculating days attended: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Private Sub btnRecordAttendance_Click(sender As Object, e As EventArgs) Handles btnRecordAttendance.Click
        Try
            OpenCon()

            Dim cmdCheck As New MySqlCommand("SELECT AttendanceID FROM tblattendance WHERE EmployeeID=@empID", dbcon)
            cmdCheck.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            Dim attendanceID = cmdCheck.ExecuteScalar()

            If attendanceID IsNot Nothing Then
                Dim clearQuery As String = "
                UPDATE tblattendance
                SET Date=@attDate,
                    TimeIn_AM=NULL,
                    TimeOut_AM=NULL,
                    TimeIn_PM=NULL,
                    TimeOut_PM=NULL,
                    AttendanceStatus=NULL
                WHERE EmployeeID=@empID
            "
                Using cmdClear As New MySqlCommand(clearQuery, dbcon)
                    cmdClear.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                    cmdClear.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                    cmdClear.ExecuteNonQuery()
                End Using

                btnRecordAttendance.Visible = False

                Dim nowTime As TimeSpan = DateTime.Now.TimeOfDay

                btnCheckInAM.Enabled = False
                btnCheckOutAM.Enabled = False
                btnCheckInPM.Enabled = False
                btnCheckOutPM.Enabled = False
                If nowTime < TimeSpan.Parse("12:00") Then
                    btnCheckInAM.Enabled = True
                    MessageBox.Show($"You may check-in AM at {DateTime.Now:HH:mm} on {DateTime.Today:yyyy-MM-dd}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    btnCheckInPM.Enabled = True
                    MessageBox.Show($"You may check-in PM at {DateTime.Now:HH:mm} on {DateTime.Today:yyyy-MM-dd}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                btnEditAttendance.Visible = True
                btnSaveAttendance.Visible = True
                btnCancelAttendance.Visible = True

                LoadAttendanceData()
            Else
                MessageBox.Show("No attendance record exists for this employee. Please contact admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error recording attendance: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
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

                        btnCheckOutAM.Enabled = IsDBNull(reader("TimeOut_AM")) AndAlso Not IsDBNull(reader("TimeIn_AM"))
                        btnCheckOutPM.Enabled = IsDBNull(reader("TimeOut_PM")) AndAlso Not IsDBNull(reader("TimeIn_PM"))

                        btnCheckInAM.Enabled = False
                        btnCheckInPM.Enabled = False
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
            Dim currentValues As New Dictionary(Of String, Object)
            Dim query As String = "SELECT TimeIn_AM, TimeOut_AM, TimeIn_PM, TimeOut_PM, AttendanceStatus FROM tblattendance WHERE EmployeeID=@empID AND Date=@attDate"
            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@attDate", dtpDateAttendance.Value.Date)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        currentValues("TimeIn_AM") = If(IsDBNull(reader("TimeIn_AM")), Nothing, reader("TimeIn_AM"))
                        currentValues("TimeOut_AM") = If(IsDBNull(reader("TimeOut_AM")), Nothing, reader("TimeOut_AM"))
                        currentValues("TimeIn_PM") = If(IsDBNull(reader("TimeIn_PM")), Nothing, reader("TimeIn_PM"))
                        currentValues("TimeOut_PM") = If(IsDBNull(reader("TimeOut_PM")), Nothing, reader("TimeOut_PM"))
                        currentValues("AttendanceStatus") = If(IsDBNull(reader("AttendanceStatus")), Nothing, reader("AttendanceStatus"))
                    End If
                End Using
            End Using
            Dim changed As Boolean = False
            For Each key In originalValues.Keys
                If Not Object.Equals(originalValues(key), currentValues(key)) Then
                    changed = True
                    Exit For
                End If
            Next

            If Not changed Then
                MessageBox.Show("No changes were made.")
            Else
                RecalculateTotals()
                RecalculateDaysAttended()
                LoadAttendanceData()
                MessageBox.Show("Attendance saved successfully!")
            End If

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
        UpdateAttendanceTime("TimeIn_AM", dtpCheckInAM)
        SetAttendanceStatusAfterCheckIn()
        btnCheckInAM.Enabled = False
        btnSaveAttendance.Visible = True
        btnCancelAttendance.Visible = True
    End Sub
    Private Sub btnCheckOutAM_Click(sender As Object, e As EventArgs) Handles btnCheckOutAM.Click
        UpdateAttendanceTime("TimeOut_AM", dtpCheckOutAM)
        SetAttendanceStatusAfterCheckOut()
        btnCheckOutAM.Enabled = False
    End Sub
    Private Sub btnCheckInPM_Click(sender As Object, e As EventArgs) Handles btnCheckInPM.Click
        UpdateAttendanceTime("TimeIn_PM", dtpCheckInPM)
        SetAttendanceStatusAfterCheckIn()
        btnCheckInPM.Enabled = False
        btnSaveAttendance.Visible = True
        btnCancelAttendance.Visible = True
    End Sub
    Private Sub btnCheckOutPM_Click(sender As Object, e As EventArgs) Handles btnCheckOutPM.Click
        UpdateAttendanceTime("TimeOut_PM", dtpCheckOutPM)
        SetAttendanceStatusAfterCheckOut()
        btnCheckOutPM.Enabled = False
    End Sub
    Private Sub SetAttendanceStatusAfterCheckIn()
        Dim shiftStartAM As TimeSpan = TimeSpan.Parse("08:00")
        Dim shiftStartPM As TimeSpan = TimeSpan.Parse("13:00")
        Dim nowTime As TimeSpan = DateTime.Now.TimeOfDay

        If nowTime <= shiftStartAM Or nowTime <= shiftStartPM Then
            cbAttendanceStatus.SelectedItem = "Present"
        Else
            cbAttendanceStatus.SelectedItem = "Late"
        End If
    End Sub
    Private Sub SetAttendanceStatusAfterCheckOut()
        Dim dtRow = dbtable.Select($"EmployeeID='{LoggedInEmployeeID}' AND Date=DATE('{DateTime.Today:yyyy-MM-dd}')")
        If dtRow.Length > 0 Then
            Dim row = dtRow(0)
            Dim amOut = If(IsDBNull(row("TimeOut_AM")), Nothing, row("TimeOut_AM"))
            Dim pmOut = If(IsDBNull(row("TimeOut_PM")), Nothing, row("TimeOut_PM"))

            If Not IsNothing(amOut) Or Not IsNothing(pmOut) Then
                cbAttendanceStatus.SelectedItem = "Left"
            End If
        End If
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
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login_frm.ClearLoginFields()
            LoggedInEmployeeID = ""
            LoggedInUsername = ""
            LoggedInUserType = ""
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub

End Class
