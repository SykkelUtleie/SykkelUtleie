Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Administrering_av_database

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Database.Show()
        Close()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Statistikk.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Brukere.Show()
        Close()
    End Sub
End Class