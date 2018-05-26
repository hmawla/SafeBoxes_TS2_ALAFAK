Imports System.Data.OleDb
Module OleDb_Tools
    'Created and managed by Hussein Almawla
    'Open source @github.com
    'Copyright MawlaTelecom.com

    'Admin Password
    Public adminPass As String = "12345"
    'Used for our custom messagebox
    Public mesResult As DialogResult
    Public inResult As String
    'Declare the connection string to be used later (change this when LDM database is done)
    Private ReadOnly conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DATADIRECTORY|OurTables.accdb;"

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

    'Execute a non-output query (DML,DDL)
    Public Sub ExecuteQuery(ByVal theQuery As String)
        theCommand.CommandText = theQuery 'Set the command text (set the query)
        theCommand.Connection = theCon 'Set the connection the will be used by the command
        theCommand.ExecuteNonQuery() 'Execute non SELECT query
    End Sub

    'Fills a data grid view with the given query
    Public Sub FillDGV(ByRef theDGV As DataGridView, ByVal theQuery As String)
        Dim dgvDbDataSet As New DataSet
        dgvDbDataSet = ReadQueryOut(theQuery).Copy() 'Activate the select query and fill dbDataSet with the output
        theDGV.DataSource = dgvDbDataSet.Tables(0) 'Set the data source for the following DataGridView
    End Sub

    'Used to generate a new unique ID for any given table
    Public Function GenID(ByVal theTable As String, ByVal theColumn As String)
        dbDataSet = ReadQueryOut("SELECT MAX(" & theColumn & ") FROM " & theTable)
        If Not dbDataSet.Tables(0).Rows(0).Item(0).GetType.ToString().ToLower().Equals("system.dbnull") Then
            Return dbDataSet.Tables(0).Rows(0).Item(0) + 1
        Else
            Return 1
        End If

    End Function

    'Used to generate a new unique ID for Accounts Tables
    Public Function GenAccID()
        dbDataSet = ReadQueryOut("SELECT MAX(AccountId) FROM (SELECT AccountId FROM ClientDepAccount UNION SELECT AccountId FROM ClientRepAccount UNION SELECT AccountId FROM CompanyAccounts UNION SELECT AccountId FROM SignCardsAccounts)")
        If Not dbDataSet.Tables(0).Rows(0).Item(0).GetType.ToString().ToLower().Equals("system.dbnull") Then
            Return dbDataSet.Tables(0).Rows(0).Item(0) + 1
        Else
            Return 1
        End If

    End Function

    'Fills a Combobox with the given query
    Public Sub FillCBox(ByRef theCBox As ComboBox, ByVal theQuery As String, ByVal ValueMember As String, ByVal DisplayName As String)
        Dim cBoxDbDataSet As New DataSet
        theCBox.Text = ""
        cBoxDbDataSet = ReadQueryOut(theQuery).Copy() 'This is the new way to get data from the database into the Combo Box, but still has some issues, and currently declared as an issue in github
        theCBox.DataSource = cBoxDbDataSet.Tables(0) 'lets's hope someone help fixing it.
        theCBox.ValueMember = ValueMember 'The problem is when I use this procedure the data is filled perfectly in the combo box but when I access the database using any query after that, it remove the data from the combo box
        theCBox.DisplayMember = DisplayName 'So now I have to refresh the combo box everytime using this function... Any Ideas?
    End Sub

    Public Sub FillCheckList(ByRef theCheckList As CheckedListBox, ByVal theQuery As String, ByVal ValueMember As String, ByVal DisplayName As String)
        Dim cBoxDbDataSet As New DataSet
        cBoxDbDataSet = ReadQueryOut(theQuery).Copy() 'This is the new way to get data from the database into the Combo Box, but still has some issues, and currently declared as an issue in github
        theCheckList.DataSource = cBoxDbDataSet.Tables(0) 'lets's hope someone help fixing it.
        theCheckList.ValueMember = ValueMember 'The problem is when I use this procedure the data is filled perfectly in the combo box but when I access the database using any query after that, it remove the data from the combo box
        theCheckList.DisplayMember = DisplayName 'So now I have to refresh the combo box everytime using this function... Any Ideas?
    End Sub

    'Checks if the item exists in the database using a query
    Public Function Exists(ByVal theObj As String, ByVal theQuery As String) As Boolean
        Try
            dbDataSet = ReadQueryOut(theQuery)
        Catch ex As Exception
            Return False
        End Try

        Dim i As Integer
        For i = 0 To dbDataSet.Tables(0).Rows.Count - 1
            If dbDataSet.Tables(0).Rows(i).Item(0).ToString.Equals(theObj.ToString) Then
                Return True
            End If
        Next
        Return False

    End Function

    'A Tool to add a building from scratch street and region
    Public Function AddBuilding(ByRef cbox_regions As ComboBox, ByRef cbox_streets As ComboBox, ByRef cbox_building As ComboBox) As Integer
        'used in the loop
        Dim i As Integer
        'Conserves Old values
        Dim theStreet As String = cbox_streets.Text
        Dim theBuilding As String = cbox_building.Text
        Dim theBuildingId As Integer
        'Conserves New Values
        If cbox_regions.SelectedValue > 0 Then
            If cbox_streets.SelectedValue > 0 Then
                If cbox_building.SelectedValue > 0 Then
                    theBuildingId = cbox_building.SelectedValue
                    GoTo End_Of_For
                End If
            End If
        End If



        'Enters a checking loop that runs 3 times, each time for Region, Street, and Building respectively
        'Each time it checks of the item exists then jump to the next else add the item and continue
        'Until the last ittiration is reached
        For i = 1 To 3
            If Exists(cbox_regions.Text, "SELECT RegionName FROM Regions") Then
                If Exists(cbox_streets.Text, "SELECT StreetName FROM Streets WHERE StreetId = " & cbox_streets.SelectedValue & " AND RegionId = " & cbox_regions.SelectedValue) Then
                    If Exists(cbox_building.Text, "SELECT BuildingName FROM Buildings b, Streets s WHERE b.StreetId = " & cbox_streets.SelectedValue & " AND RegionId = " & cbox_regions.SelectedValue) Then
                        GoTo End_Of_For
                    Else
                        theBuildingId = GenID("Buildings", "BuildingId")
                        ExecuteQuery("INSERT INTO Buildings VALUES(" & theBuildingId & ", '" & theBuilding & "', " & cbox_streets.SelectedValue & ")")
                        GoTo End_Of_For
                    End If
                Else
                    Dim streetId As String = GenID("Streets", "StreetId")
                    ExecuteQuery("INSERT INTO Streets VALUES(" & streetId & ", '" & theStreet & "', " & cbox_regions.SelectedValue & ")")
                    FillCBox(cbox_streets, "SELECT StreetId, StreetName FROM Streets WHERE RegionId = " & cbox_regions.SelectedValue, "StreetId", "StreetName")
                    cbox_streets.SelectedValue = streetId
                End If
            Else
                Dim regionId As String = GenID("Regions", "RegionId")
                ExecuteQuery("INSERT INTO Regions VALUES(" & regionId & ", '" & cbox_regions.Text & "')")
                FillCBox(cbox_regions, "SELECT RegionId, RegionName FROM Regions", "RegionId", "RegionName")
                cbox_regions.SelectedValue = regionId
            End If
        Next
End_Of_For:
        Return theBuildingId
    End Function

    Public Function AddRight(ByRef theCBox As ComboBox) As Integer
        If theCBox.SelectedIndex >= 0 Then
            Return theCBox.SelectedValue
        Else
            Dim theNewId As Integer = GenID("AuthRight", "RightId")
            ExecuteQuery("INSERT INTO AuthRight VALUES(" & theNewId & ", '" & theCBox.Text & "')")
            Return theNewId
        End If
    End Function

    'Used to check textboxes for characters other than numbers
    Public Sub Only_Number(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    'Used to check textboxes for characters other than ASCII Characters
    Public Sub Only_char(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please enter characters only")
            e.Handled = True
        End If
    End Sub

    'Toggles any control state
    Public Sub Toggle(ByRef theObj As Control)
        If theObj.Enabled Then
            theObj.Enabled = False
            theObj.Text = ""
        Else
            theObj.Enabled = True
        End If
    End Sub

End Module
