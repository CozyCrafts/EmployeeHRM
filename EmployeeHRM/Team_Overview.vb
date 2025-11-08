Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Security.Cryptography


Public Class Team_Overview
    Private  connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private currentMode As String = "" ' "", "Add", "Edit"
    Private bsEmployees As BindingSource

    ' ----------------- Form load -----------------
    Private Sub Team_Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate comboboxes
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

        ' Initialize age/years
        txtAge.Text = CalculateAge(dtpBirthDate.Value).ToString()
        txtYearsOfSevice.Text = CalculateYearsOfService(dtpDateHired.Value).ToString("0.00")

        AddHandler dtpBirthDate.ValueChanged, AddressOf dtpBirthDate_ValueChanged
        AddHandler dtpDateHired.ValueChanged, AddressOf dtpDateHired_ValueChanged
    End Sub

    ' ----------------- Load DataGridView -----------------
    Private Sub LoadOtherEmployeeInfo()
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim query As String = "
    SELECT
        e.EmployeeID, e.`First Name` AS FirstName, e.MiddleName, e.LastName,
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
            dgvOtherInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgvOtherInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.False
            dgvOtherInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvOtherInfo.DefaultCellStyle.Font = New Font("Century Gothic", 9, FontStyle.Regular)
            dgvOtherInfo.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        Catch ex As Exception
            MessageBox.Show("Error loading other info: " & ex.Message)
        End Try
    End Sub

    ' ----------------- Search Employee -----------------
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Dim searchValue As String = txtSearchEmployee.Text.Trim()
        dgvOtherInfo.ClearSelection()
        If String.IsNullOrEmpty(searchValue) Then
            LoadOtherEmployeeInfo()
            Return
        End If

        Dim searchParts() As String = searchValue.Split(" "c, StringSplitOptions.RemoveEmptyEntries)
        For Each row As DataGridViewRow In dgvOtherInfo.Rows
            If Not row.IsNewRow Then
                Dim employeeID As String = row.Cells("EmployeeID").Value.ToString()
                Dim firstName As String = row.Cells("FirstName").Value.ToString()
                Dim lastName As String = row.Cells("LastName").Value.ToString()
                Dim fullName As String = $"{firstName} {lastName}"

                Dim nameMatch As Boolean = False
                If employeeID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                   fullName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    nameMatch = True
                Else
                    For Each part In searchParts
                        If firstName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                           lastName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            nameMatch = True
                        End If
                    Next
                End If

                row.Selected = nameMatch
            End If
        Next
    End Sub

    ' ----------------- Enable / Disable / Clear -----------------
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
        ' Keep certain TextBoxes disabled
        txtEmployeeID.Enabled = False
        txtECContactID.Enabled = False
        txtUserID.Enabled = False
        txtAge.Enabled = False
        txtYearsOfSevice.Enabled = False

        ' Enable the rest
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

    ' ----------------- Button visibility -----------------
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

    ' ----------------- Populate textboxes -----------------
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
        txtFirstName.Text = GetCellValue("FirstName")
        txtMiddleName.Text = GetCellValue("MiddleName")
        txtLastName.Text = GetCellValue("LastName")

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
    ' ----------------- DataGridView click -----------------
    Private Sub dgvOtherInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOtherInfo.CellClick
        If e.RowIndex < 0 Then Return
        PopulateTextboxes(dgvOtherInfo.Rows(e.RowIndex))
        SetButtonVisibility("RowSelected")
    End Sub

    ' ----------------- Age / Years dynamic -----------------
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

    ' ----------------- Validation -----------------
    Private Function ValidateEmployeeInputs() As Boolean
        ' Basic fields
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

        ' Email validation
        If Not IsValidEmail(txtEmail.Text) Then MessageBox.Show("Invalid Email") : txtEmail.Focus() : Return False

        ' Phone validation
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

    ' ----------------- Password Hashing -----------------
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' ----------------- Username / Password Generation -----------------

    Private rng As New Random()

    ' Generate unique username based on first and last name
    Private Function GenerateTemporaryUsername() As String
        Dim username As String
        Do
            Dim firstName As String = If(String.IsNullOrWhiteSpace(txtFirstName.Text), "user", txtFirstName.Text.Trim().ToLower())
            Dim lastName As String = If(String.IsNullOrWhiteSpace(txtLastName.Text), "temp", txtLastName.Text.Trim().ToLower())
            username = $"{firstName}.{lastName}{rng.Next(100, 999)}"
        Loop While UsernameExists(username)
        Return username
    End Function

    ' Check if username already exists in the database
    Private Function UsernameExists(username As String) As Boolean
        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblaccount WHERE Username=@uname", dbcon)
                cmd.Parameters.AddWithValue("@uname", username)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    ' ----------------- Generate temporary password -----------------
    Private Function GenerateTemporaryPassword(length As Integer) As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*"
        Dim password(length - 1) As Char

        ' Fill the password array with secure random values
        Dim randomBytes(length - 1) As Byte
        RandomNumberGenerator.Fill(randomBytes)

        For i As Integer = 0 To length - 1
            password(i) = chars(randomBytes(i) Mod chars.Length)
        Next

        Return New String(password)
    End Function

    ' ----------------- btnAddEmployee Click -----------------
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        ClearAllTextboxes()
        EnableAllTextboxes()
        currentMode = "Add"
        SetButtonVisibility("AddOrEdit")

        ' Assign next IDs
        txtEmployeeID.Text = GetNextEmployeeID().ToString()
        txtDepartmentID.Text = "D" & GetNextDepartmentID().ToString()
        txtJobID.Text = "J" & GetNextJobID().ToString()
        txtUserID.Text = GetUserIDByType(If(cbUserType.SelectedItem IsNot Nothing, cbUserType.SelectedItem.ToString(), "Staff"))
        txtECContactID.Text = GetNextECID()

        ' Generate temporary username and password
        txtUsername.Text = GenerateTemporaryUsername()
        txtPassword.Text = GenerateTemporaryPassword(8) ' <-- Now works
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
    ' ----------------- EmployeeID -----------------
    Private Function GetNextEmployeeID() As Integer
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT MAX(CAST(EmployeeID AS UNSIGNED)) FROM tblemployee"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim result = cmd.ExecuteScalar()
                    Return If(result Is DBNull.Value OrElse result Is Nothing, 122, Convert.ToInt32(result) + 1)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Employee ID: " & ex.Message)
            Return 122
        End Try
    End Function

    ' ----------------- DepartmentID -----------------
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

    ' ----------------- JobID -----------------
    Private Function GetNextJobID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT MAX(CAST(SUBSTRING(JobID, 2) AS UNSIGNED)) FROM tbljobdetails"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim result = cmd.ExecuteScalar()
                    Dim nextID As Integer = If(result Is DBNull.Value OrElse result Is Nothing, 22, Convert.ToInt32(result) + 1)
                    Return "J" & nextID.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Job ID: " & ex.Message)
            Return "J22"
        End Try
    End Function

    ' ----------------- EmergencyContactID -----------------
    Private Function GetNextECID() As String
        Try
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim sql As String = "SELECT MAX(CAST(SUBSTRING(EmergencyContactID, 3) AS UNSIGNED)) FROM tblemergencycontact"
                Using cmd As New MySqlCommand(sql, dbcon)
                    Dim result = cmd.ExecuteScalar()
                    If result Is DBNull.Value OrElse result Is Nothing Then Return "EC122" ' Start at EC122 if table empty
                    Return "EC" & (Convert.ToInt32(result) + 1).ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating EmergencyContact ID: " & ex.Message)
            Return "EC122"
        End Try
    End Function

    ' ----------------- UserID -----------------
    Private Function GetUserIDByType(userType As String) As String
        Select Case userType
            Case "Manager"
                Return "U1009"
            Case "Staff"
                Return "U1008"
            Case Else
                Return "U1000"
        End Select
    End Function

    ' ----------------- Save New Employee -----------------
    Private Sub SaveNewEmployee()
        Dim newEmployeeID As String = txtEmployeeID.Text
        Dim newDepartmentID As String = txtDepartmentID.Text
        Dim newJobID As String = txtJobID.Text
        Dim newUserID As String = txtUserID.Text
        Dim newECID As String = txtECContactID.Text
        Dim hashedPassword As String = HashPassword(txtPassword.Text)

        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using tran = dbcon.BeginTransaction()
                Try
                    ' --- Employee ---
                    Dim cmd As New MySqlCommand(
                        "INSERT INTO tblemployee(EmployeeID, `First Name`, MiddleName, LastName, BirthDate, Age, Sex, `Civil Status`, `Contact Number`, `Email Address`, Address) 
                         VALUES (@eid,@fname,@mname,@lname,@bdate,@age,@sex,@civil,@phone,@email,@address)", dbcon, tran)

                    cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value)
                    cmd.Parameters.AddWithValue("@age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@sex", cbSex.Text)
                    cmd.Parameters.AddWithValue("@civil", cbCivilStatus.Text)
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                    cmd.ExecuteNonQuery()

                    ' --- Emergency Contact ---
                    cmd.CommandText = "INSERT INTO tblemergencycontact(EmergencyContactID, EmployeeID, Name, Relationship, PhoneNumber, Address) 
                                       VALUES (@ecid,@eid,@name,@rel,@phone,@addr)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@ecid", newECID)
                    cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                    cmd.Parameters.AddWithValue("@name", txtECName.Text)
                    cmd.Parameters.AddWithValue("@rel", txtECRelationship.Text)
                    cmd.Parameters.AddWithValue("@phone", txtECPhone.Text)
                    cmd.Parameters.AddWithValue("@addr", txtECAddress.Text)
                    cmd.ExecuteNonQuery()

                    ' --- Account ---
                    cmd.CommandText = "INSERT INTO tblaccount(UserID, EmployeeID, UserType, Username, PasswordHash) 
                                       VALUES (@uid,@eid,@utype,@uname,@password)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@uid", newUserID)
                    cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                    cmd.Parameters.AddWithValue("@utype", cbUserType.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    cmd.ExecuteNonQuery()

                    ' --- Job Details ---
                    cmd.CommandText = "INSERT INTO tbljobdetails(JobID, EmployeeID, EmploymentStatus, DateHired, ContractType, JobTitle, YearsOfService, DepartmentID) 
                                       VALUES (@jid,@eid,@estatus,@dhired,@ctype,@jtitle,@yos,@did)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@jid", newJobID)
                    cmd.Parameters.AddWithValue("@eid", newEmployeeID)
                    cmd.Parameters.AddWithValue("@estatus", cbEmployeeStatus.Text)
                    cmd.Parameters.AddWithValue("@dhired", dtpDateHired.Value)
                    cmd.Parameters.AddWithValue("@ctype", cbContractType.Text)
                    cmd.Parameters.AddWithValue("@jtitle", txtJobTitle.Text)
                    cmd.Parameters.AddWithValue("@yos", txtYearsOfSevice.Text)
                    cmd.Parameters.AddWithValue("@did", newDepartmentID)
                    cmd.ExecuteNonQuery()

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

    ' ----------------- Update Employee -----------------
    Private Sub UpdateEmployee()
        Dim hashedPassword As String = If(String.IsNullOrWhiteSpace(txtPassword.Text), Nothing, HashPassword(txtPassword.Text))

        Using dbcon As New MySqlConnection(connectionString)
            dbcon.Open()
            Using tran = dbcon.BeginTransaction()
                Try
                    Dim cmd As New MySqlCommand("UPDATE tblemployee SET `First Name`=@fname, MiddleName=@mname, LastName=@lname, BirthDate=@bdate, Age=@age, Sex=@sex, `Civil Status`=@civil, `Contact Number`=@phone, `Email Address`=@email, Address=@address WHERE EmployeeID=@eid", dbcon, tran)
                    cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value)
                    cmd.Parameters.AddWithValue("@age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@sex", cbSex.Text)
                    cmd.Parameters.AddWithValue("@civil", cbCivilStatus.Text)
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                    cmd.ExecuteNonQuery()

                    ' Emergency
                    cmd.CommandText = "UPDATE tblemergencycontact SET Name=@name, Relationship=@rel, PhoneNumber=@phone, Address=@addr WHERE EmployeeID=@eid"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                    cmd.Parameters.AddWithValue("@name", txtECName.Text)
                    cmd.Parameters.AddWithValue("@rel", txtECRelationship.Text)
                    cmd.Parameters.AddWithValue("@phone", txtECPhone.Text)
                    cmd.Parameters.AddWithValue("@addr", txtECAddress.Text)
                    cmd.ExecuteNonQuery()

                    ' Account
                    cmd.CommandText = "UPDATE tblaccount SET UserType=@utype, Username=@uname " & If(hashedPassword IsNot Nothing, ", Password=@password", "") & " WHERE EmployeeID=@eid"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                    cmd.Parameters.AddWithValue("@utype", cbUserType.Text)
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text)
                    If hashedPassword IsNot Nothing Then cmd.Parameters.AddWithValue("@passhash", hashedPassword)


                    ' Job
                    cmd.CommandText = "UPDATE tbljobdetails SET EmploymentStatus=@estatus, DateHired=@dhired, ContractType=@ctype, JobTitle=@jtitle, YearsOfService=@yos, DepartmentID=@did WHERE EmployeeID=@eid"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@eid", txtEmployeeID.Text)
                    cmd.Parameters.AddWithValue("@estatus", cbEmployeeStatus.Text)
                    cmd.Parameters.AddWithValue("@dhired", dtpDateHired.Value)
                    cmd.Parameters.AddWithValue("@ctype", cbContractType.Text)
                    cmd.Parameters.AddWithValue("@jtitle", txtJobTitle.Text)
                    cmd.Parameters.AddWithValue("@yos", txtYearsOfSevice.Text)
                    cmd.Parameters.AddWithValue("@did", txtDepartmentID.Text)
                    cmd.ExecuteNonQuery()

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
    ' ----------------- Navigation labels -----------------
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

    ' ----------------- Terminate -----------------
    Private Sub pcbTerminate_Click(sender As Object, e As EventArgs) Handles pcbTerminate.Click
        If MessageBox.Show("Are you sure you want to exit the system?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
