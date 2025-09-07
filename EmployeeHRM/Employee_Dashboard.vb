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
        Dim choice As DialogResult
        Dim section As Integer = 1

        Do While True
            Select Case section
                Case 1
                    choice = MessageBox.Show("Welcome to [Company Name]!" & vbCrLf & vbCrLf &
                                         "Our mission is to deliver quality products and services while fostering an inclusive and innovative workplace." & vbCrLf & vbCrLf &
                                         "Next: Employment Policies?", "Welcome & Company Overview", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 2
                    choice = MessageBox.Show("Employment Classifications:" & vbCrLf &
                                         "- Probationary Employees: Up to 6 months" & vbCrLf &
                                         "- Regular Employees: Completed probation" & vbCrLf &
                                         "- Contractual / Project-based Employees: Specific projects" & vbCrLf &
                                         "- Seasonal / Casual Employees: Short-term employment" & vbCrLf & vbCrLf &
                                         "Equal Employment Opportunity: No discrimination based on age, gender, religion, disability, or marital status." & vbCrLf & vbCrLf &
                                         "Back or Next?", "Employment Policies", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 3
                    choice = MessageBox.Show("Work Hours:" & vbCrLf &
                                         "Standard: 8 hours/day, 6 days/week" & vbCrLf &
                                         "Overtime: 25% extra; Night Differential: 10% for 10 PM - 6 AM" & vbCrLf &
                                         "Attendance is monitored via HR system. Notify supervisor for absences." & vbCrLf & vbCrLf &
                                         "Back or Next?", "Work Hours & Attendance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 4
                    choice = MessageBox.Show("Payroll is semi-monthly on 15th and 30th." & vbCrLf &
                                         "Mandatory Benefits: SSS, PhilHealth, Pag-IBIG, 13th Month Pay." & vbCrLf &
                                         "Optional Benefits: HMO, allowances, wellness programs." & vbCrLf & vbCrLf &
                                         "Back or Next?", "Compensation & Benefits", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 5
                    choice = MessageBox.Show("Service Incentive Leave: 5 days/year after 1 year" & vbCrLf &
                                         "Maternity Leave: 105 days + 15 for solo parents" & vbCrLf &
                                         "Paternity Leave: 7 days" & vbCrLf &
                                         "Special Leaves: Violence Against Women 10 days, Gynecological disorders 2 months" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Leave Policies", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 6
                    choice = MessageBox.Show("Employees must maintain professionalism, integrity, and respect." & vbCrLf &
                                         "Dress Code: Smart casual; formal for meetings" & vbCrLf &
                                         "Confidentiality and data privacy must be observed" & vbCrLf &
                                         "No alcohol or drugs at workplace" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Employee Conduct & Safety", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 7
                    choice = MessageBox.Show("Resignation requires 30-day notice." & vbCrLf &
                                         "Termination follows due process." & vbCrLf &
                                         "Final pay includes unused leave and 13th Month Pay." & vbCrLf & vbCrLf &
                                         "Acknowledgment: By continuing, you agree to follow company policies." & vbCrLf & vbCrLf &
                                         "Back?", "Separation & Acknowledgment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    Else
                        Exit Do
                    End If
            End Select
        Loop
    End Sub


    Private Sub btnPolicies_Click(sender As Object, e As EventArgs) Handles btnPolicies.Click
        Dim choice As DialogResult
        Dim section As Integer = 1

        Do While True
            Select Case section
                Case 1
                    choice = MessageBox.Show("Employment Policies:" & vbCrLf &
                                         "- Probationary: Up to 6 months" & vbCrLf &
                                         "- Regular: Completed probation" & vbCrLf &
                                         "- Contractual/Project-based" & vbCrLf &
                                         "- Seasonal/Casual" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Employment Policies", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        MessageBox.Show("You are at the first section.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 2
                    choice = MessageBox.Show("Work Hours: 8h/day, 6 days/week" & vbCrLf &
                                         "Overtime: 25% extra; Night Diff: 10%" & vbCrLf &
                                         "Attendance: Notify supervisor for absences" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Work Hours & Attendance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 3
                    choice = MessageBox.Show("Compensation & Benefits:" & vbCrLf &
                                         "Payroll: Semi-monthly" & vbCrLf &
                                         "Mandatory Benefits: SSS, PhilHealth, Pag-IBIG, 13th Month Pay" & vbCrLf &
                                         "Optional: HMO, allowances, wellness programs" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Compensation & Benefits", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 4
                    choice = MessageBox.Show("Leave Policies:" & vbCrLf &
                                         "Service Incentive: 5 days/year" & vbCrLf &
                                         "Maternity: 105 + 15 days" & vbCrLf &
                                         "Paternity: 7 days" & vbCrLf &
                                         "Solo Parent: 7 days" & vbCrLf &
                                         "Special Leaves: Violence Against Women 10 days" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Leave Policies", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 5
                    choice = MessageBox.Show("Employee Conduct & Safety:" & vbCrLf &
                                         "- Professional behavior" & vbCrLf &
                                         "- Dress Code" & vbCrLf &
                                         "- Confidentiality" & vbCrLf &
                                         "- Substance-Free Workplace" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Conduct & Safety", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 6
                    choice = MessageBox.Show("Health & Safety:" & vbCrLf &
                                         "- Follow DOLE standards" & vbCrLf &
                                         "- Emergency procedures" & vbCrLf &
                                         "- Ergonomics & wellness" & vbCrLf &
                                         "- Security & cybersecurity" & vbCrLf & vbCrLf &
                                         "Back or Next?", "Health & Safety", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 7
                    choice = MessageBox.Show("Disciplinary Action & Grievance:" & vbCrLf &
                                         "- Progressive discipline: Verbal → Written → Suspension → Termination" & vbCrLf &
                                         "- Grounds for termination: Misconduct, redundancy, fraud" & vbCrLf &
                                         "- Due process & grievance mechanisms" & vbCrLf & vbCrLf &
                                         "Back?", "Disciplinary Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    Else
                        Exit Do
                    End If
            End Select
        Loop
    End Sub
    Private Sub btnForms_Click(sender As Object, e As EventArgs) Handles btnForms.Click
        Dim choice As DialogResult
        Dim section As Integer = 1

        Do While True
            Select Case section
                Case 1
                    choice = MessageBox.Show("Leave Request Form (Sample):" & vbCrLf &
                                             "Employee Name: ____________________" & vbCrLf &
                                             "Department: _______________________" & vbCrLf &
                                             "Type of Leave: ____________________" & vbCrLf &
                                             "Start Date: __/__/____ End Date: __/__/____" & vbCrLf &
                                             "Reason: ___________________________" & vbCrLf &
                                             "Supervisor Approval: ______________" & vbCrLf & vbCrLf &
                                             "Next?", "Leave Request Form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 2
                    choice = MessageBox.Show("Incident Report Form (Sample):" & vbCrLf &
                                             "Employee Name: ____________________" & vbCrLf &
                                             "Date & Time: __/__/____ at ____:____" & vbCrLf &
                                             "Location: __________________________" & vbCrLf &
                                             "Description: _______________________" & vbCrLf &
                                             "Witnesses: ________________________" & vbCrLf &
                                             "Action Taken: _____________________" & vbCrLf & vbCrLf &
                                             "Back or Next?", "Incident Report", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 3
                    choice = MessageBox.Show("Acknowledgment Form (Sample):" & vbCrLf &
                                             "I, ___________________________, acknowledge that I have received and read the Employee Handbook, policies, and company rules." & vbCrLf &
                                             "Employee Signature: _______________" & vbCrLf &
                                             "Date: __/__/____" & vbCrLf & vbCrLf &
                                             "Back or Next?", "Acknowledgment Form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 4
                    choice = MessageBox.Show("Performance Evaluation Form (Sample):" & vbCrLf &
                                             "Employee Name: ____________________" & vbCrLf &
                                             "Department: _______________________" & vbCrLf &
                                             "Evaluation Period: __/__/____ to __/__/____" & vbCrLf &
                                             "Key Responsibilities: ______________" & vbCrLf &
                                             "Achievements: _____________________" & vbCrLf &
                                             "Areas for Improvement: ____________" & vbCrLf &
                                             "Overall Rating: ____________________" & vbCrLf &
                                             "Evaluator Name & Signature: _______" & vbCrLf & vbCrLf &
                                             "Back?", "Performance Evaluation Form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    Else
                        Exit Do
                    End If
            End Select
        Loop
    End Sub

    Private Sub btnHoliday_Click(sender As Object, e As EventArgs) Handles btnHoliday.Click
        Dim choice As DialogResult
        Dim section As Integer = 1

        Do While True
            Select Case section
                Case 1
                    choice = MessageBox.Show("Regular Holidays:" & vbCrLf &
                                             "- January 1: New Year's Day" & vbCrLf &
                                             "- April 9: Araw ng Kagitingan (Day of Valor)" & vbCrLf &
                                             "- May 1: Labor Day" & vbCrLf &
                                             "- June 12: Independence Day" & vbCrLf &
                                             "- August 21: Ninoy Aquino Day" & vbCrLf &
                                             "- November 30: Bonifacio Day" & vbCrLf &
                                             "- December 25: Christmas Day" & vbCrLf &
                                             "- December 30: Rizal Day" & vbCrLf & vbCrLf &
                                             "Next?", "Regular Holidays", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 2
                    choice = MessageBox.Show("Special (Non-Working) Holidays:" & vbCrLf &
                                             "- February 25: EDSA People Power Revolution Anniversary" & vbCrLf &
                                             "- August 29: National Heroes Day (last Monday of August)" & vbCrLf &
                                             "- November 1: All Saints Day" & vbCrLf &
                                             "- December 31: Last Day of the Year" & vbCrLf & vbCrLf &
                                             "Back or Next?", "Special Holidays", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    ElseIf choice = DialogResult.No Then
                        section += 1
                    Else
                        Exit Do
                    End If

                Case 3
                    choice = MessageBox.Show("Local Holidays: Each city/province may have its own holiday." & vbCrLf &
                                             "Check your local government announcements for specific dates." & vbCrLf & vbCrLf &
                                             "Back?", "Local Holidays", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If choice = DialogResult.Yes Then
                        section -= 1
                    Else
                        Exit Do
                    End If
            End Select
        Loop
    End Sub

    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class