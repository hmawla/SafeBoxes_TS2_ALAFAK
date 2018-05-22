Public Class Frm_NewConnects
    Dim infoVouchid As Integer
    Dim EmpId As Integer
    Dim ds As New DataSet
    Private Sub Frm_Connects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoVouchid = Frm_main.infovouchid
        EmpId = Frm_main.loggedEmpId
        Lbl_infovId.Text = "InfoVoucher ID: " & infoVouchid
        Lbl_EmpId.Text = "Employee ID: " & EmpId
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        'Dim Note As String = InputBox("Answer Note", "Enter your Answer note below: ", "Note Example")
    End Sub
End Class