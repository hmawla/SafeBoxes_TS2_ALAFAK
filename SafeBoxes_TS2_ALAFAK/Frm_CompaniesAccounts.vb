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

    Private Sub dgv_accounts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_accounts.CellDoubleClick
        If Frm_main.accountid = 0 Then
            Try
                If dgv_accounts.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                Frm_main.accountid = dgv_accounts.SelectedRows(0).Cells(0).Value
                Me.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class