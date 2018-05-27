Public Class NewBuilding
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBuilding(cbox_regions, cbox_streets, cbox_buildings)
        MessageBox.Show("Added!")
    End Sub
End Class