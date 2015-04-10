Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Utstyr
    Private b As New Sporring
    Public Sub reg(nyType As String, nyMerke As String, nyPris As String)
        b.registr = "Utstyr"
        b.sporType = nyType
        b.sporMerke = nyMerke
        b.prisbox = nyPris
        b.registrering()
    End Sub
End Class
