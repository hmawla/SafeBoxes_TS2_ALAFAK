Public Class Frm_NewClient
    Dim theNewId As Integer
    Private Sub Frm_NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        theNewId = genID("Clients", "ClientId")
        ExecuteQuery("INSERT INTO Clients(ClientId) VALUES(" & theNewId & ")")
        lbl_cid.Text = "ClientId ID: " & theNewId
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If Not Exists(cbox_regions.Text, "SELECT RegionName FROM Regions") Then
            ExecuteQuery("INSERT INTO Regions VALUES(" & genID("Regions", "RegionId") & ", '" & cbox_regions.Text & "')")
        End If
        ExecuteQuery("UPDATE Clients SET ClientFName = " & txt_fname.Text & ", ClientLName = " & txt_lname.Text & ", ClientMName = " & txt_father.Text & ", ClientMother = " & txt_mother.Text & ", ClientDOB = '" & dtpick_birth.Value & "'. ClientRegisterNbr = " & txt_rnumber.Text & ", ClientPostNbr = " & txt_pbnumber.Text & ", RegionId = " & cbox_regions.SelectedValue & " WHERE ClientId = " & theNewId)
        Me.Close()
    End Sub
End Class