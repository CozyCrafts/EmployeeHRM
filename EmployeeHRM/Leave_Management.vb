Imports MySql.Data.MySqlClient

Public Class Leave_Management
    Public Property UserRole As String
    Private currentSelectedRowIndex As Integer = 0 ' Track current selection

    Private Sub LeaveManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenCon()
            LoadLeaveHistory()
            AddHandler dgvLeaveHistory.SelectionChanged, AddressOf dgvLeaveHistory_SelectionChanged

            ' Hide Save and Cancel initially
            btnSaveLeave.Visible = False
            btnCancelLeave.Visible = False

            ' Lock all textboxes initially
            LockTextBoxes()

        Catch ex As Exception
            MessageBox.Show("Error loading leave requests: " & ex.Message)
        End Try
    End Sub

    ' --- Refactored Data Loading with JOIN ---
    Private Sub LoadLeaveHistory()
        Try
            Dim query As String = "SELECT l.leave_id, l.leave_type, l.reason, l.start_date, l.end_date, l.status, l.approved_by, " &
                              "e.`employee_id`, " &
                              "CONCAT(e.`first name`, ' ', IFNULL(e.`middle name`, ''), ' ', e.`last name`) AS full_name " &
                              "FROM tblLeave l " &
                              "JOIN tblEmployee e ON l.employee_id = e.`employee_id` " &
                              "WHERE l.employee_id = @empID " &
                              "ORDER BY l.start_date DESC"

            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            dbadapter = New MySqlDataAdapter(dbcmd)
            dbtable = New DataTable()
            dbadapter.Fill(dbtable)

            dgvLeaveHistory.DataSource = dbtable

            If dbtable.Rows.Count > 0 Then
                currentSelectedRowIndex = Math.Min(currentSelectedRowIndex, dbtable.Rows.Count - 1)
                PopulateLeaveDetails(dbtable.Rows(currentSelectedRowIndex))
            Else
                ClearLeaveFields()
            End If

        Catch ex As Exception
            Console.WriteLine("LoadLeaveHistory Error: " & ex.Message)
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
        ' Leave info
        txtLeaveID.Text = row("leave_id").ToString()
        txtLeaveType.Text = row("leave_type").ToString()
        txtLeaveReason.Text = row("reason").ToString()
        txtStatusLeave.Text = row("status").ToString()
        txtApprovedBy.Text = If(IsDBNull(row("approved_by")), "", row("approved_by").ToString())
        dtpDurationDateFrom.Value = Convert.ToDateTime(row("start_date"))
        dtpDurationDateTo.Value = Convert.ToDateTime(row("end_date"))

        ' Employee info
        txtEmployeeID.Text = row("employee_id").ToString()
        txtEmployeeName.Text = row("full_name").ToString()
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
        dtpDurationDateFrom.Value = DateTime.Now
        dtpDurationDateTo.Value = DateTime.Now
    End Sub

    ' --- Apply for Leave ---
    Private Sub btnApplyForLeave_Click(sender As Object, e As EventArgs) Handles btnApplyforLeave.Click
        Try
            OpenCon()

            ' Safe Leave ID generation
            Dim query As String = "SELECT leave_id FROM tblLeave ORDER BY leave_id DESC LIMIT 1"
            dbcmd = New MySqlCommand(query, dbcon)
            Dim lastIDObj = dbcmd.ExecuteScalar()
            Dim newID As String
            Dim lastNum As Integer

            If lastIDObj IsNot Nothing AndAlso Integer.TryParse(lastIDObj.ToString().Substring(1), lastNum) Then
                newID = "L" & (lastNum + 1).ToString("D3")
            Else
                newID = "L001"
            End If

            ' Populate form for new leave
            txtLeaveID.Text = newID
            txtLeaveType.Text = ""
            txtLeaveReason.Text = ""
            txtStatusLeave.Text = "Pending"
            txtApprovedBy.Text = ""
            dtpDurationDateFrom.Value = DateTime.Now
            dtpDurationDateTo.Value = DateTime.Now

            LockTextBoxes()
            UnlockLeaveFields()

            ' Show Save/Cancel, disable Apply
            btnSaveLeave.Visible = True
            btnCancelLeave.Visible = True
            btnApplyforLeave.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error generating leave ID: " & ex.Message)
        End Try
    End Sub

    ' --- Save Leave ---
    Private Sub btnSaveLeave_Click(sender As Object, e As EventArgs) Handles btnSaveLeave.Click
        Try
            ' Validation
            If txtLeaveType.Text = "" Or txtLeaveReason.Text = "" Then
                MessageBox.Show("Please enter leave type and reason.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If dtpDurationDateTo.Value < dtpDurationDateFrom.Value Then
                MessageBox.Show("End date cannot be earlier than start date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            OpenCon()
            Dim query As String = "INSERT INTO tblLeave (leave_id, employee_id, leave_type, reason, start_date, end_date, status) " &
                                  "VALUES (@leaveID, @empID, @type, @reason, @startDate, @endDate, @status)"
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@leaveID", txtLeaveID.Text)
            dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            dbcmd.Parameters.AddWithValue("@type", txtLeaveType.Text)
            dbcmd.Parameters.AddWithValue("@reason", txtLeaveReason.Text)
            dbcmd.Parameters.AddWithValue("@startDate", dtpDurationDateFrom.Value)
            dbcmd.Parameters.AddWithValue("@endDate", dtpDurationDateTo.Value)
            dbcmd.Parameters.AddWithValue("@status", "Pending")
            dbcmd.ExecuteNonQuery()

            MessageBox.Show("Leave request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh grid and reset buttons
            LoadLeaveHistory()
            btnSaveLeave.Visible = False
            btnCancelLeave.Visible = False
            btnApplyforLeave.Enabled = True
            LockTextBoxes()

        Catch ex As Exception
            MessageBox.Show("Error saving leave request: " & ex.Message)
        End Try
    End Sub

    ' --- Cancel Leave ---
    Private Sub btnCancelLeave_Click(sender As Object, e As EventArgs) Handles btnCancelLeave.Click
        If dbtable.Rows.Count > 0 AndAlso currentSelectedRowIndex < dbtable.Rows.Count Then
            PopulateLeaveDetails(dbtable.Rows(currentSelectedRowIndex))
        Else
            ClearLeaveFields()
        End If

        btnSaveLeave.Visible = False
        btnCancelLeave.Visible = False
        btnApplyforLeave.Enabled = True
        LockTextBoxes()
    End Sub

    ' --- Navigation buttons ---
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
