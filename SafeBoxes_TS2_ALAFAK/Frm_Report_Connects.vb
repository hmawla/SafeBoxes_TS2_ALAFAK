Public Class Frm_Report_Connects
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Connects

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ById.KeyPress
        Only_Number(Txt_ById, e)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ById.CheckedChanged
        If Rdb_ById.Checked Then
            Txt_ById.Enabled = True
            Dtpick_FromDate.Enabled = False
            Dtpick_ToDate.Enabled = False
        Else
            Txt_ById.Enabled = False
            Dtpick_FromDate.Enabled = True
            Dtpick_ToDate.Enabled = True
            Txt_ById.Text = ""
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Rdb_ById.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM Connects WHERE ConnectId =" & Txt_ById.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_connects.ReportSource = CrysReport
            RptV_connects.RefreshReport()
        Else
            If Dtpick_FromDate.Value >= Dtpick_ToDate.Value Then
                MessageBox.Show("Invalid Dates!")
            Else
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut("SELECT * FROM Connects WHERE (ConnectDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#)").Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                RptV_connects.ReportSource = CrysReport
                RptV_connects.RefreshReport()
            End If
        End If
    End Sub
End Class