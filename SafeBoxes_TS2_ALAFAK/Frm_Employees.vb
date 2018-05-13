Public Class Frm_Employees
    Public EmpId As Integer
    Private Sub Frm_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub btn_newEmp_Click(sender As Object, e As EventArgs) Handles btn_newEmp.Click
        EmpId = 0
        Frm_NewEmployee.ShowDialog()
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub btn_modEmp_Click(sender As Object, e As EventArgs) Handles btn_modEmp.Click
        EmpId = dgv_employees.SelectedRows(0).Cells(0).Value
        Frm_NewEmployee.ShowDialog()
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub btn_delEmp_Click(sender As Object, e As EventArgs) Handles btn_delEmp.Click
        ExecuteQuery("DELETE FROM Employees WHERE EmpId = " & dgv_employees.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub dgv_employees_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_employees.SelectionChanged
        Try
            If dgv_employees.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delEmp.Enabled = True
            btn_modEmp.Enabled = True
        Catch ex As Exception
            btn_delEmp.Enabled = False
            btn_modEmp.Enabled = False
        End Try
    End Sub
End Class