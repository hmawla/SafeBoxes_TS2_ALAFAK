Public Class Frm_SignatureCards
    Private Sub Frm_SignatureCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_signcard, "SELECT SignCardId AS [ID], SignCardDate AS [DATE],
                                SignCardNote AS [NOTE], ClientFName AS [CLIENT NAME],
                                Nationality, ContId, CareerName AS [CAREER], BuildingName 
                                FROM SignatureCards sc, Clients c,
                                Nationalities nat ,Careers ca ,Buildings b 
                                WHERE sc.ClientId=c.CLientId AND sc.NationId=nat.NationId 
                                AND sc.Careerid=ca.Careerid AND sc.BuildingId=b.BuildingId")
    End Sub
End Class