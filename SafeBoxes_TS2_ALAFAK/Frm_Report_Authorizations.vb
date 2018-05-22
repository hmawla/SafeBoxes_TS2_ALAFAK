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
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Authorization WHERE (AuthSignDate BETWEEN #" & Dte_from.Value.ToShortDateString & "# AND #" & dtpick_exdate.Value.ToShortDateString & "#)").Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_Authorizations.ReportSource = CrysReport
        RptV_Authorizations.RefreshReport()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Dte_from.Enabled = True
            dtpick_exdate.Enabled = True
        Else
            Dte_from.Enabled = False
            dtpick_exdate.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Authorization WHERE ContId =" & TextBox1.Text).Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_Authorizations.ReportSource = CrysReport
        RptV_Authorizations.RefreshReport()
    End Sub
End Class