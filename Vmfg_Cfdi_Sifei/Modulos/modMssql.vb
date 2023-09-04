Imports System.Data
Imports System.Data.SqlClient
Module modMssql
    Public sqluser As String = modHome.mssqlusr
    Public sqlpass As String = modHome.mssqlpas
    Public sqlserver As String = modHome.mssqlsrv
    Public sqldb As String = modHome.mssqldb


    Public conmssql As New SqlConnection("Data Source=" & sqlserver +
                                         ";Initial Catalog=" & sqldb +
                                         "; Persist Security Info=True;" +
                                         "User ID=" & sqluser +
                                         "; Password=" & sqlpass +
                                         ";")

    Sub conectarsql()
        Try
            conmssql.Open()
            MsgBox("Conexion exitosa a MSSQL")
        Catch ex As SqlException
            MsgBox("Atención!!! " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Module
