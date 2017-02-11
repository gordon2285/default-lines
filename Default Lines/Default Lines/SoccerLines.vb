Public Class SoccerLines

    Public Shared Function SoccerHandicap() As Decimal
        Dim rnd As New Random()
        Dim HandicapValue As Decimal
        Dim a As Integer = 4
        Dim b As Integer = 9

        HandicapValue = (rnd.Next(a, b))
        HandicapValue = HandicapValue / 4
        Return HandicapValue
    End Function

    Public Shared Function SoccerTotal(ByVal c As Integer, ByVal d As Integer) As Decimal
        Dim rnd2 As New Random()
        Return ((rnd2.Next(c, d)) / 4)
    End Function

End Class
