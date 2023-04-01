Public Class kubus
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, volume, luas As Integer
        sisi = Val(txtSisi.Text)

        volume = hitungVolume(sisi)
        luas = hitungLuas(sisi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
    Private Function hitungVolume(sisi As Integer) As Integer
        Dim V As Integer
        V = sisi ^ 3
        Return V
    End Function
    Private Function hitungLuas(sisi As Integer) As Integer
        Dim L As Integer
        L = 6 * (sisi ^ 2)
        Return L
    End Function
End Class