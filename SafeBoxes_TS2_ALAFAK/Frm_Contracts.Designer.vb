<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Contracts
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.btn_visits = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.btn_withdraw = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_renew = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_keydelivered = New System.Windows.Forms.Button()
        Me.btn_showmissingkeys = New System.Windows.Forms.Button()
        Me.btn_addmissingkeys = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_modcontract = New System.Windows.Forms.Button()
        Me.btn_delcontract = New System.Windows.Forms.Button()
        Me.btn_newcontract = New System.Windows.Forms.Button()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_bycontid = New System.Windows.Forms.RadioButton()
        Me.txt_bycontid = New System.Windows.Forms.TextBox()
        Me.rdb_byboxid = New System.Windows.Forms.RadioButton()
        Me.txt_byboxid = New System.Windows.Forms.TextBox()
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MissingKeysReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractsEndReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawPermissionsReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientAuthorizationsReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(668, 174)
        Me.TabControl1.TabIndex = 1
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_datacontrol.Controls.Add(Me.btn_visits)
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.btn_authorize)
        Me.tab_datacontrol.Controls.Add(Me.btn_withdraw)
        Me.tab_datacontrol.Controls.Add(Me.btn_end)
        Me.tab_datacontrol.Controls.Add(Me.Label4)
        Me.tab_datacontrol.Controls.Add(Me.btn_renew)
        Me.tab_datacontrol.Controls.Add(Me.Label3)
        Me.tab_datacontrol.Controls.Add(Me.btn_keydelivered)
        Me.tab_datacontrol.Controls.Add(Me.btn_showmissingkeys)
        Me.tab_datacontrol.Controls.Add(Me.btn_addmissingkeys)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.btn_modcontract)
        Me.tab_datacontrol.Controls.Add(Me.btn_delcontract)
        Me.tab_datacontrol.Controls.Add(Me.btn_newcontract)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datacontrol.Size = New System.Drawing.Size(660, 141)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
        'btn_visits
        '
        Me.btn_visits.Location = New System.Drawing.Point(321, 96)
        Me.btn_visits.Name = "btn_visits"
        Me.btn_visits.Size = New System.Drawing.Size(151, 29)
        Me.btn_visits.TabIndex = 16
        Me.btn_visits.Text = "Visits"
        Me.btn_visits.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(473, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Permissions"
        '
        'btn_authorize
        '
        Me.btn_authorize.Location = New System.Drawing.Point(477, 61)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(151, 29)
        Me.btn_authorize.TabIndex = 14
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'btn_withdraw
        '
        Me.btn_withdraw.Location = New System.Drawing.Point(477, 26)
        Me.btn_withdraw.Name = "btn_withdraw"
        Me.btn_withdraw.Size = New System.Drawing.Size(151, 29)
        Me.btn_withdraw.TabIndex = 13
        Me.btn_withdraw.Text = "Withdraw Permission"
        Me.btn_withdraw.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(320, 61)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(151, 29)
        Me.btn_end.TabIndex = 12
        Me.btn_end.Text = "End"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(316, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Manage Contracts"
        '
        'btn_renew
        '
        Me.btn_renew.Location = New System.Drawing.Point(320, 26)
        Me.btn_renew.Name = "btn_renew"
        Me.btn_renew.Size = New System.Drawing.Size(151, 29)
        Me.btn_renew.TabIndex = 10
        Me.btn_renew.Text = "Renew"
        Me.btn_renew.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(159, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Manage Keys"
        '
        'btn_keydelivered
        '
        Me.btn_keydelivered.Enabled = False
        Me.btn_keydelivered.Location = New System.Drawing.Point(163, 96)
        Me.btn_keydelivered.Name = "btn_keydelivered"
        Me.btn_keydelivered.Size = New System.Drawing.Size(151, 29)
        Me.btn_keydelivered.TabIndex = 8
        Me.btn_keydelivered.Text = "Key Delivered"
        Me.btn_keydelivered.UseVisualStyleBackColor = True
        '
        'btn_showmissingkeys
        '
        Me.btn_showmissingkeys.Location = New System.Drawing.Point(163, 26)
        Me.btn_showmissingkeys.Name = "btn_showmissingkeys"
        Me.btn_showmissingkeys.Size = New System.Drawing.Size(151, 29)
        Me.btn_showmissingkeys.TabIndex = 7
        Me.btn_showmissingkeys.Text = "Show Missing"
        Me.btn_showmissingkeys.UseVisualStyleBackColor = True
        '
        'btn_addmissingkeys
        '
        Me.btn_addmissingkeys.Location = New System.Drawing.Point(163, 61)
        Me.btn_addmissingkeys.Name = "btn_addmissingkeys"
        Me.btn_addmissingkeys.Size = New System.Drawing.Size(151, 29)
        Me.btn_addmissingkeys.TabIndex = 6
        Me.btn_addmissingkeys.Text = "Add Missing"
        Me.btn_addmissingkeys.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'btn_modcontract
        '
        Me.btn_modcontract.Location = New System.Drawing.Point(6, 61)
        Me.btn_modcontract.Name = "btn_modcontract"
        Me.btn_modcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_modcontract.TabIndex = 2
        Me.btn_modcontract.Text = "Modify Selected"
        Me.btn_modcontract.UseVisualStyleBackColor = True
        '
        'btn_delcontract
        '
        Me.btn_delcontract.Location = New System.Drawing.Point(6, 96)
        Me.btn_delcontract.Name = "btn_delcontract"
        Me.btn_delcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_delcontract.TabIndex = 1
        Me.btn_delcontract.Text = "Delete Selected"
        Me.btn_delcontract.UseVisualStyleBackColor = True
        '
        'btn_newcontract
        '
        Me.btn_newcontract.Location = New System.Drawing.Point(6, 26)
        Me.btn_newcontract.Name = "btn_newcontract"
        Me.btn_newcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_newcontract.TabIndex = 0
        Me.btn_newcontract.Text = "Add new"
        Me.btn_newcontract.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_bycontid)
        Me.tab_filter.Controls.Add(Me.txt_bycontid)
        Me.tab_filter.Controls.Add(Me.rdb_byboxid)
        Me.tab_filter.Controls.Add(Me.txt_byboxid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_filter.Size = New System.Drawing.Size(660, 141)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(629, 100)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(24, 35)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(551, 98)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_bycontid
        '
        Me.rdb_bycontid.AutoSize = True
        Me.rdb_bycontid.Location = New System.Drawing.Point(6, 43)
        Me.rdb_bycontid.Name = "rdb_bycontid"
        Me.rdb_bycontid.Size = New System.Drawing.Size(127, 24)
        Me.rdb_bycontid.TabIndex = 11
        Me.rdb_bycontid.Text = "By Contract ID"
        Me.rdb_bycontid.UseVisualStyleBackColor = True
        '
        'txt_bycontid
        '
        Me.txt_bycontid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bycontid.Enabled = False
        Me.txt_bycontid.Location = New System.Drawing.Point(138, 42)
        Me.txt_bycontid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_bycontid.Name = "txt_bycontid"
        Me.txt_bycontid.Size = New System.Drawing.Size(215, 27)
        Me.txt_bycontid.TabIndex = 10
        '
        'rdb_byboxid
        '
        Me.rdb_byboxid.Location = New System.Drawing.Point(6, 6)
        Me.rdb_byboxid.Name = "rdb_byboxid"
        Me.rdb_byboxid.Size = New System.Drawing.Size(104, 24)
        Me.rdb_byboxid.TabIndex = 13
        Me.rdb_byboxid.Text = "By Box ID"
        '
        'txt_byboxid
        '
        Me.txt_byboxid.Enabled = False
        Me.txt_byboxid.Location = New System.Drawing.Point(138, 5)
        Me.txt_byboxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byboxid.Name = "txt_byboxid"
        Me.txt_byboxid.Size = New System.Drawing.Size(215, 27)
        Me.txt_byboxid.TabIndex = 8
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
        Me.dgv_contracts.Location = New System.Drawing.Point(13, 209)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(668, 324)
        Me.dgv_contracts.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MissingKeysReportsToolStripMenuItem, Me.RenewReportsToolStripMenuItem, Me.ContractsEndReportsToolStripMenuItem, Me.WithdrawPermissionsReportsToolStripMenuItem, Me.ClientAuthorizationsReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'MissingKeysReportsToolStripMenuItem
        '
        Me.MissingKeysReportsToolStripMenuItem.Name = "MissingKeysReportsToolStripMenuItem"
        Me.MissingKeysReportsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.MissingKeysReportsToolStripMenuItem.Text = "Missing Keys Reports"
        '
        'RenewReportsToolStripMenuItem
        '
        Me.RenewReportsToolStripMenuItem.Name = "RenewReportsToolStripMenuItem"
        Me.RenewReportsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RenewReportsToolStripMenuItem.Text = "Renews Reports"
        '
        'ContractsEndReportsToolStripMenuItem
        '
        Me.ContractsEndReportsToolStripMenuItem.Name = "ContractsEndReportsToolStripMenuItem"
        Me.ContractsEndReportsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ContractsEndReportsToolStripMenuItem.Text = "Contracts End Reports"
        '
        'WithdrawPermissionsReportsToolStripMenuItem
        '
        Me.WithdrawPermissionsReportsToolStripMenuItem.Name = "WithdrawPermissionsReportsToolStripMenuItem"
        Me.WithdrawPermissionsReportsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.WithdrawPermissionsReportsToolStripMenuItem.Text = "Withdraw Permissions Reports"
        '
        'ClientAuthorizationsReportsToolStripMenuItem
        '
        Me.ClientAuthorizationsReportsToolStripMenuItem.Name = "ClientAuthorizationsReportsToolStripMenuItem"
        Me.ClientAuthorizationsReportsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ClientAuthorizationsReportsToolStripMenuItem.Text = "Client Authorizations Reports"
        '
        'Frm_Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 547)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgv_contracts)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Contracts"
        Me.Text = "Contracts Management"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_modcontract As Button
    Friend WithEvents btn_delcontract As Button
    Friend WithEvents btn_newcontract As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_bycontid As RadioButton
    Friend WithEvents txt_bycontid As TextBox
    Friend WithEvents rdb_byboxid As RadioButton
    Friend WithEvents txt_byboxid As TextBox
    Friend WithEvents dgv_contracts As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_keydelivered As Button
    Friend WithEvents btn_showmissingkeys As Button
    Friend WithEvents btn_addmissingkeys As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_renew As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_authorize As Button
    Friend WithEvents btn_withdraw As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MissingKeysReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenewReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContractsEndReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithdrawPermissionsReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientAuthorizationsReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_visits As Button
End Class
