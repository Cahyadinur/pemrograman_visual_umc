Public Class kubus
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, volume, luas As Integer
        sisi = Val(txtSisi.Text)

        volume = sisi ^ 3
        luas = 6 * (sisi ^ 2)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
