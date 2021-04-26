Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class BusquedaCliente
    Dim dv As New DataView
    Private Sub BusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCLientes()

    End Sub

    Private Sub CargaCLientes()
        Dim Basededatos As New MySqlConnectionStringBuilder()
        Basededatos.Server = LoginForm1.cmbservidormysql.Text
        Basededatos.UserID = LoginForm1.cmbusuariodb.Text
        Basededatos.Password = LoginForm1.CmbClavedb.Text
        Basededatos.Database = LoginForm1.CmbBasedeDatos.Text
        Dim conn As New MySqlConnection(Basededatos.ToString())
        conn.Open()

        Dim dt As MySqlDataAdapter
        Dim ds As DataSet

        Dim consulta As String
        consulta = "SELECT * FROM CLIENTES"
        dt = New MySqlDataAdapter(consulta, conn)
        ds = New DataSet
        dt.Fill(ds, "CLIENTES")

        dv.Table = ds.Tables(0)
        'cargo los datos de la tabla del dataset al dataview
        DataGridView1.DataSource = dv
        cmbidcliente.DataSource = dv
        cmbidcliente.DisplayMember = "idclient"
        Cmbcliente.DataSource = dv
        Cmbcliente.DisplayMember = "name"


        ' dgvProductos.Columns("IMAGEN").Width = 200


    End Sub

    Private Sub txtNombreCompleto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCompleto.TextChanged
        dv.RowFilter = String.Format("name Like '%{0}%'", txtNombreCompleto.Text)
    End Sub

    Private Sub BusquedaCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btnBusquedaCliente.Text = "Nueva Conexion" Then
            NuevaConexion.lblcliente.Text = Cmbcliente.Text
            NuevaConexion.lblidcliente.Text = cmbidcliente.Text

        End If
    End Sub
End Class