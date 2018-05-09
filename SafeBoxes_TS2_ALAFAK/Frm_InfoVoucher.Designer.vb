<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InfoVoucher
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
        Me.dgv_infovouchers = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datacontrol = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.btn_modinfovouch = New System.Windows.Forms.Button()
        Me.btn_delinfovouch = New System.Windows.Forms.Button()
        Me.btn_newinfovouch = New System.Windows.Forms.Button()
        Me.tab_filter = New System.Windows.Forms.TabPage()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byClientName = New System.Windows.Forms.RadioButton()
        Me.txt_byClientName = New System.Windows.Forms.TextBox()
        Me.rdb_byinfovouchid = New System.Windows.Forms.RadioButton()
        Me.txt_byInfovouchid = New System.Windows.Forms.TextBox()
        CType(Me.dgv_infovouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_datacontrol.SuspendLayout()
        Me.tab_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_infovouchers
        '
        Me.dgv_infovouchers.AllowUserToAddRows = False
        Me.dgv_infovouchers.AllowUserToDeleteRows = False
        Me.dgv_infovouchers.AllowUserToResizeRows = False
        Me.dgv_infovouchers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_infovouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_infovouchers.BackgroundColor = System.Drawing.Color.White
        Me.dgv_infovouchers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_infovouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_infovouchers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_infovouchers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_infovouchers.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_infovouchers.Location = New System.Drawing.Point(13, 195)
        Me.dgv_infovouchers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_infovouchers.MultiSelect = False
        Me.dgv_infovouchers.Name = "dgv_infovouchers"
        Me.dgv_infovouchers.ReadOnly = True
        Me.dgv_infovouchers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_infovouchers.RowHeadersVisible = False
        Me.dgv_infovouchers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_infovouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_infovouchers.Size = New System.Drawing.Size(695, 339)
        Me.dgv_infovouchers.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_datacontrol)
        Me.TabControl1.Controls.Add(Me.tab_filter)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 178)
        Me.TabControl1.TabIndex = 9
        '
        'tab_datacontrol
        '
        Me.tab_datacontrol.Controls.Add(Me.Label2)
        Me.tab_datacontrol.Controls.Add(Me.Label1)
        Me.tab_datacontrol.Controls.Add(Me.txt_details)
        Me.tab_datacontrol.Controls.Add(Me.btn_modinfovouch)
        Me.tab_datacontrol.Controls.Add(Me.btn_delinfovouch)
        Me.tab_datacontrol.Controls.Add(Me.btn_newinfovouch)
        Me.tab_datacontrol.Location = New System.Drawing.Point(4, 22)
        Me.tab_datacontrol.Name = "tab_datacontrol"
        Me.tab_datacontrol.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datacontrol.Size = New System.Drawing.Size(687, 152)
        Me.tab_datacontrol.TabIndex = 0
        Me.tab_datacontrol.Text = "Data Control"
        Me.tab_datacontrol.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control"
        '
        'txt_details
        '
        Me.txt_details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_details.Location = New System.Drawing.Point(163, 40)
        Me.txt_details.Multiline = True
        Me.txt_details.Name = "txt_details"
        Me.txt_details.ReadOnly = True
        Me.txt_details.Size = New System.Drawing.Size(518, 99)
        Me.txt_details.TabIndex = 3
        '
        'btn_modinfovouch
        '
        Me.btn_modinfovouch.Location = New System.Drawing.Point(6, 75)
        Me.btn_modinfovouch.Name = "btn_modinfovouch"
        Me.btn_modinfovouch.Size = New System.Drawing.Size(151, 29)
        Me.btn_modinfovouch.TabIndex = 2
        Me.btn_modinfovouch.Text = "Modify Selected"
        Me.btn_modinfovouch.UseVisualStyleBackColor = True
        '
        'btn_delinfovouch
        '
        Me.btn_delinfovouch.Location = New System.Drawing.Point(6, 110)
        Me.btn_delinfovouch.Name = "btn_delinfovouch"
        Me.btn_delinfovouch.Size = New System.Drawing.Size(151, 29)
        Me.btn_delinfovouch.TabIndex = 1
        Me.btn_delinfovouch.Text = "Delete Selected"
        Me.btn_delinfovouch.UseVisualStyleBackColor = True
        '
        'btn_newinfovouch
        '
        Me.btn_newinfovouch.Location = New System.Drawing.Point(6, 40)
        Me.btn_newinfovouch.Name = "btn_newinfovouch"
        Me.btn_newinfovouch.Size = New System.Drawing.Size(151, 29)
        Me.btn_newinfovouch.TabIndex = 0
        Me.btn_newinfovouch.Text = "Add new"
        Me.btn_newinfovouch.UseVisualStyleBackColor = True
        '
        'tab_filter
        '
        Me.tab_filter.Controls.Add(Me.btn_reset)
        Me.tab_filter.Controls.Add(Me.btn_search)
        Me.tab_filter.Controls.Add(Me.rdb_byClientName)
        Me.tab_filter.Controls.Add(Me.txt_byClientName)
        Me.tab_filter.Controls.Add(Me.rdb_byinfovouchid)
        Me.tab_filter.Controls.Add(Me.txt_byInfovouchid)
        Me.tab_filter.Location = New System.Drawing.Point(4, 22)
        Me.tab_filter.Name = "tab_filter"
        Me.tab_filter.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_filter.Size = New System.Drawing.Size(687, 152)
        Me.tab_filter.TabIndex = 1
        Me.tab_filter.Text = "Filter"
        Me.tab_filter.UseVisualStyleBackColor = True
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
        'txt_byClientName
        '
        Me.txt_byClientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byClientName.Enabled = False
        Me.txt_byClientName.Location = New System.Drawing.Point(6, 104)
        Me.txt_byClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byClientName.Name = "txt_byClientName"
        Me.txt_byClientName.Size = New System.Drawing.Size(236, 20)
        Me.txt_byClientName.TabIndex = 10
        '
        'rdb_byinfovouchid
        '
        Me.rdb_byinfovouchid.Location = New System.Drawing.Point(6, 6)
        Me.rdb_byinfovouchid.Name = "rdb_byinfovouchid"
        Me.rdb_byinfovouchid.Size = New System.Drawing.Size(104, 24)
        Me.rdb_byinfovouchid.TabIndex = 13
        Me.rdb_byinfovouchid.Text = "By Info Voucher ID"
        '
        'txt_byInfovouchid
        '
        Me.txt_byInfovouchid.Enabled = False
        Me.txt_byInfovouchid.Location = New System.Drawing.Point(6, 38)
        Me.txt_byInfovouchid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byInfovouchid.Name = "txt_byInfovouchid"
        Me.txt_byInfovouchid.Size = New System.Drawing.Size(236, 20)
        Me.txt_byInfovouchid.TabIndex = 8
        '
        'Frm_InfoVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 547)
        Me.Controls.Add(Me.dgv_infovouchers)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_InfoVoucher"
        Me.Text = "Frm_InfoVoucher"
        CType(Me.dgv_infovouchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datacontrol.ResumeLayout(False)
        Me.tab_datacontrol.PerformLayout()
        Me.tab_filter.ResumeLayout(False)
        Me.tab_filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_infovouchers As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_datacontrol As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents btn_modinfovouch As Button
    Friend WithEvents btn_delinfovouch As Button
    Friend WithEvents btn_newinfovouch As Button
    Friend WithEvents tab_filter As TabPage
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byClientName As RadioButton
    Friend WithEvents txt_byClientName As TextBox
    Friend WithEvents rdb_byinfovouchid As RadioButton
    Friend WithEvents txt_byInfovouchid As TextBox
End Class
