﻿Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Net.Mail
Imports System.Text
Public Class GUI
    'deklarerer variabler
    Protected Friend cBox1, cBox2, cBox3, cBox4 As ComboBox
    Protected Friend but1 As Button
    Protected Friend lab1, lab2, lab3, lab4 As Label
    Protected Friend tBox1 As TextBox
    Protected Friend dPicker1 As DateTimePicker
    Protected Friend fNavn, eNavn, tlf, epst As String
    Public Sub enkelt()
        'oppretter fuksjonalitet til brukergrensesnitt til private kunder
        lab2.Text = "Etternavn"
        lab3.Visible = True
        tBox1.Visible = True
        lab4.Visible = True
        dPicker1.Visible = True
    End Sub
    Public Sub organisasjon()
        'oppretter fuksjonalitet til brukergrensesnitt til organisasjon
        lab2.Text = "Org.navn"
        lab3.Visible = False
        tBox1.Visible = False
        lab4.Visible = False
        dPicker1.Visible = False
    End Sub
    Public Sub FyllUtKunde(ByVal fNavn As String, ByVal eNavn As String, ByVal tlf As String, ByVal epst As String)
        'fyller ut kundeopplysninger ved overføring fra registrering av ny kunde til bestilling av ny sykkel og utstyr
        Bestilling_og_tilbakelevering_av_sykler.TextBox1.Text = fNavn
        Bestilling_og_tilbakelevering_av_sykler.TextBox2.Text = eNavn
        Bestilling_og_tilbakelevering_av_sykler.TextBox3.Text = tlf
        Bestilling_og_tilbakelevering_av_sykler.TextBox4.Text = epst
        Bestilling_og_tilbakelevering_av_sykler.RadioButton1.Checked = True
        Bestilling_og_tilbakelevering_av_sykler.TextBox1.Enabled = False
        Bestilling_og_tilbakelevering_av_sykler.TextBox2.Enabled = False
        Bestilling_og_tilbakelevering_av_sykler.TextBox3.Enabled = False
        Bestilling_og_tilbakelevering_av_sykler.TextBox4.Enabled = False
        Bestilling_og_tilbakelevering_av_sykler.RadioButton1.Enabled = False
        Bestilling_og_tilbakelevering_av_sykler.RadioButton2.Enabled = False
    End Sub
End Class
