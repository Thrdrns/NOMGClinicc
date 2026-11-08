<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMenuForm
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
        Me.btnBillingAndPayments = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.lblPatientMenu = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBillingAndPayments
        '
        Me.btnBillingAndPayments.BackColor = System.Drawing.Color.Indigo
        Me.btnBillingAndPayments.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingAndPayments.ForeColor = System.Drawing.Color.White
        Me.btnBillingAndPayments.Location = New System.Drawing.Point(351, 171)
        Me.btnBillingAndPayments.Name = "btnBillingAndPayments"
        Me.btnBillingAndPayments.Size = New System.Drawing.Size(154, 86)
        Me.btnBillingAndPayments.TabIndex = 20
        Me.btnBillingAndPayments.Text = "BILLING AND CUSTOMER PAYMENTS"
        Me.btnBillingAndPayments.UseVisualStyleBackColor = False
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.Indigo
        Me.btnAppointments.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointments.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Location = New System.Drawing.Point(122, 171)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(154, 86)
        Me.btnAppointments.TabIndex = 19
        Me.btnAppointments.Text = "BOOK APPOINTMENT"
        Me.btnAppointments.UseVisualStyleBackColor = False
        '
        'lblPatientMenu
        '
        Me.lblPatientMenu.AutoSize = True
        Me.lblPatientMenu.Font = New System.Drawing.Font("Avenir Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientMenu.ForeColor = System.Drawing.Color.Indigo
        Me.lblPatientMenu.Location = New System.Drawing.Point(238, 98)
        Me.lblPatientMenu.Name = "lblPatientMenu"
        Me.lblPatientMenu.Size = New System.Drawing.Size(142, 38)
        Me.lblPatientMenu.TabIndex = 17
        Me.lblPatientMenu.Text = "User Menu"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Indigo
        Me.btnLogout.Font = New System.Drawing.Font("Avenir Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(260, 297)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(107, 28)
        Me.btnLogout.TabIndex = 21
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.BackColor = System.Drawing.Color.Transparent
        Me.NOMGClinic.Font = New System.Drawing.Font("Gotham Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.Indigo
        Me.NOMGClinic.Location = New System.Drawing.Point(112, 26)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(403, 58)
        Me.NOMGClinic.TabIndex = 22
        Me.NOMGClinic.Text = "NOMGYN Clinic"
        '
        'UserMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 352)
        Me.Controls.Add(Me.NOMGClinic)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBillingAndPayments)
        Me.Controls.Add(Me.btnAppointments)
        Me.Controls.Add(Me.lblPatientMenu)
        Me.Name = "UserMenuForm"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBillingAndPayments As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents lblPatientMenu As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents NOMGClinic As Label
End Class
