Imports MySql.Data.MySqlClient

Public Class Trainings
    Public Property UserRole As String
    Private isEditing As Boolean = False
    Private originalStatus As String = ""
    Private originalDateStarted As Date
    Private originalDateCompleted As Date
    Private Sub Trainings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoggedInUserType = "Staff" Then
            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If

        LoadTrainings()
        LockControls()
    End Sub
    Private Sub LoadTrainings()
        Try
            OpenCon()
            Dim query As String = "
                SELECT TrainingID, TrainingTitle, TrainingType, Status, DateStarted, DateCompleted, Description
                FROM tbltrainingdevelopment
                WHERE EmployeeID=@empID
                ORDER BY DateStarted DESC
            "
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)

            dbadapter = New MySqlDataAdapter(dbcmd)
            dbtable = New DataTable()
            dbadapter.Fill(dbtable)

            dgvTrainingHistory.DataSource = dbtable
            dgvTrainingHistory.ReadOnly = True
            dgvTrainingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvTrainingHistory.MultiSelect = False

        Catch ex As Exception
            MessageBox.Show("Error loading trainings: " & ex.Message)
        End Try
    End Sub
    Private Sub LockControls()
        btnUpdateTraining.Visible = False
        btnSaveTraining.Visible = False
        btnCancelTraining.Visible = False

        rbPlanned.Enabled = False
        rbInProgress.Enabled = False
        rbCompleted.Enabled = False
        rbPostponed.Enabled = False

        txtTrainingID.ReadOnly = True
        txtTrainingTitle.ReadOnly = True
        txtTrainingType.ReadOnly = True
        txtTrainingDescription.ReadOnly = True

        dtpStarted.Enabled = False
        dtpCompleted.Enabled = False
    End Sub
    Private Sub UnlockControls()
        btnUpdateTraining.Visible = False
        btnSaveTraining.Visible = True
        btnCancelTraining.Visible = True
        txtTrainingTitle.ReadOnly = False
        txtTrainingType.ReadOnly = False
        txtTrainingDescription.ReadOnly = False
        SetRadioButtonOptions(originalStatus)
    End Sub
    Private Sub SetRadioButtonOptions(currentStatus As String)
        Select Case currentStatus
            Case "Planned"
                rbPlanned.Enabled = False
                rbInProgress.Enabled = True
                rbCompleted.Enabled = False
                rbPostponed.Enabled = False
            Case "In Progress"
                rbPlanned.Enabled = False
                rbInProgress.Enabled = False
                rbCompleted.Enabled = True
                rbPostponed.Enabled = True
            Case "Completed", "Postponed"
                rbPlanned.Enabled = False
                rbInProgress.Enabled = False
                rbCompleted.Enabled = False
                rbPostponed.Enabled = False
        End Select
    End Sub
    Private Sub btnUpdateTraining_Click(sender As Object, e As EventArgs) Handles btnUpdateTraining.Click
        If dgvTrainingHistory.CurrentRow Is Nothing Then
            MessageBox.Show("Select a training to update.")
            Return
        End If
        isEditing = True
        UnlockControls()
    End Sub
    Private Sub btnSaveTraining_Click(sender As Object, e As EventArgs) Handles btnSaveTraining.Click
        If Not isEditing Then Return

        Dim selectedRow As DataGridViewRow = dgvTrainingHistory.CurrentRow
        Dim trainingID As String = selectedRow.Cells("TrainingID").Value.ToString()
        Dim newStatus As String = If(rbPlanned.Checked, "Planned",
                                 If(rbInProgress.Checked, "In Progress",
                                 If(rbCompleted.Checked, "Completed", "Postponed")))

        Dim dateStarted As Date = originalDateStarted
        Dim dateCompleted As Date = originalDateCompleted

        If rbInProgress.Checked AndAlso originalDateStarted = Date.MinValue Then
            dateStarted = Date.Now
        End If
        If rbCompleted.Checked Then
            dateCompleted = Date.Now
        End If

        If originalStatus = newStatus AndAlso originalDateStarted = dateStarted AndAlso originalDateCompleted = dateCompleted Then
            MessageBox.Show("No changes were made.")
            LockControls()
            isEditing = False
            Return
        End If

        Try
            Dim query As String = "
                UPDATE tbltrainingdevelopment
                SET Status=@status, DateStarted=@dateStarted, DateCompleted=@dateCompleted
                WHERE TrainingID=@trainingID
            "
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@status", newStatus)
            dbcmd.Parameters.AddWithValue("@dateStarted", dateStarted)
            dbcmd.Parameters.AddWithValue("@dateCompleted", dateCompleted)
            dbcmd.Parameters.AddWithValue("@trainingID", trainingID)
            dbcmd.ExecuteNonQuery()

            MessageBox.Show("Training updated successfully.")
            LoadTrainings()
            LockControls()
            isEditing = False

        Catch ex As Exception
            MessageBox.Show("Error updating training: " & ex.Message)
        End Try
    End Sub
    Private Sub btnCancelTraining_Click(sender As Object, e As EventArgs) Handles btnCancelTraining.Click
        LoadTrainings()
        LockControls()
        isEditing = False
    End Sub
    Private Sub dgvTrainingHistory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTrainingHistory.SelectionChanged
        If dgvTrainingHistory.CurrentRow Is Nothing Then Return

        Dim row As DataGridViewRow = dgvTrainingHistory.CurrentRow
        txtTrainingID.Text = row.Cells("TrainingID").Value.ToString()
        txtTrainingTitle.Text = row.Cells("TrainingTitle").Value.ToString()
        txtTrainingType.Text = row.Cells("TrainingType").Value.ToString()
        txtTrainingDescription.Text = row.Cells("Description").Value.ToString()
        originalStatus = row.Cells("Status").Value.ToString()
        rbInProgress.Checked = (originalStatus = "In Progress")
        rbPlanned.Checked = (originalStatus = "Planned")
        rbCompleted.Checked = (originalStatus = "Completed")
        rbPostponed.Checked = (originalStatus = "Postponed")
        originalDateStarted = If(IsDBNull(row.Cells("DateStarted").Value), Date.Now, CDate(row.Cells("DateStarted").Value))
        originalDateCompleted = If(IsDBNull(row.Cells("DateCompleted").Value), Date.Now, CDate(row.Cells("DateCompleted").Value))
        dtpStarted.Value = originalDateStarted
        dtpCompleted.Value = originalDateCompleted

        LockControls()
        If originalStatus <> "Completed" Then
            btnUpdateTraining.Visible = True
        Else
            btnUpdateTraining.Visible = False
        End If
        btnSaveTraining.Visible = False
        btnCancelTraining.Visible = False
    End Sub
    Private Sub rbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles rbInProgress.CheckedChanged, rbCompleted.CheckedChanged
        If isEditing Then
            If rbInProgress.Checked Then
                dtpStarted.Value = Date.Now
            End If
            If rbCompleted.Checked Then
                dtpCompleted.Value = Date.Now
            End If
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
        lblTrainings.Enabled = False
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
        Dim result = MessageBox.Show(
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
            Hide()
        End If
    End Sub
End Class