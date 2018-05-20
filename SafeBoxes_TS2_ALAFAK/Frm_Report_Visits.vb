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
    End Sub
End Class