Public Class Frm_Report_EndingContracts
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_EndingContract
    Private Sub Frm_Report_EndingContracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_EndingContracts.ReportSource = CrysReport
        RptV_EndingContracts.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_exdate.ValueChanged, DateTimePicker1.ValueChanged
        If DateTimePicker1.Value >= dtpick_exdate.Value Then
            MessageBox.Show("To Date should be greater than from date!")
            dtpick_exdate.Value = DateTimePicker1.Value.AddDays(1)
        End If
    End Sub
End Class