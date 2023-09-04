Public Class Inicio
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

        Label1.Text = "Server: " & mssqlsrv & " DB: " & mssqldb & " User: " & mssqlusr

    End Sub

    Private Sub CertificadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadoToolStripMenuItem.Click
        Dim formSellos As New formSellos()
        formSellos.Show()
    End Sub
End Class
