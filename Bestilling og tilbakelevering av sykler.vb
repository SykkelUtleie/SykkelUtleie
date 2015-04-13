Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Bestilling_og_tilbakelevering_av_sykler
    Private a As New GUI
    Private hjelp As String
    Private kunde As New Kunde
    Private sykkel As New Sykkel
    Private utstyr As New Utstyr
    Private b As New Sporring
    Private rowNum1, rowNum2 As Integer

#Region "GUI"
    Private Sub EnkeltKundeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnkeltKundeToolStripMenuItem.Click
        Endre_kunder.Show()
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
        Sok_i_sykkelbase.Show()
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
    Dim teller As Integer = 0
    Dim tall As Integer = 0
    Dim teller2 As Integer = 0
    Dim tall2 As Integer = 0
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Visible = True
        TextBox1.Visible = True
        Label2.Text = "Etternavn"
        hjelp = "KundePrivat"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Visible = False
        TextBox1.Visible = False
        Label2.Text = "Org.navn"
        hjelp = "Organisasjon"
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        b.sporBox1 = ComboBox1
        Select Case hjelp
            Case "Bestilling"
                b.hentSykkelType()
            Case "Tilbakelevering"
                rowNum1 = DataGridView1.CurrentCell.RowIndex
                b.kundID = DataGridView1.Rows(rowNum1).Cells(0).Value
                b.sporType = ComboBox1.Text
                b.soke = "tSoke"
                b.hentSykkelType()
        End Select
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        b.sporBox2 = ComboBox2
        Select Case hjelp
            Case "Bestilling"
                b.hentSykkelMerke()
            Case "Tilbakelevering"
                b.soke = "tSoke"
                b.hentSykkelMerke()
        End Select
    End Sub
    Private Sub ComboBox8_Click(sender As Object, e As EventArgs) Handles ComboBox8.Click
        b.sporBox8 = ComboBox8
        Select Case hjelp
            Case "Bestilling"
                b.hentUtstyrType()
            Case "Tilbakelevering"
                b.soke = "tSoke"
                b.hentUtstyrType()
        End Select
    End Sub
    Private Sub ComboBox9_Click(sender As Object, e As EventArgs) Handles ComboBox9.Click
        b.sporBox9 = ComboBox9
        Select Case hjelp
            Case "Bestilling"
                b.hentUtstyrMerke()
            Case "Tilbakelevering"
                b.soke = "tSoke"
                b.hentUtstyrMerke()
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If hjelp = "KundePrivat" Then
            kunde.privatKundeSok(TextBox2.Text, TextBox1.Text, TextBox3.Text, TextBox4.Text)
            MsgBox("Velg kunde fra tabell ved klikk to ganger på trekant fra venstre.")
        ElseIf hjelp = "Organisasjon" Then
            kunde.organisasjonSok(TextBox2.Text, TextBox3.Text, TextBox4.Text)
            MsgBox("Velg kunde fra tabell ved klikk to ganger på trekant fra venstre.")
        Else
            MsgBox("Du må velge kundetype!")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kunde.hjelpKundeDataGrid = DataGridView1
        DataGridView1.Visible = True
        DataGridView1.DataSource = Nothing
        kunde.alleKunderSok()
        MsgBox("Velg kunde fra tabell ved klikk to ganger på trekant fra venstre.")
    End Sub
    Private Sub Bestilling_og_tilbakelevering_av_sykler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Enabled = False : ComboBox2.Enabled = False : ComboBox3.Enabled = False : ComboBox5.Enabled = False : ComboBox8.Enabled = False : ComboBox9.Enabled = False : Button3.Visible = False : DateTimePicker1.Enabled = False : DateTimePicker2.Enabled = False : Button6.Enabled = False
        DataGridView1.DataSource = Nothing
        DataGridView3.DataSource = Nothing
        DataGridView4.DataSource = Nothing
        Label5.Text = tall
        DataGridView3.ColumnCount = 4
        DataGridView3.Columns(0).Name = "ID"
        DataGridView3.Columns(1).Name = "Type"
        DataGridView3.Columns(2).Name = "Merke"
        DataGridView3.Columns(3).Name = "SykkelID"
        DataGridView4.ColumnCount = 3
        DataGridView4.Columns(0).Name = "ID"
        DataGridView4.Columns(1).Name = "Type"
        DataGridView4.Columns(2).Name = "Merke"
    End Sub
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim resp = MsgBox("Vil du registrere BESTILLING av sykler?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            Button3.Text = "Gå videre"
            hjelp = "Bestilling"
            Label11.Visible = True : ComboBox3.Visible = True : Label15.Visible = False : ComboBox5.Visible = False : DataGridView1.Visible = False
        Else
            Dim resp1 = MsgBox("Vil du registrere TILBAKELEVERING av sykler?", MsgBoxStyle.YesNo)
            If resp1 = vbYes Then
                Button3.Text = "Gå videre"
                hjelp = "Tilbakelevering"
                Label11.Visible = False : ComboBox3.Visible = False : Label15.Visible = True : ComboBox5.Visible = True : DataGridView1.Visible = False
                GroupBox4.Visible = False
            Else
                Close()
                Form1.Show()
            End If
        End If
        RadioButton1.Enabled = False : RadioButton2.Enabled = False : TextBox1.Enabled = False : TextBox2.Enabled = False : TextBox3.Enabled = False : TextBox4.Enabled = False : Button1.Enabled = False : Button2.Enabled = False
        ComboBox1.Enabled = True : ComboBox2.Enabled = True : ComboBox3.Enabled = True : ComboBox5.Enabled = True : DateTimePicker1.Enabled = True : DateTimePicker2.Enabled = True
        Button3.Visible = True : Button4.Visible = True : Button6.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case hjelp
            Case "Bestilling"
                Dim resp = MsgBox("Vil du registrere BESTILLING av utstyr til disse sykler?", MsgBoxStyle.YesNo)
                If resp = vbYes Then
                    MsgBox("Velg sykkel fra tabell ved klikk EN GANG på trekant fra venstre.")
                    GroupBox5.Enabled = True
                    Button8.Enabled = True
                    GroupBox3.Enabled = False
                Else
                    GroupBox6.Visible = True
                    Label23.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString() & " " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString()
                    Label29.Text = DataGridView3.RowCount.ToString()
                    Label24.Text = DataGridView4.RowCount.ToString()
                End If
            Case "Tilbakelevering"
                b.sporBox1 = ComboBox5
                b.tilbSykkelUpdate()
                b.slettInfoFraMellomlagring()
                b.oversikt()
                ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = ""
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case hjelp
            Case "Bestilling"
                GroupBox5.Enabled = False
                GroupBox6.Visible = True
                Label23.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString() & " " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString()
                Label29.Text = DataGridView3.RowCount.ToString()
                Label24.Text = DataGridView4.RowCount.ToString()

            Case "Tilbakelevering"
                b.sporBox1 = ComboBox5
                b.tilbSykkelUpdate()
                b.slettInfoFraMellomlagringUtstyr()
                b.oversikt()
                ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = ""
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DataGridView3.Visible = True
        Button3.Enabled = True

        b.sykkkelIdForUtstyr()
        MsgBox(b.sykIdForUtstyr)
        DataGridView3.Rows.Insert(teller, New String() {teller, ComboBox1.Text, ComboBox2.Text, b.sykIdForUtstyr})
        teller += 1
        tall = DataGridView3.Rows.Count()
        Label5.Text = tall
        Label14.Text = tall + 1
        ComboBox1.Text = "" : ComboBox2.Text = ""
        b.hjelpDataGrid = DataGridView3
        If hjelp = "Bestilling" Then
            b.mellom = "Bestilling"
        ElseIf hjelp = "Tilbakelevering" Then
            b.mellom = "Tilbakelevering"
        End If
        b.mellomlagring()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView4.Visible = True
        DataGridView4.Rows.Insert(teller2, New String() {teller2, ComboBox8.Text, ComboBox9.Text})
        teller2 += 1
        tall2 = DataGridView4.Rows.Count()
        Label22.Text = tall2
        Label16.Text = tall2 + 1
        ComboBox9.Text = "" : ComboBox8.Text = ""
        b.hjelpDataGrid1 = DataGridView4
        If hjelp = "Bestilling" Then
            b.mellom1 = "Bestilling"
        ElseIf hjelp = "Tilbakelevering" Then
            b.mellom1 = "Tilbakelevering"
        End If
        b.mellomlagringUtstyr()
    End Sub

    Private Sub DataGridView3_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseClick
        Button5.Text = "Bestilling"
        hjelp = "Bestilling"
        ComboBox1.Enabled = False : ComboBox2.Enabled = False : ComboBox3.Enabled = False : ComboBox5.Enabled = False : Button6.Visible = True
        Button3.Enabled = False : Button4.Enabled = False : ComboBox8.Enabled = True : ComboBox9.Enabled = True : Button6.Enabled = True
    End Sub

    Private Sub DataGridView3_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseDoubleClick
        'viser sykler som er lagt til bestilligen og mulighet for å slette disse
        Dim i As Integer = DataGridView3.CurrentRow.Index
        b.slettEnFraMellomlagring()
        DataGridView3.Rows.RemoveAt(i)
        Dim rad As Integer = 0
        For Each row As DataGridViewRow In DataGridView3.Rows
            Dim id As Integer = DataGridView3.Rows(rad).Cells(0).Value.ToString
            If id > i Then
                DataGridView3.Rows(rad).Cells.Item("ID").Value = id - 1
            End If
            rad += 1
        Next
        teller -= 1
    End Sub
    Private Sub DataGridView4_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView4.RowHeaderMouseDoubleClick
        'viser utstyr som er lagt til bestillingen og mulighet for å slette disse
        Dim i As Integer = DataGridView4.CurrentRow.Index
        b.slettEnFraMellomlagringUtstyr()
        DataGridView4.Rows.RemoveAt(i)
        Dim rad As Integer = 0
        For Each row As DataGridViewRow In DataGridView4.Rows
            Dim id As Integer = DataGridView4.Rows(rad).Cells(0).Value.ToString
            If id > i Then
                DataGridView4.Rows(rad).Cells.Item("ID").Value = id - 1
            End If
            rad += 1
        Next
        teller2 -= 1
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case hjelp
            Case "Bestilling"
                rowNum1 = DataGridView1.CurrentCell.RowIndex
                sykkel.hjelpSykkelDataGrid = DataGridView3
                sykkel.bestillSykkel(DataGridView1.Rows(rowNum1).Cells(1).Value, DataGridView1.Rows(rowNum1).Cells(3).Value, DataGridView1.Rows(rowNum1).Cells(4).Value, DataGridView1.Rows(rowNum1).Cells(5).Value, ComboBox1.Text, ComboBox2.Text, DateTimePicker1, DateTimePicker2, ComboBox3)
                a.cBox1 = ComboBox1 : a.cBox2 = ComboBox2 : a.cBox3 = ComboBox3 : a.lab1 = Label14 : a.but1 = Button2
                b.slettInfoFraMellomlagring()
                utstyr.hjelpUtstyrDataGrid1 = DataGridView3
                utstyr.hjelpUtstyrDataGrid = DataGridView4
                utstyr.bestillUtstyr(DataGridView1.Rows(rowNum1).Cells(1).Value, DataGridView1.Rows(rowNum1).Cells(3).Value, DataGridView1.Rows(rowNum1).Cells(4).Value, DataGridView1.Rows(rowNum1).Cells(5).Value, ComboBox8.Text, ComboBox9.Text, DateTimePicker1, DateTimePicker2, ComboBox3)
                a.cBox1 = ComboBox8 : a.cBox2 = ComboBox9 : a.cBox3 = ComboBox3 : a.lab1 = Label16 : a.but1 = Button2
                b.oversikt()
                ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = "" : ComboBox9.Text = "" : ComboBox8.Text = ""
                b.slettInfoFraMellomlagringUtstyr()
                teller = 0
                DataGridView3.Rows.Clear()
                DataGridView3.Columns.Clear()
                DataGridView4.Rows.Clear()
                DataGridView4.Columns.Clear()
                Dim resp1 = MsgBox("Vil du registrere BESTILLING av sykler til annen bruker?", MsgBoxStyle.YesNo)
                If resp1 = vbYes Then
                    Dim hjelpForm As New Bestilling_og_tilbakelevering_av_sykler
                    Close()
                    hjelpForm.Show()
                Else
                    Close()
                    Form1.Show()
                End If

            Case "Tilbakelevering"
                b.sporBox1 = ComboBox5
                b.tilbSykkelUpdate()
                b.slettInfoFraMellomlagring()
                'b.hjelpDataGrid = DataGridView3
                'If ComboBox1.Text <> "" Then
                '    rowNum2 = DataGridView2.CurrentCell.RowIndex
                '    b.sporBox1 = ComboBox5
                '    Dim cellNum As String = DataGridView2.Rows(rowNum2).Cells(0).Value
                '    b.sykID = cellNum
                '    b.tilbSykkelUpdate()
                'End If
                'a.cBox1 = ComboBox1 : a.cBox2 = ComboBox2 : a.cBox3 = ComboBox3 : a.lab1 = Label14 : a.but1 = Button2
                b.oversikt()
                ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = ""
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button3.Visible = True
        Button4.Visible = True
        Button6.Visible = True
        GroupBox6.Visible = False
    End Sub

End Class