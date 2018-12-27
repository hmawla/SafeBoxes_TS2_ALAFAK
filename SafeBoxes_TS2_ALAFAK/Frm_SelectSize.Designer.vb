<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectSize
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
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_boxsizes = New System.Windows.Forms.ComboBox()
        Me.Btn_OK = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 72)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel3.TabIndex = 23
        Me.MaterialLabel3.Text = "Box Size:"
        '
        'cbox_boxsizes
        '
        Me.cbox_boxsizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_boxsizes.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_boxsizes.FormattingEnabled = True
        Me.cbox_boxsizes.Location = New System.Drawing.Point(13, 96)
        Me.cbox_boxsizes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbox_boxsizes.Name = "cbox_boxsizes"
        Me.cbox_boxsizes.Size = New System.Drawing.Size(361, 27)
        Me.cbox_boxsizes.TabIndex = 22
        '
        'Btn_OK
        '
        Me.Btn_OK.AutoSize = True
        Me.Btn_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_OK.Depth = 0
        Me.Btn_OK.Icon = Nothing
        Me.Btn_OK.Location = New System.Drawing.Point(381, 87)
        Me.Btn_OK.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Primary = True
        Me.Btn_OK.Size = New System.Drawing.Size(39, 36)
        Me.Btn_OK.TabIndex = 24
        Me.Btn_OK.Text = "OK"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Frm_SelectSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 141)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.cbox_boxsizes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_SelectSize"
        Me.Sizable = False
        Me.Text = "Select Box Size"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_boxsizes As ComboBox
    Friend WithEvents Btn_OK As MaterialSkin.Controls.MaterialRaisedButton
End Class
