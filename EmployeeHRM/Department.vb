Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class Department
    Private conn As MySqlConnection
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
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
            conn = New MySqlConnection(connectionString)
            conn.Open()
            LoadDepartments()
        Catch ex As MySqlException
            MessageBox.Show("Connection failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
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

        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
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
                        If table.Columns.Contains("EmployeeID") Then dgvDepartmentRecords.Columns("EmployeeID").Visible = False
                        If table.Columns.Contains("FullName") Then dgvDepartmentRecords.Columns("FullName").Visible = False
                        If table.Columns.Contains("FirstName") Then dgvDepartmentRecords.Columns("FirstName").Visible = False
                        If table.Columns.Contains("MiddleName") Then dgvDepartmentRecords.Columns("MiddleName").Visible = False
                        If table.Columns.Contains("LastName") Then dgvDepartmentRecords.Columns("LastName").Visible = False
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading departments: " & ex.Message)
        End Try
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
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "DELETE FROM tbldepartment WHERE DepartmentID=@DepartmentID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDepartments()
                txtDepartmentID.Clear()
                txtDepartmentName.Clear()
                txtDepartmentDescription.Clear()
                LockTextBoxes()
                SetDefaultButtonState()
            Catch ex As Exception
                MessageBox.Show("Error deleting department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
        If isAdding Then
            SaveNewDepartment()
        Else
            UpdateDepartment()
        End If

        LockTextBoxes()
        SetDefaultButtonState()
    End Sub
    Private Sub btnCancelDepartment_Click(sender As Object, e As EventArgs) Handles btnCancelDepartment.Click
        LoadDepartments()
        LockTextBoxes()
        SetDefaultButtonState()
    End Sub
    Private Sub SaveNewDepartment()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO tbldepartment (DepartmentID, Name, Description) VALUES (@DepartmentID, @Name, @Description)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Name", txtDepartmentName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", txtDepartmentDescription.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartments()
        Catch ex As Exception
            MessageBox.Show("Error adding department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateDepartment()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE tbldepartment SET Name=@Name, Description=@Description WHERE DepartmentID=@DepartmentID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Name", txtDepartmentName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", txtDepartmentDescription.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartments()
        Catch ex As Exception
            MessageBox.Show("Error updating department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetNextDepartmentID() As String
        Dim newID As String = "D1"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT DepartmentID FROM tbldepartment ORDER BY DepartmentID DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim lastID = cmd.ExecuteScalar()
                    If lastID IsNot Nothing Then
                        Dim numPart As Integer
                        If Integer.TryParse(lastID.ToString().Substring(1), numPart) Then
                            newID = "D" & (numPart + 1).ToString()
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating DepartmentID: " & ex.Message)
        End Try
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

