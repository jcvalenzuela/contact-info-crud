
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Module modConnection
    '// Declare variable one time but use many times.
    Public Conn As OleDbConnection
    Public Cmd As OleDbCommand
    Public DS As DataSet
    Public DR As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public strSQL As String '// Major SQL
    Public strStmt As String    '// Minor SQL

    '// Data Path 
    Public strPathData As String = MyPath(Application.StartupPath)
    '// Images Path
    Public strPathImages As String = MyPath(Application.StartupPath)

    Public Function ConnectDataBase() As System.Data.OleDb.OleDbConnection
        strPathData = MyPath(Application.StartupPath)

        Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Data\Contact.accdb;Persist Security Info=False;"

        Conn = New OleDb.OleDbConnection(strConn)
        ' Create Connection
        Conn.ConnectionString = strConn
        ' Return
        Return Conn
    End Function

    Function MyPath(AppPath As String) As String
        '/ MessageBox.Show(AppPath);
        AppPath = AppPath.ToLower()
        '/ Return Value
        MyPath = AppPath.Replace("\bin\debug", "\").Replace("\bin\release", "\")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Right(MyPath, 1) <> "\" Then MyPath = MyPath & "\"
    End Function
End Module
