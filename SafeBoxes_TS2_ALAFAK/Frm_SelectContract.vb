Public Class Frm_SelectContract
<<<<<<< HEAD
    Private Sub txt_byid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byid.KeyPress
        Only_Number(txt_byid, e)
    End Sub

    Private Sub txt_byname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byname.KeyPress
        Only_char(txt_byname, e)
=======
    Private Sub Frm_SelectContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract")
        'Will Work on this form later
>>>>>>> 85160ad44dce7b9c26be98fb2e30d920493081b1
    End Sub
End Class