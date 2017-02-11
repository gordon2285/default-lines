Public Class MainPage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblSportSelect.Click, Soccer_HFav_NTot.Click, Soccer_HFav_HTot.Click, Soccer_AFav_NTot.Click, Soccer_AFav_HTot.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Soccer_Standard.MouseClick, Soccer_HFav_NTot.MouseClick, Soccer_HFav_HTot.MouseClick, Soccer_AFav_NTot.MouseClick, Soccer_AFav_HTot.MouseClick
        Dim SoccerLines As soccer_lines
        SoccerLines = New soccer_lines()
        SoccerLines.Show()
    End Sub
End Class