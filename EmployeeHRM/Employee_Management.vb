Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Employee_Management
    Private Sub Employee_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None
        Try
            Call OpenCon()
            dbcmd.Connection = dbcon
            dbadapter = New MySqlDataAdapter("SELECT * FROM tblaccount", dbcon)
            dbtable = New DataTable
            dbadapter.Fill(dbtable)

            dgvAccount.DataSource = dbtable

            dbcon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call DisableFields()
        LoadUsers()
    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmployees_Click(sender As Object, e As EventArgs) Handles lblEmployees.Click
        Employee_Time_and_Attendancevb.Show()
        Me.Hide()
    End Sub

    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        LeaveManagement_frm.Show()
        Me.Hide()
    End Sub

    Private Sub SalaryProcessinglbl_Click(sender As Object, e As EventArgs) Handles SalaryProcessinglbl.Click
        SalaryProcessing_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Payslipslbl_Click(sender As Object, e As EventArgs) Handles Payslipslbl.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub SaveUser()
        Dim dbcon As MySqlConnection = HRMModule.GetConnection()
        Dim query As String = "INSERT INTO tblaccount (Fname, Mname, Lname, Suffix, Age, Sex, CivilStatus, BirthDate, Username, Password) 
                           VALUES (@Fname, @Mname, @Lname, @Suffix, @Age, @Sex, @CivilStatus, @BirthDate, @Username, @Password);"
        Try
            dbcon.Open()

            Using cmd As New MySqlCommand(query, dbcon)
                cmd.Parameters.AddWithValue("@Fname", txtFname.Text)
                cmd.Parameters.AddWithValue("@Mname", txtMname.Text)
                cmd.Parameters.AddWithValue("@Lname", txtLname.Text)

                If String.IsNullOrWhiteSpace(txtSuffix.Text) Then
                    cmd.Parameters.AddWithValue("@Suffix", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@Suffix", txtSuffix.Text)
                End If

                cmd.Parameters.AddWithValue("@Age", txtage.Text)
                cmd.Parameters.AddWithValue("@Sex", cmbSex.Text)
                cmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.Text)
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthdate.Value)
                cmd.Parameters.AddWithValue("@Username", txtUname.Text)
                cmd.Parameters.AddWithValue("@Password", txtPass.Text)

                cmd.ExecuteNonQuery()

                cmd.CommandText = "SELECT LAST_INSERT_ID()"
                Dim newEmployeeID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                LoadUsers()

                For Each row As DataGridViewRow In dgvAccount.Rows
                    If row.Cells("Suffix").Value Is DBNull.Value Then
                        row.Cells("Suffix").Value = " "
                    End If
                Next

                MessageBox.Show("User added successfully. New EmployeeID: " & newEmployeeID)
                DisableFields()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Private Sub LoadUsers()
        Try
            OpenCon()
            dbcon.Open()

            Dim query As String = "SELECT * FROM tblaccount"
            dbadapter = New MySqlDataAdapter(query, dbcon)
            dbtable = New DataTable()
            dbadapter.Fill(dbtable)

            dgvAccount.DataSource = dbtable

        Catch ex As MySqlException
            MessageBox.Show("Error loading data: " & ex.Message)
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


    Sub EnableFields()
        txtFname.Enabled = True
        txtMname.Enabled = True
        txtLname.Enabled = True
        txtSuffix.Enabled = True
        txtage.Enabled = True
        dtpBirthdate.Enabled = True
        cmbSex.Enabled = True
        cmbUser.Enabled = True
        cmbCivilStatus.Enabled = True
        txtUname.Enabled = True
        txtPass.Enabled = True

        btnSave.Visible = True
        btnCancel.Visible = True
        btnDelete.Visible = True
        btnAddEmployee.Visible = False
        btnEditEmployee.Visible = False
    End Sub

    Sub DisableFields()
        txtFname.Enabled = False
        txtMname.Enabled = False
        txtLname.Enabled = False
        txtSuffix.Enabled = False
        txtage.Enabled = False
        dtpBirthdate.Enabled = False
        cmbSex.Enabled = False
        cmbUser.Enabled = False
        cmbCivilStatus.Enabled = False
        txtUname.Enabled = False
        txtPass.Enabled = False

        btnSave.Visible = False
        btnCancel.Visible = False
        btnDelete.Visible = False
        btnAddEmployee.Visible = True
        btnEditEmployee.Visible = True
    End Sub

    Sub Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtSuffix.Clear()
        txtage.Clear()
        txtUname.Clear()
        txtPass.Clear()
        dtpBirthdate.Value = Date.Today
    End Sub


    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Call EnableFields()
        Call Clear()
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        DisableFields()
        Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Clear()
        LoadUsers()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveUser()
        Clear()
        LoadUsers()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call DisableFields()
        Call Clear()
    End Sub

End Class