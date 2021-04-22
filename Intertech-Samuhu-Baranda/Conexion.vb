Imports MySql.Data.MySqlClient

Module Conexion



    Public Sub Conectarse()
        Try


            MsgBox("Se Realizo Correctamente la conexion")
        Catch ex As Exception
            MsgBox("Nose puede conectar" & ex.Message)
        End Try
    End Sub
    Public Sub desconectarse()

    End Sub


    Public conn2 As New MySqlConnection("Server=192.168.248.3; User Id=superalexis; Password=i7UoksT3tQFNsema; Database=serverinfo")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String = ""



End Module
