Public Class segitiga
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sm1, sm2, alas, tinggi, luas, keliling As Integer
        sm1 = Val(txtSm1.Text)
        sm2 = Val(txtSm2.Text)
        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)
        luas = Val(txtLuas.Text)
        keliling = Val(txtKeliling.Text)
        luas = (alas * tinggi) / 2
        keliling = sm1 + sm2 + alas
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class