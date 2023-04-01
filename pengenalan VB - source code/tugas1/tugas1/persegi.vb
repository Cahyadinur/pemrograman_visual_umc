Public Class persegi
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, luas, keliling As Integer
        sisi = Val(txtSisi.Text)

        luas = hitungLuas(sisi)
        keliling = hitungKeliling(sisi)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
    Private Function hitungLuas(sisi As Integer) As Integer
        Dim L As Integer
        L = sisi ^ 2
        Return L
    End Function
    Private Function hitungKeliling(sisi As Integer) As Integer
        Dim K As Integer
        K = 4 * sisi
        Return K
    End Function
End Class