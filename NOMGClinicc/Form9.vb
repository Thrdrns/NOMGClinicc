Imports System.IO

Public Class Form9
    Private schedulesFilePath As String = GetFilePath("schedules.txt")
    Public currentUserPhone As String = ""

    Public Sub New(phoneNumber As String)
        InitializeComponent()
        currentUserPhone = phoneNumber
    End Sub

    ' Schedule appointment button
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
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
            Form14.Show()
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
                "|" +
                txtDoctor.Text + "|" +
                dtpSchedule.Value.ToShortDateString() + "|" +
                cmbTime.Text + "|" +
                cmbPurpose.Text + "|" +
                "Scheduled" + "|" +
                DateTime.Now.ToString("MM/dd/yyyy HH:mm")

        ' Save appointment
        Try
            File.AppendAllText(schedulesFilePath, record & Environment.NewLine)
            MessageBox.Show("Appointment scheduled successfully!" & Environment.NewLine &
                    "Date: " & dtpSchedule.Value.ToShortDateString() & Environment.NewLine &
                    "Time: " & cmbTime.Text & Environment.NewLine &
                    "Purpose: " & cmbPurpose.Text,
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            Me.Hide()

            ' Redirect to patient registration
            Dim form5 As New Form5()
            form5.AppointmentDate = dtpSchedule.Value
            form5.Show()

        Catch ex As Exception
            MessageBox.Show("Error saving appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Check if time slot is already booked
    Private Function CheckScheduleConflict(apptDate As String, time As String, doctor As String) As Boolean
        If Not File.Exists(schedulesFilePath) Then Return False

        Try
            Dim lines As String() = File.ReadAllLines(schedulesFilePath)
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim fields As String() = line.Split("|"c)
                    If fields.Length >= 6 Then
                        If fields.Length < 8 OrElse fields(7).Trim() <> "Cancelled" Then
                            If fields(3).Trim() = doctor AndAlso fields(4).Trim() = apptDate AndAlso fields(5).Trim() = time Then
                                Return True
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

    ' Check for scheduling conflicts
    Private Sub btnCheckConflicts_Click(sender As Object, e As EventArgs) Handles btnCheckConflicts.Click
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
        If Form2.admin = "admin" And Form2.adminPass = "admin123" Then
            Form3.Show()
        Else
            Form4.Show()
        End If
    End Sub

End Class