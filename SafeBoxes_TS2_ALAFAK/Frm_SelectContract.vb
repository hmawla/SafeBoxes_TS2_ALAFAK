Public Class Frm_SelectContract
    Private Sub txt_byid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byboxid.KeyPress
        Only_Number(txt_byboxid, e)
    End Sub

    Private Sub txt_byname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byaccid.KeyPress
        Only_Number(txt_byaccid, e)
    End Sub
    Private Sub Frm_SelectContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract")
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        btn_select.Enabled = False
        If rdb_byboxid.Checked Then
            FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract WHERE BoxId = " & txt_byboxid.Text)
        Else
            FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract WHERE AccountId = " & txt_byaccid.Text)
        End If
    End Sub

    Private Sub rdb_byboxid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byboxid.CheckedChanged
        Toggle(txt_byboxid)
    End Sub

    Private Sub rdb_byaccountid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byaccountid.CheckedChanged
        Toggle(txt_byaccid)
    End Sub

    Private Sub SelectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAccountToolStripMenuItem.Click
        Frm_main.accountid = 0
        Frm_SelectAccountClient.ShowDialog()
        txt_byaccid.Text = Frm_main.accountid
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract")
        btn_reset.Enabled = False
    End Sub

    Private Sub dgv_contracts_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contracts.RowEnter
        btn_select.Enabled = True
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Frm_main.accountid = dgv_contracts.SelectedRows.Item(0).Cells.Item(0).Value
        Me.Close()
    End Sub
End Class