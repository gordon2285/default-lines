Public Class TennisLinesCalcs
    Private Shared rnd As New Random()
    Public Shared Function ServePercentageP1(ByVal low As Integer, ByVal high As Integer) As Decimal
        Return ((rnd.Next(low, high)) / 10)
    End Function

    Public Shared Function ServePercentageP2(ByVal low As Integer, ByVal high As Integer) As Decimal
        Return ((rnd.Next(low, high)) / 10)
    End Function
End Class
