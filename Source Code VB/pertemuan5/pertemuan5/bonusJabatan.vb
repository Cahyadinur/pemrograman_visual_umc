Public Class bonusJabatan
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txJabatan.Text
            Case "Manager" : txKeterangan.Text = "Laptop, Flashdisk"

            Case "Bendahara" : txKeterangan.Text = "Kalkulator, Notebook, Bank Account"

            Case "HRD" : txKeterangan.Text = "Buku psikologi, Smartphone"

            Case "Enginer" : txKeterangan.Text = "Tool kit"

            Case Else : txKeterangan.Text = "Maaf anda belum mendapatkan bonus"
        End Select
    End Sub
End Class