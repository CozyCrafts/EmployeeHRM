Imports MySql.Data.MySqlClient
Public Class Leave_Approval
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private bsLeave As BindingSource
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

        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
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
                Dim adapter As New MySqlDataAdapter(query, dbcon)
                Dim table As New DataTable()
                adapter.Fill(table)

                bsLeave = New BindingSource()
                bsLeave.DataSource = table
                dgvEmployeeLeaveHistory.DataSource = bsLeave

                ' Hide EmployeeID column
                If dgvEmployeeLeaveHistory.Columns.Contains("EmployeeID") Then
                    dgvEmployeeLeaveHistory.Columns("EmployeeID").Visible = False
                End If

                dgvEmployeeLeaveHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvEmployeeLeaveHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvEmployeeLeaveHistory.ReadOnly = True
                dgvEmployeeLeaveHistory.AllowUserToAddRows = False
                dgvEmployeeLeaveHistory.AllowUserToDeleteRows = False
            End Using
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

        ' Populate textboxes and combo box
        Dim row As DataGridViewRow = dgvEmployeeLeaveHistory.Rows(e.RowIndex)
        txtLeaveID.Text = row.Cells("LeaveID").Value.ToString()
        txtEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
        txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
        txtJobTitle.Text = row.Cells("JobTitle").Value.ToString()
        cbLeaveType.Text = row.Cells("LeaveType").Value.ToString()
        txtReason.Text = row.Cells("Reason").Value.ToString()
        cbStatus.Text = row.Cells("Status").Value.ToString()
        txtApprovedBy.Text = If(row.Cells("ApprovedBy").Value IsNot Nothing, row.Cells("ApprovedBy").Value.ToString(), "")

        ' Lock controls
        LockLeaveControls()

        ' Show Edit button only when a row is selected
        btnEditLeave.Visible = True
        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
    End Sub
    ' ----------------- Edit Button -----------------
    Private Sub btnEditLeave_Click(sender As Object, e As EventArgs) Handles btnEditLeave.Click
        ' Enable only the editable fields
        cbStatus.Enabled = True
        txtApprovedBy.ReadOnly = False

        ' Show Save and Cancel, hide Edit
        btnEditLeave.Visible = False
        btnSaveLeave.Visible = True
        btnCancelLeave.Visible = True
    End Sub
    ' ----------------- Cancel Button -----------------
    Private Sub btnCancelLeave_Click(sender As Object, e As EventArgs) Handles btnCancelLeave.Click
        ' Reload current selected row
        Dim selectedIndex As Integer = dgvEmployeeLeaveHistory.CurrentRow.Index
        dgvEmployeeLeaveHistory_CellClick(dgvEmployeeLeaveHistory, New DataGridViewCellEventArgs(0, selectedIndex))

        ' Reset buttons
        btnEditLeave.Visible = True
        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
    End Sub

    ' ----------------- Save Button -----------------
    Private Sub btnSaveLeave_Click(sender As Object, e As EventArgs) Handles btnSaveLeave.Click
        ' Validate inputs
        If Not ValidateLeaveEdit() Then Return

        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim cmd As New MySqlCommand("UPDATE tblleave SET Status=@status, ApprovedBy=@manager WHERE LeaveID=@lid", dbcon)
                cmd.Parameters.AddWithValue("@status", cbStatus.Text)
                cmd.Parameters.AddWithValue("@manager", txtApprovedBy.Text)
                cmd.Parameters.AddWithValue("@lid", txtLeaveID.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Leave status updated successfully by the manager.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the data grid view
            LoadLeaveRequests()

            ' Lock controls and reset buttons
            LockLeaveControls()
            btnEditLeave.Visible = True
            btnSaveLeave.Visible = False
            btnCancelLeave.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error updating leave: " & ex.Message)
        End Try
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
    ' ----------------- Live Search -----------------
    Private Sub txtSearchLeave_TextChanged(sender As Object, e As EventArgs) Handles txtSearchLeave.TextChanged
        Dim searchValue As String = txtSearchLeave.Text.Trim()
        dgvEmployeeLeaveHistory.ClearSelection() ' clear previous selection

        If String.IsNullOrEmpty(searchValue) Then Return

        Dim searchParts() As String = searchValue.Split(" "c, StringSplitOptions.RemoveEmptyEntries)

        For Each row As DataGridViewRow In dgvEmployeeLeaveHistory.Rows
            If row.IsNewRow Then Continue For

            Dim employeeName As String = row.Cells("EmployeeName").Value.ToString()
            Dim matchFound As Boolean = False

            ' Full match check
            If employeeName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 Then
                matchFound = True
            Else
                ' Partial match for each word
                For Each part In searchParts
                    If employeeName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 Then
                        matchFound = True
                        Exit For
                    End If
                Next
            End If

            ' Select matching rows (blue highlight)
            row.Selected = matchFound
        Next
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
