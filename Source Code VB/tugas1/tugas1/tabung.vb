Public Class tabung
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r, t, volume, luas As Integer
        r = Val(txtJari.Text)
        t = Val(txtTinggi.Text)

        volume = hitungVolume(r, t)
        luas = hitungLuas(r, t)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub

    Private Function hitungVolume(r As Integer, t As Integer) As Integer
        Dim V As Integer
        V = 3.14 * (r ^ 2) * t
        Return V
    End Function
    Private Function hitungLuas(r As Integer, t As Integer) As Integer
        Dim L As Integer
        L = 2 * 3.14 * r * (r + t)
        Return L
    End Function

End Class