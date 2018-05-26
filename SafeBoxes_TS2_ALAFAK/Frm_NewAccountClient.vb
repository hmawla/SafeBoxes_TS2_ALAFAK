Public Class Frm_NewAccountClient
    Dim ds As New DataSet
    Dim theNewId As Integer
    Private Sub txt_compname_KeyPress(sender As Object, e As KeyPressEventArgs)
        Only_Number(Txt_Cid, e)
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click
        Frm_main.clientid = 0
        Frm_Clients.ShowDialog()
        Txt_Cid.Text = Frm_main.clientid
    End Sub

    Private Sub Txt_Cid_TextChanged(sender As Object, e As EventArgs) Handles Txt_Cid.TextChanged
        Try
            ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName FROM Clients WHERE ClientId = " & Txt_Cid.Text)
            Txt_CName.Text = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Txt_CName.Text = ""
        End Try
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        For Each row As DataGridViewRow In DGV_Clients.Rows
            If row.Cells(0).Value.Equals(Txt_Cid.Text) Then
                MessageBox.Show("Client already added!")
                GoTo theEnd
            End If
        Next
        If Txt_CName.Text.Count > 0 Then
            DGV_Clients.Rows.Add(Txt_Cid.Text, Txt_CName.Text)
        Else
            MessageBox.Show("Invalid Client ID!")
        End If
theEnd:

    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If DGV_Clients.Rows.Count > 0 Then
            theNewId = GenAccID()
            For Each row As DataGridViewRow In DGV_Clients.Rows
                ExecuteQuery("INSERT INTO ClientDepAccount VALUES(" & row.Cells(0).Value & ", " & theNewId & ")")
            Next
            MessageBox.Show("Account Added!")
            Me.Dispose()

        Else
            MessageBox.Show("Please add at least one Client!")
        End If

    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        DGV_Clients.Rows.Remove(DGV_Clients.SelectedRows(0))
    End Sub
End Class