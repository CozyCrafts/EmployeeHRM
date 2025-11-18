Imports MySql.Data.MySqlClient

Module HRMModule
    Public LoggedInEmployeeID As String
    Public LoggedInUsername As String
    Public LoggedInUserType As String

    Public dbcon As MySqlConnection
    Public dbcmd As MySqlCommand
    Public dbadapter As MySqlDataAdapter
    Public dbtable As DataTable

    Sub OpenCon()
        If dbcon Is Nothing Then
            dbcon = New MySqlConnection("server=localhost;userid=root;password=091951;database=db_hrm")
        End If

        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
    End Sub

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=091951;database=db_hrm")
    End Function

End Module
