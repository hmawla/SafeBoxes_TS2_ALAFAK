<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Boxes
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
        Me.RptV_Boxes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbox_boxsizes = New System.Windows.Forms.ComboBox()
        Me.Rdb_ByBoxSize = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Btn_Search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Txt_ByBoxId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Rdb_ByBoxId = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rpt_Boxes1 = New SafeBoxes_TS2_ALAFAK.Rpt_Boxes()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RptV_Boxes
        '
        Me.RptV_Boxes.ActiveViewIndex = 0
        Me.RptV_Boxes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RptV_Boxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RptV_Boxes.Cursor = System.Windows.Forms.Cursors.Default
        Me.RptV_Boxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RptV_Boxes.Location = New System.Drawing.Point(12, 188)
        Me.RptV_Boxes.Name = "RptV_Boxes"
        Me.RptV_Boxes.ReportSource = Me.Rpt_Boxes1
        Me.RptV_Boxes.Size = New System.Drawing.Size(685, 307)
        Me.RptV_Boxes.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbox_boxsizes)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByBoxSize)
        Me.GroupBox1.Controls.Add(Me.Btn_Search)
        Me.GroupBox1.Controls.Add(Me.Txt_ByBoxId)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByBoxId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 109)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cbox_boxsizes
        '
        Me.cbox_boxsizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_boxsizes.Enabled = False
        Me.cbox_boxsizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbox_boxsizes.FormattingEnabled = True
        Me.cbox_boxsizes.Location = New System.Drawing.Point(148, 64)
        Me.cbox_boxsizes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbox_boxsizes.Name = "cbox_boxsizes"
        Me.cbox_boxsizes.Size = New System.Drawing.Size(352, 26)
        Me.cbox_boxsizes.TabIndex = 25
        '
        'Rdb_ByBoxSize
        '
        Me.Rdb_ByBoxSize.AutoSize = True
        Me.Rdb_ByBoxSize.Depth = 0
        Me.Rdb_ByBoxSize.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByBoxSize.Location = New System.Drawing.Point(148, 28)
        Me.Rdb_ByBoxSize.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByBoxSize.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByBoxSize.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByBoxSize.Name = "Rdb_ByBoxSize"
        Me.Rdb_ByBoxSize.Ripple = True
        Me.Rdb_ByBoxSize.Size = New System.Drawing.Size(101, 30)
        Me.Rdb_ByBoxSize.TabIndex = 24
        Me.Rdb_ByBoxSize.Text = "By Box Size"
        Me.Rdb_ByBoxSize.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.AutoSize = True
        Me.Btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Search.Depth = 0
        Me.Btn_Search.Icon = Nothing
        Me.Btn_Search.Location = New System.Drawing.Point(599, 64)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Search.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Primary = False
        Me.Btn_Search.Size = New System.Drawing.Size(73, 36)
        Me.Btn_Search.TabIndex = 23
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Txt_ByBoxId
        '
        Me.Txt_ByBoxId.Depth = 0
        Me.Txt_ByBoxId.Hint = ""
        Me.Txt_ByBoxId.Location = New System.Drawing.Point(6, 68)
        Me.Txt_ByBoxId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ByBoxId.MaxLength = 32767
        Me.Txt_ByBoxId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ByBoxId.Name = "Txt_ByBoxId"
        Me.Txt_ByBoxId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ByBoxId.SelectedText = ""
        Me.Txt_ByBoxId.SelectionLength = 0
        Me.Txt_ByBoxId.SelectionStart = 0
        Me.Txt_ByBoxId.Size = New System.Drawing.Size(134, 23)
        Me.Txt_ByBoxId.TabIndex = 12
        Me.Txt_ByBoxId.TabStop = False
        Me.Txt_ByBoxId.UseSystemPasswordChar = False
        '
        'Rdb_ByBoxId
        '
        Me.Rdb_ByBoxId.AutoSize = True
        Me.Rdb_ByBoxId.Checked = True
        Me.Rdb_ByBoxId.Depth = 0
        Me.Rdb_ByBoxId.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByBoxId.Location = New System.Drawing.Point(6, 28)
        Me.Rdb_ByBoxId.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByBoxId.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByBoxId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByBoxId.Name = "Rdb_ByBoxId"
        Me.Rdb_ByBoxId.Ripple = True
        Me.Rdb_ByBoxId.Size = New System.Drawing.Size(87, 30)
        Me.Rdb_ByBoxId.TabIndex = 16
        Me.Rdb_ByBoxId.TabStop = True
        Me.Rdb_ByBoxId.Text = "By Box ID"
        Me.Rdb_ByBoxId.UseVisualStyleBackColor = True
        '
        'Frm_Report_Boxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 507)
        Me.Controls.Add(Me.RptV_Boxes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Report_Boxes"
        Me.Text = "Report Boxes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RptV_Boxes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_ByBoxId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Rdb_ByBoxId As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Btn_Search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cbox_boxsizes As ComboBox
    Friend WithEvents Rdb_ByBoxSize As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rpt_Boxes1 As Rpt_Boxes
End Class
