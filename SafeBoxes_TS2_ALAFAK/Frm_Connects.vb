Public Class Frm_Connects
    Dim infoVouchid As Integer
    Dim EmpId As Integer
    Dim ds As New DataSet
    Private Sub Frm_Connects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoVouchid = Frm_main.infovouchid
        EmpId = Frm_main.loggedEmpId
        Lbl_infovId.Text = "InfoVoucher ID: " & infoVouchid
        Lbl_EmpId.Text = "Employee ID: " & EmpId
    End Sub

    Private Sub Txt_ClientId_TextChanged(sender As Object, e As EventArgs) Handles Txt_ClientId.TextChanged
        Try
            ds = ReadQueryOut("SELECT ClientId, ClientFName + ' ' + ClientLName, ClientDOB FROM Clients WHERE ClientId = " & Txt_ClientId.Text)
            Txt_ClientName.Text = ds.Tables(0).Rows(0).Item(1)
        Catch ex As Exception
            Txt_ClientName.Text = ""
        End Try
    End Sub
    Private Sub DGV_Visits_SelectionChanged(sender As Object, e As EventArgs)
        If DGV_Connects.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub
    Private Sub Txt_ClientId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ClientId.KeyPress
        Only_Number(Txt_ClientId, e)
    End Sub
    Private Sub DGV_Visits_SelectionChanged_1(sender As Object, e As EventArgs) Handles DGV_Connects.SelectionChanged
        If DGV_Connects.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub
End Class