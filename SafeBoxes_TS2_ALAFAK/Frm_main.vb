Public Class Frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitCon()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        frm_newContract.Show()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Frm_SelectAccount.Show()
    End Sub

    Private Sub Frm_main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class
