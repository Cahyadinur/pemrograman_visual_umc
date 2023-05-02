Public Class kerucut
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r, t, s, volume, luas As Integer
        r = Val(txtJari.Text)
        s = Val(txtPelukis.Text)
        t = Val(txtTinggi.Text)

        volume = (3.14 * (r ^ 2) * t) / 3
        luas = 3.14 * r * (r + s)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class