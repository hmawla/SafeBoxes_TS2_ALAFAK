<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Info_Result
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
        Me.dgv_inforesults = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_inforesults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_inforesults
        '
        Me.dgv_inforesults.AllowUserToAddRows = False
        Me.dgv_inforesults.AllowUserToDeleteRows = False
        Me.dgv_inforesults.AllowUserToResizeRows = False
        Me.dgv_inforesults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_inforesults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_inforesults.BackgroundColor = System.Drawing.Color.White
        Me.dgv_inforesults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_inforesults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_inforesults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_inforesults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_inforesults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_inforesults.GridColor = System.Drawing.Color.PowderBlue
        Me.dgv_inforesults.Location = New System.Drawing.Point(13, 74)
        Me.dgv_inforesults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_inforesults.MultiSelect = False
        Me.dgv_inforesults.Name = "dgv_inforesults"
        Me.dgv_inforesults.ReadOnly = True
        Me.dgv_inforesults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_inforesults.RowHeadersVisible = False
        Me.dgv_inforesults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgv_inforesults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_inforesults.Size = New System.Drawing.Size(774, 362)
        Me.dgv_inforesults.TabIndex = 11
        '
        'frm_Info_Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_inforesults)
        Me.Name = "frm_Info_Result"
        Me.Text = "frm_Info_Result"
        CType(Me.dgv_inforesults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_inforesults As DataGridView
End Class
