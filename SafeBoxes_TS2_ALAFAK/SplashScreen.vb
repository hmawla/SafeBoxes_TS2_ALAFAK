Imports System.ComponentModel
Imports System.Reflection
Imports System.Diagnostics
Imports System.Threading

Public Class SplashScreen

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
End Class