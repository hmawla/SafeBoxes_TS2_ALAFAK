Public Class Frm_Report_Boxes
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Boxes1
    Private Sub Frm_Report_Boxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_Boxes.ReportSource = CrysReport
        RptV_Boxes.RefreshReport()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Only_Number(TextBox1, e)
    End Sub
End Class