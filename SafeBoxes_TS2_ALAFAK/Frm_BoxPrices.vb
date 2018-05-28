Public Class Frm_BoxPrices
    Dim ds As New DataSet
    Dim InsPrice As Integer
    Dim RentPrice As Integer
    Dim formLoaded As Boolean = False

    Private Sub Frm_BoxPrices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBox(cbox_boxsizes, "SELECT SizeId,Length + 'cm x ' + Width + 'cm x ' + Height + 'cm' AS prop FROM BoxSizes", "SizeId", "prop") 'Fill the search combo box with all available sizes
        formLoaded = True
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Dim mss As New MessageBox
        If (Not Txt_InsPrice.Text.ToString.Equals(InsPrice.ToString)) Or (Not Txt_RentPrice.Text.ToString.Equals(RentPrice.ToString)) Then
            If Txt_InsPrice.Text.Count > 0 Or Txt_RentPrice.Text.Count > 0 Then
                ExecuteQuery("INSERT INTO BoxSizesDate VALUES(" & cbox_boxsizes.SelectedValue & ", date(), " & Txt_InsPrice.Text & ", " & Txt_RentPrice.Text & ")")
                Me.Dispose()
            Else
                MessageBox.Show("Please fill all needed information!")
            End If
        Else
            MessageBox.Show("No change!")
            Me.Dispose()
        End If
    End Sub

    Private Sub cbox_boxsizes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_boxsizes.SelectedIndexChanged
        If formLoaded Then
            ds = ReadQueryOut("SELECT BoxSizesDate.RentPrice, BoxSizesDate.InsurancePrice FROM ((Query1 INNER JOIN BoxSizesDate ON (Query1.MaxOfDate = BoxSizesDate.Date) AND (Query1.SizeId = BoxSizesDate.SizeId)) INNER JOIN BoxSizes ON Query1.SizeId = BoxSizes.SizeId) INNER JOIN Boxes ON BoxSizes.SizeId = Boxes.SizeId WHERE BoxSizesDate.SizeId = " & cbox_boxsizes.SelectedValue)
            RentPrice = ds.Tables(0).Rows(0).Item(0)
            InsPrice = ds.Tables(0).Rows(0).Item(1)
            Txt_RentPrice.Text = RentPrice
            Txt_InsPrice.Text = InsPrice
        End If
    End Sub
End Class