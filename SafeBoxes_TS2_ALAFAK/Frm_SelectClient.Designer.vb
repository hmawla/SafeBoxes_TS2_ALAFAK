﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectClient
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
        Me.btn_select = New System.Windows.Forms.Button()
        Me.grp_search = New System.Windows.Forms.GroupBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.rdb_byname = New System.Windows.Forms.RadioButton()
        Me.txt_byname = New System.Windows.Forms.TextBox()
        Me.rdb_byid = New System.Windows.Forms.RadioButton()
        Me.txt_byid = New System.Windows.Forms.TextBox()
        Me.dgv_clients = New System.Windows.Forms.DataGridView()
        Me.grp_search.SuspendLayout()
        CType(Me.dgv_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.Enabled = False
        Me.btn_select.Location = New System.Drawing.Point(533, 483)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(112, 35)
        Me.btn_select.TabIndex = 9
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'grp_search
        '
        Me.grp_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_search.Controls.Add(Me.btn_reset)
        Me.grp_search.Controls.Add(Me.btn_search)
        Me.grp_search.Controls.Add(Me.rdb_byname)
        Me.grp_search.Controls.Add(Me.txt_byname)
        Me.grp_search.Controls.Add(Me.rdb_byid)
        Me.grp_search.Controls.Add(Me.txt_byid)
        Me.grp_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grp_search.Location = New System.Drawing.Point(16, 13)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(629, 113)
        Me.grp_search.TabIndex = 8
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Search"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(598, 54)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(24, 35)
        Me.btn_reset.TabIndex = 6
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(520, 54)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'rdb_byname
        '
        Me.rdb_byname.AutoSize = True
        Me.rdb_byname.Location = New System.Drawing.Point(162, 26)
        Me.rdb_byname.Name = "rdb_byname"
        Me.rdb_byname.Size = New System.Drawing.Size(91, 24)
        Me.rdb_byname.TabIndex = 5
        Me.rdb_byname.Text = "By Name"
        Me.rdb_byname.UseVisualStyleBackColor = True
        '
        'txt_byname
        '
        Me.txt_byname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_byname.Enabled = False
        Me.txt_byname.Location = New System.Drawing.Point(162, 58)
        Me.txt_byname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byname.Name = "txt_byname"
        Me.txt_byname.Size = New System.Drawing.Size(350, 26)
        Me.txt_byname.TabIndex = 4
        '
        'rdb_byid
        '
        Me.rdb_byid.AutoSize = True
        Me.rdb_byid.Checked = True
        Me.rdb_byid.Location = New System.Drawing.Point(6, 26)
        Me.rdb_byid.Name = "rdb_byid"
        Me.rdb_byid.Size = New System.Drawing.Size(66, 24)
        Me.rdb_byid.TabIndex = 3
        Me.rdb_byid.TabStop = True
        Me.rdb_byid.Text = "By ID"
        Me.rdb_byid.UseVisualStyleBackColor = True
        '
        'txt_byid
        '
        Me.txt_byid.Location = New System.Drawing.Point(6, 58)
        Me.txt_byid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_byid.Name = "txt_byid"
        Me.txt_byid.Size = New System.Drawing.Size(148, 26)
        Me.txt_byid.TabIndex = 1
        '
        'dgv_clients
        '
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
        Me.dgv_clients.Location = New System.Drawing.Point(16, 134)
        Me.dgv_clients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_clients.MultiSelect = False
        Me.dgv_clients.Name = "dgv_clients"
        Me.dgv_clients.ReadOnly = True
        Me.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_clients.RowHeadersVisible = False
        Me.dgv_clients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clients.Size = New System.Drawing.Size(629, 339)
        Me.dgv_clients.TabIndex = 7
        '
        'Frm_SelectClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(660, 531)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.grp_search)
        Me.Controls.Add(Me.dgv_clients)
        Me.Name = "Frm_SelectClient"
        Me.Text = "Select Client"
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        CType(Me.dgv_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_select As Button
    Friend WithEvents grp_search As GroupBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents rdb_byname As RadioButton
    Friend WithEvents txt_byname As TextBox
    Friend WithEvents rdb_byid As RadioButton
    Friend WithEvents txt_byid As TextBox
    Friend WithEvents dgv_clients As DataGridView
End Class
