Imports MySql.Data.MySqlClient
Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
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
            Me.CmbServidor.DataSource = dsDPc.Tables("servidores")
            Me.CmbServidor.DisplayMember = "ip_servidor_mysql"
            Me.CmbBasedeDatos.DataSource = dsDPc.Tables("servidores")
            Me.CmbBasedeDatos.DisplayMember = "database"
            conn2.Close()
        Else
            'MsgBox("LA CUENTA DE FACTURAS SE ABRIO EXITOSAMENTE", vbCritical, "ATENCIÓN")
            conn2.Close()
        End If
    End Sub
End Class
