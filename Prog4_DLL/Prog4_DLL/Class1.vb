Imports System.Data.OleDb

Public Module Class1
    Private conFlag As Boolean = False
    Private con As OleDbConnection = New OleDbConnection
    'Handles showing the database table contents
    'Contains code from Argo's example
    Public Function fnShow(conString As String)
        connectionCheck(conString)
        Dim cmd = doCommand("Select * from tblEmployee")

        'Fire the command using data adapter
        Dim da As New OleDb.OleDbDataAdapter
        da.SelectCommand = cmd

        'Fill it in a temporary table
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
        End Try


        'Return the datatable the form will show
        Return dt

    End Function
    'Handles deleting a row from the table based on ID entered
    Public Sub fnDelete(userID As String, conString As String)
        connectionCheck(conString)
        Dim cmd = doCommand("DELETE FROM tblEmployee WHERE empID='" & userID & "'")
        Try
            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Throw New Exception("Query Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Handles adding a row to the table given the inputs from the user
    Public Sub fnInsert(userID As String, userName As String, userSalary As Integer, userAddress As String, conString As String)
        connectionCheck(conString)
        Dim cmd = doCommand("INSERT INTO tblEmployee (empID, empName, empSalary, empAddress) VALUES ('" & userID & "', '" & userName & "', '" & userSalary & "', '" & userAddress & "')")
        Try
            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Throw New Exception("Query Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Creates and returns a command given the query string
    Private Function doCommand(query As String)
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandText = query
        Return cmd
    End Function
    'Checks connection to database, only opens connection if connection flag indicates a connection has not been made
    Public Sub connectionCheck(filePath As String)
        Try
            Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=#"
            conString = conString.Replace("#", filePath)
            If con.State = ConnectionState.Open Then
                If con.ConnectionString <> conString Then
                    conFlag = False
                    con.Close()
                End If
            End If
            If (conFlag = False) Then
                con = New OleDbConnection(conString)
                con.Open()
                conFlag = True
            End If
            If Not (con.State = ConnectionState.Open) Then
                Throw New Exception("Database Connection failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
