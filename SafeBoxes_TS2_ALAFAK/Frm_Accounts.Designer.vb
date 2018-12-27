<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Accounts
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
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Rdb_Clients = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rdb_Companies = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_ModAccount = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_NewAccount = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_DelAccount = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_cname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_byaccid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Rdb_ByName = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rdb_ByAccId = New MaterialSkin.Controls.MaterialRadioButton()
        Me.DGV_Accounts = New System.Windows.Forms.DataGridView()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-2, 59)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(814, 36)
        Me.MaterialTabSelector1.TabIndex = 18
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 101)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(776, 170)
        Me.MaterialTabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Rdb_Clients)
        Me.TabPage1.Controls.Add(Me.Rdb_Companies)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.Btn_ModAccount)
        Me.TabPage1.Controls.Add(Me.Btn_NewAccount)
        Me.TabPage1.Controls.Add(Me.Btn_DelAccount)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(768, 137)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Control"
        '
        'Rdb_Clients
        '
        Me.Rdb_Clients.AutoSize = True
        Me.Rdb_Clients.Checked = True
        Me.Rdb_Clients.Depth = 0
        Me.Rdb_Clients.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_Clients.Location = New System.Drawing.Point(587, 101)
        Me.Rdb_Clients.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_Clients.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_Clients.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_Clients.Name = "Rdb_Clients"
        Me.Rdb_Clients.Ripple = True
        Me.Rdb_Clients.Size = New System.Drawing.Size(72, 30)
        Me.Rdb_Clients.TabIndex = 12
        Me.Rdb_Clients.TabStop = True
        Me.Rdb_Clients.Text = "Clients"
        Me.Rdb_Clients.UseVisualStyleBackColor = True
        '
        'Rdb_Companies
        '
        Me.Rdb_Companies.AutoSize = True
        Me.Rdb_Companies.Depth = 0
        Me.Rdb_Companies.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_Companies.Location = New System.Drawing.Point(659, 101)
        Me.Rdb_Companies.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_Companies.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_Companies.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_Companies.Name = "Rdb_Companies"
        Me.Rdb_Companies.Ripple = True
        Me.Rdb_Companies.Size = New System.Drawing.Size(98, 30)
        Me.Rdb_Companies.TabIndex = 11
        Me.Rdb_Companies.TabStop = True
        Me.Rdb_Companies.Text = "Companies"
        Me.Rdb_Companies.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(5, 5)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel1.TabIndex = 10
        Me.MaterialLabel1.Text = "Control"
        '
        'Btn_ModAccount
        '
        Me.Btn_ModAccount.AutoSize = True
        Me.Btn_ModAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_ModAccount.Depth = 0
        Me.Btn_ModAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModAccount.Icon = Nothing
        Me.Btn_ModAccount.Location = New System.Drawing.Point(4, 68)
        Me.Btn_ModAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_ModAccount.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_ModAccount.Name = "Btn_ModAccount"
        Me.Btn_ModAccount.Primary = True
        Me.Btn_ModAccount.Size = New System.Drawing.Size(140, 36)
        Me.Btn_ModAccount.TabIndex = 8
        Me.Btn_ModAccount.Text = "Modify Selected"
        Me.Btn_ModAccount.UseVisualStyleBackColor = True
        '
        'Btn_NewAccount
        '
        Me.Btn_NewAccount.AutoSize = True
        Me.Btn_NewAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_NewAccount.Depth = 0
        Me.Btn_NewAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NewAccount.Icon = Nothing
        Me.Btn_NewAccount.Location = New System.Drawing.Point(9, 29)
        Me.Btn_NewAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_NewAccount.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_NewAccount.Name = "Btn_NewAccount"
        Me.Btn_NewAccount.Primary = True
        Me.Btn_NewAccount.Size = New System.Drawing.Size(81, 36)
        Me.Btn_NewAccount.TabIndex = 7
        Me.Btn_NewAccount.Text = "Add new"
        Me.Btn_NewAccount.UseVisualStyleBackColor = True
        '
        'Btn_DelAccount
        '
        Me.Btn_DelAccount.AutoSize = True
        Me.Btn_DelAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_DelAccount.Depth = 0
        Me.Btn_DelAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DelAccount.Icon = Nothing
        Me.Btn_DelAccount.Location = New System.Drawing.Point(4, 107)
        Me.Btn_DelAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_DelAccount.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_DelAccount.Name = "Btn_DelAccount"
        Me.Btn_DelAccount.Primary = True
        Me.Btn_DelAccount.Size = New System.Drawing.Size(138, 36)
        Me.Btn_DelAccount.TabIndex = 9
        Me.Btn_DelAccount.Text = "Delete Selected"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.txt_cname)
        Me.TabPage2.Controls.Add(Me.txt_byaccid)
        Me.TabPage2.Controls.Add(Me.Rdb_ByName)
        Me.TabPage2.Controls.Add(Me.Rdb_ByAccId)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(768, 137)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Filter"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(732, 93)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 14
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(656, 93)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 13
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_cname
        '
        Me.txt_cname.Depth = 0
        Me.txt_cname.Enabled = False
        Me.txt_cname.Hint = ""
        Me.txt_cname.Location = New System.Drawing.Point(153, 80)
        Me.txt_cname.MaxLength = 32767
        Me.txt_cname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cname.SelectedText = ""
        Me.txt_cname.SelectionLength = 0
        Me.txt_cname.SelectionStart = 0
        Me.txt_cname.Size = New System.Drawing.Size(352, 23)
        Me.txt_cname.TabIndex = 3
        Me.txt_cname.TabStop = False
        Me.txt_cname.UseSystemPasswordChar = False
        '
        'txt_byaccid
        '
        Me.txt_byaccid.Depth = 0
        Me.txt_byaccid.Enabled = False
        Me.txt_byaccid.Hint = ""
        Me.txt_byaccid.Location = New System.Drawing.Point(153, 22)
        Me.txt_byaccid.MaxLength = 32767
        Me.txt_byaccid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byaccid.Name = "txt_byaccid"
        Me.txt_byaccid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byaccid.SelectedText = ""
        Me.txt_byaccid.SelectionLength = 0
        Me.txt_byaccid.SelectionStart = 0
        Me.txt_byaccid.Size = New System.Drawing.Size(352, 23)
        Me.txt_byaccid.TabIndex = 2
        Me.txt_byaccid.TabStop = False
        Me.txt_byaccid.UseSystemPasswordChar = False
        '
        'Rdb_ByName
        '
        Me.Rdb_ByName.AutoSize = True
        Me.Rdb_ByName.Depth = 0
        Me.Rdb_ByName.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByName.Location = New System.Drawing.Point(9, 73)
        Me.Rdb_ByName.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByName.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByName.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByName.Name = "Rdb_ByName"
        Me.Rdb_ByName.Ripple = True
        Me.Rdb_ByName.Size = New System.Drawing.Size(84, 30)
        Me.Rdb_ByName.TabIndex = 1
        Me.Rdb_ByName.Text = "By Name"
        Me.Rdb_ByName.UseVisualStyleBackColor = True
        '
        'Rdb_ByAccId
        '
        Me.Rdb_ByAccId.AutoSize = True
        Me.Rdb_ByAccId.Depth = 0
        Me.Rdb_ByAccId.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByAccId.Location = New System.Drawing.Point(9, 15)
        Me.Rdb_ByAccId.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByAccId.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByAccId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByAccId.Name = "Rdb_ByAccId"
        Me.Rdb_ByAccId.Ripple = True
        Me.Rdb_ByAccId.Size = New System.Drawing.Size(115, 30)
        Me.Rdb_ByAccId.TabIndex = 0
        Me.Rdb_ByAccId.Text = "By Account ID"
        Me.Rdb_ByAccId.UseVisualStyleBackColor = True
        '
        'DGV_Accounts
        '
        Me.DGV_Accounts.AllowUserToAddRows = False
        Me.DGV_Accounts.AllowUserToDeleteRows = False
        Me.DGV_Accounts.AllowUserToResizeRows = False
        Me.DGV_Accounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Accounts.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Accounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Accounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Accounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Accounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Accounts.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Accounts.Location = New System.Drawing.Point(12, 269)
        Me.DGV_Accounts.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.DGV_Accounts.MultiSelect = False
        Me.DGV_Accounts.Name = "DGV_Accounts"
        Me.DGV_Accounts.ReadOnly = True
        Me.DGV_Accounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Accounts.RowHeadersVisible = False
        Me.DGV_Accounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Accounts.Size = New System.Drawing.Size(773, 315)
        Me.DGV_Accounts.TabIndex = 17
        '
        'Frm_Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.DGV_Accounts)
        Me.Name = "Frm_Accounts"
        Me.Text = "Accounts Manager | Clients"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Btn_ModAccount As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Btn_NewAccount As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Btn_DelAccount As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_cname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_byaccid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Rdb_ByName As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rdb_ByAccId As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents DGV_Accounts As DataGridView
    Friend WithEvents Rdb_Clients As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rdb_Companies As MaterialSkin.Controls.MaterialRadioButton
End Class
