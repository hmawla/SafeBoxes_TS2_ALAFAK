Public Class Frm_NewSignatureCard
    Dim EmpId As Integer
    Dim formLoaded As Boolean = False
    Dim ds As New DataSet
    Dim anotherds As DataSet
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False
    Dim bs As New BindingSource


    Private Sub Frm_NewSignatureCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(349, 408)
        EmpId = Frm_main.loggedEmpId
        FillCBox(cbox_Nation, "SELECT NationId, Nationality FROM Nationalities", "NationId", "Nationality")
        FillCBox(cbox_careers, "SELECT CareerId, CareerName FROM Careers", "CareerId", "CareerName")
        If Frm_SignatureCards.signaturecardid = 0 Then
            theNewId = GenID("SignatureCards", "SignCardId")
            ExecuteQuery("INSERT INTO SignatureCards(SignCardId) VALUES(" & theNewId & ")")
            lbl_signcardid.Text = "SignatureCard ID: " & theNewId
        Else
            theNewId = Frm_SignatureCards.signaturecardid
            lbl_signcardid.Text = "SignatureCard ID: " & theNewId
            Dim theSignDetails As New DataSet
            theSignDetails = ReadQueryOut("SELECT SignCardNote, ClientId, NationId, ContId, CareerId FROM SignatureCards WHERE SignCardId = " & theNewId).Copy
            txt_cid.Text = theSignDetails.Tables(0).Rows(0).Item(1)
            txt_contid.Text = theSignDetails.Tables(0).Rows(0).Item(3)
            cbox_careers.SelectedValue = theSignDetails.Tables(0).Rows(0).Item(4)
            cbox_Nation.SelectedValue = theSignDetails.Tables(0).Rows(0).Item(2)
            txt_signnote.Text = theSignDetails.Tables(0).Rows(0).Item(0)
        End If
        formLoaded = True
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        isSubmitting = True
        If txt_cid.Text = "" Or txt_signnote.Text = "" Or txt_contid.Text = "" Then
            MessageBox.Show("Please fill all needed information!")
        Else
            If Exists(txt_contid.Text, "SELECT ContId FROM Contract") Then
                ExecuteQuery("UPDATE SignatureCards SET ClientId = " & txt_cid.Text & ", SignCardDate = '" & Date.Today.ToShortDateString & "', SignCardNote = '" & txt_signnote.Text & "', NationId = " & cbox_Nation.SelectedValue & ", ContId = " & txt_contid.Text & ", CareerId = " & cbox_careers.SelectedValue & " WHERE SignCardId = " & theNewId)
                Me.Close()
            Else
                MessageBox.Show("Invalid contract ID!")
            End If

        End If
    End Sub

    Private Sub Frm_NewSignatureCard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSubmitting = False And Frm_SignatureCards.signaturecardid = 0 Then
            ExecuteQuery("DELETE FROM SignatureCards WHERE SignCardId = " & theNewId)
        End If
    End Sub

    Private Sub txt_cid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contid.KeyPress, txt_cid.KeyPress
        Only_Number(txt_cid, e)
    End Sub

    Private Sub txt_cnam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cnam.KeyPress
        Only_char(txt_cnam, e)
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click
        Frm_main.clientid = 0
        Frm_Clients.ShowDialog()
        txt_cid.Text = Frm_main.clientid
    End Sub

    Private Sub SelectContractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectContractToolStripMenuItem.Click
        Frm_main.contractid = 0
        Frm_Contracts.ShowDialog()
        txt_contid.Text = Frm_main.contractid
    End Sub

    Private Sub txt_cid_TextChanged(sender As Object, e As EventArgs) Handles txt_cid.TextChanged
        Try
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName From Clients WHERE ClientId = " & txt_cid.Text)
            txt_cnam.Text = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            txt_cnam.Text = ""
        End Try
    End Sub
End Class