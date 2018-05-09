Public Class Frm_Contracts
    '==========================================
    'What is still missing:
    'We need to fix the filters in the next tab
    'Should make showdialog Yes/No as "are you sure you want to delete this"
    'Should print selected contract's account owner/s into the read only multiline textbox
    'Check for more awesome ideas :P
    '==========================================

    Public contractId As Integer
    Private Sub Frm_Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
    End Sub

    Private Sub btn_newcontract_Click(sender As Object, e As EventArgs) Handles btn_newcontract.Click
        contractId = 0
        frm_newContract.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
    End Sub

    Private Sub btn_modcontract_Click(sender As Object, e As EventArgs) Handles btn_modcontract.Click
        contractId = dgv_contracts.SelectedRows(0).Cells(0).Value
        frm_newContract.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
    End Sub

    Private Sub btn_delcontract_Click(sender As Object, e As EventArgs) Handles btn_delcontract.Click
        'Should make showdialog Yes/No as "are you sure you want to delete this"
        ExecuteQuery("DELETE FROM Contract WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
    End Sub

    Private Sub dgv_contracts_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_contracts.SelectionChanged
        Try
            If dgv_contracts.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delcontract.Enabled = True
            btn_modcontract.Enabled = True
        Catch ex As Exception
            btn_delcontract.Enabled = False
            btn_modcontract.Enabled = False
        End Try
    End Sub
End Class