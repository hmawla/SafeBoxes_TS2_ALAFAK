<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SignatureCards
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
        Me.dgv_signcard = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.btn_modbox = New System.Windows.Forms.Button()
        Me.btn_delbox = New System.Windows.Forms.Button()
        Me.btn_newbox = New System.Windows.Forms.Button()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.txt_bycname = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byCname = New System.Windows.Forms.RadioButton()
        Me.txt_bybid = New System.Windows.Forms.TextBox()
        Me.rdb_bysigncardid = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_signcard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_signcard
        '
        Me.dgv_signcard.AllowUserToAddRows = False
        Me.dgv_signcard.AllowUserToDeleteRows = False
        Me.dgv_signcard.AllowUserToResizeRows = False
        Me.dgv_signcard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_signcard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_signcard.BackgroundColor = System.Drawing.Color.White
        Me.dgv_signcard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_signcard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_signcard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_signcard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_signcard.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_signcard.Location = New System.Drawing.Point(19, 222)
        Me.dgv_signcard.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_signcard.MultiSelect = False
        Me.dgv_signcard.Name = "dgv_signcard"
        Me.dgv_signcard.ReadOnly = True
        Me.dgv_signcard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_signcard.RowHeadersVisible = False
        Me.dgv_signcard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_signcard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_signcard.Size = New System.Drawing.Size(662, 386)
        Me.dgv_signcard.TabIndex = 14
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(19, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 189)
        Me.TabControl1.TabIndex = 13
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modbox)
        Me.tab_datacontrol.Controls.Add(Me.btn_delbox)
        Me.tab_datacontrol.Controls.Add(Me.btn_newbox)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Size = New System.Drawing.Size(654, 156)
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
        Me.txt_details.Location = New System.Drawing.Point(167, 30)
        Me.txt_details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(479, 107)
        Me.txt_details.TabIndex = 3
        '
        'btn_modbox
        '
        Me.btn_modbox.Location = New System.Drawing.Point(8, 69)
        Me.btn_modbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modbox.Name = "btn_modbox"
        Me.btn_modbox.Size = New System.Drawing.Size(151, 29)
        Me.btn_modbox.TabIndex = 2
        Me.btn_modbox.Text = "Modify Selected"
        Me.btn_modbox.UseVisualStyleBackColor = True
        '
        'btn_delbox
        '
        Me.btn_delbox.Location = New System.Drawing.Point(8, 108)
        Me.btn_delbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delbox.Name = "btn_delbox"
        Me.btn_delbox.Size = New System.Drawing.Size(151, 29)
        Me.btn_delbox.TabIndex = 6
        Me.btn_delbox.Text = "Delete Selected"
        '
        'btn_newbox
        '
        Me.btn_newbox.Location = New System.Drawing.Point(8, 30)
        Me.btn_newbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newbox.Name = "btn_newbox"
        Me.btn_newbox.Size = New System.Drawing.Size(151, 29)
        Me.btn_newbox.TabIndex = 0
        Me.btn_newbox.Text = "Add new"
        Me.btn_newbox.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.txt_bycname)
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byCname)
        Me.tab_filter.Controls.Add(Me.txt_bybid)
        Me.tab_filter.Controls.Add(Me.rdb_bysigncardid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Size = New System.Drawing.Size(654, 156)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
        '
        'txt_bycname
        '
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Location = New System.Drawing.Point(175, 55)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.Size = New System.Drawing.Size(352, 26)
        Me.txt_bycname.TabIndex = 14
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(608, 110)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(36, 33)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(511, 110)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(85, 33)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byCname
        '
        Me.rdb_byCname.AutoSize = True
        Me.rdb_byCname.Location = New System.Drawing.Point(9, 56)
        Me.rdb_byCname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byCname.Name = "rdb_byCname"
        Me.rdb_byCname.Size = New System.Drawing.Size(135, 24)
        Me.rdb_byCname.TabIndex = 11
        Me.rdb_byCname.Text = "By Client Name"
        Me.rdb_byCname.UseVisualStyleBackColor = True
        '
        'txt_bybid
        '
        Me.txt_bybid.Enabled = False
        Me.txt_bybid.Location = New System.Drawing.Point(175, 14)
        Me.txt_bybid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bybid.Name = "txt_bybid"
        Me.txt_bybid.Size = New System.Drawing.Size(352, 26)
        Me.txt_bybid.TabIndex = 8
        '
        'rdb_bysigncardid
        '
        Me.rdb_bysigncardid.Location = New System.Drawing.Point(9, 9)
        Me.rdb_bysigncardid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_bysigncardid.Name = "rdb_bysigncardid"
        Me.rdb_bysigncardid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_bysigncardid.TabIndex = 13
        Me.rdb_bysigncardid.Text = "By Sign Card ID"
        '
        'Frm_SignatureCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 628)
        Me.Controls.Add(Me.dgv_signcard)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_SignatureCards"
        Me.Text = "Signature Cards Manager"
        CType(Me.dgv_signcard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_signcard As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modbox As Button
    Friend WithEvents btn_delbox As Button
    Friend WithEvents btn_newbox As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents txt_bycname As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byCname As RadioButton
    Friend WithEvents txt_bybid As TextBox
    Friend WithEvents rdb_bysigncardid As RadioButton
End Class
