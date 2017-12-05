Public Class Menu

    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim Box = New Form1()
        Box.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim Box = New RockPaperScissors()
        Box.ShowDialog()
    End Sub
End Class