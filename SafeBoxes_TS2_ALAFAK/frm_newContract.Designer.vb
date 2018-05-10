<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_newContract
    Inherits Form

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
        Me.components = New System.ComponentModel.Container()
        Me.txt_phone1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_contractid = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpick_exdate = New System.Windows.Forms.DateTimePicker()
        Me.cbox_buildings = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_floor = New System.Windows.Forms.NumericUpDown()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_phone2 = New System.Windows.Forms.TextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_accountid = New System.Windows.Forms.TextBox()
        Me.AccountsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_clientinfo = New System.Windows.Forms.TextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_contnote = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.txt_boxes = New System.Windows.Forms.TextBox()
        Me.BoxesMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_empid = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_streets = New System.Windows.Forms.ComboBox()
        Me.EmployeeMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectDifferentEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.txt_floor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountsMenuStrip.SuspendLayout()
        Me.BoxesMenuStrip.SuspendLayout()
        Me.EmployeeMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_phone1
        '
        Me.txt_phone1.Location = New System.Drawing.Point(16, 123)
        Me.txt_phone1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_phone1.Name = "txt_phone1"
        Me.txt_phone1.Size = New System.Drawing.Size(148, 26)
        Me.txt_phone1.TabIndex = 2
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
        'dtpick_exdate
        '
        Me.dtpick_exdate.CustomFormat = "dd/mm/yyyy"
        Me.dtpick_exdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_exdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick_exdate.Location = New System.Drawing.Point(328, 311)
        Me.dtpick_exdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpick_exdate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.dtpick_exdate.Name = "dtpick_exdate"
        Me.dtpick_exdate.Size = New System.Drawing.Size(137, 26)
        Me.dtpick_exdate.TabIndex = 9
        '
        'cbox_buildings
        '
        Me.cbox_buildings.BackColor = System.Drawing.Color.White
        Me.cbox_buildings.ForeColor = System.Drawing.Color.Black
        Me.cbox_buildings.FormattingEnabled = True
        Me.cbox_buildings.Location = New System.Drawing.Point(16, 230)
        Me.cbox_buildings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_buildings.Name = "cbox_buildings"
        Me.cbox_buildings.Size = New System.Drawing.Size(148, 28)
        Me.cbox_buildings.TabIndex = 6
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
        'txt_floor
        '
        Me.txt_floor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_floor.Location = New System.Drawing.Point(172, 231)
        Me.txt_floor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_floor.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txt_floor.Name = "txt_floor"
        Me.txt_floor.Size = New System.Drawing.Size(148, 26)
        Me.txt_floor.TabIndex = 7
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
        'txt_phone2
        '
        Me.txt_phone2.Location = New System.Drawing.Point(172, 123)
        Me.txt_phone2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_phone2.Name = "txt_phone2"
        Me.txt_phone2.Size = New System.Drawing.Size(148, 26)
        Me.txt_phone2.TabIndex = 3
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
        'txt_contnote
        '
        Me.txt_contnote.Location = New System.Drawing.Point(16, 289)
        Me.txt_contnote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_contnote.Multiline = True
        Me.txt_contnote.Name = "txt_contnote"
        Me.txt_contnote.Size = New System.Drawing.Size(304, 49)
        Me.txt_contnote.TabIndex = 8
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
        'lbl_empid
        '
        Me.lbl_empid.AutoSize = True
        Me.lbl_empid.ContextMenuStrip = Me.EmployeeMenuStrip
        Me.lbl_empid.Depth = 0
        Me.lbl_empid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl_empid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_empid.Location = New System.Drawing.Point(178, 9)
        Me.lbl_empid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_empid.Name = "lbl_empid"
        Me.lbl_empid.Size = New System.Drawing.Size(159, 19)
        Me.lbl_empid.TabIndex = 43
        Me.lbl_empid.Text = "Employee ID: <EmpId>"
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
        Me.cbox_streets.ForeColor = System.Drawing.Color.Black
        Me.cbox_streets.FormattingEnabled = True
        Me.cbox_streets.Location = New System.Drawing.Point(172, 177)
        Me.cbox_streets.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_streets.Name = "cbox_streets"
        Me.cbox_streets.Size = New System.Drawing.Size(148, 28)
        Me.cbox_streets.TabIndex = 5
        '
        'EmployeeMenuStrip
        '
        Me.EmployeeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDifferentEmployeeToolStripMenuItem})
        Me.EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        Me.EmployeeMenuStrip.Size = New System.Drawing.Size(210, 26)
        '
        'SelectDifferentEmployeeToolStripMenuItem
        '
        Me.SelectDifferentEmployeeToolStripMenuItem.Name = "SelectDifferentEmployeeToolStripMenuItem"
        Me.SelectDifferentEmployeeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SelectDifferentEmployeeToolStripMenuItem.Text = "Select Different Employee"
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
        Me.Controls.Add(Me.lbl_empid)
        Me.Controls.Add(Me.txt_boxes)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.txt_contnote)
        Me.Controls.Add(Me.txt_clientinfo)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.txt_accountid)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.txt_phone2)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.txt_floor)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.cbox_buildings)
        Me.Controls.Add(Me.dtpick_exdate)
        Me.Controls.Add(Me.lbl_contractid)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_phone1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_newContract"
        Me.Text = "New Contract"
        CType(Me.txt_floor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountsMenuStrip.ResumeLayout(False)
        Me.BoxesMenuStrip.ResumeLayout(False)
        Me.EmployeeMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_phone1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_contractid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpick_exdate As DateTimePicker
    Friend WithEvents cbox_buildings As ComboBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_floor As NumericUpDown
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_phone2 As TextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_accountid As TextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_clientinfo As TextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_contnote As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents txt_boxes As TextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_empid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AccountsMenuStrip As ContextMenuStrip
    Friend WithEvents SelectAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoxesMenuStrip As ContextMenuStrip
    Friend WithEvents SelectBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_regions As ComboBox
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_streets As ComboBox
    Friend WithEvents EmployeeMenuStrip As ContextMenuStrip
    Friend WithEvents SelectDifferentEmployeeToolStripMenuItem As ToolStripMenuItem
End Class
