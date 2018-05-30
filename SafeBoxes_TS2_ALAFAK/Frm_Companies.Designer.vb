<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Companies
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
        Me.dgv_companies = New System.Windows.Forms.DataGridView()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modcompany = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newcompany = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delcompany = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_bycname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_bycompid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_bycid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_bycompName = New MaterialSkin.Controls.MaterialRadioButton()
        Me.CompaniesReport = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_companies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.CompaniesReport.SuspendLayout()
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
        Me.dgv_companies.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_companies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_companies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_companies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_companies.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_companies.Location = New System.Drawing.Point(13, 283)
        Me.dgv_companies.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_companies.MultiSelect = False
        Me.dgv_companies.Name = "dgv_companies"
        Me.dgv_companies.ReadOnly = True
        Me.dgv_companies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_companies.RowHeadersVisible = False
        Me.dgv_companies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_companies.Size = New System.Drawing.Size(733, 260)
        Me.dgv_companies.TabIndex = 12
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(759, 36)
        Me.MaterialTabSelector1.TabIndex = 14
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 106)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(734, 166)
        Me.MaterialTabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.btn_modcompany)
        Me.TabPage1.Controls.Add(Me.btn_newcompany)
        Me.TabPage1.Controls.Add(Me.btn_delcompany)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 133)
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
        'btn_modcompany
        '
        Me.btn_modcompany.AutoSize = True
        Me.btn_modcompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modcompany.Depth = 0
        Me.btn_modcompany.Icon = Nothing
        Me.btn_modcompany.Location = New System.Drawing.Point(7, 67)
        Me.btn_modcompany.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modcompany.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modcompany.Name = "btn_modcompany"
        Me.btn_modcompany.Primary = True
        Me.btn_modcompany.Size = New System.Drawing.Size(140, 36)
        Me.btn_modcompany.TabIndex = 2
        Me.btn_modcompany.Text = "Modify Selected"
        Me.btn_modcompany.UseVisualStyleBackColor = True
        '
        'btn_newcompany
        '
        Me.btn_newcompany.AutoSize = True
        Me.btn_newcompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newcompany.Depth = 0
        Me.btn_newcompany.Icon = Nothing
        Me.btn_newcompany.Location = New System.Drawing.Point(7, 28)
        Me.btn_newcompany.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newcompany.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newcompany.Name = "btn_newcompany"
        Me.btn_newcompany.Primary = True
        Me.btn_newcompany.Size = New System.Drawing.Size(81, 36)
        Me.btn_newcompany.TabIndex = 0
        Me.btn_newcompany.Text = "Add new"
        Me.btn_newcompany.UseVisualStyleBackColor = True
        '
        'btn_delcompany
        '
        Me.btn_delcompany.AutoSize = True
        Me.btn_delcompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delcompany.Depth = 0
        Me.btn_delcompany.Icon = Nothing
        Me.btn_delcompany.Location = New System.Drawing.Point(7, 106)
        Me.btn_delcompany.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delcompany.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delcompany.Name = "btn_delcompany"
        Me.btn_delcompany.Primary = True
        Me.btn_delcompany.Size = New System.Drawing.Size(138, 36)
        Me.btn_delcompany.TabIndex = 6
        Me.btn_delcompany.Text = "Delete Selected"
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(726, 133)
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
        Me.btn_reset.Location = New System.Drawing.Point(681, 92)
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
        Me.btn_search.Location = New System.Drawing.Point(584, 92)
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
        'CompaniesReport
        '
        Me.CompaniesReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompaniesReport.Depth = 0
        Me.CompaniesReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.CompaniesReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.CompaniesReport.Name = "CompaniesReport"
        Me.CompaniesReport.Size = New System.Drawing.Size(181, 48)
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'Frm_Companies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 569)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgv_companies)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Companies"
        Me.Text = "Companies Management"
        CType(Me.dgv_companies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.CompaniesReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_companies As DataGridView
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modcompany As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newcompany As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delcompany As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_bycname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_bycompid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_bycid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_bycompName As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents CompaniesReport As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
End Class
