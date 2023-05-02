Public Class fahrenheit
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim C, F, R, K As Decimal
        F = CDec(txFahren.Text)
        C = toCelcius(F)
        R = toReamur(F)
        K = toKelvin(F)

        txCelcius.Text = Str(C)
        txReamur.Text = Str(R)
        txKelvin.Text = Str(K)
    End Sub
    Private Function toCelcius(F As Decimal) As Decimal
        Dim C As Decimal
        C = (5 / 9) * (F - 32)
        Return C
    End Function
    Private Function toReamur(F As Decimal) As Decimal
        Dim R As Decimal
        R = (4 / 9) * (F - 32)
        Return R
    End Function
    Private Function toKelvin(F As Decimal) As Decimal
        Dim K As Decimal
        K = (5 / 9) * (F - 32) + 273
        Return K
    End Function
End Class