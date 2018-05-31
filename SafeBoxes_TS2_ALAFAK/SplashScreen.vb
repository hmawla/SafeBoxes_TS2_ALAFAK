Imports System.ComponentModel
Imports System.Reflection
Imports System.Diagnostics
Imports System.Threading

Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AddOwnedForm(Frm_Report_MissingKeys)
        Me.AddOwnedForm(Frm_Report_Authorizations)
        Me.AddOwnedForm(Frm_Report_Contract)
        Me.AddOwnedForm(Frm_Report_EndingContracts)
        Me.AddOwnedForm(Frm_Report_WithdrawPermission)
        Me.AddOwnedForm(Frm_Report_Visits)
        Me.AddOwnedForm(Frm_Report_BoxPrices)
        Me.AddOwnedForm(Frm_Report_WithdrawPermission)
        Me.AddOwnedForm(Frm_Report_RenewContract)
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub SplashScreen_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'For Each frm As Form In Me.OwnedForms
        '    frm.WindowState = 1
        '    frm.Show()
        '    Thread.Sleep(20)
        '    frm.WindowState = 0
        '    frm.Hide()
        'Next

    End Sub

    Private Sub SplashScreen_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Frm_Login.Show()
        Me.Hide()
    End Sub
End Class
