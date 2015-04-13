﻿Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Utstyr
    Private b As New Sporring
    Protected Friend hjelpUtstyrDataGrid, hjelpUtstyrDataGrid1 As DataGridView
    Public Sub reg(nyType As String, nyMerke As String, nyPris As String)
        b.registr = "Utstyr"
        b.sporType = nyType
        b.sporMerke = nyMerke
        b.prisbox = nyPris
        b.registrering()
    End Sub
    Public Sub bestillUtstyr(nyEtternavn As String, nyAdresse As String, nyTel As String, nyEpost As String, nyUtstyrType As String, nyUtstyrMerke As String, nyDatoFra As DateTimePicker, nyDatoTil As DateTimePicker, nyUtleiested As ComboBox)
        Dim df As Date = nyDatoFra.Text
        Dim s1 As String
        s1 = df.ToString("yyyy-MM-dd")
        Dim dt As Date = nyDatoTil.Text
        Dim s2 As String
        s2 = dt.ToString("yyyy-MM-dd")
        b.sporEtternavn = nyEtternavn
        b.sporAdresse = nyAdresse
        b.sporTel = nyTel
        b.sporEpost = nyEpost
        b.sporBestType = nyUtstyrType
        b.sporBestMerke = nyUtstyrMerke
        b.sporDatoFra = s1
        b.sporDatoTil = s2
        b.sporBox3 = nyUtleiested
        b.hjelpDataGrid2 = hjelpUtstyrDataGrid1
        b.hjelpDataGrid1 = hjelpUtstyrDataGrid
        b.bestillingUtstyr()
    End Sub
End Class
