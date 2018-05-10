Public Class Frm_Report_RenewContract
    Private Sub Frm_Report_RenewContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_renew, "SELECT ClientFName + ' ' + ClientLName AS [Client], R.RenewId, RenewDate, RenewToDate, ContId, EmpFName + ' ' + EmpLName AS [Employee] FROM Renew R, Clients C, Employees E, ClientsRenew CR WHERE R.RenewId = CR.RenewId AND CR.ClientId = C.ClientId AND R.EmpId = E.EmpId")
    End Sub
End Class