<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BoxPrices
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
        Me.cbox_boxsizes = New System.Windows.Forms.ComboBox()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Txt_RentPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Txt_InsPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'cbox_boxsizes
        '
        Me.cbox_boxsizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_boxsizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbox_boxsizes.FormattingEnabled = True
        Me.cbox_boxsizes.Location = New System.Drawing.Point(13, 99)
        Me.cbox_boxsizes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbox_boxsizes.Name = "cbox_boxsizes"
        Me.cbox_boxsizes.Size = New System.Drawing.Size(361, 26)
        Me.cbox_boxsizes.TabIndex = 15
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(302, 167)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 16
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Txt_RentPrice
        '
        Me.Txt_RentPrice.Depth = 0
        Me.Txt_RentPrice.Hint = ""
        Me.Txt_RentPrice.Location = New System.Drawing.Point(157, 177)
        Me.Txt_RentPrice.MaxLength = 32767
        Me.Txt_RentPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_RentPrice.Name = "Txt_RentPrice"
        Me.Txt_RentPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_RentPrice.SelectedText = ""
        Me.Txt_RentPrice.SelectionLength = 0
        Me.Txt_RentPrice.SelectionStart = 0
        Me.Txt_RentPrice.Size = New System.Drawing.Size(139, 23)
        Me.Txt_RentPrice.TabIndex = 17
        Me.Txt_RentPrice.TabStop = False
        Me.Txt_RentPrice.UseSystemPasswordChar = False
        '
        'Txt_InsPrice
        '
        Me.Txt_InsPrice.Depth = 0
        Me.Txt_InsPrice.Hint = ""
        Me.Txt_InsPrice.Location = New System.Drawing.Point(12, 177)
        Me.Txt_InsPrice.MaxLength = 32767
        Me.Txt_InsPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_InsPrice.Name = "Txt_InsPrice"
        Me.Txt_InsPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_InsPrice.SelectedText = ""
        Me.Txt_InsPrice.SelectionLength = 0
        Me.Txt_InsPrice.SelectionStart = 0
        Me.Txt_InsPrice.Size = New System.Drawing.Size(139, 23)
        Me.Txt_InsPrice.TabIndex = 18
        Me.Txt_InsPrice.TabStop = False
        Me.Txt_InsPrice.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(156, 142)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel1.TabIndex = 19
        Me.MaterialLabel1.Text = "Rent Price:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(8, 142)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(116, 19)
        Me.MaterialLabel2.TabIndex = 20
        Me.MaterialLabel2.Text = "Insurance Price:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 75)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel3.TabIndex = 21
        Me.MaterialLabel3.Text = "Box Size:"
        '
        'Frm_BoxPrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(389, 215)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Txt_InsPrice)
        Me.Controls.Add(Me.Txt_RentPrice)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.cbox_boxsizes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_BoxPrices"
        Me.Sizable = False
        Me.Text = "Frm_BoxPrices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbox_boxsizes As ComboBox
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Txt_RentPrice As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Txt_InsPrice As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
End Class
