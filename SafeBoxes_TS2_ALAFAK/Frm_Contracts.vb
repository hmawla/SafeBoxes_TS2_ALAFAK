Public Class Frm_Contracts
    Private Sub Frm_Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
    End Sub
End Class