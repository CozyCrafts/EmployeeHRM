
Imports MySql.Data.MySqlClient

Public Class Login_frm
    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenCon() ' Open database connection

            Dim query As String = "SELECT employee_id, username, role FROM employees WHERE username = @username AND password = @password"
            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@username", username)
            dbcmd.Parameters.AddWithValue("@password", password) ' Use hashed passwords in production

            Dim reader As MySqlDataReader = dbcmd.ExecuteReader()

            If reader.Read() Then
                ' --- Successful login ---
                LoggedInEmployeeID = reader("employee_id").ToString()
                LoggedInUsername = reader("username").ToString()
                LoggedInRole = reader("role").ToString()

                reader.Close()

                ' Open the single dashboard
                Employee_Dashboard.UserRole = LoggedInRole
                Employee_Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    Private Sub btne_Click(sender As Object, e As EventArgs) Handles btne.Click
        Employee_Dashboard.Show()
        Me.Hide()

    End Sub
End Class