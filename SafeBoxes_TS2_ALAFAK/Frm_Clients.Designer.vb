<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clients
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
        Me.dgv_clients = New System.Windows.Forms.DataGridView()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modclient = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newclient = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delclient = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_bycname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_byClientid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_bycid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byClientName = New MaterialSkin.Controls.MaterialRadioButton()
        CType(Me.dgv_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_clients
        '
        Me.dgv_clients.AllowUserToAddRows = False
        Me.dgv_clients.AllowUserToDeleteRows = False
        Me.dgv_clients.AllowUserToResizeRows = False
        Me.dgv_clients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clients.BackgroundColor = System.Drawing.Color.White
        Me.dgv_clients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_clients.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_clients.Location = New System.Drawing.Point(13, 297)
        Me.dgv_clients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_clients.MultiSelect = False
        Me.dgv_clients.Name = "dgv_clients"
        Me.dgv_clients.ReadOnly = True
        Me.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.RowHeadersVisible = False
        Me.dgv_clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clients.Size = New System.Drawing.Size(693, 270)
        Me.dgv_clients.TabIndex = 10
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(722, 36)
        Me.MaterialTabSelector1.TabIndex = 14
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(15, 106)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(692, 187)
        Me.MaterialTabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.btn_modclient)
        Me.TabPage1.Controls.Add(Me.btn_newclient)
        Me.TabPage1.Controls.Add(Me.btn_delclient)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(684, 154)
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
        'btn_modclient
        '
        Me.btn_modclient.AutoSize = True
        Me.btn_modclient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modclient.Depth = 0
        Me.btn_modclient.Icon = Nothing
        Me.btn_modclient.Location = New System.Drawing.Point(7, 67)
        Me.btn_modclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modclient.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modclient.Name = "btn_modclient"
        Me.btn_modclient.Primary = True
        Me.btn_modclient.Size = New System.Drawing.Size(140, 36)
        Me.btn_modclient.TabIndex = 2
        Me.btn_modclient.Text = "Modify Selected"
        Me.btn_modclient.UseVisualStyleBackColor = True
        '
        'btn_newclient
        '
        Me.btn_newclient.AutoSize = True
        Me.btn_newclient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newclient.Depth = 0
        Me.btn_newclient.Icon = Nothing
        Me.btn_newclient.Location = New System.Drawing.Point(7, 28)
        Me.btn_newclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newclient.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newclient.Name = "btn_newclient"
        Me.btn_newclient.Primary = True
        Me.btn_newclient.Size = New System.Drawing.Size(81, 36)
        Me.btn_newclient.TabIndex = 0
        Me.btn_newclient.Text = "Add new"
        Me.btn_newclient.UseVisualStyleBackColor = True
        '
        'btn_delclient
        '
        Me.btn_delclient.AutoSize = True
        Me.btn_delclient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delclient.Depth = 0
        Me.btn_delclient.Icon = Nothing
        Me.btn_delclient.Location = New System.Drawing.Point(7, 106)
        Me.btn_delclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delclient.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delclient.Name = "btn_delclient"
        Me.btn_delclient.Primary = True
        Me.btn_delclient.Size = New System.Drawing.Size(138, 36)
        Me.btn_delclient.TabIndex = 6
        Me.btn_delclient.Text = "Delete Selected"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txt_bycname)
        Me.TabPage2.Controls.Add(Me.rdb_byClientid)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.txt_bycid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.rdb_byClientName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(684, 154)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'txt_bycname
        '
        Me.txt_bycname.Depth = 0
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Hint = ""
        Me.txt_bycname.Location = New System.Drawing.Point(173, 62)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycname.MaxLength = 32767
        Me.txt_bycname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bycname.SelectedText = ""
        Me.txt_bycname.SelectionLength = 0
        Me.txt_bycname.SelectionStart = 0
        Me.txt_bycname.Size = New System.Drawing.Size(352, 23)
        Me.txt_bycname.TabIndex = 14
        Me.txt_bycname.TabStop = False
        Me.txt_bycname.UseSystemPasswordChar = False
        '
        'rdb_byClientid
        '
        Me.rdb_byClientid.Depth = 0
        Me.rdb_byClientid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byClientid.Location = New System.Drawing.Point(7, 8)
        Me.rdb_byClientid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byClientid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byClientid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byClientid.Name = "rdb_byClientid"
        Me.rdb_byClientid.Ripple = True
        Me.rdb_byClientid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byClientid.TabIndex = 13
        Me.rdb_byClientid.Text = "By Client ID"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(639, 92)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_bycid
        '
        Me.txt_bycid.Depth = 0
        Me.txt_bycid.Enabled = False
        Me.txt_bycid.Hint = ""
        Me.txt_bycid.Location = New System.Drawing.Point(173, 13)
        Me.txt_bycid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycid.MaxLength = 32767
        Me.txt_bycid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bycid.Name = "txt_bycid"
        Me.txt_bycid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bycid.SelectedText = ""
        Me.txt_bycid.SelectionLength = 0
        Me.txt_bycid.SelectionStart = 0
        Me.txt_bycid.Size = New System.Drawing.Size(352, 23)
        Me.txt_bycid.TabIndex = 8
        Me.txt_bycid.TabStop = False
        Me.txt_bycid.UseSystemPasswordChar = False
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(542, 92)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byClientName
        '
        Me.rdb_byClientName.AutoSize = True
        Me.rdb_byClientName.Depth = 0
        Me.rdb_byClientName.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byClientName.Location = New System.Drawing.Point(7, 55)
        Me.rdb_byClientName.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byClientName.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byClientName.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byClientName.Name = "rdb_byClientName"
        Me.rdb_byClientName.Ripple = True
        Me.rdb_byClientName.Size = New System.Drawing.Size(123, 30)
        Me.rdb_byClientName.TabIndex = 11
        Me.rdb_byClientName.Text = "By Client Name"
        Me.rdb_byClientName.UseVisualStyleBackColor = True
        '
        'Frm_Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 581)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgv_clients)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Clients"
        Me.Text = "Clients Management"
        CType(Me.dgv_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_clients As DataGridView
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modclient As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newclient As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delclient As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rdb_byClientid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_bycid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byClientName As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_bycname As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
