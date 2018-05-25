<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectBox
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
        Me.btn_select = New MaterialSkin.Controls.MaterialFlatButton()
        Me.dgv_boxes = New System.Windows.Forms.DataGridView()
        Me.cbox_boxsizes = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_search = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_reset = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.AutoSize = True
        Me.btn_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_select.Depth = 0
        Me.btn_select.Enabled = False
        Me.btn_select.Icon = Nothing
        Me.btn_select.Location = New System.Drawing.Point(620, 325)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_select.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Primary = False
        Me.btn_select.Size = New System.Drawing.Size(73, 36)
        Me.btn_select.TabIndex = 10
        Me.btn_select.Text = " Select"
        Me.btn_select.UseVisualStyleBackColor = True
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
        Me.dgv_boxes.Location = New System.Drawing.Point(15, 146)
        Me.dgv_boxes.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dgv_boxes.MultiSelect = False
        Me.dgv_boxes.Name = "dgv_boxes"
        Me.dgv_boxes.ReadOnly = True
        Me.dgv_boxes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_boxes.RowHeadersVisible = False
        Me.dgv_boxes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_boxes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_boxes.Size = New System.Drawing.Size(678, 163)
        Me.dgv_boxes.TabIndex = 8
        '
        'cbox_boxsizes
        '
        Me.cbox_boxsizes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbox_boxsizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_boxsizes.FormattingEnabled = True
        Me.cbox_boxsizes.Location = New System.Drawing.Point(15, 95)
        Me.cbox_boxsizes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbox_boxsizes.Name = "cbox_boxsizes"
        Me.cbox_boxsizes.Size = New System.Drawing.Size(512, 28)
        Me.cbox_boxsizes.TabIndex = 16
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(11, 71)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(166, 19)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "Length x Width x Height"
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.AutoSize = True
        Me.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_search.Depth = 0
        Me.btn_search.Icon = Nothing
        Me.btn_search.Location = New System.Drawing.Point(540, 87)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Primary = False
        Me.btn_search.Size = New System.Drawing.Size(73, 36)
        Me.btn_search.TabIndex = 13
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.AutoSize = True
        Me.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_reset.Depth = 0
        Me.btn_reset.Enabled = False
        Me.btn_reset.Icon = Nothing
        Me.btn_reset.Location = New System.Drawing.Point(657, 87)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Primary = False
        Me.btn_reset.Size = New System.Drawing.Size(30, 36)
        Me.btn_reset.TabIndex = 14
        Me.btn_reset.Text = "X"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Frm_SelectBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 366)
        Me.Controls.Add(Me.cbox_boxsizes)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.dgv_boxes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_SelectBox"
        Me.Text = "Select Box"
        CType(Me.dgv_boxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_select As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents dgv_boxes As DataGridView
    Friend WithEvents cbox_boxsizes As ComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_search As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_reset As MaterialSkin.Controls.MaterialFlatButton
End Class
