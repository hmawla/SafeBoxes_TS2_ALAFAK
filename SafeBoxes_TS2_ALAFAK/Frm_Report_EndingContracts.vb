Public Class Frm_Report_EndingContracts
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_EndingContract

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ById.KeyPress
        Only_Number(Txt_ById, e)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByContId.CheckedChanged
        If Rdb_ByContId.Checked Then
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
        If Rdb_ByContId.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM ContEnd WHERE ContId = " & Txt_ById.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_EndingContracts.ReportSource = CrysReport
            RptV_EndingContracts.RefreshReport()
        Else
            If Dtpick_FromDate.Value > Dtpick_ToDate.Value Then
                MessageBox.Show("Invalid Dates!")
            Else
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut("SELECT * FROM ContEnd WHERE (ContEndDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#)").Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                RptV_EndingContracts.ReportSource = CrysReport
                RptV_EndingContracts.RefreshReport()
            End If
        End If
    End Sub
End Class