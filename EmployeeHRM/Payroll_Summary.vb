Imports MySql.Data.MySqlClient
Public Class Payroll_Summary
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"

    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayrollSummary()
        LockControls()
    End Sub

    Private Sub UnlockControls()
        ' Payroll fields editable
        txtBasicSalary.ReadOnly = False
        txtOvertimePay.ReadOnly = False
        txtGrossSalary.ReadOnly = False
        txtNetPay.ReadOnly = False
        dtpPaymentDate.Enabled = True

        ' Salary fields editable if needed
        txtBaseSalary.ReadOnly = False
        txtAllowance.ReadOnly = False
        txtDailyRate.ReadOnly = False
        txtOvertimeRate.ReadOnly = False

        ' Deduction fields editable
        txtSSS.ReadOnly = False
        txtPhilHealth.ReadOnly = False
        txtPagIBIG.ReadOnly = False
        txtUnpaidLeave.ReadOnly = False
        dtpDateApplied.Enabled = True

        ' Attendance editable
        txtAbscences.ReadOnly = False

        ' IDs remain readonly
        cbEmployeeID.Enabled = False
        txtEmployeeName.ReadOnly = True
        txtPayrollID.ReadOnly = True
        txtSalaryID.ReadOnly = True
        txtJobID.ReadOnly = True
        txtDeductionID.ReadOnly = True
        txtAttendanceID.ReadOnly = True
        txtTotalDeduction.ReadOnly = True  ' Still locked even when editing
        txtJobTitle.ReadOnly = True
    End Sub
    Private Sub LockControls()
        cbEmployeeID.Enabled = False
        txtEmployeeName.ReadOnly = True
        txtPayrollID.ReadOnly = True
        txtBasicSalary.ReadOnly = True
        txtOvertimePay.ReadOnly = True
        txtGrossSalary.ReadOnly = True
        txtNetPay.ReadOnly = True
        dtpPaymentDate.Enabled = False
        txtSalaryID.ReadOnly = True
        txtJobID.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtBaseSalary.ReadOnly = True
        txtAllowance.ReadOnly = True
        txtDailyRate.ReadOnly = True
        txtOvertimeRate.ReadOnly = True
        txtDeductionID.ReadOnly = True
        txtAttendanceID.ReadOnly = True
        txtAbscences.ReadOnly = True
        txtUnpaidLeave.ReadOnly = True
        dtpDateApplied.Enabled = False
        txtTotalDeduction.ReadOnly = True
        txtSSS.ReadOnly = True
        txtPhilHealth.ReadOnly = True
        txtPagIBIG.ReadOnly = True
    End Sub
    Private Sub LoadPayrollSummary()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                SELECT 
                    e.EmployeeID,
                    CONCAT_WS(' ', e.`First Name`, e.MiddleName, e.LastName) AS EmployeeName,
                    j.JobTitle,
                    p.PayrollID,
                    p.BasicSalary AS PayrollBasicSalary,
                    p.OvertimePay,
                    p.GrossSalary,
                    p.NetPay,
                    p.PaymentDate,
                    s.SalaryID,
                    s.BaseSalary AS SalaryBaseSalary,
                    s.Allowance,
                    s.DailyRate,
                    s.OvertimeRate,
                    j.JobID,
                    d.DeductionID,
                    d.SSS,
                    d.PhilHealth,
                    d.PagIBIG,
                    d.UnpaidLeave,
                    d.DateApplied AS DeductionDate,
                    d.TotalDeduction,
                    a.AttendanceID,
                    a.Absences
                FROM tblemployee e
                LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID
                LEFT JOIN tbldeduction d ON e.EmployeeID = d.EmployeeID
                LEFT JOIN tblattendance a ON e.EmployeeID = a.EmployeeID
                LEFT JOIN tblsalary s ON e.EmployeeID = s.EmployeeID
                LEFT JOIN tblpayroll p ON e.EmployeeID = p.EmployeeID
                ORDER BY e.EmployeeID;
            "
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        payrollTable = New DataTable()
                        adapter.Fill(payrollTable)
                        dgvPayrollSummary.DataSource = payrollTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payroll summary: " & ex.Message)
        End Try
    End Sub

    Private payrollTable As DataTable = Nothing

    Private Sub CalculateTotalDeduction()
        Dim sss As Decimal = Val(txtSSS.Text)
        Dim philhealth As Decimal = Val(txtPhilHealth.Text)
        Dim pagibig As Decimal = Val(txtPagIBIG.Text)
        Dim unpaidLeave As Decimal = Val(txtUnpaidLeave.Text)
        txtTotalDeduction.Text = (sss + philhealth + pagibig + unpaidLeave).ToString("F2")
    End Sub
    Private Sub btnComputeDeduction_Click(sender As Object, e As EventArgs) Handles btnComputeDeduction.Click
        CalculateTotalDeduction()
    End Sub


    Private Sub dgvPayrollSummary_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPayrollSummary.SelectionChanged
        If dgvPayrollSummary.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = dgvPayrollSummary.CurrentRow

            ' Employee
            cbEmployeeID.Text = If(row.Cells("EmployeeID").Value IsNot DBNull.Value, row.Cells("EmployeeID").Value.ToString(), "")
            txtEmployeeName.Text = If(row.Cells("EmployeeName").Value IsNot DBNull.Value, row.Cells("EmployeeName").Value.ToString(), "")

            ' Payroll
            txtPayrollID.Text = If(row.Cells("PayrollID").Value IsNot DBNull.Value, row.Cells("PayrollID").Value.ToString(), "")
            txtBasicSalary.Text = If(row.Cells("PayrollBasicSalary").Value IsNot DBNull.Value, row.Cells("PayrollBasicSalary").Value.ToString(), "")
            txtOvertimePay.Text = If(row.Cells("OvertimePay").Value IsNot DBNull.Value, row.Cells("OvertimePay").Value.ToString(), "")
            txtGrossSalary.Text = If(row.Cells("GrossSalary").Value IsNot DBNull.Value, row.Cells("GrossSalary").Value.ToString(), "")
            txtNetPay.Text = If(row.Cells("NetPay").Value IsNot DBNull.Value, row.Cells("NetPay").Value.ToString(), "")
            dtpPaymentDate.Value = If(IsDate(row.Cells("PaymentDate").Value), CDate(row.Cells("PaymentDate").Value), Date.Now)

            ' Salary
            txtSalaryID.Text = If(row.Cells("SalaryID").Value IsNot DBNull.Value, row.Cells("SalaryID").Value.ToString(), "")
            txtBaseSalary.Text = If(row.Cells("SalaryBaseSalary").Value IsNot DBNull.Value, row.Cells("SalaryBaseSalary").Value.ToString(), "")
            txtAllowance.Text = If(row.Cells("Allowance").Value IsNot DBNull.Value, row.Cells("Allowance").Value.ToString(), "")
            txtDailyRate.Text = If(row.Cells("DailyRate").Value IsNot DBNull.Value, row.Cells("DailyRate").Value.ToString(), "")
            txtOvertimeRate.Text = If(row.Cells("OvertimeRate").Value IsNot DBNull.Value, row.Cells("OvertimeRate").Value.ToString(), "")

            ' Job
            txtJobID.Text = If(row.Cells("JobID").Value IsNot DBNull.Value, row.Cells("JobID").Value.ToString(), "")
            txtJobTitle.Text = If(row.Cells("JobTitle").Value IsNot DBNull.Value, row.Cells("JobTitle").Value.ToString(), "")

            ' Deduction
            txtDeductionID.Text = If(row.Cells("DeductionID").Value IsNot DBNull.Value, row.Cells("DeductionID").Value.ToString(), "")
            txtSSS.Text = If(row.Cells("SSS").Value IsNot DBNull.Value, row.Cells("SSS").Value.ToString(), "")
            txtPhilHealth.Text = If(row.Cells("PhilHealth").Value IsNot DBNull.Value, row.Cells("PhilHealth").Value.ToString(), "")
            txtPagIBIG.Text = If(row.Cells("PagIBIG").Value IsNot DBNull.Value, row.Cells("PagIBIG").Value.ToString(), "")
            txtUnpaidLeave.Text = If(row.Cells("UnpaidLeave").Value IsNot DBNull.Value, row.Cells("UnpaidLeave").Value.ToString(), "")
            dtpDateApplied.Value = If(IsDate(row.Cells("DeductionDate").Value), CDate(row.Cells("DeductionDate").Value), Date.Now)

            ' Attendance
            txtAttendanceID.Text = If(row.Cells("AttendanceID").Value IsNot DBNull.Value, row.Cells("AttendanceID").Value.ToString(), "")
            txtAbscences.Text = If(row.Cells("Absences").Value IsNot DBNull.Value, row.Cells("Absences").Value.ToString(), "")
        End If
    End Sub
    Private Function EscapeForRowFilter(value As String) As String
        ' Escape single quotes by doubling them. Also escape square brackets by surrounding with [].
        If value Is Nothing Then Return ""
        Dim v As String = value.Replace("'", "''")
        v = v.Replace("[", "[[]").Replace("]", "[]]")
        Return v
    End Function
    Private Sub txtSearchPayroll_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPayroll.TextChanged
        Dim searchText As String = txtSearchPayroll.Text.Trim().ToLower()

        ' Reset all rows when search box is empty
        If searchText = "" Then
            For Each row As DataGridViewRow In dgvPayrollSummary.Rows
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.SelectionBackColor = Color.LightBlue
                row.DefaultCellStyle.ForeColor = Color.Black
            Next
            Exit Sub
        End If

        For Each row As DataGridViewRow In dgvPayrollSummary.Rows
            If row.IsNewRow Then Continue For

            Dim match As Boolean = False

            ' Match EmployeeID
            If row.Cells("EmployeeID").Value IsNot DBNull.Value AndAlso
           row.Cells("EmployeeID").Value.ToString().ToLower().Contains(searchText) Then
                match = True
            End If

            ' Match EmployeeName
            If row.Cells("EmployeeName").Value IsNot DBNull.Value AndAlso
           row.Cells("EmployeeName").Value.ToString().ToLower().Contains(searchText) Then
                match = True
            End If

            ' Match JobTitle
            If row.Cells("JobTitle").Value IsNot DBNull.Value AndAlso
           row.Cells("JobTitle").Value.ToString().ToLower().Contains(searchText) Then
                match = True
            End If

            ' Highlight entire row if matched
            If match Then
                row.DefaultCellStyle.BackColor = Color.LightSkyBlue
                row.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue
                row.DefaultCellStyle.ForeColor = Color.Black
            Else
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.SelectionBackColor = Color.LightBlue
                row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub


    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Manager_Dashboard.Show()
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
    Private Sub lblSalaryClick(sender As Object, e As EventArgs) Handles lblSalary.Click
        Salary.Show()
        Me.Hide()
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
        lblPayrollSummary.Enabled = False
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
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to sign out?",
            "Confirm Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If result = DialogResult.Yes Then
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub


End Class