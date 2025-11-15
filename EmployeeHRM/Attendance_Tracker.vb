Imports MySql.Data.MySqlClient

Public Class Attendance_Tracker
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private attendanceBindingSource As New BindingSource()
    Private originalValues As New Dictionary(Of String, Object)
    Private Sub NumericOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Attendance_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendanceList()
        LockAllFields()
        SetupDateAndTimePickers()
        LoadEmployeeIDs()
        cbEmployeeID.DropDownStyle = ComboBoxStyle.DropDownList
        cbAttendanceStatus.Items.Clear()
        cbAttendanceStatus.Items.AddRange(New String() {"Present", "Absent", "Half-Day", "Leave", "Late"})
        btnEditAttendance.Visible = False
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
        AddHandler txtTotalHours.KeyPress, AddressOf NumericOnly
        AddHandler txtExceededHours.KeyPress, AddressOf NumericOnly
        AddHandler txtAbsences.KeyPress, AddressOf NumericOnly
        AddHandler txtDaysAttended.KeyPress, AddressOf NumericOnly
    End Sub
    Private Sub SetupDateAndTimePickers()
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MMMM dd, yyyy"
        dtpDate.ShowUpDown = False
        For Each dtp As DateTimePicker In {dtpTimeInAM, dtpTimeOutAM, dtpTimeInPM, dtpTimeOutPM}
            dtp.Format = DateTimePickerFormat.Custom
            dtp.CustomFormat = "HH:mm:ss"
            dtp.ShowUpDown = True
            dtp.Enabled = False
        Next
    End Sub
    Private Sub LockAllFields()
        cbEmployeeID.Enabled = False
        txtEmployeeName.ReadOnly = True
        txtDepartmentName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtAttendanceID.ReadOnly = True
        cbAttendanceStatus.Enabled = False
        txtTotalHours.ReadOnly = True
        txtExceededHours.ReadOnly = True
        txtAbsences.ReadOnly = True
        txtDaysAttended.ReadOnly = True
        dtpDate.Enabled = False
        dtpTimeInAM.Enabled = False
        dtpTimeOutAM.Enabled = False
        dtpTimeInPM.Enabled = False
        dtpTimeOutPM.Enabled = False
    End Sub
    Private Sub UnlockEditableFields()
        cbAttendanceStatus.Enabled = True
        txtTotalHours.ReadOnly = False
        txtExceededHours.ReadOnly = False
        txtAbsences.ReadOnly = False
        txtDaysAttended.ReadOnly = False
        dtpDate.Enabled = True
        dtpTimeInAM.Enabled = True
        dtpTimeOutAM.Enabled = True
        dtpTimeInPM.Enabled = True
        dtpTimeOutPM.Enabled = True
    End Sub
    Private Sub LoadAttendanceList()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                SELECT 
                    e.EmployeeID,
                    CONCAT(e.`First Name`, ' ', e.MiddleName, ' ', e.LastName) AS EmployeeName,
                    d.Name AS DepartmentName,
                    j.JobTitle,
                    a.AttendanceID, a.AttendanceStatus, a.TotalHours, a.ExceededHours, a.Absences, a.DaysAttended,
                    a.Date, a.TimeIn_AM, a.TimeOut_AM, a.TimeIn_PM, a.TimeOut_PM
                FROM tblemployee e
                LEFT JOIN tbldepartment d ON e.EmployeeID = d.EmployeeID
                LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                LEFT JOIN tblattendance a ON e.EmployeeID = a.EmployeeID
                "
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        attendanceBindingSource.DataSource = table
                        dgvAttendanceList.DataSource = attendanceBindingSource
                    End Using
                End Using

            End Using

            dgvAttendanceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvAttendanceList.AutoResizeColumns()
            dgvAttendanceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAttendanceList.ReadOnly = True
            dgvAttendanceList.AllowUserToAddRows = False
            dgvAttendanceList.AllowUserToDeleteRows = False

        Catch ex As Exception
            MessageBox.Show("Error loading attendance list: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadEmployeeIDs()
        Try
            cbEmployeeID.Items.Clear()
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT EmployeeID FROM tblemployee ORDER BY EmployeeID", conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        cbEmployeeID.Items.Add(reader("EmployeeID").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Employee IDs: " & ex.Message)
        End Try
    End Sub
    Private Sub cbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployeeID.SelectedIndexChanged
        Dim selectedID As String = cbEmployeeID.Text
        If String.IsNullOrWhiteSpace(selectedID) Then Return

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                SELECT 
                    e.`First Name`, e.MiddleName, e.LastName,
                    d.Name AS DepartmentName,
                    j.JobTitle,
                    a.AttendanceID, a.AttendanceStatus, a.TotalHours, a.ExceededHours, a.Absences, a.DaysAttended,
                    a.Date, a.TimeIn_AM, a.TimeOut_AM, a.TimeIn_PM, a.TimeOut_PM
                FROM tblemployee e
                LEFT JOIN tbldepartment d ON e.EmployeeID = d.EmployeeID
                LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                LEFT JOIN tblattendance a ON e.EmployeeID = a.EmployeeID
                WHERE e.EmployeeID = @eid
                ORDER BY e.EmployeeID DESC  ;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@eid", selectedID)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtEmployeeName.Text = reader("First Name").ToString() & " " &
                                               reader("MiddleName").ToString() & " " &
                                               reader("LastName").ToString()
                            txtDepartmentName.Text = If(reader("DepartmentName") IsNot DBNull.Value, reader("DepartmentName").ToString(), "")
                            txtJobTitle.Text = If(reader("JobTitle") IsNot DBNull.Value, reader("JobTitle").ToString(), "")
                            txtAttendanceID.Text = If(reader("AttendanceID") IsNot DBNull.Value, reader("AttendanceID").ToString(), "")
                            cbAttendanceStatus.Text = If(reader("AttendanceStatus") IsNot DBNull.Value, reader("AttendanceStatus").ToString(), "")
                            txtTotalHours.Text = If(reader("TotalHours") IsNot DBNull.Value, reader("TotalHours").ToString(), "")
                            txtExceededHours.Text = If(reader("ExceededHours") IsNot DBNull.Value, reader("ExceededHours").ToString(), "")
                            txtAbsences.Text = If(reader("Absences") IsNot DBNull.Value, reader("Absences").ToString(), "")
                            txtDaysAttended.Text = If(reader("DaysAttended") IsNot DBNull.Value, reader("DaysAttended").ToString(), "")
                            Dim dt As DateTime
                            If DateTime.TryParse(reader("Date")?.ToString(), dt) Then
                                dtpDate.Value = dt
                            Else
                                dtpDate.Value = Date.Today
                            End If
                            dtpTimeInAM.Value = SafeTimeParse(reader("TimeIn_AM").ToString())
                            dtpTimeOutAM.Value = SafeTimeParse(reader("TimeOut_AM").ToString())
                            dtpTimeInPM.Value = SafeTimeParse(reader("TimeIn_PM").ToString())
                            dtpTimeOutPM.Value = SafeTimeParse(reader("TimeOut_PM").ToString())
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee info: " & ex.Message)
        End Try
    End Sub
    Private Sub dgvAttendanceList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendanceList.CellClick
        If e.RowIndex < 0 Then
            btnEditAttendance.Visible = False
            Return
        End If

        Dim row As DataGridViewRow = dgvAttendanceList.Rows(e.RowIndex)

        If row.Cells("AttendanceID").Value Is Nothing OrElse
       String.IsNullOrWhiteSpace(row.Cells("AttendanceID").Value.ToString()) Then

            btnEditAttendance.Visible = False
            Return
        End If
        cbEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
        txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
        txtDepartmentName.Text = If(row.Cells("DepartmentName").Value IsNot DBNull.Value, row.Cells("DepartmentName").Value.ToString(), "")
        txtJobTitle.Text = If(row.Cells("JobTitle").Value IsNot DBNull.Value, row.Cells("JobTitle").Value.ToString(), "")
        cbAttendanceStatus.Text = If(row.Cells("AttendanceStatus").Value IsNot DBNull.Value, row.Cells("AttendanceStatus").Value.ToString(), "")
        txtTotalHours.Text = If(row.Cells("TotalHours").Value IsNot DBNull.Value, row.Cells("TotalHours").Value.ToString(), "")
        txtExceededHours.Text = If(row.Cells("ExceededHours").Value IsNot DBNull.Value, row.Cells("ExceededHours").Value.ToString(), "")
        txtAbsences.Text = If(row.Cells("Absences").Value IsNot DBNull.Value, row.Cells("Absences").Value.ToString(), "")
        txtDaysAttended.Text = If(row.Cells("DaysAttended").Value IsNot DBNull.Value, row.Cells("DaysAttended").Value.ToString(), "")

        Dim parsedDate As DateTime
        If DateTime.TryParse(row.Cells("Date").Value?.ToString(), parsedDate) Then
            dtpDate.Value = parsedDate
        Else
            dtpDate.Value = Date.Today
        End If

        dtpTimeInAM.Value = SafeTimeParse(row.Cells("TimeIn_AM").Value)
        dtpTimeOutAM.Value = SafeTimeParse(row.Cells("TimeOut_AM").Value)
        dtpTimeInPM.Value = SafeTimeParse(row.Cells("TimeIn_PM").Value)
        dtpTimeOutPM.Value = SafeTimeParse(row.Cells("TimeOut_PM").Value)
        btnEditAttendance.Visible = True
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
    End Sub
    Private Function SafeTimeParse(value As Object) As DateTime
        Dim result As DateTime
        If DateTime.TryParse(value?.ToString(), result) Then
            Return Date.Today.Add(result.TimeOfDay)
        Else
            Return Date.Today
        End If
    End Function
    Private Sub btnEditAttendance_Click(sender As Object, e As EventArgs) Handles btnEditAttendance.Click
        UnlockEditableFields()
        btnEditAttendance.Visible = False
        btnSaveAttendance.Visible = True
        btnCancelAttendance.Visible = True
        originalValues.Clear()
        originalValues("AttendanceStatus") = cbAttendanceStatus.Text
        originalValues("TotalHours") = txtTotalHours.Text
        originalValues("ExceededHours") = txtExceededHours.Text
        originalValues("Absences") = txtAbsences.Text
        originalValues("DaysAttended") = txtDaysAttended.Text
        originalValues("Date") = dtpDate.Value
        originalValues("TimeIn_AM") = dtpTimeInAM.Value
        originalValues("TimeOut_AM") = dtpTimeOutAM.Value
        originalValues("TimeIn_PM") = dtpTimeInPM.Value
        originalValues("TimeOut_PM") = dtpTimeOutPM.Value
    End Sub
    Private Sub btnCancelAttendance_Click(sender As Object, e As EventArgs) Handles btnCancelAttendance.Click
        LockAllFields()
        btnEditAttendance.Visible = True
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
    End Sub
    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        If String.IsNullOrWhiteSpace(txtAttendanceID.Text) Then
            MessageBox.Show("No attendance record selected to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(cbAttendanceStatus.Text) Then
            MessageBox.Show("Attendance Status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbAttendanceStatus.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtTotalHours.Text) Then
            MessageBox.Show("Total Hours is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalHours.Focus()
            Return
        End If

        Dim changesMade As Boolean =
    cbAttendanceStatus.Text <> originalValues("AttendanceStatus").ToString() OrElse
    txtTotalHours.Text <> originalValues("TotalHours").ToString() OrElse
    txtExceededHours.Text <> originalValues("ExceededHours").ToString() OrElse
    txtAbsences.Text <> originalValues("Absences").ToString() OrElse
    txtDaysAttended.Text <> originalValues("DaysAttended").ToString() OrElse
    dtpDate.Value.Date <> CDate(originalValues("Date")).Date OrElse
    dtpTimeInAM.Value.TimeOfDay <> CType(originalValues("TimeIn_AM"), DateTime).TimeOfDay OrElse
    dtpTimeOutAM.Value.TimeOfDay <> CType(originalValues("TimeOut_AM"), DateTime).TimeOfDay OrElse
    dtpTimeInPM.Value.TimeOfDay <> CType(originalValues("TimeIn_PM"), DateTime).TimeOfDay OrElse
    dtpTimeOutPM.Value.TimeOfDay <> CType(originalValues("TimeOut_PM"), DateTime).TimeOfDay


        If Not changesMade Then
            MessageBox.Show("No changes were made. Nothing to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                UPDATE tblattendance 
                SET 
                    AttendanceStatus = @AttendanceStatus,
                    TotalHours = @TotalHours,
                    ExceededHours = @ExceededHours,
                    Absences = @Absences,
                    DaysAttended = @DaysAttended,
                    Date = @Date,
                    TimeIn_AM = @TimeIn_AM,
                    TimeOut_AM = @TimeOut_AM,
                    TimeIn_PM = @TimeIn_PM,
                    TimeOut_PM = @TimeOut_PM
                WHERE AttendanceID = @AttendanceID;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AttendanceStatus", cbAttendanceStatus.Text)
                    cmd.Parameters.AddWithValue("@TotalHours", txtTotalHours.Text)
                    cmd.Parameters.AddWithValue("@ExceededHours", txtExceededHours.Text)
                    cmd.Parameters.AddWithValue("@Absences", txtAbsences.Text)
                    cmd.Parameters.AddWithValue("@DaysAttended", txtDaysAttended.Text)
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@TimeIn_AM", dtpTimeInAM.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@TimeOut_AM", dtpTimeOutAM.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@TimeIn_PM", dtpTimeInPM.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@TimeOut_PM", dtpTimeOutPM.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@AttendanceID", txtAttendanceID.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Attendance record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAttendanceList()
                        LockAllFields()
                        btnEditAttendance.Visible = True
                        btnSaveAttendance.Visible = False
                        btnCancelAttendance.Visible = False
                    Else
                        MessageBox.Show("No changes were applied to the record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtSearchAttendance_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAttendance.TextChanged
        Dim searchValue As String = txtSearchAttendance.Text.Trim().Replace("'", "''")

        If String.IsNullOrEmpty(searchValue) Then
            attendanceBindingSource.RemoveFilter()
            Return
        End If

        attendanceBindingSource.Filter = String.Format(
        "Convert(EmployeeID, 'System.String') LIKE '%{0}%' OR EmployeeName LIKE '%{0}%'", searchValue
    )
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