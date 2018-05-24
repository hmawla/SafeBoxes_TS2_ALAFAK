<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Client
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
        Me.CRptV_Clients = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.Txt_CId = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Rdb_ByClientId = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRptV_Clients
        '
        Me.CRptV_Clients.ActiveViewIndex = -1
        Me.CRptV_Clients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRptV_Clients.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRptV_Clients.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRptV_Clients.Location = New System.Drawing.Point(15, 152)
        Me.CRptV_Clients.Name = "CRptV_Clients"
        Me.CRptV_Clients.Size = New System.Drawing.Size(688, 428)
        Me.CRptV_Clients.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_cname)
        Me.GroupBox1.Controls.Add(Me.Txt_CId)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Rdb_ByClientId)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 134)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'txt_cname
        '
        Me.txt_cname.Location = New System.Drawing.Point(250, 57)
        Me.txt_cname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(234, 27)
        Me.txt_cname.TabIndex = 18
        '
        'Txt_CId
        '
        Me.Txt_CId.Location = New System.Drawing.Point(6, 57)
        Me.Txt_CId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_CId.Name = "Txt_CId"
        Me.Txt_CId.Size = New System.Drawing.Size(234, 27)
        Me.Txt_CId.TabIndex = 12
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(250, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(135, 24)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "By Client Name"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Rdb_ByClientId
        '
        Me.Rdb_ByClientId.AutoSize = True
        Me.Rdb_ByClientId.Location = New System.Drawing.Point(6, 25)
        Me.Rdb_ByClientId.Name = "Rdb_ByClientId"
        Me.Rdb_ByClientId.Size = New System.Drawing.Size(107, 24)
        Me.Rdb_ByClientId.TabIndex = 16
        Me.Rdb_ByClientId.TabStop = True
        Me.Rdb_ByClientId.Text = "By Client ID"
        Me.Rdb_ByClientId.UseVisualStyleBackColor = True
        '
        'Frm_Report_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 592)
        Me.Controls.Add(Me.CRptV_Clients)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Report_Client"
        Me.Text = "Report Client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRptV_Clients As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_CId As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Rdb_ByClientId As RadioButton
    Friend WithEvents txt_cname As TextBox
End Class
