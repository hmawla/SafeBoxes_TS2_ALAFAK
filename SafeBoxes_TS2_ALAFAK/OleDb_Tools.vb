Imports System.Data.OleDb
Module OleDb_Tools
    Private theCon As New OleDbConnection
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DATADIRECTORY|testDatabase.accdb;"
    Private theCommand As New OleDbCommand
    Private dbDataAdapter As New OleDbDataAdapter
    Private dbDataSet As New DataSet
    Private dbDataTable As New DataTable

    Public Sub InitCon()
        theCon.ConnectionString = conString
        theCon.Open()
    End Sub
    Public Function ReadQueryOut(ByVal theQuery As String) As DataSet
        theCon.ConnectionString = conString
        theCommand.CommandText = theQuery
        theCommand.Connection = theCon
        dbDataAdapter.SelectCommand = theCommand
        dbDataAdapter.Fill(dbDataSet)
        dbDataAdapter.Dispose()
        Return dbDataSet

    End Function

End Module
