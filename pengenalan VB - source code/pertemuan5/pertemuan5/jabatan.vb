Public Class jabatan
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txKode.Text
            Case "MGR" : txKeterangan.Text = "Manager"

            Case "SKR" : txKeterangan.Text = "Sekretaris"

            Case "BDH" : txKeterangan.Text = "Bendahara"

            Case Else : txKeterangan.Text = "Staff"
        End Select
    End Sub
End Class