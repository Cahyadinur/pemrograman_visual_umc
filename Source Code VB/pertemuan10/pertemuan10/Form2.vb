Public Class Form2
    Private Sub Reload()
        oMataKuliah.getAllData(DataGridView1)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Private Sub txtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMataKuliah.CariMataKuliah(txtKode.Text)
            If (matakuliah_baru = False) Then
                TampilMataKuliah()
            Else
                MessageBox.Show("Data Tidak Ditemukan!!")
                matakuliah_baru = True
            End If
        End If
    End Sub
    Private Sub TampilMataKuliah()
        txtKode.Text = oMataKuliah.kodemk
        txtNamaMk.Text = oMataKuliah.namamk
        txtSks.Text = oMataKuliah.sks
        txtProdi.Text = oMataKuliah.prodi
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub
    Private Sub ClearEntry()
        txtKode.Clear()
        txtNamaMk.Clear()
        txtSks.Clear()
        txtProdi.Clear()
    End Sub
    Private Sub SimpanDataMataKuliah()
        oMataKuliah.kodemk = txtKode.Text
        oMataKuliah.namamk = txtNamaMk.Text
        oMataKuliah.sks = txtSks.Text
        oMataKuliah.prodi = txtProdi.Text
        oMataKuliah.Simpan()
        Reload()
        If (oMataKuliah.InsertState = True) Then
            MessageBox.Show("Data berhasil disimpan!")
        ElseIf (oMataKuliah.UpdateState = True) Then
            MessageBox.Show("Data berhasil diperbarui!")
        Else
            MessageBox.Show("Data gagal disimpan!")
        End If
        ClearEntry()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKode.Text <> "" And txtNamaMk.Text <> "") Then
            SimpanDataMataKuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Kode MK dan Nama MK tidak boleh kosong!")
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtKode.Text <> "" And txtNamaMk.Text <> "") Then
            SimpanDataMataKuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Kode MK dan Nama MK tidak boleh kosong!")
        End If
    End Sub
    Private Sub Hapus()
        If (matakuliah_baru = False And txtKode.Text <> "") Then
            oMataKuliah.Hapus(txtKode.Text)
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
End Class