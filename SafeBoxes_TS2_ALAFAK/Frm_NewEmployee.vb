Public Class Frm_NewEmployee
    Dim theNewId As Integer
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If txt_fname.Text = "" Or txt_lname.Text = "" Or txt_father.Text = "" Then
            MessageBox.Show("Please fill all needed information!")
        Else
            ExecuteQuery("UPDATE Employees SET EmpFName = '" & txt_fname.Text & "', EmpLName = '" & txt_lname.Text & "', EmpMName = '" & txt_fname.Text & "' WHERE EmpId = " & theNewId)
            Frm_main.clientid = theNewId
            Me.Dispose()
        End If
    End Sub

    Private Sub Frm_NewEmployee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ExecuteQuery("DELETE FROM Employees WHERE EmpId = " & theNewId)
        Me.Dispose()
    End Sub

    Private Sub Frm_NewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theNewId = genID("Employees", "EmpId")
        ExecuteQuery("INSERT INTO Employees(EmpId) VALUES(" & theNewId & ")")
        lbl_Empid.Text = "EmployeeId ID: " & theNewId
    End Sub

    Private Sub txt_father_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_father.KeyPress
        Only_char(txt_father, e)
    End Sub

    Private Sub txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fname.KeyPress
        Only_char(txt_fname, e)
    End Sub

    Private Sub txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lname.KeyPress
        Only_char(txt_lname, e)
    End Sub
End Class
