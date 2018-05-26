<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewAccountCompany
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
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.DGV_Clients = New System.Windows.Forms.DataGridView()
        Me.ClientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Txt_CName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_Cid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(363, 542)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 76
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(-3, 530)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(452, 1)
        Me.MaterialDivider2.TabIndex = 75
        Me.MaterialDivider2.Text = "MaterialDivider2"
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
        Me.DGV_Clients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientId, Me.ClientName})
        Me.DGV_Clients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Clients.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Clients.Location = New System.Drawing.Point(12, 201)
        Me.DGV_Clients.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.DGV_Clients.MultiSelect = False
        Me.DGV_Clients.Name = "DGV_Clients"
        Me.DGV_Clients.ReadOnly = True
        Me.DGV_Clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Clients.RowHeadersVisible = False
        Me.DGV_Clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clients.Size = New System.Drawing.Size(419, 330)
        Me.DGV_Clients.TabIndex = 74
        '
        'ClientId
        '
        Me.ClientId.FillWeight = 40.60914!
        Me.ClientId.HeaderText = "ID"
        Me.ClientId.Name = "ClientId"
        Me.ClientId.ReadOnly = True
        '
        'ClientName
        '
        Me.ClientName.FillWeight = 159.3909!
        Me.ClientName.HeaderText = "Client's Name"
        Me.ClientName.Name = "ClientName"
        Me.ClientName.ReadOnly = True
        '
        'Btn_Add
        '
        Me.Btn_Add.AutoSize = True
        Me.Btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Add.Depth = 0
        Me.Btn_Add.Icon = Nothing
        Me.Btn_Add.Location = New System.Drawing.Point(385, 154)
        Me.Btn_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Primary = True
        Me.Btn_Add.Size = New System.Drawing.Size(48, 36)
        Me.Btn_Add.TabIndex = 73
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Txt_CName
        '
        Me.Txt_CName.Depth = 0
        Me.Txt_CName.Enabled = False
        Me.Txt_CName.Hint = ""
        Me.Txt_CName.Location = New System.Drawing.Point(135, 167)
        Me.Txt_CName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_CName.MaxLength = 32767
        Me.Txt_CName.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_CName.Name = "Txt_CName"
        Me.Txt_CName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_CName.SelectedText = ""
        Me.Txt_CName.SelectionLength = 0
        Me.Txt_CName.SelectionStart = 0
        Me.Txt_CName.Size = New System.Drawing.Size(243, 23)
        Me.Txt_CName.TabIndex = 72
        Me.Txt_CName.TabStop = False
        Me.Txt_CName.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(15, 143)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel5.TabIndex = 70
        Me.MaterialLabel5.Text = "Client ID:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(131, 143)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel1.TabIndex = 71
        Me.MaterialLabel1.Text = "Client Name:"
        '
        'Txt_Cid
        '
        Me.Txt_Cid.Depth = 0
        Me.Txt_Cid.Hint = ""
        Me.Txt_Cid.Location = New System.Drawing.Point(19, 167)
        Me.Txt_Cid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_Cid.MaxLength = 32767
        Me.Txt_Cid.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_Cid.Name = "Txt_Cid"
        Me.Txt_Cid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Cid.SelectedText = ""
        Me.Txt_Cid.SelectionLength = 0
        Me.Txt_Cid.SelectionStart = 0
        Me.Txt_Cid.Size = New System.Drawing.Size(108, 23)
        Me.Txt_Cid.TabIndex = 69
        Me.Txt_Cid.TabStop = False
        Me.Txt_Cid.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Enabled = False
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(135, 98)
        Me.MaterialSingleLineTextField1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialSingleLineTextField1.MaxLength = 32767
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(298, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 80
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(15, 74)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel2.TabIndex = 78
        Me.MaterialLabel2.Text = "Company ID:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(131, 74)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(120, 19)
        Me.MaterialLabel3.TabIndex = 79
        Me.MaterialLabel3.Text = "Company Name:"
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = ""
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(19, 98)
        Me.MaterialSingleLineTextField2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialSingleLineTextField2.MaxLength = 32767
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(108, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 77
        Me.MaterialSingleLineTextField2.TabStop = False
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'Frm_NewAccountCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 590)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.DGV_Clients)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Txt_CName)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Txt_Cid)
        Me.Name = "Frm_NewAccountCompany"
        Me.Text = "New Company's Account"
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents DGV_Clients As DataGridView
    Friend WithEvents ClientId As DataGridViewTextBoxColumn
    Friend WithEvents ClientName As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Add As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Txt_CName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_Cid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
