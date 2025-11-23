Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class MyProfile

    Private LoggedInUserID As String = HRMModule.CurrentUser.EmployeeID
    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If HRMModule.CurrentUser.UserType = "Staff" Then
            lblManagement.Visible = False
            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If

        LoadMyProfile()
    End Sub
    Private Sub LockAllFields()
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
        txtECContactID.Enabled = False
        txtECName.ReadOnly = True
        txtECRelationship.ReadOnly = True
        txtECPhone.ReadOnly = True
        txtECAddress.ReadOnly = True
        txtUserID.Enabled = False
        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
        cbUserType.Enabled = False
        txtJobID.Enabled = False
        txtJobTitle.ReadOnly = True
        txtYearsOfSevice.ReadOnly = True
        cbContractType.Enabled = False
        cbEmployeeStatus.Enabled = False
        dtpDateHired.Enabled = False
        txtDepartmentID.Enabled = False
        txtDepartment.ReadOnly = True
    End Sub
    Private Sub LoadMyProfile()
        Try
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

            Dim dt As DataTable = HRMModule.ExecuteQuery(query, New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", LoggedInUserID)
            })

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)

                txtEmployeeID.Text = row("EmployeeID").ToString()
                txtFirstName.Text = row("First Name").ToString()
                txtMiddleName.Text = row("MiddleName").ToString()
                txtLastName.Text = row("LastName").ToString()
                txtAddress.Text = row("Address").ToString()
                txtPhone.Text = row("Contact Number").ToString()
                txtEmail.Text = row("Email Address").ToString()
                txtAge.Text = row("Age").ToString()
                cbSex.Text = row("Sex").ToString()
                cbCivilStatus.Text = row("Civil Status").ToString()

                If Not IsDBNull(row("BirthDate")) Then dtpBirthDate.Value = CDate(row("BirthDate"))

                txtJobID.Text = If(row("JobID") IsNot DBNull.Value, row("JobID").ToString(), "")
                txtJobTitle.Text = If(row("JobTitle") IsNot DBNull.Value, row("JobTitle").ToString(), "")
                txtYearsOfSevice.Text = If(row("YearsOfService") IsNot DBNull.Value, row("YearsOfService").ToString(), "")
                cbContractType.Text = If(row("ContractType") IsNot DBNull.Value, row("ContractType").ToString(), "")
                cbEmployeeStatus.Text = If(row("EmploymentStatus") IsNot DBNull.Value, row("EmploymentStatus").ToString(), "")
                If Not IsDBNull(row("DateHired")) Then dtpDateHired.Value = CDate(row("DateHired"))
                txtDepartmentID.Text = If(row("DepartmentID") IsNot DBNull.Value, row("DepartmentID").ToString(), "")
                txtDepartment.Text = If(row("DepartmentName") IsNot DBNull.Value, row("DepartmentName").ToString(), "")

                txtUserID.Text = If(row("UserID") IsNot DBNull.Value, row("UserID").ToString(), "")
                txtUsername.Text = If(row("Username") IsNot DBNull.Value, row("Username").ToString(), "")
                txtPassword.Text = If(row("Password") IsNot DBNull.Value, row("Password").ToString(), "")
                cbUserType.Text = If(row("UserType") IsNot DBNull.Value, row("UserType").ToString(), "")

                txtECContactID.Text = If(row("EmergencyContactID") IsNot DBNull.Value, row("EmergencyContactID").ToString(), "")
                txtECName.Text = If(row("ECName") IsNot DBNull.Value, row("ECName").ToString(), "")
                txtECAddress.Text = If(row("ECAddress") IsNot DBNull.Value, row("ECAddress").ToString(), "")
                txtECPhone.Text = If(row("ECPhone") IsNot DBNull.Value, row("ECPhone").ToString(), "")
                txtECRelationship.Text = If(row("ECRelationship") IsNot DBNull.Value, row("ECRelationship").ToString(), "")
            End If

            LockAllFields()

        Catch ex As Exception
            MessageBox.Show("Error loading profile. Please contact admin.")
        End Try
    End Sub
    Private Sub btnEditContact_Click(sender As Object, e As EventArgs) Handles btnEditContact.Click
        txtECName.ReadOnly = False
        txtECRelationship.ReadOnly = False
        txtECPhone.ReadOnly = False
        txtECAddress.ReadOnly = False
        btnEditContact.Visible = False
        btnSaveContact.Visible = True
        btnCancelContact.Visible = True
    End Sub
    Private Sub btnCancelContact_Click(sender As Object, e As EventArgs) Handles btnCancelContact.Click
        txtECName.ReadOnly = True
        txtECRelationship.ReadOnly = True
        txtECPhone.ReadOnly = True
        txtECAddress.ReadOnly = True
        btnEditContact.Visible = True
        btnSaveContact.Visible = False
        btnCancelContact.Visible = False
        LoadMyProfile()
    End Sub
    Private Sub btnSaveContact_Click(sender As Object, e As EventArgs) Handles btnSaveContact.Click
        Try
            If String.IsNullOrWhiteSpace(txtECName.Text) OrElse
               String.IsNullOrWhiteSpace(txtECRelationship.Text) OrElse
               String.IsNullOrWhiteSpace(txtECPhone.Text) OrElse
               String.IsNullOrWhiteSpace(txtECAddress.Text) Then
                MessageBox.Show("All emergency contact fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "
                UPDATE tblemergencycontact
                SET Name=@name, Relationship=@rel, PhoneNumber=@phone, Address=@addr
                WHERE EmployeeID=@id
            "

            Dim rows = HRMModule.ExecuteNonQuery(query, New List(Of MySqlParameter) From {
                New MySqlParameter("@name", txtECName.Text),
                New MySqlParameter("@rel", txtECRelationship.Text),
                New MySqlParameter("@phone", txtECPhone.Text),
                New MySqlParameter("@addr", txtECAddress.Text),
                New MySqlParameter("@id", LoggedInUserID)
            })

            If rows > 0 Then MessageBox.Show("Emergency contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LockAllFields()
            btnEditContact.Visible = True
            btnSaveContact.Visible = False
            btnCancelContact.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error saving emergency contact info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        txtUsername.ReadOnly = False
        txtPassword.ReadOnly = False
        cbUserType.Enabled = False
        btnEditAccount.Visible = False
        btnSaveAccount.Visible = True
        btnCancelAccount.Visible = True
    End Sub
    Private Sub btnCancelAccount_Click(sender As Object, e As EventArgs) Handles btnCancelAccount.Click
        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
        cbUserType.Enabled = False
        btnEditAccount.Visible = True
        btnSaveAccount.Visible = False
        btnCancelAccount.Visible = False
        LoadMyProfile()
    End Sub
    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        Try
            If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(cbUserType.Text) Then
                MessageBox.Show("All account fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "
                UPDATE tblaccount 
                SET Username=@user, Password=@pass, UserType=@type
                WHERE EmployeeID=@id
            "

            Dim rows = HRMModule.ExecuteNonQuery(query, New List(Of MySqlParameter) From {
                New MySqlParameter("@user", txtUsername.Text),
                New MySqlParameter("@pass", txtPassword.Text),
                New MySqlParameter("@type", cbUserType.Text),
                New MySqlParameter("@id", LoggedInUserID)
            })

            If rows > 0 Then MessageBox.Show("Account info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.ReadOnly = True
            txtPassword.ReadOnly = True
            cbUserType.Enabled = False
            btnEditAccount.Visible = True
            btnSaveAccount.Visible = False
            btnCancelAccount.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error saving account info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        cbCivilStatus.Enabled = True
        txtPhone.ReadOnly = False
        txtEmail.ReadOnly = False
        txtAddress.ReadOnly = False
        btnEditInfo.Visible = False
        btnSaveInfo.Visible = True
        btnCancelInfo.Visible = True
    End Sub
    Private Sub btnCancelInfo_Click(sender As Object, e As EventArgs) Handles btnCancelInfo.Click
        cbCivilStatus.Enabled = False
        txtPhone.ReadOnly = True
        txtEmail.ReadOnly = True
        txtAddress.ReadOnly = True
        btnEditInfo.Visible = True
        btnSaveInfo.Visible = False
        btnCancelInfo.Visible = False
        LoadMyProfile()
    End Sub
    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click
        Try
            If String.IsNullOrWhiteSpace(cbCivilStatus.Text) OrElse String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
               String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtAddress.Text) Then
                MessageBox.Show("All personal info fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "
                UPDATE tblemployee 
                SET `Civil Status`=@civil, `Contact Number`=@phone, `Email Address`=@mail, Address=@addr
                WHERE EmployeeID=@id
            "

            Dim rows = HRMModule.ExecuteNonQuery(query, New List(Of MySqlParameter) From {
                New MySqlParameter("@civil", cbCivilStatus.Text),
                New MySqlParameter("@phone", txtPhone.Text),
                New MySqlParameter("@mail", txtEmail.Text),
                New MySqlParameter("@addr", txtAddress.Text),
                New MySqlParameter("@id", LoggedInUserID)
            })

            If rows > 0 Then MessageBox.Show("Personal info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LockAllFields()
            btnEditInfo.Visible = True
            btnSaveInfo.Visible = False
            btnCancelInfo.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error saving personal info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            HRMModule.SignOut(Me)
            MessageBox.Show("You have been signed out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
