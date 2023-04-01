Public Class persegi
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, luas, keliling As Integer
        sisi = Val(txtSisi.Text)
        luas = Val(txtLuas.Text)
        keliling = Val(txtKeliling.Text)
        luas = sisi ^ 2
        keliling = 4 * sisi
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class