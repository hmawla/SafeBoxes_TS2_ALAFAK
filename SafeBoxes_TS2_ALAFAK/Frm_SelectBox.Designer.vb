<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectBox
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgv_boxes = New System.Windows.Forms.DataGridView()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbox_boxsizes = New System.Windows.Forms.ComboBox()
        Me.grp_search.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.Enabled = False
        Me.btn_select.Location = New System.Drawing.Point(596, 489)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(112, 35)
        Me.btn_select.TabIndex = 10
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'grp_search
        '
        Me.grp_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_search.Controls.Add(Me.cbox_boxsizes)
        Me.grp_search.Controls.Add(Me.MaterialLabel1)
        Me.grp_search.Controls.Add(Me.Button1)
        Me.grp_search.Controls.Add(Me.btn_reset)
        Me.grp_search.Controls.Add(Me.btn_search)
        Me.grp_search.Controls.Add(Me.DataGridView1)
        Me.grp_search.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.grp_search.Location = New System.Drawing.Point(12, 12)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(697, 113)
        Me.grp_search.TabIndex = 9
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(787, 404)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Enabled = False
        Me.btn_reset.Location = New System.Drawing.Point(666, 54)
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
        Me.btn_search.Location = New System.Drawing.Point(588, 54)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(70, 35)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.PowderBlue
        Me.DataGridView1.Location = New System.Drawing.Point(1, 121)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(899, 273)
        Me.DataGridView1.TabIndex = 8
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
        Me.dgv_boxes.Location = New System.Drawing.Point(13, 133)
        Me.dgv_boxes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_boxes.MultiSelect = False
        Me.dgv_boxes.Name = "dgv_boxes"
        Me.dgv_boxes.ReadOnly = True
        Me.dgv_boxes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_boxes.RowHeadersVisible = False
        Me.dgv_boxes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_boxes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_boxes.Size = New System.Drawing.Size(695, 346)
        Me.dgv_boxes.TabIndex = 8
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(3, 33)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(177, 20)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "Length x Width x Height"
        '
        'cbox_boxsizes
        '
        Me.cbox_boxsizes.FormattingEnabled = True
        Me.cbox_boxsizes.Location = New System.Drawing.Point(7, 56)
        Me.cbox_boxsizes.Name = "cbox_boxsizes"
        Me.cbox_boxsizes.Size = New System.Drawing.Size(574, 28)
        Me.cbox_boxsizes.TabIndex = 12
        '
        'Frm_SelectBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 538)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.grp_search)
        Me.Controls.Add(Me.dgv_boxes)
        Me.Name = "Frm_SelectBox"
        Me.Text = "Form1"
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_select As Button
    Friend WithEvents grp_search As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgv_boxes As DataGridView
    Friend WithEvents cbox_boxsizes As ComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
