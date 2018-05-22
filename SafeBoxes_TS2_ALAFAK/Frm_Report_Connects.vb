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
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT * FROM Connects WHERE (ConnectDate BETWEEN #" & DateTimePicker1.Value.ToShortDateString & "# AND #" & dtpick_exdate.Value.ToShortDateString & "#)").Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_connects.ReportSource = CrysReport
        RptV_connects.RefreshReport()
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
        RptDbDataSet = ReadQueryOut("SELECT * FROM Connects WHERE ConnectId =" & TextBox1.Text).Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_connects.ReportSource = CrysReport
        RptV_connects.RefreshReport()
    End Sub
End Class