Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Clientes.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strComputerName As String = Environment.MachineName.ToString()
        lblpunto_de_venta.Text = strComputerName
        Timer1.Start()
        Me.lblfecha.Text = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Me.lblhora.Text = DateTimePicker1.Value.ToString("HH:mm:ss")
        Me.LBLMES.Text = DateTimePicker1.Value.ToString("yyyy/MM")
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Clientes.Show()
        Clientes.Focus()


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnConexiones.Click
        Conexiones.Show()
        Conexiones.Focus()
    End Sub
End Class
