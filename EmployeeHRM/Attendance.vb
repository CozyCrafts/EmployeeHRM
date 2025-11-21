Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Attendance
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private dbcon As MySqlConnection = Nothing
    Private dbcmd As MySqlCommand = Nothing

    Private todayAttendanceID As String = ""
    Private originalValues As New Dictionary(Of String, Object)
    Private isRecordingAttendance As Boolean = False

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            dtp.ShowCheckBox = True      ' << Add this
            dtp.Checked = False          ' Initially unchecked
            dtp.Enabled = False
        Next
    End Sub


    Private Sub LockAllFields()
        isRecordingAttendance = False ' Reset mode

        ' Employee info stays read-only but visible
        txtEmployeeID.ReadOnly = True
        txtEmployeeName.ReadOnly = True
        txtJobTitle.ReadOnly = True

        ' Attendance fields disabled and cleared
        txtAttendanceID.Clear()
        cbAttendanceStatus.Enabled = False
        cbAttendanceStatus.SelectedIndex = -1

        dtpDateAttendance.Enabled = False
        dtpCheckInAM.Enabled = False
        dtpCheckOutAM.Enabled = False
        dtpCheckInPM.Enabled = False
        dtpCheckOutPM.Enabled = False

        dtpCheckInAM.Checked = False
        dtpCheckOutAM.Checked = False
        dtpCheckInPM.Checked = False
        dtpCheckOutPM.Checked = False

        ' Buttons disabled except Record Attendance
        btnCheckInAM.Enabled = False
        btnCheckOutAM.Enabled = False
        btnCheckInPM.Enabled = False
        btnCheckOutPM.Enabled = False

        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False

        btnEditAttendance.Visible = False
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

        btnEditAttendance.Visible = False
        btnRecordAttendance.Visible = False

        UpdateCheckButtonsState()
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
        Catch ex As Exception
            MessageBox.Show("Error loading employee info: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTodayAttendance()
        Try
            OpenCon()
            Dim q As String = "SELECT * FROM tblattendance WHERE EmployeeID=@id AND `Date`=@date"
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@id", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@date", Date.Today.ToString("yyyy-MM-dd"))

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If Not table.Columns.Contains("TotalHours") Then table.Columns.Add("TotalHours", GetType(Double))
                    If Not table.Columns.Contains("Absences") Then table.Columns.Add("Absences", GetType(Integer))
                    If Not table.Columns.Contains("DaysAttended") Then table.Columns.Add("DaysAttended", GetType(Integer))

                    Dim daysAttended As Integer = 0

                    If table.Rows.Count > 0 Then
                        ' Load existing record
                        Dim row = table.Rows(0)
                        todayAttendanceID = row("AttendanceID").ToString()
                        txtAttendanceID.Text = todayAttendanceID
                        cbAttendanceStatus.Text = If(row("AttendanceStatus") IsNot DBNull.Value, row("AttendanceStatus").ToString(), "Present")

                        Dim timeInAM = SafeDateTimeFromDb(row("TimeIn_AM"))
                        Dim timeOutAM = SafeDateTimeFromDb(row("TimeOut_AM"))
                        Dim timeInPM = SafeDateTimeFromDb(row("TimeIn_PM"))
                        Dim timeOutPM = SafeDateTimeFromDb(row("TimeOut_PM"))

                        dtpCheckInAM.Checked = timeInAM.HasValue
                        If dtpCheckInAM.Checked Then dtpCheckInAM.Value = timeInAM.Value

                        dtpCheckOutAM.Checked = timeOutAM.HasValue
                        If dtpCheckOutAM.Checked Then dtpCheckOutAM.Value = timeOutAM.Value

                        dtpCheckInPM.Checked = timeInPM.HasValue
                        If dtpCheckInPM.Checked Then dtpCheckInPM.Value = timeInPM.Value

                        dtpCheckOutPM.Checked = timeOutPM.HasValue
                        If dtpCheckOutPM.Checked Then dtpCheckOutPM.Value = timeOutPM.Value

                        Dim totalHours As Double = GetHours(timeInAM, timeOutAM) + GetHours(timeInPM, timeOutPM)
                        row("TotalHours") = Math.Round(totalHours, 2)

                        If row("AttendanceStatus") IsNot DBNull.Value AndAlso row("AttendanceStatus").ToString().ToLower() = "absent" Then
                            row("Absences") = 1
                            daysAttended = 0
                        Else
                            row("Absences") = 0
                            daysAttended = 1
                        End If
                        row("DaysAttended") = daysAttended

                        dgvAttendanceHistory.DataSource = table
                        btnEditAttendance.Enabled = (Convert.ToDateTime(row("Date")).Date = Date.Today)
                    Else
                        ' Only generate a new row if table is empty (no duplicate row)
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
                        todayAttendanceID = GenerateNextAttendanceID() ' only generate once
                        newRow("AttendanceID") = todayAttendanceID
                        txtAttendanceID.Text = todayAttendanceID
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

                        cbAttendanceStatus.Text = "Present"
                        dtpCheckInAM.Checked = False
                        dtpCheckOutAM.Checked = False
                        dtpCheckInPM.Checked = False
                        dtpCheckOutPM.Checked = False

                        btnEditAttendance.Enabled = True
                    End If

                    dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvAttendanceHistory.ReadOnly = True
                    dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvAttendanceHistory.AllowUserToAddRows = False
                    dgvAttendanceHistory.AllowUserToDeleteRows = False
                    dgvAttendanceHistory.AutoGenerateColumns = True
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
            If DateTime.TryParse(dbValue.ToString(), d) Then Return d
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

        If Not isRecordingAttendance Then Return
        If dtpDateAttendance.Value.Date <> Date.Today Then Return

        Dim now = DateTime.Now

        Dim hasCheckInAM As Boolean = dtpCheckInAM.Checked
        Dim hasCheckOutAM As Boolean = dtpCheckOutAM.Checked
        Dim hasCheckInPM As Boolean = dtpCheckInPM.Checked
        Dim hasCheckOutPM As Boolean = dtpCheckOutPM.Checked

        If now.Hour < 12 Then
            If Not hasCheckInAM Then btnCheckInAM.Enabled = True
            If hasCheckInAM AndAlso Not hasCheckOutAM Then btnCheckOutAM.Enabled = True
        Else
            If Not hasCheckInPM Then btnCheckInPM.Enabled = True
            If hasCheckInPM AndAlso Not hasCheckOutPM Then btnCheckOutPM.Enabled = True
        End If
    End Sub
    Private Function GenerateNextAttendanceID() As String
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                ' Lock the table to prevent race conditions
                Using trans = conn.BeginTransaction(IsolationLevel.Serializable)
                    Dim lastID As String = ""
                    Dim q As String = "SELECT AttendanceID FROM tblattendance ORDER BY AttendanceID DESC LIMIT 1 FOR UPDATE"
                    Using cmd As New MySqlCommand(q, conn, trans)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                            lastID = result.ToString()
                        End If
                    End Using

                    Dim nextID As String
                    If String.IsNullOrEmpty(lastID) Then
                        nextID = "T001"
                    Else
                        Dim numericPart As Integer = 0
                        If Integer.TryParse(lastID.Substring(1), numericPart) Then
                            numericPart += 1
                        Else
                            numericPart = 1
                        End If
                        nextID = "T" & numericPart.ToString("D3")
                    End If

                    trans.Commit()
                    Return nextID
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating AttendanceID: " & ex.Message)
            Return "T001"
        End Try
    End Function


    Private Sub btnEditAttendance_Click(sender As Object, e As EventArgs) Handles btnEditAttendance.Click
        If String.IsNullOrEmpty(todayAttendanceID) Then
            MessageBox.Show("No attendance record found for today to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ensure editing is only allowed for today's record
        If dtpDateAttendance.Value.Date <> Date.Today Then
            MessageBox.Show("You can only edit today's attendance.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        UnlockForRecording()
        isRecordingAttendance = True
        StoreOriginalValues()
    End Sub

    Private Sub btnRecordAttendance_Click(sender As Object, e As EventArgs) Handles btnRecordAttendance.Click
        Try
            dtpDateAttendance.Value = Date.Today
            OpenCon()

            ' Check if attendance already exists for today
            Dim q As String = "SELECT AttendanceID FROM tblattendance WHERE EmployeeID=@eid AND `Date`=@date LIMIT 1"
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@eid", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@date", Date.Today.ToString("yyyy-MM-dd"))
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    ' Record exists
                    todayAttendanceID = result.ToString()
                    txtAttendanceID.Text = todayAttendanceID
                    MessageBox.Show("An attendance record for today already exists. You can edit it.",
                                "Attendance Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadTodayAttendance()
                Else
                    ' New record
                    todayAttendanceID = GenerateNextAttendanceID()
                    txtAttendanceID.Text = todayAttendanceID

                    ' Clear all check-in/out fields and attendance status
                    cbAttendanceStatus.SelectedIndex = -1
                    dtpCheckInAM.Checked = False
                    dtpCheckOutAM.Checked = False
                    dtpCheckInPM.Checked = False
                    dtpCheckOutPM.Checked = False

                    dgvAttendanceHistory.ClearSelection()
                End If
            End Using

            ' Unlock fields for recording
            UnlockForRecording()

            ' Important: set isRecordingAttendance BEFORE updating buttons
            isRecordingAttendance = True
            StoreOriginalValues()

            ' Enable the correct check-in/out buttons
            UpdateCheckButtonsState()

        Catch ex As Exception
            MessageBox.Show("Error preparing attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetTodayAttendanceID(empID As String, [date] As Date) As String
        Try
            Dim q As String = "SELECT AttendanceID FROM tblattendance WHERE EmployeeID=@eid AND `Date`=@date LIMIT 1"
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@eid", empID)
                cmd.Parameters.AddWithValue("@date", [date].ToString("yyyy-MM-dd"))
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then Return result.ToString()
            End Using
        Catch
        End Try
        Return ""
    End Function

    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Try
            If String.IsNullOrWhiteSpace(cbAttendanceStatus.Text) AndAlso
           Not dtpCheckInAM.Checked AndAlso
           Not dtpCheckOutAM.Checked AndAlso
           Not dtpCheckInPM.Checked AndAlso
           Not dtpCheckOutPM.Checked Then
                MessageBox.Show("Please record a check-in/check-out or set an attendance status before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenCon()
            If dtpDateAttendance.Value.Date <> Date.Today Then
                MessageBox.Show("You can only save attendance for today.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' --- Check if record exists BEFORE generating a new ID
            Dim recordExists As Boolean = AttendanceExistsForToday(LoggedInEmployeeID, Date.Today)
            If recordExists Then
                todayAttendanceID = GetTodayAttendanceID(LoggedInEmployeeID, Date.Today)
            Else
                todayAttendanceID = GenerateNextAttendanceID()
            End If

            txtAttendanceID.Text = todayAttendanceID

            If recordExists Then
                ' UPDATE
                Dim qUpdate As String = "
            UPDATE tblattendance SET 
                TimeIn_AM=@t_in_am,
                TimeOut_AM=@t_out_am,
                TimeIn_PM=@t_in_pm,
                TimeOut_PM=@t_out_pm,
                AttendanceStatus=@status
            WHERE EmployeeID=@eid AND `Date`=@date
        "
                Using cmd As New MySqlCommand(qUpdate, dbcon)
                    cmd.Parameters.AddWithValue("@eid", LoggedInEmployeeID)
                    cmd.Parameters.AddWithValue("@date", Date.Today.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@t_in_am", FormatTimeForDb(dtpCheckInAM))
                    cmd.Parameters.AddWithValue("@t_out_am", FormatTimeForDb(dtpCheckOutAM))
                    cmd.Parameters.AddWithValue("@t_in_pm", FormatTimeForDb(dtpCheckInPM))
                    cmd.Parameters.AddWithValue("@t_out_pm", FormatTimeForDb(dtpCheckOutPM))
                    cmd.Parameters.AddWithValue("@status", cbAttendanceStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                ' INSERT
                Dim qInsert As String = "
            INSERT INTO tblattendance
            (AttendanceID, EmployeeID, `Date`, TimeIn_AM, TimeOut_AM, TimeIn_PM, TimeOut_PM, AttendanceStatus)
            VALUES
            (@aid, @eid, @date, @t_in_am, @t_out_am, @t_in_pm, @t_out_pm, @status)
        "
                Using cmd As New MySqlCommand(qInsert, dbcon)
                    cmd.Parameters.AddWithValue("@aid", todayAttendanceID)
                    cmd.Parameters.AddWithValue("@eid", LoggedInEmployeeID)
                    cmd.Parameters.AddWithValue("@date", Date.Today.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@t_in_am", FormatTimeForDb(dtpCheckInAM))
                    cmd.Parameters.AddWithValue("@t_out_am", FormatTimeForDb(dtpCheckOutAM))
                    cmd.Parameters.AddWithValue("@t_in_pm", FormatTimeForDb(dtpCheckInPM))
                    cmd.Parameters.AddWithValue("@t_out_pm", FormatTimeForDb(dtpCheckOutPM))
                    cmd.Parameters.AddWithValue("@status", cbAttendanceStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End If

            LoadAttendanceHistory()
            LoadTodayAttendance()
            LockAllFields()
            UpdateCheckButtonsState()
            MessageBox.Show("Attendance saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Function AttendanceExistsForToday(empID As String, [date] As Date) As Boolean
        Dim exists As Boolean = False
        Try
            Dim q As String = "SELECT COUNT(*) FROM tblattendance WHERE EmployeeID=@eid AND `Date`=@date"
            Using cmd As New MySqlCommand(q, dbcon)
                cmd.Parameters.AddWithValue("@eid", empID)
                cmd.Parameters.AddWithValue("@date", [date].ToString("yyyy-MM-dd"))
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        Catch
            exists = False
        End Try
        Return exists
    End Function
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
        originalValues("AttendanceID") = todayAttendanceID
        originalValues("AttendanceStatus") = cbAttendanceStatus.Text
        originalValues("TimeIn_AM") = If(dtpCheckInAM.Checked, dtpCheckInAM.Value, Nothing)
        originalValues("TimeOut_AM") = If(dtpCheckOutAM.Checked, dtpCheckOutAM.Value, Nothing)
        originalValues("TimeIn_PM") = If(dtpCheckInPM.Checked, dtpCheckInPM.Value, Nothing)
        originalValues("TimeOut_PM") = If(dtpCheckOutPM.Checked, dtpCheckOutPM.Value, Nothing)
        originalValues("Date") = dtpDateAttendance.Value.Date
    End Sub
    Private Sub btnCancelAttendance_Click(sender As Object, e As EventArgs) Handles btnCancelAttendance.Click
        If originalValues.Count > 0 Then
            cbAttendanceStatus.Text = If(originalValues.ContainsKey("AttendanceStatus"), originalValues("AttendanceStatus").ToString(), "")

            ' Restore AM
            If originalValues("TimeIn_AM") IsNot Nothing Then
                dtpCheckInAM.Value = Date.Today.Date + CType(originalValues("TimeIn_AM"), DateTime).TimeOfDay
                dtpCheckInAM.Checked = True
            Else
                dtpCheckInAM.Checked = False
            End If

            If originalValues("TimeOut_AM") IsNot Nothing Then
                dtpCheckOutAM.Value = Date.Today.Date + CType(originalValues("TimeOut_AM"), DateTime).TimeOfDay
                dtpCheckOutAM.Checked = True
            Else
                dtpCheckOutAM.Checked = False
            End If

            ' Restore PM
            If originalValues("TimeIn_PM") IsNot Nothing Then
                dtpCheckInPM.Value = Date.Today.Date + CType(originalValues("TimeIn_PM"), DateTime).TimeOfDay
                dtpCheckInPM.Checked = True
            Else
                dtpCheckInPM.Checked = False
            End If

            If originalValues("TimeOut_PM") IsNot Nothing Then
                dtpCheckOutPM.Value = Date.Today.Date + CType(originalValues("TimeOut_PM"), DateTime).TimeOfDay
                dtpCheckOutPM.Checked = True
            Else
                dtpCheckOutPM.Checked = False
            End If
        End If

        LockAllFields()
        UpdateCheckButtonsState()
    End Sub

    Private Sub btnCheckInAM_Click(sender As Object, e As EventArgs) Handles btnCheckInAM.Click
        dtpCheckInAM.Value = DateTime.Now
        UnlockForRecording()
        StoreOriginalValues()
        UpdateCheckButtonsState()
    End Sub

    Private Sub btnCheckOutAM_Click(sender As Object, e As EventArgs) Handles btnCheckOutAM.Click
        dtpCheckOutAM.Value = DateTime.Now
        UnlockForRecording()
        UpdateCheckButtonsState()
    End Sub

    Private Sub btnCheckInPM_Click(sender As Object, e As EventArgs) Handles btnCheckInPM.Click
        dtpCheckInPM.Value = DateTime.Now
        UnlockForRecording()
        StoreOriginalValues()
        UpdateCheckButtonsState()
    End Sub

    Private Sub btnCheckOutPM_Click(sender As Object, e As EventArgs) Handles btnCheckOutPM.Click
        dtpCheckOutPM.Value = DateTime.Now
        UnlockForRecording()
        UpdateCheckButtonsState()
    End Sub
    Private Function FormatTimeForDb(dtp As DateTimePicker) As Object
        If Not dtp.Checked Then Return DBNull.Value
        ' Only use TimeOfDay
        Return dtp.Value.ToString("HH:mm:ss")
    End Function
    Private Function ChangesExist() As Boolean
        If originalValues.Count = 0 Then Return True
        If originalValues("AttendanceStatus").ToString() <> cbAttendanceStatus.Text Then Return True

        Dim mappings As New Dictionary(Of String, DateTimePicker) From {
        {"TimeIn_AM", dtpCheckInAM},
        {"TimeOut_AM", dtpCheckOutAM},
        {"TimeIn_PM", dtpCheckInPM},
        {"TimeOut_PM", dtpCheckOutPM}
    }

        For Each key In mappings.Keys
            Dim origTime As TimeSpan = If(originalValues(key) IsNot Nothing, CType(originalValues(key), DateTime).TimeOfDay, TimeSpan.Zero)
            Dim currentTime As TimeSpan = mappings(key).Value.TimeOfDay
            If origTime <> currentTime Then Return True
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
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login_frm.ClearLoginFields
            LoggedInEmployeeID = ""
            LoggedInUsername = ""
            LoggedInUserType = ""
            Login_frm.Show
            Hide
        End If
    End Sub

    Private Sub btnSignOut_Click_1(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show(
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
            Me.Hide()
        End If

    End Sub
End Class
