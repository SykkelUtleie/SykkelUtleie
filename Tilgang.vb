Public Class Tilgang

    Private b As New Sporring


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b.bruker()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.glemt()
    End Sub

End Class