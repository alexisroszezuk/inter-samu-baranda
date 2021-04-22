Imports MySql.Data.MySqlClient
Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.


    Private Sub CompruebaUsuario()
        Dim Basededatos As New MySqlConnectionStringBuilder()
        Basededatos.Server = cmbservidormysql.Text
        Basededatos.UserID = cmbusuariodb.Text
        Basededatos.Password = CmbClavedb.Text
        Basededatos.Database = CmbBasedeDatos.Text
        Dim con As New MySqlConnection(Basededatos.ToString())

        Try
            con.Open()
            Dim comando As MySqlCommand = New MySqlCommand
            comando.Connection = con

            comando.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO ='" + TxtUsuario.Text + "' and PASSWORD = '" + TxtPassword.Text + "'"
            Dim r As MySqlDataReader

            r = comando.ExecuteReader

            If r.HasRows <> False Then
                r.Read()
                'MsgBox(r.GetString("usuario"))
                Form1.Show()
                Form1.LBLUSUARIO.Text = r.GetString("USUARIO")
                Form1.LBLIDUSUARIO.Text = r.GetString("IDUSUARIO")
                con.Close()
                Me.Hide()

            Else
                MsgBox("Acceso Incorrecto")
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("no se pudo conectar")
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub





    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaServidores()
    End Sub
    Private Sub CargaServidores()
        conn2.Open()
        Dim adaptadorPP As MySqlDataAdapter
        Dim dsDPc As DataSet
        Dim lista As Byte
        Dim consulta As String
        consulta = "SELECT * FROM servidores"
        adaptadorPP = New MySqlDataAdapter(consulta, conn2)
        dsDPc = New DataSet
        adaptadorPP.Fill(dsDPc, "servidores")
        lista = dsDPc.Tables("servidores").Rows.Count
        If lista <> 0 Then

            Me.CmbBasedeDatos.DataSource = dsDPc.Tables("servidores")
            Me.CmbBasedeDatos.DisplayMember = "database"
            Me.cmbIpRouterBoard.DataSource = dsDPc.Tables("servidores")
            Me.cmbIpRouterBoard.DisplayMember = "ip_routerboard"
            Me.CmbClaveRouter.DataSource = dsDPc.Tables("servidores")
            Me.CmbClaveRouter.DisplayMember = "password"
            Me.CmbUsuarioRouter.DataSource = dsDPc.Tables("servidores")
            Me.CmbUsuarioRouter.DisplayMember = "usuariorb"
            Me.CmbEstado.DataSource = dsDPc.Tables("servidores")
            Me.CmbEstado.DisplayMember = "estado"
            Me.cmbservidormysql.DataSource = dsDPc.Tables("servidores")
            Me.cmbservidormysql.DisplayMember = "ip_servidor_mysql"
            Me.CmbClavedb.DataSource = dsDPc.Tables("servidores")
            Me.CmbClavedb.DisplayMember = "passworddb"
            Me.cmbusuariodb.DataSource = dsDPc.Tables("servidores")
            Me.cmbusuariodb.DisplayMember = "usuario"

            conn2.Close()
        Else
            'MsgBox("LA CUENTA DE FACTURAS SE ABRIO EXITOSAMENTE", vbCritical, "ATENCIÓN")
            conn2.Close()
        End If
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        CompruebaUsuario()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If TxtPassword.Text = "" Then
                TxtPassword.BackColor = Color.Red
                TxtPassword.Focus()
            Else
                CompruebaUsuario()
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If TxtUsuario.Text = "" Then
                TxtUsuario.BackColor = Color.Red
                TxtUsuario.Focus()
            Else
                CompruebaUsuario()
            End If
        End If
    End Sub
End Class
