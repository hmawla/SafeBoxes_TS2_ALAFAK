Public Class Frm_SignatureCards
    Public signaturecardid As Integer = 0
    Private Sub Frm_SignatureCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(670, 574)
        If Frm_main.signatureCardId = 0 Then
            FillDGV(dgv_signcard, "SELECT SignCardId AS [ID], SignCardDate AS [DATE],
                                SignCardNote AS [NOTE], ClientFName AS [CLIENT NAME],
                                Nationality, ContId, CareerName AS [CAREER], BuildingName 
                                FROM SignatureCards sc, Clients c,
                                Nationalities nat ,Careers ca ,Buildings b 
                                WHERE sc.ClientId=c.CLientId AND sc.NationId=nat.NationId 
                                AND sc.Careerid=ca.Careerid AND sc.BuildingId=b.BuildingId AND c.ClientId=" & Frm_main.clientid)

        Else
            FillDGV(dgv_signcard, "SELECT SignCardId AS [ID], SignCardDate AS [DATE],
                                SignCardNote AS [NOTE], ClientFName AS [CLIENT NAME],
                                Nationality, ContId, CareerName AS [CAREER], BuildingName 
                                FROM SignatureCards sc, Clients c,
                                Nationalities nat ,Careers ca ,Buildings b 
                                WHERE sc.ClientId=c.CLientId AND sc.NationId=nat.NationId 
                                AND sc.Careerid=ca.Careerid AND sc.BuildingId=b.BuildingId")
        End If


    End Sub

    Private Sub btn_delbox_Click(sender As Object, e As EventArgs) Handles btn_delbox.Click
        InputBox.Show("Enter admin password:", "Delete Signature Card#" & dgv_signcard.SelectedRows(0).Cells(0).Value, True)
        If Not inResult.Equals("0") Then
            If inResult = adminPass Then
                ExecuteQuery("DELETE FROM SignatureCards WHERE SignCardId = " & dgv_signcard.SelectedRows(0).Cells(0).Value)
            Else
                MessageBox.Show("Wrong password!")
            End If
        End If
        FillDGV(dgv_signcard, "SELECT SignCardId AS [ID], SignCardDate AS [DATE],
                                SignCardNote AS [NOTE], ClientFName AS [CLIENT NAME],
                                Nationality, ContId, CareerName AS [CAREER], BuildingName 
                                FROM SignatureCards sc, Clients c,
                                Nationalities nat ,Careers ca ,Buildings b 
                                WHERE sc.ClientId=c.CLientId AND sc.NationId=nat.NationId 
                                AND sc.Careerid=ca.Careerid AND sc.BuildingId=b.BuildingId")
    End Sub

    Private Sub rdb_bysigncardid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_bysigncardid.CheckedChanged
        txt_bybid.Enabled = True
        txt_bycname.Enabled = False
        txt_bycname.Text = ""
    End Sub

    Private Sub rdb_byBoxSize_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byCname.CheckedChanged
        txt_bybid.Enabled = False
        txt_bycname.Enabled = True
        txt_bybid.Text = ""
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        If rdb_bysigncardid.Checked Then
            FillDGV(dgv_signcard, "SELECT SignCardId AS [ID], SignCardDate AS [DATE],
                                SignCardNote AS [NOTE], ClientFName AS [CLIENT NAME],
                                Nationality, ContId, CareerName AS [CAREER], BuildingName 
                                FROM SignatureCards sc, Clients c,
                                Nationalities nat ,Careers ca ,Buildings b 
                                WHERE sc.ClientId=c.CLientId AND sc.NationId=nat.NationId 
                                AND sc.Careerid=ca.Careerid AND sc.BuildingId=b.BuildingId
                                AND sc.SignCardId=" & txt_bybid.Text)
        Else

        End If
    End Sub

    Private Sub txt_bybid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bybid.KeyPress
        Only_Number(txt_bybid, e)
    End Sub

    Private Sub txt_bycname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bycname.KeyPress
        Only_char(txt_bycname, e)
    End Sub

    Private Sub btn_newbox_Click(sender As Object, e As EventArgs) Handles btn_newbox.Click
        Frm_NewSignatureCard.ShowDialog()
        FillDGV(dgv_signcard, "SELECT SignCardId AS [ID], SignCardDate AS [DATE],
                                SignCardNote AS [NOTE], ClientFName AS [CLIENT NAME],
                                Nationality, ContId, CareerName AS [CAREER], BuildingName 
                                FROM SignatureCards sc, Clients c,
                                Nationalities nat ,Careers ca ,Buildings b 
                                WHERE sc.ClientId=c.CLientId AND sc.NationId=nat.NationId 
                                AND sc.Careerid=ca.Careerid AND sc.BuildingId=b.BuildingId")
    End Sub

    Private Sub dgv_signcard_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_signcard.CellDoubleClick
        If Frm_main.signatureCardId = 0 Then
            Try
                If dgv_signcard.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                Frm_main.signatureCardId = dgv_signcard.SelectedRows(0).Cells(0).Value
                Me.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class