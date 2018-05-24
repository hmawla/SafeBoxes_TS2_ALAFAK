<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Redeliver_Date
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
        Me.dtpick_redeliverdate = New System.Windows.Forms.DateTimePicker()
        Me.btn_ok = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'dtpick_redeliverdate
        '
        Me.dtpick_redeliverdate.CustomFormat = "dd/mm/yyyy"
        Me.dtpick_redeliverdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_redeliverdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick_redeliverdate.Location = New System.Drawing.Point(246, 69)
        Me.dtpick_redeliverdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpick_redeliverdate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.dtpick_redeliverdate.Name = "dtpick_redeliverdate"
        Me.dtpick_redeliverdate.Size = New System.Drawing.Size(119, 26)
        Me.dtpick_redeliverdate.TabIndex = 10
        '
        'btn_ok
        '
        Me.btn_ok.AutoSize = True
        Me.btn_ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ok.Depth = 0
        Me.btn_ok.Icon = Nothing
        Me.btn_ok.Location = New System.Drawing.Point(327, 101)
        Me.btn_ok.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Primary = True
        Me.btn_ok.Size = New System.Drawing.Size(39, 36)
        Me.btn_ok.TabIndex = 11
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 74)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Please choose the delivery date:"
        '
        'Redeliver_Date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(378, 153)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.dtpick_redeliverdate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Redeliver_Date"
        Me.Text = "Redeliver Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpick_redeliverdate As DateTimePicker
    Friend WithEvents btn_ok As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
End Class
