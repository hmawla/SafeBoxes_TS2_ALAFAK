Public Class NewBuilding
    Dim formLoaded As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBuilding(cbox_regions, cbox_streets, cbox_buildings)
        MessageBox.Show("Added!")
    End Sub

    Private Sub NewBuilding_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        formLoaded = True
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
End Class