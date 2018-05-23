<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Authorize
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
        Me.dgv_contracts = New System.Windows.Forms.DataGridView()
        Me.CBox_AuthRights = New System.Windows.Forms.ComboBox()
        Me.Txt_ClientId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_streets = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_buildings = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.RightId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RightDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_contracts
        '
        Me.dgv_contracts.AllowUserToAddRows = False
        Me.dgv_contracts.AllowUserToDeleteRows = False
        Me.dgv_contracts.AllowUserToResizeRows = False
        Me.dgv_contracts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_contracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_contracts.BackgroundColor = System.Drawing.Color.White
        Me.dgv_contracts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_contracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contracts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RightId, Me.RightDescription})
        Me.dgv_contracts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_contracts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_contracts.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_contracts.Location = New System.Drawing.Point(13, 259)
        Me.dgv_contracts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_contracts.MultiSelect = False
        Me.dgv_contracts.Name = "dgv_contracts"
        Me.dgv_contracts.ReadOnly = True
        Me.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_contracts.RowHeadersVisible = False
        Me.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contracts.Size = New System.Drawing.Size(643, 218)
        Me.dgv_contracts.TabIndex = 9
        '
        'CBox_AuthRights
        '
        Me.CBox_AuthRights.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBox_AuthRights.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.CBox_AuthRights.FormattingEnabled = True
        Me.CBox_AuthRights.Location = New System.Drawing.Point(337, 217)
        Me.CBox_AuthRights.Name = "CBox_AuthRights"
        Me.CBox_AuthRights.Size = New System.Drawing.Size(221, 27)
        Me.CBox_AuthRights.TabIndex = 10
        '
        'Txt_ClientId
        '
        Me.Txt_ClientId.Depth = 0
        Me.Txt_ClientId.Hint = ""
        Me.Txt_ClientId.Location = New System.Drawing.Point(16, 107)
        Me.Txt_ClientId.MaxLength = 32767
        Me.Txt_ClientId.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ClientId.Name = "Txt_ClientId"
        Me.Txt_ClientId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ClientId.SelectedText = ""
        Me.Txt_ClientId.SelectionLength = 0
        Me.Txt_ClientId.SelectionStart = 0
        Me.Txt_ClientId.Size = New System.Drawing.Size(80, 23)
        Me.Txt_ClientId.TabIndex = 11
        Me.Txt_ClientId.TabStop = False
        Me.Txt_ClientId.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 85)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel1.TabIndex = 12
        Me.MaterialLabel1.Text = "Client ID:"
        '
        'Txt_ClientName
        '
        Me.Txt_ClientName.Depth = 0
        Me.Txt_ClientName.Enabled = False
        Me.Txt_ClientName.Hint = ""
        Me.Txt_ClientName.Location = New System.Drawing.Point(102, 107)
        Me.Txt_ClientName.MaxLength = 32767
        Me.Txt_ClientName.MouseState = MaterialSkin.MouseState.HOVER
        Me.Txt_ClientName.Name = "Txt_ClientName"
        Me.Txt_ClientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ClientName.SelectedText = ""
        Me.Txt_ClientName.SelectionLength = 0
        Me.Txt_ClientName.SelectionStart = 0
        Me.Txt_ClientName.Size = New System.Drawing.Size(215, 23)
        Me.Txt_ClientName.TabIndex = 13
        Me.Txt_ClientName.TabStop = False
        Me.Txt_ClientName.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(98, 85)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel2.TabIndex = 14
        Me.MaterialLabel2.Text = "Client Name:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(333, 195)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(149, 19)
        Me.MaterialLabel3.TabIndex = 15
        Me.MaterialLabel3.Text = "Authorization Rights:"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(565, 212)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = True
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(91, 36)
        Me.MaterialFlatButton1.TabIndex = 16
        Me.MaterialFlatButton1.Text = "Add Right"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(166, 195)
        Me.MaterialLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(66, 19)
        Me.MaterialLabel12.TabIndex = 53
        Me.MaterialLabel12.Text = "Building:"
        '
        'cbox_streets
        '
        Me.cbox_streets.BackColor = System.Drawing.Color.White
        Me.cbox_streets.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_streets.ForeColor = System.Drawing.Color.Black
        Me.cbox_streets.FormattingEnabled = True
        Me.cbox_streets.Location = New System.Drawing.Point(13, 217)
        Me.cbox_streets.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_streets.Name = "cbox_streets"
        Me.cbox_streets.Size = New System.Drawing.Size(148, 27)
        Me.cbox_streets.TabIndex = 49
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(166, 143)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel4.TabIndex = 52
        Me.MaterialLabel4.Text = "Region:"
        '
        'cbox_regions
        '
        Me.cbox_regions.BackColor = System.Drawing.Color.White
        Me.cbox_regions.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_regions.ForeColor = System.Drawing.Color.Black
        Me.cbox_regions.FormattingEnabled = True
        Me.cbox_regions.Location = New System.Drawing.Point(169, 165)
        Me.cbox_regions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_regions.Name = "cbox_regions"
        Me.cbox_regions.Size = New System.Drawing.Size(148, 27)
        Me.cbox_regions.TabIndex = 48
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(9, 195)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(53, 19)
        Me.MaterialLabel5.TabIndex = 51
        Me.MaterialLabel5.Text = "Street:"
        '
        'cbox_buildings
        '
        Me.cbox_buildings.BackColor = System.Drawing.Color.White
        Me.cbox_buildings.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_buildings.ForeColor = System.Drawing.Color.Black
        Me.cbox_buildings.FormattingEnabled = True
        Me.cbox_buildings.Location = New System.Drawing.Point(169, 217)
        Me.cbox_buildings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_buildings.Name = "cbox_buildings"
        Me.cbox_buildings.Size = New System.Drawing.Size(148, 27)
        Me.cbox_buildings.TabIndex = 50
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(9, 143)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(111, 19)
        Me.MaterialLabel6.TabIndex = 54
        Me.MaterialLabel6.Text = "Client Address:"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(-2, 485)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(674, 1)
        Me.MaterialDivider2.TabIndex = 55
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(586, 492)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 56
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'RightId
        '
        Me.RightId.FillWeight = 8.387229!
        Me.RightId.HeaderText = "Right ID"
        Me.RightId.Name = "RightId"
        Me.RightId.ReadOnly = True
        '
        'RightDescription
        '
        Me.RightDescription.FillWeight = 46.68891!
        Me.RightDescription.HeaderText = "Right Description"
        Me.RightDescription.Name = "RightDescription"
        Me.RightDescription.ReadOnly = True
        '
        'Frm_Authorize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 540)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel12)
        Me.Controls.Add(Me.cbox_streets)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.cbox_regions)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.cbox_buildings)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.Txt_ClientName)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Txt_ClientId)
        Me.Controls.Add(Me.CBox_AuthRights)
        Me.Controls.Add(Me.dgv_contracts)
        Me.Name = "Frm_Authorize"
        Me.Text = "Authorization"
        CType(Me.dgv_contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_contracts As DataGridView
    Friend WithEvents CBox_AuthRights As ComboBox
    Friend WithEvents Txt_ClientId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_streets As ComboBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_regions As ComboBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_buildings As ComboBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents RightId As DataGridViewTextBoxColumn
    Friend WithEvents RightDescription As DataGridViewTextBoxColumn
End Class
