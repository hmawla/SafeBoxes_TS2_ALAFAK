<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Client
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
        Me.CRptV_Clients = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_cname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_CId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rdb_ByClientId = New MaterialSkin.Controls.MaterialRadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRptV_Clients
        '
        Me.CRptV_Clients.ActiveViewIndex = -1
        Me.CRptV_Clients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRptV_Clients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRptV_Clients.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRptV_Clients.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRptV_Clients.Location = New System.Drawing.Point(15, 215)
        Me.CRptV_Clients.Name = "CRptV_Clients"
        Me.CRptV_Clients.Size = New System.Drawing.Size(688, 365)
        Me.CRptV_Clients.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Btn_Search)
        Me.GroupBox1.Controls.Add(Me.txt_cname)
        Me.GroupBox1.Controls.Add(Me.Txt_CId)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByClientId)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 134)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Btn_Search
        '
        Me.Btn_Search.AutoSize = True
        Me.Btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Search.Depth = 0
        Me.Btn_Search.Icon = Nothing
        Me.Btn_Search.Location = New System.Drawing.Point(608, 89)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Search.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Primary = True
        Me.Btn_Search.Size = New System.Drawing.Size(73, 36)
        Me.Btn_Search.TabIndex = 19
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'txt_cname
        '
        Me.txt_cname.Depth = 0
        Me.txt_cname.Enabled = False
        Me.txt_cname.Hint = ""
        Me.txt_cname.Location = New System.Drawing.Point(250, 57)
        Me.txt_cname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cname.MaxLength = 32767
        Me.txt_cname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cname.SelectedText = ""
        Me.txt_cname.SelectionLength = 0
        Me.txt_cname.SelectionStart = 0
        Me.txt_cname.Size = New System.Drawing.Size(234, 23)
        Me.txt_cname.TabIndex = 18
        Me.txt_cname.TabStop = False
        Me.txt_cname.UseSystemPasswordChar = False
        '
        'Txt_CId
        '
        Me.Txt_CId.Depth = 0
        Me.Txt_CId.Hint = ""
        Me.Txt_CId.Location = New System.Drawing.Point(6, 57)
        Me.Txt_CId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_CId.MaxLength = 32767
        Me.Txt_CId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_CId.Name = "Txt_CId"
        Me.Txt_CId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_CId.SelectedText = ""
        Me.Txt_CId.SelectionLength = 0
        Me.Txt_CId.SelectionStart = 0
        Me.Txt_CId.Size = New System.Drawing.Size(234, 23)
        Me.Txt_CId.TabIndex = 12
        Me.Txt_CId.TabStop = False
        Me.Txt_CId.UseSystemPasswordChar = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Depth = 0
        Me.RadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(250, 25)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Ripple = True
        Me.RadioButton2.Size = New System.Drawing.Size(123, 30)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.Text = "By Client Name"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Rdb_ByClientId
        '
        Me.Rdb_ByClientId.AutoSize = True
        Me.Rdb_ByClientId.Checked = True
        Me.Rdb_ByClientId.Depth = 0
        Me.Rdb_ByClientId.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByClientId.Location = New System.Drawing.Point(6, 25)
        Me.Rdb_ByClientId.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByClientId.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByClientId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByClientId.Name = "Rdb_ByClientId"
        Me.Rdb_ByClientId.Ripple = True
        Me.Rdb_ByClientId.Size = New System.Drawing.Size(100, 30)
        Me.Rdb_ByClientId.TabIndex = 16
        Me.Rdb_ByClientId.TabStop = True
        Me.Rdb_ByClientId.Text = "By Client ID"
        Me.Rdb_ByClientId.UseVisualStyleBackColor = True
        '
        'Frm_Report_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 592)
        Me.Controls.Add(Me.CRptV_Clients)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Report_Client"
        Me.Text = "Report Client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRptV_Clients As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_CId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rdb_ByClientId As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txt_cname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Btn_Search As MaterialSkin.Controls.MaterialFlatButton
End Class
