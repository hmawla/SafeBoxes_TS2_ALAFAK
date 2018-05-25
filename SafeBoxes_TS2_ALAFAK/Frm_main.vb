Imports MaterialSkin

Public Class Frm_main
    Public accountid As Integer = vbNull
    Public clientid As Integer = vbNull
    Public contractid As Integer = vbNull
    Public loggedEmpId As Integer = vbNull
    Public employeeid As Integer = vbNull
    Public infovouchid As Integer = vbNull
    Public boxId As Integer = vbNull

    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ds As New DataSet
        ds = ReadQueryOut("SELECT EmpFName + ' ' + EmpLName FROM Employees WHERE EmpId = " & loggedEmpId)
        Lbl_WelcomeEmp.Text = "Welcome: " + ds.Tables(0).Rows(0).Item(0)
        InitCon()
    End Sub

    Private Sub Frm_main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SplashScreen.Close()
    End Sub

    Private Sub btn_contractsman_Click(sender As Object, e As EventArgs) Handles btn_contractsman.Click
        Frm_Contracts.ShowDialog()
    End Sub

    Private Sub MaterialRaisedButton18_Click(sender As Object, e As EventArgs) Handles btn_clientsman.Click
        Frm_Clients.ShowDialog()
    End Sub

    Private Sub MaterialRaisedButton18_Click_1(sender As Object, e As EventArgs) Handles btn_compman.Click
        Frm_Companies.ShowDialog()
    End Sub

    Private Sub MaterialRaisedButton19_Click(sender As Object, e As EventArgs) Handles btn_infovouchman.Click
        Frm_InfoVoucher.ShowDialog()
    End Sub

    Private Sub MaterialRaisedButton19_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton19.Click
        Frm_Boxes.ShowDialog()
    End Sub

    Private Sub MaterialRaisedButton18_Click_2(sender As Object, e As EventArgs) Handles MaterialRaisedButton18.Click
        Frm_Employees.ShowDialog()
    End Sub

    Private Sub MaterialRaisedButton20_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton20.Click
        Frm_SignatureCards.ShowDialog()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Frm_ClientAccounts.ShowDialog()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Frm_CompaniesAccounts.ShowDialog()
    End Sub

    Private Sub Frm_main_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        PictureBox3.Visible = False
    End Sub

    Private Sub Frm_main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PictureBox3.Visible = True
    End Sub
End Class
