﻿Public Class Frm_Contracts
    '==========================================
    '        What is still missing:
    '==========================================
    'We need to fix the filters in the next tab
    'Should make showdialog Yes/No as "are you sure you want to delete this" (DONE)
    'Should print selected contract's account owner/s into the read only multiline textbox
    'Check for more awesome ideas :P
    '==========================================
    Public redeliverDate As Date

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
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete contract #" & dgv_contracts.SelectedRows(0).Cells(0).Value, "Delete Contract", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ExecuteQuery("DELETE FROM Contract WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
        End If

    End Sub

    Private Sub dgv_contracts_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_contracts.SelectionChanged
        Try
            If dgv_contracts.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delcontract.Enabled = True
            btn_modcontract.Enabled = True
            btn_addmissingkeys.Enabled = True
        Catch ex As Exception
            btn_delcontract.Enabled = False
            btn_modcontract.Enabled = False
            btn_addmissingkeys.Enabled = False
        End Try
    End Sub

    Private Sub btn_addmissingkeys_Click(sender As Object, e As EventArgs) Handles btn_addmissingkeys.Click
        If Not Exists(dgv_contracts.SelectedRows(0).Cells(0).Value, "SELECT ContId FROM MissingKeys WHERE RedeliverDate IS NULL AND ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to submit missing keys to contract #" & dgv_contracts.SelectedRows(0).Cells(0).Value, "Submit Missing Keys", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim theNewId As Integer = genID("MissingKeys", "MissKeyId")
                ExecuteQuery("INSERT INTO MissingKeys(MissKeyId, MissKeyDate, ContId) VALUES(" & theNewId & ", date(), " & dgv_contracts.SelectedRows(0).Cells(0).Value & ")")
            End If
        Else
            MessageBox.Show("Contract already has pending missing key in progress!")
        End If

    End Sub

    Private Sub btn_showmissingkeys_Click(sender As Object, e As EventArgs) Handles btn_showmissingkeys.Click
        If Not btn_showmissingkeys.Text.Equals("Reset") Then
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId IN (SELECT ContId FROM MissingKeys WHERE RedeliverDate IS NULL)")
            btn_showmissingkeys.Text = "Reset"
            btn_keydelivered.Enabled = True
        Else
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId")
            btn_showmissingkeys.Text = "ShowMissing"
            btn_keydelivered.Enabled = False
        End If

    End Sub

    Private Sub btn_keydelivered_Click(sender As Object, e As EventArgs) Handles btn_keydelivered.Click
        Redeliver_Date.ShowDialog()
        Try
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT MissKeyDate FROM MissingKeys WHERE RedeliverDate IS NULL AND ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
            If redeliverDate > ds.Tables(0).Rows(0).Item(0) Then
                ExecuteQuery("UPDATE MissingKeys SET RedeliverDate = '" & redeliverDate.ToShortDateString & "' WHERE RedeliverDate IS NULL AND ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
            Else
                MessageBox.Show("Date should not be before missing key's submittance date!")
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Date!")
        End Try

    End Sub

    Private Sub dgv_contracts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contracts.CellDoubleClick
        If Frm_main.contractid = 0 Then
            Try
                If dgv_contracts.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                Frm_main.contractid = dgv_contracts.SelectedRows(0).Cells(0).Value
                Me.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class