<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectContract
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
        Me.btn_select = New System.Windows.Forms.Button()
        Me.grp_search = New System.Windows.Forms.GroupBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byboxid = New System.Windows.Forms.RadioButton()
        Me.txt_byid = New System.Windows.Forms.TextBox()
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.rdb_byaccountid = New System.Windows.Forms.RadioButton()
        Me.txt_byname = New System.Windows.Forms.TextBox()
        Me.grp_search.SuspendLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.Enabled = False
        Me.btn_select.Location = New System.Drawing.Point(507, 472)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(112, 35)
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
        Me.grp_search.Controls.Add(Me.txt_byname)
        Me.grp_search.Controls.Add(Me.rdb_byboxid)
        Me.grp_search.Controls.Add(Me.txt_byid)
        Me.grp_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grp_search.Location = New System.Drawing.Point(16, 13)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(603, 113)
        Me.grp_search.TabIndex = 8
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Search"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(573, 54)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(24, 35)
        Me.btn_reset.TabIndex = 6
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(495, 54)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_byname
        '
        Me.txt_byname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byname.Enabled = False
        Me.txt_byname.Location = New System.Drawing.Point(162, 58)
        Me.txt_byname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byname.Name = "txt_byname"
        Me.txt_byname.Size = New System.Drawing.Size(324, 26)
        Me.txt_byname.TabIndex = 4
        '
        'txt_byid
        '
        Me.txt_byid.Location = New System.Drawing.Point(7, 58)
        Me.txt_byid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byid.Name = "txt_byid"
        Me.txt_byid.Size = New System.Drawing.Size(148, 26)
        Me.txt_byid.TabIndex = 1
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
        Me.dgv_contracts.Location = New System.Drawing.Point(16, 134)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(603, 328)
        Me.dgv_contracts.TabIndex = 7
        '
        'rdb_byaccountid
        '
        Me.rdb_byaccountid.AutoSize = True
        Me.rdb_byaccountid.Location = New System.Drawing.Point(251, 26)
        Me.rdb_byaccountid.Name = "rdb_byaccountid"
        Me.rdb_byaccountid.Size = New System.Drawing.Size(125, 24)
        Me.rdb_byaccountid.TabIndex = 5
        Me.rdb_byaccountid.Text = "By Account ID"
        Me.rdb_byaccountid.UseVisualStyleBackColor = True
        '
        'txt_byname
        '
        Me.txt_byname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byname.Enabled = False
        Me.txt_byname.Location = New System.Drawing.Point(251, 58)
        Me.txt_byname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byname.Name = "txt_byname"
        Me.txt_byname.Size = New System.Drawing.Size(236, 27)
        Me.txt_byname.TabIndex = 4
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
        Me.Text = "Frm_SelectContract"
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_select As Button
    Friend WithEvents grp_search As GroupBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byboxid As RadioButton
    Friend WithEvents txt_byid As TextBox
    Friend WithEvents dgv_contracts As DataGridView
    Friend WithEvents rdb_byaccountid As RadioButton
    Friend WithEvents txt_byname As TextBox
End Class
