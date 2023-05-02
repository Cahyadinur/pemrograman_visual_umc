Public Class kerucut
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r, t, s, volume, luas As Integer
        r = Val(txtJari.Text)
        s = Val(txtPelukis.Text)
        t = Val(txtTinggi.Text)

        volume = hitungVolume(r, t)
        luas = hitungLuas(r, s)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
    Private Function hitungVolume(r As Integer, t As Integer) As Integer
        Dim V As Integer
        V = (3.14 * (r ^ 2) * t) / 3
        Return V
    End Function
    Private Function hitungLuas(r As Integer, s As Integer) As Integer
        Dim L As Integer
        L = 3.14 * r * (r + s)
        Return L
    End Function
End Class