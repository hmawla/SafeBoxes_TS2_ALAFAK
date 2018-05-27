Public Class Frm_Report_Contract
    Dim RptDbDataSet As New DataSet 'Declare the new dataset
    Dim CrysReport As New Rpt_Contract 'Declare an instance of the crystal report


    Private Sub Rdb_ByContId_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByContId.CheckedChanged
        If Rdb_ByContId.Checked Then
            Txt_ContId.Enabled = True
            Dtpick_FromDate.Enabled = False
            Dtpick_ToDate.Enabled = False
        Else
            Txt_ContId.Enabled = False
            Txt_ContId.Text = ""
            Dtpick_FromDate.Enabled = True
            Dtpick_ToDate.Enabled = True
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Rdb_ByContId.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM Contract WHERE ContId = " & Txt_ContId.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            CRptV_Contract.ReportSource = CrysReport
            CRptV_Contract.RefreshReport()
        Else
            If Dtpick_FromDate.Value > Dtpick_ToDate.Value Then
                MessageBox.Show("Invalid Dates!")
            Else
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut("SELECT * FROM Contract WHERE (ContBDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#)").Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                CRptV_Contract.ReportSource = CrysReport
                CRptV_Contract.RefreshReport()
            End If
        End If
    End Sub
End Class