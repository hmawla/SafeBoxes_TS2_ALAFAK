Public Class Frm_Boxes
    Public BoxId As Integer

    Private Sub Frm_Boxes_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_boxsizes, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop") 'Fill the search combo box with all available sizes
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
        Me.MinimumSize = New Size(700, 628)
    End Sub

    Private Sub btn_newbox_Click(sender As Object, e As EventArgs) Handles btn_newbox.Click
        BoxId = 0
        Frm_NewBox.ShowDialog()
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
    End Sub

    Private Sub btn_modbox_Click(sender As Object, e As EventArgs) Handles btn_modbox.Click
        BoxId = dgv_boxes.SelectedRows(0).Cells(0).Value
        Frm_NewBox.ShowDialog()
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
    End Sub

    Private Sub btn_delbox_Click(sender As Object, e As EventArgs) Handles btn_delbox.Click
        InputBox.Show("Enter admin password:", "Delete Box#" & dgv_boxes.SelectedRows(0).Cells(0).Value, True)
        If Not inResult.Equals("0") Then
            If inResult = adminPass Then
                ExecuteQuery("DELETE FROM Boxes WHERE BoxId = " & dgv_boxes.SelectedRows(0).Cells(0).Value)
                FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
            Else
                MessageBox.Show("Wrong password!")
            End If
        End If


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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        If rdb_byBoxid.Checked Then
            FillDGV(dgv_boxes, "SELECT BoxId AS [ID],Length,Width, Height FROM Boxes b,BoxSizes bs WHERE b.BoxId=" & txt_bybid.Text & "AND b.SizeId=bs.SizeId")
        Else
            FillDGV(dgv_boxes, "SELECT BoxId AS [ID],Length,Width, Height FROM Boxes b, BoxSizes bs, BoxSizesDate bsd WHERE b.SizeId = " & cbox_boxsizes.SelectedValue & " AND bs.SizeId = " & cbox_boxsizes.SelectedValue & " AND bsd.SizeId = " & cbox_boxsizes.SelectedValue)
        End If
    End Sub

    Private Sub rdb_byBoxid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byBoxid.CheckedChanged
        txt_bybid.Enabled = True
        cbox_boxsizes.Enabled = False
        txt_bybid.Focus()
    End Sub

    Private Sub rdb_byBoxSize_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byBoxSize.CheckedChanged
        txt_bybid.Enabled = False
        cbox_boxsizes.Enabled = True
        txt_bybid.Text = ""
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
        btn_reset.Enabled = False
        txt_bybid.Text = ""
    End Sub

    Private Sub txt_bybid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bybid.KeyPress
        Only_Number(txt_bybid, e)
    End Sub

    Private Sub dgv_boxes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_boxes.CellDoubleClick
        If Frm_main.boxid = 0 Then
            Try
                If dgv_boxes.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                Frm_main.boxId = dgv_boxes.SelectedRows(0).Cells(0).Value
                Me.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BoxesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoxesReportToolStripMenuItem.Click
        Frm_Report_Boxes.ShowDialog()
    End Sub

    Private Sub Btn_ModfyPrices_Click(sender As Object, e As EventArgs) Handles Btn_ModfyPrices.Click
        Frm_BoxPrices.ShowDialog()
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
    End Sub

    Private Sub Btn_ModifySize_Click(sender As Object, e As EventArgs) Handles Btn_ModifySize.Click
        Frm_SelectSize.ShowDialog()
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
    End Sub

    Private Sub Btn_NewSize_Click(sender As Object, e As EventArgs) Handles Btn_NewSize.Click
        Frm_main.sizeId = 0
        Frm_NewBoxSize.ShowDialog()
        FillDGV(dgv_boxes, "SELECT Boxes.BoxId, [Length] & 'x' & [Width] & 'x' & [Height] AS [Size], BoxSizesDate.InsurancePrice, BoxSizesDate.RentPrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId")
    End Sub
End Class