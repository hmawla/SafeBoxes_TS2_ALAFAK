Public Class Frm_Report_Client
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_Clients

    Private Sub Txt_ContId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CId.KeyPress
        Only_Number(Txt_CId, e)
    End Sub

    Private Sub txt_cname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cname.KeyPress
        Only_char(txt_cname, e)
    End Sub

    Private Sub Rdb_ByClientId_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ByClientId.CheckedChanged
        If Rdb_ByClientId.Checked Then
            Txt_CId.Enabled = True
            txt_cname.Text = ""
            txt_cname.Enabled = False
            Txt_CId.Focus()
        Else
            Txt_CId.Enabled = False
            txt_cname.Enabled = True
            Txt_CId.Text = ""
            txt_cname.Focus()
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Rdb_ByClientId.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT * FROM Clients WHERE ClientId =" & Txt_CId.Text).Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            CRptV_Clients.ReportSource = CrysReport
            CRptV_Clients.RefreshReport()
        Else
            If txt_cname.Text.Count > 0 Then
                Dim firstName As String
                Dim lastName As String = ""
                firstName = txt_cname.Text.Split(New Char() {" "c})(0)
                Try
                    lastName = txt_cname.Text.Split(New Char() {" "c})(1)
                Catch ex As Exception

                End Try
                Dim theQuery As String = "SELECT * FROM Clients WHERE ClientFName LIKE '%" & firstName & "%'"
                If lastName <> "" Then
                    theQuery = "SELECT * FROM Clients WHERE ClientFName LIKE '%" & firstName & "%' AND ClientLName LIKE '%" & lastName & "%'"
                End If
                RptDbDataSet.Reset()
                RptDbDataSet = ReadQueryOut(theQuery).Copy()
                CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
                CRptV_Clients.ReportSource = CrysReport
                CRptV_Clients.RefreshReport()
            Else
                MessageBox.Show("Enter a valid name!")
            End If
        End If
    End Sub

    Private Sub Frm_Report_Client_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class