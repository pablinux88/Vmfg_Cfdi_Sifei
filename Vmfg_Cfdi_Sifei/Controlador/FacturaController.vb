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

                            factura.NumeroFactura = numeroFactura

                            If Not reader.IsDBNull(0) Then
                                factura.Campo0 = reader.GetString(0)
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
                                'factura.Campo9 = reader.GetDecimal(9).ToString()
                                Dim valorCampo9 As String = reader.GetDecimal(9).ToString()

                                If valorCampo9 = "0.00" Then
                                    factura.Campo9 = ""
                                Else
                                    factura.Campo9 = valorCampo9
                                End If
                            End If
                            If Not reader.IsDBNull(10) Then
                                factura.Campo10 = reader.GetString(10).ToString()
                            End If
                            If Not reader.IsDBNull(11) Then
                                'factura.Campo11 = reader.GetDecimal(11).ToString()
                                Dim valorCampo10 As String = reader.GetString(10)
                                Dim valorCampo11 As String = reader.GetDecimal(11).ToString()

                                ' Verifica si el valor del campo es igual a "MXN"
                                If valorCampo10 = "MXN" Then
                                    factura.Campo11 = "1"
                                Else
                                    factura.Campo11 = valorCampo11
                                End If
                            End If
                            If Not reader.IsDBNull(12) Then
                                factura.Campo12 = reader.GetDecimal(12)
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
                                factura.Campo28 = reader.GetString(28)
                            End If
                            If Not reader.IsDBNull(29) Then
                                factura.Campo29 = reader.GetDecimal(29).ToString()
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
                            If Not reader.IsDBNull(48) Then
                                factura.Campo48 = reader.GetString(48)
                            End If
                            If Not reader.IsDBNull(49) Then
                                factura.Campo49 = reader.GetString(49)
                            End If
                            If Not reader.IsDBNull(50) Then
                                factura.Campo50 = reader.GetString(50)
                            End If
                            If Not reader.IsDBNull(51) Then
                                factura.Campo51 = reader.GetString(51)
                            End If
                            If Not reader.IsDBNull(52) Then
                                factura.Campo52 = reader.GetString(52)
                            End If
                            If Not reader.IsDBNull(53) Then
                                factura.Campo53 = reader.GetString(53)
                            End If
                            If Not reader.IsDBNull(54) Then
                                factura.Campo54 = reader.GetDecimal(54)
                            End If
                            If Not reader.IsDBNull(55) Then
                                factura.Campo55 = reader.GetDecimal(55)
                            End If
                            If Not reader.IsDBNull(56) Then
                                factura.Campo56 = reader.GetString(56)
                            End If
                            If Not reader.IsDBNull(57) Then
                                factura.Campo57 = reader.GetString(57)
                            End If
                            If Not reader.IsDBNull(58) Then
                                factura.Campo58 = reader.GetString(58)
                            End If
                            If Not reader.IsDBNull(59) Then
                                factura.Campo59 = reader.GetString(59)
                            End If
                            If Not reader.IsDBNull(60) Then
                                factura.Campo60 = reader.GetString(60)
                            End If
                            If Not reader.IsDBNull(61) Then
                                factura.Campo61 = reader.GetString(61)
                            End If
                            If Not reader.IsDBNull(62) Then
                                factura.Campo62 = reader.GetString(62)
                            End If
                            If Not reader.IsDBNull(63) Then
                                factura.Campo63 = reader.GetString(63)
                            End If
                            If Not reader.IsDBNull(64) Then
                                factura.Campo64 = reader.GetString(64)
                            End If
                            facturaData.Add(factura)
                        End While
                    End Using
                End Using
                ' Ejecuta el procedimiento almacenado y obtiene los datos de DetalleFacturaModel
                Dim detalleData As New List(Of DetalleFacturaModel)()
                Using cmd As New SqlCommand("sp_ObtenerCfdiFacturaDetalle", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@INVOICE_ID", numeroFactura)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim facturaDet As New DetalleFacturaModel()
                            ' Rellena los datos de DetalleFacturaModel
                            facturaDet.NumeroFactura = numeroFactura
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
                        For Each factura As FacturaModel In facturaData
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


                                ' Busca los datos correspondientes en los detalles de la factura
                                ' Verifica si hay detalles para la factura actual
                                'Dim detalles As List(Of DetalleDetalleFacturaModel) = facturaDetalleData.Where(Function(detalle) detalle.NumeroCobro = factura.NumeroCobro).ToList()
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
                ' La factura no existe, muestra un mensaje de error
                MessageBox.Show("La factura no existe en la base de datos.", "Factura no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub
End Class
