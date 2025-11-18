Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class Amenities

    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private isAddingAmenity As Boolean = False
    Private originalAmenityValues As New Dictionary(Of String, String)

    Private Sub CapitalizeWords(sender As Object, e As EventArgs)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim selStart As Integer = tb.SelectionStart
        tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text.ToLower())
        tb.SelectionStart = selStart
    End Sub
    Private Sub Amenities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAmenities()
        cbConditionAmenities.Items.AddRange({"Good", "Needs Repair", "Excellent", "Fair"})
        cbConditionAmenities.SelectedIndex = -1
        LockControls()
        SetDefaultAmenityButtons()
        AddHandler txtNameAmenities.TextChanged, AddressOf CapitalizeWords
        AddHandler txtLocationAmenities.TextChanged, AddressOf CapitalizeWords
    End Sub
    Private Sub LoadAmenities()
        Dim query As String = "
            SELECT 
                AmenitiesID,
                Name AS AmenityName,
                Location,
                `Condition`
            FROM tblamenities
            ORDER BY AmenitiesID;
        "
        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvAmenities.DataSource = table
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
    Private Function ValidateAmenityFields() As Boolean
        If String.IsNullOrWhiteSpace(txtNameAmenities.Text) Then
            MessageBox.Show("Amenity Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNameAmenities.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLocationAmenities.Text) Then
            MessageBox.Show("Amenity Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLocationAmenities.Focus()
            Return False
        End If

        If cbConditionAmenities.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Condition.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbConditionAmenities.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub SaveNewAmenity()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                    INSERT INTO tblamenities 
                        (AmenitiesID, Name, Location, `Condition`) 
                    VALUES 
                        (@AmenitiesID, @Name, @Location, @Condition)
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AmenitiesID", txtAmenitiesID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Name", txtNameAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", txtLocationAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Condition", cbConditionAmenities.SelectedItem.ToString())
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
                    SET 
                        Name=@Name,
                        Location=@Location,
                        `Condition`=@Condition
                    WHERE AmenitiesID=@AmenitiesID
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AmenitiesID", txtAmenitiesID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Name", txtNameAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", txtLocationAmenities.Text.Trim())
                    cmd.Parameters.AddWithValue("@Condition", cbConditionAmenities.SelectedItem.ToString())
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

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this amenity?", "Confirm Delete", MessageBoxButtons.YesNo)

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

                MessageBox.Show("Amenity deleted successfully!")
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
        cbConditionAmenities.Enabled = False
    End Sub
    Private Sub UnlockControls()
        txtAmenitiesID.ReadOnly = True
        txtNameAmenities.ReadOnly = False
        txtLocationAmenities.ReadOnly = False
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
        If dgvAmenities.CurrentRow Is Nothing Then Return

        Dim row As DataGridViewRow = dgvAmenities.CurrentRow
        If row.Cells("AmenitiesID").Value IsNot Nothing Then txtAmenitiesID.Text = row.Cells("AmenitiesID").Value.ToString()
        If row.Cells("AmenityName").Value IsNot Nothing Then txtNameAmenities.Text = row.Cells("AmenityName").Value.ToString()
        If row.Cells("Location").Value IsNot Nothing Then txtLocationAmenities.Text = row.Cells("Location").Value.ToString()
        If row.Cells("Condition").Value IsNot Nothing Then cbConditionAmenities.SelectedItem = row.Cells("Condition").Value.ToString()

        originalAmenityValues("AmenityName") = txtNameAmenities.Text
        originalAmenityValues("Location") = txtLocationAmenities.Text
        originalAmenityValues("Condition") = If(cbConditionAmenities.SelectedItem IsNot Nothing, cbConditionAmenities.SelectedItem.ToString(), "")

        LockControls()
        SetRecordSelectedAmenityButtons()
    End Sub
    Private Sub btnAddAmenity_Click(sender As Object, e As EventArgs) Handles btnAddAmenity.Click
        isAddingAmenity = True
        txtAmenitiesID.Text = GetNextAmenityID()
        txtNameAmenities.Clear()
        txtLocationAmenities.Clear()
        cbConditionAmenities.SelectedIndex = -1
        dgvAmenities.Enabled = False
        UnlockControls()
        SetEditAddAmenityButtons()
    End Sub
    Private Sub btnEditAmenity_Click(sender As Object, e As EventArgs) Handles btnEditAmenity.Click
        If txtAmenitiesID.Text = "" Then
            MessageBox.Show("Select an amenity to edit.")
            Return
        End If

        isAddingAmenity = False
        UnlockControls()
        SetEditAddAmenityButtons()
    End Sub
    Private Sub btnSaveAmenity_Click(sender As Object, e As EventArgs) Handles btnSaveAmenity.Click

        If Not ValidateAmenityFields() Then Exit Sub
        If Not isAddingAmenity Then
            Dim nameChanged As Boolean = Not originalAmenityValues.ContainsKey("AmenityName") OrElse txtNameAmenities.Text <> originalAmenityValues("AmenityName")
            Dim locationChanged As Boolean = Not originalAmenityValues.ContainsKey("Location") OrElse txtLocationAmenities.Text <> originalAmenityValues("Location")
            Dim conditionChanged As Boolean = Not originalAmenityValues.ContainsKey("Condition") OrElse cbConditionAmenities.SelectedItem.ToString() <> originalAmenityValues("Condition")

            If Not (nameChanged Or locationChanged Or conditionChanged) Then
                MessageBox.Show("No changes were made. Nothing to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
        If isAddingAmenity Then
            SaveNewAmenity()
        Else
            UpdateAmenity()
        End If
        If Not isAddingAmenity Then
            Dim nameOriginal As String = If(originalAmenityValues.ContainsKey("AmenityName"), originalAmenityValues("AmenityName"), "")
            Dim locationOriginal As String = If(originalAmenityValues.ContainsKey("Location"), originalAmenityValues("Location"), "")
            Dim conditionOriginal As String = If(originalAmenityValues.ContainsKey("Condition"), originalAmenityValues("Condition"), "")

            If txtNameAmenities.Text = nameOriginal AndAlso
       txtLocationAmenities.Text = locationOriginal AndAlso
       cbConditionAmenities.SelectedItem.ToString() = conditionOriginal Then

                MessageBox.Show("No changes were made. Nothing to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
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
    Private Sub txtSearchAmenities_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAmenities.TextChanged
        Dim searchValue As String = txtSearchAmenities.Text.Trim()
        Dim dt As DataTable = TryCast(dgvAmenities.DataSource, DataTable)
        If dt Is Nothing Then Return
        If String.IsNullOrEmpty(searchValue) Then
            dt.DefaultView.RowFilter = ""
            Return
        End If
        searchValue = searchValue.Replace("'", "''")
        dt.DefaultView.RowFilter = String.Format(
        "AmenitiesID LIKE '%{0}%' OR AmenityName LIKE '%{0}%'",
        searchValue
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
            Login_frm.ClearLoginFields()
            LoggedInEmployeeID = ""
            LoggedInUsername = ""
            LoggedInUserType = ""
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub
End Class
