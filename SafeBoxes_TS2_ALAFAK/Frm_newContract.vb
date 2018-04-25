Imports System.ComponentModel

Public Class frm_newContract
    Dim ds As DataSet
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False

    Private Sub SelectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAccountToolStripMenuItem.Click
        Frm_SelectAccount.ShowDialog()
    End Sub

    Private Sub txt_accountid_Leave(sender As Object, e As EventArgs) Handles txt_accountid.Leave
        ds.Reset()
        txt_clientinfo.Text = ""
        Dim i As Integer = 1
        Try
            ds = ReadQueryOut("SELECT c.ClientId, ClientFName, ClientLName, ClientDOB FROM Clients c, ClientDepAccount a WHERE c.ClientId = a.ClientId AND a.accountid = " & txt_accountid.Text)
            If ds.Tables(0).Rows.Count <> 0 Then
                For Each datarow As DataRow In ds.Tables(0).Rows
                    txt_clientinfo.Text = txt_clientinfo.Text & "(" & i & ")" & vbNewLine & "Client ID: " & datarow.Item(0) & vbNewLine & "Client Name: " & datarow.Item(1) & " " & datarow.Item(2) & vbNewLine & "BirthDate: " & datarow.Item(3) & vbNewLine & vbNewLine
                    i = i + 1
                Next
            Else
                MsgBox("Invalid Account ID!")
                txt_accountid.Focus()
                txt_accountid.SelectAll()
            End If

        Catch ex As Exception
            MsgBox("Invalid Account ID!")
            txt_accountid.Focus()
            txt_accountid.SelectAll()
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        isSubmitting = True
        Me.Close()
    End Sub

    Private Sub frm_newContract_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSubmitting = False Then
            ExecuteQuery("DELETE FROM Contract WHERE ContId = " & theNewId)
        End If

    End Sub

    Private Sub frm_newContract_Load(sender As Object, e As EventArgs) Handles Me.Load
        ds = ReadQueryOut("SELECT MAX(ContId) FROM Contract")
        theNewId = ds.Tables(0).Rows(0).Item(0) + 1
        ds.Reset()
        ds = ReadQueryOut("SELECT BuildingName FROM Buildings")
        For Each datarow As DataRow In ds.Tables(0).Rows
            cbox_buildings.Items.Add(datarow.Item(0))
        Next
        Try
            ExecuteQuery("INSERT INTO CONTRACT(ContId) VALUES(" & theNewId & ")")
            lbl_contractid.Text = "Contract ID: " & theNewId
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cbox_buildings.SelectedIndex = 0
    End Sub
End Class