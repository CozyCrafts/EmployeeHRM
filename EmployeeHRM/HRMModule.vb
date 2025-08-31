Imports MySql.Data.MySqlClient
Module HRMModule
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Sub OpenCon()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=admin;database=db_hrm"
    End Sub
End Module
