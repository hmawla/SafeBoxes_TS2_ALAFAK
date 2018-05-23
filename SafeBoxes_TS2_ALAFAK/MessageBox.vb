Public Class MessageBox
    Dim result As DialogResult
    Public Overloads Sub Show(message As String)
        Btn_No.Visible = False
        Btn_Yes.Visible = False
        Btn_OK.Visible = True
        Text = "Notice"
        Lbl_Message.Text = message
        Me.ShowDialog()
    End Sub
    Public Overloads Sub Show(message As String, title As String)
        Btn_No.Visible = False
        Btn_Yes.Visible = False
        Btn_OK.Visible = True
        Text = title
        Lbl_Message.Text = message
        Me.ShowDialog()
    End Sub
    Public Overloads Sub Show(message As String, title As String, type As MessageBoxButtons)
        If type = MessageBoxButtons.YesNo Then
            Text = title
            Lbl_Message.Text = message
            Btn_Yes.Visible = True
            Btn_No.Visible = True
            Btn_OK.Visible = False
        End If
        Me.ShowDialog()
    End Sub


    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        Close()
    End Sub

    Private Sub Btn_No_Click(sender As Object, e As EventArgs) Handles Btn_No.Click
        mesResult = DialogResult.No
        Close()
    End Sub

    Private Sub Btn_Yes_Click(sender As Object, e As EventArgs) Handles Btn_Yes.Click
        mesResult = DialogResult.Yes
        Close()
    End Sub
End Class