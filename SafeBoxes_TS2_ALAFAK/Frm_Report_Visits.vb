Public Class Frm_Report_Visits
    Dim RptDbDataSet As New DataSet 'Declare the new dataset
    Dim CrysReport As New Rpt_Visits 'Declare an instance of the crystal report
    Private Sub Frm_Report_Visits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptDbDataSet.Reset() 'reset the dataset incase it has data
        CRptV_Visits.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Visits.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub
End Class