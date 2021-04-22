Imports MySql.Data.MySqlClient
Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        NuevoCliente.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.BtnClientes.IconColor = Color.Aqua
        cargaClientes()
    End Sub

    Private Sub Clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.BtnClientes.IconColor = Color.White

    End Sub

    Private Sub btnNuevoCLiente_Click(sender As Object, e As EventArgs) Handles btnNuevoCLiente.Click
        NuevoCliente.Show()
        NuevoCliente.Focus()

    End Sub


    Public Sub cargaClientes()
        Dim Basededatos As New MySqlConnectionStringBuilder()
        Basededatos.Server = LoginForm1.cmbservidormysql.Text
        Basededatos.UserID = LoginForm1.cmbusuariodb.Text
        Basededatos.Password = LoginForm1.CmbClavedb.Text
        Basededatos.Database = LoginForm1.CmbBasedeDatos.Text
        Dim con As New MySqlConnection(Basededatos.ToString())

        Dim adaptadorPP As MySqlDataAdapter
        Dim dsDPc As DataSet
        Dim lista As Byte
        Dim consulta As String
        consulta = "SELECT * FROM CLIENTES"
        adaptadorPP = New MySqlDataAdapter(consulta, con)
        dsDPc = New DataSet
        adaptadorPP.Fill(dsDPc, "CLIENTES")
        lista = dsDPc.Tables("CLIENTES").Rows.Count
        If lista <> 0 Then
            DataGridView1.DataSource = dsDPc.Tables("CLIENTES")

        Else
            MsgBox("No se puede Cargar La tabla Clientes", vbCritical, "ATENCIÓN")
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Close()
        Form1.Focus()

    End Sub
End Class