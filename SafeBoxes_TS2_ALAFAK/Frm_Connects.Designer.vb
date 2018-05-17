<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Connects
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
        Me.DGV_Connects = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.Btn_Connects = New System.Windows.Forms.Button()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientName = New System.Windows.Forms.TextBox()
        Me.Txt_ClientId = New System.Windows.Forms.TextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.DTPick_Expire = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Lbl_infovId = New MaterialSkin.Controls.MaterialLabel()
        Me.Lbl_EmpId = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_note = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Connects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Connects
        '
        Me.DGV_Connects.AllowUserToAddRows = False
        Me.DGV_Connects.AllowUserToDeleteRows = False
        Me.DGV_Connects.AllowUserToResizeRows = False
        Me.DGV_Connects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Connects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Connects.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Connects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Connects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Connects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGV_Connects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Connects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Connects.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Connects.Location = New System.Drawing.Point(15, 135)
        Me.DGV_Connects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_Connects.MultiSelect = False
        Me.DGV_Connects.Name = "DGV_Connects"
        Me.DGV_Connects.ReadOnly = True
        Me.DGV_Connects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Connects.RowHeadersVisible = False
        Me.DGV_Connects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Connects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Connects.Size = New System.Drawing.Size(653, 351)
        Me.DGV_Connects.TabIndex = 86
        '
        'Column1
        '
        Me.Column1.FillWeight = 40.0!
        Me.Column1.HeaderText = "Client ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 90.0!
        Me.Column2.HeaderText = "Client Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 73.85786!
        Me.Column3.HeaderText = "Date of Birth"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.Enabled = False
        Me.Btn_Submit.Location = New System.Drawing.Point(592, 496)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Submit.TabIndex = 85
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Btn_Connects
        '
        Me.Btn_Connects.Enabled = False
        Me.Btn_Connects.Location = New System.Drawing.Point(592, 65)
        Me.Btn_Connects.Name = "Btn_Connects"
        Me.Btn_Connects.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Connects.TabIndex = 84
        Me.Btn_Connects.Text = "Connect"
        Me.Btn_Connects.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(312, 41)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel3.TabIndex = 83
        Me.MaterialLabel3.Text = "Client Name:"
        '
        'Txt_ClientName
        '
        Me.Txt_ClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_ClientName.Location = New System.Drawing.Point(315, 65)
        Me.Txt_ClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientName.Name = "Txt_ClientName"
        Me.Txt_ClientName.ReadOnly = True
        Me.Txt_ClientName.Size = New System.Drawing.Size(270, 26)
        Me.Txt_ClientName.TabIndex = 82
        '
        'Txt_ClientId
        '
        Me.Txt_ClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_ClientId.Location = New System.Drawing.Point(159, 65)
        Me.Txt_ClientId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientId.Name = "Txt_ClientId"
        Me.Txt_ClientId.Size = New System.Drawing.Size(148, 26)
        Me.Txt_ClientId.TabIndex = 80
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(156, 41)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel7.TabIndex = 81
        Me.MaterialLabel7.Text = "Client ID:"
        '
        'DTPick_Expire
        '
        Me.DTPick_Expire.CustomFormat = "dd/mm/yyyy"
        Me.DTPick_Expire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DTPick_Expire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPick_Expire.Location = New System.Drawing.Point(14, 65)
        Me.DTPick_Expire.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DTPick_Expire.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.DTPick_Expire.Name = "DTPick_Expire"
        Me.DTPick_Expire.Size = New System.Drawing.Size(137, 26)
        Me.DTPick_Expire.TabIndex = 78
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(11, 41)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(104, 19)
        Me.MaterialLabel2.TabIndex = 79
        Me.MaterialLabel2.Text = "Connect Date:"
        '
        'Lbl_infovId
        '
        Me.Lbl_infovId.AutoSize = True
        Me.Lbl_infovId.Depth = 0
        Me.Lbl_infovId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_infovId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_infovId.Location = New System.Drawing.Point(11, 9)
        Me.Lbl_infovId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_infovId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_infovId.Name = "Lbl_infovId"
        Me.Lbl_infovId.Size = New System.Drawing.Size(171, 19)
        Me.Lbl_infovId.TabIndex = 77
        Me.Lbl_infovId.Text = "InfoVoucher ID: <InfoId>"
        '
        'Lbl_EmpId
        '
        Me.Lbl_EmpId.AutoSize = True
        Me.Lbl_EmpId.Depth = 0
        Me.Lbl_EmpId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_EmpId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_EmpId.Location = New System.Drawing.Point(187, 9)
        Me.Lbl_EmpId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_EmpId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_EmpId.Name = "Lbl_EmpId"
        Me.Lbl_EmpId.Size = New System.Drawing.Size(159, 19)
        Me.Lbl_EmpId.TabIndex = 76
        Me.Lbl_EmpId.Text = "Employee ID: <EmpId>"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(16, 103)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel1.TabIndex = 88
        Me.MaterialLabel1.Text = "Connect Notes:"
        '
        'txt_note
        '
        Me.txt_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_note.Location = New System.Drawing.Point(138, 99)
        Me.txt_note.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(530, 26)
        Me.txt_note.TabIndex = 87
        '
        'Frm_Connects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 530)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.DGV_Connects)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Btn_Connects)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.Txt_ClientName)
        Me.Controls.Add(Me.Txt_ClientId)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.DTPick_Expire)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.Lbl_infovId)
        Me.Controls.Add(Me.Lbl_EmpId)
        Me.Name = "Frm_Connects"
        Me.Text = "Frm_Connects"
        CType(Me.DGV_Connects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Connects As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Submit As Button
    Friend WithEvents Btn_Connects As Button
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientName As TextBox
    Friend WithEvents Txt_ClientId As TextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DTPick_Expire As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_infovId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_EmpId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_note As TextBox
End Class
