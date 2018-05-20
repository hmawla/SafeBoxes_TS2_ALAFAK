Imports MaterialSkin
Public Class Frm_Login
    Public materialSkinManager As MaterialSkin.MaterialSkinManager = materialSkinManager.Instance

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Exists(txt_empid.Text, "SELECT EmpId FROM Employees") Then
            Frm_main.loggedEmpId = txt_empid.Text
            Frm_main.Show()
            Me.Dispose()
        Else
            MessageBox.Show("Invalid Employee ID!")
        End If

    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.AddFormToManage(Frm_main)
        materialSkinManager.AddFormToManage(Frm_Contracts)
        materialSkinManager.AddFormToManage(Frm_ContractVisits)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        materialSkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub txt_empid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_empid.KeyPress
        Only_Number(txt_empid, e)
    End Sub
End Class