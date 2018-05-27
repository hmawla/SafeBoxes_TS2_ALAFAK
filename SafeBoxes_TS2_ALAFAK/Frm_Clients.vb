
Public Class Frm_Clients
    Public clientId As Integer
    Private Sub Frm_Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId")
    End Sub

    Private Sub btn_newclient_Click(sender As Object, e As EventArgs) Handles btn_newclient.Click
        clientId = 0
        Frm_NewClient.ShowDialog()
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId")
    End Sub

    Private Sub btn_modclient_Click(sender As Object, e As EventArgs) Handles btn_modclient.Click
        clientId = dgv_clients.SelectedRows(0).Cells(0).Value
        Frm_NewClient.ShowDialog()
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId")
    End Sub

    Private Sub btn_delclient_Click(sender As Object, e As EventArgs) Handles btn_delclient.Click
        InputBox.Show("Enter admin password:", "Delete Client#" & dgv_clients.SelectedRows(0).Cells(0).Value, True)
        If Not inResult.Equals("0") Then
            If inResult = "12345" Then
                ExecuteQuery("DELETE FROM Clients WHERE ClientId = " & dgv_clients.SelectedRows(0).Cells(0).Value)
                FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId")
            Else
                MessageBox.Show("Wrong password!")
            End If
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
            If txt_bycid.Text.Count > 0 Then
                FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId AND ClientId = " & txt_bycid.Text)
            Else
                MessageBox.Show("Enter a valid ID!")
            End If

        Else
            If txt_bycname.Text.Count > 0 Then
                Dim firstName As String
                Dim lastName As String = ""
                firstName = txt_bycname.Text.Split(New Char() {" "c})(0)
                Try
                    lastName = txt_bycname.Text.Split(New Char() {" "c})(1)
                Catch ex As Exception

                End Try
                Dim theQuery As String = "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId AND ClientFName LIKE '%" & firstName & "%'"
                If lastName <> "" Then
                    theQuery = "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId AND ClientFName LIKE '%" & firstName & "%' AND ClientLName LIKE '%" & lastName & "%'"
                End If
                FillDGV(dgv_clients, theQuery)
            Else
                MessageBox.Show("Enter a valid name!")
            End If
        End If
    End Sub

    Private Sub rdb_byClientid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byClientid.CheckedChanged
        txt_bycid.Enabled = True
        txt_bycname.Enabled = False
        txt_bycname.Text = ""
        txt_bycid.Focus()
    End Sub

    Private Sub rdb_byClientName_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byClientName.CheckedChanged
        txt_bycid.Enabled = False
        txt_bycname.Enabled = True
        txt_bycid.Text = ""
        txt_bycname.Focus()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName + ' ' + ClientLName AS [Client's Name], ClientMName AS [Father's Name], ClientMother AS [Mother's Name], ClientDOB AS [Date of Birth], ClientRegisterNbr AS [Register#], PostBoxNbr AS [Post Box#], RegionName AS [Birth Place] FROM Clients C, Regions R WHERE C.RegionId = R.RegionId")
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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Frm_Report_Client.ShowDialog()
    End Sub
End Class