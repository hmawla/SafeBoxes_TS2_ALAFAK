Public Class Frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitCon()
        Dim ds As DataSet
        ds = ReadQueryOut("SELECT * FROM TestTable")
        MsgBox(ds.Tables(0).Rows.Count)
        ds = ReadQueryOut("SELECT * FROM TestTable")
        MsgBox(ds.Tables(0).Rows(0).Item(1))
    End Sub
End Class
