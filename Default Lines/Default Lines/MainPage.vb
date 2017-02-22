Public Class MainPage
   
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Soccer_Standard.MouseClick
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()
        SoccerLinesWindow.Show()


        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-3, 3)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(9, 14)

    End Sub

    Private Sub Soccer_HFav_NTot_Click(sender As Object, e As EventArgs) Handles Soccer_HFav_NTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()
        SoccerLinesWindow.Show()


        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-8, -3)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(11, 14)
    End Sub

    Private Sub Soccer_AFav_NTot_Click(sender As Object, e As EventArgs) Handles Soccer_AFav_NTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()
        SoccerLinesWindow.Show()


        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(3, 8)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(11, 14)
    End Sub

    Private Sub Soccer_HFav_HTot_Click(sender As Object, e As EventArgs) Handles Soccer_HFav_HTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()
        SoccerLinesWindow.Show()


        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-8, -3)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(16, 24)
    End Sub

    Private Sub Soccer_AFav_HTot_Click(sender As Object, e As EventArgs) Handles Soccer_AFav_HTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()
        SoccerLinesWindow.Show()


        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(3, 8)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(16, 24)
    End Sub
End Class