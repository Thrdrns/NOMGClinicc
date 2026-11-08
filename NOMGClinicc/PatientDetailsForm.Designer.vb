<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientDetailsForm))
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
        Me.chbBaby = New System.Windows.Forms.CheckBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.cmbCivil = New System.Windows.Forms.ComboBox()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblCivil = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.txtSexReg = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(397, 28)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(53, 21)
        Me.txtAge.TabIndex = 84
        '
        'txtAddr
        '
        Me.txtAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr.Location = New System.Drawing.Point(304, 72)
        Me.txtAddr.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(290, 21)
        Me.txtAddr.TabIndex = 83
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(112, 28)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(222, 21)
        Me.txtFullName.TabIndex = 82
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(286, 335)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 37)
        Me.btnClear.TabIndex = 81
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(455, 335)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 37)
        Me.btnSave.TabIndex = 80
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbObReg
        '
        Me.cmbObReg.FormattingEnabled = True
        Me.cmbObReg.Items.AddRange(New Object() {"Dr. Nom"})
        Me.cmbObReg.Location = New System.Drawing.Point(478, 32)
        Me.cmbObReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbObReg.Name = "cmbObReg"
        Me.cmbObReg.Size = New System.Drawing.Size(116, 24)
        Me.cmbObReg.TabIndex = 79
        '
        'lblOB
        '
        Me.lblOB.AutoSize = True
        Me.lblOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOB.ForeColor = System.Drawing.Color.Black
        Me.lblOB.Location = New System.Drawing.Point(347, 32)
        Me.lblOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOB.Name = "lblOB"
        Me.lblOB.Size = New System.Drawing.Size(123, 20)
        Me.lblOB.TabIndex = 78
        Me.lblOB.Text = "Assigned OB: "
        '
        'txtGestAge
        '
        Me.txtGestAge.Location = New System.Drawing.Point(163, 79)
        Me.txtGestAge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGestAge.Name = "txtGestAge"
        Me.txtGestAge.ReadOnly = True
        Me.txtGestAge.Size = New System.Drawing.Size(139, 22)
        Me.txtGestAge.TabIndex = 77
        '
        'lblGA
        '
        Me.lblGA.AutoSize = True
        Me.lblGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGA.ForeColor = System.Drawing.Color.Black
        Me.lblGA.Location = New System.Drawing.Point(11, 79)
        Me.lblGA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGA.Name = "lblGA"
        Me.lblGA.Size = New System.Drawing.Size(144, 20)
        Me.lblGA.TabIndex = 76
        Me.lblGA.Text = "Gestational Age:"
        '
        'dtpReg
        '
        Me.dtpReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReg.Location = New System.Drawing.Point(205, 31)
        Me.dtpReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpReg.Name = "dtpReg"
        Me.dtpReg.Size = New System.Drawing.Size(97, 22)
        Me.dtpReg.TabIndex = 75
        '
        'lblLMP
        '
        Me.lblLMP.AutoSize = True
        Me.lblLMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMP.ForeColor = System.Drawing.Color.Black
        Me.lblLMP.Location = New System.Drawing.Point(11, 30)
        Me.lblLMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLMP.Name = "lblLMP"
        Me.lblLMP.Size = New System.Drawing.Size(194, 20)
        Me.lblLMP.TabIndex = 74
        Me.lblLMP.Text = "Last Menstrual Period: "
        '
        'chbBaby
        '
        Me.chbBaby.AutoSize = True
        Me.chbBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBaby.ForeColor = System.Drawing.Color.Black
        Me.chbBaby.Location = New System.Drawing.Point(109, 116)
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
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.Black
        Me.lblFirst.Location = New System.Drawing.Point(7, 117)
        Me.lblFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(100, 20)
        Me.lblFirst.TabIndex = 71
        Me.lblFirst.Text = "First Baby: "
        '
        'cmbCivil
        '
        Me.cmbCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCivil.FormattingEnabled = True
        Me.cmbCivil.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        Me.cmbCivil.Location = New System.Drawing.Point(112, 73)
        Me.cmbCivil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbCivil.Name = "cmbCivil"
        Me.cmbCivil.Size = New System.Drawing.Size(94, 21)
        Me.cmbCivil.TabIndex = 70
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr.ForeColor = System.Drawing.Color.Black
        Me.lblAddr.Location = New System.Drawing.Point(217, 72)
        Me.lblAddr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(85, 20)
        Me.lblAddr.TabIndex = 68
        Me.lblAddr.Text = "Address: "
        '
        'lblCivil
        '
        Me.lblCivil.AutoSize = True
        Me.lblCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCivil.ForeColor = System.Drawing.Color.Black
        Me.lblCivil.Location = New System.Drawing.Point(5, 73)
        Me.lblCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCivil.Name = "lblCivil"
        Me.lblCivil.Size = New System.Drawing.Size(109, 20)
        Me.lblCivil.TabIndex = 67
        Me.lblCivil.Text = "Civil Status: "
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Black
        Me.lblSex.Location = New System.Drawing.Point(459, 27)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(44, 20)
        Me.lblSex.TabIndex = 65
        Me.lblSex.Text = "Sex:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(346, 27)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(51, 20)
        Me.lblAge.TabIndex = 64
        Me.lblAge.Text = "Age: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(7, 27)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 20)
        Me.lblName.TabIndex = 63
        Me.lblName.Text = "Full Name:"
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.White
        Me.NOMGClinic.Location = New System.Drawing.Point(13, 4)
        Me.NOMGClinic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(294, 45)
        Me.NOMGClinic.TabIndex = 62
        Me.NOMGClinic.Text = "NOMGYN Clinic"
        '
        'txtSexReg
        '
        Me.txtSexReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexReg.Location = New System.Drawing.Point(504, 28)
        Me.txtSexReg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSexReg.Name = "txtSexReg"
        Me.txtSexReg.ReadOnly = True
        Me.txtSexReg.Size = New System.Drawing.Size(92, 21)
        Me.txtSexReg.TabIndex = 85
        Me.txtSexReg.Text = "Female"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.NOMGClinic)
        Me.Panel1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 51)
        Me.Panel1.TabIndex = 86
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.txtSexReg)
        Me.GroupBox1.Controls.Add(Me.lblSex)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.lblCivil)
        Me.GroupBox1.Controls.Add(Me.txtAddr)
        Me.GroupBox1.Controls.Add(Me.lblAddr)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.cmbCivil)
        Me.GroupBox1.Controls.Add(Me.lblFirst)
        Me.GroupBox1.Controls.Add(Me.chbBaby)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 149)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLMP)
        Me.GroupBox2.Controls.Add(Me.dtpReg)
        Me.GroupBox2.Controls.Add(Me.lblGA)
        Me.GroupBox2.Controls.Add(Me.txtGestAge)
        Me.GroupBox2.Controls.Add(Me.lblOB)
        Me.GroupBox2.Controls.Add(Me.cmbObReg)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 108)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pregnancy Details"
        '
        'PatientDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 383)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "PatientDetailsForm"
        Me.Text = "Patient Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents chbBaby As CheckBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents cmbCivil As ComboBox
    Friend WithEvents lblAddr As Label
    Friend WithEvents lblCivil As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblName As Label
    Friend WithEvents NOMGClinic As Label
    Friend WithEvents txtSexReg As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
