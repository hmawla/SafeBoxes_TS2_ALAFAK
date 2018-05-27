Public Class Frm_RenewContract
    Dim ContId As Integer
    Dim EmpId As Integer
    Dim ds As New DataSet
    Private Sub Frm_RenewContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(679, 464)
        ContId = Frm_main.contractid
        EmpId = Frm_main.loggedEmpId
        Lbl_ContId.Text = "Contract ID: " & ContId
        Lbl_EmpId.Text = "Employee ID: " & EmpId
        DTPick_Expire.Value = DateTime.Now.AddYears(1)
    End Sub

    Private Sub SelectClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectClientToolStripMenuItem.Click
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
        For i As Integer = 0 To DGV_Clients.Rows.Count - 1
            If Txt_ClientId.Text = DGV_Clients.Rows(i).Cells(0).Value Then
                MessageBox.Show("Client Already Added!")
                GoTo the_End
            End If
        Next
        ds = ReadQueryOut("SELECT ClientId, ClientFName + ' ' + ClientLName, ClientDOB FROM Clients WHERE ClientId = " & Txt_ClientId.Text)
        Dim theDate As Date = ds.Tables(0).Rows(0).Item(2)
        DGV_Clients.Rows.Add(ds.Tables(0).Rows(0).Item(0), ds.Tables(0).Rows(0).Item(1), theDate.ToShortDateString())
the_End:

    End Sub

    Private Sub DGV_Clients_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Clients.SelectionChanged
        If DGV_Clients.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        If DGV_Clients.Rows.Count > 0 Then
            DGV_Clients.Rows.RemoveAt(DGV_Clients.SelectedRows(0).Index)
        Else
            MessageBox.Show("Please select a row!")
        End If

    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Dim theNewId As Integer = GenID("Renew", "RenewId")
        ExecuteQuery("INSERT INTO Renew VALUES(" & theNewId & ", date(), '" & DTPick_Expire.Value.ToShortDateString & "', " & ContId & ", " & EmpId & ")")
        For i As Integer = 0 To DGV_Clients.Rows.Count - 1
            ExecuteQuery("INSERT INTO ClientsRenew VALUES(" & DGV_Clients.Rows(i).Cells(0).Value & ", " & theNewId & ")")
        Next
        ExecuteQuery("UPDATE Contract SET ContToDate = '" & DTPick_Expire.Value.ToShortDateString & "' WHERE ContId = " & ContId)
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

End Class