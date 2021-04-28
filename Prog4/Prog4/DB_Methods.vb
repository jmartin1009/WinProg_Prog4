Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class DB_Methods
    Private conFlag As Boolean = False
    Private con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\employeeDB.mdb")
    'Handles showing the database table contents
    'Contains code from Argo's example
    Public Sub fnShow(sender As Form1)
        connectionCheck()
        Dim cmd = doCommand("Select * from tblEmployee")

        'Fire the command using data adapter
        Dim da As New OleDb.OleDbDataAdapter
        da.SelectCommand = cmd

        'Fill it in a temporary table
        Dim dt As New DataTable
        da.Fill(dt)

        'Display in the front end
        sender.dvgEmployee.DataSource = dt

    End Sub
    'Handles deleting a row from the table based on ID entered
    Public Sub fnDelete(userID As String, sender As Form1)
        connectionCheck()
        Dim cmd = doCommand("DELETE FROM tblEmployee WHERE empID='" & userID & "'")
        Try
            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Throw New Exception("Query Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fnShow(sender)
    End Sub
    'Handles adding a row to the table given the inputs from the user
    Public Sub fnInsert(userID As String, userName As String, userSalary As Integer, userAddress As String, sender As Form1)
        connectionCheck()
        Dim cmd = doCommand("INSERT INTO tblEmployee (empID, empName, empSalary, empAddress) VALUES ('" & userID & "', '" & userName & "', '" & userSalary & "', '" & userAddress & "')")
        Try
            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Throw New Exception("Query Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fnShow(sender)
    End Sub
    'Creates and returns a command given the query string
    Private Function doCommand(query As String)
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandText = query
        Return cmd
    End Function
    'Checks connection to database, only opens connection if connection flag indicates a connection has not been made
    Public Sub connectionCheck()
        If (conFlag = False) Then
            con.Open()
            conFlag = True
        End If
        Try
            If Not (con.State = ConnectionState.Open) Then
                Throw New Exception("Database Connection failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
