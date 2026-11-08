Imports System.IO

Public Class Form11

    Private patientDetails As String = GetFilePath("patients.txt")
    Private schedulesFilePath As String = GetFilePath("schedules.txt")

    ' Load appointment data
    Public Sub loadPatientData()
        dgvAppointments.Rows.Clear()

        If Not File.Exists(patientDetails) OrElse Not File.Exists(schedulesFilePath) Then
            MessageBox.Show("Required data files not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim patientInf As String() = File.ReadAllLines(patientDetails)
            Dim scheduleInfo As String() = File.ReadAllLines(schedulesFilePath)

            ' Create dictionary for patient info lookup
            Dim patientDict As New Dictionary(Of String, String())
            For Each line As String In patientInf
                If String.IsNullOrWhiteSpace(line) Then Continue For
                Dim fields As String() = line.Split("|"c)
                If fields.Length >= 14 Then
                    Dim phone As String = fields(13)
                    If Not patientDict.ContainsKey(phone) Then
                        patientDict.Add(phone, fields)
                    End If
                End If
            Next

            ' Process schedules and match with patient data
            For Each line As String In scheduleInfo
                If String.IsNullOrWhiteSpace(line) Then Continue For

                Dim fields As String() = line.Split("|"c)
                If fields.Length >= 8 Then
                    Dim phone As String = fields(1)
                    Dim doctor As String = fields(3)
                    Dim scheduledDate As String = fields(4)
                    Dim time As String = fields(5)
                    Dim purpose As String = fields(6)

                    ' Find matching patient data
                    If patientDict.ContainsKey(phone) Then
                        Dim patientFields As String() = patientDict(phone)
                        dgvAppointments.Rows.Add(
                            doctor,
                            patientFields(1), ' Patient name
                            purpose,
                            scheduledDate,
                            time,
                            phone)
                    Else
                        dgvAppointments.Rows.Add(
                            doctor,
                            "Unknown",
                            purpose,
                            scheduledDate,
                            time,
                            phone)
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading appointment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Form load - load appointment data
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPatientData()
    End Sub

    ' Search appointments
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text.Trim().ToLower()

        For Each row As DataGridViewRow In dgvAppointments.Rows
            If row.IsNewRow Then Continue For

            Dim match As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If TypeOf cell Is DataGridViewButtonCell Then Continue For
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(search) Then
                    match = True
                    Exit For
                End If
            Next

            row.Visible = match
        Next
    End Sub

    ' Back button - return to admin menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form3.Show()
    End Sub

End Class