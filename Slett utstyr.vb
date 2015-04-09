Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Slett_utstyr
    Private a As New GUI
    Private kunde As New Kunde
    Private sykkel As New Sykkel
    Private b As New Sporring
    Private hjelp As String
#Region "GUI"

    Private Sub SøkIKundebaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIKundebaseToolStripMenuItem.Click
        Sok_i_kundebase.Show()
        Close()
    End Sub
    Private Sub SlettKundeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SlettKundeToolStripMenuItem.Click
        Slett_kunde.Show()
        Close()
    End Sub
    Private Sub EnkeltKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnkeltKundeToolStripMenuItem.Click
        Endre_kunder.Show()
        Close()
    End Sub
    Private Sub ReparasjonToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReparasjonToolStripMenuItem.Click
        Reparasjon.Show()
        Close()
    End Sub
    Private Sub SøkISykkelbaseToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SøkISykkelbaseToolStripMenuItem.Click
        Sok_i_sykkelbase.Show()
        Close()
    End Sub
    Private Sub GruppefamilieBedrifterOsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruppefamilieBedrifterOsvToolStripMenuItem.Click
        Registrering_av_gruppe.Show()
        Close()
    End Sub
    Private Sub RegistreringAvNySykkelToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RegistreringAvNySykkelToolStripMenuItem.Click
        Registrering_av_ny_sykkel.Show()
        Close()
    End Sub
    Private Sub SlettSykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettSykkelToolStripMenuItem.Click
        Slett_sykkel.Show()
        Close()
    End Sub

    Private Sub RegistreringAvNyUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistreringAvNyUtstyrToolStripMenuItem.Click
        Registrering_av_nytt_utstyr.Show()
        Close()
    End Sub
    Private Sub SøkIUrtstyrbaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIUrtstyrbaseToolStripMenuItem.Click
        Sok_i_utstyrbase.Show()
        Close()
    End Sub
    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestilling_og_tilbakelevering_av_sykler.Show()
        Close()
    End Sub
    Private Sub AVSLUTTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AVSLUTTToolStripMenuItem.Click
        b.oversikt()
        Close()
        Form1.Show()
    End Sub

#End Region
End Class