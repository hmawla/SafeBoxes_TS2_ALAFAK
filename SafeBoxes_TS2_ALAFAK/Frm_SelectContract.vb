Public Class Frm_SelectContract
    Private Sub Frm_SelectContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId, AccountId, BoxId, ContBDate FROM Contract")
        'Will Work on this form later
    End Sub
End Class