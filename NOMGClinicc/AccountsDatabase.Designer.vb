<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountsDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountsDatabase))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvAccountRecords = New System.Windows.Forms.DataGridView()
        Me.lblAccountRecords = New System.Windows.Forms.Label()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMobileNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnBirthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvAccountRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(650, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(316, 29)
        Me.txtSearch.TabIndex = 18
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(840, 456)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(123, 38)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(711, 456)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 38)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvAccountRecords
        '
        Me.dgvAccountRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccountRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.columnFirstName, Me.columnMiddleName, Me.columnLastName, Me.columnMobileNumber, Me.ColumnBirthday, Me.columnDateAndTime})
        Me.dgvAccountRecords.Location = New System.Drawing.Point(9, 72)
        Me.dgvAccountRecords.Name = "dgvAccountRecords"
        Me.dgvAccountRecords.RowHeadersWidth = 51
        Me.dgvAccountRecords.Size = New System.Drawing.Size(954, 378)
        Me.dgvAccountRecords.TabIndex = 15
        '
        'lblAccountRecords
        '
        Me.lblAccountRecords.AutoSize = True
        Me.lblAccountRecords.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountRecords.ForeColor = System.Drawing.Color.White
        Me.lblAccountRecords.Location = New System.Drawing.Point(15, 9)
        Me.lblAccountRecords.Name = "lblAccountRecords"
        Me.lblAccountRecords.Size = New System.Drawing.Size(201, 50)
        Me.lblAccountRecords.TabIndex = 14
        Me.lblAccountRecords.Text = "Accounts"
        '
        'ColumnId
        '
        Me.ColumnId.HeaderText = "ID"
        Me.ColumnId.Name = "ColumnId"
        '
        'columnFirstName
        '
        Me.columnFirstName.HeaderText = "First Name"
        Me.columnFirstName.MinimumWidth = 6
        Me.columnFirstName.Name = "columnFirstName"
        Me.columnFirstName.Width = 150
        '
        'columnMiddleName
        '
        Me.columnMiddleName.HeaderText = "Middle Name"
        Me.columnMiddleName.MinimumWidth = 6
        Me.columnMiddleName.Name = "columnMiddleName"
        Me.columnMiddleName.Width = 125
        '
        'columnLastName
        '
        Me.columnLastName.HeaderText = "Last Name"
        Me.columnLastName.MinimumWidth = 6
        Me.columnLastName.Name = "columnLastName"
        Me.columnLastName.Width = 125
        '
        'columnMobileNumber
        '
        Me.columnMobileNumber.HeaderText = "Mobile Number"
        Me.columnMobileNumber.MinimumWidth = 6
        Me.columnMobileNumber.Name = "columnMobileNumber"
        Me.columnMobileNumber.Width = 150
        '
        'ColumnBirthday
        '
        Me.ColumnBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnBirthday.HeaderText = "Birthday"
        Me.ColumnBirthday.MinimumWidth = 6
        Me.ColumnBirthday.Name = "ColumnBirthday"
        Me.ColumnBirthday.Width = 125
        '
        'columnDateAndTime
        '
        Me.columnDateAndTime.HeaderText = "Date and Time"
        Me.columnDateAndTime.MinimumWidth = 6
        Me.columnDateAndTime.Name = "columnDateAndTime"
        Me.columnDateAndTime.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.lblAccountRecords)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(-3, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 63)
        Me.Panel1.TabIndex = 19
        '
        'AccountsDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvAccountRecords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AccountsDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Database"
        CType(Me.dgvAccountRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvAccountRecords As DataGridView
    Friend WithEvents lblAccountRecords As Label
    Friend WithEvents ColumnId As DataGridViewTextBoxColumn
    Friend WithEvents columnFirstName As DataGridViewTextBoxColumn
    Friend WithEvents columnMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents columnLastName As DataGridViewTextBoxColumn
    Friend WithEvents columnMobileNumber As DataGridViewTextBoxColumn
    Friend WithEvents ColumnBirthday As DataGridViewTextBoxColumn
    Friend WithEvents columnDateAndTime As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
