Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Reparasjon
    Private a As New GUI
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

    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
        b.soke = "repSoke"
        b.sporBox1 = ComboBox1
        If RadioButton1.Checked = True Then
            b.repSoke = "rep"
        ElseIf RadioButton2.Checked = True Then
            b.repSoke = "ferdig"
        Else
            MsgBox("Du må velge hva du trenger å gjøre med sykkel!")
        End If
        b.hentSykkelType()
    End Sub

    Private Sub ComboBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox2.MouseClick
        b.soke = "repSoke"
        b.sporBox2 = ComboBox2
        If RadioButton1.Checked = True Then
            b.repSoke = "rep"
        ElseIf RadioButton2.Checked = True Then
            b.repSoke = "ferdig"
        Else
            MsgBox("Du må velge hva du trenger å gjøre med sykkel!")
        End If
        b.hentSykkelMerke()
    End Sub

    Private Sub ComboBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox3.MouseClick
        b.sporBox1 = ComboBox1
        b.sporBox2 = ComboBox2
        b.sporBox4 = ComboBox3
        If RadioButton1.Checked = True Then
            b.repSoke = "rep"
        ElseIf RadioButton2.Checked = True Then
            b.repSoke = "ferdig"
        Else
            MsgBox("Du må velge hva du trenger å gjøre med sykkel!")
        End If
        b.sykkkelIdForRep()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label5.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label5.Text = ComboBox1.Text & " " & ComboBox2.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label5.Text = ComboBox1.Text & " " & ComboBox2.Text & ", ID: " & ComboBox3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b.sporBox1 = ComboBox1
        b.sporBox2 = ComboBox2
        b.sporBox4 = ComboBox3
        If RadioButton1.Checked = True Then
            b.repSoke = "rep"
            b.reparasjon()
        ElseIf RadioButton2.Checked = True Then
            b.repSoke = "ferdig"
            b.reparasjon()
        Else
            MsgBox("Du må velge hva du trenger å gjøre med sykkel!")
        End If
        b.hjelpDataGrid3 = DataGridView1
        b.visReparasjon()
        ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = ""
    End Sub
End Class