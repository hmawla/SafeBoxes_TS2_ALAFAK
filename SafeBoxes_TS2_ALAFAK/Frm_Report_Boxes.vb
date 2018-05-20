Public Class Frm_Report_Boxes
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_boxes
    Private Sub Frm_Report_Boxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_Boxes.ReportSource = CrysReport
        RptV_Boxes.RefreshReport()
    End Sub
End Class