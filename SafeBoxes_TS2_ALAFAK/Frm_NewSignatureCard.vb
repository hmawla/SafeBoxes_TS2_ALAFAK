Public Class Frm_NewSignatureCard
    Dim EmpId As Integer
    Dim formLoaded As Boolean = False
    Dim ds As DataSet
    Dim anotherds As DataSet
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False
    Dim bs As New BindingSource


    Private Sub Frm_NewSignatureCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cid.Text = ""
        txt_cnam.Text = ""
        txt_contid.Text = ""
        cbox_careers.Text = ""
        cbox_buildings.Text = ""
        cbox_Nation.Text = ""
        txt_signnote.Text = ""
        EmpId = Frm_main.loggedEmpId
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings", "BuildingId", "BuildingName")
        FillCBox(cbox_Nation, "SELECT NationId, Nationality FROM Nationalities", "NationId", "Nationality")
        FillCBox(cbox_careers, "SELECT CareerId, CareerName FROM Careers", "CareerId", "CareerName")
        If Frm_SignatureCards.signaturecardid = 0 Then
            theNewId = GenID("SignatureCards", "SignCardId")
            ExecuteQuery("INSERT INTO SignatureCards(SignCardId) VALUES(" & theNewId & ")")
            lbl_signcardid.Text = "SignatureCard ID: " & theNewId
        Else
            theNewId = Frm_SignatureCards.signaturecardid
            lbl_signcardid.Text = "SignatureCard ID: " & theNewId
        End If
        formLoaded = True
    End Sub

    Private Sub txt_accountid_Leave(sender As Object, e As EventArgs) Handles txt_cid.Leave
        txt_cnam.Text = ""
        Dim i As Integer = 1
        Try
            ds = ReadQueryOut("SELECT ClientId, ClientFName, ClientLName, ClientDOB FROM Clients WHERE ClientId = " & txt_cid.Text)
            If ds.Tables(0).Rows.Count <> 0 Then
                txt_cnam.Text = ds.Tables(0).Rows(0).Item(1) & " " & ds.Tables(0).Rows(0).Item(2)
            Else
                MsgBox("Invalid Client ID!")
                txt_cid.Focus()
                txt_cid.SelectAll()
            End If

        Catch ex As Exception
            MsgBox("Invalid Client ID!")
            txt_cid.Focus()
            txt_cid.SelectAll()
        End Try

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        isSubmitting = True
        If txt_cid.Text = "" Or txt_signnote.Text = "" Or txt_contid.Text = "" Then
            MessageBox.Show("Please fill all needed information!")
        Else
            ExecuteQuery("UPDATE SignatureCards SET ClientId = " & txt_cid.Text & ", SignCardDate = '" & Date.Today.ToShortDateString & "', SignCardNote = '" & txt_signnote.Text & "', NationId = " & cbox_Nation.SelectedValue & ", ContId = " & txt_contid.Text & ", CareerId = " & cbox_careers.SelectedValue & ", BuildingId = " & cbox_buildings.SelectedValue & " WHERE SignCardId = " & theNewId)
            Me.Close()
        End If
    End Sub

    Private Sub Frm_NewSignatureCard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSubmitting = False And Frm_Contracts.contractId = 0 Then
            ExecuteQuery("DELETE FROM SignatureCards WHERE SignCardId = " & theNewId)
        End If
    End Sub

    Private Sub txt_cid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contid.KeyPress, txt_cid.KeyPress
        Only_Number(txt_cid, e)
    End Sub
End Class