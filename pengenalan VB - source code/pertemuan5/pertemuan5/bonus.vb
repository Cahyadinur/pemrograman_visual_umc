Public Class bonus
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txMasa.Text) >= 20) Then
            txKeterangan.Text = "Anda mendapat bonus berupa motor"

        ElseIf (txMasa.Text >= 15) Then
            txKeterangan.Text = "Anda mendapat bonus sepeda gunung"

        ElseIf (txMasa.Text >= 10) Then
            txKeterangan.Text = "Anda mendapat binus cincin emas 5gr"

        ElseIf (txMasa.Text >= 5) Then
            txKeterangan.Text = "Anda mendapat voucher belanja Rp.500rb"

        Else
            txKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class
