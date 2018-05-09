Public Class Frm_Companies
    Private Sub Frm_Companies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompTypeId=ct.CompTypeId")
    End Sub
End Class