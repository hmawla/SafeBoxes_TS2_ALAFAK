<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewEmployee
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
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_lname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_father = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_fname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lbl_Empid = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(343, 110)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel7.TabIndex = 55
        Me.MaterialLabel7.Text = "Last Name:"
        '
        'txt_lname
        '
        Me.txt_lname.Depth = 0
        Me.txt_lname.Hint = ""
        Me.txt_lname.Location = New System.Drawing.Point(346, 136)
        Me.txt_lname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_lname.MaxLength = 32767
        Me.txt_lname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lname.SelectedText = ""
        Me.txt_lname.SelectionLength = 0
        Me.txt_lname.SelectionStart = 0
        Me.txt_lname.Size = New System.Drawing.Size(150, 23)
        Me.txt_lname.TabIndex = 54
        Me.txt_lname.TabStop = False
        Me.txt_lname.UseSystemPasswordChar = False
        '
        'txt_father
        '
        Me.txt_father.Depth = 0
        Me.txt_father.Hint = ""
        Me.txt_father.Location = New System.Drawing.Point(183, 136)
        Me.txt_father.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_father.MaxLength = 32767
        Me.txt_father.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_father.Name = "txt_father"
        Me.txt_father.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_father.SelectedText = ""
        Me.txt_father.SelectionLength = 0
        Me.txt_father.SelectionStart = 0
        Me.txt_father.Size = New System.Drawing.Size(151, 23)
        Me.txt_father.TabIndex = 53
        Me.txt_father.TabStop = False
        Me.txt_father.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(180, 110)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
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
        Me.MaterialLabel5.Location = New System.Drawing.Point(17, 110)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel5.TabIndex = 51
        Me.MaterialLabel5.Text = "First Name:"
        '
        'btn_submit
        '
        Me.btn_submit.AutoSize = True
        Me.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submit.Depth = 0
        Me.btn_submit.Icon = Nothing
        Me.btn_submit.Location = New System.Drawing.Point(425, 175)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Primary = False
        Me.btn_submit.Size = New System.Drawing.Size(71, 36)
        Me.btn_submit.TabIndex = 50
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'txt_fname
        '
        Me.txt_fname.Depth = 0
        Me.txt_fname.Hint = ""
        Me.txt_fname.Location = New System.Drawing.Point(20, 136)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_fname.MaxLength = 32767
        Me.txt_fname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_fname.SelectedText = ""
        Me.txt_fname.SelectionLength = 0
        Me.txt_fname.SelectionStart = 0
        Me.txt_fname.Size = New System.Drawing.Size(151, 23)
        Me.txt_fname.TabIndex = 49
        Me.txt_fname.TabStop = False
        Me.txt_fname.UseSystemPasswordChar = False
        '
        'lbl_Empid
        '
        Me.lbl_Empid.AutoSize = True
        Me.lbl_Empid.Depth = 0
        Me.lbl_Empid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_Empid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Empid.Location = New System.Drawing.Point(13, 76)
        Me.lbl_Empid.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lbl_Empid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_Empid.Name = "lbl_Empid"
        Me.lbl_Empid.Size = New System.Drawing.Size(159, 19)
        Me.lbl_Empid.TabIndex = 48
        Me.lbl_Empid.Text = "Employee ID: <EmpId>"
        '
        'Frm_NewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 226)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_father)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.lbl_Empid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_NewEmployee"
        Me.Text = "New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_lname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_father As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_fname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lbl_Empid As MaterialSkin.Controls.MaterialLabel
End Class
