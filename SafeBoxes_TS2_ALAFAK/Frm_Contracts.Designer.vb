<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Contracts
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
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_bycontid = New System.Windows.Forms.RadioButton()
        Me.txt_bycontid = New System.Windows.Forms.TextBox()
        Me.rdb_byboxid = New System.Windows.Forms.RadioButton()
        Me.txt_byboxid = New System.Windows.Forms.TextBox()
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_visits = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_newcontract = New System.Windows.Forms.Button()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.btn_delcontract = New System.Windows.Forms.Button()
        Me.btn_withdraw = New System.Windows.Forms.Button()
        Me.btn_modcontract = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_addmissingkeys = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_showmissingkeys = New System.Windows.Forms.Button()
        Me.btn_renew = New System.Windows.Forms.Button()
        Me.btn_keydelivered = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.MissingKeysReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractEndingReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitsReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorizationReport = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(629, 115)
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
        Me.btn_search.Location = New System.Drawing.Point(551, 113)
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
        Me.dgv_contracts.Location = New System.Drawing.Point(13, 288)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(668, 289)
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
        Me.MaterialTabControl1.Size = New System.Drawing.Size(668, 176)
        Me.MaterialTabControl1.TabIndex = 17
        '
        'TabPage1
        '
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
        Me.TabPage1.Size = New System.Drawing.Size(660, 143)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_visits
        '
        Me.btn_visits.Location = New System.Drawing.Point(321, 95)
        Me.btn_visits.Name = "btn_visits"
        Me.btn_visits.Size = New System.Drawing.Size(151, 29)
        Me.btn_visits.TabIndex = 16
        Me.btn_visits.Text = "Visits"
        Me.btn_visits.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(473, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Permissions"
        '
        'btn_newcontract
        '
        Me.btn_newcontract.Location = New System.Drawing.Point(6, 25)
        Me.btn_newcontract.Name = "btn_newcontract"
        Me.btn_newcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_newcontract.TabIndex = 0
        Me.btn_newcontract.Text = "Add new"
        Me.btn_newcontract.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.Location = New System.Drawing.Point(477, 60)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(151, 29)
        Me.btn_authorize.TabIndex = 14
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'btn_delcontract
        '
        Me.btn_delcontract.Location = New System.Drawing.Point(6, 95)
        Me.btn_delcontract.Name = "btn_delcontract"
        Me.btn_delcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_delcontract.TabIndex = 1
        Me.btn_delcontract.Text = "Delete Selected"
        Me.btn_delcontract.UseVisualStyleBackColor = True
        '
        'btn_withdraw
        '
        Me.btn_withdraw.Location = New System.Drawing.Point(477, 25)
        Me.btn_withdraw.Name = "btn_withdraw"
        Me.btn_withdraw.Size = New System.Drawing.Size(151, 29)
        Me.btn_withdraw.TabIndex = 13
        Me.btn_withdraw.Text = "Withdraw Permission"
        Me.btn_withdraw.UseVisualStyleBackColor = True
        '
        'btn_modcontract
        '
        Me.btn_modcontract.Location = New System.Drawing.Point(6, 60)
        Me.btn_modcontract.Name = "btn_modcontract"
        Me.btn_modcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_modcontract.TabIndex = 2
        Me.btn_modcontract.Text = "Modify Selected"
        Me.btn_modcontract.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(320, 60)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(151, 29)
        Me.btn_end.TabIndex = 12
        Me.btn_end.Text = "End"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_addmissingkeys
        '
        Me.btn_addmissingkeys.Location = New System.Drawing.Point(163, 60)
        Me.btn_addmissingkeys.Name = "btn_addmissingkeys"
        Me.btn_addmissingkeys.Size = New System.Drawing.Size(151, 29)
        Me.btn_addmissingkeys.TabIndex = 6
        Me.btn_addmissingkeys.Text = "Add Missing"
        Me.btn_addmissingkeys.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(316, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Manage Contracts"
        '
        'btn_showmissingkeys
        '
        Me.btn_showmissingkeys.Location = New System.Drawing.Point(163, 25)
        Me.btn_showmissingkeys.Name = "btn_showmissingkeys"
        Me.btn_showmissingkeys.Size = New System.Drawing.Size(151, 29)
        Me.btn_showmissingkeys.TabIndex = 7
        Me.btn_showmissingkeys.Text = "Show Missing"
        Me.btn_showmissingkeys.UseVisualStyleBackColor = True
        '
        'btn_renew
        '
        Me.btn_renew.Location = New System.Drawing.Point(320, 25)
        Me.btn_renew.Name = "btn_renew"
        Me.btn_renew.Size = New System.Drawing.Size(151, 29)
        Me.btn_renew.TabIndex = 10
        Me.btn_renew.Text = "Renew"
        Me.btn_renew.UseVisualStyleBackColor = True
        '
        'btn_keydelivered
        '
        Me.btn_keydelivered.Enabled = False
        Me.btn_keydelivered.Location = New System.Drawing.Point(163, 95)
        Me.btn_keydelivered.Name = "btn_keydelivered"
        Me.btn_keydelivered.Size = New System.Drawing.Size(151, 29)
        Me.btn_keydelivered.TabIndex = 8
        Me.btn_keydelivered.Text = "Key Delivered"
        Me.btn_keydelivered.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(159, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Manage Keys"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.rdb_byboxid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.txt_byboxid)
        Me.TabPage2.Controls.Add(Me.rdb_bycontid)
        Me.TabPage2.Controls.Add(Me.txt_bycontid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(660, 143)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
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
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MissingKeysReport, Me.RenewReport, Me.ContractEndingReport, Me.VisitsReport, Me.WithdrawReport, Me.AuthorizationReport})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(199, 136)
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
        'Frm_Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 591)
        Me.ContextMenuStrip = Me.MaterialContextMenuStrip1
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
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_bycontid As RadioButton
    Friend WithEvents txt_bycontid As TextBox
    Friend WithEvents rdb_byboxid As RadioButton
    Friend WithEvents txt_byboxid As TextBox
    Friend WithEvents dgv_contracts As DataGridView
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_visits As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_newcontract As Button
    Friend WithEvents btn_authorize As Button
    Friend WithEvents btn_delcontract As Button
    Friend WithEvents btn_withdraw As Button
    Friend WithEvents btn_modcontract As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents btn_addmissingkeys As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_showmissingkeys As Button
    Friend WithEvents btn_renew As Button
    Friend WithEvents btn_keydelivered As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents MissingKeysReport As ToolStripMenuItem
    Friend WithEvents RenewReport As ToolStripMenuItem
    Friend WithEvents ContractEndingReport As ToolStripMenuItem
    Friend WithEvents VisitsReport As ToolStripMenuItem
    Friend WithEvents WithdrawReport As ToolStripMenuItem
    Friend WithEvents AuthorizationReport As ToolStripMenuItem
End Class
