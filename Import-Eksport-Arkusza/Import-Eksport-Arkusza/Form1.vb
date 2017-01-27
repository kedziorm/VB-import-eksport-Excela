Public Class Form1
    Private Sub btnKoniec_Click(sender As Object, e As EventArgs) Handles btnKoniec.Click
        Close()
    End Sub

    Private Sub btnWczytaj_Click(sender As Object, e As EventArgs) Handles btnWczytaj.Click

        ' Wczytanie pliku
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MsgBox(String.Format("Wybrano plik: '{0}'", OpenFileDialog1.FileName))
        Else
            MsgBox("Nie wybrałeś pliku!!")
        End If

        ' Zapis do pliku
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MsgBox(String.Format("Wybrano zapis do: '{0}'", SaveFileDialog1.FileName))
        Else
            MsgBox("Nie wybrałeś miejsca zapisu")
        End If

    End Sub
End Class
