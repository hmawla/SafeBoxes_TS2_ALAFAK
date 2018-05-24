Public Class Frm_NewBox
    Dim theNewId As Integer
    Private Sub Frm_NewBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_addsize, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop") 'Fill the search combo box with all available sizes
        If Frm_Boxes.BoxId = 0 Then
            theNewId = GenID("Boxes", "BoxId")
            lbl_boxid.Text = "Box ID: " & theNewId
        Else
            theNewId = Frm_Boxes.BoxId
            lbl_boxid.Text = "Box ID: " & theNewId
            Dim theContDetails As New DataSet
            theContDetails = ReadQueryOut("SELECT * FROM Boxes WHERE BoxId = " & theNewId)
            Dim rows As DataRow = theContDetails.Tables(0).Rows(0)
            cbox_addsize.SelectedValue = rows.Item(1)
        End If

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        If Frm_Boxes.BoxId = 0 Then
            Console.WriteLine("INSERT INTO Boxes VALUES(" & theNewId & ", " & cbox_addsize.SelectedValue & ")")
            ExecuteQuery("INSERT INTO Boxes VALUES(" & theNewId & ", " & cbox_addsize.SelectedValue & ")")
        Else
            ExecuteQuery("UPDATE Boxes SET SizeId = " & cbox_addsize.SelectedValue & " WHERE BoxId = " & theNewId)
        End If
        Me.Dispose()
    End Sub
End Class