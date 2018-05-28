Public Class Frm_SelectSize
    Private Sub Frm_SelectSize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_boxsizes, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop") 'Fill the search combo box with all available sizes
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        Frm_main.sizeId = cbox_boxsizes.SelectedValue
        Frm_NewBoxSize.ShowDialog()
        Me.Dispose()
    End Sub
End Class