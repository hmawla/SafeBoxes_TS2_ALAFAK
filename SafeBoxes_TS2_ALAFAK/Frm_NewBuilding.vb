Public Class Frm_NewBuilding
    Dim formLoaded As Boolean = False
    Private Sub Frm_NewBuilding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        formLoaded = True
    End Sub

    Private Sub cbox_regions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_regions.SelectedIndexChanged
        If formLoaded Then
            FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim i As Integer
        Dim theStreet As String = cbox_streets.Text
        For i = 1 To 3
            If Exists(cbox_regions.Text, "SELECT RegionName FROM Regions") Then
                If Exists(cbox_streets.Text, "SELECT StreetName FROM Streets WHERE StreetId = " & cbox_streets.SelectedValue & " AND RegionId = " & cbox_regions.SelectedValue) Then
                    If Exists(txt_building.Text, "SELECT BuildingName FROM Buildings b, Streets s WHERE b.StreetId = " & cbox_streets.SelectedValue & " AND RegionId = " & cbox_regions.SelectedValue) Then
                        MsgBox("Building already exists in the current street!")
                        GoTo End_Of_For
                    Else
                        MsgBox("Inserting Building")
                        ExecuteQuery("INSERT INTO Buildings VALUES(" & genID("Buildings", "BuildingId") & ", '" & txt_building.Text & "', " & cbox_streets.SelectedValue & ")")
                        Me.Close()
                        GoTo End_Of_For
                    End If
                Else
                    MsgBox("Inserting Street " & genID("Streets", "StreetId") & " Region " & cbox_regions.SelectedValue)
                    ExecuteQuery("INSERT INTO Streets VALUES(" & genID("Streets", "StreetId") & ", '" & theStreet & "', " & cbox_regions.SelectedValue & ")")
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                    cbox_streets.SelectedIndex = cbox_streets.Items.Count - 1
                End If
            Else
                MsgBox("Inserting Region")
                ExecuteQuery("INSERT INTO Regions VALUES(" & genID("Regions", "RegionId") & ", '" & cbox_regions.Text & "')")
                FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                cbox_regions.SelectedIndex = cbox_regions.Items.Count - 1
            End If


        Next
End_Of_For:


    End Sub
End Class