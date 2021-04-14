Imports MySql.Data.MySqlClient

Module Conexion
    Public conn As New MySqlConnection("Server='" + Form1.txtservidor.Text + "'; User Id=superalexis; Password=i7UoksT3tQFNsema; Database='" + Form1.txtbasededatos.Text + "'")
    Public conn2 As New MySqlConnection("Server=192.168.248.3; User Id=superalexis; Password=i7UoksT3tQFNsema; Database=serverinfo")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String = ""
    Public Sub conectarse()
        Try
            conn2.Open()
            MsgBox("conexión exitosa con la base de datos - Saludos De INTERTECH-SOFTWARE -", MsgBoxStyle.Information, "PROGRAMADOR")
        Catch ex As Exception
            If ex.ToString.Contains("no se puede usar") Then
                MsgBox(" USANDO OTRA COMPU")
            End If
            MsgBox(ex.ToString)
        End Try
    End Sub


End Module
