Public Class Frm_SelectContract
    Private Sub txt_byid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byid.KeyPress
        Only_Number(txt_byid, e)
    End Sub

    Private Sub txt_byname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byname.KeyPress
        Only_char(txt_byname, e)
    End Sub
End Class