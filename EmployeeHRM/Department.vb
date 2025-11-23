Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class Department
    Private isAdding As Boolean = False
    Private originalValues As New Dictionary(Of String, String)

    Private Sub CapitalizeWords(sender As Object, e As EventArgs)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim selStart As Integer = tb.SelectionStart
        tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text.ToLower())
        tb.SelectionStart = selStart
    End Sub

    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadDepartments()
        Catch ex As Exception
            MessageBox.Show("Error loading departments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LockTextBoxes()
        SetDefaultButtonState()

        AddHandler txtDepartmentName.TextChanged, AddressOf CapitalizeWords
        AddHandler txtDepartmentDescription.TextChanged, AddressOf CapitalizeWords
    End Sub
    Private Sub LoadDepartments()
        Dim query As String = "
            SELECT 
                e.EmployeeID,
                e.`First Name` AS FirstName,
                e.MiddleName,
                e.LastName,
                d.DepartmentID,
                d.Name AS DepartmentName,
                d.Description
            FROM tbldepartment d
            LEFT JOIN tblemployee e ON e.EmployeeID = d.EmployeeID
            ORDER BY d.DepartmentID;
        "

        Dim table As DataTable = HRMModule.ExecuteQuery(query)

        If Not table.Columns.Contains("FullName") Then
            table.Columns.Add("FullName", GetType(String))
        End If

        For Each row As DataRow In table.Rows
            Dim firstName As String = If(row("FirstName") IsNot DBNull.Value, row("FirstName").ToString(), "")
            Dim middleName As String = If(row("MiddleName") IsNot DBNull.Value, row("MiddleName").ToString(), "")
            Dim lastName As String = If(row("LastName") IsNot DBNull.Value, row("LastName").ToString(), "")
            row("FullName") = (firstName & " " & middleName & " " & lastName).Trim()
        Next

        dgvDepartmentRecords.DataSource = table

        ' Hide unnecessary columns
        Dim columnsToHide = {"EmployeeID", "FullName", "FirstName", "MiddleName", "LastName"}
        For Each col In columnsToHide
            If table.Columns.Contains(col) Then dgvDepartmentRecords.Columns(col).Visible = False
        Next
    End Sub
    Private Sub dgvDepartmentRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDepartmentRecords.SelectionChanged
        If dgvDepartmentRecords.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = dgvDepartmentRecords.CurrentRow
            txtDepartmentID.Text = If(row.Cells("DepartmentID").Value IsNot DBNull.Value, row.Cells("DepartmentID").Value.ToString(), "")
            txtDepartmentName.Text = If(row.Cells("DepartmentName").Value IsNot DBNull.Value, row.Cells("DepartmentName").Value.ToString(), "")
            txtDepartmentDescription.Text = If(row.Cells("Description").Value IsNot DBNull.Value, row.Cells("Description").Value.ToString(), "")

            originalValues("DepartmentName") = txtDepartmentName.Text
            originalValues("Description") = txtDepartmentDescription.Text
        End If

        LockTextBoxes()
        SetRecordSelectedButtonState()
    End Sub
    Private Sub LockTextBoxes()
        txtDepartmentID.ReadOnly = True
        txtDepartmentName.ReadOnly = True
        txtDepartmentDescription.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        txtDepartmentID.ReadOnly = True
        txtDepartmentName.ReadOnly = False
        txtDepartmentDescription.ReadOnly = False
    End Sub
    Private Sub SetDefaultButtonState()
        btnAddDepartment.Visible = True
        btnEditDepartment.Visible = False
        btnDeleteDepartment.Visible = False
        btnSaveDepartment.Visible = False
        btnCancelDepartment.Visible = False
    End Sub
    Private Sub SetEditAddButtonState()
        btnAddDepartment.Visible = False
        btnEditDepartment.Visible = False
        btnDeleteDepartment.Visible = False
        btnSaveDepartment.Visible = True
        btnCancelDepartment.Visible = True
    End Sub
    Private Sub SetRecordSelectedButtonState()
        btnAddDepartment.Visible = True
        btnEditDepartment.Visible = True
        btnDeleteDepartment.Visible = True
        btnSaveDepartment.Visible = False
        btnCancelDepartment.Visible = False
    End Sub
    Private Sub btnDeleteDepartment_Click(sender As Object, e As EventArgs) Handles btnDeleteDepartment.Click
        If String.IsNullOrEmpty(txtDepartmentID.Text) Then
            MessageBox.Show("Please select a department to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM tbldepartment WHERE DepartmentID=@DepartmentID"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@DepartmentID", txtDepartmentID.Text.Trim())
            }

            If HRMModule.ExecuteNonQuery(query, parameters) >= 0 Then
                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDepartments()
                txtDepartmentID.Clear()
                txtDepartmentName.Clear()
                txtDepartmentDescription.Clear()
                LockTextBoxes()
                SetDefaultButtonState()
            Else
                MessageBox.Show("Error deleting department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
        isAdding = True
        txtDepartmentID.Text = GetNextDepartmentID()
        txtDepartmentName.Clear()
        txtDepartmentDescription.Clear()
        dgvDepartmentRecords.Enabled = False
        UnlockTextBoxes()
        SetEditAddButtonState()
    End Sub
    Private Sub btnEditDepartment_Click(sender As Object, e As EventArgs) Handles btnEditDepartment.Click
        If String.IsNullOrEmpty(txtDepartmentID.Text) Then
            MessageBox.Show("Please select a department to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        isAdding = False
        UnlockTextBoxes()
        SetEditAddButtonState()
    End Sub
    Private Sub btnSaveDepartment_Click(sender As Object, e As EventArgs) Handles btnSaveDepartment.Click
        If String.IsNullOrWhiteSpace(txtDepartmentName.Text) Then
            MessageBox.Show("Please enter a Department Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepartmentName.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtDepartmentDescription.Text) Then
            MessageBox.Show("Please enter a Department Description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepartmentDescription.Focus()
            Return
        End If

        If Not isAdding Then
            If txtDepartmentName.Text = originalValues("DepartmentName") AndAlso txtDepartmentDescription.Text = originalValues("Description") Then
                MessageBox.Show("No changes were made. Nothing to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If

        If isAdding Then SaveNewDepartment() Else UpdateDepartment()
        LockTextBoxes()
        SetDefaultButtonState()
    End Sub

    Private Sub btnCancelDepartment_Click(sender As Object, e As EventArgs) Handles btnCancelDepartment.Click
        LoadDepartments()
        LockTextBoxes()
        SetDefaultButtonState()
    End Sub
    Private Sub SaveNewDepartment()
        Dim query As String = "INSERT INTO tbldepartment (DepartmentID, Name, Description) VALUES (@DepartmentID, @Name, @Description)"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DepartmentID", txtDepartmentID.Text.Trim()),
            New MySqlParameter("@Name", txtDepartmentName.Text.Trim()),
            New MySqlParameter("@Description", txtDepartmentDescription.Text.Trim())
        }

        If HRMModule.ExecuteNonQuery(query, parameters) >= 0 Then
            MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartments()
        Else
            MessageBox.Show("Error adding department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub UpdateDepartment()
        Dim query As String = "UPDATE tbldepartment SET Name=@Name, Description=@Description WHERE DepartmentID=@DepartmentID"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DepartmentID", txtDepartmentID.Text.Trim()),
            New MySqlParameter("@Name", txtDepartmentName.Text.Trim()),
            New MySqlParameter("@Description", txtDepartmentDescription.Text.Trim())
        }

        If HRMModule.ExecuteNonQuery(query, parameters) >= 0 Then
            MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartments()
        Else
            MessageBox.Show("Error updating department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function GetNextDepartmentID() As String
        Dim newID As String = "D1"
        Dim query As String = "SELECT DepartmentID FROM tbldepartment ORDER BY DepartmentID DESC LIMIT 1"
        Dim lastID = HRMModule.ExecuteScalar(query)

        If lastID IsNot Nothing AndAlso Integer.TryParse(lastID.ToString().Substring(1), Nothing) Then
            Dim numPart As Integer
            Integer.TryParse(lastID.ToString().Substring(1), numPart)
            newID = "D" & (numPart + 1).ToString()
        End If

        Return newID
    End Function
    Private Sub txtSearchDepartment_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDepartment.TextChanged
        Dim searchValue As String = txtSearchDepartment.Text.Trim()
        If String.IsNullOrEmpty(searchValue) Then
            LoadDepartments()
            Return
        End If
        Dim searchParts() As String = searchValue.Split(" "c, StringSplitOptions.RemoveEmptyEntries)

        For Each row As DataGridViewRow In dgvDepartmentRecords.Rows
            If Not row.IsNewRow Then
                Dim departmentID As String = row.Cells("DepartmentID").Value.ToString()
                Dim departmentName As String = row.Cells("DepartmentName").Value.ToString()
                Dim matchFound As Boolean = False
                If departmentID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               departmentName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    matchFound = True
                Else
                    For Each part In searchParts
                        If departmentID.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                       departmentName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            matchFound = True
                            Exit For
                        End If
                    Next
                End If
                row.Visible = matchFound
            End If
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
        lblDepartment.Enabled = False
    End Sub
    Private Sub lblAmenities_Click(sender As Object, e As EventArgs) Handles lblAmenities.Click
        Amenities.Show()
        Me.Hide()
    End Sub
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            HRMModule.SignOut(Me)
            MessageBox.Show("You have been signed out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class

