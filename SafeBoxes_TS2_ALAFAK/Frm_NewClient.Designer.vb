<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewClient
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
        Me.lbl_cid = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_father = New System.Windows.Forms.TextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_mother = New System.Windows.Forms.TextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpick_birth = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_rnumber = New System.Windows.Forms.TextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_pbnumber = New System.Windows.Forms.TextBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_cid
        '
        Me.lbl_cid.AutoSize = True
        Me.lbl_cid.Depth = 0
        Me.lbl_cid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_cid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_cid.Location = New System.Drawing.Point(15, 9)
        Me.lbl_cid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_cid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_cid.Name = "lbl_cid"
        Me.lbl_cid.Size = New System.Drawing.Size(141, 19)
        Me.lbl_cid.TabIndex = 24
        Me.lbl_cid.Text = "Client ID: <ClientId>"
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(19, 70)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(148, 26)
        Me.txt_fname.TabIndex = 0
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(212, 271)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(112, 35)
        Me.btn_submit.TabIndex = 8
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(15, 46)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel5.TabIndex = 31
        Me.MaterialLabel5.Text = "First Name:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(15, 101)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(110, 19)
        Me.MaterialLabel6.TabIndex = 32
        Me.MaterialLabel6.Text = "Father's Name:"
        '
        'txt_father
        '
        Me.txt_father.Location = New System.Drawing.Point(19, 125)
        Me.txt_father.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_father.Name = "txt_father"
        Me.txt_father.Size = New System.Drawing.Size(148, 26)
        Me.txt_father.TabIndex = 2
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(171, 46)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel7.TabIndex = 35
        Me.MaterialLabel7.Text = "Last Name:"
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(175, 70)
        Me.txt_lname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(148, 26)
        Me.txt_lname.TabIndex = 1
        '
        'txt_mother
        '
        Me.txt_mother.Location = New System.Drawing.Point(175, 125)
        Me.txt_mother.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_mother.Name = "txt_mother"
        Me.txt_mother.Size = New System.Drawing.Size(148, 26)
        Me.txt_mother.TabIndex = 3
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(171, 101)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(116, 19)
        Me.MaterialLabel1.TabIndex = 36
        Me.MaterialLabel1.Text = "Mother's Name:"
        '
        'dtpick_birth
        '
        Me.dtpick_birth.CustomFormat = "dd-mm-yyyy"
        Me.dtpick_birth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_birth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick_birth.Location = New System.Drawing.Point(19, 178)
        Me.dtpick_birth.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpick_birth.Name = "dtpick_birth"
        Me.dtpick_birth.Size = New System.Drawing.Size(148, 26)
        Me.dtpick_birth.TabIndex = 4
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(15, 156)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(97, 19)
        Me.MaterialLabel2.TabIndex = 39
        Me.MaterialLabel2.Text = "Date of Birth:"
        '
        'txt_rnumber
        '
        Me.txt_rnumber.Location = New System.Drawing.Point(20, 235)
        Me.txt_rnumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_rnumber.Name = "txt_rnumber"
        Me.txt_rnumber.Size = New System.Drawing.Size(148, 26)
        Me.txt_rnumber.TabIndex = 6
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(16, 211)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(125, 19)
        Me.MaterialLabel3.TabIndex = 40
        Me.MaterialLabel3.Text = "Register Number:"
        '
        'txt_pbnumber
        '
        Me.txt_pbnumber.Location = New System.Drawing.Point(176, 235)
        Me.txt_pbnumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_pbnumber.Name = "txt_pbnumber"
        Me.txt_pbnumber.Size = New System.Drawing.Size(148, 26)
        Me.txt_pbnumber.TabIndex = 7
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(172, 211)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(130, 19)
        Me.MaterialLabel4.TabIndex = 42
        Me.MaterialLabel4.Text = "Post Box Number:"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(172, 158)
        Me.MaterialLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(103, 19)
        Me.MaterialLabel8.TabIndex = 47
        Me.MaterialLabel8.Text = "Place of Birth:"
        '
        'cbox_regions
        '
        Me.cbox_regions.BackColor = System.Drawing.Color.White
        Me.cbox_regions.ForeColor = System.Drawing.Color.Black
        Me.cbox_regions.FormattingEnabled = True
        Me.cbox_regions.Location = New System.Drawing.Point(175, 180)
        Me.cbox_regions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_regions.Name = "cbox_regions"
        Me.cbox_regions.Size = New System.Drawing.Size(148, 28)
        Me.cbox_regions.TabIndex = 5
        '
        'Frm_NewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(337, 320)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.cbox_regions)
        Me.Controls.Add(Me.txt_pbnumber)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.txt_rnumber)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.dtpick_birth)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.txt_mother)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_father)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.lbl_cid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_NewClient"
        Me.Text = "Frm_NewClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_father As TextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_mother As TextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpick_birth As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_rnumber As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_pbnumber As TextBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_regions As ComboBox
End Class
