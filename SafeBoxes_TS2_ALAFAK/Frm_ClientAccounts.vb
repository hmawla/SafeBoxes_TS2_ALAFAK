
Public Class Frm_ClientAccounts

    Public ClientId As Integer

    Private Sub Frm_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_accounts, "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId")
    End Sub

    Private Sub btn_newbox_Click(sender As Object, e As EventArgs) Handles btn_newbox.Click
        ClientId = 0
        Frm_NewAccountClient.ShowDialog()
        FillDGV(dgv_accounts, "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId")

    End Sub

    Private Sub btn_modbox_Click(sender As Object, e As EventArgs) Handles btn_modbox.Click
        ClientId = dgv_accounts.SelectedRows(0).Cells(0).Value
        Frm_SelectBox.ShowDialog()
        FillDGV(dgv_accounts, "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId")
    End Sub

    Private Sub txt_byaccid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byaccid.KeyPress
        Only_Number(txt_byaccid, e)
    End Sub

    Private Sub txt_cname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cname.KeyPress
        Only_char(txt_cname, e)
    End Sub

End Class