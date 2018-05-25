Public Class Frm_Authorize
    Dim formLoaded As Boolean = False
    Private Sub Frm_Authorize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        FillCBox(CBox_AuthRights, "SELECT RightId, RightDesc FROM AuthRight", "RightId", "RightDesc")
        Txt_ClientId.Focus()
        formLoaded = True
    End Sub

    Private Sub Btn_AddRight_Click(sender As Object, e As EventArgs) Handles Btn_AddRight.Click
        For i As Integer = 0 To DGV_Rights.Rows.Count - 1
            If CBox_AuthRights.SelectedValue = DGV_Rights.Rows(i).Cells(0).Value Then
                MessageBox.Show("Right Already Added!")
                GoTo theEnd
            End If
        Next
        DGV_Rights.Rows.Add(AddRight(CBox_AuthRights), CBox_AuthRights.Text)
        FillCBox(CBox_AuthRights, "SELECT RightId, RightDesc FROM AuthRight", "RightId", "RightDesc")
theEnd:


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

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        If DGV_Rights.Rows.Count > 0 Then
            DGV_Rights.Rows.RemoveAt(DGV_Rights.SelectedRows(0).Index)
        Else
            MessageBox.Show("Please select a row!")
        End If
    End Sub

    Private Sub ModifyRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyRightToolStripMenuItem.Click
        If CBox_AuthRights.SelectedValue > 0 Then
            InputBox.Show("Modify right's Description:", "Modify right#" & CBox_AuthRights.SelectedValue)
            If inResult.Count > 0 Then
                ExecuteQuery("UPDATE AuthRight SET RightDesc = '" & inResult & "' WHERE RightId = " & CBox_AuthRights.SelectedValue)
                For i As Integer = 0 To DGV_Rights.Rows.Count - 1
                    If CBox_AuthRights.SelectedValue = DGV_Rights.Rows(i).Cells(0).Value Then
                        DGV_Rights.Rows(i).Cells(1).Value = inResult
                    End If
                Next
                FillCBox(CBox_AuthRights, "SELECT RightId, RightDesc FROM AuthRight", "RightId", "RightDesc")
            Else
                MessageBox.Show("Invalid description!")
            End If

        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRightToolStripMenuItem.Click
        If CBox_AuthRights.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!", "Delete right#" & CBox_AuthRights.SelectedValue, True)
            If inResult = "12345" Then
                ExecuteQuery("DELETE FROM AuthRight WHERE RightId = " & CBox_AuthRights.SelectedValue)
                For i As Integer = 0 To DGV_Rights.Rows.Count - 1
                    If CBox_AuthRights.SelectedValue = DGV_Rights.Rows(i).Cells(0).Value Then
                        DGV_Rights.Rows.RemoveAt(DGV_Rights.Rows(i).Index)
                        GoTo theEnd
                    End If
                Next
theEnd:
                FillCBox(CBox_AuthRights, "SELECT RightId, RightDesc FROM AuthRight", "RightId", "RightDesc")
            End If
        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If Txt_ClientName.Text.Count > 0 Then
            If DGV_Rights.Rows.Count > 0 Then
                If cbox_regions.Text.Count > 0 And cbox_streets.Text.Count > 0 And cbox_buildings.Text.Count > 0 Then
                    Dim theNewId As Integer = GenID("Authorizations", "Authid")
                    ExecuteQuery("INSERT INTO Authorizations VALUES(" & theNewId & ", date(), " & Frm_Contracts.contractId & ")")
                    For Each row As DataGridViewRow In DGV_Rights.Rows
                        ExecuteQuery("INSERT INTO AuthorizationAuthRight VALUES(" & theNewId & ", " & row.Cells(0).Value & ")")
                    Next
                    Me.Dispose()
                Else
                    MessageBox.Show("Invalid address!")
                End If
            Else
                MessageBox.Show("Please choose at least one right!")
            End If
        Else
            MessageBox.Show("Please enter a valid client!")
        End If
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

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click
        Frm_main.clientid = 0
        Frm_Clients.ShowDialog()
        Txt_ClientId.Text = Frm_main.clientid
    End Sub

    Private Sub Txt_ClientId_TextChanged(sender As Object, e As EventArgs) Handles Txt_ClientId.TextChanged
        Try
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName From Clients WHERE ClientId = " & Txt_ClientId.Text)
            Txt_ClientName.Text = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Txt_ClientName.Text = ""
        End Try
    End Sub
End Class