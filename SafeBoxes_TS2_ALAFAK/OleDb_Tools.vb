Imports System.Data.OleDb
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

    Public Sub FillDGV(ByRef theDGV As DataGridView, ByVal theQuery As String)
        Dim dgvDbDataSet As New DataSet
        dgvDbDataSet = ReadQueryOut(theQuery).Copy() 'Activate the select query and fill dbDataSet with the output
        theDGV.DataSource = dgvDbDataSet.Tables(0) 'Set the data source for the following DataGridView
    End Sub

    Public Function genID(ByVal theTable As String, ByVal theColumn As String)
        dbDataSet = ReadQueryOut("SELECT MAX(" & theColumn & ") FROM " & theTable)
        Return dbDataSet.Tables(0).Rows(0).Item(0) + 1
    End Function

    Public Sub FillCBox(ByRef theCBox As ComboBox, ByVal theQuery As String, ByVal ValueMember As String, ByVal DisplayName As String)
        Dim cBoxDbDataSet As New DataSet
        theCBox.Text = ""
        cBoxDbDataSet = ReadQueryOut(theQuery).Copy() 'This is the new way to get data from the database into the Combo Box, but still has some issues, and currently declared as an issue in github
        theCBox.DataSource = cBoxDbDataSet.Tables(0) 'lets's hope someone help fixing it.
        theCBox.ValueMember = ValueMember 'The problem is when I use this procedure the data is filled perfectly in the combo box but when I access the database using any query after that, it remove the data from the combo box
        theCBox.DisplayMember = DisplayName 'So now I have to refresh the combo box everytime using this function... Any Ideas?
    End Sub

    Public Function Exists(ByVal theObj As String, ByVal theQuery As String) As Boolean
        Try
            dbDataSet = ReadQueryOut(theQuery)
        Catch ex As Exception
            Return False
        End Try

        Dim i As Integer
        For i = 0 To dbDataSet.Tables(0).Rows.Count - 1
            If dbDataSet.Tables(0).Rows(i).Item(0) = theObj Then
                Return True
            End If
        Next
        Return False

    End Function

    Public Sub AddBuilding(ByRef cbox_regions As ComboBox, ByRef cbox_streets As ComboBox, ByRef cbox_building As ComboBox)
        Dim i As Integer
        Dim theStreet As String = cbox_streets.Text
        Dim theBuilding As String = cbox_building.Text
        If cbox_regions.SelectedValue > 0 Then
            Dim selectedRegion As String = cbox_regions.SelectedValue
        End If
        If cbox_streets.SelectedValue > 0 Then
            Dim selectedStreet As String = cbox_streets.SelectedValue
        End If

        For i = 1 To 3
            If Exists(cbox_regions.Text, "SELECT RegionName FROM Regions") Then
                If Exists(cbox_streets.Text, "SELECT StreetName FROM Streets WHERE StreetId = " & cbox_streets.SelectedValue & " AND RegionId = " & cbox_regions.SelectedValue) Then
                    If Exists(cbox_building.Text, "SELECT BuildingName FROM Buildings b, Streets s WHERE b.StreetId = " & cbox_streets.SelectedValue & " AND RegionId = " & cbox_regions.SelectedValue) Then
                        GoTo End_Of_For
                    Else
                        ExecuteQuery("INSERT INTO Buildings VALUES(" & genID("Buildings", "BuildingId") & ", '" & theBuilding & "', " & cbox_streets.SelectedValue & ")")
                        GoTo End_Of_For
                    End If
                Else
                    Dim streetId As String = genID("Streets", "StreetId")
                    ExecuteQuery("INSERT INTO Streets VALUES(" & streetId & ", '" & theStreet & "', " & cbox_regions.SelectedValue & ")")
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                    cbox_streets.SelectedValue = streetId
                End If
            Else
                Dim regionId As String = genID("Regions", "RegionId")
                ExecuteQuery("INSERT INTO Regions VALUES(" & regionId & ", '" & cbox_regions.Text & "')")
                FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                cbox_regions.SelectedValue = regionId
            End If
        Next
End_Of_For:
    End Sub

    Public Sub Only_Number(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Public Sub Only_char(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please enter characters only")
            e.Handled = True
        End If
    End Sub

    Public Sub Toggle(ByRef theObj As Control)
        If theObj.Enabled Then
            theObj.Enabled = False
        Else
            theObj.Enabled = True
        End If
    End Sub

End Module
