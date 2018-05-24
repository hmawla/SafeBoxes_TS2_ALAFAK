<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox
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
        Me.Btn_OK = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Lbl_Message = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_No = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Btn_Yes = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'Btn_OK
        '
        Me.Btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_OK.AutoSize = True
        Me.Btn_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_OK.Depth = 0
        Me.Btn_OK.Icon = Nothing
        Me.Btn_OK.Location = New System.Drawing.Point(288, 162)
        Me.Btn_OK.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Primary = True
        Me.Btn_OK.Size = New System.Drawing.Size(39, 36)
        Me.Btn_OK.TabIndex = 0
        Me.Btn_OK.Text = "ok"
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
        Me.Lbl_Message.Location = New System.Drawing.Point(12, 78)
        Me.Lbl_Message.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Lbl_Message.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_Message.Name = "Lbl_Message"
        Me.Lbl_Message.Size = New System.Drawing.Size(70, 19)
        Me.Lbl_Message.TabIndex = 1
        Me.Lbl_Message.Text = "Message"
        '
        'Btn_No
        '
        Me.Btn_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_No.AutoSize = True
        Me.Btn_No.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_No.Depth = 0
        Me.Btn_No.Icon = Nothing
        Me.Btn_No.Location = New System.Drawing.Point(242, 162)
        Me.Btn_No.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_No.Name = "Btn_No"
        Me.Btn_No.Primary = True
        Me.Btn_No.Size = New System.Drawing.Size(40, 36)
        Me.Btn_No.TabIndex = 2
        Me.Btn_No.Text = "no"
        Me.Btn_No.UseVisualStyleBackColor = True
        Me.Btn_No.Visible = False
        '
        'Btn_Yes
        '
        Me.Btn_Yes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Yes.AutoSize = True
        Me.Btn_Yes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Yes.Depth = 0
        Me.Btn_Yes.Icon = Nothing
        Me.Btn_Yes.Location = New System.Drawing.Point(288, 162)
        Me.Btn_Yes.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Yes.Name = "Btn_Yes"
        Me.Btn_Yes.Primary = True
        Me.Btn_Yes.Size = New System.Drawing.Size(45, 36)
        Me.Btn_Yes.TabIndex = 3
        Me.Btn_Yes.Text = "Yes"
        Me.Btn_Yes.UseVisualStyleBackColor = True
        Me.Btn_Yes.Visible = False
        '
        'MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 210)
        Me.Controls.Add(Me.Btn_Yes)
        Me.Controls.Add(Me.Btn_No)
        Me.Controls.Add(Me.Lbl_Message)
        Me.Controls.Add(Me.Btn_OK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageBox"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_OK As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Lbl_Message As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Btn_No As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Btn_Yes As MaterialSkin.Controls.MaterialRaisedButton
End Class
