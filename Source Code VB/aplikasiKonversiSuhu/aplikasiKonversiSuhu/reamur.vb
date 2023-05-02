Public Class reamur
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim C, F, R, K As Decimal
        R = CDec(txReamur.Text)
        C = toCelcius(R)
        F = toFahrenheit(R)
        K = toKelvin(R)

        txCelcius.Text = Str(C)
        txFahren.Text = Str(F)
        txKelvin.Text = Str(K)
    End Sub
    Private Function toCelcius(R As Decimal) As Decimal
        Dim C As Decimal
        C = (5 / 4) * R
        Return C
    End Function
    Private Function toFahrenheit(R As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 4) * (R + 32)
        Return F
    End Function
    Private Function toKelvin(R As Decimal) As Decimal
        Dim K As Decimal
        K = (5 / 4) * (R + 273)
        Return K
    End Function
End Class