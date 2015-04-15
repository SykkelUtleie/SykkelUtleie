Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Sykkel
    Private b As New Sporring
    Protected Friend sHjelp As String
    Protected Friend hjelpSykkelDataGrid As DataGridView
    Public Sub reg(nyType As String, nyMerke As String, nyHjul As String, nyRamme As String, nyGir As String, nyGaffel As String, nyBremser As String)
        b.registr = "Sykkel"
        b.sporType = nyType
        b.sporMerke = nyMerke
        b.sporHjul = nyHjul
        b.sporRamme = nyRamme
        b.sporGir = nyGir
        b.sporGaffel = nyGaffel
        b.sporBremser = nyBremser
        b.registrering()
    End Sub

    Public Sub bestillSykkel(nyEtternavn As String, nyAdresse As String, nyTel As String, nyEpost As String, nySykkelType As String, nySykkelMerke As String, nyDatoFra As DateTimePicker, nyDatoTil As DateTimePicker, nyUtleiested As ComboBox)
        Dim df As Date = nyDatoFra.Text
        Dim s1 As String = df.ToString("yyyy-MM-dd")
        Dim dt As Date = nyDatoTil.Text
        Dim s2 As String = dt.ToString("yyyy-MM-dd")
        b.sporEtternavn = nyEtternavn
        b.sporAdresse = nyAdresse
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.sporBestType = nySykkelType
        b.sporBestMerke = nySykkelMerke
        b.sporDatoFra = s1
        b.sporDatoTil = s2
        b.sporBox3 = nyUtleiested
        b.hjelpDataGrid = hjelpSykkelDataGrid
        b.bestillingSykkel()
    End Sub
    Public Sub sykkelSok(nyType As String, nyMerke As String)
        Select Case sHjelp
            Case "bestemt"
                b.sykkelSok = "bestemtSykkel"
                b.sporType = nyType
                b.sporMerke = nyMerke
            Case "alle"
                b.sykkelSok = "alleSykler"
            Case "tilgjengelige"
                b.sykkelSok = "tilgjengeligeSykler"
            Case "utleied"
                b.sykkelSok = "utleiedSykler"
            Case "stjalet"
                b.sykkelSok = "stjaletsykler"
        End Select
        b.soke = "sSoke"
        b.sok()
    End Sub
    Public Sub sykkelSlett(nyType As String, nyMerke As String)
        Select Case sHjelp
            Case "type"
                b.slette = "sykkelSlett"
                b.spor = "sType"
            Case "typeOgMerke"
                b.slette = "sykkelSlett"
                b.spor = "sMerke"
        End Select
        b.sporType = nyType
        b.sporMerke = nyMerke
        b.slett()
    End Sub
End Class
