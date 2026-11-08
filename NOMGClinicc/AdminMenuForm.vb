Public Class AdminMenuForm

    ' Patients button - goes to patients database form
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Me.Hide()
        PatientDetailsDatabase.Show()
    End Sub

    ' Appointments button - goes to appointments database form
    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Me.Hide()
        AppointmentsDatabase.Show()
    End Sub

    ' Billing and Payments button - goes to billing form
    Private Sub btnBillingAndPayments_Click(sender As Object, e As EventArgs) Handles btnBillingAndPayments.Click
        Me.Hide()
        PaymentRecordsDatabase.Show()
    End Sub

    ' Logout button - returns to login screen
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        StartupForm.Show()
        AdminLoginForm.adminPass = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AccountsDatabase.Show()
    End Sub

    Private Sub AdminMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class