Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1
    Private b As New Sporring
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As Date = Date.Now
        Label6.Text = d.ToString("dd.MM.yyyy")
        b.oversikt()
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
    Private Sub SøkIKundebaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIKundebaseToolStripMenuItem.Click
        Sok_i_kundebase.Show()
        Hide()
    End Sub
    Private Sub SlettKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettKundeToolStripMenuItem.Click
        Slett_kunde.Show()
        Hide()
    End Sub
    Private Sub RegistreringAvNySykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistreringAvNySykkelToolStripMenuItem.Click
        Registrering_av_ny_sykkel.Show()
        Hide()
    End Sub
    Private Sub SøkISykkelbaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkISykkelbaseToolStripMenuItem.Click
        Sok_i_sykkelbase.Show()
        Hide()
    End Sub
    Private Sub BestillingAvSyklerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingAvSyklerToolStripMenuItem.Click
        Bestilling_og_tilbakelevering_av_sykler.Show()
        Hide()
    End Sub
    Private Sub ReparasjonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReparasjonToolStripMenuItem.Click
        Reparasjon.Show()
        Hide()
    End Sub
    Private Sub SlettSykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettSykkelToolStripMenuItem.Click
        Slett_sykkel.Show()
        Hide()
    End Sub
    Private Sub RegistreringAvNyUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistreringAvNyUtstyrToolStripMenuItem.Click
        Registrering_av_nytt_utstyr.Show()
        Hide()
    End Sub
    Private Sub SøkIUrtstyrbaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIUrtstyrbaseToolStripMenuItem.Click
        Sok_i_utstyrbase.Show()
        Hide()
    End Sub
    Private Sub BestillingOgTilbakeleveringAvUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingOgTilbakeleveringAvUtstyrToolStripMenuItem.Click
        Bestilling_og_tilbakelevering_av_utstyr.Show()
        Hide()
    End Sub
    Private Sub SlettUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettUtstyrToolStripMenuItem.Click
        Slett_utstyr.Show()
        Hide()
    End Sub
    Private Sub AdministreringAvDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministreringAvDatabaseToolStripMenuItem.Click
        Administrering_av_database.Show()
        Hide()
    End Sub
    Private Sub AVSLUTTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AVSLUTTToolStripMenuItem.Click
        End
    End Sub
#End Region


End Class
