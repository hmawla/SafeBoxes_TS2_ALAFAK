<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewConnects
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
        Me.Lbl_infovId = New MaterialSkin.Controls.MaterialLabel()
        Me.Lbl_EmpId = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Rdb_AnswerN = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rdb_AnswerY = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Txt_AnswerNote = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Chk_AnswerNote = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Rdb_ResultY = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Rdb_ResultN = New MaterialSkin.Controls.MaterialRadioButton()
        Me.SelectEmployee = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectDifferentEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SelectEmployee.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_infovId
        '
        Me.Lbl_infovId.AutoSize = True
        Me.Lbl_infovId.Depth = 0
        Me.Lbl_infovId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_infovId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_infovId.Location = New System.Drawing.Point(23, 77)
        Me.Lbl_infovId.Margin = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.Lbl_infovId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_infovId.Name = "Lbl_infovId"
        Me.Lbl_infovId.Size = New System.Drawing.Size(171, 19)
        Me.Lbl_infovId.TabIndex = 77
        Me.Lbl_infovId.Text = "InfoVoucher ID: <InfoId>"
        '
        'Lbl_EmpId
        '
        Me.Lbl_EmpId.AutoSize = True
        Me.Lbl_EmpId.ContextMenuStrip = Me.SelectEmployee
        Me.Lbl_EmpId.Depth = 0
        Me.Lbl_EmpId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Lbl_EmpId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_EmpId.Location = New System.Drawing.Point(222, 77)
        Me.Lbl_EmpId.Margin = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.Lbl_EmpId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lbl_EmpId.Name = "Lbl_EmpId"
        Me.Lbl_EmpId.Size = New System.Drawing.Size(159, 19)
        Me.Lbl_EmpId.TabIndex = 76
        Me.Lbl_EmpId.Text = "Employee ID: <EmpId>"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 23)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(125, 19)
        Me.MaterialLabel2.TabIndex = 93
        Me.MaterialLabel2.Text = "Client Answered?"
        '
        'Rdb_AnswerN
        '
        Me.Rdb_AnswerN.AutoSize = True
        Me.Rdb_AnswerN.Checked = True
        Me.Rdb_AnswerN.Depth = 0
        Me.Rdb_AnswerN.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_AnswerN.Location = New System.Drawing.Point(16, 72)
        Me.Rdb_AnswerN.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_AnswerN.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_AnswerN.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_AnswerN.Name = "Rdb_AnswerN"
        Me.Rdb_AnswerN.Ripple = True
        Me.Rdb_AnswerN.Size = New System.Drawing.Size(47, 30)
        Me.Rdb_AnswerN.TabIndex = 94
        Me.Rdb_AnswerN.TabStop = True
        Me.Rdb_AnswerN.Text = "No"
        Me.Rdb_AnswerN.UseVisualStyleBackColor = True
        '
        'Rdb_AnswerY
        '
        Me.Rdb_AnswerY.AutoSize = True
        Me.Rdb_AnswerY.Depth = 0
        Me.Rdb_AnswerY.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_AnswerY.Location = New System.Drawing.Point(16, 42)
        Me.Rdb_AnswerY.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_AnswerY.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_AnswerY.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_AnswerY.Name = "Rdb_AnswerY"
        Me.Rdb_AnswerY.Ripple = True
        Me.Rdb_AnswerY.Size = New System.Drawing.Size(52, 30)
        Me.Rdb_AnswerY.TabIndex = 95
        Me.Rdb_AnswerY.Text = "Yes"
        Me.Rdb_AnswerY.UseVisualStyleBackColor = True
        '
        'Txt_AnswerNote
        '
        Me.Txt_AnswerNote.Depth = 0
        Me.Txt_AnswerNote.Enabled = False
        Me.Txt_AnswerNote.Hint = ""
        Me.Txt_AnswerNote.Location = New System.Drawing.Point(27, 244)
        Me.Txt_AnswerNote.MaxLength = 32767
        Me.Txt_AnswerNote.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_AnswerNote.Name = "Txt_AnswerNote"
        Me.Txt_AnswerNote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_AnswerNote.SelectedText = ""
        Me.Txt_AnswerNote.SelectionLength = 0
        Me.Txt_AnswerNote.SelectionStart = 0
        Me.Txt_AnswerNote.Size = New System.Drawing.Size(338, 23)
        Me.Txt_AnswerNote.TabIndex = 96
        Me.Txt_AnswerNote.TabStop = False
        Me.Txt_AnswerNote.UseSystemPasswordChar = False
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(307, 300)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 98
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Chk_AnswerNote
        '
        Me.Chk_AnswerNote.AutoSize = True
        Me.Chk_AnswerNote.Depth = 0
        Me.Chk_AnswerNote.Enabled = False
        Me.Chk_AnswerNote.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Chk_AnswerNote.Location = New System.Drawing.Point(27, 211)
        Me.Chk_AnswerNote.Margin = New System.Windows.Forms.Padding(0)
        Me.Chk_AnswerNote.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Chk_AnswerNote.MouseState = MaterialSkin.MouseState.HOVER
        Me.Chk_AnswerNote.Name = "Chk_AnswerNote"
        Me.Chk_AnswerNote.Ripple = True
        Me.Chk_AnswerNote.Size = New System.Drawing.Size(113, 30)
        Me.Chk_AnswerNote.TabIndex = 99
        Me.Chk_AnswerNote.Text = "Answer Note:"
        Me.Chk_AnswerNote.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(6, 23)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(132, 19)
        Me.MaterialLabel1.TabIndex = 100
        Me.MaterialLabel1.Text = "Called with result?"
        '
        'Rdb_ResultY
        '
        Me.Rdb_ResultY.AutoSize = True
        Me.Rdb_ResultY.Depth = 0
        Me.Rdb_ResultY.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ResultY.Location = New System.Drawing.Point(10, 42)
        Me.Rdb_ResultY.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Rdb_ResultY.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ResultY.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ResultY.Name = "Rdb_ResultY"
        Me.Rdb_ResultY.Ripple = True
        Me.Rdb_ResultY.Size = New System.Drawing.Size(52, 30)
        Me.Rdb_ResultY.TabIndex = 102
        Me.Rdb_ResultY.Text = "Yes"
        Me.Rdb_ResultY.UseVisualStyleBackColor = True
        '
        'Rdb_ResultN
        '
        Me.Rdb_ResultN.AutoSize = True
        Me.Rdb_ResultN.Checked = True
        Me.Rdb_ResultN.Depth = 0
        Me.Rdb_ResultN.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ResultN.Location = New System.Drawing.Point(10, 72)
        Me.Rdb_ResultN.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ResultN.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ResultN.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ResultN.Name = "Rdb_ResultN"
        Me.Rdb_ResultN.Ripple = True
        Me.Rdb_ResultN.Size = New System.Drawing.Size(47, 30)
        Me.Rdb_ResultN.TabIndex = 101
        Me.Rdb_ResultN.TabStop = True
        Me.Rdb_ResultN.Text = "No"
        Me.Rdb_ResultN.UseVisualStyleBackColor = True
        '
        'SelectEmployee
        '
        Me.SelectEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelectEmployee.Depth = 0
        Me.SelectEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDifferentEmployeeToolStripMenuItem})
        Me.SelectEmployee.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectEmployee.Name = "SelectEmployee"
        Me.SelectEmployee.Size = New System.Drawing.Size(210, 26)
        '
        'SelectDifferentEmployeeToolStripMenuItem
        '
        Me.SelectDifferentEmployeeToolStripMenuItem.Name = "SelectDifferentEmployeeToolStripMenuItem"
        Me.SelectDifferentEmployeeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SelectDifferentEmployeeToolStripMenuItem.Text = "Select Different Employee"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.Rdb_ResultN)
        Me.GroupBox1.Controls.Add(Me.Rdb_ResultY)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 109)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox2.Controls.Add(Me.Rdb_AnswerN)
        Me.GroupBox2.Controls.Add(Me.Rdb_AnswerY)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 109)
        Me.GroupBox2.TabIndex = 105
        Me.GroupBox2.TabStop = False
        '
        'Frm_NewConnects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(390, 348)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Chk_AnswerNote)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Txt_AnswerNote)
        Me.Controls.Add(Me.Lbl_infovId)
        Me.Controls.Add(Me.Lbl_EmpId)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_NewConnects"
        Me.Text = "Frm_Connects"
        Me.SelectEmployee.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_infovId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lbl_EmpId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Rdb_AnswerN As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rdb_AnswerY As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Txt_AnswerNote As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Chk_AnswerNote As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Rdb_ResultY As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rdb_ResultN As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents SelectEmployee As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectDifferentEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
