Imports System.IO

Public Class Form4

    ' Billing button - opens billing form if patient exists
    Private Sub btnBillingAndPayments_Click(sender As Object, e As EventArgs) Handles btnBillingAndPayments.Click
        If Not PatientExists(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("Patient data not found! Please register first.", "No Patient Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim billingForm As New Form7(GlobalVariables.CurrentUserPhone)
        billingForm.Show()
        Me.Hide()
    End Sub

    ' Check if patient record exists
    Private Function PatientExists(phoneNumber As String) As Boolean
        Try
            Dim patientsFilePath As String = GlobalVariables.GetFilePath("patients.txt")
            If Not File.Exists(patientsFilePath) Then Return False

            Dim patientLines = File.ReadAllLines(patientsFilePath)
            For Each line In patientLines
                Dim fields = line.Split("|"c)
                If fields.Length >= 14 AndAlso fields(13).Trim() = phoneNumber.Trim() Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Appointments button - opens appointments form
    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Me.Hide()
        Dim userPhone As String = GetCurrentUserPhone()
        Dim form9 As New Form9(userPhone)
        form9.Show()
    End Sub

    ' Logout button - returns to main menu
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
        Form2.adminPass = ""
    End Sub

    ' Get current user's phone number
    Private Function GetCurrentUserPhone() As String
        Return GlobalVariables.CurrentUserPhone
    End Function

End Class