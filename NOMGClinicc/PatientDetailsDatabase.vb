Imports System.IO

Public Class PatientDetailsDatabase
    Private patientDetails As String = GetFilePath("patients.txt")
    Private schedulesFilePath As String = GetFilePath("schedules.txt")

    ' Search patients by name, phone, or other details
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView1.Rows
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

    ' Setup data grid view columns
    Private Sub setUpGrid()
        DataGridView1.Columns.Clear()

        ' Add patient data columns
        Dim columns As String() = {
            "ID", "Name", "Address", "Civil Status", "Age",
            "Gestational Age", "Gender", "First Baby", "LMP Date",
            "OB Doctor", "Reg Date", "Next Visit", "Phone Number"
        }

        For Each colName As String In columns
            DataGridView1.Columns.Add(colName, colName)
        Next

        ' Add delete button column
        Dim deleteBtn As New DataGridViewButtonColumn()
        deleteBtn.HeaderText = "Action"
        deleteBtn.Name = "Delete"
        deleteBtn.Text = "Delete"
        deleteBtn.UseColumnTextForButtonValue = True
        deleteBtn.Width = 70
        DataGridView1.Columns.Add(deleteBtn)

        ' Set column widths
        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("Name").Width = 120
        DataGridView1.Columns("Address").Width = 150
        DataGridView1.Columns("Civil Status").Width = 80
        DataGridView1.Columns("Age").Width = 40
        DataGridView1.Columns("Gestational Age").Width = 100
        DataGridView1.Columns("Gender").Width = 60
        DataGridView1.Columns("First Baby").Width = 70
        DataGridView1.Columns("LMP Date").Width = 80
        DataGridView1.Columns("OB Doctor").Width = 80
        DataGridView1.Columns("Reg Date").Width = 80
        DataGridView1.Columns("Next Visit").Width = 80
        DataGridView1.Columns("Phone Number").Width = 100
    End Sub

    ' Form load - setup grid and load data
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setUpGrid()
        loadPatientData()
    End Sub

    ' Load patient data from file
    Public Sub loadPatientData()
        DataGridView1.Rows.Clear()

        If Not File.Exists(patientDetails) Then
            MessageBox.Show("patients.txt not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim patientinf As String() = File.ReadAllLines(patientDetails)
            For Each line As String In patientinf
                If String.IsNullOrWhiteSpace(line) Then Continue For

                Dim fields As String() = line.Split("|"c)
                If fields.Length >= 14 Then
                    DataGridView1.Rows.Add(
                        fields(0),  ' ID
                        fields(1),  ' Name
                        fields(2),  ' Address
                        fields(3),  ' Civil Status
                        fields(4),  ' Age
                        fields(5),  ' Gestational Age
                        fields(6),  ' Gender
                        fields(7),  ' First Baby
                        fields(8),  ' LMP Date
                        fields(9),  ' OB Doctor
                        fields(11), ' Registration Date
                        fields(12), ' Next Visit Date
                        fields(13)  ' Phone Number
                    )
                Else
                    MessageBox.Show("Invalid entry in patients.txt", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading patient data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handle button clicks in data grid
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
            If MessageBox.Show("Are you sure you want to delete this patient record?" & Environment.NewLine &
                           "This will also delete any associated appointments.", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                DeletePatient(e.RowIndex)
                loadPatientData()
            End If
        End If
    End Sub

    ' Delete patient record
    Private Sub DeletePatient(rowIndex As Integer)
        If Not File.Exists(patientDetails) Then Return

        Try
            Dim linesList As New List(Of String)(File.ReadAllLines(patientDetails))

            If rowIndex < 0 OrElse rowIndex >= linesList.Count Then Return

            ' Get patient data before deleting
            Dim patientData As String() = linesList(rowIndex).Split("|"c)
            If patientData.Length >= 14 Then
                Dim phoneNumber As String = patientData(13).Trim()
                Dim patientID As String = patientData(0).Trim()
                DeletePatientSchedules(phoneNumber, patientID)
            End If

            linesList.RemoveAt(rowIndex)
            File.WriteAllLines(patientDetails, linesList.ToArray())

            MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting patient: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete associated schedules
    Private Sub DeletePatientSchedules(phoneNumber As String, patientID As String)
        If Not File.Exists(schedulesFilePath) Then Return

        Try
            Dim linesList As New List(Of String)(File.ReadAllLines(schedulesFilePath))
            linesList.RemoveAll(Function(line)
                                    If String.IsNullOrWhiteSpace(line) Then Return False
                                    Dim fields As String() = line.Split("|"c)
                                    Return (fields.Length >= 2 AndAlso (fields(1).Trim() = phoneNumber OrElse fields(2).Trim() = patientID))
                                End Function)
            File.WriteAllLines(schedulesFilePath, linesList.ToArray())
        Catch ex As Exception
            MessageBox.Show("Warning: Could not delete all associated appointments", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Back button - return to admin menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        AdminMenuForm.Show()
    End Sub

    ' Show patient details on double click
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim patientInfo As String = "Patient Details:" & Environment.NewLine &
                                "ID: " & selectedRow.Cells("ID").Value.ToString() & Environment.NewLine &
                                "Name: " & selectedRow.Cells("Name").Value.ToString() & Environment.NewLine &
                                "Age: " & selectedRow.Cells("Age").Value.ToString() & Environment.NewLine &
                                "Gestational Age: " & selectedRow.Cells("Gestational Age").Value.ToString() & Environment.NewLine &
                                "Next Visit: " & selectedRow.Cells("Next Visit").Value.ToString() & Environment.NewLine &
                                "Phone: " & selectedRow.Cells("Phone Number").Value.ToString()

        MessageBox.Show(patientInfo, "Patient Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class