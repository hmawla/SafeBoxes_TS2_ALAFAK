﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Report_Contract
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_ContId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Rdb_ByDate = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Dtpick_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.Rdb_ByContId = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Dtpick_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.CRptV_Contract = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Btn_Search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Btn_Search)
        Me.GroupBox1.Controls.Add(Me.Txt_ContId)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByDate)
        Me.GroupBox1.Controls.Add(Me.Dtpick_ToDate)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByContId)
        Me.GroupBox1.Controls.Add(Me.Dtpick_FromDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 134)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Txt_ContId
        '
        Me.Txt_ContId.Depth = 0
        Me.Txt_ContId.Hint = ""
        Me.Txt_ContId.Location = New System.Drawing.Point(6, 57)
        Me.Txt_ContId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ContId.MaxLength = 32767
        Me.Txt_ContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ContId.Name = "Txt_ContId"
        Me.Txt_ContId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ContId.SelectedText = ""
        Me.Txt_ContId.SelectionLength = 0
        Me.Txt_ContId.SelectionStart = 0
        Me.Txt_ContId.Size = New System.Drawing.Size(234, 23)
        Me.Txt_ContId.TabIndex = 12
        Me.Txt_ContId.TabStop = False
        Me.Txt_ContId.UseSystemPasswordChar = False
        '
        'Rdb_ByDate
        '
        Me.Rdb_ByDate.AutoSize = True
        Me.Rdb_ByDate.Depth = 0
        Me.Rdb_ByDate.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByDate.Location = New System.Drawing.Point(250, 25)
        Me.Rdb_ByDate.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByDate.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByDate.Name = "Rdb_ByDate"
        Me.Rdb_ByDate.Ripple = True
        Me.Rdb_ByDate.Size = New System.Drawing.Size(149, 30)
        Me.Rdb_ByDate.TabIndex = 15
        Me.Rdb_ByDate.Text = "By Date (FROM-TO)"
        Me.Rdb_ByDate.UseVisualStyleBackColor = True
        '
        'Dtpick_ToDate
        '
        Me.Dtpick_ToDate.CustomFormat = "dd/mm/yyyy"
        Me.Dtpick_ToDate.Enabled = False
        Me.Dtpick_ToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Dtpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpick_ToDate.Location = New System.Drawing.Point(466, 55)
        Me.Dtpick_ToDate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Dtpick_ToDate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.Dtpick_ToDate.Name = "Dtpick_ToDate"
        Me.Dtpick_ToDate.Size = New System.Drawing.Size(204, 26)
        Me.Dtpick_ToDate.TabIndex = 10
        '
        'Rdb_ByContId
        '
        Me.Rdb_ByContId.AutoSize = True
        Me.Rdb_ByContId.Checked = True
        Me.Rdb_ByContId.Depth = 0
        Me.Rdb_ByContId.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Rdb_ByContId.Location = New System.Drawing.Point(6, 25)
        Me.Rdb_ByContId.Margin = New System.Windows.Forms.Padding(0)
        Me.Rdb_ByContId.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Rdb_ByContId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rdb_ByContId.Name = "Rdb_ByContId"
        Me.Rdb_ByContId.Ripple = True
        Me.Rdb_ByContId.Size = New System.Drawing.Size(117, 30)
        Me.Rdb_ByContId.TabIndex = 16
        Me.Rdb_ByContId.TabStop = True
        Me.Rdb_ByContId.Text = "By Contract ID"
        Me.Rdb_ByContId.UseVisualStyleBackColor = True
        '
        'Dtpick_FromDate
        '
        Me.Dtpick_FromDate.CustomFormat = "dd/mm/yyyy"
        Me.Dtpick_FromDate.Enabled = False
        Me.Dtpick_FromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Dtpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpick_FromDate.Location = New System.Drawing.Point(250, 55)
        Me.Dtpick_FromDate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Dtpick_FromDate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.Dtpick_FromDate.Name = "Dtpick_FromDate"
        Me.Dtpick_FromDate.Size = New System.Drawing.Size(204, 26)
        Me.Dtpick_FromDate.TabIndex = 11
        '
        'CRptV_Contract
        '
        Me.CRptV_Contract.ActiveViewIndex = -1
        Me.CRptV_Contract.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRptV_Contract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRptV_Contract.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRptV_Contract.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRptV_Contract.Location = New System.Drawing.Point(12, 219)
        Me.CRptV_Contract.Name = "CRptV_Contract"
        Me.CRptV_Contract.Size = New System.Drawing.Size(688, 361)
        Me.CRptV_Contract.TabIndex = 21
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.AutoSize = True
        Me.Btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Search.Depth = 0
        Me.Btn_Search.Icon = Nothing
        Me.Btn_Search.Location = New System.Drawing.Point(608, 95)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Search.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Primary = False
        Me.Btn_Search.Size = New System.Drawing.Size(73, 36)
        Me.Btn_Search.TabIndex = 17
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Frm_Report_Contract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 592)
        Me.Controls.Add(Me.CRptV_Contract)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Report_Contract"
        Me.Text = "Contract Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_ContId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Rdb_ByDate As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Dtpick_ToDate As DateTimePicker
    Friend WithEvents Dtpick_FromDate As DateTimePicker
    Friend WithEvents CRptV_Contract As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Rdb_ByContId As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Btn_Search As MaterialSkin.Controls.MaterialFlatButton
End Class
