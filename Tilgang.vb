Public Class Tilgang

    Private b As New Sporring


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b.bruker()

        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.glemt()
    End Sub

End Class