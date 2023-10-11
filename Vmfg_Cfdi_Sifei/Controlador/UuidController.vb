Public Class UuidController
    Private _uuidModel As UuidModel

    Public Sub New()
        _uuidModel = New UuidModel()
    End Sub

    Public Sub IniciarMonitoreo(progressBar As ProgressBar)
        ' Inicia el proceso de monitoreo
        _uuidModel.MonitorearFacturas(progressBar)
    End Sub
End Class
