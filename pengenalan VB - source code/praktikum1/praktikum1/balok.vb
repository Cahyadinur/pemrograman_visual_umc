Public Class balok
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, tinggi, volume, luas As Integer
        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)
        tinggi = Val(txtTinggi.Text)

        volume = panjang * lebar * tinggi
        luas = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi))

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class