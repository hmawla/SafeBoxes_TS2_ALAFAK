<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

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
        Me.txt_empid = New System.Windows.Forms.TextBox()
        Me.txt_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_empid
        '
        Me.txt_empid.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empid.Location = New System.Drawing.Point(22, 39)
        Me.txt_empid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.Size = New System.Drawing.Size(148, 27)
        Me.txt_empid.TabIndex = 0
        Me.txt_empid.Text = "1"
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(42, 74)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(112, 35)
        Me.txt_login.TabIndex = 1
        Me.txt_login.Text = "Login"
        Me.txt_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(193, 131)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.txt_empid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_empid As TextBox
    Friend WithEvents txt_login As Button
    Friend WithEvents Label1 As Label
End Class
