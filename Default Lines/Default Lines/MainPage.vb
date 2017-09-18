Public Class MainPage

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Soccer_Standard.MouseClick
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()

        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-3, 3)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(9, 14)

        SoccerLinesWindow.ShowDialog()

    End Sub

    Private Sub Soccer_HFav_NTot_Click(sender As Object, e As EventArgs) Handles Soccer_HFav_NTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()

        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-8, -3)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(11, 14)

        SoccerLinesWindow.ShowDialog()

    End Sub

    Private Sub Soccer_AFav_NTot_Click(sender As Object, e As EventArgs) Handles Soccer_AFav_NTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()

        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(3, 8)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(11, 14)

        SoccerLinesWindow.ShowDialog()

    End Sub

    Private Sub Soccer_HFav_HTot_Click(sender As Object, e As EventArgs) Handles Soccer_HFav_HTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()

        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-8, -3)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(16, 24)

        SoccerLinesWindow.ShowDialog()

    End Sub

    Private Sub Soccer_AFav_HTot_Click(sender As Object, e As EventArgs) Handles Soccer_AFav_HTot.Click
        Dim SoccerLinesWindow As soccer_lines
        SoccerLinesWindow = New soccer_lines()

        SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(3, 8)
        SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(16, 24)

        SoccerLinesWindow.ShowDialog()

    End Sub
    Private Sub Tennis_MGrass_P1_Click(sender As Object, e As EventArgs) Handles Tennis_MGrass_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(630, 700)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MGrass_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_MGrass_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 640)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 640)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MGrass_P2_Click(sender As Object, e As EventArgs) Handles Tennis_MGrass_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(630, 700)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MHard_P1_Click(sender As Object, e As EventArgs) Handles Tennis_MHard_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(650, 720)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(570, 620)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MHard_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_MHard_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(600, 660)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(600, 660)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MHard_P2_Click(sender As Object, e As EventArgs) Handles Tennis_MHard_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(570, 620)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(650, 720)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MClay_P1_Click(sender As Object, e As EventArgs) Handles Tennis_MClay_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 630)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MClay_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_MClay_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_MClay_P2_Click(sender As Object, e As EventArgs) Handles Tennis_MClay_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 630)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WGrass_P1_Click(sender As Object, e As EventArgs) Handles Tennis_WGrass_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(480, 530)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WGrass_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_WGrass_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(530, 580)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(530, 580)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WGrass_P2_Click(sender As Object, e As EventArgs) Handles Tennis_WGrass_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(480, 530)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WHard_P1_Click(sender As Object, e As EventArgs) Handles Tennis_WHard_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 630)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WHard_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_WHard_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WHard_P2_Click(sender As Object, e As EventArgs) Handles Tennis_WHard_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 630)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WClay_P1_Click(sender As Object, e As EventArgs) Handles Tennis_WClay_P1.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(530, 580)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(450, 500)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WClay_Avg_Click(sender As Object, e As EventArgs) Handles Tennis_WClay_Avg.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Tennis_WClay_P2_Click(sender As Object, e As EventArgs) Handles Tennis_WClay_P2.Click
        Dim Tennis_Lines As Tennis_Lines_Window
        Tennis_Lines = New Tennis_Lines_Window()

        Tennis_Lines.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(450, 500)
        Tennis_Lines.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(530, 580)

        Tennis_Lines.ShowDialog()

    End Sub

    Private Sub Basketball_SmHmFav_LoTot_Click(sender As Object, e As EventArgs) Handles Basketball_SmHmFav_LoTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(0, 20)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basketball_SmAwFav_LoTot_Click(sender As Object, e As EventArgs) Handles Basketball_SmAwFav_LoTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-20, 0)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basketball_LrgHmFav_LoTot_Click(sender As Object, e As EventArgs) Handles Basketball_LrgHmFav_LoTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(30, 80)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basketball_LrgAwFav_LoTot_Click(sender As Object, e As EventArgs) Handles Basketball_LrgAwFav_LoTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-80, -30)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basketball_SmHmFav_HiTot_Click(sender As Object, e As EventArgs) Handles Basketball_SmHmFav_HiTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(0, 20)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basketball_SmAwFav_HiTot_Click(sender As Object, e As EventArgs) Handles Basketball_SmAwFav_HiTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-20, 0)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basketball_LrgHmFav_HiTot_Click(sender As Object, e As EventArgs) Handles Basketball_LrgHmFav_HiTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(30, 100)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub Basetball_LrgAwFav_HiTot_Click(sender As Object, e As EventArgs) Handles Basetball_LrgAwFav_HiTot.Click
        Dim Basketball_Lines As Basketball_Lines_Window
        Basketball_Lines = New Basketball_Lines_Window()

        Basketball_Lines.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-100, -30)
        Basketball_Lines.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430)

        Basketball_Lines.ShowDialog()
    End Sub

    Private Sub SportSelectBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SportSelectBox.SelectedIndexChanged

        If (SportSelectBox.SelectedItem = "Soccer") Then
            Soccer_Panel.BringToFront()
            Soccer_Panel.Visible = True
        ElseIf (SportSelectBox.SelectedItem = "Tennis") Then
            Tennis_Panel.BringToFront()
            Tennis_Panel.Visible = True
        ElseIf (SportSelectBox.SelectedItem = "Basketball") Then
            Basketball_Panel.BringToFront()
            Basketball_Panel.Visible = True
        End If

    End Sub
End Class