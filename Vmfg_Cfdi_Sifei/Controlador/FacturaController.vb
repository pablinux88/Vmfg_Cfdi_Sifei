Imports System.IO
Imports System.Data.SqlClient

Public Class FacturaController
    Public Sub GenerarArchivoTxt(numeroFactura As String, rutaArchivo As String)
        ' Conexión a la base de datos SQL Server
        Dim connectionString As String = "Server=" & modHome.mssqlsrv & ";Database=" & modHome.mssqldb & ";User Id=" & modHome.mssqlusr & ";Password=" & modHome.mssqlpas & ";"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Verifica si la factura existe
            Dim facturaExiste As Boolean = False
            Using cmdExistencia As New SqlCommand("sp_VerificarExistenciaFactura", connection)
                cmdExistencia.CommandType = CommandType.StoredProcedure
                cmdExistencia.Parameters.AddWithValue("@INVOICE_ID", numeroFactura)
                Dim resultadoExistencia As Object = cmdExistencia.ExecuteScalar()

                If resultadoExistencia IsNot Nothing AndAlso resultadoExistencia IsNot DBNull.Value Then
                    facturaExiste = Convert.ToBoolean(resultadoExistencia)
                End If
            End Using

            If facturaExiste Then
                ' Ejecuta el procedimiento almacenado y obtiene los datos de FacturaModel
                Dim facturaData As New List(Of FacturaModel)()
                Using cmd As New SqlCommand("sp_ObtenerCfdiFactura", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@INVOICE_ID", numeroFactura)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim factura As New FacturaModel()
                            ' Rellena los datos de FacturaModel
                            If Not reader.IsDBNull(0) Then
                                factura.NumeroFactura = reader.GetString(0)
                            End If

                            If Not reader.IsDBNull(1) Then
                                factura.Campo1 = reader.GetString(1)
                            End If

                            If Not reader.IsDBNull(2) Then
                                factura.Campo2 = reader.GetString(2)
                            End If

                            If Not reader.IsDBNull(3) Then
                                factura.Campo3 = reader.GetString(3)
                            End If

                            If Not reader.IsDBNull(4) Then
                                factura.Campo4 = reader.GetString(4)
                            End If

                            If Not reader.IsDBNull(5) Then
                                factura.Campo5 = reader.GetString(5)
                            End If

                            If Not reader.IsDBNull(6) Then
                                factura.Campo6 = reader.GetString(6)
                            End If

                            If Not reader.IsDBNull(7) Then
                                factura.Campo7 = reader.GetString(7)
                            End If

                            If Not reader.IsDBNull(8) Then
                                factura.Campo8 = reader.GetDecimal(8).ToString()
                            End If

                            If Not reader.IsDBNull(9) Then
                                factura.Campo9 = reader.GetDecimal(9).ToString()
                            End If
                            If Not reader.IsDBNull(10) Then
                                factura.Campo10 = reader.GetDecimal(10).ToString()
                            End If
                            If Not reader.IsDBNull(11) Then
                                factura.Campo11 = reader.GetDecimal(11).ToString()
                            End If
                            If Not reader.IsDBNull(12) Then
                                factura.Campo12 = reader.GetString(12)
                            End If
                            If Not reader.IsDBNull(13) Then
                                factura.Campo13 = reader.GetString(13)
                            End If
                            If Not reader.IsDBNull(14) Then
                                factura.Campo14 = reader.GetString(14)
                            End If
                            If Not reader.IsDBNull(15) Then
                                factura.Campo15 = reader.GetString(15)
                            End If
                            If Not reader.IsDBNull(16) Then
                                factura.Campo16 = reader.GetString(16)
                            End If
                            If Not reader.IsDBNull(17) Then
                                factura.Campo17 = reader.GetString(17)
                            End If
                            If Not reader.IsDBNull(18) Then
                                factura.Campo18 = reader.GetString(18)
                            End If
                            If Not reader.IsDBNull(19) Then
                                factura.Campo19 = reader.GetString(19)
                            End If
                            If Not reader.IsDBNull(20) Then
                                factura.Campo20 = reader.GetString(20)
                            End If
                            If Not reader.IsDBNull(21) Then
                                factura.Campo21 = reader.GetString(21)
                            End If
                            If Not reader.IsDBNull(22) Then
                                factura.Campo22 = reader.GetString(22)
                            End If
                            If Not reader.IsDBNull(23) Then
                                factura.Campo23 = reader.GetString(23)
                            End If
                            If Not reader.IsDBNull(24) Then
                                factura.Campo24 = reader.GetString(24)
                            End If
                            If Not reader.IsDBNull(25) Then
                                factura.Campo25 = reader.GetString(25)
                            End If
                            If Not reader.IsDBNull(26) Then
                                factura.Campo26 = reader.GetString(26)
                            End If
                            If Not reader.IsDBNull(27) Then
                                factura.Campo27 = reader.GetString(27)
                            End If
                            If Not reader.IsDBNull(28) Then
                                factura.Campo28 = reader.GetDecimal(28).ToString()
                            End If
                            If Not reader.IsDBNull(29) Then
                                factura.Campo29 = reader.GetString(29)
                            End If
                            If Not reader.IsDBNull(30) Then
                                factura.Campo30 = reader.GetString(30)
                            End If
                            If Not reader.IsDBNull(31) Then
                                factura.Campo31 = reader.GetString(31)
                            End If
                            If Not reader.IsDBNull(32) Then
                                factura.Campo32 = reader.GetString(32)
                            End If
                            If Not reader.IsDBNull(33) Then
                                factura.Campo33 = reader.GetString(33)
                            End If
                            If Not reader.IsDBNull(34) Then
                                factura.Campo34 = reader.GetString(34)
                            End If
                            If Not reader.IsDBNull(35) Then
                                factura.Campo35 = reader.GetString(35)
                            End If
                            If Not reader.IsDBNull(36) Then
                                factura.Campo36 = reader.GetString(36)
                            End If
                            If Not reader.IsDBNull(37) Then
                                factura.Campo37 = reader.GetString(37)
                            End If
                            If Not reader.IsDBNull(38) Then
                                factura.Campo38 = reader.GetString(38)
                            End If
                            If Not reader.IsDBNull(39) Then
                                factura.Campo39 = reader.GetString(39)
                            End If
                            If Not reader.IsDBNull(40) Then
                                factura.Campo40 = reader.GetString(40)
                            End If
                            If Not reader.IsDBNull(41) Then
                                factura.Campo41 = reader.GetString(41)
                            End If
                            If Not reader.IsDBNull(42) Then
                                factura.Campo42 = reader.GetString(42)
                            End If
                            If Not reader.IsDBNull(43) Then
                                factura.Campo43 = reader.GetString(43)
                            End If
                            If Not reader.IsDBNull(44) Then
                                factura.Campo44 = reader.GetString(44)
                            End If
                            If Not reader.IsDBNull(45) Then
                                factura.Campo45 = reader.GetString(45)
                            End If
                            If Not reader.IsDBNull(46) Then
                                factura.Campo46 = reader.GetString(46)
                            End If
                            If Not reader.IsDBNull(47) Then
                                factura.Campo47 = reader.GetString(47)
                            End If

                            facturaData.Add(factura)
                        End While
                    End Using
                End Using

                ' Ejecuta el procedimiento almacenado y obtiene los datos de DetalleFacturaModel
                Dim facturaDetalleData As New List(Of DetalleFacturaModel)()
                Using cmdDetalle As New SqlCommand("sp_ObtenerCfdiFacturaDetalle", connection)
                    cmdDetalle.CommandType = CommandType.StoredProcedure
                    cmdDetalle.Parameters.AddWithValue("@INVOICE_ID", numeroFactura)
                    Using readerDetalle As SqlDataReader = cmdDetalle.ExecuteReader()
                        While readerDetalle.Read()
                            Dim detalle As New DetalleFacturaModel()
                            If Not readerDetalle.IsDBNull(0) Then
                                detalle.NumeroFactura = readerDetalle.GetString(0)
                            End If

                            If Not readerDetalle.IsDBNull(1) Then
                                detalle.Campo1 = readerDetalle.GetString(1)
                            End If

                            If Not readerDetalle.IsDBNull(2) Then
                                detalle.Campo2 = readerDetalle.GetInt16(2).ToString()
                            End If

                            If Not readerDetalle.IsDBNull(3) Then
                                detalle.Campo3 = readerDetalle.GetDecimal(3).ToString()
                            End If
                        End While
                    End Using
                End Using

                Try
                    ' Genera el archivo de texto
                    Using writer As New StreamWriter(rutaArchivo)
                        For Each factura As FacturaModel In facturaData
                            Dim linea As String = $"{factura.NumeroFactura}|{factura.Campo1}|{factura.Campo2}|{factura.Campo3}" +
            $"|{factura.Campo4}|{factura.Campo5}|{factura.Campo6}|{factura.Campo7}|{factura.Campo8}|{factura.Campo9}" +
            $"|{factura.Campo10}|{factura.Campo11}|{factura.Campo12}|{factura.Campo13}|{factura.Campo14}|{factura.Campo15}" +
            $"|{factura.Campo16}|{factura.Campo17}|{factura.Campo18}|{factura.Campo19}|{factura.Campo20}|{factura.Campo21}" +
            $"|{factura.Campo22}|{factura.Campo23}|{factura.Campo24}|{factura.Campo25}|{factura.Campo26}|{factura.Campo27}" +
            $"|{factura.Campo28}|{factura.Campo29}|{factura.Campo30}|{factura.Campo31}|{factura.Campo32}|{factura.Campo33}" +
            $"|{factura.Campo34}|{factura.Campo35}" & vbCrLf &
            $"{factura.Campo36}|{factura.Campo37}|{factura.Campo38}|{factura.Campo39}|{factura.Campo40}|{factura.Campo41}" +
            $"{factura.Campo42}|{factura.Campo43}|{factura.Campo44}|{factura.Campo45}|{factura.Campo46}|{factura.Campo47}"

                            ' Busca los datos correspondientes en los detalles de la factura
                            Dim detalles As List(Of DetalleFacturaModel) = facturaDetalleData.Where(Function(detalle) detalle.NumeroFactura = factura.NumeroFactura).ToList()

                            ' Agrega los campos de DetalleFacturaModel a la línea
                            For Each detalle As DetalleFacturaModel In detalles
                                linea += $"linea"
                                ' Continúa agregando campos según las propiedades de la clase DetalleFacturaModel
                            Next

                            ' Escribe la línea en el archivo
                            writer.WriteLine(linea)
                        Next

                        ' El archivo se generó con éxito, muestra un mensaje de confirmación
                        MessageBox.Show("El archivo se ha generado con éxito.", "Generación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As UnauthorizedAccessException
                    ' Manejo de la excepción de acceso denegado
                    MessageBox.Show("Acceso denegado para crear el archivo o guardar en la ubicación. Verifique los permisos de acceso a la ubicación.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As IOException
                    ' Manejo de excepción de escritura de archivo
                    MessageBox.Show("Ocurrió un error al escribir en el archivo: " & ex.Message, "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    ' Manejo de otras excepciones generales
                    MessageBox.Show("Ocurrió un error al generar o guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ' La factura no existe, muestra un mensaje de error
                MessageBox.Show("La factura no existe en la base de datos.", "Factura no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub
End Class
