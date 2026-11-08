<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenuForm))
        Me.btnBillingAndPayments = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.lblAdminMenu = New System.Windows.Forms.Label()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBillingAndPayments
        '
        Me.btnBillingAndPayments.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBillingAndPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingAndPayments.ForeColor = System.Drawing.Color.White
        Me.btnBillingAndPayments.Location = New System.Drawing.Point(44, 211)
        Me.btnBillingAndPayments.Name = "btnBillingAndPayments"
        Me.btnBillingAndPayments.Size = New System.Drawing.Size(286, 86)
        Me.btnBillingAndPayments.TabIndex = 14
        Me.btnBillingAndPayments.Text = "PAYMENT RECORDS"
        Me.btnBillingAndPayments.UseVisualStyleBackColor = False
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointments.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Location = New System.Drawing.Point(44, 303)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(286, 86)
        Me.btnAppointments.TabIndex = 13
        Me.btnAppointments.Text = "APPOINTMENTS"
        Me.btnAppointments.UseVisualStyleBackColor = False
        '
        'lblAdminMenu
        '
        Me.lblAdminMenu.AutoSize = True
        Me.lblAdminMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminMenu.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAdminMenu.Location = New System.Drawing.Point(107, 77)
        Me.lblAdminMenu.Name = "lblAdminMenu"
        Me.lblAdminMenu.Size = New System.Drawing.Size(157, 29)
        Me.lblAdminMenu.TabIndex = 12
        Me.lblAdminMenu.Text = "Admin Menu"
        '
        'btnPatient
        '
        Me.btnPatient.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatient.ForeColor = System.Drawing.Color.White
        Me.btnPatient.Location = New System.Drawing.Point(44, 119)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(286, 86)
        Me.btnPatient.TabIndex = 11
        Me.btnPatient.Text = "PATIENTS"
        Me.btnPatient.UseVisualStyleBackColor = False
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.BackColor = System.Drawing.Color.Transparent
        Me.NOMGClinic.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.White
        Me.NOMGClinic.Location = New System.Drawing.Point(18, 6)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(337, 52)
        Me.NOMGClinic.TabIndex = 10
        Me.NOMGClinic.Text = "NOMGYN Clinic"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(223, 410)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(107, 28)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(44, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 28)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "view accounts"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.NOMGClinic)
        Me.Panel1.Location = New System.Drawing.Point(-3, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 67)
        Me.Panel1.TabIndex = 24
        '
        'AdminMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBillingAndPayments)
        Me.Controls.Add(Me.btnAppointments)
        Me.Controls.Add(Me.lblAdminMenu)
        Me.Controls.Add(Me.btnPatient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBillingAndPayments As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents lblAdminMenu As Label
    Friend WithEvents btnPatient As Button
    Friend WithEvents NOMGClinic As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
End Class
