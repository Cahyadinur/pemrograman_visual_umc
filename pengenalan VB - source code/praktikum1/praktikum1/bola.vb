Public Class bola
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r, volume, luas As Integer
        r = Val(txtJari.Text)

        volume = (4 * 3.14 * (r ^ 3)) / 3
        luas = 4 * 3.14 * (r ^ 2)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class