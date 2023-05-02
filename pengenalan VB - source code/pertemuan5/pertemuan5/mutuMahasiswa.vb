Public Class mutuMahasiswa
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim nim, nama, prodi As String
        nim = txNim.Text
        nama = txNama.Text
        prodi = txProdi.Text

        txOutNim.Text = nim
        txOutNama.Text = nama
        txOutProdi.Text = prodi

        Dim hadir, tugas, uts, uas, akhir As Integer
        hadir = Val(txHadir.Text)
        tugas = Val(txTugas.Text)
        uts = Val(txUts.Text)
        uas = Val(txUas.Text)
        akhir = nilaiAkhir(hadir, tugas, uts, uas)

        txAkhir.Text = Str(akhir)

        If (akhir >= 85) Then
            txMutu.Text = "A"
        ElseIf (akhir >= 75) Then
            txMutu.Text = "B"
        ElseIf (akhir >= 55) Then
            txMutu.Text = "C"
        ElseIf (akhir >= 30) Then
            txMutu.Text = "D"
        ElseIf (akhir <= 29) Then
            txMutu.Text = "E"
        End If
    End Sub
    Private Function nilaiAkhir(hadir As Integer, tugas As Integer, uts As Integer, uas As Integer) As Integer
        Dim A As Integer
        A = (0.25 * hadir) + (0.35 * tugas) + (0.2 * uts) + (0.2 * uas)
        Return A
    End Function
End Class