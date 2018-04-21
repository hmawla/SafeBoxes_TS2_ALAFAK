Public Class Frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitCon()
        Dim ds As DataSet

        Try
            ExecuteQuery("INSERT INTO Contract(ContId,ContNote,ContFloor) VALUES(1,'Just a test', 3)")
            ds = ReadQueryOut("SELECT ContId, ContNote, ContFloor FROM Contract WHERE ContId = " & 1)
            MsgBox(ds.Tables(0).Rows(0).Item(0))
            MsgBox(ds.Tables(0).Rows(0).Item(1))
            MsgBox(ds.Tables(0).Rows(0).Item(2))
            ds.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        frm_newContract.Show()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Frm_SelectAccount.Show()
    End Sub
End Class
