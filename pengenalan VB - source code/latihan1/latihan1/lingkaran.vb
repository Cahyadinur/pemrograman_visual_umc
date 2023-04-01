Public Class lingkaran
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, luas, keliling As Integer
        jari = Val(txtJari.Text)
        luas = Val(txtLuas.Text)
        keliling = Val(txtKeliling.Text)
        luas = 3.14 * (jari ^ 2)
        keliling = 2 * 3.14 * jari
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class