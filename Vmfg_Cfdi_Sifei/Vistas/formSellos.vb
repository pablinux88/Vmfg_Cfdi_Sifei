Imports System.Data
Imports System.Data.SqlClient
Public Class formSellos
    Private controlador As SelloController

    Public Sub New()
        InitializeComponent()
        controlador = New SelloController()
        CargarSellos()
    End Sub

    Private Sub CargarSellos()
        Dim sellos As DataTable = controlador.ObtenerSellos()
        DataGridSellos.DataSource = sellos
    End Sub

    Private Sub LimpiarCampos()
        TextBoxRow.Clear()
        TextBoxID.Clear()
        TextBoxVigencia.Clear()
        TextBoxEstatus.Clear()
    End Sub
    Private Sub DataGridViewClientes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridSellos.SelectionChanged
        If DataGridSellos.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridSellos.SelectedRows(0)
            TextBoxRow.Text = filaSeleccionada.Cells("ROW").Value.ToString()
            TextBoxID.Text = filaSeleccionada.Cells("ID").Value.ToString()
            TextBoxVigencia.Text = filaSeleccionada.Cells("Vigencia").Value.ToString()
            TextBoxEstatus.Text = filaSeleccionada.Cells("Estatus").Value.ToString()

        End If
    End Sub

    Private Sub formSellos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el DataGridView para ajustar automáticamente las columnas
        DataGridSellos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Configura el DataGridView para ajustar automáticamente las filas
        DataGridSellos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim id As String = TextBoxID.Text
        Dim vigencia As String = TextBoxVigencia.Text
        Dim estatus As String = TextBoxEstatus.Text

        controlador.InsertarSello(id, vigencia, estatus)

        LimpiarCampos()
        CargarSellos()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim id As String = TextBoxID.Text
        Dim vigencia As String = TextBoxVigencia.Text
        Dim estatus As String = TextBoxEstatus.Text

        controlador.ActualizarSello(id, vigencia, estatus)

        LimpiarCampos()
        CargarSellos()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim row As Integer = Convert.ToInt32(TextBoxRow.Text)
        controlador.EliminarSello(row)

        LimpiarCampos()
        CargarSellos()
    End Sub
End Class