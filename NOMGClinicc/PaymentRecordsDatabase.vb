Imports System.IO

Public Class PaymentRecordsDatabase

    ' Search billing records
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text.Trim().ToLower()

        For Each row As DataGridViewRow In dgvPaymentRecords.Rows
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

    ' Form load - load billing data
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
    End Sub

    ' Load billing records from file
    Private Sub LoadBillingData()
        Try
            Dim billingFilePath As String = GlobalVariables.GetFilePath("billing.txt")

            If File.Exists(billingFilePath) Then
                dgvPaymentRecords.Rows.Clear()
                Dim lines As String() = File.ReadAllLines(billingFilePath)

                For Each line In lines
                    Dim fields As String() = line.Split("|"c)

                    If fields.Length >= 8 Then
                        dgvPaymentRecords.Rows.Add(
                            fields(0), ' Name
                            fields(1), ' Phone Number
                            Decimal.Parse(fields(3)).ToString("₱#,##0.00"), ' Checkup Price
                            fields(4), ' Vitamins
                            Decimal.Parse(fields(5)).ToString("₱#,##0.00"), ' Total Amount
                            Decimal.Parse(fields(6)).ToString("₱#,##0.00"), ' Amount Paid
                            fields(8), ' Status
                            fields(7)) ' Date
                    End If
                Next
            Else
                MessageBox.Show("billing.txt file not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading billing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Refresh button - reload billing data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBillingData()
    End Sub

    ' Back button - return to admin menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        AdminMenuForm.Show()
    End Sub

End Class