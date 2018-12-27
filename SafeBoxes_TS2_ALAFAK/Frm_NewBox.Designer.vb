<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewBox
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
        Me.cbox_addsize = New System.Windows.Forms.ComboBox()
        Me.lbl_boxid = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'cbox_addsize
        '
        Me.cbox_addsize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbox_addsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_addsize.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_addsize.FormattingEnabled = True
        Me.cbox_addsize.Location = New System.Drawing.Point(13, 148)
        Me.cbox_addsize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbox_addsize.Name = "cbox_addsize"
        Me.cbox_addsize.Size = New System.Drawing.Size(301, 28)
        Me.cbox_addsize.TabIndex = 16
        '
        'lbl_boxid
        '
        Me.lbl_boxid.AutoSize = True
        Me.lbl_boxid.Depth = 0
        Me.lbl_boxid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_boxid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_boxid.Location = New System.Drawing.Point(9, 74)
        Me.lbl_boxid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_boxid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_boxid.Name = "lbl_boxid"
        Me.lbl_boxid.Size = New System.Drawing.Size(113, 19)
        Me.lbl_boxid.TabIndex = 25
        Me.lbl_boxid.Text = "Box ID: <BoxId>"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(9, 112)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(170, 19)
        Me.MaterialLabel1.TabIndex = 26
        Me.MaterialLabel1.Text = "Length x Width x Height:"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(243, 189)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 27
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Frm_NewBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(327, 237)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.lbl_boxid)
        Me.Controls.Add(Me.cbox_addsize)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_NewBox"
        Me.Sizable = False
        Me.Text = "New Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_addsize As ComboBox
    Friend WithEvents lbl_boxid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
End Class
