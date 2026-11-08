<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentRecordsDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentRecordsDatabase))
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.dgvPaymentRecords = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.columnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckupPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vitamins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPaymentRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.BackColor = System.Drawing.Color.Transparent
        Me.NOMGClinic.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.Transparent
        Me.NOMGClinic.Location = New System.Drawing.Point(3, 6)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(325, 45)
        Me.NOMGClinic.TabIndex = 9
        Me.NOMGClinic.Text = "Payment Records"
        '
        'dgvPaymentRecords
        '
        Me.dgvPaymentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnName, Me.PhoneNumber, Me.CheckupPrice, Me.Vitamins, Me.TotalAmount, Me.AmountPaid, Me.Status, Me.DatePaid})
        Me.dgvPaymentRecords.Location = New System.Drawing.Point(8, 53)
        Me.dgvPaymentRecords.Name = "dgvPaymentRecords"
        Me.dgvPaymentRecords.RowHeadersWidth = 51
        Me.dgvPaymentRecords.Size = New System.Drawing.Size(1099, 549)
        Me.dgvPaymentRecords.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(875, 608)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 35)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(994, 608)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(113, 35)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(707, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(403, 29)
        Me.txtSearch.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.NOMGClinic)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(-3, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1123, 54)
        Me.Panel1.TabIndex = 14
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
        Me.Vitamins.Width = 150
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
        'PaymentRecordsDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 649)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvPaymentRecords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PaymentRecordsDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Records Database"
        CType(Me.dgvPaymentRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NOMGClinic As Label
    Friend WithEvents dgvPaymentRecords As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents columnName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents CheckupPrice As DataGridViewTextBoxColumn
    Friend WithEvents Vitamins As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DatePaid As DataGridViewTextBoxColumn
End Class
