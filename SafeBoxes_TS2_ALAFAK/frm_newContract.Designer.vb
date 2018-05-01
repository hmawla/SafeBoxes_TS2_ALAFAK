<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newContract
    Inherits Form

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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_contractid = New MaterialSkin.Controls.MaterialLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbox_buildings = New System.Windows.Forms.ComboBox()
        Me.BuildingsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewBuildingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_accountid = New System.Windows.Forms.TextBox()
        Me.AccountsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_clientinfo = New System.Windows.Forms.TextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.txt_boxes = New System.Windows.Forms.TextBox()
        Me.BoxesMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_streets = New System.Windows.Forms.ComboBox()
        Me.BuildingsMenuStrip.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountsMenuStrip.SuspendLayout()
        Me.BoxesMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 123)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "<ContPhone1>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 5
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(328, 289)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel1.TabIndex = 21
        Me.MaterialLabel1.Text = "Expiry Date:*"
        '
        'lbl_contractid
        '
        Me.lbl_contractid.AutoSize = True
        Me.lbl_contractid.Depth = 0
        Me.lbl_contractid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_contractid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_contractid.Location = New System.Drawing.Point(13, 9)
        Me.lbl_contractid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_contractid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_contractid.Name = "lbl_contractid"
        Me.lbl_contractid.Size = New System.Drawing.Size(153, 19)
        Me.lbl_contractid.TabIndex = 23
        Me.lbl_contractid.Text = "Contract ID: <ContId>"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 311)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 26)
        Me.DateTimePicker1.TabIndex = 9
        '
        'cbox_buildings
        '
        Me.cbox_buildings.BackColor = System.Drawing.Color.White
        Me.cbox_buildings.ContextMenuStrip = Me.BuildingsMenuStrip
        Me.cbox_buildings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_buildings.ForeColor = System.Drawing.Color.Black
        Me.cbox_buildings.FormattingEnabled = True
        Me.cbox_buildings.Location = New System.Drawing.Point(16, 230)
        Me.cbox_buildings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_buildings.Name = "cbox_buildings"
        Me.cbox_buildings.Size = New System.Drawing.Size(148, 28)
        Me.cbox_buildings.TabIndex = 6
        '
        'BuildingsMenuStrip
        '
        Me.BuildingsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBuildingToolStripMenuItem})
        Me.BuildingsMenuStrip.Name = "BuildingsMenuStrip"
        Me.BuildingsMenuStrip.Size = New System.Drawing.Size(146, 26)
        '
        'NewBuildingToolStripMenuItem
        '
        Me.NewBuildingToolStripMenuItem.Name = "NewBuildingToolStripMenuItem"
        Me.NewBuildingToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewBuildingToolStripMenuItem.Text = "New Building"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(169, 155)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel3.TabIndex = 26
        Me.MaterialLabel3.Text = "Street*:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(172, 231)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(148, 26)
        Me.NumericUpDown1.TabIndex = 7
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(169, 208)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(54, 19)
        Me.MaterialLabel4.TabIndex = 28
        Me.MaterialLabel4.Text = "Floor:*"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(13, 99)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(130, 19)
        Me.MaterialLabel5.TabIndex = 29
        Me.MaterialLabel5.Text = "Phone Number 1:*"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(168, 99)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(124, 19)
        Me.MaterialLabel6.TabIndex = 31
        Me.MaterialLabel6.Text = "Phone Number 2:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(172, 123)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 26)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "<ContPhone2>"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(13, 43)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel7.TabIndex = 32
        Me.MaterialLabel7.Text = "Account ID:*"
        '
        'txt_accountid
        '
        Me.txt_accountid.ContextMenuStrip = Me.AccountsMenuStrip
        Me.txt_accountid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_accountid.Location = New System.Drawing.Point(16, 67)
        Me.txt_accountid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_accountid.Name = "txt_accountid"
        Me.txt_accountid.Size = New System.Drawing.Size(148, 26)
        Me.txt_accountid.TabIndex = 0
        Me.txt_accountid.Text = "<AccountId>"
        '
        'AccountsMenuStrip
        '
        Me.AccountsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAccountToolStripMenuItem, Me.NewAccountToolStripMenuItem})
        Me.AccountsMenuStrip.Name = "AccountsMenuStrip"
        Me.AccountsMenuStrip.Size = New System.Drawing.Size(154, 48)
        '
        'SelectAccountToolStripMenuItem
        '
        Me.SelectAccountToolStripMenuItem.Name = "SelectAccountToolStripMenuItem"
        Me.SelectAccountToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SelectAccountToolStripMenuItem.Text = "Select Account"
        '
        'NewAccountToolStripMenuItem
        '
        Me.NewAccountToolStripMenuItem.Name = "NewAccountToolStripMenuItem"
        Me.NewAccountToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewAccountToolStripMenuItem.Text = "New Account"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(324, 43)
        Me.MaterialLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel8.TabIndex = 35
        Me.MaterialLabel8.Text = "Client Info:"
        '
        'txt_clientinfo
        '
        Me.txt_clientinfo.BackColor = System.Drawing.Color.White
        Me.txt_clientinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clientinfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_clientinfo.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txt_clientinfo.Location = New System.Drawing.Point(328, 67)
        Me.txt_clientinfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_clientinfo.Multiline = True
        Me.txt_clientinfo.Name = "txt_clientinfo"
        Me.txt_clientinfo.ReadOnly = True
        Me.txt_clientinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_clientinfo.Size = New System.Drawing.Size(221, 195)
        Me.txt_clientinfo.TabIndex = 36
        Me.txt_clientinfo.Text = "<INFO HERE>"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(13, 265)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(46, 19)
        Me.MaterialLabel9.TabIndex = 38
        Me.MaterialLabel9.Text = "Note:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(16, 289)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(304, 49)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "<ContNote>"
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(473, 298)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(76, 40)
        Me.btn_submit.TabIndex = 10
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'txt_boxes
        '
        Me.txt_boxes.ContextMenuStrip = Me.BoxesMenuStrip
        Me.txt_boxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_boxes.Location = New System.Drawing.Point(172, 67)
        Me.txt_boxes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_boxes.Name = "txt_boxes"
        Me.txt_boxes.Size = New System.Drawing.Size(148, 26)
        Me.txt_boxes.TabIndex = 1
        Me.txt_boxes.Text = "<BoxId>"
        '
        'BoxesMenuStrip
        '
        Me.BoxesMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectBoxToolStripMenuItem})
        Me.BoxesMenuStrip.Name = "BoxesMenuStrip"
        Me.BoxesMenuStrip.Size = New System.Drawing.Size(128, 26)
        '
        'SelectBoxToolStripMenuItem
        '
        Me.SelectBoxToolStripMenuItem.Name = "SelectBoxToolStripMenuItem"
        Me.SelectBoxToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SelectBoxToolStripMenuItem.Text = "Select Box"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(169, 43)
        Me.MaterialLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(62, 19)
        Me.MaterialLabel10.TabIndex = 40
        Me.MaterialLabel10.Text = "Box ID:*"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(178, 9)
        Me.MaterialLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(159, 19)
        Me.MaterialLabel11.TabIndex = 43
        Me.MaterialLabel11.Text = "Employee ID: <EmpId>"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(13, 155)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel2.TabIndex = 45
        Me.MaterialLabel2.Text = "Region*:"
        '
        'cbox_regions
        '
        Me.cbox_regions.BackColor = System.Drawing.Color.White
        Me.cbox_regions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_regions.ForeColor = System.Drawing.Color.Black
        Me.cbox_regions.FormattingEnabled = True
        Me.cbox_regions.Location = New System.Drawing.Point(16, 177)
        Me.cbox_regions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_regions.Name = "cbox_regions"
        Me.cbox_regions.Size = New System.Drawing.Size(148, 28)
        Me.cbox_regions.TabIndex = 4
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(13, 208)
        Me.MaterialLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel12.TabIndex = 47
        Me.MaterialLabel12.Text = "Building:*"
        '
        'cbox_streets
        '
        Me.cbox_streets.BackColor = System.Drawing.Color.White
        Me.cbox_streets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_streets.ForeColor = System.Drawing.Color.Black
        Me.cbox_streets.FormattingEnabled = True
        Me.cbox_streets.Location = New System.Drawing.Point(172, 177)
        Me.cbox_streets.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_streets.Name = "cbox_streets"
        Me.cbox_streets.Size = New System.Drawing.Size(148, 28)
        Me.cbox_streets.TabIndex = 5
        '
        'frm_newContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 355)
        Me.Controls.Add(Me.MaterialLabel12)
        Me.Controls.Add(Me.cbox_streets)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.cbox_regions)
        Me.Controls.Add(Me.MaterialLabel11)
        Me.Controls.Add(Me.txt_boxes)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.txt_clientinfo)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.txt_accountid)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.cbox_buildings)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_contractid)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_newContract"
        Me.Text = "New Contract"
        Me.BuildingsMenuStrip.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountsMenuStrip.ResumeLayout(False)
        Me.BoxesMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_contractid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbox_buildings As ComboBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_accountid As TextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_clientinfo As TextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents txt_boxes As TextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AccountsMenuStrip As ContextMenuStrip
    Friend WithEvents SelectAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoxesMenuStrip As ContextMenuStrip
    Friend WithEvents SelectBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_regions As ComboBox
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_streets As ComboBox
    Friend WithEvents BuildingsMenuStrip As ContextMenuStrip
    Friend WithEvents NewBuildingToolStripMenuItem As ToolStripMenuItem
End Class
