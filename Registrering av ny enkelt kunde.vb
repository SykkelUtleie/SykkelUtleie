﻿Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Registrering_av_ny_enkelt_kunde
    Private a As New GUI
    Private kunde As New Kunde
    Private sykkel As New Sykkel
    Private b As New Sporring
    Private hjelp As String
#Region "GUI"
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
    Private Sub Registrering_av_ny_enkelt_kunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Enabled = False : ComboBox2.Enabled = False : ComboBox3.Enabled = False : DateTimePicker1.Enabled = False : DateTimePicker2.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kunde.regPrivat(TextBox2.Text, TextBox1.Text, TextBox5.Text, TextBox6.Text, TextBox4.Text, DateTimePicker3.Text)
        Dim resp = MsgBox("Vil du bestille sykkel til bruker?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            'TextBox1.Enabled = False : TextBox2.Enabled = False : TextBox4.Enabled = False : TextBox5.Enabled = False : TextBox6.Enabled = False : DateTimePicker3.Enabled = False : Button1.Enabled = False
            'ComboBox1.Enabled = True : ComboBox2.Enabled = True : ComboBox3.Enabled = True : DateTimePicker1.Enabled = True : DateTimePicker2.Enabled = True
            a.FyllUtKunde(TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox4.Text)
            Bestilling_og_tilbakelevering_av_sykler.Show()
        Else
            Dim hjelpForm As New Registrering_av_ny_enkelt_kunde
            Close()
            hjelpForm.Show()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            sykkel.bestillSykkel(TextBox2.Text, TextBox5.Text, TextBox6.Text, TextBox4.Text, ComboBox1.Text, ComboBox2.Text, DateTimePicker1, DateTimePicker2, ComboBox3)
        End If
        ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = ""
        Dim resp = MsgBox("Vil du registrere ny bruker?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            Dim hjelpForm As New Registrering_av_ny_enkelt_kunde
            Close()
            hjelpForm.Show()
        Else
            Close()
            Form1.Show()
        End If
        b.oversikt()
    End Sub
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        b.sporBox1 = ComboBox1
        b.hentSykkelType()
    End Sub
    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        b.sporBox2 = ComboBox2
        b.hentSykkelMerke()
    End Sub
End Class