Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Threading



Public Class UuidModel

    Public Sub MonitorearFacturas()
        ' Configura la cadena de conexión a MariaDB
        Dim mariaDBConnectionString As String = "Server=" & modHome.mariadbsrv & ";Database=" & modHome.mariadb & ";Uid=" & modHome.mariadbusr & ";Pwd=" & modHome.mariadbpas & ";"

        ' Configura la cadena de conexión a SQL Server
        Dim sqlServerConnectionString As String = "Server=" & modHome.mssqlsrv & ";Database=" & modHome.mssqldb & ";User Id=" & modHome.mssqlusr & ";Password=" & modHome.mssqlpas & ";"

        ' Crea un bucle infinito para monitorear la base de datos MariaDB

        Try
            ' Conecta a MariaDB y verifica si hay nuevos registros en la tabla de facturas
            Using mariaDBConnection As New MySqlConnection(mariaDBConnectionString)
                mariaDBConnection.Open()

                Dim selectQuery As String = "SELECT SUBSTRING(NombreArchivo, 1, LOCATE('.', NombreArchivo) - 1) AS NumeroFactura, T.UUID,F.Actualizado " +
                    "FROM cfdfacturasemit AS F LEFT JOIN cfditimbresemit AS T ON F.IdCFDFacturas = T.IdCFDFacturas " +
                    "WHERE TipoDocto = 'FA' AND Actualizado IS NULL AND NombreArchivo LIKE 'B%' "
                Using sqlCommand As New MySqlCommand(selectQuery, mariaDBConnection)
                    Using reader As MySqlDataReader = sqlCommand.ExecuteReader()
                        While reader.Read()
                            ' Obtiene los datos del registro
                            Dim numeroFactura As String = reader("NumeroFactura").ToString(0)
                            Dim uuid As String = reader("UUID").ToString(1)

                            ' Conecta a SQL Server y actualiza el campo UID
                            Using sqlConnection As New SqlConnection(sqlServerConnectionString)
                                sqlConnection.Open()


                                Dim updateQuery As String = "UPDATE RECEIVABLE SET UUID = @UUID WHERE INVOICE_ID = @NumeroFactura"
                                Using sqlCommandSQL As New SqlCommand(updateQuery, sqlConnection)
                                    sqlCommandSQL.Parameters.AddWithValue("@NumeroFactura", numeroFactura)
                                    sqlCommandSQL.Parameters.AddWithValue("@UUID", uuid)
                                    sqlCommandSQL.ExecuteNonQuery()
                                End Using

                            End Using

                            ' Marca el registro en MariaDB como actualizado
                            Dim updateMariaDBQuery As String = "UPDATE cfdfacturasemit SET Actualizado = 1 WHERE IdCFDFacturas = @NumeroFactura"
                            Using sqlCommandMariaDB As New MySqlCommand(updateMariaDBQuery, mariaDBConnection)
                                sqlCommandMariaDB.Parameters.AddWithValue("@NumeroFactura", numeroFactura)
                                sqlCommandMariaDB.ExecuteNonQuery()
                            End Using
                        End While
                    End Using
                End Using
            End Using

            ' Espera un tiempo antes de verificar nuevamente
            'Thread.Sleep(5000) ' Espera 5 segundos antes de verificar nuevamente

        Catch ex As Exception
            ' Maneja cualquier excepción que pueda ocurrir durante el proceso.
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
