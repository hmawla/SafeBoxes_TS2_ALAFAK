Public Class Frm_InfoVoucher
    Private Sub Frm_InfoVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_infovouchers, "SELECT InfoVouchId AS ID, InfoVouchFromTime AS [From Time], InfoVouchToTime AS [To Time], InfoVouchDate AS [Date], SubjectDetails, ContId AS [Contract ID], BuildingName AS Address, InfoSubjTitle, ClientFName AS [Client Name] FROM InfoVoucher i,Clients c, Buildings b,InfoSubjectTitles ist WHERE i.BuildingId = b.BuildingId AND i.ClientId = c.ClientId AND i.InfoSubjTitleId=ist.InfoSubjTitleId")
    End Sub
End Class