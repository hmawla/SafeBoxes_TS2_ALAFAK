<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NewCompany
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
        Me.components = New System.ComponentModel.Container()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.SelectRep = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectRepresentativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_compname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lbl_compid = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_comptypes = New System.Windows.Forms.ComboBox()
        Me.SelectRep.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(272, 112)
        Me.MaterialLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel8.TabIndex = 65
        Me.MaterialLabel8.Text = "Company Type:"
        '
        'SelectRep
        '
        Me.SelectRep.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectRepresentativeToolStripMenuItem})
        Me.SelectRep.Name = "SelectRep"
        Me.SelectRep.Size = New System.Drawing.Size(186, 26)
        '
        'SelectRepresentativeToolStripMenuItem
        '
        Me.SelectRepresentativeToolStripMenuItem.Name = "SelectRepresentativeToolStripMenuItem"
        Me.SelectRepresentativeToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SelectRepresentativeToolStripMenuItem.Text = "Select Representative"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(11, 110)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(120, 19)
        Me.MaterialLabel5.TabIndex = 51
        Me.MaterialLabel5.Text = "Company Name:"
        '
        'btn_submit
        '
        Me.btn_submit.AutoSize = True
        Me.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submit.Depth = 0
        Me.btn_submit.Icon = Nothing
        Me.btn_submit.Location = New System.Drawing.Point(418, 170)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Primary = False
        Me.btn_submit.Size = New System.Drawing.Size(71, 36)
        Me.btn_submit.TabIndex = 50
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'txt_compname
        '
        Me.txt_compname.Depth = 0
        Me.txt_compname.Hint = ""
        Me.txt_compname.Location = New System.Drawing.Point(15, 134)
        Me.txt_compname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_compname.MaxLength = 32767
        Me.txt_compname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_compname.Name = "txt_compname"
        Me.txt_compname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_compname.SelectedText = ""
        Me.txt_compname.SelectionLength = 0
        Me.txt_compname.SelectionStart = 0
        Me.txt_compname.Size = New System.Drawing.Size(252, 23)
        Me.txt_compname.TabIndex = 49
        Me.txt_compname.TabStop = False
        Me.txt_compname.UseSystemPasswordChar = False
        '
        'lbl_compid
        '
        Me.lbl_compid.AutoSize = True
        Me.lbl_compid.Depth = 0
        Me.lbl_compid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_compid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_compid.Location = New System.Drawing.Point(11, 73)
        Me.lbl_compid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_compid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_compid.Name = "lbl_compid"
        Me.lbl_compid.Size = New System.Drawing.Size(166, 19)
        Me.lbl_compid.TabIndex = 48
        Me.lbl_compid.Text = "Company ID: <CompId>"
        '
        'cbox_comptypes
        '
        Me.cbox_comptypes.BackColor = System.Drawing.Color.White
        Me.cbox_comptypes.ForeColor = System.Drawing.Color.Black
        Me.cbox_comptypes.FormattingEnabled = True
        Me.cbox_comptypes.Location = New System.Drawing.Point(275, 134)
        Me.cbox_comptypes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_comptypes.Name = "cbox_comptypes"
        Me.cbox_comptypes.Size = New System.Drawing.Size(274, 28)
        Me.cbox_comptypes.TabIndex = 64
        '
        'Frm_NewCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 222)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.cbox_comptypes)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_compname)
        Me.Controls.Add(Me.lbl_compid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_NewCompany"
        Me.Text = "New Company"
        Me.SelectRep.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_compname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lbl_compid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_comptypes As ComboBox
    Friend WithEvents SelectRep As ContextMenuStrip
    Friend WithEvents SelectRepresentativeToolStripMenuItem As ToolStripMenuItem
End Class
