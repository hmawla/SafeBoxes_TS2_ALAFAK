<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Boxes
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
        Me.dgv_boxes = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.btn_modbox = New System.Windows.Forms.Button()
        Me.btn_delbox = New System.Windows.Forms.Button()
        Me.btn_newbox = New System.Windows.Forms.Button()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byBoxSize = New System.Windows.Forms.RadioButton()
        Me.txt_bybsize = New System.Windows.Forms.TextBox()
        Me.txt_bybid = New System.Windows.Forms.TextBox()
        Me.rdb_byBoxid = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_boxes
        '
        Me.dgv_boxes.AllowUserToAddRows = False
        Me.dgv_boxes.AllowUserToDeleteRows = False
        Me.dgv_boxes.AllowUserToResizeRows = False
        Me.dgv_boxes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_boxes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_boxes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_boxes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_boxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_boxes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_boxes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_boxes.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_boxes.Location = New System.Drawing.Point(13, 216)
        Me.dgv_boxes.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_boxes.MultiSelect = False
        Me.dgv_boxes.Name = "dgv_boxes"
        Me.dgv_boxes.ReadOnly = True
        Me.dgv_boxes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_boxes.RowHeadersVisible = False
        Me.dgv_boxes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_boxes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_boxes.Size = New System.Drawing.Size(662, 386)
        Me.dgv_boxes.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(13, 14)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 189)
        Me.TabControl1.TabIndex = 11
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modbox)
        Me.tab_datacontrol.Controls.Add(Me.btn_delbox)
        Me.tab_datacontrol.Controls.Add(Me.btn_newbox)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 29)
        Me.tab_datacontrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_datacontrol.Size = New System.Drawing.Size(654, 156)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(163, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
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
        Me.txt_details.Size = New System.Drawing.Size(479, 107)
        Me.txt_details.TabIndex = 3
        '
        'btn_modbox
        '
        Me.btn_modbox.Location = New System.Drawing.Point(8, 69)
        Me.btn_modbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_modbox.Name = "btn_modbox"
        Me.btn_modbox.Size = New System.Drawing.Size(151, 29)
        Me.btn_modbox.TabIndex = 2
        Me.btn_modbox.Text = "Modify Selected"
        Me.btn_modbox.UseVisualStyleBackColor = True
        '
        'btn_delbox
        '
        Me.btn_delbox.Location = New System.Drawing.Point(8, 108)
        Me.btn_delbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delbox.Name = "btn_delbox"
        Me.btn_delbox.Size = New System.Drawing.Size(151, 29)
        Me.btn_delbox.TabIndex = 1
        Me.btn_delbox.Text = "Delete Selected"
        Me.btn_delbox.UseVisualStyleBackColor = True
        '
        'btn_newbox
        '
        Me.btn_newbox.Location = New System.Drawing.Point(8, 30)
        Me.btn_newbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newbox.Name = "btn_newbox"
        Me.btn_newbox.Size = New System.Drawing.Size(151, 29)
        Me.btn_newbox.TabIndex = 0
        Me.btn_newbox.Text = "Add new"
        Me.btn_newbox.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byBoxSize)
        Me.tab_filter.Controls.Add(Me.txt_bybsize)
        Me.tab_filter.Controls.Add(Me.txt_bybid)
        Me.tab_filter.Controls.Add(Me.rdb_byBoxid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 29)
        Me.tab_filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_filter.Size = New System.Drawing.Size(654, 156)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(608, 110)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(36, 33)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(511, 110)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(85, 33)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Filter"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byBoxSize
        '
        Me.rdb_byBoxSize.AutoSize = True
        Me.rdb_byBoxSize.Location = New System.Drawing.Point(9, 56)
        Me.rdb_byBoxSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byBoxSize.Name = "rdb_byBoxSize"
        Me.rdb_byBoxSize.Size = New System.Drawing.Size(109, 23)
        Me.rdb_byBoxSize.TabIndex = 11
        Me.rdb_byBoxSize.Text = "By Box Size"
        Me.rdb_byBoxSize.UseVisualStyleBackColor = True
        '
        'txt_bybsize
        '
        Me.txt_bybsize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bybsize.Enabled = False
        Me.txt_bybsize.Location = New System.Drawing.Point(175, 54)
        Me.txt_bybsize.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bybsize.Name = "txt_bybsize"
        Me.txt_bybsize.Size = New System.Drawing.Size(352, 27)
        Me.txt_bybsize.TabIndex = 10
        '
        'txt_bybid
        '
        Me.txt_bybid.Enabled = False
        Me.txt_bybid.Location = New System.Drawing.Point(175, 14)
        Me.txt_bybid.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_bybid.Name = "txt_bybid"
        Me.txt_bybid.Size = New System.Drawing.Size(352, 27)
        Me.txt_bybid.TabIndex = 8
        '
        'rdb_byBoxid
        '
        Me.rdb_byBoxid.Location = New System.Drawing.Point(9, 9)
        Me.rdb_byBoxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdb_byBoxid.Name = "rdb_byBoxid"
        Me.rdb_byBoxid.Size = New System.Drawing.Size(156, 37)
        Me.rdb_byBoxid.TabIndex = 13
        Me.rdb_byBoxid.Text = "By Box ID"
        '
        'Frm_Boxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 628)
        Me.Controls.Add(Me.dgv_boxes)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Boxes"
        Me.Text = "Boxes Management"
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_boxes As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modbox As Button
    Friend WithEvents btn_delbox As Button
    Friend WithEvents btn_newbox As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byBoxSize As RadioButton
    Friend WithEvents txt_bybsize As TextBox
    Friend WithEvents txt_bybid As TextBox
    Friend WithEvents rdb_byBoxid As RadioButton
End Class
