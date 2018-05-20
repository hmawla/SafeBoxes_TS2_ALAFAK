Public Class Frm_Report_Client
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Clients
    Private Sub Frm_Report_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRptV_Clients.ReportSource = CrysReport
        CRptV_Clients.RefreshReport()
    End Sub
End Class