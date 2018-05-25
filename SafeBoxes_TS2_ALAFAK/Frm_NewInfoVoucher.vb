Public Class Frm_NewInfoVoucher
    Dim formLoaded As Boolean = False
    Dim check
    Dim theNewId As Integer
    Private Sub Frm_NewInfoVoucher_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBox(cbox_subjecttitles, "SELECT InfoSubjTitleId, InfoSubjTitle FROM InfoSubjectTitles", "InfoSubjTitleId", "InfoSubjTitle")
        FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
        FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
        FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
        FillCheckList(chklist_exceptdays, "SELECT * FROM Days", "DayId", "DayName")
        If Not Frm_InfoVoucher.infovouchId = 0 Then
            theNewId = Frm_InfoVoucher.infovouchId
            Dim theMainDetails As New DataSet
            theMainDetails = ReadQueryOut("SELECT InfoVouchFromTime, InfoVouchToTime, SubjectDetails, ContId, ClientId, InfoSubjTitleId, BuildingId FROM InfoVoucher WHERE InfoVouchId = " & theNewId).Copy
            Dim rows As DataRow = theMainDetails.Tables(0).Rows(0)
            dtpick_fromtime.Value = rows.Item(0)
            dtpick_totime.Value = rows.Item(1)
            txt_subjectbody.Text = rows.Item(2)
            txt_contractid.Text = rows.Item(3)
            txt_clientid.Text = rows.Item(4)
            cbox_subjecttitles.SelectedValue = rows.Item(5)
            Dim theBuildingDetails As New DataSet
            theMainDetails = ReadQueryOut("SELECT RegionId, S.StreetId FROM Buildings B, Streets S WHERE B.StreetId = S.StreetId AND BuildingId = " & rows.Item(6)).Copy
            cbox_regions.SelectedValue = theMainDetails.Tables(0).Rows(0).Item(0)
            FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
            cbox_streets.SelectedValue = theMainDetails.Tables(0).Rows(0).Item(1)
            FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
            cbox_buildings.SelectedValue = rows.Item(6)
            Dim theConnWaysDetails As New DataSet
            theConnWaysDetails = ReadQueryOut("SELECT ConnWayId, ConnWayText FROM ConnWaysInfoVoucher WHERE InfoVouchId = " & theNewId).Copy
            For Each row As DataRow In theConnWaysDetails.Tables(0).Rows
                If row.Item(0) = 1 Then
                    chk_phone.Checked = True
                    txt_phonenumber.Text = row.Item(1)
                ElseIf row.Item(0) = 2 Then
                    chk_mailpost.Checked = True
                    txt_mailpost.Text = row.Item(1)
                ElseIf row.Item(0) = 3 Then
                    chk_email.Checked = True
                    txt_email.Text = row.Item(1)
                Else
                    chk_other.Checked = True
                    txt_otherconn.Text = row.Item(1)
                End If
            Next
            Dim theDaysDetails As New DataSet
            theDaysDetails = ReadQueryOut("SELECT DayId FROM InfoVoucherExDays WHERE InfoVouchId = " & theNewId).Copy
            For Each row As DataRow In theDaysDetails.Tables(0).Rows

                chklist_exceptdays.SetItemChecked(row.Item(0) - 1, True)
            Next
        End If
        formLoaded = True
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem1.Click
        Frm_main.clientid = 0
        MessageBox.Show("Double click on the desired client to select it!")
        Frm_SelectClient.ShowDialog()
        txt_clientid.Text = Frm_main.clientid
        Frm_main.clientid = -1
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

    Private Sub ContraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectContractToolStripMenuItem.Click
        Frm_main.contractid = 0
        MessageBox.Show("Double click on the desired contract to select it!")
        Frm_Contracts.ShowDialog()
        txt_contractid.Text = Frm_main.contractid
        Frm_main.contractid = -1
    End Sub

    Private Sub txt_contractid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contractid.KeyPress
        Only_Number(txt_contractid, e)
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
        If txt_clientname.Text.Count > 0 Then
            If Exists(txt_contractid.Text, "SELECT ContId FROM Contract WHERE ContId NOT IN (SELECT ContId FROM ContEnd) And ContToDate > date()") Then
                If txt_subjectbody.Text.Count > 0 Then
                    If Frm_InfoVoucher.infovouchId = 0 Then
                        If txt_phonenumber.Text.Count > 0 Or txt_email.Text.Count > 0 Or txt_mailpost.Text.Count > 0 Or txt_otherconn.Text.Count > 0 Then
                            If dtpick_fromtime.Value.TimeOfDay > dtpick_totime.Value.TimeOfDay Then
                                MessageBox.Show("To time should be greater than from time!")
                            Else
                                Dim subjTitleId As Integer = cbox_subjecttitles.SelectedValue
                                If cbox_subjecttitles.SelectedIndex < 0 Then
                                    subjTitleId = GenID("InfoSubjectTitles", "InfoSubjTitleId")
                                    ExecuteQuery("INSERT INTO InfoSubjectTitles VALUES(" & subjTitleId & ", '" & cbox_subjecttitles.Text & "')")
                                End If
                                theNewId = GenID("InfoVoucher", "InfoVouchId")
                                ExecuteQuery("INSERT INTO InfoVoucher VALUES(" & theNewId & ", '" & dtpick_fromtime.Value.ToShortTimeString & "', '" & dtpick_totime.Value.ToShortTimeString & "', date(), '" & txt_subjectbody.Text & "', " & txt_contractid.Text & ", " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ", " & subjTitleId & ", " & txt_clientid.Text & ")")

                                For Each indexChecked In chklist_exceptdays.CheckedIndices
                                    ExecuteQuery("INSERT INTO InfoVoucherExDays Values(" & theNewId & ", " & (Int(indexChecked.ToString()) + 1) & ")")
                                Next
                                If chk_phone.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 1, '" & txt_phonenumber.Text & "')")
                                End If
                                If chk_mailpost.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 2, '" & txt_mailpost.Text & "')")
                                End If
                                If chk_email.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 3, '" & txt_email.Text & "')")
                                End If
                                If chk_other.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 4, '" & txt_otherconn.Text & "')")
                                End If
                                Me.Dispose()
                            End If
                        Else
                            MessageBox.Show("Enter at least one connection way!")
                        End If
                    Else
                        If txt_phonenumber.Text.Count > 0 Or txt_email.Text.Count > 0 Or txt_mailpost.Text.Count > 0 Or txt_otherconn.Text.Count > 0 Then
                            If dtpick_fromtime.Value.TimeOfDay > dtpick_totime.Value.TimeOfDay Then
                                MessageBox.Show("To time should be greater than from time!")
                            Else
                                ExecuteQuery("UPDATE InfoVoucher SET InfoVouchFromTime = '" & dtpick_fromtime.Value.ToShortTimeString & "',InfoVouchToTime = '" & dtpick_totime.Value.ToShortTimeString & "',InfoVouchDate = '" & Date.Today.ToShortDateString & "',SubjectDetails = '" & txt_subjectbody.Text & "',Contid = " & txt_contractid.Text & ",BuildingId = " & AddBuilding(cbox_regions, cbox_streets, cbox_buildings) & ",InfoSubjTitleId = " & cbox_subjecttitles.SelectedValue & ",ClientId = " & txt_clientid.Text & " WHERE InfoVouchId = " & theNewId)
                                ExecuteQuery("DELETE FROM InfoVoucherExDays WHERE InfoVouchId = " & theNewId)
                                ExecuteQuery("DELETE FROM ConnWaysInfoVoucher WHERE InfoVouchId = " & theNewId)
                                For Each indexChecked In chklist_exceptdays.CheckedIndices
                                    ExecuteQuery("INSERT INTO InfoVoucherExDays Values(" & theNewId & ", " & (Int(indexChecked.ToString()) + 1) & ")")
                                Next
                                If chk_phone.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 1, '" & txt_phonenumber.Text & "')")
                                End If
                                If chk_mailpost.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 2, '" & txt_mailpost.Text & "')")
                                End If
                                If chk_email.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 3, '" & txt_email.Text & "')")
                                End If
                                If chk_other.Checked Then
                                    ExecuteQuery("INSERT INTO ConnWaysInfoVoucher Values(" & theNewId & ", 4, '" & txt_otherconn.Text & "')")
                                End If
                                Me.Dispose()
                            End If
                        Else
                            MessageBox.Show("Enter at least one connection way!")
                        End If
                    End If
                Else
                    MessageBox.Show("Please enter subject details!")
                End If

            Else
                MessageBox.Show("Invalid contract ID!")
            End If
        Else
            MessageBox.Show("Invalid client ID!")
        End If



    End Sub

    Private Sub Frm_NewInfoVoucher_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
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

    Private Sub ModifyTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyTitleToolStripMenuItem.Click
        If cbox_subjecttitles.SelectedIndex >= 0 Then
            InputBox.Show("Modify subject title's Name:", "Modify subject title#" & cbox_subjecttitles.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE InfoSubjectTitles SET InfoSubjTitle = '" & inResult & "' WHERE InfoSubjTitleId = " & cbox_subjecttitles.SelectedValue)
                    FillCBox(cbox_subjecttitles, "SELECT InfoSubjTitleId, InfoSubjTitle FROM InfoSubjectTitles", "InfoSubjTitleId", "InfoSubjTitle")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteSubjectTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSubjectTitleToolStripMenuItem.Click
        If cbox_subjecttitles.SelectedIndex >= 0 Then
            InputBox.Show("Please enter admin password!" & vbNewLine & "All records that contains this title will be deleted!", "Delete region#" & cbox_subjecttitles.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM InfoSubjectTitles WHERE InfoSubjTitleId = " & cbox_regions.SelectedValue)
                    ExecuteQuery("DELETE FROM InfoVoucher WHERE InfoSubjTitleId = " & cbox_regions.SelectedValue)
                    FillCBox(cbox_subjecttitles, "SELECT InfoSubjTitleId, InfoSubjTitle FROM InfoSubjectTitles", "InfoSubjTitleId", "InfoSubjTitle")
                Else
                    MessageBox.Show("Invalid password!")
                End If
            End If
        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub ModifySelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifySelectedToolStripMenuItem.Click
        If cbox_buildings.SelectedValue > 0 Then
            InputBox.Show("Modify building's Name:", "Modify building#" & cbox_buildings.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE Buildings SET BuildingName = '" & inResult & "' WHERE BuildingId = " & cbox_buildings.SelectedValue)
                    FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteBuildingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBuildingToolStripMenuItem.Click
        If cbox_buildings.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!", "Delete building#" & cbox_buildings.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM Buildings WHERE BuildingId = " & cbox_buildings.SelectedValue)
                    FillCBox(cbox_buildings, "SELECT BuildingId, BuildingName FROM Buildings WHERE StreetId = " & cbox_streets.SelectedValue, "BuildingId", "BuildingName")
                Else
                    MessageBox.Show("Invalid password!")
                End If
            End If


        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub ModifyRegionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyRegionToolStripMenuItem.Click
        If cbox_regions.SelectedValue > 0 Then
            InputBox.Show("Modify region's Name:", "Modify region#" & cbox_regions.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE Regions SET RegionName = '" & inResult & "' WHERE RegionId = " & cbox_regions.SelectedValue)
                    FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteRegionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRegionToolStripMenuItem.Click
        If cbox_regions.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!" & vbNewLine & "All buildings and streets belonging to this region will be deleted!", "Delete region#" & cbox_regions.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM Regions WHERE RegionId = " & cbox_regions.SelectedValue)
                    ExecuteQuery("DELETE FROM Buildings WHERE StreetId IN (SELECT StreetId FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue & ")")
                    ExecuteQuery("DELETE FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue)
                    FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                Else
                    MessageBox.Show("Invalid password!")
                End If
            End If
        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub

    Private Sub ModifyStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyStreetToolStripMenuItem.Click
        If cbox_streets.SelectedValue > 0 Then
            InputBox.Show("Modify street's Name:", "Modify street#" & cbox_streets.SelectedValue)
            If inResult.Count > 0 Then
                If Not inResult.Equals("0") Then
                    ExecuteQuery("UPDATE Streets SET StreetName = '" & inResult & "' WHERE StreetId = " & cbox_streets.SelectedValue)
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                End If
            Else
                MessageBox.Show("Invalid name!")
            End If
        Else
            MessageBox.Show("Please select before modifying!")
        End If
    End Sub

    Private Sub DeleteStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStreetToolStripMenuItem.Click
        If cbox_streets.SelectedValue > 0 Then
            InputBox.Show("Please enter admin password!" & vbNewLine & "All buildings belonging to this street will be deleted!", "Delete street#" & cbox_streets.SelectedValue, True)
            If Not inResult.Equals("0") Then
                If inResult = "12345" Then
                    ExecuteQuery("DELETE FROM Buildings WHERE StreetId  = " & cbox_streets.SelectedValue)
                    ExecuteQuery("DELETE FROM Streets WHERE StreetId = " & cbox_streets.SelectedValue)
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                End If
            End If
        Else
            MessageBox.Show("Please select before deleting!")
        End If
    End Sub
End Class