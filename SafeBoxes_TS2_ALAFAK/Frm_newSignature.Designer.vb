﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_newSignature
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
        Me.Txt_ArabicFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Btn_ArabicBrowse = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Btn_LatinBrowse = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Txt_LatinFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.client = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_clientid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_clientname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Chk_arb = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chk_lat = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txt_signc = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.signcontx = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectSignnatureCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.client.SuspendLayout()
        Me.signcontx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_ArabicFile
        '
        Me.Txt_ArabicFile.Depth = 0
        Me.Txt_ArabicFile.Enabled = False
        Me.Txt_ArabicFile.Hint = ""
        Me.Txt_ArabicFile.Location = New System.Drawing.Point(9, 166)
        Me.Txt_ArabicFile.MaxLength = 32767
        Me.Txt_ArabicFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ArabicFile.Name = "Txt_ArabicFile"
        Me.Txt_ArabicFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ArabicFile.SelectedText = ""
        Me.Txt_ArabicFile.SelectionLength = 0
        Me.Txt_ArabicFile.SelectionStart = 0
        Me.Txt_ArabicFile.Size = New System.Drawing.Size(204, 23)
        Me.Txt_ArabicFile.TabIndex = 0
        Me.Txt_ArabicFile.TabStop = False
        Me.Txt_ArabicFile.UseSystemPasswordChar = False
        '
        'Btn_ArabicBrowse
        '
        Me.Btn_ArabicBrowse.AutoSize = True
        Me.Btn_ArabicBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_ArabicBrowse.Depth = 0
        Me.Btn_ArabicBrowse.Enabled = False
        Me.Btn_ArabicBrowse.Icon = Nothing
        Me.Btn_ArabicBrowse.Location = New System.Drawing.Point(220, 153)
        Me.Btn_ArabicBrowse.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_ArabicBrowse.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_ArabicBrowse.Name = "Btn_ArabicBrowse"
        Me.Btn_ArabicBrowse.Primary = True
        Me.Btn_ArabicBrowse.Size = New System.Drawing.Size(76, 36)
        Me.Btn_ArabicBrowse.TabIndex = 2
        Me.Btn_ArabicBrowse.Text = "Browse"
        Me.Btn_ArabicBrowse.UseVisualStyleBackColor = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(228, 283)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 3
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Btn_LatinBrowse
        '
        Me.Btn_LatinBrowse.AutoSize = True
        Me.Btn_LatinBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_LatinBrowse.Depth = 0
        Me.Btn_LatinBrowse.Enabled = False
        Me.Btn_LatinBrowse.Icon = Nothing
        Me.Btn_LatinBrowse.Location = New System.Drawing.Point(220, 212)
        Me.Btn_LatinBrowse.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_LatinBrowse.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_LatinBrowse.Name = "Btn_LatinBrowse"
        Me.Btn_LatinBrowse.Primary = True
        Me.Btn_LatinBrowse.Size = New System.Drawing.Size(76, 36)
        Me.Btn_LatinBrowse.TabIndex = 6
        Me.Btn_LatinBrowse.Text = "Browse"
        Me.Btn_LatinBrowse.UseVisualStyleBackColor = True
        '
        'Txt_LatinFile
        '
        Me.Txt_LatinFile.Depth = 0
        Me.Txt_LatinFile.Enabled = False
        Me.Txt_LatinFile.Hint = ""
        Me.Txt_LatinFile.Location = New System.Drawing.Point(9, 225)
        Me.Txt_LatinFile.MaxLength = 32767
        Me.Txt_LatinFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_LatinFile.Name = "Txt_LatinFile"
        Me.Txt_LatinFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_LatinFile.SelectedText = ""
        Me.Txt_LatinFile.SelectionLength = 0
        Me.Txt_LatinFile.SelectionStart = 0
        Me.Txt_LatinFile.Size = New System.Drawing.Size(204, 23)
        Me.Txt_LatinFile.TabIndex = 4
        Me.Txt_LatinFile.TabStop = False
        Me.Txt_LatinFile.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.ContextMenuStrip = Me.client
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(9, 81)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel5.TabIndex = 61
        Me.MaterialLabel5.Text = "Client ID:"
        '
        'client
        '
        Me.client.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.client.Depth = 0
        Me.client.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem})
        Me.client.MouseState = MaterialSkin.MouseState.HOVER
        Me.client.Name = "MaterialContextMenuStrip1"
        Me.client.Size = New System.Drawing.Size(140, 26)
        '
        'SelectClientToolStripMenuItem
        '
        Me.SelectClientToolStripMenuItem.Name = "SelectClientToolStripMenuItem"
        Me.SelectClientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectClientToolStripMenuItem.Text = "Select Client"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(113, 81)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel1.TabIndex = 63
        Me.MaterialLabel1.Text = "Client Name:"
        '
        'txt_clientid
        '
        Me.txt_clientid.Depth = 0
        Me.txt_clientid.Hint = ""
        Me.txt_clientid.Location = New System.Drawing.Point(13, 105)
        Me.txt_clientid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_clientid.MaxLength = 32767
        Me.txt_clientid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_clientid.Name = "txt_clientid"
        Me.txt_clientid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_clientid.SelectedText = ""
        Me.txt_clientid.SelectionLength = 0
        Me.txt_clientid.SelectionStart = 0
        Me.txt_clientid.Size = New System.Drawing.Size(96, 23)
        Me.txt_clientid.TabIndex = 60
        Me.txt_clientid.TabStop = False
        Me.txt_clientid.UseSystemPasswordChar = False
        '
        'txt_clientname
        '
        Me.txt_clientname.Depth = 0
        Me.txt_clientname.Enabled = False
        Me.txt_clientname.Hint = ""
        Me.txt_clientname.Location = New System.Drawing.Point(117, 105)
        Me.txt_clientname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_clientname.MaxLength = 32767
        Me.txt_clientname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_clientname.Name = "txt_clientname"
        Me.txt_clientname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_clientname.SelectedText = ""
        Me.txt_clientname.SelectionLength = 0
        Me.txt_clientname.SelectionStart = 0
        Me.txt_clientname.Size = New System.Drawing.Size(175, 23)
        Me.txt_clientname.TabIndex = 62
        Me.txt_clientname.TabStop = False
        Me.txt_clientname.UseSystemPasswordChar = False
        '
        'Chk_arb
        '
        Me.Chk_arb.AutoSize = True
        Me.Chk_arb.Depth = 0
        Me.Chk_arb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Chk_arb.Location = New System.Drawing.Point(12, 137)
        Me.Chk_arb.Margin = New System.Windows.Forms.Padding(0)
        Me.Chk_arb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Chk_arb.MouseState = MaterialSkin.MouseState.HOVER
        Me.Chk_arb.Name = "Chk_arb"
        Me.Chk_arb.Ripple = True
        Me.Chk_arb.Size = New System.Drawing.Size(132, 30)
        Me.Chk_arb.TabIndex = 64
        Me.Chk_arb.Text = "Arabic Signature"
        Me.Chk_arb.UseVisualStyleBackColor = True
        '
        'chk_lat
        '
        Me.chk_lat.AutoSize = True
        Me.chk_lat.Depth = 0
        Me.chk_lat.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chk_lat.Location = New System.Drawing.Point(12, 197)
        Me.chk_lat.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_lat.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chk_lat.MouseState = MaterialSkin.MouseState.HOVER
        Me.chk_lat.Name = "chk_lat"
        Me.chk_lat.Ripple = True
        Me.chk_lat.Size = New System.Drawing.Size(127, 30)
        Me.chk_lat.TabIndex = 65
        Me.chk_lat.Text = "Latin Signature:"
        Me.chk_lat.UseVisualStyleBackColor = True
        '
        'txt_signc
        '
        Me.txt_signc.Depth = 0
        Me.txt_signc.Hint = ""
        Me.txt_signc.Location = New System.Drawing.Point(10, 286)
        Me.txt_signc.MaxLength = 32767
        Me.txt_signc.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_signc.Name = "txt_signc"
        Me.txt_signc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_signc.SelectedText = ""
        Me.txt_signc.SelectionLength = 0
        Me.txt_signc.SelectionStart = 0
        Me.txt_signc.Size = New System.Drawing.Size(135, 23)
        Me.txt_signc.TabIndex = 67
        Me.txt_signc.TabStop = False
        Me.txt_signc.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.ContextMenuStrip = Me.signcontx
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(5, 264)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel3.TabIndex = 69
        Me.MaterialLabel3.Text = "Sign Card Id:"
        '
        'signcontx
        '
        Me.signcontx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signcontx.Depth = 0
        Me.signcontx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectSignnatureCardToolStripMenuItem})
        Me.signcontx.MouseState = MaterialSkin.MouseState.HOVER
        Me.signcontx.Name = "MaterialContextMenuStrip2"
        Me.signcontx.Size = New System.Drawing.Size(187, 26)
        '
        'SelectSignnatureCardToolStripMenuItem
        '
        Me.SelectSignnatureCardToolStripMenuItem.Name = "SelectSignnatureCardToolStripMenuItem"
        Me.SelectSignnatureCardToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SelectSignnatureCardToolStripMenuItem.Text = "Select Signature Card"
        '
        'Frm_newSignature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(311, 331)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.txt_signc)
        Me.Controls.Add(Me.chk_lat)
        Me.Controls.Add(Me.Chk_arb)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txt_clientid)
        Me.Controls.Add(Me.txt_clientname)
        Me.Controls.Add(Me.Btn_LatinBrowse)
        Me.Controls.Add(Me.Txt_LatinFile)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Btn_ArabicBrowse)
        Me.Controls.Add(Me.Txt_ArabicFile)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_newSignature"
        Me.Sizable = False
        Me.Text = "New Signature"
        Me.client.ResumeLayout(False)
        Me.signcontx.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_ArabicFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Btn_ArabicBrowse As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Btn_LatinBrowse As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Txt_LatinFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_clientid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_clientname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Chk_arb As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chk_lat As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txt_signc As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents client As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents signcontx As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectSignnatureCardToolStripMenuItem As ToolStripMenuItem
End Class
