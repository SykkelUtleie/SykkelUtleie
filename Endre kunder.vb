Public Class Endre_kunder
    Private b As New Sporring
    Private hjelp As String
    Private a As New GUI
    Private kunde As New Kunde
#Region "GUI"
    Private Sub EnkeltKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnkeltKundeToolStripMenuItem.Click
        Registrering_av_ny_enkelt_kunde.Show()
        Close()
    End Sub
    Private Sub GruppefamilieBedrifterOsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruppefamilieBedrifterOsvToolStripMenuItem.Click
        Registrering_av_gruppe.Show()
        Close()
    End Sub
    Private Sub SlettKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettKundeToolStripMenuItem.Click
        Slett_kunde.Show()
        Close()
    End Sub
    Private Sub RegistreringAvNysykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistreringAvNySykkelToolStripMenuItem.Click
        Registrering_av_ny_sykkel.Show()
        Close()
    End Sub
    Private Sub SøkIsykkelbaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkISykkelbaseToolStripMenuItem.Click
        Sok_i_sykkelbase.Show()
        Close()
    End Sub
    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Bestilling_og_tilbakelevering_av_sykler.Show()
        Close()
    End Sub
    Private Sub ReparasjonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReparasjonToolStripMenuItem.Click
        Reparasjon.Show()
        Close()
    End Sub
    Private Sub SlettsykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettSykkelToolStripMenuItem.Click
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
    Private Sub SlettUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettUtstyrToolStripMenuItem.Click
        Slett_utstyr.Show()
        Close()
    End Sub
    Private Sub AVSLUTTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AVSLUTTToolStripMenuItem.Click
        b.oversikt()
        Close()
        Form1.Show()
    End Sub
#End Region
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear() : TextBox2.Clear() : TextBox3.Clear() : TextBox4.Clear() : TextBox5.Clear() : TextBox6.Clear() : TextBox7.Clear() : TextBox8.Clear() : TextBox9.Clear()
        b.kSok()
    End Sub
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        If RadioButton1.Checked = True Then
            TextBox1.Clear() : TextBox2.Clear() : TextBox3.Clear() : TextBox4.Clear() : TextBox5.Clear() : TextBox6.Clear() : TextBox7.Clear() : TextBox8.Clear() : TextBox9.Clear()
            b.hentKunde()
            TextBox1.ReadOnly = False : TextBox2.ReadOnly = False : TextBox4.ReadOnly = False : TextBox5.ReadOnly = False : TextBox6.ReadOnly = False
            TextBox3.ReadOnly = True : TextBox7.ReadOnly = True : TextBox8.ReadOnly = True : TextBox9.ReadOnly = True
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Clear() : TextBox2.Clear() : TextBox3.Clear() : TextBox4.Clear() : TextBox5.Clear() : TextBox6.Clear() : TextBox7.Clear() : TextBox8.Clear() : TextBox9.Clear()
            b.hentKunde()
            TextBox1.ReadOnly = True : TextBox2.ReadOnly = True : TextBox4.ReadOnly = True : TextBox5.ReadOnly = True : TextBox6.ReadOnly = True
            TextBox3.ReadOnly = False : TextBox7.ReadOnly = False : TextBox8.ReadOnly = False : TextBox9.ReadOnly = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.endreKunde()
        
    End Sub
End Class