﻿Imports System.ComponentModel
Imports System.Data

Public Class frm_newContract
    Dim formLoaded As Boolean = False
    Dim ds As DataSet
    Dim anotherds As DataSet
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False
    Dim bs As New BindingSource

    Private Sub SelectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAccountToolStripMenuItem.Click
        Frm_main.accountid = 0
        Frm_SelectAccountClient.ShowDialog()
        txt_accountid.Text = Frm_main.accountid
    End Sub

    Private Sub txt_accountid_Leave(sender As Object, e As EventArgs) Handles txt_accountid.Leave
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
        If txt_accountid.Text = "" Or txt_boxes.Text = "" Or txt_floor.Text = "" Then
            MessageBox.Show("Please fill all needed information!")
        ElseIf txt_contnote.TextLength > 0 Then
            ExecuteQuery("UPDATE Contract SET AccountId = " & txt_accountid.Text & ", BoxId = " & txt_boxes.Text & ", BuildingId = " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", EmpId = " & Frm_main.employeeid & ", ContFloor = " & txt_floor.Value & ", ContBDate = '" & Date.Today.ToShortDateString & "', ContToDate = '" & dtpick_exdate.Value.ToShortDateString & "', ContPhone1 = '" & txt_phone1.Text & "', ContPhone2 = '" & txt_phone2.Text & "', ContNote = '" & txt_contnote.Text & "' WHERE ContId = " & theNewId)
            Frm_main.contractid = theNewId
            Me.Close()
        Else
            ExecuteQuery("UPDATE Contract SET AccountId = " & txt_accountid.Text & ", BoxId = " & txt_boxes.Text & ", BuildingId = " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", EmpId = " & Frm_main.employeeid & ", ContFloor = " & txt_floor.Value & ", ContBDate = '" & Date.Today.ToShortDateString & "', ContToDate = '" & dtpick_exdate.Value.ToShortDateString & "', ContPhone1 = '" & txt_phone1.Text & "', ContPhone2 = '" & txt_phone2.Text & "' WHERE ContId = " & theNewId)
            Frm_main.contractid = theNewId
            Me.Close()
        End If

    End Sub

    Private Sub frm_newContract_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSubmitting = False Then
            ExecuteQuery("DELETE FROM Contract WHERE ContId = " & theNewId)
        End If

    End Sub

    Private Sub frm_newContract_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        theNewId = genID("Contract", "ContId")
        ExecuteQuery("INSERT INTO Contract(ContId) VALUES(" & theNewId & ")")
        lbl_contractid.Text = "Contract ID: " & theNewId
        lbl_empid.Text = "Employee ID: " & Frm_main.employeeid
        formLoaded = True
    End Sub

    Private Sub SelectBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectBoxToolStripMenuItem.Click
        Frm_SelectBox.ShowDialog()
    End Sub

    Private Sub cbox_regions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_regions.SelectedIndexChanged
        If formLoaded Then
            FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        End If
    End Sub

    Private Sub cbox_streets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_streets.SelectedIndexChanged
        If formLoaded Then
            FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        End If
    End Sub

    Private Sub txt_accountid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_accountid.KeyPress
        Only_Number(txt_accountid, e)
    End Sub

    Private Sub txt_boxes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_boxes.KeyPress
        Only_Number(txt_boxes, e)
    End Sub
End Class