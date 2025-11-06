Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Globalization
Imports System.Windows.Controls

Public Class Team_Overview

    Private Sub Team_Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOtherEmployeeInfo()
        DisableAllTextboxes()
    End Sub

    ' Load all employee info into dgvOtherInfo
    Private Sub LoadOtherEmployeeInfo()
        Try
            Dim connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
            Using dbcon As New MySqlConnection(connectionString)
                dbcon.Open()

                Dim query As String = "
                SELECT
                    e.EmployeeID,
                    e.`First Name` AS FirstName,
                    e.MiddleName,
                    e.LastName,
                    e.BirthDate,
                    e.Age,
                    e.Sex,
                    e.`Civil Status` AS CivilStatus,
                    e.`Contact Number` AS ContactNumber,
                    e.`Email Address` AS EmailAddress,
                    e.Address,
                    ec.EmergencyContactID,
                    ec.Name AS EmergencyName,
                    ec.Relationship,
                    ec.PhoneNumber AS EmergencyPhone,
                    ec.Address AS EmergencyAddress,
                    a.UserID,
                    a.UserType,
                    j.JobID,
                    j.EmploymentStatus,
                    j.DateHired,
                    j.ContractType,
                    j.JobTitle,
                    j.YearsOfService,
                    d.DepartmentID,
                    d.Name AS DepartmentName
                FROM tblemployee e
                LEFT JOIN tblemergencycontact ec ON e.EmployeeID = ec.EmployeeID
                LEFT JOIN tblaccount a ON e.EmployeeID = a.EmployeeID
                LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                LEFT JOIN tbldepartment d ON j.DepartmentID = d.DepartmentID;
                "

                Dim adapter As New MySqlDataAdapter(query, dbcon)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvOtherInfo.DataSource = table
            End Using

            dgvOtherInfo.ScrollBars = ScrollBars.Both
            dgvOtherInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgvOtherInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.False
            dgvOtherInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvOtherInfo.DefaultCellStyle.Font = New Font("Century Gothic", 9, FontStyle.Regular)
            dgvOtherInfo.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)

        Catch ex As Exception
            MessageBox.Show("Error loading other info: " & ex.Message)
        End Try
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

    Private Sub EnableAllTextboxes()
        txtEmployeeID.Enabled = True
        txtFirstName.Enabled = True
        txtMiddleName.Enabled = True
        txtLastName.Enabled = True
        dtpBirthDate.Enabled = True
        txtAge.Enabled = True
        txtSex.Enabled = True
        txtCivilStatus.Enabled = True
        txtPhone.Enabled = True
        txtEmail.Enabled = True
        txtAddress.Enabled = True
        txtECContactID.Enabled = True
        txtECName.Enabled = True
        txtECRelationship.Enabled = True
        txtECPhone.Enabled = True
        txtECAddress.Enabled = True
        txtUserID.Enabled = True
        txtUserType.Enabled = True
        txtDepartmentID.Enabled = True
        txtDepartment.Enabled = True
        txtJobID.Enabled = True
        txtEmployeeStatus.Enabled = True
        dtpDateHired.Enabled = True
        txtContractType.Enabled = True
        txtJobTitle.Enabled = True
        txtYearsOfSevice.Enabled = True
    End Sub

    ' Populate textboxes from selected row
    Private Sub PopulateTextboxes(row As DataGridViewRow)
        If row Is Nothing Then Return

        Dim GetCellValue As Func(Of String, String) = Function(colName As String)
                                                          If row.DataGridView.Columns.Contains(colName) Then
                                                              Return If(row.Cells(colName)?.Value, "").ToString()
                                                          Else
                                                              Return ""
                                                          End If
                                                      End Function

        ' --- Employee Info ---
        txtEmployeeID.Text = GetCellValue("EmployeeID")
        txtFirstName.Text = GetCellValue("FirstName")
        txtMiddleName.Text = GetCellValue("MiddleName")
        txtLastName.Text = GetCellValue("LastName")

        Dim birthDate As DateTime
        If DateTime.TryParse(GetCellValue("BirthDate"), birthDate) Then
            dtpBirthDate.Value = birthDate
        Else
            dtpBirthDate.Value = DateTime.Now
        End If

        txtAge.Text = GetCellValue("Age")
        txtSex.Text = GetCellValue("Sex")
        txtCivilStatus.Text = GetCellValue("CivilStatus")
        txtPhone.Text = GetCellValue("ContactNumber")
        txtEmail.Text = GetCellValue("EmailAddress")
        txtAddress.Text = GetCellValue("Address")

        ' --- Emergency Contact ---
        txtECContactID.Text = GetCellValue("EmergencyContactID")
        txtECName.Text = GetCellValue("EmergencyName")
        txtECRelationship.Text = GetCellValue("Relationship")
        txtECPhone.Text = GetCellValue("EmergencyPhone")
        txtECAddress.Text = GetCellValue("EmergencyAddress")

        ' --- Account Info ---
        txtUserID.Text = GetCellValue("UserID")
        txtUserType.Text = GetCellValue("UserType")

        ' --- Job / Department Info ---
        txtDepartmentID.Text = GetCellValue("DepartmentID")
        txtDepartment.Text = GetCellValue("DepartmentName")
        txtJobID.Text = GetCellValue("JobID")
        txtEmployeeStatus.Text = GetCellValue("EmploymentStatus")

        Dim dateHired As DateTime
        If DateTime.TryParse(GetCellValue("DateHired"), dateHired) Then
            dtpDateHired.Value = dateHired
        Else
            dtpDateHired.Value = DateTime.Now
        End If

        txtContractType.Text = GetCellValue("ContractType")
        txtJobTitle.Text = GetCellValue("JobTitle")
        txtYearsOfSevice.Text = GetCellValue("YearsOfService")
    End Sub

    ' dgvOtherInfo click
    Private Sub dgvOtherInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOtherInfo.CellClick
        If e.RowIndex < 0 Then Return
        PopulateTextboxes(dgvOtherInfo.Rows(e.RowIndex))
    End Sub

    ' --- Live search on text change ---
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Dim searchValue As String = txtSearchEmployee.Text.Trim()

        ' Clear previous selection
        dgvOtherInfo.ClearSelection()

        If String.IsNullOrEmpty(searchValue) Then
            ' Reload all data if search box is empty
            LoadOtherEmployeeInfo()
            Return
        End If

        Dim found As Boolean = False
        Dim searchParts() As String = searchValue.Split(" "c, StringSplitOptions.RemoveEmptyEntries)

        For Each row As DataGridViewRow In dgvOtherInfo.Rows
            If Not row.IsNewRow Then
                Dim employeeID As String = row.Cells("EmployeeID").Value.ToString()
                Dim firstName As String = row.Cells("FirstName").Value.ToString()
                Dim lastName As String = row.Cells("LastName").Value.ToString()
                Dim fullName As String = $"{firstName} {lastName}"

                ' Check EmployeeID
                If employeeID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    row.Selected = True
                    found = True
                    Continue For
                End If

                ' Check full name or individual parts
                Dim nameMatch As Boolean = False
                If fullName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    nameMatch = True
                Else
                    For Each part In searchParts
                        If firstName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                           lastName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            nameMatch = True
                        End If
                    Next
                End If

                If nameMatch Then
                    row.Selected = True
                    found = True
                End If
            End If
        Next
    End Sub

    ' --- Navigation and exit code remains unchanged ---
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

    ' Exit
    Private Sub pcbTerminate_Click(sender As Object, e As EventArgs) Handles pcbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the system?",
                                                    "Confirm Exit",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)
        If result = DialogResult.Yes Then Application.Exit()
    End Sub

End Class
