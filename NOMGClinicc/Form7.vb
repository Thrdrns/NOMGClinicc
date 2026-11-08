Imports System.IO

Public Class Form7
    Inherits Form

    ' Payment prices for services and medications
    Private paymentTable As New Dictionary(Of String, Decimal) From {
        {"Initial Check up", 2000},
        {"Follow up Check-Up", 500},
        {"Iron Vitamin", 15},
        {"B Complex", 25},
        {"DHA", 20},
        {"Flu Vac", 1500}
    }

    Private currentPatientPhone As String
    Private patientData As String()
    Private scheduleData As String()
    Private totalAmountDue As Decimal = 0
    Private visitTypePrice As Decimal = 0

    Public Sub New(phoneNumber As String)
        InitializeComponent()
        currentPatientPhone = phoneNumber
        LoadPatientData()
        CalculateVitaminsAndBilling()
    End Sub

    ' Load patient and schedule data
    Private Sub LoadPatientData()
        Try
            Dim patientsFilePath As String = GlobalVariables.GetFilePath("patients.txt")
            Dim schedulesFilePath As String = GlobalVariables.GetFilePath("schedules.txt")

            ' Load patient data
            If File.Exists(patientsFilePath) Then
                Dim patientLines = File.ReadAllLines(patientsFilePath)
                For Each line In patientLines
                    Dim fields = line.Split("|"c)
                    If fields.Length >= 14 AndAlso fields(13).Trim() = currentPatientPhone.Trim() Then
                        patientData = fields
                        txtFullName.Text = fields(1)
                        txtPhoneNumber.Text = fields(13)
                        Exit For
                    End If
                Next
            End If

            ' Load schedule data
            If File.Exists(schedulesFilePath) Then
                Dim scheduleLines = File.ReadAllLines(schedulesFilePath)
                For Each line In scheduleLines
                    Dim fields = line.Split("|"c)
                    If fields.Length >= 7 AndAlso fields(1).Trim() = currentPatientPhone.Trim() Then
                        scheduleData = fields
                        Dim visitType = fields(6)
                        If visitType = "Initial Checkup" Then
                            chbInitial.Checked = True
                        ElseIf visitType = "Follow-up Checkup" Then
                            chbFollow.Checked = True
                        End If
                        Exit For
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading patient data: " & ex.Message)
        End Try
    End Sub

    ' Calculate vitamins and billing amounts
    Private Sub CalculateVitaminsAndBilling()
        If patientData Is Nothing Then
            MessageBox.Show("Patient data not found!")
            Return
        End If

        Try
            ' Get next visit date
            Dim nextVisitDateStr As String = patientData(12).Trim()
            Dim nextVisitDate As DateTime = DateTime.Parse(nextVisitDateStr)

            ' Get appointment date
            Dim appointmentDate As DateTime = DateTime.Now
            If scheduleData IsNot Nothing AndAlso scheduleData.Length >= 5 Then
                Dim appointmentDateStr As String = scheduleData(4).Trim()
                If Not String.IsNullOrEmpty(appointmentDateStr) Then
                    appointmentDate = DateTime.Parse(appointmentDateStr)
                End If
            End If

            ' Calculate days until next visit
            Dim daysUntilNextVisit As Integer = (nextVisitDate - appointmentDate).Days
            If daysUntilNextVisit < 0 Then daysUntilNextVisit = 0
            txtVisit.Text = daysUntilNextVisit.ToString()

            ' Reset totals
            totalAmountDue = 0
            visitTypePrice = 0

            ' Add checkup cost and vitamins
            If chbInitial.Checked Then
                visitTypePrice = paymentTable("Initial Check up")
                totalAmountDue += visitTypePrice
                txtVisitPrice.Text = $"₱{visitTypePrice:N2}"
                CalculateVitaminQuantities(daysUntilNextVisit, includeFluVaccine:=True)

            ElseIf chbFollow.Checked Then
                visitTypePrice = paymentTable("Follow up Check-Up")
                totalAmountDue += visitTypePrice
                txtVisitPrice.Text = $"₱{visitTypePrice:N2}"
                CalculateVitaminQuantities(daysUntilNextVisit, includeFluVaccine:=False)
            End If

            ' Update totals
            txtTotal.Text = $"₱{totalAmountDue:N2}"
            txtTotalAmt.Text = $"₱{totalAmountDue:N2}"
            txtStatus.Text = "Pending"

        Catch ex As Exception
            MessageBox.Show("Error calculating billing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Calculate vitamin quantities and costs
    Private Sub CalculateVitaminQuantities(daysUntilNextVisit As Integer, includeFluVaccine As Boolean)
        ' Iron Vitamin (once daily)
        Dim ironQuantity As Integer = daysUntilNextVisit
        Dim ironCost As Decimal = ironQuantity * paymentTable("Iron Vitamin")
        totalAmountDue += ironCost
        txtIronVitamin.Text = $"{ironQuantity} pcs"
        txtIronVitaminPrice.Text = $"₱{ironCost:N2}"

        ' B Complex (once daily)
        Dim bComplexQuantity As Integer = daysUntilNextVisit
        Dim bComplexCost As Decimal = bComplexQuantity * paymentTable("B Complex")
        totalAmountDue += bComplexCost
        txtBComplex.Text = $"{bComplexQuantity} pcs"
        txtBComplexPrice.Text = $"₱{bComplexCost:N2}"

        ' DHA (three times daily)
        Dim dhaQuantity As Integer = daysUntilNextVisit * 3
        Dim dhaCost As Decimal = dhaQuantity * paymentTable("DHA")
        totalAmountDue += dhaCost
        txtDHA.Text = $"{dhaQuantity} pcs"
        txtDHAPrice.Text = $"₱{dhaCost:N2}"

        ' Flu Vaccine (once if included)
        If includeFluVaccine Then
            totalAmountDue += paymentTable("Flu Vac")
            txtFluVaccine.Text = "1 pc"
            txtFluVaccinePrice.Text = $"₱{paymentTable("Flu Vac"):N2}"
        Else
            txtFluVaccine.Text = "0 pcs"
            txtFluVaccinePrice.Text = "₱0.00"
        End If
    End Sub

    ' Calculate change when payment amount changes
    Private Sub CalculateChange(sender As Object, e As EventArgs)
        Try
            If Decimal.TryParse(txtAmtPaid.Text.Replace("₱", "").Trim(), Nothing) Then
                Dim amountPaid As Decimal = Decimal.Parse(txtAmtPaid.Text.Replace("₱", "").Trim())
                Dim change As Decimal = amountPaid - totalAmountDue
                txtChange.Text = $"₱{change:N2}"

                If change < 0 Then
                    txtChange.ForeColor = Color.Red
                Else
                    txtChange.ForeColor = Color.Green
                End If
            Else
                txtChange.Text = "₱0.00"
            End If
        Catch ex As Exception
            txtChange.Text = "₱0.00"
        End Try
    End Sub

    ' Save billing record to file
    Private Sub SaveBillingToFile()
        Try
            Dim billingFilePath As String = GlobalVariables.GetFilePath("billing.txt")

            ' Get visit type
            Dim visitType As String = ""
            If chbInitial.Checked Then visitType = "Initial Checkup"
            If chbFollow.Checked Then visitType = "Follow-up Checkup"

            ' Create billing record
            Dim billingRecord As String = $"{txtFullName.Text}|{txtPhoneNumber.Text}|{visitType}|{visitTypePrice}|{GetPrescribedVitamins()}|{totalAmountDue}|{txtAmtPaid.Text.Replace("₱", "").Trim()}|Complete|{DateTime.Now:MM/dd/yyyy HH:mm}"

            File.AppendAllText(billingFilePath, billingRecord & Environment.NewLine)

        Catch ex As Exception
            MessageBox.Show("Error saving billing record: " & ex.Message)
        End Try
    End Sub

    ' Get list of prescribed vitamins
    Private Function GetPrescribedVitamins() As String
        Dim vitamins As New List(Of String)

        If txtIronVitamin.Text <> "0 pcs" Then vitamins.Add("Iron Vitamin")
        If txtBComplex.Text <> "0 pcs" Then vitamins.Add("B Complex")
        If txtDHA.Text <> "0 pcs" Then vitamins.Add("DHA")
        If txtFluVaccine.Text <> "0 pcs" Then vitamins.Add("Flu Vaccine")

        Return String.Join(", ", vitamins)
    End Function

    ' Complete billing and payment
    Private Sub btnCompleteBP_Click(sender As Object, e As EventArgs) Handles btnCompleteBP.Click
        Try
            ' Validate payment
            If String.IsNullOrEmpty(txtAmtPaid.Text) OrElse Not Decimal.TryParse(txtAmtPaid.Text.Replace("₱", "").Trim(), Nothing) Then
                MessageBox.Show("Please enter a valid payment amount.")
                Return
            End If

            Dim amountPaid As Decimal = Decimal.Parse(txtAmtPaid.Text.Replace("₱", "").Trim())
            If amountPaid < totalAmountDue Then
                MessageBox.Show("Please enter sufficient payment amount.")
                Return
            End If

            ' Update status and save
            txtStatus.Text = "Complete"
            SaveBillingToFile()

            MessageBox.Show("Billing and payment completed successfully! Your change is " + txtChange.Text)

            ' Return to Patient Menu
            Dim patientMenu As New Form4()
            patientMenu.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error completing billing: " & ex.Message)
        End Try
    End Sub

    ' Delete patient and schedule records after payment
    Private Sub DeletePatientAndSchedules()
        Try
            Dim patientsFilePath As String = GlobalVariables.GetFilePath("patients.txt")
            Dim schedulesFilePath As String = GlobalVariables.GetFilePath("schedules.txt")

            ' Delete from patients.txt
            If File.Exists(patientsFilePath) Then
                Dim patientsList As New List(Of String)(File.ReadAllLines(patientsFilePath))
                patientsList.RemoveAll(Function(p) p.Contains(currentPatientPhone))
                File.WriteAllLines(patientsFilePath, patientsList.ToArray())
            End If

            ' Delete from schedules.txt
            If File.Exists(schedulesFilePath) Then
                Dim schedulesList As New List(Of String)(File.ReadAllLines(schedulesFilePath))
                schedulesList.RemoveAll(Function(s) s.Contains(currentPatientPhone))
                File.WriteAllLines(schedulesFilePath, schedulesList.ToArray())
            End If

        Catch ex As Exception
            MessageBox.Show("Warning: Could not delete patient records", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Form load - setup event handlers
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtAmtPaid.TextChanged, AddressOf CalculateChange
        chbInitial.Enabled = False
        chbFollow.Enabled = False
    End Sub

    ' Checkbox handlers - ensure only one visit type is selected
    Private Sub chbInitial_CheckedChanged(sender As Object, e As EventArgs) Handles chbInitial.CheckedChanged
        If chbInitial.Checked Then chbFollow.Checked = False
    End Sub

    Private Sub chbFollow_CheckedChanged(sender As Object, e As EventArgs) Handles chbFollow.CheckedChanged
        If chbFollow.Checked Then chbInitial.Checked = False
    End Sub

    ' Back button - return to patient menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form4.Show()
    End Sub

End Class