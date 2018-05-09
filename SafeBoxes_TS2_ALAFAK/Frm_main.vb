Public Class Frm_main
    Public accountid As String
    Public clientid As String
    Public contractid As String
    Public employeeid As String

    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitCon()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        frm_newContract.Show()

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs)
        Frm_SelectAccountClient.Show()
    End Sub

    Private Sub Frm_main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btn_newclient_Click(sender As Object, e As EventArgs) Handles btn_newclient.Click
        Frm_NewClient.Show()
    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Frm_NewCompany.Show()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Frm_NewInfoVoucher.Show()
    End Sub

    Private Sub btn_submitemp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Frm_NewEmployee.Show()
    End Sub

    Private Sub btn_contractsman_Click(sender As Object, e As EventArgs) Handles btn_contractsman.Click
        Frm_Contracts.Show()
    End Sub
End Class
