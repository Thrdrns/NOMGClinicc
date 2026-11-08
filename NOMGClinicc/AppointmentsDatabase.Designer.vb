<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentsDatabase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.Doctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfPatient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextVisit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.Font = New System.Drawing.Font("Gotham Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.Indigo
        Me.NOMGClinic.Location = New System.Drawing.Point(12, 18)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(266, 36)
        Me.NOMGClinic.TabIndex = 10
        Me.NOMGClinic.Text = "APPOINTMENTS"
        '
        'dgvAppointments
        '
        Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Doctor, Me.Status, Me.NameOfPatient, Me.Purpose, Me.ScheduledDate, Me.Time, Me.NextVisit, Me.PhoneNumber})
        Me.dgvAppointments.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvAppointments.Location = New System.Drawing.Point(5, 60)
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.RowHeadersWidth = 51
        Me.dgvAppointments.Size = New System.Drawing.Size(608, 249)
        Me.dgvAppointments.TabIndex = 11
        '
        'Doctor
        '
        Me.Doctor.HeaderText = "Doctor"
        Me.Doctor.MinimumWidth = 6
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'NameOfPatient
        '
        Me.NameOfPatient.HeaderText = "Name of Patient"
        Me.NameOfPatient.MinimumWidth = 6
        Me.NameOfPatient.Name = "NameOfPatient"
        Me.NameOfPatient.Width = 150
        '
        'Purpose
        '
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.MinimumWidth = 6
        Me.Purpose.Name = "Purpose"
        Me.Purpose.Width = 125
        '
        'ScheduledDate
        '
        Me.ScheduledDate.HeaderText = "Scheduled Date"
        Me.ScheduledDate.MinimumWidth = 6
        Me.ScheduledDate.Name = "ScheduledDate"
        Me.ScheduledDate.Width = 125
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.MinimumWidth = 6
        Me.Time.Name = "Time"
        Me.Time.Width = 125
        '
        'NextVisit
        '
        Me.NextVisit.HeaderText = "Next Visit"
        Me.NextVisit.Name = "NextVisit"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.MinimumWidth = 6
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Width = 125
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Indigo
        Me.btnBack.Font = New System.Drawing.Font("Avenir Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(507, 315)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 23)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(338, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(272, 29)
        Me.txtSearch.TabIndex = 14
        '
        'AppointmentsDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 352)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvAppointments)
        Me.Controls.Add(Me.NOMGClinic)
        Me.Name = "AppointmentsDatabase"
        Me.Text = "Appointments Database"
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NOMGClinic As Label
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents NameOfPatient As DataGridViewTextBoxColumn
    Friend WithEvents Purpose As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledDate As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents NextVisit As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
End Class
