Public Class Brukere
    Private b As New Sporring

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Administrering_av_database.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'legger til bruker
        b.leggtilBruker()
        TextBox1.Clear() : TextBox2.Clear() : ComboBox2.SelectedIndex = -1 : TextBox4.Clear() : TextBox5.Clear() : TextBox6.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'viser brukere i et datagridview
        DataGridView1.DataSource = Nothing
        b.sokBruker()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'tømmer datagridview og skjuler groupbox'er 
        DataGridView1.DataSource = Nothing
        GroupBox1.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'tømmer datagridview og skjuler groupbox'er
        DataGridView1.DataSource = Nothing
        GroupBox5.Visible = False
        GroupBox4.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'tømmer datagridview og skjuler groupbox'er
        DataGridView1.DataSource = Nothing
        GroupBox1.Visible = False
        GroupBox5.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Oppdatere endringene som har blitt utført på en bruker
        b.endreBruker()
        TextBox7.Clear() : TextBox8.Clear() : TextBox9.Clear() : TextBox10.Clear() : TextBox11.Clear() : TextBox12.Clear()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        'Mulighet for å slette brukere fra et datagridview
        Dim resp = MsgBox("Ønsker du å slette denne brukeren ?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            b.slettBruker()
            b.sokBruker()
        End If
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        'søker opp brukere og legger de i en combobox
        b.sokBruker()
    End Sub
    Private Sub ComboBox1_SelectedIndexChange(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'søker etter brukere og legger informasjonen til brukeren inn i textbokser
        b.sokBruker()
        b.hentBruker()
    End Sub

    Private Sub Brukere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setter inn to valg i comboboksen av oppstart av formen
        ComboBox2.DisplayMember = "Text"
        ComboBox2.Items.Add(New With {.Text = "Bruker", .Value = 2})
        ComboBox2.Items.Add(New With {.Text = "Admin", .Value = 1})
    End Sub
End Class