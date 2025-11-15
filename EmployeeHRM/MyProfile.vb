Imports MySql.Data.MySqlClient

Public Class MyProfile
    Private LoggedInUserID As String

    ' --- Lock all fields initially ---
    Private Sub LockAllFields()
        ' Personal Info
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
        txtECAddress.ReadOnly = True
        txtECPhone.ReadOnly = True
        txtECRelationship.ReadOnly = True
        txtECName.ReadOnly = True
        txtECContactID.ReadOnly = True

        ' Account Info
        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
    End Sub

    ' --- Unlock fields by section ---
    Private Sub UnlockPersonalInfo()
        txtFirstName.ReadOnly = False
        txtMiddleName.ReadOnly = False
        txtLastName.ReadOnly = False
        dtpBirthDate.Enabled = True
        txtAge.ReadOnly = False
        cbSex.Enabled = True
        cbCivilStatus.Enabled = True
        txtPhone.ReadOnly = False
        txtEmail.ReadOnly = False
        txtAddress.ReadOnly = False
    End Sub

    Private Sub UnlockEmergencyContact()
        txtECAddress.ReadOnly = False
        txtECPhone.ReadOnly = False
        txtECRelationship.ReadOnly = False
        txtECName.ReadOnly = False
        txtECContactID.ReadOnly = False
    End Sub

    Private Sub UnlockAccountInfo()
        txtUsername.ReadOnly = False
        txtPassword.ReadOnly = False
    End Sub

    ' --- Load profile ---
    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenCon()
            LoadPersonalInfo()
            LoadEmergencyContact()
            LoadAccountInfo()
            LockAllFields()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        End Try
    End Sub

    ' --- Load data methods ---
    Private Sub LoadPersonalInfo()
        Dim query As String = "SELECT * FROM employees WHERE employee_id=@empID"
        dbcmd = New MySqlCommand(query, dbcon)
        dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
        Dim reader As MySqlDataReader = dbcmd.ExecuteReader()
        If reader.Read() Then
            txtFirstName.Text = reader("first_name").ToString()
            txtMiddleName.Text = reader("middle_name").ToString()
            txtLastName.Text = reader("last_name").ToString()
            dtpBirthDate.Value = Convert.ToDateTime(reader("birth_date"))
            txtAge.Text = reader("age").ToString()
            cbSex.Text = reader("sex").ToString()
            cbCivilStatus.Text = reader("civil_status").ToString()
            txtPhone.Text = reader("phone").ToString()
            txtEmail.Text = reader("email").ToString()
            txtAddress.Text = reader("address").ToString()
        End If
        reader.Close()
    End Sub

    Private Sub LoadEmergencyContact()
        Dim query As String = "SELECT * FROM emergency_contacts WHERE employee_id=@empID"
        dbcmd = New MySqlCommand(query, dbcon)
        dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
        Dim reader As MySqlDataReader = dbcmd.ExecuteReader()
        If reader.Read() Then
            txtECName.Text = reader("name").ToString()
            txtECRelationship.Text = reader("relationship").ToString()
            txtECPhone.Text = reader("phone").ToString()
            txtECAddress.Text = reader("address").ToString()
            txtECContactID.Text = reader("contact_id").ToString()
        End If
        reader.Close()
    End Sub

    Private Sub LoadAccountInfo()
        Dim query As String = "SELECT * FROM users WHERE user_id=@userID"
        dbcmd = New MySqlCommand(query, dbcon)
        dbcmd.Parameters.AddWithValue("@userID", LoggedInUserID) ' Assuming you have this
        Dim reader As MySqlDataReader = dbcmd.ExecuteReader()
        If reader.Read() Then
            txtUsername.Text = reader("username").ToString()
            txtPassword.Text = reader("password").ToString()
            cbUserType.Text = reader("user_type").ToString()
        End If
        reader.Close()
    End Sub

    ' --- Edit buttons ---
    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        UnlockPersonalInfo()
        btnSaveInfo.Visible = True
        btnCancelInfo.Visible = True
        btnEditInfo.Visible = False
    End Sub

    Private Sub btnEditContact_Click(sender As Object, e As EventArgs) Handles btnEditContact.Click
        UnlockEmergencyContact()
        btnSaveContact.Visible = True
        btnCancelContact.Visible = True
        btnEditContact.Visible = False
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        UnlockAccountInfo()
        btnSaveAccount.Visible = True
        btnCancelAccount.Visible = True
        btnEditAccount.Visible = False
    End Sub

    ' --- Save buttons ---
    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click
        Try
            Dim query As String = "UPDATE employees SET first_name=@first, middle_name=@middle, last_name=@last, birth_date=@birth, age=@age, sex=@sex, civil_status=@civil, phone=@phone, email=@mail, address=@addr WHERE employee_id=@empID"
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@first", txtFirstName.Text)
            dbcmd.Parameters.AddWithValue("@middle", txtMiddleName.Text)
            dbcmd.Parameters.AddWithValue("@last", txtLastName.Text)
            dbcmd.Parameters.AddWithValue("@birth", dtpBirthDate.Value)
            dbcmd.Parameters.AddWithValue("@age", txtAge.Text)
            dbcmd.Parameters.AddWithValue("@sex", cbSex.Text)
            dbcmd.Parameters.AddWithValue("@civil", cbCivilStatus.Text)
            dbcmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            dbcmd.Parameters.AddWithValue("@mail", txtEmail.Text)
            dbcmd.Parameters.AddWithValue("@addr", txtAddress.Text)
            dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            dbcmd.ExecuteNonQuery()
            MessageBox.Show("Personal info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LockAllFields()
            btnSaveInfo.Visible = False
            btnCancelInfo.Visible = False
            btnEditInfo.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error saving personal info: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveContact_Click(sender As Object, e As EventArgs) Handles btnSaveContact.Click
        Try
            Dim query As String = "UPDATE emergency_contacts SET name=@name, relationship=@rel, phone=@phone, address=@addr WHERE contact_id=@contactID"
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@name", txtECName.Text)
            dbcmd.Parameters.AddWithValue("@rel", txtECRelationship.Text)
            dbcmd.Parameters.AddWithValue("@phone", txtECPhone.Text)
            dbcmd.Parameters.AddWithValue("@addr", txtECAddress.Text)
            dbcmd.Parameters.AddWithValue("@contactID", txtECContactID.Text)
            dbcmd.ExecuteNonQuery()
            MessageBox.Show("Emergency contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LockAllFields()
            btnSaveContact.Visible = False
            btnCancelContact.Visible = False
            btnEditContact.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error saving emergency contact: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        Try
            Dim query As String = "UPDATE users SET username=@username, password=@password WHERE user_id=@userID"
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@username", txtUsername.Text)
            dbcmd.Parameters.AddWithValue("@password", txtPassword.Text)
            dbcmd.Parameters.AddWithValue("@userID", txtUserID.Text)
            dbcmd.ExecuteNonQuery()
            MessageBox.Show("Account info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LockAllFields()
            btnSaveAccount.Visible = False
            btnCancelAccount.Visible = False
            btnEditAccount.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error saving account info: " & ex.Message)
        End Try
    End Sub


    ' --- Navigation buttons ---
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        lblDashboard.Enabled = False
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

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show(
            "Are you sure you want to sign out?",
            "Confirm Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If result = DialogResult.Yes Then
            Login_frm.Show()
            Hide()
        End If
    End Sub
End Class
