﻿Public Class Frm_Accounts

    Private Sub Frm_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clients Codes
        FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.ClientId AS [Client ID], ClientFName + ' ' + ClientLName AS [Client's Name] FROM Clients C, ClientDepAccount A WHERE C.ClientId = A.ClientId")
    End Sub

    Private Sub Rdb_Clients_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Clients.CheckedChanged
        If Rdb_Clients.Checked Then
            'Clients Codes
            Me.Text = "Accounts Manager | Clients"
            FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.ClientId AS [Client ID], ClientFName + ' ' + ClientLName AS [Client's Name] FROM Clients C, ClientDepAccount A WHERE C.ClientId = A.ClientId")
        Else
            'Companies Codes
            Me.Text = "Accounts Manager | Companies"
            FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.CompId AS [Company ID], CompName AS [Company's Name] FROM CompanyAccounts A, Company AS C WHERE A.CompId = C.CompId")
        End If
    End Sub

    Private Sub Btn_NewAccount_Click(sender As Object, e As EventArgs) Handles Btn_NewAccount.Click
        If Rdb_Clients.Checked Then
            'Clients Codes
            Frm_main.accountid = 0
            Frm_NewAccountClient.ShowDialog()
            FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.ClientId AS [Client ID], ClientFName + ' ' + ClientLName AS [Client's Name] FROM Clients C, ClientDepAccount A WHERE C.ClientId = A.ClientId")

        Else
            'Companies Codes
            Frm_main.accountid = 0
            Frm_NewAccountCompany.ShowDialog()
            FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.CompId AS [Company ID], CompName AS [Company's Name] FROM CompanyAccounts A, Company AS C WHERE A.CompId = C.CompId")
        End If
    End Sub

    Private Sub Btn_ModAccount_Click(sender As Object, e As EventArgs) Handles Btn_ModAccount.Click
        If Rdb_Clients.Checked Then
            'Clients Codes
            If DGV_Accounts.Rows.Count > 0 Then
                Frm_main.accountid = DGV_Accounts.SelectedRows(0).Cells(0).Value
                Frm_NewAccountClient.ShowDialog()
                FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.ClientId AS [Client ID], ClientFName + ' ' + ClientLName AS [Client's Name] FROM Clients C, ClientDepAccount A WHERE C.ClientId = A.ClientId")
            Else
                MessageBox.Show("Select at least one record!")
            End If
        Else
            'Companies Codes
            If DGV_Accounts.Rows.Count > 0 Then
                Frm_main.accountid = DGV_Accounts.SelectedRows(0).Cells(0).Value
                Frm_NewAccountCompany.ShowDialog()
                FillDGV(DGV_Accounts, "SELECT AccountId AS [Account ID], C.CompId AS [Company ID], CompName AS [Company's Name] FROM CompanyAccounts A, Company AS C WHERE A.CompId = C.CompId")
            Else
                MessageBox.Show("Select at least one record!")
            End If
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