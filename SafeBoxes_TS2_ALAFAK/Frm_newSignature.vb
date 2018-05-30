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

    Private Sub Rdb_Arabic_CheckedChanged(sender As Object, e As EventArgs)
        If Chk_arb.Checked Then
            Txt_ArabicFile.Enabled = True
            Btn_ArabicBrowse.Enabled = True
            Txt_LatinFile.Enabled = False
            Btn_LatinBrowse.Enabled = False
        ElseIf chk_lat.Checked Then
            Txt_ArabicFile.Enabled = False
            Btn_ArabicBrowse.Enabled = False
            Txt_LatinFile.Enabled = True
            Btn_LatinBrowse.Enabled = True
        ElseIf chk_lat.Checked And Chk_arb.Checked Then
            Txt_ArabicFile.Enabled = True
            Btn_ArabicBrowse.Enabled = True
            Txt_LatinFile.Enabled = True
            Btn_LatinBrowse.Enabled = True
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Dim ds1 As New DataSet
        ds1 = ReadQueryOut("SELECT COUNT(SignType) from Signatures WHERE SignCardId=" & txt_signc.Text)
        Dim type As Integer = ds1.Tables(0).Rows(0).Item(0)
        theNewId = GenID("Signatures", "SignId")

        If type > 3 Then
            MessageBox.Show("sign type :" & type & "has been inserted successfully")
            MessageBox.Show("you reached the max sign types")
        Else
            If Chk_arb.Checked = True And chk_lat.Checked = False Then
                addNewSignaturear(theNewId, File.ReadAllBytes(Txt_ArabicFile.Text), File.ReadAllBytes(Txt_ArabicFile.Text), type, Date.Now, txt_clientid.Text, txt_signc.Text)
                Dim ds As New DataSet
                ds = ReadQueryOut("SELECT SignArabic FROM Signatures")
            ElseIf chk_lat.Checked = True And Chk_arb.Checked = False Then
                addNewSignaturelat(theNewId, File.ReadAllBytes(Txt_LatinFile.Text), File.ReadAllBytes(Txt_LatinFile.Text), type, Date.Now, txt_clientid.Text, txt_signc.Text)

                Dim ds As New DataSet
                ds = ReadQueryOut("SELECT SignLatin FROM Signatures")
            ElseIf chk_lat.Checked = True And Chk_arb.Checked = True Then
                addNewSignatureboth(theNewId, File.ReadAllBytes(Txt_ArabicFile.Text), File.ReadAllBytes(Txt_LatinFile.Text), type, Date.Now, txt_clientid.Text, txt_signc.Text)

            End If
        End If


    End Sub

    Private Sub txt_clientname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clientname.KeyPress
        Only_char(txt_clientname, e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_arb.CheckedChanged
        If Chk_arb.Checked Then
            Btn_ArabicBrowse.Enabled = True
        Else
            Btn_ArabicBrowse.Enabled = False
            Txt_ArabicFile.Text = ""
        End If

    End Sub

    Private Sub chk_lat_CheckedChanged(sender As Object, e As EventArgs) Handles chk_lat.CheckedChanged
        If chk_lat.Checked Then
            Btn_LatinBrowse.Enabled = True
        Else
            Btn_LatinBrowse.Enabled = False
            Txt_LatinFile.Text = ""
        End If

    End Sub



    Private Sub txt_clientid_Leave(sender As Object, e As EventArgs) Handles txt_clientid.Leave
        Try
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName FROM Clients WHERE ClientId = " & txt_clientid.Text)
            txt_clientname.Text = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            txt_clientname.Text = ""
        End Try
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click

        Frm_main.clientid = 0
        Frm_Clients.ShowDialog()
        txt_clientid.Text = Frm_main.clientid

    End Sub

    Private Sub SelectSignnatureCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectSignnatureCardToolStripMenuItem.Click
        Frm_main.signatureCardId = 0
        Frm_main.clientid = txt_clientid.Text
        Frm_SignatureCards.ShowDialog()
        txt_signc.Text = Frm_main.signatureCardId
    End Sub
End Class