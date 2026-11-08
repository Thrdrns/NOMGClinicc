Imports System.IO
Public Module GlobalVariables
    Public CurrentUserPhone As String = ""
    Public CurrentUserName As String = ""
    Public CurrentUserID As String = ""

    Public Function GetFilePath(fileName As String) As String
        Return Path.Combine(Application.StartupPath, "..\..\Resources\Text Files", fileName)
    End Function

    Public Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        If String.IsNullOrEmpty(phoneNumber) OrElse phoneNumber.Length <> 10 Then
            Return False
        End If
        Return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, "^\d+$")
    End Function

    Public Function FormatPhoneNumber(phoneNumber As String) As String
        If phoneNumber.StartsWith("+63") Then
            Return phoneNumber
        Else
            Return "+63" & phoneNumber
        End If
    End Function

    Public Function GetNextID(filePath As String) As Integer
        Dim nextID As Integer = 1
        If Not File.Exists(filePath) Then Return nextID

        Try
            Dim lines As String() = File.ReadAllLines(filePath)
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim parts As String() = line.Split("|"c)
                    If parts.Length > 0 AndAlso Integer.TryParse(parts(0).Trim(), Nothing) Then
                        Dim currentID As Integer = Integer.Parse(parts(0).Trim())
                        If currentID >= nextID Then
                            nextID = currentID + 1
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            ' If error, start from 1
        End Try
        Return nextID
    End Function
End Module
Public Class UserLoginForm1
    Private accountsFilePath As String = GetFilePath("accounts.txt")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()

        ' Use centralized validation
        If Not IsValidPhoneNumber(phoneNumber) Then
            MessageBox.Show("Phone number must be exactly 10 digits containing only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' FORMAT: Add +63 prefix for storage and comparison
        Dim formattedPhoneNumber As String = "+63" & phoneNumber

        ' CHECK: If phone number exists in database and get user data
        Dim userData As String() = GetUserData(formattedPhoneNumber)
        If userData IsNot Nothing Then
            ' Phone number EXISTS - go directly to SCHEDULE FORM (Form9)
            Dim surname As String = userData(3) ' Last Name is the 4th field (index 3)
            MessageBox.Show("Welcome back " & surname & "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Set global variables
            GlobalVariables.CurrentUserPhone = formattedPhoneNumber
            GlobalVariables.CurrentUserName = surname

            ' EXISTING USER: Redirect directly to SCHEDULE FORM
            Me.Hide()
            UserMenuForm.Show()
        Else
            ' Phone number NOT EXISTS - go to REGISTRATION FORM (Form15)
            GlobalVariables.CurrentUserPhone = formattedPhoneNumber
            MessageBox.Show("New user detected. Please complete registration.", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPhoneNumber.Clear()
            ' NEW USER: Redirect to REGISTRATION FORM
            Me.Hide()
            UserLoginForm2.Show()
        End If
    End Sub

    ' FUNCTION: Gets user data if phone number exists, returns Nothing if not found
    Private Function GetUserData(phoneNumber As String) As String()
        ' Check if accounts file exists
        If Not File.Exists(accountsFilePath) Then
            Return Nothing
        End If

        Try
            Dim lines As String() = File.ReadAllLines(accountsFilePath)
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim fields As String() = line.Split("|"c)
                    ' Phone number is the 5th field (index 4) in the new 7-field format
                    If fields.Length >= 5 Then
                        Dim existingPhone As String = fields(4).Trim()
                        If existingPhone = phoneNumber Then
                            Return fields ' Return all user data fields
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error reading accounts file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Nothing
    End Function

    ' Rest of your existing code remains the same...
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged
        If txtPhoneNumber.Text.Length > 10 Then
            txtPhoneNumber.Text = txtPhoneNumber.Text.Substring(0, 10)
            txtPhoneNumber.SelectionStart = 10
        End If
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPhoneNumber.MaxLength = 10
    End Sub
End Class