Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClientes.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.lblfecha.Text = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Me.lblhora.Text = DateTimePicker1.Value.ToString("HH:mm:ss")
        Me.LBLMES.Text = DateTimePicker1.Value.ToString("yyyy/MM")
    End Sub
End Class
