Public Class Frm_InfoVoucher
    Public infovouchId As Integer

    Private Sub Frm_InfoVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId")
    End Sub

    Private Sub btn_newinfovouch_Click(sender As Object, e As EventArgs) Handles btn_newinfovouch.Click
        infovouchId = 0
        Frm_NewInfoVoucher.ShowDialog()
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS [ID], InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId, BuildingName, InfoSubjTitle, ClientFName FROM InfoVoucher, Buildings, Clients, InfoSubjectTitles WHERE InfoVoucher.BuildingId=Buildings.BuildingId AND InfoVoucher.InfoSubjTitleId=InfoSubjectTitles.InfoSubjTitleId AND InfoVoucher.ClientId=Clients.ClientId")
    End Sub

    Private Sub btn_modinfovouch_Click(sender As Object, e As EventArgs) Handles btn_modinfovouch.Click
        infovouchId = dgv_infovouchers.SelectedRows(0).Cells(0).Value
        Frm_NewInfoVoucher.ShowDialog()
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS [ID], InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId, BuildingName, InfoSubjTitle, ClientFName FROM InfoVoucher, Buildings, Clients, InfoSubjectTitles WHERE InfoVoucher.BuildingId=Buildings.BuildingId AND InfoVoucher.InfoSubjTitleId=InfoSubjectTitles.InfoSubjTitleId AND InfoVoucher.ClientId=Clients.ClientId")
    End Sub

    Private Sub btn_delinfovouch_Click(sender As Object, e As EventArgs) Handles btn_delinfovouch.Click
        ExecuteQuery("DELETE FROM InfoVoucher WHERE InfoVouchId = " & dgv_infovouchers.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS [ID], InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId, BuildingName, InfoSubjTitle, ClientFName FROM InfoVoucher, Buildings, Clients, InfoSubjectTitles WHERE InfoVoucher.BuildingId=Buildings.BuildingId AND InfoVoucher.InfoSubjTitleId=InfoSubjectTitles.InfoSubjTitleId AND InfoVoucher.ClientId=Clients.ClientId")
    End Sub

    Private Sub dgv_infovouchers_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_infovouchers.SelectionChanged
        Try
            If dgv_infovouchers.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delinfovouch.Enabled = True
            btn_modinfovouch.Enabled = True
        Catch ex As Exception
            btn_delinfovouch.Enabled = False
            btn_modinfovouch.Enabled = False
        End Try
    End Sub
End Class