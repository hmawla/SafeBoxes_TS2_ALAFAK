Public Class Frm_NewCompany
    Dim theNewId As Integer
    Dim ds As New DataSet

    Private Sub Frm_NewCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_comptypes, "SELECT CompTypeId, CompType FROM CompType", "CompTypeId", "CompType")
        If Not Frm_Companies.companyId = 0 Then
            theNewId = Frm_Companies.companyId
            Dim theContDetails As New DataSet
            theContDetails = ReadQueryOut("SELECT * FROM Company WHERE CompId = " & theNewId)
            Dim rows As DataRow = theContDetails.Tables(0).Rows(0)
            txt_compname.Text = rows.Item(1)
            Dim theType As String = rows.Item(2)
            theContDetails.Reset()
            theContDetails = ReadQueryOut("SELECT CompType, CompTypeId FROM CompType WHERE CompTypeId = " & theType)
            rows = theContDetails.Tables(0).Rows(0)
            cbox_comptypes.SelectedValue = rows.Item(1)
        End If

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If Frm_Companies.companyId = 0 Then
            If txt_compname.Text = "" Or cbox_comptypes.Text = "" Then
                MessageBox.Show("Please fill all needed information!")
            Else
                theNewId = GenID("Company", "CompId")
                ExecuteQuery("INSERT INTO Company VALUES(" & theNewId & ", '" & txt_compname.Text & "', " & cbox_comptypes.SelectedValue & ")")
                MessageBox.Show("Company Added!")
                Me.Dispose()
            End If
        Else
            If txt_compname.Text = "" Or cbox_comptypes.Text = "" Then
                MessageBox.Show("Please fill all needed information!")
            Else
                ExecuteQuery("UPDATE Company SET CompName = '" & txt_compname.Text & "', CompTypeId = " & cbox_comptypes.SelectedValue & " WHERE CompId = " & theNewId)
                MessageBox.Show("Company Updated!")
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub txt_compname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compname.KeyPress
        Only_char(txt_compname, e)
    End Sub

    Private Sub cbox_comptypes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_comptypes.KeyPress
        Only_char(cbox_comptypes, e)
    End Sub

    Private Sub Frm_NewCompany_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub cbox_comptypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbox_comptypes.TextChanged
        Rdb_Personal.Enabled = False
        Try
            ds = ReadQueryOut("SELECT PersonalYN FROM CompType WHERE CompTypeId = " & cbox_comptypes.SelectedValue)
            Rdb_Personal.Checked = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Rdb_Personal.Enabled = True
            Rdb_Personal.Checked = False
        End Try

    End Sub
End Class