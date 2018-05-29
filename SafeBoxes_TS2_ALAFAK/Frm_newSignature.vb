﻿Imports System.IO
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
        theNewId = GenID("Signatures", "SignId")
        If Chk_arb.Checked = True And chk_lat.Checked = False Then
            addNewSignaturear(theNewId, File.ReadAllBytes(Txt_ArabicFile.Text), File.ReadAllBytes(Txt_LatinFile.Text), 1, Date.Now, txt_clientid.Text, 1)
            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT SignArabic FROM Signatures")
        ElseIf chk_lat.Checked = True And Chk_arb.Checked = False Then
            addNewSignaturelat(theNewId, File.ReadAllBytes(Txt_ArabicFile.Text), File.ReadAllBytes(Txt_LatinFile.Text), 1, Date.Now, txt_clientid.Text, 1)

            Dim ds As New DataSet
            ds = ReadQueryOut("SELECT SignLatin FROM Signatures")
        End If

    End Sub

    Private Sub txt_clientname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clientname.KeyPress
        Only_char(txt_clientname, e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_arb.CheckedChanged

    End Sub


End Class