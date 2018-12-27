Public Class frm_Info_Result
    Public theInfo As Integer
    Private Sub frm_Info_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_inforesults, "SELECT * FROM InfoResult")
    End Sub

    Private Sub dgv_inforesults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_inforesults.CellDoubleClick
        If dgv_inforesults.Rows.Count > 0 Then
            theInfo = dgv_inforesults.SelectedRows(0).Cells(0).Value
            Frm_Report_InfoResult.ShowDialog()
        Else
            MessageBox.Show("Please select an item!")
        End If
    End Sub
End Class