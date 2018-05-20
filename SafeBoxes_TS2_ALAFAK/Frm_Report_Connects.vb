Public Class Frm_Report_Connects
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Connects
    Private Sub Frm_Report_Connects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_connects.ReportSource = CrysReport
        RptV_connects.RefreshReport()
    End Sub
End Class