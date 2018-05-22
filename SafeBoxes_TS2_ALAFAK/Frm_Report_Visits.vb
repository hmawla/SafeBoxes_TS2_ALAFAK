Public Class Frm_Report_Visits
    Dim RptDbDataSet As New DataSet 'Declare the new dataset
    Dim CrysReport As New Rpt_Visits 'Declare an instance of the crystal report
    Private Sub Frm_Report_Visits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptDbDataSet.Reset() 'reset the dataset incase it has data
        CRptV_Visits.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Visits.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_exdate.ValueChanged, DateTimePicker1.ValueChanged
        If DateTimePicker1.Value >= dtpick_exdate.Value Then
            MessageBox.Show("To Date should be greater than from date!")
            dtpick_exdate.Value = DateTimePicker1.Value.AddDays(1)
        End If
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Visits WHERE (VisitDate BETWEEN #" & DateTimePicker1.Value.ToShortDateString & "# AND #" & dtpick_exdate.Value.ToShortDateString & "#)").Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        CRptV_Visits.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Visits.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub

    Private Sub Txt_ContId_TextChanged(sender As Object, e As EventArgs) Handles Txt_ContId.TextChanged
        RptDbDataSet.Reset() 'reset the dataset incase it has data
        RptDbDataSet = ReadQueryOut("SELECT * FROM Visits WHERE ContId = " & Txt_ContId.Text).Copy() 'Set the condition on the desired table
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0)) 'Override the table(0) (First table in the Creport database) using the condition
        CRptV_Visits.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Visits.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub

    Private Sub Rdb_ByContId_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByContId.CheckedChanged
        If Rdb_ByContId.Checked Then
            Txt_ContId.Enabled = True
        Else
            Txt_ContId.Enabled = False
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