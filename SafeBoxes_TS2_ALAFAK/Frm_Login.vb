Public Class Frm_Login
    Private Sub txt_login_Click(sender As Object, e As EventArgs) Handles txt_login.Click
        If Exists(txt_empid.Text, "SELECT EmpId FROM Employees") Then
            Frm_main.employeeid = txt_empid.Text
            Frm_main.Show()
            Me.Dispose()
        Else
            MessageBox.Show("Invalid Employee ID!")
        End If

    End Sub
End Class