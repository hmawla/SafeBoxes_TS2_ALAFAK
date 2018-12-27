<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_MissingKeys
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
        Me.Txt_ByContId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Dtpick_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Rdb_ByDate = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rdb_ByContId = New MaterialSkin.Controls.MaterialRadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Chk_Delivered = New MaterialSkin.Controls.MaterialCheckBox()
        Me.RptV_MissingKeys = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_ByContId
        '
        Me.Txt_ByContId.Depth = 0
        Me.Txt_ByContId.Enabled = False
        Me.Txt_ByContId.Hint = ""
        Me.Txt_ByContId.Location = New System.Drawing.Point(6, 57)
        Me.Txt_ByContId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ByContId.MaxLength = 32767
        Me.Txt_ByContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ByContId.Name = "Txt_ByContId"
        Me.Txt_ByContId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ByContId.SelectedText = ""
        Me.Txt_ByContId.SelectionLength = 0
        Me.Txt_ByContId.SelectionStart = 0
        Me.Txt_ByContId.Size = New System.Drawing.Size(234, 23)
        Me.Txt_ByContId.TabIndex = 12
        Me.Txt_ByContId.TabStop = False
        Me.Txt_ByContId.UseSystemPasswordChar = False
        '
        'Dtpick_ToDate
        '
        Me.Dtpick_ToDate.CustomFormat = "dd/mm/yyyy"
        Me.Dtpick_ToDate.Enabled = False
        Me.Dtpick_ToDate.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Dtpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpick_ToDate.Location = New System.Drawing.Point(466, 55)
        Me.Dtpick_ToDate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Dtpick_ToDate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.Dtpick_ToDate.Name = "Dtpick_ToDate"
        Me.Dtpick_ToDate.Size = New System.Drawing.Size(204, 27)
        Me.Dtpick_ToDate.TabIndex = 10
        '
        'Dtpick_FromDate
        '
        Me.Dtpick_FromDate.CustomFormat = "dd/mm/yyyy"
        Me.Dtpick_FromDate.Enabled = False
        Me.Dtpick_FromDate.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Dtpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpick_FromDate.Location = New System.Drawing.Point(250, 55)
        Me.Dtpick_FromDate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Dtpick_FromDate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.Dtpick_FromDate.Name = "Dtpick_FromDate"
        Me.Dtpick_FromDate.Size = New System.Drawing.Size(204, 27)
        Me.Dtpick_FromDate.TabIndex = 11
        '
        'Rdb_ByDate
        '
        Me.Rdb_ByDate.AutoSize = True
        Me.Rdb_ByDate.Depth = 0
        Me.Rdb_ByDate.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByDate.Location = New System.Drawing.Point(250, 25)
        Me.Rdb_ByDate.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByDate.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByDate.Name = "Rdb_ByDate"
        Me.Rdb_ByDate.Ripple = True
        Me.Rdb_ByDate.Size = New System.Drawing.Size(149, 30)
        Me.Rdb_ByDate.TabIndex = 15
        Me.Rdb_ByDate.Text = "By Date (FROM-TO)"
        Me.Rdb_ByDate.UseVisualStyleBackColor = True
        '
        'Rdb_ByContId
        '
        Me.Rdb_ByContId.AutoSize = True
        Me.Rdb_ByContId.Checked = True
        Me.Rdb_ByContId.Depth = 0
        Me.Rdb_ByContId.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByContId.Location = New System.Drawing.Point(6, 25)
        Me.Rdb_ByContId.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByContId.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByContId.Name = "Rdb_ByContId"
        Me.Rdb_ByContId.Ripple = True
        Me.Rdb_ByContId.Size = New System.Drawing.Size(117, 30)
        Me.Rdb_ByContId.TabIndex = 16
        Me.Rdb_ByContId.TabStop = True
        Me.Rdb_ByContId.Text = "By Contract ID"
        Me.Rdb_ByContId.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Btn_Search)
        Me.GroupBox1.Controls.Add(Me.Chk_Delivered)
        Me.GroupBox1.Controls.Add(Me.Txt_ByContId)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByDate)
        Me.GroupBox1.Controls.Add(Me.Dtpick_ToDate)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByContId)
        Me.GroupBox1.Controls.Add(Me.Dtpick_FromDate)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 134)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.AutoSize = True
        Me.Btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Search.Depth = 0
        Me.Btn_Search.Icon = Nothing
        Me.Btn_Search.Location = New System.Drawing.Point(599, 98)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Search.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Primary = True
        Me.Btn_Search.Size = New System.Drawing.Size(73, 36)
        Me.Btn_Search.TabIndex = 19
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Chk_Delivered
        '
        Me.Chk_Delivered.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_Delivered.AutoSize = True
        Me.Chk_Delivered.Depth = 0
        Me.Chk_Delivered.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Chk_Delivered.Location = New System.Drawing.Point(493, 104)
        Me.Chk_Delivered.Margin = New System.Windows.Forms.Padding(0)
        Me.Chk_Delivered.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Chk_Delivered.MouseState = MaterialSkin.MouseState.HOVER
        Me.Chk_Delivered.Name = "Chk_Delivered"
        Me.Chk_Delivered.Ripple = True
        Me.Chk_Delivered.Size = New System.Drawing.Size(87, 30)
        Me.Chk_Delivered.TabIndex = 17
        Me.Chk_Delivered.Text = "Delivered"
        Me.Chk_Delivered.UseVisualStyleBackColor = True
        '
        'RptV_MissingKeys
        '
        Me.RptV_MissingKeys.ActiveViewIndex = -1
        Me.RptV_MissingKeys.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RptV_MissingKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RptV_MissingKeys.Cursor = System.Windows.Forms.Cursors.Default
        Me.RptV_MissingKeys.Location = New System.Drawing.Point(12, 218)
        Me.RptV_MissingKeys.Name = "RptV_MissingKeys"
        Me.RptV_MissingKeys.Size = New System.Drawing.Size(685, 277)
        Me.RptV_MissingKeys.TabIndex = 18
        '
        'Frm_Report_MissingKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(709, 507)
        Me.Controls.Add(Me.RptV_MissingKeys)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Report_MissingKeys"
        Me.Text = "Report Missing Keys"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Txt_ByContId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Dtpick_ToDate As DateTimePicker
    Friend WithEvents Dtpick_FromDate As DateTimePicker
    Friend WithEvents Rdb_ByDate As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rdb_ByContId As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Chk_Delivered As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents RptV_MissingKeys As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btn_Search As MaterialSkin.Controls.MaterialFlatButton
End Class
