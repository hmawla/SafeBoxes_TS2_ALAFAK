Public Class Frm_NewBoxSize
    Dim theNewId As Integer
    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If Frm_main.sizeId = 0 Then
            If Txt_Height.Text.Count > 0 And Txt_Width.Text.Count > 0 And Txt_Length.Text.Count > 0 And Txt_InsPrice.Text.Count > 0 And Txt_RentPrice.Text.Count > 0 Then
                Dim ds As New DataSet
                ds = ReadQueryOut("SELECT Length, Width, Height FROM BoxSizes")
                If Not (Txt_Length.Text = ds.Tables(0).Rows(0).Item(0) And Txt_Width.Text = ds.Tables(0).Rows(0).Item(0) And Txt_Height.Text = ds.Tables(0).Rows(0).Item(0)) Then
                    theNewId = GenID("BoxSizes", "SizeId")
                    ExecuteQuery("INSERT INTO BoxSizes VALUES(" & theNewId & ", " & Txt_Length.Text & ", " & Txt_Width.Text & ", " & Txt_Height.Text & " )")
                    ExecuteQuery("INSERT INTO BoxSizesDate VALUES(" & theNewId & ", date(), " & Txt_InsPrice.Text & ", " & Txt_RentPrice.Text & ")")
                    Me.Dispose()
                Else
                    MessageBox.Show("Size already exist!")
                End If
            Else
                MessageBox.Show("Please fill all needed information!")
            End If
        Else
            If Txt_Height.Text.Count > 0 And Txt_Width.Text.Count > 0 And Txt_Length.Text.Count > 0 And Txt_InsPrice.Text.Count > 0 And Txt_RentPrice.Text.Count > 0 Then
                ExecuteQuery("UPDATE BoxSizes SET Length = " & Txt_Length.Text & ", Width = " & Txt_Width.Text & ", Height = " & Txt_Height.Text & " WHERE SizeId = " & theNewId)
                Me.Dispose()
            Else
                MessageBox.Show("Please fill all needed information!")
            End If
        End If
    End Sub

    Private Sub Frm_NewBoxSize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Frm_main.sizeId = 0 Then
            theNewId = Frm_main.sizeId
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT Length, Width, height FROM BoxSizes WHERE SizeId = " & theNewId)
            Txt_Length.Text = ds.Tables(0).Rows(0).Item(0)
            Txt_Width.Text = ds.Tables(0).Rows(0).Item(1)
            Txt_Height.Text = ds.Tables(0).Rows(0).Item(2)
            ds = ReadQueryOut("SELECT SizeId, InsurancePrice, RentPrice, MAX(Date) FROM BoxSizesDate WHERE SizeId = " & theNewId & " GROUP BY SizeId, InsurancePrice, RentPrice")
            Txt_InsPrice.Text = ds.Tables(0).Rows(0).Item(1)
            Txt_RentPrice.Text = ds.Tables(0).Rows(0).Item(2)
            Txt_RentPrice.Enabled = False
            Txt_InsPrice.Enabled = False
        End If
    End Sub

    Private Sub Frm_NewBoxSize_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class