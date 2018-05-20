Public Class Frm_Report_Connects
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Connects
    Private Sub Frm_Report_Connects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_connects.ReportSource = CrysReport
        RptV_connects.RefreshReport()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Only_Number(TextBox1, e)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_exdate.ValueChanged, DateTimePicker1.ValueChanged
        If DateTimePicker1.Value >= dtpick_exdate.Value Then
            MessageBox.Show("To Date should be greater than from date!")
            dtpick_exdate.Value = DateTimePicker1.Value.AddDays(1)
        End If
    End Sub
End Class