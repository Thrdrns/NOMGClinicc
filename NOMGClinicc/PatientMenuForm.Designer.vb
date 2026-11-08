<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientMenuForm))
        Me.btnBillingAndPayments = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.lblPatientMenu = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBillingAndPayments
        '
        Me.btnBillingAndPayments.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBillingAndPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingAndPayments.ForeColor = System.Drawing.Color.White
        Me.btnBillingAndPayments.Location = New System.Drawing.Point(281, 111)
        Me.btnBillingAndPayments.Name = "btnBillingAndPayments"
        Me.btnBillingAndPayments.Size = New System.Drawing.Size(253, 86)
        Me.btnBillingAndPayments.TabIndex = 20
        Me.btnBillingAndPayments.Text = "BILLING AND CUSTOMER PAYMENTS"
        Me.btnBillingAndPayments.UseVisualStyleBackColor = False
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointments.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Location = New System.Drawing.Point(12, 111)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(253, 86)
        Me.btnAppointments.TabIndex = 19
        Me.btnAppointments.Text = "BOOK APPOINTMENT"
        Me.btnAppointments.UseVisualStyleBackColor = False
        '
        'lblPatientMenu
        '
        Me.lblPatientMenu.AutoSize = True
        Me.lblPatientMenu.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientMenu.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPatientMenu.Location = New System.Drawing.Point(191, 70)
        Me.lblPatientMenu.Name = "lblPatientMenu"
        Me.lblPatientMenu.Size = New System.Drawing.Size(164, 29)
        Me.lblPatientMenu.TabIndex = 17
        Me.lblPatientMenu.Text = "Patient Menu"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(446, 6)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(97, 37)
        Me.btnLogout.TabIndex = 21
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.BackColor = System.Drawing.Color.Transparent
        Me.NOMGClinic.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.White
        Me.NOMGClinic.Location = New System.Drawing.Point(3, 0)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(381, 45)
        Me.NOMGClinic.TabIndex = 22
        Me.NOMGClinic.Text = "MATERBONYA Clinic"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.NOMGClinic)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 45)
        Me.Panel1.TabIndex = 23
        '
        'PatientMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(544, 221)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPatientMenu)
        Me.Controls.Add(Me.btnBillingAndPayments)
        Me.Controls.Add(Me.btnAppointments)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBillingAndPayments As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents lblPatientMenu As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents NOMGClinic As Label
    Friend WithEvents Panel1 As Panel
End Class
