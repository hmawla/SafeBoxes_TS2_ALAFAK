<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_empid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_login = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'txt_empid
        '
        Me.txt_empid.Depth = 0
        Me.txt_empid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_empid.Hint = ""
        Me.txt_empid.Location = New System.Drawing.Point(68, 102)
        Me.txt_empid.MaxLength = 32767
        Me.txt_empid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_empid.SelectedText = ""
        Me.txt_empid.SelectionLength = 0
        Me.txt_empid.SelectionStart = 0
        Me.txt_empid.Size = New System.Drawing.Size(61, 23)
        Me.txt_empid.TabIndex = 3
        Me.txt_empid.TabStop = False
        Me.txt_empid.Text = "1"
        Me.txt_empid.UseSystemPasswordChar = False
        '
        'btn_login
        '
        Me.btn_login.AutoSize = True
        Me.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_login.Depth = 0
        Me.btn_login.Icon = Nothing
        Me.btn_login.Location = New System.Drawing.Point(68, 131)
        Me.btn_login.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Primary = True
        Me.btn_login.Size = New System.Drawing.Size(61, 36)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(204, 179)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_empid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.Sizable = False
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_empid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_login As MaterialSkin.Controls.MaterialRaisedButton
End Class
