Public Class kelulusan
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txNilai.Text) >= 60) Then
            txKeterangan.Text = "Anda Lulus"
        Else
            txKeterangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub
End Class