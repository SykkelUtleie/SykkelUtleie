Public Class LeggTilUteleiested
    Private b As New Sporring
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'legger til nytt sted for utleie eller tilbakelervering for så hente en ny liste av steder
        b.leggtilSted()
        b.hentSted()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'legger stedene inn i et datagridview
        DataGridView1.DataSource = Nothing
        b.hentSted()
    End Sub
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        'Mulighet for å slette steder fra et datagridview
        Dim resp = MsgBox("Ønsker du å slette dette stedet?", MsgBoxStyle.YesNo)
        If resp = vbYes Then
            b.fjernSted()
            b.hentSted()
        End If
    End Sub

    Private Sub LeggTilUteleiested_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tømmer textbox og datagridview
        TextBox1.Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Administrering_av_database.Show()
        Close()
    End Sub
End Class