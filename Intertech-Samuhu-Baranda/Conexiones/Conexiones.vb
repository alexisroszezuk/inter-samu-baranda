Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class Conexiones
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Close()
        Form1.Focus()

    End Sub

    Private Sub Conexiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.btnConexiones.IconColor = Color.Aqua
    End Sub

    Private Sub Conexiones_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.btnConexiones.IconColor = Color.White
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
        consulta = "SELECT * FROM CONEXIONES"
        adaptadorPP = New MySqlDataAdapter(consulta, con)
        dsDPc = New DataSet
        adaptadorPP.Fill(dsDPc, "CONEXIONES")
        lista = dsDPc.Tables("CONEXIONES").Rows.Count
        If lista <> 0 Then
            DataGridView1.DataSource = dsDPc.Tables("CONEXIONES")

        Else
            MsgBox("No se puede Cargar La tabla Clientes", vbCritical, "ATENCIÓN")
            con.Close()
        End If
        con.Close()
    End Sub
End Class