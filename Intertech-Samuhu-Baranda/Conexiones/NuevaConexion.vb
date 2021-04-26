Imports MySql.Data.MySqlClient


Public Class NuevaConexion



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        BusquedaCliente.btnBusquedaCliente.Text = "Nueva Conexion"
        BusquedaCliente.Show()
        BusquedaCliente.Focus()
    End Sub
End Class