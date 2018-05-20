Public Class Frm_Report_Authorizations
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Authorizations

    Private Sub Frm_Report_Authorizations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_Authorizations.ReportSource = CrysReport
        RptV_Authorizations.RefreshReport()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Only_Number(TextBox1, e)
    End Sub

    Private Sub dtpick_exdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_exdate.ValueChanged, Dte_from.ValueChanged
        If Dte_from.Value >= dtpick_exdate.Value Then
            MessageBox.Show("To Date should be greater than from date!")
            dtpick_exdate.Value = Dte_from.Value.AddDays(1)
        End If
    End Sub
End Class