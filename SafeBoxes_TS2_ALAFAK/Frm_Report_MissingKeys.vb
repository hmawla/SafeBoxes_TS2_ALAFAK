Public Class Frm_Report_MissingKeys
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_MissingKeys

    Private Sub Frm_Report_MissingKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_MissingKeys.ReportSource = CrysReport
        RptV_MissingKeys.RefreshReport()
    End Sub

    Private Sub Chk_Delivered_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Delivered.CheckedChanged
        If Chk_Delivered.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE RedeliverDate IS NOT NULL").Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        Else
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys").Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_exdate.ValueChanged, DateTimePicker1.ValueChanged
        If DateTimePicker1.Value >= dtpick_exdate.Value Then
            MessageBox.Show("To Date should be greater than from date!")
            dtpick_exdate.Value = DateTimePicker1.Value.AddDays(1)
        End If
        If Chk_Delivered.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE RedeliverDate IS NOT NULL AND MissKeyDate BETWEEN #" & DateTimePicker1.Value.ToShortDateString & "# AND #" & dtpick_exdate.Value.ToShortDateString & "#").Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        Else
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE (MissKeyDate BETWEEN #" & DateTimePicker1.Value.ToShortDateString & "# AND #" & dtpick_exdate.Value.ToShortDateString & "#)").Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Chk_Delivered.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE RedeliverDate IS NOT NULL AND ContId =" & TextBox1.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        Else
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE ContId =" & TextBox1.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DateTimePicker1.Enabled = True
            dtpick_exdate.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            dtpick_exdate.Enabled = False
        End If
    End Sub
End Class