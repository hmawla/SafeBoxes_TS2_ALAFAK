﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RenewContract
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.DGVMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_EmpId = New MaterialSkin.Controls.MaterialLabel()
        Me.EmployeeMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectDifferentEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_ContId = New MaterialSkin.Controls.MaterialLabel()
        Me.DTPick_Expire = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ClientMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVMenuStrip.SuspendLayout()
        Me.EmployeeMenuStrip.SuspendLayout()
        Me.ClientMenuStrip.SuspendLayout()
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
        Me.DGV_Clients.Location = New System.Drawing.Point(13, 190)
        Me.DGV_Clients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_Clients.MultiSelect = False
        Me.DGV_Clients.Name = "DGV_Clients"
        Me.DGV_Clients.ReadOnly = True
        Me.DGV_Clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Clients.RowHeadersVisible = False
        Me.DGV_Clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clients.Size = New System.Drawing.Size(653, 232)
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
        'Lbl_EmpId
        '
        Me.Lbl_EmpId.AutoSize = True
        Me.Lbl_EmpId.ContextMenuStrip = Me.EmployeeMenuStrip
        Me.Lbl_EmpId.Depth = 0
        Me.Lbl_EmpId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_EmpId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_EmpId.Location = New System.Drawing.Point(194, 81)
        Me.Lbl_EmpId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_EmpId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_EmpId.Name = "Lbl_EmpId"
        Me.Lbl_EmpId.Size = New System.Drawing.Size(159, 19)
        Me.Lbl_EmpId.TabIndex = 49
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
        'Lbl_ContId
        '
        Me.Lbl_ContId.AutoSize = True
        Me.Lbl_ContId.Depth = 0
        Me.Lbl_ContId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_ContId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_ContId.Location = New System.Drawing.Point(18, 81)
        Me.Lbl_ContId.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Lbl_ContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_ContId.Name = "Lbl_ContId"
        Me.Lbl_ContId.Size = New System.Drawing.Size(153, 19)
        Me.Lbl_ContId.TabIndex = 50
        Me.Lbl_ContId.Text = "Contract ID: <ContId>"
        '
        'DTPick_Expire
        '
        Me.DTPick_Expire.CustomFormat = "dd/mm/yyyy"
        Me.DTPick_Expire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DTPick_Expire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPick_Expire.Location = New System.Drawing.Point(21, 137)
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
        Me.MaterialLabel2.Location = New System.Drawing.Point(18, 113)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel2.TabIndex = 53
        Me.MaterialLabel2.Text = "Expiry Date:"
        '
        'Txt_ClientId
        '
        Me.Txt_ClientId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_ClientId.ContextMenuStrip = Me.ClientMenuStrip
        Me.Txt_ClientId.Depth = 0
        Me.Txt_ClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_ClientId.Hint = ""
        Me.Txt_ClientId.Location = New System.Drawing.Point(166, 137)
        Me.Txt_ClientId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientId.MaxLength = 32767
        Me.Txt_ClientId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ClientId.Name = "Txt_ClientId"
        Me.Txt_ClientId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ClientId.SelectedText = ""
        Me.Txt_ClientId.SelectionLength = 0
        Me.Txt_ClientId.SelectionStart = 0
        Me.Txt_ClientId.Size = New System.Drawing.Size(148, 23)
        Me.Txt_ClientId.TabIndex = 54
        Me.Txt_ClientId.TabStop = False
        Me.Txt_ClientId.UseSystemPasswordChar = False
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
        Me.MaterialLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(163, 113)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel7.TabIndex = 55
        Me.MaterialLabel7.Text = "Client ID:"
        '
        'Txt_ClientName
        '
        Me.Txt_ClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_ClientName.Depth = 0
        Me.Txt_ClientName.Enabled = False
        Me.Txt_ClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_ClientName.Hint = ""
        Me.Txt_ClientName.Location = New System.Drawing.Point(322, 137)
        Me.Txt_ClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ClientName.MaxLength = 32767
        Me.Txt_ClientName.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ClientName.Name = "Txt_ClientName"
        Me.Txt_ClientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ClientName.SelectedText = ""
        Me.Txt_ClientName.SelectionLength = 0
        Me.Txt_ClientName.SelectionStart = 0
        Me.Txt_ClientName.Size = New System.Drawing.Size(270, 23)
        Me.Txt_ClientName.TabIndex = 56
        Me.Txt_ClientName.TabStop = False
        Me.Txt_ClientName.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(319, 113)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel3.TabIndex = 57
        Me.MaterialLabel3.Text = "Client Name:"
        '
        'Btn_Add
        '
        Me.Btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Add.AutoSize = True
        Me.Btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Add.Depth = 0
        Me.Btn_Add.Enabled = False
        Me.Btn_Add.Icon = Nothing
        Me.Btn_Add.Location = New System.Drawing.Point(599, 137)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Primary = False
        Me.Btn_Add.Size = New System.Drawing.Size(48, 36)
        Me.Btn_Add.TabIndex = 58
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Enabled = False
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(591, 430)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = False
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 59
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Frm_RenewContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 464)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_RenewContract"
        Me.Text = "Renew Contract"
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVMenuStrip.ResumeLayout(False)
        Me.EmployeeMenuStrip.ResumeLayout(False)
        Me.ClientMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Clients As DataGridView
    Friend WithEvents Lbl_EmpId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_ContId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DTPick_Expire As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ClientMenuStrip As ContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeMenuStrip As ContextMenuStrip
    Friend WithEvents SelectDifferentEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGVMenuStrip As ContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Add As MaterialSkin.Controls.MaterialFlatButton
End Class
