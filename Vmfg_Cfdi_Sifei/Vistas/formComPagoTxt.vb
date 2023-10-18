Public Class formComPagoTxt
    Sub validar()
        If NumeroCobroTextBox.Text = String.Empty Or RutaArchivoTextBox.Text = String.Empty Then
            GenerarArchivoButton.Enabled = False
        Else
            GenerarArchivoButton.Enabled = True
        End If
    End Sub

    Dim cobroController As New ComPagoController()

    Private Sub GenerarArchivoButton_Click(sender As Object, e As EventArgs) Handles GenerarArchivoButton.Click

        Dim numeroFactura As String = NumeroCobroTextBox.Text
        Dim rutaArchivo As String = RutaArchivoTextBox.Text + "\" + NumeroCobroTextBox.Text + ".txt"


        cobroController.GenerarArchivoTxt(numeroFactura, rutaArchivo)

    End Sub

    Private Sub CarpetaButton_Click(sender As Object, e As EventArgs) Handles CarpetaButton.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            RutaArchivoTextBox.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub
    Private Sub formComPagoTxt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validar()
    End Sub

    Private Sub RutaArchivoTextBox_TextChanged(sender As Object, e As EventArgs) Handles RutaArchivoTextBox.TextChanged
        validar()
    End Sub

    Private Sub NumeroCobroTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumeroCobroTextBox.TextChanged
        validar()
    End Sub

End Class