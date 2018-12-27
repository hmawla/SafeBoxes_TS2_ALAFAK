Public Class Frm_NewConnects
    Dim infoVouchid As Integer
    Dim EmpId As Integer
    Dim ds As New DataSet
    Dim answer As Integer
    Dim result As Integer

    Private Sub Frm_Connects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoVouchid = Frm_main.infovouchid
        EmpId = Frm_main.loggedEmpId
        Lbl_infovId.Text = "InfoVoucher ID: " & infoVouchid
        Lbl_EmpId.Text = "Employee ID: " & EmpId
        Me.MinimumSize = New Size(407, 327)
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If Rdb_AnswerY.Checked Then
            answer = 1
        Else
            answer = 0
        End If
        If Rdb_ResultY.Checked Then
            result = 1
        Else
            result = 0
        End If
        If Chk_AnswerNote.Enabled Then
            If Txt_AnswerNote.Text.Count = 0 Then
                MessageBox.Show("Please enter a valid answer note!")
            Else
                Dim theNewId As Integer = GenID("Connects", "ConnectId")
                ExecuteQuery("INSERT INTO Connects VALUES(" & theNewId & ", date(), time()," & answer & ", " & result & ", " & infoVouchid & ", " & EmpId & ")")
                ExecuteQuery("INSERT INTO AnswerNote VALUES(" & theNewId & ", '" & Txt_AnswerNote.Text & "')")
                Me.Dispose()
            End If
        Else
            Dim theNewId As Integer = GenID("Connects", "ConnectId")
            ExecuteQuery("INSERT INTO Connects VALUES(" & theNewId & ", date(), time()," & answer & ", " & result & ", " & infoVouchid & ", " & EmpId & ")")
            Me.Dispose()
        End If
    End Sub

    Private Sub Rdb_AnswerY_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_AnswerY.CheckedChanged
        If Rdb_AnswerY.Checked Then
            Chk_AnswerNote.Enabled = True
        Else
            Chk_AnswerNote.Checked = False
            Chk_AnswerNote.Enabled = False
        End If
    End Sub

    Private Sub Chk_AnswerNote_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_AnswerNote.CheckedChanged
        If Chk_AnswerNote.Checked Then
            Txt_AnswerNote.Enabled = True
            Txt_AnswerNote.Focus()
        Else
            Txt_AnswerNote.Enabled = False
            Txt_AnswerNote.Text = ""
        End If
    End Sub
End Class