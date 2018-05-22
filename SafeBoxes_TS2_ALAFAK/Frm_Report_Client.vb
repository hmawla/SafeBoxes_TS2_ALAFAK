Public Class Frm_Report_Client
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Clients
    Private Sub Frm_Report_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRptV_Clients.ReportSource = CrysReport
        CRptV_Clients.RefreshReport()
    End Sub

    Private Sub Txt_ContId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CId.KeyPress
        Only_Number(Txt_CId, e)
    End Sub

    Private Sub txt_cname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cname.KeyPress
        Only_char(txt_cname, e)
    End Sub

    Private Sub Rdb_ByClientId_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByClientId.CheckedChanged
        If Rdb_ByClientId.Checked Then
            Txt_CId.Enabled = True
        Else
            Txt_CId.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            txt_cname.Enabled = True
        Else
            txt_cname.Enabled = False
        End If
    End Sub

    Private Sub Txt_CId_TextChanged(sender As Object, e As EventArgs) Handles Txt_CId.TextChanged
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Clients WHERE ClientId =" & Txt_CId.Text).Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        CRptV_Clients.ReportSource = CrysReport
        CRptV_Clients.RefreshReport()
    End Sub

    Private Sub txt_cname_TextChanged(sender As Object, e As EventArgs) Handles txt_cname.TextChanged
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Clients WHERE ClientFName LIKE '%" & txt_cname.Text & "%'").Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        CRptV_Clients.ReportSource = CrysReport
        CRptV_Clients.RefreshReport()
    End Sub
End Class