<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NewAccountClient
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.Txt_CName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.ClientSelector = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_Cid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Btn_Add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DGV_Clients = New System.Windows.Forms.DataGridView()
        Me.ClientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientRemover = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.ClientSelector.SuspendLayout()
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientRemover.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_CName
        '
        Me.Txt_CName.Depth = 0
        Me.Txt_CName.Enabled = False
        Me.Txt_CName.Hint = ""
        Me.Txt_CName.Location = New System.Drawing.Point(129, 100)
        Me.Txt_CName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_CName.MaxLength = 32767
        Me.Txt_CName.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_CName.Name = "Txt_CName"
        Me.Txt_CName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_CName.SelectedText = ""
        Me.Txt_CName.SelectionLength = 0
        Me.Txt_CName.SelectionStart = 0
        Me.Txt_CName.Size = New System.Drawing.Size(243, 23)
        Me.Txt_CName.TabIndex = 64
        Me.Txt_CName.TabStop = False
        Me.Txt_CName.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.ContextMenuStrip = Me.ClientSelector
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(9, 76)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel5.TabIndex = 62
        Me.MaterialLabel5.Text = "Client ID:"
        '
        'ClientSelector
        '
        Me.ClientSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSelector.Depth = 0
        Me.ClientSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem})
        Me.ClientSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClientSelector.Name = "ClientSelector"
        Me.ClientSelector.Size = New System.Drawing.Size(140, 26)
        '
        'SelectClientToolStripMenuItem
        '
        Me.SelectClientToolStripMenuItem.Name = "SelectClientToolStripMenuItem"
        Me.SelectClientToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SelectClientToolStripMenuItem.Text = "Select Client"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(125, 76)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel1.TabIndex = 63
        Me.MaterialLabel1.Text = "Client Name:"
        '
        'Txt_Cid
        '
        Me.Txt_Cid.ContextMenuStrip = Me.ClientSelector
        Me.Txt_Cid.Depth = 0
        Me.Txt_Cid.Hint = ""
        Me.Txt_Cid.Location = New System.Drawing.Point(13, 100)
        Me.Txt_Cid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_Cid.MaxLength = 32767
        Me.Txt_Cid.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_Cid.Name = "Txt_Cid"
        Me.Txt_Cid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Cid.SelectedText = ""
        Me.Txt_Cid.SelectionLength = 0
        Me.Txt_Cid.SelectionStart = 0
        Me.Txt_Cid.Size = New System.Drawing.Size(108, 23)
        Me.Txt_Cid.TabIndex = 61
        Me.Txt_Cid.TabStop = False
        Me.Txt_Cid.UseSystemPasswordChar = False
        '
        'Btn_Add
        '
        Me.Btn_Add.AutoSize = True
        Me.Btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Add.Depth = 0
        Me.Btn_Add.Icon = Nothing
        Me.Btn_Add.Location = New System.Drawing.Point(379, 87)
        Me.Btn_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Primary = True
        Me.Btn_Add.Size = New System.Drawing.Size(48, 36)
        Me.Btn_Add.TabIndex = 65
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
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
        Me.DGV_Clients.ContextMenuStrip = Me.ClientRemover
        Me.DGV_Clients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Clients.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Clients.Location = New System.Drawing.Point(15, 155)
        Me.DGV_Clients.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.DGV_Clients.MultiSelect = False
        Me.DGV_Clients.Name = "DGV_Clients"
        Me.DGV_Clients.ReadOnly = True
        Me.DGV_Clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Clients.RowHeadersVisible = False
        Me.DGV_Clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clients.Size = New System.Drawing.Size(415, 327)
        Me.DGV_Clients.TabIndex = 66
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
        'ClientRemover
        '
        Me.ClientRemover.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientRemover.Depth = 0
        Me.ClientRemover.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem})
        Me.ClientRemover.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClientRemover.Name = "ClientRemover"
        Me.ClientRemover.Size = New System.Drawing.Size(165, 26)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(0, 493)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(447, 1)
        Me.MaterialDivider2.TabIndex = 67
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(362, 500)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 68
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(15, 128)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MaterialLabel2.TabIndex = 69
        Me.MaterialLabel2.Text = "Owners:"
        '
        'Frm_NewAccountClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(445, 542)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.DGV_Clients)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Txt_CName)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Txt_Cid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_NewAccountClient"
        Me.Sizable = False
        Me.Text = "New Client's Account"
        Me.ClientSelector.ResumeLayout(False)
        CType(Me.DGV_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientRemover.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_CName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_Cid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Btn_Add As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ClientSelector As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGV_Clients As DataGridView
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ClientId As DataGridViewTextBoxColumn
    Friend WithEvents ClientName As DataGridViewTextBoxColumn
    Friend WithEvents ClientRemover As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
End Class
