Imports System.Windows.Forms
Public Class Inicio

    Private uuid As New UuidModel()
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(modHome.fSettings) = True Then
        Else
            MenuStrip.Enabled = False
            MsgBox("No existe el archivo en la ruta: " & modHome.fSettings)
            'Application.ExitThread()
        End If

        Dim dataBase = modHome.dataBase
        Dim objIniFile As New clsIni(modHome.fSettings)

        modHome.mssqlsrv = objIniFile.GetString(dataBase, "SERVER", "")
        modHome.mssqldb = objIniFile.GetString(dataBase, "DB", "")
        modHome.mssqlusr = objIniFile.GetString(dataBase, "USER", "")
        modHome.mssqlpas = objIniFile.GetString(dataBase, "PASS", "")

        modHome.mariadbsrv = objIniFile.GetString(dataBase, "MARIASRV", "")
        modHome.mariadb = objIniFile.GetString(dataBase, "MARIADB", "")
        modHome.mariadbusr = objIniFile.GetString(dataBase, "MARIAUSR", "")
        modHome.mariadbpas = objIniFile.GetString(dataBase, "MARIAPAS", "")

        Label1.Text = "Server: " & mssqlsrv & " DB: " & mssqldb & " User: " & mssqlusr

        Label2.Text = "Server: " & mariadbsrv & " DB: " & mariadb & " User: " & mariadbusr

    End Sub

    Private Sub CertificadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadoToolStripMenuItem.Click
        Dim formSellos As New formSellos()
        formSellos.Show()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaciónToolStripMenuItem.Click
        Dim formSellos As New formFacturaTxt()
        formSellos.Show()
    End Sub
    Private Sub CFDISifeiAVMFGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFDISifeiAVMFGToolStripMenuItem.Click
        ' Crear una instancia del controlador
        Dim uuidController As New UuidController()

        ' Llamar al método IniciarMonitoreo del controlador y pasar la ProgressBar
        uuidController.IniciarMonitoreo(ProgressBar) ' Asegúrate de que ProgressBar1 sea el nombre correcto de tu ProgressBar
    End Sub
End Class
