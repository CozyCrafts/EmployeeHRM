Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Security.Cryptography


Public Class Team_Overview
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private currentMode As String = ""
    Private bsEmployees As BindingSource
    Private Sub Team_Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSex.Items.Clear()
        cbSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cbCivilStatus.Items.Clear()
        cbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Separated"})
        cbEmployeeStatus.Items.Clear()
        cbEmployeeStatus.Items.AddRange(New Object() {"Active", "Inactive", "Probationary", "Terminated", "Resigned"})
        cbContractType.Items.Clear()
        cbContractType.Items.AddRange(New Object() {"Regular", "Seasonal", "Contractual", "Part-Time"})
        cbUserType.Items.Clear()
        cbUserType.Items.AddRange(New Object() {"Manager", "Staff"})
        LoadOtherEmployeeInfo()
        DisableAllTextboxes()
        SetButtonVisibility("Default")
        txtAge.ReadOnly = True
        txtYearsOfSevice.ReadOnly = True
        txtAge.Text = CalculateAge(dtpBirthDate.Value).ToString()
        txtYearsOfSevice.Text = CalculateYearsOfService(dtpDateHired.Value).ToString("0.00")
        AddHandler dtpBirthDate.ValueChanged, AddressOf dtpBirthDate_ValueChanged
        AddHandler dtpDateHired.ValueChanged, AddressOf dtpDateHired_ValueChanged
    End Sub
    Private Sub LoadOtherEmployeeInfo()
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim query As String = "
                 SELECT
                 e.EmployeeID,
                 CONCAT(e.`First Name`, ' ', IFNULL(e.MiddleName, ''), ' ', e.LastName) AS FullName,
                 e.BirthDate, e.Age, e.Sex, e.`Civil Status` AS CivilStatus,
                 e.`Contact Number` AS ContactNumber, e.`Email Address` AS EmailAddress,
                 e.Address,
                 ec.EmergencyContactID, ec.Name AS EmergencyName, ec.Relationship,
                 ec.PhoneNumber AS EmergencyPhone, ec.Address AS EmergencyAddress,
                 a.UserID, a.UserType, a.Username,
                 j.JobID, j.EmploymentStatus, j.DateHired, j.ContractType, j.JobTitle, j.YearsOfService,
                 d.DepartmentID, d.Name AS DepartmentName
                 FROM tblemployee e
                 LEFT JOIN tblemergencycontact ec ON e.EmployeeID = ec.EmployeeID
                 LEFT JOIN tblaccount a ON e.EmployeeID = a.EmployeeID
                 LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                 LEFT JOIN tbldepartment d ON j.DepartmentID = d.DepartmentID;
