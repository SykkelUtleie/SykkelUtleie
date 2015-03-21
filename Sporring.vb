Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Net.Mail
Imports System.Text
Public Class Sporring
    Private sporring As String
    Protected Friend registr, soke, soke1, kundeSok, sykkelSok, slette, spor, sykID, kundID As String
    Protected Friend sporEtternavn, sporNavn, sporAdresse, sporTel, sporEpost, sporFdato, sporDatoFra, sporDatoTil As String
    Protected Friend sporType, sporMerke, sporHjul, sporRamme, sporGir, sporGaffel, sporBremser, sporBestType, sporBestMerke As String
    Protected Friend sporBox1, sporBox2, sporBox3, sporBox8, sporBox9 As ComboBox
    Private B_id, bruker1, po As String

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
        sporring += "CREATE TABLE `Bestilling_tilbakelevering` (`BestillingID` int(10) NOT NULL AUTO_INCREMENT, " &
            "`Utleied_av` int(10) unsigned NOT NULL, " &
            "`Dato_fra` date DEFAULT NULL, " &
            "`Dato_til` date DEFAULT NULL, " &
            "`Utleiested` varchar(30) DEFAULT NULL, " &
            "`Tilbakeleveringssted` varchar(30) DEFAULT NULL, " &
            "`Dato_b` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP, " &
            "PRIMARY KEY (`BestillingID`)) ENGINE=MyISAM DEFAULT CHARSET=latin1; " &
            "ALTER TABLE `Bestilling_tilbakelevering` " &
            "ADD FOREIGN KEY(Utleied_av) REFERENCES Kunde(KundeID);"
        sporring += "CREATE TABLE`Sykkel_bestilling` (`BestillingID` int(10) unsigned NOT NULL, " &
            "`SykkelID` int(10) unsigned NOT NULL) ENGINE=MyISAM DEFAULT CHARSET=latin1;" &
            "ALTER TABLE `Sykkel_bestilling` " &
            "ADD FOREIGN KEY(SykkelID) REFERENCES Sykkel(SykkelID);" &
            "ALTER TABLE `Sykkel_bestilling` " &
            "ADD FOREIGN KEY(BestillingID) REFERENCES Bestilling_tilbakelevering(BestillingID);"
        sporring += "CREATE TABLE `Utstyr_bestilling` (`BestillingID` int(10) unsigned NOT NULL, " &
            "`UtstyrID` int(10) unsigned NOT NULL) ENGINE=MyISAM DEFAULT CHARSET=latin1; " &
            "ALTER TABLE `Utstyr_bestilling` " &
            "ADD FOREIGN KEY(UtstyrID) REFERENCES Utstyr(UtstyrID);" &
            "ALTER TABLE `Sykkel_bestilling` " &
            "ADD FOREIGN KEY(BestillingID) REFERENCES Bestilling_tilbakelevering(BestillingID);"
        sporring += "CREATE TABLE `auth` (`id` int(11) NOT NULL AUTO_INCREMENT, " &
            "`klasse` int(11) NOT NULL, " &
            "`navn` varchar(50) DEFAULT NULL, " &
            "`login` varchar(50) DEFAULT NULL, " &
            "`password` varchar(50) DEFAULT NULL, " &
            "`epost` varchar(50) DEFAULT NULL, " &
            "PRIMARY KEY (`id`)) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;"
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
            Dim sporring1 As String = "SELECT Sykkeltype, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL) GROUP BY Sykkeltype"
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
            sporring = "SELECT Sykkeltype, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL) GROUP BY Sykkeltype"
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
            sporring = "SELECT Sykkelmerke, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' AND SykkelID IN (SELECT s.SykkelID FROM Sykkel_bestilling s,Bestilling_tilbakelevering sb WHERE sb.Utleied_av = " & kundID & ") GROUP BY Sykkelmerke"
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
            sporring = "SELECT Sykkelmerke, COUNT(DISTINCT SykkelID) AS Antall FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' AND (SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL)) GROUP BY Sykkelmerke"
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
    Public Sub hentUtstyrType()
        sporBox9.Items.Clear()
        Dim data As New DataTable
        sporring = "SELECT Utstyrtype, COUNT(DISTINCT UtstyrID) AS Antall FROM Utstyr WHERE UtstyrID NOT IN (SELECT UtstyrID FROM Utstyr_bestilling) OR UtstyrID IN (SELECT UtstyrID FROM Utstyr_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL) GROUP BY Utstyrtype"
        data = query(sporring)
        Dim rad As DataRow
        Dim utstyrtype, antallType As String
        For Each rad In data.Rows
            utstyrtype = rad("Utstyrtype")
            antallType = rad("Antall")
            sporBox9.Items.Add(utstyrtype)
        Next rad
    End Sub
    Public Sub hentUtstyrMerke()
        sporBox8.Items.Clear()
        Dim hjelp As String = sporBox9.Text
        Dim a() As String = hjelp.Split(" ")
        Dim data As New DataTable
        sporring = "SELECT Utstyrmerke, COUNT(DISTINCT UtstyrID) AS Antall FROM Utstyr WHERE Utstyrtype LIKE '" & a(0) & "' AND (UtstyrID NOT IN (SELECT UtstyrID FROM Utstyr_bestilling) OR UtstyrID IN (SELECT UtstyrID FROM Utstyr_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL)) GROUP BY Utstyrmerke"
        data = query(sporring)
        Dim rad As DataRow
        Dim utstyrmerke, antallMerke As String
        For Each rad In data.Rows
            utstyrmerke = rad("Utstyrmerke")
            antallMerke = rad("Antall")
            sporBox8.Items.Add(utstyrmerke)
        Next rad
    End Sub
    Public Sub bestillingSykkel()
        Dim data1 As New DataTable
        Dim sporring2 As String = "SELECT KundeID FROM Kunde WHERE Etternavn_org_navn = '" & sporEtternavn & "' AND Adresse = '" & sporAdresse & "' AND Telefon = " & sporTel & " AND Epost = '" & sporEpost & "'"
        data1 = query(sporring2)
        Dim rad1 As DataRow
        Dim KundeID As Integer
        For Each rad1 In data1.Rows
            KundeID = rad1("KundeID")
        Next rad1
        Dim data2 As New DataTable
        Dim sporring3 As String = "INSERT INTO Bestilling_tilbakelevering(Utleied_av, Dato_fra, Dato_til, Utleiested, Tilbakeleveringssted) VALUES('" & KundeID &
        "', '" & sporDatoFra & "', '" & sporDatoTil & "', '" & sporBox3.Text & "',NULL)"
        data2 = query(sporring3)
        Dim rad6 As Integer = 0
        For Each row As DataGridViewRow In Bestilling_og_tilbakelevering_av_sykler.DataGridView3.Rows
            Dim type As String = Bestilling_og_tilbakelevering_av_sykler.DataGridView3.Rows(rad6).Cells(1).Value.ToString
            Dim merke As String = Bestilling_og_tilbakelevering_av_sykler.DataGridView3.Rows(rad6).Cells(2).Value.ToString
            rad6 += 1
            Dim data As New DataTable
            Dim sporring1 As String = "SELECT SykkelID FROM Sykkel WHERE Sykkeltype = '" & type & "' AND Sykkelmerke = '" & merke & "' AND (SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL))"
            data = query(sporring1)
            Dim rad As DataRow = data.Rows(0)
            Dim sykkelId As Integer
            For Each rad In data.Rows
                sykkelId = rad("SykkelID")
            Next
            Dim data3 As New DataTable
            Dim sporring4 As String = "SELECT LAST_INSERT_ID() AS last"
            data3 = query(sporring4)

            Dim rad2 As DataRow
            For Each rad2 In data3.Rows
                B_id = rad2("last")
            Next
            Dim data4 As New DataTable
            Dim sporring5 As String = "INSERT INTO Sykkel_bestilling VALUES ('" & B_id & "', '" & sykkelId & "')"
            data4 = query(sporring5)
        Next
        Dim rad7 As Integer = 0
        For Each row As DataGridViewRow In Bestilling_og_tilbakelevering_av_sykler.DataGridView4.Rows
            Dim type As String = Bestilling_og_tilbakelevering_av_sykler.DataGridView4.Rows(rad7).Cells(1).Value.ToString
            Dim merke As String = Bestilling_og_tilbakelevering_av_sykler.DataGridView4.Rows(rad7).Cells(2).Value.ToString
            rad7 += 1
            Dim data10 As New DataTable
            Dim sporring10 As String = "SELECT MIN(UtstyrID) FROM Utstyr WHERE Utstyrtype = '" & type & "' AND Utstyrmerke = '" & merke & "' AND (UtstyrID NOT IN (SELECT UtstyrID FROM Utstyr_bestilling) OR UtstyrID IN (SELECT UtstyrID FROM Utstyr_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL))"
            data10 = query(sporring10)
            Dim rad10 As DataRow = data10.Rows(0)
            Dim utstyrID As Integer
            For Each rad10 In data10.Rows
                utstyrID = rad10("MIN(UtstyrID)")
            Next
            Dim data11 As New DataTable
            Dim sporring11 As String = "SELECT LAST_INSERT_ID() AS last"
            data11 = query(sporring11)
            'Dim B_id As String
            Dim rad11 As DataRow
            For Each rad11 In data11.Rows
                B_id = rad11("last")
            Next
            Dim data12 As New DataTable
            Dim sporring12 As String = "INSERT INTO Utstyr_bestilling VALUES ('" & B_id & "', '" & utstyrID & "')"
            data12 = query(sporring12)
        Next
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
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling)"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                    Case "utleiedSykler"
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling)"
                        data = query(sporring)
                        Sok_i_sykkelbase.DataGridView1.DataSource = data
                    Case "stjaletsykler"
                        Dim dt As Date = Date.Now
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Dato_til >= '" & dt.ToString("yyyy-MM-dd") & "')"
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
                    sporring = "DELETE FROM Kunde WHERE KundeID = '" & kundeID & "'"
                    data1 = query(sporring)
                End If
            Case "sykkelSlett"
                Select Case spor
                    Case "sType"
                        Dim data As New DataTable
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling) AND Sykkeltype = '" & sporType & "'"
                        data = query(sporring)
                        Slett_sykkel.DataGridView1.DataSource = data
                    Case "sMerke"
                        Dim data As New DataTable
                        sporring = "SELECT * FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling) AND Sykkeltype = '" & sporType & "' AND Sykkelmerke = '" & sporMerke & "'"
                        data = query(sporring)
                        Slett_sykkel.DataGridView1.DataSource = data
                    Case "slett"
                        Dim resp As String = MsgBox("Vil du slette denne sykkel?", MsgBoxStyle.YesNo)
                        If resp = vbYes Then
                            Dim data As New DataTable
                            sporring = "DELETE FROM Sykkel WHERE SykkelID = '" & sykID & "'"
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
                sporring = "SELECT * FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") AND Sykkeltype ='" & sporType & "' AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL)"
                data = query(sporring)
                Bestilling_og_tilbakelevering_av_sykler.DataGridView2.DataSource = data
            Case "tMerkeSoke"
                Dim hjelp As String = sporBox1.Text
                Dim a() As String = hjelp.Split(" ")
                Dim data As New DataTable
                sporring = "SELECT * FROM Sykkel WHERE Sykkeltype LIKE '" & a(0) & "' AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Utleied_av = " & kundID & ") AND SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL)"
                data = query(sporring)
                Bestilling_og_tilbakelevering_av_sykler.DataGridView2.DataSource = data
        End Select
    End Sub
    Public Sub tilbSykkelUpdate()
        Dim data As New DataTable
        sporring = "UPDATE Bestilling_tilbakelevering SET Tilbakeleveringssted ='" & sporBox1.Text & "' WHERE SykkelID = " & sykID
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
        Dim sporring3 As String = "SELECT COUNT(DISTINCT SykkelID) AS AntallSykler FROM Sykkel WHERE SykkelID NOT IN (SELECT SykkelID FROM Sykkel_bestilling) OR SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NOT NULL)"
        data = query(sporring3)
        For Each rad In data.Rows
            antallTilUtleie = rad("AntallSykler")
            Form1.Label9.Text = antallTilUtleie
        Next rad
        Dim sporring4 As String = "SELECT COUNT(DISTINCT SykkelID) AS AntallSykler FROM Sykkel WHERE SykkelID IN (SELECT SykkelID FROM Sykkel_bestilling, Bestilling_tilbakelevering WHERE Tilbakeleveringssted IS NULL)"
        data = query(sporring4)
        For Each rad In data.Rows
            antallUtleied = rad("AntallSykler")
            Form1.Label10.Text = antallUtleied
        Next rad
    End Sub
    Shared forsok As Integer = 3
    Public Shared klasse As String
    Public Sub bruker()

        Dim data As New DataTable
        Dim sql As String = "Select login From auth Where login = '" & Tilgang.TextBox1.Text & "' and password = '" & Tilgang.TextBox2.Text & "' "
        data = query(sql)
        If forsok = 1 Then
            MsgBox("Du har brukt for mange innloggingsforsøk!")
            Form1.Close()
        Else
            If data.Rows.Count = 1 Then
                Form1.Show()

            Else
                forsok -= 1
                If forsok > 1 Then
                    MsgBox("Login eller Passord er feil, du har " & forsok & " forsøk igjen!")
                Else
                    MsgBox("Login eller Passord er feil, du har ETT forsøk igjen!")
                End If

            End If
        End If
    End Sub

    Public Sub sokBruker()
        Dim data As New DataTable
        Dim sql As String = "SELECT * FROM auth"
        data = query(sql)
        Brukere.DataGridView1.DataSource = data
    End Sub
    Public Sub slettBruker()
        Dim brukerid As String = Brukere.DataGridView1.Rows(Brukere.DataGridView1.CurrentRow.Index).Cells(2).Value.ToString()
        Dim data As New DataTable
        Dim sql As String = "DELETE FROM auth WHERE login = '" & brukerid & "'"
        data = query(sql)
    End Sub
    Public Sub endreBruker()

    End Sub
    Public Sub leggtilBruker()
        Dim login As String
        Dim sjekk As Integer = 0
        Dim data2 As New DataTable
        Dim sql2 As String = "SELECT login FROM auth"
        data2 = query(sql2)
        For Each rad In data2.Rows
            login = rad("login")
            If login = Brukere.TextBox4.Text Then
                sjekk = 1
            End If
        Next
        If sjekk = 1 Then
            MsgBox("Brukernavnet er allerede i bruk!")
            Brukere.TextBox4.Clear()
            Brukere.TextBox4.Select()
        Else
            If Brukere.TextBox5.Text = Brukere.TextBox6.Text Then
                Dim data As New DataTable
                sporring = "INSERT INTO auth VALUES(NULL, '" & Brukere.TextBox1.Text & "','" & Brukere.TextBox4.Text & "','" & Brukere.TextBox3.Text & "','" & Brukere.TextBox5.Text & "','" & Brukere.TextBox2.Text & "','" & Brukere.TextBox3.Text & "');"
                data = query(sporring)
                MsgBox("Ny privat kunde er registrert!", MsgBoxStyle.Information)
            Else
                MsgBox("Kontroll passordet stemmer ikke med passordet. Prøv på nytt!")
                Brukere.TextBox5.Clear() : Brukere.TextBox6.Clear() : Brukere.TextBox5.Select()
            End If
        End If
    End Sub
    Public Sub glemt()
        Dim epostmelding As New MailMessage()
        Dim epost As String = InputBox("Skriv inn din registerte epost")
        'Dim bruker As String
        'Dim po As String
        Dim data As New DataTable
        Dim rad As DataRow
        Dim sql As String = "Select login, password From auth Where epost = '" & epost & "' "
        data = query(sql)
        For Each rad In data.Rows
            bruker1 = rad("login")
            po = rad("password")
        Next
        Try
            epostmelding.From = New MailAddress("babed.epost.test@gmail.com")
            epostmelding.To.Add(epost)
            epostmelding.Subject = "Brukernavn og passord"
            epostmelding.Body = "Ditt brukernavn er: " & bruker1 & " og passordet er: " & po
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("babed.epost.test@gmail.com", "trondheim")
            smtp.Send(epostmelding)
            MsgBox("E-post er sendt!")

        Catch ex As Exception
            MsgBox("Noe gikk galt med sending av e-post: " & ex.Message)
        End Try
    End Sub
End Class
