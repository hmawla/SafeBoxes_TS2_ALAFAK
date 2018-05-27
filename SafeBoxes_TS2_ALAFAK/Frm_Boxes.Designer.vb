<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Boxes
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
        Me.dgv_boxes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newbox = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cbox_boxsizes = New System.Windows.Forms.ComboBox()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byBoxSize = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txt_bybid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_byBoxid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Boxreport = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.BoxesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_ModfyPrices = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Boxreport.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_boxes
        '
        Me.dgv_boxes.AllowUserToAddRows = False
        Me.dgv_boxes.AllowUserToDeleteRows = False
        Me.dgv_boxes.AllowUserToResizeRows = False
        Me.dgv_boxes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_boxes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_boxes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_boxes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_boxes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_boxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_boxes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_boxes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_boxes.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_boxes.Location = New System.Drawing.Point(13, 286)
        Me.dgv_boxes.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_boxes.MultiSelect = False
        Me.dgv_boxes.Name = "dgv_boxes"
        Me.dgv_boxes.ReadOnly = True
        Me.dgv_boxes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_boxes.RowHeadersVisible = False
        Me.dgv_boxes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_boxes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_boxes.Size = New System.Drawing.Size(671, 325)
        Me.dgv_boxes.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.btn_modbox.Location = New System.Drawing.Point(7, 67)
        Me.btn_modbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modbox.Name = "btn_modbox"
        Me.btn_modbox.Primary = True
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
        Me.btn_delbox.Location = New System.Drawing.Point(7, 106)
        Me.btn_delbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delbox.Name = "btn_delbox"
        Me.btn_delbox.Primary = True
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
        Me.btn_newbox.Location = New System.Drawing.Point(7, 28)
        Me.btn_newbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newbox.Name = "btn_newbox"
        Me.btn_newbox.Primary = True
        Me.btn_newbox.Size = New System.Drawing.Size(81, 36)
        Me.btn_newbox.TabIndex = 0
        Me.btn_newbox.Text = "Add new"
        Me.btn_newbox.UseVisualStyleBackColor = True
        '
        'cbox_boxsizes
        '
        Me.cbox_boxsizes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbox_boxsizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_boxsizes.Enabled = False
        Me.cbox_boxsizes.FormattingEnabled = True
        Me.cbox_boxsizes.Location = New System.Drawing.Point(173, 55)
        Me.cbox_boxsizes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbox_boxsizes.Name = "cbox_boxsizes"
        Me.cbox_boxsizes.Size = New System.Drawing.Size(352, 28)
        Me.cbox_boxsizes.TabIndex = 14
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(606, 92)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
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
        Me.btn_search.Location = New System.Drawing.Point(509, 92)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byBoxSize
        '
        Me.rdb_byBoxSize.AutoSize = True
        Me.rdb_byBoxSize.Depth = 0
        Me.rdb_byBoxSize.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byBoxSize.Location = New System.Drawing.Point(7, 55)
        Me.rdb_byBoxSize.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byBoxSize.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byBoxSize.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byBoxSize.Name = "rdb_byBoxSize"
        Me.rdb_byBoxSize.Ripple = True
        Me.rdb_byBoxSize.Size = New System.Drawing.Size(101, 30)
        Me.rdb_byBoxSize.TabIndex = 11
        Me.rdb_byBoxSize.Text = "By Box Size"
        Me.rdb_byBoxSize.UseVisualStyleBackColor = True
        '
        'txt_bybid
        '
        Me.txt_bybid.Depth = 0
        Me.txt_bybid.Enabled = False
        Me.txt_bybid.Hint = ""
        Me.txt_bybid.Location = New System.Drawing.Point(173, 13)
        Me.txt_bybid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bybid.MaxLength = 32767
        Me.txt_bybid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bybid.Name = "txt_bybid"
        Me.txt_bybid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bybid.SelectedText = ""
        Me.txt_bybid.SelectionLength = 0
        Me.txt_bybid.SelectionStart = 0
        Me.txt_bybid.Size = New System.Drawing.Size(352, 23)
        Me.txt_bybid.TabIndex = 8
        Me.txt_bybid.TabStop = False
        Me.txt_bybid.UseSystemPasswordChar = False
        '
        'rdb_byBoxid
        '
        Me.rdb_byBoxid.Depth = 0
        Me.rdb_byBoxid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byBoxid.Location = New System.Drawing.Point(7, 8)
        Me.rdb_byBoxid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byBoxid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byBoxid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byBoxid.Name = "rdb_byBoxid"
        Me.rdb_byBoxid.Ripple = True
        Me.rdb_byBoxid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byBoxid.TabIndex = 13
        Me.rdb_byBoxid.Text = "By Box ID"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 103)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(676, 176)
        Me.MaterialTabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Btn_ModfyPrices)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_modbox)
        Me.TabPage1.Controls.Add(Me.btn_newbox)
        Me.TabPage1.Controls.Add(Me.btn_delbox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(668, 143)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.cbox_boxsizes)
        Me.TabPage2.Controls.Add(Me.rdb_byBoxid)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.txt_bybid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.rdb_byBoxSize)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(668, 143)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-2, 61)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(705, 36)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Boxreport
        '
        Me.Boxreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Boxreport.Depth = 0
        Me.Boxreport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoxesReportToolStripMenuItem})
        Me.Boxreport.MouseState = MaterialSkin.MouseState.HOVER
        Me.Boxreport.Name = "Boxreport"
        Me.Boxreport.Size = New System.Drawing.Size(143, 26)
        '
        'BoxesReportToolStripMenuItem
        '
        Me.BoxesReportToolStripMenuItem.Name = "BoxesReportToolStripMenuItem"
        Me.BoxesReportToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BoxesReportToolStripMenuItem.Text = "Boxes Report"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(175, 4)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel1.TabIndex = 7
        Me.MaterialLabel1.Text = "Prices"
        '
        'Btn_ModfyPrices
        '
        Me.Btn_ModfyPrices.AutoSize = True
        Me.Btn_ModfyPrices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_ModfyPrices.Depth = 0
        Me.Btn_ModfyPrices.Icon = Nothing
        Me.Btn_ModfyPrices.Location = New System.Drawing.Point(179, 28)
        Me.Btn_ModfyPrices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_ModfyPrices.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_ModfyPrices.Name = "Btn_ModfyPrices"
        Me.Btn_ModfyPrices.Primary = True
        Me.Btn_ModfyPrices.Size = New System.Drawing.Size(121, 36)
        Me.Btn_ModfyPrices.TabIndex = 8
        Me.Btn_ModfyPrices.Text = "Modify Prices"
        Me.Btn_ModfyPrices.UseVisualStyleBackColor = True
        '
        'Frm_Boxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 628)
        Me.ContextMenuStrip = Me.Boxreport
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgv_boxes)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Boxes"
        Me.Text = "Boxes Management"
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Boxreport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_boxes As DataGridView
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newbox As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byBoxSize As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_bybid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_byBoxid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents cbox_boxsizes As ComboBox
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Boxreport As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents BoxesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_ModfyPrices As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
