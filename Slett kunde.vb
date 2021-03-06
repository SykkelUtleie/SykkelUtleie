﻿Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Slett_kunde
    Private a As New GUI
    Private kunde As New Kunde
    Private b As New Sporring
    Private hjelp As String
#Region "GUI"

    Private Sub SøkIKundebaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SøkIKundebaseToolStripMenuItem.Click
        Sok_i_kundebase.Show()
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
        'setter formen opp for privatkunde
        Label1.Visible = True
        TextBox1.Visible = True
        Label2.Text = "Etternavn"
        hjelp = "KundePrivat"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'setter formen opp for bedrifter
        Label1.Visible = False
        TextBox1.Visible = False
        Label2.Text = "Org.navn"
        hjelp = "Organisasjon"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'søker opp kunde ut fra informasjonen som har blitt gitt av brukeren
        If hjelp = "KundePrivat" Then
            kunde.privatKundeSok(TextBox2.Text, TextBox1.Text, TextBox3.Text, TextBox4.Text)
            MsgBox("Velg kunde fra tabell ved klikk på trekant fra venstre.")
        ElseIf hjelp = "Organisasjon" Then
            kunde.organisasjonSok(TextBox2.Text, TextBox3.Text, TextBox4.Text)
            MsgBox("Velg kunde fra tabell ved klikk på trekant fra venstre.")
        Else
            MsgBox("Du må velge kundetype!")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sletter den valgte kunden fra databasen
        If hjelp = "KundePrivat" Then
            kunde.privatKundeSlett(TextBox2.Text, TextBox1.Text, TextBox3.Text, TextBox4.Text)
        ElseIf hjelp = "Organisasjon" Then
            kunde.organisasjonSlett(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        Else
            MsgBox("Du må velge kundetype!")
        End If
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = ""
    End Sub

    Private Sub Slett_kunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tømmer datagridview
        DataGridView1.DataSource = Nothing
    End Sub
End Class