<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CompaniesAccounts
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
        Me.dgv_accounts = New System.Windows.Forms.DataGridView()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_cname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_byAccid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_byaccid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byCname = New MaterialSkin.Controls.MaterialRadioButton()
        CType(Me.dgv_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_accounts
        '
        Me.dgv_accounts.AllowUserToAddRows = False
        Me.dgv_accounts.AllowUserToDeleteRows = False
        Me.dgv_accounts.AllowUserToResizeRows = False
        Me.dgv_accounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_accounts.BackgroundColor = System.Drawing.Color.White
        Me.dgv_accounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_accounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_accounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_accounts.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_accounts.Location = New System.Drawing.Point(13, 283)
        Me.dgv_accounts.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_accounts.MultiSelect = False
        Me.dgv_accounts.Name = "dgv_accounts"
        Me.dgv_accounts.ReadOnly = True
        Me.dgv_accounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_accounts.RowHeadersVisible = False
        Me.dgv_accounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_accounts.Size = New System.Drawing.Size(673, 319)
        Me.dgv_accounts.TabIndex = 16
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(702, 36)
        Me.MaterialTabSelector1.TabIndex = 18
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(14, 106)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(676, 170)
        Me.MaterialTabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.btn_modbox)
        Me.TabPage1.Controls.Add(Me.btn_newbox)
        Me.TabPage1.Controls.Add(Me.btn_delbox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(668, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(7, 4)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Control"
        '
        'btn_modbox
        '
        Me.btn_modbox.AutoSize = True
        Me.btn_modbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modbox.Depth = 0
        Me.btn_modbox.Icon = Nothing
        Me.btn_modbox.Location = New System.Drawing.Point(7, 67)
        Me.btn_modbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modbox.Name = "btn_modbox"
        Me.btn_modbox.Primary = True
        Me.btn_modbox.Size = New System.Drawing.Size(140, 36)
        Me.btn_modbox.TabIndex = 2
        Me.btn_modbox.Text = "Modify Selected"
        Me.btn_modbox.UseVisualStyleBackColor = True
        '
        'btn_newbox
        '
        Me.btn_newbox.AutoSize = True
        Me.btn_newbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newbox.Depth = 0
        Me.btn_newbox.Icon = Nothing
        Me.btn_newbox.Location = New System.Drawing.Point(7, 28)
        Me.btn_newbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newbox.Name = "btn_newbox"
        Me.btn_newbox.Primary = True
        Me.btn_newbox.Size = New System.Drawing.Size(81, 36)
        Me.btn_newbox.TabIndex = 0
        Me.btn_newbox.Text = "Add new"
        Me.btn_newbox.UseVisualStyleBackColor = True
        '
        'btn_delbox
        '
        Me.btn_delbox.AutoSize = True
        Me.btn_delbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delbox.Depth = 0
        Me.btn_delbox.Icon = Nothing
        Me.btn_delbox.Location = New System.Drawing.Point(7, 106)
        Me.btn_delbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delbox.Name = "btn_delbox"
        Me.btn_delbox.Primary = True
        Me.btn_delbox.Size = New System.Drawing.Size(138, 36)
        Me.btn_delbox.TabIndex = 6
        Me.btn_delbox.Text = "Delete Selected"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txt_cname)
        Me.TabPage2.Controls.Add(Me.rdb_byAccid)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.txt_byaccid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.rdb_byCname)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(668, 144)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'txt_cname
        '
        Me.txt_cname.Depth = 0
        Me.txt_cname.Enabled = False
        Me.txt_cname.Hint = ""
        Me.txt_cname.Location = New System.Drawing.Point(173, 62)
        Me.txt_cname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_cname.MaxLength = 32767
        Me.txt_cname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cname.SelectedText = ""
        Me.txt_cname.SelectionLength = 0
        Me.txt_cname.SelectionStart = 0
        Me.txt_cname.Size = New System.Drawing.Size(352, 23)
        Me.txt_cname.TabIndex = 14
        Me.txt_cname.TabStop = False
        Me.txt_cname.UseSystemPasswordChar = False
        '
        'rdb_byAccid
        '
        Me.rdb_byAccid.Depth = 0
        Me.rdb_byAccid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byAccid.Location = New System.Drawing.Point(7, 8)
        Me.rdb_byAccid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byAccid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byAccid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byAccid.Name = "rdb_byAccid"
        Me.rdb_byAccid.Ripple = True
        Me.rdb_byAccid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byAccid.TabIndex = 13
        Me.rdb_byAccid.Text = "By Account ID"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(607, 92)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_byaccid
        '
        Me.txt_byaccid.Depth = 0
        Me.txt_byaccid.Enabled = False
        Me.txt_byaccid.Hint = ""
        Me.txt_byaccid.Location = New System.Drawing.Point(173, 13)
        Me.txt_byaccid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byaccid.MaxLength = 32767
        Me.txt_byaccid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byaccid.Name = "txt_byaccid"
        Me.txt_byaccid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byaccid.SelectedText = ""
        Me.txt_byaccid.SelectionLength = 0
        Me.txt_byaccid.SelectionStart = 0
        Me.txt_byaccid.Size = New System.Drawing.Size(352, 23)
        Me.txt_byaccid.TabIndex = 8
        Me.txt_byaccid.TabStop = False
        Me.txt_byaccid.UseSystemPasswordChar = False
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(510, 92)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byCname
        '
        Me.rdb_byCname.AutoSize = True
        Me.rdb_byCname.Depth = 0
        Me.rdb_byCname.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byCname.Location = New System.Drawing.Point(7, 55)
        Me.rdb_byCname.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byCname.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byCname.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byCname.Name = "rdb_byCname"
        Me.rdb_byCname.Ripple = True
        Me.rdb_byCname.Size = New System.Drawing.Size(146, 30)
        Me.rdb_byCname.TabIndex = 11
        Me.rdb_byCname.Text = "By Company Name"
        Me.rdb_byCname.UseVisualStyleBackColor = True
        '
        'Frm_CompaniesAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 628)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgv_accounts)
        Me.Name = "Frm_CompaniesAccounts"
        Me.Text = "Companies Accounts Management"
        CType(Me.dgv_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_accounts As DataGridView
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_cname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_byAccid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_byaccid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byCname As MaterialSkin.Controls.MaterialRadioButton
End Class
