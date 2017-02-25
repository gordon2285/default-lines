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
    Private Sub Tennis_MGrass_P1_Click(sender As Object, e As EventArgs) Handles Tennis_MGrass_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(630, 700)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600)
    End Sub

    Private Sub Tennis_MGrass_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_MGrass_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 640)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 640)
    End Sub

    Private Sub Tennis_MGrass_P2_Click(sender As Object, e As EventArgs) Handles Tennis_MGrass_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(630, 700)
    End Sub

    Private Sub Tennis_MHard_P1_Click(sender As Object, e As EventArgs) Handles Tennis_MHard_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(650, 720)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(570, 620)
    End Sub

    Private Sub Tennis_MHard_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_MHard_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(600, 660)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(600, 660)
    End Sub

    Private Sub Tennis_MHard_P2_Click(sender As Object, e As EventArgs) Handles Tennis_MHard_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(570, 620)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(650, 720)
    End Sub

    Private Sub Tennis_MClay_P1_Click(sender As Object, e As EventArgs) Handles Tennis_MClay_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 630)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550)
    End Sub

    Private Sub Tennis_MClay_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_MClay_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600)
    End Sub

    Private Sub Tennis_MClay_P2_Click(sender As Object, e As EventArgs) Handles Tennis_MClay_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()
        Tennis_Lines.Show()


        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 630)
    End Sub
End Class