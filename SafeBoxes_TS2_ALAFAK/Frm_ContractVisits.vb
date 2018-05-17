Public Class Frm_ContractVisits
    Dim ContId As Integer
    Dim EmpId As Integer
    Dim ds As New DataSet
    Private Sub Frm_ContractVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContId = Frm_main.contractid
        EmpId = Frm_main.loggedEmpId
        Lbl_ContId.Text = "Contract ID: " & ContId
        Lbl_EmpId.Text = "Employee ID: " & EmpId
    End Sub

    Private Sub ClientMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ClientMenuStrip.Opening
        Frm_main.clientid = 0
        Frm_Clients.ShowDialog()
        Txt_ClientId.Text = Frm_main.clientid
    End Sub

    Private Sub Txt_ClientId_TextChanged(sender As Object, e As EventArgs) Handles Txt_ClientId.TextChanged
        Try
            ds = ReadQueryOut("SELECT ClientId, ClientFName + ' ' + ClientLName, ClientDOB FROM Clients WHERE ClientId = " & Txt_ClientId.Text)
            Txt_ClientName.Text = ds.Tables(0).Rows(0).Item(1)
        Catch ex As Exception
            Txt_ClientName.Text = ""
        End Try

    End Sub

    Private Sub Txt_ClientName_TextChanged(sender As Object, e As EventArgs) Handles Txt_ClientName.TextChanged
        If Not Txt_ClientName.Text = "" Then
            Btn_Add.Enabled = Enabled
        Else
            Btn_Add.Enabled = False
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        If txt_note.Text <> "" Then
            For i As Integer = 0 To DGV_Visits.Rows.Count - 1
                If Txt_ClientId.Text = DGV_Visits.Rows(i).Cells(0).Value Then
                    MessageBox.Show("Client Already Added!")
                    GoTo the_End
                End If
            Next
            ds = ReadQueryOut("SELECT ClientId, ClientFName + ' ' + ClientLName, ClientDOB FROM Clients WHERE ClientId = " & Txt_ClientId.Text)
            Dim theDate As Date = ds.Tables(0).Rows(0).Item(2)

            DGV_Visits.Rows.Add(ds.Tables(0).Rows(0).Item(0), ds.Tables(0).Rows(0).Item(1), theDate.ToShortDateString())
the_End:
        Else
            MessageBox.Show("Kindly insert a note first <3 :* mwah")
        End If

    End Sub

    Private Sub DGV_Visits_SelectionChanged(sender As Object, e As EventArgs)
        If DGV_Visits.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        If DGV_Visits.Rows.Count > 0 Then
            DGV_Visits.Rows.RemoveAt(DGV_Visits.SelectedRows(0).Index)
        Else
            MessageBox.Show("Please select a row!")
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Dim theNewId As Integer = GenID("Visits", "VisitId")
        Dim theNewvId As Integer = GenID("VisitNotes", "VisitNoteId")
        ExecuteQuery("INSERT INTO Visits VALUES(" & theNewId & ", date(), date(), " & ContId & ", " & EmpId & ")")
        ExecuteQuery("INSERT INTO VisitsVisitNotes VALUES(" & theNewId & ",'" & theNewvId & "')")
        ExecuteQuery("INSERT INTO VisitNotes VALUES(" & theNewvId & ",'" & txt_note.Text & "')")

        For i As Integer = 0 To DGV_Visits.Rows.Count - 1
            ExecuteQuery("INSERT INTO ClientVisit VALUES(" & DGV_Visits.Rows(i).Cells(0).Value & ", " & theNewId & ")")
        Next
        Me.Dispose()
    End Sub

    Private Sub SelectDifferentEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectDifferentEmployeeToolStripMenuItem.Click
        Frm_main.employeeid = 0
        Frm_Employees.ShowDialog()
        EmpId = Frm_main.employeeid
        Lbl_EmpId.Text = "Employee ID: " & EmpId
    End Sub

    Private Sub Txt_ClientId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ClientId.KeyPress
        Only_Number(Txt_ClientId, e)
    End Sub

    Private Sub DGV_Visits_SelectionChanged_1(sender As Object, e As EventArgs) Handles DGV_Visits.SelectionChanged
        If DGV_Visits.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub
End Class