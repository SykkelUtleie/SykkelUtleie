Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Administrering_av_database
    Private b As New Sporring
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b.opprett()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
        Form1.Show()
    End Sub
End Class