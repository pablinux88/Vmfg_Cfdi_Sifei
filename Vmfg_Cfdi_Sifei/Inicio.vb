Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataBase = modHome.dataBase
        Dim objIniFile As New clsIni(modHome.fSettings)

        modHome.mssqlsrv = objIniFile.GetString(dataBase, "SERVER", "")
        modHome.mssqldb = objIniFile.GetString(dataBase, "DB", "")
        modHome.mssqlusr = objIniFile.GetString(dataBase, "USER", "")
        modHome.mssqlpas = objIniFile.GetString(dataBase, "PASS", "")

        Label1.Text = "Server: " & mssqlsrv & " DB: " & mssqldb & " User: " & mssqlusr

    End Sub
End Class
