Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data

Public Class Amenities

    Private isAddingAmenity As Boolean = False
    Private originalAmenityValues As New Dictionary(Of String, String)


    Private Sub CapitalizeWords(sender As Object, e As EventArgs)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim selStart As Integer = tb.SelectionStart
        tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text.ToLower())
        tb.SelectionStart = selStart
    End Sub

    Private Sub Amenities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HRMModule.RequireManagerAccess(Me)
        LoadAmenities()
        cbConditionAmenities.Items.AddRange({"Good", "Needs Repair", "Excellent", "Fair"})
        cbConditionAmenities.SelectedIndex = -1
        LockControls()
        SetDefaultAmenityButtons()
        AddHandler txtNameAmenities.TextChanged, AddressOf CapitalizeWords
        AddHandler txtLocationAmenities.TextChanged, AddressOf CapitalizeWords
    End Sub

    Private Sub LoadAmenities()
        Try
            Dim query As String = "
                SELECT 
                    AmenitiesID,
                    Name AS AmenityName,
                    Location,
                    `Condition`
                FROM tblamenities
                ORDER BY AmenitiesID;
            "
            Dim dt As DataTable = HRMModule.ExecuteQuery(query)
            dgvAmenities.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading amenities: " & ex.Message)
        End Try
    End Sub

    Private Function GetNextAmenityID() As String
        Dim newID As String = "AM1"
        Try
            Dim query As String = "SELECT AmenitiesID FROM tblamenities ORDER BY AmenitiesID DESC LIMIT 1"
            Dim dt As DataTable = HRMModule.ExecuteQuery(query)
            If dt.Rows.Count > 0 Then
                Dim lastID As String = dt.Rows(0)("AmenitiesID").ToString()
                Dim numPart As Integer
                If Integer.TryParse(lastID.Substring(2), numPart) Then
                    newID = "AM" & (numPart + 1).ToString()
                End If
            End If
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
            Dim query As String = "
                INSERT INTO tblamenities 
                    (AmenitiesID, Name, Location, `Condition`) 
                VALUES 
                    (@AmenitiesID, @Name, @Location, @Condition)
            "
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@AmenitiesID", txtAmenitiesID.Text.Trim()),
                New MySqlParameter("@Name", txtNameAmenities.Text.Trim()),
                New MySqlParameter("@Location", txtLocationAmenities.Text.Trim()),
                New MySqlParameter("@Condition", cbConditionAmenities.SelectedItem.ToString())
            }
            HRMModule.ExecuteNonQuery(query, parameters)
            MessageBox.Show("Amenity added successfully!")
            LoadAmenities()
        Catch ex As Exception
            MessageBox.Show("Error adding amenity: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateAmenity()
        Try
            Dim query As String = "
                UPDATE tblamenities
                SET 
                    Name=@Name,
                    Location=@Location,
                    `Condition`=@Condition
                WHERE AmenitiesID=@AmenitiesID
            "
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@AmenitiesID", txtAmenitiesID.Text.Trim()),
                New MySqlParameter("@Name", txtNameAmenities.Text.Trim()),
                New MySqlParameter("@Location", txtLocationAmenities.Text.Trim()),
                New MySqlParameter("@Condition", cbConditionAmenities.SelectedItem.ToString())
            }
            HRMModule.ExecuteNonQuery(query, parameters)
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

        If MessageBox.Show("Are you sure you want to delete this amenity?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM tblamenities WHERE AmenitiesID=@AmenitiesID"
                Dim parameters As New List(Of MySqlParameter) From {
                    New MySqlParameter("@AmenitiesID", txtAmenitiesID.Text.Trim())
                }
                HRMModule.ExecuteNonQuery(query, parameters)
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
        txtAmenitiesID.Text = If(row.Cells("AmenitiesID").Value?.ToString(), "")
        txtNameAmenities.Text = If(row.Cells("AmenityName").Value?.ToString(), "")
        txtLocationAmenities.Text = If(row.Cells("Location").Value?.ToString(), "")
        cbConditionAmenities.SelectedItem = If(row.Cells("Condition").Value?.ToString(), Nothing)

        originalAmenityValues("AmenityName") = txtNameAmenities.Text
        originalAmenityValues("Location") = txtLocationAmenities.Text
        originalAmenityValues("Condition") = If(cbConditionAmenities.SelectedItem?.ToString(), "")

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

    Private Sub txtSearchAmenities_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAmenities.TextChanged
        Dim searchValue As String = txtSearchAmenities.Text.Trim()
        Dim dt As DataTable = TryCast(dgvAmenities.DataSource, DataTable)
        If dt Is Nothing Then Return
        If String.IsNullOrEmpty(searchValue) Then
            dt.DefaultView.RowFilter = ""
            Return
        End If
        searchValue = searchValue.Replace("'", "''")
        dt.DefaultView.RowFilter = String.Format("AmenitiesID LIKE '%{0}%' OR AmenityName LIKE '%{0}%'", searchValue)
    End Sub

    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
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
      lblAmenities.Enabled = False
    End Sub

    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        HRMModule.SignOut(Me)
    End Sub



End Class
