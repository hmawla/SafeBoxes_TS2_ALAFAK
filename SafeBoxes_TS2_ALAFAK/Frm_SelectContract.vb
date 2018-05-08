Public Class Frm_SelectContract
    Private Sub txt_byid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byid.KeyPress
        Only_Number(txt_byid, e)
    End Sub

    Private Sub txt_byname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byname.KeyPress
        Only_char(txt_byname, e)
    End Sub
    Private Sub Frm_SelectContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract")
        'Will Work on this form later
    End Sub
End Class