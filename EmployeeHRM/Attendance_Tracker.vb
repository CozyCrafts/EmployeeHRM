Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Attendance_Tracker
    Private attendanceBindingSource As New BindingSource()
    Private originalValues As New Dictionary(Of String, Object)

    Private Sub NumericOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub
    Private Sub CapitalizeWords(sender As Object, e As EventArgs)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim pos = tb.SelectionStart
        Dim text = tb.Text

        Dim newText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower())

        If text <> newText Then
            tb.Text = newText
            tb.SelectionStart = pos
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
        AddHandler txtDepartmentName.TextChanged, AddressOf CapitalizeWords
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
            Dim query As String =
                "SELECT 
                    e.EmployeeID,
                    CONCAT(e.`First Name`, ' ', e.MiddleName, ' ', e.LastName) AS EmployeeName,
                    d.Name AS DepartmentName,
                    j.JobTitle,
                    a.AttendanceID, a.AttendanceStatus, a.TotalHours, a.ExceededHours, a.Absences, a.DaysAttended,
                    a.Date, a.TimeIn_AM, a.TimeOut_AM, a.TimeIn_PM, a.TimeOut_PM
                FROM tblemployee e
                LEFT JOIN tbldepartment d ON e.EmployeeID = d.EmployeeID
                LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                LEFT JOIN tblattendance a ON e.EmployeeID = a.EmployeeID"

            Dim dt As DataTable = HRMModule.ExecuteQuery(query)

            attendanceBindingSource.DataSource = dt
            dgvAttendanceList.DataSource = attendanceBindingSource

            dgvAttendanceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvAttendanceList.AutoResizeColumns()
            dgvAttendanceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAttendanceList.ReadOnly = True
            dgvAttendanceList.AllowUserToAddRows = False
            dgvAttendanceList.AllowUserToDeleteRows = False

        Catch ex As Exception
            MessageBox.Show("Unable to load attendance list. Please contact admin.",
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadEmployeeIDs()
        Try
            Dim dt As DataTable = HRMModule.ExecuteQuery("SELECT EmployeeID FROM tblemployee ORDER BY EmployeeID")
            cbEmployeeID.Items.Clear()

            For Each row As DataRow In dt.Rows
                cbEmployeeID.Items.Add(row("EmployeeID").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("Unable to load employee list.", "Database Error")
        End Try
    End Sub

    Private Sub cbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployeeID.SelectedIndexChanged
        If String.IsNullOrWhiteSpace(cbEmployeeID.Text) Then Exit Sub

        Try
            Dim query As String =
                "SELECT 
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
                ORDER BY e.EmployeeID DESC"

            Dim param As New List(Of MySqlParameter) From {
                New MySqlParameter("@eid", cbEmployeeID.Text)
            }

            Dim dt As DataTable = HRMModule.ExecuteQuery(query, param)

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)

                txtEmployeeName.Text = $"{row("First Name")} {row("MiddleName")} {row("LastName")}"
                txtDepartmentName.Text = row("DepartmentName").ToString()
                txtJobTitle.Text = row("JobTitle").ToString()
                txtAttendanceID.Text = row("AttendanceID").ToString()

                cbAttendanceStatus.Text = row("AttendanceStatus").ToString()
                txtTotalHours.Text = row("TotalHours").ToString()
                txtExceededHours.Text = row("ExceededHours").ToString()
                txtAbsences.Text = row("Absences").ToString()
                txtDaysAttended.Text = row("DaysAttended").ToString()

                dtpDate.Value = If(IsDBNull(row("Date")), Date.Today, CDate(row("Date")))
                dtpTimeInAM.Value = SafeTimeParse(row("TimeIn_AM"))
                dtpTimeOutAM.Value = SafeTimeParse(row("TimeOut_AM"))
                dtpTimeInPM.Value = SafeTimeParse(row("TimeIn_PM"))
                dtpTimeOutPM.Value = SafeTimeParse(row("TimeOut_PM"))
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to load employee details.", "Error")
        End Try
    End Sub

    Private Sub dgvAttendanceList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendanceList.CellClick
        If e.RowIndex < 0 Then
            btnEditAttendance.Visible = False
            Return
        End If

        Dim row As DataGridViewRow = dgvAttendanceList.Rows(e.RowIndex)
        If row.Cells("AttendanceID").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("AttendanceID").Value.ToString()) Then
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
        dtpDate.Value = If(row.Cells("Date").Value IsNot DBNull.Value, CDate(row.Cells("Date").Value), Date.Today)
        dtpTimeInAM.Value = SafeTimeParse(row.Cells("TimeIn_AM").Value)
        dtpTimeOutAM.Value = SafeTimeParse(row.Cells("TimeOut_AM").Value)
        dtpTimeInPM.Value = SafeTimeParse(row.Cells("TimeIn_PM").Value)
        dtpTimeOutPM.Value = SafeTimeParse(row.Cells("TimeOut_PM").Value)

        btnEditAttendance.Visible = True
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
    End Sub
    Private Function SafeTimeParse(value As Object) As DateTime
        If value Is DBNull.Value OrElse value Is Nothing OrElse value.ToString().Trim() = "" Then
            Return Date.Today
        End If

        Dim temp As DateTime
        If DateTime.TryParse(value.ToString(), temp) Then
            Return Date.Today.Add(temp.TimeOfDay)
        End If

        Return Date.Today
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
        RestoreOriginalValues()
        LockAllFields()
        btnEditAttendance.Visible = True
        btnSaveAttendance.Visible = False
        btnCancelAttendance.Visible = False
    End Sub

    Private Sub RestoreOriginalValues()
        If originalValues Is Nothing OrElse originalValues.Count = 0 Then Return

        Dim val As Object

        If originalValues.TryGetValue("AttendanceStatus", val) Then cbAttendanceStatus.Text = val?.ToString()
        If originalValues.TryGetValue("TotalHours", val) Then txtTotalHours.Text = val?.ToString()
        If originalValues.TryGetValue("ExceededHours", val) Then txtExceededHours.Text = val?.ToString()
        If originalValues.TryGetValue("Absences", val) Then txtAbsences.Text = val?.ToString()
        If originalValues.TryGetValue("DaysAttended", val) Then txtDaysAttended.Text = val?.ToString()
        If originalValues.TryGetValue("Date", val) AndAlso TypeOf val Is DateTime Then dtpDate.Value = CType(val, DateTime)
        If originalValues.TryGetValue("TimeIn_AM", val) AndAlso TypeOf val Is DateTime Then dtpTimeInAM.Value = CType(val, DateTime)
        If originalValues.TryGetValue("TimeOut_AM", val) AndAlso TypeOf val Is DateTime Then dtpTimeOutAM.Value = CType(val, DateTime)
        If originalValues.TryGetValue("TimeIn_PM", val) AndAlso TypeOf val Is DateTime Then dtpTimeInPM.Value = CType(val, DateTime)
        If originalValues.TryGetValue("TimeOut_PM", val) AndAlso TypeOf val Is DateTime Then dtpTimeOutPM.Value = CType(val, DateTime)
    End Sub

    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        If String.IsNullOrWhiteSpace(txtAttendanceID.Text) Then
            MessageBox.Show("No attendance record selected.", "Warning")
            Exit Sub
        End If

        Dim query As String =
            "UPDATE tblattendance 
             SET AttendanceStatus=@AttendanceStatus,
                 TotalHours=@TotalHours,
                 ExceededHours=@ExceededHours,
                 Absences=@Absences,
                 DaysAttended=@DaysAttended,
                 Date=@Date,
                 TimeIn_AM=@TimeIn_AM,
                 TimeOut_AM=@TimeOut_AM,
                 TimeIn_PM=@TimeIn_PM,
                 TimeOut_PM=@TimeOut_PM
             WHERE AttendanceID=@AttendanceID"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@AttendanceStatus", cbAttendanceStatus.Text),
            New MySqlParameter("@TotalHours", txtTotalHours.Text),
            New MySqlParameter("@ExceededHours", txtExceededHours.Text),
            New MySqlParameter("@Absences", txtAbsences.Text),
            New MySqlParameter("@DaysAttended", txtDaysAttended.Text),
            New MySqlParameter("@Date", dtpDate.Value.ToString("yyyy-MM-dd")),
            New MySqlParameter("@TimeIn_AM", dtpTimeInAM.Value.ToString("HH:mm:ss")),
            New MySqlParameter("@TimeOut_AM", dtpTimeOutAM.Value.ToString("HH:mm:ss")),
            New MySqlParameter("@TimeIn_PM", dtpTimeInPM.Value.ToString("HH:mm:ss")),
            New MySqlParameter("@TimeOut_PM", dtpTimeOutPM.Value.ToString("HH:mm:ss")),
            New MySqlParameter("@AttendanceID", txtAttendanceID.Text)
        }

        Try
            Dim rowsAffected As Integer = HRMModule.ExecuteNonQuery(query, parameters)

            If rowsAffected > 0 Then
                MessageBox.Show("Attendance updated successfully.", "Success")
                LoadAttendanceList()
                LockAllFields()
                btnEditAttendance.Visible = True
                btnSaveAttendance.Visible = False
                btnCancelAttendance.Visible = False
            Else
                MessageBox.Show("No changes were made.", "Info")
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to update attendance.", "Database Error")
        End Try
    End Sub

    Private Sub txtSearchAttendance_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAttendance.TextChanged
        Dim value As String = txtSearchAttendance.Text.Trim().Replace("'", "''")

        If value = "" Then
            attendanceBindingSource.RemoveFilter()
        Else
            attendanceBindingSource.Filter =
                $"Convert(EmployeeID, 'System.String') LIKE '%{value}%' OR EmployeeName LIKE '%{value}%'"
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
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            HRMModule.SignOut(Me)
            MessageBox.Show("You have been signed out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
