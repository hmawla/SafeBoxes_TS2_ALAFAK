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
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.btn_newcontract = New System.Windows.Forms.Button()
        Me.btn_delcontract = New System.Windows.Forms.Button()
        Me.btn_modcontract = New System.Windows.Forms.Button()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byaccountid = New System.Windows.Forms.RadioButton()
        Me.txt_byaccid = New System.Windows.Forms.TextBox()
        Me.rdb_byboxid = New System.Windows.Forms.RadioButton()
        Me.txt_byboxid = New System.Windows.Forms.TextBox()
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 178)
        Me.TabControl1.TabIndex = 1
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modcontract)
        Me.tab_datacontrol.Controls.Add(Me.btn_delcontract)
        Me.tab_datacontrol.Controls.Add(Me.btn_newcontract)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datacontrol.Size = New System.Drawing.Size(687, 145)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byaccountid)
        Me.tab_filter.Controls.Add(Me.txt_byaccid)
        Me.tab_filter.Controls.Add(Me.rdb_byboxid)
        Me.tab_filter.Controls.Add(Me.txt_byboxid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_filter.Size = New System.Drawing.Size(687, 145)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
        '
        'btn_newcontract
        '
        Me.btn_newcontract.Location = New System.Drawing.Point(6, 40)
        Me.btn_newcontract.Name = "btn_newcontract"
        Me.btn_newcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_newcontract.TabIndex = 0
        Me.btn_newcontract.Text = "Add new"
        Me.btn_newcontract.UseVisualStyleBackColor = True
        '
        'btn_delcontract
        '
        Me.btn_delcontract.Location = New System.Drawing.Point(6, 110)
        Me.btn_delcontract.Name = "btn_delcontract"
        Me.btn_delcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_delcontract.TabIndex = 1
        Me.btn_delcontract.Text = "Delete Selected"
        Me.btn_delcontract.UseVisualStyleBackColor = True
        '
        'btn_modcontract
        '
        Me.btn_modcontract.Location = New System.Drawing.Point(6, 75)
        Me.btn_modcontract.Name = "btn_modcontract"
        Me.btn_modcontract.Size = New System.Drawing.Size(151, 29)
        Me.btn_modcontract.TabIndex = 2
        Me.btn_modcontract.Text = "Modify Selected"
        Me.btn_modcontract.UseVisualStyleBackColor = True
        '
        'txt_details
        '
        Me.txt_details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_details.Location = New System.Drawing.Point(163, 40)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(518, 99)
        Me.txt_details.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(656, 100)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(24, 35)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(578, 100)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byaccountid
        '
        Me.rdb_byaccountid.AutoSize = True
        Me.rdb_byaccountid.Location = New System.Drawing.Point(6, 72)
        Me.rdb_byaccountid.Name = "rdb_byaccountid"
        Me.rdb_byaccountid.Size = New System.Drawing.Size(129, 24)
        Me.rdb_byaccountid.TabIndex = 11
        Me.rdb_byaccountid.Text = "By Account ID"
        Me.rdb_byaccountid.UseVisualStyleBackColor = True
        '
        'txt_byaccid
        '
        Me.txt_byaccid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byaccid.Enabled = False
        Me.txt_byaccid.Location = New System.Drawing.Point(6, 104)
        Me.txt_byaccid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byaccid.Name = "txt_byaccid"
        Me.txt_byaccid.Size = New System.Drawing.Size(236, 26)
        Me.txt_byaccid.TabIndex = 10
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
        Me.txt_byboxid.Location = New System.Drawing.Point(6, 38)
        Me.txt_byboxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byboxid.Name = "txt_byboxid"
        Me.txt_byboxid.Size = New System.Drawing.Size(236, 26)
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
        Me.dgv_contracts.Location = New System.Drawing.Point(13, 194)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(695, 339)
        Me.dgv_contracts.TabIndex = 8
        '
        'Frm_Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 547)
        Me.Controls.Add(Me.dgv_contracts)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Contracts"
        Me.Text = "Contracts Management"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modcontract As Button
    Friend WithEvents btn_delcontract As Button
    Friend WithEvents btn_newcontract As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byaccountid As RadioButton
    Friend WithEvents txt_byaccid As TextBox
    Friend WithEvents rdb_byboxid As RadioButton
    Friend WithEvents txt_byboxid As TextBox
    Friend WithEvents dgv_contracts As DataGridView
End Class
