Public Class Frm_Companies
    Public companyId As Integer
    Private Sub Frm_Companies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompTypeId=ct.CompTypeId")
    End Sub

    Private Sub btn_modcompany_Click(sender As Object, e As EventArgs) Handles btn_modcompany.Click
        companyId = dgv_companies.SelectedRows(0).Cells(0).Value
        Frm_NewCompany.ShowDialog()
        FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompTypeId=ct.CompTypeId")

    End Sub

    Private Sub btn_newcompany_Click(sender As Object, e As EventArgs) Handles btn_newcompany.Click
        companyId = 0
        Frm_NewCompany.ShowDialog()
        FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompTypeId=ct.CompTypeId")

    End Sub

    Private Sub btn_delcompany_Click(sender As Object, e As EventArgs) Handles btn_delcompany.Click
        ExecuteQuery("DELETE FROM Company WHERE CompId = " & dgv_companies.SelectedRows(0).Cells(0).Value)
        FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompTypeId=ct.CompTypeId")

    End Sub

    Private Sub dgv_companies_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_companies.SelectionChanged
        Try
            If dgv_companies.SelectedRows(0).Cells(0).Value > 0 Then
            End If
            btn_delcompany.Enabled = True
            btn_modcompany.Enabled = True
        Catch ex As Exception
            btn_delcompany.Enabled = False
            btn_modcompany.Enabled = False
        End Try
    End Sub
End Class