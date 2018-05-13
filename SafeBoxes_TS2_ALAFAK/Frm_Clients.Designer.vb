<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clients
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
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.txt_bycid = New System.Windows.Forms.TextBox()
        Me.rdb_byClientid = New System.Windows.Forms.RadioButton()
        Me.txt_bycname = New System.Windows.Forms.TextBox()
        Me.rdb_byClientName = New System.Windows.Forms.RadioButton()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.btn_newclient = New System.Windows.Forms.Button()
        Me.btn_delclient = New System.Windows.Forms.Button()
        Me.btn_modclient = New System.Windows.Forms.Button()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.dgv_clients = New System.Windows.Forms.DataGridView()
        Me.tab_filter.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.dgv_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_filter
        '
<<<<<<< HEAD
        Me.dgv_clients.AllowUserToAddRows = False
        Me.dgv_clients.AllowUserToDeleteRows = False
        Me.dgv_clients.AllowUserToResizeRows = False
        Me.dgv_clients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clients.BackgroundColor = System.Drawing.Color.White
        Me.dgv_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_clients.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_clients.Location = New System.Drawing.Point(20, 217)
        Me.dgv_clients.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_clients.MultiSelect = False
        Me.dgv_clients.Name = "dgv_clients"
        Me.dgv_clients.ReadOnly = True
        Me.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.RowHeadersVisible = False
        Me.dgv_clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clients.Size = New System.Drawing.Size(699, 385)
        Me.dgv_clients.TabIndex = 10
=======
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byClientName)
        Me.tab_filter.Controls.Add(Me.txt_bycname)
        Me.tab_filter.Controls.Add(Me.txt_bycid)
        Me.tab_filter.Controls.Add(Me.rdb_byClientid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 22)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_filter.Size = New System.Drawing.Size(687, 152)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'txt_bycid
        '
        Me.txt_bycid.Enabled = False
        Me.txt_bycid.Location = New System.Drawing.Point(6, 38)
        Me.txt_bycid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_bycid.Name = "txt_bycid"
        Me.txt_bycid.Size = New System.Drawing.Size(236, 20)
        Me.txt_bycid.TabIndex = 8
        '
        'rdb_byClientid
        '
        Me.rdb_byClientid.Location = New System.Drawing.Point(6, 6)
        Me.rdb_byClientid.Name = "rdb_byClientid"
        Me.rdb_byClientid.Size = New System.Drawing.Size(104, 24)
        Me.rdb_byClientid.TabIndex = 13
        Me.rdb_byClientid.Text = "By Client ID"
        '
        'txt_bycname
        '
        Me.txt_bycname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
<<<<<<< HEAD
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Location = New System.Drawing.Point(20, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(699, 184)
        Me.TabControl1.TabIndex = 9
=======
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Location = New System.Drawing.Point(6, 104)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.Size = New System.Drawing.Size(236, 20)
        Me.txt_bycname.TabIndex = 10
        '
        'rdb_byClientName
        '
        Me.rdb_byClientName.AutoSize = True
        Me.rdb_byClientName.Location = New System.Drawing.Point(6, 72)
        Me.rdb_byClientName.Name = "rdb_byClientName"
        Me.rdb_byClientName.Size = New System.Drawing.Size(97, 17)
        Me.rdb_byClientName.TabIndex = 11
        Me.rdb_byClientName.Text = "By Client Name"
        Me.rdb_byClientName.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(578, 100)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(656, 100)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(24, 35)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modclient)
        Me.tab_datacontrol.Controls.Add(Me.btn_delclient)
        Me.tab_datacontrol.Controls.Add(Me.btn_newclient)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Size = New System.Drawing.Size(691, 151)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txt_details.Location = New System.Drawing.Point(165, 30)
        Me.txt_details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(518, 107)
        Me.txt_details.TabIndex = 3
        '
        'btn_modclient
        '
        Me.btn_modclient.Location = New System.Drawing.Point(7, 69)
        Me.btn_modclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modclient.Name = "btn_modclient"
        Me.btn_modclient.Size = New System.Drawing.Size(150, 29)
        Me.btn_modclient.TabIndex = 2
        Me.btn_modclient.Text = "Modify Selected"
        Me.btn_modclient.UseVisualStyleBackColor = True
