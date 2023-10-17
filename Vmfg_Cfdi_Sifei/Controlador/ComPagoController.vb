Imports System.IO
Imports System.Data.SqlClient

Public Class ComPagoController
    Public Sub GenerarArchivoTxt(numeroCobro As String, rutaArchivo As String)

        ' Conexión a la base de datos SQL Server
        Dim connectionString As String = "Server=" & modHome.mssqlsrv & ";Database=" & modHome.mssqldb & ";User Id=" & modHome.mssqlusr & ";Password=" & modHome.mssqlpas & ";"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Verifica si la cobro existe
            Dim facturaExiste As Boolean = False
            Using cmdExistencia As New SqlCommand("sp_VerificarExistenciaCobro", connection)
                cmdExistencia.CommandType = CommandType.StoredProcedure
                cmdExistencia.Parameters.AddWithValue("@DEPOSIT_ID", numeroCobro)
                Dim resultadoExistencia As Object = cmdExistencia.ExecuteScalar()

                If resultadoExistencia IsNot Nothing AndAlso resultadoExistencia IsNot DBNull.Value Then
                    facturaExiste = Convert.ToBoolean(resultadoExistencia)
                End If
            End Using

            If facturaExiste Then
                ' Ejecuta el procedimiento almacenado y obtiene los datos de CobroModel
                Dim cobroData As New List(Of FacturaModel)()
                Using cmd As New SqlCommand("sp_ObtenerCfdiPago", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@DEPOSIT_ID", numeroCobro)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim cobro As New FacturaModel()
                            ' Rellena los datos de FacturaModel

                            cobro.NumeroFactura = numeroCobro

                            If Not reader.IsDBNull(0) Then
                                cobro.Campo0 = reader.GetString(0)
                            End If

                            If Not reader.IsDBNull(1) Then
                                cobro.Campo1 = reader.GetString(1)
                            End If

                            If Not reader.IsDBNull(2) Then
                                cobro.Campo2 = reader.GetString(2)
                            End If

                            If Not reader.IsDBNull(3) Then
                                cobro.Campo3 = reader.GetString(3)
                            End If

                            If Not reader.IsDBNull(4) Then
                                cobro.Campo4 = reader.GetString(4)
                            End If

                            If Not reader.IsDBNull(5) Then
                                cobro.Campo5 = reader.GetString(5)
                            End If

                            If Not reader.IsDBNull(6) Then
                                cobro.Campo6 = reader.GetString(6)
                            End If

                            If Not reader.IsDBNull(7) Then
                                cobro.Campo7 = reader.GetString(7)
                            End If

                            If Not reader.IsDBNull(8) Then
                                cobro.Campo7 = reader.GetString(8)
                            End If

                            If Not reader.IsDBNull(9) Then
                                cobro.Campo7 = reader.GetString(9)
                            End If
                            If Not reader.IsDBNull(10) Then
                                cobro.Campo10 = reader.GetString(10)
                            End If
                            If Not reader.IsDBNull(11) Then
                                cobro.Campo10 = reader.GetString(11)
                            End If
                            If Not reader.IsDBNull(12) Then
                                cobro.Campo12 = reader.GetDecimal(12)
                            End If
                            If Not reader.IsDBNull(13) Then
                                cobro.Campo13 = reader.GetString(13)
                            End If
                            If Not reader.IsDBNull(14) Then
                                cobro.Campo14 = reader.GetString(14)
                            End If
                            If Not reader.IsDBNull(15) Then
                                cobro.Campo15 = reader.GetString(15)
                            End If
                            If Not reader.IsDBNull(16) Then
                                cobro.Campo16 = reader.GetString(16)
                            End If
                            If Not reader.IsDBNull(17) Then
                                cobro.Campo17 = reader.GetString(17)
                            End If
                            If Not reader.IsDBNull(18) Then
                                cobro.Campo18 = reader.GetString(18)
                            End If
                            If Not reader.IsDBNull(19) Then
                                cobro.Campo19 = reader.GetString(19)
                            End If
                            If Not reader.IsDBNull(20) Then
                                cobro.Campo20 = reader.GetString(20)
                            End If
                            If Not reader.IsDBNull(21) Then
                                cobro.Campo21 = reader.GetString(21)
                            End If
                            If Not reader.IsDBNull(22) Then
                                cobro.Campo22 = reader.GetString(22)
                            End If
                            If Not reader.IsDBNull(23) Then
                                cobro.Campo23 = reader.GetString(23)
                            End If
                            If Not reader.IsDBNull(24) Then
                                cobro.Campo24 = reader.GetString(24)
                            End If
                            If Not reader.IsDBNull(25) Then
                                cobro.Campo25 = reader.GetString(25)
                            End If
                            If Not reader.IsDBNull(26) Then
                                cobro.Campo26 = reader.GetString(26)
                            End If
                            If Not reader.IsDBNull(27) Then
                                cobro.Campo27 = reader.GetString(27)
                            End If
                            If Not reader.IsDBNull(28) Then
                                cobro.Campo28 = reader.GetString(28)
                            End If
                            If Not reader.IsDBNull(29) Then
                                cobro.Campo29 = reader.GetString(29)
                            End If
                            If Not reader.IsDBNull(30) Then
                                cobro.Campo30 = reader.GetString(30)
                            End If
                            If Not reader.IsDBNull(31) Then
                                cobro.Campo31 = reader.GetString(31)
                            End If
                            If Not reader.IsDBNull(32) Then
                                cobro.Campo32 = reader.GetString(32)
                            End If
                            If Not reader.IsDBNull(33) Then
                                cobro.Campo33 = reader.GetString(33)
                            End If
                            If Not reader.IsDBNull(34) Then
                                cobro.Campo34 = reader.GetString(34)
                            End If
                            If Not reader.IsDBNull(35) Then
                                cobro.Campo35 = reader.GetString(35)
                            End If
                            If Not reader.IsDBNull(36) Then
                                cobro.Campo36 = reader.GetString(36)
                            End If
                            If Not reader.IsDBNull(37) Then
                                cobro.Campo37 = reader.GetString(37)
                            End If
                            If Not reader.IsDBNull(38) Then
                                cobro.Campo38 = reader.GetString(38)
                            End If
                            If Not reader.IsDBNull(39) Then
                                cobro.Campo39 = reader.GetString(39)
                            End If
                            If Not reader.IsDBNull(40) Then
                                cobro.Campo40 = reader.GetString(40)
                            End If
                            If Not reader.IsDBNull(41) Then
                                cobro.Campo41 = reader.GetString(41)
                            End If
                            If Not reader.IsDBNull(42) Then
                                cobro.Campo42 = reader.GetString(42)
                            End If
                            If Not reader.IsDBNull(43) Then
                                cobro.Campo43 = reader.GetString(43)
                            End If
                            If Not reader.IsDBNull(44) Then
                                cobro.Campo44 = reader.GetString(44)
                            End If
                            If Not reader.IsDBNull(45) Then
                                cobro.Campo45 = reader.GetString(45)
                            End If
                            If Not reader.IsDBNull(46) Then
                                cobro.Campo46 = reader.GetString(46)
                            End If
                            If Not reader.IsDBNull(47) Then
                                cobro.Campo47 = reader.GetString(47)
                            End If
                            If Not reader.IsDBNull(48) Then
                                cobro.Campo48 = reader.GetString(48)
                            End If
                            If Not reader.IsDBNull(49) Then
                                cobro.Campo49 = reader.GetString(49)
                            End If
                            If Not reader.IsDBNull(50) Then
                                cobro.Campo50 = reader.GetString(50)
                            End If
                            If Not reader.IsDBNull(51) Then
                                cobro.Campo51 = reader.GetString(51)
                            End If
                            If Not reader.IsDBNull(52) Then
                                cobro.Campo52 = reader.GetString(52)
                            End If
                            If Not reader.IsDBNull(53) Then
                                cobro.Campo53 = reader.GetString(53)
                            End If
                            If Not reader.IsDBNull(54) Then
                                cobro.Campo54 = reader.GetDecimal(54)
                            End If
                            If Not reader.IsDBNull(55) Then
                                cobro.Campo55 = reader.GetDecimal(55)
                            End If
                            If Not reader.IsDBNull(56) Then
                                cobro.Campo56 = reader.GetString(56)
                            End If
                            If Not reader.IsDBNull(57) Then
                                cobro.Campo57 = reader.GetString(57)
                            End If
                            If Not reader.IsDBNull(58) Then
                                cobro.Campo58 = reader.GetString(58)
                            End If
                            If Not reader.IsDBNull(59) Then
                                cobro.Campo59 = reader.GetString(59)
                            End If
                            If Not reader.IsDBNull(60) Then
                                cobro.Campo60 = reader.GetString(60)
                            End If
                            If Not reader.IsDBNull(61) Then
                                cobro.Campo61 = reader.GetString(61)
                            End If
                            If Not reader.IsDBNull(62) Then
                                cobro.Campo62 = reader.GetString(62)
                            End If
                            If Not reader.IsDBNull(63) Then
                                cobro.Campo63 = reader.GetString(63)
                            End If
                            If Not reader.IsDBNull(64) Then
                                cobro.Campo64 = reader.GetString(64)
                            End If
                            cobroData.Add(cobro)
                        End While
                    End Using
                End Using
                ' Ejecuta el procedimiento almacenado y obtiene los datos de DetalleFacturaModel
                Dim detalleData As New List(Of DetalleFacturaModel)()
                Using cmd As New SqlCommand("sp_ObtenerCfdiPagoDetalle", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@DEPOSIT_ID", numeroCobro)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim facturaDet As New DetalleFacturaModel()
                            ' Rellena los datos de DetalleFacturaModel
                            facturaDet.NumeroFactura = numeroCobro
                            If Not reader.IsDBNull(0) Then
                                facturaDet.Campo0 = reader.GetString(0)
                            End If

                            If Not reader.IsDBNull(1) Then
                                facturaDet.Campo1 = reader.GetInt16(1)
                            End If

                            If Not reader.IsDBNull(2) Then
                                facturaDet.Campo2 = reader.GetDecimal(2)
                            End If
                            If Not reader.IsDBNull(3) Then
                                facturaDet.Campo3 = reader.GetString(3)
                            End If
                            If Not reader.IsDBNull(4) Then
                                facturaDet.Campo4 = reader.GetString(4)
                            End If
                            If Not reader.IsDBNull(5) Then
                                facturaDet.Campo5 = reader.GetString(5)
                            End If
                            If Not reader.IsDBNull(6) Then
                                facturaDet.Campo6 = reader.GetString(6)
                            End If
                            If Not reader.IsDBNull(7) Then
                                facturaDet.Campo7 = reader.GetString(7)
                            End If
                            If Not reader.IsDBNull(8) Then
                                facturaDet.Campo8 = reader.GetDecimal(8)
                            End If
                            If Not reader.IsDBNull(9) Then
                                facturaDet.Campo9 = reader.GetString(9)
                            End If
                            If Not reader.IsDBNull(10) Then
                                facturaDet.Campo10 = reader.GetDecimal(10)
                            End If
                            If Not reader.IsDBNull(11) Then
                                facturaDet.Campo11 = reader.GetString(11)
                            End If
                            If Not reader.IsDBNull(12) Then
                                facturaDet.Campo12 = reader.GetString(12)
                            End If
                            If Not reader.IsDBNull(13) Then
                                facturaDet.Campo13 = reader.GetString(13)
                            End If
                            If Not reader.IsDBNull(14) Then
                                facturaDet.Campo14 = reader.GetString(14)
                            End If
                            If Not reader.IsDBNull(15) Then
                                facturaDet.Campo15 = reader.GetDecimal(15)
                            End If
                            If Not reader.IsDBNull(16) Then
                                facturaDet.Campo16 = reader.GetString(16)
                            End If
                            If Not reader.IsDBNull(17) Then
                                facturaDet.Campo17 = reader.GetString(17)
                            End If
                            If Not reader.IsDBNull(18) Then
                                facturaDet.Campo18 = reader.GetString(18)
                            End If
                            If Not reader.IsDBNull(19) Then
                                facturaDet.Campo19 = reader.GetDecimal(19)
                            End If

                            detalleData.Add(facturaDet)
                        End While
                    End Using
                End Using
                Try
                    ' Genera el archivo de texto
                    Using writer As New StreamWriter(rutaArchivo)
                        For Each factura As FacturaModel In cobroData
                            Dim linea As String = $"{factura.Campo0}|{factura.Campo1}|{factura.Campo2}|{factura.Campo3}" +
                                $"|{factura.Campo4}|{factura.Campo5}|{factura.Campo6}|{factura.Campo7}|{factura.Campo8}|{factura.Campo9}" +
                                $"|{factura.Campo10}|{factura.Campo11}|{factura.Campo12}|{factura.Campo13}|{factura.Campo14}|{factura.Campo15}" +
                                $"|{factura.Campo16}|{factura.Campo17}|{factura.Campo18}|{factura.Campo19}|{factura.Campo20}|{factura.Campo21}" +
                                $"|{factura.Campo22}|{factura.Campo23}|{factura.Campo24}|{factura.Campo25}|{factura.Campo26}|{factura.Campo27}" +
                                $"|{factura.Campo28}|{factura.Campo29}|{factura.Campo30}|{factura.Campo31}|{factura.Campo32}|{factura.Campo33}" +
                                $"|{factura.Campo34}|{factura.Campo35}|{factura.Campo36}" & vbCrLf &
                                $"{factura.Campo37}|{factura.Campo38}|{factura.Campo39}|{factura.Campo40}|{factura.Campo41}|" +
                                $"{factura.Campo42}|{factura.Campo43}|{factura.Campo44}|{factura.Campo45}|{factura.Campo46}|{factura.Campo47}|{factura.Campo48}" & vbCrLf

                            For Each facturad As DetalleFacturaModel In detalleData
                                linea += $"{facturad.Campo0}|{facturad.Campo1}|{facturad.Campo2}|{facturad.Campo3}|{facturad.Campo4}|{facturad.Campo5}" +
                                    $"|{facturad.Campo6}|{facturad.Campo7}|{facturad.Campo8}|{facturad.Campo9}|{facturad.Campo10}" +
                                    $"|{facturad.Campo11}|{facturad.Campo12}" & vbCrLf +
                                    $"{facturad.Campo13}|{facturad.Campo14}|{facturad.Campo15}|{facturad.Campo16}|{facturad.Campo17}" +
                                    $"|{facturad.Campo18}|{facturad.Campo19}" & vbCrLf


                                ' Busca los datos correspondientes en los detalles de la cobro
                                ' Verifica si hay detalles para la cobro actual
                                'Dim detalles As List(Of DetalleDetalleFacturaModel) = facturaDetalleData.Where(Function(detalle) detalle.NumeroFactura = cobro.NumeroFactura).ToList()
                                'Dim detalles As List(Of DetalleDetalleFacturaModel)
                            Next
                            linea += $"{factura.Campo49}|{factura.Campo50}|{factura.Campo51}|{factura.Campo52}|{factura.Campo53}|{factura.Campo54}|{factura.Campo55}" & vbCrLf &
                                $"{factura.Campo56}|{factura.Campo57}|{factura.Campo58}|{factura.Campo59}|" & vbCrLf &
                                $"{factura.Campo60}|{factura.Campo61}|{factura.Campo62}|{factura.Campo63}|{factura.Campo64}"

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
                ' La cobro no existe, muestra un mensaje de error
                MessageBox.Show("La cobro no existe en la base de datos.", "Factura no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub
End Class
