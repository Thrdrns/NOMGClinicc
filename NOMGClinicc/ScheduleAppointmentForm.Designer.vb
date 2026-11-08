<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleAppointmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleAppointmentForm))
        Me.lbl9AM = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.txtSched = New System.Windows.Forms.TextBox()
        Me.cmbPurpose = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpSchedule = New System.Windows.Forms.DateTimePicker()
        Me.lblLMP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Schedule = New System.Windows.Forms.Label()
        Me.lbl11AM = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl3PM = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl4PM = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl2PM = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl10AM = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl9AM
        '
        Me.lbl9AM.AutoSize = True
        Me.lbl9AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9AM.ForeColor = System.Drawing.Color.Black
        Me.lbl9AM.Location = New System.Drawing.Point(128, 26)
        Me.lbl9AM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl9AM.Name = "lbl9AM"
        Me.lbl9AM.Size = New System.Drawing.Size(90, 17)
        Me.lbl9AM.TabIndex = 67
        Me.lbl9AM.Text = "AVAILABLE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "09:00 AM -"
        '
        'txtDoctor
        '
        Me.txtDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(89, 30)
        Me.txtDoctor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.ReadOnly = True
        Me.txtDoctor.Size = New System.Drawing.Size(173, 24)
        Me.txtDoctor.TabIndex = 64
        Me.txtDoctor.Text = "Dr. Nom"
        '
        'txtSched
        '
        Me.txtSched.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSched.Location = New System.Drawing.Point(13, 246)
        Me.txtSched.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSched.Name = "txtSched"
        Me.txtSched.ReadOnly = True
        Me.txtSched.Size = New System.Drawing.Size(506, 24)
        Me.txtSched.TabIndex = 63
        '
        'cmbPurpose
        '
        Me.cmbPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurpose.FormattingEnabled = True
        Me.cmbPurpose.Items.AddRange(New Object() {"Initial Checkup", "Follow-up Checkup"})
        Me.cmbPurpose.Location = New System.Drawing.Point(90, 134)
        Me.cmbPurpose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPurpose.Name = "cmbPurpose"
        Me.cmbPurpose.Size = New System.Drawing.Size(212, 24)
        Me.cmbPurpose.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Purpose: "
        '
        'dtpSchedule
        '
        Me.dtpSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSchedule.Location = New System.Drawing.Point(89, 68)
        Me.dtpSchedule.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpSchedule.Name = "dtpSchedule"
        Me.dtpSchedule.Size = New System.Drawing.Size(284, 22)
        Me.dtpSchedule.TabIndex = 57
        '
        'lblLMP
        '
        Me.lblLMP.AutoSize = True
        Me.lblLMP.BackColor = System.Drawing.Color.Transparent
        Me.lblLMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMP.ForeColor = System.Drawing.Color.Black
        Me.lblLMP.Location = New System.Drawing.Point(9, 68)
        Me.lblLMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLMP.Name = "lblLMP"
        Me.lblLMP.Size = New System.Drawing.Size(52, 17)
        Me.lblLMP.TabIndex = 56
        Me.lblLMP.Text = "Date: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Doctor: "
        '
        'Schedule
        '
        Me.Schedule.AutoSize = True
        Me.Schedule.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Schedule.ForeColor = System.Drawing.Color.White
        Me.Schedule.Location = New System.Drawing.Point(4, 7)
        Me.Schedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.Size = New System.Drawing.Size(312, 27)
        Me.Schedule.TabIndex = 52
        Me.Schedule.Text = "SCHEDULE APPOINTMENT"
        '
        'lbl11AM
        '
        Me.lbl11AM.AutoSize = True
        Me.lbl11AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11AM.ForeColor = System.Drawing.Color.Black
        Me.lbl11AM.Location = New System.Drawing.Point(126, 66)
        Me.lbl11AM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl11AM.Name = "lbl11AM"
        Me.lbl11AM.Size = New System.Drawing.Size(90, 17)
        Me.lbl11AM.TabIndex = 69
        Me.lbl11AM.Text = "AVAILABLE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "11:00 AM -"
        '
        'lbl3PM
        '
        Me.lbl3PM.AutoSize = True
        Me.lbl3PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3PM.ForeColor = System.Drawing.Color.Black
        Me.lbl3PM.Location = New System.Drawing.Point(126, 130)
        Me.lbl3PM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl3PM.Name = "lbl3PM"
        Me.lbl3PM.Size = New System.Drawing.Size(90, 17)
        Me.lbl3PM.TabIndex = 71
        Me.lbl3PM.Text = "AVAILABLE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 130)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "03:00 PM -"
        '
        'lbl4PM
        '
        Me.lbl4PM.AutoSize = True
        Me.lbl4PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4PM.ForeColor = System.Drawing.Color.Black
        Me.lbl4PM.Location = New System.Drawing.Point(126, 149)
        Me.lbl4PM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl4PM.Name = "lbl4PM"
        Me.lbl4PM.Size = New System.Drawing.Size(90, 17)
        Me.lbl4PM.TabIndex = 77
        Me.lbl4PM.Text = "AVAILABLE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(20, 149)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 17)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "04:00 PM -"
        '
        'lbl2PM
        '
        Me.lbl2PM.AutoSize = True
        Me.lbl2PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2PM.ForeColor = System.Drawing.Color.Black
        Me.lbl2PM.Location = New System.Drawing.Point(126, 111)
        Me.lbl2PM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2PM.Name = "lbl2PM"
        Me.lbl2PM.Size = New System.Drawing.Size(90, 17)
        Me.lbl2PM.TabIndex = 75
        Me.lbl2PM.Text = "AVAILABLE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(21, 111)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 17)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "02:00 PM -"
        '
        'lbl10AM
        '
        Me.lbl10AM.AutoSize = True
        Me.lbl10AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10AM.ForeColor = System.Drawing.Color.Black
        Me.lbl10AM.Location = New System.Drawing.Point(126, 46)
        Me.lbl10AM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl10AM.Name = "lbl10AM"
        Me.lbl10AM.Size = New System.Drawing.Size(90, 17)
        Me.lbl10AM.TabIndex = 73
        Me.lbl10AM.Text = "AVAILABLE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(19, 46)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 17)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "10:00 AM -"
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSchedule.Location = New System.Drawing.Point(615, 241)
        Me.btnSchedule.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(147, 34)
        Me.btnSchedule.TabIndex = 79
        Me.btnSchedule.Text = "Schedule"
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(533, 241)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 34)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Time:"
        '
        'cmbTime
        '
        Me.cmbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Items.AddRange(New Object() {"09:00 AM", "10:00 AM", "11:00 AM", "02:00 PM", "03:00 PM", "04:00 PM"})
        Me.cmbTime.Location = New System.Drawing.Point(90, 100)
        Me.cmbTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(212, 24)
        Me.cmbTime.TabIndex = 84
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Schedule)
        Me.Panel1.ForeColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 39)
        Me.Panel1.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpSchedule)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTime)
        Me.GroupBox1.Controls.Add(Me.lblLMP)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbPurpose)
        Me.GroupBox1.Controls.Add(Me.txtDoctor)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 188)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl10AM)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl9AM)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbl11AM)
        Me.GroupBox2.Controls.Add(Me.lbl4PM)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lbl3PM)
        Me.GroupBox2.Controls.Add(Me.lbl2PM)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(398, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 188)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Schedule"
        '
        'ScheduleAppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 285)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.txtSched)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ScheduleAppointmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl9AM As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDoctor As TextBox
    Friend WithEvents txtSched As TextBox
    Friend WithEvents cmbPurpose As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpSchedule As DateTimePicker
    Friend WithEvents lblLMP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Schedule As Label
    Friend WithEvents lbl11AM As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl3PM As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl4PM As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl2PM As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl10AM As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
