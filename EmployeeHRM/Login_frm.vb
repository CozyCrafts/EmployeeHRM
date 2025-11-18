Imports MySql.Data.MySqlClient

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

        If password = "" Then
            MessageBox.Show("Password is required!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        If password.Length < 4 Then
            MessageBox.Show("Password must be at least 4 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        If selectedRole = "" Then
            MessageBox.Show("Please choose a User Type (Manager or Staff).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUserType.Focus()
            Return
        End If

        Try
            OpenCon()

            Dim query As String = "SELECT EmployeeID, Username, Password, UserType 
                                   FROM tblaccount 
                                   WHERE Username=@username AND Password=@password"

            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@username", username)
            dbcmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = dbcmd.ExecuteReader()

            If reader.Read() Then
                If reader("UserType").ToString() <> selectedRole Then
                    reader.Close()
                    MessageBox.Show("Selected User Type does not match the account's User Type!",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                LoggedInEmployeeID = reader("EmployeeID").ToString()
                LoggedInUsername = reader("Username").ToString()
                LoggedInUserType = reader("UserType").ToString()
                reader.Close()

                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Employee_Dashboard.Show()
                Me.Hide()

            Else
                reader.Close()
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
        End Try
    End Sub
    Public Sub ClearLoginFields()
        txtUsername.Text = ""
        txtPassword.Text = ""
        cbUserType.SelectedIndex = -1
    End Sub

    Private Sub btne_Click(sender As Object, e As EventArgs) Handles btne.Click
        Employee_Dashboard.Show()
        Me.Hide()
    End Sub
End Class
