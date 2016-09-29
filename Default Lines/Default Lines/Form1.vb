Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblSportSelect.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Soccer_Standard.MouseClick
        Dim SoccerLines As New Form()
        SoccerLines.Show()
    End Sub
End Class
