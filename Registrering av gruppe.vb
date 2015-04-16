Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Registrering_av_gruppe
    'deklarerer variabler
    Private a As New GUI
    Private kunde As New Kunde
    Private sykkel As New Sykkel
    Private b As New Sporring
    Private hjelp As String
#Region "GUI"
    'oppretter fuksjonalitet til brukergrensesnitt
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

    Private Sub RegistreringAvNySykkelToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RegistreringAvNySykkelToolStripMenuItem.Click
        Registrering_av_ny_sykkel.Show()
        Close()
    End Sub
    Private Sub SlettSykkelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettSykkelToolStripMenuItem.Click
        Slett_sykkel.Show()
        Close()
    End Sub
    Private Sub SlettUtstyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettUtstyrToolStripMenuItem.Click
        Slett_utstyr.Show()
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'velger kundetype
        a.lab2 = Label2 : a.lab3 = Label1 : a.lab4 = Label3 : a.tBox1 = TextBox1 : a.dPicker1 = DateTimePicker3
        a.enkelt()
        hjelp = "KundePrivat"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'velger kundetype
        a.lab2 = Label2 : a.lab3 = Label1 : a.lab4 = Label3 : a.tBox1 = TextBox1 : a.dPicker1 = DateTimePicker3
        a.organisasjon()
        hjelp = "Organisasjon"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'registrerer ny kunde
        If hjelp = "KundePrivat" Then
            b.sjekkHjelp = "Privat"
            b.sjekk(TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            If b.res = True Then
                kunde.regPrivat(TextBox2.Text, TextBox1.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, DateTimePicker3.Text)
                Dim resp = MsgBox("Vil du bestille sykler til kunden?", MsgBoxStyle.YesNo)
                If resp = vbYes Then
                    Bestilling_og_tilbakelevering_av_sykler.Show()
                    Close()
                Else
                    Dim resp1 = MsgBox("Vil du registrere ny kunde?", MsgBoxStyle.YesNo)
                    If resp1 = vbYes Then
                        Dim hjelpForm As New Registrering_av_gruppe
                        Close()
                        hjelpForm.Show()
                    Else
                        Form1.Show()
                        Close()
                    End If
                End If
            End If
        ElseIf hjelp = "Organisasjon" Then
            b.sjekkHjelp = "Organisasjon"
            b.sjekk(TextBox2.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            If b.res = True Then
                kunde.regOrg(TextBox2.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
                Dim resp = MsgBox("Vil du bestille sykler til kunden?", MsgBoxStyle.YesNo)
                If resp = vbYes Then
                    Bestilling_og_tilbakelevering_av_sykler.Show()
                    Close()
                Else
                    Dim resp1 = MsgBox("Vil du registrere ny kunde?", MsgBoxStyle.YesNo)
                    If resp1 = vbYes Then
                        Dim hjelpForm As New Registrering_av_gruppe
                        Close()
                        hjelpForm.Show()
                    Else
                        Form1.Show()
                        Close()
                    End If
                End If
            End If
        Else
            MsgBox("Du må velge kundetype!")
        End If
    End Sub
End Class