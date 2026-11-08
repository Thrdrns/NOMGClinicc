<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btnBillingAndPayments = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.lblAdminMenu = New System.Windows.Forms.Label()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBillingAndPayments
        '
        Me.btnBillingAndPayments.BackColor = System.Drawing.Color.Indigo
        Me.btnBillingAndPayments.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingAndPayments.ForeColor = System.Drawing.Color.White
        Me.btnBillingAndPayments.Location = New System.Drawing.Point(230, 161)
        Me.btnBillingAndPayments.Name = "btnBillingAndPayments"
        Me.btnBillingAndPayments.Size = New System.Drawing.Size(154, 86)
        Me.btnBillingAndPayments.TabIndex = 14
        Me.btnBillingAndPayments.Text = "PAYMENT RECORDS"
        Me.btnBillingAndPayments.UseVisualStyleBackColor = False
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.Indigo
        Me.btnAppointments.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointments.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Location = New System.Drawing.Point(419, 161)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(154, 86)
        Me.btnAppointments.TabIndex = 13
        Me.btnAppointments.Text = "APPOINTMENTS"
        Me.btnAppointments.UseVisualStyleBackColor = False
        '
        'lblAdminMenu
        '
        Me.lblAdminMenu.AutoSize = True
        Me.lblAdminMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminMenu.Font = New System.Drawing.Font("Avenir Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminMenu.ForeColor = System.Drawing.Color.Indigo
        Me.lblAdminMenu.Location = New System.Drawing.Point(232, 92)
        Me.lblAdminMenu.Name = "lblAdminMenu"
        Me.lblAdminMenu.Size = New System.Drawing.Size(163, 38)
        Me.lblAdminMenu.TabIndex = 12
        Me.lblAdminMenu.Text = "Admin Menu"
        '
        'btnPatient
        '
        Me.btnPatient.BackColor = System.Drawing.Color.Indigo
        Me.btnPatient.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatient.ForeColor = System.Drawing.Color.White
        Me.btnPatient.Location = New System.Drawing.Point(44, 161)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(154, 86)
        Me.btnPatient.TabIndex = 11
        Me.btnPatient.Text = "PATIENTS"
        Me.btnPatient.UseVisualStyleBackColor = False
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
        Me.NOMGClinic.TabIndex = 10
        Me.NOMGClinic.Text = "NOMGYN Clinic"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Indigo
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(260, 300)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(107, 28)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 352)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBillingAndPayments)
        Me.Controls.Add(Me.btnAppointments)
        Me.Controls.Add(Me.lblAdminMenu)
        Me.Controls.Add(Me.btnPatient)
        Me.Controls.Add(Me.NOMGClinic)
        Me.Name = "Form3"
        Me.Text = "D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBillingAndPayments As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents lblAdminMenu As Label
    Friend WithEvents btnPatient As Button
    Friend WithEvents NOMGClinic As Label
    Friend WithEvents btnLogout As Button
End Class
