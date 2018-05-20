Public Class Redeliver_Date
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Frm_Contracts.redeliverDate = dtpick_redeliverdate.Value
        Me.Dispose()
        dtpick_redeliverdate.Value = Date.Now
    End Sub

    Private Sub dtpick_redeliverdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_redeliverdate.ValueChanged
        If dtpick_redeliverdate.Value < Date.Now Then
            MessageBox.Show("invalied date!")
            dtpick_redeliverdate.Value = Date.Now
        End If
    End Sub
End Class