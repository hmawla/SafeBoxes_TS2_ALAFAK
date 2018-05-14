Public Class Frm_Boxes
    Public BoxId As Integer

    Private Sub Frm_Boxes_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillDGV(dgv_boxes, "SELECT BoxId AS [ID],Length,Width, Height FROM Boxes b,BoxSizes bs WHERE b.SizeId=bs.SizeId")
    End Sub

    Private Sub btn_newbox_Click(sender As Object, e As EventArgs) Handles btn_newbox.Click
        BoxId = 0
        Frm_SelectBox.ShowDialog()
        FillDGV(dgv_boxes, "SELECT BoxId AS [ID],Length,Width, Height FROM Boxes b,BoxSizes bs WHERE b.SizeId=bs.SizeId")
    End Sub

    Private Sub btn_modbox_Click(sender As Object, e As EventArgs) Handles btn_modbox.Click
        BoxId = dgv_boxes.SelectedRows(0).Cells(0).Value
        Frm_SelectBox.ShowDialog()
        FillDGV(dgv_boxes, "SELECT BoxId AS [ID],Length,Width, Height FROM Boxes b,BoxSizes bs WHERE b.SizeId=bs.SizeId")
    End Sub

    Private Sub btn_delbox_Click(sender As Object, e As EventArgs) Handles btn_delbox.Click
        ExecuteQuery("DELETE FROM Boxes WHERE BoxId = " & dgv_boxes.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_boxes, "SELECT BoxId AS [ID],Length,Width, Height FROM Boxes b,BoxSizes bs WHERE b.SizeId=bs.SizeId")

    End Sub

    Private Sub dgv_boxes_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_boxes.SelectionChanged
        Try
            If dgv_boxes.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delbox.Enabled = True
            btn_modbox.Enabled = True
        Catch ex As Exception
            btn_delbox.Enabled = False
            btn_modbox.Enabled = False
        End Try
    End Sub
End Class