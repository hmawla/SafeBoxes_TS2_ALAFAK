Public Class Frm_CompaniesAccounts
    Private Sub Frm_CompaniesAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_accounts, "SELECT ca.AccountId AS [ACCOUNT ID],CompName AS [COMPANY],ClientFName AS [REPRESENTATOR],SignCardId FROM  CompanyAccounts ca,Company com,Clients c,ClientRepAccount rep,SignCardsAccounts sca WHERE ca.CompId=com.CompId AND rep.ClientId=c.ClientId AND ca.AccountId=sca.AccountId")
    End Sub

    Private Sub txt_byaccid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byaccid.KeyPress
        Only_Number(txt_byaccid, e)
    End Sub

    Private Sub txt_cname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cname.KeyPress
        Only_char(txt_cname, e)
    End Sub
End Class