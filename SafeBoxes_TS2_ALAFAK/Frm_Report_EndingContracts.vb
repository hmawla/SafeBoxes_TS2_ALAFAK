Public Class Frm_Report_EndingContracts
    Private Sub Frm_Report_EndingContracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_ending, "SELECT * FROM ContEnd")
    End Sub
End Class