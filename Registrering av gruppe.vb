Imports MySql.Data.MySqlClient
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
    Private Sub Registrering_av_gruppe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Enabled = False : ComboBox2.Enabled = False : ComboBox3.Enabled = False : ComboBox4.Enabled = False : Button2.Enabled = False : Button3.Enabled = False : DateTimePicker1.Enabled = False : DateTimePicker2.Enabled = False
    End Sub
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
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        b.sporBox1 = ComboBox1
        b.hentSykkelType()
    End Sub
    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        b.sporBox2 = ComboBox2
        b.hentSykkelMerke()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            sykkel.bestillSykkel(TextBox2.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, ComboBox1.Text, ComboBox2.Text, DateTimePicker1, DateTimePicker2, ComboBox3)
        End If
        a.cBox1 = ComboBox1 : a.cBox2 = ComboBox2 : a.cBox3 = ComboBox3 : a.cBox4 = ComboBox4 : a.lab1 = Label14 : a.but1 = Button2
        b.oversikt()
        If a.num = Val(ComboBox4.Text) + 1 Then
            a.num = 1
            Dim resp = MsgBox("Vil du registrere ny bruker?", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                Dim hjelpForm As New Registrering_av_gruppe
                Close()
                hjelpForm.Show()
            Else
                Close()
                Form1.Show()
            End If
        End If
        ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = ""
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
            ComboBox1.Enabled = True : ComboBox2.Enabled = True : ComboBox3.Enabled = True : ComboBox4.Enabled = True : Button2.Enabled = True : Button3.Enabled = True : DateTimePicker1.Enabled = True : DateTimePicker2.Enabled = True
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a.visLagredePosisjoner()
    End Sub

End Class