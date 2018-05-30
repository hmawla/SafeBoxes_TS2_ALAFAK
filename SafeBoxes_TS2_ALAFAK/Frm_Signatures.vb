Public Class Frm_Signatures
    Public sigcardid As Integer = 0
    Private Sub Brn_NewSignature_Click(sender As Object, e As EventArgs) Handles Brn_NewSignature.Click
        Frm_main.signatureId = 0
        If Dgv_Signatures.Rows.Count > 0 Then
            sigcardid = Dgv_Signatures.SelectedRows(0).Cells(4).Value
        Else
            sigcardid = 0
        End If
        Frm_newSignature.ShowDialog()
        FillDGV(Dgv_Signatures, "SELECT SignId, SignType, SignDate, ClientFName + ' ' + ClientLName, SignCardId FROM Signatures s, Clients c WHERE s.ClientId = c.ClientId")
    End Sub

    Private Sub Frm_Signatures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV(Dgv_Signatures, "SELECT SignId, SignType, SignDate, ClientFName + ' ' + ClientLName, SignCardId FROM Signatures s, Clients c WHERE s.ClientId = c.ClientId")
    End Sub
    Private Sub Btn_DelSignature_Click(sender As Object, e As EventArgs) Handles Btn_DelSignature.Click
        InputBox.Show("Enter admin password:", "Delete Signature#" & Dgv_Signatures.SelectedRows(0).Cells(0).Value, True)

        If inResult = adminPass Then
            ExecuteQuery("DELETE FROM Signature WHERE SignId = " & Dgv_Signatures.SelectedRows(0).Cells(0).Value)
            ExecuteQuery("DELETE FROM Signature WHERE SignType = " & Dgv_Signatures.SelectedRows(0).Cells(0).Value)
            ExecuteQuery("DELETE FROM Signature WHERE SignDate = " & Dgv_Signatures.SelectedRows(0).Cells(0).Value)
            ExecuteQuery("DELETE FROM Clients WHERE ClientFName = " & Dgv_Signatures.SelectedRows(0).Cells(0).Value & "DELETE FROM Clients WHERE ClientLName = " & Dgv_Signatures.SelectedRows(0).Cells(0).Value)


            ExecuteQuery("DELETE FROM Signature WHERE SignCardId = " & Dgv_Signatures.SelectedRows(0).Cells(0).Value)
        Else
            MessageBox.Show("Wrong password!")
        End If

    End Sub
End Class

