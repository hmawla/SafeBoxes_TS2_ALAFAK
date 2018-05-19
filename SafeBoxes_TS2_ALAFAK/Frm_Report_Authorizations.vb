Public Class Frm_Report_Authorizations
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Authorizations

    Private Sub Frm_Report_Authorizations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_Authorizations.ReportSource = CrysReport
        RptV_Authorizations.RefreshReport()
    End Sub
End Class