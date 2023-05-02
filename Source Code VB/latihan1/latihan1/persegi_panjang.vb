Public Class persegi_panjang
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, luas, keliling As Integer
        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)
        luas = Val(txtLuas.Text)
        keliling = Val(txtKeliling.Text)
        luas = panjang * lebar
        keliling = (2 * panjang) + (2 * lebar)
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
