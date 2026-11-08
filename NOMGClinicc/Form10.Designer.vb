<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.dgvPaymentRecords = New System.Windows.Forms.DataGridView()
        Me.columnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckupPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vitamins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvPaymentRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.Font = New System.Drawing.Font("Gotham Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.Indigo
        Me.NOMGClinic.Location = New System.Drawing.Point(12, 31)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(301, 38)
        Me.NOMGClinic.TabIndex = 9
        Me.NOMGClinic.Text = "Payment Records"
        '
        'dgvPaymentRecords
        '
        Me.dgvPaymentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnName, Me.PhoneNumber, Me.CheckupPrice, Me.Vitamins, Me.TotalAmount, Me.AmountPaid, Me.Status, Me.DatePaid})
        Me.dgvPaymentRecords.Location = New System.Drawing.Point(36, 72)
        Me.dgvPaymentRecords.Name = "dgvPaymentRecords"
        Me.dgvPaymentRecords.RowHeadersWidth = 51
        Me.dgvPaymentRecords.Size = New System.Drawing.Size(554, 200)
        Me.dgvPaymentRecords.TabIndex = 10
        '
        'columnName
        '
        Me.columnName.HeaderText = "Name of Patient"
        Me.columnName.MinimumWidth = 6
        Me.columnName.Name = "columnName"
        Me.columnName.Width = 150
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.MinimumWidth = 6
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Width = 125
        '
        'CheckupPrice
        '
        Me.CheckupPrice.HeaderText = "Checkup Price"
        Me.CheckupPrice.MinimumWidth = 6
        Me.CheckupPrice.Name = "CheckupPrice"
        Me.CheckupPrice.Width = 125
        '
        'Vitamins
        '
        Me.Vitamins.HeaderText = "Vitamins"
        Me.Vitamins.MinimumWidth = 6
        Me.Vitamins.Name = "Vitamins"
        Me.Vitamins.Width = 300
        '
        'TotalAmount
        '
        Me.TotalAmount.HeaderText = "Total "
        Me.TotalAmount.MinimumWidth = 6
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Width = 125
        '
        'AmountPaid
        '
        Me.AmountPaid.HeaderText = "Total Paid"
        Me.AmountPaid.MinimumWidth = 6
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 125
        '
        'DatePaid
        '
        Me.DatePaid.HeaderText = "Date and Time"
        Me.DatePaid.MinimumWidth = 6
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.Width = 125
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Indigo
        Me.btnBack.Font = New System.Drawing.Font("Avenir Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(388, 302)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 25)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Indigo
        Me.btnRefresh.Font = New System.Drawing.Font("Avenir Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(485, 302)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(91, 25)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(318, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(272, 29)
        Me.txtSearch.TabIndex = 13
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 352)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvPaymentRecords)
        Me.Controls.Add(Me.NOMGClinic)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.dgvPaymentRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NOMGClinic As Label
    Friend WithEvents dgvPaymentRecords As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents columnName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents CheckupPrice As DataGridViewTextBoxColumn
    Friend WithEvents Vitamins As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DatePaid As DataGridViewTextBoxColumn
End Class
