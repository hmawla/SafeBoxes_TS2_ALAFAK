Public Class Frm_NewCompany
    Dim theNewId As Integer

    Private Sub Frm_NewCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_comptypes, "SELECT CompTypeId, CompType FROM CompType", "CompTypeId", "CompType")
        theNewId = genID("Company", "CompId")
        ExecuteQuery("INSERT INTO Company(CompId) VALUES(" & theNewId & ")")
        lbl_compid.Text = "Company ID: " & theNewId
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If txt_compname.Text = "" Or cbox_comptypes.Text = "" Then
            MessageBox.Show("Fill all needed information!")
        Else
            ExecuteQuery("UPDATE Company SET CompName = '" & txt_compname.Text & "', CompType = " & cbox_comptypes.SelectedValue & "WHERE CompId = " & theNewId)
            MessageBox.Show("Company Added!")
            Me.Close()
        End If


    End Sub
End Class