Public Class Frm_Report_WithdrawPermission
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Withdraw

    Private Sub Frm_Report_WithdrawPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_Withdraw.ReportSource = CrysReport
        RptV_Withdraw.RefreshReport()
    End Sub
End Class