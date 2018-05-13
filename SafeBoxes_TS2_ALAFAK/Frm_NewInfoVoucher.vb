Public Class Frm_NewInfoVoucher
    Dim formLoaded As Boolean = False
    Dim check
    Dim theNewId As Integer
    Dim isSubmitting As Boolean = False
    Private Sub Frm_NewInfoVoucher_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_subjecttitles, "SELECT InfoSubjTitleId, InfoSubjTitle FROM InfoSubjectTitles", "InfoSubjTitleId", "InfoSubjTitle")
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        FillCheckList(chklist_exceptdays, "SELECT * FROM Days", "DayId", "DayName")
        If Frm_InfoVoucher.infovouchId = 0 Then
            theNewId = GenID("InfoVoucher", "InfoVouchId")
            ExecuteQuery("INSERT INTO InfoVoucher(InfoVouchId) VALUES(" & theNewId & ")")
        Else
            theNewId = Frm_InfoVoucher.infovouchId
            Dim theContDetails As New DataSet
            theContDetails = ReadQueryOut("SELECT * FROM InfoVoucher WHERE InfoVouchId = " & theNewId)
            Dim rows As DataRow = theContDetails.Tables(0).Rows(0)
            dtpick_fromtime.Value = rows.Item(1)
            dtpick_totime.Value = rows.Item(2)
            txt_subjectbody.Text = rows.Item(4)
            txt_contractid.Text = rows.Item(5)
            txt_clientid.Text = rows.Item(8)
            Dim theBuilding As String = rows.Item(6)
            Dim theinfosubjecttitleid As String = rows.Item(7)
            theContDetails.Reset()
            theContDetails = ReadQueryOut("SELECT BuildingId, Streets.StreetId, RegionId FROM Buildings, Streets WHERE BuildingId = " & theBuilding)
            rows = theContDetails.Tables(0).Rows(0)
            cbox_regions.SelectedValue = rows.Item(2)
            cbox_streets.SelectedValue = rows.Item(1)
            cbox_buildings.SelectedValue = rows.Item(0)
            theContDetails.Reset()
            theContDetails = ReadQueryOut("SELECT InfoSubjTitleId, InfoSubjTitle FROM InfoSubjectTitles WHERE InfoSubjTitleId = " & theinfosubjecttitleid)
            rows = theContDetails.Tables(0).Rows(0)
            cbox_subjecttitles.SelectedValue = rows.Item(0)
        End If
        formLoaded = True
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click
        Frm_main.clientid = 0
        Frm_SelectClient.ShowDialog()
        txt_clientid.Text = Frm_main.clientid
    End Sub

    Private Sub txt_clientid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clientid.KeyPress
        Only_Number(txt_clientid, e)
    End Sub

    Private Sub txt_clientid_Leave(sender As Object, e As EventArgs) Handles txt_clientid.Leave
        If txt_clientid.Text <> "" Then
            If Exists(txt_clientid.Text, "SELECT ClientId FROM Clients") Then
                Dim ds As New DataSet
                ds = ReadQueryOut("SELECT ClientFName + ' ' + ClientLName FROM Clients WHERE ClientId = " & txt_clientid.Text)
                txt_clientname.Text = ds.Tables(0).Rows(0).Item(0)
            Else
                MessageBox.Show("Invalid Client ID!")
                txt_clientid.Focus()
                txt_clientid.SelectAll()
            End If
        Else
            MessageBox.Show("Invalid Client ID!")
            txt_clientid.Focus()
        End If
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

    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        Frm_main.clientid = 0
        Frm_NewClient.ShowDialog()
        txt_clientid.Text = Frm_main.clientid
        Frm_main.clientid = -1
    End Sub

    Private Sub ContraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContraToolStripMenuItem.Click
        Frm_main.contractid = 0
        MessageBox.Show("Double click on the desired contract to select it!")
        Frm_Contracts.ShowDialog()
        txt_contractid.Text = Frm_main.contractid
        Frm_main.contractid = -1
    End Sub

    Private Sub NewContractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewContractToolStripMenuItem.Click
        Frm_main.contractid = 0
        Frm_newContract.ShowDialog()
        txt_contractid.Text = Frm_main.contractid
        Frm_main.contractid = -1
    End Sub

    Private Sub txt_contractid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contractid.KeyPress
        Only_Number(txt_contractid, e)
    End Sub

    Private Sub dtpick_totime_ValueChanged(sender As Object, e As EventArgs) Handles dtpick_totime.ValueChanged, dtpick_fromtime.ValueChanged
        If dtpick_fromtime.Value >= dtpick_totime.Value Then
            MessageBox.Show("To time should be greater than from time !")
        End If
    End Sub

    Private Sub chk_phone_CheckedChanged(sender As Object, e As EventArgs) Handles chk_phone.CheckedChanged
        Toggle(txt_phonenumber)
    End Sub

    Private Sub chk_mailpost_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mailpost.CheckedChanged
        Toggle(txt_mailpost)
    End Sub

    Private Sub chk_email_CheckedChanged(sender As Object, e As EventArgs) Handles chk_email.CheckedChanged
        Toggle(txt_email)
    End Sub

    Private Sub chk_other_CheckedChanged(sender As Object, e As EventArgs) Handles chk_other.CheckedChanged
        Toggle(txt_otherconn)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        isSubmitting = True
        ExecuteQuery("UPDATE InfoVoucher SET InfoVouchFromTime = '" & dtpick_fromtime.Value.ToShortTimeString & "',InfoVouchToTime = '" & dtpick_totime.Value.ToShortTimeString & "',InfoVouchDate = '" & Date.Today.ToShortDateString & "',SubjectDetails = '" & txt_subjectbody.Text & "',Contid = " & txt_contractid.Text & ",BuildingId = " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ",InfoSubjTitleId = " & cbox_subjecttitles.SelectedValue & ",ClientId = " & txt_clientid.Text & " WHERE InfoVouchId = " & theNewId)

        'For Each indexChecked In chklist_exceptdays.CheckedIndices
        '    ExecuteQuery("INSERT INTO InfoVoucherExDays Values(" & theNewId & ", " & (Int(indexChecked.ToString()) + 1) & ")")
        'Next


        'If chk_phone.Checked Then
        '    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 1, '" & txt_phonenumber.Text & "')")
        'End If
        'If chk_mailpost.Checked Then
        '    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 2, '" & txt_mailpost.Text & "')")
        'End If
        'If chk_email.Checked Then
        '    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 3, '" & txt_email.Text & "')")
        'End If
        'If chk_other.Checked Then
        '    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 4, '" & txt_otherconn.Text & "')")
        'End If
        Me.Close()
    End Sub

    Private Sub Frm_NewInfoVoucher_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If isSubmitting = False And Frm_InfoVoucher.infovouchId = 0 Then
            ExecuteQuery("DELETE FROM InfoVoucher WHERE InfoVoucherId = " & theNewId)
        End If
    End Sub

    Private Sub cbox_subjecttitles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_subjecttitles.KeyPress
        Only_char(cbox_subjecttitles, e)
    End Sub

    Private Sub cbox_regions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_regions.KeyPress
        Only_char(cbox_regions, e)
    End Sub

    Private Sub cbox_streets_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_streets.KeyPress
        Only_char(cbox_streets, e)
    End Sub

    Private Sub cbox_buildings_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbox_buildings.KeyPress
        Only_char(cbox_buildings, e)
    End Sub

    Private Sub txt_phonenumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phonenumber.KeyPress
        Only_Number(txt_phonenumber, e)
    End Sub

    Private Sub txt_mailpost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mailpost.KeyPress
        Only_Number(txt_mailpost, e)
    End Sub
End Class