Public Class SelloController
    Private _modelo As SelloModel

    Public Sub New()
        _modelo = New SelloModel()
    End Sub

    Public Function ObtenerSellos() As DataTable
        Return _modelo.ObtenerSellos()
    End Function

    Public Sub InsertarSello(id As String, vigencia As DateTime, estatus As String)
        _modelo.InsertarSello(id, vigencia, estatus)
    End Sub

    Public Sub ActualizarSello(id As String, vigencia As DateTime, estatus As String)
        _modelo.ActualizarSello(id, vigencia, estatus)
    End Sub
End Class
