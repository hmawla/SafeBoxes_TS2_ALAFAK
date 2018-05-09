Public Class Frm_Contracts
    Private Sub Frm_Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId AS [ID], ContBDate [Contract Date], ContToDate [Expire Date] BoxId, ContBDate FROM Contract")
    End Sub
End Class