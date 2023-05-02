Public Class balok
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, tinggi, volume, luas As Integer
        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)
        tinggi = Val(txtTinggi.Text)

        volume = hitungVolume(panjang, lebar, tinggi)
        luas = hitungLuas(panjang, lebar, tinggi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
    Private Function hitungVolume(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim V As Integer
        V = panjang * lebar * tinggi
        Return V
    End Function
    Private Function hitungLuas(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim L As Integer
        L = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi))
        Return L
    End Function
End Class