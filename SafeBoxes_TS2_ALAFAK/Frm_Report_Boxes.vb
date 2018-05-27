Public Class Frm_Report_Boxes
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Boxes

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ByBoxId.KeyPress
        Only_Number(Txt_ByBoxId, e)
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Rdb_ByBoxId.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM Boxes WHERE BoxId =" & Txt_ByBoxId.Text).Copy()
            CrysReport.Database.Tables(2).SetDataSource(RptDbDataSet.Tables(0))
            RptV_Boxes.ReportSource = CrysReport
            RptV_Boxes.RefreshReport()
        Else
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM Boxes WHERE SizeId = " & cbox_boxsizes.SelectedValue).Copy()
            CrysReport.Database.Tables(2).SetDataSource(RptDbDataSet.Tables(0))
            RptV_Boxes.ReportSource = CrysReport
            RptV_Boxes.RefreshReport()
        End If
    End Sub

    Private Sub Frm_Report_Boxes_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_boxsizes, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop")
    End Sub

    Private Sub Rdb_ByBoxId_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByBoxId.CheckedChanged
        If Rdb_ByBoxId.Checked Then
            Txt_ByBoxId.Enabled = True
            cbox_boxsizes.Enabled = False
            Txt_ByBoxId.Focus()
        Else
            Txt_ByBoxId.Text = ""
            Txt_ByBoxId.Enabled = False
            cbox_boxsizes.Enabled = True
        End If
    End Sub
End Class