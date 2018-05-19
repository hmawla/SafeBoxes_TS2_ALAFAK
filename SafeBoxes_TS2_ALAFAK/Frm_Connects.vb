Public Class Frm_Connects
    Dim infoVouchid As Integer
    Dim EmpId As Integer
    Dim ds As New DataSet
    Dim Ans As String = "no"
    Dim Res As String = "no"
    Private Sub Frm_Connects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoVouchid = Frm_main.infovouchid
        EmpId = Frm_main.loggedEmpId
        Lbl_infovId.Text = "InfoVoucher ID: " & infoVouchid
        Lbl_EmpId.Text = "Employee ID: " & EmpId
        Try
            ds = ReadQueryOut("SELECT EmpId, EmpFName + ' ' + EmpLName FROM Employees WHERE EmpId = " & EmpId)
            Txt_EmpName.Text = ds.Tables(0).Rows(0).Item(1)
        Catch ex As Exception
            Txt_EmpName.Text = ""
        End Try
    End Sub

    Private Sub DGV_Visits_SelectionChanged(sender As Object, e As EventArgs)
        If DGV_Connects.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub

    Private Sub DGV_Visits_SelectionChanged_1(sender As Object, e As EventArgs) Handles DGV_Connects.SelectionChanged
        If DGV_Connects.Rows.Count > 0 Then
            Btn_Submit.Enabled = True
        Else
            Btn_Submit.Enabled = False
        End If
    End Sub

    Private Sub Btn_Connects_Click(sender As Object, e As EventArgs) Handles Btn_Connects.Click
        If txt_note.Text <> "" Then

            DGV_Connects.Rows.Add(infoVouchid, Ans, txt_note.Text, Res, Txt_EmpName.Text)

        Else
            MessageBox.Show("Insert a note first !")
        End If
        Ans = "no"
        Res = "no"
        RadioButton2.Checked = True
        RadioButton3.Checked = True
        txt_note.Text = "No Answer"
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        For i As Integer = 0 To DGV_Connects.Rows.Count - 1
            Dim theNewId As Integer = GenID("Connects", "ConnectId")
            ExecuteQuery("INSERT INTO Connects VALUES(" & theNewId & ", date(), date(), " & DGV_Connects.Rows(i).Cells(1).Value & ", " & DGV_Connects.Rows(i).Cells(3).Value & ", " & infoVouchid & ", " & EmpId & ")")
            ExecuteQuery("INSERT INTO AnswerNote VALUES(" & theNewId & ", date(), date(), " & DGV_Connects.Rows(i).Cells(1).Value & ", " & DGV_Connects.Rows(i).Cells(3).Value & ", '" & DGV_Connects.Rows(i).Cells(2).Value & "', " & infoVouchid & ", " & EmpId & ")")
        Next
        Me.Dispose()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Ans = "yes"
            txt_note.Text = ""
            GroupBox2.Enabled = True
            txt_note.Enabled = True
        Else
            Ans = "no"
            txt_note.Text = "No Answer"
            txt_note.Enabled = False
            GroupBox2.Enabled = False
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged
        If RadioButton4.Checked Then
            Res = "yes"
        Else
            Res = "no"
        End If
    End Sub
End Class