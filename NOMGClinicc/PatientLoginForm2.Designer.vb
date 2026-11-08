<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientLoginForm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientLoginForm2))
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lblLMP = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.White
        Me.NOMGClinic.Location = New System.Drawing.Point(18, 11)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(316, 33)
        Me.NOMGClinic.TabIndex = 17
        Me.NOMGClinic.Text = "MATERBONYA Clinic"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(42, 249)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(254, 21)
        Me.txtLastName.TabIndex = 91
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(44, 120)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(254, 21)
        Me.txtFirstName.TabIndex = 90
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAddr.Location = New System.Drawing.Point(40, 226)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(105, 20)
        Me.lblAddr.TabIndex = 88
        Me.lblAddr.Text = "Last Name: "
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAge.Location = New System.Drawing.Point(40, 164)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(122, 20)
        Me.lblAge.TabIndex = 86
        Me.lblAge.Text = "Middle Name: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblName.Location = New System.Drawing.Point(40, 97)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(96, 20)
        Me.lblName.TabIndex = 85
        Me.lblName.Text = "First Name"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(133, 298)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(163, 20)
        Me.dtpBirthDate.TabIndex = 94
        '
        'lblLMP
        '
        Me.lblLMP.AutoSize = True
        Me.lblLMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMP.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblLMP.Location = New System.Drawing.Point(38, 298)
        Me.lblLMP.Name = "lblLMP"
        Me.lblLMP.Size = New System.Drawing.Size(88, 20)
        Me.lblLMP.TabIndex = 93
        Me.lblLMP.Text = "Birthdate:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(43, 187)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(254, 21)
        Me.txtMiddleName.TabIndex = 95
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 349)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(323, 57)
        Me.btnSave.TabIndex = 96
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.NOMGClinic)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 54)
        Me.Panel1.TabIndex = 97
        '
        'PatientLoginForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(344, 418)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.dtpBirthDate)
        Me.Controls.Add(Me.lblLMP)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientLoginForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NOMGClinic As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblAddr As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblName As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents lblLMP As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
End Class
