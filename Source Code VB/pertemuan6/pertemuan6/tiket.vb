Public Class tiket
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim usia As Decimal

        'fungsi radio button
        If rdAnak.Checked Then
            usia = 10000
        ElseIf rdDewasa.Checked Then
            usia = 20000
        ElseIf rdLansia.Checked Then
            usia = 15000
        Else
            MessageBox.Show("Tolong Pilih Kategori Usia Anda!")
        End If

        txHarga.Text = Format(Val(usia), "Rp,###,##,0.00")
    End Sub
End Class