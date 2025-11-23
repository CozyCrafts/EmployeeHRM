Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class Login_frm

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim selectedRole As String = If(cbUserType.SelectedItem?.ToString(), "")

        If username = "" Then
            MessageBox.Show("Username is required!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If
        If password = "" OrElse password.Length < 4 Then
            MessageBox.Show("Password is required and must be at least 4 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If
        If selectedRole = "" Then
            MessageBox.Show("Please choose a User Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUserType.Focus()
            Return
        End If

        Dim query As String = "SELECT EmployeeID, Username, Password, UserType 
                               FROM tblaccount 
                               WHERE Username=@username AND Password=@password"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@username", username),
            New MySqlParameter("@password", password)
        }

        Dim dt As DataTable = HRMModule.ExecuteQuery(query, parameters)

        If dt.Rows.Count = 1 Then
            Dim row = dt.Rows(0)

            If row("UserType").ToString() <> selectedRole Then
                MessageBox.Show("Selected User Type does not match the account's User Type!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            HRMModule.CurrentUser.EmployeeID = row("EmployeeID").ToString()
            HRMModule.CurrentUser.Username = row("Username").ToString()
            HRMModule.CurrentUser.UserType = row("UserType").ToString()

            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim dashboard As New Employee_Dashboard()
            dashboard.Show()

            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub ClearLoginFields()
        If txtUsername IsNot Nothing Then txtUsername.Text = ""
        If txtPassword IsNot Nothing Then txtPassword.Text = ""
        If cbUserType IsNot Nothing Then cbUserType.SelectedIndex = -1
    End Sub

End Class
