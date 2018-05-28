Imports System.IO
Public Class Frm_newSignature
    Dim theNewId As Integer
    Private Sub Frm_newSignature_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txt_clientid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clientid.KeyPress
        Only_Number(txt_clientid, e)
    End Sub

    Private Sub txt_clientid_TextChanged(sender As Object, e As EventArgs) Handles txt_clientid.TextChanged
        Try
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName FROM Clients WHERE ClientId = " & txt_clientid.Text)
            txt_clientname.Text = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            txt_clientname.Text = ""
        End Try

    End Sub

    Private Sub Btn_ArabicBrowse_Click(sender As Object, e As EventArgs) Handles Btn_ArabicBrowse.Click
        Dim fd As New OpenFileDialog()
        fd.Title = "Select Signature file"
        fd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.*)|*.png"
        fd.Multiselect = False
        fd.RestoreDirectory = True
        If fd.ShowDialog = DialogResult.OK Then
            Txt_ArabicFile.Text = fd.FileName
        End If
    End Sub

    Private Sub Btn_LatinBrowse_Click(sender As Object, e As EventArgs) Handles Btn_LatinBrowse.Click
        Dim fd As New OpenFileDialog()
        fd.Title = "Select Signature file"
        fd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.*)|*.png"
        fd.Multiselect = False
        fd.RestoreDirectory = True
        If fd.ShowDialog = DialogResult.OK Then
            Txt_LatinFile.Text = fd.FileName
        End If
    End Sub

    Private Sub Rdb_Arabic_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Arabic.CheckedChanged
        If Rdb_Arabic.Checked Then
            Txt_ArabicFile.Enabled = True
            Btn_ArabicBrowse.Enabled = True
            Txt_LatinFile.Enabled = False
            Btn_LatinBrowse.Enabled = False
        Else
            Txt_ArabicFile.Enabled = False
            Btn_ArabicBrowse.Enabled = False
            Txt_LatinFile.Enabled = True
            Btn_LatinBrowse.Enabled = True
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        theNewId = GenID("Signatures", "SignId")
        addNewSignature(File.ReadAllBytes(Txt_ArabicFile.Text))
        Dim ds As New DataSet
        ds = ReadQueryOut("SELECT SignArabic FROM Signatures")
        File.WriteAllBytes("d:/file.jpg", ds.Tables(0).Rows(0).Item(0))
    End Sub
End Class