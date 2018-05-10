Public Class Frm_Report_Authorizations
    Private Sub Frm_Report_Authorizations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_authorizations, "SELECT * FROM Authorizations")
    End Sub
End Class