Public Class Amenities
    Public Property UserRole As String
    Private Sub Amenities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        If UserRole = "Staff" Then

            lblTeamOverview.Visible = False
            lblAttendanceTracker.Visible = False
            lblLeaveApproval.Visible = False
            lblPayrollSummary.Visible = False
            lblPerformanceReview.Visible = False
            lblDepartment.Visible = False

        ElseIf UserRole = "Manager" Then

            lblTeamOverview.Visible = True
            lblAttendanceTracker.Visible = True
            lblLeaveApproval.Visible = True
            lblPayrollSummary.Visible = True
            lblPerformanceReview.Visible = True
            lblDepartment.Visible = True
        End If

    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs)
        If UserRole = "Staff" Then
            Employee_Dashboard.Show()
        ElseIf UserRole = "Manager" Then
            Manager_Dashboard.Show()
        End If
        Me.Hide()
    End Sub
    Private Sub lblMyProfile_Click(sender As Object, e As EventArgs) Handles lblMyProfile.Click
        MyProfile.Show()
        Me.Hide()
    End Sub
    Private Sub lblAttendance_Click(sender As Object, e As EventArgs)
        Attendance.Show()
        Me.Hide()
    End Sub

    Private Sub lblLeave_Management_Click(sender As Object, e As EventArgs)
        Leave_Management.Show()
        Me.Hide()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs)
        Salary.Show()
        Me.Hide()
    End Sub

    Private Sub lblGoalsAndGrowth_Click(sender As Object, e As EventArgs)
        Goals_and_Growth.Show()
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

    Private Sub lblPerformanceReview_Click(sender As Object, e As EventArgs) Handles lblPerformanceReview.Click
        Performance_Review.Show()
        Me.Hide()
    End Sub

    Private Sub lblDepartment_Click(sender As Object, e As EventArgs) Handles lblDepartment.Click
        Department.Show()
        Me.Hide()
    End Sub

    Private Sub lblAmenities_Click(sender As Object, e As EventArgs) Handles lblAmenities.Click
        lblAmenities.Enabled = False

    End Sub


End Class
