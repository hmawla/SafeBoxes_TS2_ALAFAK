Public Class Frm_Report_RenewContract
    Dim RptDbDataSet As New DataSet 'Declare the new dataset
    Dim CrysReport As New Rpt_Renew 'Declare an instance of the crystal report
    Private Sub Frm_Report_RenewContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptDbDataSet.Reset() 'reset the dataset incase it has data
        CRptV_Renew.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Renew.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub

    Private Sub Txt_ContId_TextChanged(sender As Object, e As EventArgs) Handles Txt_ContId.TextChanged
        RptDbDataSet.Reset() 'reset the dataset incase it has data
        RptDbDataSet = ReadQueryOut("SELECT * FROM Renew WHERE ContId = " & Txt_ContId.Text).Copy() 'Set the condition on the desired table
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0)) 'Override the table(0) (First table in the Creport database) using the condition
        CRptV_Renew.ReportSource = CrysReport 'set the viewer's source to the created instance of the creport
        CRptV_Renew.RefreshReport() 'Refresh the viewer (may not be needed)
    End Sub
End Class