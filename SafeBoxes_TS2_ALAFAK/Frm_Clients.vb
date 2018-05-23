
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
        Dim result As Object = InputBox("Enter admin password:", "Delete Client#" & dgv_clients.SelectedRows(0).Cells(0).Value, "")
        If result = "12345" Then
            ExecuteQuery("DELETE FROM Clients WHERE ClientId = " & dgv_clients.SelectedRows(0).Cells(0).Value)
            FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName AS [First Name], ClientMName AS [Father Name], ClientLName AS [Last Name], ClientDOB AS [Date Of Birth], ClientMother AS [Mother Name], ClientRegisterNbr, PostBoxNbr,RegionName  FROM Clients c,Regions r WHERE c.RegionId=r.RegionId")
        Else
            MessageBox.Show("Wrong password!")
        End If

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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        If rdb_byClientid.Checked Then
            FillDGV(dgv_clients, "SELECT ClientId as ID, ClientFName + ' ' + ClientLName as [Full Name], ClientMName as [Father's Name], ClientMother as [Mother's Name], ClientDOB as [Birth Date] FROM Clients WHERE ClientId = " & txt_bycid.Text)
        Else
            Dim firstName As String
            Dim lastName As String = ""
            firstName = txt_bycname.Text.Split(New Char() {" "c})(0)
            Try
                lastName = txt_bycname.Text.Split(New Char() {" "c})(1)
            Catch ex As Exception

            End Try
            Dim theQuery As String = "SELECT ClientId as ID, ClientFName + ' ' + ClientLName as [Full Name], ClientMName as [Father's Name], ClientMother as [Mother's Name], ClientDOB as [Birth Date] FROM Clients WHERE ClientFName LIKE '%" & firstName & "%'"
            If lastName <> "" Then
                theQuery = "SELECT ClientId as ID, ClientFName + ' ' + ClientLName as [Full Name], ClientMName as [Father's Name], ClientMother as [Mother's Name], ClientDOB as [Birth Date] FROM Clients WHERE ClientFName LIKE '%" & firstName & "%' AND ClientLName LIKE '%" & lastName & "%'"
            End If
            FillDGV(dgv_clients, theQuery)
        End If
    End Sub

    Private Sub rdb_byClientid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byClientid.CheckedChanged
        txt_bycid.Enabled = True
        txt_bycname.Enabled = False
        txt_bycname.Text = ""
    End Sub

    Private Sub rdb_byClientName_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byClientName.CheckedChanged
        txt_bycid.Enabled = False
        txt_bycname.Enabled = True
        txt_bycid.Text = ""
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_clients, "SELECT ClientId as ID, ClientFName + ' ' + ClientLName as [Full Name], ClientMName as [Father's Name], ClientMother as [Mother's Name], ClientDOB as [Birth Date] FROM Clients")
        btn_reset.Enabled = False
        txt_bycid.Text = ""
        txt_bycname.Text = ""
    End Sub

    Private Sub txt_bycname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bycname.KeyPress
        Only_char(txt_bycname, e)
    End Sub

    Private Sub txt_bycid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bycid.KeyPress
        Only_Number(txt_bycid, e)
    End Sub
End Class