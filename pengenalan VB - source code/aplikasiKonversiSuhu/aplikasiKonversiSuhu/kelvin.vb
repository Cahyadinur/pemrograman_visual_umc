Public Class kelvin
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim C, F, R, K As Decimal
        K = CDec(txKelvin.Text)
        C = toCelcius(K)
        F = toFahrenheit(K)
        R = toReamur(K)

        txCelcius.Text = Str(C)
        txFahren.Text = Str(F)
        txReamur.Text = Str(R)
    End Sub
    Private Function toCelcius(K As Decimal) As Decimal
        Dim C As Decimal
        C = K - 273
        Return C
    End Function
    Private Function toFahrenheit(K As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 5) * (K - 273) + 32
        Return F
    End Function
    Private Function toReamur(K As Decimal) As Decimal
        Dim R As Decimal
        R = (4 / 5) * (K - 273)
        Return R
    End Function
End Class