Public Class Frm_NewClient
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False
    Private Sub Frm_NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        If Frm_Clients.clientId = 0 Then
            theNewId = genID("Clients", "ClientId")
            ExecuteQuery("INSERT INTO Clients(ClientId) VALUES(" & theNewId & ")")
            lbl_cid.Text = "ClientId ID: " & theNewId
        Else
            theNewId = Frm_Clients.clientId
            lbl_cid.Text = "Client ID: " & theNewId
            Dim theContDetails As New DataSet
            theContDetails = ReadQueryOut("SELECT * FROM Clients WHERE ClientId = " & theNewId)
            Dim rows As DataRow = theContDetails.Tables(0).Rows(0)
            txt_fname.Text = rows.Item(1)
            txt_father.Text = rows.Item(2)
            txt_lname.Text = rows.Item(3)
            dtpick_birth.Value = rows.Item(4)
            txt_mother.Text = rows.Item(5)
            txt_rnumber.Text = rows.Item(6)
            txt_pbnumber.Text = rows.Item(7)
            Dim theRegion As String = rows.Item(8)
            theContDetails.Reset()
            theContDetails = ReadQueryOut("SELECT RegionId,RegionName FROM Regions WHERE RegionId = " & theRegion)
            rows = theContDetails.Tables(0).Rows(0)
            cbox_regions.SelectedValue = rows.Item(0)
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        isSubmitting = True
        If txt_fname.Text = "" Or txt_lname.Text = "" Or txt_father.Text = "" Or txt_mother.Text = "" Or txt_pbnumber.Text = "" Or txt_rnumber.Text = "" Or dtpick_birth.Value > DateTime.Now.AddYears(-18) Or cbox_regions.Text = "" Then
            MessageBox.Show("Please fill all needed information!")
        Else
            If Not Exists(cbox_regions.Text, "SELECT RegionName FROM Regions") Then
                ExecuteQuery("INSERT INTO Regions VALUES(" & genID("Regions", "RegionId") & ", '" & cbox_regions.Text & "')")
            End If
            ExecuteQuery("UPDATE Clients SET ClientFName = '" & txt_fname.Text & "', ClientLName = '" & txt_lname.Text & "', ClientMName = '" & txt_father.Text & "', ClientMother = '" & txt_mother.Text & "', ClientDOB = '" & dtpick_birth.Value.ToShortDateString & "', ClientRegisterNbr = " & txt_rnumber.Text & ", PostBoxNbr = " & txt_pbnumber.Text & ", RegionId = " & cbox_regions.SelectedValue & " WHERE ClientId = " & theNewId)
            Frm_main.clientid = theNewId
            Me.Dispose()
        End If
    End Sub

    Private Sub dtpick_birth_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_birth.ValueChanged
        If dtpick_birth.Value > DateTime.Now.AddYears(-18) Then
            MessageBox.Show("Enter a valid date! " & vbNewLine & "Notice: the client should be at least 18 years old!")
            dtpick_birth.Value = DateTime.Now.AddYears(-18)
        End If
    End Sub

    Private Sub txt_rnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rnumber.KeyPress
        Only_Number(txt_rnumber, e)
    End Sub

    Private Sub txt_pbnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pbnumber.KeyPress
        Only_Number(txt_rnumber, e)
    End Sub



    Private Sub txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fname.KeyPress
        Only_char(txt_fname, e)
    End Sub

    Private Sub txt_father_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_father.KeyPress
        Only_char(txt_father, e)
    End Sub

    Private Sub txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lname.KeyPress
        Only_char(txt_lname, e)
    End Sub

    Private Sub txt_mother_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mother.KeyPress
        Only_char(txt_mother, e)
    End Sub

    Private Sub Frm_NewClient_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not isSubmitting Then
            ExecuteQuery("DELETE FROM Clients WHERE ClientId = " & theNewId)
            Me.Dispose()
        End If
    End Sub

    Private Sub cbox_regions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_regions.KeyPress
        Only_char(cbox_regions, e)
    End Sub
End Class