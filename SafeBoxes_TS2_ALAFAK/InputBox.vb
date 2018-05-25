Public Class InputBox
    Dim isOk As Boolean = False
    Public Overloads Sub Show(message As String, title As String)
        isOk = False
        inResult = ""
        Lbl_Message.Text = message
        Me.Text = title
        Txt_Input.Text = ""
        Txt_Input.UseSystemPasswordChar = False
        Me.ShowDialog()
    End Sub
    Public Overloads Sub Show(message As String, title As String, pass As Boolean)
        isOk = False
        inResult = ""
        Lbl_Message.Text = message
        Me.Text = title
        Txt_Input.Text = ""
        Txt_Input.UseSystemPasswordChar = True
        Me.ShowDialog()
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        isOk = True
        inResult = Txt_Input.Text
        Me.Close()
    End Sub

    Private Sub InputBox_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not isOk Then
            inResult = "0"
        End If
    End Sub
End Class