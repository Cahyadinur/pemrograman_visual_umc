Public Class registrasi
    Private Sub registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProdi.Items.Clear() 'Fungsi untuk menghapus isi combo box
        cmbProdi.Items.Add("Teknik Informatika") 'Fungsi untuk menambah isi combo box
        cmbProdi.Items.Add("Teknik Industri")
        cmbProdi.Items.Add("Teknik Listrik")
        cmbProdi.Items.Add("Teknik Geografi")
        cmbProdi.Items.Add("PGSD")
        cmbProdi.Items.Add("Management")
    End Sub

    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        If cmbProdi.Text = "Teknik Informatika" Then
            txBiaya.Text = "Rp. 8.000.0000"
        ElseIf cmbProdi.Text = "Teknik Industri" Then
            txBiaya.Text = "Rp. 7.000.000"
        ElseIf cmbProdi.Text = "Teknik Listrik" Then
            txBiaya.Text = "Rp. 8.500.000"
        ElseIf cmbProdi.Text = "Teknik Geografi" Then
            txBiaya.Text = "Rp. 7.500.000"
        ElseIf cmbProdi.Text = "PGSD" Then
            txBiaya.Text = "Rp. 14.000.000"
        ElseIf cmbProdi.Text = "Management" Then
            txBiaya.Text = "Rp. 6.000.000"
        End If
    End Sub
End Class
