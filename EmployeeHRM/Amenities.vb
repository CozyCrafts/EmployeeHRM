Imports MySql.Data.MySqlClient

Public Class Amenities
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private isAddingAmenity As Boolean = False
    Private Sub Amenities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAmenities()
        cbConditionAmenities.Items.AddRange({"Good", "Needs Repair", "Excellent", "Fair"})
        cbConditionAmenities.SelectedIndex = -1
        LockControls()
        SetDefaultAmenityButtons()
    End Sub
    Private Function GetNullableInt(value As String) As Object
        If String.IsNullOrWhiteSpace(value) Then Return DBNull.Value
        Dim num As Integer
        If Integer.TryParse(value, num) Then Return num Else Return DBNull.Value
    End Function
    Private Sub LoadAmenities()
        Dim query As String = "
            SELECT 
                a.AmenitiesID,
                a.Name AS AmenityName,
                a.Location,
                a.Condition,
                a.EmployeeID,
                e.`First Name` AS FirstName,
                e.MiddleName,
                e.LastName,
                a.DepartmentID,
                d.Name AS DepartmentName
            FROM tblamenities a
            LEFT JOIN tblemployee e ON a.EmployeeID = e.EmployeeID
            LEFT JOIN tbldepartment d ON a.DepartmentID = d.DepartmentID
            ORDER BY a.AmenitiesID;
        "
        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        If Not table.Columns.Contains("EmployeeName") Then
                            table.Columns.Add("EmployeeName", GetType(String))
                        End If
                        For Each row As DataRow In table.Rows
                            Dim firstName As String = If(row("FirstName") IsNot DBNull.Value, row("FirstName").ToString(), "")
                            Dim middleName As String = If(row("MiddleName") IsNot DBNull.Value, row("MiddleName").ToString(), "")
                            Dim lastName As String = If(row("LastName") IsNot DBNull.Value, row("LastName").ToString(), "")
                            row("EmployeeName") = (firstName & " " & middleName & " " & lastName).Trim()
                        Next
                        dgvAmenities.DataSource = table
                        For Each col As String In {"EmployeeID", "EmployeeName", "FirstName", "MiddleName", "LastName", "DepartmentID", "DepartmentName"}
                            If table.Columns.Contains(col) Then dgvAmenities.Columns(col).Visible = False
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading amenities: " & ex.Message)
        End Try
    End Sub
    Private Function GetNextAmenityID() As String
        Dim newID As String = "AM1"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT AmenitiesID FROM tblamenities ORDER BY AmenitiesID DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim lastID = cmd.ExecuteScalar()
                    If lastID IsNot Nothing Then
                        Dim numPart As Integer
                        If Integer.TryParse(lastID.ToString().Substring(2), numPart) Then
                            newID = "AM" & (numPart + 1).ToString()
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Amenity ID: " & ex.Message)
        End Try
        Return newID
    End Function
    Private Sub SaveNewAmenity()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    INSERT INTO tblamenities 
                        (AmenitiesID, Name, Location, `Condition`, EmployeeID, DepartmentID) 
                    VALUES 
                        (@AmenitiesID, @Name, @Location, @Condition, @EmployeeID, @DepartmentID)
                "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AmenitiesID", txtAmenitiesID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Name", txtNameAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", txtLocationAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Condition", cbConditionAmenities.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@EmployeeID", GetNullableInt(txtEmployeeID.Text.Trim()))
                    cmd.Parameters.AddWithValue("@DepartmentID", GetNullableInt(txtDepartmentID.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Amenity added successfully!")
            LoadAmenities()
        Catch ex As Exception
            MessageBox.Show("Error adding amenity: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateAmenity()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    UPDATE tblamenities
                    SET Name=@Name,
                        Location=@Location,
                        `Condition`=@Condition,
                        EmployeeID=@EmployeeID,
                        DepartmentID=@DepartmentID
                    WHERE AmenitiesID=@AmenitiesID
                "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AmenitiesID", txtAmenitiesID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Name", txtNameAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", txtLocationAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Condition", cbConditionAmenities.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@EmployeeID", GetNullableInt(txtEmployeeID.Text.Trim()))
                    cmd.Parameters.AddWithValue("@DepartmentID", GetNullableInt(txtDepartmentID.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Amenity updated successfully!")
            LoadAmenities()
        Catch ex As Exception
            MessageBox.Show("Error updating amenity: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteAmenity()
        If String.IsNullOrEmpty(txtAmenitiesID.Text) Then
            MessageBox.Show("Select an amenity to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this amenity?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "DELETE FROM tblamenities WHERE AmenitiesID=@AmenitiesID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@AmenitiesID", txtAmenitiesID.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Amenity deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadAmenities()
            Catch ex As Exception
                MessageBox.Show("Error deleting amenity: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub LockControls()
        txtAmenitiesID.ReadOnly = True
        txtNameAmenities.ReadOnly = True
        txtLocationAmenities.ReadOnly = True
        txtEmployeeID.ReadOnly = True
        txtDepartmentID.ReadOnly = True
        cbConditionAmenities.Enabled = False
    End Sub
    Private Sub UnlockControls()
        txtAmenitiesID.ReadOnly = True
        txtNameAmenities.ReadOnly = False
        txtLocationAmenities.ReadOnly = False
        txtEmployeeID.ReadOnly = True
        txtDepartmentID.ReadOnly = True
        cbConditionAmenities.Enabled = True
    End Sub
    Private Sub SetDefaultAmenityButtons()
        btnAddAmenity.Visible = True
        btnEditAmenity.Visible = False
        btnDeleteAmenity.Visible = False
        btnSaveAmenity.Visible = False
        btnCancelAmenity.Visible = False
    End Sub
    Private Sub SetRecordSelectedAmenityButtons()
        btnAddAmenity.Visible = True
        btnEditAmenity.Visible = True
        btnDeleteAmenity.Visible = True
        btnSaveAmenity.Visible = False
        btnCancelAmenity.Visible = False
    End Sub
    Private Sub SetEditAddAmenityButtons()
        btnAddAmenity.Visible = False
        btnEditAmenity.Visible = False
        btnDeleteAmenity.Visible = False
        btnSaveAmenity.Visible = True
        btnCancelAmenity.Visible = True
    End Sub
    Private Sub dgvAmenities_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAmenities.SelectionChanged
        If isAddingAmenity Then Return

        If dgvAmenities.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = dgvAmenities.CurrentRow
            txtAmenitiesID.Text = If(row.Cells("AmenitiesID").Value IsNot DBNull.Value, row.Cells("AmenitiesID").Value.ToString(), "")
            txtNameAmenities.Text = If(row.Cells("AmenityName").Value IsNot DBNull.Value, row.Cells("AmenityName").Value.ToString(), "")
            txtLocationAmenities.Text = If(row.Cells("Location").Value IsNot DBNull.Value, row.Cells("Location").Value.ToString(), "")
            txtEmployeeID.Text = If(row.Cells("EmployeeID").Value IsNot DBNull.Value, row.Cells("EmployeeID").Value.ToString(), "")
            txtDepartmentID.Text = If(row.Cells("DepartmentID").Value IsNot DBNull.Value, row.Cells("DepartmentID").Value.ToString(), "")
            If row.Cells("Condition").Value IsNot DBNull.Value Then
                cbConditionAmenities.SelectedItem = row.Cells("Condition").Value.ToString()
            Else
                cbConditionAmenities.SelectedIndex = -1
            End If

            LockControls()
            SetRecordSelectedAmenityButtons()
        Else
            SetDefaultAmenityButtons()
        End If
    End Sub
    Private Sub btnAddAmenity_Click(sender As Object, e As EventArgs) Handles btnAddAmenity.Click
        isAddingAmenity = True
        txtAmenitiesID.Text = GetNextAmenityID()
        txtNameAmenities.Clear()
        txtLocationAmenities.Clear()
        txtEmployeeID.Clear()
        txtDepartmentID.Clear()
        cbConditionAmenities.SelectedIndex = -1
        UnlockControls()
        SetEditAddAmenityButtons()
    End Sub
    Private Sub btnEditAmenity_Click(sender As Object, e As EventArgs) Handles btnEditAmenity.Click
        If String.IsNullOrEmpty(txtAmenitiesID.Text) Then
            MessageBox.Show("Please select an amenity to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        isAddingAmenity = False
        UnlockControls()
        SetEditAddAmenityButtons()
    End Sub
    Private Sub btnSaveAmenity_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtNameAmenities.Text) Then
            MessageBox.Show("Amenity Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If isAddingAmenity Then
            SaveNewAmenity()
        Else
            UpdateAmenity()
        End If

        isAddingAmenity = False
        LockControls()
        SetDefaultAmenityButtons()
    End Sub
    Private Sub btnCancelAmenity_Click(sender As Object, e As EventArgs) Handles btnCancelAmenity.Click
        isAddingAmenity = False
        LoadAmenities()
        LockControls()
        SetDefaultAmenityButtons()
    End Sub
    Private Sub btnDeleteAmenity_Click(sender As Object, e As EventArgs) Handles btnDeleteAmenity.Click
        DeleteAmenity()
        LockControls()
        SetDefaultAmenityButtons()
    End Sub
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
    Private Sub lblEmployeeTrainings_Click(sender As Object, e As EventArgs) Handles lblEmployeeTrainings.Click
        Employee_Trainings.Show()
        Me.Hide()
    End Sub
    Private Sub lblDepartment_Click(sender As Object, e As EventArgs) Handles lblDepartment.Click
        Department.Show()
        Me.Hide()
    End Sub
    Private Sub lblAmenities_Click(sender As Object, e As EventArgs) Handles lblAmenities.Click
        lblAmenities.Enabled = False
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
