Public Class Frm_NewInfoVoucher
    Private Sub Frm_NewInfoVoucher_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_subjecttitles, "SELECT InfoSubjTitleId, InfoSubjTitle FROM InfoSubjectTitles", "InfoSubjTitleId", "InfoSubjTitle")
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click
        Frm_main.clientid = 0
        Frm_SelectClient.ShowDialog()
        txt_clientid.Text = Frm_main.clientid
    End Sub

    Private Sub txt_clientid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clientid.KeyPress
        Only_Number(txt_clientid, e)
    End Sub

    Private Sub txt_clientid_Leave(sender As Object, e As EventArgs) Handles txt_clientid.Leave
        If txt_clientid.Text <> "" Then
            If Exists(txt_clientid.Text, "SELECT ClientId FROM Clients") Then
                Dim ds As New DataSet
                ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName FROM Clients WHERE ClientId = " & txt_clientid.Text)
                txt_clientname.Text = ds.Tables(0).Rows(0).Item(0)
            Else
                MessageBox.Show("Invalid Client ID!")
                txt_clientid.Focus()
                txt_clientid.SelectAll()
            End If
        Else
            MessageBox.Show("Invalid Client ID!")
            txt_clientid.Focus()
        End If

    End Sub

    Private Sub txt_contractid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contractid.KeyPress
        Only_Number(txt_contractid, e)
    End Sub

    Private Sub dtpick_totime_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_totime.ValueChanged, dtpick_fromtime.ValueChanged
        If dtpick_fromtime.Value >= dtpick_totime.Value Then
            MessageBox.Show("From time should be greater than to time !")
        ElseIf dtpick_totime.Value <= dtpick_fromtime.Value
            MessageBox.Show("To time should be greater than from time !")
        End If
    End Sub
End Class