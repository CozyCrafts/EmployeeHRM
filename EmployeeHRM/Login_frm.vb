Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Login_frm
    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            OpenCon()
            dbcon.Open()

            Dim hashedPassword As String = HashPassword(txtPass.Text)

            Dim query As String = "SELECT UserType FROM tblaccount WHERE Username=@Username AND Password=@Password"
            Dim cmd As New MySqlCommand(query, dbcon)
            cmd.Parameters.AddWithValue("@Username", txtUname.Text)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim userType As String = reader("UserType").ToString()

                If userType = "Manager" Then
                    Admin_frm.Show()
                    Me.Hide()
                ElseIf userType = "Staff" Then
                    Employee_Dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Select a valid role", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUname.Clear()
                txtPass.Clear()
                cmbRole.SelectedIndex = -1
            End If

            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
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
End Class