Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Sok_i_sykkelbase
    Private b As New Sporring
    Private sykkel As New Sykkel
#Region "GUI"
    Private Sub EnkeltKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnkeltKundeToolStripMenuItem.Click
        Registrering_av_ny_enkelt_kunde.Show()
        Close()
    End Sub
    Private Sub GruppefamilieBedrifterOsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruppefamilieBedrifterOsvToolStripMenuItem.Click
        Registrering_av_gruppe.Show()
        Close()
    End Sub
    Private Sub SøkIKundebaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIKundebaseToolStripMenuItem.Click
        Sok_i_kundebase.Show()
        Close()
    End Sub
    Private Sub SlettKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettKundeToolStripMenuItem.Click
        Slett_kunde.Show()
        Close()
    End Sub
    Private Sub RegistreringAvNySykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistreringAvNySykkelToolStripMenuItem.Click
        Registrering_av_ny_sykkel.Show()
        Close()
    End Sub
    Private Sub SøkISykkelbaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkISykkelbaseToolStripMenuItem.Click
        Show()
    End Sub
    Private Sub BestillingAvSyklerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingAvSyklerToolStripMenuItem.Click
        Bestilling_og_tilbakelevering_av_sykler.Show()
        Close()
    End Sub
    Private Sub ReparasjonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReparasjonToolStripMenuItem.Click
        Reparasjon.Show()
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
    Private Sub BestillingOgTilbakeleveringAvUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingOgTilbakeleveringAvUtstyrToolStripMenuItem.Click
        Bestilling_og_tilbakelevering_av_utstyr.Show()
        Close()
    End Sub
    Private Sub SlettUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettUtstyrToolStripMenuItem.Click
        Slett_utstyr.Show()
        Close()
    End Sub
    Private Sub AVSLUTTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AVSLUTTToolStripMenuItem.Click
        Close()
        Form1.Show()
    End Sub
#End Region
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        b.soke = "sSoke"
        b.sporBox1 = ComboBox1
        b.hentSykkelType()
    End Sub
    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        b.soke = "sSoke"
        b.sporBox2 = ComboBox2
        b.hentSykkelMerke()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sykkel.sHjelp = "bestemt"
        sykkel.sykkelSok(ComboBox1.Text, ComboBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sykkel.sHjelp = "alle"
        sykkel.sykkelSok(ComboBox1.Text, ComboBox2.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sykkel.sHjelp = "tilgjengelige"
        sykkel.sykkelSok(ComboBox1.Text, ComboBox2.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sykkel.sHjelp = "utleied"
        sykkel.sykkelSok(ComboBox1.Text, ComboBox2.Text)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sykkel.sHjelp = "stjalet"
        sykkel.sykkelSok(ComboBox1.Text, ComboBox2.Text)
    End Sub
End Class