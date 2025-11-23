
Imports MySql.Data.MySqlClient
Imports System.Globalization


Public Class Payroll_Summary
    Private payrollTable As DataTable = Nothing
    Private originalValues As New Dictionary(Of String, String)
    Private payrollBindingSource As BindingSource
    Private Sub Payroll_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayrollSummary()
        LoadEmployeeIDs()
        LockFields()
        ShowButtons(add:=True, edit:=False, delete:=False, compute:=False, save:=False, cancel:=False)
        btnSendToATM.Visible = False
        payrollBindingSource = New BindingSource()
        payrollBindingSource.DataSource = payrollTable
        dgvPayrollSummary.DataSource = payrollBindingSource
    End Sub
    Private Sub LoadPayrollSummary()
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
        ORDER BY e.EmployeeID;
    "

        payrollTable = HRMModule.ExecuteQuery(query)
        dgvPayrollSummary.DataSource = payrollTable
        dgvPayrollSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvPayrollSummary.RowTemplate.Height = 30
        dgvPayrollSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
    End Sub
    Private Sub LoadEmployeeIDs()
        cbEmployeeID.Items.Clear()
        If payrollTable IsNot Nothing AndAlso payrollTable.Rows.Count > 0 Then
            For Each row As DataRow In payrollTable.Rows
                Dim empID As String = row("EmployeeID").ToString()
                If Not cbEmployeeID.Items.Contains(empID) Then cbEmployeeID.Items.Add(empID)
            Next
        End If
    End Sub
    Private Sub cbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployeeID.SelectedIndexChanged
        If Not cbEmployeeID.Enabled Then Exit Sub
        Dim selectedID As String = cbEmployeeID.Text
        If String.IsNullOrWhiteSpace(selectedID) Then Exit Sub

        Dim rows() As DataRow = payrollTable.Select("EmployeeID = '" & selectedID & "'")
        If rows.Length > 0 Then
            PopulateFieldsFromDataRow(rows(0))
        Else
            ClearPayrollFields()
        End If
    End Sub
    Private Sub PopulateFieldsFromDataRow(row As DataRow)
        txtEmployeeName.Text = row("EmployeeName").ToString()
        txtJobTitle.Text = row("JobTitle").ToString()
        txtBaseSalary.Text = If(row("SalaryBaseSalary") IsNot DBNull.Value, row("SalaryBaseSalary").ToString(), "0")
        txtAllowance.Text = If(row("SalaryAllowance") IsNot DBNull.Value, row("SalaryAllowance").ToString(), "0")
        txtDailyRate.Text = If(row("SalaryDailyRate") IsNot DBNull.Value, row("SalaryDailyRate").ToString(), "0")
        txtOvertimeRate.Text = If(row("SalaryOvertimeRate") IsNot DBNull.Value, row("SalaryOvertimeRate").ToString(), "0")

        txtPayrollID.Text = If(String.IsNullOrEmpty(row("PayrollID").ToString()), GenerateNextPayrollID(), row("PayrollID").ToString())
        txtBasicSalary.Text = row("PayrollBasicSalary").ToString()
        txtOvertimePay.Text = row("PayrollOvertimePay").ToString()
        txtGrossSalary.Text = row("PayrollGrossSalary").ToString()
        txtNetPay.Text = row("PayrollNetPay").ToString()

        Dim paymentDate As DateTime
        If row("PayrollPaymentDate") IsNot DBNull.Value AndAlso DateTime.TryParse(row("PayrollPaymentDate").ToString(), paymentDate) Then
            dtpPaymentDate.Value = paymentDate
        Else
            Dim today As DateTime = DateTime.Today
            dtpPaymentDate.Value = New DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month))
        End If

        txtAttendanceID.Text = If(row("AttendanceID") IsNot DBNull.Value, row("AttendanceID").ToString(), GenerateNextAttendanceID())
        txtTotalHours.Text = row("AttendanceTotalHours").ToString()
        txtExceededHours.Text = row("AttendanceExceededHours").ToString()
        txtDaysAttended.Text = row("AttendanceDaysAttended").ToString()
        txtAbsences.Text = row("AttendanceAbsences").ToString()
        txtDeductionID.Text = If(row("DeductionID") IsNot DBNull.Value, row("DeductionID").ToString(), GenerateNextDeductionID())
        txtUnpaidLeave.Text = If(row("DeductionUnpaidLeave") IsNot DBNull.Value, row("DeductionUnpaidLeave").ToString(), "0")
        txtSSS.Text = If(row("DeductionSSS") IsNot DBNull.Value, row("DeductionSSS").ToString(), "0")
        txtPhilHealth.Text = If(row("DeductionPhilHealth") IsNot DBNull.Value, row("DeductionPhilHealth").ToString(), "0")
        txtPagIBIG.Text = If(row("DeductionPagIBIG") IsNot DBNull.Value, row("DeductionPagIBIG").ToString(), "0")
        txtTotalDeduction.Text = If(row("DeductionTotalDeduction") IsNot DBNull.Value, row("DeductionTotalDeduction").ToString(), "0")

        StoreOriginalValues()
        LockFields()
    End Sub
    Private Sub StoreOriginalValues()
        originalValues.Clear()
        originalValues("BaseSalary") = txtBaseSalary.Text
        originalValues("Allowance") = txtAllowance.Text
        originalValues("DailyRate") = txtDailyRate.Text
        originalValues("OvertimeRate") = txtOvertimeRate.Text
        originalValues("BasicSalary") = txtBasicSalary.Text
        originalValues("OvertimePay") = txtOvertimePay.Text
        originalValues("GrossSalary") = txtGrossSalary.Text
        originalValues("NetPay") = txtNetPay.Text
        originalValues("SSS") = txtSSS.Text
        originalValues("PhilHealth") = txtPhilHealth.Text
        originalValues("PagIBIG") = txtPagIBIG.Text
        originalValues("UnpaidLeave") = txtUnpaidLeave.Text
        originalValues("TotalDeduction") = txtTotalDeduction.Text
    End Sub
    Private Sub PopulateFieldsFromSelectedRow(rowIndex As Integer)
        Dim row As DataGridViewRow = dgvPayrollSummary.Rows(rowIndex)
        cbEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
        cbEmployeeID.Enabled = False
        txtEmployeeName.Text = row.Cells("EmployeeName").Value.ToString()
        txtJobTitle.Text = row.Cells("JobTitle").Value.ToString()
        txtPayrollID.Text = row.Cells("PayrollID").Value.ToString()
        txtBasicSalary.Text = row.Cells("PayrollBasicSalary").Value.ToString()
        txtOvertimePay.Text = row.Cells("PayrollOvertimePay").Value.ToString()
        txtGrossSalary.Text = row.Cells("PayrollGrossSalary").Value.ToString()
        txtNetPay.Text = row.Cells("PayrollNetPay").Value.ToString()
        Dim paymentDateStr As String = row.Cells("PayrollPaymentDate").Value.ToString()
        Dim paymentDate As DateTime

        If Not String.IsNullOrWhiteSpace(paymentDateStr) AndAlso DateTime.TryParseExact(paymentDateStr, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, paymentDate) Then
            dtpPaymentDate.Value = paymentDate
        Else
            Dim today As DateTime = DateTime.Today
            dtpPaymentDate.Value = New DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month))
        End If
        txtBaseSalary.Text = row.Cells("SalaryBaseSalary").Value.ToString()
        txtAllowance.Text = row.Cells("SalaryAllowance").Value.ToString()
        txtDailyRate.Text = row.Cells("SalaryDailyRate").Value.ToString()
        txtOvertimeRate.Text = row.Cells("SalaryOvertimeRate").Value.ToString()
        txtAttendanceID.Text = If(row.Cells("AttendanceID").Value IsNot DBNull.Value, row.Cells("AttendanceID").Value.ToString(), GenerateNextAttendanceID())
        txtTotalHours.Text = row.Cells("AttendanceTotalHours").Value.ToString()
        txtExceededHours.Text = row.Cells("AttendanceExceededHours").Value.ToString()
        txtDaysAttended.Text = row.Cells("AttendanceDaysAttended").Value.ToString()
        txtAbsences.Text = row.Cells("AttendanceAbsences").Value.ToString()
        txtDeductionID.Text = If(row.Cells("DeductionID").Value IsNot DBNull.Value, row.Cells("DeductionID").Value.ToString(), GenerateNextDeductionID())
        txtUnpaidLeave.Text = row.Cells("DeductionUnpaidLeave").Value.ToString()
        txtSSS.Text = row.Cells("DeductionSSS").Value.ToString()
        txtPhilHealth.Text = row.Cells("DeductionPhilHealth").Value.ToString()
        txtPagIBIG.Text = row.Cells("DeductionPagIBIG").Value.ToString()
        txtTotalDeduction.Text = row.Cells("DeductionTotalDeduction").Value.ToString()

        originalValues.Clear()
        originalValues("BaseSalary") = txtBaseSalary.Text
        originalValues("Allowance") = txtAllowance.Text
        originalValues("DailyRate") = txtDailyRate.Text
        originalValues("OvertimeRate") = txtOvertimeRate.Text
        originalValues("BasicSalary") = txtBasicSalary.Text
        originalValues("OvertimePay") = txtOvertimePay.Text
        originalValues("GrossSalary") = txtGrossSalary.Text
        originalValues("NetPay") = txtNetPay.Text
        originalValues("SSS") = txtSSS.Text
        originalValues("PhilHealth") = txtPhilHealth.Text
        originalValues("PagIBIG") = txtPagIBIG.Text
        originalValues("UnpaidLeave") = txtUnpaidLeave.Text
        originalValues("TotalDeduction") = txtTotalDeduction.Text

        LockFields()
    End Sub
    Private Sub dgvPayrollSummary_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollSummary.CellClick
        If e.RowIndex >= 0 Then
            PopulateFieldsFromSelectedRow(e.RowIndex)
            ShowButtons(add:=True, edit:=True, delete:=True, compute:=True, save:=False, cancel:=False)
        End If
    End Sub
    Private Sub LockFields()
        cbEmployeeID.Enabled = False
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
    End Sub
    Private Sub UnlockFields()
        cbEmployeeID.Enabled = True
        txtEmployeeName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtPayrollID.ReadOnly = True
        txtBasicSalary.ReadOnly = True
        txtOvertimePay.ReadOnly = True
        txtGrossSalary.ReadOnly = True
        txtNetPay.ReadOnly = True
        dtpPaymentDate.Enabled = False
        txtBaseSalary.ReadOnly = False
        txtAllowance.ReadOnly = False
        txtDailyRate.ReadOnly = False
        txtOvertimeRate.ReadOnly = False
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
    End Sub
    Private Sub ShowButtons(add As Boolean, edit As Boolean, delete As Boolean, compute As Boolean, save As Boolean, cancel As Boolean)
        btnAddPayroll.Visible = add
        btnEditPayroll.Visible = edit
        btnDeletePayroll.Visible = delete
        btnComputePayroll.Visible = compute
        btnSavePayroll.Visible = save
        btnCancelPayroll.Visible = cancel
    End Sub
    Private Sub SetPaymentDateToLastDay()
        Dim today As DateTime = DateTime.Today
        dtpPaymentDate.Value = New DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month))
        dtpPaymentDate.Enabled = False
    End Sub
    Private Sub ClearPayrollFields()
        cbEmployeeID.Text = ""
        txtEmployeeName.Text = ""
        txtJobTitle.Text = ""
        txtPayrollID.Text = ""
        txtBasicSalary.Text = ""
        txtOvertimePay.Text = ""
        txtGrossSalary.Text = ""
        txtNetPay.Text = ""
        txtBaseSalary.Text = ""
        txtAllowance.Text = ""
        txtDailyRate.Text = ""
        txtOvertimeRate.Text = ""
        txtAttendanceID.Text = ""
        txtTotalHours.Text = ""
        txtExceededHours.Text = ""
        txtDaysAttended.Text = ""
        txtAbsences.Text = ""
        txtDeductionID.Text = ""
        txtUnpaidLeave.Text = ""
        txtSSS.Text = ""
        txtPhilHealth.Text = ""
        txtPagIBIG.Text = ""
        txtTotalDeduction.Text = ""
    End Sub
    Private Function ParseDecimal(txt As TextBox) As Decimal
        Dim value As Decimal = 0D
        Decimal.TryParse(txt.Text, value)
        Return value
    End Function
    Private Function GenerateNextPayrollID() As String
        Dim lastIDObj = HRMModule.ExecuteScalar("SELECT PayrollID FROM tblpayroll ORDER BY PayrollID DESC LIMIT 1")
        Dim nextID As String = "P001"
        If lastIDObj IsNot Nothing AndAlso Not IsDBNull(lastIDObj) Then
            Dim lastID As String = lastIDObj.ToString()
            Dim numericPart As Integer
            If lastID.Length > 1 AndAlso Integer.TryParse(lastID.Substring(1), numericPart) Then
                nextID = "P" & (numericPart + 1).ToString("D3")
            End If
        End If
        Return nextID
    End Function

    Private Function GenerateNextDeductionID() As String
        Dim lastID = HRMModule.ExecuteScalar("SELECT DeductionID FROM tbldeduction ORDER BY DeductionID DESC LIMIT 1")
        Dim nextID As String = "DDC001"
        If lastID IsNot Nothing AndAlso Not IsDBNull(lastID) Then
            Dim numericPart As Integer
            If Integer.TryParse(lastID.ToString().Substring(3), numericPart) Then
                nextID = "DDC" & (numericPart + 1).ToString("D3")
            End If
        End If
        Return nextID
    End Function
    Private Function GenerateNextAttendanceID() As String
        Dim lastID = HRMModule.ExecuteScalar("SELECT AttendanceID FROM tblattendance ORDER BY AttendanceID DESC LIMIT 1")
        Dim nextID As String = "T001"
        If lastID IsNot Nothing AndAlso Not IsDBNull(lastID) Then
            Dim numericPart As Integer
            If Integer.TryParse(lastID.ToString().Substring(1), numericPart) Then
                nextID = "T" & (numericPart + 1).ToString("D3")
            End If
        End If
        Return nextID
    End Function
    Private Function GenerateNextSalaryID() As String
        Dim lastID = HRMModule.ExecuteScalar("SELECT SalaryID FROM tblsalary ORDER BY SalaryID DESC LIMIT 1")
        Dim nextID As String = "S1"
        If lastID IsNot Nothing AndAlso Not IsDBNull(lastID) Then
            Dim numericPart As Integer
            If Integer.TryParse(lastID.ToString().Substring(1), numericPart) Then
                nextID = "S" & (numericPart + 1).ToString()
            End If
        End If
        Return nextID
    End Function
    Private Sub ComputePayroll()
        Dim baseSalary As Decimal = ParseDecimal(txtBaseSalary)
        Dim allowance As Decimal = ParseDecimal(txtAllowance)
        Dim dailyRate As Decimal = ParseDecimal(txtDailyRate)
        Dim overtimeRate As Decimal = ParseDecimal(txtOvertimeRate)
        Dim daysAttended As Decimal = ParseDecimal(txtDaysAttended)
        Dim exceededHours As Decimal = ParseDecimal(txtExceededHours)
        Dim absences As Decimal = ParseDecimal(txtAbsences)
        Dim unpaidLeave As Decimal = ParseDecimal(txtUnpaidLeave)
        Dim computedBasicSalary As Decimal = dailyRate * daysAttended
        Dim overtimePay As Decimal = exceededHours * overtimeRate
        Dim grossSalary As Decimal = computedBasicSalary + allowance + overtimePay
        Dim sss As Decimal = Math.Round(baseSalary * 0.04D, 2)
        Dim philHealth As Decimal = Math.Round(baseSalary * 0.03D, 2)
        Dim pagIBIG As Decimal = Math.Round(baseSalary * 0.02D, 2)
        txtSSS.Text = sss.ToString("F2")
        txtPhilHealth.Text = philHealth.ToString("F2")
        txtPagIBIG.Text = pagIBIG.ToString("F2")
        Dim absencesDeduction As Decimal = dailyRate * absences
        Dim unpaidLeaveDeduction As Decimal = dailyRate * unpaidLeave
        Dim totalDeductions As Decimal = sss + philHealth + pagIBIG + absencesDeduction + unpaidLeaveDeduction
        Dim netPay As Decimal = grossSalary - totalDeductions
        txtBasicSalary.Text = computedBasicSalary.ToString("F2")
        txtOvertimePay.Text = overtimePay.ToString("F2")
        txtGrossSalary.Text = grossSalary.ToString("F2")
        txtTotalDeduction.Text = totalDeductions.ToString("F2")
        txtNetPay.Text = netPay.ToString("F2")
    End Sub
    Private Sub ShowSendToATMButton()
        Dim netPay As Decimal
        If Decimal.TryParse(txtNetPay.Text, netPay) AndAlso netPay > 0 Then
            btnSendToATM.Visible = True
        Else
            btnSendToATM.Visible = False
        End If
    End Sub
    Private Function HasChanges() As Boolean
        If originalValues.Count = 0 Then Return True
        Return originalValues("BaseSalary") <> txtBaseSalary.Text OrElse
               originalValues("Allowance") <> txtAllowance.Text OrElse
               originalValues("DailyRate") <> txtDailyRate.Text OrElse
               originalValues("OvertimeRate") <> txtOvertimeRate.Text OrElse
               originalValues("BasicSalary") <> txtBasicSalary.Text OrElse
               originalValues("OvertimePay") <> txtOvertimePay.Text OrElse
               originalValues("GrossSalary") <> txtGrossSalary.Text OrElse
               originalValues("NetPay") <> txtNetPay.Text OrElse
               originalValues("SSS") <> txtSSS.Text OrElse
               originalValues("PhilHealth") <> txtPhilHealth.Text OrElse
               originalValues("PagIBIG") <> txtPagIBIG.Text OrElse
               originalValues("UnpaidLeave") <> txtUnpaidLeave.Text OrElse
               originalValues("TotalDeduction") <> txtTotalDeduction.Text
    End Function
    Private Function ValidatePayrollFields() As Boolean
        If String.IsNullOrWhiteSpace(cbEmployeeID.Text) Then
            MessageBox.Show("Please select an employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtBaseSalary.Text) OrElse Not IsNumeric(txtBaseSalary.Text) Then
            MessageBox.Show("Base Salary is required and must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDailyRate.Text) OrElse Not IsNumeric(txtDailyRate.Text) Then
            MessageBox.Show("Daily Rate is required and must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtOvertimeRate.Text) OrElse Not IsNumeric(txtOvertimeRate.Text) Then
            MessageBox.Show("Overtime Rate is required and must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDaysAttended.Text) OrElse Not IsNumeric(txtDaysAttended.Text) Then
            MessageBox.Show("Days Attended is required and must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtExceededHours.Text) OrElse Not IsNumeric(txtExceededHours.Text) Then
            MessageBox.Show("Exceeded Hours is required and must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function
    Private Sub btnComputePayroll_Click(sender As Object, e As EventArgs) Handles btnComputePayroll.Click
        If String.IsNullOrWhiteSpace(cbEmployeeID.Text) Then
            MessageBox.Show("Please select an employee first.", "Compute Payroll", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not ValidatePayrollFields() Then Exit Sub

        If CDbl(txtDailyRate.Text) < 0 OrElse CDbl(txtDaysAttended.Text) < 0 OrElse CDbl(txtExceededHours.Text) < 0 Then
            MessageBox.Show("Values cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ComputePayroll()
        ShowSendToATMButton()
    End Sub
    Private Sub btnAddPayroll_Click(sender As Object, e As EventArgs) Handles btnAddPayroll.Click
        UnlockFields()
        ClearPayrollFields()
        SetPaymentDateToLastDay()
        cbEmployeeID.Enabled = True
        txtPayrollID.Text = GenerateNextPayrollID()
        txtDeductionID.Text = GenerateNextDeductionID()
        ShowButtons(add:=False, edit:=False, delete:=False, compute:=True, save:=True, cancel:=True)

    End Sub
    Private Sub btnSavePayroll_Click(sender As Object, e As EventArgs) Handles btnSavePayroll.Click
        ComputePayroll()
        If String.IsNullOrWhiteSpace(cbEmployeeID.Text) Then
            MessageBox.Show("Please select an employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim payrollID As String = If(String.IsNullOrWhiteSpace(txtPayrollID.Text), GenerateNextPayrollID(), txtPayrollID.Text)
        Dim deductionID As String = If(String.IsNullOrWhiteSpace(txtDeductionID.Text), GenerateNextDeductionID(), txtDeductionID.Text)
        Dim salaryID As String = GenerateNextSalaryID()

        Dim queries As New List(Of String)
        Dim parameters As New List(Of List(Of MySqlParameter))

        queries.Add("
            INSERT INTO tblpayroll (PayrollID, EmployeeID, BasicSalary, OvertimePay, GrossSalary, NetPay, PaymentDate)
            VALUES (@pid, @eid, @basic, @ot, @gross, @net, @date)
            ON DUPLICATE KEY UPDATE 
                BasicSalary=@basic, OvertimePay=@ot, GrossSalary=@gross, NetPay=@net, PaymentDate=@date
        ")
        parameters.Add(New List(Of MySqlParameter) From {
            New MySqlParameter("@pid", payrollID),
            New MySqlParameter("@eid", cbEmployeeID.Text),
            New MySqlParameter("@basic", txtBasicSalary.Text),
            New MySqlParameter("@ot", txtOvertimePay.Text),
            New MySqlParameter("@gross", txtGrossSalary.Text),
            New MySqlParameter("@net", txtNetPay.Text),
            New MySqlParameter("@date", dtpPaymentDate.Value)
        })

        queries.Add("
            INSERT INTO tblsalary (SalaryID, EmployeeID, BaseSalary, Allowance, DailyRate, OvertimeRate)
            VALUES (@sid, @eid, @base, @allow, @daily, @otrate)
            ON DUPLICATE KEY UPDATE 
                BaseSalary=@base, Allowance=@allow, DailyRate=@daily, OvertimeRate=@otrate
        ")
        parameters.Add(New List(Of MySqlParameter) From {
            New MySqlParameter("@sid", salaryID),
            New MySqlParameter("@eid", cbEmployeeID.Text),
            New MySqlParameter("@base", txtBaseSalary.Text),
            New MySqlParameter("@allow", txtAllowance.Text),
            New MySqlParameter("@daily", txtDailyRate.Text),
            New MySqlParameter("@otrate", txtOvertimeRate.Text)
        })

        Dim attendanceID As String = If(String.IsNullOrWhiteSpace(txtAttendanceID.Text), GenerateNextAttendanceID(), txtAttendanceID.Text)
        queries.Add("
            INSERT INTO tblattendance (AttendanceID, EmployeeID, TotalHours, ExceededHours, DaysAttended, Absences)
            VALUES (@aid, @eid, @total, @exceeded, @days, @absences)
            ON DUPLICATE KEY UPDATE
                TotalHours=@total, ExceededHours=@exceeded, DaysAttended=@days, Absences=@absences
        ")
        parameters.Add(New List(Of MySqlParameter) From {
            New MySqlParameter("@aid", attendanceID),
            New MySqlParameter("@eid", cbEmployeeID.Text),
            New MySqlParameter("@total", txtTotalHours.Text),
            New MySqlParameter("@exceeded", txtExceededHours.Text),
            New MySqlParameter("@days", txtDaysAttended.Text),
            New MySqlParameter("@absences", txtAbsences.Text)
        })

        queries.Add("
            INSERT INTO tbldeduction (DeductionID, EmployeeID, SSS, PhilHealth, PagIBIG, UnpaidLeave, TotalDeduction)
            VALUES (@did, @eid, @sss, @phil, @pag, @unpaid, @total)
            ON DUPLICATE KEY UPDATE 
                SSS=@sss, PhilHealth=@phil, PagIBIG=@pag, UnpaidLeave=@unpaid, TotalDeduction=@total
        ")
        parameters.Add(New List(Of MySqlParameter) From {
            New MySqlParameter("@did", deductionID),
            New MySqlParameter("@eid", cbEmployeeID.Text),
            New MySqlParameter("@sss", txtSSS.Text),
            New MySqlParameter("@phil", txtPhilHealth.Text),
            New MySqlParameter("@pag", txtPagIBIG.Text),
            New MySqlParameter("@unpaid", txtUnpaidLeave.Text),
            New MySqlParameter("@total", txtTotalDeduction.Text)
        })

        For i As Integer = 0 To queries.Count - 1
            If Not HRMModule.ExecuteNonQuery(queries(i), parameters(i)) Then
                MessageBox.Show("Error saving payroll data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        MessageBox.Show("Payroll saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadPayrollSummary()
        LockFields()
    End Sub

    Private Sub btnEditPayroll_Click(sender As Object, e As EventArgs) Handles btnEditPayroll.Click
        If String.IsNullOrWhiteSpace(txtPayrollID.Text) Then
            MessageBox.Show("Please select a payroll record to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        UnlockFields()
        SetPaymentDateToLastDay()
        cbEmployeeID.Enabled = False
        ShowButtons(add:=False, edit:=False, delete:=False, compute:=True, save:=True, cancel:=True)
    End Sub
    Private Sub btnCancelPayroll_Click(sender As Object, e As EventArgs) Handles btnCancelPayroll.Click
        LockFields()
        ClearPayrollFields()
        ShowButtons(add:=True, edit:=False, delete:=False, compute:=False, save:=False, cancel:=False)
    End Sub
    Private Sub btnDeletePayroll_Click(sender As Object, e As EventArgs) Handles btnDeletePayroll.Click
        If MessageBox.Show("Are you sure you want to delete this payroll record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim queries As New List(Of String)
            Dim parameters As New List(Of List(Of MySqlParameter))

            queries.Add("DELETE FROM tblpayroll WHERE PayrollID = @pid")
            parameters.Add(New List(Of MySqlParameter) From {New MySqlParameter("@pid", txtPayrollID.Text)})

            queries.Add("DELETE FROM tbldeduction WHERE DeductionID = @did")
            parameters.Add(New List(Of MySqlParameter) From {New MySqlParameter("@did", txtDeductionID.Text)})

            For i As Integer = 0 To queries.Count - 1
                HRMModule.ExecuteNonQuery(queries(i), parameters(i))
            Next

            MessageBox.Show("Payroll deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPayrollSummary()
            ClearPayrollFields()
        End If
    End Sub
    Private Sub txtSearchPayroll_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPayroll.TextChanged
        If payrollBindingSource Is Nothing OrElse payrollBindingSource.DataSource Is Nothing Then Exit Sub

        Dim searchValue As String = txtSearchPayroll.Text.Trim()
        Dim dt As DataTable = TryCast(payrollBindingSource.DataSource, DataTable)
        If dt Is Nothing Then Exit Sub

        If String.IsNullOrWhiteSpace(searchValue) Then
            payrollBindingSource.RemoveFilter()
        Else
            searchValue = searchValue.Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]")
            Dim isEmployeeIDNumeric As Boolean = dt.Columns("EmployeeID").DataType Is GetType(Integer) OrElse dt.Columns("EmployeeID").DataType Is GetType(Long)

            If isEmployeeIDNumeric AndAlso IsNumeric(searchValue) Then
                payrollBindingSource.Filter = $"EmployeeName LIKE '%{searchValue}%' OR EmployeeID = {searchValue}"
            Else
                payrollBindingSource.Filter = $"EmployeeName LIKE '%{searchValue}%' OR Convert(EmployeeID, 'System.String') LIKE '%{searchValue}%'"
            End If
        End If
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
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        HRMModule.SignOut(Me)
    End Sub


End Class
