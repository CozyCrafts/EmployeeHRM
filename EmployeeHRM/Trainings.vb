Imports MySql.Data.MySqlClient

Public Class Trainings
    Public Property UserRole As String
    Private isEditing As Boolean = False
    Private originalStatus As String = ""
    Private originalDateStarted As Date
    Private originalDateCompleted As Date

    Private Sub Trainings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentUser.UserType = "Staff" Then
            lblManagement.Visible = False
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
        Dim query As String = "
        SELECT TrainingID, TrainingTitle, TrainingType, Status,
               DateStarted, DateCompleted, Description
        FROM tbltrainingdevelopment
        WHERE EmployeeID=@empID
        ORDER BY DateStarted DESC;
    "

        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@empID", HRMModule.CurrentUser.EmployeeID)
    }

        Try
            Dim dt As DataTable = HRMModule.ExecuteQuery(query, parameters)

            For Each row As DataRow In dt.Rows

                If Not IsDBNull(row("DateStarted")) AndAlso row("DateStarted").ToString() <> "" Then
                    row("DateStarted") = Convert.ToDateTime(row("DateStarted")).ToString("yyyy-MM-dd")
                Else
                    row("DateStarted") = ""
                End If

                If Not IsDBNull(row("DateCompleted")) AndAlso row("DateCompleted").ToString() <> "" Then
                    row("DateCompleted") = Convert.ToDateTime(row("DateCompleted")).ToString("yyyy-MM-dd")
                Else
                    row("DateCompleted") = ""
                End If

            Next

            dgvTrainingHistory.DataSource = dt

            dgvTrainingHistory.Columns("DateStarted").HeaderText = "Date Started"
            dgvTrainingHistory.Columns("DateCompleted").HeaderText = "Date Completed"

            dgvTrainingHistory.ReadOnly = True
            dgvTrainingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvTrainingHistory.MultiSelect = False
            dgvTrainingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvTrainingHistory.ScrollBars = ScrollBars.Both

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
        dtpStarted.Enabled = (originalStatus <> "Completed")
        dtpCompleted.Enabled = (originalStatus <> "Completed")
        SetRadioButtonOptions(originalStatus)
    End Sub
    Private Sub SetRadioButtonOptions(currentStatus As String)
        Select Case currentStatus
            Case "Planned"
                rbPlanned.Enabled = False
                rbInProgress.Enabled = True
                rbCompleted.Enabled = False
                rbPostponed.Enabled = True
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

        If originalStatus = "Completed" Then
            MessageBox.Show("This training has been completed and can no longer be updated.")
            Return
        End If

        isEditing = True
        UnlockControls()
    End Sub


    Private Sub btnSaveTraining_Click(sender As Object, e As EventArgs) Handles btnSaveTraining.Click
    If Not isEditing Then Return

    Dim selectedRow As DataGridViewRow = dgvTrainingHistory.CurrentRow
    If selectedRow Is Nothing Then Return

    Dim trainingID As String = selectedRow.Cells("TrainingID").Value.ToString()

    Dim newStatus As String = If(rbPlanned.Checked, "Planned",
                 If(rbInProgress.Checked, "In Progress",
                 If(rbCompleted.Checked, "Completed", "Postponed")))

    Dim dateStarted As Date = originalDateStarted
    Dim dateCompleted As Date = originalDateCompleted

        Select Case newStatus
            Case "Planned"
                dateStarted = Date.MinValue
                dateCompleted = Date.MinValue

            Case "In Progress"
                If originalDateStarted = Date.MinValue Then
                    dateStarted = Date.Today
                End If
                dateCompleted = Date.MinValue

            Case "Completed"
                If originalDateStarted = Date.MinValue Then
                    dateStarted = Date.Today
                End If
                dateCompleted = Date.Today

            Case "Postponed"
                If originalDateStarted = Date.MinValue Then
                    dateStarted = Date.Today
                End If
                dateCompleted = Date.MinValue
        End Select
        Dim cleanStarted As Object = If(dateStarted = Date.MinValue, Nothing, dateStarted)
    Dim cleanCompleted As Object = If(dateCompleted = Date.MinValue, Nothing, dateCompleted)

    If originalStatus = newStatus AndAlso
       originalDateStarted = dateStarted AndAlso
       originalDateCompleted = dateCompleted Then

        MessageBox.Show("No changes were made.")
        LockControls()
        isEditing = False
        Return
    End If

        Dim updateQuery As String = "
        UPDATE tbltrainingdevelopment
        SET Status=@status, 
            DateStarted=@dateStarted, 
            DateCompleted=@dateCompleted
        WHERE TrainingID=@trainingID;
    "
    Dim updateParams As New List(Of MySqlParameter) From {
        New MySqlParameter("@status", newStatus),
        New MySqlParameter("@dateStarted",
            If(dateStarted = Date.MinValue, DBNull.Value, dateStarted.ToString("yyyy-MM-dd"))),
        New MySqlParameter("@dateCompleted",
            If(dateCompleted = Date.MinValue, DBNull.Value, dateCompleted.ToString("yyyy-MM-dd"))),
        New MySqlParameter("@trainingID", trainingID)
    }

    Try
        Dim rowsAffected As Integer = HRMModule.ExecuteNonQuery(updateQuery, updateParams)
        If rowsAffected > 0 Then
            MessageBox.Show("Training updated successfully.")
        Else
            MessageBox.Show("No rows were updated. Check the TrainingID.")
        End If

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
        If isEditing Then Return
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

        Dim tempDate As Date
        If Not IsDBNull(row.Cells("DateStarted").Value) AndAlso DateTime.TryParse(row.Cells("DateStarted").Value.ToString(), tempDate) Then
            originalDateStarted = tempDate.Date
        Else
            originalDateStarted = Date.Today
        End If

        If Not IsDBNull(row.Cells("DateCompleted").Value) AndAlso DateTime.TryParse(row.Cells("DateCompleted").Value.ToString(), tempDate) Then
            originalDateCompleted = tempDate.Date
        Else
            originalDateCompleted = Date.Today
        End If

        dtpStarted.Value = originalDateStarted
        dtpCompleted.Value = originalDateCompleted

        LockControls()
        btnUpdateTraining.Visible = True
    End Sub


    Private Sub rbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlanned.CheckedChanged, rbInProgress.CheckedChanged, rbCompleted.CheckedChanged, rbPostponed.CheckedChanged
        If Not isEditing Then Return

        If rbPlanned.Checked Then
            dtpStarted.Enabled = False
            dtpCompleted.Enabled = False
        ElseIf rbInProgress.Checked Then
            dtpStarted.Enabled = True
            dtpCompleted.Enabled = False
            If originalDateStarted = Date.MinValue Then
                dtpStarted.Value = Date.Now
            End If
        ElseIf rbCompleted.Checked Then
            dtpStarted.Value = If(originalDateStarted = Date.MinValue, Date.Now, originalDateStarted)
            dtpCompleted.Value = Date.Now
            dtpStarted.Enabled = False
            dtpCompleted.Enabled = False
        ElseIf rbPostponed.Checked Then
            dtpStarted.Enabled = True
            dtpCompleted.Enabled = False
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
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        HRMModule.SignOut(Me)
    End Sub


End Class