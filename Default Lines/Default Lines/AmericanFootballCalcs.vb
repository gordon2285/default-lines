Public Class AmericanFootballCalcs

    Public Shared Function AmericanFootballHandicap(ByVal a As Integer, ByVal b As Integer) As Decimal
        Dim rnd As New Random()
        Return ((rnd.Next(a, b)) / 2)
    End Function

    Public Shared Function AmericanFootballTotal(ByVal c As Integer, ByVal d As Integer) As Decimal
        Dim rnd2 As New Random()
        Return ((rnd2.Next(c, d)) / 2)
    End Function

End Class
