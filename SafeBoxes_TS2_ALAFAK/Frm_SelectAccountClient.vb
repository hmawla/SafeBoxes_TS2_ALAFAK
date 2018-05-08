Public Class Frm_SelectAccountClient
    Private Sub Frm_SelectAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_accounts, "SELECT AccountId, ClientFName & ' ' & ClientLName as client, ClientMother, ClientDOB  FROM Clients C, ClientDepAccount A WHERE A.ClientId = C.ClientId")
    End Sub

    Private Sub rdb_byid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byid.CheckedChanged
        txt_byid.Enabled = True
        txt_byname.Enabled = False
    End Sub

    Private Sub rdb_byname_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byname.CheckedChanged
        txt_byid.Enabled = False
        txt_byname.Enabled = True
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        btn_select.Enabled = False
        If rdb_byid.Checked Then
            FillDGV(dgv_accounts, "SELECT AccountId, ClientFName & ' ' & ClientLName as client, ClientMother, ClientDOB  FROM Clients C, ClientDepAccount A WHERE A.ClientId = C.ClientId AND C.ClientId = " & txt_byid.Text)
        Else
            Dim firstName As String
            Dim lastName As String = ""
            firstName = txt_byname.Text.Split(New Char() {" "c})(0)
            Try
                lastName = txt_byname.Text.Split(New Char() {" "c})(1)
            Catch ex As Exception

            End Try

            Dim theQuery As String = "SELECT AccountId, ClientFName & ' ' & ClientLName as client, ClientMother, ClientDOB  FROM Clients C, ClientDepAccount A WHERE A.ClientId = C.ClientId AND (ClientFName LIKE '%" & firstName & "%')"
            If lastName <> "" Then
                theQuery = "SELECT AccountId, ClientFName & ' ' & ClientLName as client, ClientMother, ClientDOB  FROM Clients C, ClientDepAccount A WHERE A.ClientId = C.ClientId AND (ClientFName LIKE '%" & firstName & "%' AND ClientLName LIKE '%" & lastName & "%')"
            End If
            FillDGV(dgv_accounts, theQuery)
        End If

    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_accounts, "SELECT AccountId, ClientFName & ' ' & ClientLName as client, ClientMother, ClientDOB  FROM Clients C, ClientDepAccount A WHERE A.ClientId = C.ClientId")
        btn_reset.Enabled = False
    End Sub

    Private Sub dgv_accounts_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_accounts.RowEnter
        btn_select.Enabled = True
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Frm_main.accountid = dgv_accounts.SelectedRows.Item(0).Cells.Item(0).Value
        'frm_newContract.txt_accountid.Text = dgv_accounts.SelectedRows.Item(0).Cells.Item(0).Value
        Me.Close()
    End Sub

    Private Sub txt_byid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byid.KeyPress
        Only_Number(txt_byid, e)
    End Sub

    Private Sub txt_byname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byname.KeyPress
        Only_char(txt_byname, e)
    End Sub
End Class