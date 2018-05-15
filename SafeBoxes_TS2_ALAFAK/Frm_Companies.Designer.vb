<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Companies
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
        Me.dgv_companies = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.btn_modcompany = New System.Windows.Forms.Button()
        Me.btn_delcompany = New System.Windows.Forms.Button()
        Me.btn_newcompany = New System.Windows.Forms.Button()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_bycompName = New System.Windows.Forms.RadioButton()
        Me.txt_bycname = New System.Windows.Forms.TextBox()
        Me.rdb_bycompid = New System.Windows.Forms.RadioButton()
        Me.txt_bycid = New System.Windows.Forms.TextBox()
        CType(Me.dgv_companies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_companies
        '
        Me.dgv_companies.AllowUserToAddRows = False
        Me.dgv_companies.AllowUserToDeleteRows = False
        Me.dgv_companies.AllowUserToResizeRows = False
        Me.dgv_companies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_companies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_companies.BackgroundColor = System.Drawing.Color.White
        Me.dgv_companies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_companies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_companies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_companies.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_companies.Location = New System.Drawing.Point(13, 205)
        Me.dgv_companies.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_companies.MultiSelect = False
        Me.dgv_companies.Name = "dgv_companies"
        Me.dgv_companies.ReadOnly = True
        Me.dgv_companies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_companies.RowHeadersVisible = False
        Me.dgv_companies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_companies.Size = New System.Drawing.Size(720, 338)
        Me.dgv_companies.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Location = New System.Drawing.Point(13, 14)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(720, 178)
        Me.TabControl1.TabIndex = 11
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modcompany)
        Me.tab_datacontrol.Controls.Add(Me.btn_delcompany)
        Me.tab_datacontrol.Controls.Add(Me.btn_newcompany)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Size = New System.Drawing.Size(712, 145)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(163, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'txt_details
        '
        Me.txt_details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_details.Location = New System.Drawing.Point(167, 29)
        Me.txt_details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(537, 107)
        Me.txt_details.TabIndex = 3
        '
        'btn_modcompany
        '
        Me.btn_modcompany.Location = New System.Drawing.Point(8, 68)
        Me.btn_modcompany.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modcompany.Name = "btn_modcompany"
        Me.btn_modcompany.Size = New System.Drawing.Size(151, 29)
        Me.btn_modcompany.TabIndex = 2
        Me.btn_modcompany.Text = "Modify Selected"
        Me.btn_modcompany.UseVisualStyleBackColor = True
        '
        'btn_delcompany
        '
        Me.btn_delcompany.Location = New System.Drawing.Point(8, 107)
        Me.btn_delcompany.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delcompany.Name = "btn_delcompany"
        Me.btn_delcompany.Size = New System.Drawing.Size(151, 29)
        Me.btn_delcompany.TabIndex = 1
        Me.btn_delcompany.Text = "Delete Selected"
        Me.btn_delcompany.UseVisualStyleBackColor = True
        '
        'btn_newcompany
        '
        Me.btn_newcompany.Location = New System.Drawing.Point(8, 29)
        Me.btn_newcompany.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newcompany.Name = "btn_newcompany"
        Me.btn_newcompany.Size = New System.Drawing.Size(151, 29)
        Me.btn_newcompany.TabIndex = 0
        Me.btn_newcompany.Text = "Add new"
        Me.btn_newcompany.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_bycompName)
        Me.tab_filter.Controls.Add(Me.txt_bycname)
        Me.tab_filter.Controls.Add(Me.rdb_bycompid)
        Me.tab_filter.Controls.Add(Me.txt_bycid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Size = New System.Drawing.Size(712, 145)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(656, 78)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(36, 54)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(539, 78)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 54)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_bycompName
        '
        Me.rdb_bycompName.AutoSize = True
        Me.rdb_bycompName.Location = New System.Drawing.Point(9, 56)
        Me.rdb_bycompName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_bycompName.Name = "rdb_bycompName"
        Me.rdb_bycompName.Size = New System.Drawing.Size(162, 24)
        Me.rdb_bycompName.TabIndex = 11
        Me.rdb_bycompName.Text = "By Company Name"
        Me.rdb_bycompName.UseVisualStyleBackColor = True
        '
        'txt_bycname
        '
        Me.txt_bycname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Location = New System.Drawing.Point(175, 55)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.Size = New System.Drawing.Size(352, 26)
        Me.txt_bycname.TabIndex = 10
        '
        'rdb_bycompid
        '
        Me.rdb_bycompid.Location = New System.Drawing.Point(9, 9)
        Me.rdb_bycompid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_bycompid.Name = "rdb_bycompid"
        Me.rdb_bycompid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_bycompid.TabIndex = 13
        Me.rdb_bycompid.Text = "By Company ID"
        '
        'txt_bycid
        '
        Me.txt_bycid.Enabled = False
        Me.txt_bycid.Location = New System.Drawing.Point(175, 14)
        Me.txt_bycid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycid.Name = "txt_bycid"
        Me.txt_bycid.Size = New System.Drawing.Size(352, 26)
        Me.txt_bycid.TabIndex = 8
        '
        'Frm_Companies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 569)
        Me.Controls.Add(Me.dgv_companies)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Companies"
        Me.Text = "Companies Management"
        CType(Me.dgv_companies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_companies As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modcompany As Button
    Friend WithEvents btn_delcompany As Button
    Friend WithEvents btn_newcompany As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_bycompName As RadioButton
    Friend WithEvents txt_bycname As TextBox
    Friend WithEvents rdb_bycompid As RadioButton
    Friend WithEvents txt_bycid As TextBox
End Class
