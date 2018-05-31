Public Class Frm_Employees
    Public EmpId As Integer
    Private Sub Frm_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
        Me.MinimumSize = New Size(685, 577)
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
        InputBox.Show("Enter admin password:", "Delete Employee#" & dgv_employees.SelectedRows(0).Cells(0).Value, True)
        If Not inResult.Equals("0") Then
            If inResult = adminPass Then
                ExecuteQuery("DELETE FROM Employees WHERE EmpId = " & dgv_employees.SelectedRows(0).Cells(0).Value)
                FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
            Else
                MessageBox.Show("Wrong password!")
            End If
        End If
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

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees")
        btn_reset.Enabled = False
        btn_search.Enabled = True
        txt_byEmpid.Text = ""
        txt_byEmpname.Text = ""
    End Sub

    Private Sub rdb_byEmpid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byEmpid.CheckedChanged
        txt_byEmpid.Enabled = True
        txt_byEmpname.Enabled = False
        txt_byEmpname.Text = ""
        txt_byEmpid.Focus()
    End Sub

    Private Sub rdb_byEmpName_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_byEmpName.CheckedChanged
        txt_byEmpid.Enabled = False
        txt_byEmpname.Enabled = True
        txt_byEmpid.Text = ""
        txt_byEmpname.Focus()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        btn_search.Enabled = False
        If rdb_byEmpid.Checked Then
            FillDGV(dgv_employees, "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees WHERE EmpId = " & txt_byEmpid.Text)
        Else
            Dim firstName As String
            Dim lastName As String = ""
            firstName = txt_byEmpname.Text.Split(New Char() {" "c})(0)
            Try
                lastName = txt_byEmpname.Text.Split(New Char() {" "c})(1)
            Catch ex As Exception

            End Try

            Dim theQuery As String = "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees WHERE EmpFName LIKE '%" & firstName & "%'"
            If lastName <> "" Then
                theQuery = "SELECT EmpId AS [ID], EmpFName AS [First Name], EmpMName AS [Father Name], EmpLName AS [Last Name] FROM Employees WHERE EmpFName LIKE '%" & firstName & "%' AND EmpLName LIKE '%" & lastName & "%'"
            End If
            FillDGV(dgv_employees, theQuery)
        End If
    End Sub

    Private Sub txt_byEmpid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byEmpid.KeyPress
        Only_Number(txt_byEmpid, e)
    End Sub

    Private Sub txt_byEmpname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_byEmpname.KeyPress
        Only_char(txt_byEmpname, e)
    End Sub
End Class