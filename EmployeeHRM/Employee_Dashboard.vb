Imports MySql.Data.MySqlClient

Public Class Employee_Dashboard
    Public UserRole As String

    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & LoggedInUsername

        If LoggedInUserType = "Staff" Then
            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblEmployeeTrainings.Visible = False
            lblDepartment.Visible = False
            lblAmenities.Visible = False
        End If
        txtEmployeeID.ReadOnly = True
        txtName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtDepartment.ReadOnly = True
        LoadEmployeeInfo()
    End Sub
    Public Sub LoadEmployeeInfo()
        Try
            OpenCon()
            Dim query As String =
                "SELECT e.EmployeeID, " &
                "CONCAT(IFNULL(e.`First Name`, ''), ' ', IFNULL(e.`MiddleName`, ''), ' ', IFNULL(e.`LastName`, '')) AS FullName, " &
                "j.JobTitle, d.Name AS DepartmentName " &
                "FROM tblemployee e " &
                "LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID " &
                "LEFT JOIN tbldepartment d ON e.EmployeeID = d.EmployeeID " &
                "WHERE e.EmployeeID = @empID"

            dbcmd = New MySqlCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)

            Dim reader As MySqlDataReader = dbcmd.ExecuteReader()
            If reader.Read() Then
                txtEmployeeID.Text = reader("EmployeeID").ToString()
                txtName.Text = reader("FullName").ToString()
                txtJobTitle.Text = reader("JobTitle").ToString()
                txtDepartment.Text = reader("DepartmentName").ToString()
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading employee info: " & ex.Message)
        End Try
    End Sub
    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
        lblEmpDashboard.Enabled = False
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
    Private Sub btnCheckInOut_Click(sender As Object, e As EventArgs) Handles btnCheckInOut.Click
        Attendance.Show()
        Me.Hide()
    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        MyProfile.Show()
        Me.Hide()
    End Sub
    Private Sub btnApplyforLeave_Click(sender As Object, e As EventArgs) Handles btnApplyforLeave.Click
        Leave_Management.Show()
        Me.Hide()
    End Sub
    Private Sub btnViewSalary_Click(sender As Object, e As EventArgs) Handles btnViewSalary.Click
        Salary.Show()
        Me.Hide()
    End Sub
    Private Sub btnSeeTrainings_Click(sender As Object, e As EventArgs) Handles btnSeeTrainings.Click
        Trainings.Show()
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
            Login_frm.ClearLoginFields()
            LoggedInEmployeeID = ""
            LoggedInUsername = ""
            LoggedInUserType = ""
            Login_frm.Show()
            Me.Hide()
        End If
    End Sub

End Class
