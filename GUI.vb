Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Net.Mail
Imports System.Text
Public Class GUI
    Protected Friend num As Integer = 1
    Protected Friend cBox1, cBox2, cBox3, cBox4 As ComboBox
    Protected Friend but1 As Button
    Protected Friend lab1, lab2, lab3, lab4 As Label
    Protected Friend tBox1 As TextBox
    Protected Friend dPicker1 As DateTimePicker
    Protected Friend posisjon(30, 4) As String
    Public Sub lagrePosisjon()
        If cBox4.Text <> "" Then
            cBox4.Enabled = False
            Dim type As String = cBox1.Text
            Dim merke As String = cBox2.Text
            Dim utleiested As String = cBox3.Text
            Dim nummer As Integer = num
            posisjon(num - 1, 0) = nummer
            posisjon(num - 1, 1) = type
            posisjon(num - 1, 2) = merke
            posisjon(num - 1, 3) = utleiested
            lab1.Text = num + 1
            If num = Val(cBox4.Text) Then
                but1.Enabled = False
                lab1.Text = "1"
                MsgBox(Space(25) & "Du har lagret " & num & " posisjoner.")
            End If
        Else
            MsgBox("Du må velge antall posisjoner!", MsgBoxStyle.Exclamation)
        End If
        num += 1
    End Sub
    Public Sub visLagredePosisjoner()
        For i = 0 To Val(cBox4.Text) - 1
            Utskrift.ListBox1.Items.Add("Posisjon " & posisjon(i, 0) & ": Type: " & posisjon(i, 1) &
                   ", merke: " & posisjon(i, 2) & ", utleiested: " & posisjon(i, 3) & "." & vbNewLine)
        Next
        Utskrift.Show()
    End Sub
    Public Sub enkelt()
        lab2.Text = "Etternavn"
        lab3.Visible = True
        tBox1.Visible = True
        lab4.Visible = True
        dPicker1.Visible = True
    End Sub
    Public Sub organisasjon()
        lab2.Text = "Org.navn"
        lab3.Visible = False
        tBox1.Visible = False
        lab4.Visible = False
        dPicker1.Visible = False
    End Sub
    
End Class
