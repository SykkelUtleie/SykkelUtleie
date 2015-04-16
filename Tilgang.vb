Public Class Tilgang

    Private b As New Sporring
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'login for brukerene av programmet
        b.bruker()
        ComboBox1.SelectedIndex = -1 : TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'sender brukernavn og passord som er registert på eposten
        b.glemt()
    End Sub
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        'søker opp brukere og legger de i en combobox
        b.sokBruker()
    End Sub

    Private Sub Tilgang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sjekker om sykler ikke er levert tilbake til avtalt tid
        b.stjalet()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        b.stjalet()
    End Sub
End Class