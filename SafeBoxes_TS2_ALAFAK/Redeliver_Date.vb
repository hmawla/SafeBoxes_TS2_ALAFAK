Public Class Redeliver_Date
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Frm_Contracts.redeliverDate = dtpick_redeliverdate.Value
        Me.Dispose()
    End Sub
End Class