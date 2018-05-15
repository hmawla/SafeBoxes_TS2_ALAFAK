<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Employees
    Inherits System.Windows.Forms.Form

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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.btn_modEmp = New System.Windows.Forms.Button()
        Me.btn_delEmp = New System.Windows.Forms.Button()
        Me.btn_newEmp = New System.Windows.Forms.Button()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byEmpName = New System.Windows.Forms.RadioButton()
        Me.txt_byEmpname = New System.Windows.Forms.TextBox()
        Me.txt_byEmpid = New System.Windows.Forms.TextBox()
        Me.rdb_byEmpid = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
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
        Me.dgv_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_employees.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_employees.Location = New System.Drawing.Point(13, 208)
        Me.dgv_employees.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_employees.MultiSelect = False
        Me.dgv_employees.Name = "dgv_employees"
        Me.dgv_employees.ReadOnly = True
        Me.dgv_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_employees.RowHeadersVisible = False
        Me.dgv_employees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_employees.Size = New System.Drawing.Size(657, 352)
        Me.dgv_employees.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Location = New System.Drawing.Point(13, 14)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(659, 185)
        Me.TabControl1.TabIndex = 11
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modEmp)
        Me.tab_datacontrol.Controls.Add(Me.btn_delEmp)
        Me.tab_datacontrol.Controls.Add(Me.btn_newEmp)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Size = New System.Drawing.Size(651, 152)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(163, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'txt_details
        '
        Me.txt_details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_details.Location = New System.Drawing.Point(167, 30)
        Me.txt_details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(476, 107)
        Me.txt_details.TabIndex = 3
        '
        'btn_modEmp
        '
        Me.btn_modEmp.Location = New System.Drawing.Point(8, 69)
        Me.btn_modEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modEmp.Name = "btn_modEmp"
        Me.btn_modEmp.Size = New System.Drawing.Size(151, 29)
        Me.btn_modEmp.TabIndex = 2
        Me.btn_modEmp.Text = "Modify Selected"
        Me.btn_modEmp.UseVisualStyleBackColor = True
        '
        'btn_delEmp
        '
        Me.btn_delEmp.Location = New System.Drawing.Point(8, 108)
        Me.btn_delEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delEmp.Name = "btn_delEmp"
        Me.btn_delEmp.Size = New System.Drawing.Size(151, 29)
        Me.btn_delEmp.TabIndex = 1
        Me.btn_delEmp.Text = "Delete Selected"
        Me.btn_delEmp.UseVisualStyleBackColor = True
        '
        'btn_newEmp
        '
        Me.btn_newEmp.Location = New System.Drawing.Point(8, 30)
        Me.btn_newEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newEmp.Name = "btn_newEmp"
        Me.btn_newEmp.Size = New System.Drawing.Size(151, 29)
        Me.btn_newEmp.TabIndex = 0
        Me.btn_newEmp.Text = "Add new"
        Me.btn_newEmp.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byEmpName)
        Me.tab_filter.Controls.Add(Me.txt_byEmpname)
        Me.tab_filter.Controls.Add(Me.txt_byEmpid)
        Me.tab_filter.Controls.Add(Me.rdb_byEmpid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Size = New System.Drawing.Size(651, 152)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(606, 90)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(36, 54)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(489, 90)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 54)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byEmpName
        '
        Me.rdb_byEmpName.AutoSize = True
        Me.rdb_byEmpName.Location = New System.Drawing.Point(317, 9)
        Me.rdb_byEmpName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byEmpName.Name = "rdb_byEmpName"
        Me.rdb_byEmpName.Size = New System.Drawing.Size(165, 24)
        Me.rdb_byEmpName.TabIndex = 11
        Me.rdb_byEmpName.Text = "By Employee Name"
        Me.rdb_byEmpName.UseVisualStyleBackColor = True
        '
        'txt_byEmpname
        '
        Me.txt_byEmpname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byEmpname.Enabled = False
        Me.txt_byEmpname.Location = New System.Drawing.Point(317, 58)
        Me.txt_byEmpname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byEmpname.Name = "txt_byEmpname"
        Me.txt_byEmpname.Size = New System.Drawing.Size(324, 26)
        Me.txt_byEmpname.TabIndex = 10
        '
        'txt_byEmpid
        '
        Me.txt_byEmpid.Enabled = False
        Me.txt_byEmpid.Location = New System.Drawing.Point(9, 58)
        Me.txt_byEmpid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_byEmpid.Name = "txt_byEmpid"
        Me.txt_byEmpid.Size = New System.Drawing.Size(299, 26)
        Me.txt_byEmpid.TabIndex = 8
        '
        'rdb_byEmpid
        '
        Me.rdb_byEmpid.Location = New System.Drawing.Point(9, 9)
        Me.rdb_byEmpid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byEmpid.Name = "rdb_byEmpid"
        Me.rdb_byEmpid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byEmpid.TabIndex = 13
        Me.rdb_byEmpid.Text = "By Employee ID"
        '
        'Frm_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(685, 577)
        Me.Controls.Add(Me.dgv_employees)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Employees"
        Me.Text = "Employees Management"
        CType(Me.dgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_employees As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modEmp As Button
    Friend WithEvents btn_delEmp As Button
    Friend WithEvents btn_newEmp As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byEmpName As RadioButton
    Friend WithEvents txt_byEmpname As TextBox
    Friend WithEvents txt_byEmpid As TextBox
    Friend WithEvents rdb_byEmpid As RadioButton
End Class
