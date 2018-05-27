Public Class Frm_Report_MissingKeys
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_MissingKeys

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
            If Chk_Delivered.Checked Then
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE RedeliverDate IS NOT NULL AND ContId =" & Txt_ByContId.Text).Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                RptV_MissingKeys.ReportSource = CrysReport
                RptV_MissingKeys.RefreshReport()
            Else
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE ContId =" & Txt_ByContId.Text).Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                RptV_MissingKeys.ReportSource = CrysReport
                RptV_MissingKeys.RefreshReport()
            End If
        Else
            If Dtpick_FromDate.Value > Dtpick_ToDate.Value Then
                MessageBox.Show("Invalid Date!")
            Else
                If Chk_Delivered.Checked Then
                    RptDbDataSet.Reset()
                    RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE RedeliverDate IS NOT NULL AND MissKeyDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#").Copy()
                    CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                    RptV_MissingKeys.ReportSource = CrysReport
                    RptV_MissingKeys.RefreshReport()
                Else
                    RptDbDataSet.Reset()
                    RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE (MissKeyDate BETWEEN #" & Dtpick_FromDate.Value.ToShortDateString & "# AND #" & Dtpick_ToDate.Value.ToShortDateString & "#)").Copy()
                    CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                    RptV_MissingKeys.ReportSource = CrysReport
                    RptV_MissingKeys.RefreshReport()
                End If
            End If

        End If
    End Sub
End Class