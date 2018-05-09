Public Class Frm_Clients
    Private Sub Frm_Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_clients, "SELECT ClientId AS [ID], ClientFName AS [First Name], ClientMName AS [Father Name], ClientLName AS [Last Name], ClientDOB AS [Date Of Birth], ClientMother AS [Mother Name], ClientRegisterNbr, PostBoxNbr,RegionName  FROM Clients c,Regions r WHERE c.RegionId=r.RegionId")
    End Sub
End Class