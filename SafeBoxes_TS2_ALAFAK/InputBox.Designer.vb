<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBox
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
        Me.Txt_Input = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Btn_OK = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Lbl_Message = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'Txt_Input
        '
        Me.Txt_Input.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_Input.Depth = 0
        Me.Txt_Input.Hint = ""
        Me.Txt_Input.Location = New System.Drawing.Point(12, 153)
        Me.Txt_Input.MaxLength = 32767
        Me.Txt_Input.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_Input.Name = "Txt_Input"
        Me.Txt_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Input.SelectedText = ""
        Me.Txt_Input.SelectionLength = 0
        Me.Txt_Input.SelectionStart = 0
        Me.Txt_Input.Size = New System.Drawing.Size(266, 23)
        Me.Txt_Input.TabIndex = 0
        Me.Txt_Input.TabStop = False
        Me.Txt_Input.UseSystemPasswordChar = False
        '
        'Btn_OK
        '
        Me.Btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_OK.AutoSize = True
        Me.Btn_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_OK.Depth = 0
        Me.Btn_OK.Icon = Nothing
        Me.Btn_OK.Location = New System.Drawing.Point(287, 140)
        Me.Btn_OK.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Primary = True
        Me.Btn_OK.Size = New System.Drawing.Size(39, 36)
        Me.Btn_OK.TabIndex = 1
        Me.Btn_OK.Text = "Ok"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Lbl_Message
        '
        Me.Lbl_Message.AutoEllipsis = True
        Me.Lbl_Message.AutoSize = True
        Me.Lbl_Message.BackColor = System.Drawing.Color.White
        Me.Lbl_Message.Depth = 0
        Me.Lbl_Message.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_Message.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_Message.Location = New System.Drawing.Point(12, 75)
        Me.Lbl_Message.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Lbl_Message.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_Message.Name = "Lbl_Message"
        Me.Lbl_Message.Size = New System.Drawing.Size(70, 19)
        Me.Lbl_Message.TabIndex = 2
        Me.Lbl_Message.Text = "Message"
        '
        'InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 188)
        Me.Controls.Add(Me.Lbl_Message)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.Txt_Input)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBox"
        Me.Sizable = False
        Me.Text = "InputBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Input As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Btn_OK As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Lbl_Message As MaterialSkin.Controls.MaterialLabel
End Class
