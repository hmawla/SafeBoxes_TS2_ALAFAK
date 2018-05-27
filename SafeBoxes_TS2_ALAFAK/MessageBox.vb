Public Class MessageBox
    Dim result As DialogResult
    Dim isSbmit As Boolean = False
    Public Overloads Sub Show(message As String)
        isSbmit = False
        Btn_No.Visible = False
        Btn_Yes.Visible = False
        Btn_OK.Visible = True
        Text = "Notice"
        Lbl_Message.Text = message
        Me.ShowDialog()
    End Sub
    Public Overloads Sub Show(message As String, title As String)
        isSbmit = False
        Btn_No.Visible = False
        Btn_Yes.Visible = False
        Btn_OK.Visible = True
        Text = title
        Lbl_Message.Text = message
        Me.ShowDialog()
    End Sub
    Public Overloads Sub Show(message As String, title As String, type As MessageBoxButtons)
        isSbmit = False
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
        isSbmit = True
        Close()
    End Sub

    Private Sub Btn_No_Click(sender As Object, e As EventArgs) Handles Btn_No.Click
        isSbmit = True
        mesResult = DialogResult.No
        Close()
    End Sub

    Private Sub Btn_Yes_Click(sender As Object, e As EventArgs) Handles Btn_Yes.Click
        isSbmit = True
        mesResult = DialogResult.Yes
        Close()
    End Sub

    Private Sub MessageBox_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSbmit = False Then
            mesResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(345, 210)
    End Sub
End Class