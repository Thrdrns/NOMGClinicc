Imports System.IO

Public Class Form5
    Public id As Integer = 0
    Public fBaby As String
    Public AppointmentDate As DateTime = DateTime.Now

    ' Calculate next visit date based on gestational age
    Private Function CalculateNextVisit(gestationalAgeText As String, lmpDate As DateTime, appointmentDate As DateTime) As DateTime
        Dim weeks As Integer = 0
        Dim days As Integer = 0

        ' Parse weeks and days from gestational age text
        Try
            Dim weekMatch = System.Text.RegularExpressions.Regex.Match(gestationalAgeText, "(\d+)\s*weeks")
            Dim dayMatch = System.Text.RegularExpressions.Regex.Match(gestationalAgeText, "(\d+)\s*days")

            If weekMatch.Success Then Integer.TryParse(weekMatch.Groups(1).Value, weeks)
            If dayMatch.Success Then Integer.TryParse(dayMatch.Groups(1).Value, days)
        Catch ex As Exception
            weeks = 0
            days = 0
        End Try

        ' Calculate days from LMP and determine next visit interval
        Dim gestationalAgeAtAppointment As Integer = (appointmentDate - lmpDate).Days
        Dim daysToAdd As Integer = 0

        If gestationalAgeAtAppointment <= 90 Then      ' First 3 months
            daysToAdd = 30
        ElseIf gestationalAgeAtAppointment <= 180 Then ' Next 3 months
            daysToAdd = 20
        Else                                           ' Last 3 months
            daysToAdd = 10
        End If

        Return AdjustForClosure(appointmentDate.AddDays(daysToAdd))
    End Function

    ' Adjust date for clinic closure (Sunday and Monday)
    Private Function AdjustForClosure(targetDate As DateTime) As DateTime
        Dim adjustedDate As DateTime = targetDate

        Select Case adjustedDate.DayOfWeek
            Case DayOfWeek.Sunday
                adjustedDate = adjustedDate.AddDays(2) ' Sunday → Tuesday
            Case DayOfWeek.Monday
                adjustedDate = adjustedDate.AddDays(1) ' Monday → Tuesday
        End Select

        Return adjustedDate
    End Function

    ' Save patient details
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields
        If String.IsNullOrEmpty(txtFullName.Text.Trim()) Then
            MessageBox.Show("Please enter patient's full name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtAge.Text.Trim()) OrElse Not IsNumeric(txtAge.Text) Then
            MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAge.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtAddr.Text.Trim()) Then
            MessageBox.Show("Please enter patient's address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddr.Focus()
            Return
        End If

        If cmbCivil.SelectedIndex = -1 Then
            MessageBox.Show("Please select civil status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCivil.Focus()
            Return
        End If

        If txtGestAge.Text = "Invalid LMP date" OrElse txtGestAge.Text = "LMP cannot be in future" Then
            MessageBox.Show("Please select a valid LMP date (cannot be in the future).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpReg.Focus()
            Return
        End If

        If String.IsNullOrEmpty(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("No user logged in. Please login first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            Form14.Show()
            Return
        End If

        If PatientExists(GlobalVariables.CurrentUserPhone) Then
            MessageBox.Show("Patient record already exists for this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get first baby status
        Dim fBaby As String = "No"
        If TypeOf Me.Controls("chbBaby") Is CheckBox Then
            Dim chbBaby As CheckBox = DirectCast(Me.Controls("chbBaby"), CheckBox)
            fBaby = If(chbBaby.Checked, "Yes", "No")
        End If

        ' Get next ID and calculate next visit
        id = GetNextID(GetFilePath("patients.txt"))
        Dim nextVisitDate As DateTime = CalculateNextVisit(txtGestAge.Text, dtpReg.Value, AppointmentDate)

        ' Build patient record
        Dim record As String = id.ToString() + "|" + txtFullName.Text.Trim() + "|" + txtAddr.Text.Trim() + "|" +
                         cmbCivil.Text + "|" + txtAge.Text.Trim() + "|" + txtGestAge.Text.Trim() + "|" +
                         txtSexReg.Text.Trim() + "|" + fBaby + "|" + dtpReg.Value.ToString("MM/dd/yyyy") + "|" +
                         "Dr. Nom" + "|" + "|" + DateTime.Now.ToString("MM/dd/yyyy") + "|" +
                         nextVisitDate.ToString("MM/dd/yyyy") + "|" + GlobalVariables.CurrentUserPhone

        ' Save to file
        Try
            File.AppendAllText(GetFilePath("patients.txt"), record & Environment.NewLine)
            Form8.loadPatientData()

            MessageBox.Show("Patient details saved successfully!" & Environment.NewLine &
                        "Patient ID: " & id.ToString() & Environment.NewLine &
                        "Gestational Age: " & txtGestAge.Text & Environment.NewLine &
                        "Next Visit: " & nextVisitDate.ToString("MM/dd/yyyy") & Environment.NewLine &
                        "Day: " & nextVisitDate.DayOfWeek.ToString(),
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearAllFields()

            ' Redirect based on user type
            If Form2.admin = "admin" And Form2.adminPass = "admin123" Then
                Me.Hide()
                Form3.Show()
            Else
                Me.Hide()
                Form4.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving patient details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Check if patient already exists
    Private Function PatientExists(phoneNumber As String) As Boolean
        Dim patientsFilePath As String = GetFilePath("patients.txt")
        If Not File.Exists(patientsFilePath) Then Return False

        Try
            Dim lines As String() = File.ReadAllLines(patientsFilePath)
            For Each line As String In lines
                If line.Trim() <> "" Then
                    Dim fields As String() = line.Split("|"c)
                    If fields.Length >= 14 AndAlso fields(13).Trim() = phoneNumber Then
                        Return True
                    End If
                End If
            Next
        Catch ex As Exception
            ' Ignore error for existence check
        End Try

        Return False
    End Function

    ' Clear all form fields
    Private Sub ClearAllFields()
        txtFullName.Clear()
        txtAge.Clear()
        txtAddr.Clear()
        cmbCivil.SelectedIndex = -1
        dtpReg.Value = DateTime.Today
        txtGestAge.Clear()

        If TypeOf Me.Controls("chbBaby") Is CheckBox Then
            DirectCast(Me.Controls("chbBaby"), CheckBox).Checked = False
        End If
    End Sub

    ' Form load - initialize controls
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCivil.DropDownStyle = ComboBoxStyle.DropDownList
        cmbObReg.DropDownStyle = ComboBoxStyle.DropDownList

        If cmbCivil.Items.Count = 0 Then
            cmbCivil.Items.AddRange({"Single", "Married", "Divorced", "Widowed"})
        End If

        cmbObReg.Items.Clear()
        cmbObReg.Items.Add("Dr. Nom")
        cmbObReg.SelectedIndex = 0
        cmbObReg.Enabled = False

        If String.IsNullOrEmpty(txtSexReg.Text) Then
            txtSexReg.Text = "Female"
        End If

        CalculateGestationalAge()
    End Sub

    ' Calculate gestational age when LMP date changes
    Private Sub dtpReg_ValueChanged(sender As Object, e As EventArgs) Handles dtpReg.ValueChanged
        CalculateGestationalAge()
    End Sub

    ' Calculate and display gestational age
    Private Sub CalculateGestationalAge()
        Try
            Dim lmp As DateTime = dtpReg.Value
            Dim today As DateTime = DateTime.Today

            If lmp > today Then
                txtGestAge.Text = "LMP cannot be calculated"
                Return
            End If

            Dim totalDays As Integer = (today - lmp).Days
            Dim weeks As Integer = totalDays \ 7
            Dim days As Integer = totalDays Mod 7

            txtGestAge.Text = $"{weeks} weeks, {days} days"

        Catch ex As Exception
            MessageBox.Show("Error calculating gestational age: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Back button - return to previous form
    Private Sub btnBackReg_Click(sender As Object, e As EventArgs) Handles btnBackReg.Click
        ClearAllFields()
        Me.Hide()
        Form4.Show()
    End Sub

    ' Clear button - reset all fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAllFields()
    End Sub

    ' Validate age field - numbers only
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

End Class