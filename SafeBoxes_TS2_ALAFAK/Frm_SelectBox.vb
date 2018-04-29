Public Class Frm_SelectBox
    Private Sub Frm_SelectBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_boxes, "SELECT BoxId, Length, Width, Height, InsurancePrice, RentPrice FROM Boxes b, BoxSizes bs, BoxSizesDate bsd WHERE b.SizeId = bs.SizeId AND bs.SizeId = bsd.SizeId")
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

    End Sub
End Class