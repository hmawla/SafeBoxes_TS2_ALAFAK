﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewInfoVoucher
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
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.ClientSelector = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectClientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_clientid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_clientname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_phonenumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.chk_phone = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chk_mailpost = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txt_mailpost = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.chk_email = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txt_email = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.chk_other = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txt_otherconn = New MaterialSkin.Controls.MaterialSingleLineTextField()
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
        Me.StreetsMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifyStreetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteStreetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_regions = New System.Windows.Forms.ComboBox()
        Me.RegionMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifyRegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_buildings = New System.Windows.Forms.ComboBox()
        Me.BuildingsMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifySelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBuildingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_subjectbody = New System.Windows.Forms.TextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_subjecttitles = New System.Windows.Forms.ComboBox()
        Me.SubjectTitlesMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ModifyTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSubjectTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_contractid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ContractSelector = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.SelectContractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_submit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ClientSelector.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StreetsMenuStrip.SuspendLayout()
        Me.RegionMenuStrip.SuspendLayout()
        Me.BuildingsMenuStrip.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SubjectTitlesMenuStrip.SuspendLayout()
        Me.ContractSelector.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.ContextMenuStrip = Me.ClientSelector
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(15, 79)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel5.TabIndex = 57
        Me.MaterialLabel5.Text = "Client ID:"
        '
        'ClientSelector
        '
        Me.ClientSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSelector.Depth = 0
        Me.ClientSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectClientToolStripMenuItem1})
        Me.ClientSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClientSelector.Name = "MaterialContextMenuStrip1"
        Me.ClientSelector.Size = New System.Drawing.Size(140, 26)
        '
        'SelectClientToolStripMenuItem1
        '
        Me.SelectClientToolStripMenuItem1.Name = "SelectClientToolStripMenuItem1"
        Me.SelectClientToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.SelectClientToolStripMenuItem1.Text = "Select Client"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(119, 79)
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
        Me.txt_clientid.Depth = 0
        Me.txt_clientid.Hint = ""
        Me.txt_clientid.Location = New System.Drawing.Point(19, 103)
        Me.txt_clientid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_clientid.MaxLength = 32767
        Me.txt_clientid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_clientid.Name = "txt_clientid"
        Me.txt_clientid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_clientid.SelectedText = ""
        Me.txt_clientid.SelectionLength = 0
        Me.txt_clientid.SelectionStart = 0
        Me.txt_clientid.Size = New System.Drawing.Size(96, 23)
        Me.txt_clientid.TabIndex = 56
        Me.txt_clientid.TabStop = False
        Me.txt_clientid.UseSystemPasswordChar = False
        '
        'txt_clientname
        '
        Me.txt_clientname.Depth = 0
        Me.txt_clientname.Enabled = False
        Me.txt_clientname.Hint = ""
        Me.txt_clientname.Location = New System.Drawing.Point(123, 103)
        Me.txt_clientname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_clientname.MaxLength = 32767
        Me.txt_clientname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_clientname.Name = "txt_clientname"
        Me.txt_clientname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_clientname.SelectedText = ""
        Me.txt_clientname.SelectionLength = 0
        Me.txt_clientname.SelectionStart = 0
        Me.txt_clientname.Size = New System.Drawing.Size(175, 23)
        Me.txt_clientname.TabIndex = 58
        Me.txt_clientname.TabStop = False
        Me.txt_clientname.UseSystemPasswordChar = False
        '
        'txt_phonenumber
        '
        Me.txt_phonenumber.Depth = 0
        Me.txt_phonenumber.Enabled = False
        Me.txt_phonenumber.Hint = ""
        Me.txt_phonenumber.Location = New System.Drawing.Point(6, 57)
        Me.txt_phonenumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_phonenumber.MaxLength = 32767
        Me.txt_phonenumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_phonenumber.Name = "txt_phonenumber"
        Me.txt_phonenumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phonenumber.SelectedText = ""
        Me.txt_phonenumber.SelectionLength = 0
        Me.txt_phonenumber.SelectionStart = 0
        Me.txt_phonenumber.Size = New System.Drawing.Size(156, 23)
        Me.txt_phonenumber.TabIndex = 60
        Me.txt_phonenumber.TabStop = False
        Me.txt_phonenumber.UseSystemPasswordChar = False
        '
        'chk_phone
        '
        Me.chk_phone.AutoSize = True
        Me.chk_phone.Depth = 0
        Me.chk_phone.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chk_phone.Location = New System.Drawing.Point(6, 25)
        Me.chk_phone.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_phone.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chk_phone.MouseState = MaterialSkin.MouseState.HOVER
        Me.chk_phone.Name = "chk_phone"
        Me.chk_phone.Ripple = True
        Me.chk_phone.Size = New System.Drawing.Size(125, 30)
        Me.chk_phone.TabIndex = 62
        Me.chk_phone.Text = "Phone Number:"
        Me.chk_phone.UseVisualStyleBackColor = True
        '
        'chk_mailpost
        '
        Me.chk_mailpost.AutoSize = True
        Me.chk_mailpost.Depth = 0
        Me.chk_mailpost.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chk_mailpost.Location = New System.Drawing.Point(170, 25)
        Me.chk_mailpost.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_mailpost.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chk_mailpost.MouseState = MaterialSkin.MouseState.HOVER
        Me.chk_mailpost.Name = "chk_mailpost"
        Me.chk_mailpost.Ripple = True
        Me.chk_mailpost.Size = New System.Drawing.Size(144, 30)
        Me.chk_mailpost.TabIndex = 64
        Me.chk_mailpost.Text = "Mail Post Number:"
        Me.chk_mailpost.UseVisualStyleBackColor = True
        '
        'txt_mailpost
        '
        Me.txt_mailpost.Depth = 0
        Me.txt_mailpost.Enabled = False
        Me.txt_mailpost.Hint = ""
        Me.txt_mailpost.Location = New System.Drawing.Point(170, 57)
        Me.txt_mailpost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_mailpost.MaxLength = 32767
        Me.txt_mailpost.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_mailpost.Name = "txt_mailpost"
        Me.txt_mailpost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mailpost.SelectedText = ""
        Me.txt_mailpost.SelectionLength = 0
        Me.txt_mailpost.SelectionStart = 0
        Me.txt_mailpost.Size = New System.Drawing.Size(156, 23)
        Me.txt_mailpost.TabIndex = 63
        Me.txt_mailpost.TabStop = False
        Me.txt_mailpost.UseSystemPasswordChar = False
        '
        'chk_email
        '
        Me.chk_email.AutoSize = True
        Me.chk_email.Depth = 0
        Me.chk_email.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chk_email.Location = New System.Drawing.Point(334, 25)
        Me.chk_email.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_email.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chk_email.MouseState = MaterialSkin.MouseState.HOVER
        Me.chk_email.Name = "chk_email"
        Me.chk_email.Ripple = True
        Me.chk_email.Size = New System.Drawing.Size(68, 30)
        Me.chk_email.TabIndex = 66
        Me.chk_email.Text = "Email:"
        Me.chk_email.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Depth = 0
        Me.txt_email.Enabled = False
        Me.txt_email.Hint = ""
        Me.txt_email.Location = New System.Drawing.Point(334, 57)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.SelectedText = ""
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.Size = New System.Drawing.Size(156, 23)
        Me.txt_email.TabIndex = 65
        Me.txt_email.TabStop = False
        Me.txt_email.UseSystemPasswordChar = False
        '
        'chk_other
        '
        Me.chk_other.AutoSize = True
        Me.chk_other.Depth = 0
        Me.chk_other.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chk_other.Location = New System.Drawing.Point(6, 91)
        Me.chk_other.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_other.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chk_other.MouseState = MaterialSkin.MouseState.HOVER
        Me.chk_other.Name = "chk_other"
        Me.chk_other.Ripple = True
        Me.chk_other.Size = New System.Drawing.Size(67, 30)
        Me.chk_other.TabIndex = 68
        Me.chk_other.Text = "Other:"
        Me.chk_other.UseVisualStyleBackColor = True
        '
        'txt_otherconn
        '
        Me.txt_otherconn.Depth = 0
        Me.txt_otherconn.Enabled = False
        Me.txt_otherconn.Hint = ""
        Me.txt_otherconn.Location = New System.Drawing.Point(6, 123)
        Me.txt_otherconn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_otherconn.MaxLength = 32767
        Me.txt_otherconn.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_otherconn.Name = "txt_otherconn"
        Me.txt_otherconn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_otherconn.SelectedText = ""
        Me.txt_otherconn.SelectionLength = 0
        Me.txt_otherconn.SelectionStart = 0
        Me.txt_otherconn.Size = New System.Drawing.Size(484, 23)
        Me.txt_otherconn.TabIndex = 67
        Me.txt_otherconn.TabStop = False
        Me.txt_otherconn.UseSystemPasswordChar = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(547, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 180)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Ways"
        '
        'dtpick_fromtime
        '
        Me.dtpick_fromtime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_fromtime.CustomFormat = "HH:mm"
        Me.dtpick_fromtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_fromtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpick_fromtime.Location = New System.Drawing.Point(13, 44)
        Me.dtpick_fromtime.Name = "dtpick_fromtime"
        Me.dtpick_fromtime.ShowUpDown = True
        Me.dtpick_fromtime.Size = New System.Drawing.Size(139, 26)
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
        Me.GroupBox2.Location = New System.Drawing.Point(547, 84)
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
        Me.dtpick_totime.ShowUpDown = True
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
        Me.cbox_streets.ContextMenuStrip = Me.StreetsMenuStrip
        Me.cbox_streets.ForeColor = System.Drawing.Color.Black
        Me.cbox_streets.FormattingEnabled = True
        Me.cbox_streets.Location = New System.Drawing.Point(166, 51)
        Me.cbox_streets.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_streets.Name = "cbox_streets"
        Me.cbox_streets.Size = New System.Drawing.Size(148, 28)
        Me.cbox_streets.TabIndex = 74
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
        Me.cbox_regions.ContextMenuStrip = Me.RegionMenuStrip
        Me.cbox_regions.ForeColor = System.Drawing.Color.Black
        Me.cbox_regions.FormattingEnabled = True
        Me.cbox_regions.Location = New System.Drawing.Point(10, 51)
        Me.cbox_regions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_regions.Name = "cbox_regions"
        Me.cbox_regions.Size = New System.Drawing.Size(148, 28)
        Me.cbox_regions.TabIndex = 73
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
        Me.cbox_buildings.ContextMenuStrip = Me.BuildingsMenuStrip
        Me.cbox_buildings.ForeColor = System.Drawing.Color.Black
        Me.cbox_buildings.FormattingEnabled = True
        Me.cbox_buildings.Location = New System.Drawing.Point(322, 51)
        Me.cbox_buildings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbox_buildings.Name = "cbox_buildings"
        Me.cbox_buildings.Size = New System.Drawing.Size(148, 28)
        Me.cbox_buildings.TabIndex = 75
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel12)
        Me.GroupBox3.Controls.Add(Me.cbox_buildings)
        Me.GroupBox3.Controls.Add(Me.cbox_streets)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel7)
        Me.GroupBox3.Controls.Add(Me.cbox_regions)
        Me.GroupBox3.Location = New System.Drawing.Point(547, 269)
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
        Me.MaterialLabel8.Location = New System.Drawing.Point(15, 134)
        Me.MaterialLabel8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(97, 19)
        Me.MaterialLabel8.TabIndex = 80
        Me.MaterialLabel8.Text = "Subject Title:"
        '
        'txt_subjectbody
        '
        Me.txt_subjectbody.Location = New System.Drawing.Point(19, 213)
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
        Me.MaterialLabel9.Location = New System.Drawing.Point(15, 189)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(100, 19)
        Me.MaterialLabel9.TabIndex = 82
        Me.MaterialLabel9.Text = "Subject Body:"
        '
        'cbox_subjecttitles
        '
        Me.cbox_subjecttitles.ContextMenuStrip = Me.SubjectTitlesMenuStrip
        Me.cbox_subjecttitles.FormattingEnabled = True
        Me.cbox_subjecttitles.Location = New System.Drawing.Point(19, 156)
        Me.cbox_subjecttitles.Name = "cbox_subjecttitles"
        Me.cbox_subjecttitles.Size = New System.Drawing.Size(521, 28)
        Me.cbox_subjecttitles.TabIndex = 84
        '
        'SubjectTitlesMenuStrip
        '
        Me.SubjectTitlesMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTitlesMenuStrip.Depth = 0
        Me.SubjectTitlesMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyTitleToolStripMenuItem, Me.DeleteSubjectTitleToolStripMenuItem})
        Me.SubjectTitlesMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.SubjectTitlesMenuStrip.Name = "SubjectTitlesMenuStrip"
        Me.SubjectTitlesMenuStrip.Size = New System.Drawing.Size(181, 48)
        '
        'ModifyTitleToolStripMenuItem
        '
        Me.ModifyTitleToolStripMenuItem.Name = "ModifyTitleToolStripMenuItem"
        Me.ModifyTitleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModifyTitleToolStripMenuItem.Text = "Modify Subject Title"
        '
        'DeleteSubjectTitleToolStripMenuItem
        '
        Me.DeleteSubjectTitleToolStripMenuItem.Name = "DeleteSubjectTitleToolStripMenuItem"
        Me.DeleteSubjectTitleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteSubjectTitleToolStripMenuItem.Text = "Delete Subject Title"
        '
        'txt_contractid
        '
        Me.txt_contractid.ContextMenuStrip = Me.ContractSelector
        Me.txt_contractid.Depth = 0
        Me.txt_contractid.Hint = ""
        Me.txt_contractid.Location = New System.Drawing.Point(306, 103)
        Me.txt_contractid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_contractid.MaxLength = 32767
        Me.txt_contractid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_contractid.Name = "txt_contractid"
        Me.txt_contractid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contractid.SelectedText = ""
        Me.txt_contractid.SelectionLength = 0
        Me.txt_contractid.SelectionStart = 0
        Me.txt_contractid.Size = New System.Drawing.Size(134, 23)
        Me.txt_contractid.TabIndex = 86
        Me.txt_contractid.TabStop = False
        Me.txt_contractid.UseSystemPasswordChar = False
        '
        'ContractSelector
        '
        Me.ContractSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContractSelector.Depth = 0
        Me.ContractSelector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectContractToolStripMenuItem})
        Me.ContractSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.ContractSelector.Name = "ContractSelector"
        Me.ContractSelector.Size = New System.Drawing.Size(155, 26)
        '
        'SelectContractToolStripMenuItem
        '
        Me.SelectContractToolStripMenuItem.Name = "SelectContractToolStripMenuItem"
        Me.SelectContractToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SelectContractToolStripMenuItem.Text = "Select Contract"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.ContextMenuStrip = Me.ContractSelector
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(302, 79)
        Me.MaterialLabel10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(89, 19)
        Me.MaterialLabel10.TabIndex = 87
        Me.MaterialLabel10.Text = "Contract ID:"
        '
        'btn_submit
        '
        Me.btn_submit.AutoSize = True
        Me.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_submit.Depth = 0
        Me.btn_submit.Icon = Nothing
        Me.btn_submit.Location = New System.Drawing.Point(447, 97)
        Me.btn_submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Primary = True
        Me.btn_submit.Size = New System.Drawing.Size(71, 36)
        Me.btn_submit.TabIndex = 88
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Frm_NewInfoVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 627)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.txt_contractid)
        Me.Controls.Add(Me.cbox_subjecttitles)
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
        Me.MaximizeBox = False
        Me.Name = "Frm_NewInfoVoucher"
        Me.Sizable = False
        Me.Text = "Info Voucher"
        Me.ClientSelector.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StreetsMenuStrip.ResumeLayout(False)
        Me.RegionMenuStrip.ResumeLayout(False)
        Me.BuildingsMenuStrip.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SubjectTitlesMenuStrip.ResumeLayout(False)
        Me.ContractSelector.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_clientid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_clientname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_phonenumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents chk_phone As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chk_mailpost As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txt_mailpost As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents chk_email As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txt_email As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents chk_other As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txt_otherconn As MaterialSkin.Controls.MaterialSingleLineTextField
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
    Friend WithEvents cbox_subjecttitles As ComboBox
    Friend WithEvents txt_contractid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_submit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ClientSelector As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectClientToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContractSelector As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents SelectContractToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectTitlesMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifyTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSubjectTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StreetsMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifyStreetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStreetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegionMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifyRegionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRegionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildingsMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ModifySelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteBuildingToolStripMenuItem As ToolStripMenuItem
End Class
