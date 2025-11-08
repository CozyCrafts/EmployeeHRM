Imports MySql.Data.MySqlClient

Public Class Employee_Trainings
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private isAdding As Boolean = False
    Private Sub Employee_Trainings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        LoadTrainings()
        LockControls()
        SetDefaultButtonState()
    End Sub
    Private Sub SetDefaultButtonState()
        btnAddTraining.Visible = True
        btnEditTraining.Visible = False
        btnDeleteTraining.Visible = False
        btnSaveTraining.Visible = False
        btnCancelTraining.Visible = False
    End Sub
    Private Sub SetRecordSelectedButtonState()
        btnAddTraining.Visible = True
        btnEditTraining.Visible = True
        btnDeleteTraining.Visible = True
        btnSaveTraining.Visible = False
        btnCancelTraining.Visible = False
    End Sub
    Private Sub SetEditAddButtonState()
        btnAddTraining.Visible = False
        btnEditTraining.Visible = False
        btnDeleteTraining.Visible = False
        btnSaveTraining.Visible = True
        btnCancelTraining.Visible = True
    End Sub
    Private Sub LoadEmployees()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT EmployeeID, CONCAT(`First Name`, ' ', MiddleName, ' ', LastName) AS FullName FROM tblemployee"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        cbEmployeeID.DataSource = dt
                        cbEmployeeID.ValueMember = "EmployeeID"
                        cbEmployeeID.DisplayMember = "EmployeeID"
                        cbEmployeeID.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadTrainings()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    SELECT 
                        td.TrainingID,
                        td.EmployeeID,
                        CONCAT_WS(' ', e.`First Name`, e.MiddleName, e.LastName) AS EmployeeName,
                        td.TrainingTitle,
                        td.TrainingType,
                        td.Status,
                        td.DateStarted,
                        td.DateCompleted,
                        td.Description
                    FROM tbltrainingdevelopment td
                    LEFT JOIN tblemployee e ON td.EmployeeID = e.EmployeeID
                    ORDER BY td.TrainingID;
                "
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvEmployeeTrainingHistory.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading trainings: " & ex.Message)
        End Try
    End Sub
    Private Sub LockControls()
        cbEmployeeID.Enabled = False
        txtEmployeeName.ReadOnly = True
        txtTrainingID.ReadOnly = True
        txtTrainingTitle.ReadOnly = True
        txtTrainingType.ReadOnly = True
        txtTrainingDescription.ReadOnly = True
        dtpTrainingStarted.Enabled = False
        dtpTrainingCompleted.Enabled = False
        rbPlanned.Enabled = False
        rbInProgress.Enabled = False
        rbCompleted.Enabled = False
        rbPostponed.Enabled = False
        SetDefaultButtonState()
    End Sub
    Private Sub UnlockControls()
        txtTrainingTitle.ReadOnly = False
        txtTrainingType.ReadOnly = False
        txtTrainingDescription.ReadOnly = False
        cbEmployeeID.Enabled = False
        txtEmployeeName.ReadOnly = True
        txtTrainingID.ReadOnly = True
        dtpTrainingStarted.Enabled = True
        dtpTrainingCompleted.Enabled = True
        rbPlanned.Enabled = True
        rbInProgress.Enabled = True
        rbCompleted.Enabled = True
        rbPostponed.Enabled = True
    End Sub
    Private Sub ClearForm()
        cbEmployeeID.SelectedIndex = -1
        txtEmployeeName.Clear()
        txtTrainingID.Clear()
        txtTrainingTitle.Clear()
        txtTrainingType.Clear()
        txtTrainingDescription.Clear()
        dtpTrainingStarted.Value = Date.Now
        dtpTrainingCompleted.Value = Date.Now
        rbPlanned.Checked = True
    End Sub
    Private Sub dgvEmployeeTrainingHistory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployeeTrainingHistory.SelectionChanged
        If dgvEmployeeTrainingHistory.CurrentRow IsNot Nothing AndAlso Not isAdding Then
            Dim row As DataGridViewRow = dgvEmployeeTrainingHistory.CurrentRow
            cbEmployeeID.SelectedValue = If(row.Cells("EmployeeID").Value IsNot DBNull.Value, row.Cells("EmployeeID").Value.ToString(), "")
            txtEmployeeName.Text = If(row.Cells("EmployeeName").Value IsNot DBNull.Value, row.Cells("EmployeeName").Value.ToString(), "")
            txtTrainingID.Text = If(row.Cells("TrainingID").Value IsNot DBNull.Value, row.Cells("TrainingID").Value.ToString(), "")
            txtTrainingTitle.Text = If(row.Cells("TrainingTitle").Value IsNot DBNull.Value, row.Cells("TrainingTitle").Value.ToString(), "")
            txtTrainingType.Text = If(row.Cells("TrainingType").Value IsNot DBNull.Value, row.Cells("TrainingType").Value.ToString(), "")
            txtTrainingDescription.Text = If(row.Cells("Description").Value IsNot DBNull.Value, row.Cells("Description").Value.ToString(), "")
            dtpTrainingStarted.Value = If(IsDate(row.Cells("DateStarted").Value), CDate(row.Cells("DateStarted").Value), Date.Now)
            dtpTrainingCompleted.Value = If(IsDate(row.Cells("DateCompleted").Value), CDate(row.Cells("DateCompleted").Value), Date.Now)
            Dim status As String = If(row.Cells("Status").Value IsNot DBNull.Value, row.Cells("Status").Value.ToString(), "")
            rbPlanned.Checked = (status = "Planned")
            rbInProgress.Checked = (status = "In Progress")
            rbCompleted.Checked = (status = "Completed")
            rbPostponed.Checked = (status = "Postponed")
            LockControls()
            SetRecordSelectedButtonState()
        End If
    End Sub
    Private Sub btnAddTraining_Click(sender As Object, e As EventArgs) Handles btnAddTraining.Click
        isAdding = True
        ClearForm()
        LoadEmployees()
        cbEmployeeID.Enabled = True
        txtTrainingID.Text = GetNextTrainingID()
        txtTrainingID.ReadOnly = True
        txtTrainingTitle.ReadOnly = False
        txtTrainingType.ReadOnly = False
        txtTrainingDescription.ReadOnly = False
        dtpTrainingStarted.Enabled = True
        dtpTrainingCompleted.Enabled = False
        rbPlanned.Checked = True
        rbPlanned.Enabled = True
        rbInProgress.Checked = False
        rbInProgress.Enabled = False
        rbCompleted.Checked = False
        rbCompleted.Enabled = False
        rbPostponed.Checked = False
        rbPostponed.Enabled = False
        SetEditAddButtonState()
    End Sub
    Private Sub cbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployeeID.SelectedIndexChanged
        If cbEmployeeID.SelectedIndex <> -1 Then
            Dim selectedID As String = cbEmployeeID.SelectedValue.ToString()
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "SELECT CONCAT(`First Name`, ' ', MiddleName, ' ', LastName) AS FullName FROM tblemployee WHERE EmployeeID=@EmployeeID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@EmployeeID", selectedID)
                        Dim empName = cmd.ExecuteScalar()
                        txtEmployeeName.Text = If(empName IsNot Nothing, empName.ToString(), "")
                        txtEmployeeName.ReadOnly = True
                    End Using
                End Using
                cbEmployeeID.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Error fetching employee name: " & ex.Message)
            End Try
        Else
            txtEmployeeName.Clear()
        End If
    End Sub
    Private Sub btnEditTraining_Click(sender As Object, e As EventArgs) Handles btnEditTraining.Click
        If String.IsNullOrEmpty(txtTrainingID.Text) Then
            MessageBox.Show("Select a training to edit.")
            Return
        End If
        isAdding = False
        UnlockControls()
        SetEditAddButtonState()
    End Sub
    Private Sub btnSaveTraining_Click(sender As Object, e As EventArgs) Handles btnSaveTraining.Click
        Dim status As String = If(rbPlanned.Checked, "Planned", If(rbInProgress.Checked, "In Progress", If(rbCompleted.Checked, "Completed", "Postponed")))
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String
                If isAdding Then
                    query = "INSERT INTO tbltrainingdevelopment (EmployeeID, TrainingID, TrainingTitle, TrainingType, Status, DateStarted, DateCompleted, Description) " &
                            "VALUES (@EmployeeID, @TrainingID, @TrainingTitle, @TrainingType, @Status, @DateStarted, @DateCompleted, @Description)"
                Else
                    query = "UPDATE tbltrainingdevelopment SET TrainingTitle=@TrainingTitle, TrainingType=@TrainingType, Status=@Status, " &
                            "DateStarted=@DateStarted, DateCompleted=@DateCompleted, Description=@Description WHERE TrainingID=@TrainingID"
                End If
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", cbEmployeeID.SelectedValue.ToString())
                    cmd.Parameters.AddWithValue("@TrainingID", txtTrainingID.Text.Trim())
                    cmd.Parameters.AddWithValue("@TrainingTitle", txtTrainingTitle.Text.Trim())
                    cmd.Parameters.AddWithValue("@TrainingType", txtTrainingType.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@DateStarted", dtpTrainingStarted.Value)
                    cmd.Parameters.AddWithValue("@DateCompleted", dtpTrainingCompleted.Value)
                    cmd.Parameters.AddWithValue("@Description", txtTrainingDescription.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Training saved successfully.")
            LoadTrainings()
        Catch ex As Exception
            MessageBox.Show("Error saving training: " & ex.Message)
        End Try
        isAdding = False
        LockControls()
        SetDefaultButtonState()
    End Sub
    Private Sub btnDeleteTraining_Click(sender As Object, e As EventArgs) Handles btnDeleteTraining.Click
        If String.IsNullOrEmpty(txtTrainingID.Text) Then
            MessageBox.Show("Select a training to delete.")
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this training?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "DELETE FROM tbltrainingdevelopment WHERE TrainingID=@TrainingID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@TrainingID", txtTrainingID.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Training deleted successfully.")
                LoadTrainings()
                ClearForm()
                LockControls()
                SetDefaultButtonState()
            Catch ex As Exception
                MessageBox.Show("Error deleting training: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnCancelTraining_Click(sender As Object, e As EventArgs) Handles btnCancelTraining.Click
        isAdding = False
        ClearForm()
        LoadTrainings()
        LockControls()
        SetDefaultButtonState()
    End Sub
    Private Function GetNextTrainingID() As String
        Dim newID As String = "TR1"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT TrainingID FROM tbltrainingdevelopment ORDER BY TrainingID DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim lastID = cmd.ExecuteScalar()
                    If lastID IsNot Nothing Then
                        Dim numPart As Integer
                        If Integer.TryParse(lastID.ToString().Substring(2), numPart) Then
                            newID = "TR" & (numPart + 1).ToString()
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Training ID: " & ex.Message)
        End Try
        Return newID
    End Function
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
    Manager_Dashboard.Show()
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
        lblEmployeeTrainings.Enabled = False
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