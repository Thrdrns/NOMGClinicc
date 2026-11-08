Public Class StartupForm

    ' Admin button - goes to admin form
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        AdminLoginForm.Show()
    End Sub

    ' Patient button - goes to patient form  
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        PatientLoginForm1.Show()
    End Sub

End Class