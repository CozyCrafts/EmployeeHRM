Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Attendance
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private dbcon As MySqlConnection = Nothing
    Private dbcmd As MySqlCommand = Nothing

    Private todayAttendanceID As String = ""
    Private originalValues As New Dictionary(Of String, Object)
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

        SetupDateAndTimePickers()
        LockAllFields()
        PopulateAttendanceStatusCombo()
        LoadAttendanceHistory()
        LoadEmployeeInfo()
        SetDefaultDateToToday()
        UpdateCheckButtonsState()
    End Sub
    Private Sub PopulateAttendanceStatusCombo()
        cbAttendanceStatus.Items.Clear()
        cbAttendanceStatus.Items.Add("Present")
        cbAttendanceStatus.Items.Add("Absent")
        cbAttendanceStatus.Items.Add("Late")
        cbAttendanceStatus.Items.Add("On Leave")
    End Sub
    Private Sub OpenCon()
        If dbcon Is Nothing Then dbcon = New MySqlConnection(connectionString)
        If dbcon.State = ConnectionState.Closed Then dbcon.Open()
    End Sub
    Private Sub CloseCon()
        If dbcon IsNot Nothing AndAlso dbcon.State <> ConnectionState.Closed Then dbcon.Close()
    End Sub
    Private Sub SetupDateAndTimePickers()
        dtpDateAttendance.Format = DateTimePickerFormat.Custom
        dtpDateAttendance.CustomFormat = "MMMM dd, yyyy"
        dtpDateAttendance.Enabled = False

        For Each dtp As DateTimePicker In {dtpCheckInAM, dtpCheckOutAM, dtpCheckInPM, dtpCheckOutPM}
            dtp.Format = DateTimePickerFormat.Custom
            dtp.CustomFormat = "HH:mm:ss"
            dtp.ShowUpDown = True
            dtp.Value = Date.Today
            dtp.Enabled = False
        Next
    End Sub
    Private Sub LockAllFields()
        txtAttendanceID.ReadOnly = True
        txtEmployeeID.ReadOnly = True
        txtEmployeeName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        cbAttendanceStatus.Enabled = False

        dtpDateAttendance.Enabled = False
        dtpCheckInAM.Enabled = False
        dtpCheckOutAM.Enabled = False
        dtpCheckInPM.Enabled = False
        dtpCheckOutPM.Enabled = False

        btnCheckInAM.Enabled = False
        btnCheckOutAM.Enabled = False
        btnCheckInPM.Enabled = False
        btnCheckOutPM.Enabled = False

        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
        btnRecordAttendance.Visible = True
    End Sub
    Private Sub UnlockForRecording()
        cbAttendanceStatus.Enabled = True
        dtpCheckInAM.Enabled = True
        dtpCheckOutAM.Enabled = True
        dtpCheckInPM.Enabled = True
        dtpCheckOutPM.Enabled = True

        btnSaveAttendance.Visible = True
        btnCancelAttendance.Visible = True
        btnRecordAttendance.Visible = False
    End Sub
    Private Sub SetDefaultDateToToday()
        dtpDateAttendance.Value = Date.Today
    End Sub
    Private Function GetHours(startTime As Object, endTime As Object) As Double
        Try
            If startTime Is Nothing OrElse startTime Is DBNull.Value Then Return 0
            If endTime Is Nothing OrElse endTime Is DBNull.Value Then Return 0

            Dim startDt As DateTime = Convert.ToDateTime(startTime)
            Dim endDt As DateTime = Convert.ToDateTime(endTime)

            Dim diff As TimeSpan = endDt - startDt
            If diff.TotalHours < 0 Then Return 0
            Return diff.TotalHours
        Catch
            Return 0
        End Try
    End Function
    Private Sub LoadAttendanceHistory()
        Try
            OpenCon()
            Dim sql As String = "SELECT * FROM tblattendance WHERE EmployeeID = @empID ORDER BY Date DESC"
            Using cmd As New MySqlCommand(sql, dbcon)
                cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Add calculated columns
                    If Not table.Columns.Contains("TotalHours") Then table.Columns.Add("TotalHours", GetType(Double))
                    If Not table.Columns.Contains("Absences") Then table.Columns.Add("Absences", GetType(Integer))
                    If Not table.Columns.Contains("DaysAttended") Then table.Columns.Add("DaysAttended", GetType(Integer))

                    Dim daysAttended As Integer = 0

                    For Each row As DataRow In table.Rows
                        ' Total hours worked
                        Dim totalHours As Double = 0
                        totalHours += GetHours(row("TimeIn_AM"), row("TimeOut_AM"))
                        totalHours += GetHours(row("TimeIn_PM"), row("TimeOut_PM"))
                        row("TotalHours") = Math.Round(totalHours, 2)

                        ' Count absences
                        If row("AttendanceStatus") IsNot DBNull.Value AndAlso row("AttendanceStatus").ToString().ToLower() = "absent" Then
                            row("Absences") = 1
                        Else
                            row("Absences") = 0
                            daysAttended += 1
                        End If

                        ' Set cumulative days attended
                        row("DaysAttended") = daysAttended
                    Next

                    dgvAttendanceHistory.DataSource = table
                    dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvAttendanceHistory.ReadOnly = True
                    dgvAttendanceHistory.AllowUserToAddRows = False
                    dgvAttendanceHistory.AllowUserToDeleteRows = False
                    dgvAttendanceHistory.AutoGenerateColumns = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading attendance history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------- LOAD EMPLOYEE INFO ----------
    Private Sub LoadEmployeeInfo()
        Try
            OpenCon()
            Dim q As String = "
            SELECT EmployeeID, `First Name`, MiddleName, LastName,
                   (SELECT JobTitle FROM tbljobdetails j WHERE j.EmployeeID = e.EmployeeID LIMIT 1) AS JobTitle
            FROM tblemployee e
            WHERE EmployeeID = @id LIMIT 1
        "
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@id", LoggedInEmployeeID)
                Using r As MySqlDataReader = cmd.ExecuteReader()
                    If r.Read() Then
                        txtEmployeeID.Text = r("EmployeeID").ToString()
                        txtEmployeeName.Text = String.Format("{0} {1} {2}",
                        r("First Name").ToString(),
                        r("MiddleName").ToString(),
                        r("LastName").ToString()).Trim()
                        txtJobTitle.Text = If(r("JobTitle") IsNot DBNull.Value, r("JobTitle").ToString(), "")
                    End If
                End Using
            End Using

            ' Load today's attendance
            LoadTodayAttendance()
        Catch ex As Exception
            MessageBox.Show("Error loading employee info: " & ex.Message)
        End Try
    End Sub

    ' ---------- LOAD TODAY ATTENDANCE ----------
    Private Sub LoadTodayAttendance()
        Try
            OpenCon()
            Dim q As String = "
            SELECT * FROM tblattendance 
            WHERE EmployeeID=@id AND `Date`=@date
        "
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@id", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@date", Date.Today.ToString("yyyy-MM-dd"))

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Add calculated columns
                    If Not table.Columns.Contains("TotalHours") Then table.Columns.Add("TotalHours", GetType(Double))
                    If Not table.Columns.Contains("Absences") Then table.Columns.Add("Absences", GetType(Integer))
                    If Not table.Columns.Contains("DaysAttended") Then table.Columns.Add("DaysAttended", GetType(Integer))

                    Dim daysAttended As Integer = 0

                    If table.Rows.Count > 0 Then
                        Dim row = table.Rows(0)
                        todayAttendanceID = row("AttendanceID").ToString()
                        txtAttendanceID.Text = todayAttendanceID

                        cbAttendanceStatus.Text = If(row("AttendanceStatus") IsNot DBNull.Value, row("AttendanceStatus").ToString(), "Present")

                        ' --- Safely assign times ---
                        dtpCheckInAM.Value = If(SafeDateTimeFromDb(row("TimeIn_AM")).HasValue, SafeDateTimeFromDb(row("TimeIn_AM")).Value, Date.Today)
                        dtpCheckOutAM.Value = If(SafeDateTimeFromDb(row("TimeOut_AM")).HasValue, SafeDateTimeFromDb(row("TimeOut_AM")).Value, Date.Today)
                        dtpCheckInPM.Value = If(SafeDateTimeFromDb(row("TimeIn_PM")).HasValue, SafeDateTimeFromDb(row("TimeIn_PM")).Value, Date.Today)
                        dtpCheckOutPM.Value = If(SafeDateTimeFromDb(row("TimeOut_PM")).HasValue, SafeDateTimeFromDb(row("TimeOut_PM")).Value, Date.Today)

                        ' Calculate TotalHours
                        Dim totalHours As Double = 0
                        totalHours += GetHours(row("TimeIn_AM"), row("TimeOut_AM"))
                        totalHours += GetHours(row("TimeIn_PM"), row("TimeOut_PM"))
                        row("TotalHours") = Math.Round(totalHours, 2)

                        ' Absences and DaysAttended
                        If row("AttendanceStatus") IsNot DBNull.Value AndAlso row("AttendanceStatus").ToString().ToLower() = "absent" Then
                            row("Absences") = 1
                            daysAttended = 0
                        Else
                            row("Absences") = 0
                            daysAttended = 1
                        End If
                        row("DaysAttended") = daysAttended

                        dgvAttendanceHistory.DataSource = table
                        dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        dgvAttendanceHistory.ReadOnly = True
                        dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        dgvAttendanceHistory.AllowUserToAddRows = False
                        dgvAttendanceHistory.AllowUserToDeleteRows = False
                        dgvAttendanceHistory.AutoGenerateColumns = True

                    Else
                        ' --- No record: create new row ---
                        Dim dt As New DataTable()
                        dt.Columns.Add("AttendanceID")
                        dt.Columns.Add("EmployeeID")
                        dt.Columns.Add("Date")
                        dt.Columns.Add("TimeIn_AM")
                        dt.Columns.Add("TimeOut_AM")
                        dt.Columns.Add("TimeIn_PM")
                        dt.Columns.Add("TimeOut_PM")
                        dt.Columns.Add("AttendanceStatus")
                        dt.Columns.Add("TotalHours", GetType(Double))
                        dt.Columns.Add("Absences", GetType(Integer))
                        dt.Columns.Add("DaysAttended", GetType(Integer))

                        Dim newRow = dt.NewRow()
                        todayAttendanceID = GenerateNextAttendanceID()
                        newRow("AttendanceID") = todayAttendanceID
                        newRow("EmployeeID") = LoggedInEmployeeID
                        newRow("Date") = Date.Today.ToString("yyyy-MM-dd")
                        newRow("AttendanceStatus") = "Present"
                        newRow("TimeIn_AM") = DBNull.Value
                        newRow("TimeOut_AM") = DBNull.Value
                        newRow("TimeIn_PM") = DBNull.Value
                        newRow("TimeOut_PM") = DBNull.Value
                        newRow("TotalHours") = 0
                        newRow("Absences") = 0
                        newRow("DaysAttended") = 1
                        dt.Rows.Add(newRow)

                        dgvAttendanceHistory.DataSource = dt
                        dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        dgvAttendanceHistory.ReadOnly = True
                        dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        dgvAttendanceHistory.AllowUserToAddRows = False
                        dgvAttendanceHistory.AllowUserToDeleteRows = False
                        dgvAttendanceHistory.AutoGenerateColumns = True

                        cbAttendanceStatus.Text = "Present"
                        dtpCheckInAM.Value = Date.Today
                        dtpCheckOutAM.Value = Date.Today
                        dtpCheckInPM.Value = Date.Today
                        dtpCheckOutPM.Value = Date.Today
                    End If
                End Using
            End Using

            UpdateCheckButtonsState()
        Catch ex As Exception
            MessageBox.Show("Error loading today's attendance: " & ex.Message)
        End Try
    End Sub

    Private Function SafeDateTimeFromDb(dbValue As Object) As Nullable(Of DateTime)
        Try
            If dbValue Is Nothing OrElse dbValue Is DBNull.Value Then Return Nothing
            Dim d As DateTime
            If DateTime.TryParse(dbValue.ToString(), d) Then
                Return d
            End If
            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub UpdateCheckButtonsState()
        btnCheckInAM.Enabled = False
        btnCheckOutAM.Enabled = False
        btnCheckInPM.Enabled = False
        btnCheckOutPM.Enabled = False

        Dim hasCheckInAM As Boolean = dtpCheckInAM.Value.TimeOfDay <> TimeSpan.Zero
        Dim hasCheckOutAM As Boolean = dtpCheckOutAM.Value.TimeOfDay <> TimeSpan.Zero
        Dim hasCheckInPM As Boolean = dtpCheckInPM.Value.TimeOfDay <> TimeSpan.Zero
        Dim hasCheckOutPM As Boolean = dtpCheckOutPM.Value.TimeOfDay <> TimeSpan.Zero

        Dim nowHour = DateTime.Now.Hour

        If nowHour < 12 Then
            If Not hasCheckInAM Then btnCheckInAM.Enabled = True
            If hasCheckInAM AndAlso Not hasCheckOutAM Then btnCheckOutAM.Enabled = True
        Else
            If Not hasCheckInPM Then btnCheckInPM.Enabled = True
            If hasCheckInPM AndAlso Not hasCheckOutPM Then btnCheckOutPM.Enabled = True
        End If

        btnRecordAttendance.Enabled = True
    End Sub
    Private Function GenerateNextAttendanceID() As String
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim lastID As String = ""
                Dim q As String = "SELECT AttendanceID FROM tblattendance ORDER BY AttendanceID DESC LIMIT 1"
                Using cmd As New MySqlCommand(q, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        lastID = result.ToString()
                    End If
                End Using

                If String.IsNullOrEmpty(lastID) Then Return "T001"

                ' Extract numeric part and increment
                Dim numericPart As Integer = 0
                If Integer.TryParse(lastID.Substring(1), numericPart) Then
                    numericPart += 1
                Else
                    numericPart = 1
                End If

                Return "T" & numericPart.ToString("D3")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating AttendanceID: " & ex.Message)
            Return "T001"
        End Try
    End Function

    ' ---------- RECORD ATTENDANCE BUTTON ----------
    Private Sub btnRecordAttendance_Click(sender As Object, e As EventArgs) Handles btnRecordAttendance.Click
        UnlockForRecording()
        cbAttendanceStatus.Text = If(String.IsNullOrEmpty(cbAttendanceStatus.Text), "Present", cbAttendanceStatus.Text)
        dtpDateAttendance.Value = Date.Today
        UpdateCheckButtonsState()

        ' Generate new AttendanceID as string
        todayAttendanceID = GenerateNextAttendanceID()
        txtAttendanceID.Text = todayAttendanceID

        StoreOriginalValues()
    End Sub
    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Try
            If String.IsNullOrWhiteSpace(cbAttendanceStatus.Text) AndAlso
           dtpCheckInAM.Value.TimeOfDay = TimeSpan.Zero AndAlso
           dtpCheckOutAM.Value.TimeOfDay = TimeSpan.Zero AndAlso
           dtpCheckInPM.Value.TimeOfDay = TimeSpan.Zero AndAlso
           dtpCheckOutPM.Value.TimeOfDay = TimeSpan.Zero Then
                MessageBox.Show("Please record a check-in/check-out or set an attendance status before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenCon()

            If Not String.IsNullOrEmpty(todayAttendanceID) AndAlso AttendanceExists(todayAttendanceID) Then
                ' UPDATE existing record
                Dim q As String = "
                UPDATE tblattendance
                SET AttendanceStatus=@status,
                    TimeIn_AM=@t_in_am, TimeOut_AM=@t_out_am,
                    TimeIn_PM=@t_in_pm, TimeOut_PM=@t_out_pm
                WHERE AttendanceID=@aid
            "
                Using cmd As New MySqlCommand(q, dbcon)
                    cmd.Parameters.AddWithValue("@status", cbAttendanceStatus.Text)
                    cmd.Parameters.AddWithValue("@t_in_am", FormatTimeForDb(dtpCheckInAM.Value))
                    cmd.Parameters.AddWithValue("@t_out_am", FormatTimeForDb(dtpCheckOutAM.Value))
                    cmd.Parameters.AddWithValue("@t_in_pm", FormatTimeForDb(dtpCheckInPM.Value))
                    cmd.Parameters.AddWithValue("@t_out_pm", FormatTimeForDb(dtpCheckOutPM.Value))
                    cmd.Parameters.AddWithValue("@aid", todayAttendanceID)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                ' INSERT new record
                Dim q As String = "
                INSERT INTO tblattendance (AttendanceID, EmployeeID, `Date`, TimeIn_AM, TimeOut_AM, TimeIn_PM, TimeOut_PM, AttendanceStatus)
                VALUES (@aid, @eid, @date, @t_in_am, @t_out_am, @t_in_pm, @t_out_pm, @status)
            "
                Using cmd As New MySqlCommand(q, dbcon)
                    cmd.Parameters.AddWithValue("@aid", todayAttendanceID)
                    cmd.Parameters.AddWithValue("@eid", LoggedInEmployeeID)
                    cmd.Parameters.AddWithValue("@date", Date.Today.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@t_in_am", FormatTimeForDb(dtpCheckInAM.Value))
                    cmd.Parameters.AddWithValue("@t_out_am", FormatTimeForDb(dtpCheckOutAM.Value))
                    cmd.Parameters.AddWithValue("@t_in_pm", FormatTimeForDb(dtpCheckInPM.Value))
                    cmd.Parameters.AddWithValue("@t_out_pm", FormatTimeForDb(dtpCheckOutPM.Value))
                    cmd.Parameters.AddWithValue("@status", cbAttendanceStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End If

            LoadAttendanceHistory()
            LoadTodayAttendance()
            LockAllFields()
            UpdateCheckButtonsState()
        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function AttendanceExists(aid As String) As Boolean
        Dim exists As Boolean = False
        Try
            Dim q As String = "SELECT COUNT(*) FROM tblattendance WHERE AttendanceID=@aid"
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@aid", aid)
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        Catch
            exists = False
        End Try
        Return exists
    End Function

    Private Sub StoreOriginalValues()
        originalValues.Clear()
        originalValues("AttendanceID") = If(String.IsNullOrEmpty(todayAttendanceID), Nothing, todayAttendanceID)
        originalValues("status") = cbAttendanceStatus.Text
        originalValues("time_in_am") = If(dtpCheckInAM.Value.TimeOfDay = TimeSpan.Zero, Nothing, dtpCheckInAM.Value)
        originalValues("time_out_am") = If(dtpCheckOutAM.Value.TimeOfDay = TimeSpan.Zero, Nothing, dtpCheckOutAM.Value)
        originalValues("time_in_pm") = If(dtpCheckInPM.Value.TimeOfDay = TimeSpan.Zero, Nothing, dtpCheckInPM.Value)
        originalValues("time_out_pm") = If(dtpCheckOutPM.Value.TimeOfDay = TimeSpan.Zero, Nothing, dtpCheckOutPM.Value)
        originalValues("date") = dtpDateAttendance.Value.Date
    End Sub

    Private Sub btnCancelAttendance_Click(sender As Object, e As EventArgs) Handles btnCancelAttendance.Click
        If originalValues.Count > 0 Then
            cbAttendanceStatus.Text = If(originalValues.ContainsKey("status"), originalValues("status").ToString(), "")
            dtpCheckInAM.Value = If(originalValues("time_in_am") IsNot Nothing, CType(originalValues("time_in_am"), DateTime), Date.Today)
            dtpCheckOutAM.Value = If(originalValues("time_out_am") IsNot Nothing, CType(originalValues("time_out_am"), DateTime), Date.Today)
            dtpCheckInPM.Value = If(originalValues("time_in_pm") IsNot Nothing, CType(originalValues("time_in_pm"), DateTime), Date.Today)
            dtpCheckOutPM.Value = If(originalValues("time_out_pm") IsNot Nothing, CType(originalValues("time_out_pm"), DateTime), Date.Today)
        End If

        LockAllFields()
        UpdateCheckButtonsState()
    End Sub
    Private Sub btnCheckInAM_Click(sender As Object, e As EventArgs) Handles btnCheckInAM.Click
        dtpCheckInAM.Value = DateTime.Now
        btnCheckInAM.Enabled = False
        btnCheckOutAM.Enabled = True
        UnlockForRecording()
        StoreOriginalValues()
    End Sub
    Private Sub btnCheckOutAM_Click(sender As Object, e As EventArgs) Handles btnCheckOutAM.Click
        dtpCheckOutAM.Value = DateTime.Now
        btnCheckOutAM.Enabled = False
        UnlockForRecording()
    End Sub
    Private Sub btnCheckInPM_Click(sender As Object, e As EventArgs) Handles btnCheckInPM.Click
        dtpCheckInPM.Value = DateTime.Now
        btnCheckInPM.Enabled = False
        btnCheckOutPM.Enabled = True
        UnlockForRecording()
        StoreOriginalValues()
    End Sub
    Private Sub btnCheckOutPM_Click(sender As Object, e As EventArgs) Handles btnCheckOutPM.Click
        dtpCheckOutPM.Value = DateTime.Now
        btnCheckOutPM.Enabled = False
        UnlockForRecording()
    End Sub
    Private Function FormatTimeForDb(dt As DateTime) As Object
        If dt.TimeOfDay = TimeSpan.Zero Then Return DBNull.Value
        Return dt.ToString("HH:mm:ss")
    End Function
    Private Function ChangesExist() As Boolean
        If originalValues.Count = 0 Then Return True
        If originalValues("status").ToString() <> cbAttendanceStatus.Text Then Return True

        Dim orig As Nullable(Of DateTime)

        For Each key As String In {"time_in_am", "time_out_am", "time_in_pm", "time_out_pm"}
            If originalValues(key) IsNot Nothing Then
                orig = Convert.ToDateTime(originalValues(key))
            Else
                orig = Nothing
            End If

            Dim current As TimeSpan = CType(Me.Controls("dtp" & key.Replace("_", "")), DateTimePicker).Value.TimeOfDay
            If (orig.HasValue AndAlso orig.Value.TimeOfDay <> current) Or (Not orig.HasValue AndAlso current <> TimeSpan.Zero) Then
                Return True
            End If
        Next

        Return False
    End Function
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
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
