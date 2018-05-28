Public Class Frm_Signatures
    Private Sub Brn_NewSignature_Click(sender As Object, e As EventArgs) Handles Brn_NewSignature.Click
        Frm_main.signatureId = 0
        Frm_newSignature.ShowDialog()
    End Sub

    Private Sub Frm_Signatures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(Dgv_Signatures, "SELECT SignId, SignType, SignDate, ClientFName + ' ' + ClientLName, SignCardId FROM Signatures s, Clients c WHERE s.ClientId = c.ClientId")
    End Sub
End Class