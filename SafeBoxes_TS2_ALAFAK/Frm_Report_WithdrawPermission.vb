Public Class Frm_Report_WithdrawPermission
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Withdraw

    Private Sub Frm_Report_WithdrawPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptV_Withdraw.ReportSource = CrysReport
        RptV_Withdraw.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_exdate.ValueChanged, DateTimePicker1.ValueChanged
        If DateTimePicker1.Value >= dtpick_exdate.Value Then
            MessageBox.Show("To Date should be greater than from date!")
            dtpick_exdate.Value = DateTimePicker1.Value.AddDays(1)
        End If
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Permissions WHERE (PermDate BETWEEN #" & DateTimePicker1.Value.ToShortDateString & "# AND #" & dtpick_exdate.Value.ToShortDateString & "#)").Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_Withdraw.ReportSource = CrysReport
        RptV_Withdraw.RefreshReport()
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
            DateTimePicker1.Enabled = True
            dtpick_exdate.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            dtpick_exdate.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Permission WHERE ContId =" & TextBox1.Text).Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_Withdraw.ReportSource = CrysReport
        RptV_Withdraw.RefreshReport()
    End Sub
End Class