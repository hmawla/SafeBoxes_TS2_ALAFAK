<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Signatures
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_ModSignature = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Brn_NewSignature = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_DelSignature = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_bycname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_bycompid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_bycid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_bycompName = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Dgv_Signatures = New System.Windows.Forms.DataGridView()
        Me.SignatureReport = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage1.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv_Signatures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SignatureReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.Btn_ModSignature)
        Me.TabPage1.Controls.Add(Me.Brn_NewSignature)
        Me.TabPage1.Controls.Add(Me.Btn_DelSignature)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(672, 140)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(7, 4)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Control"
        '
        'Btn_ModSignature
        '
        Me.Btn_ModSignature.AutoSize = True
        Me.Btn_ModSignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_ModSignature.Depth = 0
        Me.Btn_ModSignature.Icon = Nothing
        Me.Btn_ModSignature.Location = New System.Drawing.Point(5, 63)
        Me.Btn_ModSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_ModSignature.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_ModSignature.Name = "Btn_ModSignature"
        Me.Btn_ModSignature.Primary = True
        Me.Btn_ModSignature.Size = New System.Drawing.Size(140, 36)
        Me.Btn_ModSignature.TabIndex = 2
        Me.Btn_ModSignature.Text = "Modify Selected"
        Me.Btn_ModSignature.UseVisualStyleBackColor = True
        '
        'Brn_NewSignature
        '
        Me.Brn_NewSignature.AutoSize = True
        Me.Brn_NewSignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Brn_NewSignature.Depth = 0
        Me.Brn_NewSignature.Icon = Nothing
        Me.Brn_NewSignature.Location = New System.Drawing.Point(7, 28)
        Me.Brn_NewSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Brn_NewSignature.MouseState = MaterialSkin.MouseState.HOVER
        Me.Brn_NewSignature.Name = "Brn_NewSignature"
        Me.Brn_NewSignature.Primary = True
        Me.Brn_NewSignature.Size = New System.Drawing.Size(81, 36)
        Me.Brn_NewSignature.TabIndex = 0
        Me.Brn_NewSignature.Text = "Add new"
        Me.Brn_NewSignature.UseVisualStyleBackColor = True
        '
        'Btn_DelSignature
        '
        Me.Btn_DelSignature.AutoSize = True
        Me.Btn_DelSignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_DelSignature.Depth = 0
        Me.Btn_DelSignature.Icon = Nothing
        Me.Btn_DelSignature.Location = New System.Drawing.Point(7, 99)
        Me.Btn_DelSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_DelSignature.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_DelSignature.Name = "Btn_DelSignature"
        Me.Btn_DelSignature.Primary = True
        Me.Btn_DelSignature.Size = New System.Drawing.Size(138, 36)
        Me.Btn_DelSignature.TabIndex = 6
        Me.Btn_DelSignature.Text = "Delete Selected"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 62)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(707, 36)
        Me.MaterialTabSelector1.TabIndex = 17
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 104)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(680, 166)
        Me.MaterialTabControl1.TabIndex = 18
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txt_bycname)
        Me.TabPage2.Controls.Add(Me.rdb_bycompid)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.txt_bycid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.rdb_bycompName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(672, 140)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'txt_bycname
        '
        Me.txt_bycname.Depth = 0
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Hint = ""
        Me.txt_bycname.Location = New System.Drawing.Point(173, 62)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycname.MaxLength = 32767
        Me.txt_bycname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bycname.SelectedText = ""
        Me.txt_bycname.SelectionLength = 0
        Me.txt_bycname.SelectionStart = 0
        Me.txt_bycname.Size = New System.Drawing.Size(352, 23)
        Me.txt_bycname.TabIndex = 14
        Me.txt_bycname.TabStop = False
        Me.txt_bycname.UseSystemPasswordChar = False
        '
        'rdb_bycompid
        '
        Me.rdb_bycompid.Depth = 0
        Me.rdb_bycompid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_bycompid.Location = New System.Drawing.Point(7, 8)
        Me.rdb_bycompid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_bycompid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_bycompid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_bycompid.Name = "rdb_bycompid"
        Me.rdb_bycompid.Ripple = True
        Me.rdb_bycompid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_bycompid.TabIndex = 13
        Me.rdb_bycompid.Text = "By Company ID"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(633, 96)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_bycid
        '
        Me.txt_bycid.Depth = 0
        Me.txt_bycid.Enabled = False
        Me.txt_bycid.Hint = ""
        Me.txt_bycid.Location = New System.Drawing.Point(173, 13)
        Me.txt_bycid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycid.MaxLength = 32767
        Me.txt_bycid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_bycid.Name = "txt_bycid"
        Me.txt_bycid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bycid.SelectedText = ""
        Me.txt_bycid.SelectionLength = 0
        Me.txt_bycid.SelectionStart = 0
        Me.txt_bycid.Size = New System.Drawing.Size(352, 23)
        Me.txt_bycid.TabIndex = 8
        Me.txt_bycid.TabStop = False
        Me.txt_bycid.UseSystemPasswordChar = False
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(536, 96)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_bycompName
        '
        Me.rdb_bycompName.AutoSize = True
        Me.rdb_bycompName.Depth = 0
        Me.rdb_bycompName.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_bycompName.Location = New System.Drawing.Point(7, 55)
        Me.rdb_bycompName.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_bycompName.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_bycompName.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_bycompName.Name = "rdb_bycompName"
        Me.rdb_bycompName.Ripple = True
        Me.rdb_bycompName.Size = New System.Drawing.Size(146, 30)
        Me.rdb_bycompName.TabIndex = 11
        Me.rdb_bycompName.Text = "By Company Name"
        Me.rdb_bycompName.UseVisualStyleBackColor = True
        '
        'Dgv_Signatures
        '
        Me.Dgv_Signatures.AllowUserToAddRows = False
        Me.Dgv_Signatures.AllowUserToDeleteRows = False
        Me.Dgv_Signatures.AllowUserToResizeRows = False
        Me.Dgv_Signatures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Signatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Signatures.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Signatures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Signatures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv_Signatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Signatures.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dgv_Signatures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dgv_Signatures.GridColor = System.Drawing.Color.PowderBlue
        Me.Dgv_Signatures.Location = New System.Drawing.Point(13, 281)
        Me.Dgv_Signatures.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Dgv_Signatures.MultiSelect = False
        Me.Dgv_Signatures.Name = "Dgv_Signatures"
        Me.Dgv_Signatures.ReadOnly = True
        Me.Dgv_Signatures.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv_Signatures.RowHeadersVisible = False
        Me.Dgv_Signatures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Dgv_Signatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Signatures.Size = New System.Drawing.Size(679, 331)
        Me.Dgv_Signatures.TabIndex = 16
        '
        'SignatureReport
        '
        Me.SignatureReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignatureReport.Depth = 0
        Me.SignatureReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem})
        Me.SignatureReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.SignatureReport.Name = "SignatureReport"
        Me.SignatureReport.Size = New System.Drawing.Size(181, 48)
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportToolStripMenuItem.Text = "Reports"
        '
        'Frm_Signatures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 629)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.Dgv_Signatures)
        Me.Name = "Frm_Signatures"
        Me.Text = "Frm_SignatureManager"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Dgv_Signatures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SignatureReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Btn_ModSignature As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Brn_NewSignature As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Btn_DelSignature As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_bycname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_bycompid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_bycid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_bycompName As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Dgv_Signatures As DataGridView
    Friend WithEvents SignatureReport As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