"
                Dim adapter As New MySqlDataAdapter(query, dbcon)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvOtherInfo.DataSource = table
                bsEmployees = New BindingSource()
                bsEmployees.DataSource = table.DefaultView
                dgvOtherInfo.DataSource = bsEmployees
            End Using
            dgvOtherInfo.ScrollBars = ScrollBars.Both
            dgvOtherInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvOtherInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvOtherInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvOtherInfo.DefaultCellStyle.Font = New Font("Century Gothic", 9, FontStyle.Regular)
            dgvOtherInfo.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
            dgvOtherInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvOtherInfo.ReadOnly = True
            dgvOtherInfo.AllowUserToAddRows = False
            dgvOtherInfo.AllowUserToDeleteRows = False
            dgvOtherInfo.AutoResizeColumns()
            dgvOtherInfo.AutoResizeRows()
            If dgvOtherInfo.Columns.Contains("FullName") Then
                dgvOtherInfo.Columns("FullName").HeaderText = "Full Name"
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading other info: " & ex.Message)
        End Try
    End Sub
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Dim searchValue As String = txtSearchEmployee.Text.Trim()

        If String.IsNullOrEmpty(searchValue) Then
            ' Reload original data
            LoadOtherEmployeeInfo()
            Return
        End If

        Dim searchParts() As String = searchValue.Split(" "c, StringSplitOptions.RemoveEmptyEntries)

        For Each row As DataGridViewRow In dgvOtherInfo.Rows
            If Not row.IsNewRow Then

                Dim employeeID As String = row.Cells("EmployeeID").Value.ToString()
                Dim fullName As String = row.Cells("FullName").Value.ToString()

                Dim match As Boolean =
                employeeID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                fullName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0

                ' If not matched yet, check each search word
                If Not match Then
                    For Each part In searchParts
                        If fullName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            match = True
                            Exit For
                        End If
                    Next
                End If

                ' 🔥 This is what makes it filter instead of just highlight
                row.Visible = match
            End If
        Next
    End Sub

    Private Sub DisableAllTextboxes()
        txtAge.Enabled = False
        txtYearsOfSevice.Enabled = False
        txtEmployeeID.Enabled = False
        txtECContactID.Enabled = False
        txtUserID.Enabled = False
        txtJobID.Enabled = False
        txtFirstName.Enabled = False
        txtMiddleName.Enabled = False
        txtLastName.Enabled = False
        dtpBirthDate.Enabled = False
        cbSex.Enabled = False
        cbCivilStatus.Enabled = False
        txtPhone.Enabled = False
        txtEmail.Enabled = False
        txtAddress.Enabled = False
        txtECName.Enabled = False
        txtECRelationship.Enabled = False
        txtECPhone.Enabled = False
        txtECAddress.Enabled = False
        cbUserType.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtDepartmentID.Enabled = False
        txtDepartment.Enabled = False
        cbEmployeeStatus.Enabled = False
        dtpDateHired.Enabled = False
        cbContractType.Enabled = False
        txtJobTitle.Enabled = False
    End Sub
    Private Sub EnableAllTextboxes()
        txtEmployeeID.Enabled = False
        txtECContactID.Enabled = False
        txtUserID.Enabled = False
        txtAge.Enabled = False
        txtYearsOfSevice.Enabled = False
        txtFirstName.Enabled = True
        txtMiddleName.Enabled = True
        txtLastName.Enabled = True
        dtpBirthDate.Enabled = True
        cbSex.Enabled = True
        cbCivilStatus.Enabled = True
        txtPhone.Enabled = True
        txtEmail.Enabled = True
        txtAddress.Enabled = True
        txtECName.Enabled = True
        txtECRelationship.Enabled = True
        txtECPhone.Enabled = True
        txtECAddress.Enabled = True
        cbUserType.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtDepartmentID.Enabled = True
        txtDepartment.Enabled = True
        cbEmployeeStatus.Enabled = True
        dtpDateHired.Enabled = True
        cbContractType.Enabled = True
        txtJobTitle.Enabled = True
        txtJobID.Enabled = True
    End Sub
    Private Sub ClearAllTextboxes()
        txtEmployeeID.Text = ""
        txtECContactID.Text = ""
        txtUserID.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAge.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtECName.Text = ""
        txtECRelationship.Text = ""
        txtECPhone.Text = ""
        txtECAddress.Text = ""
        cbSex.Text = ""
        cbCivilStatus.Text = ""
        cbUserType.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtDepartmentID.Text = ""
        txtDepartment.Text = ""
        cbEmployeeStatus.Text = ""
        dtpBirthDate.Value = DateTime.Now
        dtpDateHired.Value = DateTime.Now
        cbContractType.Text = ""
        txtJobTitle.Text = ""
        txtJobID.Text = ""
        txtYearsOfSevice.Text = ""
    End Sub
    Private Sub SetButtonVisibility(mode As String)
        Select Case mode
            Case "Default"
                btnAddEmployee.Visible = True
                btnEditEmployee.Visible = False
                btnDeleteEmployee.Visible = False
                btnSaveEmployee.Visible = False
                btnCancelEmployee.Visible = False
            Case "RowSelected"
                btnAddEmployee.Visible = True
                btnEditEmployee.Visible = True
                btnDeleteEmployee.Visible = True
                btnSaveEmployee.Visible = False
                btnCancelEmployee.Visible = False
            Case "AddOrEdit"
                btnAddEmployee.Visible = False
                btnEditEmployee.Visible = False
                btnDeleteEmployee.Visible = False
                btnSaveEmployee.Visible = True
                btnCancelEmployee.Visible = True
        End Select
    End Sub
    Private Sub PopulateTextboxes(row As DataGridViewRow)
        If row Is Nothing Then Return

        Dim GetCellValue As Func(Of String, String) =
            Function(colName As String)
                If row.DataGridView.Columns.Contains(colName) Then
                    Return If(row.Cells(colName)?.Value, "").ToString()
                Else
                    Return ""
                End If
            End Function

        txtEmployeeID.Text = If(GetCellValue("EmployeeID") <> "", FormatID("EMP", ExtractNumericID(GetCellValue("EmployeeID")), 4), "")
        Dim fullName As String = GetCellValue("FullName")
        Dim nameParts() As String = fullName.Split(" "c, StringSplitOptions.RemoveEmptyEntries)
        If nameParts.Length > 0 Then txtFirstName.Text = nameParts(0)
        If nameParts.Length > 2 Then
            txtMiddleName.Text = nameParts(1)
            txtLastName.Text = String.Join(" ", nameParts.Skip(2))
        ElseIf nameParts.Length = 2 Then
            txtMiddleName.Text = ""
            txtLastName.Text = nameParts(1)
        End If

        Dim birthDate As DateTime
        If DateTime.TryParse(GetCellValue("BirthDate"), birthDate) Then dtpBirthDate.Value = birthDate Else dtpBirthDate.Value = DateTime.Now

        cbSex.Text = GetCellValue("Sex")
        cbCivilStatus.Text = GetCellValue("CivilStatus")
        txtPhone.Text = GetCellValue("ContactNumber")
        txtEmail.Text = GetCellValue("EmailAddress")
        txtAddress.Text = GetCellValue("Address")

        txtECContactID.Text = If(GetCellValue("EmergencyContactID") <> "", FormatID("EC", ExtractNumericID(GetCellValue("EmergencyContactID")), 4), "")
        txtECName.Text = GetCellValue("EmergencyName")
        txtECRelationship.Text = GetCellValue("Relationship")
        txtECPhone.Text = GetCellValue("EmergencyPhone")
        txtECAddress.Text = GetCellValue("EmergencyAddress")

        txtUserID.Text = If(GetCellValue("UserID") <> "", FormatID("USR", ExtractNumericID(GetCellValue("UserID")), 4), "")
        cbUserType.Text = GetCellValue("UserType")
        txtUsername.Text = GetCellValue("Username")
        txtPassword.Text = ""

        txtDepartmentID.Text = GetCellValue("DepartmentID")
        txtDepartment.Text = GetCellValue("DepartmentName")
        txtJobID.Text = If(GetCellValue("JobID") <> "", FormatID("JOB", ExtractNumericID(GetCellValue("JobID")), 4), "")
        cbEmployeeStatus.Text = GetCellValue("EmploymentStatus")

        Dim dateHired As DateTime
        If DateTime.TryParse(GetCellValue("DateHired"), dateHired) Then dtpDateHired.Value = dateHired Else dtpDateHired.Value = DateTime.Now

        cbContractType.Text = GetCellValue("ContractType")
        txtJobTitle.Text = GetCellValue("JobTitle")

        txtAge.Text = If(String.IsNullOrWhiteSpace(GetCellValue("Age")), CalculateAge(dtpBirthDate.Value).ToString(), GetCellValue("Age"))
        txtYearsOfSevice.Text = If(String.IsNullOrWhiteSpace(GetCellValue("YearsOfService")), CalculateYearsOfService(dtpDateHired.Value).ToString("0.00"), GetCellValue("YearsOfService"))
    End Sub
    Private Sub dgvOtherInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOtherInfo.CellClick
        If e.RowIndex < 0 Then Return
        PopulateTextboxes(dgvOtherInfo.Rows(e.RowIndex))
        SetButtonVisibility("RowSelected")
    End Sub
    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs)
        txtAge.Text = CalculateAge(dtpBirthDate.Value).ToString()
    End Sub
    Private Sub dtpDateHired_ValueChanged(sender As Object, e As EventArgs)
        txtYearsOfSevice.Text = CalculateYearsOfService(dtpDateHired.Value).ToString("0.00")
    End Sub
    Private Function CalculateAge(birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1
        Return Math.Max(age, 0)
    End Function
    Private Function CalculateYearsOfService(startDate As DateTime) As Double
        Return Math.Round(Math.Max((Date.Today - startDate).TotalDays / 365.25, 0), 2)
    End Function
    Private Function FormatID(prefix As String, numericId As Integer, digits As Integer) As String
        Return prefix & numericId.ToString().PadLeft(digits, "0"c)
    End Function
    Private Function ExtractNumericID(formatted As String) As Integer
        If String.IsNullOrWhiteSpace(formatted) Then Return 0
        Dim digits = New String(formatted.Where(AddressOf Char.IsDigit).ToArray())
        Dim n As Integer
        If Integer.TryParse(digits, n) Then Return n
        Return 0
    End Function
    Private Function ValidateEmployeeInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then MessageBox.Show("Enter First Name") : txtFirstName.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then MessageBox.Show("Enter Last Name") : txtLastName.Focus() : Return False
        If String.IsNullOrWhiteSpace(cbSex.Text) Then MessageBox.Show("Select Sex") : cbSex.Focus() : Return False
        If String.IsNullOrWhiteSpace(cbCivilStatus.Text) Then MessageBox.Show("Select Civil Status") : cbCivilStatus.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtPhone.Text) Then MessageBox.Show("Enter Phone") : txtPhone.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then MessageBox.Show("Enter Email") : txtEmail.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then MessageBox.Show("Enter Address") : txtAddress.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtECName.Text) Then MessageBox.Show("Enter Emergency Contact Name") : txtECName.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtECRelationship.Text) Then MessageBox.Show("Enter Emergency Relationship") : txtECRelationship.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtECPhone.Text) Then MessageBox.Show("Enter Emergency Phone") : txtECPhone.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtECAddress.Text) Then MessageBox.Show("Enter Emergency Address") : txtECAddress.Focus() : Return False
        If String.IsNullOrWhiteSpace(cbUserType.Text) Then MessageBox.Show("Select User Type") : cbUserType.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then MessageBox.Show("Enter Username") : txtUsername.Focus() : Return False
        If currentMode = "Add" AndAlso String.IsNullOrWhiteSpace(txtPassword.Text) Then MessageBox.Show("Enter Password") : txtPassword.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtDepartment.Text) Then MessageBox.Show("Enter Department") : txtDepartment.Focus() : Return False
        If String.IsNullOrWhiteSpace(cbEmployeeStatus.Text) Then MessageBox.Show("Select Employment Status") : cbEmployeeStatus.Focus() : Return False
        If String.IsNullOrWhiteSpace(cbContractType.Text) Then MessageBox.Show("Select Contract Type") : cbContractType.Focus() : Return False
        If String.IsNullOrWhiteSpace(txtJobTitle.Text) Then MessageBox.Show("Enter Job Title") : txtJobTitle.Focus() : Return False
        If Not IsValidEmail(txtEmail.Text) Then MessageBox.Show("Invalid Email") : txtEmail.Focus() : Return False
        If Not IsNumeric(txtPhone.Text) Then MessageBox.Show("Phone must be numeric") : txtPhone.Focus() : Return False
        If Not IsNumeric(txtECPhone.Text) Then MessageBox.Show("Emergency Phone must be numeric") : txtECPhone.Focus() : Return False
        Return True
    End Function
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
    Private rng As New Random()
    Private Function GenerateTemporaryUsername() As String
        Dim username As String
        Do
            Dim firstName As String = If(String.IsNullOrWhiteSpace(txtFirstName.Text), "user", txtFirstName.Text.Trim().ToLower())
            Dim lastName As String = If(String.IsNullOrWhiteSpace(txtLastName.Text), "temp", txtLastName.Text.Trim().ToLower())
            username = $"{firstName}.{lastName}{rng.Next(100, 999)}"
        Loop While UsernameExists(username)
        Return username
    End Function
    Private Function UsernameExists(username As String) As Boolean
        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblaccount WHERE Username=@uname", dbcon)
                cmd.Parameters.AddWithValue("@uname", username)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function
    Private Function GenerateTemporaryPassword(length As Integer) As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*"
        Dim password(length - 1) As Char
        Dim randomBytes(length - 1) As Byte
        RandomNumberGenerator.Fill(randomBytes)

        For i As Integer = 0 To length - 1
            password(i) = chars(randomBytes(i) Mod chars.Length)
        Next

        Return New String(password)
    End Function
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        ClearAllTextboxes()
        EnableAllTextboxes()
        currentMode = "Add"
        SetButtonVisibility("AddOrEdit")
        txtEmployeeID.Text = GetNextEmployeeID().ToString()
        txtDepartmentID.Text = "D" & GetNextDepartmentID().ToString()
        txtJobID.Text = "J" & GetNextJobID().ToString()
        txtUserID.Text = GetNextUserID()
        txtUsername.Text = GenerateTemporaryUsername()
        txtPassword.Text = GenerateTemporaryPassword(8)
        txtECContactID.Text = GetNextECID()

    End Sub
    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then Return
        EnableAllTextboxes()
        currentMode = "Edit"
        SetButtonVisibility("AddOrEdit")
    End Sub
    Private Sub btnCancelEmployee_Click(sender As Object, e As EventArgs) Handles btnCancelEmployee.Click
        ClearAllTextboxes()
        DisableAllTextboxes()
        SetButtonVisibility("Default")
        currentMode = ""
    End Sub
    Private Sub btnSaveEmployee_Click(sender As Object, e As EventArgs) Handles btnSaveEmployee.Click
        If Not ValidateEmployeeInputs() Then Return
        txtAge.Text = CalculateAge(dtpBirthDate.Value).ToString()
        txtYearsOfSevice.Text = CalculateYearsOfService(dtpDateHired.Value).ToString("0.00")

        If currentMode = "Add" Then
            SaveNewEmployee()
        ElseIf currentMode = "Edit" Then
            UpdateEmployee()
        End If

        LoadOtherEmployeeInfo()
        DisableAllTextboxes()
        SetButtonVisibility("Default")
        currentMode = ""
    End Sub
    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            MessageBox.Show("Select an employee to delete.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this employee? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If

        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using tran = dbcon.BeginTransaction()
                Try
                    ' Delete from child tables first
                    Using cmd As New MySqlCommand("DELETE FROM tblaccount WHERE EmployeeID=@eid", dbcon, tran)
                        cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd As New MySqlCommand("DELETE FROM tblemergencycontact WHERE EmployeeID=@eid", dbcon, tran)
                        cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd As New MySqlCommand("DELETE FROM tbljobdetails WHERE EmployeeID=@eid", dbcon, tran)
                        cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Finally, delete the employee record
                    Using cmd As New MySqlCommand("DELETE FROM tblemployee WHERE EmployeeID=@eid", dbcon, tran)
                        cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    tran.Commit()
                    MessageBox.Show("Employee deleted successfully.")
                    ClearAllTextboxes()
                    DisableAllTextboxes()
                    SetButtonVisibility("Default")
                    LoadOtherEmployeeInfo()
                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show("Error deleting employee: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Function GetNextEmployeeID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT EmployeeID FROM tblemployee ORDER BY EmployeeID DESC LIMIT 1"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim lastID As Object = cmd.ExecuteScalar()
                    If lastID Is Nothing OrElse lastID Is DBNull.Value Then Return "EMP0122"
                    Dim numericPart As Integer = 0
                    Dim digits = New String(lastID.ToString().Where(AddressOf Char.IsDigit).ToArray())
                    If Integer.TryParse(digits, numericPart) Then numericPart += 1 Else numericPart = 122
                    Return "EMP" & numericPart.ToString("D4")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Employee ID: " & ex.Message)
            Return "EMP0122"
        End Try
    End Function
    Private Function GetNextDepartmentID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT MAX(CAST(SUBSTRING(DepartmentID, 2) AS UNSIGNED)) FROM tbldepartment"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim result = cmd.ExecuteScalar()
                    Dim nextID As Integer = If(result Is DBNull.Value OrElse result Is Nothing, 22, Convert.ToInt32(result) + 1)
                    Return "D" & nextID.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Department ID: " & ex.Message)
            Return "D22"
        End Try
    End Function
    Private Function GetNextJobID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT JobID FROM tbljobdetails ORDER BY JobID DESC LIMIT 1"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim lastID As Object = cmd.ExecuteScalar()
                    If lastID Is Nothing OrElse lastID Is DBNull.Value Then Return "J0122"
                    Dim numericPart As Integer = 0
                    Dim digits = New String(lastID.ToString().Where(AddressOf Char.IsDigit).ToArray())
                    If Integer.TryParse(digits, numericPart) Then numericPart += 1 Else numericPart = 122
                    Return "J" & numericPart.ToString("D4")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Job ID: " & ex.Message)
            Return "J0122"
        End Try
    End Function
    Private Function GetNextECID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT EmergencyContactID FROM tblemergencycontact ORDER BY EmergencyContactID DESC LIMIT 1"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim lastID As Object = cmd.ExecuteScalar()
                    If lastID Is Nothing OrElse lastID Is DBNull.Value Then Return "EC0122"
                    Dim numericPart As Integer = 0
                    Dim digits = New String(lastID.ToString().Where(AddressOf Char.IsDigit).ToArray())
                    If Integer.TryParse(digits, numericPart) Then numericPart += 1 Else numericPart = 122
                    Return "EC" & numericPart.ToString("D4")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating EC ID: " & ex.Message)
            Return "EC0122"
        End Try
    End Function
    Private Function GetNextUserID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT UserID FROM tblaccount ORDER BY UserID DESC LIMIT 1"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim lastID As Object = cmd.ExecuteScalar()
                    If lastID Is Nothing OrElse lastID Is DBNull.Value Then Return "U1000"
                    Dim numericPart As Integer = 0
                    Dim digits = New String(lastID.ToString().Where(AddressOf Char.IsDigit).ToArray())
                    If Integer.TryParse(digits, numericPart) Then numericPart += 1 Else numericPart = 1000
                    Return "U" & numericPart.ToString("D4")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating User ID: " & ex.Message)
            Return "U1000"
        End Try
    End Function
    Private Sub SaveNewEmployee()
        ' Convert IDs to numeric parts
        Dim newEmployeeID As Integer = ExtractNumericID(txtEmployeeID.Text)
        Dim newDepartmentID As Integer = ExtractNumericID(txtDepartmentID.Text)
        Dim newJobID As Integer = ExtractNumericID(txtJobID.Text)
        Dim newUserID As Integer = ExtractNumericID(txtUserID.Text)
        Dim newECID As Integer = ExtractNumericID(If(String.IsNullOrWhiteSpace(txtECContactID.Text), GetNextECID(), txtECContactID.Text))

        txtECContactID.Text = FormatID("EC", newECID, 4) ' Keep prefix in UI
        Dim hashedPassword As String = HashPassword(txtPassword.Text)

        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using tran = dbcon.BeginTransaction()
                Try
                    ' Insert Employee
                    Using cmd As New MySqlCommand(
                    "INSERT INTO tblemployee(EmployeeID, `First Name`, MiddleName, LastName, BirthDate, Age, Sex, `Civil Status`, `Contact Number`, `Email Address`, Address) 
                     VALUES (@eid,@fname,@mname,@lname,@bdate,@age,@sex,@civil,@phone,@email,@address)", dbcon, tran)

                        Dim age As Integer = 0
                        Integer.TryParse(txtAge.Text, age)

                        cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                        cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
                        cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                        cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value)
                        cmd.Parameters.AddWithValue("@age", age)
                        cmd.Parameters.AddWithValue("@sex", cbSex.Text)
                        cmd.Parameters.AddWithValue("@civil", cbCivilStatus.Text)
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text)

                        cmd.ExecuteNonQuery()
                    End Using

                    ' Insert Emergency Contact
                    Using cmd As New MySqlCommand(
                    "INSERT INTO tblemergencycontact(EmergencyContactID, EmployeeID, Name, Relationship, PhoneNumber, Address) 
                     VALUES (@ecid,@eid,@name,@rel,@phone,@addr)", dbcon, tran)

                        cmd.Parameters.AddWithValue("@ecid", newECID)
                        cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                        cmd.Parameters.AddWithValue("@name", txtECName.Text)
                        cmd.Parameters.AddWithValue("@rel", txtECRelationship.Text)
                        cmd.Parameters.AddWithValue("@phone", txtECPhone.Text)
                        cmd.Parameters.AddWithValue("@addr", txtECAddress.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Insert Account
                    Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblaccount WHERE EmployeeID=@eid", dbcon, tran)
                        cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If count = 0 Then
                            Using insertCmd As New MySqlCommand(
                            "INSERT INTO tblaccount(UserID, EmployeeID, UserType, Username, Password) 
                             VALUES (@uid, @eid, @utype, @uname, @password)", dbcon, tran)

                                insertCmd.Parameters.AddWithValue("@uid", newUserID)
                                insertCmd.Parameters.AddWithValue("@eid", newEmployeeID)
                                insertCmd.Parameters.AddWithValue("@utype", cbUserType.SelectedItem.ToString())
                                insertCmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                                insertCmd.Parameters.AddWithValue("@password", hashedPassword)
                                insertCmd.ExecuteNonQuery()
                            End Using
                        Else
                            Using updateCmd As New MySqlCommand(
                            "UPDATE tblaccount SET UserType=@utype, Username=@uname, Password=@password WHERE EmployeeID=@eid", dbcon, tran)

                                updateCmd.Parameters.AddWithValue("@eid", newEmployeeID)
                                updateCmd.Parameters.AddWithValue("@utype", cbUserType.SelectedItem.ToString())
                                updateCmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                                updateCmd.Parameters.AddWithValue("@password", hashedPassword)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using

                    ' Insert Job Details
                    Using cmd As New MySqlCommand(
                    "INSERT INTO tbljobdetails(JobID, EmployeeID, EmploymentStatus, DateHired, ContractType, JobTitle, YearsOfService, DepartmentID) 
                     VALUES (@jid,@eid,@estatus,@dhired,@ctype,@jtitle,@yos,@did)", dbcon, tran)

                        Dim yos As Double = 0
                        Double.TryParse(txtYearsOfSevice.Text, yos)

                        cmd.Parameters.AddWithValue("@jid", newJobID)
                        cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                        cmd.Parameters.AddWithValue("@estatus", cbEmployeeStatus.Text)
                        cmd.Parameters.AddWithValue("@dhired", dtpDateHired.Value)
                        cmd.Parameters.AddWithValue("@ctype", cbContractType.Text)
                        cmd.Parameters.AddWithValue("@jtitle", txtJobTitle.Text)
                        cmd.Parameters.AddWithValue("@yos", yos)
                        cmd.Parameters.AddWithValue("@did", newDepartmentID)

                        cmd.ExecuteNonQuery()
                    End Using

                    tran.Commit()
                    MessageBox.Show("Employee added successfully.")
                    ClearAllTextboxes()
                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show("Error adding employee: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub UpdateEmployee()
        Dim hashedPassword As String = If(String.IsNullOrWhiteSpace(txtPassword.Text), Nothing, HashPassword(txtPassword.Text))

        Dim numericEmployeeID As Integer = ExtractNumericID(txtEmployeeID.Text)
        Dim numericDepartmentID As Integer = ExtractNumericID(txtDepartmentID.Text)
        Dim numericJobID As Integer = ExtractNumericID(txtJobID.Text)

        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using tran = dbcon.BeginTransaction()
                Try
                    ' Update tblemployee
                    Dim age As Integer = 0
                    Integer.TryParse(txtAge.Text, age)

                    Using cmd As New MySqlCommand(
                    "UPDATE tblemployee SET `First Name`=@fname, MiddleName=@mname, LastName=@lname, BirthDate=@bdate, Age=@age, Sex=@sex, `Civil Status`=@civil, `Contact Number`=@phone, `Email Address`=@email, Address=@address WHERE EmployeeID=@eid",
                    dbcon, tran)

                        cmd.Parameters.AddWithValue("@eid", numericEmployeeID)
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                        cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
                        cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                        cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value)
                        cmd.Parameters.AddWithValue("@age", age)
                        cmd.Parameters.AddWithValue("@sex", cbSex.Text)
                        cmd.Parameters.AddWithValue("@civil", cbCivilStatus.Text)
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update Emergency Contact
                    Using cmd As New MySqlCommand(
                    "UPDATE tblemergencycontact SET Name=@name, Relationship=@rel, PhoneNumber=@phone, Address=@addr WHERE EmployeeID=@eid",
                    dbcon, tran)

                        cmd.Parameters.AddWithValue("@eid", numericEmployeeID)
                        cmd.Parameters.AddWithValue("@name", txtECName.Text)
                        cmd.Parameters.AddWithValue("@rel", txtECRelationship.Text)
                        cmd.Parameters.AddWithValue("@phone", txtECPhone.Text)
                        cmd.Parameters.AddWithValue("@addr", txtECAddress.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update Account
                    Using cmd As New MySqlCommand(
                    "UPDATE tblaccount SET UserType=@utype, Username=@uname" &
                    If(hashedPassword IsNot Nothing, ", Password=@password", "") &
                    " WHERE EmployeeID=@eid",
                    dbcon, tran)

                        cmd.Parameters.AddWithValue("@eid", numericEmployeeID)
                        cmd.Parameters.AddWithValue("@utype", cbUserType.Text)
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                        If hashedPassword IsNot Nothing Then cmd.Parameters.AddWithValue("@password", hashedPassword)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update Job Details
                    Dim yos As Double = 0
                    Double.TryParse(txtYearsOfSevice.Text, yos)

                    Using cmd As New MySqlCommand(
                    "UPDATE tbljobdetails SET EmploymentStatus=@estatus, DateHired=@dhired, ContractType=@ctype, JobTitle=@jtitle, YearsOfService=@yos, DepartmentID=@did WHERE EmployeeID=@eid",
                    dbcon, tran)

                        cmd.Parameters.AddWithValue("@eid", numericEmployeeID)
                        cmd.Parameters.AddWithValue("@estatus", cbEmployeeStatus.Text)
                        cmd.Parameters.AddWithValue("@dhired", dtpDateHired.Value)
                        cmd.Parameters.AddWithValue("@ctype", cbContractType.Text)
                        cmd.Parameters.AddWithValue("@jtitle", txtJobTitle.Text)
                        cmd.Parameters.AddWithValue("@yos", yos)
                        cmd.Parameters.AddWithValue("@did", numericDepartmentID)
                        cmd.ExecuteNonQuery()
                    End Using

                    tran.Commit()
                    MessageBox.Show("Employee updated successfully.")
                    ClearAllTextboxes()
                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show("Error updating employee: " & ex.Message)
                End Try
            End Using
        End Using
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
        lblTeamOverview.Enabled = False
    End Sub
    Private Sub lblAttandanceTracker_Click(sender As Object, e As EventArgs) Handles lblAttandanceTracker.Click
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
