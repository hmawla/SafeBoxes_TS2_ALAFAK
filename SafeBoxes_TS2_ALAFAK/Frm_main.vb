Public Class Frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitCon()
        Dim ds As DataSet
        ds = ReadQueryOut("SELECT * FROM TestTable")
        MsgBox(ds.Tables(0).Rows.Count)
        ds.Clear()

        ds = ReadQueryOut("SELECT * FROM TestTable")
        MsgBox(ds.Tables(0).Rows(0).Item(1))
        ds.Clear()



        Try
            ExecuteQuery("INSERT INTO TestTable VALUES(5,'Just a test', 'and it worked')")
            ds = ReadQueryOut("SELECT * FROM TestTable WHERE ID = 5")
            MsgBox(ds.Tables(0).Rows(0).Item(1))
            MsgBox(ds.Tables(0).Rows(0).Item(2))
            ds.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class
