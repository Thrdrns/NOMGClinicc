Imports System.IO

Public Class Form15
    Private accountsFilePath As String = GetFilePath("accounts.txt")

    ' Save button - create new user account
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields
        If String.IsNullOrEmpty(txtFirstName.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
            MessageBox.Show("Please enter at least First Name and Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate birthdate is not in future
        If dtpBirthDate.Value > DateTime.Today Then
            MessageBox.Show("Birthdate cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate user is at least 13 years old
        Dim minAge As Integer = 13
        If dtpBirthDate.Value > DateTime.Today.AddYears(-minAge) Then
            MessageBox.Show($"You must be at least {minAge} years old to register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if phone number exists
        If String.IsNullOrEmpty(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("No phone number found. Please start from login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Hide()
            Form14.Show()
            Return
        End If

        ' Check if phone number already registered
        If PhoneNumberExists(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("This phone number is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Generate account ID and create record
        Dim accountID As Integer = GetNextID(accountsFilePath)
        Dim record As String = accountID.ToString() + "|" +
                             txtFirstName.Text.Trim() + "|" +
                             txtMiddleName.Text.Trim() + "|" +
                             txtLastName.Text.Trim() + "|" +
                             GlobalVariables.CurrentUserPhone + "|" +
                             dtpBirthDate.Value.ToString("MM/dd/yyyy") + "|" +
                             DateTime.Now.ToString("MM/dd/yyyy HH:mm")

        ' Save account to file
        Try
            File.AppendAllText(accountsFilePath, record & Environment.NewLine)
            GlobalVariables.CurrentUserName = txtLastName.Text.Trim()

            MessageBox.Show("Account created successfully!" & Environment.NewLine &
                        "Welcome " & txtFirstName.Text.Trim() & " " & txtLastName.Text.Trim() & "!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearForm()
            Me.Hide()
            Form4.Show()
        Catch ex As Exception
            MessageBox.Show("Error saving account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Check if phone number already exists
    Private Function PhoneNumberExists(phoneNumber As String) As Boolean
        If Not File.Exists(accountsFilePath) Then Return False

        Try
            Dim lines As String() = File.ReadAllLines(accountsFilePath)
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim fields As String() = line.Split("|"c)
                    If fields.Length >= 5 Then
                        Dim existingPhone As String = fields(4).Trim()
                        If existingPhone = phoneNumber Then
                            Return True
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error checking phone number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    ' Clear all form fields
    Private Sub ClearForm()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        dtpBirthDate.Value = DateTime.Today.AddYears(-18)
    End Sub

    ' Form load - initialize controls
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpBirthDate.Value = DateTime.Today.AddYears(-18)
        dtpBirthDate.MaxDate = DateTime.Today
        dtpBirthDate.MinDate = DateTime.Today.AddYears(-100)
        txtFirstName.Focus()
    End Sub

    ' Validate name fields - letters only
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress, txtMiddleName.KeyPress, txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    ' Form closing - return to login
    Private Sub Form15_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            ClearForm()
            Form14.Show()
        End If
    End Sub

End Class