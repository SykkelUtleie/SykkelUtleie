Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1
    Private b As New Sporring
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As Date = Date.Now
        Label6.Text = d.ToString("dd.MM.yyyy")
        b.oversikt()
        Label7.Text = b.overK
        Label8.Text = b.overS
        Label9.Text = b.overTU
        Label10.Text = b.overU
    End Sub
#Region "GUI"
    Private Sub EnkeltKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnkeltKundeToolStripMenuItem.Click
        Registrering_av_ny_enkelt_kunde.Show()
        Hide()
    End Sub
    Private Sub GruppefamilieBedrifterOsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruppefamilieBedrifterOsvToolStripMenuItem.Click
        Registrering_av_gruppe.Show()
        Hide()
    End Sub
    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestilling_og_tilbakelevering_av_sykler.Show()
        Hide()
    End Sub
    Private Sub SøkIKundebaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIKundebaseToolStripMenuItem.Click
        Sok_i_kundebase.Show()
        Hide()
    End Sub
    Private Sub SlettKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettKundeToolStripMenuItem.Click
        Slett_kunde.Show()
        Hide()
    End Sub
    Private Sub SykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SykkelToolStripMenuItem.Click
        Sykkel_Utstyr.Show()
        Hide()
    End Sub
    Private Sub AdministreringAvDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministreringAvDatabaseToolStripMenuItem.Click
        Administrering_av_database.Show()
        Hide()
    End Sub
    Private Sub AVSLUTTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AVSLUTTToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub LogUtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogUtToolStripMenuItem.Click
        Tilgang.Show()
        Me.Close()
    End Sub
#End Region

   
End Class
