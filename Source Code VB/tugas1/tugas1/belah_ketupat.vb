Public Class belah_ketupat
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, d1, d2, luas, keliling As Integer
        sisi = Val(txtSisi.Text)
        d2 = Val(txtD2.Text)
        d1 = Val(txtD1.Text)

        luas = hitungLuas(d1, d2)
        keliling = hitungKeliling(sisi)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
    Private Function hitungLuas(d1 As Integer, d2 As Integer) As Integer
        Dim L As Integer
        L = (d1 * d2) / 2
        Return L
    End Function
    Private Function hitungKeliling(sisi As Integer) As Integer
        Dim K As Integer
        K = 4 * sisi
        Return K
    End Function
End Class