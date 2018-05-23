Public Class Frm_InfoVoucher
    Public infovouchId As Integer

    Private Sub Frm_InfoVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId")
    End Sub

    Private Sub btn_newinfovouch_Click(sender As Object, e As EventArgs)
        infovouchId = 0
        Frm_NewInfoVoucher.ShowDialog()
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS [ID], InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId, BuildingName, InfoSubjTitle, ClientFName FROM InfoVoucher, Buildings, Clients, InfoSubjectTitles WHERE InfoVoucher.BuildingId=Buildings.BuildingId AND InfoVoucher.InfoSubjTitleId=InfoSubjectTitles.InfoSubjTitleId AND InfoVoucher.ClientId=Clients.ClientId")
    End Sub

    Private Sub btn_modinfovouch_Click(sender As Object, e As EventArgs)
        infovouchId = dgv_infovouchers.SelectedRows(0).Cells(0).Value
        Frm_NewInfoVoucher.ShowDialog()
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS [ID], InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId, BuildingName, InfoSubjTitle, ClientFName FROM InfoVoucher, Buildings, Clients, InfoSubjectTitles WHERE InfoVoucher.BuildingId=Buildings.BuildingId AND InfoVoucher.InfoSubjTitleId=InfoSubjectTitles.InfoSubjTitleId AND InfoVoucher.ClientId=Clients.ClientId")
    End Sub

    Private Sub btn_delinfovouch_Click(sender As Object, e As EventArgs)
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

    Private Sub rdb_byinfovouchid_CheckedChanged(sender As Object, e As EventArgs)
        txt_byInfovouchid.Enabled = True
        txt_byClientName.Enabled = False
        txt_byClientName.Text = ""
    End Sub

    Private Sub rdb_byClientName_CheckedChanged(sender As Object, e As EventArgs)
        txt_byInfovouchid.Enabled = False
        txt_byClientName.Enabled = True
        txt_byInfovouchid.Text = ""
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs)
        btn_reset.Enabled = True
        If rdb_byinfovouchid.Checked Then
            FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.InfoVouchId=" & txt_byInfovouchid.Text & " AND i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId")
        Else
            Dim firstName As String
            Dim lastName As String = ""
            firstName = txt_byClientName.Text.Split(New Char() {" "c})(0)
            Try
                lastName = txt_byClientName.Text.Split(New Char() {" "c})(1)
            Catch ex As Exception

            End Try
            Dim theQuery As String = "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId AND ClientFName LIKE '%" & firstName & "%'"
            If lastName <> "" Then
                theQuery = "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId AND ClientFName LIKE '%" & firstName & "%' AND ClientLName LIKE '%" & lastName & "%'"
            End If
            FillDGV(dgv_infovouchers, theQuery)
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs)
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId")
        btn_reset.Enabled = False
        txt_byInfovouchid.Text = ""
        txt_byClientName.Text = ""
    End Sub

    Private Sub txt_byInfovouchid_KeyPress(sender As Object, e As KeyPressEventArgs)
        Only_Number(txt_byInfovouchid, e)
    End Sub

    Private Sub txt_byClientName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Only_char(txt_byClientName, e)
    End Sub

    Private Sub btn_connects_Click(sender As Object, e As EventArgs)
        Frm_main.infovouchid = dgv_infovouchers.SelectedRows(0).Cells(0).Value
        Frm_NewConnects.ShowDialog()
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId")
    End Sub

End Class