<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InfoVoucher
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
        Me.dgv_infovouchers = New System.Windows.Forms.DataGridView()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_NewInfoResult = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_connects = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modinfovouch = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newinfovouch = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delinfovouch = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_byClientName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_byinfovouchid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_byInfovouchid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byClientName = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Reports = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.InfoVoucherReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoResultsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_infovouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Reports.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_infovouchers
        '
        Me.dgv_infovouchers.AllowUserToAddRows = False
        Me.dgv_infovouchers.AllowUserToDeleteRows = False
        Me.dgv_infovouchers.AllowUserToResizeRows = False
        Me.dgv_infovouchers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_infovouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_infovouchers.BackgroundColor = System.Drawing.Color.White
        Me.dgv_infovouchers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_infovouchers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_infovouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_infovouchers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_infovouchers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_infovouchers.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_infovouchers.Location = New System.Drawing.Point(13, 280)
        Me.dgv_infovouchers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_infovouchers.MultiSelect = False
        Me.dgv_infovouchers.Name = "dgv_infovouchers"
        Me.dgv_infovouchers.ReadOnly = True
        Me.dgv_infovouchers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_infovouchers.RowHeadersVisible = False
        Me.dgv_infovouchers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_infovouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_infovouchers.Size = New System.Drawing.Size(695, 254)
        Me.dgv_infovouchers.TabIndex = 10
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(720, 36)
        Me.MaterialTabSelector1.TabIndex = 22
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(14, 106)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(694, 171)
        Me.MaterialTabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialFlatButton1)
        Me.TabPage1.Controls.Add(Me.Btn_NewInfoResult)
        Me.TabPage1.Controls.Add(Me.btn_connects)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.btn_modinfovouch)
        Me.TabPage1.Controls.Add(Me.btn_newinfovouch)
        Me.TabPage1.Controls.Add(Me.btn_delinfovouch)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(686, 145)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(176, 101)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = True
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(113, 36)
        Me.MaterialFlatButton1.TabIndex = 9
        Me.MaterialFlatButton1.Text = "Info Results"
        '
        'Btn_NewInfoResult
        '
        Me.Btn_NewInfoResult.AutoSize = True
        Me.Btn_NewInfoResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_NewInfoResult.Depth = 0
        Me.Btn_NewInfoResult.Icon = Nothing
        Me.Btn_NewInfoResult.Location = New System.Drawing.Point(176, 67)
        Me.Btn_NewInfoResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_NewInfoResult.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_NewInfoResult.Name = "Btn_NewInfoResult"
        Me.Btn_NewInfoResult.Primary = True
        Me.Btn_NewInfoResult.Size = New System.Drawing.Size(137, 36)
        Me.Btn_NewInfoResult.TabIndex = 8
        Me.Btn_NewInfoResult.Text = "New Info Result"
        '
        'btn_connects
        '
        Me.btn_connects.AutoSize = True
        Me.btn_connects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_connects.Depth = 0
        Me.btn_connects.Icon = Nothing
        Me.btn_connects.Location = New System.Drawing.Point(176, 28)
        Me.btn_connects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_connects.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_connects.Name = "btn_connects"
        Me.btn_connects.Primary = True
        Me.btn_connects.Size = New System.Drawing.Size(84, 36)
        Me.btn_connects.TabIndex = 7
        Me.btn_connects.Text = "Connect"
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
        'btn_modinfovouch
        '
        Me.btn_modinfovouch.AutoSize = True
        Me.btn_modinfovouch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modinfovouch.Depth = 0
        Me.btn_modinfovouch.Icon = Nothing
        Me.btn_modinfovouch.Location = New System.Drawing.Point(7, 67)
        Me.btn_modinfovouch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modinfovouch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modinfovouch.Name = "btn_modinfovouch"
        Me.btn_modinfovouch.Primary = True
        Me.btn_modinfovouch.Size = New System.Drawing.Size(140, 36)
        Me.btn_modinfovouch.TabIndex = 2
        Me.btn_modinfovouch.Text = "Modify Selected"
        Me.btn_modinfovouch.UseVisualStyleBackColor = True
        '
        'btn_newinfovouch
        '
        Me.btn_newinfovouch.AutoSize = True
        Me.btn_newinfovouch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newinfovouch.Depth = 0
        Me.btn_newinfovouch.Icon = Nothing
        Me.btn_newinfovouch.Location = New System.Drawing.Point(7, 28)
        Me.btn_newinfovouch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newinfovouch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newinfovouch.Name = "btn_newinfovouch"
        Me.btn_newinfovouch.Primary = True
        Me.btn_newinfovouch.Size = New System.Drawing.Size(81, 36)
        Me.btn_newinfovouch.TabIndex = 0
        Me.btn_newinfovouch.Text = "Add new"
        Me.btn_newinfovouch.UseVisualStyleBackColor = True
        '
        'btn_delinfovouch
        '
        Me.btn_delinfovouch.AutoSize = True
        Me.btn_delinfovouch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delinfovouch.Depth = 0
        Me.btn_delinfovouch.Icon = Nothing
        Me.btn_delinfovouch.Location = New System.Drawing.Point(7, 106)
        Me.btn_delinfovouch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delinfovouch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delinfovouch.Name = "btn_delinfovouch"
        Me.btn_delinfovouch.Primary = True
        Me.btn_delinfovouch.Size = New System.Drawing.Size(138, 36)
        Me.btn_delinfovouch.TabIndex = 6
        Me.btn_delinfovouch.Text = "Delete Selected"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txt_byClientName)
        Me.TabPage2.Controls.Add(Me.rdb_byinfovouchid)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.txt_byInfovouchid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.rdb_byClientName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(686, 145)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'txt_byClientName
        '
        Me.txt_byClientName.Depth = 0
        Me.txt_byClientName.Enabled = False
        Me.txt_byClientName.Hint = ""
        Me.txt_byClientName.Location = New System.Drawing.Point(173, 62)
        Me.txt_byClientName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byClientName.MaxLength = 32767
        Me.txt_byClientName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byClientName.Name = "txt_byClientName"
        Me.txt_byClientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byClientName.SelectedText = ""
        Me.txt_byClientName.SelectionLength = 0
        Me.txt_byClientName.SelectionStart = 0
        Me.txt_byClientName.Size = New System.Drawing.Size(352, 23)
        Me.txt_byClientName.TabIndex = 14
        Me.txt_byClientName.TabStop = False
        Me.txt_byClientName.UseSystemPasswordChar = False
        '
        'rdb_byinfovouchid
        '
        Me.rdb_byinfovouchid.Depth = 0
        Me.rdb_byinfovouchid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byinfovouchid.Location = New System.Drawing.Point(7, 8)
        Me.rdb_byinfovouchid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byinfovouchid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byinfovouchid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byinfovouchid.Name = "rdb_byinfovouchid"
        Me.rdb_byinfovouchid.Ripple = True
        Me.rdb_byinfovouchid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byinfovouchid.TabIndex = 13
        Me.rdb_byinfovouchid.Text = "By Info Voucher ID"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(625, 92)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_byInfovouchid
        '
        Me.txt_byInfovouchid.Depth = 0
        Me.txt_byInfovouchid.Enabled = False
        Me.txt_byInfovouchid.Hint = ""
        Me.txt_byInfovouchid.Location = New System.Drawing.Point(173, 13)
        Me.txt_byInfovouchid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byInfovouchid.MaxLength = 32767
        Me.txt_byInfovouchid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byInfovouchid.Name = "txt_byInfovouchid"
        Me.txt_byInfovouchid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byInfovouchid.SelectedText = ""
        Me.txt_byInfovouchid.SelectionLength = 0
        Me.txt_byInfovouchid.SelectionStart = 0
        Me.txt_byInfovouchid.Size = New System.Drawing.Size(352, 23)
        Me.txt_byInfovouchid.TabIndex = 8
        Me.txt_byInfovouchid.TabStop = False
        Me.txt_byInfovouchid.UseSystemPasswordChar = False
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(528, 92)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byClientName
        '
        Me.rdb_byClientName.AutoSize = True
        Me.rdb_byClientName.Depth = 0
        Me.rdb_byClientName.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byClientName.Location = New System.Drawing.Point(7, 55)
        Me.rdb_byClientName.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byClientName.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byClientName.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byClientName.Name = "rdb_byClientName"
        Me.rdb_byClientName.Ripple = True
        Me.rdb_byClientName.Size = New System.Drawing.Size(123, 30)
        Me.rdb_byClientName.TabIndex = 11
        Me.rdb_byClientName.Text = "By Client Name"
        Me.rdb_byClientName.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.Reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Reports.Depth = 0
        Me.Reports.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoVoucherReportToolStripMenuItem, Me.ConnectsReportToolStripMenuItem, Me.InfoResultsReportToolStripMenuItem})
        Me.Reports.MouseState = MaterialSkin.MouseState.HOVER
        Me.Reports.Name = "MaterialContextMenuStrip1"
        Me.Reports.Size = New System.Drawing.Size(181, 92)
        Me.Reports.Text = "Reports"
        '
        'InfoVoucherReportToolStripMenuItem
        '
        Me.InfoVoucherReportToolStripMenuItem.Name = "InfoVoucherReportToolStripMenuItem"
        Me.InfoVoucherReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InfoVoucherReportToolStripMenuItem.Text = "InfoVoucher Report"
        '
        'ConnectsReportToolStripMenuItem
        '
        Me.ConnectsReportToolStripMenuItem.Name = "ConnectsReportToolStripMenuItem"
        Me.ConnectsReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectsReportToolStripMenuItem.Text = "Connects Report"
        '
        'InfoResultsReportToolStripMenuItem
        '
        Me.InfoResultsReportToolStripMenuItem.Name = "InfoResultsReportToolStripMenuItem"
        Me.InfoResultsReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InfoResultsReportToolStripMenuItem.Text = "Info Results Report"
        '
        'Frm_InfoVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 547)
        Me.ContextMenuStrip = Me.Reports
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgv_infovouchers)
        Me.Name = "Frm_InfoVoucher"
        Me.Text = "Info Voucher Management"
        CType(Me.dgv_infovouchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Reports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_infovouchers As DataGridView
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_connects As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modinfovouch As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newinfovouch As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delinfovouch As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_byClientName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_byinfovouchid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_byInfovouchid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byClientName As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Reports As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents InfoVoucherReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_NewInfoResult As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ConnectsReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents InfoResultsReportToolStripMenuItem As ToolStripMenuItem
End Class
