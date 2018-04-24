Public Class frm_newContract
    Private Sub frm_newContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SelectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAccountToolStripMenuItem.Click
        Frm_SelectAccount.ShowDialog()
    End Sub

    Private Sub txt_accountid_Leave(sender As Object, e As EventArgs) Handles txt_accountid.Leave
        txt_clientinfo.Text = ""
        Dim i As Integer = 1
        Dim ds As DataSet
        Try
            ds = ReadQueryOut("SELECT c.ClientId, ClientFName, ClientLName, ClientMName, ClientMother, ClientDOB FROM Clients c, ClientDepAccount a WHERE a.accountid = " & txt_accountid.Text)
            For Each datarow As DataRow In ds.Tables(0).Rows
                txt_clientinfo.Text = txt_clientinfo.Text & "Client (" & i & ")" & vbNewLine & "Client ID: " & datarow.Item(0) & vbNewLine
                i = i + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class