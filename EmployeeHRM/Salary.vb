Imports MySql.Data.MySqlClient

Public Class Salary
    Private salaryTable As DataTable = Nothing
    Private salaryBindingSource As BindingSource

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentUser.UserType = "Staff" Then
            lblManagement.Visible = False
            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If
        LoadSalarySummary()
        LockFields()
    End Sub
    Private Sub LoadSalarySummary()
        Dim query As String = "
            SELECT 
                e.EmployeeID,
                CONCAT_WS(' ', e.`First Name`, e.MiddleName, e.LastName) AS EmployeeName,
                j.JobTitle,
                p.PayrollID,
                p.BasicSalary AS PayrollBasicSalary,
                p.OvertimePay AS PayrollOvertimePay,
                p.GrossSalary AS PayrollGrossSalary,
                p.NetPay AS PayrollNetPay,
                p.PaymentDate AS PayrollPaymentDate,
                s.SalaryID AS SalaryID,
                s.BaseSalary AS SalaryBaseSalary,
                s.Allowance AS SalaryAllowance,
                s.DailyRate AS SalaryDailyRate,
                s.OvertimeRate AS SalaryOvertimeRate,
                a.AttendanceID AS AttendanceID,
                a.TotalHours AS AttendanceTotalHours,
                a.ExceededHours AS AttendanceExceededHours,
                a.DaysAttended AS AttendanceDaysAttended,
                a.Absences AS AttendanceAbsences,
                d.DeductionID AS DeductionID,
                d.UnpaidLeave AS DeductionUnpaidLeave,
                d.SSS AS DeductionSSS,
                d.PagIBIG AS DeductionPagIBIG,
                d.PhilHealth AS DeductionPhilHealth,
                d.TotalDeduction AS DeductionTotalDeduction
            FROM tblemployee e
            LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
            LEFT JOIN tblpayroll p ON e.EmployeeID = p.EmployeeID
            LEFT JOIN tblsalary s ON e.EmployeeID = s.EmployeeID
            LEFT JOIN tblattendance a ON e.EmployeeID = a.EmployeeID
            LEFT JOIN tbldeduction d ON e.EmployeeID = d.EmployeeID
            WHERE e.EmployeeID = @empID
            ORDER BY p.PaymentDate DESC;
        "

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@empID", HRMModule.CurrentUser.EmployeeID)
        }

        Try
            salaryTable = HRMModule.ExecuteQuery(query, parameters)
            salaryBindingSource = New BindingSource()
            salaryBindingSource.DataSource = salaryTable
            dgvSalaryHistory.DataSource = salaryBindingSource

            dgvSalaryHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvSalaryHistory.RowTemplate.Height = 30
            dgvSalaryHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        Catch ex As Exception
            MessageBox.Show("Error loading salary summary. Please contact admin.")
        End Try
    End Sub
    Private Sub LockFields()
        txtEmployeeID.ReadOnly = True
        txtEmployeeName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtPayrollID.ReadOnly = True
        txtBasicSalary.ReadOnly = True
        txtOvertimePay.ReadOnly = True
        txtGrossSalary.ReadOnly = True
        txtNetPay.ReadOnly = True
        dtpPaymentDate.Enabled = False
        txtBaseSalary.ReadOnly = True
        txtAllowance.ReadOnly = True
        txtDailyRate.ReadOnly = True
        txtOvertimeRate.ReadOnly = True
        txtAttendanceID.ReadOnly = True
        txtTotalHours.ReadOnly = True
        txtExceededHours.ReadOnly = True
        txtDaysAttended.ReadOnly = True
        txtAbsences.ReadOnly = True
        txtDeductionID.ReadOnly = True
        txtUnpaidLeave.ReadOnly = True
        txtSSS.ReadOnly = True
        txtPhilHealth.ReadOnly = True
        txtPagIBIG.ReadOnly = True
        txtTotalDeduction.ReadOnly = True
        rbSalarySent.Enabled = False
    End Sub
    Private Sub dgvSalaryHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalaryHistory.CellClick
        If e.RowIndex >= 0 Then
            PopulateFieldsFromSelectedRow(e.RowIndex)
        End If
    End Sub
    Private Sub PopulateFieldsFromSelectedRow(rowIndex As Integer)
        Dim row As DataGridViewRow = dgvSalaryHistory.Rows(rowIndex)

        txtEmployeeID.Text = row.Cells("EmployeeID").Value?.ToString()
        txtEmployeeName.Text = row.Cells("EmployeeName").Value?.ToString()
        txtJobTitle.Text = row.Cells("JobTitle").Value?.ToString()
        txtPayrollID.Text = row.Cells("PayrollID").Value?.ToString()
        txtBasicSalary.Text = row.Cells("PayrollBasicSalary").Value?.ToString()
        txtOvertimePay.Text = row.Cells("PayrollOvertimePay").Value?.ToString()
        txtGrossSalary.Text = row.Cells("PayrollGrossSalary").Value?.ToString()
        txtNetPay.Text = row.Cells("PayrollNetPay").Value?.ToString()

        Dim paymentDate As DateTime
        If row.Cells("PayrollPaymentDate").Value IsNot DBNull.Value AndAlso DateTime.TryParse(row.Cells("PayrollPaymentDate").Value.ToString(), paymentDate) Then
            dtpPaymentDate.Value = paymentDate

            Dim lastDayOfMonth As DateTime = New DateTime(paymentDate.Year, paymentDate.Month, DateTime.DaysInMonth(paymentDate.Year, paymentDate.Month))
            rbSalarySent.Checked = (paymentDate.Date = lastDayOfMonth)
        Else
            dtpPaymentDate.Value = DateTime.Today
            rbSalarySent.Checked = False
        End If

        txtBaseSalary.Text = row.Cells("SalaryBaseSalary").Value?.ToString()
        txtAllowance.Text = row.Cells("SalaryAllowance").Value?.ToString()
        txtDailyRate.Text = row.Cells("SalaryDailyRate").Value?.ToString()
        txtOvertimeRate.Text = row.Cells("SalaryOvertimeRate").Value?.ToString()
        txtAttendanceID.Text = row.Cells("AttendanceID").Value?.ToString()
        txtTotalHours.Text = row.Cells("AttendanceTotalHours").Value?.ToString()
        txtExceededHours.Text = row.Cells("AttendanceExceededHours").Value?.ToString()
        txtDaysAttended.Text = row.Cells("AttendanceDaysAttended").Value?.ToString()
        txtAbsences.Text = row.Cells("AttendanceAbsences").Value?.ToString()
        txtDeductionID.Text = row.Cells("DeductionID").Value?.ToString()
        txtUnpaidLeave.Text = row.Cells("DeductionUnpaidLeave").Value?.ToString()
        txtSSS.Text = row.Cells("DeductionSSS").Value?.ToString()
        txtPhilHealth.Text = row.Cells("DeductionPhilHealth").Value?.ToString()
        txtPagIBIG.Text = row.Cells("DeductionPagIBIG").Value?.ToString()
        txtTotalDeduction.Text = row.Cells("DeductionTotalDeduction").Value?.ToString()
    End Sub
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Employee_Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        MyProfile.Show()
        Me.Hide()
    End Sub
    Private Sub lblAttendance_Click(sender As Object, e As EventArgs) Handles lblAttendance.Click
        Attendance.Show()
        Me.Hide()
    End Sub
    Private Sub lblLeaveManagement_Click(sender As Object, e As EventArgs) Handles lblLeaveManagement.Click
        Leave_Management.Show()
        Me.Hide()
    End Sub
    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        lblSalary.Enabled = False
    End Sub
    Private Sub lblTrainings_Click(sender As Object, e As EventArgs) Handles lblTrainings.Click
        Trainings.Show()
        Me.Hide()
    End Sub
    Private Sub lblTeamOverview_Click(sender As Object, e As EventArgs) Handles lblTeamOverview.Click
        Team_Overview.Show()
        Me.Hide()
    End Sub
    Private Sub lblAttendanceTracker_Click(sender As Object, e As EventArgs) Handles lblAttendanceTracker.Click
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


    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        HRMModule.SignOut(Me)
    End Sub

End Class