=======
        'btn_newclient
        '
        Me.btn_newclient.Location = New System.Drawing.Point(6, 40)
        Me.btn_newclient.Name = "btn_newclient"
        Me.btn_newclient.Size = New System.Drawing.Size(151, 29)
        Me.btn_newclient.TabIndex = 0
        Me.btn_newclient.Text = "Add new"
        Me.btn_newclient.UseVisualStyleBackColor = True
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'btn_delclient
        '
        Me.btn_delclient.Location = New System.Drawing.Point(7, 108)
        Me.btn_delclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delclient.Name = "btn_delclient"
        Me.btn_delclient.Size = New System.Drawing.Size(150, 29)
        Me.btn_delclient.TabIndex = 1
        Me.btn_delclient.Text = "Delete Selected"
        Me.btn_delclient.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'btn_newclient
        '
        Me.btn_newclient.Location = New System.Drawing.Point(7, 30)
        Me.btn_newclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newclient.Name = "btn_newclient"
        Me.btn_newclient.Size = New System.Drawing.Size(150, 29)
        Me.btn_newclient.TabIndex = 0
        Me.btn_newclient.Text = "Add new"
        Me.btn_newclient.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byClientName)
        Me.tab_filter.Controls.Add(Me.txt_bycname)
        Me.tab_filter.Controls.Add(Me.rdb_byClientid)
        Me.tab_filter.Controls.Add(Me.txt_bycid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 22)
        Me.tab_filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Size = New System.Drawing.Size(1034, 248)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
=======
        'btn_modclient
        '
        Me.btn_modclient.Location = New System.Drawing.Point(6, 75)
        Me.btn_modclient.Name = "btn_modclient"
        Me.btn_modclient.Size = New System.Drawing.Size(151, 29)
        Me.btn_modclient.TabIndex = 2
        Me.btn_modclient.Text = "Modify Selected"
        Me.btn_modclient.UseVisualStyleBackColor = True
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'txt_details
        '
<<<<<<< HEAD
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(984, 154)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(36, 54)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
=======
        Me.txt_details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_details.Location = New System.Drawing.Point(163, 40)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(518, 99)
        Me.txt_details.TabIndex = 3
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'Label1
        '
<<<<<<< HEAD
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(867, 154)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 54)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
=======
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'Label2
        '
<<<<<<< HEAD
        Me.rdb_byClientName.AutoSize = True
        Me.rdb_byClientName.Location = New System.Drawing.Point(9, 111)
        Me.rdb_byClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byClientName.Name = "rdb_byClientName"
        Me.rdb_byClientName.Size = New System.Drawing.Size(135, 24)
        Me.rdb_byClientName.TabIndex = 11
        Me.rdb_byClientName.Text = "By Client Name"
        Me.rdb_byClientName.UseVisualStyleBackColor = True
=======
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
<<<<<<< HEAD
        Me.txt_bycname.Enabled = False
        Me.txt_bycname.Location = New System.Drawing.Point(9, 160)
        Me.txt_bycname.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycname.Name = "txt_bycname"
        Me.txt_bycname.Size = New System.Drawing.Size(352, 26)
        Me.txt_bycname.TabIndex = 10
        '
        'rdb_byClientid
        '
        Me.rdb_byClientid.Location = New System.Drawing.Point(9, 9)
        Me.rdb_byClientid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byClientid.Name = "rdb_byClientid"
        Me.rdb_byClientid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byClientid.TabIndex = 13
        Me.rdb_byClientid.Text = "By Client ID"
=======
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 178)
        Me.TabControl1.TabIndex = 9
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'dgv_clients
        '
<<<<<<< HEAD
        Me.txt_bycid.Enabled = False
        Me.txt_bycid.Location = New System.Drawing.Point(9, 58)
        Me.txt_bycid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bycid.Name = "txt_bycid"
        Me.txt_bycid.Size = New System.Drawing.Size(352, 26)
        Me.txt_bycid.TabIndex = 8
=======
        Me.dgv_clients.AllowUserToAddRows = False
        Me.dgv_clients.AllowUserToDeleteRows = False
        Me.dgv_clients.AllowUserToResizeRows = False
        Me.dgv_clients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clients.BackgroundColor = System.Drawing.Color.White
        Me.dgv_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_clients.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_clients.Location = New System.Drawing.Point(13, 195)
        Me.dgv_clients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_clients.MultiSelect = False
        Me.dgv_clients.Name = "dgv_clients"
        Me.dgv_clients.ReadOnly = True
        Me.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.RowHeadersVisible = False
        Me.dgv_clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clients.Size = New System.Drawing.Size(695, 339)
        Me.dgv_clients.TabIndex = 10
>>>>>>> 221d888497fb03db58575245230c1b77aba4c68c
        '
        'Frm_Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(737, 622)
        Me.Controls.Add(Me.dgv_clients)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Clients"
        Me.Text = "Clients Management"
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.dgv_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byClientName As RadioButton
    Friend WithEvents txt_bycname As TextBox
    Friend WithEvents txt_bycid As TextBox
    Friend WithEvents rdb_byClientid As RadioButton
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modclient As Button
    Friend WithEvents btn_delclient As Button
    Friend WithEvents btn_newclient As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents dgv_clients As DataGridView
End Class
