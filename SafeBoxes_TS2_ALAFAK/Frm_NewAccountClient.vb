﻿Public Class Frm_NewAccountClient
    Private Sub txt_compname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compname.KeyPress
        Only_Number(txt_compname, e)
    End Sub
End Class