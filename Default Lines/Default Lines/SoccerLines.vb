Public Class SoccerLinesCalcs

    Public Shared Function SoccerHandicap(ByVal a As Integer, ByVal b As Integer) As Decimal
        Dim rnd As New Random()
        Return ((rnd.Next(a, b)) / 4)
    End Function

    Public Shared Function SoccerTotal(ByVal c As Integer, ByVal d As Integer) As Decimal
        Dim rnd2 As New Random()
        Return ((rnd2.Next(c, d)) / 4)
    End Function

End Class
