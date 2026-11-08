<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientDetailsDatabase
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientDetailsDatabase))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstBaby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextVisit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMGClinic = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(795, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(401, 29)
        Me.txtSearch.TabIndex = 26
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1068, 499)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 40)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.PhoneNumber, Me.Column1, Me.Address, Me.CivilStatus, Me.Column2, Me.Column3, Me.Gender, Me.FirstBaby, Me.LMP, Me.Column4, Me.NextVisit})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(8, 54)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1190, 439)
        Me.DataGridView1.TabIndex = 117
        '
        'Column5
        '
        Me.Column5.HeaderText = "ID"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 30
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.MinimumWidth = 6
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.MinimumWidth = 6
        Me.Address.Name = "Address"
        Me.Address.Width = 150
        '
        'CivilStatus
        '
        Me.CivilStatus.HeaderText = "Civil Status"
        Me.CivilStatus.MinimumWidth = 6
        Me.CivilStatus.Name = "CivilStatus"
        Me.CivilStatus.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Age"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 30
        '
        'Column3
        '
        Me.Column3.HeaderText = "GA"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.MinimumWidth = 6
        Me.Gender.Name = "Gender"
        Me.Gender.Width = 75
        '
        'FirstBaby
        '
        Me.FirstBaby.HeaderText = "First Baby"
        Me.FirstBaby.MinimumWidth = 6
        Me.FirstBaby.Name = "FirstBaby"
        Me.FirstBaby.Width = 50
        '
        'LMP
        '
        Me.LMP.HeaderText = "LMP"
        Me.LMP.MinimumWidth = 6
        Me.LMP.Name = "LMP"
        Me.LMP.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "OB Doctor"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'NextVisit
        '
        Me.NextVisit.HeaderText = "Next Visit"
        Me.NextVisit.MinimumWidth = 6
        Me.NextVisit.Name = "NextVisit"
        Me.NextVisit.Width = 150
        '
        'NOMGClinic
        '
        Me.NOMGClinic.AutoSize = True
        Me.NOMGClinic.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMGClinic.ForeColor = System.Drawing.Color.White
        Me.NOMGClinic.Location = New System.Drawing.Point(10, 10)
        Me.NOMGClinic.Name = "NOMGClinic"
        Me.NOMGClinic.Size = New System.Drawing.Size(254, 41)
        Me.NOMGClinic.TabIndex = 118
        Me.NOMGClinic.Text = "Patient Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.NOMGClinic)
        Me.Panel1.Location = New System.Drawing.Point(-5, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1215, 52)
        Me.Panel1.TabIndex = 119
        '
        'PatientDetailsDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 549)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientDetailsDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Details Database"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents CivilStatus As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents FirstBaby As DataGridViewTextBoxColumn
    Friend WithEvents LMP As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents NextVisit As DataGridViewTextBoxColumn
    Friend WithEvents NOMGClinic As Label
    Friend WithEvents Panel1 As Panel
End Class
