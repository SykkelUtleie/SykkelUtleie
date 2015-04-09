﻿Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Registrering_av_gruppe
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
        a.lab2 = Label2 : a.lab3 = Label1 : a.lab4 = Label3 : a.tBox1 = TextBox1 : a.dPicker1 = DateTimePicker3
        a.enkelt()
        hjelp = "KundePrivat"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        a.lab2 = Label2 : a.lab3 = Label1 : a.lab4 = Label3 : a.tBox1 = TextBox1 : a.dPicker1 = DateTimePicker3
        a.organisasjon()
        hjelp = "Organisasjon"
    End Sub
    
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If hjelp = "KundePrivat" Then
            kunde.regPrivat(TextBox2.Text, TextBox1.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, DateTimePicker3.Text)
        ElseIf hjelp = "Organisasjon" Then
            kunde.regOrg(TextBox2.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Else
            MsgBox("Du må velge kundetype!")
        End If
        ReDim a.posisjon(30, 4)
        Dim resp = MsgBox("Vil du bestille sykler til bruker?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            TextBox1.Enabled = False : TextBox2.Enabled = False : TextBox4.Enabled = False : TextBox5.Enabled = False : TextBox6.Enabled = False : DateTimePicker3.Enabled = False

        Else
            Dim resp1 = MsgBox("Vil du registrere ny bruker?", MsgBoxStyle.YesNo)
            If resp1 = vbYes Then
                Dim hjelpForm As New Registrering_av_gruppe
                Close()
                hjelpForm.Show()
            Else
                Close()
                Form1.Show()
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        a.visLagredePosisjoner()
    End Sub

End Class