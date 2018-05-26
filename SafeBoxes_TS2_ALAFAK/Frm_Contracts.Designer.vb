<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Contracts
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
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_bycontid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_bycontid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_byboxid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_byboxid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_visits = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_newcontract = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_authorize = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delcontract = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_withdraw = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_modcontract = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_end = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_addmissingkeys = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_showmissingkeys = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_renew = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_keydelivered = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.MissingKeysReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractEndingReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitsReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorizationReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.Chk_Expired = New MaterialSkin.Controls.MaterialCheckBox()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(623, 81)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(551, 81)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_bycontid
        '
        Me.rdb_bycontid.Depth = 0
        Me.rdb_bycontid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_bycontid.Location = New System.Drawing.Point(31, 50)
        Me.rdb_bycontid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_bycontid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_bycontid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_bycontid.Name = "rdb_bycontid"
        Me.rdb_bycontid.Ripple = True
        Me.rdb_bycontid.Size = New System.Drawing.Size(127, 24)
        Me.rdb_bycontid.TabIndex = 11
        Me.rdb_bycontid.Text = "By Contract ID"
        Me.rdb_bycontid.UseVisualStyleBackColor = True
        '
        'txt_bycontid
        '
        Me.txt_bycontid.Depth = 0
        Me.txt_bycontid.Enabled = False
        Me.txt_bycontid.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bycontid.Hint = ""
        Me.txt_bycontid.Location = New System.Drawing.Point(166, 50)
        Me.txt_bycontid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_bycontid.MaxLength = 32767
        Me.txt_bycontid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bycontid.Name = "txt_bycontid"
        Me.txt_bycontid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bycontid.SelectedText = ""
        Me.txt_bycontid.SelectionLength = 0
        Me.txt_bycontid.SelectionStart = 0
        Me.txt_bycontid.Size = New System.Drawing.Size(315, 23)
        Me.txt_bycontid.TabIndex = 10
        Me.txt_bycontid.TabStop = False
        Me.txt_bycontid.UseSystemPasswordChar = False
        '
        'rdb_byboxid
        '
        Me.rdb_byboxid.Depth = 0
        Me.rdb_byboxid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byboxid.Location = New System.Drawing.Point(33, 20)
        Me.rdb_byboxid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byboxid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byboxid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byboxid.Name = "rdb_byboxid"
        Me.rdb_byboxid.Ripple = True
        Me.rdb_byboxid.Size = New System.Drawing.Size(104, 24)
        Me.rdb_byboxid.TabIndex = 13
        Me.rdb_byboxid.Text = "By Box ID"
        '
        'txt_byboxid
        '
        Me.txt_byboxid.Depth = 0
        Me.txt_byboxid.Enabled = False
        Me.txt_byboxid.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_byboxid.Hint = ""
        Me.txt_byboxid.Location = New System.Drawing.Point(166, 21)
        Me.txt_byboxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byboxid.MaxLength = 32767
        Me.txt_byboxid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byboxid.Name = "txt_byboxid"
        Me.txt_byboxid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byboxid.SelectedText = ""
        Me.txt_byboxid.SelectionLength = 0
        Me.txt_byboxid.SelectionStart = 0
        Me.txt_byboxid.Size = New System.Drawing.Size(315, 23)
        Me.txt_byboxid.TabIndex = 8
        Me.txt_byboxid.TabStop = False
        Me.txt_byboxid.UseSystemPasswordChar = False
        '
        'dgv_contracts
        '
        Me.dgv_contracts.AllowUserToAddRows = False
        Me.dgv_contracts.AllowUserToDeleteRows = False
        Me.dgv_contracts.AllowUserToResizeRows = False
        Me.dgv_contracts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_contracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_contracts.BackgroundColor = System.Drawing.Color.White
        Me.dgv_contracts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_contracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contracts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_contracts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_contracts.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_contracts.Location = New System.Drawing.Point(13, 281)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(668, 296)
        Me.dgv_contracts.TabIndex = 8
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(13, 104)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(668, 169)
        Me.MaterialTabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btn_visits)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btn_newcontract)
        Me.TabPage1.Controls.Add(Me.btn_authorize)
        Me.TabPage1.Controls.Add(Me.btn_delcontract)
        Me.TabPage1.Controls.Add(Me.btn_withdraw)
        Me.TabPage1.Controls.Add(Me.btn_modcontract)
        Me.TabPage1.Controls.Add(Me.btn_end)
        Me.TabPage1.Controls.Add(Me.btn_addmissingkeys)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btn_showmissingkeys)
        Me.TabPage1.Controls.Add(Me.btn_renew)
        Me.TabPage1.Controls.Add(Me.btn_keydelivered)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(660, 136)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        '
        'btn_visits
        '
        Me.btn_visits.AutoSize = True
        Me.btn_visits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_visits.Depth = 0
        Me.btn_visits.Icon = Nothing
        Me.btn_visits.Location = New System.Drawing.Point(320, 94)
        Me.btn_visits.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_visits.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_visits.Name = "btn_visits"
        Me.btn_visits.Primary = True
        Me.btn_visits.Size = New System.Drawing.Size(62, 36)
        Me.btn_visits.TabIndex = 16
        Me.btn_visits.Text = "Visits"
        Me.btn_visits.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(473, 2)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Permissions"
        '
        'btn_newcontract
        '
        Me.btn_newcontract.AutoSize = True
        Me.btn_newcontract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newcontract.Depth = 0
        Me.btn_newcontract.Icon = Nothing
        Me.btn_newcontract.Location = New System.Drawing.Point(10, 22)
        Me.btn_newcontract.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_newcontract.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newcontract.Name = "btn_newcontract"
        Me.btn_newcontract.Primary = True
        Me.btn_newcontract.Size = New System.Drawing.Size(81, 36)
        Me.btn_newcontract.TabIndex = 0
        Me.btn_newcontract.Text = "Add new"
        Me.btn_newcontract.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.AutoSize = True
        Me.btn_authorize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_authorize.Depth = 0
        Me.btn_authorize.Icon = Nothing
        Me.btn_authorize.Location = New System.Drawing.Point(477, 58)
        Me.btn_authorize.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_authorize.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Primary = True
        Me.btn_authorize.Size = New System.Drawing.Size(95, 36)
        Me.btn_authorize.TabIndex = 14
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'btn_delcontract
        '
        Me.btn_delcontract.AutoSize = True
        Me.btn_delcontract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delcontract.Depth = 0
        Me.btn_delcontract.Icon = Nothing
        Me.btn_delcontract.Location = New System.Drawing.Point(10, 94)
        Me.btn_delcontract.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_delcontract.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delcontract.Name = "btn_delcontract"
        Me.btn_delcontract.Primary = True
        Me.btn_delcontract.Size = New System.Drawing.Size(138, 36)
        Me.btn_delcontract.TabIndex = 1
        Me.btn_delcontract.Text = "Delete Selected"
        Me.btn_delcontract.UseVisualStyleBackColor = True
        '
        'btn_withdraw
        '
        Me.btn_withdraw.AutoSize = True
        Me.btn_withdraw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_withdraw.Depth = 0
        Me.btn_withdraw.Icon = Nothing
        Me.btn_withdraw.Location = New System.Drawing.Point(477, 22)
        Me.btn_withdraw.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_withdraw.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_withdraw.Name = "btn_withdraw"
        Me.btn_withdraw.Primary = True
        Me.btn_withdraw.Size = New System.Drawing.Size(94, 36)
        Me.btn_withdraw.TabIndex = 13
        Me.btn_withdraw.Text = "Withdraw"
        Me.btn_withdraw.UseVisualStyleBackColor = True
        '
        'btn_modcontract
        '
        Me.btn_modcontract.AutoSize = True
        Me.btn_modcontract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modcontract.Depth = 0
        Me.btn_modcontract.Icon = Nothing
        Me.btn_modcontract.Location = New System.Drawing.Point(10, 58)
        Me.btn_modcontract.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_modcontract.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modcontract.Name = "btn_modcontract"
        Me.btn_modcontract.Primary = True
        Me.btn_modcontract.Size = New System.Drawing.Size(140, 36)
        Me.btn_modcontract.TabIndex = 2
        Me.btn_modcontract.Text = "Modify Selected"
        Me.btn_modcontract.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.AutoSize = True
        Me.btn_end.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_end.Depth = 0
        Me.btn_end.Icon = Nothing
        Me.btn_end.Location = New System.Drawing.Point(320, 58)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_end.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Primary = True
        Me.btn_end.Size = New System.Drawing.Size(47, 36)
        Me.btn_end.TabIndex = 12
        Me.btn_end.Text = "End"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_addmissingkeys
        '
        Me.btn_addmissingkeys.AutoSize = True
        Me.btn_addmissingkeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_addmissingkeys.Depth = 0
        Me.btn_addmissingkeys.Icon = Nothing
        Me.btn_addmissingkeys.Location = New System.Drawing.Point(163, 58)
        Me.btn_addmissingkeys.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_addmissingkeys.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_addmissingkeys.Name = "btn_addmissingkeys"
        Me.btn_addmissingkeys.Primary = True
        Me.btn_addmissingkeys.Size = New System.Drawing.Size(107, 36)
        Me.btn_addmissingkeys.TabIndex = 6
        Me.btn_addmissingkeys.Text = "Add Missing"
        Me.btn_addmissingkeys.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(316, 2)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Manage Contracts"
        '
        'btn_showmissingkeys
        '
        Me.btn_showmissingkeys.AutoSize = True
        Me.btn_showmissingkeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_showmissingkeys.Depth = 0
        Me.btn_showmissingkeys.Icon = Nothing
        Me.btn_showmissingkeys.Location = New System.Drawing.Point(163, 22)
        Me.btn_showmissingkeys.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_showmissingkeys.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_showmissingkeys.Name = "btn_showmissingkeys"
        Me.btn_showmissingkeys.Primary = True
        Me.btn_showmissingkeys.Size = New System.Drawing.Size(119, 36)
        Me.btn_showmissingkeys.TabIndex = 7
        Me.btn_showmissingkeys.Text = "Show Missing"
        Me.btn_showmissingkeys.UseVisualStyleBackColor = True
        '
        'btn_renew
        '
        Me.btn_renew.AutoSize = True
        Me.btn_renew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_renew.Depth = 0
        Me.btn_renew.Icon = Nothing
        Me.btn_renew.Location = New System.Drawing.Point(320, 22)
        Me.btn_renew.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_renew.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_renew.Name = "btn_renew"
        Me.btn_renew.Primary = True
        Me.btn_renew.Size = New System.Drawing.Size(67, 36)
        Me.btn_renew.TabIndex = 10
        Me.btn_renew.Text = "Renew"
        Me.btn_renew.UseVisualStyleBackColor = True
        '
        'btn_keydelivered
        '
        Me.btn_keydelivered.AutoSize = True
        Me.btn_keydelivered.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_keydelivered.Depth = 0
        Me.btn_keydelivered.Enabled = False
        Me.btn_keydelivered.Icon = Nothing
        Me.btn_keydelivered.Location = New System.Drawing.Point(163, 94)
        Me.btn_keydelivered.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btn_keydelivered.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_keydelivered.Name = "btn_keydelivered"
        Me.btn_keydelivered.Primary = True
        Me.btn_keydelivered.Size = New System.Drawing.Size(119, 36)
        Me.btn_keydelivered.TabIndex = 8
        Me.btn_keydelivered.Text = "Key Delivered"
        Me.btn_keydelivered.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(159, 2)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Manage Keys"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Chk_Expired)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.rdb_byboxid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.txt_byboxid)
        Me.TabPage2.Controls.Add(Me.rdb_bycontid)
        Me.TabPage2.Controls.Add(Me.txt_bycontid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(660, 136)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(693, 35)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MissingKeysReport, Me.RenewReport, Me.ContractEndingReport, Me.VisitsReport, Me.WithdrawReport, Me.AuthorizationReport, Me.SelectBoxToolStripMenuItem, Me.SelectAccountToolStripMenuItem})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(199, 180)
        '
        'MissingKeysReport
        '
        Me.MissingKeysReport.Name = "MissingKeysReport"
        Me.MissingKeysReport.Size = New System.Drawing.Size(198, 22)
        Me.MissingKeysReport.Text = "Missing Keys Reports"
        '
        'RenewReport
        '
        Me.RenewReport.Name = "RenewReport"
        Me.RenewReport.Size = New System.Drawing.Size(198, 22)
        Me.RenewReport.Text = "Renew Report"
        '
        'ContractEndingReport
        '
        Me.ContractEndingReport.Name = "ContractEndingReport"
        Me.ContractEndingReport.Size = New System.Drawing.Size(198, 22)
        Me.ContractEndingReport.Text = "Contract Ending Report"
        '
        'VisitsReport
        '
        Me.VisitsReport.Name = "VisitsReport"
        Me.VisitsReport.Size = New System.Drawing.Size(198, 22)
        Me.VisitsReport.Text = "Visits Report"
        '
        'WithdrawReport
        '
        Me.WithdrawReport.Name = "WithdrawReport"
        Me.WithdrawReport.Size = New System.Drawing.Size(198, 22)
        Me.WithdrawReport.Text = "Withdraw Report"
        '
        'AuthorizationReport
        '
        Me.AuthorizationReport.Name = "AuthorizationReport"
        Me.AuthorizationReport.Size = New System.Drawing.Size(198, 22)
        Me.AuthorizationReport.Text = "Authorization Report"
        '
        'SelectBoxToolStripMenuItem
        '
        Me.SelectBoxToolStripMenuItem.Name = "SelectBoxToolStripMenuItem"
        Me.SelectBoxToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SelectBoxToolStripMenuItem.Text = "Select Box"
        '
        'SelectAccountToolStripMenuItem
        '
        Me.SelectAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientAccountToolStripMenuItem, Me.CompanyAccountToolStripMenuItem})
        Me.SelectAccountToolStripMenuItem.Name = "SelectAccountToolStripMenuItem"
        Me.SelectAccountToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SelectAccountToolStripMenuItem.Text = "Select Account"
        '
        'ClientAccountToolStripMenuItem
        '
        Me.ClientAccountToolStripMenuItem.Name = "ClientAccountToolStripMenuItem"
        Me.ClientAccountToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClientAccountToolStripMenuItem.Text = "Client Account"
        '
        'CompanyAccountToolStripMenuItem
        '
        Me.CompanyAccountToolStripMenuItem.Name = "CompanyAccountToolStripMenuItem"
        Me.CompanyAccountToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CompanyAccountToolStripMenuItem.Text = "Company Account"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 276)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(693, 1)
        Me.MaterialDivider1.TabIndex = 17
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'Chk_Expired
        '
        Me.Chk_Expired.AutoSize = True
        Me.Chk_Expired.Depth = 0
        Me.Chk_Expired.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Chk_Expired.Location = New System.Drawing.Point(29, 82)
        Me.Chk_Expired.Margin = New System.Windows.Forms.Padding(0)
        Me.Chk_Expired.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Chk_Expired.MouseState = MaterialSkin.MouseState.HOVER
        Me.Chk_Expired.Name = "Chk_Expired"
        Me.Chk_Expired.Ripple = True
        Me.Chk_Expired.Size = New System.Drawing.Size(76, 30)
        Me.Chk_Expired.TabIndex = 14
        Me.Chk_Expired.Text = "Expired"
        Me.Chk_Expired.UseVisualStyleBackColor = True
        '
        'Frm_Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 591)
        Me.ContextMenuStrip = Me.MaterialContextMenuStrip1
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.dgv_contracts)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Contracts"
        Me.Text = "Contracts Management"
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_bycontid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_bycontid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_byboxid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_byboxid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgv_contracts As DataGridView
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_visits As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_newcontract As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_authorize As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delcontract As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_withdraw As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_modcontract As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_end As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_addmissingkeys As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_showmissingkeys As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_renew As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_keydelivered As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents MissingKeysReport As ToolStripMenuItem
    Friend WithEvents RenewReport As ToolStripMenuItem
    Friend WithEvents ContractEndingReport As ToolStripMenuItem
    Friend WithEvents VisitsReport As ToolStripMenuItem
    Friend WithEvents WithdrawReport As ToolStripMenuItem
    Friend WithEvents AuthorizationReport As ToolStripMenuItem
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents SelectBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Chk_Expired As MaterialSkin.Controls.MaterialCheckBox
End Class
