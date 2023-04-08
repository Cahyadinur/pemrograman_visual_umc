Public Class celcius
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim C, F, R, K As Decimal
        C = CDec(txCelcius.Text)
        F = toFahrenheit(C)
        R = toReamur(C)
        K = toKelvin(C)

        txFahren.Text = Str(F)
        txReamur.Text = Str(R)
        txKelvin.Text = Str(K)
    End Sub
    Private Function toFahrenheit(C As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 5) * (C + 32)
        Return F
    End Function
    Private Function toReamur(C As Decimal) As Decimal
        Dim R As Decimal
        R = (4 / 5) * C
        Return R
    End Function
    Private Function toKelvin(C As Decimal) As Decimal
        Dim K As Decimal
        K = C + 273
        Return K
    End Function
End Class
