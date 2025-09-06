Public Class Employee_Dashboard
    Private Sub lblEmpDashboard_Click(sender As Object, e As EventArgs) Handles lblEmpDashboard.Click
        lblEmpDashboard.Enabled = False
    End Sub

    Private Sub lblMyProf_Click(sender As Object, e As EventArgs) Handles lblMyProf.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpTA_Click(sender As Object, e As EventArgs) Handles lblEmpTA.Click
        Employee_Time_and_Attendancevb.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpPayroll_Click(sender As Object, e As EventArgs) Handles lblEmpPayroll.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub lblEmpGG_Click(sender As Object, e As EventArgs) Handles lblEmpGG.Click
        Employee_Goals_and_Growth.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditProf_Click(sender As Object, e As EventArgs) Handles btnEditProf.Click
        Employee_My_Profile.Show()
        Me.Hide()
    End Sub
    Private Sub btnCIO_Click(sender As Object, e As EventArgs) Handles btnCIO.Click
        Employee_Time_and_Attendancevb.Show()
        Me.Hide()
    End Sub
    Private Sub btnPerfRev_Click(sender As Object, e As EventArgs) Handles btnPerfRev.Click
        Employee_Goals_and_Growth.Show()
        Me.Hide()
    End Sub
    Private Sub btnViewPayslips_Click(sender As Object, e As EventArgs) Handles btnViewPayslips.Click
        Employee_Payroll.Show()
        Me.Hide()
    End Sub
    Private Sub btnHandbook_Click(sender As Object, e As EventArgs) Handles btnHandbook.Click

        MessageBox.Show("Welcome to [Company Name]!" & vbCrLf & vbCrLf &
                    "Our mission is to deliver quality products and services while fostering an inclusive and innovative workplace.",
                    "Welcome & Company Overview", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Employment Classifications:" & vbCrLf &
                    "- Probationary Employees: Up to 6 months" & vbCrLf &
                    "- Regular Employees: Completed probation" & vbCrLf &
                    "- Contractual / Project-based Employees: Specific projects" & vbCrLf &
                    "- Seasonal / Casual Employees: Short-term employment" & vbCrLf & vbCrLf &
                    "We provide equal employment opportunities and a safe workplace.",
                    "Employment Policies", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MessageBox.Show("Work Hours:" & vbCrLf &
                    "Standard: 8 hours/day, 6 days/week" & vbCrLf & vbCrLf &
                    "Overtime: 25% extra; Night Differential: 10% for 10 PM - 6 AM" & vbCrLf &
                    "Attendance is monitored via HR system. Notify supervisor for absences.",
                    "Work Hours & Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MessageBox.Show("Payroll is semi-monthly on 15th and 30th." & vbCrLf &
                    "Mandatory Benefits: SSS, PhilHealth, Pag-IBIG, 13th Month Pay." & vbCrLf &
                    "Optional Benefits: HMO, allowances, wellness programs.",
                    "Compensation & Benefits", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MessageBox.Show("Service Incentive Leave: 5 days/year after 1 year" & vbCrLf &
                    "Maternity Leave: 105 days + 15 for solo parents" & vbCrLf &
                    "Paternity Leave: 7 days" & vbCrLf &
                    "Special Leaves: Violence Against Women 10 days, Gynecological disorders 2 months",
                    "Leave Policies", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Employees must maintain professionalism, integrity, and respect." & vbCrLf &
                    "Dress Code: Smart casual; formal for meetings" & vbCrLf &
                    "Confidentiality and data privacy must be observed" & vbCrLf &
                    "No alcohol or drugs at workplace",
                    "Employee Conduct & Safety", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Resignation requires 30-day notice." & vbCrLf &
                    "Termination follows due process." & vbCrLf &
                    "Final pay includes unused leave and 13th Month Pay." & vbCrLf & vbCrLf &
                    "Acknowledgment: By continuing, you agree to follow company policies.",
                    "Separation & Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub btnPolicies_Click(sender As Object, e As EventArgs) Handles btnPolicies.Click
        Dim choice As DialogResult
        Dim section As Integer = 1 ' Tracks which section to show

        Do While True
            If section = 1 Then
                choice = MessageBox.Show("Employment Policies:" & vbCrLf &
                                     "- Probationary Employees: Up to 6 months" & vbCrLf &
                                     "- Regular Employees: Completed probation" & vbCrLf &
                                     "- Contractual / Project-based Employees" & vbCrLf &
                                     "- Seasonal / Casual Employees" & vbCrLf & vbCrLf &
                                     "Do you want to go to the next section?", "Employment Policies",
                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If choice = DialogResult.Yes Then
                    section = 2 ' Go to next section
                ElseIf choice = DialogResult.No Then
                    ' Cannot go back, already at first section
                    MessageBox.Show("You are at the first section.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Do ' Cancel
                End If

            ElseIf section = 2 Then
                choice = MessageBox.Show("Work Hours & Attendance:" & vbCrLf &
                                     "- Standard Work Hours: 8 hours/day" & vbCrLf &
                                     "- Overtime: 25% extra" & vbCrLf &
                                     "- Night Differential: 10% extra" & vbCrLf & vbCrLf &
                                     "Do you want to go back to the previous section?", "Work Hours & Attendance",
                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If choice = DialogResult.Yes Then
                    section = 1 ' Go back
                ElseIf choice = DialogResult.No Then
                    ' Next section could go here if you add more
                    Exit Do ' For demo, we exit
                Else
                    Exit Do ' Cancel
                End If
            End If
        Loop
    End Sub

    Private Sub btnForms_Click(sender As Object, e As EventArgs) Handles btnForms.Click

        MessageBox.Show("Leave Request Form (Sample):" & vbCrLf &
                    "Employee Name: ____________________" & vbCrLf &
                    "Department: _______________________" & vbCrLf &
                    "Type of Leave: ____________________" & vbCrLf &
                    "Start Date: __/__/____ End Date: __/__/____" & vbCrLf &
                    "Reason: ___________________________" & vbCrLf &
                    "Supervisor Approval: ______________",
                    "Leave Request Form", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Incident Report Form (Sample):" & vbCrLf &
                    "Employee Name: ____________________" & vbCrLf &
                    "Date & Time of Incident: __/__/____ at ____:____" & vbCrLf &
                    "Location: __________________________" & vbCrLf &
                    "Description of Incident: ____________" & vbCrLf &
                    "Witnesses: ________________________" & vbCrLf &
                    "Action Taken: _____________________",
                    "Incident Report Form", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Acknowledgment Form (Sample):" & vbCrLf &
                    "I, ___________________________, acknowledge that I have received and read the Employee Handbook, policies, and company rules." & vbCrLf &
                    "Employee Signature: _______________" & vbCrLf &
                    "Date: __/__/____",
                    "Acknowledgment Form", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MessageBox.Show("Performance Evaluation Form (Sample):" & vbCrLf &
                    "Employee Name: ____________________" & vbCrLf &
                    "Department: _______________________" & vbCrLf &
                    "Evaluation Period: __/__/____ to __/__/____" & vbCrLf &
                    "Key Responsibilities: ______________" & vbCrLf &
                    "Achievements: _____________________" & vbCrLf &
                    "Areas for Improvement: ____________" & vbCrLf &
                    "Overall Rating: ____________________" & vbCrLf &
                    "Evaluator Name & Signature: _______",
                    "Performance Evaluation Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnHoliday_Click(sender As Object, e As EventArgs) Handles btnHoliday.Click

        MessageBox.Show("Regular Holidays:" & vbCrLf &
                    "- January 1: New Year's Day" & vbCrLf &
                    "- April 9: Araw ng Kagitingan (Day of Valor)" & vbCrLf &
                    "- May 1: Labor Day" & vbCrLf &
                    "- June 12: Independence Day" & vbCrLf &
                    "- August 21: Ninoy Aquino Day" & vbCrLf &
                    "- November 30: Bonifacio Day" & vbCrLf &
                    "- December 25: Christmas Day" & vbCrLf &
                    "- December 30: Rizal Day",
                    "Regular Holidays", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Special (Non-Working) Holidays:" & vbCrLf &
                    "- February 25: EDSA People Power Revolution Anniversary" & vbCrLf &
                    "- August 29: National Heroes Day (last Monday of August)" & vbCrLf &
                    "- November 1: All Saints Day" & vbCrLf &
                    "- December 31: Last Day of the Year",
                    "Special Holidays", MessageBoxButtons.OK, MessageBoxIcon.Information)


        MessageBox.Show("Local Holidays: Each city/province may have its own holiday" & vbCrLf &
                    "Check your local government announcements for specific dates.",
                    "Local Holidays", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class