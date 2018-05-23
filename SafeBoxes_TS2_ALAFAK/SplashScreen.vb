Imports System.ComponentModel
Imports System.Reflection
Imports System.Diagnostics
Imports System.Threading

Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.AddOwnedForm(Frm_Report_MissingKeys)
        'Me.AddOwnedForm(Frm_Report_Authorizations)
        'Me.AddOwnedForm(Frm_Report_Contract)
        'Me.AddOwnedForm(Frm_Report_EndingContracts)
        'Me.AddOwnedForm(Frm_Report_WithdrawPermission)
        'Me.AddOwnedForm(Frm_Report_Visits)
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each frm As Form In Me.OwnedForms
            frm.WindowState = WindowState.Minimized
            frm.Show()
            Thread.Sleep(50)
            frm.WindowState = WindowState.Normal
            frm.Hide()
        Next
        Frm_Login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
