Public Class persegi_panjang
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, luas, keliling As Integer
        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)

        luas = hitungLuas(panjang, lebar)
        keliling = hitungKeliling(panjang, lebar)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
    Private Function hitungLuas(panjang As Integer, lebar As Integer) As Integer
        Dim L As Integer
        L = panjang * lebar
        Return L
    End Function
    Private Function hitungKeliling(panjang As Integer, lebar As Integer) As Integer
        Dim K As Integer
        K = (2 * panjang) + (2 * lebar)
        Return K
    End Function
End Class