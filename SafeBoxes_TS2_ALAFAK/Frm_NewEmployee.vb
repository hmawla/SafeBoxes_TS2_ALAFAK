Public Class Frm_NewEmployee
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False
    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        isSubmitting = True
        If txt_fname.Text = "" Or txt_lname.Text = "" Or txt_father.Text = "" Then
            MessageBox.Show("Please fill all needed information!")
        Else
            ExecuteQuery("UPDATE Employees SET EmpFName = '" & txt_fname.Text & "', EmpLName = '" & txt_lname.Text & "', EmpMName = '" & txt_father.Text & "' WHERE EmpId = " & theNewId)
            Frm_main.employeeid = theNewId
            Me.Dispose()
        End If
    End Sub

    Private Sub Frm_NewEmployee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSubmitting = False And Frm_Employees.EmpId = 0 Then
            ExecuteQuery("DELETE FROM Employees WHERE EmpId = " & theNewId)
            Me.Dispose()
        End If
    End Sub

    Private Sub Frm_NewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Employees.EmpId = 0 Then
            theNewId = GenID("Employees", "EmpId")
            ExecuteQuery("INSERT INTO Employees(EmpId) VALUES(" & theNewId & ")")
            lbl_Empid.Text = "Employee's ID: " & theNewId
        Else
            theNewId = Frm_Employees.EmpId
            lbl_Empid.Text = "Employee's ID: " & theNewId
            Dim theContDetails As New DataSet
            theContDetails = ReadQueryOut("SELECT * FROM Employees WHERE EmpId = " & theNewId)
            Dim rows As DataRow = theContDetails.Tables(0).Rows(0)
            txt_fname.Text = rows.Item(1)
            txt_father.Text = rows.Item(2)
            txt_lname.Text = rows.Item(3)
        End If

    End Sub

    Private Sub Txt_father_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_father.KeyPress
        Only_char(txt_father, e)
    End Sub

    Private Sub Txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fname.KeyPress
        Only_char(txt_fname, e)
    End Sub

    Private Sub Txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lname.KeyPress
        Only_char(txt_lname, e)
    End Sub
End Class
