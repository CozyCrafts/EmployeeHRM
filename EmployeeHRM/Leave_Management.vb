Imports MySql.Data.MySqlClient

Public Class Leave_Management
    Public Property UserRole As String
    Private currentSelectedRowIndex As Integer = 0
    Private dbtable As DataTable
    Private maxLeaveDays As Integer = 30

    Private Sub LeaveManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HRMModule.HideManagerLabelsForStaff(Me)
        Try
            LoadLeaveHistory()
            AddHandler dgvLeaveHistory.SelectionChanged, AddressOf dgvLeaveHistory_SelectionChanged

            btnSaveLeave.Visible = False
            btnCancelLeave.Visible = False
            LockTextBoxes()
        Catch ex As Exception
            MessageBox.Show("Error loading leave requests: " & ex.Message)
        End Try

        dtpDurationDateFrom.MinDate = DateTime.Today
        dtpDurationDateFrom.MaxDate = DateTime.Today.AddDays(maxLeaveDays - 1)

        dtpDurationDateTo.MinDate = dtpDurationDateFrom.Value
        dtpDurationDateTo.MaxDate = dtpDurationDateFrom.Value.AddDays(maxLeaveDays - 1)

        AddHandler dtpDurationDateFrom.ValueChanged, AddressOf dtpDurationDateFrom_ValueChanged
        AddHandler dtpDurationDateTo.ValueChanged, AddressOf dtpDurationDateTo_ValueChanged
    End Sub
    Private Sub dtpDurationDateFrom_ValueChanged(sender As Object, e As EventArgs)
        dtpDurationDateTo.MinDate = dtpDurationDateFrom.Value.AddDays(1)
        dtpDurationDateTo.MaxDate = dtpDurationDateFrom.Value.AddDays(maxLeaveDays - 1)
        If dtpDurationDateTo.Value <= dtpDurationDateFrom.Value Then
            dtpDurationDateTo.Value = dtpDurationDateFrom.Value.AddDays(1)
        End If
    End Sub
    Private Sub dtpDurationDateTo_ValueChanged(sender As Object, e As EventArgs)
        If dtpDurationDateTo.Value <= dtpDurationDateFrom.Value Then
            dtpDurationDateTo.Value = dtpDurationDateFrom.Value.AddDays(1)
        End If
    End Sub

    Private Sub LoadLeaveHistory()
        Try
            Dim query As String = "
                SELECT 
                    l.LeaveID, l.LeaveType, l.Reason, l.DurationDateFrom, l.DurationDateTo, l.Status, l.ApprovedBy,
                    e.EmployeeID, CONCAT(e.`First Name`, ' ', IFNULL(e.MiddleName, ''), ' ', e.LastName) AS EmployeeName
                FROM tblLeave l
                JOIN tblEmployee e ON l.EmployeeID = e.EmployeeID
                WHERE l.EmployeeID = @empID
                ORDER BY l.DurationDateFrom DESC;
            "

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", HRMModule.CurrentUser.EmployeeID)
            }

            dbtable = HRMModule.ExecuteQuery(query, parameters)

            dgvLeaveHistory.DataSource = dbtable
            dgvLeaveHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvLeaveHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvLeaveHistory.ReadOnly = True
            dgvLeaveHistory.AllowUserToAddRows = False
            dgvLeaveHistory.AllowUserToDeleteRows = False

            If dbtable.Rows.Count > 0 Then
                currentSelectedRowIndex = Math.Min(currentSelectedRowIndex, dbtable.Rows.Count - 1)
                PopulateLeaveDetails(dbtable.Rows(currentSelectedRowIndex))
            Else
                ClearLeaveFields()
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading leave history: " & ex.Message)
        End Try
    End Sub
    Private Sub LockTextBoxes()
        txtLeaveID.ReadOnly = True
        txtEmployeeID.ReadOnly = True
        txtEmployeeName.ReadOnly = True
        txtLeaveType.ReadOnly = True
        txtLeaveReason.ReadOnly = True
        dtpDurationDateFrom.Enabled = False
        dtpDurationDateTo.Enabled = False
        txtStatusLeave.ReadOnly = True
        txtApprovedBy.ReadOnly = True
    End Sub
    Private Sub UnlockLeaveFields()
        txtLeaveType.ReadOnly = False
        txtLeaveReason.ReadOnly = False
        dtpDurationDateFrom.Enabled = True
        dtpDurationDateTo.Enabled = True
    End Sub
    Private Sub PopulateLeaveDetails(row As DataRow)
        txtLeaveID.Text = row("LeaveID").ToString()
        txtLeaveType.Text = row("LeaveType").ToString()
        txtLeaveReason.Text = row("Reason").ToString()
        txtStatusLeave.Text = row("Status").ToString()
        txtApprovedBy.Text = If(IsDBNull(row("ApprovedBy")), "", row("ApprovedBy").ToString())
        txtEmployeeID.Text = row("EmployeeID").ToString()
        txtEmployeeName.Text = row("EmployeeName").ToString()

        Dim fromDate As DateTime
        If DateTime.TryParse(row("DurationDateFrom").ToString(), fromDate) Then
            dtpDurationDateFrom.Value = fromDate
        Else
            dtpDurationDateFrom.Value = DateTime.Today
        End If

        Dim toDate As DateTime
        If DateTime.TryParse(row("DurationDateTo").ToString(), toDate) Then
            dtpDurationDateTo.Value = toDate
        Else
            dtpDurationDateTo.Value = DateTime.Today
        End If
    End Sub
    Private Sub dgvLeaveHistory_SelectionChanged(sender As Object, e As EventArgs)
        If dgvLeaveHistory.SelectedRows.Count > 0 Then
            currentSelectedRowIndex = dgvLeaveHistory.SelectedRows(0).Index
            Dim row As DataRow = CType(dgvLeaveHistory.DataSource, DataTable).Rows(currentSelectedRowIndex)
            PopulateLeaveDetails(row)
        End If
    End Sub
    Private Sub ClearLeaveFields()
        txtLeaveID.Text = ""
        txtLeaveType.Text = ""
        txtLeaveReason.Text = ""
        txtStatusLeave.Text = ""
        txtApprovedBy.Text = ""
        txtEmployeeID.Text = ""
        txtEmployeeName.Text = ""
        dtpDurationDateFrom.Value = DateTime.Today
        dtpDurationDateTo.Value = DateTime.Today
    End Sub
    Private Sub btnApplyforLeave_Click(sender As Object, e As EventArgs) Handles btnApplyforLeave.Click
        Try
            Dim lastIDObj = HRMModule.ExecuteScalar("SELECT LeaveID FROM tblLeave ORDER BY LeaveID DESC LIMIT 1")
            Dim newID As String = "L001"
            Dim lastNum As Integer

            If lastIDObj IsNot Nothing AndAlso Integer.TryParse(lastIDObj.ToString().Substring(1), lastNum) Then
                newID = "L" & (lastNum + 1).ToString("D3")
            End If

            txtLeaveID.Text = newID
            txtLeaveType.Clear()
            txtLeaveReason.Clear()
            txtStatusLeave.Text = "Pending"
            txtApprovedBy.Clear()
            txtEmployeeID.Text = HRMModule.CurrentUser.EmployeeID
            txtEmployeeName.Text = HRMModule.CurrentUser.Username
            dtpDurationDateFrom.Value = DateTime.Today
            dtpDurationDateTo.Value = DateTime.Today

            UnlockLeaveFields()

            btnApplyforLeave.Visible = False
            btnSaveLeave.Visible = True
            btnCancelLeave.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error generating Leave ID: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSaveLeave_Click(sender As Object, e As EventArgs) Handles btnSaveLeave.Click
        Try
            If txtLeaveType.Text.Trim() = "" Or txtLeaveReason.Text.Trim() = "" Then
                MessageBox.Show("Please enter leave type and reason.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim today As DateTime = DateTime.Today
            Dim fromDate As DateTime = dtpDurationDateFrom.Value.Date
            Dim toDate As DateTime = dtpDurationDateTo.Value.Date

            If fromDate < today Then
                MessageBox.Show("Leave start date cannot be in the past.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If toDate <= fromDate Then
                MessageBox.Show("Leave end date must be after the start date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If (toDate - fromDate).Days + 1 > maxLeaveDays Then
                MessageBox.Show($"Leave duration cannot exceed {maxLeaveDays} days.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to submit this leave request?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            Dim query As String = "
                INSERT INTO tblLeave (LeaveID, EmployeeID, LeaveType, Reason, DurationDateFrom, DurationDateTo, Status)
                VALUES (@LeaveID, @EmployeeID, @LeaveType, @Reason, @DurationDateFrom, @DurationDateTo, @Status)
            "
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@LeaveID", txtLeaveID.Text),
                New MySqlParameter("@EmployeeID", HRMModule.CurrentUser.EmployeeID),
                New MySqlParameter("@LeaveType", txtLeaveType.Text.Trim()),
                New MySqlParameter("@Reason", txtLeaveReason.Text.Trim()),
                New MySqlParameter("@DurationDateFrom", fromDate),
                New MySqlParameter("@DurationDateTo", toDate),
                New MySqlParameter("@Status", "Pending")
            }

            Dim success = HRMModule.ExecuteNonQuery(query, parameters)
            If success Then
                MessageBox.Show("Leave request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadLeaveHistory()
                btnSaveLeave.Visible = False
                btnCancelLeave.Visible = False
                btnApplyforLeave.Visible = True
                LockTextBoxes()
                ClearLeaveFields()
            Else
                MessageBox.Show("Failed to submit leave request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving leave request: " & ex.Message)
        End Try
    End Sub
    Private Sub btnCancelLeave_Click(sender As Object, e As EventArgs) Handles btnCancelLeave.Click
        If dbtable.Rows.Count > 0 AndAlso currentSelectedRowIndex < dbtable.Rows.Count Then
            PopulateLeaveDetails(dbtable.Rows(currentSelectedRowIndex))
        Else
            ClearLeaveFields()
        End If

        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
        btnApplyforLeave.Visible = True
        LockTextBoxes()
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
        Me.Hide()
    End Sub
    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        lblLeaveManagement.Enabled = False
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
        HRMModule.SignOut(Me)
    End Sub


End Class
