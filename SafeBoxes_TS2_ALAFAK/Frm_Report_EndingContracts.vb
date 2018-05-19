Public Class Frm_Report_EndingContracts
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_EndingContract
    Private Sub Frm_Report_EndingContracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_EndingContracts.ReportSource = CrysReport
        RptV_EndingContracts.RefreshReport()
    End Sub
End Class