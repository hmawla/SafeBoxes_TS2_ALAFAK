Public Class Frm_Report_InfoResult
    Dim crpt As New Rpt_Info_result
    Dim ds As New DataSet
    Private Sub Frm_Report_InfoResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Reset()
        ds = ReadQueryOut("SELECT * FROM InfoResult WHERE InfoResultId = " & frm_Info_Result.theInfo).Copy()
        crpt.Database.Tables(0).SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = crpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class