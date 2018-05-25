<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Visits
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
        Me.CRptV_Visits = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Txt_ContId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.dtpick_exdate = New System.Windows.Forms.DateTimePicker()
        Me.Rdb_ByContId = New MaterialSkin.Controls.MaterialRadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRptV_Visits
        '
        Me.CRptV_Visits.ActiveViewIndex = -1
        Me.CRptV_Visits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRptV_Visits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRptV_Visits.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRptV_Visits.Location = New System.Drawing.Point(12, 152)
        Me.CRptV_Visits.Name = "CRptV_Visits"
        Me.CRptV_Visits.Size = New System.Drawing.Size(706, 373)
        Me.CRptV_Visits.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Txt_ContId)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.dtpick_exdate)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByContId)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 134)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(579, 104)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 24)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Delivered"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Txt_ContId
        '
        Me.Txt_ContId.Location = New System.Drawing.Point(6, 57)
        Me.Txt_ContId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ContId.Name = "Txt_ContId"
        Me.Txt_ContId.Size = New System.Drawing.Size(234, 27)
        Me.Txt_ContId.TabIndex = 12
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(250, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(165, 24)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "By Date (FROM-TO)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dtpick_exdate
        '
        Me.dtpick_exdate.CustomFormat = "dd/mm/yyyy"
        Me.dtpick_exdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_exdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick_exdate.Location = New System.Drawing.Point(466, 55)
        Me.dtpick_exdate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.dtpick_exdate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.dtpick_exdate.Name = "dtpick_exdate"
        Me.dtpick_exdate.Size = New System.Drawing.Size(204, 26)
        Me.dtpick_exdate.TabIndex = 10
        '
        'Rdb_ByContId
        '
        Me.Rdb_ByContId.AutoSize = True
        Me.Rdb_ByContId.Location = New System.Drawing.Point(6, 25)
        Me.Rdb_ByContId.Name = "Rdb_ByContId"
        Me.Rdb_ByContId.Size = New System.Drawing.Size(127, 24)
        Me.Rdb_ByContId.TabIndex = 16
        Me.Rdb_ByContId.TabStop = True
        Me.Rdb_ByContId.Text = "By Contract ID"
        Me.Rdb_ByContId.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/mm/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(250, 55)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DateTimePicker1.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(204, 26)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Frm_Report_Visits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 537)
        Me.Controls.Add(Me.CRptV_Visits)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Report_Visits"
        Me.Text = "Report Visits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRptV_Visits As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Txt_ContId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents dtpick_exdate As DateTimePicker
    Friend WithEvents Rdb_ByContId As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
