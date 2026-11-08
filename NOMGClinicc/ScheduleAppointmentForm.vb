Imports System.IO

Public Class ScheduleAppointmentForm
    Private schedulesFilePath As String = GetFilePath("schedules.txt")
    Public currentUserPhone As String = ""

    Public Sub New(phoneNumber As String)
        InitializeComponent()
        currentUserPhone = phoneNumber
    End Sub

    ' Schedule appointment button
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        ' First check if patient has pending balance
        If HasPendingBalance(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("You have pending balance. Please settle your payments before booking a new appointment.",
                          "Pending Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate date is not today or in past
        If dtpSchedule.Value.Date <= DateTime.Today Then
            MessageBox.Show("Cannot schedule appointments for today or past dates. Please select a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate time and purpose selected
        If String.IsNullOrEmpty(cmbTime.Text) Then
            MessageBox.Show("Please select a time slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(cmbPurpose.Text) Then
            MessageBox.Show("Please select a purpose.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate user session
        If String.IsNullOrEmpty(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("No user session found. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            PatientLoginForm1.Show()
            Return
        End If

        ' Check for schedule conflict
        If CheckScheduleConflict(dtpSchedule.Value.ToShortDateString(), cmbTime.Text, txtDoctor.Text) Then
            MessageBox.Show("This time slot is no longer available.", "Time Slot Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UpdateAvailableSlots()
            Return
        End If

        ' Generate appointment ID and create record
        Dim appointmentID As Integer = GetNextID(schedulesFilePath)
        Dim record As String = appointmentID.ToString() + "|" +
                GlobalVariables.CurrentUserPhone + "|" +
                "|" +  ' Patient Name (empty, will be filled in PatientDetailsForm)
                txtDoctor.Text + "|" +
                dtpSchedule.Value.ToShortDateString() + "|" +
                cmbTime.Text + "|" +
                cmbPurpose.Text + "|" +
                "Pending" + "|" +  ' Status is ALWAYS "Pending" for new appointments
                DateTime.Now.ToString("MM/dd/yyyy HH:mm")

        ' Save appointment
        Try
            File.AppendAllText(schedulesFilePath, record & Environment.NewLine)
            MessageBox.Show("Appointment scheduled successfully!" & Environment.NewLine &
                    "Date: " & dtpSchedule.Value.ToShortDateString() & Environment.NewLine &
                    "Time: " & cmbTime.Text & Environment.NewLine &
                    "Purpose: " & cmbPurpose.Text & Environment.NewLine &
                    "Status: Pending (Awaiting confirmation)",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            Me.Hide()

            ' Redirect to patient registration
            Dim form5 As New PatientDetailsForm()
            form5.AppointmentDate = dtpSchedule.Value
            form5.Show()

        Catch ex As Exception
            MessageBox.Show("Error saving appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Check if patient has any pending balance
    Private Function HasPendingBalance(phoneNumber As String) As Boolean
        Try
            Dim billingFilePath As String = GetFilePath("billing.txt")
            If Not File.Exists(billingFilePath) Then Return False

            Dim lines As String() = File.ReadAllLines(billingFilePath)

            ' Check for any incomplete payments for this patient
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim fields As String() = line.Split("|"c)

                    ' Check if this is the current patient's record
                    ' Format: PatientName|PhoneNumber|VisitType|VisitPrice|Vitamins|TotalAmount|AmountPaid|PaymentDate|Status
                    If fields.Length >= 9 AndAlso fields(1).Trim() = phoneNumber.Trim() Then
                        Dim paymentStatus As String = fields(8).Trim() ' Status field index (now index 8)

                        ' Check if payment status is "Pending" (not "Complete")
                        If paymentStatus = "Pending" Then
                            Return True ' Found pending balance
                        End If
                    End If
                End If
            Next

            ' Also check for appointments that haven't been billed yet
            ' This would be appointments with status "Pending" but no billing record
            If HasUnbilledAppointments(phoneNumber) Then
                Return True
            End If

            Return False ' No pending balance found
        Catch ex As Exception
            ' If error occurs, assume no pending balance to avoid blocking legitimate bookings
            Return False
        End Try
    End Function

    ' Check if patient has appointments that haven't been billed yet
    Private Function HasUnbilledAppointments(phoneNumber As String) As Boolean
        Try
            Dim schedulesFilePath As String = GetFilePath("schedules.txt")
            Dim billingFilePath As String = GetFilePath("billing.txt")

            If Not File.Exists(schedulesFilePath) Then Return False

            ' Get all appointments for this patient
            Dim appointmentLines As String() = File.ReadAllLines(schedulesFilePath)
            For Each appointmentLine As String In appointmentLines
                If appointmentLine.Trim() <> "" Then
                    Dim appointmentFields As String() = appointmentLine.Split("|"c)

                    If appointmentFields.Length >= 8 AndAlso appointmentFields(1).Trim() = phoneNumber.Trim() Then
                        Dim appointmentStatus As String = GetValidStatus(appointmentFields(7).Trim())

                        ' If appointment is "Pending", check if it has a corresponding billing record
                        If appointmentStatus = "Pending" Then
                            ' Check if there's a billing record for this patient with status "Pending"
                            If Not File.Exists(billingFilePath) Then
                                ' If no billing file exists but there's a pending appointment, 
                                ' then there's an unbilled appointment
                                Return True
                            Else
                                Dim hasPendingBillingRecord As Boolean = False
                                Dim billingLines As String() = File.ReadAllLines(billingFilePath)

                                For Each billingLine As String In billingLines
                                    If billingLine.Trim() <> "" Then
                                        Dim billingFields As String() = billingLine.Split("|"c)

                                        ' Check if this billing record is for the same patient with status "Pending"
                                        ' Format: PatientName|PhoneNumber|VisitType|VisitPrice|Vitamins|TotalAmount|AmountPaid|PaymentDate|Status
                                        If billingFields.Length >= 9 AndAlso
                                           billingFields(1).Trim() = phoneNumber.Trim() AndAlso
                                           billingFields(8).Trim() = "Pending" Then
                                            hasPendingBillingRecord = True
                                            Exit For
                                        End If
                                    End If
                                Next

                                ' If no pending billing record found for this pending appointment
                                If Not hasPendingBillingRecord Then
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Check if time slot is already booked
    Private Function CheckScheduleConflict(apptDate As String, time As String, doctor As String) As Boolean
        If Not File.Exists(schedulesFilePath) Then Return False

        Try
            Dim lines As String() = File.ReadAllLines(schedulesFilePath)
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim fields As String() = line.Split("|"c)
                    If fields.Length >= 8 Then
                        ' Check if this appointment is for the same doctor, date, and time
                        If fields(3).Trim() = doctor AndAlso fields(4).Trim() = apptDate AndAlso fields(5).Trim() = time Then

                            ' Get the status field (index 7)
                            Dim status As String = GetValidStatus(fields(7).Trim())

                            ' Get appointment date and time
                            Dim appointmentDateStr As String = fields(4).Trim()
                            Dim appointmentTime As String = fields(5).Trim()

                            ' Parse appointment date
                            Dim appointmentDate As DateTime
                            If DateTime.TryParseExact(appointmentDateStr, "MM/dd/yyyy", Nothing, Globalization.DateTimeStyles.None, appointmentDate) OrElse
                               DateTime.TryParseExact(appointmentDateStr, "M/d/yyyy", Nothing, Globalization.DateTimeStyles.None, appointmentDate) OrElse
                               DateTime.TryParse(appointmentDateStr, appointmentDate) Then

                                ' Combine date and time to get full appointment datetime
                                Dim appointmentDateTime As DateTime = GetDateTimeFromTimeSlot(appointmentDate, appointmentTime)
                                Dim currentDateTime As DateTime = DateTime.Now

                                ' IMPORTANT CHANGE: Keep the slot booked until the appointment time has passed
                                ' This applies to ALL appointments regardless of payment status
                                If appointmentDateTime > currentDateTime Then
                                    ' This is a future appointment - it should block the time slot
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            ' Ignore error for conflict check
        End Try
        Return False
    End Function

    ' Helper function to convert time slot string to DateTime
    Private Function GetDateTimeFromTimeSlot(datePart As DateTime, timeSlot As String) As DateTime
        Try
            ' Parse the time string (e.g., "09:00 AM")
            Dim timeParts As String() = timeSlot.Split(" "c)
            Dim timeValue As String = timeParts(0)
            Dim amPm As String = timeParts(1)

            Dim hourMinute As String() = timeValue.Split(":"c)
            Dim hour As Integer = Integer.Parse(hourMinute(0))
            Dim minute As Integer = Integer.Parse(hourMinute(1))

            ' Convert to 24-hour format if needed
            If amPm.ToUpper() = "PM" AndAlso hour <> 12 Then
                hour += 12
            ElseIf amPm.ToUpper() = "AM" AndAlso hour = 12 Then
                hour = 0
            End If

            Return New DateTime(datePart.Year, datePart.Month, datePart.Day, hour, minute, 0)
        Catch ex As Exception
            ' If parsing fails, return date at 9:00 AM as default
            Return New DateTime(datePart.Year, datePart.Month, datePart.Day, 9, 0, 0)
        End Try
    End Function

    ' Helper function to ensure status is either "Pending" or "Completed"
    Private Function GetValidStatus(status As String) As String
        If status = "Pending" OrElse status = "Completed" Then
            Return status
        Else
            ' If status is something else (like old "Scheduled" or "Cancelled"), treat it as "Pending"
            Return "Pending"
        End If
    End Function

    ' Check for scheduling conflicts
    Private Sub btnCheckConflicts_Click(sender As Object, e As EventArgs) 
        ' First check if patient has pending balance
        If HasPendingBalance(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("You have pending balance. Please settle your payments before checking for available slots.",
                          "Pending Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate date is not today or in past
        If dtpSchedule.Value.Date <= DateTime.Today Then
            MessageBox.Show("Cannot check availability for today or past dates. Please select a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(cmbTime.Text) Then
            MessageBox.Show("Please select a time slot first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedDate As DateTime = dtpSchedule.Value
        Dim selectedTime As String = cmbTime.Text
        Dim selectedDoctor As String = txtDoctor.Text

        ' Check if clinic is closed (Sunday or Monday)
        If selectedDate.DayOfWeek = DayOfWeek.Sunday OrElse selectedDate.DayOfWeek = DayOfWeek.Monday Then
            MessageBox.Show("Clinic is closed on Sundays and Mondays.", "Clinic Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check time slot availability
        If CheckScheduleConflict(selectedDate.ToShortDateString(), selectedTime, selectedDoctor) Then
            MessageBox.Show("This time slot is already booked.", "Time Slot Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("No conflicts found. Time slot is available!", "No Conflicts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Update available time slots when date changes
    Private Sub dtpSchedule_ValueChanged(sender As Object, e As EventArgs) Handles dtpSchedule.ValueChanged
        UpdateAvailableSlots()
    End Sub

    ' Update available time slots display
    Private Sub UpdateAvailableSlots()
        Dim selectedDate As DateTime = dtpSchedule.Value
        Dim timeLabels As Dictionary(Of String, Label) = GetTimeSlotLabels()

        cmbTime.Items.Clear()
        cmbTime.Text = ""

        ' Check for today or past date
        If selectedDate.Date <= DateTime.Today Then
            txtSched.Text = "INVALID: Cannot schedule appointments for today or past dates"
            For Each label In timeLabels.Values
                label.Text = "INVALID DATE"
                label.BackColor = Color.LightYellow
                label.ForeColor = Color.DarkOrange
                label.Enabled = False
            Next
            Return
        End If

        ' Check for clinic closure
        If selectedDate.DayOfWeek = DayOfWeek.Sunday OrElse selectedDate.DayOfWeek = DayOfWeek.Monday Then
            txtSched.Text = "CLINIC CLOSED ON SUNDAYS AND MONDAYS"
            For Each label In timeLabels.Values
                label.Text = "CLOSED"
                label.BackColor = Color.LightGray
                label.ForeColor = Color.DarkGray
                label.Enabled = False
            Next
            Return
        Else
            txtSched.Text = "Available slots for " & txtDoctor.Text & " on " & selectedDate.ToString("dddd · MMMM dd, yyyy")
            For Each label In timeLabels.Values
                label.Enabled = True
            Next
        End If

        ' Update each time slot display
        For Each timeSlot In timeLabels
            Dim time As String = timeSlot.Key
            Dim label As Label = timeSlot.Value

            Dim isBooked As Boolean = CheckScheduleConflict(selectedDate.ToShortDateString(), time, txtDoctor.Text)

            If isBooked Then
                label.Text = time & " - BOOKED"
                label.BackColor = Color.LightCoral
                label.ForeColor = Color.DarkRed
            Else
                label.Text = time & " - AVAILABLE"
                label.BackColor = Color.LightGreen
                label.ForeColor = Color.DarkGreen
                cmbTime.Items.Add(time)
            End If
        Next
    End Sub

    ' Get all time slot labels
    Private Function GetTimeSlotLabels() As Dictionary(Of String, Label)
        Return New Dictionary(Of String, Label) From {
            {"09:00 AM", lbl9AM},
            {"10:00 AM", lbl10AM},
            {"11:00 AM", lbl11AM},
            {"02:00 PM", lbl2PM},
            {"03:00 PM", lbl3PM},
            {"04:00 PM", lbl4PM}
        }
    End Function

    ' Time slot click handlers - select time in combo box
    Private Sub lbl9AM_Click(sender As Object, e As EventArgs) Handles lbl9AM.Click
        If lbl9AM.Text.Contains("AVAILABLE") Then cmbTime.Text = "09:00 AM"
    End Sub

    Private Sub lbl10AM_Click(sender As Object, e As EventArgs) Handles lbl10AM.Click
        If lbl10AM.Text.Contains("AVAILABLE") Then cmbTime.Text = "10:00 AM"
    End Sub

    Private Sub lbl11AM_Click(sender As Object, e As EventArgs) Handles lbl11AM.Click
        If lbl11AM.Text.Contains("AVAILABLE") Then cmbTime.Text = "11:00 AM"
    End Sub

    Private Sub lbl2PM_Click(sender As Object, e As EventArgs) Handles lbl2PM.Click
        If lbl2PM.Text.Contains("AVAILABLE") Then cmbTime.Text = "02:00 PM"
    End Sub

    Private Sub lbl3PM_Click(sender As Object, e As EventArgs) Handles lbl3PM.Click
        If lbl3PM.Text.Contains("AVAILABLE") Then cmbTime.Text = "03:00 PM"
    End Sub

    Private Sub lbl4PM_Click(sender As Object, e As EventArgs) Handles lbl4PM.Click
        If lbl4PM.Text.Contains("AVAILABLE") Then cmbTime.Text = "04:00 PM"
    End Sub

    ' Clear form selections
    Private Sub ClearForm()
        cmbPurpose.SelectedIndex = -1
        cmbPurpose.Text = ""
        cmbTime.SelectedIndex = -1
        cmbTime.Text = ""
        UpdateAvailableSlots()
    End Sub

    ' Form load - initialize controls
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDoctor.Text = "Dr. Nom"
        txtDoctor.ReadOnly = True
        cmbPurpose.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTime.DropDownStyle = ComboBoxStyle.DropDownList

        ' Setup purpose options
        If cmbPurpose.Items.Count = 0 Then
            cmbPurpose.Items.Add("Initial Checkup")
            cmbPurpose.Items.Add("Follow-up Checkup")
            cmbPurpose.Items.Add("Emergency")
            cmbPurpose.Items.Add("Consultation")
        End If

        ' Set minimum date to tomorrow to prevent selecting today or past dates
        dtpSchedule.MinDate = DateTime.Today.AddDays(1)

        ' Set default date to tomorrow (skip Sunday/Monday if needed)
        Dim tomorrow As DateTime = DateTime.Today.AddDays(1)
        If tomorrow.DayOfWeek = DayOfWeek.Sunday Then
            dtpSchedule.Value = tomorrow.AddDays(1) ' Monday
        ElseIf tomorrow.DayOfWeek = DayOfWeek.Monday Then
            dtpSchedule.Value = tomorrow.AddDays(1) ' Tuesday
        Else
            dtpSchedule.Value = tomorrow ' Tomorrow (Tuesday-Saturday)
        End If

        UpdateAvailableSlots()
    End Sub

    ' Cancel button - return to previous form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearForm()
        Me.Hide()
        If AdminLoginForm.admin = "admin" And AdminLoginForm.adminPass = "admin123" Then
            AdminMenuForm.Show()
        Else
            PatientMenuForm.Show()
        End If
    End Sub

End Class