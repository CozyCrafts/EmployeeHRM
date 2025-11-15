
Imports MySql.Data.MySqlClient

Public Class Payroll_Summary
    Private connectionString As String = "server=localhost;userid=root;password=091951;database=db_hrm"
    Private payrollTable As DataTable = Nothing
    Private Sub Payroll_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayrollSummary()
        LoadEmployeeIDs()
        SetInitialButtonState()
        LockFields()
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
                    p.BasicSalary AS PayrollBasicSalary,   -- alias for payroll table
                    p.OvertimePay AS PayrollOvertimePay,
                    p.GrossSalary AS PayrollGrossSalary,
                    p.NetPay AS PayrollNetPay,
                    p.PaymentDate AS PayrollPaymentDate,
                    s.SalaryID AS SalaryID,
                    s.BaseSalary AS SalaryBaseSalary,      -- alias for salary table
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
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        payrollTable = New DataTable()
                        adapter.Fill(payrollTable)
                        dgvPayrollSummary.DataSource = payrollTable
                        dgvPayrollSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        dgvPayrollSummary.RowTemplate.Height = 30
                        dgvPayrollSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payroll summary: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadEmployeeIDs()
        cbEmployeeID.Items.Clear()
        If payrollTable IsNot Nothing AndAlso payrollTable.Rows.Count > 0 Then
            For Each row As DataRow In payrollTable.Rows
                Dim empID As String = row("EmployeeID").ToString()
                If Not cbEmployeeID.Items.Contains(empID) Then
                    cbEmployeeID.Items.Add(empID)
                End If
            Next
        End If
    End Sub
    Private Sub cbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployeeID.SelectedIndexChanged
        If Not cbEmployeeID.Enabled Then Exit Sub
        Dim selectedID As String = cbEmployeeID.Text
        If String.IsNullOrWhiteSpace(selectedID) Then Exit Sub
        Dim rows() As DataRow = payrollTable.Select("EmployeeID = '" & selectedID & "'")
        If rows.Length > 0 Then
            Dim row As DataRow = rows(0)
            txtEmployeeName.Text = row("EmployeeName").ToString()
            txtJobTitle.Text = row("JobTitle").ToString()
            txtBaseSalary.Text = row("SalaryBaseSalary").ToString()
            txtAllowance.Text = row("SalaryAllowance").ToString()
            txtDailyRate.Text = row("SalaryDailyRate").ToString()
            txtOvertimeRate.Text = row("SalaryOvertimeRate").ToString()
            Dim payrollID As String = row("PayrollID").ToString()
            If String.IsNullOrEmpty(payrollID) Then
                txtPayrollID.Text = GenerateNextPayrollID()
            Else
                txtPayrollID.Text = payrollID
            End If
            txtBasicSalary.Text = row("PayrollBasicSalary").ToString()
            txtOvertimePay.Text = row("PayrollOvertimePay").ToString()
            txtGrossSalary.Text = row("PayrollGrossSalary").ToString()
            txtNetPay.Text = row("PayrollNetPay").ToString()
            Dim paymentDateStr As String = row("PayrollPaymentDate").ToString()
            Dim paymentDate As DateTime
            If Not String.IsNullOrWhiteSpace(paymentDateStr) AndAlso DateTime.TryParseExact(paymentDateStr, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, paymentDate) Then
                dtpPaymentDate.Value = paymentDate
            Else
                Dim today As DateTime = DateTime.Today
                dtpPaymentDate.Value = New DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month))
            End If
            txtAttendanceID.Text = row("AttendanceID").ToString()
            txtTotalHours.Text = row("AttendanceTotalHours").ToString()
            txtExceededHours.Text = row("AttendanceExceededHours").ToString()
            txtDaysAttended.Text = row("AttendanceDaysAttended").ToString()
            txtAbsences.Text = row("AttendanceAbsences").ToString()
            If row("DeductionID") IsNot Nothing AndAlso Not IsDBNull(row("DeductionID")) Then
                txtDeductionID.Text = row("DeductionID").ToString()
            Else
                txtDeductionID.Text = GenerateNextDeductionID()
            End If
            txtUnpaidLeave.Text = If(row("DeductionUnpaidLeave") IsNot DBNull.Value, row("DeductionUnpaidLeave").ToString(), "0")
            txtSSS.Text = If(row("DeductionSSS") IsNot DBNull.Value, row("DeductionSSS").ToString(), "0")
            txtPhilHealth.Text = If(row("DeductionPhilHealth") IsNot DBNull.Value, row("DeductionPhilHealth").ToString(), "0")
            txtPagIBIG.Text = If(row("DeductionPagIBIG") IsNot DBNull.Value, row("DeductionPagIBIG").ToString(), "0")
            txtTotalDeduction.Text = If(row("DeductionTotalDeduction") IsNot DBNull.Value, row("DeductionTotalDeduction").ToString(), "0")
        Else
            ClearPayrollFields()
        End If
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
        txtAttendanceID.Text = row.Cells("AttendanceID").Value.ToString()
        txtTotalHours.Text = row.Cells("AttendanceTotalHours").Value.ToString()
        txtExceededHours.Text = row.Cells("AttendanceExceededHours").Value.ToString()
        txtDaysAttended.Text = row.Cells("AttendanceDaysAttended").Value.ToString()
        txtAbsences.Text = row.Cells("AttendanceAbsences").Value.ToString()
        txtDeductionID.Text = row.Cells("DeductionID").Value.ToString()
        txtUnpaidLeave.Text = row.Cells("DeductionUnpaidLeave").Value.ToString()
        txtSSS.Text = row.Cells("DeductionSSS").Value.ToString()
        txtPhilHealth.Text = row.Cells("DeductionPhilHealth").Value.ToString()
        txtPagIBIG.Text = row.Cells("DeductionPagIBIG").Value.ToString()
        txtTotalDeduction.Text = row.Cells("DeductionTotalDeduction").Value.ToString()
        LockFields()
    End Sub
    Private Sub dgvPayrollSummary_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollSummary.CellClick
        If e.RowIndex >= 0 Then
            PopulateFieldsFromSelectedRow(e.RowIndex)
            btnAddPayroll.Visible = True
            btnEditPayroll.Visible = True
            btnDeletePayroll.Visible = True
            btnComputePayroll.Visible = True
            btnSavePayroll.Visible = False
            btnCancelPayroll.Visible = False
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
    Private Sub SetInitialButtonState()
        btnAddPayroll.Visible = True
        btnEditPayroll.Visible = False
        btnDeletePayroll.Visible = False
        btnComputePayroll.Visible = False
        btnSavePayroll.Visible = False
        btnCancelPayroll.Visible = False
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
        Dim nextID As String = "P001"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT PayrollID FROM tblpayroll ORDER BY PayrollID DESC LIMIT 1", conn)
                Dim lastIDObj = cmd.ExecuteScalar()
                If lastIDObj IsNot Nothing AndAlso Not IsDBNull(lastIDObj) Then
                    Dim lastID As String = lastIDObj.ToString()
                    Dim numericPart As Integer
                    If Integer.TryParse(lastID.Substring(1), numericPart) Then
                        numericPart += 1
                        nextID = "P" & numericPart.ToString("D3")
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating PayrollID: " & ex.Message)
        End Try

        Return nextID
    End Function
    Private Function GenerateNextDeductionID() As String
        Dim nextID As String = "DDC001"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT DeductionID FROM tbldeduction ORDER BY DeductionID DESC LIMIT 1", conn)
                Dim lastIDObj = cmd.ExecuteScalar()
                If lastIDObj IsNot Nothing AndAlso Not IsDBNull(lastIDObj) Then
                    Dim lastID As String = lastIDObj.ToString()
                    Dim numericPart As Integer
                    If Integer.TryParse(lastID.Substring(3), numericPart) Then
                        numericPart += 1
                        nextID = "DDC" & numericPart.ToString("D3")
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating DeductionID: " & ex.Message)
        End Try

        Return nextID
    End Function
    Private Function GenerateNextAttendanceID() As String
        Dim nextID As String = "T001"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT AttendanceID FROM tblattendance ORDER BY AttendanceID DESC LIMIT 1", conn)
                Dim lastIDObj = cmd.ExecuteScalar()
                If lastIDObj IsNot Nothing AndAlso Not IsDBNull(lastIDObj) Then
                    Dim lastID As String = lastIDObj.ToString()
                    Dim numericPart As Integer
                    If Integer.TryParse(lastID.Substring(1), numericPart) Then
                        numericPart += 1
                        nextID = "T" & numericPart.ToString("D3")
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating AttendanceID: " & ex.Message)
        End Try
        Return nextID
    End Function
    Private Function GenerateNextSalaryID() As String
        Dim nextID As String = "S1"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT SalaryID FROM tblsalary ORDER BY SalaryID DESC LIMIT 1", conn)
                Dim lastIDObj = cmd.ExecuteScalar()
                If lastIDObj IsNot Nothing AndAlso Not IsDBNull(lastIDObj) Then
                    Dim lastID As String = lastIDObj.ToString()
                    Dim numericPart As Integer
                    If Integer.TryParse(lastID.Substring(1), numericPart) Then
                        numericPart += 1
                        nextID = "S" & numericPart.ToString()
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating SalaryID: " & ex.Message)
        End Try

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
    Private Sub btnComputePayroll_Click(sender As Object, e As EventArgs) Handles btnComputePayroll.Click
        If String.IsNullOrWhiteSpace(cbEmployeeID.Text) Then
            MessageBox.Show("Please select an employee first.", "Compute Payroll", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ComputePayroll()
    End Sub
    Private Sub btnAddPayroll_Click(sender As Object, e As EventArgs) Handles btnAddPayroll.Click
        UnlockFields()
        ClearPayrollFields()
        SetPaymentDateToLastDay()
        cbEmployeeID.Enabled = True
        txtPayrollID.Text = GenerateNextPayrollID()
        txtDeductionID.Text = GenerateNextDeductionID()
        btnAddPayroll.Visible = False
        btnEditPayroll.Visible = False
        btnDeletePayroll.Visible = False
        btnComputePayroll.Visible = True
        btnSavePayroll.Visible = True
        btnCancelPayroll.Visible = True
    End Sub
    Private Sub btnSavePayroll_Click(sender As Object, e As EventArgs) Handles btnSavePayroll.Click
        ComputePayroll()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim isNewPayroll As Boolean = String.IsNullOrWhiteSpace(txtPayrollID.Text) OrElse txtPayrollID.Text.StartsWith("P") = False
                Dim payrollID As String = txtPayrollID.Text
                Dim deductionID As String = txtDeductionID.Text
                Dim salaryID As String = " "
                If isNewPayroll Then
                    payrollID = GenerateNextPayrollID()
                    deductionID = GenerateNextDeductionID()
                    salaryID = GenerateNextSalaryID()
                End If
                Dim cmdPayroll As New MySqlCommand("
                INSERT INTO tblpayroll (PayrollID, EmployeeID, BasicSalary, OvertimePay, GrossSalary, NetPay, PaymentDate)
                VALUES (@pid, @eid, @basic, @ot, @gross, @net, @date)
                ON DUPLICATE KEY UPDATE 
                    BasicSalary=@basic, OvertimePay=@ot, GrossSalary=@gross, NetPay=@net, PaymentDate=@date
            ", conn)
                cmdPayroll.Parameters.AddWithValue("@pid", payrollID)
                cmdPayroll.Parameters.AddWithValue("@eid", cbEmployeeID.Text)
                cmdPayroll.Parameters.AddWithValue("@basic", txtBasicSalary.Text)
                cmdPayroll.Parameters.AddWithValue("@ot", txtOvertimePay.Text)
                cmdPayroll.Parameters.AddWithValue("@gross", txtGrossSalary.Text)
                cmdPayroll.Parameters.AddWithValue("@net", txtNetPay.Text)
                cmdPayroll.Parameters.AddWithValue("@date", dtpPaymentDate.Value)
                cmdPayroll.ExecuteNonQuery()
                Dim cmdSalary As New MySqlCommand("
        INSERT INTO tblsalary (SalaryID, EmployeeID, BaseSalary, Allowance, DailyRate, OvertimeRate)
        VALUES (@sid, @eid, @base, @allow, @daily, @otrate)
        ON DUPLICATE KEY UPDATE 
            BaseSalary=@base, Allowance=@allow, DailyRate=@daily, OvertimeRate=@otrate
    ", conn)
                cmdSalary.Parameters.AddWithValue("@sid", salaryID)
                cmdSalary.Parameters.AddWithValue("@eid", cbEmployeeID.Text)
                cmdSalary.Parameters.AddWithValue("@base", txtBaseSalary.Text)
                cmdSalary.Parameters.AddWithValue("@allow", txtAllowance.Text)
                cmdSalary.Parameters.AddWithValue("@daily", txtDailyRate.Text)
                cmdSalary.Parameters.AddWithValue("@otrate", txtOvertimeRate.Text)
                cmdSalary.ExecuteNonQuery()
                Dim attendanceID As String = txtAttendanceID.Text
                If String.IsNullOrWhiteSpace(attendanceID) Then
                    attendanceID = GenerateNextAttendanceID()
                End If
                Dim cmdAttendance As New MySqlCommand("
    INSERT INTO tblattendance (AttendanceID, EmployeeID, TotalHours, ExceededHours, DaysAttended, Absences)
    VALUES (@aid, @eid, @total, @exceeded, @days, @absences)
    ON DUPLICATE KEY UPDATE
        TotalHours=@total, ExceededHours=@exceeded, DaysAttended=@days, Absences=@absences
", conn)
                cmdAttendance.Parameters.AddWithValue("@aid", attendanceID)
                cmdAttendance.Parameters.AddWithValue("@eid", cbEmployeeID.Text)
                cmdAttendance.Parameters.AddWithValue("@total", txtTotalHours.Text)
                cmdAttendance.Parameters.AddWithValue("@exceeded", txtExceededHours.Text)
                cmdAttendance.Parameters.AddWithValue("@days", txtDaysAttended.Text)
                cmdAttendance.Parameters.AddWithValue("@absences", txtAbsences.Text)
                cmdAttendance.ExecuteNonQuery()
                Dim cmdDed As New MySqlCommand("
                INSERT INTO tbldeduction (DeductionID, EmployeeID, SSS, PhilHealth, PagIBIG, UnpaidLeave, TotalDeduction)
                VALUES (@did, @eid, @sss, @phil, @pag, @unpaid, @total)
                ON DUPLICATE KEY UPDATE 
                    SSS=@sss, PhilHealth=@phil, PagIBIG=@pag, UnpaidLeave=@unpaid, TotalDeduction=@total
            ", conn)
                cmdDed.Parameters.AddWithValue("@did", deductionID)
                cmdDed.Parameters.AddWithValue("@eid", cbEmployeeID.Text)
                cmdDed.Parameters.AddWithValue("@sss", txtSSS.Text)
                cmdDed.Parameters.AddWithValue("@phil", txtPhilHealth.Text)
                cmdDed.Parameters.AddWithValue("@pag", txtPagIBIG.Text)
                cmdDed.Parameters.AddWithValue("@unpaid", txtUnpaidLeave.Text)
                cmdDed.Parameters.AddWithValue("@total", txtTotalDeduction.Text)
                cmdDed.ExecuteNonQuery()
                txtPayrollID.Text = payrollID
                txtDeductionID.Text = deductionID
                txtAttendanceID.Text = attendanceID
            End Using
            MessageBox.Show("Payroll saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LockFields()
            ClearPayrollFields()
            SetInitialButtonState()
            LoadPayrollSummary()
            LoadEmployeeIDs()
        Catch ex As Exception
            MessageBox.Show("Error saving payroll: " & ex.Message)
        End Try
    End Sub
    Private Sub btnEditPayroll_Click(sender As Object, e As EventArgs) Handles btnEditPayroll.Click
        UnlockFields()
        SetPaymentDateToLastDay()
        cbEmployeeID.Enabled = False
        btnEditPayroll.Visible = False
        btnDeletePayroll.Visible = False
        btnComputePayroll.Visible = True
        btnSavePayroll.Visible = True
        btnCancelPayroll.Visible = True
    End Sub
    Private Sub btnCancelPayroll_Click(sender As Object, e As EventArgs) Handles btnCancelPayroll.Click
        LockFields()
        ClearPayrollFields()
        SetInitialButtonState()
    End Sub
    Private Sub btnDeletePayroll_Click(sender As Object, e As EventArgs) Handles btnDeletePayroll.Click
        If String.IsNullOrWhiteSpace(cbEmployeeID.Text) Then
            MessageBox.Show("Please select an employee/payroll to delete.", "Delete Payroll", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this payroll and its deductions? This action cannot be undone.",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )
        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim cmdPayroll As New MySqlCommand("DELETE FROM tblpayroll WHERE PayrollID = @pid", conn)
                    cmdPayroll.Parameters.AddWithValue("@pid", txtPayrollID.Text)
                    cmdPayroll.ExecuteNonQuery()
                    Dim cmdDeduction As New MySqlCommand("DELETE FROM tbldeduction WHERE DeductionID = @did", conn)
                    cmdDeduction.Parameters.AddWithValue("@did", txtDeductionID.Text)
                    cmdDeduction.ExecuteNonQuery()
                End Using
                MessageBox.Show("Payroll and associated deductions deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearPayrollFields()
                LoadPayrollSummary()
                SetInitialButtonState()
            Catch ex As Exception
                MessageBox.Show("Error deleting payroll: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnSendToATM_Click(sender As Object, e As EventArgs) Handles btnSendToATM.Click
        Dim requiredFields As TextBox() = {
        txtEmployeeName, txtJobTitle, txtBaseSalary, txtAllowance, txtDailyRate, txtOvertimeRate,
        txtBasicSalary, txtOvertimePay, txtGrossSalary, txtNetPay,
        txtSSS, txtPhilHealth, txtPagIBIG, txtUnpaidLeave, txtTotalDeduction
    }
        For Each field In requiredFields
            If String.IsNullOrWhiteSpace(field.Text) Then
                MessageBox.Show("Please make sure all payroll fields are filled before sending to ATM.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next
        Dim today As DateTime = DateTime.Today
        Dim lastDayOfMonth As Integer = DateTime.DaysInMonth(today.Year, today.Month)
        If today.Day <> lastDayOfMonth Then
            MessageBox.Show("Payroll can only be sent on the last day of the month.", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim confirmResult As DialogResult = MessageBox.Show(
        "Are you sure you want to send this payroll to the employee's ATM?",
        "Confirm Send",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            MessageBox.Show("Payroll successfully sent to ATM.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Payroll sending canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub txtSearchPayroll_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPayroll.TextChanged
        Dim searchValue As String = txtSearchPayroll.Text.Trim()
        dgvPayrollSummary.ClearSelection()

        If String.IsNullOrEmpty(searchValue) Then
            LoadPayrollSummary()
            Return
        End If
        Dim searchParts() As String = searchValue.Split(" "c, StringSplitOptions.RemoveEmptyEntries)
        For Each row As DataGridViewRow In dgvPayrollSummary.Rows
            If Not row.IsNewRow Then
                Dim employeeID As String = row.Cells("EmployeeID").Value.ToString()
                Dim fullName As String = row.Cells("EmployeeName").Value.ToString()
                Dim matchFound As Boolean = False
                If employeeID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               fullName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    matchFound = True
                Else
                    For Each part In searchParts
                        If fullName.IndexOf(part, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            matchFound = True
                            Exit For
                        End If
                    Next
                End If

                row.Selected = matchFound
            End If
        Next
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
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub
End Class
