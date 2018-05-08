<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewEmployee
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
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_father = New System.Windows.Forms.TextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.lbl_Empid = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(28, 153)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel7.TabIndex = 55
        Me.MaterialLabel7.Text = "Last Name:"
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(32, 177)
        Me.txt_lname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(180, 20)
        Me.txt_lname.TabIndex = 54
        '
        'txt_father
        '
        Me.txt_father.Location = New System.Drawing.Point(32, 128)
        Me.txt_father.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_father.Name = "txt_father"
        Me.txt_father.Size = New System.Drawing.Size(180, 20)
        Me.txt_father.TabIndex = 53
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(28, 104)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(110, 19)
        Me.MaterialLabel6.TabIndex = 52
        Me.MaterialLabel6.Text = "Father's Name:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(28, 49)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel5.TabIndex = 51
        Me.MaterialLabel5.Text = "First Name:"
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(134, 212)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(112, 35)
        Me.btn_submit.TabIndex = 50
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(32, 73)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(180, 20)
        Me.txt_fname.TabIndex = 49
        '
        'lbl_Empid
        '
        Me.lbl_Empid.AutoSize = True
        Me.lbl_Empid.Depth = 0
        Me.lbl_Empid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_Empid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Empid.Location = New System.Drawing.Point(9, 9)
        Me.lbl_Empid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Empid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_Empid.Name = "lbl_Empid"
        Me.lbl_Empid.Size = New System.Drawing.Size(159, 19)
        Me.lbl_Empid.TabIndex = 48
        Me.lbl_Empid.Text = "Employee ID: <EmpId>"
        '
        'frm_NewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 261)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_father)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.lbl_Empid)
        Me.Name = "frm_NewEmployee"
        Me.Text = "frm_NewEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_father As TextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submit As Button
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents lbl_Empid As MaterialSkin.Controls.MaterialLabel
End Class
