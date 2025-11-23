Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms

Module HRMModule

    Public Class LoggedInUser
        Public Property EmployeeID As String
        Public Property Username As String
        Public Property UserType As String
    End Class

    Public CurrentUser As New LoggedInUser()

    Public LoginFormInstance As Login_frm

    Private Function GetConnectionString() As String
        Dim cs = ConfigurationManager.ConnectionStrings("HRMDb")?.ConnectionString
        If String.IsNullOrEmpty(cs) Then
            MessageBox.Show("Database connection string 'HRMDb' is missing. Please configure app.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return cs
    End Function


    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(GetConnectionString())
    End Function

    Public Function ExecuteQuery(query As String, Optional params As List(Of MySqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New MySqlConnection(GetConnectionString())
                Using cmd As New MySqlCommand(query, conn)
                    If params?.Count > 0 Then cmd.Parameters.AddRange(params.ToArray())
                    conn.Open()
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("A database error occurred. Please contact admin.")
        End Try
        Return dt
    End Function

    Public Function ExecuteNonQuery(query As String, Optional params As List(Of MySqlParameter) = Nothing) As Integer
        Try
            Using conn As New MySqlConnection(GetConnectionString())
                Using cmd As New MySqlCommand(query, conn)
                    If params?.Count > 0 Then cmd.Parameters.AddRange(params.ToArray())
                    conn.Open()
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("A database error occurred.")
            Return -1
        End Try
    End Function

    Public Function ExecuteScalar(query As String, Optional params As List(Of MySqlParameter) = Nothing) As Object
        Try
            Using conn As New MySqlConnection(GetConnectionString())
                Using cmd As New MySqlCommand(query, conn)
                    If params?.Count > 0 Then cmd.Parameters.AddRange(params.ToArray())
                    conn.Open()
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("A database error occurred.")
            Return Nothing
        End Try
    End Function

    Public Sub SignOut(currentForm As Form)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then Return

        CurrentUser = New LoggedInUser()
        If LoginFormInstance Is Nothing OrElse LoginFormInstance.IsDisposed Then
            LoginFormInstance = New Login_frm()
        End If
        If LoginFormInstance IsNot Nothing Then
            LoginFormInstance.ClearLoginFields()
            LoginFormInstance.Show()
        End If

        currentForm.Close()
        MessageBox.Show("You have been signed out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Module
