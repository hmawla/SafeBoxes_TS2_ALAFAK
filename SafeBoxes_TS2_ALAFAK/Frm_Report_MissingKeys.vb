Public Class Frm_Report_MissingKeys
    Private Sub Frm_Report_MissingKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_missingkeys, "SELECT * FROM MissingKeys")
    End Sub
End Class