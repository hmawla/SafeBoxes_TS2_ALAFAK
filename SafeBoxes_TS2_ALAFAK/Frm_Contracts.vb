Public Class Frm_Contracts
    Public contractId As Integer
    Private Sub Frm_Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
    End Sub

    Private Sub btn_newcontract_Click(sender As Object, e As EventArgs) Handles btn_newcontract.Click
        contractId = 0
        frm_newContract.ShowDialog()
    End Sub

    Private Sub btn_modcontract_Click(sender As Object, e As EventArgs) Handles btn_modcontract.Click
        contractId = dgv_contracts.SelectedRows(0).Cells(0).Value
        frm_newContract.ShowDialog()
    End Sub

    Private Sub btn_delcontract_Click(sender As Object, e As EventArgs) Handles btn_delcontract.Click
        'Should delete selected record
        'ExecuteQuery("")
    End Sub
End Class