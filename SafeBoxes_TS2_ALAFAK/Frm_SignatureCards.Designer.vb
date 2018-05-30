<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_SignatureCards
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.dgv_signcard = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.rdb_bysigncardid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_bycname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byCname = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_bybid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SignatureCardsReport = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        CType(Me.dgv_signcard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        Me.SignatureCardsReport.SuspendLayout()
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
        Me.dgv_signcard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_signcard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_signcard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_signcard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_signcard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_signcard.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_signcard.Location = New System.Drawing.Point(15, 332)
        Me.dgv_signcard.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.dgv_signcard.MultiSelect = False
        Me.dgv_signcard.Name = "dgv_signcard"
        Me.dgv_signcard.ReadOnly = True
        Me.dgv_signcard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_signcard.RowHeadersVisible = False
        Me.dgv_signcard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_signcard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_signcard.Size = New System.Drawing.Size(637, 221)
        Me.dgv_signcard.TabIndex = 14
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Depth = 0
        Me.TabControl1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(15, 111)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 215)
        Me.TabControl1.TabIndex = 13
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.BackColor = System.Drawing.Color.White
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.btn_modbox)
        Me.tab_datacontrol.Controls.Add(Me.btn_delbox)
        Me.tab_datacontrol.Controls.Add(Me.btn_newbox)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.tab_datacontrol.Size = New System.Drawing.Size(632, 182)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'btn_modbox
        '
        Me.btn_modbox.AutoSize = True
        Me.btn_modbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modbox.Depth = 0
        Me.btn_modbox.Icon = Nothing
        Me.btn_modbox.Location = New System.Drawing.Point(12, 81)
        Me.btn_modbox.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_modbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modbox.Name = "btn_modbox"
        Me.btn_modbox.Primary = False
        Me.btn_modbox.Size = New System.Drawing.Size(140, 36)
        Me.btn_modbox.TabIndex = 2
        Me.btn_modbox.Text = "Modify Selected"
        Me.btn_modbox.UseVisualStyleBackColor = True
        '
        'btn_delbox
        '
        Me.btn_delbox.AutoSize = True
        Me.btn_delbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delbox.Depth = 0
        Me.btn_delbox.Icon = Nothing
        Me.btn_delbox.Location = New System.Drawing.Point(12, 126)
        Me.btn_delbox.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_delbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delbox.Name = "btn_delbox"
        Me.btn_delbox.Primary = False
        Me.btn_delbox.Size = New System.Drawing.Size(138, 36)
        Me.btn_delbox.TabIndex = 6
        Me.btn_delbox.Text = "Delete Selected"
        '
        'btn_newbox
        '
        Me.btn_newbox.AutoSize = True
        Me.btn_newbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newbox.Depth = 0
        Me.btn_newbox.Icon = Nothing
        Me.btn_newbox.Location = New System.Drawing.Point(12, 36)
        Me.btn_newbox.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_newbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newbox.Name = "btn_newbox"
        Me.btn_newbox.Primary = False
        Me.btn_newbox.Size = New System.Drawing.Size(81, 36)
        Me.btn_newbox.TabIndex = 0
        Me.btn_newbox.Text = "Add new"
        Me.btn_newbox.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.BackColor = System.Drawing.Color.White
        Me.tab_filter.Controls.Add(Me.rdb_bysigncardid)
        Me.tab_filter.Controls.Add(Me.txt_bycname)
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byCname)
        Me.tab_filter.Controls.Add(Me.txt_bybid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.tab_filter.Size = New System.Drawing.Size(632, 182)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        '
        'rdb_bysigncardid
        '
        Me.rdb_bysigncardid.AutoSize = True
        Me.rdb_bysigncardid.Depth = 0
        Me.rdb_bysigncardid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_bysigncardid.Location = New System.Drawing.Point(14, 29)
        Me.rdb_bysigncardid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_bysigncardid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_bysigncardid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_bysigncardid.Name = "rdb_bysigncardid"
        Me.rdb_bysigncardid.Ripple = True
        Me.rdb_bysigncardid.Size = New System.Drawing.Size(124, 30)
        Me.rdb_bysigncardid.TabIndex = 15
        Me.rdb_bysigncardid.Text = "By Sign Card ID"
        Me.rdb_bysigncardid.UseVisualStyleBackColor = True
        '
        'txt_bycname
        '
        Me.txt_bycname.Depth = 0
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Hint = ""
        Me.txt_bycname.Location = New System.Drawing.Point(162, 85)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.txt_bycname.MaxLength = 32767
        Me.txt_bycname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bycname.SelectedText = ""
        Me.txt_bycname.SelectionLength = 0
        Me.txt_bycname.SelectionStart = 0
        Me.txt_bycname.Size = New System.Drawing.Size(371, 23)
        Me.txt_bycname.TabIndex = 14
        Me.txt_bycname.TabStop = False
        Me.txt_bycname.UseSystemPasswordChar = False
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(587, 126)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
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
        Me.btn_search.Location = New System.Drawing.Point(505, 126)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
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
        Me.rdb_byCname.Location = New System.Drawing.Point(15, 85)
        Me.rdb_byCname.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byCname.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byCname.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byCname.Name = "rdb_byCname"
        Me.rdb_byCname.Ripple = True
        Me.rdb_byCname.Size = New System.Drawing.Size(123, 30)
        Me.rdb_byCname.TabIndex = 11
        Me.rdb_byCname.Text = "By Client Name"
        Me.rdb_byCname.UseVisualStyleBackColor = True
        '
        'txt_bybid
        '
        Me.txt_bybid.Depth = 0
        Me.txt_bybid.Enabled = False
        Me.txt_bybid.Hint = ""
        Me.txt_bybid.Location = New System.Drawing.Point(162, 29)
        Me.txt_bybid.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.txt_bybid.MaxLength = 32767
        Me.txt_bybid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bybid.Name = "txt_bybid"
        Me.txt_bybid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bybid.SelectedText = ""
        Me.txt_bybid.SelectionLength = 0
        Me.txt_bybid.SelectionStart = 0
        Me.txt_bybid.Size = New System.Drawing.Size(371, 23)
        Me.txt_bybid.TabIndex = 8
        Me.txt_bybid.TabStop = False
        Me.txt_bybid.UseSystemPasswordChar = False
        '
        'SignatureCardsReport
        '
        Me.SignatureCardsReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignatureCardsReport.Depth = 0
        Me.SignatureCardsReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.SignatureCardsReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.SignatureCardsReport.Name = "MaterialContextMenuStrip1"
        Me.SignatureCardsReport.Size = New System.Drawing.Size(181, 48)
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.TabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-7, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(684, 37)
        Me.MaterialTabSelector1.TabIndex = 15
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Frm_SignatureCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 574)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.dgv_signcard)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_SignatureCards"
        Me.Text = "Signature Cards Manager"
        CType(Me.dgv_signcard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.SignatureCardsReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_signcard As DataGridView
    Friend WithEvents TabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents txt_bycname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byCname As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_bybid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SignatureCardsReport As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rdb_bysigncardid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
End Class
