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
        LoadEmployee()

        txtPass.UseSystemPasswordChar = True
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

    Private Sub SaveEmployee()
        Dim dbcon As MySqlConnection = HRMModule.GetConnection()
        Dim query As String = "INSERT INTO tblaccount (Fname, Mname, Lname, Suffix, Age, Sex, CivilStatus, BirthDate, UserType, Username, Password) 
                           VALUES (@Fname, @Mname, @Lname, @Suffix, @Age, @Sex, @CivilStatus, @BirthDate, @UserType, @Username, @Password);"
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
                cmd.Parameters.AddWithValue("@UserType", cmbUser.Text)
                cmd.Parameters.AddWithValue("@Username", txtUname.Text)
                cmd.Parameters.AddWithValue("@Password", HashPassword(txtPass.Text))

                cmd.ExecuteNonQuery()

                cmd.CommandText = "SELECT LAST_INSERT_ID()"
                Dim newEmployeeID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                LoadEmployee()

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

    Private Sub UpdateEmployee()
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to update.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvAccount.SelectedRows(0)
        Dim employeeID As Integer = Convert.ToInt32(selectedRow.Cells("EmployeeID").Value)

        Dim dbcon As MySqlConnection = HRMModule.GetConnection()
        Dim query As String = "UPDATE tblaccount 
                           SET Fname = @Fname, 
                               Mname = @Mname, 
                               Lname = @Lname, 
                               Suffix = @Suffix, 
                               Age = @Age, 
                               Sex = @Sex, 
                               CivilStatus = @CivilStatus, 
                               BirthDate = @BirthDate, 
                               UserType = @UserType,
                               Username = @Username, 
                               Password = @Password
                           WHERE EmployeeID = @EmployeeID;"

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
                cmd.Parameters.AddWithValue("@UserType", cmbUser.Text)
                cmd.Parameters.AddWithValue("@Username", txtUname.Text)
                cmd.Parameters.AddWithValue("@Password", HashPassword(txtPass.Text))
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    LoadEmployee()
                    For Each row As DataGridViewRow In dgvAccount.Rows
                        If row.Cells("Suffix").Value Is DBNull.Value Then
                            row.Cells("Suffix").Value = " "
                        End If
                    Next
                    MessageBox.Show("User updated successfully.")
                    DisableFields()
                Else
                    MessageBox.Show("No record updated. Please check EmployeeID.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub


    Private Sub LoadEmployee()
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
        btnUpdate.Visible = False
        btnAddEmployee.Visible = True
        btnEditEmployee.Visible = True
    End Sub

    Sub Clear()
        lblID.Text = ""
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtSuffix.Clear()
        txtage.Clear()
        cmbCivilStatus.SelectedIndex = -1
        cmbSex.SelectedIndex = -1
        cmbUser.SelectedIndex = -1
        txtUname.Clear()
        txtPass.Clear()
        dtpBirthdate.Value = Date.Today
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        EnableFields()
        Clear()
        btnSave.Visible = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
        btnCancel.Visible = True
        btnAddEmployee.Visible = False
        btnEditEmployee.Visible = False
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        EnableFields()
        Clear()
        btnSave.Visible = False
        btnUpdate.Visible = True
        btnDelete.Visible = True
        btnCancel.Visible = True
        btnAddEmployee.Visible = False
        btnEditEmployee.Visible = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Clear()
        LoadEmployee()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveEmployee()
        Clear()
        LoadEmployee()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableFields()
        Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateEmployee()
        Clear()
        LoadEmployee()
    End Sub

    Private Sub dgvAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvAccount.Rows(e.RowIndex)

        lblID.Text = row.Cells("EmployeeID").Value.ToString()
        txtFname.Text = row.Cells("Fname").Value.ToString()
        txtMname.Text = row.Cells("Mname").Value.ToString()
        txtLname.Text = row.Cells("Lname").Value.ToString()

        If IsDBNull(row.Cells("Suffix").Value) Then
            txtSuffix.Clear()
        Else
            txtSuffix.Text = row.Cells("Suffix").Value.ToString()
        End If

        txtage.Text = row.Cells("Age").Value.ToString()
        cmbSex.Text = row.Cells("Sex").Value.ToString()
        cmbCivilStatus.Text = row.Cells("CivilStatus").Value.ToString()

        If Not IsDBNull(row.Cells("BirthDate").Value) Then
            dtpBirthdate.Value = Convert.ToDateTime(row.Cells("BirthDate").Value)
        End If

        cmbUser.Text = row.Cells("UserType").Value.ToString()
        txtUname.Text = row.Cells("Username").Value.ToString()
        txtPass.Text = row.Cells("Password").Value.ToString()
    End Sub

End Class