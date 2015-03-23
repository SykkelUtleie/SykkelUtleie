Public Class Brukere
    Private b As New Sporring
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Administrering_av_database.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        b.leggtilBruker()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.DataSource = Nothing
        b.sokBruker()
    End Sub
   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        GroupBox1.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.DataSource = Nothing
        GroupBox5.Visible = False
        GroupBox4.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.DataSource = Nothing
        GroupBox1.Visible = False
        GroupBox5.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        b.slettBruker()
        b.sokBruker()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        b.sokBruker()
    End Sub
    Private Sub ComboBox1_SelectedIndexChange(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        b.sokBruker()
        b.hentBruker()
    End Sub
End Class