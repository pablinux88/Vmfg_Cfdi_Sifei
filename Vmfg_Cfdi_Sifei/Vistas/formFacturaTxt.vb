Public Class formFacturaTxt
    Sub validar()
        If NumeroFacturaTextBox.Text = String.Empty Then
            GenerarArchivoButton.Enabled = False
        Else
            GenerarArchivoButton.Enabled = True
        End If
    End Sub

    Dim facturaController As New FacturaController()

    Private Sub GenerarArchivoButton_Click(sender As Object, e As EventArgs) Handles GenerarArchivoButton.Click

        Dim numeroFactura As String = NumeroFacturaTextBox.Text
        Dim rutaArchivo As String = RutaArchivoTextBox.Text + "\" + NumeroFacturaTextBox.Text + ".txt"


        facturaController.GenerarArchivoTxt(numeroFactura, rutaArchivo)

    End Sub

    Private Sub CarpetaButton_Click(sender As Object, e As EventArgs) Handles CarpetaButton.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            RutaArchivoTextBox.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub formFacturaTxt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validar()
    End Sub

    Private Sub NumeroFacturaTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumeroFacturaTextBox.TextChanged
        validar()
    End Sub
End Class