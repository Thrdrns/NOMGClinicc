Imports System.IO

Public Class AppointmentsDatabase

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
                    Dim status As String = "Pending" ' Default status

                    ' Get status from schedules.txt (index 7 in the array)
                    If fields.Length >= 8 Then
                        status = fields(7)
                    End If

                    ' Find matching patient data
                    If patientDict.ContainsKey(phone) Then
                        Dim patientFields As String() = patientDict(phone)
                        Dim patientName As String = patientFields(1)
                        Dim nextVisit As String = ""

                        ' Get next visit date from patient fields
                        ' According to your format: ID|NAME|ADDRESS|CIVIL STATUS|AGE|GESTATIONAL AGE|GENDER|FIRST BABY|LMP DATE|OB DOCTOR|REG DATE|NEXT VISIT|PHONE NUMBER
                        ' Next Visit is at index 11
                        If patientFields.Length >= 12 Then
                            nextVisit = patientFields(12)
                        End If

                        ' Add row with all columns including Next Visit and Status
                        dgvAppointments.Rows.Add(
                            doctor,
                            patientName,
                            purpose,
                            scheduledDate,
                            time,
                            phone,
                            nextVisit,
                            status) ' Add Status column
                    Else
                        dgvAppointments.Rows.Add(
                            doctor,
                            "Unknown",
                            purpose,
                            scheduledDate,
                            time,
                            phone,
                            "", ' Empty Next Visit for unknown patients
                            status) ' Add Status column
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading appointment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Form load - load appointment data
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' First, ensure the DataGridView has all the required columns
        SetupDataGridViewColumns()
        loadPatientData()
    End Sub

    ' Setup DataGridView columns if not already set up in designer
    Private Sub SetupDataGridViewColumns()
        ' Clear existing columns if any
        dgvAppointments.Columns.Clear()

        ' Add columns in the correct order
        dgvAppointments.Columns.Add("Doctor", "Doctor")
        dgvAppointments.Columns.Add("PatientName", "Patient Name")
        dgvAppointments.Columns.Add("Purpose", "Purpose")
        dgvAppointments.Columns.Add("ScheduledDate", "Scheduled Date")
        dgvAppointments.Columns.Add("Time", "Time")
        dgvAppointments.Columns.Add("PhoneNumber", "Phone Number")
        dgvAppointments.Columns.Add("NextVisit", "Next Visit")
        dgvAppointments.Columns.Add("Status", "Status") ' New Status column

        ' Optional: Adjust column widths
        dgvAppointments.Columns("Doctor").Width = 120
        dgvAppointments.Columns("PatientName").Width = 150
        dgvAppointments.Columns("Purpose").Width = 150
        dgvAppointments.Columns("ScheduledDate").Width = 100
        dgvAppointments.Columns("Time").Width = 80
        dgvAppointments.Columns("PhoneNumber").Width = 120
        dgvAppointments.Columns("NextVisit").Width = 100
        dgvAppointments.Columns("Status").Width = 80
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
        AdminMenuForm.Show()
    End Sub

    Private Sub dgvAppointments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellContentClick
        ' Handle cell click events if needed
    End Sub
End Class