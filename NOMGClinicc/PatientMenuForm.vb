Imports System.IO

Public Class PatientMenuForm

    ' Billing button - opens billing form if patient exists and has PENDING status
    Private Sub btnBillingAndPayments_Click(sender As Object, e As EventArgs) Handles btnBillingAndPayments.Click
        ' First check if patient exists
        If Not PatientExists(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("Patient data not found! Please register first.", "No Patient Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if patient has PENDING status
        Dim patientStatus As String = GetPatientStatus(GlobalVariables.CurrentUserPhone)
        Dim appointmentStatus As String = GetAppointmentStatus(GlobalVariables.CurrentUserPhone)

        ' Debug: Show what statuses were found
        'MessageBox.Show($"Patient Status: {patientStatus}, Appointment Status: {appointmentStatus}", "Debug Info")

        ' If both statuses are "Completed", show message
        If patientStatus = "Completed" AndAlso appointmentStatus = "Completed" Then
            MessageBox.Show("No patient record found that are pending. All records are completed.",
                          "No Pending Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' If patient status is "Completed" but appointment is not (or vice versa), show appropriate message
        If patientStatus = "Completed" Then
            MessageBox.Show("Patient record is already completed.", "Patient Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If appointmentStatus = "Completed" Then
            MessageBox.Show("Appointment is already completed.", "Appointment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' If patient status is "Not Found", it means no Pending patient record exists
        If patientStatus = "Not Found" Then
            MessageBox.Show("No pending patient record found. Please complete your registration first.",
                          "No Pending Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' If appointment status is "Not Found", it means no Pending appointment exists
        If appointmentStatus = "Not Found" Then
            MessageBox.Show("No pending appointment found. Please schedule an appointment first.",
                          "No Pending Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' If we get here, at least one is Pending, proceed with billing
        Dim billingForm As New BillingAndPaymentForm(GlobalVariables.CurrentUserPhone)
        billingForm.Show()
        Me.Hide()
    End Sub

    ' Check if patient record exists (regardless of status)
    Private Function PatientExists(phoneNumber As String) As Boolean
        Try
            Dim patientsFilePath As String = GlobalVariables.GetFilePath("patients.txt")
            If Not File.Exists(patientsFilePath) Then Return False

            Dim patientLines = File.ReadAllLines(patientsFilePath)
            For Each line In patientLines
                Dim fields = line.Split("|"c)
                If fields.Length >= 15 AndAlso fields(13).Trim() = phoneNumber.Trim() Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Get patient status (Pending or Completed) - Find the MOST RECENT Pending record
    Private Function GetPatientStatus(phoneNumber As String) As String
        Try
            Dim patientsFilePath As String = GlobalVariables.GetFilePath("patients.txt")
            If Not File.Exists(patientsFilePath) Then Return "Not Found"

            Dim patientLines = File.ReadAllLines(patientsFilePath)

            ' First, try to find a Pending record (most recent first)
            For i As Integer = patientLines.Length - 1 To 0 Step -1
                Dim line As String = patientLines(i)
                If line.Trim() <> "" Then
                    Dim fields = line.Split("|"c)
                    If fields.Length >= 15 AndAlso fields(13).Trim() = phoneNumber.Trim() Then
                        Dim status As String = fields(14).Trim() ' Status field
                        If status = "Pending" Then
                            Return "Pending"
                        End If
                    End If
                End If
            Next

            ' If no Pending found, check if any Completed records exist
            For i As Integer = patientLines.Length - 1 To 0 Step -1
                Dim line As String = patientLines(i)
                If line.Trim() <> "" Then
                    Dim fields = line.Split("|"c)
                    If fields.Length >= 15 AndAlso fields(13).Trim() = phoneNumber.Trim() Then
                        Dim status As String = fields(14).Trim() ' Status field
                        If status = "Completed" Then
                            Return "Completed"
                        End If
                    End If
                End If
            Next

            Return "Not Found"
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    ' Get appointment status (Pending or Completed) - Find the MOST RECENT Pending appointment
    Private Function GetAppointmentStatus(phoneNumber As String) As String
        Try
            Dim schedulesFilePath As String = GlobalVariables.GetFilePath("schedules.txt")
            If Not File.Exists(schedulesFilePath) Then Return "Not Found"

            Dim scheduleLines = File.ReadAllLines(schedulesFilePath)

            ' First, try to find a Pending appointment (most recent first)
            For i As Integer = scheduleLines.Length - 1 To 0 Step -1
                Dim line As String = scheduleLines(i)
                If line.Trim() <> "" Then
                    Dim fields = line.Split("|"c)
                    If fields.Length >= 8 AndAlso fields(1).Trim() = phoneNumber.Trim() Then
                        Dim status As String = fields(7).Trim() ' Status field
                        If status = "Pending" Then
                            Return "Pending"
                        End If
                    End If
                End If
            Next

            ' If no Pending found, check if any Completed appointments exist
            For i As Integer = scheduleLines.Length - 1 To 0 Step -1
                Dim line As String = scheduleLines(i)
                If line.Trim() <> "" Then
                    Dim fields = line.Split("|"c)
                    If fields.Length >= 8 AndAlso fields(1).Trim() = phoneNumber.Trim() Then
                        Dim status As String = fields(7).Trim() ' Status field
                        If status = "Completed" Then
                            Return "Completed"
                        End If
                    End If
                End If
            Next

            Return "Not Found"
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    ' Appointments button - opens appointments form
    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Me.Hide()
        Dim userPhone As String = GetCurrentUserPhone()
        Dim form9 As New ScheduleAppointmentForm(userPhone)
        form9.Show()
    End Sub

    ' Logout button - returns to main menu
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        StartupForm.Show()
        AdminLoginForm.adminPass = ""
    End Sub

    ' Get current user's phone number
    Private Function GetCurrentUserPhone() As String
        Return GlobalVariables.CurrentUserPhone
    End Function

    Private Sub lblPatientMenu_Click(sender As Object, e As EventArgs) Handles lblPatientMenu.Click

    End Sub

    Private Sub PatientMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class