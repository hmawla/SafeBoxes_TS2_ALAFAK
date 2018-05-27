Public Class Frm_Contracts
    '==========================================
    '        What is still missing:
    '==========================================
    '   You tell me :P
    '==========================================
    Public redeliverDate As Date
    Public contractId As Integer
    Public boxId As Integer

    Private Sub Frm_Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
        Me.MinimumSize = New Size(693, 591)
    End Sub

    Private Sub btn_newcontract_Click(sender As Object, e As EventArgs) Handles btn_newcontract.Click
        contractId = 0
        Frm_newContract.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
    End Sub

    Private Sub btn_modcontract_Click(sender As Object, e As EventArgs) Handles btn_modcontract.Click
        contractId = dgv_contracts.SelectedRows(0).Cells(0).Value
        boxId = dgv_contracts.SelectedRows(0).Cells(5).Value
        Frm_newContract.ShowDialog()
        boxId = 0
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
    End Sub

    Private Sub btn_delcontract_Click(sender As Object, e As EventArgs) Handles btn_delcontract.Click
        InputBox.Show("Enter admin password:", "Delete Contract#" & dgv_contracts.SelectedRows(0).Cells(0).Value, True)
        If Not inResult.Equals("0") Then
            If inResult = adminPass Then
                ExecuteQuery("DELETE FROM Contract WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM SignatureCards WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM Permissions WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM ContEnd WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM Visits WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM MissingKeys WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM InfoVoucher WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM Authorizations WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM Renew WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                ExecuteQuery("DELETE FROM FATCA WHERE ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value)
                FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
            Else
                MessageBox.Show("Wrong password!")
            End If
        End If
    End Sub

    Private Sub dgv_contracts_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_contracts.SelectionChanged
        Try
            If dgv_contracts.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delcontract.Enabled = True
            btn_modcontract.Enabled = True
            btn_renew.Enabled = True
            btn_end.Enabled = True
            btn_withdraw.Enabled = True
            btn_authorize.Enabled = True
            btn_addmissingkeys.Enabled = True
        Catch ex As Exception
            btn_delcontract.Enabled = False
            btn_modcontract.Enabled = False
            btn_renew.Enabled = False
            btn_end.Enabled = False
            btn_withdraw.Enabled = False
            btn_authorize.Enabled = False
            btn_addmissingkeys.Enabled = False
        End Try
    End Sub

    Private Sub btn_addmissingkeys_Click(sender As Object, e As EventArgs) Handles btn_addmissingkeys.Click
        If Not Exists(dgv_contracts.SelectedRows(0).Cells(0).Value, "SELECT ContId FROM MissingKeys WHERE RedeliverDate IS NULL AND ContId = " & dgv_contracts.SelectedRows(0).Cells(0).Value) Then
            MessageBox.Show("Are you sure you want to submit missing keys to contract #" & dgv_contracts.SelectedRows(0).Cells(0).Value, "Submit Missing Keys", MessageBoxButtons.YesNo)
            If mesResult = DialogResult.Yes Then
                Dim theNewId As Integer = GenID("MissingKeys", "MissKeyId")
                ExecuteQuery("INSERT INTO MissingKeys(MissKeyId, MissKeyDate, ContId) VALUES(" & theNewId & ", date(), " & dgv_contracts.SelectedRows(0).Cells(0).Value & ")")
            End If
        Else
            MessageBox.Show("Contract already has pending missing key in progress!")
        End If

    End Sub

    Private Sub btn_showmissingkeys_Click(sender As Object, e As EventArgs) Handles btn_showmissingkeys.Click
        If Not btn_showmissingkeys.Text.Equals("Reset") Then
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId IN (SELECT ContId FROM MissingKeys WHERE RedeliverDate IS NULL) AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
            btn_showmissingkeys.Text = "Reset"
            Try
                If dgv_contracts.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                btn_keydelivered.Enabled = True
            Catch ex As Exception

            End Try

        Else
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
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

    Private Sub MissingKeysReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MissingKeysReport.Click
        Frm_Report_MissingKeys.ShowDialog()
    End Sub

    Private Sub RenewReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenewReport.Click
        Frm_Report_RenewContract.ShowDialog()
    End Sub

    Private Sub btn_renew_Click(sender As Object, e As EventArgs) Handles btn_renew.Click
        Frm_main.contractid = dgv_contracts.SelectedRows(0).Cells(0).Value
        Frm_RenewContract.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        MessageBox.Show("Are you sure you want to end contract #" & dgv_contracts.SelectedRows(0).Cells(0).Value, "End Contract", MessageBoxButtons.YesNo)
        If mesResult = DialogResult.Yes Then
            Dim theNewId As Integer = GenID("ContEnd", "ContEndId")
            ExecuteQuery("INSERT INTO ContEnd VALUES(" & theNewId & ", date(), " & dgv_contracts.SelectedRows(0).Cells(0).Value & ")")
            Dim mesBox = New MessageBox
            mesBox.Show("Contract #" & dgv_contracts.SelectedRows(0).Cells(0).Value & " is now ended and cannot be reused!")
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
        End If

    End Sub

    Private Sub rdb_byboxid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byboxid.CheckedChanged
        txt_byboxid.Enabled = True

        txt_bycontid.Enabled = False
        txt_bycontid.Text = ""
        txt_byboxid.Focus()
    End Sub

    Private Sub rdb_bycontid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_bycontid.CheckedChanged
        txt_byboxid.Enabled = False
        txt_bycontid.Enabled = True
        txt_byboxid.Text = ""
        txt_bycontid.Focus()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
        btn_reset.Enabled = False
        txt_byboxid.Text = ""
        txt_bycontid.Text = ""
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        If rdb_byboxid.Checked Then
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date() AND BoxId=" & txt_byboxid.Text)
        Else
            FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date() AND ContId=" & txt_bycontid.Text)

        End If
    End Sub

    Private Sub txt_byboxid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byboxid.KeyPress
        Only_Number(txt_byboxid, e)
    End Sub

    Private Sub txt_bycontid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bycontid.KeyPress
        Only_Number(txt_bycontid, e)
    End Sub

    Private Sub btn_visits_Click(sender As Object, e As EventArgs) Handles btn_visits.Click
        Frm_main.contractid = dgv_contracts.SelectedRows(0).Cells(0).Value
        Frm_ContractVisits.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
    End Sub

    Private Sub ContractsEndReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractEndingReport.Click
        Frm_Report_EndingContracts.ShowDialog()
    End Sub

    Private Sub WithdrawPermissionsReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawReport.Click
        Frm_Report_WithdrawPermission.ShowDialog()
    End Sub

    Private Sub ClientAuthorizationsReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorizationReport.Click
        Frm_Report_Authorizations.ShowDialog()
    End Sub

    Private Sub VisitsReport_Click(sender As Object, e As EventArgs) Handles VisitsReport.Click
        Frm_Report_Visits.ShowDialog()
    End Sub

    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        MessageBox.Show("Are you sure you want to grant permission to withdraw rental fees for Contract #" & dgv_contracts.SelectedRows(0).Cells(0).Value & " from Account#" & dgv_contracts.SelectedRows(0).Cells(6).Value, "Withdraw Permission", MessageBoxButtons.YesNo)
        If mesResult = DialogResult.Yes Then
            Dim theNewId As Integer = GenID("Permissions", "PermId")
            ExecuteQuery("INSERT INTO Permissions VALUES(" & theNewId & ", date(), " & dgv_contracts.SelectedRows(0).Cells(0).Value & ")")
        End If
    End Sub


    Private Sub SelectBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Frm_main.boxId = 0
        Frm_Boxes.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date() AND Contract.BoxId=" & Frm_main.boxId)

    End Sub

    Private Sub ClientAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Frm_main.accountid = 0
        Frm_Accounts.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date() AND Contract.AccountId=" & Frm_main.accountid)

    End Sub
    Private Sub btn_authorize_Click(sender As Object, e As EventArgs) Handles btn_authorize.Click
        contractId = dgv_contracts.SelectedRows(0).Cells(0).Value
        Frm_Authorize.ShowDialog()
        FillDGV(dgv_contracts, "SELECT ContId AS ID, ContBDate AS [Contract Date], ContToDate AS [Expire Date], ContPhone1 AS [Phone1], ContPhone2 AS [Phone2], BoxId AS [Box ID], AccountId AS [Account ID], BuildingName AS Address, EmpFName + ' ' + EmpLName AS Employee FROM Contract, Buildings, Employees WHERE Contract.BuildingId = Buildings.BuildingId AND Contract.EmpId = Employees.EmpId AND ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()")
    End Sub

    Private Sub ContractReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractReportToolStripMenuItem.Click
        Frm_Report_Contract.ShowDialog()
    End Sub
End Class