Public Class bola
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim r, volume, luas As Integer
        r = Val(txtJari.Text)

        volume = hitungVolume(r)
        luas = hitungLuas(r)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
    Private Function hitungVolume(r As Integer) As Integer
        Dim V As Integer
        V = (4 * 3.14 * (r ^ 3)) / 3
        Return V
    End Function
    Private Function hitungLuas(r As Integer) As Integer
        Dim L As Integer
        L = 4 * 3.14 * (r ^ 2)
        Return L
    End Function
End Class