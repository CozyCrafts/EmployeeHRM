Imports MySql.Data.MySqlClient
Module HRMModule
    Public dbCon As MySqlConnection

    Sub OpenCon()
        dbCon.ConnectionString = "server=localhost;username=root;password=;database=db_hrm"
        dbCon.Open()
    End Sub
End Module
