Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Kunde
    Private b As New Sporring
    Public Sub regPrivat(nyEtternavn As String, nyNavn As String, nyAdresse As String, nyTel As String, nyEpost As String, nyFdato As Date)
        Dim d As Date = nyFdato
        Dim s As String
        s = d.ToString("yyyy-MM-dd")
        b.registr = "PrivatKunde"
        b.sporEtternavn = nyEtternavn
        b.sporNavn = nyNavn
        b.sporAdresse = nyAdresse
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.sporFdato = s
        b.registrering()
    End Sub
    Public Sub regOrg(nyEtternavn As String, nyAdresse As String, nyTel As String, nyEpost As String)
        b.registr = "Organisasjon"
        b.sporEtternavn = nyEtternavn
        b.sporAdresse = nyAdresse
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.registrering()
    End Sub
    Public Sub privatKundeSok(nyEtternavn As String, nyNavn As String, nyTel As String, nyEpost As String)
        b.soke = "kSoke"
        b.kundeSok = "bestemtKunde"
        b.registr = "PrivatKunde"
        b.sporEtternavn = nyEtternavn
        b.sporNavn = nyNavn
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.sok()
    End Sub
    Public Sub organisasjonSok(nyEtternavn As String, nyTel As String, nyEpost As String)
        b.soke = "kSoke"
        b.kundeSok = "bestemtKunde"
        b.registr = "Organisasjon"
        b.sporEtternavn = nyEtternavn
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.sok()
    End Sub
    Protected Friend hjelpKundeDataGrid As DataGridView
    Public Sub alleKunderSok()
        b.hjelpDataGrid = hjelpKundeDataGrid
        b.soke = "kSoke"
        b.kundeSok = "alleKunder"
        b.sok()
    End Sub
    Public Sub privatKundeSlett(nyEtternavn As String, nyNavn As String, nyTel As String, nyEpost As String)
        b.slette = "kundeSlett"
        b.registr = "PrivatKunde"
        b.sporEtternavn = nyEtternavn
        b.sporNavn = nyNavn
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.slett()
    End Sub
    Public Sub organisasjonSlett(nyEtternavn As String, nyTel As String, nyEpost As String)
        b.slette = "kundeSlett"
        b.registr = "Organisasjon"
        b.sporEtternavn = nyEtternavn
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.slett()
    End Sub
End Class
