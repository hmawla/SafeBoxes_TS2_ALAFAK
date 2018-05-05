<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_main
    Inherits Form

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
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_newclient = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txt_empid = New System.Windows.Forms.TextBox()
        Me.lbl_empid = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submitemp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(13, 73)
        Me.MaterialRaisedButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(126, 36)
        Me.MaterialRaisedButton1.TabIndex = 0
        Me.MaterialRaisedButton1.Text = "New Contract"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'btn_newclient
        '
        Me.btn_newclient.AutoSize = True
        Me.btn_newclient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newclient.Depth = 0
        Me.btn_newclient.Icon = Nothing
        Me.btn_newclient.Location = New System.Drawing.Point(211, 73)
        Me.btn_newclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newclient.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newclient.Name = "btn_newclient"
        Me.btn_newclient.Primary = True
        Me.btn_newclient.Size = New System.Drawing.Size(100, 36)
        Me.btn_newclient.TabIndex = 2
        Me.btn_newclient.Text = "New Client"
        Me.btn_newclient.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(370, 73)
        Me.MaterialRaisedButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(120, 36)
        Me.MaterialRaisedButton2.TabIndex = 3
        Me.MaterialRaisedButton2.Text = "New Company"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.AutoSize = True
        Me.MaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Icon = Nothing
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(559, 73)
        Me.MaterialRaisedButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(134, 36)
        Me.MaterialRaisedButton3.TabIndex = 4
        Me.MaterialRaisedButton3.Text = "New Info Vouch"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'txt_empid
        '
        Me.txt_empid.Location = New System.Drawing.Point(13, 33)
        Me.txt_empid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.Size = New System.Drawing.Size(148, 26)
        Me.txt_empid.TabIndex = 5
        '
        'lbl_empid
        '
        Me.lbl_empid.AutoSize = True
        Me.lbl_empid.Depth = 0
        Me.lbl_empid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_empid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_empid.Location = New System.Drawing.Point(9, 9)
        Me.lbl_empid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_empid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_empid.Name = "lbl_empid"
        Me.lbl_empid.Size = New System.Drawing.Size(97, 19)
        Me.lbl_empid.TabIndex = 54
        Me.lbl_empid.Text = "Employee ID:"
        '
        'btn_submitemp
        '
        Me.btn_submitemp.Location = New System.Drawing.Point(168, 30)
        Me.btn_submitemp.Name = "btn_submitemp"
        Me.btn_submitemp.Size = New System.Drawing.Size(89, 32)
        Me.btn_submitemp.TabIndex = 55
        Me.btn_submitemp.Text = "Set"
        Me.btn_submitemp.UseVisualStyleBackColor = True
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 360)
        Me.Controls.Add(Me.btn_submitemp)
        Me.Controls.Add(Me.lbl_empid)
        Me.Controls.Add(Me.txt_empid)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.btn_newclient)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_newclient As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txt_empid As TextBox
    Friend WithEvents lbl_empid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submitemp As Button
End Class
