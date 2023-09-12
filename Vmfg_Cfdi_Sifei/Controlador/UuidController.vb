Public Class UuidController
    Private _uuidModel As UuidModel

    Public Sub New()
        _uuidModel = New UuidModel()
    End Sub

    Public Sub IniciarMonitoreo()
        ' Inicia el proceso de monitoreo
        _uuidModel.MonitorearFacturas()
    End Sub
End Class
