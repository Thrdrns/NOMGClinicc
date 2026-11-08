<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.btnBackReg = New System.Windows.Forms.Button()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbObReg = New System.Windows.Forms.ComboBox()
        Me.lblOB = New System.Windows.Forms.Label()
        Me.txtGestAge = New System.Windows.Forms.TextBox()
        Me.lblGA = New System.Windows.Forms.Label()
        Me.dtpReg = New System.Windows.Forms.DateTimePicker()
        Me.lblLMP = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.chbBaby = New System.Windows.Forms.CheckBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.cmbCivil = New System.Windows.Forms.ComboBox()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblCivil = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.txtSexReg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBackReg
        '
        Me.btnBackReg.BackColor = System.Drawing.Color.Indigo
        Me.btnBackReg.ForeColor = System.Drawing.Color.White
        Me.btnBackReg.Location = New System.Drawing.Point(520, 293)
        Me.btnBackReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBackReg.Name = "btnBackReg"
        Me.btnBackReg.Size = New System.Drawing.Size(91, 25)
        Me.btnBackReg.TabIndex = 85
        Me.btnBackReg.Text = "Back"
        Me.btnBackReg.UseVisualStyleBackColor = False
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(400, 124)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(53, 21)
        Me.txtAge.TabIndex = 84
        '
        'txtAddr
        '
        Me.txtAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr.Location = New System.Drawing.Point(310, 164)
        Me.txtAddr.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(290, 21)
        Me.txtAddr.TabIndex = 83
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(114, 124)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(239, 21)
        Me.txtFullName.TabIndex = 82
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Indigo
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(421, 293)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 25)
        Me.btnClear.TabIndex = 81
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Indigo
        Me.btnSave.Font = New System.Drawing.Font("Gotham Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(322, 293)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 25)
        Me.btnSave.TabIndex = 80
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbObReg
        '
        Me.cmbObReg.FormattingEnabled = True
        Me.cmbObReg.Items.AddRange(New Object() {"Dr. Nom"})
        Me.cmbObReg.Location = New System.Drawing.Point(429, 250)
        Me.cmbObReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbObReg.Name = "cmbObReg"
        Me.cmbObReg.Size = New System.Drawing.Size(116, 21)
        Me.cmbObReg.TabIndex = 79
        '
        'lblOB
        '
        Me.lblOB.AutoSize = True
        Me.lblOB.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOB.Location = New System.Drawing.Point(317, 247)
        Me.lblOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOB.Name = "lblOB"
        Me.lblOB.Size = New System.Drawing.Size(118, 25)
        Me.lblOB.TabIndex = 78
        Me.lblOB.Text = "Assigned OB: "
        '
        'txtGestAge
        '
        Me.txtGestAge.Location = New System.Drawing.Point(162, 273)
        Me.txtGestAge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGestAge.Name = "txtGestAge"
        Me.txtGestAge.ReadOnly = True
        Me.txtGestAge.Size = New System.Drawing.Size(116, 21)
        Me.txtGestAge.TabIndex = 77
        '
        'lblGA
        '
        Me.lblGA.AutoSize = True
        Me.lblGA.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGA.Location = New System.Drawing.Point(14, 273)
        Me.lblGA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGA.Name = "lblGA"
        Me.lblGA.Size = New System.Drawing.Size(140, 25)
        Me.lblGA.TabIndex = 76
        Me.lblGA.Text = "Gestational Age:"
        '
        'dtpReg
        '
        Me.dtpReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReg.Location = New System.Drawing.Point(204, 251)
        Me.dtpReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpReg.Name = "dtpReg"
        Me.dtpReg.Size = New System.Drawing.Size(97, 21)
        Me.dtpReg.TabIndex = 75
        '
        'lblLMP
        '
        Me.lblLMP.AutoSize = True
        Me.lblLMP.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMP.Location = New System.Drawing.Point(10, 250)
        Me.lblLMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLMP.Name = "lblLMP"
        Me.lblLMP.Size = New System.Drawing.Size(190, 25)
        Me.lblLMP.TabIndex = 74
        Me.lblLMP.Text = "Last Menstrual Period: "
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Avenir Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(177, 212)
        Me.lblDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(278, 38)
        Me.lblDetails.TabIndex = 73
        Me.lblDetails.Text = "PREGNANCY DETAILS"
        '
        'chbBaby
        '
        Me.chbBaby.AutoSize = True
        Me.chbBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBaby.Location = New System.Drawing.Point(144, 195)
        Me.chbBaby.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chbBaby.Name = "chbBaby"
        Me.chbBaby.Size = New System.Drawing.Size(56, 24)
        Me.chbBaby.TabIndex = 72
        Me.chbBaby.Text = "Yes"
        Me.chbBaby.UseVisualStyleBackColor = True
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(26, 195)
        Me.lblFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(99, 25)
        Me.lblFirst.TabIndex = 71
        Me.lblFirst.Text = "First Baby: "
        '
        'cmbCivil
        '
        Me.cmbCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCivil.FormattingEnabled = True
        Me.cmbCivil.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        Me.cmbCivil.Location = New System.Drawing.Point(131, 166)
        Me.cmbCivil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbCivil.Name = "cmbCivil"
        Me.cmbCivil.Size = New System.Drawing.Size(94, 21)
        Me.cmbCivil.TabIndex = 70
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr.Location = New System.Drawing.Point(236, 161)
        Me.lblAddr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(84, 25)
        Me.lblAddr.TabIndex = 68
        Me.lblAddr.Text = "Address: "
        '
        'lblCivil
        '
        Me.lblCivil.AutoSize = True
        Me.lblCivil.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCivil.Location = New System.Drawing.Point(24, 162)
        Me.lblCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCivil.Name = "lblCivil"
        Me.lblCivil.Size = New System.Drawing.Size(107, 25)
        Me.lblCivil.TabIndex = 67
        Me.lblCivil.Text = "Civil Status: "
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Avenir Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(200, 67)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(226, 38)
        Me.lblInfo.TabIndex = 66
        Me.lblInfo.Text = "PATIENT DETAILS"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(468, 123)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(44, 25)
        Me.lblSex.TabIndex = 65
        Me.lblSex.Text = "Sex:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(357, 123)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(53, 25)
        Me.lblAge.TabIndex = 64
        Me.lblAge.Text = "Age: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Avenir Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(26, 123)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 25)
        Me.lblName.TabIndex = 63
        Me.lblName.Text = "Full Name:"
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.Font = New System.Drawing.Font("Gotham Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.Location = New System.Drawing.Point(112, 9)
        Me.NOMGClinic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(403, 58)
        Me.NOMGClinic.TabIndex = 62
        Me.NOMGClinic.Text = "NOMGYN Clinic"
        '
        'txtSexReg
        '
        Me.txtSexReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexReg.Location = New System.Drawing.Point(508, 124)
        Me.txtSexReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSexReg.Name = "txtSexReg"
        Me.txtSexReg.ReadOnly = True
        Me.txtSexReg.Size = New System.Drawing.Size(92, 21)
        Me.txtSexReg.TabIndex = 85
        Me.txtSexReg.Text = "Female"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 352)
        Me.Controls.Add(Me.txtSexReg)
        Me.Controls.Add(Me.btnBackReg)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbObReg)
        Me.Controls.Add(Me.lblOB)
        Me.Controls.Add(Me.txtGestAge)
        Me.Controls.Add(Me.lblGA)
        Me.Controls.Add(Me.dtpReg)
        Me.Controls.Add(Me.lblLMP)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.chbBaby)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.cmbCivil)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblCivil)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.NOMGClinic)
        Me.Font = New System.Drawing.Font("Gotham Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackReg As Button
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtAddr As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbObReg As ComboBox
    Friend WithEvents lblOB As Label
    Friend WithEvents txtGestAge As TextBox
    Friend WithEvents lblGA As Label
    Friend WithEvents dtpReg As DateTimePicker
    Friend WithEvents lblLMP As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents chbBaby As CheckBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents cmbCivil As ComboBox
    Friend WithEvents lblAddr As Label
    Friend WithEvents lblCivil As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblName As Label
    Friend WithEvents NOMGClinic As Label
    Friend WithEvents txtSexReg As TextBox
End Class
