Imports MySql.Data.MySqlClient

Public Class Leave_Approval
    Private bsLeave As BindingSource
    Private originalStatus As String
    Private originalApprovedBy As String
    Private Sub Leave_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLeaveRequests()
        LockLeaveControls()
        cbStatus.Items.Clear()
        cbStatus.Items.AddRange(New Object() {"Pending", "Approved", "Rejected", "Cancelled", "Completed"})
        btnEditLeave.Visible = False
        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
    End Sub
    Private Sub LoadLeaveRequests()
        Dim query As String = "
            SELECT 
                l.LeaveID,
                e.EmployeeID,
                CONCAT(e.`First Name`, ' ', IFNULL(e.MiddleName, ''), ' ', e.LastName) AS EmployeeName,
                j.JobTitle,
                l.LeaveType,
                l.Reason,
                l.ApprovedBy,
                l.Status,
                l.DurationDateFrom,
                l.DurationDateTo
            FROM tblleave l
            LEFT JOIN tblemployee e ON l.EmployeeID = e.EmployeeID
            LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID;
        "

        Try
            Dim table As DataTable = HRMModule.ExecuteQuery(query)
            bsLeave = New BindingSource()
            bsLeave.DataSource = table
            dgvEmployeeLeaveHistory.DataSource = bsLeave

            dgvEmployeeLeaveHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvEmployeeLeaveHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvEmployeeLeaveHistory.ReadOnly = True
            dgvEmployeeLeaveHistory.AllowUserToAddRows = False
            dgvEmployeeLeaveHistory.AllowUserToDeleteRows = False
        Catch ex As Exception
            MessageBox.Show("Error loading leave requests: " & ex.Message)
        End Try
    End Sub
    Private Sub UnlockLeaveControls()
        cbStatus.Enabled = True
        txtApprovedBy.ReadOnly = False
    End Sub
    Private Sub LockLeaveControls()
        txtEmployeeID.ReadOnly = True
        txtEmployeeName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtLeaveID.ReadOnly = True
        cbLeaveType.Enabled = False
        txtReason.ReadOnly = True
        dtpLeaveDateFrom.Enabled = False
        dtpLeaveDateTo.Enabled = False
        cbStatus.Enabled = False
        txtApprovedBy.ReadOnly = True
    End Sub
    Private Sub dgvEmployeeLeaveHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeLeaveHistory.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvEmployeeLeaveHistory.Rows(e.RowIndex)
        txtLeaveID.Text = row.Cells("LeaveID").Value.ToString()
        txtEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
        txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
        txtJobTitle.Text = row.Cells("JobTitle").Value.ToString()
        cbLeaveType.Text = row.Cells("LeaveType").Value.ToString()
        txtReason.Text = row.Cells("Reason").Value.ToString()
        cbStatus.Text = row.Cells("Status").Value.ToString()
        txtApprovedBy.Text = If(row.Cells("ApprovedBy").Value IsNot Nothing, row.Cells("ApprovedBy").Value.ToString(), "")

        LockLeaveControls()

        btnEditLeave.Visible = True
        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
        originalStatus = cbStatus.Text
        originalApprovedBy = txtApprovedBy.Text
    End Sub
    Private Sub btnEditLeave_Click(sender As Object, e As EventArgs) Handles btnEditLeave.Click
        cbStatus.Enabled = True
        txtApprovedBy.ReadOnly = False
        btnEditLeave.Visible = False
        btnSaveLeave.Visible = True
        btnCancelLeave.Visible = True
    End Sub
    Private Sub btnCancelLeave_Click(sender As Object, e As EventArgs) Handles btnCancelLeave.Click
        Dim selectedIndex As Integer = dgvEmployeeLeaveHistory.CurrentRow.Index
        dgvEmployeeLeaveHistory_CellClick(dgvEmployeeLeaveHistory, New DataGridViewCellEventArgs(0, selectedIndex))
        btnEditLeave.Visible = True
        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
    End Sub
    Private Sub btnSaveLeave_Click(sender As Object, e As EventArgs) Handles btnSaveLeave.Click
        If cbStatus.Text = originalStatus AndAlso txtApprovedBy.Text.Trim() = originalApprovedBy.Trim() Then
            MessageBox.Show("No changes were made.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not ValidateLeaveEdit() Then Return

        Dim query As String = "UPDATE tblleave SET Status=@status, ApprovedBy=@manager WHERE LeaveID=@lid"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@status", cbStatus.Text),
            New MySqlParameter("@manager", txtApprovedBy.Text),
            New MySqlParameter("@lid", txtLeaveID.Text)
        }

        If HRMModule.ExecuteNonQuery(query, parameters) >= 0 Then
            MessageBox.Show("Leave status updated successfully by the manager.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadLeaveRequests()
            LockLeaveControls()
            btnEditLeave.Visible = True
            btnSaveLeave.Visible = False
            btnCancelLeave.Visible = False
        Else
            MessageBox.Show("Error updating leave. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateLeaveEdit() As Boolean
        If String.IsNullOrWhiteSpace(cbStatus.Text) Then
            MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbStatus.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtApprovedBy.Text) Then
            MessageBox.Show("Please enter the manager's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApprovedBy.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub txtSearchLeave_TextChanged(sender As Object, e As EventArgs) Handles txtSearchLeave.TextChanged
        Dim searchValue As String = txtSearchLeave.Text.Trim()

        If bsLeave Is Nothing Then Exit Sub

        If String.IsNullOrWhiteSpace(searchValue) Then
            bsLeave.RemoveFilter()
            Return
        End If

        searchValue = searchValue.Replace("'", "''")
        bsLeave.Filter = $"EmployeeName LIKE '%{searchValue}%'"
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
        lblLeaveApproval.Enabled = False
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
