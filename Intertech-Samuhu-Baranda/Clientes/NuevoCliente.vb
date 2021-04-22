Imports MySql.Data.MySqlClient
Public Class NuevoCliente
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnGuardar.Enabled = False
        GuardarCliente()
    End Sub
    Private Sub GuardarCliente()
        Dim Basededatos As New MySqlConnectionStringBuilder()
        Basededatos.Server = LoginForm1.cmbservidormysql.Text
        Basededatos.UserID = LoginForm1.cmbusuariodb.Text
        Basededatos.Password = LoginForm1.CmbClavedb.Text
        Basededatos.Database = LoginForm1.CmbBasedeDatos.Text
        Dim con As New MySqlConnection(Basededatos.ToString())
        con.Open()
        Try
            'Abrimos la conexión


            'Guardamos solo 4 campos
            Dim str As String
            str = "insert into CLIENTES (name,address,phone,dni,city,province,email,observacion,iduser,pc,date,mouth) values (?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As MySqlCommand = New MySqlCommand(str, con)

            cmd.Parameters.Add(New MySqlParameter("name", CType(txtNombreCompleto.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("address", CType(txtDomicilio.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("phone", CType(txtCelular.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("dni", CType(TxtDni.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("city", CType(TxtCiudad.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("province", CType(TxtProvincia.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("email", CType(TxtEmail.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("observacion", CType(TxtObservacion.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("iduser", CType(Form1.LBLIDUSUARIO.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("pc", CType(Form1.lblpunto_de_venta.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("date", CType(Form1.lblfecha.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("mouth", CType(Form1.LBLMES.Text, String)))

            cmd.ExecuteNonQuery()
            MsgBox("La información se guardo correctamente..!", MsgBoxStyle.Information, "Registro de Gastos")
            con.Close()
            Clientes.cargaClientes()
            Me.Close()
            Clientes.Focus()

            'Cerramos la conexión
        Catch ex As Exception
            ex.Message.ToUpper()
            MsgBox(ex.Message)
            con.Close()

        End Try
    End Sub

    Private Sub NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clientes.btnNuevoCLiente.IconColor = Color.Aqua

    End Sub

    Private Sub NuevoCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Clientes.btnNuevoCLiente.IconColor = Color.White
    End Sub
End Class