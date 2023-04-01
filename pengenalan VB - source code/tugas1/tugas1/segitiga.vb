Public Class segitiga
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sm1, sm2, alas, tinggi, luas, keliling As Integer
        sm1 = Val(txtSm1.Text)
        sm2 = Val(txtSm2.Text)
        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)

        luas = hitungLuas(alas, tinggi)
        keliling = hitungKeliling(sm1, sm2, alas)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
    Private Function hitungLuas(alas As Integer, tinggi As Integer) As Integer
        Dim L As Integer
        L = (alas * tinggi) / 2
        Return L
    End Function
    Private Function hitungKeliling(sm1 As Integer, sm2 As Integer, alas As Integer) As Integer
        Dim K As Integer
        K = sm1 + sm2 + alas
        Return K
    End Function
End Class