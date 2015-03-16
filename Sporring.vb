﻿Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Sporring
    Private sporring As String
    Protected Friend registr, soke, soke1, kundeSok, sykkelSok, slette, spor, sykID, kundID As String
    Protected Friend sporEtternavn, sporNavn, sporAdresse, sporTel, sporEpost, sporFdato, sporDatoFra, sporDatoTil As String
    Protected Friend sporType, sporMerke, sporHjul, sporRamme, sporGir, sporGaffel, sporBremser, sporBestType, sporBestMerke As String
    Protected Friend sporBox1, sporBox2, sporBox3 As ComboBox

    Private Function query(sql As String) As DataTable
        Dim data As New DataTable
        Dim conn As MySqlConnection = New MySqlConnection()
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("mySql").ConnectionString
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, conn)
            adapter.Fill(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Feil ved oppkobling mot database: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
        Return data
    End Function
    Public Sub opprett()
        Dim data As New DataTable
        sporring = "CREATE TABLE `Kunde` (`KundeID` int(10) NOT NULL AUTO_INCREMENT, " &
            "`Etternavn_org_navn` varchar(50) default NULL, " &
            "`Fornavn` varchar(50) default NULL, " &
            "`Adresse` varchar(50) default NULL, " &
            "`Telefon` varchar(50) default NULL, " &
            "`Epost` varchar(50) default NULL, " &
            "`Fdato` date default NULL, " &
            "PRIMARY KEY (`KundeID`)) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;"
        sporring += "CREATE TABLE `Sykkel` (`SykkelID` int(10) NOT NULL AUTO_INCREMENT, " &
            "`Sykkeltype` varchar(50) default NULL, " &
            "`Sykkelmerke` varchar(50) default NULL, " &
            "`Hjulstorelse` varchar(50) default NULL, " &
            "`Ramme` varchar(50) default NULL, " &
            "`Girsystem` varchar(50) default NULL, " &
            "`Dempergaffel` varchar(50) default NULL, " &
            "`Bremser` varchar(50) default NULL, " &
            "`Trenger_reparasjon` varchar(3) NOT NULL, " &
            "PRIMARY KEY (`SykkelID`)) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1; " &
            "ALTER TABLE `Sykkel` " &
            "ADD FOREIGN KEY(Trenger_reparasjon) REFERENCES Reparasjon(Trenger_reparasjon);"
        sporring += "CREATE TABLE `Utstyr` (`UtstyrID` int(10) NOT NULL AUTO_INCREMENT, " &
            "`Utstyrtype` varchar(50) default NULL, " &
            "`Utstyrmerke` varchar(50) default NULL, " &
            "PRIMARY KEY (`UtstyrID`)) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;"
        sporring += "CREATE TABLE `Reparasjon` (`SykkelID` int UNSIGNED NOT NULL, " &
            "`Trenger_reparasjon` varchar(3) default NULL, " &
            "PRIMARY KEY (`SykkelID`)) ENGINE=MyISAM;" &
            "ALTER TABLE `Reparasjon` " &
            "ADD FOREIGN KEY(SykkelID) REFERENCES Sykkel(SykkelID);"
        sporring += "CREATE TABLE `Sykkel_bestilling_tilbakelevering` (`SykkelID` int UNSIGNED NOT NULL, " &
            "`Utleied_av` int UNSIGNED NOT NULL, " &
            "`Dato_fra` date default NULL, " &
            "`Dato_til` date default NULL, " &
            "`Utleiested` varchar(30) default NULL, " &
            "`Tilbakeleveringssted` varchar(30) default NULL, " &
            "PRIMARY KEY (`SykkelID`)) ENGINE=MyISAM; " &
            "ALTER TABLE `Sykkel_bestilling_tilbakelevering` " &
            "ADD FOREIGN KEY(SykkelID) REFERENCES Sykkel(SykkelID); " &
            "ALTER TABLE `Sykkel_bestilling_tilbakelevering` " &
            "ADD FOREIGN KEY(Utleied_av) REFERENCES Kunde(KundeID);"
        sporring += "CREATE TABLE `Utstyr_bestilling_tilbakelevering` (`UtstyrID` int UNSIGNED NOT NULL, " &
            "`Utleied_av` int UNSIGNED NOT NULL, " &
            "`Dato_fra` date default NULL, " &
            "`Dato_til` date default NULL, " &
            "`Utleiested` varchar(30) default NULL, " &
            "`Tilbakeleveringssted` varchar(30) default NULL, " &
            "PRIMARY KEY (`UtstyrID`)) ENGINE=MyISAM;" &
            "ALTER TABLE `Utstyr_bestilling_tilbakelevering` " &
            "ADD FOREIGN KEY(UtstyrID) REFERENCES Utstyr(UtstyrID); " &
            "ALTER TABLE `Utstyr_bestilling_tilbakelevering` " &
            "ADD FOREIGN KEY(Utleied_av) REFERENCES Kunde(KundeID);"
        data = query(sporring)
        MsgBox("Databasen er opprettet!", MsgBoxStyle.Information)
    End Sub
    Public Sub registrering()
        Dim data As New DataTable
        Select Case registr
            Case "PrivatKunde"
                sporring = "INSERT INTO Kunde VALUES(NULL, '" & sporEtternavn & "','" & sporNavn & "','" & sporAdresse & "','" & sporTel & "','" & sporEpost & "','" & sporFdato & "');"
                data = query(sporring)
                MsgBox("Ny privat kunde er registrert!", MsgBoxStyle.Information)
            Case "Organisasjon"
                sporring = "INSERT INTO Kunde VALUES(NULL, '" & sporEtternavn & "', NULL, '" & sporAdresse & "','" & sporTel & "','" & sporEpost & "', NULL);"
                data = query(sporring)
                MsgBox("Ny organisasjon er registrert!", MsgBoxStyle.Information)
            Case "Sykkel"
                sporring = "INSERT INTO Sykkel VALUES(NULL, '" & sporType & "','" & sporMerke & "','" & sporHjul & "','" & sporRamme & "','" & sporGir & "','" & sporGaffel & "','" & sporBremser & "', 'NEI');"
                data = query(sporring)
                MsgBox("Ny sykkel er registrert!", MsgBoxStyle.Information)
            Case "Utstyr"
                sporring = "INSERT INTO Utstyr VALUES(NULL, '" & sporType & "','" & sporMerke & "');"
                data = query(sporring)
                MsgBox("Nytt utstyr er registrert!", MsgBoxStyle.Information)
        End Select
        oversikt()
    End Sub
    Public Sub hentSykkelType()
        sporBox1.Items.Clear()
        If soke = "sSoke" Then
            Dim data As New DataTable
            sporring = "SELECT Sykkeltype, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel GROUP BY Sykkeltype"
            data = query(sporring)
            Dim rad As DataRow
            Dim sykkeltype, antallType As String
            For Each rad In data.Rows
                sykkeltype = rad("Sykkeltype")
                antallType = rad("Antall")
                sporBox1.Items.Add(sykkeltype)
            Next rad
        ElseIf soke = "tSoke" Then
            Dim data1 As New DataTable
            Dim sporring1 As String = "SELECT Sykkeltype, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL) GROUP BY Sykkeltype"
            data1 = query(sporring1)
            Dim rad As DataRow
            Dim sykkeltype, antallType As String
            For Each rad In data1.Rows
                sykkeltype = rad("Sykkeltype")
                antallType = rad("Antall")
                sporBox1.Items.Add(sykkeltype)
            Next rad
            soke1 = "tTypeSoke"
            tilbSykkel()
        Else
            Dim data As New DataTable
            sporring = "SELECT Sykkeltype, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL) GROUP BY Sykkeltype"
            data = query(sporring)
            Dim rad As DataRow
            Dim sykkeltype, antallType As String
            For Each rad In data.Rows
                sykkeltype = rad("Sykkeltype")
                antallType = rad("Antall")
                sporBox1.Items.Add(sykkeltype)
            Next rad
        End If
    End Sub
    Public Sub hentSykkelMerke()
        sporBox2.Items.Clear()
        If soke = "sSoke" Then
            Dim hjelp As String = sporBox1.Text
            Dim a() As String = hjelp.Split(" ")
            Dim data As New DataTable
            sporring = "SELECT Sykkelmerke, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' GROUP BY Sykkelmerke"
            data = query(sporring)
            Dim rad As DataRow
            Dim sykkelmerke, antallMerke As String
            For Each rad In data.Rows
                sykkelmerke = rad("Sykkelmerke")
                antallMerke = rad("Antall")
                sporBox2.Items.Add(sykkelmerke)
            Next rad
        ElseIf soke = "tSoke" Then
            Dim hjelp As String = sporBox1.Text
            Dim a() As String = hjelp.Split(" ")
            Dim data As New DataTable
            sporring = "SELECT Sykkelmerke, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") GROUP BY Sykkelmerke"
            data = query(sporring)
            Dim rad As DataRow
            Dim sykkelmerke, antallMerke As String
            For Each rad In data.Rows
                sykkelmerke = rad("Sykkelmerke")
                antallMerke = rad("Antall")
                sporBox2.Items.Add(sykkelmerke)
            Next rad
            soke1 = "tMerkeSoke"
            tilbSykkel()
        Else
            Dim hjelp As String = sporBox1.Text
            Dim a() As String = hjelp.Split(" ")
            Dim data As New DataTable
            sporring = "SELECT Sykkelmerke, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' AND (SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL)) GROUP BY Sykkelmerke"
            data = query(sporring)
            Dim rad As DataRow
            Dim sykkelmerke, antallMerke As String
            For Each rad In data.Rows
                sykkelmerke = rad("Sykkelmerke")
                antallMerke = rad("Antall")
                sporBox2.Items.Add(sykkelmerke)
            Next rad
        End If
    End Sub
    Public Sub bestillingSykkel()
        Dim data As New DataTable
        Dim sporring1 As String = "SELECT MIN(SykkelID) FROM Sykkel WHERE Sykkeltype = '" & sporBestType & "' AND Sykkelmerke = '" & sporBestMerke & "' AND (SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL))"
        data = query(sporring1)
        Dim rad As DataRow = data.Rows(0)
        Dim sykkelId As Integer
        sykkelId = rad("MIN(SykkelID)")
        Dim data1 As New DataTable
        Dim sporring2 As String = "SELECT KundeID FROM Kunde WHERE Etternavn_org_navn = '" & sporEtternavn & "' AND Adresse = '" & sporAdresse & "' AND Telefon = " & sporTel & " AND Epost = '" & sporEpost & "'"
        data1 = query(sporring2)
        Dim rad1 As DataRow
        Dim KundeID As Integer
        For Each rad1 In data1.Rows
            KundeID = rad1("KundeID")
        Next rad1
        Dim data2 As New DataTable
        Dim sporring3 = "INSERT INTO Sykkel_bestilling_tilbakelevering VALUES(" & sykkelId & ", " & KundeID &
            ", '" & sporDatoFra & "', '" & sporDatoTil & "', '" & sporBox3.Text & "', NULL)"
        data2 = query(sporring3)
        MsgBox("Sykkel er bestilt!", MsgBoxStyle.Information)
        oversikt()
    End Sub
    Public Sub sok()
        Select Case soke
            Case "kSoke"
                Select Case kundeSok
                    Case "bestemtKunde"
                        Dim data As New DataTable
                        Dim kundeID As Integer
                        Select Case registr
                            Case "PrivatKunde"
                                sporring = "SELECT KundeID FROM Kunde WHERE Etternavn_org_navn = '" & sporEtternavn & "' AND Fornavn = '" & sporNavn & "' AND Telefon = '" & sporTel & "' AND Epost = '" & sporEpost & "'"
                                data = query(sporring)
                                Dim rad As DataRow
                                For Each rad In data.Rows
                                    kundeID = rad("KundeID")
                                Next rad
                            Case "Organisasjon"
                                sporring = "SELECT KundeID FROM Kunde WHERE Etternavn_org_navn = '" & sporEtternavn & "' AND Telefon = " & sporTel & " AND Epost = '" & sporEpost & "'"
                                data = query(sporring)
                                Dim rad As DataRow
                                For Each rad In data.Rows
                                    kundeID = rad("KundeID")
                                Next rad
                        End Select
                        Dim data1 As New DataTable
                        Dim sporring1 As String = "SELECT * FROM Kunde WHERE KundeID = " & kundeID
                        data1 = query(sporring1)
                        Sok_i_kundebase.DataGridView1.DataSource = data1
                        Slett_kunde.DataGridView1.DataSource = data1
                        Bestilling_og_tilbakelevering_av_sykler.DataGridView1.DataSource = data1
                    Case "alleKunder"
                        Dim data As New DataTable
                        sporring = "SELECT * FROM Kunde"
                        data = query(sporring)
                        Sok_i_kundebase.DataGridView1.DataSource = data
                        Bestilling_og_tilbakelevering_av_sykler.DataGridView1.DataSource = data
                End Select
            Case "sSoke"
                Dim data As New DataTable
                Select Case sykkelSok
                    Case "bestemtSykkel"
                        sporring = "SELECT * FROM Sykkel WHERE Sykkeltype = '" & sporType & "' AND Sykkelmerke = '" & sporMerke & "'"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                    Case "alleSykler"
                        sporring = "SELECT * FROM Sykkel"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                    Case "tilgjengeligeSykler"
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering)"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                    Case "utleiedSykler"
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering)"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                    Case "stjaletsykler"
                        Dim dt As Date = Date.Now
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Dato_til >= '" & dt.ToString("yyyy-MM-dd") & "')"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                End Select
            Case "uSoke"
        End Select
        
    End Sub
    Public Sub slett()
        Select Case slette
            Case "kundeSlett"
                Dim data As New DataTable
                Dim kundeID As Integer
                Select Case registr
                    Case "PrivatKunde"
                        sporring = "SELECT KundeID FROM Kunde WHERE Etternavn_org_navn = '" & sporEtternavn & "' AND Fornavn = '" & sporNavn & "' AND Telefon = '" & sporTel & "' AND Epost = '" & sporEpost & "'"
                        data = query(sporring)
                        Dim rad As DataRow
                        For Each rad In data.Rows
                            kundeID = rad("KundeID")
                        Next rad
                    Case "Organisasjon"
                        sporring = "SELECT KundeID FROM Kunde WHERE Etternavn_org_navn = '" & sporEtternavn & "' AND Telefon = " & sporTel & " AND Epost = '" & sporEpost & "'"
                        data = query(sporring)
                        Dim rad As DataRow
                        For Each rad In data.Rows
                            kundeID = rad("KundeID")
                        Next rad
                End Select
                Dim resp As String = MsgBox("Vil du slette denne kunden?", MsgBoxStyle.YesNo)
                If resp = vbYes Then
                    Dim data1 As New DataTable
                    sporring = "DELETE FROM Kunde WHERE KundeID = " & kundeID
                    data1 = query(sporring)
                End If
            Case "sykkelSlett"
                Select Case spor
                    Case "sType"
                        Dim data As New DataTable
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering) AND Sykkeltype = '" & sporType & "'"
                        data = query(sporring)
                        Slett_sykkel.DataGridView1.DataSource = data
                    Case "sMerke"
                        Dim data As New DataTable
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering) AND Sykkeltype = '" & sporType & "' AND Sykkelmerke = '" & sporMerke & "'"
                        data = query(sporring)
                        Slett_sykkel.DataGridView1.DataSource = data
                    Case "slett"
                        Dim resp As String = MsgBox("Vil du slette denne sykkel?", MsgBoxStyle.YesNo)
                        If resp = vbYes Then
                            Dim data As New DataTable
                            sporring = "DELETE FROM Sykkel WHERE SykkelID = " & sykID
                            data = query(sporring)
                        End If
                End Select
            Case "utstyrSlett"


        End Select
        oversikt()
    End Sub
    Public Sub tilbSykkel()
        Select Case soke1
            Case "tTypeSoke"
                Dim data As New DataTable
                sporring = "SELECT * FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") AND Sykkeltype ='" & sporType & "' AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL)"
                data = query(sporring)
                Bestilling_og_tilbakelevering_av_sykler.DataGridView2.DataSource = data
            Case "tMerkeSoke"
                Dim hjelp As String = sporBox1.Text
                Dim a() As String = hjelp.Split(" ")
                Dim data As New DataTable
                sporring = "SELECT * FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL)"
                data = query(sporring)
                Bestilling_og_tilbakelevering_av_sykler.DataGridView2.DataSource = data
        End Select
    End Sub
    Public Sub tilbSykkelUpdate()
        Dim data As New DataTable
        sporring = "UPDATE Sykkel_bestilling_tilbakelevering SET Tilbakeleveringssted ='" & sporBox1.Text & "' WHERE SykkelID = " & sykID
        data = query(sporring)
        MsgBox("Tilbakelevering av sykkel er registrert!")
        oversikt()
    End Sub

    Public Sub oversikt()
        Dim data As New DataTable
        Dim sporring1 As String = "SELECT COUNT(DISTINCT KundeID) AS AntallKunder FROM Kunde"
        data = query(sporring1)
        Dim rad As DataRow
        Dim antallKunder, antallSykler, antallTilUtleie, antallUtleied As String
        For Each rad In data.Rows
            antallKunder = rad("AntallKunder")
            Form1.Label7.Text = antallKunder
        Next rad
        Dim sporring2 As String = "SELECT COUNT(DISTINCT SykkelID) AS AntallSykler FROM Sykkel"
        data = query(sporring2)
        For Each rad In data.Rows
            antallSykler = rad("AntallSykler")
            Form1.Label8.Text = antallSykler
        Next
        Dim sporring3 As String = "SELECT COUNT(DISTINCT SykkelID) AS AntallSykler FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL)"
        data = query(sporring3)
        For Each rad In data.Rows
            antallTilUtleie = rad("AntallSykler")
            Form1.Label9.Text = antallTilUtleie
        Next rad
        Dim sporring4 As String = "SELECT COUNT(DISTINCT SykkelID) AS AntallSykler FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL)"
        data = query(sporring4)
        For Each rad In data.Rows
            antallUtleied = rad("AntallSykler")
            Form1.Label10.Text = antallUtleied
        Next rad
    End Sub
End Class