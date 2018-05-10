Public Class Frm_Report_WithdrawPermission
    Private Sub Frm_Report_WithdrawPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_withdraw, "SELECT * FROM Permissions")
    End Sub
End Class