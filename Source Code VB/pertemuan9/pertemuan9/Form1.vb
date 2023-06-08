Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Private Sub Reload()
        oMahasiswa.getAllData(DataGridView1)
    End Sub

    Private Sub txtNim_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNim.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMahasiswa.CariMahasiswa(txtNim.Text)
            If (mahasiswa_baru = False) Then
                TampilMahasiswa()
            Else
                MessageBox.Show("Data Tidak Ditemukan!!")
            End If
        End If
    End Sub
    Private Sub TampilMahasiswa()
        txtNim.Text = oMahasiswa.nim
        txtNama.Text = oMahasiswa.nama
        txtJk.Text = oMahasiswa.jk
        txtProdi.Text = oMahasiswa.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub
    Private Sub ClearEntry()
        txtNim.Clear()
        txtNama.Clear()
        txtJk.Clear()
        txtProdi.Clear()
    End Sub
End Class
