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
                mahasiswa_baru = True
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
    Private Sub SimpanDataMahasiswa()
        oMahasiswa.nim = txtNim.Text
        oMahasiswa.nama = txtNama.Text
        oMahasiswa.jk = txtJk.Text
        oMahasiswa.prodi = txtProdi.Text
        oMahasiswa.Simpan()
        Reload()
        If (oMahasiswa.InsertState = True) Then
            MessageBox.Show("Data berhasil disimpan!")
        ElseIf (oMahasiswa.UpdateState = True) Then
            MessageBox.Show("Data berhasil diperbarui!")
        Else
            MessageBox.Show("Data gagal disimpan!")
        End If
        ClearEntry()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtNim.Text <> "" And txtNama.Text <> "") Then
            SimpanDataMahasiswa()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("NIM dan nama tidak boleh kosong!")
        End If
    End Sub
    Private Sub Hapus()
        If (mahasiswa_baru = False And txtNim.Text <> "") Then
            oMahasiswa.Hapus(txtNim.Text)
            ClearEntry()
            Reload()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus?", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
            MessageBox.Show("Data berhasil dihapus!")
        Else
            MessageBox.Show("Data batal dihapus!")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtNim.Text <> "" And txtNama.Text <> "") Then
            SimpanDataMahasiswa()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("NIM dan nama tidak boleh kosong!")
        End If
    End Sub
End Class

