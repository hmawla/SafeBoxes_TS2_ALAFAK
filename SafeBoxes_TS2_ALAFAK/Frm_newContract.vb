Imports System.ComponentModel
Imports System.Data

Public Class Frm_newContract
    Dim EmpId As Integer
    Dim formLoaded As Boolean = False
    Dim ds As DataSet
    Dim theNewId As Integer

    Private Sub SelectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAccountToolStripMenuItem.Click
        Frm_main.accountid = 0
        Frm_Accounts.ShowDialog()
        txt_accountid.Text = Frm_main.accountid
    End Sub


    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If Exists(txt_accountid.Text, "SELECT AccountId FROM (SELECT AccountId FROM ClientDepAccount UNION SELECT AccountId FROM ClientRepAccount UNION SELECT AccountId FROM CompanyAccounts)") Then
            If Exists(txt_boxes.Text, "SELECT BoxId FROM Boxes WHERE BoxId NOT IN (SELECT BoxId FROM Contract WHERE ContId NOT IN (SELECT ContId FROM ContEnd))") Or txt_boxes.Text.Equals(Frm_Contracts.boxId.ToString) Then
                If dtpick_exdate.Value > DateAndTime.Today Then
                    If cbox_regions.Text.Count > 0 And cbox_streets.Text.Count > 0 And cbox_buildings.Text.Count > 0 Then
                        If txt_accountid.Text.Count > 0 And txt_boxes.Text.Count > 0 And txt_phone1.Text.Count > 0 And txt_phone2.Text.Count > 0 Then
                            If Frm_Contracts.contractId = 0 Then
                                theNewId = GenID("Contract", "ContId")
                                If txt_contnote.TextLength > 0 Then
                                    ExecuteQuery("INSERT INTO Contract VALUES(" & theNewId & ", date(), '" & dtpick_exdate.Value.ToShortDateString & "', '" & txt_contnote.Text & "', " & txt_floor.Value & ", '" & txt_phone1.Text & "', '" & txt_phone2.Text & "', " & EmpId & ", " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", " & txt_accountid.Text & ", " & txt_boxes.Text & ")")
                                Else
                                    ExecuteQuery("INSERT INTO Contract VALUES(" & theNewId & ", date(), '" & dtpick_exdate.Value.ToShortDateString & "', '', " & txt_floor.Value & ", '" & txt_phone1.Text & "', '" & txt_phone2.Text & "', " & EmpId & ", " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", " & txt_accountid.Text & ", " & txt_boxes.Text & ")")
                                End If
                            Else
                                If txt_contnote.TextLength > 0 Then
                                    ExecuteQuery("UPDATE Contract SET AccountId = " & txt_accountid.Text & ", BoxId = " & txt_boxes.Text & ", BuildingId = " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", EmpId = " & EmpId & ", ContFloor = " & txt_floor.Value & ", ContBDate = '" & Date.Today.ToShortDateString & "', ContToDate = '" & dtpick_exdate.Value.ToShortDateString & "', ContPhone1 = '" & txt_phone1.Text & "', ContPhone2 = '" & txt_phone2.Text & "', ContNote = '" & txt_contnote.Text & "' WHERE ContId = " & theNewId)
                                    Frm_main.contractid = theNewId
                                Else
                                    ExecuteQuery("UPDATE Contract SET AccountId = " & txt_accountid.Text & ", BoxId = " & txt_boxes.Text & ", BuildingId = " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", EmpId = " & EmpId & ", ContFloor = " & txt_floor.Value & ", ContBDate = '" & Date.Today.ToShortDateString & "', ContToDate = '" & dtpick_exdate.Value.ToShortDateString & "', ContPhone1 = '" & txt_phone1.Text & "', ContPhone2 = '" & txt_phone2.Text & "' WHERE ContId = " & theNewId)
                                    Frm_main.contractid = theNewId
                                End If
                            End If
                            Me.Dispose()
                        Else
                            MessageBox.Show("Please fill all needed information!")
                        End If
                    Else
                        MessageBox.Show("Invalid address!")
                    End If
                    MessageBox.Show("Invalid date!")
                End If
            Else
                MessageBox.Show("Invalid box ID!")
            End If
        Else
            MessageBox.Show("Invalid account ID!")
        End If
    End Sub

    Private Sub Frm_newContract_Load(sender As Object, e As EventArgs) Handles Me.Load

        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")

        If Frm_Contracts.contractId = 0 Then
            EmpId = Frm_main.loggedEmpId
            dtpick_exdate.Value = DateTime.Now.AddYears(1)
        Else
            theNewId = Frm_Contracts.contractId
            Dim theContDetails As New DataSet
            theContDetails = ReadQueryOut("SELECT * FROM Contract WHERE ContId = " & theNewId).Copy
            Dim rows As DataRow = theContDetails.Tables(0).Rows(0)
            dtpick_exdate.Value = rows.Item(2)
            dtpick_exdate.Enabled = False
            txt_contnote.Text = rows.Item(3)
            txt_floor.Value = rows.Item(4)
            txt_phone1.Text = rows.Item(5)
            txt_phone2.Text = rows.Item(6)
            EmpId = rows.Item(7)
            txt_accountid.Text = rows.Item(9)
            txt_boxes.Text = rows.Item(10)
            Dim theBuilding As String = rows.Item(8)
            theContDetails.Reset()
            theContDetails = ReadQueryOut("SELECT BuildingId, Streets.StreetId, RegionId FROM Buildings, Streets WHERE BuildingId = " & theBuilding)
            rows = theContDetails.Tables(0).Rows(0)
            cbox_regions.SelectedValue = rows.Item(2)
            cbox_streets.SelectedValue = rows.Item(1)
            cbox_buildings.SelectedValue = rows.Item(0)
        End If
        lbl_empid.Text = "Employee ID: " & EmpId
        formLoaded = True
    End Sub

    Private Sub SelectBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectBoxToolStripMenuItem.Click
        Frm_main.boxId = 0
        Frm_Boxes.ShowDialog()
        txt_boxes.Text = Frm_main.boxId
    End Sub

    Private Sub CBox_regions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_regions.SelectedIndexChanged
        If formLoaded Then
            FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        End If
    End Sub

    Private Sub CBox_streets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_streets.SelectedIndexChanged
        If formLoaded Then
            FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        End If
    End Sub

    Private Sub Txt_accountid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_accountid.KeyPress
        Only_Number(txt_accountid, e)
    End Sub

    Private Sub Txt_boxes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_boxes.KeyPress
        Only_Number(txt_boxes, e)
    End Sub

    Private Sub SelectDifferentEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectDifferentEmployeeToolStripMenuItem.Click
        Frm_main.employeeid = 0
        Frm_Employees.ShowDialog()
        EmpId = Frm_main.employeeid
        lbl_empid.Text = "Employee ID: " & EmpId
    End Sub

    Private Sub txt_phone2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone2.KeyPress
        Only_Number(txt_phone2, e)
    End Sub

    Private Sub txt_phone1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone1.KeyPress
        Only_Number(txt_phone1, e)
    End Sub

    Private Sub cbox_regions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_regions.KeyPress
        Only_char(cbox_regions, e)
    End Sub

    Private Sub cbox_streets_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_streets.KeyPress
        Only_char(cbox_streets, e)
    End Sub

    Private Sub cbox_buildings_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_buildings.KeyPress
        Only_char(cbox_buildings, e)
    End Sub

    Private Sub ModifySelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifySelectedToolStripMenuItem.Click
        If cbox_buildings.SelectedValue > 0 Then
            InputBox.Show("Modify building's Name:", "Modify building#" & cbox_buildings.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE Buildings SET BuildingName = '" & inResult & "' WHERE BuildingId = " & cbox_buildings.SelectedValue)
                    FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteBuildingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBuildingToolStripMenuItem.Click
        If cbox_buildings.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!", "Delete building#" & cbox_buildings.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM Buildings WHERE BuildingId = " & cbox_buildings.SelectedValue)
                    FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
                Else
                    MessageBox.Show("Invalid password!")
                End If
            End If


        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub ModifyRegionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyRegionToolStripMenuItem.Click
        If cbox_regions.SelectedValue > 0 Then
            InputBox.Show("Modify region's Name:", "Modify region#" & cbox_regions.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE Regions SET RegionName = '" & inResult & "' WHERE RegionId = " & cbox_regions.SelectedValue)
                    FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteRegionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRegionToolStripMenuItem.Click
        If cbox_regions.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!" & vbNewLine & "All buildings and streets belonging to this region will be deleted!", "Delete region#" & cbox_regions.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM Regions WHERE RegionId = " & cbox_regions.SelectedValue)
                    ExecuteQuery("DELETE FROM Buildings WHERE StreetId IN (SELECT StreetId FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue & ")")
                    ExecuteQuery("DELETE FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue)
                    FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                Else
                    MessageBox.Show("Invalid password!")
                End If
            End If
        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub ModifyStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyStreetToolStripMenuItem.Click
        If cbox_streets.SelectedValue > 0 Then
            InputBox.Show("Modify street's Name:", "Modify street#" & cbox_streets.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE Streets SET StreetName = '" & inResult & "' WHERE StreetId = " & cbox_streets.SelectedValue)
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStreetToolStripMenuItem.Click
        If cbox_streets.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!" & vbNewLine & "All buildings belonging to this street will be deleted!", "Delete street#" & cbox_streets.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM Buildings WHERE StreetId  = " & cbox_streets.SelectedValue)
                    ExecuteQuery("DELETE FROM Streets WHERE StreetId = " & cbox_streets.SelectedValue)
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                End If
            End If
        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub Frm_newContract_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class