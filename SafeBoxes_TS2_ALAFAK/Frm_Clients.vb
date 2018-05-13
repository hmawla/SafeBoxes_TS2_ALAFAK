
Public Class Frm_Clients
    Public clientId As Integer
    Private Sub Frm_Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName AS [First Name], ClientMName AS [Father Name], ClientLName AS [Last Name], ClientDOB AS [Date Of Birth], ClientMother AS [Mother Name], ClientRegisterNbr, PostBoxNbr,RegionName  FROM Clients c,Regions r WHERE c.RegionId=r.RegionId")
    End Sub

    Private Sub btn_newclient_Click(sender As Object, e As EventArgs) Handles btn_newclient.Click
        clientId = 0
        Frm_NewClient.ShowDialog()
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName AS [First Name], ClientMName AS [Father Name], ClientLName AS [Last Name], ClientDOB AS [Date Of Birth], ClientMother AS [Mother Name], ClientRegisterNbr, PostBoxNbr,RegionName  FROM Clients c,Regions r WHERE c.RegionId=r.RegionId")
    End Sub

    Private Sub btn_modclient_Click(sender As Object, e As EventArgs) Handles btn_modclient.Click
        clientId = dgv_clients.SelectedRows(0).Cells(0).Value
        Frm_NewClient.ShowDialog()
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName AS [First Name], ClientMName AS [Father Name], ClientLName AS [Last Name], ClientDOB AS [Date Of Birth], ClientMother AS [Mother Name], ClientRegisterNbr, PostBoxNbr,RegionName  FROM Clients c,Regions r WHERE c.RegionId=r.RegionId")
    End Sub

    Private Sub btn_delclient_Click(sender As Object, e As EventArgs) Handles btn_delclient.Click
        ExecuteQuery("DELETE FROM Clients WHERE ClientId = " & dgv_clients.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName AS [First Name], ClientMName AS [Father Name], ClientLName AS [Last Name], ClientDOB AS [Date Of Birth], ClientMother AS [Mother Name], ClientRegisterNbr, PostBoxNbr,RegionName  FROM Clients c,Regions r WHERE c.RegionId=r.RegionId")
    End Sub

    Private Sub dgv_clients_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_clients.SelectionChanged
        Try
            If dgv_clients.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delclient.Enabled = True
            btn_modclient.Enabled = True
        Catch ex As Exception
            btn_delclient.Enabled = False
            btn_modclient.Enabled = False
        End Try
    End Sub

    Private Sub dgv_clients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clients.CellDoubleClick
        If Frm_main.clientid = 0 Then
            Try
                If dgv_clients.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                Frm_main.clientid = dgv_clients.SelectedRows(0).Cells(0).Value
                Me.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class