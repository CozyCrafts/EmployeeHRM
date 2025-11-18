Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class MyProfile

    Private dbcon As MySqlConnection
    Private dbcmd As MySqlCommand
    Private LoggedInUserID As String = LoggedInEmployeeID

    Private Sub OpenCon()
        If dbcon Is Nothing Then
            dbcon = New MySqlConnection("server=localhost;userid=root;password=091951;database=db_hrm")
        End If
        If dbcon.State = ConnectionState.Closed Then dbcon.Open()
    End Sub
    Private Sub LockAllFields()
        ' Employee Info
        txtEmployeeID.Enabled = False
        txtFirstName.ReadOnly = True
        txtMiddleName.ReadOnly = True
        txtLastName.ReadOnly = True
        dtpBirthDate.Enabled = False
        txtAge.ReadOnly = True
        cbSex.Enabled = False
        cbCivilStatus.Enabled = False
        txtPhone.ReadOnly = True
        txtEmail.ReadOnly = True
        txtAddress.ReadOnly = True

        ' Emergency Contact
        txtECContactID.Enabled = False
        txtECName.ReadOnly = True
        txtECRelationship.ReadOnly = True
        txtECPhone.ReadOnly = True
        txtECAddress.ReadOnly = True

        ' Account Info
        txtUserID.Enabled = False
        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
        cbUserType.Enabled = False

        ' Job Info
        txtJobID.Enabled = False
        txtJobTitle.ReadOnly = True
        txtYearsOfSevice.ReadOnly = True
        cbContractType.Enabled = False
        cbEmployeeStatus.Enabled = False
        dtpDateHired.Enabled = False

        ' Department Info
        txtDepartmentID.Enabled = False
        txtDepartment.ReadOnly = True
    End Sub

    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoggedInUserType = "Staff" Then
            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If

        Try
            OpenCon()
            LoadMyProfile()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadMyProfile()
        Try
            OpenCon()
            Dim query As String = "
SELECT 
    e.EmployeeID,
    e.`First Name`, e.MiddleName, e.LastName, e.Address, e.`Contact Number`, e.`Email Address`, e.BirthDate, e.Age, e.Sex, e.`Civil Status`,
    j.JobID, j.EmploymentStatus, j.DateHired, j.ContractType, j.JobTitle, j.YearsOfService,
    d.DepartmentID, d.Name AS DepartmentName,
    a.UserID, a.UserType, a.Username, a.Password,
    ec.EmergencyContactID, ec.Name AS ECName, ec.Address AS ECAddress, ec.PhoneNumber AS ECPhone, ec.Relationship AS ECRelationship
