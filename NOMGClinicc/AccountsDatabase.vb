Imports System.IO

Public Class AccountsDatabase
    Private Sub AccountsDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountData()
    End Sub

    Private Sub LoadAccountData()
        Try
            Dim accountsFilePath As String = GlobalVariables.GetFilePath("accounts.txt")

            If File.Exists(accountsFilePath) Then
                dgvAccountRecords.Rows.Clear()
                dgvAccountRecords.Refresh()

                Dim lines As String() = File.ReadAllLines(accountsFilePath)
                Dim lineNumber As Integer = 1

                For Each line In lines
                    Try
                        ' Skip empty lines
                        If String.IsNullOrWhiteSpace(line) Then Continue For

                        Dim fields As String() = line.Split("|"c)

                        ' Check if we have enough fields (7 fields based on your usage)
                        If fields.Length >= 7 Then
                            dgvAccountRecords.Rows.Add(
                                fields(0), ' id
                                fields(1), ' First Name
                                fields(2), ' Middle Name
                                fields(3), ' Last Name
                                fields(4), ' Number
                                fields(5), ' Birthday
                                fields(6)) ' Date and Time
                        Else
                            ' Log or handle insufficient fields
                            Debug.WriteLine($"Line {lineNumber}: Insufficient fields ({fields.Length}) - {line}")
                        End If
                    Catch ex As Exception
                        Debug.WriteLine($"Error processing line {lineNumber}: {ex.Message}")
                        ' Continue with next line instead of stopping
                    End Try

                    lineNumber += 1
                Next

                If dgvAccountRecords.Rows.Count = 0 Then
                    MessageBox.Show("No account records found in file.", "Information",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("accounts.txt file not found at: " & accountsFilePath,
                               "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading accounts data: " & ex.Message &
                           Environment.NewLine & "Stack Trace: " & ex.StackTrace,
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAccountData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        AdminMenuForm.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text.Trim().ToLower()

        For Each row As DataGridViewRow In dgvAccountRecords.Rows
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

    Private Sub lblAccountRecords_Click(sender As Object, e As EventArgs) Handles lblAccountRecords.Click

    End Sub
End Class