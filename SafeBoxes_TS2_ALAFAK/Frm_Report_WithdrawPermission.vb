Public Class Frm_Report_WithdrawPermission
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Withdraw

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByContId.CheckedChanged
        If Rdb_ByContId.Checked Then
            Txt_ByContId.Enabled = True
            Dtpick_FromDate.Enabled = False
            Dtpick_ToDate.Enabled = False
        Else
            Txt_ByContId.Enabled = False
            Dtpick_FromDate.Enabled = True
            Dtpick_ToDate.Enabled = True
            Txt_ByContId.Text = ""
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Rdb_ByContId.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM Permissions WHERE ContId =" & Txt_ByContId.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_Withdraw.ReportSource = CrysReport
            RptV_Withdraw.RefreshReport()
        Else
            If Dtpick_FromDate.Value > Dtpick_ToDate.Value Then
                MessageBox.Show("Invalid Dates!")
            Else
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut("SELECT * FROM Permissions WHERE (PermDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#)").Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                RptV_Withdraw.ReportSource = CrysReport
                RptV_Withdraw.RefreshReport()
            End If
        End If
    End Sub
End Class