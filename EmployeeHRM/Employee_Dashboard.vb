Imports MySql.Data.MySqlClient

Public Class Employee_Dashboard
    Public UserRole As String

    Private Sub Employee_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & CurrentUser.Username

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

        txtEmployeeID.ReadOnly = True
        txtName.ReadOnly = True
        txtJobTitle.ReadOnly = True
        txtDepartment.ReadOnly = True

        LoadEmployeeInfo()
    End Sub
    Public Sub LoadEmployeeInfo()
        Try
            Dim query As String =
                "SELECT e.EmployeeID, " &
                "CONCAT(IFNULL(e.`First Name`, ''), ' ', IFNULL(e.`MiddleName`, ''), ' ', IFNULL(e.`LastName`, '')) AS FullName, " &
                "j.JobTitle, d.Name AS DepartmentName " &
                "FROM tblemployee e " &
                "LEFT JOIN tbljobdetails j ON e.EmployeeID = j.EmployeeID " &
                "LEFT JOIN tbldepartment d ON e.EmployeeID = d.EmployeeID " &
                "WHERE e.EmployeeID = @empID"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@empID", CurrentUser.EmployeeID)
            }

            Dim dt As DataTable = ExecuteQuery(query, parameters)

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txtEmployeeID.Text = row("EmployeeID").ToString()
                txtName.Text = row("FullName").ToString()
                txtJobTitle.Text = row("JobTitle").ToString()
                txtDepartment.Text = row("DepartmentName").ToString()
            End If
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
    Private Sub btnEmployeeHandbook_Click(sender As Object, e As EventArgs) Handles btnEmployeeHandbook.Click

        Dim content As String =
    "Welcome to Sundowners Resort!" & vbCrLf & vbCrLf &
    "We are thrilled to have you as part of our team. This handbook provides essential information about our policies, procedures, benefits, and workplace expectations." & vbCrLf & vbCrLf &
    "Our mission is to create an extraordinary experience for our guests while fostering a safe, respectful, and rewarding work environment for all employees." & vbCrLf & vbCrLf &
    "1. Mission, Vision, and Values" & vbCrLf &
    "Mission:" & vbCrLf &
    "To provide a world-class hospitality experience through professionalism, warmth, and attention to detail." & vbCrLf & vbCrLf &
    "Vision:" & vbCrLf &
    "To be the leading resort destination known for exceptional guest service, employee satisfaction, and sustainable operations." & vbCrLf & vbCrLf &
    "Core Values:" & vbCrLf &
    "- Integrity: Act with honesty and fairness in all situations." & vbCrLf &
    "- Excellence: Strive for superior performance in every task." & vbCrLf &
    "- Teamwork: Support colleagues and maintain a collaborative environment." & vbCrLf &
    "- Hospitality: Deliver memorable experiences to our guests." & vbCrLf &
    "- Sustainability: Operate responsibly, respecting the environment and community." & vbCrLf & vbCrLf &
    "2. Employment Policies" & vbCrLf &
    "Equal Opportunity:" & vbCrLf &
    "Sundowners Resort is an equal opportunity employer. Discrimination or harassment based on race, gender, religion, sexual orientation, age, disability, or any protected status is strictly prohibited." & vbCrLf & vbCrLf &
    "Employment Classification:" & vbCrLf &
    "- Full-Time: 40+ hours per week, eligible for full benefits." & vbCrLf &
    "- Part-Time: Less than 40 hours per week, eligible for some benefits." & vbCrLf &
    "- Temporary/Seasonal: Hired for specific periods; limited benefits." & vbCrLf & vbCrLf &
    "Background Checks:" & vbCrLf &
    "Employment may be contingent upon passing background and reference checks." & vbCrLf & vbCrLf &
    "Probationary Period:" & vbCrLf &
    "New employees undergo a 3-month probationary period to evaluate performance and fit." & vbCrLf & vbCrLf &
    "3. Workplace Conduct" & vbCrLf &
    "Code of Conduct:" & vbCrLf &
    "Employees are expected to demonstrate professionalism, maintain appropriate appearance, avoid conflicts of interest, and adhere to resort policies and safety guidelines." & vbCrLf & vbCrLf &
    "Harassment & Discrimination Policy:" & vbCrLf &
    "Harassment, bullying, or discrimination will not be tolerated. All incidents should be reported immediately to HR." & vbCrLf & vbCrLf &
    "Attendance and Punctuality:" & vbCrLf &
    "Consistent attendance and punctuality are critical. Unapproved absences may lead to disciplinary action." & vbCrLf & vbCrLf &
    "4. Compensation and Benefits" & vbCrLf &
    "Salary & Wages:" & vbCrLf &
    "Employees are compensated according to role, experience, and labor laws. Salaries are paid monthly." & vbCrLf & vbCrLf &
    "Benefits:" & vbCrLf &
    "- Health and dental insurance for eligible employees" & vbCrLf &
    "- Paid vacation, sick leave, and public holidays" & vbCrLf &
    "- Employee discounts on resort services and partner businesses" & vbCrLf &
    "- Meals during shifts for operational staff" & vbCrLf &
    "- Training and career development programs" & vbCrLf &
    "- Wellness programs, including fitness classes and spa discounts" & vbCrLf & vbCrLf &
    "Overtime:" & vbCrLf &
    "Overtime must be pre-approved and is compensated according to labor regulations." & vbCrLf & vbCrLf &
    "5. Work Schedule" & vbCrLf &
    "- Weekly schedules will be posted in advance." & vbCrLf &
    "- Leave requests should be submitted at least [X] days ahead." & vbCrLf &
    "- Shift swaps require managerial approval." & vbCrLf &
    "- Flexibility is sometimes needed to accommodate resort operations during peak seasons." & vbCrLf & vbCrLf &
    "6. Safety, Security, and Emergency Procedures" & vbCrLf &
    "- Follow safety guidelines for all equipment and facilities." & vbCrLf &
    "- Report any unsafe conditions immediately to your supervisor." & vbCrLf &
    "- Learn fire evacuation, first aid, and emergency protocols." & vbCrLf &
    "- Ensure guest belongings, cash, and sensitive information are secure." & vbCrLf &
    "- Participate in periodic safety drills." & vbCrLf & vbCrLf &
    "7. Guest Service Standards" & vbCrLf &
    "- Greet all guests warmly and professionally." & vbCrLf &
    "- Anticipate guest needs and provide proactive solutions." & vbCrLf &
    "- Maintain cleanliness and presentation in all areas." & vbCrLf &
    "- Handle complaints promptly, escalating when necessary." & vbCrLf &
    "- Adhere to Sundowners Resort brand standards in all interactions." & vbCrLf & vbCrLf &
    "8. Department-Specific Guidelines" & vbCrLf &
    "Front Desk / Reception:" & vbCrLf &
    "Efficient check-in/out, accurate reservation management, immediate resolution of guest concerns." & vbCrLf & vbCrLf &
    "Housekeeping:" & vbCrLf &
    "Maintain cleanliness, report maintenance issues, respect guest privacy." & vbCrLf & vbCrLf &
    "Food & Beverage:" & vbCrLf &
    "Follow hygiene protocols, provide courteous service, ensure accurate order delivery." & vbCrLf & vbCrLf &
    "Maintenance:" & vbCrLf &
    "Conduct preventive/corrective maintenance, ensure safety, report major repair needs." & vbCrLf & vbCrLf &
    "Spa & Recreation:" & vbCrLf &
    "Maintain cleanliness, ensure proper training, provide professional guest experience." & vbCrLf & vbCrLf &
    "9. Training and Development" & vbCrLf &
    "- Mandatory orientation for new employees" & vbCrLf &
    "- Ongoing skill enhancement workshops" & vbCrLf &
    "- Annual performance evaluations" & vbCrLf &
    "- Opportunities for promotions, cross-training, and leadership programs" & vbCrLf & vbCrLf &
    "10. Technology, Social Media, and Data Privacy" & vbCrLf &
    "- Use company systems responsibly." & vbCrLf &
    "- Protect guest and company data." & vbCrLf &
    "- Avoid sharing confidential information online." & vbCrLf &
    "- Maintain a professional online presence." & vbCrLf & vbCrLf &
    "11. Discipline and Termination" & vbCrLf &
    "Disciplinary Procedures: Verbal warning, written warning, suspension, termination." & vbCrLf &
    "Grounds for Immediate Termination: Theft, fraud, physical violence, serious safety violations, breach of confidentiality." & vbCrLf & vbCrLf &
    "12. Sustainability and Corporate Responsibility" & vbCrLf &
    "- Reduce waste and energy consumption" & vbCrLf &
    "- Support local communities and suppliers" & vbCrLf &
    "- Promote responsible tourism practices" & vbCrLf & vbCrLf &
    "13. Employee Recognition" & vbCrLf &
    "- Employee of the Month program" & vbCrLf &
    "- Spot awards for exceptional performance" & vbCrLf &
    "- Team outings and wellness activities" & vbCrLf &
    "- Annual awards ceremony for top performers" & vbCrLf & vbCrLf &
    "14. Acknowledgment" & vbCrLf &
    "All employees are expected to read and understand the policies and guidelines in this handbook. Compliance ensures a safe, productive, and harmonious workplace at Sundowners Resort."

        Dim boldWords As New List(Of String) From {
        "Welcome to Sundowners Resort",
        "1. Mission, Vision, and Values",
        "2. Employment Policies",
        "3. Workplace Conduct",
        "4. Compensation and Benefits",
        "5. Work Schedule",
        "6. Safety, Security, and Emergency Procedures",
        "7. Guest Service Standards",
        "8. Department-Specific Guidelines",
        "9. Training and Development",
        "10. Technology, Social Media, and Data Privacy",
        "11. Discipline and Termination",
        "12. Sustainability and Corporate Responsibility",
        "13. Employee Recognition",
        "14. Acknowledgment"
    }

        Dim italicBoldWords As New List(Of String) From {
        "Mission",
        "Vision",
        "Core Values",
        "Salary & Wages",
        "Benefits",
        "Overtime",
        "Front Desk / Reception",
        "Housekeeping",
        "Food & Beverage",
        "Maintenance",
        "Spa & Recreation"
    }

        Dim viewer As New frmInfoViewer()
        viewer.ShowInfo("Sundowners Resort Employee Handbook", content, boldWords, italicBoldWords)
    End Sub
    Private Sub btnHolidayCalendar_Click(sender As Object, e As EventArgs) Handles btnHolidayCalendar.Click
        Dim content As String =
        "Holiday Calendar – Sundowners Resort (Philippines)" & vbCrLf & vbCrLf &
        "Sundowners Resort observes national and special holidays recognized in the Philippines. Because the resort operates every day to ensure excellent guest service, staff schedules are managed on a rotational basis. Employees working on holidays receive either premium pay or compensatory leave in accordance with Philippine labor laws." & vbCrLf & vbCrLf &
        "Regular Holidays" & vbCrLf &
        "Regular holidays are mandatory and fully recognized under Philippine labor law. Employees are entitled to pay even if not scheduled to work, and those working receive additional compensation. These holidays include:" & vbCrLf & vbCrLf &
        "- New Year’s Day – January 1: A nationwide celebration marking the start of the year. Administrative staff may be off, while operational staff ensure guests receive uninterrupted service." & vbCrLf &
        "- Maundy Thursday – April 9: A Christian observance, part of Holy Week. Guest-facing operations are maintained with rotational staff coverage." & vbCrLf &
        "- Good Friday – April 10: Another Holy Week observance, widely observed across the country. Staff working this day receive compensatory leave or holiday pay." & vbCrLf &
        "- Araw ng Kagitingan – April 9: Commemorates the heroism of Filipino soldiers during World War II. Operational staff rotate shifts to maintain resort services." & vbCrLf &
        "- Labor Day – May 1: Celebrates the contributions of workers nationwide. Staff working this day may receive premium pay." & vbCrLf &
        "- Independence Day – June 12: National holiday celebrating the Philippines’ independence. Staff on duty will receive compensatory leave if applicable." & vbCrLf &
        "- National Heroes Day – August 26: Honors the country’s national heroes. Some staff work on a rotational schedule to maintain operations." & vbCrLf &
        "- Bonifacio Day – November 30: Commemorates the birth of Filipino revolutionary leader Andres Bonifcio. Operational coverage ensures uninterrupted guest service." & vbCrLf &
        "- Christmas Day – December 25: Celebrated nationwide. All departments operate, and staff on duty receive premium pay or compensatory leave." & vbCrLf &
        "- Rizal Day – December 30: Honors national hero Jose Rizal. Staff rotations are applied to maintain guest services." & vbCrLf & vbCrLf &
        "Special (Non-Working) Holidays" & vbCrLf &
        "Special holidays may vary each year and are observed at the discretion of management. Employees may request leave for these days subject to approval:" & vbCrLf &
        "- Chinese New Year – February 10: Recognized due to the Philippines’ significant Chinese-Filipino community. Staff schedules managed based on operational needs." & vbCrLf &
        "- EDSA People Power Revolution Anniversary – February 25: Commemorates the 1986 peaceful revolution. Leave requests accommodated where staffing allows." & vbCrLf &
        "- All Saints’ Day – November 1 & All Souls’ Day – November 2: Days to honor deceased loved ones. Resort operations continue; some staff rotations may apply." & vbCrLf &
        "- Feast of the Immaculate Conception – December 8: A major religious observance. Operational staff maintain service while administrative employees may have the day off." & vbCrLf &
        "Note: Dates for movable holidays such as Eid’l Fitr, Eid’l Adha, and other religious observances are announced officially and observed by employees of relevant faiths." & vbCrLf & vbCrLf &
        "Sundowners Resort-Specific Holidays" & vbCrLf &
        "- Employee Appreciation Day – TBD: Staff enjoy special recognition, activities, or additional time off." & vbCrLf &
        "- Resort Anniversary – TBD: A celebration of the resort’s founding, often including team-building events and awards." & vbCrLf &
        "- Seasonal Closure / Inventory Days – TBD: Used for maintenance, deep cleaning, or inventory management. Staff rotations and advance scheduling are applied." & vbCrLf & vbCrLf &
        "Holiday Policies" & vbCrLf &
        "- Rotational Coverage: Because Sundowners Resort operates every day, some employees are required to work on holidays. Compensatory leave or premium pay is provided according to Philippine labor law." & vbCrLf &
        "- Optional Leave Requests: Employees may request leave for personal or religious holidays not officially listed. Approval is based on staffing requirements." & vbCrLf &
        "- Advance Notice: All leave requests should be submitted at least 30 days in advance." & vbCrLf &
        "- Holiday Pay: Employees working on regular holidays receive 100% of daily wage plus applicable overtime. Special holidays worked are compensated according to Philippine labor laws." & vbCrLf &
        "- Operational Flexibility: During peak seasons (e.g., Christmas, Holy Week, summer), employees may be required to adjust schedules to ensure consistent guest service."


        Dim boldWords As New List(Of String) From {
        "Holiday Calendar – Sundowners Resort (Philippines)",
        "Regular Holidays",
        "Special (Non-Working) Holidays",
        "Sundowners Resort-Specific Holidays",
        "Holiday Policies"
    }

        Dim italicBoldWords As New List(Of String) From {
        "New Year’s Day – January 1",
        "Maundy Thursday – April 9",
        "Good Friday – April 10",
        "Araw ng Kagitingan – April 9",
        "Labor Day – May 1",
        "Independence Day – June 12",
        "National Heroes Day – August 26",
        "Bonifacio Day – November 30",
        "Christmas Day – December 25",
        "Rizal Day – December 30",
        "Chinese New Year – February 10",
        "EDSA People Power Revolution Anniversary – February 25",
        "All Saints’ Day – November 1",
        "All Souls’ Day – November 2",
        "Feast of the Immaculate Conception – December 8",
        "Employee Appreciation Day – TBD",
        "Resort Anniversary – TBD",
        "Seasonal Closure / Inventory Days – TBD"
    }

        Dim viewer As New frmInfoViewer()
        viewer.ShowInfo("Holiday Calendar – Sundowners Resort", content, boldWords, italicBoldWords)
    End Sub
    Private Sub btnPolicies_Click(sender As Object, e As EventArgs) Handles btnPolicies.Click
        Dim content =
        "Policies – Sundowners Resort" & vbCrLf & vbCrLf &
        "Sundowners Resort is committed to maintaining a professional, safe, and respectful work environment. All employees are expected to follow these policies to ensure smooth operations, exceptional guest service, and a positive workplace culture." & vbCrLf & vbCrLf &
        "Workplace Conduct" & vbCrLf &
        "   Professionalism: Employees must conduct themselves with integrity, courtesy, and respect at all times, whether interacting with guests, colleagues, or management." & vbCrLf &
        "   Dress Code & Grooming: Staff must adhere to department-specific uniforms and maintain a clean, neat, and professional appearance. Personal hygiene is mandatory." & vbCrLf &
        "   Attendance & Punctuality: Regular attendance is required. Employees must inform their supervisor promptly in case of emergencies or unavoidable absences. Chronic tardiness or absenteeism may lead to disciplinary action." & vbCrLf &
        "   Harassment & Discrimination: Harassment, bullying, or discrimination of any kind is strictly prohibited. Any reports will be investigated and may result in disciplinary action or termination." & vbCrLf &
        "   Substance Use Policy: Alcohol or illegal drugs are strictly prohibited on resort property during working hours. Prescription medications that affect performance must be reported to HR." & vbCrLf & vbCrLf &
        "Employee Responsibilities" & vbCrLf &
        "   Job Duties: Employees are expected to perform assigned duties efficiently, with attention to detail and guest satisfaction." & vbCrLf &
        "   Teamwork: Cooperation, effective communication, and support for colleagues are essential for smooth operations." & vbCrLf &
        "   Guest Service: Deliver exceptional service at all times, responding to guest needs promptly and professionally." & vbCrLf &
        "   Confidentiality: Protect all confidential information, including guest data, financial records, and proprietary operations procedures." & vbCrLf &
        "   Ethical Behavior: Avoid conflicts of interest, bribery, or any unethical activities that could harm the resort’s reputation." & vbCrLf & vbCrLf &
        "Attendance and Leave" & vbCrLf &
        "Work Schedules: Shift schedules are posted weekly. Employees must adhere to assigned shifts and notify supervisors of conflicts or emergencies." & vbCrLf &
        "   Leave Requests: Leave must be requested at least 30 days in advance. Approval depends on operational requirements." & vbCrLf &
        "   Types of Leave:" & vbCrLf &
        "- Vacation Leave: Accrued per employment contract and Philippine labor law." & vbCrLf &
        "- Sick Leave: Paid sick leave with a doctor’s certificate for extended absences." & vbCrLf &
        "- Emergency Leave: For urgent personal or family matters." & vbCrLf &
        "- Maternity/Paternity Leave: Provided per Philippine labor law." & vbCrLf &
        "- Special Leave: For personal, religious, or cultural observances." & vbCrLf & vbCrLf &
        "Compensation and Benefits" & vbCrLf &
        "   Salary & Wages: Paid monthly according to employment classification." & vbCrLf &
        "   Overtime Pay: Employees working beyond regular hours are compensated per Philippine labor law." & vbCrLf &
        "   Holiday Pay: Regular holiday work receives 100% pay plus applicable overtime, while special holiday work is compensated per labor regulations." & vbCrLf &
        "   Employee Benefits: Health insurance, meal allowances, employee discounts, training programs, and wellness initiatives." & vbCrLf &
        "   Performance Incentives: Spot bonuses or recognition awards for exceptional work." & vbCrLf & vbCrLf &
        "Safety, Security, and Emergency Procedures" & vbCrLf &
        "   Workplace Safety: Follow all safety protocols and immediately report unsafe conditions." & vbCrLf &
        "   Fire & Emergency Preparedness: Know evacuation routes, emergency exits, and fire safety procedures. Participate in regular drills." & vbCrLf &
        "   Guest & Property Security: Protect guest belongings and resort property. Theft or negligence may result in immediate termination." & vbCrLf &
        "   Accident Reporting: Report all workplace accidents or injuries immediately to a supervisor." & vbCrLf & vbCrLf &
        "Technology and Social Media" & vbCrLf &
        "   Use of Company Systems: Resort computers, phones, and other equipment are for work purposes only." & vbCrLf &
        "   Social Media Policy: Do not post confidential resort or guest information. Public posts representing Sundowners Resort should maintain professionalism." & vbCrLf &
        "   Email and Communication: Maintain professional conduct in all internal and external communications." & vbCrLf & vbCrLf &
        "Performance and Training" & vbCrLf &
        "   Orientation & Training: New employees complete mandatory orientation and department-specific training." & vbCrLf &
        "   Continuous Development: Employees are encouraged to attend workshops, courses, and certification programs." & vbCrLf &
        "   Performance Reviews: Conducted annually to provide feedback and support career growth." & vbCrLf &
        "   Promotion & Career Development: Opportunities based on performance, merit, and skill development." & vbCrLf & vbCrLf &
        "Discipline and Termination" & vbCrLf &
        "   Progressive Discipline: Verbal warning → Written warning → Suspension → Termination" & vbCrLf &
        "   Immediate Termination: Theft, violence, harassment, major safety violations, or breach of confidentiality." & vbCrLf &
        "   Grievance Reporting: Employees can report workplace concerns to HR or supervisors without fear of retaliation." & vbCrLf & vbCrLf &
        "Environmental and Social Responsibility" & vbCrLf &
        "   Sustainability Practices: Reduce waste, conserve energy, and follow eco-friendly procedures." & vbCrLf &
        "   Responsible Tourism: Support and promote sustainable tourism initiatives with guests." & vbCrLf &
        "   Community Engagement: Participate in local community programs and charitable activities organized by the resort." & vbCrLf & vbCrLf &
        "Guest Interaction Guidelines" & vbCrLf &
        "   Customer Service Excellence: Greet guests warmly, anticipate needs, and handle complaints efficiently." & vbCrLf &
        "   Cultural Sensitivity: Respect the diverse backgrounds of guests and colleagues." & vbCrLf &
        "   Problem Resolution: Resolve issues promptly or escalate to supervisors as needed." & vbCrLf &
        "   Privacy: Maintain strict confidentiality regarding guest information and activities." & vbCrLf & vbCrLf &
        "Employee Wellness and Support" & vbCrLf &
        "   Wellness Programs: Access to fitness activities, spa discounts, and mental health resources." & vbCrLf &
        "   Stress Management: Supervisors are encouraged to monitor workloads and support staff during high-demand periods." & vbCrLf &
        "   Work-Life Balance: Scheduling attempts to balance operational needs with personal time off." & vbCrLf &
        "   Open-Door Policy: Employees may approach management or HR with questions, suggestions, or concerns." & vbCrLf & vbCrLf &
        "Recognition and Rewards" & vbCrLf &
        "   Employee of the Month: Recognizes consistent excellence in service and teamwork." & vbCrLf &
        "   Spot Awards: For outstanding performance, initiative, or exceptional guest feedback." & vbCrLf &
        "   Team Events: Regular team-building activities and wellness programs." & vbCrLf &
        "   Annual Awards Ceremony: Celebrates top performers and departmental achievements."

        Dim boldWords As New List(Of String) From {
        "Policies – Sundowners Resort (Expanded)",
        "Workplace Conduct",
        "Employee Responsibilities",
        "Attendance and Leave",
        "Compensation and Benefits",
        "Safety, Security, and Emergency Procedures",
        "Technology and Social Media",
        "Performance and Training",
        "Discipline and Termination",
        "Environmental and Social Responsibility",
        "Guest Interaction Guidelines",
        "Employee Wellness and Support",
        "Recognition and Rewards"
    }

        Dim italicBoldWords As New List(Of String) From {
        "Professionalism",
        "Dress Code & Grooming",
        "Attendance & Punctuality",
        "Harassment & Discrimination",
        "Substance Use Policy",
        "Job Duties",
        "Teamwork",
        "Guest Service",
        "Confidentiality",
        "Salary & Wages",
        "Overtime Pay",
        "Holiday Pay",
        "Employee Benefits",
        "Performance Incentives",
        "Workplace Safety",
        "Fire & Emergency Preparedness",
        "Guest & Property Security",
        "Accident Reporting",
        "Use of Company Systems",
        "Social Media Policy",
        "Email and Communication",
        "Orientation & Training",
        "Continuous Development",
        "Performance Reviews",
        "Promotion & Career Development",
        "Progressive Discipline",
        "Immediate Termination",
        "Grievance Reporting",
        "Sustainability Practices",
        "Responsible Tourism",
        "Community Engagement",
        "Customer Service Excellence",
        "Cultural Sensitivity",
        "Problem Resolution",
        "Privacy",
        "Wellness Programs",
        "Stress Management",
        "Work-Life Balance",
        "Open-Door Policy",
        "Employee of the Month",
        "Spot Awards",
        "Team Events",
        "Annual Awards Ceremony"
    }

        Dim viewer As New frmInfoViewer
        viewer.ShowInfo("Policies – Sundowners Resort", content, boldWords, italicBoldWords)
    End Sub
    Private Sub btnSafetyInfo_Click(sender As Object, e As EventArgs) Handles btnSafetyInfo.Click
        Dim content As String =
        "Safety and Emergency Information – Sundowners Resort" & vbCrLf & vbCrLf &
        "At Sundowners Resort, the safety of our guests, employees, and property is our highest priority. All staff are expected to comply with safety policies, participate in emergency preparedness programs, and take proactive steps to prevent accidents." & vbCrLf & vbCrLf &
        "General Workplace Safety" & vbCrLf &
        "   Hazard Awareness: Report unsafe conditions, broken equipment, or spills immediately." & vbCrLf &
        "   Equipment Safety: Operate machinery, kitchen equipment, and cleaning tools only if trained and authorized." & vbCrLf &
        "   Personal Protective Equipment (PPE)_**: Always wear required PPE in kitchens, maintenance areas, housekeeping, or other high-risk departments." & vbCrLf &
        "   Ergonomics & Injury Prevention_**: Lift objects safely, use proper posture, take breaks to prevent strain, and seek assistance when handling heavy items." & vbCrLf &
        "   Chemical Safety: Follow instructions when handling cleaning chemicals, store chemicals safely, and use protective gloves or masks as required." & vbCrLf & vbCrLf &
        "Fire Safety" & vbCrLf &
        "   Fire Prevention: Keep corridors, emergency exits, and stairways clear. Report faulty wiring, exposed circuits, or flammable materials immediately." & vbCrLf &
        "   Fire Extinguishers: Know locations and proper use of fire extinguishers in your area." & vbCrLf &
        "   Fire Drills: Participate actively and familiarize yourself with evacuation routes and assembly points." & vbCrLf &
        "   In Case of Fire: Alert nearby guests and staff. Activate the nearest fire alarm. Evacuate calmly via the designated route. Assemble at the designated safety point and follow instructions from the Safety Officer." & vbCrLf & vbCrLf &
        "   Medical Emergencies" & vbCrLf &
        "   First Aid: First aid kits are available in all departments. Staff trained in first aid should respond until professional help arrives." & vbCrLf &
        "   Accident Reporting: Report all injuries, no matter how minor, to supervisors and complete an incident report." & vbCrLf &
        "   Emergency Medical Contacts_**: Keep local hospital, ambulance, and resort emergency numbers accessible." & vbCrLf & vbCrLf &
        "Natural Disasters" & vbCrLf &
        "   Typhoons/Storms: Secure outdoor furniture, equipment, and windows. Move guests to safe areas if necessary." & vbCrLf &
        "   Earthquakes: Drop, cover, and hold on. Evacuate calmly after shaking stops. Avoid elevators." & vbCrLf &
        "   Floods/Landslides: Move to higher ground and follow management and local authority instructions." & vbCrLf & vbCrLf &
        "Guest Safety and Special Areas" & vbCrLf &
        "   Pools and Water Activities: Lifeguards or trained staff must always be present. Enforce pool rules and monitor guests. Respond to accidents promptly following CPR/first aid protocols." & vbCrLf &
        "   Kitchen & Food Safety: Follow hygiene standards, prevent cross-contamination, use heat-resistant gloves and cut-resistant tools, report gas leaks or equipment malfunctions immediately." & vbCrLf &
        "   Maintenance & Equipment Safety: Only trained staff may operate machinery. Lockout/tagout procedures must be followed. Report broken equipment promptly." & vbCrLf &
        "   Guest Rooms and Housekeeping: Use ladders safely, follow chemical safety protocols, mark wet floors, respect guest privacy." & vbCrLf & vbCrLf &
        "Fire, Earthquake, and Emergency Drills" & vbCrLf &
        "Conducted regularly in all departments. Employees must know evacuation routes, assembly points, and participate actively to assist guests." & vbCrLf & vbCrLf &
        "Emergency Communication" & vbCrLf &
        "   Internal Communication: Use radios, phones, or messaging systems to report incidents." & vbCrLf &
        "   External Contacts: Local Police: 117, Fire Department: 160, Local Hospital/Ambulance: [Insert contact], Resort Security: [Insert contact], Front Desk/Reception: [Insert contact]" & vbCrLf & vbCrLf &
        "Health and Wellness Safety" & vbCrLf &
        "   Infectious Diseases: Follow sanitation protocols, hand hygiene, mask policies during outbreaks." & vbCrLf &
        "   Sanitation: Maintain clean workspaces, kitchens, and guest areas. Dispose of waste safely." & vbCrLf &
        "   Heat & Sun Safety_**: Stay hydrated, wear sun protection, take scheduled breaks." & vbCrLf &
        "   Mental Health: Supervisors monitor workloads to prevent stress. Access to wellness programs and counseling is available." & vbCrLf & vbCrLf &
        "Emergency Roles and Responsibilities" & vbCrLf &
        "   Employees: Follow procedures, report hazards, assist guests." & vbCrLf &
        "   Supervisors: Ensure staff trained, monitor compliance, coordinate response." & vbCrLf &
        "   Management: Conduct risk assessments, update policies, provide training and resources." & vbCrLf & vbCrLf &
        "Incident Reporting" & vbCrLf &
        "Report all accidents, near misses, or security breaches immediately to supervisors and HR. Document incidents properly for follow-up." & vbCrLf & vbCrLf &
        "Preparedness and Training" & vbCrLf &
        "All staff receive mandatory safety training during onboarding. Periodic drills simulate emergencies, with department-specific training for high-risk areas."

        Dim boldWords As New List(Of String) From {
        "Safety and Emergency Information – Sundowners Resort",
        "General Workplace Safety",
        "Fire Safety",
        "Medical Emergencies",
        "Natural Disasters",
        "Guest Safety and Special Areas",
        "Fire, Earthquake, and Emergency Drills",
        "Emergency Communication",
        "Health and Wellness Safety",
        "Emergency Roles and Responsibilities",
        "Incident Reporting",
        "Preparedness and Training"
    }

        Dim italicBoldWords As New List(Of String) From {
        "Hazard Awareness",
        "Equipment Safety",
        "Personal Protective Equipment (PPE)",
        "Ergonomics & Injury Prevention",
        "Chemical Safety",
        "Fire Prevention",
        "Fire Extinguishers",
        "Fire Drills",
        "In Case of Fire",
        "First Aid",
        "Accident Reporting",
        "Emergency Medical Contacts",
        "Typhoons/Storms",
        "Earthquakes",
        "Floods/Landslides",
        "Pools and Water Activities",
        "Kitchen & Food Safety",
        "Maintenance & Equipment Safety",
        "Guest Rooms and Housekeeping",
        "Internal Communication",
        "External Contacts",
        "Infectious Diseases",
        "Sanitation",
        "Heat & Sun Safety",
        "Mental Health",
        "Employees",
        "Supervisors",
        "Management"
    }

        Dim viewer As New frmInfoViewer()
        viewer.ShowInfo("Safety and Emergency Information – Sundowners Resort", content, boldWords, italicBoldWords)
    End Sub
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            HRMModule.SignOut(Me)
            MessageBox.Show("You have been signed out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class
