<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Employees
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.dgv_employees = New System.Windows.Forms.DataGridView()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_modEmp = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_newEmp = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_delEmp = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_byEmpname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdb_byEmpid = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txt_byEmpid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdb_byEmpName = New MaterialSkin.Controls.MaterialRadioButton()
        Me.EmployeesReport = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.EmployeesReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_employees
        '
        Me.dgv_employees.AllowUserToAddRows = False
        Me.dgv_employees.AllowUserToDeleteRows = False
        Me.dgv_employees.AllowUserToResizeRows = False
        Me.dgv_employees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_employees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_employees.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_employees.Location = New System.Drawing.Point(13, 297)
        Me.dgv_employees.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_employees.MultiSelect = False
        Me.dgv_employees.Name = "dgv_employees"
        Me.dgv_employees.ReadOnly = True
        Me.dgv_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_employees.RowHeadersVisible = False
        Me.dgv_employees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_employees.Size = New System.Drawing.Size(657, 263)
        Me.dgv_employees.TabIndex = 12
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-1, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(686, 36)
        Me.MaterialTabSelector1.TabIndex = 20
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(13, 106)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(660, 180)
        Me.MaterialTabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.btn_modEmp)
        Me.TabPage1.Controls.Add(Me.btn_newEmp)
        Me.TabPage1.Controls.Add(Me.btn_delEmp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(652, 147)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(7, 4)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Control"
        '
        'btn_modEmp
        '
        Me.btn_modEmp.AutoSize = True
        Me.btn_modEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_modEmp.Depth = 0
        Me.btn_modEmp.Icon = Nothing
        Me.btn_modEmp.Location = New System.Drawing.Point(7, 67)
        Me.btn_modEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modEmp.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_modEmp.Name = "btn_modEmp"
        Me.btn_modEmp.Primary = True
        Me.btn_modEmp.Size = New System.Drawing.Size(140, 36)
        Me.btn_modEmp.TabIndex = 2
        Me.btn_modEmp.Text = "Modify Selected"
        Me.btn_modEmp.UseVisualStyleBackColor = True
        '
        'btn_newEmp
        '
        Me.btn_newEmp.AutoSize = True
        Me.btn_newEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newEmp.Depth = 0
        Me.btn_newEmp.Icon = Nothing
        Me.btn_newEmp.Location = New System.Drawing.Point(7, 28)
        Me.btn_newEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newEmp.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newEmp.Name = "btn_newEmp"
        Me.btn_newEmp.Primary = True
        Me.btn_newEmp.Size = New System.Drawing.Size(81, 36)
        Me.btn_newEmp.TabIndex = 0
        Me.btn_newEmp.Text = "Add new"
        Me.btn_newEmp.UseVisualStyleBackColor = True
        '
        'btn_delEmp
        '
        Me.btn_delEmp.AutoSize = True
        Me.btn_delEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delEmp.Depth = 0
        Me.btn_delEmp.Icon = Nothing
        Me.btn_delEmp.Location = New System.Drawing.Point(7, 106)
        Me.btn_delEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delEmp.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_delEmp.Name = "btn_delEmp"
        Me.btn_delEmp.Primary = True
        Me.btn_delEmp.Size = New System.Drawing.Size(138, 36)
        Me.btn_delEmp.TabIndex = 6
        Me.btn_delEmp.Text = "Delete Selected"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txt_byEmpname)
        Me.TabPage2.Controls.Add(Me.rdb_byEmpid)
        Me.TabPage2.Controls.Add(Me.btn_reset)
        Me.TabPage2.Controls.Add(Me.txt_byEmpid)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.rdb_byEmpName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(652, 147)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter"
        '
        'txt_byEmpname
        '
        Me.txt_byEmpname.Depth = 0
        Me.txt_byEmpname.Enabled = False
        Me.txt_byEmpname.Hint = ""
        Me.txt_byEmpname.Location = New System.Drawing.Point(173, 62)
        Me.txt_byEmpname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byEmpname.MaxLength = 32767
        Me.txt_byEmpname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byEmpname.Name = "txt_byEmpname"
        Me.txt_byEmpname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byEmpname.SelectedText = ""
        Me.txt_byEmpname.SelectionLength = 0
        Me.txt_byEmpname.SelectionStart = 0
        Me.txt_byEmpname.Size = New System.Drawing.Size(352, 23)
        Me.txt_byEmpname.TabIndex = 14
        Me.txt_byEmpname.TabStop = False
        Me.txt_byEmpname.UseSystemPasswordChar = False
        '
        'rdb_byEmpid
        '
        Me.rdb_byEmpid.Depth = 0
        Me.rdb_byEmpid.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byEmpid.Location = New System.Drawing.Point(7, 8)
        Me.rdb_byEmpid.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byEmpid.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byEmpid.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byEmpid.Name = "rdb_byEmpid"
        Me.rdb_byEmpid.Ripple = True
        Me.rdb_byEmpid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byEmpid.TabIndex = 13
        Me.rdb_byEmpid.Text = "By Employee ID"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(591, 92)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_byEmpid
        '
        Me.txt_byEmpid.Depth = 0
        Me.txt_byEmpid.Enabled = False
        Me.txt_byEmpid.Hint = ""
        Me.txt_byEmpid.Location = New System.Drawing.Point(173, 13)
        Me.txt_byEmpid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byEmpid.MaxLength = 32767
        Me.txt_byEmpid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_byEmpid.Name = "txt_byEmpid"
        Me.txt_byEmpid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_byEmpid.SelectedText = ""
        Me.txt_byEmpid.SelectionLength = 0
        Me.txt_byEmpid.SelectionStart = 0
        Me.txt_byEmpid.Size = New System.Drawing.Size(352, 23)
        Me.txt_byEmpid.TabIndex = 8
        Me.txt_byEmpid.TabStop = False
        Me.txt_byEmpid.UseSystemPasswordChar = False
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(494, 92)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(64, 36)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byEmpName
        '
        Me.rdb_byEmpName.AutoSize = True
        Me.rdb_byEmpName.Depth = 0
        Me.rdb_byEmpName.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdb_byEmpName.Location = New System.Drawing.Point(7, 55)
        Me.rdb_byEmpName.Margin = New System.Windows.Forms.Padding(0)
        Me.rdb_byEmpName.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdb_byEmpName.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdb_byEmpName.Name = "rdb_byEmpName"
        Me.rdb_byEmpName.Ripple = True
        Me.rdb_byEmpName.Size = New System.Drawing.Size(148, 30)
        Me.rdb_byEmpName.TabIndex = 11
        Me.rdb_byEmpName.Text = "By Employee Name"
        Me.rdb_byEmpName.UseVisualStyleBackColor = True
        '
        'EmployeesReport
        '
        Me.EmployeesReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmployeesReport.Depth = 0
        Me.EmployeesReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.EmployeesReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.EmployeesReport.Name = "EmployeesReport"
        Me.EmployeesReport.Size = New System.Drawing.Size(181, 48)
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'Frm_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(685, 577)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgv_employees)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Employees"
        Me.Text = "Employees Management"
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.EmployeesReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_employees As DataGridView
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_modEmp As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_newEmp As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_delEmp As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_byEmpname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdb_byEmpid As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txt_byEmpid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdb_byEmpName As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents EmployeesReport As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
End Class
