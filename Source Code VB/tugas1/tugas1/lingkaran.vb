Public Class lingkaran
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, luas, keliling As Integer
        jari = Val(txtJari.Text)

        luas = hitungLuas(jari)
        keliling = hitungKeliling(jari)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
    Private Function hitungLuas(jari As Integer) As Integer
        Dim L As Integer
        L = 3.14 * (jari ^ 2)
        Return L
    End Function
    Private Function hitungKeliling(jari As Integer) As Integer
        Dim K As Integer
        K = 2 * 3.14 * jari
        Return K
    End Function
End Class