FROM tblemployee e
LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
LEFT JOIN tbldepartment d ON e.EmployeeID = d.EmployeeID
LEFT JOIN tblaccount a ON e.EmployeeID = a.EmployeeID
LEFT JOIN tblemergencycontact ec ON e.EmployeeID = ec.EmployeeID
WHERE e.EmployeeID=@empID
"

            Using dbcmd = New MySqlCommand(query, dbcon)
                dbcmd.Parameters.AddWithValue("@empID", LoggedInUserID)
                Using reader As MySqlDataReader = dbcmd.ExecuteReader()
                    If reader.Read() Then
                        ' --- Employee Info ---
                        txtEmployeeID.Text = reader("EmployeeID").ToString()
                        txtFirstName.Text = reader("First Name").ToString()
                        txtMiddleName.Text = reader("MiddleName").ToString()
                        txtLastName.Text = reader("LastName").ToString()
                        txtAddress.Text = reader("Address").ToString()
                        txtPhone.Text = reader("Contact Number").ToString()
                        txtEmail.Text = reader("Email Address").ToString()
                        txtAge.Text = reader("Age").ToString()
                        cbSex.Text = reader("Sex").ToString()
                        cbCivilStatus.Text = reader("Civil Status").ToString()

                        ' --- BirthDate safely ---
                        dtpBirthDate.Value = GetSafeDate(reader("BirthDate"), Date.Today)

                        ' --- Job Info ---
                        txtJobID.Text = If(reader("JobID") IsNot DBNull.Value, reader("JobID").ToString(), "")
                        txtJobTitle.Text = If(reader("JobTitle") IsNot DBNull.Value, reader("JobTitle").ToString(), "")
                        txtYearsOfSevice.Text = If(reader("YearsOfService") IsNot DBNull.Value, reader("YearsOfService").ToString(), "")
                        cbContractType.Text = If(reader("ContractType") IsNot DBNull.Value, reader("ContractType").ToString(), "")
                        cbEmployeeStatus.Text = If(reader("EmploymentStatus") IsNot DBNull.Value, reader("EmploymentStatus").ToString(), "")

                        ' --- DateHired safely ---
                        dtpDateHired.Value = GetSafeDate(reader("DateHired"), Date.Today)

                        ' --- Department Info ---
                        txtDepartmentID.Text = If(reader("DepartmentID") IsNot DBNull.Value, reader("DepartmentID").ToString(), "")
                        txtDepartment.Text = If(reader("DepartmentName") IsNot DBNull.Value, reader("DepartmentName").ToString(), "")

                        ' --- Account Info ---
                        txtUserID.Text = If(reader("UserID") IsNot DBNull.Value, reader("UserID").ToString(), "")
                        txtUsername.Text = If(reader("Username") IsNot DBNull.Value, reader("Username").ToString(), "")
                        txtPassword.Text = If(reader("Password") IsNot DBNull.Value, reader("Password").ToString(), "")
                        cbUserType.Text = If(reader("UserType") IsNot DBNull.Value, reader("UserType").ToString(), "")

                        ' --- Emergency Contact ---
                        txtECContactID.Text = If(reader("EmergencyContactID") IsNot DBNull.Value, reader("EmergencyContactID").ToString(), "")
                        txtECName.Text = If(reader("ECName") IsNot DBNull.Value, reader("ECName").ToString(), "")
                        txtECAddress.Text = If(reader("ECAddress") IsNot DBNull.Value, reader("ECAddress").ToString(), "")
                        txtECPhone.Text = If(reader("ECPhone") IsNot DBNull.Value, reader("ECPhone").ToString(), "")
                        txtECRelationship.Text = If(reader("ECRelationship") IsNot DBNull.Value, reader("ECRelationship").ToString(), "")
                    End If
                End Using
            End Using

            LockAllFields()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        End Try
    End Sub

    ' --- Helper function to safely parse dates ---
    Private Function GetSafeDate(dbValue As Object, defaultValue As DateTime) As DateTime
        Try
            If dbValue IsNot DBNull.Value Then
                Dim s As String = dbValue.ToString().Trim()
                s = s.TrimEnd("/"c) ' Remove trailing slashes if any

                Dim dt As DateTime
                If DateTime.TryParse(s, dt) Then
                    Return dt
                End If
            End If
        Catch
            ' Ignore and fall back to default
        End Try
        Return defaultValue
    End Function

    Private Sub btnEditContact_Click(sender As Object, e As EventArgs) Handles btnEditContact.Click
        ' Unlock only the editable fields
        txtECName.ReadOnly = False
        txtECRelationship.ReadOnly = False
        txtECPhone.ReadOnly = False
        txtECAddress.ReadOnly = False

        ' Show Save/Cancel buttons, hide Edit
        btnEditContact.Visible = False
        btnSaveContact.Visible = True
        btnCancelContact.Visible = True
    End Sub
    Private Sub btnCancelContact_Click(sender As Object, e As EventArgs) Handles btnCancelContact.Click
        ' Re-lock fields
        txtECName.ReadOnly = True
        txtECRelationship.ReadOnly = True
        txtECPhone.ReadOnly = True
        txtECAddress.ReadOnly = True

        ' Show Edit button, hide Save/Cancel
        btnEditContact.Visible = True
        btnSaveContact.Visible = False
        btnCancelContact.Visible = False

        ' Reload original emergency contact info
        LoadMyProfile()
    End Sub
    Private Sub btnSaveContact_Click(sender As Object, e As EventArgs) Handles btnSaveContact.Click
        Try
            ' --- Validation ---
            If String.IsNullOrWhiteSpace(txtECName.Text) Then
                MessageBox.Show("Emergency contact name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtECName.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(txtECRelationship.Text) Then
                MessageBox.Show("Relationship cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtECRelationship.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(txtECPhone.Text) Then
                MessageBox.Show("Phone number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtECPhone.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(txtECAddress.Text) Then
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtECAddress.Focus()
                Return
            End If

            ' --- Check for changes ---
            Dim currentName As String = ""
            Dim currentRel As String = ""
            Dim currentPhone As String = ""
            Dim currentAddr As String = ""

            Using dbcmd = New MySqlCommand("SELECT Name, Relationship, PhoneNumber, Address FROM tblemergencycontact WHERE EmployeeID=@id", dbcon)
                dbcmd.Parameters.AddWithValue("@id", LoggedInUserID)
                Using reader = dbcmd.ExecuteReader()
                    If reader.Read() Then
                        currentName = reader("Name").ToString()
                        currentRel = reader("Relationship").ToString()
                        currentPhone = reader("PhoneNumber").ToString()
                        currentAddr = reader("Address").ToString()
                    End If
                End Using
            End Using

            If txtECName.Text = currentName AndAlso
           txtECRelationship.Text = currentRel AndAlso
           txtECPhone.Text = currentPhone AndAlso
           txtECAddress.Text = currentAddr Then
                MessageBox.Show("No changes were made to emergency contact info.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' --- Update Database ---
            Dim query As String = "
            UPDATE tblemergencycontact
            SET Name=@name, Relationship=@rel, PhoneNumber=@phone, Address=@addr
            WHERE EmployeeID=@id
        "

            Using dbcmd = New MySqlCommand(query, dbcon)
                dbcmd.Parameters.AddWithValue("@name", txtECName.Text)
                dbcmd.Parameters.AddWithValue("@rel", txtECRelationship.Text)
                dbcmd.Parameters.AddWithValue("@phone", txtECPhone.Text)
                dbcmd.Parameters.AddWithValue("@addr", txtECAddress.Text)
                dbcmd.Parameters.AddWithValue("@id", LoggedInUserID)
                dbcmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Emergency contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Lock fields again
            LockAllFields()
            btnEditContact.Visible = True
            btnSaveContact.Visible = False
            btnCancelContact.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error saving emergency contact: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        ' Unlock account fields
        txtUsername.ReadOnly = False
        txtPassword.ReadOnly = False
        cbUserType.Enabled = False

        ' Show Save/Cancel, hide Edit
        btnEditAccount.Visible = False
        btnSaveAccount.Visible = True
        btnCancelAccount.Visible = True
    End Sub
    Private Sub btnCancelAccount_Click(sender As Object, e As EventArgs) Handles btnCancelAccount.Click
        ' Re-lock fields
        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
        cbUserType.Enabled = False

        ' Show Edit, hide Save/Cancel
        btnEditAccount.Visible = True
        btnSaveAccount.Visible = False
        btnCancelAccount.Visible = False

        ' Reload original account info
        LoadMyProfile()
    End Sub
    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        Try
            ' --- Validation ---
            If String.IsNullOrWhiteSpace(txtUsername.Text) Then
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsername.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(cbUserType.Text) Then
                MessageBox.Show("User type must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbUserType.Focus()
                Return
            End If

            ' --- Check for changes ---
            Dim currentUsername As String = ""
            Dim currentPassword As String = ""
            Dim currentUserType As String = ""

            ' Fetch current values from DB
            Using dbcmd = New MySqlCommand("SELECT Username, Password, UserType FROM tblaccount WHERE EmployeeID=@id", dbcon)
                dbcmd.Parameters.AddWithValue("@id", LoggedInUserID)
                Using reader = dbcmd.ExecuteReader()
                    If reader.Read() Then
                        currentUsername = reader("Username").ToString()
                        currentPassword = reader("Password").ToString()
                        currentUserType = reader("UserType").ToString()
                    End If
                End Using
            End Using

            If txtUsername.Text = currentUsername AndAlso
           txtPassword.Text = currentPassword AndAlso
           cbUserType.Text = currentUserType Then
                MessageBox.Show("No changes were made to the account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' --- Update Database ---
            Dim query As String = "
            UPDATE tblaccount 
            SET Username=@user, Password=@pass, UserType=@type
            WHERE EmployeeID=@id
        "

            Using dbcmd = New MySqlCommand(query, dbcon)
                dbcmd.Parameters.AddWithValue("@user", txtUsername.Text)
                dbcmd.Parameters.AddWithValue("@pass", txtPassword.Text) ' add encryption here if needed
                dbcmd.Parameters.AddWithValue("@type", cbUserType.Text)
                dbcmd.Parameters.AddWithValue("@id", LoggedInUserID)
                dbcmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Account info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- Lock fields again ---
            txtUsername.ReadOnly = True
            txtPassword.ReadOnly = True
            cbUserType.Enabled = False

            btnEditAccount.Visible = True
            btnSaveAccount.Visible = False
            btnCancelAccount.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error saving account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        ' Unlock only the editable fields
        cbCivilStatus.Enabled = True
        txtPhone.ReadOnly = False
        txtEmail.ReadOnly = False
        txtAddress.ReadOnly = False

        ' Show Save/Cancel, hide Edit
        btnEditInfo.Visible = False
        btnSaveInfo.Visible = True
        btnCancelInfo.Visible = True
    End Sub
    Private Sub btnCancelInfo_Click(sender As Object, e As EventArgs) Handles btnCancelInfo.Click
        ' Re-lock fields
        cbCivilStatus.Enabled = False
        txtPhone.ReadOnly = True
        txtEmail.ReadOnly = True
        txtAddress.ReadOnly = True

        ' Show Edit, hide Save/Cancel
        btnEditInfo.Visible = True
        btnSaveInfo.Visible = False
        btnCancelInfo.Visible = False

        ' Reload original personal info
        LoadMyProfile()
    End Sub
    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click
        Try
            ' --- Validation ---
            If String.IsNullOrWhiteSpace(cbCivilStatus.Text) Then
                MessageBox.Show("Civil Status cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbCivilStatus.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(txtPhone.Text) Then
                MessageBox.Show("Phone number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhone.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(txtEmail.Text) Then
                MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(txtAddress.Text) Then
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
                Return
            End If

            ' --- Check for changes ---
            Dim currentCivil As String = ""
            Dim currentPhone As String = ""
            Dim currentEmail As String = ""
            Dim currentAddress As String = ""

            Using dbcmd = New MySqlCommand("SELECT `Civil Status`, `Contact Number`, `Email Address`, Address FROM tblemployee WHERE EmployeeID=@id", dbcon)
                dbcmd.Parameters.AddWithValue("@id", LoggedInUserID)
                Using reader = dbcmd.ExecuteReader()
                    If reader.Read() Then
                        currentCivil = reader("Civil Status").ToString()
                        currentPhone = reader("Contact Number").ToString()
                        currentEmail = reader("Email Address").ToString()
                        currentAddress = reader("Address").ToString()
                    End If
                End Using
            End Using

            If cbCivilStatus.Text = currentCivil AndAlso
           txtPhone.Text = currentPhone AndAlso
           txtEmail.Text = currentEmail AndAlso
           txtAddress.Text = currentAddress Then
                MessageBox.Show("No changes were made to personal info.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' --- Update Database ---
            Dim query As String = "
            UPDATE tblemployee 
            SET `Civil Status`=@civil, `Contact Number`=@phone, `Email Address`=@mail, Address=@addr
            WHERE EmployeeID=@id
        "

            Using dbcmd = New MySqlCommand(query, dbcon)
                dbcmd.Parameters.AddWithValue("@civil", cbCivilStatus.Text)
                dbcmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                dbcmd.Parameters.AddWithValue("@mail", txtEmail.Text)
                dbcmd.Parameters.AddWithValue("@addr", txtAddress.Text)
                dbcmd.Parameters.AddWithValue("@id", LoggedInUserID)
                dbcmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Personal info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Lock fields again
            LockAllFields()
            btnEditInfo.Visible = True
            btnSaveInfo.Visible = False
            btnCancelInfo.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error saving personal info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Employee_Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        lblMyProfile.Enabled = False
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
