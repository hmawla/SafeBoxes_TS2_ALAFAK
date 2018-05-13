Public Class Frm_Employees
    Public EmpId As Integer
    Private Sub Frm_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub Btn_newEmp_Click(sender As Object, e As EventArgs) Handles btn_newEmp.Click
        EmpId = 0
        Frm_NewEmployee.ShowDialog()
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub Btn_modEmp_Click(sender As Object, e As EventArgs) Handles btn_modEmp.Click
        EmpId = dgv_employees.SelectedRows(0).Cells(0).Value
        Frm_NewEmployee.ShowDialog()
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub Btn_delEmp_Click(sender As Object, e As EventArgs) Handles btn_delEmp.Click
        ExecuteQuery("DELETE FROM Employees WHERE EmpId = " & dgv_employees.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
    End Sub

    Private Sub Dgv_employees_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_employees.SelectionChanged
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

    Private Sub dgv_employees_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_employees.CellDoubleClick
        If Frm_main.employeeid = 0 Then
            Try
                If dgv_employees.SelectedRows(0).Cells(0).Value > 0 Then
                End If
                Frm_main.employeeid = dgv_employees.SelectedRows(0).Cells(0).Value
                Me.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class