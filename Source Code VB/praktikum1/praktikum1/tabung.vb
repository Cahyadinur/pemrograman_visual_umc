Public Class tabung
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r, t, volume, luas As Integer
        r = Val(txtJari.Text)
        t = Val(txtTinggi.Text)

        volume = 3.14 * (r ^ 2) * t
        luas = 2 * 3.14 * r * (r + t)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class