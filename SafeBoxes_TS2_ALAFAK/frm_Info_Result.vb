Public Class frm_Info_Result
    Private Sub frm_Info_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_inforesult, "SELECT * FROM InfoResult")
    End Sub
End Class