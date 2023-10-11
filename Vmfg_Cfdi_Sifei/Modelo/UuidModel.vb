Imports System.Data.SqlClient
Imports System.Threading
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms

Public Class UuidModel
    Private mariaDBConnectionString As String = "Driver={MariaDB ODBC 3.1 Driver};Server=" & modHome.mariadbsrv & ";Port=3306;Database=" & modHome.mariadb & ";Uid=" & modHome.mariadbusr & ";Pwd=" & modHome.mariadbpas & ";"
    Private sqlServerConnectionString As String = "Server=" & modHome.mssqlsrv & ";Database=" & modHome.mssqldb & ";User Id=" & modHome.mssqlusr & ";Password=" & modHome.mssqlpas & ";"

    Public Sub MonitorearFacturas(progressBar As ProgressBar)
        Dim registrosCorrectos As Integer = 0
        Dim registrosIncorrectos As Integer = 0

        Try
            ' Conectar a MariaDB y obtener datos de la tabla Facturas
            Using mariaDBConnection As New OdbcConnection(mariaDBConnectionString)
                mariaDBConnection.Open()

                If mariaDBConnection.State = ConnectionState.Open Then
                    Dim selectQuery As String = "SELECT SUBSTRING(F.NombreArchivo, 1, LOCATE('.', NombreArchivo) - 1) AS NumeroFactura, F.IdCFDFacturas,  " +
                        "F.Version, F.Serie, F.Folio, F.Fecha, F.Sello, " +
                        "F.noAprobacion, F.formaDePago, F.noCertificado, F.condicionesDePago, F.SubTotal, F.Descuento, " +
                        "F.motivoDescuento, F.Total, F.metodoDePago, F.tipoDeComprobante, F.RfcCont, F.NombreCont, " +
                        "F.RazonSocialCont, F.DFCont, F.IdEmisor, F.NombreEmi, F.EEEmisor, F.RfcCli, F.NombreCli, " +
                        "F.RazonSocialCli, F.RECliente, F.TotalImpuestosRetenidos, F.TotalImpuestosTrasladados, F.CadenaOriginal, " +
                        "F.DescuentoGral, F.ImpuestoGral, F.Status, F.TipoDocto, F.Pdf, F.Xml, F.FechaCancel, F.idGUID, F.Moneda, " +
                        "F.TipoDeCambio, F.NombreArchivo, F.Mail, F.MailEnviado, F.LugarExped, F.UsoCfdiCli," +
                        "T.UUID " +
                        "FROM cfdfacturasemit AS F LEFT JOIN cfditimbresemit AS T ON F.IdCFDFacturas = T.IdCFDFacturas " +
                        "WHERE TipoDocto = 'FA' AND NombreArchivo LIKE 'B%' "
                    Using sqlCommand As New OdbcCommand(selectQuery, mariaDBConnection)
                        Using reader As OdbcDataReader = sqlCommand.ExecuteReader()
                            While reader.Read()
                                ' Obtener los datos de la tabla de MariaDB
                                Dim numeroFactura As String = reader("NumeroFactura").ToString()
                                Dim idCfdFacturas As Integer = Convert.ToInt32(reader("IdCFDFacturas"))
                                Dim version As String = reader("Version").ToString()
                                Dim serie As String = reader("Serie").ToString()
                                Dim folio As Integer = Convert.ToInt32(reader("Folio"))
                                Dim fecha As Date = reader("Fecha")
                                Dim sello As String = reader("Sello").ToString()
                                Dim noAprobacion As String = reader("noAprobacion").ToString()
                                Dim formaDePago As String = reader("formaDePago").ToString()
                                Dim noCertificado As String = reader("noCertificado").ToString()
                                Dim condicionesDePago As String = reader("condicionesDePago").ToString()
                                Dim subTotal As Decimal = reader("SubTotal")
                                Dim descuento As Decimal = reader("Descuento")
                                Dim motivoDescuento As String = reader("motivoDescuento").ToString()
                                Dim total As Decimal = reader("Total")
                                Dim metodoDePago As String = reader("metodoDePago").ToString()
                                Dim tipoDeComprobante As String = reader("tipoDeComprobante").ToString()
                                Dim rfcCont As String = reader("RfcCont").ToString()
                                Dim nombreCont As String = reader("NombreCont").ToString()
                                Dim razonSocialCont As String = reader("RazonSocialCont").ToString()
                                Dim dfCont As String = reader("DFCont").ToString()
                                Dim idEmisor As Integer = Convert.ToInt32(reader("IdEmisor"))
                                Dim uuid As String = reader("UUID").ToString()


                                ' Iniciar el proceso de inserción y actualización
                                Dim registroCorrecto As Boolean = False

                                ' Conectar a SQL Server
                                Using sqlConnection As New SqlConnection(sqlServerConnectionString)
                                    sqlConnection.Open()

                                    If sqlConnection.State = ConnectionState.Open Then
                                        ' Iniciar la transacción
                                        Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction()

                                        Try
                                            'Borrar en CFDI_FACTURAS
                                            Dim deleteQuery As String = "DELETE FROM CFDI_FACTURAS WHERE INVOICE_ID = @NumeroFactura"
                                            Using sqlCommand1SQL As New SqlCommand(deleteQuery, sqlConnection, sqlTransaction)
                                                sqlCommand1SQL.Parameters.AddWithValue("@NumeroFactura", numeroFactura)
                                                sqlCommand1SQL.ExecuteNonQuery()
                                            End Using
                                            ' Insertar en CFDI_FACTURAS
                                            Dim insertQuery As String = "INSERT INTO CFDI_FACTURAS (INVOICE_ID, IDCFDFACTURAS, VERSION, SERIE, FOLIO, " +
                                                " FECHA,  SELLO, NOAPROBACION, FORMADEPAGO, NOCERTIFICADO, CONDICIONESDEPAGO, SUBTOTAL, DESCUENTO, " +
                                                " MOTIVODESCUENTO, TOTAL, METODODEPAGO, TIPODECOMPROBANTE, RFCCONT, NOMBRECONT, RAZONSOCIALCONT, DFCONT, IDEMISOR, " +
                                                " UUID ) " +
                                                " VALUES (@NumeroFactura, @IDCFDFACTURAS, @VERSION, @SERIE, @FOLIO, " +
                                                " @FECHA, @SELLO, @NOAPROBACION, @FORMADEPAGO, @NOCERTIFICADO, @CONDICIONESDEPAGO, @SUBTOTAL, @DESCUENTO, " +
                                                " @MOTIVODESCUENTO, @TOTAL, @METODODEPAGO, @TIPODECOMPROBANTE, @RFCCONT, @NOMBRECONT, @RAZONSOCIALCONT, @DFCONT, @IDEMISOR, " +
                                                " @UUID)"
                                            Using sqlCommandSQL As New SqlCommand(insertQuery, sqlConnection, sqlTransaction)
                                                sqlCommandSQL.Parameters.AddWithValue("@NumeroFactura", numeroFactura)
                                                sqlCommandSQL.Parameters.AddWithValue("@IDCFDFACTURAS", idCfdFacturas)
                                                sqlCommandSQL.Parameters.AddWithValue("@SERIE", serie)
                                                sqlCommandSQL.Parameters.AddWithValue("@FOLIO", folio)
                                                sqlCommandSQL.Parameters.AddWithValue("@VERSION", version)
                                                sqlCommandSQL.Parameters.AddWithValue("@FECHA", fecha)
                                                sqlCommandSQL.Parameters.AddWithValue("@SELLO", sello)
                                                sqlCommandSQL.Parameters.AddWithValue("@NOAPROBACION", noAprobacion)
                                                sqlCommandSQL.Parameters.AddWithValue("@FORMADEPAGO", formaDePago)
                                                sqlCommandSQL.Parameters.AddWithValue("@NOCERTIFICADO", noCertificado)
                                                sqlCommandSQL.Parameters.AddWithValue("@CONDICIONESDEPAGO", condicionesDePago)
                                                sqlCommandSQL.Parameters.AddWithValue("@SUBTOTAL", subTotal)
                                                sqlCommandSQL.Parameters.AddWithValue("@DESCUENTO", descuento)
                                                sqlCommandSQL.Parameters.AddWithValue("@MOTIVODESCUENTO", motivoDescuento)
                                                sqlCommandSQL.Parameters.AddWithValue("@TOTAL", total)
                                                sqlCommandSQL.Parameters.AddWithValue("@METODODEPAGO", metodoDePago)
                                                sqlCommandSQL.Parameters.AddWithValue("@TIPODECOMPROBANTE", tipoDeComprobante)
                                                sqlCommandSQL.Parameters.AddWithValue("@RFCCONT", rfcCont)
                                                sqlCommandSQL.Parameters.AddWithValue("@NOMBRECONT", nombreCont)
                                                sqlCommandSQL.Parameters.AddWithValue("@RAZONSOCIALCONT", razonSocialCont)
                                                sqlCommandSQL.Parameters.AddWithValue("@DFCONT", dfCont)
                                                sqlCommandSQL.Parameters.AddWithValue("@IDEMISOR", idEmisor)

                                                sqlCommandSQL.Parameters.AddWithValue("@UUID", uuid)
                                                sqlCommandSQL.ExecuteNonQuery()
                                            End Using

                                            ' Validar el resultado del insert
                                            ' Si llegas a tener condiciones específicas de validación, aquí puedes agregarlas

                                            ' Marcar el registro en MariaDB como actualizado
                                            Dim updateMariaDBQuery As String = "UPDATE cfdfacturasemit SET Actualizado = 1 WHERE IdCFDFacturas = @IdCFDFacturas"
                                            Using sqlCommandMariaDB As New OdbcCommand(updateMariaDBQuery, mariaDBConnection)
                                                sqlCommandMariaDB.Parameters.AddWithValue("@IdCFDFacturas", IdCFDFacturas)
                                                sqlCommandMariaDB.ExecuteNonQuery()
                                            End Using

                                            ' Validar el resultado del update
                                            ' Si llegas a tener condiciones específicas de validación, aquí puedes agregarlas

                                            ' Confirmar la transacción
                                            sqlTransaction.Commit()

                                            ' El registro se procesó correctamente
                                            registrosCorrectos += 1
                                            registroCorrecto = True

                                        Catch ex As Exception
                                            ' Manejar las excepciones y mostrar mensajes de error
                                            MessageBox.Show($"Error durante el proceso del registro {numeroFactura}: {ex.Message}", "Error de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                            ' Revertir la transacción en caso de error
                                            sqlTransaction.Rollback()

                                            ' Marcar el registro como incorrecto
                                            registrosIncorrectos += 1
                                        End Try
                                    Else
                                        MessageBox.Show("Error en la conexión a SQL Server.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                End Using

                                ' Actualizar el progreso
                                progressBar.Invoke(Sub() progressBar.Value += 1)

                                ' Si el registro no fue procesado correctamente, puedes manejarlo aquí según tus necesidades
                                If Not registroCorrecto Then
                                    ' Puedes realizar acciones adicionales en caso de error
                                End If
                            End While
                        End Using
                    End Using
                Else
                    MessageBox.Show("Error en la conexión a MariaDB.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' Muestra un mensaje al finalizar el proceso
            MessageBox.Show($"Registros Correctos: {registrosCorrectos}{Environment.NewLine}Registros Incorrectos: {registrosIncorrectos}", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Manejar las excepciones generales y mostrar mensajes de error
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
