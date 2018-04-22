﻿Imports System.Data.OleDb
Module OleDb_Tools
    'Declare the connection string to be used later (change this when LDM database is done)
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DATADIRECTORY|OurTables.accdb;"

    'Declare the connection using the connection string
    Private theCon As New OleDbConnection(conString)

    'Declare the command that will be executed as query
    Private theCommand As New OleDbCommand

    'Declare Data Adapter that will be used to get data tables from the database
    Private dbDataAdapter As New OleDbDataAdapter

    'Declare Data Set that will hold the data that is given by the Data Table
    Private dbDataSet As New DataSet

    'Used to initialize the connection at the main form load
    Public Sub InitCon()
        theCon.Open()
    End Sub

    'This will be used with queries that has output tables like SELECT...
    'Mostly SELECT...
    '...Only SELECT :P
    Public Function ReadQueryOut(ByVal theQuery As String) As DataSet
        dbDataSet.Reset() 'Empty the Data Set in case it has any information
        theCommand.CommandText = theQuery 'Set the command text (set the query)
        theCommand.Connection = theCon 'Set the connection the will be used by the command
        dbDataAdapter.SelectCommand = theCommand 'Append the command to the data adapter and execute
        dbDataAdapter.Fill(dbDataSet) 'Fill the data from the data adapter to the data set to be readed
        dbDataAdapter.Dispose() 'Distroy the data adapter to conserve memory since it is not needed anymore
        Return dbDataSet 'Return the data set to be readed by the caller
    End Function

    Public Sub ExecuteQuery(ByVal theQuery As String)
        theCommand.CommandText = theQuery 'Set the command text (set the query)
        theCommand.Connection = theCon 'Set the connection the will be used by the command
        theCommand.ExecuteNonQuery() 'Execute non SELECT query
    End Sub

    Public Sub FillDGV(ByVal theDGV As DataGridView, ByVal theQuery As String)
        dbDataSet = ReadQueryOut(theQuery) 'Activate the select query and fill dbDataSet with the output
        'theDGV.Rows.Clear() 'Clears the data grid view in case it contains data
        theDGV.DataSource = dbDataSet.Tables(0) 'Set the data source for the following DataGridView
    End Sub


End Module
