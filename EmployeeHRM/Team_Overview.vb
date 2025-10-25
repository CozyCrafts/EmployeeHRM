Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Team_Overview
    Private Sub Team_Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None
        Try
            Call OpenCon()
            dbcmd.Connection = dbcon
            dbadapter = New MySqlDataAdapter("SELECT * FROM tblaccount", dbcon)
            dbtable = New DataTable
            dbadapter.Fill(dbtable)

            dgvAccount.DataSource = dbtable

            dbcon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call DisableFields()
        LoadEmployee()

        txtPass.UseSystemPasswordChar = True
        lblID.Text = GenerateEmployeeID()
        dtpBirthdate.Format = DateTimePickerFormat.Custom
        dtpBirthdate.CustomFormat = "MMMM/dd/yyyy"
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Manager_Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        MyProfile.Show()
        Hide()
    End Sub

    Private Sub lblAttendance_Click(sender As Object, e As EventArgs) Handles lblAttendance.Click
        Attendance.Show()
        Hide()
    End Sub

    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        Leave_Management.Show()
        Hide()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        Salary.Show()
        Me.Hide()
    End Sub

    Private Sub lblGoalsAndGrowth_Click(sender As Object, e As EventArgs) Handles lblGoalsAndGrowth.Click
        Goals_and_Growth.Show()
        Me.Hide()
    End Sub

    Private Sub lblTeamOverview_Click(sender As Object, e As EventArgs) Handles lblTeamOverview.Click
        lblTeamOverview.Enabled = False
    End Sub

    Private Sub lblAttandance_Tracker_Click(sender As Object, e As EventArgs) Handles lblAttandanceTracker.Click
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

    Private Sub lblPerformanceReview_Click(sender As Object, e As EventArgs) Handles lblPerformanceReview.Click
        Performance_Review.Show()
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

    Private Sub SaveEmployee()
        Dim dbcon As MySqlConnection = HRMModule.GetConnection()
        Dim newEmployeeID As String = GenerateEmployeeID()

        Dim query As String = "INSERT INTO tblaccount (EmployeeID, Fname, Mname, Lname, Suffix, Age, Sex, CivilStatus, BirthDate, UserType, Username, Password) 
                           VALUES (@EmployeeID, @Fname, @Mname, @Lname, @Suffix, @Age, @Sex, @CivilStatus, @BirthDate, @UserType, @Username, @Password);"

        Try
            dbcon.Open()

            Using dbcmd As New MySqlCommand(query, dbcon)
                dbcmd.Parameters.AddWithValue("@EmployeeID", newEmployeeID)

                dbcmd.Parameters.AddWithValue("@Fname", txtFname.Text)
                dbcmd.Parameters.AddWithValue("@Mname", txtMname.Text)
                dbcmd.Parameters.AddWithValue("@Lname", txtLname.Text)

                If String.IsNullOrWhiteSpace(txtSuffix.Text) Then
                    dbcmd.Parameters.AddWithValue("@Suffix", DBNull.Value)
                Else
                    dbcmd.Parameters.AddWithValue("@Suffix", txtSuffix.Text)
                End If

                dbcmd.Parameters.AddWithValue("@Age", txtage.Text)
                dbcmd.Parameters.AddWithValue("@Sex", cmbSex.Text)
                dbcmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.Text)
                dbcmd.Parameters.AddWithValue("@BirthDate", dtpBirthdate.Value.ToString("yyyy-MM-dd"))
                dbcmd.Parameters.AddWithValue("@UserType", cmbUser.Text)
                dbcmd.Parameters.AddWithValue("@Username", txtUname.Text)
                dbcmd.Parameters.AddWithValue("@Password", HashPassword(txtPass.Text))

                dbcmd.ExecuteNonQuery()
            End Using

            LoadEmployee()

            For Each row As DataGridViewRow In dgvAccount.Rows
                If row.Cells("Suffix").Value Is DBNull.Value Then
                    row.Cells("Suffix").Value = " "
                End If
            Next

            MessageBox.Show("User added successfully. New EmployeeID: " & newEmployeeID)
            DisableFields()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Private Function GenerateEmployeeID() As String
        Dim prefix As String = "20250"

        Dim newID As String = prefix & "1"

        Try
            OpenCon()
            dbcon.Open()

            Dim query As String = "SELECT MAX(EmployeeID) FROM tblaccount WHERE EmployeeID LIKE @prefix"
            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@prefix", prefix & "%")

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim lastID As String = result.ToString()
                    Dim lastNumber As Integer = Convert.ToInt32(lastID)
                    newID = (lastNumber + 1).ToString()
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error generating EmployeeID: " & ex.Message)
        Finally
            dbcon.Close()
        End Try

        Return newID
    End Function


    Private Sub UpdateEmployee()
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to update.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvAccount.SelectedRows(0)
        Dim employeeID As Integer = Convert.ToInt32(selectedRow.Cells("EmployeeID").Value)

        Dim dbcon As MySqlConnection = HRMModule.GetConnection()
        Dim query As String = "UPDATE tblaccount 
                           SET Fname = @Fname, 
                               Mname = @Mname, 
                               Lname = @Lname, 
                               Suffix = @Suffix, 
                               Age = @Age, 
                               Sex = @Sex, 
                               CivilStatus = @CivilStatus, 
                               BirthDate = @BirthDate, 
                               UserType = @UserType,
                               Username = @Username, 
                               Password = @Password
                           WHERE EmployeeID = @EmployeeID;"

        Try
            dbcon.Open()

            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@Fname", txtFname.Text)
                cmd.Parameters.AddWithValue("@Mname", txtMname.Text)
                cmd.Parameters.AddWithValue("@Lname", txtLname.Text)

                If String.IsNullOrWhiteSpace(txtSuffix.Text) Then
                    cmd.Parameters.AddWithValue("@Suffix", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@Suffix", txtSuffix.Text)
                End If

                cmd.Parameters.AddWithValue("@Age", txtage.Text)
                cmd.Parameters.AddWithValue("@Sex", cmbSex.Text)
                cmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.Text)
                dbcmd.Parameters.AddWithValue("@BirthDate", dtpBirthdate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@UserType", cmbUser.Text)
                cmd.Parameters.AddWithValue("@Username", txtUname.Text)
                cmd.Parameters.AddWithValue("@Password", HashPassword(txtPass.Text))
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    LoadEmployee()
                    For Each row As DataGridViewRow In dgvAccount.Rows
                        If row.Cells("Suffix").Value Is DBNull.Value Then
                            row.Cells("Suffix").Value = " "
                        End If
                    Next
                    MessageBox.Show("User updated successfully.")
                    DisableFields()
                Else
                    MessageBox.Show("No record updated. Please check EmployeeID.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Private Sub DeleteEmployee()
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedCell As DataGridViewCell = dgvAccount.SelectedCells(0)
        Dim selectedRow As DataGridViewRow = dgvAccount.Rows(selectedCell.RowIndex)

        Dim employeeID As Integer = Convert.ToInt32(selectedRow.Cells("EmployeeID").Value)
        Dim employeeName As String = selectedRow.Cells("Fname").Value.ToString() & " " & selectedRow.Cells("Lname").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete employee {employeeName}?",
                                                 "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Try
            OpenCon()
            dbcon.Open()

            Dim query As String = "DELETE FROM tblaccount WHERE EmployeeID = @EmployeeID"
            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    LoadEmployee()
                    MessageBox.Show("Employee deleted successfully.", "Deleted",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No record was deleted. Please check EmployeeID.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error deleting employee: " & ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Private Sub LoadEmployee()
        Try
            OpenCon()
            dbcon.Open()

            Dim query As String = "SELECT * FROM tblaccount"
            dbadapter = New MySqlDataAdapter(query, dbcon)
            dbtable = New DataTable()
            dbadapter.Fill(dbtable)

            dgvAccount.DataSource = dbtable

        Catch ex As MySqlException
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub


    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function


    Sub EnableFields()
        txtFname.Enabled = True
        txtMname.Enabled = True
        txtLname.Enabled = True
        txtSuffix.Enabled = True
        txtage.Enabled = True
        dtpBirthdate.Enabled = True
        cmbSex.Enabled = True
        cmbUser.Enabled = True
        cmbCivilStatus.Enabled = True
        txtUname.Enabled = True
        txtPass.Enabled = True

        btnSave.Visible = True
        btnCancel.Visible = True
        btnDelete.Visible = True
        btnAddEmployee.Visible = False
        btnEditEmployee.Visible = False
    End Sub

    Sub DisableFields()
        txtFname.Enabled = False
        txtMname.Enabled = False
        txtLname.Enabled = False
        txtSuffix.Enabled = False
        txtage.Enabled = False
        dtpBirthdate.Enabled = False
        cmbSex.Enabled = False
        cmbUser.Enabled = False
        cmbCivilStatus.Enabled = False
        txtUname.Enabled = False
        txtPass.Enabled = False

        btnSave.Visible = False
        btnCancel.Visible = False
        btnDelete.Visible = False
        btnUpdate.Visible = False
        btnAddEmployee.Visible = True
        btnEditEmployee.Visible = True
    End Sub

    Sub Clear()
        lblID.Text = ""
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtSuffix.Clear()
        txtage.Clear()
        cmbCivilStatus.SelectedIndex = -1
        cmbSex.SelectedIndex = -1
        cmbUser.SelectedIndex = -1
        txtUname.Clear()
        txtPass.Clear()
        dtpBirthdate.Value = Date.Today
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        EnableFields()
        Clear()
        btnSave.Visible = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
        btnCancel.Visible = True
        btnAddEmployee.Visible = False
        btnEditEmployee.Visible = False
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        EnableFields()
        Clear()
        btnSave.Visible = False
        btnUpdate.Visible = True
        btnDelete.Visible = True
        btnCancel.Visible = True
        btnAddEmployee.Visible = False
        btnEditEmployee.Visible = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteEmployee()
        Clear()
        LoadEmployee()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtFname.Text) OrElse
       String.IsNullOrWhiteSpace(txtLname.Text) OrElse
       String.IsNullOrWhiteSpace(txtage.Text) OrElse
       String.IsNullOrWhiteSpace(cmbSex.Text) OrElse
       String.IsNullOrWhiteSpace(cmbCivilStatus.Text) OrElse
       String.IsNullOrWhiteSpace(cmbUser.Text) OrElse
       String.IsNullOrWhiteSpace(txtUname.Text) OrElse
       String.IsNullOrWhiteSpace(txtPass.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim age As Integer
        If Not Integer.TryParse(txtage.Text, age) OrElse age < 1 OrElse age > 100 Then
            MessageBox.Show("Please enter a valid age (1-100).", "Invalid Age",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SaveEmployee()
        Clear()
        LoadEmployee()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableFields()
        Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to update.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtFname.Text) OrElse
       String.IsNullOrWhiteSpace(txtLname.Text) OrElse
       String.IsNullOrWhiteSpace(txtage.Text) OrElse
       String.IsNullOrWhiteSpace(cmbSex.Text) OrElse
       String.IsNullOrWhiteSpace(cmbCivilStatus.Text) OrElse
       String.IsNullOrWhiteSpace(cmbUser.Text) OrElse
       String.IsNullOrWhiteSpace(txtUname.Text) Then

            MessageBox.Show("Please fill in all required fields before updating.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim age As Integer
        If Not Integer.TryParse(txtage.Text, age) OrElse age < 1 OrElse age > 100 Then
            MessageBox.Show("Please enter a valid age (1-100).", "Invalid Age",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        UpdateEmployee()
        Clear()
        LoadEmployee()
    End Sub

    Private Sub dgvAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvAccount.Rows(e.RowIndex)

        lblID.Text = row.Cells("EmployeeID").Value.ToString()
        txtFname.Text = row.Cells("Fname").Value.ToString()
        txtMname.Text = row.Cells("Mname").Value.ToString()
        txtLname.Text = row.Cells("Lname").Value.ToString()

        If IsDBNull(row.Cells("Suffix").Value) Then
            txtSuffix.Clear()
        Else
            txtSuffix.Text = row.Cells("Suffix").Value.ToString()
        End If

        txtage.Text = row.Cells("Age").Value.ToString()
        cmbSex.Text = row.Cells("Sex").Value.ToString()
        cmbCivilStatus.Text = row.Cells("CivilStatus").Value.ToString()

        If Not IsDBNull(row.Cells("BirthDate").Value) Then
            dtpBirthdate.Value = Convert.ToDateTime(row.Cells("BirthDate").Value)
        End If

        cmbUser.Text = row.Cells("UserType").Value.ToString()
        txtUname.Text = row.Cells("Username").Value.ToString()
        txtPass.Text = row.Cells("Password").Value.ToString()
    End Sub

    Private Sub pcbTerminate_Click(sender As Object, e As EventArgs) Handles pcbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the system?",
                                                "Confirm Exit",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class