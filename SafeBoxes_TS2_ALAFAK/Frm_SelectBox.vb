Imports System.ComponentModel
Imports System.Data
Public Class Frm_SelectBox
    Private Sub Frm_SelectBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_boxes, "SELECT BoxId, Length, Width, Height, InsurancePrice, RentPrice FROM Boxes b, BoxSizes bs, BoxSizesDate bsd WHERE b.SizeId = bs.SizeId AND bs.SizeId = bsd.SizeId AND BoxId NOT IN (SELECT BoxId FROM Contract)") 'Fill the data grid view with all data
        FillCBox(cbox_boxsizes, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop") 'Fill the search combo box with all available sizes
        FillCBox(cbox_addsize, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop") 'Fill the search combo box with all available sizes
    End Sub



    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_boxes, "SELECT BoxId, Length, Width, Height, InsurancePrice, RentPrice FROM Boxes b, BoxSizes bs, BoxSizesDate bsd WHERE b.SizeId = bs.SizeId AND bs.SizeId = bsd.SizeId AND BoxId NOT IN (SELECT BoxId FROM Contract)") 'Reset all data in the data grid view
        btn_reset.Enabled = False 'disables the reset button since there is no need to re reset
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        frm_newContract.txt_boxes.Text = dgv_boxes.SelectedRows.Item(0).Cells.Item(0).Value 'submit the selected record
        Me.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        btn_select.Enabled = False
        FillDGV(dgv_boxes, "SELECT BoxId, Length, Width, Height, InsurancePrice, RentPrice FROM Boxes b, BoxSizes bs, BoxSizesDate bsd WHERE b.SizeId = " & cbox_boxsizes.SelectedValue & " AND bs.SizeId = " & cbox_boxsizes.SelectedValue & " AND bsd.SizeId = " & cbox_boxsizes.SelectedValue)
    End Sub

    Private Sub dgv_boxes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_boxes.RowEnter
        btn_select.Enabled = True
    End Sub

    Private Sub btn_addbox_Click(sender As Object, e As EventArgs) Handles btn_addbox.Click
        ExecuteQuery("INSERT INTO Boxes VALUES(" & genID("Boxes", "BoxId") & ", " & cbox_addsize.SelectedValue & ")")
        FillDGV(dgv_boxes, "SELECT BoxId, Length, Width, Height, InsurancePrice, RentPrice FROM Boxes b, BoxSizes bs, BoxSizesDate bsd WHERE b.SizeId = bs.SizeId AND bs.SizeId = bsd.SizeId AND BoxId NOT IN (SELECT BoxId FROM Contract)") 'Fill the data grid view with all data
    End Sub
End Class