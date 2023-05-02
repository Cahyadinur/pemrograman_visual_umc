Public Class belah_ketupat
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, d1, d2, luas, keliling As Integer
        sisi = Val(txtSisi.Text)
        d2 = Val(txtD2.Text)
        d1 = Val(txtD1.Text)
        luas = Val(txtLuas.Text)
        keliling = Val(txtKeliling.Text)
        luas = (d1 * d2) / 2
        keliling = 4 * sisi
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class