Public Class Frm_NewClient
    Dim theNewId As Integer
    Private Sub Frm_NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        theNewId = genID("Clients", "ClientId")
        ExecuteQuery("INSERT INTO Clients(ClientId) VALUES(" & theNewId & ")")
        lbl_cid.Text = "ClientId ID: " & theNewId
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If txt_fname.Text = "" Or txt_lname.Text = "" Or txt_father.Text = "" Or txt_mother.Text = "" Or txt_pbnumber.Text = "" Or txt_rnumber.Text = "" Or dtpick_birth.Value > DateTime.Now.AddYears(-18) Or dtpick_birth.Value = "" Then
            MessageBox.Show("Please fill all needed information!")
        Else
            If Not Exists(cbox_regions.Text, "SELECT RegionName FROM Regions") Then
                ExecuteQuery("INSERT INTO Regions VALUES(" & genID("Regions", "RegionId") & ", '" & cbox_regions.Text & "')")
            End If
            ExecuteQuery("UPDATE Clients SET ClientFName = '" & txt_fname.Text & "', ClientLName = '" & txt_lname.Text & "', ClientMName = '" & txt_father.Text & "', ClientMother = '" & txt_mother.Text & "', ClientDOB = '" & dtpick_birth.Value.ToShortDateString & "', ClientRegisterNbr = " & txt_rnumber.Text & ", PostBoxNbr = " & txt_pbnumber.Text & ", RegionId = " & cbox_regions.SelectedValue & " WHERE ClientId = " & theNewId)
            Me.Close()
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
End Class