﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewSignatureCard
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
        Me.cbox_Nation = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_careers = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_signnote = New System.Windows.Forms.TextBox()
        Me.txt_cid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_signcardid = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cnam = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_contid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ClientSelector = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractSelector = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectContractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientSelector.SuspendLayout()
        Me.ContractSelector.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbox_Nation
        '
        Me.cbox_Nation.BackColor = System.Drawing.Color.White
        Me.cbox_Nation.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_Nation.ForeColor = System.Drawing.Color.Black
        Me.cbox_Nation.FormattingEnabled = True
        Me.cbox_Nation.Location = New System.Drawing.Point(344, 179)
        Me.cbox_Nation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_Nation.Name = "cbox_Nation"
        Me.cbox_Nation.Size = New System.Drawing.Size(154, 27)
        Me.cbox_Nation.TabIndex = 53
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(178, 155)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MaterialLabel2.TabIndex = 70
        Me.MaterialLabel2.Text = "Career*:"
        '
        'cbox_careers
        '
        Me.cbox_careers.BackColor = System.Drawing.Color.White
        Me.cbox_careers.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_careers.ForeColor = System.Drawing.Color.Black
        Me.cbox_careers.FormattingEnabled = True
        Me.cbox_careers.Location = New System.Drawing.Point(182, 179)
        Me.cbox_careers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_careers.Name = "cbox_careers"
        Me.cbox_careers.Size = New System.Drawing.Size(154, 27)
        Me.cbox_careers.TabIndex = 52
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(173, 104)
        Me.MaterialLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(102, 19)
        Me.MaterialLabel10.TabIndex = 68
        Me.MaterialLabel10.Text = "Client Name:*"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(17, 211)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(46, 19)
        Me.MaterialLabel9.TabIndex = 67
        Me.MaterialLabel9.Text = "Note:"
        '
        'txt_signnote
        '
        Me.txt_signnote.Location = New System.Drawing.Point(20, 235)
        Me.txt_signnote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_signnote.Multiline = True
        Me.txt_signnote.Name = "txt_signnote"
        Me.txt_signnote.Size = New System.Drawing.Size(477, 49)
        Me.txt_signnote.TabIndex = 57
        '
        'txt_cid
        '
        Me.txt_cid.Depth = 0
        Me.txt_cid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_cid.Hint = ""
        Me.txt_cid.Location = New System.Drawing.Point(20, 128)
        Me.txt_cid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cid.MaxLength = 32767
        Me.txt_cid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cid.SelectedText = ""
        Me.txt_cid.SelectionLength = 0
        Me.txt_cid.SelectionStart = 0
        Me.txt_cid.Size = New System.Drawing.Size(148, 23)
        Me.txt_cid.TabIndex = 48
        Me.txt_cid.TabStop = False
        Me.txt_cid.UseSystemPasswordChar = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.ContextMenuStrip = Me.ClientSelector
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(17, 104)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(76, 19)
        Me.MaterialLabel7.TabIndex = 66
        Me.MaterialLabel7.Text = "Client ID:*"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(340, 157)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(92, 19)
        Me.MaterialLabel3.TabIndex = 62
        Me.MaterialLabel3.Text = "Nationality*:"
        '
        'lbl_signcardid
        '
        Me.lbl_signcardid.AutoSize = True
        Me.lbl_signcardid.Depth = 0
        Me.lbl_signcardid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_signcardid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_signcardid.Location = New System.Drawing.Point(17, 70)
        Me.lbl_signcardid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_signcardid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_signcardid.Name = "lbl_signcardid"
        Me.lbl_signcardid.Size = New System.Drawing.Size(157, 19)
        Me.lbl_signcardid.TabIndex = 61
        Me.lbl_signcardid.Text = "SignatureCard ID: <Id>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 54
        '
        'txt_cnam
        '
        Me.txt_cnam.Depth = 0
        Me.txt_cnam.Enabled = False
        Me.txt_cnam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_cnam.Hint = ""
        Me.txt_cnam.Location = New System.Drawing.Point(176, 128)
        Me.txt_cnam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cnam.MaxLength = 32767
        Me.txt_cnam.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_cnam.Name = "txt_cnam"
        Me.txt_cnam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cnam.SelectedText = ""
        Me.txt_cnam.SelectionLength = 0
        Me.txt_cnam.SelectionStart = 0
        Me.txt_cnam.Size = New System.Drawing.Size(321, 23)
        Me.txt_cnam.TabIndex = 49
        Me.txt_cnam.TabStop = False
        Me.txt_cnam.UseSystemPasswordChar = False
        '
        'txt_contid
        '
        Me.txt_contid.Depth = 0
        Me.txt_contid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_contid.Hint = ""
        Me.txt_contid.Location = New System.Drawing.Point(20, 183)
        Me.txt_contid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_contid.MaxLength = 32767
        Me.txt_contid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_contid.Name = "txt_contid"
        Me.txt_contid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contid.SelectedText = ""
        Me.txt_contid.SelectionLength = 0
        Me.txt_contid.SelectionStart = 0
        Me.txt_contid.Size = New System.Drawing.Size(148, 23)
        Me.txt_contid.TabIndex = 73
        Me.txt_contid.TabStop = False
        Me.txt_contid.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.ContextMenuStrip = Me.ContractSelector
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(17, 159)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(95, 19)
        Me.MaterialLabel1.TabIndex = 74
        Me.MaterialLabel1.Text = "Contract ID:*"
        '
        'btn_submit
        '
        Me.btn_submit.AutoSize = True
        Me.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submit.Depth = 0
        Me.btn_submit.Icon = Nothing
        Me.btn_submit.Location = New System.Drawing.Point(427, 299)
        Me.btn_submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Primary = True
        Me.btn_submit.Size = New System.Drawing.Size(71, 36)
        Me.btn_submit.TabIndex = 79
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'ClientSelector
        '
        Me.ClientSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSelector.Depth = 0
        Me.ClientSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem})
        Me.ClientSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClientSelector.Name = "ClientSelector"
        Me.ClientSelector.Size = New System.Drawing.Size(140, 26)
        '
        'SelectClientToolStripMenuItem
        '
        Me.SelectClientToolStripMenuItem.Name = "SelectClientToolStripMenuItem"
        Me.SelectClientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectClientToolStripMenuItem.Text = "Select Client"
        '
        'ContractSelector
        '
        Me.ContractSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContractSelector.Depth = 0
        Me.ContractSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectContractToolStripMenuItem})
        Me.ContractSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.ContractSelector.Name = "ContractSelector"
        Me.ContractSelector.Size = New System.Drawing.Size(181, 48)
        '
        'SelectContractToolStripMenuItem
        '
        Me.SelectContractToolStripMenuItem.Name = "SelectContractToolStripMenuItem"
        Me.SelectContractToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectContractToolStripMenuItem.Text = "Select Contract"
        '
        'Frm_NewSignatureCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(510, 346)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_contid)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.cbox_Nation)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.cbox_careers)
        Me.Controls.Add(Me.txt_cnam)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.txt_signnote)
        Me.Controls.Add(Me.txt_cid)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.lbl_signcardid)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_NewSignatureCard"
        Me.Sizable = False
        Me.Text = "New Signature Card"
        Me.ClientSelector.ResumeLayout(False)
        Me.ContractSelector.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_Nation As ComboBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_careers As ComboBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_signnote As TextBox
    Friend WithEvents txt_cid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_signcardid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cnam As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_contid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ClientSelector As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContractSelector As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectContractToolStripMenuItem As ToolStripMenuItem
End Class
