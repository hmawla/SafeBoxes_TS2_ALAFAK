<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Connects
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
        Me.RptV_connects = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.dtpick_exdate = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RptV_connects
        '
        Me.RptV_connects.ActiveViewIndex = -1
        Me.RptV_connects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RptV_connects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RptV_connects.Cursor = System.Windows.Forms.Cursors.Default
        Me.RptV_connects.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RptV_connects.Location = New System.Drawing.Point(12, 212)
        Me.RptV_connects.Name = "RptV_connects"
        Me.RptV_connects.Size = New System.Drawing.Size(685, 283)
        Me.RptV_connects.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.dtpick_exdate)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 134)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(6, 57)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(234, 23)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TabStop = False
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Depth = 0
        Me.RadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(250, 25)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Ripple = True
        Me.RadioButton2.Size = New System.Drawing.Size(149, 30)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "By Date (FROM-TO)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dtpick_exdate
        '
        Me.dtpick_exdate.CustomFormat = "dd/mm/yyyy"
        Me.dtpick_exdate.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.dtpick_exdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick_exdate.Location = New System.Drawing.Point(466, 55)
        Me.dtpick_exdate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.dtpick_exdate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.dtpick_exdate.Name = "dtpick_exdate"
        Me.dtpick_exdate.Size = New System.Drawing.Size(204, 27)
        Me.dtpick_exdate.TabIndex = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Depth = 0
        Me.RadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(6, 25)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Ripple = True
        Me.RadioButton1.Size = New System.Drawing.Size(140, 30)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "By InfoVoucher ID"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/mm/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(250, 55)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DateTimePicker1.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(204, 27)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Frm_Report_Connects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 507)
        Me.Controls.Add(Me.RptV_connects)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Report_Connects"
        Me.Text = "Report Connects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RptV_connects As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents dtpick_exdate As DateTimePicker
    Friend WithEvents RadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
