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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_reset.Enabled = True
        If rdb_bycompid.Checked Then
            FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompId=" & txt_bycid.Text & " AND c.CompTypeId=ct.CompTypeId")
        Else
            FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompName LIKE '%" & txt_bycname.Text & "%' AND c.CompTypeId=ct.CompTypeId")
        End If
    End Sub

    Private Sub rdb_bycompid_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_bycompid.CheckedChanged
        txt_bycid.Enabled = True
        txt_bycname.Enabled = False
        txt_bycname.Text = ""
        txt_bycid.Focus()
    End Sub

    Private Sub rdb_bycompName_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_bycompName.CheckedChanged
        txt_bycid.Enabled = False
        txt_bycname.Enabled = True
        txt_bycid.Text = ""
        txt_bycname.Focus()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        FillDGV(dgv_companies, "SELECT CompId AS [ID], CompName AS [Company Name], CompType AS [Company Type]  FROM Company c,CompType ct WHERE c.CompTypeId=ct.CompTypeId")
        btn_reset.Enabled = False
        txt_bycid.Text = ""
        txt_bycname.Text = ""
    End Sub

    Private Sub txt_bycid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bycid.KeyPress
        Only_Number(txt_bycid, e)
    End Sub

    Private Sub txt_bycname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bycname.KeyPress
        Only_char(txt_bycname, e)
    End Sub
End Class