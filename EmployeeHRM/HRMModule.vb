Imports MySql.Data.MySqlClient
Module HRMModule
    Dim dbcon As MySqlConnection
    Dim dbcmd As New MySqlCommand
    Dim dbadapter As MySqlDataAdapter
    Dim dbtable As DataTable

    Sub OpenCon()
        dbcon = New MySqlConnection
        dbcon.ConnectionString = "server=localhost;userid=root;password=admin;database=db_hrm"
    End Sub

End Module
