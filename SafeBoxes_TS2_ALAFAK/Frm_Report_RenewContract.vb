Public Class Frm_Report_RenewContract
    Dim RptDbDataSet As New DataSet 'Declare the new dataset
    Dim CrysReport As New Rpt_Renew 'Declare an instance of the crystal report

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
            RptDbDataSet.Reset() 'reset the dataset incase it has data
            RptDbDataSet = ReadQueryOut("SELECT * FROM Renew WHERE ContId = " & Txt_ContId.Text).Copy() 'Set the condition on the desired table
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0)) 'Override the table(0) (First table in the Creport database) using the condition
            CRptV_Renew.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
            CRptV_Renew.RefreshReport() 'Refresh the viewer (may not be needed)
        Else
            If Dtpick_FromDate.Value > Dtpick_ToDate.Value Then
                MessageBox.Show("Invalid dates!")
            Else
                RptDbDataSet.Reset() 'reset the dataset incase it has data
                RptDbDataSet = ReadQueryOut("SELECT * FROM Renew WHERE (RenewDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#)").Copy() 'Set the condition on the desired table
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0)) 'Override the table(0) (First table in the Creport database) using the condition
                CRptV_Renew.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
                CRptV_Renew.RefreshReport() 'Refresh the viewer (may not be needed)
            End If

        End If
    End Sub
End Class