Public Class Frm_Report_Contract
    Dim RptDbDataSet As New DataSet 'Declare the new dataset
    Dim CrysReport As New Rpt_Contract 'Declare an instance of the crystal report

    Private Sub Frm_Report_Contract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptDbDataSet.Reset() 'reset the dataset incase it has data
        CRptV_Contract.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Contract.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub

    Private Sub Rdb_ByContId_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByContId.CheckedChanged

    End Sub
End Class