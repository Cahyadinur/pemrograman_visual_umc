Public Class kasir
    Dim harga As Decimal
    Private Sub kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPromo.Items.Clear() 'Fungsi untuk menghapus isi combo box
        cmbPromo.Items.Add("Promo 1") 'Fungsi untuk menambah isi combo box
        cmbPromo.Items.Add("Promo 2")
        cmbPromo.Items.Add("Promo 3")
    End Sub
    Private Sub cmbPromo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPromo.SelectedIndexChanged
        If cmbPromo.Text = "Promo 1" Then
            txIsi.Text = "Ayam Penyet + Salad"
            harga = "30000"
        ElseIf cmbPromo.Text = "Promo 2" Then
            txIsi.Text = "Nasi Goreng + Dadar"
            harga = "35000"
        ElseIf cmbPromo.Text = "Promo 3" Then
            txIsi.Text = "Ramen Ichiraku"
            harga = "50000"
        End If

        txHarga.Text = Format(Val(harga), "Rp,###,##,0.00")
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim promo As Decimal
        Dim tambahan As Decimal
        Dim total As Decimal

        promo = harga

        'fungsi radio button
        If rdMenu1.Checked Then
            tambahan = 10000
        ElseIf rdMenu2.Checked Then
            tambahan = 20000
        ElseIf rdMenu3.Checked Then
            tambahan = 15000
        ElseIf rdMenu4.Checked Then
            tambahan = 25000
        End If

        total = promo + tambahan

        If cbMember.Checked = True Then
            total = (promo + tambahan) - (0.1 * (promo + tambahan))
        Else
            total = promo + tambahan
        End If

        txTotal.Text = Format(Val(total), "Rp,###,##,0.00")
    End Sub
End Class