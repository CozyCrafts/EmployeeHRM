Imports MySql.Data.MySqlClient

Module HRMModule
    Public dbcon As MySqlConnection
    Public dbcmd As New MySqlCommand
    Public dbadapter As MySqlDataAdapter
    Public dbtable As DataTable


    Sub OpenCon()
        dbcon = New MySqlConnection
        dbcon.ConnectionString = "server=localhost;userid=root;password=091951;database=db_hrm"
    End Sub


    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=admin;database=db_hrm")
    End Function

End Module
