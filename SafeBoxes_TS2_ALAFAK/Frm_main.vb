Public Class Frm_main
    Public accountid As Integer
    Public clientid As Integer
    Public contractid As Integer
    Public employeeid As Integer
    Public loggedEmpId As Integer
    Public infovouchid As Integer

    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitCon()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Frm_newContract.Show()

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

    Private Sub MaterialRaisedButton18_Click(sender As Object, e As EventArgs) Handles btn_clientsman.Click
        Frm_Clients.Show()
    End Sub

    Private Sub MaterialRaisedButton18_Click_1(sender As Object, e As EventArgs) Handles btn_compman.Click
        Frm_Companies.Show()
    End Sub

    Private Sub MaterialRaisedButton19_Click(sender As Object, e As EventArgs) Handles btn_infovouchman.Click
        Frm_InfoVoucher.Show()
    End Sub

    Private Sub MaterialRaisedButton19_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton19.Click
        Frm_Boxes.Show()
    End Sub

    Private Sub MaterialRaisedButton18_Click_2(sender As Object, e As EventArgs) Handles MaterialRaisedButton18.Click
        Frm_Employees.Show()
    End Sub
End Class
