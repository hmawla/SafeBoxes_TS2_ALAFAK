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
        Me.DGV_Rights = New System.Windows.Forms.DataGridView()
        Me.RightId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RightDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBox_AuthRights = New System.Windows.Forms.ComboBox()
        Me.RightsMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifyRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Txt_ClientId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Txt_ClientName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Btn_AddRight = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_streets = New System.Windows.Forms.ComboBox()
        Me.StreetsMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifyStreetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteStreetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.RegionMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifyRegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_buildings = New System.Windows.Forms.ComboBox()
        Me.BuildingsMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifySelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBuildingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DGVMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV_Rights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightsMenuStrip.SuspendLayout()
        Me.StreetsMenuStrip.SuspendLayout()
        Me.RegionMenuStrip.SuspendLayout()
        Me.BuildingsMenuStrip.SuspendLayout()
        Me.DGVMenuStrip.SuspendLayout()
        Me.ClientMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Rights
        '
        Me.DGV_Rights.AllowUserToAddRows = False
        Me.DGV_Rights.AllowUserToDeleteRows = False
        Me.DGV_Rights.AllowUserToResizeRows = False
        Me.DGV_Rights.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Rights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Rights.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Rights.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Rights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Rights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Rights.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RightId, Me.RightDescription})
        Me.DGV_Rights.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Rights.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Rights.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Rights.Location = New System.Drawing.Point(13, 259)
        Me.DGV_Rights.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_Rights.MultiSelect = False
        Me.DGV_Rights.Name = "DGV_Rights"
        Me.DGV_Rights.ReadOnly = True
        Me.DGV_Rights.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Rights.RowHeadersVisible = False
        Me.DGV_Rights.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Rights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Rights.Size = New System.Drawing.Size(648, 218)
        Me.DGV_Rights.TabIndex = 9
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
        'CBox_AuthRights
        '
        Me.CBox_AuthRights.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBox_AuthRights.ContextMenuStrip = Me.RightsMenuStrip
        Me.CBox_AuthRights.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.CBox_AuthRights.FormattingEnabled = True
        Me.CBox_AuthRights.Location = New System.Drawing.Point(342, 217)
        Me.CBox_AuthRights.Name = "CBox_AuthRights"
        Me.CBox_AuthRights.Size = New System.Drawing.Size(221, 27)
        Me.CBox_AuthRights.TabIndex = 10
        '
        'RightsMenuStrip
        '
        Me.RightsMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RightsMenuStrip.Depth = 0
        Me.RightsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyRightToolStripMenuItem, Me.DeleteRightToolStripMenuItem})
        Me.RightsMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.RightsMenuStrip.Name = "RightsMenuStrip"
        Me.RightsMenuStrip.Size = New System.Drawing.Size(144, 48)
        '
        'ModifyRightToolStripMenuItem
        '
        Me.ModifyRightToolStripMenuItem.Name = "ModifyRightToolStripMenuItem"
        Me.ModifyRightToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ModifyRightToolStripMenuItem.Text = "Modify Right"
        '
        'DeleteRightToolStripMenuItem
        '
        Me.DeleteRightToolStripMenuItem.Name = "DeleteRightToolStripMenuItem"
        Me.DeleteRightToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DeleteRightToolStripMenuItem.Text = "Delete Right"
        '
        'Txt_ClientId
        '
        Me.Txt_ClientId.ContextMenuStrip = Me.ClientMenuStrip
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
        Me.MaterialLabel3.Location = New System.Drawing.Point(338, 195)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(149, 19)
        Me.MaterialLabel3.TabIndex = 15
        Me.MaterialLabel3.Text = "Authorization Rights:"
        '
        'Btn_AddRight
        '
        Me.Btn_AddRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddRight.AutoSize = True
        Me.Btn_AddRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_AddRight.Depth = 0
        Me.Btn_AddRight.Icon = Nothing
        Me.Btn_AddRight.Location = New System.Drawing.Point(570, 212)
        Me.Btn_AddRight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_AddRight.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_AddRight.Name = "Btn_AddRight"
        Me.Btn_AddRight.Primary = True
        Me.Btn_AddRight.Size = New System.Drawing.Size(91, 36)
        Me.Btn_AddRight.TabIndex = 16
        Me.Btn_AddRight.Text = "Add Right"
        Me.Btn_AddRight.UseVisualStyleBackColor = True
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
        Me.cbox_streets.ContextMenuStrip = Me.StreetsMenuStrip
        Me.cbox_streets.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_streets.ForeColor = System.Drawing.Color.Black
        Me.cbox_streets.FormattingEnabled = True
        Me.cbox_streets.Location = New System.Drawing.Point(13, 217)
        Me.cbox_streets.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_streets.Name = "cbox_streets"
        Me.cbox_streets.Size = New System.Drawing.Size(148, 27)
        Me.cbox_streets.TabIndex = 49
        '
        'StreetsMenuStrip
        '
        Me.StreetsMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StreetsMenuStrip.Depth = 0
        Me.StreetsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyStreetToolStripMenuItem, Me.DeleteStreetToolStripMenuItem})
        Me.StreetsMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.StreetsMenuStrip.Name = "StreetsMenuStrip"
        Me.StreetsMenuStrip.Size = New System.Drawing.Size(146, 48)
        '
        'ModifyStreetToolStripMenuItem
        '
        Me.ModifyStreetToolStripMenuItem.Name = "ModifyStreetToolStripMenuItem"
        Me.ModifyStreetToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ModifyStreetToolStripMenuItem.Text = "Modify Street"
        '
        'DeleteStreetToolStripMenuItem
        '
        Me.DeleteStreetToolStripMenuItem.Name = "DeleteStreetToolStripMenuItem"
        Me.DeleteStreetToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DeleteStreetToolStripMenuItem.Text = "Delete Street"
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
        Me.cbox_regions.ContextMenuStrip = Me.RegionMenuStrip
        Me.cbox_regions.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_regions.ForeColor = System.Drawing.Color.Black
        Me.cbox_regions.FormattingEnabled = True
        Me.cbox_regions.Location = New System.Drawing.Point(169, 165)
        Me.cbox_regions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_regions.Name = "cbox_regions"
        Me.cbox_regions.Size = New System.Drawing.Size(148, 27)
        Me.cbox_regions.TabIndex = 48
        '
        'RegionMenuStrip
        '
        Me.RegionMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegionMenuStrip.Depth = 0
        Me.RegionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyRegionToolStripMenuItem, Me.DeleteRegionToolStripMenuItem})
        Me.RegionMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.RegionMenuStrip.Name = "RegionMenuStrip"
        Me.RegionMenuStrip.Size = New System.Drawing.Size(153, 48)
        '
        'ModifyRegionToolStripMenuItem
        '
        Me.ModifyRegionToolStripMenuItem.Name = "ModifyRegionToolStripMenuItem"
        Me.ModifyRegionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModifyRegionToolStripMenuItem.Text = "Modify Region"
        '
        'DeleteRegionToolStripMenuItem
        '
        Me.DeleteRegionToolStripMenuItem.Name = "DeleteRegionToolStripMenuItem"
        Me.DeleteRegionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteRegionToolStripMenuItem.Text = "Delete Region"
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
        Me.cbox_buildings.ContextMenuStrip = Me.BuildingsMenuStrip
        Me.cbox_buildings.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.cbox_buildings.ForeColor = System.Drawing.Color.Black
        Me.cbox_buildings.FormattingEnabled = True
        Me.cbox_buildings.Location = New System.Drawing.Point(169, 217)
        Me.cbox_buildings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_buildings.Name = "cbox_buildings"
        Me.cbox_buildings.Size = New System.Drawing.Size(148, 27)
        Me.cbox_buildings.TabIndex = 50
        '
        'BuildingsMenuStrip
        '
        Me.BuildingsMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BuildingsMenuStrip.Depth = 0
        Me.BuildingsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifySelectedToolStripMenuItem, Me.DeleteBuildingToolStripMenuItem})
        Me.BuildingsMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.BuildingsMenuStrip.Name = "BuildingsMenuStrip"
        Me.BuildingsMenuStrip.Size = New System.Drawing.Size(160, 48)
        '
        'ModifySelectedToolStripMenuItem
        '
        Me.ModifySelectedToolStripMenuItem.Name = "ModifySelectedToolStripMenuItem"
        Me.ModifySelectedToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ModifySelectedToolStripMenuItem.Text = "Modify Building"
        '
        'DeleteBuildingToolStripMenuItem
        '
        Me.DeleteBuildingToolStripMenuItem.Name = "DeleteBuildingToolStripMenuItem"
        Me.DeleteBuildingToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DeleteBuildingToolStripMenuItem.Text = "Delete Building"
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
        Me.MaterialDivider2.Size = New System.Drawing.Size(679, 1)
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
        Me.Btn_Submit.Location = New System.Drawing.Point(591, 492)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 56
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'DGVMenuStrip
        '
        Me.DGVMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMenuStrip.Depth = 0
        Me.DGVMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem})
        Me.DGVMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.DGVMenuStrip.Name = "DGVMenuStrip"
        Me.DGVMenuStrip.Size = New System.Drawing.Size(165, 26)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'ClientMenuStrip
        '
        Me.ClientMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientMenuStrip.Depth = 0
        Me.ClientMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem})
        Me.ClientMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClientMenuStrip.Name = "ClientMenuStrip"
        Me.ClientMenuStrip.Size = New System.Drawing.Size(140, 26)
        '
        'SelectClientToolStripMenuItem
        '
        Me.SelectClientToolStripMenuItem.Name = "SelectClientToolStripMenuItem"
        Me.SelectClientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectClientToolStripMenuItem.Text = "Select Client"
        '
        'Frm_Authorize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 540)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel12)
        Me.Controls.Add(Me.cbox_streets)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.cbox_regions)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.cbox_buildings)
        Me.Controls.Add(Me.Btn_AddRight)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.Txt_ClientName)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Txt_ClientId)
        Me.Controls.Add(Me.CBox_AuthRights)
        Me.Controls.Add(Me.DGV_Rights)
        Me.Name = "Frm_Authorize"
        Me.Text = "Authorization"
        CType(Me.DGV_Rights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightsMenuStrip.ResumeLayout(False)
        Me.StreetsMenuStrip.ResumeLayout(False)
        Me.RegionMenuStrip.ResumeLayout(False)
        Me.BuildingsMenuStrip.ResumeLayout(False)
        Me.DGVMenuStrip.ResumeLayout(False)
        Me.ClientMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Rights As DataGridView
    Friend WithEvents CBox_AuthRights As ComboBox
    Friend WithEvents Txt_ClientId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Txt_ClientName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Btn_AddRight As MaterialSkin.Controls.MaterialFlatButton
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
    Friend WithEvents DGVMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightsMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifyRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildingsMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifySelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteBuildingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegionMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifyRegionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRegionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StreetsMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifyStreetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStreetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
End Class
