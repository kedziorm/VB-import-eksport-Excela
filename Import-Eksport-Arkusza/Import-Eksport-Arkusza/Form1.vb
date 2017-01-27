Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub btnKoniec_Click(sender As Object, e As EventArgs) Handles btnKoniec.Click
        Close()
    End Sub

    Private Sub btnWczytaj_Click(sender As Object, e As EventArgs) Handles btnWczytaj.Click

        Dim APP As New Excel.Application
        Dim skoroszyt_out As Excel.Workbook = APP.Workbooks.Add()
        Dim skoroszyt_in As Excel.Workbook
        Dim arkusz_out As Excel.Worksheet = skoroszyt_out.Sheets(1)
        Dim arkusz_in As Excel.Worksheet

        ' Wczytanie pliku
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'MsgBox(String.Format("Wybrano plik: '{0}'", OpenFileDialog1.FileName))

            Dim NazwaPliku = OpenFileDialog1.FileName
            skoroszyt_in = APP.Workbooks.Open(NazwaPliku)

            lblDiagnostyka.Text = ""
            Dim wiersz As Integer = 2

            ' Zapisanie nagłówka
            arkusz_out.Cells(1, 1).value = "Nazwa arkusza"
            arkusz_out.Cells(1, 2).value = "Suma"
            arkusz_out.Cells(1, 3).value = "Średnia"

            For Each arkusz_in In skoroszyt_in.Sheets()
                Dim ostatniWiersz =
                    arkusz_in.Range("A1").End(Excel.XlDirection.xlDown).Row
                Dim ostatniaKolumna =
                    arkusz_in.Range("A1").End(Excel.XlDirection.xlToRight).Column
                lblDiagnostyka.Text += String.Format("Nazwa: {0}, l. wierszy: {1}, l. kolumn: {2}{3}",
                                                    arkusz_in.Name, ostatniWiersz, ostatniaKolumna, vbNewLine)

                '''''''''''''''''''''''
                '' ToDo - użyć LinQ zamiast sumowania w taki rozwlekły sposób
                ' Imports System.Linq
                ' Dim zakresDanych As System.Array =
                ' arkusz_in.Range(arkusz_in.Cells(2, ostatniaKolumna), arkusz_in.Cells(ostatniWiersz, ostatniaKolumna)).Value
                ' Dim srednia As Double = zakresDanych.Average()
                '''''''''''''''''''''''
                Dim suma, srednia As Double
                suma = 0

                For i = 2 To ostatniWiersz
                    suma += arkusz_in.Cells(i, ostatniaKolumna).Value
                Next

                srednia = suma / (ostatniWiersz - 1)

                arkusz_out.Cells(wiersz, 1).value = arkusz_in.Name
                arkusz_out.Cells(wiersz, 2).value = suma
                arkusz_out.Cells(wiersz, 3).value = srednia
                wiersz += 1
            Next

            skoroszyt_in.Close()

        Else
            MsgBox("Nie wybrałeś pliku do wczytania!!!")
        End If

        ' Zapis do pliku
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ''MsgBox(String.Format("Wybrano zapis do: '{0}'", SaveFileDialog1.FileName))
            skoroszyt_out.SaveAs(SaveFileDialog1.FileName)
            skoroszyt_out.Close()
        Else
            MsgBox("Nie wybrałeś miejsca zapisu")
        End If

    End Sub
End Class
