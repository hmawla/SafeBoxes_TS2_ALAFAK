
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

    Private Sub rdb_byAccid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byAccid.CheckedChanged
        txt_byaccid.Enabled = True
        txt_cname.Enabled = False
        txt_cname.Text = ""
        txt_byaccid.Focus()
    End Sub

    Private Sub rdb_byCname_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byCname.CheckedChanged
        txt_byaccid.Enabled = False
        txt_cname.Enabled = True
        txt_byaccid.Text = ""
        txt_cname.Focus()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        If rdb_byAccid.Checked Then
            FillDGV(dgv_accounts, "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE ca.AccountId=" & txt_byaccid.Text & " AND ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId")
        Else
            Dim firstName As String
            Dim lastName As String = ""
            firstName = txt_cname.Text.Split(New Char() {" "c})(0)
            Try
                lastName = txt_cname.Text.Split(New Char() {" "c})(1)
            Catch ex As Exception

            End Try
            Dim theQuery As String = "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE c.ClientFName LIKE '%" & firstName & "%' AND ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId"
            If lastName <> "" Then
                theQuery = "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE c.ClientFName LIKE '%" & firstName & "%' AND c.ClientLName LIKE '%" & lastName & "%' AND ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId"
            End If
            FillDGV(dgv_accounts, theQuery)
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        btn_reset.Enabled = False
        txt_byaccid.Text = ""
        txt_cname.Text = ""
        FillDGV(dgv_accounts, "SELECT ca.AccountId AS [ACCOUNT ID],ClientFName AS [FIRST NAME],ClientLName AS [LAST NAME],SignCardId FROM  ClientDepAccount ca,Clients c,SignCardsAccounts sca WHERE ca.ClientId=c.ClientId AND ca.AccountId=sca.AccountId")
    End Sub
End Class