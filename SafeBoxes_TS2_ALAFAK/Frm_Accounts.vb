Public Class Frm_Accounts

    Private Sub Frm_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Rdb_Clients.Checked Then
            'Clients Codes
        Else
            'Companies Codes
        End If
    End Sub

    Private Sub Rdb_Clients_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Clients.CheckedChanged
        If Rdb_Clients.Checked Then
            'Clients Codes
            Me.Text = "Accounts Manager | Clients"
        Else
            'Companies Codes
            Me.Text = "Accounts Manager | Companies"
        End If
    End Sub

    Private Sub Btn_NewAccount_Click(sender As Object, e As EventArgs) Handles Btn_NewAccount.Click
        If Rdb_Clients.Checked Then
            'Clients Codes
        Else
            'Companies Codes
        End If
    End Sub

    Private Sub Btn_ModAccount_Click(sender As Object, e As EventArgs) Handles Btn_ModAccount.Click
        If Rdb_Clients.Checked Then
            'Clients Codes
        Else
            'Companies Codes
        End If
    End Sub

    Private Sub Btn_DelAccount_Click(sender As Object, e As EventArgs) Handles Btn_DelAccount.Click
        If Rdb_Clients.Checked Then
            'Clients Codes
        Else
            'Companies Codes
        End If
    End Sub


End Class