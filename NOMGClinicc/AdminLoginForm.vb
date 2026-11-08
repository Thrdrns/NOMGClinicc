Public Class AdminLoginForm
    Public admin As String
    Public adminPass As String

    ' Login button - checks username and password
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "admin" And txtPassword.Text = "admin123" Then
            admin = txtUserName.Text
            adminPass = txtPassword.Text
            txtUserName.Clear()
            txtPassword.Clear()
            Me.Hide()
            AdminMenuForm.Show()
        Else
            MsgBox("Incorrect Credentials")
        End If
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class