Public Class Frm_SelectAccount
    Private Sub Frm_SelectAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_accounts, "SELECT AccountId, ClientFName & ' ' & ClientLName as client, ClientMother, ClientDOB  FROM Clients C, ClientDepAccount A WHERE A.ClientId = C.ClientId")
    End Sub
End Class