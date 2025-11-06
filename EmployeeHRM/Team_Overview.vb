Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Globalization

Public Class Team_Overview

    Private Sub Team_Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
        LoadOtherEmployeeInfo()
        DisableAllTextboxes()
    End Sub

    Private Sub LoadEmployeeData()
        Try
            Dim connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()
                Dim query As String = "SELECT * FROM tblemployee"
                Dim adapter As New MySqlDataAdapter(query, dbcon)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAccount.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadOtherEmployeeInfo()
        Try
            Dim connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()

                Dim query As String = "
                    SELECT 
                        e.`EmployeeID`,
                        e.`First Name` AS FirstName,
                        e.`MiddleName`,
                        e.`LastName`,
                        e.`BirthDate`,
                        e.`Age`,
                        e.`Sex`,
                        e.`Civil Status` AS CivilStatus,
                        e.`Contact Number` AS ContactNumber,
                        e.`Email Address` AS EmailAddress,
                        e.`Address`,
                        ec.`EmergencyContactID` AS ContactID,
                        ec.`Name` AS EmergencyName,
                        ec.`Relationship`,
                        ec.`PhoneNumber` AS EmergencyPhone,
                        ec.`Address` AS EmergencyAddress,
                        a.`UserID`,
                        a.`UserType`,
                        d.`DepartmentID`,
                        d.`Name` AS DepartmentName,
                        j.`JobID`,
                        j.`EmploymentStatus`,
                        j.`DateHired`,
                        j.`ContractType`,
                        j.`JobTitle`,
                        j.`YearsOfService`
                    FROM `tblemployee` e
                    LEFT JOIN `tblemergencycontact` ec ON e.`EmployeeID` = ec.`EmployeeID`
                    LEFT JOIN `tblaccount` a ON e.`EmployeeID` = a.`EmployeeID`
                    LEFT JOIN `tbljobdetails` j ON e.`EmployeeID` = j.`EmployeeID`
                    LEFT JOIN `tbldepartment` d ON j.`DepartmentID` = d.`DepartmentID`;
                "

                Dim adapter As New MySqlDataAdapter(query, dbcon)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvOtherInfo.DataSource = table
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading other info: " & ex.Message)
        End Try

        dgvOtherInfo.ScrollBars = ScrollBars.Both
        dgvOtherInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvOtherInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dgvOtherInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvOtherInfo.DefaultCellStyle.Font = New Font("Century Gothic", 9, FontStyle.Regular)
        dgvOtherInfo.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
    End Sub

    Private Sub DisableAllTextboxes()
        txtEmployeeID.Enabled = False
        txtFirstName.Enabled = False
        txtMiddleName.Enabled = False
        txtLastName.Enabled = False
        dtpBirthDate.Enabled = False
        txtAge.Enabled = False
        txtSex.Enabled = False
        txtCivilStatus.Enabled = False
        txtPhone.Enabled = False
        txtEmail.Enabled = False
        txtAddress.Enabled = False
        txtECContactID.Enabled = False
        txtECName.Enabled = False
        txtECRelationship.Enabled = False
        txtECPhone.Enabled = False
        txtECAddress.Enabled = False
        txtUserID.Enabled = False
        txtUserType.Enabled = False
        txtDepartmentID.Enabled = False
        txtDepartment.Enabled = False
        txtJobID.Enabled = False
        txtEmployeeStatus.Enabled = False
        dtpDateHired.Enabled = False
        txtContractType.Enabled = False
        txtJobTitle.Enabled = False
        txtYearsOfSevice.Enabled = False
    End Sub
    Private Sub dgvOtherInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOtherInfo.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvOtherInfo.Rows(e.RowIndex)

        txtEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
        txtFirstName.Text = row.Cells("FirstName").Value.ToString()
        txtMiddleName.Text = row.Cells("MiddleName").Value.ToString()
        txtLastName.Text = row.Cells("LastName").Value.ToString()
        Dim birthDateStr As String = If(row.Cells("BirthDate").Value, "").ToString()
        Dim birthDate As DateTime
        If DateTime.TryParseExact(birthDateStr, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, birthDate) Then
            dtpBirthDate.Value = birthDate
        Else
            dtpBirthDate.Value = DateTime.Now
        End If
        txtAge.Text = row.Cells("Age").Value.ToString()
        txtSex.Text = row.Cells("Sex").Value.ToString()
        txtCivilStatus.Text = row.Cells("CivilStatus").Value.ToString()
        txtPhone.Text = row.Cells("ContactNumber").Value.ToString()
        txtEmail.Text = row.Cells("EmailAddress").Value.ToString()
        txtAddress.Text = row.Cells("Address").Value.ToString()
        txtECContactID.Text = row.Cells("ContactID").Value.ToString()
        txtECName.Text = row.Cells("EmergencyName").Value.ToString()
        txtECRelationship.Text = row.Cells("Relationship").Value.ToString()
        txtECPhone.Text = row.Cells("EmergencyPhone").Value.ToString()
        txtECAddress.Text = row.Cells("EmergencyAddress").Value.ToString()
        txtUserID.Text = row.Cells("UserID").Value.ToString()
        txtUserType.Text = row.Cells("UserType").Value.ToString()
        txtDepartmentID.Text = row.Cells("DepartmentID").Value.ToString()
        txtDepartment.Text = row.Cells("DepartmentName").Value.ToString()
        txtJobID.Text = row.Cells("JobID").Value.ToString()
        txtEmployeeStatus.Text = row.Cells("EmploymentStatus").Value.ToString()
        Dim dateHiredStr As String = If(row.Cells("DateHired").Value, "").ToString()
        Dim dateHired As DateTime
        If DateTime.TryParseExact(dateHiredStr, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dateHired) Then
            dtpDateHired.Value = dateHired
        Else
            dtpDateHired.Value = DateTime.Now
        End If

        txtContractType.Text = row.Cells("ContractType").Value.ToString()
        txtJobTitle.Text = row.Cells("JobTitle").Value.ToString()
        txtYearsOfSevice.Text = row.Cells("YearsOfService").Value.ToString()
    End Sub


    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Manager_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        MyProfile.Show()
        Hide()
    End Sub

    Private Sub lblAttendance_Click(sender As Object, e As EventArgs) Handles lblAttendance.Click
        Attendance.Show()
        Hide()
    End Sub

    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        Leave_Management.Show()
        Hide()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        Salary.Show()
        Me.Hide()
    End Sub

    Private Sub lblTrainings_Click(sender As Object, e As EventArgs) Handles lblTrainings.Click
        Trainings.Show()
        Me.Hide()
    End Sub

    Private Sub lblTeamOverview_Click(sender As Object, e As EventArgs) Handles lblTeamOverview.Click
        lblTeamOverview.Enabled = False
    End Sub

    Private Sub lblAttandanceTracker_Click(sender As Object, e As EventArgs) Handles lblAttandanceTracker.Click
        Attendance_Tracker.Show()
        Me.Hide()
    End Sub

    Private Sub lblLeaveApproval_Click(sender As Object, e As EventArgs) Handles lblLeaveApproval.Click
        Leave_Approval.Show()
        Me.Hide()
    End Sub

    Private Sub lblPayrollSummary_Click(sender As Object, e As EventArgs) Handles lblPayrollSummary.Click
        Payroll_Summary.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmployeeTrainings_Click(sender As Object, e As EventArgs) Handles lblEmployeeTrainings.Click
        Employee_Trainings.Show()
        Me.Hide()
    End Sub

    Private Sub lblDepartment_Click(sender As Object, e As EventArgs) Handles lblDepartment.Click
        Department.Show()
        Me.Hide()
    End Sub

    Private Sub lblAmenities_Click(sender As Object, e As EventArgs) Handles lblAmenities.Click
        Amenities.Show()
        Me.Hide()
    End Sub

    Private Sub pcbTerminate_Click(sender As Object, e As EventArgs) Handles pcbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the system?",
                                                "Confirm Exit",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
