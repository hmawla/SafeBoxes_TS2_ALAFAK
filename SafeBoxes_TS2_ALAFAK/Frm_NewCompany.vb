Public Class Frm_NewCompany
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False

    Private Sub Frm_NewCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_comptypes, "SELECT CompTypeId, CompType FROM CompType", "CompTypeId", "CompType")
        If Frm_Companies.companyId = 0 Then
            theNewId = GenID("Company", "CompId")
            ExecuteQuery("INSERT INTO Company(CompId) VALUES(" & theNewId & ")")
            lbl_compid.Text = "Company ID: " & theNewId
        Else
            theNewId = Frm_Companies.companyId
            lbl_compid.Text = "Company ID: " & theNewId
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
        isSubmitting = True
        If txt_compname.Text = "" Or cbox_comptypes.Text = "" Then
            MessageBox.Show("Fill all needed information!")
        Else
            ExecuteQuery("UPDATE Company SET CompName = '" & txt_compname.Text & "', CompTypeId = " & cbox_comptypes.SelectedValue & " WHERE CompId = " & theNewId)
            MessageBox.Show("Company Added!")
            Me.Close()
        End If


    End Sub

    Private Sub txt_compname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compname.KeyPress
        Only_char(txt_compname, e)
    End Sub

    Private Sub cbox_comptypes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_comptypes.KeyPress
        Only_char(cbox_comptypes, e)
    End Sub

    Private Sub Frm_NewCompany_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not isSubmitting Then
            ExecuteQuery("DELETE FROM Company WHERE CompId = " & theNewId)
            Me.Dispose()
        End If
    End Sub
End Class