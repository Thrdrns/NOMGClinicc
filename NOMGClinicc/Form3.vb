Public Class Form3

    ' Patients button - goes to patients form
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Me.Hide()
        Form8.Show()
    End Sub

    ' Appointments button - goes to appointments form
    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Me.Hide()
        Form11.Show()
    End Sub

    ' Billing and Payments button - goes to billing form
    Private Sub btnBillingAndPayments_Click(sender As Object, e As EventArgs) Handles btnBillingAndPayments.Click
        Me.Hide()
        Form10.Show()
    End Sub

    ' Logout button - returns to login screen
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
        Form2.adminPass = ""
    End Sub

End Class