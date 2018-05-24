<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_SelectAccountClient
    Inherits System.Windows.Forms.Form

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
        Me.dgv_accounts = New System.Windows.Forms.DataGridView()
        Me.txt_byid = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.grp_search = New System.Windows.Forms.GroupBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.rdb_byname = New System.Windows.Forms.RadioButton()
        Me.txt_byname = New System.Windows.Forms.TextBox()
        Me.rdb_byid = New System.Windows.Forms.RadioButton()
        Me.btn_select = New System.Windows.Forms.Button()
        CType(Me.dgv_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_search.SuspendLayout()
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
        Me.dgv_accounts.Location = New System.Drawing.Point(18, 133)
        Me.dgv_accounts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_accounts.MultiSelect = False
        Me.dgv_accounts.Name = "dgv_accounts"
        Me.dgv_accounts.ReadOnly = True
        Me.dgv_accounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_accounts.RowHeadersVisible = False
        Me.dgv_accounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_accounts.Size = New System.Drawing.Size(603, 328)
        Me.dgv_accounts.TabIndex = 0
        '
        'txt_byid
        '
        Me.txt_byid.Location = New System.Drawing.Point(6, 58)
        Me.txt_byid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byid.Name = "txt_byid"
        Me.txt_byid.Size = New System.Drawing.Size(148, 26)
        Me.txt_byid.TabIndex = 1
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(494, 54)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'grp_search
        '
        Me.grp_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_search.Controls.Add(Me.btn_reset)
        Me.grp_search.Controls.Add(Me.btn_search)
        Me.grp_search.Controls.Add(Me.rdb_byname)
        Me.grp_search.Controls.Add(Me.txt_byname)
        Me.grp_search.Controls.Add(Me.rdb_byid)
        Me.grp_search.Controls.Add(Me.txt_byid)
        Me.grp_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grp_search.Location = New System.Drawing.Point(18, 12)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(603, 113)
        Me.grp_search.TabIndex = 4
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Search"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(572, 54)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(24, 35)
        Me.btn_reset.TabIndex = 6
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'rdb_byname
        '
        Me.rdb_byname.AutoSize = True
        Me.rdb_byname.Location = New System.Drawing.Point(162, 26)
        Me.rdb_byname.Name = "rdb_byname"
        Me.rdb_byname.Size = New System.Drawing.Size(91, 24)
        Me.rdb_byname.TabIndex = 5
        Me.rdb_byname.Text = "By Name"
        Me.rdb_byname.UseVisualStyleBackColor = True
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
        'rdb_byid
        '
        Me.rdb_byid.AutoSize = True
        Me.rdb_byid.Checked = True
        Me.rdb_byid.Location = New System.Drawing.Point(6, 26)
        Me.rdb_byid.Name = "rdb_byid"
        Me.rdb_byid.Size = New System.Drawing.Size(66, 24)
        Me.rdb_byid.TabIndex = 3
        Me.rdb_byid.TabStop = True
        Me.rdb_byid.Text = "By ID"
        Me.rdb_byid.UseVisualStyleBackColor = True
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.Enabled = False
        Me.btn_select.Location = New System.Drawing.Point(509, 471)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(112, 35)
        Me.btn_select.TabIndex = 6
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'Frm_SelectAccountClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 520)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.grp_search)
        Me.Controls.Add(Me.dgv_accounts)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_SelectAccountClient"
        Me.Text = "Select Account"
        CType(Me.dgv_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_accounts As DataGridView
    Friend WithEvents txt_byid As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents grp_search As GroupBox
    Friend WithEvents rdb_byname As RadioButton
    Friend WithEvents txt_byname As TextBox
    Friend WithEvents rdb_byid As RadioButton
    Friend WithEvents btn_select As Button
    Friend WithEvents btn_reset As Button
End Class
