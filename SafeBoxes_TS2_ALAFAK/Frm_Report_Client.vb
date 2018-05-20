Public Class Frm_Report_Client
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Clients
    Private Sub Frm_Report_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRptV_Clients.ReportSource = CrysReport
        CRptV_Clients.RefreshReport()
    End Sub

    Private Sub Txt_ContId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ContId.KeyPress
        Only_Number(Txt_ContId, e)
    End Sub

    Private Sub txt_cname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cname.KeyPress
        Only_char(txt_cname, e)
    End Sub
End Class