Imports System.Data.SqlClient
Public Class SelloModel
    Private Conexion As SqlConnection
    Private CadenaConexion As String = "Server=" & modHome.mssqlsrv & ";Database=" & modHome.mssqldb & ";User Id=" & modHome.mssqlusr & ";Password=" & modHome.mssqlpas & ";"




    Public Sub New()
        Conexion = New SqlConnection(CadenaConexion)
    End Sub

    Public Function ObtenerSellos() As DataTable
        Dim procedimiento As String = "sp_ObtenerCfdiSellos"

        Dim adaptador As New SqlDataAdapter(procedimiento, Conexion)
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim tabla As New DataTable()

        Conexion.Open()
        adaptador.Fill(tabla)
        Conexion.Close()

        Return tabla
    End Function

    Public Sub InsertarSello(id As String, vigencia As DateTime, estatus As String)
        Dim procedimiento As String = "sp_InsertarCfdiSello"

        Dim comando As New SqlCommand(procedimiento, Conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@ID", id)
        comando.Parameters.AddWithValue("@VIGENCIA", vigencia)
        comando.Parameters.AddWithValue("@ESTATUS", estatus)

        Conexion.Open()
        comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub

    Public Sub ActualizarSello(id As String, vigencia As DateTime, estatus As String)
        Dim procedimiento As String = "sp_ActualizarCfdiSello"

        Dim comando As New SqlCommand(procedimiento, Conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@ID", id)
        comando.Parameters.AddWithValue("@VIGENCIA", vigencia)
        comando.Parameters.AddWithValue("@ESTATUS", estatus)

        Conexion.Open()
        comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub

    Public Sub EliminarSello(row As Integer)
        Dim procedimiento As String = "sp_EliminarCfdiSellos"

        Dim comando As New SqlCommand(procedimiento, Conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@ROW", row)

        Conexion.Open()
        comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub
End Class
