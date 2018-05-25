<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectContract
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
        Me.btn_select = New MaterialSkin.Controls.MaterialFlatButton()
        Me.grp_search = New System.Windows.Forms.GroupBox()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byaccountid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_byaccid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ContextAccountSelect = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rdb_byboxid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_byboxid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.grp_search.SuspendLayout()
        Me.ContextAccountSelect.SuspendLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.AutoSize = True
        Me.btn_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_select.Depth = 0
        Me.btn_select.Enabled = False
        Me.btn_select.Icon = Nothing
        Me.btn_select.Location = New System.Drawing.Point(550, 472)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_select.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Primary = False
        Me.btn_select.Size = New System.Drawing.Size(69, 36)
        Me.btn_select.TabIndex = 9
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'grp_search
        '
        Me.grp_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_search.Controls.Add(Me.btn_reset)
        Me.grp_search.Controls.Add(Me.btn_search)
        Me.grp_search.Controls.Add(Me.rdb_byaccountid)
        Me.grp_search.Controls.Add(Me.txt_byaccid)
        Me.grp_search.Controls.Add(Me.rdb_byboxid)
        Me.grp_search.Controls.Add(Me.txt_byboxid)
        Me.grp_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grp_search.Location = New System.Drawing.Point(19, 73)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(603, 113)
        Me.grp_search.TabIndex = 8
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Search"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(566, 54)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 6
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
        Me.btn_search.Location = New System.Drawing.Point(485, 54)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(73, 36)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byaccountid
        '
        Me.rdb_byaccountid.AutoSize = True
        Me.rdb_byaccountid.Depth = 0
        Me.rdb_byaccountid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byaccountid.Location = New System.Drawing.Point(251, 26)
        Me.rdb_byaccountid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byaccountid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byaccountid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byaccountid.Name = "rdb_byaccountid"
        Me.rdb_byaccountid.Ripple = True
        Me.rdb_byaccountid.Size = New System.Drawing.Size(115, 30)
        Me.rdb_byaccountid.TabIndex = 5
        Me.rdb_byaccountid.Text = "By Account ID"
        Me.rdb_byaccountid.UseVisualStyleBackColor = True
        '
        'txt_byaccid
        '
        Me.txt_byaccid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byaccid.ContextMenuStrip = Me.ContextAccountSelect
        Me.txt_byaccid.Depth = 0
        Me.txt_byaccid.Enabled = False
        Me.txt_byaccid.Hint = ""
        Me.txt_byaccid.Location = New System.Drawing.Point(251, 58)
        Me.txt_byaccid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byaccid.MaxLength = 32767
        Me.txt_byaccid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byaccid.Name = "txt_byaccid"
        Me.txt_byaccid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byaccid.SelectedText = ""
        Me.txt_byaccid.SelectionLength = 0
        Me.txt_byaccid.SelectionStart = 0
        Me.txt_byaccid.Size = New System.Drawing.Size(236, 23)
        Me.txt_byaccid.TabIndex = 4
        Me.txt_byaccid.TabStop = False
        Me.txt_byaccid.UseSystemPasswordChar = False
        '
        'ContextAccountSelect
        '
        Me.ContextAccountSelect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAccountToolStripMenuItem})
        Me.ContextAccountSelect.Name = "ContextAccountSelect"
        Me.ContextAccountSelect.Size = New System.Drawing.Size(154, 26)
        '
        'SelectAccountToolStripMenuItem
        '
        Me.SelectAccountToolStripMenuItem.Name = "SelectAccountToolStripMenuItem"
        Me.SelectAccountToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SelectAccountToolStripMenuItem.Text = "Select Account"
        '
        'rdb_byboxid
        '
        Me.rdb_byboxid.Depth = 0
        Me.rdb_byboxid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byboxid.Location = New System.Drawing.Point(7, 26)
        Me.rdb_byboxid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byboxid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byboxid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byboxid.Name = "rdb_byboxid"
        Me.rdb_byboxid.Ripple = True
        Me.rdb_byboxid.Size = New System.Drawing.Size(104, 24)
        Me.rdb_byboxid.TabIndex = 7
        Me.rdb_byboxid.Text = "By Box ID"
        '
        'txt_byboxid
        '
        Me.txt_byboxid.Depth = 0
        Me.txt_byboxid.Enabled = False
        Me.txt_byboxid.Hint = ""
        Me.txt_byboxid.Location = New System.Drawing.Point(7, 58)
        Me.txt_byboxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byboxid.MaxLength = 32767
        Me.txt_byboxid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byboxid.Name = "txt_byboxid"
        Me.txt_byboxid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byboxid.SelectedText = ""
        Me.txt_byboxid.SelectionLength = 0
        Me.txt_byboxid.SelectionStart = 0
        Me.txt_byboxid.Size = New System.Drawing.Size(236, 23)
        Me.txt_byboxid.TabIndex = 1
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
        Me.dgv_contracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contracts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_contracts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_contracts.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_contracts.Location = New System.Drawing.Point(16, 194)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(603, 268)
        Me.dgv_contracts.TabIndex = 7
        '
        'Frm_SelectContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 520)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.grp_search)
        Me.Controls.Add(Me.dgv_contracts)
        Me.Name = "Frm_SelectContract"
        Me.Text = "Select Contract"
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        Me.ContextAccountSelect.ResumeLayout(False)
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_select As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents grp_search As GroupBox
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byboxid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_byboxid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgv_contracts As DataGridView
    Friend WithEvents rdb_byaccountid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_byaccid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ContextAccountSelect As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectAccountToolStripMenuItem As ToolStripMenuItem
End Class
