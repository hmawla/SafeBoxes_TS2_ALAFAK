<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RenewContract
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV_Clients = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_EmpId = New MaterialSkin.Controls.MaterialLabel()
        Me.Lbl_ContId = New MaterialSkin.Controls.MaterialLabel()
        Me.DTPick_Expire = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientId = New System.Windows.Forms.TextBox()
        Me.ClientMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientName = New System.Windows.Forms.TextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.EmployeeMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectDifferentEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGVMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientMenuStrip.SuspendLayout()
        Me.EmployeeMenuStrip.SuspendLayout()
        Me.DGVMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Clients
        '
        Me.DGV_Clients.AllowUserToAddRows = False
        Me.DGV_Clients.AllowUserToDeleteRows = False
        Me.DGV_Clients.AllowUserToResizeRows = False
        Me.DGV_Clients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Clients.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGV_Clients.ContextMenuStrip = Me.DGVMenuStrip
        Me.DGV_Clients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Clients.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Clients.Location = New System.Drawing.Point(13, 101)
        Me.DGV_Clients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_Clients.MultiSelect = False
        Me.DGV_Clients.Name = "DGV_Clients"
        Me.DGV_Clients.ReadOnly = True
        Me.DGV_Clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Clients.RowHeadersVisible = False
        Me.DGV_Clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clients.Size = New System.Drawing.Size(653, 387)
        Me.DGV_Clients.TabIndex = 13
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
        'Lbl_EmpId
        '
        Me.Lbl_EmpId.AutoSize = True
        Me.Lbl_EmpId.ContextMenuStrip = Me.EmployeeMenuStrip
        Me.Lbl_EmpId.Depth = 0
        Me.Lbl_EmpId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_EmpId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_EmpId.Location = New System.Drawing.Point(186, 9)
        Me.Lbl_EmpId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_EmpId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_EmpId.Name = "Lbl_EmpId"
        Me.Lbl_EmpId.Size = New System.Drawing.Size(158, 18)
        Me.Lbl_EmpId.TabIndex = 49
        Me.Lbl_EmpId.Text = "Employee ID: <EmpId>"
        '
        'Lbl_ContId
        '
        Me.Lbl_ContId.AutoSize = True
        Me.Lbl_ContId.Depth = 0
        Me.Lbl_ContId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_ContId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_ContId.Location = New System.Drawing.Point(10, 9)
        Me.Lbl_ContId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_ContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_ContId.Name = "Lbl_ContId"
        Me.Lbl_ContId.Size = New System.Drawing.Size(152, 18)
        Me.Lbl_ContId.TabIndex = 50
        Me.Lbl_ContId.Text = "Contract ID: <ContId>"
        '
        'DTPick_Expire
        '
        Me.DTPick_Expire.CustomFormat = "dd/mm/yyyy"
        Me.DTPick_Expire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DTPick_Expire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPick_Expire.Location = New System.Drawing.Point(13, 65)
        Me.DTPick_Expire.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DTPick_Expire.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.DTPick_Expire.Name = "DTPick_Expire"
        Me.DTPick_Expire.Size = New System.Drawing.Size(137, 26)
        Me.DTPick_Expire.TabIndex = 52
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(10, 41)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(87, 18)
        Me.MaterialLabel2.TabIndex = 53
        Me.MaterialLabel2.Text = "Expiry Date:"
        '
        'Txt_ClientId
        '
        Me.Txt_ClientId.ContextMenuStrip = Me.ClientMenuStrip
        Me.Txt_ClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_ClientId.Location = New System.Drawing.Point(158, 65)
        Me.Txt_ClientId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientId.Name = "Txt_ClientId"
        Me.Txt_ClientId.Size = New System.Drawing.Size(148, 26)
        Me.Txt_ClientId.TabIndex = 54
        '
        'ClientMenuStrip
        '
        Me.ClientMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem})
        Me.ClientMenuStrip.Name = "ClientMenuStrip"
        Me.ClientMenuStrip.Size = New System.Drawing.Size(140, 26)
        '
        'SelectClientToolStripMenuItem
        '
        Me.SelectClientToolStripMenuItem.Name = "SelectClientToolStripMenuItem"
        Me.SelectClientToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SelectClientToolStripMenuItem.Text = "Select Client"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(155, 41)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(69, 18)
        Me.MaterialLabel7.TabIndex = 55
        Me.MaterialLabel7.Text = "Client ID:"
        '
        'Txt_ClientName
        '
        Me.Txt_ClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_ClientName.Location = New System.Drawing.Point(314, 65)
        Me.Txt_ClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientName.Name = "Txt_ClientName"
        Me.Txt_ClientName.ReadOnly = True
        Me.Txt_ClientName.Size = New System.Drawing.Size(270, 26)
        Me.Txt_ClientName.TabIndex = 56
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(311, 41)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(95, 18)
        Me.MaterialLabel3.TabIndex = 57
        Me.MaterialLabel3.Text = "Client Name:"
        '
        'Btn_Add
        '
        Me.Btn_Add.Enabled = False
        Me.Btn_Add.Location = New System.Drawing.Point(591, 65)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Add.TabIndex = 58
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.Enabled = False
        Me.Btn_Submit.Location = New System.Drawing.Point(591, 496)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Submit.TabIndex = 59
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'EmployeeMenuStrip
        '
        Me.EmployeeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDifferentEmployeeToolStripMenuItem})
        Me.EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        Me.EmployeeMenuStrip.Size = New System.Drawing.Size(210, 48)
        '
        'SelectDifferentEmployeeToolStripMenuItem
        '
        Me.SelectDifferentEmployeeToolStripMenuItem.Name = "SelectDifferentEmployeeToolStripMenuItem"
        Me.SelectDifferentEmployeeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SelectDifferentEmployeeToolStripMenuItem.Text = "Select Different Employee"
        '
        'DGVMenuStrip
        '
        Me.DGVMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem})
        Me.DGVMenuStrip.Name = "DGVMenuStrip"
        Me.DGVMenuStrip.Size = New System.Drawing.Size(165, 26)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'Frm_RenewContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 530)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.Txt_ClientName)
        Me.Controls.Add(Me.Txt_ClientId)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.DTPick_Expire)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.Lbl_ContId)
        Me.Controls.Add(Me.Lbl_EmpId)
        Me.Controls.Add(Me.DGV_Clients)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_RenewContract"
        Me.Text = "Renew Contract"
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientMenuStrip.ResumeLayout(False)
        Me.EmployeeMenuStrip.ResumeLayout(False)
        Me.DGVMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Clients As DataGridView
    Friend WithEvents Lbl_EmpId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_ContId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DTPick_Expire As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientId As TextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientName As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Submit As Button
    Friend WithEvents ClientMenuStrip As ContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeMenuStrip As ContextMenuStrip
    Friend WithEvents SelectDifferentEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGVMenuStrip As ContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
End Class
