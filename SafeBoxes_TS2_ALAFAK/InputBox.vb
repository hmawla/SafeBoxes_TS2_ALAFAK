Public Class InputBox
    Public Overloads Sub Show(message As String, title As String)
        inResult = ""
        Lbl_Message.Text = message
        Me.Text = title
        Txt_Input.Text = ""
        Me.ShowDialog()
    End Sub
    Public Overloads Sub Show(message As String, title As String, pass As Boolean)
        inResult = ""
        Lbl_Message.Text = message
        Me.Text = title
        Txt_Input.Text = ""
        Txt_Input.UseSystemPasswordChar = True
        Me.ShowDialog()
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        inResult = Txt_Input.Text
        Me.Close()
    End Sub
End Class