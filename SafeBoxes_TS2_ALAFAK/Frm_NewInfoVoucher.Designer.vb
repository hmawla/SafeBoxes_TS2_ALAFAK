<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewInfoVoucher
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
        Me.components = New System.ComponentModel.Container()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_clientid = New System.Windows.Forms.TextBox()
        Me.ClientSelector = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_clientname = New System.Windows.Forms.TextBox()
        Me.txt_phonenumber = New System.Windows.Forms.TextBox()
        Me.chk_phone = New System.Windows.Forms.CheckBox()
        Me.chk_mailpost = New System.Windows.Forms.CheckBox()
        Me.txt_mailpost = New System.Windows.Forms.TextBox()
        Me.chk_email = New System.Windows.Forms.CheckBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.chk_other = New System.Windows.Forms.CheckBox()
        Me.txt_otherconn = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpick_fromtime = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.chklist_exceptdays = New System.Windows.Forms.CheckedListBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpick_totime = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_streets = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_buildings = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_subjectbody = New System.Windows.Forms.TextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cbox_subjecttitles = New System.Windows.Forms.ComboBox()
        Me.txt_contractid = New System.Windows.Forms.TextBox()
        Me.ContractSelector = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewContractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.ClientSelector.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ContractSelector.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(15, 9)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel5.TabIndex = 57
        Me.MaterialLabel5.Text = "Client ID:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(119, 9)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel1.TabIndex = 59
        Me.MaterialLabel1.Text = "Client Name:"
        '
        'txt_clientid
        '
        Me.txt_clientid.ContextMenuStrip = Me.ClientSelector
        Me.txt_clientid.Location = New System.Drawing.Point(19, 33)
        Me.txt_clientid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_clientid.Name = "txt_clientid"
        Me.txt_clientid.Size = New System.Drawing.Size(96, 26)
        Me.txt_clientid.TabIndex = 56
        '
        'ClientSelector
        '
        Me.ClientSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem, Me.NewClientToolStripMenuItem})
        Me.ClientSelector.Name = "ContextMenuStrip1"
        Me.ClientSelector.Size = New System.Drawing.Size(140, 48)
        '
        'SelectClientToolStripMenuItem
        '
        Me.SelectClientToolStripMenuItem.Name = "SelectClientToolStripMenuItem"
        Me.SelectClientToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SelectClientToolStripMenuItem.Text = "Select Client"
        '
        'NewClientToolStripMenuItem
        '
        Me.NewClientToolStripMenuItem.Name = "NewClientToolStripMenuItem"
        Me.NewClientToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.NewClientToolStripMenuItem.Text = "New Client"
        '
        'txt_clientname
        '
        Me.txt_clientname.Location = New System.Drawing.Point(123, 33)
        Me.txt_clientname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_clientname.Name = "txt_clientname"
        Me.txt_clientname.ReadOnly = True
        Me.txt_clientname.Size = New System.Drawing.Size(175, 26)
        Me.txt_clientname.TabIndex = 58
        '
        'txt_phonenumber
        '
        Me.txt_phonenumber.Enabled = False
        Me.txt_phonenumber.Location = New System.Drawing.Point(6, 57)
        Me.txt_phonenumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_phonenumber.Name = "txt_phonenumber"
        Me.txt_phonenumber.Size = New System.Drawing.Size(156, 26)
        Me.txt_phonenumber.TabIndex = 60
        '
        'chk_phone
        '
        Me.chk_phone.AutoSize = True
        Me.chk_phone.Location = New System.Drawing.Point(6, 25)
        Me.chk_phone.Name = "chk_phone"
        Me.chk_phone.Size = New System.Drawing.Size(138, 24)
        Me.chk_phone.TabIndex = 62
        Me.chk_phone.Text = "Phone Number:"
        Me.chk_phone.UseVisualStyleBackColor = True
        '
        'chk_mailpost
        '
        Me.chk_mailpost.AutoSize = True
        Me.chk_mailpost.Location = New System.Drawing.Point(170, 25)
        Me.chk_mailpost.Name = "chk_mailpost"
        Me.chk_mailpost.Size = New System.Drawing.Size(156, 24)
        Me.chk_mailpost.TabIndex = 64
        Me.chk_mailpost.Text = "Mail Post Number:"
        Me.chk_mailpost.UseVisualStyleBackColor = True
        '
        'txt_mailpost
        '
        Me.txt_mailpost.Enabled = False
        Me.txt_mailpost.Location = New System.Drawing.Point(170, 57)
        Me.txt_mailpost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_mailpost.Name = "txt_mailpost"
        Me.txt_mailpost.Size = New System.Drawing.Size(156, 26)
        Me.txt_mailpost.TabIndex = 63
        '
        'chk_email
        '
        Me.chk_email.AutoSize = True
        Me.chk_email.Location = New System.Drawing.Point(334, 25)
        Me.chk_email.Name = "chk_email"
        Me.chk_email.Size = New System.Drawing.Size(71, 24)
        Me.chk_email.TabIndex = 66
        Me.chk_email.Text = "Email:"
        Me.chk_email.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(334, 57)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(156, 26)
        Me.txt_email.TabIndex = 65
        '
        'chk_other
        '
        Me.chk_other.AutoSize = True
        Me.chk_other.Location = New System.Drawing.Point(6, 91)
        Me.chk_other.Name = "chk_other"
        Me.chk_other.Size = New System.Drawing.Size(72, 24)
        Me.chk_other.TabIndex = 68
        Me.chk_other.Text = "Other:"
        Me.chk_other.UseVisualStyleBackColor = True
        '
        'txt_otherconn
        '
        Me.txt_otherconn.Enabled = False
        Me.txt_otherconn.Location = New System.Drawing.Point(6, 123)
        Me.txt_otherconn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_otherconn.Name = "txt_otherconn"
        Me.txt_otherconn.Size = New System.Drawing.Size(484, 26)
        Me.txt_otherconn.TabIndex = 67
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_phone)
        Me.GroupBox1.Controls.Add(Me.chk_other)
        Me.GroupBox1.Controls.Add(Me.txt_phonenumber)
        Me.GroupBox1.Controls.Add(Me.txt_otherconn)
        Me.GroupBox1.Controls.Add(Me.txt_mailpost)
        Me.GroupBox1.Controls.Add(Me.chk_email)
        Me.GroupBox1.Controls.Add(Me.chk_mailpost)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Location = New System.Drawing.Point(547, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 180)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Ways"
        '
        'dtpick_fromtime
        '
        Me.dtpick_fromtime.CalendarFont = New System.Drawing.Font("Roboto", 12.0!)
        Me.dtpick_fromtime.CustomFormat = "HH:mm"
        Me.dtpick_fromtime.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.dtpick_fromtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpick_fromtime.Location = New System.Drawing.Point(13, 44)
        Me.dtpick_fromtime.Name = "dtpick_fromtime"
        Me.dtpick_fromtime.Size = New System.Drawing.Size(139, 27)
        Me.dtpick_fromtime.TabIndex = 70
        Me.dtpick_fromtime.Value = New Date(2018, 5, 20, 0, 0, 0, 0)
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(9, 22)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(48, 19)
        Me.MaterialLabel2.TabIndex = 71
        Me.MaterialLabel2.Text = "From:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox2.Controls.Add(Me.chklist_exceptdays)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox2.Controls.Add(Me.dtpick_totime)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox2.Controls.Add(Me.dtpick_fromtime)
        Me.GroupBox2.Location = New System.Drawing.Point(547, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 179)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Time"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(8, 87)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(58, 19)
        Me.MaterialLabel4.TabIndex = 75
        Me.MaterialLabel4.Text = "Except:"
        '
        'chklist_exceptdays
        '
        Me.chklist_exceptdays.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chklist_exceptdays.FormattingEnabled = True
        Me.chklist_exceptdays.Location = New System.Drawing.Point(3, 109)
        Me.chklist_exceptdays.MultiColumn = True
        Me.chklist_exceptdays.Name = "chklist_exceptdays"
        Me.chklist_exceptdays.Size = New System.Drawing.Size(516, 67)
        Me.chklist_exceptdays.TabIndex = 74
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(154, 22)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(31, 19)
        Me.MaterialLabel3.TabIndex = 73
        Me.MaterialLabel3.Text = "To:"
        '
        'dtpick_totime
        '
        Me.dtpick_totime.CustomFormat = "HH:mm"
        Me.dtpick_totime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpick_totime.Location = New System.Drawing.Point(158, 44)
        Me.dtpick_totime.Name = "dtpick_totime"
        Me.dtpick_totime.Size = New System.Drawing.Size(139, 26)
        Me.dtpick_totime.TabIndex = 72
        Me.dtpick_totime.Value = New Date(2018, 5, 20, 23, 59, 0, 0)
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(319, 29)
        Me.MaterialLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel12.TabIndex = 78
        Me.MaterialLabel12.Text = "Building:*"
        '
        'cbox_streets
        '
        Me.cbox_streets.BackColor = System.Drawing.Color.White
        Me.cbox_streets.ForeColor = System.Drawing.Color.Black
        Me.cbox_streets.FormattingEnabled = True
        Me.cbox_streets.Location = New System.Drawing.Point(166, 51)
        Me.cbox_streets.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_streets.Name = "cbox_streets"
        Me.cbox_streets.Size = New System.Drawing.Size(148, 28)
        Me.cbox_streets.TabIndex = 74
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(7, 29)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel6.TabIndex = 77
        Me.MaterialLabel6.Text = "Region*:"
        '
        'cbox_regions
        '
        Me.cbox_regions.BackColor = System.Drawing.Color.White
        Me.cbox_regions.ForeColor = System.Drawing.Color.Black
        Me.cbox_regions.FormattingEnabled = True
        Me.cbox_regions.Location = New System.Drawing.Point(10, 51)
        Me.cbox_regions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_regions.Name = "cbox_regions"
        Me.cbox_regions.Size = New System.Drawing.Size(148, 28)
        Me.cbox_regions.TabIndex = 73
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(163, 29)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel7.TabIndex = 76
        Me.MaterialLabel7.Text = "Street*:"
        '
        'cbox_buildings
        '
        Me.cbox_buildings.BackColor = System.Drawing.Color.White
        Me.cbox_buildings.ForeColor = System.Drawing.Color.Black
        Me.cbox_buildings.FormattingEnabled = True
        Me.cbox_buildings.Location = New System.Drawing.Point(322, 51)
        Me.cbox_buildings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_buildings.Name = "cbox_buildings"
        Me.cbox_buildings.Size = New System.Drawing.Size(148, 28)
        Me.cbox_buildings.TabIndex = 75
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel12)
        Me.GroupBox3.Controls.Add(Me.cbox_buildings)
        Me.GroupBox3.Controls.Add(Me.cbox_streets)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel7)
        Me.GroupBox3.Controls.Add(Me.cbox_regions)
        Me.GroupBox3.Location = New System.Drawing.Point(547, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(522, 100)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Address"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(15, 64)
        Me.MaterialLabel8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(97, 19)
        Me.MaterialLabel8.TabIndex = 80
        Me.MaterialLabel8.Text = "Subject Title:"
        '
        'txt_subjectbody
        '
        Me.txt_subjectbody.Location = New System.Drawing.Point(19, 143)
        Me.txt_subjectbody.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_subjectbody.Multiline = True
        Me.txt_subjectbody.Name = "txt_subjectbody"
        Me.txt_subjectbody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_subjectbody.Size = New System.Drawing.Size(521, 342)
        Me.txt_subjectbody.TabIndex = 81
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(15, 119)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(100, 19)
        Me.MaterialLabel9.TabIndex = 82
        Me.MaterialLabel9.Text = "Subject Body:"
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(447, 29)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(93, 34)
        Me.btn_submit.TabIndex = 83
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'cbox_subjecttitles
        '
        Me.cbox_subjecttitles.FormattingEnabled = True
        Me.cbox_subjecttitles.Location = New System.Drawing.Point(19, 86)
        Me.cbox_subjecttitles.Name = "cbox_subjecttitles"
        Me.cbox_subjecttitles.Size = New System.Drawing.Size(521, 28)
        Me.cbox_subjecttitles.TabIndex = 84
        '
        'txt_contractid
        '
        Me.txt_contractid.ContextMenuStrip = Me.ContractSelector
        Me.txt_contractid.Location = New System.Drawing.Point(306, 33)
        Me.txt_contractid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_contractid.Name = "txt_contractid"
        Me.txt_contractid.Size = New System.Drawing.Size(134, 26)
        Me.txt_contractid.TabIndex = 86
        '
        'ContractSelector
        '
        Me.ContractSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContraToolStripMenuItem, Me.NewContractToolStripMenuItem})
        Me.ContractSelector.Name = "ContractSelector"
        Me.ContractSelector.Size = New System.Drawing.Size(155, 48)
        '
        'ContraToolStripMenuItem
        '
        Me.ContraToolStripMenuItem.Name = "ContraToolStripMenuItem"
        Me.ContraToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ContraToolStripMenuItem.Text = "Select Contract"
        '
        'NewContractToolStripMenuItem
        '
        Me.NewContractToolStripMenuItem.Name = "NewContractToolStripMenuItem"
        Me.NewContractToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewContractToolStripMenuItem.Text = "New Contract"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(302, 9)
        Me.MaterialLabel10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(89, 19)
        Me.MaterialLabel10.TabIndex = 87
        Me.MaterialLabel10.Text = "Contract ID:"
        '
        'Frm_NewInfoVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 501)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.txt_contractid)
        Me.Controls.Add(Me.cbox_subjecttitles)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.txt_subjectbody)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txt_clientid)
        Me.Controls.Add(Me.txt_clientname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_NewInfoVoucher"
        Me.Text = "Info Voucher"
        Me.ClientSelector.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContractSelector.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_clientid As TextBox
    Friend WithEvents txt_clientname As TextBox
    Friend WithEvents txt_phonenumber As TextBox
    Friend WithEvents chk_phone As CheckBox
    Friend WithEvents chk_mailpost As CheckBox
    Friend WithEvents txt_mailpost As TextBox
    Friend WithEvents chk_email As CheckBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents chk_other As CheckBox
    Friend WithEvents txt_otherconn As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpick_fromtime As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chklist_exceptdays As CheckedListBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpick_totime As DateTimePicker
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_streets As ComboBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_regions As ComboBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbox_buildings As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_subjectbody As TextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submit As Button
    Friend WithEvents cbox_subjecttitles As ComboBox
    Friend WithEvents ClientSelector As ContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_contractid As TextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ContractSelector As ContextMenuStrip
    Friend WithEvents ContraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewContractToolStripMenuItem As ToolStripMenuItem
End Class
