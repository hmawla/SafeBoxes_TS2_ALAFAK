﻿Imports MaterialSkin
Public Class Frm_Login
    Public materialSkinManager As MaterialSkin.MaterialSkinManager = materialSkinManager.Instance

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Exists(txt_empid.Text, "SELECT EmpId FROM Employees") Then
            Frm_main.loggedEmpId = txt_empid.Text
            Frm_main.Show()
            Me.Dispose()
        Else
            MessageBox.Show("Invalid Employee ID!")
            txt_empid.Text = ""
            txt_empid.Focus()
        End If

    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.AddFormToManage(Frm_main)
        materialSkinManager.AddFormToManage(Frm_Contracts)
        materialSkinManager.AddFormToManage(Frm_ContractVisits)
        materialSkinManager.AddFormToManage(MessageBox)
        materialSkinManager.AddFormToManage(InputBox)
        materialSkinManager.AddFormToManage(Frm_Clients)
        materialSkinManager.AddFormToManage(Frm_InfoVoucher)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        materialSkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple500, Accent.LightBlue200, TextShade.WHITE)
        Me.MinimumSize = New Size(204, 179)
    End Sub

    Private Sub txt_empid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_empid.KeyPress
        Only_Number(txt_empid, e)
    End Sub

    Private Sub txt_empid_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_empid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub Frm_Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class