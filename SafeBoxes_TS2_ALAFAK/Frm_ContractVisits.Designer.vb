<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ContractVisits
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
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientName = New System.Windows.Forms.TextBox()
        Me.Txt_ClientId = New System.Windows.Forms.TextBox()
        Me.ClientMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.DTPick_Expire = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Lbl_ContId = New MaterialSkin.Controls.MaterialLabel()
        Me.Lbl_EmpId = New MaterialSkin.Controls.MaterialLabel()
        Me.EmployeeMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectDifferentEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGVMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.DGV_Visits = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.ClientMenuStrip.SuspendLayout()
        Me.EmployeeMenuStrip.SuspendLayout()
        Me.DGVMenuStrip.SuspendLayout()
        CType(Me.DGV_Visits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Add
        '
        Me.Btn_Add.Enabled = False
        Me.Btn_Add.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Location = New System.Drawing.Point(590, 65)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Add.TabIndex = 68
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(310, 41)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(99, 20)
        Me.MaterialLabel3.TabIndex = 67
        Me.MaterialLabel3.Text = "Client Name:"
        '
        'Txt_ClientName
        '
        Me.Txt_ClientName.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ClientName.Location = New System.Drawing.Point(313, 65)
        Me.Txt_ClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientName.Name = "Txt_ClientName"
        Me.Txt_ClientName.ReadOnly = True
        Me.Txt_ClientName.Size = New System.Drawing.Size(270, 27)
        Me.Txt_ClientName.TabIndex = 66
        '
        'Txt_ClientId
        '
        Me.Txt_ClientId.ContextMenuStrip = Me.ClientMenuStrip
        Me.Txt_ClientId.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ClientId.Location = New System.Drawing.Point(157, 65)
        Me.Txt_ClientId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientId.Name = "Txt_ClientId"
        Me.Txt_ClientId.Size = New System.Drawing.Size(148, 27)
        Me.Txt_ClientId.TabIndex = 64
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
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(154, 41)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(71, 20)
        Me.MaterialLabel7.TabIndex = 65
        Me.MaterialLabel7.Text = "Client ID:"
        '
        'DTPick_Expire
        '
        Me.DTPick_Expire.CustomFormat = "dd/mm/yyyy"
        Me.DTPick_Expire.Enabled = False
        Me.DTPick_Expire.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPick_Expire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPick_Expire.Location = New System.Drawing.Point(12, 65)
        Me.DTPick_Expire.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DTPick_Expire.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.DTPick_Expire.Name = "DTPick_Expire"
        Me.DTPick_Expire.Size = New System.Drawing.Size(137, 27)
        Me.DTPick_Expire.TabIndex = 62
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(9, 41)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(80, 20)
        Me.MaterialLabel2.TabIndex = 63
        Me.MaterialLabel2.Text = "Visit Date:"
        '
        'Lbl_ContId
        '
        Me.Lbl_ContId.AutoSize = True
        Me.Lbl_ContId.Depth = 0
        Me.Lbl_ContId.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ContId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_ContId.Location = New System.Drawing.Point(9, 9)
        Me.Lbl_ContId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_ContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_ContId.Name = "Lbl_ContId"
        Me.Lbl_ContId.Size = New System.Drawing.Size(157, 20)
        Me.Lbl_ContId.TabIndex = 61
        Me.Lbl_ContId.Text = "Contract ID: <ContId>"
        '
        'Lbl_EmpId
        '
        Me.Lbl_EmpId.AutoSize = True
        Me.Lbl_EmpId.ContextMenuStrip = Me.EmployeeMenuStrip
        Me.Lbl_EmpId.Depth = 0
        Me.Lbl_EmpId.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EmpId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_EmpId.Location = New System.Drawing.Point(185, 9)
        Me.Lbl_EmpId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_EmpId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_EmpId.Name = "Lbl_EmpId"
        Me.Lbl_EmpId.Size = New System.Drawing.Size(165, 20)
        Me.Lbl_EmpId.TabIndex = 60
        Me.Lbl_EmpId.Text = "Employee ID: <EmpId>"
        '
        'EmployeeMenuStrip
        '
        Me.EmployeeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDifferentEmployeeToolStripMenuItem})
        Me.EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        Me.EmployeeMenuStrip.Size = New System.Drawing.Size(210, 26)
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
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.Enabled = False
        Me.Btn_Submit.Location = New System.Drawing.Point(590, 496)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Submit.TabIndex = 72
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'DGV_Visits
        '
        Me.DGV_Visits.AllowUserToAddRows = False
        Me.DGV_Visits.AllowUserToDeleteRows = False
        Me.DGV_Visits.AllowUserToResizeRows = False
        Me.DGV_Visits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Visits.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Visits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Visits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGV_Visits.ContextMenuStrip = Me.DGVMenuStrip
        Me.DGV_Visits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Visits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Visits.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Visits.Location = New System.Drawing.Point(13, 130)
        Me.DGV_Visits.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_Visits.MultiSelect = False
        Me.DGV_Visits.Name = "DGV_Visits"
        Me.DGV_Visits.ReadOnly = True
        Me.DGV_Visits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Visits.RowHeadersVisible = False
        Me.DGV_Visits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Visits.Size = New System.Drawing.Size(653, 356)
        Me.DGV_Visits.TabIndex = 73
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
        'txt_note
        '
        Me.txt_note.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(110, 99)
        Me.txt_note.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(555, 27)
        Me.txt_note.TabIndex = 74
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(13, 103)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(89, 20)
        Me.MaterialLabel1.TabIndex = 75
        Me.MaterialLabel1.Text = "Visit Notes:"
        '
        'Frm_ContractVisits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 530)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.DGV_Visits)
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
        Me.Name = "Frm_ContractVisits"
        Me.Text = "Frm_ContractVisits"
        Me.ClientMenuStrip.ResumeLayout(False)
        Me.EmployeeMenuStrip.ResumeLayout(False)
        Me.DGVMenuStrip.ResumeLayout(False)
        CType(Me.DGV_Visits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Add As Button
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientName As TextBox
    Friend WithEvents Txt_ClientId As TextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DTPick_Expire As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_ContId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_EmpId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents EmployeeMenuStrip As ContextMenuStrip
    Friend WithEvents SelectDifferentEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGVMenuStrip As ContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientMenuStrip As ContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Submit As Button
    Friend WithEvents DGV_Visits As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txt_note As TextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
